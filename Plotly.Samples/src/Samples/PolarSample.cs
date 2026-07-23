using System.Linq;
using Tesserae;
using Tesserae.Plotly;

namespace Plotly.Samples
{
    public sealed class PolarSample : ISample
    {
        public string Group => "Specialized";
        public string Name  => "Polar";

        public IComponent Content()
        {
            var theta = new[] { "North", "N-E", "East", "S-E", "South", "S-W", "West", "N-W" };

            var radar = new PlotlyChart(
                    Traces.scatterpolar(
                        Scatterpolar.r(new float[] { 4, 3, 2, 5, 4, 3, 2, 4 }),
                        Scatterpolar.theta(theta),
                        Scatterpolar.Fill.toself(),
                        Scatterpolar.name("Team A")),
                    Traces.scatterpolar(
                        Scatterpolar.r(new float[] { 3, 4, 5, 2, 3, 4, 5, 3 }),
                        Scatterpolar.theta(theta),
                        Scatterpolar.Fill.toself(),
                        Scatterpolar.name("Team B")))
                .Title("Radar chart")
                .ShowLegend();

            var spiral = new PlotlyChart(
                    Traces.scatterpolar(
                        Scatterpolar.r(Datasets.Range(60).Select(v => v / 6f).ToArray()),
                        Scatterpolar.theta(Datasets.Range(60).Select(v => v * 12f).ToArray()),
                        Scatterpolar.mode(Scatterpolar.Mode.lines())))
                .Title("Polar spiral");

            return SampleUI.Page(
                "Polar",
                "Scatterpolar traces plot radius (r) against angle (theta) — useful for radar charts and polar curves.",
                new Example("Radar", "Two filled series on a categorical angular axis.", radar, 440),
                new Example("Spiral", "A continuous polar line.", spiral, 440));
        }
    }
}
