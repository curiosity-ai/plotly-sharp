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

    public static partial class Currentvalue
    {
        /// Shows the currently-selected value above the slider.
        public static Box<ICurrentvalueProperty> visible(bool val) => Interop.mkCurrentvalueAttr("visible", val);
        /// The amount of space, in pixels, between the current value label and the slider.
        public static Box<ICurrentvalueProperty> offset(int val) => Interop.mkCurrentvalueAttr("offset", val);
        /// The amount of space, in pixels, between the current value label and the slider.
        public static Box<ICurrentvalueProperty> offset(float val) => Interop.mkCurrentvalueAttr("offset", val);
        /// When currentvalue.visible is true, this sets the prefix of the label.
        public static Box<ICurrentvalueProperty> prefix(string val) => Interop.mkCurrentvalueAttr("prefix", val);
        /// When currentvalue.visible is true, this sets the suffix of the label.
        public static Box<ICurrentvalueProperty> suffix(string val) => Interop.mkCurrentvalueAttr("suffix", val);
        /// Sets the font of the current value label text.
        public static Box<ICurrentvalueProperty> font(params Box<IFontProperty>[] properties) => Interop.mkCurrentvalueAttr("font", Bindings.flattenProperties(properties));
    }

    public static partial class Currentvalue
    {
        /// The alignment of the value readout relative to the length of the slider.
        public static partial class Xanchor
        {
            public static Box<ICurrentvalueProperty> center() => Interop.mkCurrentvalueAttr("xanchor", "center");
            public static Box<ICurrentvalueProperty> left() => Interop.mkCurrentvalueAttr("xanchor", "left");
            public static Box<ICurrentvalueProperty> right() => Interop.mkCurrentvalueAttr("xanchor", "right");
        }
    }
}