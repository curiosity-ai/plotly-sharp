namespace Fable.Plotly.Generator

module Program =
    open Fake.IO
    open Fake.IO.FileSystemOperators
    open Microsoft.CodeAnalysis
    open Microsoft.CodeAnalysis.CSharp
    open FSharp.Data

    [<EntryPoint>]
    let main _ =


        // only embedd the javascript files on the Plotly.Bridge project
        let libMinFile  = __SOURCE_DIRECTORY__ @@ "../Plotly.Bridge/bridge/plotly.min.js"
        let libFile     = __SOURCE_DIRECTORY__ @@ "../Plotly.Bridge/bridge/plotly.js"

        Http.RequestString(@"https://raw.githubusercontent.com/plotly/plotly.js/master/dist/plotly.min.js") |> File.writeString false libMinFile
        Http.RequestString(@"https://raw.githubusercontent.com/plotly/plotly.js/master/dist/plotly.js")     |> File.writeString false libFile

        let projects = ["Plotly.Bridge"; "Plotly.Sharp"]

        for proj in projects do
            let api = match proj with
                      | "Plotly.Bridge" -> "PlotlyBridge" |> ApiParser.parseApi
                      | "Plotly.Sharp"  -> "Plotly"       |> ApiParser.parseApi
            
            let plotlyFile  = __SOURCE_DIRECTORY__ @@ sprintf "../%s/Plotly.cs" proj
            let interopFile = __SOURCE_DIRECTORY__ @@ sprintf "../%s/Interop.cs" proj
            let typesFile   = __SOURCE_DIRECTORY__ @@ sprintf "../%s/Types.cs" proj
            let propsDir    = __SOURCE_DIRECTORY__ @@ sprintf "../%s/Props" proj

            Shell.cleanDir propsDir

            let plotlyCode  = Render.componentDocument api.GeneratorComponentApi |> CSharpSyntaxTree.ParseText
            plotlyCode.GetRoot().NormalizeWhitespace().ToFullString()            |> File.writeString false plotlyFile

            let interopCode = Render.interopDocument api.GeneratorComponentApi   |> CSharpSyntaxTree.ParseText
            interopCode.GetRoot().NormalizeWhitespace().ToFullString()           |> File.writeString false interopFile

            let typesCode   = Render.typesDocument api.GeneratorComponentApi     |> CSharpSyntaxTree.ParseText
            typesCode.GetRoot().NormalizeWhitespace().ToFullString()             |> File.writeString false typesFile

            api.GeneratorComponentApi
            |> Render.propsDocument true
            |> List.iter (fun (name, doc) ->
                let path        = propsDir @@ (sprintf "%s.cs" (name |> String.upperFirst))
                let formatedDoc = doc |> CSharpSyntaxTree.ParseText;
                formatedDoc.GetRoot().NormalizeWhitespace().ToFullString() |> File.writeString false path
                )
            
        0
