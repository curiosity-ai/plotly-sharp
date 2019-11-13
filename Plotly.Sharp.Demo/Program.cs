using System;

namespace Plotly.Sharp.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new[]
                {
                                new float[]{ 1, 20, 30 },
                                new float[]{20,  1, 60 },
                                new float[]{30, 60,  1 }
                            };


            var chart = Plotly.plot(
                                plot.traces(
                                     Traces.heatmap(
                                            Heatmap.z(data)
                                    )
                                )
                            );

            Console.WriteLine(chart.Render().ToHTML());
        }
    }
}
