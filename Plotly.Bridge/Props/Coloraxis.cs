namespace PlotlyBridge
{
    /*////////////////////////////////
    /// THIS FILE IS AUTO-GENERATED //
    ///      by propsDocument       //
    ////////////////////////////////*/
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Types;
    using Bridge;
    using static Retyped.dom;

    public static partial class Coloraxis
    {
        /// Determines whether or not the color domain is computed with respect to the input data (here corresponding trace color array(s)) or the bounds set in `cmin` and `cmax`  Defaults to `false` when `cmin` and `cmax` are set by the user.
        public static Box<IColoraxisProperty> cauto(bool val) => Interop.mkColoraxisAttr("cauto", val);
        /// Sets the lower bound of the color domain. Value should have the same units as corresponding trace color array(s) and if set, `cmax` must be set as well.
        public static Box<IColoraxisProperty> cmin(int val) => Interop.mkColoraxisAttr("cmin", val);
        /// Sets the lower bound of the color domain. Value should have the same units as corresponding trace color array(s) and if set, `cmax` must be set as well.
        public static Box<IColoraxisProperty> cmin(float val) => Interop.mkColoraxisAttr("cmin", val);
        /// Sets the upper bound of the color domain. Value should have the same units as corresponding trace color array(s) and if set, `cmin` must be set as well.
        public static Box<IColoraxisProperty> cmax(int val) => Interop.mkColoraxisAttr("cmax", val);
        /// Sets the upper bound of the color domain. Value should have the same units as corresponding trace color array(s) and if set, `cmin` must be set as well.
        public static Box<IColoraxisProperty> cmax(float val) => Interop.mkColoraxisAttr("cmax", val);
        /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as corresponding trace color array(s). Has no effect when `cauto` is `false`.
        public static Box<IColoraxisProperty> cmid(int val) => Interop.mkColoraxisAttr("cmid", val);
        /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as corresponding trace color array(s). Has no effect when `cauto` is `false`.
        public static Box<IColoraxisProperty> cmid(float val) => Interop.mkColoraxisAttr("cmid", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IColoraxisProperty> colorscale(string val) => Interop.mkColoraxisAttr("colorscale", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IColoraxisProperty> colorscale(List<string[]> values) => Interop.mkColoraxisAttr("colorscale", Bindings.flatten2DArrayIf1D(values));
        /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
        public static Box<IColoraxisProperty> autocolorscale(bool val) => Interop.mkColoraxisAttr("autocolorscale", val);
        /// Reverses the color mapping if true. If true, `cmin` will correspond to the last color in the array and `cmax` will correspond to the first color.
        public static Box<IColoraxisProperty> reversescale(bool val) => Interop.mkColoraxisAttr("reversescale", val);
        /// Determines whether or not a colorbar is displayed for this trace.
        public static Box<IColoraxisProperty> showscale(bool val) => Interop.mkColoraxisAttr("showscale", val);
        public static Box<IColoraxisProperty> colorbar(params Box<IColorbarProperty>[] properties) => Interop.mkColoraxisAttr("colorbar", Bindings.flattenProperties(properties));
    }
}