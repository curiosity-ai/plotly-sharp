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

    public static partial class Concentrationscales
    {
        /// The label of the links to color based on their concentration within a flow.
        public static Box<IConcentrationscalesProperty> label(string val) => Interop.mkConcentrationscalesAttr("label", val);
        /// Sets the upper bound of the color domain.
        public static Box<IConcentrationscalesProperty> cmax(int val) => Interop.mkConcentrationscalesAttr("cmax", val);
        /// Sets the upper bound of the color domain.
        public static Box<IConcentrationscalesProperty> cmax(float val) => Interop.mkConcentrationscalesAttr("cmax", val);
        /// Sets the lower bound of the color domain.
        public static Box<IConcentrationscalesProperty> cmin(int val) => Interop.mkConcentrationscalesAttr("cmin", val);
        /// Sets the lower bound of the color domain.
        public static Box<IConcentrationscalesProperty> cmin(float val) => Interop.mkConcentrationscalesAttr("cmin", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IConcentrationscalesProperty> colorscale(string val) => Interop.mkConcentrationscalesAttr("colorscale", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IConcentrationscalesProperty> colorscale(List<string[]> values) => Interop.mkConcentrationscalesAttr("colorscale", Bindings.flatten2DArrayIf1D(values));
        /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
        public static Box<IConcentrationscalesProperty> name(string val) => Interop.mkConcentrationscalesAttr("name", val);
        /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
        public static Box<IConcentrationscalesProperty> templateitemname(string val) => Interop.mkConcentrationscalesAttr("templateitemname", val);
    }
}