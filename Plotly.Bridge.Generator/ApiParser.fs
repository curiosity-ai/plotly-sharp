namespace Fable.Plotly.Generator

open FSharp.Data
open FSharp.Data.JsonExtensions
open Domain

module ParserUtils =
    open Fake.IO
    open Fake.IO.FileSystemOperators

    /// The Plotly.js schema
    let schema =
        Http.RequestString(@"https://raw.githubusercontent.com/plotly/plotly.js/master/dist/plot-schema.json")
        |> JsonValue.Parse

    /// Returns `true` if the `JsonValue` is a component
    let private isComp (jVal: JsonValue) =
        jVal
        |> JsonValue.tryGetProp "role"
        |> Option.map (JsonValue.asString >> ((=) "object"))
        |> function
        | Some b -> b
        | None -> false

    /// Gets the description from the specified `JsonValue` when it is a component
    let private getCompDoc (jVal: JsonValue) =
        jVal.TryGetProperty("meta")
        |> Option.bind (JsonValue.tryGetProp "description")
        |> Option.map JsonValue.asString
        |> Option.toList

    /// Gets the description from the specified `JsonValue` when it is a prop
    let private getPropDoc (jVal: JsonValue) =
        jVal.TryGetProperty("description")
        |> Option.map JsonValue.asString
        |> Option.toList

    /// Gets the documentation of a specified `JsonValue`
    let getDocs (jVal: JsonValue) =
        if isComp jVal then getCompDoc jVal
        else getPropDoc jVal
        |> List.map (fun s -> s.Trim().Trim('"'))
        |> List.filter (fun s -> s <> "")

    let trimBypass (s: string) =
        if s.EndsWith("_BYPASS") then s.Substring(0, s.Length - 7)
        else s

    let trimBypassWith (s: string) trueFun falseFun =
        if s.EndsWith("_BYPASS") then s.Substring(0, s.Length - 7) |> trueFun
        else falseFun s

    let skips =
        schema?defs?metaKeys.AsArray()
        |> Array.toList
        |> List.map (JsonValue.asString >> trimJson)

    let traceChildrenWithJson =
        schema?traces.Properties

    let traceChildren =
        traceChildrenWithJson
        |> Array.map fst
        |> List.ofArray

    let transformsChildren =
        schema?transforms.Properties
        |> Array.map fst
        |> List.ofArray

    let hasEnums (jVal: JsonValue) =
        jVal.TryGetProperty("valType")
        |> Option.map (JsonExtensions.AsString >> ((=) "enumerated"))
        |> Option.defaultValue false
            
    /// Gets anchor static mapping attributes
    let layoutAnchorMappings (compName: string) (propName: string) =
        [ "polar"; "geo"; "mapbox"; "ternary" ] 
        |> List.tryFind compName.Contains
        |> function
        | _ when propName = "xaxes" || propName = "yaxes" -> {| Value = propName; Array = true |}
        | _ when propName.StartsWith "x" || propName.StartsWith "y" -> {| Value = propName.Substring(0,1); Array = false |}
        | _ when List.contains propName [ "coloraxis"; "scene" ] -> {| Value = propName; Array = false |}
        | _ when compName = "Choropleth" && propName = "geo" -> {| Value = propName; Array = false |}
        | Some aName -> {| Value = aName; Array = false |}
        | _ -> failwith "Invalid anchor mapping call."

