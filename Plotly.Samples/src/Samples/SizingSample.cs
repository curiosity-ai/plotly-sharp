using Tesserae;
using Tesserae.Plotly;
using static Tesserae.UI;

namespace Plotly.Samples
{
    public sealed class SizingSample : ISample
    {
        public string Group => "Layout";
        public string Name  => "Sizing";

        private static PlotlyChart Demo(string title) => new PlotlyChart(
                Traces.scatter(Scatter.x(Datasets.Months), Scatter.y(Datasets.Revenue), Scatter.mode(Scatter.Mode.lines(), Scatter.Mode.markers())))
            .Title(title)
            .Margin(40, 20, 40, 30);

        public IComponent Content()
        {
            // Fixed pixel size — the chart container is exactly 420 x 240.
            var fixedSize = Demo("420 x 240").W(420).H(240).Class("sample-chart-fixed");

            // Full width, fixed height — fills the card's width, follows it on resize.
            var stretchW = Demo("Width stretch").WS().H(260).Class("sample-chart-ws");

            // Two charts sharing a row equally: each lives in a .W(1).Grow() pane so both shrink evenly.
            var growLeft  = Demo("Grow (left)").Class("sample-chart-grow").S();
            var growRight = Demo("Grow (right)").Class("sample-chart-grow").S();
            var row = HStack().WS().H(280).Children(
                VStack().W(1).Grow().HS().Children(growLeft),
                VStack().W(1).Grow().HS().Children(growRight));

            return VStack().S().ScrollY().PL(24).PR(24).PB(24).Children(
                TextBlock("Sizing", textSize: TextSize.XLarge, textWeight: TextWeight.Bold).PT(24).PB(4),
                TextBlock("PlotlyChart implements ISpecialCaseStyling, so the standard Tesserae sizing helpers apply directly to the chart and Plotly resizes to match its container (via a ResizeObserver).", textSize: TextSize.Medium).PB(16),

                Card(VStack().WS().Children(
                    TextBlock("Fixed size — .W(420).H(240)", textSize: TextSize.MediumPlus, textWeight: TextWeight.SemiBold).PB(8),
                    fixedSize)).WS().MB(16),

                Card(VStack().WS().Children(
                    TextBlock("Width stretch — .WS().H(260)", textSize: TextSize.MediumPlus, textWeight: TextWeight.SemiBold).PB(8),
                    stretchW)).WS().MB(16),

                Card(VStack().WS().Children(
                    TextBlock("Two charts sharing a row — .Grow() in an HStack", textSize: TextSize.MediumPlus, textWeight: TextWeight.SemiBold).PB(8),
                    row)).WS().MB(16));
        }
    }
}
