namespace Fable.Plotly.Generator

module rec Domain =
    open FSharp.Data
    open FSharp.Data.JsonExtensions

    type PrimSpecs =
        { ArrayOk: bool
          Explicit: (string * string) list
          Identity: ValType option
          IsCalcType: bool
          NullOk: bool
          NumArrayOk: bool
          TwoDimArrayOk: bool }

    type PrimSpecOverrides =
        { ArrayOk: bool * bool
          Explicit: (string * string) list
          Identity: ValType option
          IsCalcType: bool * bool
          NullOk: bool * bool
          NumArrayOk: bool * bool
          TwoDimArrayOk: bool * bool }

    module PrimSpecs =
        let create (jVal: JsonValue): PrimSpecs =
            let isArrayOk =
                match jVal.TryGetProperty("arrayOk") with
                | Some arrOk -> arrOk.AsBoolean()
                | None -> false

            { ArrayOk = isArrayOk
              Explicit = []
              Identity = None
              IsCalcType =
                  let editType =
                      jVal.TryGetProperty("editType")
                      |> Option.map (JsonExtensions.AsString >> ((=) "calc"))
                      |> Option.defaultValue false

                  let role =
                      jVal.TryGetProperty("role")
                      |> Option.map (JsonExtensions.AsString >> ((=) "data"))
                      |> Option.defaultValue false

                  editType && role
              NullOk =
                  match jVal.TryGetProperty("role") with
                  | Some role when role
                                   |> JsonExtensions.AsString = "data" -> true
                  | _ -> false
              NumArrayOk =
                  match jVal.TryGetProperty("description") with
                  | Some desc when desc.AsString().Contains("array of numbers") -> true
                  | _ -> false
              TwoDimArrayOk =
                  if isArrayOk then
                      jVal.TryGetProperty("description")
                      |> Option.map (JsonExtensions.AsString >> (fun s -> s.Contains "2D array"))
                      |> Option.defaultValue false
                  else
                      false }

        let allFalse: PrimSpecs =
            { ArrayOk = false
              Explicit = []
              Identity = None
              IsCalcType = false
              NullOk = false
              NumArrayOk = false
              TwoDimArrayOk = false }

        let applyOverride (overrides: PrimSpecOverrides) (baseSpecs: PrimSpecs) =
            { baseSpecs with
                  ArrayOk =
                      match overrides.ArrayOk with
                      | true, b -> b
                      | false, _ -> baseSpecs.ArrayOk
                  Explicit = overrides.Explicit
                  IsCalcType =
                      match overrides.IsCalcType with
                      | true, b -> b
                      | false, _ -> baseSpecs.IsCalcType
                  NullOk =
                      match overrides.NullOk with
                      | true, b -> b
                      | false, _ -> baseSpecs.NullOk
                  NumArrayOk =
                      match overrides.NumArrayOk with
                      | true, b -> b
                      | false, _ -> baseSpecs.NumArrayOk
                  TwoDimArrayOk =
                      match overrides.TwoDimArrayOk with
                      | true, b -> b
                      | false, _ -> baseSpecs.TwoDimArrayOk }

    module PrimSpecOverrides =
        let empty: PrimSpecOverrides =
            { ArrayOk = false, false
              Explicit = []
              Identity = None
              IsCalcType = false, false
              NullOk = false, false
              NumArrayOk = false, false
              TwoDimArrayOk = false, false }

    [<RequireQualifiedAccess>]
    type ValType =
        | Any
        | Bool of PrimSpecs
        | Color of PrimSpecs
        | ColorArray
        | ColorScale
        | DataArray of PrimSpecs
        | Enumerated
        | EnumeratedArray
        | EnumeratedWithCustom
        | ExplicitOverride of PrimSpecs
        | FlagList
        | FloatArray
        | InfoArray of ValType
        | Int of PrimSpecs
        | List of ValType
        | Number of PrimSpecs
        | String of PrimSpecs
        | Component

    module ValType =
        let boolStr = "bool val", "val"
        let boolResizeSingleton = "bool val", "new []{ val }"
        let boolSeqResizeStr = "IEnumerable<bool> values", "values.ToArray()"
        let boolSeqResizeStrOpt = "IEnumerable<bool?> values", "values.ToArray()"
        let boolSeqStr = "params bool[] values", "values"
        let boolSeqStrOpt = "params bool?[] values", "values"
        let boolSingleton = "bool val", "new []{ val }"
        let bool2DSeqStr = "IEnumerable<bool[]> values", "Bindings.flatten2DArrayIf1D(values)"
        let bool2DSeqStrOpt = "IEnumerable<bool?[]> values", "Bindings.flatten2DArrayIf1D(values)"
        let bool2DListStr = "List<bool[]> values", "Bindings.flatten2DArrayIf1D(values)"
        let bool2DListStrOpt = "List<bool?[]> values", "Bindings.flatten2DArrayIf1D(values)"
        let bool2DArrayStr = "params bool[][] values", "Bindings.flatten2DArrayIf1D(values)"
        let bool2DArrayStrOpt = "params bool?[][] values", "Bindings.flatten2DArrayIf1D(values)"

        let compStr s = sprintf "params Box<I%sProperty>[] properties" s, "Bindings.flattenProperties(properties)"
        let compStrExplicit s = sprintf "params Box<I%sProperty>[] properties" s,  "Bindings.flattenProperties(properties)"
        let compStrExplicitExpanded s = sprintf "int id, params Box<I%sProperty>[] properties" s, "Bindings.flattenProperties(properties)"

        let data2D = "Literals.PlotData[] values", "values"

        let dateStr = "System.DateTime val", "val"
        let dateResizeSingleton = "System.DateTime val", "new []{ val }"
        let dateSeqResizeStr = "IEnumerable<System.DateTime> values", "values.ToArray()"
        let dateSeqResizeStrOpt = "IEnumerable<System.DateTime?> values", "values.ToArray()"
        let dateSeqStr = "params System.DateTime[] values", "values"
        let dateSeqStrOpt = "params System.DateTime?[] values", "values"
        let dateSingleton = "System.DateTime val", "new []{ val }"

        let enumeratedArrayStrSeq s =
            sprintf "IEnumerable<Box<I%sProperty>> properties" s,
            "Bindings.flattenProperties(properties)"

        let flaglistStrSeq s =
            sprintf "params Box<I%sProperty>[] properties" s,
            "Script.Write<object>(\"{0}.join('+')\", properties)"

        let floatStr = "float val", "val"
        let floatResizeSingleton = "float val", "new []{ val }"
        let floatSeqResizeStr = "IEnumerable<float> values", "values.ToArray()"
        let floatSeqResizeStrOpt = "IEnumerable<float?> values", "values.ToArray()"
        let floatSeqStr = "params float[] values", "values"
        let floatSeqStrOpt = "params float?[] values", "values"
        let floatSingleton = "float val", "new []{ val }"
        let float32FromFloatSeqStr = "float[] values", "values"
        let float32FromFloatSeqStrOpt =
            "float?[] values", "values"
        let float32FromIntSeqStr = "params int[] values", "values"
        let float32FromIntSeqStrOpt = "params int?[] values", "values"
        let float2DSeqStr = "IEnumerable<IEnumerable<float>> values", "Bindings.flatten2DArrayIf1D(values)"
        let float2DSeqStrOpt = "IEnumerable<IEnumerable<float?>> values", "Bindings.flatten2DArrayIf1D(values)"
        let float2DListStr = "List<float[]> values", "Bindings.flatten2DArrayIf1D(values)"
        let float2DListStrOpt = "List<float?[]> values", "Bindings.flatten2DArrayIf1D(values)"
        let float2DArrayStr = "params float[][] values", "Bindings.flatten2DArrayIf1D(values)"
        let float2DArrayStrOpt = "params float?[][] values", "Bindings.flatten2DArrayIf1D(values)"

        let intStr = "int val", "val"
        let intStrCustom s f = sprintf "int %s" s, sprintf "%s" f
        let intSeqStrCustom s f = sprintf "int[] %s" s, sprintf "%s" f
        let intResizeSingleton = "int val", "new []{ val }"
        let intSeqResizeStr = "IEnumerable<int> values", "values.ToArray()"
        let intSeqResizeStrOpt = "IEnumerable<int?> values", "values.ToArray()"
        let intSeqStr = "params int[] values", "values"
        let intSeqStrOpt = "params int?[] values", "values"
        let intSingleton = "int val", "new []{ val }"
        let int2DSeqStr = "IEnumerable<IEnumerable<int>> values", "Bindings.flatten2DArrayIf1D(values)"
        let int2DSeqStrOpt = "IEnumerable<IEnumerable<int?>> values", "Bindings.flatten2DArrayIf1D(values)"
        let int2DListStr = "List<int[]> values", "Bindings.flatten2DArrayIf1D(values)"
        let int2DListStrOpt = "List<int?[]> values", "Bindings.flatten2DArrayIf1D(values)"
        let int2DArrayStr = "params int[][] values", "Bindings.flatten2DArrayIf1D(values)"
        let int2DArrayStrOpt = "params int?[][] values", "Bindings.flatten2DArrayIf1D(values)"

        let stringStr = "string val", "val"
        let stringResizeSingleton = "string val", "new []{ val }"
        let stringSeqResizeStr = "IEnumerable<string> values", "values.ToArray()"
        let stringSeqStr = "params string[] values", "values"
        let stringSingleton = "string val", "new []{ val }"
        let string2DSeqStr = "IEnumerable<IEnumerable<string>> values", "Bindings.flatten2DArrayIf1D(values)"
        let string2DListStr = "List<string[]> values", "Bindings.flatten2DArrayIf1D(values)"
        let string2DArrayStr = "params string[][] values", "Bindings.flatten2DArrayIf1D(values)"

        let allNormalStrs =
            [ boolStr; boolSeqStr; dateStr; dateSeqStr; intStr; intSeqStr; floatStr; floatSeqStr; stringStr; stringSeqStr ]

        let allNormalOptStrs = [ boolSeqStrOpt; dateSeqStrOpt; intSeqStrOpt; floatSeqStrOpt ]

        let allBool2DStrs = [ bool2DSeqStr; bool2DListStr; bool2DArrayStr ]
        let allBool2DStrOpt = [ bool2DSeqStrOpt; bool2DListStrOpt; bool2DArrayStrOpt ]

        let allFloat2DStrs = [ float2DSeqStr; float2DListStr; float2DArrayStr ]
        let allFloat2DStrOpt = [ float2DSeqStrOpt; float2DListStrOpt; float2DArrayStrOpt ]

        let allInt2DStrs = [ int2DSeqStr; int2DListStr; int2DArrayStr ]
        let allInt2DStrOpt = [ int2DSeqStrOpt; int2DListStrOpt; int2DArrayStrOpt ]

        let allStr2DStrs = [ string2DSeqStr; string2DListStr; string2DArrayStr ]

        let all2DStrsNoUnions = allBool2DStrs @ allStr2DStrs @ allInt2DStrs @ allFloat2DStrs
        let all2DStrsNoUnionsOpt = allBool2DStrOpt @ allFloat2DStrOpt @ allInt2DStrOpt

        let all2DStrs = all2DStrsNoUnions @ [ data2D ]

        let allBoolArrStrs = [ boolSingleton; boolSeqStr ]
        let allBoolArrResizeStrs = [ boolResizeSingleton; boolSeqResizeStr ]

        let allDateArrStrs = [ dateSingleton; dateSeqStr ]
        let allDateArrResizeStrs = [ dateResizeSingleton; dateSeqResizeStr ]

        let allFloatArrStrs = [ floatSingleton; floatSeqStr ]
        let allFloatArrResizeStrs = [ floatResizeSingleton; floatSeqResizeStr ]

        let allIntArrStrs = [ intSingleton; intSeqStr ]
        let allIntArrResizeStrs = [ intResizeSingleton; intSeqResizeStr ]

        let allStringArrStrs = [ stringSingleton; stringSeqStr ]
        let allStringArrResizeStrs = [ stringResizeSingleton; stringSeqResizeStr ]

        let allArrStrs =
            allBoolArrStrs 
            @ allDateArrStrs 
            @ allFloatArrStrs 
            @ allIntArrStrs 
            @ allStringArrStrs

        let allArrResizeStrs = 
            allBoolArrResizeStrs 
            @ allDateArrResizeStrs 
            @ allFloatArrResizeStrs 
            @ allIntArrResizeStrs 
            @ allStringArrResizeStrs

        let allArrResizeOptStrs =
            [ boolSeqResizeStrOpt; dateSeqResizeStrOpt; intSeqResizeStrOpt; floatSeqResizeStrOpt ]

        let getPrimativeOverloadSeq =
            function
            | ValType.Any -> allArrResizeStrs
            | ValType.Bool _ -> allBoolArrResizeStrs
            | ValType.ColorScale -> [ stringStr; string2DListStr ]
            | ValType.Enumerated -> []
            | ValType.EnumeratedWithCustom -> []
            | ValType.FlagList -> []
            | ValType.Int _ -> allIntArrResizeStrs
            | ValType.Number _ -> allIntArrResizeStrs @ allFloatArrResizeStrs
            | ValType.String _ -> allStringArrResizeStrs
            | s ->
                printfn "%s" (s.ToString())
                [ "TODO val", "val" ]

        /// Extracts the type of the prop
        let rec getType propName attribOverrides (jVal: JsonValue) =
            let hasValType = jVal.TryGetProperty("valType").IsSome

            let isEnumeratedWithCustom() =
                jVal?values.AsArray()
                |> Array.filter (fun s -> s.AsString() |> String.containsRegex)
                |> Array.length > 0

            let attributes = PrimSpecs.create jVal |> PrimSpecs.applyOverride attribOverrides

            match propName, hasValType with
            | _ when attributes.Explicit.IsEmpty |> not ->
                ValType.ExplicitOverride
                    { attributes with Identity = Some <| getType propName { attribOverrides with Explicit = [] } jVal }
            | "matches", true when jVal?valType.AsString() = "enumerated" -> ValType.String attributes
            | "xy", true -> ValType.FloatArray
            | _, true ->
                match jVal?valType
                      |> JsonValue.asString
                      |> fun s -> s.Trim('"') with
                | "angle" -> ValType.Number attributes
                | "any" -> ValType.Any
                | "boolean" -> ValType.Bool attributes
                | "color" ->
                    match attributes.ArrayOk && attributes.NumArrayOk with
                    | true -> ValType.ColorArray
                    | false when attributes.ArrayOk -> ValType.Color attributes
                    | false -> ValType.String attributes
                | "colorlist" -> ValType.String PrimSpecs.allFalse |> ValType.List
                | "colorscale" -> ValType.ColorScale
                | "data_array" -> ValType.DataArray attributes
                | "enumerated" when isEnumeratedWithCustom() -> ValType.EnumeratedWithCustom
                | "enumerated" ->
                    if attributes.ArrayOk then ValType.EnumeratedArray
                    else ValType.Enumerated
                | "flaglist" -> ValType.FlagList
                | "info_array" ->
                    if jVal?items.AsArray().Length < 1 then jVal?items
                    else jVal?items.AsArray().[0]
                    |> getType propName attribOverrides
                    |> ValType.InfoArray
                | "integer" -> ValType.Int attributes
                | "number" -> ValType.Number attributes
                | "string" when jVal.TryGetProperty("values").IsSome -> ValType.EnumeratedWithCustom
                | "string" -> ValType.String attributes
                | "subplotid" -> ValType.String attributes
                | _ -> ValType.Any
            | _ -> ValType.Component

        /// Returns a list of primative overloads for the `ValType`
        let rec getOverloadStrings (parentName: string) (compName: string) (vType: ValType) =
            match vType with
            | ValType.Any -> allNormalStrs
            | ValType.Bool attrib ->
                [ boolStr
                  if attrib.ArrayOk then
                      if attrib.IsCalcType then
                          boolSeqStr
                      else
                          boolSeqResizeStr
                          if attrib.TwoDimArrayOk then yield! allBool2DStrs ]
            | ValType.Color attrib ->
                [ stringStr
                  if attrib.IsCalcType then
                      stringSeqStr
                  else
                      stringSeqResizeStr
                      intSeqStr
                      floatSeqStr
                      if attrib.TwoDimArrayOk then yield! allStr2DStrs ]
            | ValType.ColorArray -> [ stringStr; stringSeqStr; intSingleton; intSeqStr; floatSingleton; floatSeqStr ]
            | ValType.ColorScale -> [ stringStr; string2DListStr ]
            | ValType.DataArray attrib -> 
                if attrib.IsCalcType then allArrStrs @ all2DStrs @ allArrResizeOptStrs
                else allArrResizeStrs @ all2DStrs @ allArrResizeOptStrs
            | ValType.Enumerated -> []
            | ValType.EnumeratedArray -> [ enumeratedArrayStrSeq parentName ]
            | ValType.EnumeratedWithCustom -> []
            | ValType.ExplicitOverride attrib ->
                match attrib.Identity with
                | Some propIdentity -> getOverloadStrings parentName compName propIdentity
                | _ -> []
            | ValType.FlagList -> [ flaglistStrSeq parentName ]
            | ValType.FloatArray -> [ float32FromIntSeqStr; float32FromFloatSeqStr ]
            | ValType.InfoArray vt ->
                match vt with
                | ValType.List vtPrim -> vtPrim
                | _ -> vt
                |> getPrimativeOverloadSeq
            | ValType.Int attrib ->
                [ intStr
                  if attrib.ArrayOk then
                      if attrib.IsCalcType then
                          intSeqStr
                      else
                          intSeqResizeStr
                          if attrib.TwoDimArrayOk then yield! allInt2DStrs ]
            | ValType.List vt -> getPrimativeOverloadSeq vt
            | ValType.Number attrib ->
                [ intStr
                  floatStr
                  if attrib.ArrayOk then
                      if attrib.IsCalcType then
                          yield! [ intSeqStr; floatSeqStr ]
                      else
                          yield! [ intSeqResizeStr; floatSeqResizeStr ]
                          if attrib.TwoDimArrayOk then
                              yield! [ yield! allInt2DStrs
                                       yield! allFloat2DStrs ] ]
            | ValType.String attrib ->
                [ stringStr
                  if attrib.ArrayOk then
                      if attrib.IsCalcType then
                          stringSeqStr
                      else
                          stringSeqResizeStr
                          if attrib.TwoDimArrayOk then yield! allStr2DStrs ]
            | ValType.Component -> [ compStr compName ]

        /// Returns a list of primative overloads for explicit overrides if any are present
        let getExplicitOverloadStrings (vType: ValType) =
            match vType with
            | ValType.ExplicitOverride attrib -> attrib.Explicit
            | _ -> []

        let rec isPrimative (vType: ValType) =
            match vType with
            | ValType.ExplicitOverride attrib ->
                match attrib.Identity with
                | Some vt -> isPrimative vt
                | _ -> false
            | ValType.Component
            | ValType.Enumerated
            | ValType.EnumeratedArray
            | ValType.EnumeratedWithCustom
            | ValType.FlagList -> false
            | _ -> true

    type RegularPropOverloadBody =
        | ValueExprOnly of string
        | CustomBody of string

    type RegularPropOverload =
        { /// The code for the method parameters, e.g. `(value: string)`.
          ParamsCode: string
          /// The code for the prop value expression, e.g. `value` or
          /// `(System.Func<_,_,_> handler)`.
          BodyCode: RegularPropOverloadBody
          /// Whether the member is inline.
          IsInline: bool
          /// Whether the member should be implemented as an extension member.
          IsExtension: bool }

    module RegularPropOverload =
        /// Creates an inline prop overload with the specified code for params and
        /// value expression, implemented as a regular (non-extension) member.
        let create paramsCode valueCode =
            { ParamsCode = paramsCode
              BodyCode = ValueExprOnly valueCode
              IsInline = true
              IsExtension = false }

        /// Creates an inline prop overload with the specified code for params and
        /// body, implemented as a regular (non-extension) member.
        let createCustom paramsCode customBodyCode =
            { ParamsCode = paramsCode
              BodyCode = CustomBody customBodyCode
              IsInline = true
              IsExtension = false }

        /// Sets whether the overload is inline.
        let setInline isInline (overload: RegularPropOverload) = { overload with IsInline = isInline }

        /// Sets whether the overload is implemented as an extension member.
        let setExtension isExtension (overload: RegularPropOverload) = { overload with IsExtension = isExtension }

    type EnumPropOverload =
        { /// The doc lines for the enum prop's value/overload, without leading ///.
          DocLines: string list
          /// The name of the enum prop's value/overload.
          MethodName: string
          /// The code for the method parameters, e.g. `(value: string)`. Normally this
          /// would be `None` (for simple enum values).
          ParamsCode: string option
          /// The code for the prop value expression. Normally this would be the enum
          /// value, e.g. `"topRight"`.
          ValueCode: string
          /// Whether the member is inline.
          IsInline: bool }

    module EnumPropOverload =
        /// Creates an inline enum prop value/overload with the specified method name
        /// and code for value expression and no docs or params.
        let create methodName valueCode =
            { DocLines = []
              MethodName = methodName
              ParamsCode = None
              ValueCode = valueCode
              IsInline = true }

        /// Sets the doc lines of the enum prop value/overload.
        let setDocs docLines (overload: EnumPropOverload) = { overload with DocLines = docLines }

        /// Sets the params code for the enum prop value/overload.
        let setParamsCode code (overload: EnumPropOverload) = { overload with ParamsCode = Some code }

        /// Sets whether the overload is inline.
        let setInline isInline (overload: EnumPropOverload) = { overload with IsInline = isInline }

    type Prop =
        { /// The doc lines for the prop, without leading ///.
          DocLines: string list
          /// The actual name of the prop in the native API.
          RealPropName: string
          /// The name used for the prop overload methods.
          MethodName: string
          /// The prop overloads.
          RegularOverloads: RegularPropOverload list
          /// The prop overloads.
          EnumOverloads: EnumPropOverload list
          /// The list of parent components
          ParentNameTree: string list
          /// The data type of the prop
          PropType: ValType }

    module Prop =
        /// Creates a prop with the specified native API name and method name and no
        /// docs or overloads.
        let create propType realPropName methodName =
            { DocLines = []
              RealPropName = realPropName
              MethodName = methodName
              RegularOverloads = []
              EnumOverloads = []
              ParentNameTree = []
              PropType = propType }

        /// Sets the prop's doc lines.
        let setDocs docLines (prop: Prop) = { prop with DocLines = docLines }

        /// Adds the specified regular (non-enum) overload to the prop.
        let addRegularOverload overload prop = { prop with RegularOverloads = prop.RegularOverloads @ [ overload ] }

        /// Adds the specified enum value/overload to the prop.
        let addEnumOverload overload prop = { prop with EnumOverloads = prop.EnumOverloads @ [ overload ] }

        /// Adds the specified component tree to the prop.
        let addParentComponentTree (tree: string list) (prop: Prop) =
            { prop with ParentNameTree = prop.ParentNameTree @ (tree |> List.map String.upperFirst) }

        /// Indicates whether all regular prop overloads are inline.
        let allRegularOverloadsAreInline prop = prop.RegularOverloads |> List.forall (fun o -> o.IsInline)

    type ComponentOverload =
        { /// The code for the method parameters, e.g. `props` or `(text: string)`.
          ParamFun: string -> string
          /// The expression for the props passed to the created element, e.g. `props`
          /// or `[ prop.children (Html.text text) ]`.
          PropsCode: string
          /// Whether the member is inline.
          IsInline: bool
          /// Whether the attribute should produce an attribute for a higher level component
          SkipAttr: bool }

    module ComponentOverload =
        /// A default overload that accepts and passes a list of props.
        let defaults =
            [ { ParamFun = sprintf "List<Box<I%sProperty>> properties"
                PropsCode = "properties"
                IsInline = true
                SkipAttr = false } ]

        /// Creates an inline component overload with the specified code for params
        /// and props expression.
        let create paramFun propsCode =
            { ParamFun = paramFun
              PropsCode = propsCode
              IsInline = true
              SkipAttr = false }

        /// Sets whether the overload is inline.
        let setInline isInline (overload: ComponentOverload) = { overload with IsInline = isInline }

        /// Sets the overload parameter function
        let setParamFun paramFun (overload: ComponentOverload) = { overload with ParamFun = paramFun }

        /// Sets the overload props code
        let setPropsCode propsCode (overload: ComponentOverload) = { overload with PropsCode = propsCode }

        /// Sets if the component should produce an attribute for a higher level component
        let setSkipAttr b (overload: ComponentOverload) = { overload with SkipAttr = b }

    type Component =
        { /// The doc lines for the component, without leading ///.
          DocLines: string list
          /// The name used for the component overloads.
          MethodName: string
          /// The path the component will be imported from.
          ImportSelector: string option
          /// The overloads used to create the component.
          Overloads: ComponentOverload list
          /// The component's props.
          Props: Prop list
          /// The list of parent components
          ParentNameTree: string list }

    module Component =
        /// Creates a component with the specified method name and import path, no
        /// documentation, import selector, or props, and the default component
        /// overload.
        let create methodName =
            { DocLines = []
              MethodName = methodName
              ImportSelector = None
              Overloads = ComponentOverload.defaults
              Props = []
              ParentNameTree = [] }

        /// Sets the import selector of the component.
        let setImportSelector selector comp = { comp with ImportSelector = Some selector }

        /// Sets the component's doc lines.
        let setDocs docLines (comp: Component) = { comp with DocLines = docLines }

        /// Adds the specified overload to the component.
        let addOverload overload comp = { comp with Overloads = comp.Overloads @ [ overload ] }

        /// Adds the specified prop to the component.
        let addProp prop comp = { comp with Props = comp.Props @ [ prop ] }

        /// Indicates whether all components have only inline overloads.
        let hasOnlyInlineOverloads comp = comp.Overloads |> List.forall (fun o -> o.IsInline)

        /// Add a component tree list
        let addParentComponentTree (tree: string list) (comp: Component) =
            { comp with ParentNameTree = comp.ParentNameTree @ (tree |> List.map String.upperFirst) }

    type ComponentApi =
        { /// The namespace for the API.
          Namespace: string
          /// Lines to insert before the component definitions.
          ComponentsPrelude: string list
          /// Lines to insert before the prop definitions.
          PropsPrelude: string list
          /// The name of the module the types are placed under.
          ComponentContainerName: string
          /// The type the component methods will be placed in.
          ComponentContainerTypeName: string
          /// All components in the API.
          Components: Component list
          /// Bindings for the API.
          Bindings: (string * string) list
          /// Lines to insert after the component definitions.
          TypePostlude: (string * string) list }

    module ComponentApi =
        /// Creates a component API with the specified namespace and component type
        /// name and no components.
        let create namespace' typeName containerName bindings typePostlude =
            { Namespace = namespace'
              ComponentsPrelude = []
              PropsPrelude = []
              ComponentContainerName = containerName
              ComponentContainerTypeName = typeName
              Components = []
              Bindings = bindings
              TypePostlude = typePostlude }

        /// Adds the specified component to the API.
        let addComponent component' api: ComponentApi = { api with Components = api.Components @ [ component' ] }

        /// Adds the specified components prelude to the API.
        let setComponentsPrelude lines api = { api with ComponentsPrelude = lines }

        /// Adds the specified props prelude to the API.
        let setPropsPrelude lines api = { api with PropsPrelude = lines }

    type PlotlyComponentApi =
        { GeneratorComponentApi: ComponentApi
          PlotlyComponents: Component list }
