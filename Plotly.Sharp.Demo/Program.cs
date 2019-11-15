using System;

namespace Plotly.Sharp.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var testData = new[]
            {
                new float[]{ 1, 20, 30 },
                new float[]{20,  1, 60 },
                new float[]{30, 60,  1 }
            };

            var chart = new Plot(Plot.traces(Traces.heatmap(Heatmap.z(testData))));
            
            Console.WriteLine(chart.Render());
        }
    }
}
