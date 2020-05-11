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

    public static partial class Hoverlabel
    {
        /// Sets the background color of the hover labels for this trace
        public static Box<IHoverlabelProperty> bgcolor(string val) => Interop.mkHoverlabelAttr("bgcolor", val);
        /// Sets the background color of the hover labels for this trace
        public static Box<IHoverlabelProperty> bgcolor(IEnumerable<string> values) => Interop.mkHoverlabelAttr("bgcolor", values.ToArray());
        /// Sets the background color of the hover labels for this trace
        public static Box<IHoverlabelProperty> bgcolor(params int[] values) => Interop.mkHoverlabelAttr("bgcolor", values);
        /// Sets the background color of the hover labels for this trace
        public static Box<IHoverlabelProperty> bgcolor(params float[] values) => Interop.mkHoverlabelAttr("bgcolor", values);
        /// Sets the border color of the hover labels for this trace.
        public static Box<IHoverlabelProperty> bordercolor(string val) => Interop.mkHoverlabelAttr("bordercolor", val);
        /// Sets the border color of the hover labels for this trace.
        public static Box<IHoverlabelProperty> bordercolor(IEnumerable<string> values) => Interop.mkHoverlabelAttr("bordercolor", values.ToArray());
        /// Sets the border color of the hover labels for this trace.
        public static Box<IHoverlabelProperty> bordercolor(params int[] values) => Interop.mkHoverlabelAttr("bordercolor", values);
        /// Sets the border color of the hover labels for this trace.
        public static Box<IHoverlabelProperty> bordercolor(params float[] values) => Interop.mkHoverlabelAttr("bordercolor", values);
        /// Sets the font used in hover labels.
        public static Box<IHoverlabelProperty> font(params Box<IFontProperty>[] properties) => Interop.mkHoverlabelAttr("font", Bindings.flattenProperties(properties));
        /// Sets the horizontal alignment of the text content within hover label box. Has an effect only if the hover label text spans more two or more lines
        public static Box<IHoverlabelProperty> align(IEnumerable<Box<IHoverlabelProperty>> properties) => Interop.mkHoverlabelAttr("align", Bindings.flattenProperties(properties));
        /// Sets the default length (in number of characters) of the trace name in the hover labels for all traces. -1 shows the whole name regardless of length. 0-3 shows the first 0-3 characters, and an integer >3 will show the whole name if it is less than that many characters, but if it is longer, will truncate to `namelength - 3` characters and add an ellipsis.
        public static Box<IHoverlabelProperty> namelength(int val) => Interop.mkHoverlabelAttr("namelength", val);
        /// Sets the default length (in number of characters) of the trace name in the hover labels for all traces. -1 shows the whole name regardless of length. 0-3 shows the first 0-3 characters, and an integer >3 will show the whole name if it is less than that many characters, but if it is longer, will truncate to `namelength - 3` characters and add an ellipsis.
        public static Box<IHoverlabelProperty> namelength(IEnumerable<int> values) => Interop.mkHoverlabelAttr("namelength", values.ToArray());
        /// Sets the source reference on plot.ly for  bgcolor .
        public static Box<IHoverlabelProperty> bgcolorsrc(string val) => Interop.mkHoverlabelAttr("bgcolorsrc", val);
        /// Sets the source reference on plot.ly for  bordercolor .
        public static Box<IHoverlabelProperty> bordercolorsrc(string val) => Interop.mkHoverlabelAttr("bordercolorsrc", val);
        /// Sets the source reference on plot.ly for  align .
        public static Box<IHoverlabelProperty> alignsrc(string val) => Interop.mkHoverlabelAttr("alignsrc", val);
        /// Sets the source reference on plot.ly for  namelength .
        public static Box<IHoverlabelProperty> namelengthsrc(string val) => Interop.mkHoverlabelAttr("namelengthsrc", val);
        /// Show hover information (open, close, high, low) in separate labels.
        public static Box<IHoverlabelProperty> split(bool val) => Interop.mkHoverlabelAttr("split", val);
    }

    public static partial class Hoverlabel
    {
        /// Sets the horizontal alignment of the text content within hover label box. Has an effect only if the hover label text spans more two or more lines
        public static partial class Align
        {
            public static Box<IHoverlabelProperty> auto() => Interop.mkHoverlabelAttr("align", "auto");
            public static Box<IHoverlabelProperty> left() => Interop.mkHoverlabelAttr("align", "left");
            public static Box<IHoverlabelProperty> right() => Interop.mkHoverlabelAttr("align", "right");
        }
    }
}