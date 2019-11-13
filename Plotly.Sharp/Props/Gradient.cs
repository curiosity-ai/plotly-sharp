namespace Plotly
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

    public static partial class Gradient
    {
        /// Sets the final color of the gradient fill: the center color for radial, the right for horizontal, or the bottom for vertical.
        public static Box<IGradientProperty> color(string val) => Interop.mkGradientAttr("color", val);
        /// Sets the final color of the gradient fill: the center color for radial, the right for horizontal, or the bottom for vertical.
        public static Box<IGradientProperty> color(IEnumerable<string> values) => Interop.mkGradientAttr("color", values.ToArray());
        /// Sets the final color of the gradient fill: the center color for radial, the right for horizontal, or the bottom for vertical.
        public static Box<IGradientProperty> color(params int[] values) => Interop.mkGradientAttr("color", values);
        /// Sets the final color of the gradient fill: the center color for radial, the right for horizontal, or the bottom for vertical.
        public static Box<IGradientProperty> color(params float[] values) => Interop.mkGradientAttr("color", values);
        /// Sets the source reference on plot.ly for  type .
        public static Box<IGradientProperty> typesrc(string val) => Interop.mkGradientAttr("typesrc", val);
        /// Sets the source reference on plot.ly for  color .
        public static Box<IGradientProperty> colorsrc(string val) => Interop.mkGradientAttr("colorsrc", val);
    }

    public static partial class Gradient
    {
        /// Sets the type of gradient used to fill the markers
        public static partial class _type
        {
            public static Box<IGradientProperty> horizontal() => Interop.mkGradientAttr("type", "horizontal");
            public static Box<IGradientProperty> none() => Interop.mkGradientAttr("type", "none");
            public static Box<IGradientProperty> radial() => Interop.mkGradientAttr("type", "radial");
            public static Box<IGradientProperty> vertical() => Interop.mkGradientAttr("type", "vertical");
        }
    }
}