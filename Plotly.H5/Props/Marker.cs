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

    public static partial class Marker
    {
        /// Sets the marker symbol type. Adding 100 is equivalent to appending *-open* to a symbol name. Adding 200 is equivalent to appending *-dot* to a symbol name. Adding 300 is equivalent to appending *-open-dot* or *dot-open* to a symbol name.
        public static Box<IMarkerProperty> symbol(IEnumerable<Box<IMarkerProperty>> properties) => Interop.mkMarkerAttr("symbol", Bindings.flattenProperties(properties));
        /// Sets the marker opacity.
        public static Box<IMarkerProperty> opacity(int val) => Interop.mkMarkerAttr("opacity", val);
        /// Sets the marker opacity.
        public static Box<IMarkerProperty> opacity(float val) => Interop.mkMarkerAttr("opacity", val);
        /// Sets the marker opacity.
        public static Box<IMarkerProperty> opacity(IEnumerable<int> values) => Interop.mkMarkerAttr("opacity", values.ToArray());
        /// Sets the marker opacity.
        public static Box<IMarkerProperty> opacity(IEnumerable<float> values) => Interop.mkMarkerAttr("opacity", values.ToArray());
        /// Sets the marker size (in px).
        public static Box<IMarkerProperty> size(int val) => Interop.mkMarkerAttr("size", val);
        /// Sets the marker size (in px).
        public static Box<IMarkerProperty> size(float val) => Interop.mkMarkerAttr("size", val);
        /// Sets the marker size (in px).
        public static Box<IMarkerProperty> size(IEnumerable<int> values) => Interop.mkMarkerAttr("size", values.ToArray());
        /// Sets the marker size (in px).
        public static Box<IMarkerProperty> size(IEnumerable<float> values) => Interop.mkMarkerAttr("size", values.ToArray());
        /// Sets a maximum number of points to be drawn on the graph. *0* corresponds to no limit.
        public static Box<IMarkerProperty> maxdisplayed(int val) => Interop.mkMarkerAttr("maxdisplayed", val);
        /// Sets a maximum number of points to be drawn on the graph. *0* corresponds to no limit.
        public static Box<IMarkerProperty> maxdisplayed(float val) => Interop.mkMarkerAttr("maxdisplayed", val);
        /// Has an effect only if `marker.size` is set to a numerical array. Sets the scale factor used to determine the rendered size of marker points. Use with `sizemin` and `sizemode`.
        public static Box<IMarkerProperty> sizeref(int val) => Interop.mkMarkerAttr("sizeref", val);
        /// Has an effect only if `marker.size` is set to a numerical array. Sets the scale factor used to determine the rendered size of marker points. Use with `sizemin` and `sizemode`.
        public static Box<IMarkerProperty> sizeref(float val) => Interop.mkMarkerAttr("sizeref", val);
        /// Has an effect only if `marker.size` is set to a numerical array. Sets the minimum size (in px) of the rendered marker points.
        public static Box<IMarkerProperty> sizemin(int val) => Interop.mkMarkerAttr("sizemin", val);
        /// Has an effect only if `marker.size` is set to a numerical array. Sets the minimum size (in px) of the rendered marker points.
        public static Box<IMarkerProperty> sizemin(float val) => Interop.mkMarkerAttr("sizemin", val);
        public static Box<IMarkerProperty> line(params Box<ILineProperty>[] properties) => Interop.mkMarkerAttr("line", Bindings.flattenProperties(properties));
        public static Box<IMarkerProperty> gradient(params Box<IGradientProperty>[] properties) => Interop.mkMarkerAttr("gradient", Bindings.flattenProperties(properties));
        /// Sets themarkercolor. It accepts either a specific color or an array of numbers that are mapped to the colorscale relative to the max and min values of the array or relative to `marker.cmin` and `marker.cmax` if set.
        public static Box<IMarkerProperty> color(string val) => Interop.mkMarkerAttr("color", val);
        /// Sets themarkercolor. It accepts either a specific color or an array of numbers that are mapped to the colorscale relative to the max and min values of the array or relative to `marker.cmin` and `marker.cmax` if set.
        public static Box<IMarkerProperty> color(params string[] values) => Interop.mkMarkerAttr("color", values);
        /// Sets themarkercolor. It accepts either a specific color or an array of numbers that are mapped to the colorscale relative to the max and min values of the array or relative to `marker.cmin` and `marker.cmax` if set.
        public static Box<IMarkerProperty> color(int val) => Interop.mkMarkerAttr("color", new[]{val});
        /// Sets themarkercolor. It accepts either a specific color or an array of numbers that are mapped to the colorscale relative to the max and min values of the array or relative to `marker.cmin` and `marker.cmax` if set.
        public static Box<IMarkerProperty> color(params int[] values) => Interop.mkMarkerAttr("color", values);
        /// Sets themarkercolor. It accepts either a specific color or an array of numbers that are mapped to the colorscale relative to the max and min values of the array or relative to `marker.cmin` and `marker.cmax` if set.
        public static Box<IMarkerProperty> color(float val) => Interop.mkMarkerAttr("color", new[]{val});
        /// Sets themarkercolor. It accepts either a specific color or an array of numbers that are mapped to the colorscale relative to the max and min values of the array or relative to `marker.cmin` and `marker.cmax` if set.
        public static Box<IMarkerProperty> color(params float[] values) => Interop.mkMarkerAttr("color", values);
        /// Determines whether or not the color domain is computed with respect to the input data (here in `marker.color`) or the bounds set in `marker.cmin` and `marker.cmax`  Has an effect only if in `marker.color`is set to a numerical array. Defaults to `false` when `marker.cmin` and `marker.cmax` are set by the user.
        public static Box<IMarkerProperty> cauto(bool val) => Interop.mkMarkerAttr("cauto", val);
        /// Sets the lower bound of the color domain. Has an effect only if in `marker.color`is set to a numerical array. Value should have the same units as in `marker.color` and if set, `marker.cmax` must be set as well.
        public static Box<IMarkerProperty> cmin(int val) => Interop.mkMarkerAttr("cmin", val);
        /// Sets the lower bound of the color domain. Has an effect only if in `marker.color`is set to a numerical array. Value should have the same units as in `marker.color` and if set, `marker.cmax` must be set as well.
        public static Box<IMarkerProperty> cmin(float val) => Interop.mkMarkerAttr("cmin", val);
        /// Sets the upper bound of the color domain. Has an effect only if in `marker.color`is set to a numerical array. Value should have the same units as in `marker.color` and if set, `marker.cmin` must be set as well.
        public static Box<IMarkerProperty> cmax(int val) => Interop.mkMarkerAttr("cmax", val);
        /// Sets the upper bound of the color domain. Has an effect only if in `marker.color`is set to a numerical array. Value should have the same units as in `marker.color` and if set, `marker.cmin` must be set as well.
        public static Box<IMarkerProperty> cmax(float val) => Interop.mkMarkerAttr("cmax", val);
        /// Sets the mid-point of the color domain by scaling `marker.cmin` and/or `marker.cmax` to be equidistant to this point. Has an effect only if in `marker.color`is set to a numerical array. Value should have the same units as in `marker.color`. Has no effect when `marker.cauto` is `false`.
        public static Box<IMarkerProperty> cmid(int val) => Interop.mkMarkerAttr("cmid", val);
        /// Sets the mid-point of the color domain by scaling `marker.cmin` and/or `marker.cmax` to be equidistant to this point. Has an effect only if in `marker.color`is set to a numerical array. Value should have the same units as in `marker.color`. Has no effect when `marker.cauto` is `false`.
        public static Box<IMarkerProperty> cmid(float val) => Interop.mkMarkerAttr("cmid", val);
        /// Sets the colorscale. Has an effect only if in `marker.color`is set to a numerical array. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`marker.cmin` and `marker.cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IMarkerProperty> colorscale(string val) => Interop.mkMarkerAttr("colorscale", val);
        /// Sets the colorscale. Has an effect only if in `marker.color`is set to a numerical array. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`marker.cmin` and `marker.cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IMarkerProperty> colorscale(List<string[]> values) => Interop.mkMarkerAttr("colorscale", Bindings.flatten2DArrayIf1D(values));
        /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `marker.colorscale`. Has an effect only if in `marker.color`is set to a numerical array. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
        public static Box<IMarkerProperty> autocolorscale(bool val) => Interop.mkMarkerAttr("autocolorscale", val);
        /// Reverses the color mapping if true. Has an effect only if in `marker.color`is set to a numerical array. If true, `marker.cmin` will correspond to the last color in the array and `marker.cmax` will correspond to the first color.
        public static Box<IMarkerProperty> reversescale(bool val) => Interop.mkMarkerAttr("reversescale", val);
        /// Determines whether or not a colorbar is displayed for this trace. Has an effect only if in `marker.color`is set to a numerical array.
        public static Box<IMarkerProperty> showscale(bool val) => Interop.mkMarkerAttr("showscale", val);
        public static Box<IMarkerProperty> colorbar(params Box<IColorbarProperty>[] properties) => Interop.mkMarkerAttr("colorbar", Bindings.flattenProperties(properties));
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<IMarkerProperty> coloraxis(int anchorId) => Interop.mkMarkerAttr("coloraxis", anchorId > 1 ? $"coloraxis{anchorId}" : "");
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<IMarkerProperty> coloraxis(string val) => Interop.mkMarkerAttr("coloraxis", val);
        /// Sets the source reference on plot.ly for  symbol .
        public static Box<IMarkerProperty> symbolsrc(string val) => Interop.mkMarkerAttr("symbolsrc", val);
        /// Sets the source reference on plot.ly for  opacity .
        public static Box<IMarkerProperty> opacitysrc(string val) => Interop.mkMarkerAttr("opacitysrc", val);
        /// Sets the source reference on plot.ly for  size .
        public static Box<IMarkerProperty> sizesrc(string val) => Interop.mkMarkerAttr("sizesrc", val);
        /// Sets the source reference on plot.ly for  color .
        public static Box<IMarkerProperty> colorsrc(string val) => Interop.mkMarkerAttr("colorsrc", val);
        /// Sets the color of the outlier sample points.
        public static Box<IMarkerProperty> outliercolor(string val) => Interop.mkMarkerAttr("outliercolor", val);
        /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
        public static Box<IMarkerProperty> colors(bool val) => Interop.mkMarkerAttr("colors", new[]{val});
        /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
        public static Box<IMarkerProperty> colors(params bool[] values) => Interop.mkMarkerAttr("colors", values);
        /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
        public static Box<IMarkerProperty> colors(System.DateTime val) => Interop.mkMarkerAttr("colors", new[]{val});
        /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
        public static Box<IMarkerProperty> colors(params System.DateTime[] values) => Interop.mkMarkerAttr("colors", values);
        /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
        public static Box<IMarkerProperty> colors(float val) => Interop.mkMarkerAttr("colors", new[]{val});
        /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
        public static Box<IMarkerProperty> colors(params float[] values) => Interop.mkMarkerAttr("colors", values);
        /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
        public static Box<IMarkerProperty> colors(int val) => Interop.mkMarkerAttr("colors", new[]{val});
        /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
        public static Box<IMarkerProperty> colors(params int[] values) => Interop.mkMarkerAttr("colors", values);
        /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
        public static Box<IMarkerProperty> colors(string val) => Interop.mkMarkerAttr("colors", new[]{val});
        /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
        public static Box<IMarkerProperty> colors(params string[] values) => Interop.mkMarkerAttr("colors", values);
        /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
        public static Box<IMarkerProperty> colors(IEnumerable<bool[]> values) => Interop.mkMarkerAttr("colors", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
        public static Box<IMarkerProperty> colors(List<bool[]> values) => Interop.mkMarkerAttr("colors", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
        public static Box<IMarkerProperty> colors(params bool[][] values) => Interop.mkMarkerAttr("colors", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
        public static Box<IMarkerProperty> colors(IEnumerable<IEnumerable<string>> values) => Interop.mkMarkerAttr("colors", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
        public static Box<IMarkerProperty> colors(List<string[]> values) => Interop.mkMarkerAttr("colors", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
        public static Box<IMarkerProperty> colors(params string[][] values) => Interop.mkMarkerAttr("colors", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
        public static Box<IMarkerProperty> colors(IEnumerable<IEnumerable<int>> values) => Interop.mkMarkerAttr("colors", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
        public static Box<IMarkerProperty> colors(List<int[]> values) => Interop.mkMarkerAttr("colors", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
        public static Box<IMarkerProperty> colors(params int[][] values) => Interop.mkMarkerAttr("colors", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
        public static Box<IMarkerProperty> colors(IEnumerable<IEnumerable<float>> values) => Interop.mkMarkerAttr("colors", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
        public static Box<IMarkerProperty> colors(List<float[]> values) => Interop.mkMarkerAttr("colors", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
        public static Box<IMarkerProperty> colors(params float[][] values) => Interop.mkMarkerAttr("colors", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
        public static Box<IMarkerProperty> colors(Literals.PlotData[] values) => Interop.mkMarkerAttr("colors", values);
        /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
        public static Box<IMarkerProperty> colors(IEnumerable<bool?> values) => Interop.mkMarkerAttr("colors", values.ToArray());
        /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
        public static Box<IMarkerProperty> colors(IEnumerable<System.DateTime?> values) => Interop.mkMarkerAttr("colors", values.ToArray());
        /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
        public static Box<IMarkerProperty> colors(IEnumerable<int?> values) => Interop.mkMarkerAttr("colors", values.ToArray());
        /// Sets the color of each sector. If not specified, the default trace color set is used to pick the sector colors.
        public static Box<IMarkerProperty> colors(IEnumerable<float?> values) => Interop.mkMarkerAttr("colors", values.ToArray());
        /// Sets the source reference on plot.ly for  colors .
        public static Box<IMarkerProperty> colorssrc(string val) => Interop.mkMarkerAttr("colorssrc", val);
        public static Box<IMarkerProperty> pad(params Box<IPadProperty>[] properties) => Interop.mkMarkerAttr("pad", Bindings.flattenProperties(properties));
        /// Determines if colors are blended together for a translucency effect in case `opacity` is specified as a value less then `1`. Setting `blend` to `true` reduces zoom/pan speed if used with large numbers of points.
        public static Box<IMarkerProperty> blend(bool val) => Interop.mkMarkerAttr("blend", val);
        /// Sets the maximum size (in px) of the rendered marker points. Effective when the `pointcloud` shows only few points.
        public static Box<IMarkerProperty> sizemax(int val) => Interop.mkMarkerAttr("sizemax", val);
        /// Sets the maximum size (in px) of the rendered marker points. Effective when the `pointcloud` shows only few points.
        public static Box<IMarkerProperty> sizemax(float val) => Interop.mkMarkerAttr("sizemax", val);
        public static Box<IMarkerProperty> border(params Box<IBorderProperty>[] properties) => Interop.mkMarkerAttr("border", Bindings.flattenProperties(properties));
    }

    public static partial class Marker
    {
        /// Sets the marker symbol type. Adding 100 is equivalent to appending *-open* to a symbol name. Adding 200 is equivalent to appending *-dot* to a symbol name. Adding 300 is equivalent to appending *-open-dot* or *dot-open* to a symbol name.
        public static partial class Symbol
        {
            public static Box<IMarkerProperty> asterisk() => Interop.mkMarkerAttr("symbol", "asterisk");
            public static Box<IMarkerProperty> asteriskOpen() => Interop.mkMarkerAttr("symbol", "asterisk-open");
            public static Box<IMarkerProperty> bowtie() => Interop.mkMarkerAttr("symbol", "bowtie");
            public static Box<IMarkerProperty> bowtieOpen() => Interop.mkMarkerAttr("symbol", "bowtie-open");
            public static Box<IMarkerProperty> circle() => Interop.mkMarkerAttr("symbol", "circle");
            public static Box<IMarkerProperty> circleCross() => Interop.mkMarkerAttr("symbol", "circle-cross");
            public static Box<IMarkerProperty> circleCrossOpen() => Interop.mkMarkerAttr("symbol", "circle-cross-open");
            public static Box<IMarkerProperty> circleDot() => Interop.mkMarkerAttr("symbol", "circle-dot");
            public static Box<IMarkerProperty> circleOpen() => Interop.mkMarkerAttr("symbol", "circle-open");
            public static Box<IMarkerProperty> circleOpenDot() => Interop.mkMarkerAttr("symbol", "circle-open-dot");
            public static Box<IMarkerProperty> circleX() => Interop.mkMarkerAttr("symbol", "circle-x");
            public static Box<IMarkerProperty> circleXOpen() => Interop.mkMarkerAttr("symbol", "circle-x-open");
            public static Box<IMarkerProperty> cross() => Interop.mkMarkerAttr("symbol", "cross");
            public static Box<IMarkerProperty> crossDot() => Interop.mkMarkerAttr("symbol", "cross-dot");
            public static Box<IMarkerProperty> crossOpen() => Interop.mkMarkerAttr("symbol", "cross-open");
            public static Box<IMarkerProperty> crossOpenDot() => Interop.mkMarkerAttr("symbol", "cross-open-dot");
            public static Box<IMarkerProperty> crossThin() => Interop.mkMarkerAttr("symbol", "cross-thin");
            public static Box<IMarkerProperty> crossThinOpen() => Interop.mkMarkerAttr("symbol", "cross-thin-open");
            public static Box<IMarkerProperty> diamond() => Interop.mkMarkerAttr("symbol", "diamond");
            public static Box<IMarkerProperty> diamondCross() => Interop.mkMarkerAttr("symbol", "diamond-cross");
            public static Box<IMarkerProperty> diamondCrossOpen() => Interop.mkMarkerAttr("symbol", "diamond-cross-open");
            public static Box<IMarkerProperty> diamondDot() => Interop.mkMarkerAttr("symbol", "diamond-dot");
            public static Box<IMarkerProperty> diamondOpen() => Interop.mkMarkerAttr("symbol", "diamond-open");
            public static Box<IMarkerProperty> diamondOpenDot() => Interop.mkMarkerAttr("symbol", "diamond-open-dot");
            public static Box<IMarkerProperty> diamondTall() => Interop.mkMarkerAttr("symbol", "diamond-tall");
            public static Box<IMarkerProperty> diamondTallDot() => Interop.mkMarkerAttr("symbol", "diamond-tall-dot");
            public static Box<IMarkerProperty> diamondTallOpen() => Interop.mkMarkerAttr("symbol", "diamond-tall-open");
            public static Box<IMarkerProperty> diamondTallOpenDot() => Interop.mkMarkerAttr("symbol", "diamond-tall-open-dot");
            public static Box<IMarkerProperty> diamondWide() => Interop.mkMarkerAttr("symbol", "diamond-wide");
            public static Box<IMarkerProperty> diamondWideDot() => Interop.mkMarkerAttr("symbol", "diamond-wide-dot");
            public static Box<IMarkerProperty> diamondWideOpen() => Interop.mkMarkerAttr("symbol", "diamond-wide-open");
            public static Box<IMarkerProperty> diamondWideOpenDot() => Interop.mkMarkerAttr("symbol", "diamond-wide-open-dot");
            public static Box<IMarkerProperty> diamondX() => Interop.mkMarkerAttr("symbol", "diamond-x");
            public static Box<IMarkerProperty> diamondXOpen() => Interop.mkMarkerAttr("symbol", "diamond-x-open");
            public static Box<IMarkerProperty> hash() => Interop.mkMarkerAttr("symbol", "hash");
            public static Box<IMarkerProperty> hashDot() => Interop.mkMarkerAttr("symbol", "hash-dot");
            public static Box<IMarkerProperty> hashOpen() => Interop.mkMarkerAttr("symbol", "hash-open");
            public static Box<IMarkerProperty> hashOpenDot() => Interop.mkMarkerAttr("symbol", "hash-open-dot");
            public static Box<IMarkerProperty> hexagon() => Interop.mkMarkerAttr("symbol", "hexagon");
            public static Box<IMarkerProperty> hexagonDot() => Interop.mkMarkerAttr("symbol", "hexagon-dot");
            public static Box<IMarkerProperty> hexagonOpen() => Interop.mkMarkerAttr("symbol", "hexagon-open");
            public static Box<IMarkerProperty> hexagonOpenDot() => Interop.mkMarkerAttr("symbol", "hexagon-open-dot");
            public static Box<IMarkerProperty> hexagon2() => Interop.mkMarkerAttr("symbol", "hexagon2");
            public static Box<IMarkerProperty> hexagon2Dot() => Interop.mkMarkerAttr("symbol", "hexagon2-dot");
            public static Box<IMarkerProperty> hexagon2Open() => Interop.mkMarkerAttr("symbol", "hexagon2-open");
            public static Box<IMarkerProperty> hexagon2OpenDot() => Interop.mkMarkerAttr("symbol", "hexagon2-open-dot");
            public static Box<IMarkerProperty> hexagram() => Interop.mkMarkerAttr("symbol", "hexagram");
            public static Box<IMarkerProperty> hexagramDot() => Interop.mkMarkerAttr("symbol", "hexagram-dot");
            public static Box<IMarkerProperty> hexagramOpen() => Interop.mkMarkerAttr("symbol", "hexagram-open");
            public static Box<IMarkerProperty> hexagramOpenDot() => Interop.mkMarkerAttr("symbol", "hexagram-open-dot");
            public static Box<IMarkerProperty> hourglass() => Interop.mkMarkerAttr("symbol", "hourglass");
            public static Box<IMarkerProperty> hourglassOpen() => Interop.mkMarkerAttr("symbol", "hourglass-open");
            public static Box<IMarkerProperty> lineEw() => Interop.mkMarkerAttr("symbol", "line-ew");
            public static Box<IMarkerProperty> lineEwOpen() => Interop.mkMarkerAttr("symbol", "line-ew-open");
            public static Box<IMarkerProperty> lineNe() => Interop.mkMarkerAttr("symbol", "line-ne");
            public static Box<IMarkerProperty> lineNeOpen() => Interop.mkMarkerAttr("symbol", "line-ne-open");
            public static Box<IMarkerProperty> lineNs() => Interop.mkMarkerAttr("symbol", "line-ns");
            public static Box<IMarkerProperty> lineNsOpen() => Interop.mkMarkerAttr("symbol", "line-ns-open");
            public static Box<IMarkerProperty> lineNw() => Interop.mkMarkerAttr("symbol", "line-nw");
            public static Box<IMarkerProperty> lineNwOpen() => Interop.mkMarkerAttr("symbol", "line-nw-open");
            public static Box<IMarkerProperty> octagon() => Interop.mkMarkerAttr("symbol", "octagon");
            public static Box<IMarkerProperty> octagonDot() => Interop.mkMarkerAttr("symbol", "octagon-dot");
            public static Box<IMarkerProperty> octagonOpen() => Interop.mkMarkerAttr("symbol", "octagon-open");
            public static Box<IMarkerProperty> octagonOpenDot() => Interop.mkMarkerAttr("symbol", "octagon-open-dot");
            public static Box<IMarkerProperty> pentagon() => Interop.mkMarkerAttr("symbol", "pentagon");
            public static Box<IMarkerProperty> pentagonDot() => Interop.mkMarkerAttr("symbol", "pentagon-dot");
            public static Box<IMarkerProperty> pentagonOpen() => Interop.mkMarkerAttr("symbol", "pentagon-open");
            public static Box<IMarkerProperty> pentagonOpenDot() => Interop.mkMarkerAttr("symbol", "pentagon-open-dot");
            public static Box<IMarkerProperty> square() => Interop.mkMarkerAttr("symbol", "square");
            public static Box<IMarkerProperty> squareCross() => Interop.mkMarkerAttr("symbol", "square-cross");
            public static Box<IMarkerProperty> squareCrossOpen() => Interop.mkMarkerAttr("symbol", "square-cross-open");
            public static Box<IMarkerProperty> squareDot() => Interop.mkMarkerAttr("symbol", "square-dot");
            public static Box<IMarkerProperty> squareOpen() => Interop.mkMarkerAttr("symbol", "square-open");
            public static Box<IMarkerProperty> squareOpenDot() => Interop.mkMarkerAttr("symbol", "square-open-dot");
            public static Box<IMarkerProperty> squareX() => Interop.mkMarkerAttr("symbol", "square-x");
            public static Box<IMarkerProperty> squareXOpen() => Interop.mkMarkerAttr("symbol", "square-x-open");
            public static Box<IMarkerProperty> star() => Interop.mkMarkerAttr("symbol", "star");
            public static Box<IMarkerProperty> starDiamond() => Interop.mkMarkerAttr("symbol", "star-diamond");
            public static Box<IMarkerProperty> starDiamondDot() => Interop.mkMarkerAttr("symbol", "star-diamond-dot");
            public static Box<IMarkerProperty> starDiamondOpen() => Interop.mkMarkerAttr("symbol", "star-diamond-open");
            public static Box<IMarkerProperty> starDiamondOpenDot() => Interop.mkMarkerAttr("symbol", "star-diamond-open-dot");
            public static Box<IMarkerProperty> starDot() => Interop.mkMarkerAttr("symbol", "star-dot");
            public static Box<IMarkerProperty> starOpen() => Interop.mkMarkerAttr("symbol", "star-open");
            public static Box<IMarkerProperty> starOpenDot() => Interop.mkMarkerAttr("symbol", "star-open-dot");
            public static Box<IMarkerProperty> starSquare() => Interop.mkMarkerAttr("symbol", "star-square");
            public static Box<IMarkerProperty> starSquareDot() => Interop.mkMarkerAttr("symbol", "star-square-dot");
            public static Box<IMarkerProperty> starSquareOpen() => Interop.mkMarkerAttr("symbol", "star-square-open");
            public static Box<IMarkerProperty> starSquareOpenDot() => Interop.mkMarkerAttr("symbol", "star-square-open-dot");
            public static Box<IMarkerProperty> starTriangleDown() => Interop.mkMarkerAttr("symbol", "star-triangle-down");
            public static Box<IMarkerProperty> starTriangleDownDot() => Interop.mkMarkerAttr("symbol", "star-triangle-down-dot");
            public static Box<IMarkerProperty> starTriangleDownOpen() => Interop.mkMarkerAttr("symbol", "star-triangle-down-open");
            public static Box<IMarkerProperty> starTriangleDownOpenDot() => Interop.mkMarkerAttr("symbol", "star-triangle-down-open-dot");
            public static Box<IMarkerProperty> starTriangleUp() => Interop.mkMarkerAttr("symbol", "star-triangle-up");
            public static Box<IMarkerProperty> starTriangleUpDot() => Interop.mkMarkerAttr("symbol", "star-triangle-up-dot");
            public static Box<IMarkerProperty> starTriangleUpOpen() => Interop.mkMarkerAttr("symbol", "star-triangle-up-open");
            public static Box<IMarkerProperty> starTriangleUpOpenDot() => Interop.mkMarkerAttr("symbol", "star-triangle-up-open-dot");
            public static Box<IMarkerProperty> triangleDown() => Interop.mkMarkerAttr("symbol", "triangle-down");
            public static Box<IMarkerProperty> triangleDownDot() => Interop.mkMarkerAttr("symbol", "triangle-down-dot");
            public static Box<IMarkerProperty> triangleDownOpen() => Interop.mkMarkerAttr("symbol", "triangle-down-open");
            public static Box<IMarkerProperty> triangleDownOpenDot() => Interop.mkMarkerAttr("symbol", "triangle-down-open-dot");
            public static Box<IMarkerProperty> triangleLeft() => Interop.mkMarkerAttr("symbol", "triangle-left");
            public static Box<IMarkerProperty> triangleLeftDot() => Interop.mkMarkerAttr("symbol", "triangle-left-dot");
            public static Box<IMarkerProperty> triangleLeftOpen() => Interop.mkMarkerAttr("symbol", "triangle-left-open");
            public static Box<IMarkerProperty> triangleLeftOpenDot() => Interop.mkMarkerAttr("symbol", "triangle-left-open-dot");
            public static Box<IMarkerProperty> triangleNe() => Interop.mkMarkerAttr("symbol", "triangle-ne");
            public static Box<IMarkerProperty> triangleNeDot() => Interop.mkMarkerAttr("symbol", "triangle-ne-dot");
            public static Box<IMarkerProperty> triangleNeOpen() => Interop.mkMarkerAttr("symbol", "triangle-ne-open");
            public static Box<IMarkerProperty> triangleNeOpenDot() => Interop.mkMarkerAttr("symbol", "triangle-ne-open-dot");
            public static Box<IMarkerProperty> triangleNw() => Interop.mkMarkerAttr("symbol", "triangle-nw");
            public static Box<IMarkerProperty> triangleNwDot() => Interop.mkMarkerAttr("symbol", "triangle-nw-dot");
            public static Box<IMarkerProperty> triangleNwOpen() => Interop.mkMarkerAttr("symbol", "triangle-nw-open");
            public static Box<IMarkerProperty> triangleNwOpenDot() => Interop.mkMarkerAttr("symbol", "triangle-nw-open-dot");
            public static Box<IMarkerProperty> triangleRight() => Interop.mkMarkerAttr("symbol", "triangle-right");
            public static Box<IMarkerProperty> triangleRightDot() => Interop.mkMarkerAttr("symbol", "triangle-right-dot");
            public static Box<IMarkerProperty> triangleRightOpen() => Interop.mkMarkerAttr("symbol", "triangle-right-open");
            public static Box<IMarkerProperty> triangleRightOpenDot() => Interop.mkMarkerAttr("symbol", "triangle-right-open-dot");
            public static Box<IMarkerProperty> triangleSe() => Interop.mkMarkerAttr("symbol", "triangle-se");
            public static Box<IMarkerProperty> triangleSeDot() => Interop.mkMarkerAttr("symbol", "triangle-se-dot");
            public static Box<IMarkerProperty> triangleSeOpen() => Interop.mkMarkerAttr("symbol", "triangle-se-open");
            public static Box<IMarkerProperty> triangleSeOpenDot() => Interop.mkMarkerAttr("symbol", "triangle-se-open-dot");
            public static Box<IMarkerProperty> triangleSw() => Interop.mkMarkerAttr("symbol", "triangle-sw");
            public static Box<IMarkerProperty> triangleSwDot() => Interop.mkMarkerAttr("symbol", "triangle-sw-dot");
            public static Box<IMarkerProperty> triangleSwOpen() => Interop.mkMarkerAttr("symbol", "triangle-sw-open");
            public static Box<IMarkerProperty> triangleSwOpenDot() => Interop.mkMarkerAttr("symbol", "triangle-sw-open-dot");
            public static Box<IMarkerProperty> triangleUp() => Interop.mkMarkerAttr("symbol", "triangle-up");
            public static Box<IMarkerProperty> triangleUpDot() => Interop.mkMarkerAttr("symbol", "triangle-up-dot");
            public static Box<IMarkerProperty> triangleUpOpen() => Interop.mkMarkerAttr("symbol", "triangle-up-open");
            public static Box<IMarkerProperty> triangleUpOpenDot() => Interop.mkMarkerAttr("symbol", "triangle-up-open-dot");
            public static Box<IMarkerProperty> x() => Interop.mkMarkerAttr("symbol", "x");
            public static Box<IMarkerProperty> xDot() => Interop.mkMarkerAttr("symbol", "x-dot");
            public static Box<IMarkerProperty> xOpen() => Interop.mkMarkerAttr("symbol", "x-open");
            public static Box<IMarkerProperty> xOpenDot() => Interop.mkMarkerAttr("symbol", "x-open-dot");
            public static Box<IMarkerProperty> xThin() => Interop.mkMarkerAttr("symbol", "x-thin");
            public static Box<IMarkerProperty> xThinOpen() => Interop.mkMarkerAttr("symbol", "x-thin-open");
            public static Box<IMarkerProperty> yDown() => Interop.mkMarkerAttr("symbol", "y-down");
            public static Box<IMarkerProperty> yDownOpen() => Interop.mkMarkerAttr("symbol", "y-down-open");
            public static Box<IMarkerProperty> yLeft() => Interop.mkMarkerAttr("symbol", "y-left");
            public static Box<IMarkerProperty> yLeftOpen() => Interop.mkMarkerAttr("symbol", "y-left-open");
            public static Box<IMarkerProperty> yRight() => Interop.mkMarkerAttr("symbol", "y-right");
            public static Box<IMarkerProperty> yRightOpen() => Interop.mkMarkerAttr("symbol", "y-right-open");
            public static Box<IMarkerProperty> yUp() => Interop.mkMarkerAttr("symbol", "y-up");
            public static Box<IMarkerProperty> yUpOpen() => Interop.mkMarkerAttr("symbol", "y-up-open");
            public static Box<IMarkerProperty> _0() => Interop.mkMarkerAttr("symbol", "0");
            public static Box<IMarkerProperty> _1() => Interop.mkMarkerAttr("symbol", "1");
            public static Box<IMarkerProperty> _10() => Interop.mkMarkerAttr("symbol", "10");
            public static Box<IMarkerProperty> _100() => Interop.mkMarkerAttr("symbol", "100");
            public static Box<IMarkerProperty> _101() => Interop.mkMarkerAttr("symbol", "101");
            public static Box<IMarkerProperty> _102() => Interop.mkMarkerAttr("symbol", "102");
            public static Box<IMarkerProperty> _103() => Interop.mkMarkerAttr("symbol", "103");
            public static Box<IMarkerProperty> _104() => Interop.mkMarkerAttr("symbol", "104");
            public static Box<IMarkerProperty> _105() => Interop.mkMarkerAttr("symbol", "105");
            public static Box<IMarkerProperty> _106() => Interop.mkMarkerAttr("symbol", "106");
            public static Box<IMarkerProperty> _107() => Interop.mkMarkerAttr("symbol", "107");
            public static Box<IMarkerProperty> _108() => Interop.mkMarkerAttr("symbol", "108");
            public static Box<IMarkerProperty> _109() => Interop.mkMarkerAttr("symbol", "109");
            public static Box<IMarkerProperty> _11() => Interop.mkMarkerAttr("symbol", "11");
            public static Box<IMarkerProperty> _110() => Interop.mkMarkerAttr("symbol", "110");
            public static Box<IMarkerProperty> _111() => Interop.mkMarkerAttr("symbol", "111");
            public static Box<IMarkerProperty> _112() => Interop.mkMarkerAttr("symbol", "112");
            public static Box<IMarkerProperty> _113() => Interop.mkMarkerAttr("symbol", "113");
            public static Box<IMarkerProperty> _114() => Interop.mkMarkerAttr("symbol", "114");
            public static Box<IMarkerProperty> _115() => Interop.mkMarkerAttr("symbol", "115");
            public static Box<IMarkerProperty> _116() => Interop.mkMarkerAttr("symbol", "116");
            public static Box<IMarkerProperty> _117() => Interop.mkMarkerAttr("symbol", "117");
            public static Box<IMarkerProperty> _118() => Interop.mkMarkerAttr("symbol", "118");
            public static Box<IMarkerProperty> _119() => Interop.mkMarkerAttr("symbol", "119");
            public static Box<IMarkerProperty> _12() => Interop.mkMarkerAttr("symbol", "12");
            public static Box<IMarkerProperty> _120() => Interop.mkMarkerAttr("symbol", "120");
            public static Box<IMarkerProperty> _121() => Interop.mkMarkerAttr("symbol", "121");
            public static Box<IMarkerProperty> _122() => Interop.mkMarkerAttr("symbol", "122");
            public static Box<IMarkerProperty> _123() => Interop.mkMarkerAttr("symbol", "123");
            public static Box<IMarkerProperty> _124() => Interop.mkMarkerAttr("symbol", "124");
            public static Box<IMarkerProperty> _125() => Interop.mkMarkerAttr("symbol", "125");
            public static Box<IMarkerProperty> _126() => Interop.mkMarkerAttr("symbol", "126");
            public static Box<IMarkerProperty> _127() => Interop.mkMarkerAttr("symbol", "127");
            public static Box<IMarkerProperty> _128() => Interop.mkMarkerAttr("symbol", "128");
            public static Box<IMarkerProperty> _129() => Interop.mkMarkerAttr("symbol", "129");
            public static Box<IMarkerProperty> _13() => Interop.mkMarkerAttr("symbol", "13");
            public static Box<IMarkerProperty> _130() => Interop.mkMarkerAttr("symbol", "130");
            public static Box<IMarkerProperty> _131() => Interop.mkMarkerAttr("symbol", "131");
            public static Box<IMarkerProperty> _132() => Interop.mkMarkerAttr("symbol", "132");
            public static Box<IMarkerProperty> _133() => Interop.mkMarkerAttr("symbol", "133");
            public static Box<IMarkerProperty> _134() => Interop.mkMarkerAttr("symbol", "134");
            public static Box<IMarkerProperty> _135() => Interop.mkMarkerAttr("symbol", "135");
            public static Box<IMarkerProperty> _136() => Interop.mkMarkerAttr("symbol", "136");
            public static Box<IMarkerProperty> _137() => Interop.mkMarkerAttr("symbol", "137");
            public static Box<IMarkerProperty> _138() => Interop.mkMarkerAttr("symbol", "138");
            public static Box<IMarkerProperty> _139() => Interop.mkMarkerAttr("symbol", "139");
            public static Box<IMarkerProperty> _14() => Interop.mkMarkerAttr("symbol", "14");
            public static Box<IMarkerProperty> _140() => Interop.mkMarkerAttr("symbol", "140");
            public static Box<IMarkerProperty> _141() => Interop.mkMarkerAttr("symbol", "141");
            public static Box<IMarkerProperty> _142() => Interop.mkMarkerAttr("symbol", "142");
            public static Box<IMarkerProperty> _143() => Interop.mkMarkerAttr("symbol", "143");
            public static Box<IMarkerProperty> _144() => Interop.mkMarkerAttr("symbol", "144");
            public static Box<IMarkerProperty> _15() => Interop.mkMarkerAttr("symbol", "15");
            public static Box<IMarkerProperty> _16() => Interop.mkMarkerAttr("symbol", "16");
            public static Box<IMarkerProperty> _17() => Interop.mkMarkerAttr("symbol", "17");
            public static Box<IMarkerProperty> _18() => Interop.mkMarkerAttr("symbol", "18");
            public static Box<IMarkerProperty> _19() => Interop.mkMarkerAttr("symbol", "19");
            public static Box<IMarkerProperty> _2() => Interop.mkMarkerAttr("symbol", "2");
            public static Box<IMarkerProperty> _20() => Interop.mkMarkerAttr("symbol", "20");
            public static Box<IMarkerProperty> _200() => Interop.mkMarkerAttr("symbol", "200");
            public static Box<IMarkerProperty> _201() => Interop.mkMarkerAttr("symbol", "201");
            public static Box<IMarkerProperty> _202() => Interop.mkMarkerAttr("symbol", "202");
            public static Box<IMarkerProperty> _203() => Interop.mkMarkerAttr("symbol", "203");
            public static Box<IMarkerProperty> _204() => Interop.mkMarkerAttr("symbol", "204");
            public static Box<IMarkerProperty> _205() => Interop.mkMarkerAttr("symbol", "205");
            public static Box<IMarkerProperty> _206() => Interop.mkMarkerAttr("symbol", "206");
            public static Box<IMarkerProperty> _207() => Interop.mkMarkerAttr("symbol", "207");
            public static Box<IMarkerProperty> _208() => Interop.mkMarkerAttr("symbol", "208");
            public static Box<IMarkerProperty> _209() => Interop.mkMarkerAttr("symbol", "209");
            public static Box<IMarkerProperty> _21() => Interop.mkMarkerAttr("symbol", "21");
            public static Box<IMarkerProperty> _210() => Interop.mkMarkerAttr("symbol", "210");
            public static Box<IMarkerProperty> _211() => Interop.mkMarkerAttr("symbol", "211");
            public static Box<IMarkerProperty> _212() => Interop.mkMarkerAttr("symbol", "212");
            public static Box<IMarkerProperty> _213() => Interop.mkMarkerAttr("symbol", "213");
            public static Box<IMarkerProperty> _214() => Interop.mkMarkerAttr("symbol", "214");
            public static Box<IMarkerProperty> _215() => Interop.mkMarkerAttr("symbol", "215");
            public static Box<IMarkerProperty> _216() => Interop.mkMarkerAttr("symbol", "216");
            public static Box<IMarkerProperty> _217() => Interop.mkMarkerAttr("symbol", "217");
            public static Box<IMarkerProperty> _218() => Interop.mkMarkerAttr("symbol", "218");
            public static Box<IMarkerProperty> _219() => Interop.mkMarkerAttr("symbol", "219");
            public static Box<IMarkerProperty> _22() => Interop.mkMarkerAttr("symbol", "22");
            public static Box<IMarkerProperty> _220() => Interop.mkMarkerAttr("symbol", "220");
            public static Box<IMarkerProperty> _221() => Interop.mkMarkerAttr("symbol", "221");
            public static Box<IMarkerProperty> _222() => Interop.mkMarkerAttr("symbol", "222");
            public static Box<IMarkerProperty> _223() => Interop.mkMarkerAttr("symbol", "223");
            public static Box<IMarkerProperty> _224() => Interop.mkMarkerAttr("symbol", "224");
            public static Box<IMarkerProperty> _23() => Interop.mkMarkerAttr("symbol", "23");
            public static Box<IMarkerProperty> _236() => Interop.mkMarkerAttr("symbol", "236");
            public static Box<IMarkerProperty> _24() => Interop.mkMarkerAttr("symbol", "24");
            public static Box<IMarkerProperty> _25() => Interop.mkMarkerAttr("symbol", "25");
            public static Box<IMarkerProperty> _26() => Interop.mkMarkerAttr("symbol", "26");
            public static Box<IMarkerProperty> _27() => Interop.mkMarkerAttr("symbol", "27");
            public static Box<IMarkerProperty> _28() => Interop.mkMarkerAttr("symbol", "28");
            public static Box<IMarkerProperty> _29() => Interop.mkMarkerAttr("symbol", "29");
            public static Box<IMarkerProperty> _3() => Interop.mkMarkerAttr("symbol", "3");
            public static Box<IMarkerProperty> _30() => Interop.mkMarkerAttr("symbol", "30");
            public static Box<IMarkerProperty> _300() => Interop.mkMarkerAttr("symbol", "300");
            public static Box<IMarkerProperty> _301() => Interop.mkMarkerAttr("symbol", "301");
            public static Box<IMarkerProperty> _302() => Interop.mkMarkerAttr("symbol", "302");
            public static Box<IMarkerProperty> _303() => Interop.mkMarkerAttr("symbol", "303");
            public static Box<IMarkerProperty> _304() => Interop.mkMarkerAttr("symbol", "304");
            public static Box<IMarkerProperty> _305() => Interop.mkMarkerAttr("symbol", "305");
            public static Box<IMarkerProperty> _306() => Interop.mkMarkerAttr("symbol", "306");
            public static Box<IMarkerProperty> _307() => Interop.mkMarkerAttr("symbol", "307");
            public static Box<IMarkerProperty> _308() => Interop.mkMarkerAttr("symbol", "308");
            public static Box<IMarkerProperty> _309() => Interop.mkMarkerAttr("symbol", "309");
            public static Box<IMarkerProperty> _31() => Interop.mkMarkerAttr("symbol", "31");
            public static Box<IMarkerProperty> _310() => Interop.mkMarkerAttr("symbol", "310");
            public static Box<IMarkerProperty> _311() => Interop.mkMarkerAttr("symbol", "311");
            public static Box<IMarkerProperty> _312() => Interop.mkMarkerAttr("symbol", "312");
            public static Box<IMarkerProperty> _313() => Interop.mkMarkerAttr("symbol", "313");
            public static Box<IMarkerProperty> _314() => Interop.mkMarkerAttr("symbol", "314");
            public static Box<IMarkerProperty> _315() => Interop.mkMarkerAttr("symbol", "315");
            public static Box<IMarkerProperty> _316() => Interop.mkMarkerAttr("symbol", "316");
            public static Box<IMarkerProperty> _317() => Interop.mkMarkerAttr("symbol", "317");
            public static Box<IMarkerProperty> _318() => Interop.mkMarkerAttr("symbol", "318");
            public static Box<IMarkerProperty> _319() => Interop.mkMarkerAttr("symbol", "319");
            public static Box<IMarkerProperty> _32() => Interop.mkMarkerAttr("symbol", "32");
            public static Box<IMarkerProperty> _320() => Interop.mkMarkerAttr("symbol", "320");
            public static Box<IMarkerProperty> _321() => Interop.mkMarkerAttr("symbol", "321");
            public static Box<IMarkerProperty> _322() => Interop.mkMarkerAttr("symbol", "322");
            public static Box<IMarkerProperty> _323() => Interop.mkMarkerAttr("symbol", "323");
            public static Box<IMarkerProperty> _324() => Interop.mkMarkerAttr("symbol", "324");
            public static Box<IMarkerProperty> _33() => Interop.mkMarkerAttr("symbol", "33");
            public static Box<IMarkerProperty> _336() => Interop.mkMarkerAttr("symbol", "336");
            public static Box<IMarkerProperty> _34() => Interop.mkMarkerAttr("symbol", "34");
            public static Box<IMarkerProperty> _35() => Interop.mkMarkerAttr("symbol", "35");
            public static Box<IMarkerProperty> _36() => Interop.mkMarkerAttr("symbol", "36");
            public static Box<IMarkerProperty> _37() => Interop.mkMarkerAttr("symbol", "37");
            public static Box<IMarkerProperty> _38() => Interop.mkMarkerAttr("symbol", "38");
            public static Box<IMarkerProperty> _39() => Interop.mkMarkerAttr("symbol", "39");
            public static Box<IMarkerProperty> _4() => Interop.mkMarkerAttr("symbol", "4");
            public static Box<IMarkerProperty> _40() => Interop.mkMarkerAttr("symbol", "40");
            public static Box<IMarkerProperty> _41() => Interop.mkMarkerAttr("symbol", "41");
            public static Box<IMarkerProperty> _42() => Interop.mkMarkerAttr("symbol", "42");
            public static Box<IMarkerProperty> _43() => Interop.mkMarkerAttr("symbol", "43");
            public static Box<IMarkerProperty> _44() => Interop.mkMarkerAttr("symbol", "44");
            public static Box<IMarkerProperty> _5() => Interop.mkMarkerAttr("symbol", "5");
            public static Box<IMarkerProperty> _6() => Interop.mkMarkerAttr("symbol", "6");
            public static Box<IMarkerProperty> _7() => Interop.mkMarkerAttr("symbol", "7");
            public static Box<IMarkerProperty> _8() => Interop.mkMarkerAttr("symbol", "8");
            public static Box<IMarkerProperty> _9() => Interop.mkMarkerAttr("symbol", "9");
        }

        /// Has an effect only if `marker.size` is set to a numerical array. Sets the rule for which the data in `size` is converted to pixels.
        public static partial class Sizemode
        {
            public static Box<IMarkerProperty> area() => Interop.mkMarkerAttr("sizemode", "area");
            public static Box<IMarkerProperty> diameter() => Interop.mkMarkerAttr("sizemode", "diameter");
        }

        /// Determines if the sector colors are faded towards the background from the leaves up to the headers. This option is unavailable when a `colorscale` is present, defaults to false when `marker.colors` is set, but otherwise defaults to true. When set to *reversed*, the fading direction is inverted, that is the top elements within hierarchy are drawn with fully saturated colors while the leaves are faded towards the background color.
        public static partial class Depthfade
        {
            public static Box<IMarkerProperty> reversed() => Interop.mkMarkerAttr("depthfade", "reversed");
            public static Box<IMarkerProperty> _false() => Interop.mkMarkerAttr("depthfade", false);
            public static Box<IMarkerProperty> _true() => Interop.mkMarkerAttr("depthfade", true);
        }
    }
}