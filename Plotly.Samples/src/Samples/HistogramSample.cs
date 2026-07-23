using Tesserae;
using Tesserae.Plotly;

namespace Plotly.Samples
{
    public sealed class HistogramSample : ISample
    {
        public string Group => "Statistical";
        public string Name  => "Histogram";

        public IComponent Content()
        {
            var a = Datasets.Noisy(400, 7, 100);
            var b = Datasets.Noisy(400, 99, 100);

            var basic = new PlotlyChart(
                    Traces.histogram(Histogram.x(a), Histogram.nbinsx(30)))
                .Title("Distribution (30 bins)");

            var overlaid = new PlotlyChart(
                    Traces.histogram(Histogram.x(a), Histogram.name("Group A"), Histogram.opacity(0.6f)),
                    Traces.histogram(Histogram.x(b), Histogram.name("Group B"), Histogram.opacity(0.6f)))
                .Title("Two overlaid distributions")
                .BarMode("overlay")
                .ShowLegend();

            return SampleUI.Page(
                "Histogram",
                "Histograms bin raw values automatically. Overlay several with transparency and BarMode(\"overlay\").",
                new Example("Basic", "A single distribution with a fixed bin count.", basic),
                new Example("Overlaid", "Two semi-transparent distributions.", overlaid));
        }
    }
}
