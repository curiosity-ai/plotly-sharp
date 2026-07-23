using Tesserae;
using Tesserae.Plotly;

namespace Plotly.Samples
{
    public sealed class BarSample : ISample
    {
        public string Group => "Basic";
        public string Name  => "Bar";

        public IComponent Content()
        {
            var q = new[] { "Q1", "Q2", "Q3", "Q4" };

            var grouped = new PlotlyChart(
                    Traces.bar(Bar.x(q), Bar.y(new float[] { 20, 14, 23, 25 }), Bar.name("2024"), Bar.marker(Marker.color("#5B8FF9"))),
                    Traces.bar(Bar.x(q), Bar.y(new float[] { 12, 18, 29, 33 }), Bar.name("2025"), Bar.marker(Marker.color("#61DDAA"))))
                .Title("Grouped bars")
                .BarMode("group")
                .ShowLegend();

            var stacked = new PlotlyChart(
                    Traces.bar(Bar.x(q), Bar.y(new float[] { 20, 14, 23, 25 }), Bar.name("Product A")),
                    Traces.bar(Bar.x(q), Bar.y(new float[] { 12, 18, 29, 33 }), Bar.name("Product B")),
                    Traces.bar(Bar.x(q), Bar.y(new float[] { 8, 9, 11, 15 }), Bar.name("Product C")))
                .Title("Stacked bars")
                .BarMode("stack")
                .ShowLegend();

            var horizontal = new PlotlyChart(
                    Traces.bar(
                        Bar.y(new[] { "Alpha", "Bravo", "Charlie", "Delta", "Echo" }),
                        Bar.x(new float[] { 42, 31, 27, 18, 9 }),
                        Bar.Orientation.h(),
                        Bar.marker(Marker.color("#F6BD16"))))
                .Title("Horizontal bars")
                .Margin(120, 20, 40, 40);

            return SampleUI.Page(
                "Bar",
                "Bar charts group or stack multiple traces and can be drawn horizontally. Combine traces with BarMode.",
                new Example("Grouped", "Two series side by side.", grouped),
                new Example("Stacked", "Three series stacked with BarMode(\"stack\").", stacked),
                new Example("Horizontal", "Categories on the y axis via Orientation.h().", horizontal));
        }
    }
}
