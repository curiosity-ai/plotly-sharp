using Tesserae;
using Tesserae.Plotly;

namespace Plotly.Samples
{
    public sealed class BubbleSample : ISample
    {
        public string Group => "Basic";
        public string Name  => "Bubble";

        public IComponent Content()
        {
            var x    = new float[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var y    = new float[] { 15, 11, 18, 14, 22, 19, 27, 24 };
            var size = new float[] { 40, 18, 30, 12, 55, 25, 60, 35 };

            var bubble = new PlotlyChart(
                    Traces.scatter(
                        Scatter.x(x), Scatter.y(y),
                        Scatter.mode(Scatter.Mode.markers()),
                        Scatter.marker(Marker.size(size), Marker.color(size), Marker.colorscale("Portland"), Marker.showscale(true))))
                .Title("Bubble chart (marker size + color scale)");

            return SampleUI.Page(
                "Bubble",
                "A scatter trace becomes a bubble chart when the marker size is bound to a data array; color can encode a third dimension.",
                new Example("Bubbles", "Marker size and color both driven by the data.", bubble, 420));
        }
    }
}
