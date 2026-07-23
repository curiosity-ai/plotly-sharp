using Tesserae;
using Tesserae.Plotly;

namespace Plotly.Samples
{
    public sealed class Surface3DSample : ISample
    {
        public string Group => "3D";
        public string Name  => "Surface (3D)";

        public IComponent Content()
        {
            var z = Datasets.Surface(30, 40);

            var surface = new PlotlyChart(
                    Traces.surface(Surface.z(z)))
                .Title("3D surface");

            var scaled = new PlotlyChart(
                    Traces.surface(Surface.z(z), Surface.colorscale("Viridis")))
                .Title("3D surface (Viridis)");

            return SampleUI.Page(
                "Surface (3D)",
                "Surface traces render a z-matrix as an interactive 3D surface — drag to rotate, scroll to zoom.",
                new Example("Default", "A rotatable 3D surface.", surface, 460),
                new Example("Viridis", "The same surface with a different color scale.", scaled, 460));
        }
    }
}
