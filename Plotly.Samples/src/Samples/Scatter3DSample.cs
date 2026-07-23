using System;
using System.Linq;
using Tesserae;
using Tesserae.Plotly;

namespace Plotly.Samples
{
    public sealed class Scatter3DSample : ISample
    {
        public string Group => "3D";
        public string Name  => "Scatter (3D)";

        public IComponent Content()
        {
            var n = 120;
            var t = Enumerable.Range(0, n).Select(i => i * 0.2f).ToArray();
            var x = t.Select(v => (float)Math.Cos(v)).ToArray();
            var y = t.Select(v => (float)Math.Sin(v)).ToArray();
            var z = t;

            var helix = new PlotlyChart(
                    Traces.scatter3d(
                        Scatter3d.x(x), Scatter3d.y(y), Scatter3d.z(z),
                        Scatter3d.mode(Scatter3d.Mode.lines(), Scatter3d.Mode.markers()),
                        Scatter3d.marker(Marker.size(3), Marker.color(z), Marker.colorscale("Portland"))))
                .Title("3D scatter / line (helix)");

            var cloud = new PlotlyChart(
                    Traces.scatter3d(
                        Scatter3d.x(Datasets.Noisy(150, 1, 10)),
                        Scatter3d.y(Datasets.Noisy(150, 2, 10)),
                        Scatter3d.z(Datasets.Noisy(150, 3, 10)),
                        Scatter3d.mode(Scatter3d.Mode.markers()),
                        Scatter3d.marker(Marker.size(4), Marker.opacity(0.7f))))
                .Title("3D point cloud");

            return SampleUI.Page(
                "Scatter (3D)",
                "3D scatter traces plot points (and optional connecting lines) in x/y/z space.",
                new Example("Helix", "A line + markers helix, colored along z.", helix, 460),
                new Example("Point cloud", "Markers only, semi-transparent.", cloud, 460));
        }
    }
}