module rec ApiParser =
    open ParserUtils

    let manualDeprecated = 
        [ ("layout", [ "radialaxis"; "angularaxis" ]) ]

    let isManualDeprecated componentName (name: string) =
        match List.filter (fst >> fun n -> n = componentName) manualDeprecated with
        | fList when fList.Length > 0 -> 
            fList 
            |> List.exists (snd >> List.exists (fun n -> n = name)) 
        | _ -> false

    /// Filter all JsonValue properties if deprecated
    let parseWithfilterDeprecated componentName parentTree (props: (string * JsonValue) []) =
        props
        |> Array.choose (fun (pName, pJ) ->
            if pJ.TryGetProperty("description")
               |> Option.map (fun j -> j.AsString().Contains("deprecated!"))
               |> Option.defaultValue false || pName = "_deprecated" 
               || isManualDeprecated componentName pName
            then None
            else parseProp parentTree pName pJ |> Some)

    /// Parses a `JsonValue` with given information and returns a `Prop`
    let parseProp componentTree propName (jVal: JsonValue) =
        let jumpArray = [ "annotations"; "dimensions"; "styles"; "transforms" ]
        let typeAdders = [ "Traces"; "Transforms" ]
        let typeAdderChildren = traceChildren @ transformsChildren

        let isSkip =
            [ "meta"; "categories"; "animatable"; "type"; "layoutAttributes"; "requiredOpts"; "otherOpts"; "valType"; "transform" ]
            |> List.contains propName

        let isExpanded =
            let isExpandedLayout = 
                [ "xaxis"; "yaxis"; "geo"; "ternary"; "polar"; "mapbox"; "coloraxis"; "scene" ]
                |> List.contains propName 

            match (componentTree
                   |> List.rev
                   |> List.head), propName with
            | "Layout", _ when isExpandedLayout -> true
            | _ -> false

        let propMethodName =
            propName
            |> trimJson
            |> spaceCaseTokebabCase
            |> kebabCaseToCamelCase
            |> snakeCaseToCamelCase
            |> replaceAddSymbol
            |> appendApostropheToReservedKeywords

        let componentParent = componentTree |> List.rev |> List.head

        let mNameUpper = propMethodName |> String.upperFirst

        let axisInt axisIdentity isArray =
            if isArray then
                [ ValType.intSeqStrCustom "anchorIds"
                    (sprintf "anchorIds.Select(anchorId => anchorId > 1 ? $\"%s{anchorId}\" : \"\").ToArray()" axisIdentity)
                  ValType.intStrCustom "anchorId"
                    (sprintf "anchorId > 1 ? $\"%s{anchorId}\" : \"\"" axisIdentity) ]
            else
                ValType.intStrCustom "anchorId"
                    (sprintf "anchorId > 1 ? $\"%s{anchorId}\" : \"\"" axisIdentity)
                |> List.singleton

        let propType =
            let isPropAxis = 
                [ "xaxis"; "yaxis"; "subplot"; "geo"; "coloraxis"; "scene" ]
                |> List.contains propName

            match componentParent, propName with
            | "Line", "color"
            | "Line", "width" -> { PrimSpecOverrides.empty with ArrayOk = true, true }
            | "Style", "value" ->
                { PrimSpecOverrides.empty with
                      Explicit =
                          schema?traces
                          |> JsonExtensions.Properties
                          |> Array.map
                              (fst
                               >> String.upperFirst
                               >> ValType.compStrExplicit)
                          |> List.ofArray }
            | _, "theta" -> { PrimSpecOverrides.empty with IsCalcType = true, false }
            | _ when componentParent <> "Layout" && isPropAxis ->
                { PrimSpecOverrides.empty with
                      Explicit =
                          layoutAnchorMappings componentParent propName
                          |> fun res -> axisInt res.Value res.Array }
            | _ when isExpanded ->
                { PrimSpecOverrides.empty with
                      Explicit =
                          let pNameUpper = propName |> String.upperFirst
                          [ pNameUpper |> ValType.compStrExplicitExpanded ] }
            | _ -> PrimSpecOverrides.empty
            |> fun overs -> ValType.getType propName overs jVal

        let propOverloads =
            if isSkip then
                []
            else
                let explicitOverloadStrings =
                    ValType.getExplicitOverloadStrings propType
                    |> fun expOverStrs ->
                        if isExpanded then
                            expOverStrs
                            |> List.map (fun (paramsCode, valueCode) ->
                                let bodyCode =
                                    sprintf "Interop.mk%sAttr(%s,%s);" componentParent
                                        (sprintf "$\"%s{id}\"" propMethodName) valueCode
                                RegularPropOverload.createCustom paramsCode bodyCode)
                        else
                            expOverStrs
                            |> List.map (fun (paramsCode, valueCode) -> RegularPropOverload.create paramsCode valueCode)

                ValType.getOverloadStrings componentParent mNameUpper propType
                |> List.map (fun (paramsCode, valueCode) ->
                    if List.contains propMethodName typeAdderChildren
                       && List.contains (componentTree |> List.head) typeAdders then
                        (paramsCode,
                         sprintf "Bindings.flattenProperties(properties.Concat(new []{ Interop.mk%sAttr(\"type\", \"%s\") }))"
                             (propMethodName |> String.upperFirst) propMethodName) ||> RegularPropOverload.create
                    elif List.contains propMethodName jumpArray then
                        (paramsCode, "Bindings.flattenPropertiesToArray(properties)")
                        ||> RegularPropOverload.create
                    else RegularPropOverload.create paramsCode valueCode)
                |> List.append explicitOverloadStrings

        let enumOverloads =
            let isAnchorOrOverlay =
                (componentParent = "Xaxis" || componentParent = "Yaxis") 
                    && (propName = "overlaying" || propName = "anchor" || propName = "scaleanchor")

            let isXAxisRef = [ "xref"; "axref" ] |> List.contains propName
            let isYAxisRef = [ "yref"; "ayref" ] |> List.contains propName

            match propType with
            | ValType.Enumerated
            | ValType.EnumeratedArray ->
                jVal?values.AsArray()
                |> Array.map JsonValue.asString
                |> List.ofArray
            | ValType.EnumeratedWithCustom ->
                jVal?values.AsArray()
                |> Array.collect (fun j ->
                    match j |> JsonValue.asString with
                    | s when String.containsRegex s && isAnchorOrOverlay -> [| "x"; "y" |]
                    | s when String.containsRegex s && isXAxisRef -> [| "x" |]
                    | s when String.containsRegex s && isYAxisRef -> [| "y" |]
                    | s when String.containsRegex s -> [||]
                    | s -> s |> Array.singleton)
                |> Array.append [| "custom" |]
                |> List.ofArray
            | ValType.FlagList ->
                let flagCombinations =
                    jVal?flags.AsArray()
                    |> List.ofArray
                    |> List.map (JsonValue.asString >> trimJson)

                let extras =
                    match jVal.TryGetProperty("extras") with
                    | Some extras ->
                        extras.AsArray()
                        |> List.ofArray
                        |> List.map (JsonValue.asString)
                    | None -> []

                extras @ flagCombinations
            | _ -> []
            |> List.sort
            |> List.collect (fun v ->
                let methodName =
                    v
                    |> emptStringToNone
                    |> trimJson
                    |> replaceAddSymbol
                    |> fixMethodNameOperators propMethodName
                    |> dashStringToDash
                    |> spaceCaseTokebabCase
                    |> kebabCaseToCamelCase
                    |> snakeCaseToCamelCase
                    |> prefixUnderscoreOrNegativeToNumbers
                    |> appendApostropheToReservedKeywords

                match propType with
                | ValType.EnumeratedWithCustom when (isAnchorOrOverlay || isXAxisRef || isYAxisRef ) && (v = "x" || v = "y") ->
                    axisInt v false 
                    |> List.unzip
                    ||> List.map2 (fun paramsCode valueCode ->
                        EnumPropOverload.create methodName valueCode
                        |> EnumPropOverload.setParamsCode paramsCode)
                | ValType.EnumeratedWithCustom when v = "custom" && componentParent = "Line" && propName = "dash" ->
                    let valueCode, paramsCode = [ ValType.intSeqResizeStr; ValType.floatSeqResizeStr ] |> List.unzip

                    paramsCode
                    |> List.map2
                        (fun pCode vCode ->
                        EnumPropOverload.create methodName vCode |> EnumPropOverload.setParamsCode pCode) valueCode

                | ValType.EnumeratedWithCustom when v = "custom" ->
                    let paramsCode, valueCode = ValType.stringStr

                    EnumPropOverload.create methodName valueCode
                    |> EnumPropOverload.setParamsCode paramsCode
                    |> List.singleton
                | _ ->
                    match v with
                    | "true"
                    | "false" -> sprintf "%s" (trimJson v)
                    | _ -> sprintf "\"%s\"" (trimJson v)
                    |> EnumPropOverload.create methodName
                    |> List.singleton)
            |> List.distinct

        let addRegularOverloads prop = (prop, propOverloads) ||> Seq.fold (flip Prop.addRegularOverload)

        let addEnumOverloads prop = (prop, enumOverloads) ||> Seq.fold (flip Prop.addEnumOverload)

        Prop.create propType propName propMethodName
        |> Prop.setDocs (getDocs jVal)
        |> Prop.addParentComponentTree
            (if propType |> ValType.isPrimative then componentTree
             else (componentTree @ [ propName ]))
        |> addRegularOverloads
        |> addEnumOverloads

    /// Parses a `JsonValue` with given information and returns a `Component`
    let parseComponent (parentTree: string list) (componentName: string) (jVal: JsonValue) =
        let jumpComp = [ "attributes"; "items"; "traces" ]
        let jumpCompIf = [ ("Layout", "layoutAttributes") ]
        let parentTree = parentTree |> List.map trimBypass

        let rec performJumps (name: string) (j: JsonValue) =
            if List.contains name jumpComp then j.Properties |> Array.collect (fun (name, j) -> performJumps name j)
            else (name, j) |> Array.singleton

        let filterAttributes (props: (string * JsonValue) []) =
            let isJumpCompIf name =
                List.contains name (jumpCompIf |> List.map snd)
                && List.contains parentTree.Head (jumpCompIf |> List.map fst)

            props
            |> Array.collect
                (Array.singleton
                 >> (fun prop ->
                 match prop |> Array.head with
                 | attribs when attribs
                                |> fst
                                |> isJumpCompIf ->
                     attribs
                     |> snd
                     |> fun j -> j.Properties
                 | (name, j) when List.contains name jumpComp -> performJumps name j
                 | _ -> prop)
                 >> (fun prop ->
                 prop
                 |> Array.filter
                     (fun p ->
                     Array.contains (fst p)
                         ((skips |> List.filter (fun skip -> List.contains skip (jumpCompIf |> List.map snd) |> not))
                          |> Array.ofList) |> not)))

        let props =
            jVal.Properties
            |> filterAttributes
            |> parseWithfilterDeprecated componentName parentTree
            |> Array.distinctBy (fun p -> p.MethodName)

        let addProps comp = (comp, props) ||> Array.fold (flip Component.addProp)

        Component.create componentName
        |> Component.setDocs (getDocs jVal)
        |> Component.addParentComponentTree parentTree
        |> addProps

    /// Parses the root schema for enumerated values with the given component name and enum name returning a JsonValue of the collected values.
    let getAllEnumAttributes (property: string) (enumName: string) =
        let rec getEnumValues attribList parent (jVal: JsonValue) =
            jVal.Properties
            |> Array.partition (fun (name, j) -> name = enumName && j |> hasEnums && parent = property)
            ||> fun matches others ->
                let addedAttribList =
                    matches
                    |> Array.collect (fun (_, attrib) -> [| parent, attrib |])
                    |> Array.append attribList
                Array.append addedAttribList (Array.collect (fun (pName, j) -> getEnumValues [||] pName j) others)

        getEnumValues [||] property schema
        |> (Array.collect (snd >> JsonExtensions.Properties)
            >> Array.collect (fun (name, jVal) ->
                if name = "values" then jVal.AsArray()
                else [||]))
        |> Array.distinct
        |> JsonValue.Array

    /// Parses given JsonValue for components with the given name returning a JsonValue of a collected set of properties.
    let getAttributesOf (source: JsonValue) (property: string) =
        let rec getAttributes attribList parent (jVal: JsonValue) =
            jVal.Properties
            |> Array.partition (fun (name, j) -> name = property && j.TryGetProperty("valType").IsNone)
            ||> fun matches others ->
                let addedAttribList =
                    matches
                    |> Array.collect (fun (_, attrib) -> [| parent, attrib |])
                    |> Array.append attribList
                Array.append addedAttribList (Array.collect (fun (pName, j) -> getAttributes [||] pName j) others)

        getAttributes [||] property source
        |> Array.collect (snd >> JsonExtensions.Properties)
        |> Array.distinct
        |> Array.map (fun (name, jVal) ->
            if jVal |> hasEnums then
                let fullEnums = getAllEnumAttributes property name
                jVal.Properties
                |> Array.map (fun (n, j) ->
                    if n = "values" then (n, fullEnums)
                    else (n, j))
                |> JsonValue.Record
                |> fun newJ -> (name, newJ)
            else
                (name, jVal))
        |> JsonValue.Record

    /// Parses the root schema for components with the given name returning a JsonValue of a collected set of properties.
    let getAllAttributes (property: string) = getAttributesOf schema property

    /// Gets a list of all components within the schema with their collected properties
    let getAllComponents() =
        let fixComponentName =
            trimJson
            >> spaceCaseTokebabCase
            >> kebabCaseToCamelCase
            >> snakeCaseToCamelCase
            >> replaceAddSymbol
            >> appendApostropheToReservedKeywords

        let jumps = [ "attributes"; "items"; "layoutAttributes" ]
        let subLayouts = [ "ternary"; "geo"; "mapbox"; "polar" ]

        let rec allComponentNames (jVal: JsonValue): string list =
            let props =
                match jumps |> List.choose (jVal.TryGetProperty) with
                | j when j.Length > 0 -> (j |> List.head).Properties
                | _ -> jVal.Properties
                |> List.ofArray
                |> List.filter (fun (name, j) -> 
                    List.contains name skips |> not
                        && j.TryGetProperty("valType").IsNone)

            let newNames =
                props
                |> List.map fst
                |> List.distinct

            props
            |> List.collect (fun (name, j) ->
                if j.TryGetProperty("valType").IsNone then allComponentNames j
                else [ name ])
            |> List.append newNames
            |> List.distinct

        let result =
            let schemaSkips = [ "defs" ]
            let compSkips = [ "type"; "transform" ]

            schema.Properties
            |> Array.filter (fun (name, _) -> List.contains name schemaSkips |> not)
            |> JsonValue.Record
            |> allComponentNames
            |> List.filter (fun name -> List.contains name compSkips |> not)
            |> List.distinct

        result
        |> List.map
            (((fun n ->
             n |> fixComponentName,
             getAllAttributes n
             |> fun res ->
                 match n, List.filter ((=) n) subLayouts with
                 | "layout", _ ->
                     res.Properties
                     |> Array.append (getAllAttributes "layoutAttributes" |> JsonExtensions.Properties)
                     |> JsonValue.Record
                 | _, subL when subL.Length > 0 ->
                     traceChildrenWithJson
                     |> Array.choose (fun (traceName, traceJson) ->
                         if traceName.Contains(n) then
                             getAttributesOf traceJson "layoutAttributes"
                             |> JsonExtensions.Properties
                             |> Some
                         else None)
                     |> Array.concat
                     |> Array.distinct
                     |> Array.append res.Properties
                     |> JsonValue.Record
                 | _ -> res))
             >> (fun (n, j) ->
                match List.filter (fun (name, _) -> name = n) manualDeprecated |> List.collect snd with
                | res when res.Length > 0 ->
                    n,
                    j.Properties |> Array.filter (fun (pName, _) -> List.contains pName res |> not)
                    |> JsonValue.Record
                | _ -> (n,j))
             >> (fun (n, j) -> parseComponent [ n |> String.upperFirst ] n j))

    /// Parse the Plotly.js json schema
    let parseApi() =
        let components = getAllComponents()

        let addAllComponents api = (api, components) ||> List.fold (flip ComponentApi.addComponent)

        let bindings =
            [ "Create a Plotly plot component.",
              "public static IPlot plot (params Box<IPlotProperty>[] props) => Bindings.createPlot(props);" ]

        let typePostlude =
            [ "Create the plotly traces",
              "public static Box<IPlotProperty> traces (params Box<ITracesProperty>[] properties) => Bindings.extractTraces(properties);"
              "Create the plotly config",
              "public static Box<IPlotProperty> config (params Box<IConfigProperty>[] properties) => Bindings.extractConfig(properties);"
              "Create the plotly layout",
              "public static Box<IPlotProperty> layout (params Box<ILayoutProperty>[] properties) => Bindings.extractLayout(properties);"
              "When provided, causes the plot to update when the revision is incremented.",
              "public static Box<IPlotProperty> revision (int val) => Interop.mkPlotAttr(\"revision\", val);"
              "When provided, causes the plot to update when the revision is incremented.",
              "public static Box<IPlotProperty> revision (float val) => Interop.mkPlotAttr(\"revision\", val);"
              "Callback executed after plot is initialized.",
              "public static Box<IPlotProperty> onInitialized (Action handler, HTMLElement unit) => Interop.mkPlotAttr(\"onInitialized\", handler);"
              "Callback executed when when a plot is updated due to new data or layout, or when user interacts with a plot.",
              "public static Box<IPlotProperty> onUpdate (Action<HTMLElement> handler) => Interop.mkPlotAttr(\"onUpdate\", handler);"
              "Callback executed when component unmounts, before Plotly.purge strips the graphDiv of all private attributes.",
              "public static Box<IPlotProperty> onPurge (Action<HTMLElement> handler) => Interop.mkPlotAttr(\"onPurge\", handler);"
              "Callback executed when a plotly.js API method rejects",
              "public static Box<IPlotProperty> onError (Action<Event> handler) => Interop.mkPlotAttr(\"onError\", handler);"
              "Id assigned to the <div> into which the plot is rendered.",
              "public static Box<IPlotProperty> divId (string val) => Interop.mkPlotAttr(\"divId\",val);"
              "Class applied to the <div> into which the plot is rendered",
              "public static Box<IPlotProperty> className (string val) => Interop.mkPlotAttr(\"className\",val);"
              "Styles the <div> into which the plot is rendered - TODO, check if this should be a different interface than IStyleProperty",
              "public static Box<IStyleProperty> style (List<IStyleProperty> properties) => Interop.mkStyleAttr(\"style\", properties);"
              "Assign the graph div to window.gd for debugging",
              "public static Box<IPlotProperty> debug (bool val) => Interop.mkPlotAttr(\"debug\",val);"
              "When true, adds a call to Plotly.Plot.resize() as a window.resize event handler",
              "public static Box<IPlotProperty> useResizeHandler (bool val) => Interop.mkPlotAttr(\"useResizeHandler\", val);"
              "", 
              "public static Box<IPlotProperty> onAfterExport (Action handler) => Interop.mkPlotAttr(\"onClick\", handler);"
              "",
              "public static Box<IPlotProperty> onAfterPlot (Action handler) => Interop.mkPlotAttr(\"onAfterPlot\", handler);"
              "",
              "public static Box<IPlotProperty> onAnimated (Action handler) => Interop.mkPlotAttr(\"onAnimated\", handler);"
              "",
              "public static Box<IPlotProperty> onAnimatingFrame (Action<Literals.FrameAnimationEvent> handler) => Interop.mkPlotAttr(\"onAnimatingFrame\", handler);"
              "",
              "public static Box<IPlotProperty> onAnimationInterrupted (Action handler) => Interop.mkPlotAttr(\"onAnimationInterrupted\", handler);"
              "", 
              "public static Box<IPlotProperty> onAutoSize (Action handler) => Interop.mkPlotAttr(\"onAutoSize\", handler);"
              "",
              "public static Box<IPlotProperty> onBeforeExport (Action handler) => Interop.mkPlotAttr(\"onBeforeExport\", handler);"
              "",
              "public static Box<IPlotProperty> onButtonClicked (Action<Literals.ButtonClickEvent> handler ) => Interop.mkPlotAttr(\"onButtonClicked\", handler);"
              "",
              "public static Box<IPlotProperty> onClick (Action<Literals.PlotMouseEvent> handler ) => Interop.mkPlotAttr(\"onClick\", handler);"
              "",
              "public static Box<IPlotProperty> onClickAnnotation (Action<Literals.ClickAnnotationEvent> handler ) => Interop.mkPlotAttr(\"onClickAnnotation\", handler);"
              "",
              "public static Box<IPlotProperty> onDeselect (Action handler) => Interop.mkPlotAttr(\"onDeselect\", handler);"
              "",
              "public static Box<IPlotProperty> onDoubleClick (Action handler) => Interop.mkPlotAttr(\"onDoubleClick\", handler);"
              "",
              "public static Box<IPlotProperty> onFramework (Action handler) => Interop.mkPlotAttr(\"onFramework\", handler);"
              "",
              "public static Box<IPlotProperty> onHover (Action<Literals.PlotMouseEvent> handler ) => Interop.mkPlotAttr(\"onHover\", handler);"
              "",
              "public static Box<IPlotProperty> onLegendClick (Action<Literals.LegendClickEvent> handler ) => Interop.mkPlotAttr(\"onLegendClick\", handler);"
              "",
              "public static Box<IPlotProperty> onLegendDoubleClick (Action<Literals.LegendClickEvent> handler ) => Interop.mkPlotAttr(\"onLegendDoubleClick\", handler);"
              "",
              "public static Box<IPlotProperty> onRelayout (Action<Literals.PlotRelayoutEvent> handler ) => Interop.mkPlotAttr(\"onRelayout\", handler);"
              "",
              "public static Box<IPlotProperty> onRestyle (Action<Literals.PlotRestyleEvent> handler ) => Interop.mkPlotAttr(\"onRestyle\", handler);"
              "", 
              "public static Box<IPlotProperty> onRedraw (Action handler) => Interop.mkPlotAttr(\"onRedraw\", handler);"
              "",
              "public static Box<IPlotProperty> onSelected (Action<Literals.PlotSelectionEvent> handler ) => Interop.mkPlotAttr(\"onSelected\", handler);"
              "",
              "public static Box<IPlotProperty> onSelecting (Action<Literals.PlotSelectionEvent> handler ) => Interop.mkPlotAttr(\"onSelecting\", handler);"
              "",
              "public static Box<IPlotProperty> onSliderChange (Action<Literals.SliderChangeEvent> handler) => Interop.mkPlotAttr(\"onSliderChange\", handler);"
              "",
              "public static Box<IPlotProperty> onSliderEnd (Action<Literals.SliderEndEvent> handler) => Interop.mkPlotAttr(\"onSliderEnd\", handler);"
              "",
              "public static Box<IPlotProperty> onSliderStart (Action<Literals.SliderStartEvent> handler) => Interop.mkPlotAttr(\"onSliderStart\", handler);"
              "",
              "public static Box<IPlotProperty> onTransitioning (Action handler) => Interop.mkPlotAttr(\"onTransitioning\", handler);"
              "",
              "public static Box<IPlotProperty> onTransitionInterrupted (Action handler) => Interop.mkPlotAttr(\"onTransitionInterrupted\", handler);"
              "",
              "public static Box<IPlotProperty> onUnhover (Action<Literals.PlotMouseEvent> handler) => Interop.mkPlotAttr(\"onUnhover\", handler);" ]

        let api = ComponentApi.create "PlotlyBridge" "Plot" "Plotly" bindings typePostlude |> addAllComponents

        { GeneratorComponentApi = api
          PlotlyComponents = components }
