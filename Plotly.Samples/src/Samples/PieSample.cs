using Tesserae;
using Tesserae.Plotly;

namespace Plotly.Samples
{
    public sealed class PieSample : ISample
    {
        public string Group => "Basic";
        public string Name  => "Pie & Donut";

        public IComponent Content()
        {
            var labels = new[] { "Direct", "Search", "Social", "Referral", "Email" };
            var values = new float[] { 42, 27, 18, 9, 4 };

            var pie = new PlotlyChart(
                    Traces.pie(Pie.labels(labels), Pie.values(values)))
                .Title("Traffic sources")
                .ShowLegend();

            var donut = new PlotlyChart(
                    Traces.pie(Pie.labels(labels), Pie.values(values), Pie.hole(0.5f),
                        Pie.marker(Marker.colors(new[] { "#5B8FF9", "#61DDAA", "#F6BD16", "#7262FD", "#F08BB4" }))))
                .Title("Donut chart")
                .ShowLegend();

            return SampleUI.Page(
                "Pie & Donut",
                "Pie traces show parts of a whole; set a hole to turn a pie into a donut.",
                new Example("Pie", "Category share of total.", pie),
                new Example("Donut", "A pie with a 0.5 hole and a custom color set.", donut));
        }
    }
}
