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
    using static H5.Core.dom;

    public static partial class Colorscale
    {
        /// Sets the default sequential colorscale for positive values. Note that `autocolorscale` must be true for this attribute to work.
        public static Box<IColorscaleProperty> sequential(string val) => Interop.mkColorscaleAttr("sequential", val);
        /// Sets the default sequential colorscale for positive values. Note that `autocolorscale` must be true for this attribute to work.
        public static Box<IColorscaleProperty> sequential(List<string[]> values) => Interop.mkColorscaleAttr("sequential", Bindings.flatten2DArrayIf1D(values));
        /// Sets the default sequential colorscale for negative values. Note that `autocolorscale` must be true for this attribute to work.
        public static Box<IColorscaleProperty> sequentialminus(string val) => Interop.mkColorscaleAttr("sequentialminus", val);
        /// Sets the default sequential colorscale for negative values. Note that `autocolorscale` must be true for this attribute to work.
        public static Box<IColorscaleProperty> sequentialminus(List<string[]> values) => Interop.mkColorscaleAttr("sequentialminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the default diverging colorscale. Note that `autocolorscale` must be true for this attribute to work.
        public static Box<IColorscaleProperty> diverging(string val) => Interop.mkColorscaleAttr("diverging", val);
        /// Sets the default diverging colorscale. Note that `autocolorscale` must be true for this attribute to work.
        public static Box<IColorscaleProperty> diverging(List<string[]> values) => Interop.mkColorscaleAttr("diverging", Bindings.flatten2DArrayIf1D(values));
    }
}