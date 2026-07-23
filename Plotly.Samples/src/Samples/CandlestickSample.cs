using System;
using Tesserae;
using Tesserae.Plotly;

namespace Plotly.Samples
{
    public sealed class CandlestickSample : ISample
    {
        public string Group => "Financial";
        public string Name  => "Candlestick";

        public IComponent Content()
        {
            const int n = 30;
            var dates = new string[n];
            var open  = new float[n];
            var high  = new float[n];
            var low   = new float[n];
            var close = new float[n];

            var noise = Datasets.Noisy(n * 2, 42, 6);
            var price = 100f;
            var start = new DateTime(2025, 1, 1);

            for (int i = 0; i < n; i++)
            {
                var o = price;
                var c = price + noise[i] - 3f;
                var h = Math.Max(o, c) + noise[n + i] * 0.5f;
                var l = Math.Min(o, c) - noise[n + i] * 0.5f;

                dates[i] = start.AddDays(i).ToString("yyyy-MM-dd");
                open[i]  = o;
                close[i] = c;
                high[i]  = h;
                low[i]   = l;
                price    = c;
            }

            var candles = new PlotlyChart(
                    Traces.candlestick(
                        Candlestick.x(dates),
                        Candlestick._open(open),
                        Candlestick.high(high),
                        Candlestick.low(low),
                        Candlestick.close(close),
                        Candlestick.name("ACME")))
                .Title("Daily OHLC")
                .ShowLegend(false);

            return SampleUI.Page(
                "Candlestick",
                "Candlestick traces visualize open / high / low / close financial series over time.",
                new Example("OHLC", "A month of synthetic daily prices.", candles, 460));
        }
    }
}
