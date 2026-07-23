using Tesserae;
using Tesserae.Plotly;

namespace Plotly.Samples
{
    public sealed class IndicatorSample : ISample
    {
        public string Group => "Specialized";
        public string Name  => "Indicator";

        public IComponent Content()
        {
            var gauge = new PlotlyChart(
                    Traces.indicator(
                        Indicator.mode(Indicator.Mode.gauge(), Indicator.Mode.number(), Indicator.Mode.delta()),
                        Indicator.value(270f),
                        Indicator.delta(Delta.reference(250)),
                        Indicator.title(Title.text("Speed"))))
                .Title("Gauge indicator");

            var number = new PlotlyChart(
                    Traces.indicator(
                        Indicator.mode(Indicator.Mode.number(), Indicator.Mode.delta()),
                        Indicator.value(4390f),
                        Indicator.delta(Delta.reference(4200)),
                        Indicator.title(Title.text("Monthly active users"))))
                .Title("Number + delta");

            return SampleUI.Page(
                "Indicator",
                "Indicator traces show a single KPI as a number, a delta against a reference, and/or a gauge.",
                new Example("Gauge", "Gauge + number + delta.", gauge, 320),
                new Example("Number", "A big number with a delta versus last period.", number, 320));
        }
    }
}
