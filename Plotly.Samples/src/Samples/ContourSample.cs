using Tesserae;
using Tesserae.Plotly;

namespace Plotly.Samples
{
    public sealed class ContourSample : ISample
    {
        public string Group => "Scientific";
        public string Name  => "Contour";

        public IComponent Content()
        {
            var z = Datasets.Surface(24, 32);

            var basic = new PlotlyChart(
                    Traces.contour(Contour.z(z)))
                .Title("Contour plot");

            var scaled = new PlotlyChart(
                    Traces.contour(Contour.z(z), Contour.colorscale("Electric")))
                .Title("Contour (Electric)");

            return SampleUI.Page(
                "Contour",
                "Contour traces draw iso-lines over a 2D z-matrix — the same data as a heatmap, shown as filled level bands.",
                new Example("Basic", "Default contour of z = sin(x)·cos(y).", basic, 420),
                new Example("Colored", "A different named color scale.", scaled, 420));
        }
    }
}
