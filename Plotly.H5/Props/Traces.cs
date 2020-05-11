namespace PlotlyH5
{
    /*////////////////////////////////
    /// THIS FILE IS AUTO-GENERATED //
    ///      by propsDocument       //
    ////////////////////////////////*/
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Types;
    using H5;
    using static Retyped.dom;

    public static partial class Traces
    {
        public static Box<ITracesProperty> scatter(params Box<IScatterProperty>[] properties) => Interop.mkTracesAttr("scatter", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkScatterAttr("type", "scatter")})));
        public static Box<ITracesProperty> bar(params Box<IBarProperty>[] properties) => Interop.mkTracesAttr("bar", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkBarAttr("type", "bar")})));
        public static Box<ITracesProperty> box(params Box<IBoxProperty>[] properties) => Interop.mkTracesAttr("box", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkBoxAttr("type", "box")})));
        public static Box<ITracesProperty> heatmap(params Box<IHeatmapProperty>[] properties) => Interop.mkTracesAttr("heatmap", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkHeatmapAttr("type", "heatmap")})));
        public static Box<ITracesProperty> histogram(params Box<IHistogramProperty>[] properties) => Interop.mkTracesAttr("histogram", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkHistogramAttr("type", "histogram")})));
        public static Box<ITracesProperty> histogram2d(params Box<IHistogram2dProperty>[] properties) => Interop.mkTracesAttr("histogram2d", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkHistogram2dAttr("type", "histogram2d")})));
        public static Box<ITracesProperty> histogram2dcontour(params Box<IHistogram2dcontourProperty>[] properties) => Interop.mkTracesAttr("histogram2dcontour", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkHistogram2dcontourAttr("type", "histogram2dcontour")})));
        public static Box<ITracesProperty> contour(params Box<IContourProperty>[] properties) => Interop.mkTracesAttr("contour", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkContourAttr("type", "contour")})));
        public static Box<ITracesProperty> scatterternary(params Box<IScatterternaryProperty>[] properties) => Interop.mkTracesAttr("scatterternary", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkScatterternaryAttr("type", "scatterternary")})));
        public static Box<ITracesProperty> violin(params Box<IViolinProperty>[] properties) => Interop.mkTracesAttr("violin", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkViolinAttr("type", "violin")})));
        public static Box<ITracesProperty> funnel(params Box<IFunnelProperty>[] properties) => Interop.mkTracesAttr("funnel", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkFunnelAttr("type", "funnel")})));
        public static Box<ITracesProperty> waterfall(params Box<IWaterfallProperty>[] properties) => Interop.mkTracesAttr("waterfall", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkWaterfallAttr("type", "waterfall")})));
        public static Box<ITracesProperty> image(params Box<IImageProperty>[] properties) => Interop.mkTracesAttr("image", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkImageAttr("type", "image")})));
        public static Box<ITracesProperty> pie(params Box<IPieProperty>[] properties) => Interop.mkTracesAttr("pie", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkPieAttr("type", "pie")})));
        public static Box<ITracesProperty> sunburst(params Box<ISunburstProperty>[] properties) => Interop.mkTracesAttr("sunburst", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkSunburstAttr("type", "sunburst")})));
        public static Box<ITracesProperty> treemap(params Box<ITreemapProperty>[] properties) => Interop.mkTracesAttr("treemap", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkTreemapAttr("type", "treemap")})));
        public static Box<ITracesProperty> funnelarea(params Box<IFunnelareaProperty>[] properties) => Interop.mkTracesAttr("funnelarea", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkFunnelareaAttr("type", "funnelarea")})));
        public static Box<ITracesProperty> scatter3d(params Box<IScatter3dProperty>[] properties) => Interop.mkTracesAttr("scatter3d", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkScatter3dAttr("type", "scatter3d")})));
        public static Box<ITracesProperty> surface(params Box<ISurfaceProperty>[] properties) => Interop.mkTracesAttr("surface", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkSurfaceAttr("type", "surface")})));
        public static Box<ITracesProperty> isosurface(params Box<IIsosurfaceProperty>[] properties) => Interop.mkTracesAttr("isosurface", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkIsosurfaceAttr("type", "isosurface")})));
        public static Box<ITracesProperty> volume(params Box<IVolumeProperty>[] properties) => Interop.mkTracesAttr("volume", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkVolumeAttr("type", "volume")})));
        public static Box<ITracesProperty> mesh3d(params Box<IMesh3dProperty>[] properties) => Interop.mkTracesAttr("mesh3d", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkMesh3dAttr("type", "mesh3d")})));
        public static Box<ITracesProperty> cone(params Box<IConeProperty>[] properties) => Interop.mkTracesAttr("cone", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkConeAttr("type", "cone")})));
        public static Box<ITracesProperty> streamtube(params Box<IStreamtubeProperty>[] properties) => Interop.mkTracesAttr("streamtube", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkStreamtubeAttr("type", "streamtube")})));
        public static Box<ITracesProperty> scattergeo(params Box<IScattergeoProperty>[] properties) => Interop.mkTracesAttr("scattergeo", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkScattergeoAttr("type", "scattergeo")})));
        public static Box<ITracesProperty> choropleth(params Box<IChoroplethProperty>[] properties) => Interop.mkTracesAttr("choropleth", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkChoroplethAttr("type", "choropleth")})));
        public static Box<ITracesProperty> scattergl(params Box<IScatterglProperty>[] properties) => Interop.mkTracesAttr("scattergl", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkScatterglAttr("type", "scattergl")})));
        public static Box<ITracesProperty> splom(params Box<ISplomProperty>[] properties) => Interop.mkTracesAttr("splom", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkSplomAttr("type", "splom")})));
        public static Box<ITracesProperty> pointcloud(params Box<IPointcloudProperty>[] properties) => Interop.mkTracesAttr("pointcloud", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkPointcloudAttr("type", "pointcloud")})));
        public static Box<ITracesProperty> heatmapgl(params Box<IHeatmapglProperty>[] properties) => Interop.mkTracesAttr("heatmapgl", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkHeatmapglAttr("type", "heatmapgl")})));
        public static Box<ITracesProperty> parcoords(params Box<IParcoordsProperty>[] properties) => Interop.mkTracesAttr("parcoords", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkParcoordsAttr("type", "parcoords")})));
        public static Box<ITracesProperty> parcats(params Box<IParcatsProperty>[] properties) => Interop.mkTracesAttr("parcats", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkParcatsAttr("type", "parcats")})));
        public static Box<ITracesProperty> scattermapbox(params Box<IScattermapboxProperty>[] properties) => Interop.mkTracesAttr("scattermapbox", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkScattermapboxAttr("type", "scattermapbox")})));
        public static Box<ITracesProperty> choroplethmapbox(params Box<IChoroplethmapboxProperty>[] properties) => Interop.mkTracesAttr("choroplethmapbox", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkChoroplethmapboxAttr("type", "choroplethmapbox")})));
        public static Box<ITracesProperty> densitymapbox(params Box<IDensitymapboxProperty>[] properties) => Interop.mkTracesAttr("densitymapbox", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkDensitymapboxAttr("type", "densitymapbox")})));
        public static Box<ITracesProperty> sankey(params Box<ISankeyProperty>[] properties) => Interop.mkTracesAttr("sankey", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkSankeyAttr("type", "sankey")})));
        public static Box<ITracesProperty> indicator(params Box<IIndicatorProperty>[] properties) => Interop.mkTracesAttr("indicator", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkIndicatorAttr("type", "indicator")})));
        public static Box<ITracesProperty> table(params Box<ITableProperty>[] properties) => Interop.mkTracesAttr("table", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkTableAttr("type", "table")})));
        public static Box<ITracesProperty> carpet(params Box<ICarpetProperty>[] properties) => Interop.mkTracesAttr("carpet", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkCarpetAttr("type", "carpet")})));
        public static Box<ITracesProperty> scattercarpet(params Box<IScattercarpetProperty>[] properties) => Interop.mkTracesAttr("scattercarpet", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkScattercarpetAttr("type", "scattercarpet")})));
        public static Box<ITracesProperty> contourcarpet(params Box<IContourcarpetProperty>[] properties) => Interop.mkTracesAttr("contourcarpet", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkContourcarpetAttr("type", "contourcarpet")})));
        public static Box<ITracesProperty> ohlc(params Box<IOhlcProperty>[] properties) => Interop.mkTracesAttr("ohlc", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkOhlcAttr("type", "ohlc")})));
        public static Box<ITracesProperty> candlestick(params Box<ICandlestickProperty>[] properties) => Interop.mkTracesAttr("candlestick", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkCandlestickAttr("type", "candlestick")})));
        public static Box<ITracesProperty> scatterpolar(params Box<IScatterpolarProperty>[] properties) => Interop.mkTracesAttr("scatterpolar", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkScatterpolarAttr("type", "scatterpolar")})));
        public static Box<ITracesProperty> scatterpolargl(params Box<IScatterpolarglProperty>[] properties) => Interop.mkTracesAttr("scatterpolargl", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkScatterpolarglAttr("type", "scatterpolargl")})));
        public static Box<ITracesProperty> barpolar(params Box<IBarpolarProperty>[] properties) => Interop.mkTracesAttr("barpolar", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkBarpolarAttr("type", "barpolar")})));
        public static Box<ITracesProperty> area(params Box<IAreaProperty>[] properties) => Interop.mkTracesAttr("area", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkAreaAttr("type", "area")})));
    }
}