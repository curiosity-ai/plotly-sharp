[![Build Status](https://dev.azure.com/curiosity-ai/mosaik/_apis/build/status/plotly-sharp?branchName=master)](https://dev.azure.com/curiosity-ai/mosaik/_build/latest?definitionId=19&branchName=master)

<img src="https://raw.githubusercontent.com/curiosity-ai/plotly.bridge/master/Plotly.Bridge/plotly-bridge-logo.png"/>

<a href="https://curiosity.ai"><img src="https://curiosity.ai/media/cat.color.square.svg" width="100" height="100" align="right" /></a>

_**Plotly.Sharp**_ provides a strongly-typed binding to generate embedded HTML using  [Plotly](https://plot.ly/javascript/).

[![Nuget](https://img.shields.io/nuget/v/Plotly.Sharp.svg?maxAge=0&colorB=brightgreen)](https://www.nuget.org/packages/Plotly.Sharp)

_**Plotly.Bridge**_ provides a strongly-typed binding to use [Plotly](https://plot.ly/javascript/) on [Bridge.Net](https://github.com/bridgedotnet/Bridge) applications. 

[![Nuget](https://img.shields.io/nuget/v/Plotly.Bridge.svg?maxAge=0&colorB=brightgreen)](https://www.nuget.org/packages/Plotly.Bridge)

_**Tesserae.Plotly**_ provides the same strongly-typed binding **plus** a first-class [Tesserae](https://github.com/curiosity-ai/tesserae) `IComponent` wrapper (`PlotlyChart`) for building charts inside Tesserae web applications compiled with the Transpose C#-to-JavaScript compiler. The vendored `plotly.js` is bundled in the package and injected automatically, so no CDN is required.

[![Nuget](https://img.shields.io/nuget/v/Tesserae.Plotly.svg?maxAge=0&colorB=brightgreen)](https://www.nuget.org/packages/Tesserae.Plotly)

### Using `PlotlyChart` in a Tesserae app

`PlotlyChart` is a normal Tesserae component: it draws itself into a full-size container when mounted and keeps itself sized to that container (via a `ResizeObserver`), so all the usual sizing helpers (`.WS()`, `.HS()`, `.S()`, `.W(..)`, `.H(..)`, `.Grow()`, …) apply. Key Plotly options are surfaced as fluent methods.

```csharp
using Tesserae.Plotly;
using static Tesserae.UI;

var chart = new PlotlyChart(
        Traces.scatter(Scatter.x(months), Scatter.y(revenue), Scatter.mode(Scatter.Mode.lines()), Scatter.name("Revenue")),
        Traces.scatter(Scatter.x(months), Scatter.y(costs),   Scatter.mode(Scatter.Mode.lines()), Scatter.name("Costs")))
    .Title("Monthly revenue vs. costs")
    .Background("#ffffff")
    .ShowLegend()
    .WS().H(360);

// Later, update the existing plot efficiently (uses Plotly.react under the hood):
chart.Update(Traces.bar(Bar.x(months), Bar.y(newValues)));
```

The `Plotly.Samples` project in this repository is a runnable Tesserae app with one page per plot type (line/scatter, bar, pie, bubble, histogram, box &amp; violin, heatmap, contour, 3D surface &amp; scatter, candlestick, polar, sunburst, indicator) plus dedicated **Sizing** and **Updating** demos.

Both libraries are automatically generated from the official [plotly.js API schema](https://raw.githubusercontent.com/plotly/plotly.js/master/dist/plot-schema.json), and includes  the respective plotly.min.js file as part of the Nuget package.

Example:

```csharp
var data = new[]{
                    new []{ 1f, 20f, 30f },
                    new []{20f,  1f, 60f },
                    new []{30f, 60f,  1f }
                };

//Or use the shortcut:
// var data = data.m( 1f, 20f, 30f)
//                .r(20f,  1f, 60f)
//                .r(30f, 60f,  1f);

var chart = new Plot(
                Plot.traces(
                     Traces.heatmap(
                            Heatmap.z(data))));

//For Plotly.Bridge, you can directly render the chart to an HTMLElement:
    document.body.appendChild(chart.Render());

//For Plotly.Sharp, you can create the embedded HTML string as follows:
    var html = chart.Render().ToHTML();
```

You can follow the official [documentation](https://plot.ly/javascript/) from Plotly, as the types and usage are almost exactly the same (one minor but **important change**: some of the objects on C# have the first letter in upper-case (like Traces.heatmap on the example above).

*Note*: Event types have been manually created, and have not been all validated against plotly's events. If you find any definition that doesn't match the expected one from plotly, please open an issue for it!

This project is derived from the awesome work by [Cody Johnson](https://github.com/Shmew) on the [F# bindings](https://github.com/Shmew/Feliz.Plotly/).
