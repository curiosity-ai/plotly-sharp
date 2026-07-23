using Tesserae;
using Tesserae.Plotly;

namespace Plotly.Samples
{
    public sealed class LineScatterSample : ISample
    {
        public string Group => "Basic";
        public string Name  => "Line & Scatter";

        public IComponent Content()
        {
            var x = Datasets.Range(20);

            var lines = new PlotlyChart(
                    Traces.scatter(Scatter.x(Datasets.Months), Scatter.y(Datasets.Revenue), Scatter.mode(Scatter.Mode.lines()), Scatter.name("Revenue")),
                    Traces.scatter(Scatter.x(Datasets.Months), Scatter.y(Datasets.Costs), Scatter.mode(Scatter.Mode.lines()), Scatter.name("Costs")))
                .Title("Monthly revenue vs. costs")
                .ShowLegend();

            var markers = new PlotlyChart(
                    Traces.scatter(
                        Scatter.x(Datasets.Noisy(60, 1, 10)),
                        Scatter.y(Datasets.Noisy(60, 2, 10)),
                        Scatter.mode(Scatter.Mode.markers()),
                        Scatter.marker(Marker.size(9), Marker.color("#5B8FF9"), Marker.opacity(0.7f)),
                        Scatter.name("Samples")))
                .Title("Scatter (markers only)");

            var linesMarkers = new PlotlyChart(
                    Traces.scatter(
                        Scatter.x(x), Scatter.y(Datasets.Sine(20, 3f)),
                        Scatter.mode(Scatter.Mode.lines(), Scatter.Mode.markers()),
                        Scatter.line(Line.Shape.spline(), Line.width(3)),
                        Scatter.marker(Marker.size(7)),
                        Scatter.name("sin")))
                .Title("Smoothed line + markers");

            var filled = new PlotlyChart(
                    Traces.scatter(Scatter.x(x), Scatter.y(Datasets.Sine(20, 2f, 0f)), Scatter.Fill.tozeroy(), Scatter.name("A")),
                    Traces.scatter(Scatter.x(x), Scatter.y(Datasets.Sine(20, 3f, 1f)), Scatter.Fill.tonexty(), Scatter.name("B")))
                .Title("Filled area")
                .ShowLegend();

            return SampleUI.Page(
                "Line & Scatter",
                "Scatter traces cover line charts, point clouds, smoothed lines and filled areas — switch behaviour with the trace mode and fill.",
                new Example("Line chart", "Two line series with a legend.", lines),
                new Example("Scatter", "Markers only, with size, color and opacity.", markers),
                new Example("Line + markers", "A spline-smoothed line with markers.", linesMarkers),
                new Example("Filled area", "Stacked filled areas using fill: tozeroy / tonexty.", filled));
        }
    }
}
