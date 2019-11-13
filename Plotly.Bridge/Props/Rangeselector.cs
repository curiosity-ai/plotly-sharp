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

    public static partial class Rangeselector
    {
        /// Determines whether or not this range selector is visible. Note that range selectors are only available for x axes of `type` set to or auto-typed to *date*.
        public static Box<IRangeselectorProperty> visible(bool val) => Interop.mkRangeselectorAttr("visible", val);
        public static Box<IRangeselectorProperty> buttons(params Box<IButtonsProperty>[] properties) => Interop.mkRangeselectorAttr("buttons", Bindings.flattenProperties(properties));
        /// Sets the x position (in normalized coordinates) of the range selector.
        public static Box<IRangeselectorProperty> x(int val) => Interop.mkRangeselectorAttr("x", val);
        /// Sets the x position (in normalized coordinates) of the range selector.
        public static Box<IRangeselectorProperty> x(float val) => Interop.mkRangeselectorAttr("x", val);
        /// Sets the y position (in normalized coordinates) of the range selector.
        public static Box<IRangeselectorProperty> y(int val) => Interop.mkRangeselectorAttr("y", val);
        /// Sets the y position (in normalized coordinates) of the range selector.
        public static Box<IRangeselectorProperty> y(float val) => Interop.mkRangeselectorAttr("y", val);
        /// Sets the font of the range selector button text.
        public static Box<IRangeselectorProperty> font(params Box<IFontProperty>[] properties) => Interop.mkRangeselectorAttr("font", Bindings.flattenProperties(properties));
        /// Sets the background color of the range selector buttons.
        public static Box<IRangeselectorProperty> bgcolor(string val) => Interop.mkRangeselectorAttr("bgcolor", val);
        /// Sets the background color of the active range selector button.
        public static Box<IRangeselectorProperty> activecolor(string val) => Interop.mkRangeselectorAttr("activecolor", val);
        /// Sets the color of the border enclosing the range selector.
        public static Box<IRangeselectorProperty> bordercolor(string val) => Interop.mkRangeselectorAttr("bordercolor", val);
        /// Sets the width (in px) of the border enclosing the range selector.
        public static Box<IRangeselectorProperty> borderwidth(int val) => Interop.mkRangeselectorAttr("borderwidth", val);
        /// Sets the width (in px) of the border enclosing the range selector.
        public static Box<IRangeselectorProperty> borderwidth(float val) => Interop.mkRangeselectorAttr("borderwidth", val);
    }

    public static partial class Rangeselector
    {
        /// Sets the range selector's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the range selector.
        public static partial class Xanchor
        {
            public static Box<IRangeselectorProperty> auto() => Interop.mkRangeselectorAttr("xanchor", "auto");
            public static Box<IRangeselectorProperty> center() => Interop.mkRangeselectorAttr("xanchor", "center");
            public static Box<IRangeselectorProperty> left() => Interop.mkRangeselectorAttr("xanchor", "left");
            public static Box<IRangeselectorProperty> right() => Interop.mkRangeselectorAttr("xanchor", "right");
        }

        /// Sets the range selector's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the range selector.
        public static partial class Yanchor
        {
            public static Box<IRangeselectorProperty> auto() => Interop.mkRangeselectorAttr("yanchor", "auto");
            public static Box<IRangeselectorProperty> bottom() => Interop.mkRangeselectorAttr("yanchor", "bottom");
            public static Box<IRangeselectorProperty> middle() => Interop.mkRangeselectorAttr("yanchor", "middle");
            public static Box<IRangeselectorProperty> top() => Interop.mkRangeselectorAttr("yanchor", "top");
        }
    }
}