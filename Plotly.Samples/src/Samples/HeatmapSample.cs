using Tesserae;
using Tesserae.Plotly;

namespace Plotly.Samples
{
    public sealed class HeatmapSample : ISample
    {
        public string Group => "Scientific";
        public string Name  => "Heatmap";

        public IComponent Content()
        {
            var z = Datasets.Surface(20, 30);

            var basic = new PlotlyChart(
                    Traces.heatmap(Heatmap.z(z)))
                .Title("Heatmap (default color scale)");

            var scaled = new PlotlyChart(
                    Traces.heatmap(Heatmap.z(z), Heatmap.colorscale("Viridis"), Heatmap.showscale(true)))
                .Title("Heatmap (Viridis)");

            return SampleUI.Page(
                "Heatmap",
                "Heatmaps render a 2D matrix (z) as a color grid. Pick any named Plotly color scale.",
                new Example("Basic", "A z-matrix with the default color scale.", basic, 420),
                new Example("Viridis", "The same data with the Viridis scale and a visible color bar.", scaled, 420));
        }
    }
}
