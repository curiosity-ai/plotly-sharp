using Tesserae;
using Tesserae.Plotly;
using static Tesserae.UI;

namespace Plotly.Samples
{
    public sealed class UpdatingSample : ISample
    {
        public string Group => "Layout";
        public string Name  => "Updating";

        public IComponent Content()
        {
            var seed = 1;

            var chart = new PlotlyChart(
                    Traces.bar(Bar.x(Datasets.Months), Bar.y(Datasets.Noisy(12, seed, 50)), Bar.marker(Marker.color("#5B8FF9"))))
                .Title("Live data")
                .ShowLegend(false);

            // Reuse the same chart instance: change traces and call Update() -> Plotly.react (no teardown).
            var randomize = Button("New data").Primary().OnClick(() =>
            {
                seed++;
                chart.Update(Traces.bar(Bar.x(Datasets.Months), Bar.y(Datasets.Noisy(12, seed, 50)), Bar.marker(Marker.color("#5B8FF9"))));
            });

            var recolor = Button("Recolor").OnClick(() =>
            {
                // Fluent setters after render also update the existing plot.
                chart.PlotBackground(seed % 2 == 0 ? "#FFFFFF" : "#F2F6FF").Update();
            });

            return VStack().S().ScrollY().PL(24).PR(24).PB(24).Children(
                TextBlock("Updating an existing plot", textSize: TextSize.XLarge, textWeight: TextWeight.Bold).PT(24).PB(4),
                TextBlock("The first render calls Plotly.newPlot; every later change — whether Update(newTraces) or a fluent setter followed by Update() — is applied with Plotly.react, which diffs against the current plot instead of rebuilding it.", textSize: TextSize.Medium).PB(16),
                Card(VStack().WS().Children(
                    HStack().PB(8).Children(randomize.MR(8), recolor),
                    chart.WS().H(360))).WS());
        }
    }
}
