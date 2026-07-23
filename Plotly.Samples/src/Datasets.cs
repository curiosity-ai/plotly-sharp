using System;
using System.Linq;

namespace Plotly.Samples
{
    /// <summary>Small, deterministic datasets shared across the sample pages.</summary>
    internal static class Datasets
    {
        public static readonly string[] Months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

        public static readonly float[] Revenue = { 12, 19, 15, 27, 24, 33, 31, 38, 42, 40, 47, 52 };
        public static readonly float[] Costs   = { 8, 11, 13, 14, 18, 20, 22, 25, 27, 26, 30, 34 };

        public static float[] Range(int n) => Enumerable.Range(0, n).Select(i => (float)i).ToArray();

        public static float[] Sine(int n, float amp = 1f, float phase = 0f) =>
            Enumerable.Range(0, n).Select(i => (float)(amp * Math.Sin(i * 0.4 + phase))).ToArray();

        // A cheap deterministic pseudo-random generator (Math.random is unavailable in transpiled code
        // at build time, and we want stable output anyway).
        public static float[] Noisy(int n, int seed, float scale = 10f)
        {
            var r = new float[n];
            var s = (uint)seed;
            for (int i = 0; i < n; i++)
            {
                s = s * 1664525u + 1013904223u;
                r[i] = (s >> 8) % 1000 / 1000f * scale;
            }
            return r;
        }

        // z = f(x, y) surface used by heatmap/contour/surface samples.
        public static float[][] Surface(int rows, int cols)
        {
            var z = new float[rows][];
            for (int y = 0; y < rows; y++)
            {
                z[y] = new float[cols];
                for (int x = 0; x < cols; x++)
                {
                    var dx = (x - cols / 2f) / 3f;
                    var dy = (y - rows / 2f) / 3f;
                    z[y][x] = (float)(Math.Sin(dx) * Math.Cos(dy) + 0.2 * (dx + dy));
                }
            }
            return z;
        }
    }
}
