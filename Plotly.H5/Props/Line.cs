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

    public static partial class Line
    {
        /// Sets the line color.
        public static Box<ILineProperty> color(string val) => Interop.mkLineAttr("color", val);
        /// Sets the line color.
        public static Box<ILineProperty> color(IEnumerable<string> values) => Interop.mkLineAttr("color", values.ToArray());
        /// Sets the line color.
        public static Box<ILineProperty> color(params int[] values) => Interop.mkLineAttr("color", values);
        /// Sets the line color.
        public static Box<ILineProperty> color(params float[] values) => Interop.mkLineAttr("color", values);
        /// Sets the line width (in px).
        public static Box<ILineProperty> width(int val) => Interop.mkLineAttr("width", val);
        /// Sets the line width (in px).
        public static Box<ILineProperty> width(float val) => Interop.mkLineAttr("width", val);
        /// Sets the line width (in px).
        public static Box<ILineProperty> width(IEnumerable<int> values) => Interop.mkLineAttr("width", values.ToArray());
        /// Sets the line width (in px).
        public static Box<ILineProperty> width(IEnumerable<float> values) => Interop.mkLineAttr("width", values.ToArray());
        /// Has an effect only if `shape` is set to *spline* Sets the amount of smoothing. *0* corresponds to no smoothing (equivalent to a *linear* shape).
        public static Box<ILineProperty> smoothing(int val) => Interop.mkLineAttr("smoothing", val);
        /// Has an effect only if `shape` is set to *spline* Sets the amount of smoothing. *0* corresponds to no smoothing (equivalent to a *linear* shape).
        public static Box<ILineProperty> smoothing(float val) => Interop.mkLineAttr("smoothing", val);
        /// Simplifies lines by removing nearly-collinear points. When transitioning lines, it may be desirable to disable this so that the number of points along the resulting SVG path is unaffected.
        public static Box<ILineProperty> simplify(bool val) => Interop.mkLineAttr("simplify", val);
        /// Determines whether or not the color domain is computed with respect to the input data (here in `marker.line.color`) or the bounds set in `marker.line.cmin` and `marker.line.cmax`  Has an effect only if in `marker.line.color`is set to a numerical array. Defaults to `false` when `marker.line.cmin` and `marker.line.cmax` are set by the user.
        public static Box<ILineProperty> cauto(bool val) => Interop.mkLineAttr("cauto", val);
        /// Sets the lower bound of the color domain. Has an effect only if in `marker.line.color`is set to a numerical array. Value should have the same units as in `marker.line.color` and if set, `marker.line.cmax` must be set as well.
        public static Box<ILineProperty> cmin(int val) => Interop.mkLineAttr("cmin", val);
        /// Sets the lower bound of the color domain. Has an effect only if in `marker.line.color`is set to a numerical array. Value should have the same units as in `marker.line.color` and if set, `marker.line.cmax` must be set as well.
        public static Box<ILineProperty> cmin(float val) => Interop.mkLineAttr("cmin", val);
        /// Sets the upper bound of the color domain. Has an effect only if in `marker.line.color`is set to a numerical array. Value should have the same units as in `marker.line.color` and if set, `marker.line.cmin` must be set as well.
        public static Box<ILineProperty> cmax(int val) => Interop.mkLineAttr("cmax", val);
        /// Sets the upper bound of the color domain. Has an effect only if in `marker.line.color`is set to a numerical array. Value should have the same units as in `marker.line.color` and if set, `marker.line.cmin` must be set as well.
        public static Box<ILineProperty> cmax(float val) => Interop.mkLineAttr("cmax", val);
        /// Sets the mid-point of the color domain by scaling `marker.line.cmin` and/or `marker.line.cmax` to be equidistant to this point. Has an effect only if in `marker.line.color`is set to a numerical array. Value should have the same units as in `marker.line.color`. Has no effect when `marker.line.cauto` is `false`.
        public static Box<ILineProperty> cmid(int val) => Interop.mkLineAttr("cmid", val);
        /// Sets the mid-point of the color domain by scaling `marker.line.cmin` and/or `marker.line.cmax` to be equidistant to this point. Has an effect only if in `marker.line.color`is set to a numerical array. Value should have the same units as in `marker.line.color`. Has no effect when `marker.line.cauto` is `false`.
        public static Box<ILineProperty> cmid(float val) => Interop.mkLineAttr("cmid", val);
        /// Sets the colorscale. Has an effect only if in `marker.line.color`is set to a numerical array. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`marker.line.cmin` and `marker.line.cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<ILineProperty> colorscale(string val) => Interop.mkLineAttr("colorscale", val);
        /// Sets the colorscale. Has an effect only if in `marker.line.color`is set to a numerical array. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`marker.line.cmin` and `marker.line.cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<ILineProperty> colorscale(List<string[]> values) => Interop.mkLineAttr("colorscale", Bindings.flatten2DArrayIf1D(values));
        /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `marker.line.colorscale`. Has an effect only if in `marker.line.color`is set to a numerical array. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
        public static Box<ILineProperty> autocolorscale(bool val) => Interop.mkLineAttr("autocolorscale", val);
        /// Reverses the color mapping if true. Has an effect only if in `marker.line.color`is set to a numerical array. If true, `marker.line.cmin` will correspond to the last color in the array and `marker.line.cmax` will correspond to the first color.
        public static Box<ILineProperty> reversescale(bool val) => Interop.mkLineAttr("reversescale", val);
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<ILineProperty> coloraxis(int anchorId) => Interop.mkLineAttr("coloraxis", anchorId > 1 ? $"coloraxis{anchorId}" : "");
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<ILineProperty> coloraxis(string val) => Interop.mkLineAttr("coloraxis", val);
        /// Sets the source reference on plot.ly for  width .
        public static Box<ILineProperty> widthsrc(string val) => Interop.mkLineAttr("widthsrc", val);
        /// Sets the source reference on plot.ly for  color .
        public static Box<ILineProperty> colorsrc(string val) => Interop.mkLineAttr("colorsrc", val);
        /// Sets the border line color of the outlier sample points. Defaults to marker.color
        public static Box<ILineProperty> outliercolor(string val) => Interop.mkLineAttr("outliercolor", val);
        /// Sets the border line width (in px) of the outlier sample points.
        public static Box<ILineProperty> outlierwidth(int val) => Interop.mkLineAttr("outlierwidth", val);
        /// Sets the border line width (in px) of the outlier sample points.
        public static Box<ILineProperty> outlierwidth(float val) => Interop.mkLineAttr("outlierwidth", val);
        /// Determines whether or not a colorbar is displayed for this trace. Has an effect only if in `line.color`is set to a numerical array.
        public static Box<ILineProperty> showscale(bool val) => Interop.mkLineAttr("showscale", val);
        public static Box<ILineProperty> colorbar(params Box<IColorbarProperty>[] properties) => Interop.mkLineAttr("colorbar", Bindings.flattenProperties(properties));
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `count` and `probability`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<ILineProperty> hovertemplate(string val) => Interop.mkLineAttr("hovertemplate", val);
        /// Sets the source reference on plot.ly for  dash .
        public static Box<ILineProperty> dashsrc(string val) => Interop.mkLineAttr("dashsrc", val);
    }

    public static partial class Line
    {
        /// Determines the line shape. With *spline* the lines are drawn using spline interpolation. The other available values correspond to step-wise line shapes.
        public static partial class Shape
        {
            public static Box<ILineProperty> hspline() => Interop.mkLineAttr("shape", "hspline");
            public static Box<ILineProperty> hv() => Interop.mkLineAttr("shape", "hv");
            public static Box<ILineProperty> hvh() => Interop.mkLineAttr("shape", "hvh");
            public static Box<ILineProperty> linear() => Interop.mkLineAttr("shape", "linear");
            public static Box<ILineProperty> spline() => Interop.mkLineAttr("shape", "spline");
            public static Box<ILineProperty> vh() => Interop.mkLineAttr("shape", "vh");
            public static Box<ILineProperty> vhv() => Interop.mkLineAttr("shape", "vhv");
        }

        /// Sets the dash style of lines. Set to a dash type string (*solid*, *dot*, *dash*, *longdash*, *dashdot*, or *longdashdot*) or a dash length list in px (eg *5px,10px,2px,2px*).
        public static partial class Dash
        {
            public static Box<ILineProperty> dash() => Interop.mkLineAttr("dash", "dash");
            public static Box<ILineProperty> dashdot() => Interop.mkLineAttr("dash", "dashdot");
            public static Box<ILineProperty> dot() => Interop.mkLineAttr("dash", "dot");
            public static Box<ILineProperty> longdash() => Interop.mkLineAttr("dash", "longdash");
            public static Box<ILineProperty> longdashdot() => Interop.mkLineAttr("dash", "longdashdot");
            public static Box<ILineProperty> solid() => Interop.mkLineAttr("dash", "solid");
            public static Box<ILineProperty> custom(IEnumerable<int> values) => Interop.mkLineAttr("dash", values.ToArray());
            public static Box<ILineProperty> custom(IEnumerable<float> values) => Interop.mkLineAttr("dash", values.ToArray());
        }
    }
}