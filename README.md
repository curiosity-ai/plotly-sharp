<a href="https://curiosity.ai"><img src="https://curiosity.ai/assets/images/logos/curiosity.png" width="100" height="100" align="right" /></a>

_**Plotly.Bridge**_ provides a strongly-typed binding to use [Plotly](https://plot.ly/javascript/) on [Bridge.Net](https://github.com/bridgedotnet/Bridge) applications. 

This library is automatically generated from the official [plotly.js API schema](https://raw.githubusercontent.com/plotly/plotly.js/master/dist/plot-schema.json), and includes  the respective plotly.min.js file as part of the Nuget package.

[![Nuget](https://img.shields.io/nuget/v/Plotly.Bridge.svg?maxAge=0&colorB=brightgreen)](https://www.nuget.org/packages/Plotly.Bridge)

Example:

```csharp
var data = new[]
                {
                    new float[]{ 1, 20, 30 },
                    new float[]{20,  1, 60 },
                    new float[]{30, 60,  1 }
                };


var chart = Plotly.plot(
                   plot.traces(
                        Traces.heatmap(
                               Heatmap.z(data)
                        )
                    )
                );

document.body.appendChild(chart.Render());

```

You can follow the official [documentation](https://plot.ly/javascript/) from Plotly, as the types and usage are almost exactly the same (one minor but important change: some of the objects on C# have the first letter in upper-case (like Traces.heatmap on the example above).

> Event types have been manually created, and have not been all checked for consistency. If you find any definition that doesn't match the expected one from plotly, please open an issue for it!