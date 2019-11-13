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

    public static partial class Fill
    {
        /// Sets the cell fill color. It accepts either a specific color or an array of colors or a 2D array of colors.
        public static Box<IFillProperty> color(string val) => Interop.mkFillAttr("color", val);
        /// Sets the cell fill color. It accepts either a specific color or an array of colors or a 2D array of colors.
        public static Box<IFillProperty> color(IEnumerable<string> values) => Interop.mkFillAttr("color", values.ToArray());
        /// Sets the cell fill color. It accepts either a specific color or an array of colors or a 2D array of colors.
        public static Box<IFillProperty> color(params int[] values) => Interop.mkFillAttr("color", values);
        /// Sets the cell fill color. It accepts either a specific color or an array of colors or a 2D array of colors.
        public static Box<IFillProperty> color(params float[] values) => Interop.mkFillAttr("color", values);
        /// Sets the cell fill color. It accepts either a specific color or an array of colors or a 2D array of colors.
        public static Box<IFillProperty> color(IEnumerable<IEnumerable<string>> values) => Interop.mkFillAttr("color", Bindings.flatten2DArrayIf1D(values));
        /// Sets the cell fill color. It accepts either a specific color or an array of colors or a 2D array of colors.
        public static Box<IFillProperty> color(List<string[]> values) => Interop.mkFillAttr("color", Bindings.flatten2DArrayIf1D(values));
        /// Sets the cell fill color. It accepts either a specific color or an array of colors or a 2D array of colors.
        public static Box<IFillProperty> color(params string[][] values) => Interop.mkFillAttr("color", Bindings.flatten2DArrayIf1D(values));
        /// Sets the source reference on plot.ly for  color .
        public static Box<IFillProperty> colorsrc(string val) => Interop.mkFillAttr("colorsrc", val);
        /// Sets the fill outline color (mapbox.layer.paint.fill-outline-color). Has an effect only when `type` is set to *fill*.
        public static Box<IFillProperty> outlinecolor(string val) => Interop.mkFillAttr("outlinecolor", val);
    }
}