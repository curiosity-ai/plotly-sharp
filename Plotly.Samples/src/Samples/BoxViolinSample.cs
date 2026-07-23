using Tesserae;
using Tesserae.Plotly;

namespace Plotly.Samples
{
    public sealed class BoxViolinSample : ISample
    {
        public string Group => "Statistical";
        public string Name  => "Box & Violin";

        public IComponent Content()
        {
            var g1 = Datasets.Noisy(80, 3, 40);
            var g2 = Datasets.Noisy(80, 15, 60);
            var g3 = Datasets.Noisy(80, 27, 50);

            var box = new PlotlyChart(
                    Traces.box(Box.y(g1), Box.name("A")),
                    Traces.box(Box.y(g2), Box.name("B")),
                    Traces.box(Box.y(g3), Box.name("C")))
                .Title("Box plot by group");

            var boxPoints = new PlotlyChart(
                    Traces.box(Box.y(g1), Box.name("A"), Box.Boxpoints.all(), Box.marker(Marker.color("#5B8FF9"))),
                    Traces.box(Box.y(g2), Box.name("B"), Box.Boxpoints.all(), Box.marker(Marker.color("#61DDAA"))))
                .Title("Box plot showing all points");

            var violin = new PlotlyChart(
                    Traces.violin(Violin.y(g1), Violin.name("A"), Violin.box(Box.Visible._true())),
                    Traces.violin(Violin.y(g2), Violin.name("B"), Violin.box(Box.Visible._true())))
                .Title("Violin plot with inner box");

            return SampleUI.Page(
                "Box & Violin",
                "Box and violin traces summarize distributions. Box plots can overlay their raw points; violins can embed a box.",
                new Example("Box", "One box per group.", box),
                new Example("Box + points", "Every underlying point drawn alongside the box.", boxPoints),
                new Example("Violin", "Kernel-density violins with an inner box.", violin));
        }
    }
}
