using Tesserae;
using Tesserae.Plotly;

namespace Plotly.Samples
{
    public sealed class SunburstSample : ISample
    {
        public string Group => "Specialized";
        public string Name  => "Sunburst";

        public IComponent Content()
        {
            var labels  = new[] { "Total", "Tech", "Finance", "Health", "Cloud", "Devices", "Banking", "Insurance", "Pharma", "Care" };
            var parents = new[] { "", "Total", "Total", "Total", "Tech", "Tech", "Finance", "Finance", "Health", "Health" };
            var values  = new float[] { 0, 40, 35, 25, 22, 18, 20, 15, 13, 12 };

            var sunburst = new PlotlyChart(
                    Traces.sunburst(Sunburst.labels(labels), Sunburst.parents(parents), Sunburst.values(values), Sunburst.Branchvalues.total()))
                .Title("Sunburst hierarchy");

            var treemap = new PlotlyChart(
                    Traces.treemap(Treemap.labels(labels), Treemap.parents(parents), Treemap.values(values), Treemap.Branchvalues.total()))
                .Title("Treemap of the same hierarchy");

            return SampleUI.Page(
                "Sunburst",
                "Hierarchical traces (sunburst and treemap) show nested parts of a whole from labels + parents + values.",
                new Example("Sunburst", "Radial hierarchy.", sunburst, 440),
                new Example("Treemap", "The same data as nested rectangles.", treemap, 440));
        }
    }
}
