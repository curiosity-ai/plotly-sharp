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

    public static partial class Slider
    {
        /// Determines whether or not the slider is visible.
        public static Box<ISliderProperty> visible(bool val) => Interop.mkSliderAttr("visible", val);
        /// Determines which button (by index starting from 0) is considered active.
        public static Box<ISliderProperty> active(int val) => Interop.mkSliderAttr("active", val);
        /// Determines which button (by index starting from 0) is considered active.
        public static Box<ISliderProperty> active(float val) => Interop.mkSliderAttr("active", val);
        public static Box<ISliderProperty> steps(params Box<IStepsProperty>[] properties) => Interop.mkSliderAttr("steps", Bindings.flattenProperties(properties));
        /// Sets the length of the slider This measure excludes the padding of both ends. That is, the slider's length is this length minus the padding on both ends.
        public static Box<ISliderProperty> len(int val) => Interop.mkSliderAttr("len", val);
        /// Sets the length of the slider This measure excludes the padding of both ends. That is, the slider's length is this length minus the padding on both ends.
        public static Box<ISliderProperty> len(float val) => Interop.mkSliderAttr("len", val);
        /// Sets the x position (in normalized coordinates) of the slider.
        public static Box<ISliderProperty> x(int val) => Interop.mkSliderAttr("x", val);
        /// Sets the x position (in normalized coordinates) of the slider.
        public static Box<ISliderProperty> x(float val) => Interop.mkSliderAttr("x", val);
        /// Set the padding of the slider component along each side.
        public static Box<ISliderProperty> pad(params Box<IPadProperty>[] properties) => Interop.mkSliderAttr("pad", Bindings.flattenProperties(properties));
        /// Sets the y position (in normalized coordinates) of the slider.
        public static Box<ISliderProperty> y(int val) => Interop.mkSliderAttr("y", val);
        /// Sets the y position (in normalized coordinates) of the slider.
        public static Box<ISliderProperty> y(float val) => Interop.mkSliderAttr("y", val);
        public static Box<ISliderProperty> transition(params Box<ITransitionProperty>[] properties) => Interop.mkSliderAttr("transition", Bindings.flattenProperties(properties));
        public static Box<ISliderProperty> currentvalue(params Box<ICurrentvalueProperty>[] properties) => Interop.mkSliderAttr("currentvalue", Bindings.flattenProperties(properties));
        /// Sets the font of the slider step labels.
        public static Box<ISliderProperty> font(params Box<IFontProperty>[] properties) => Interop.mkSliderAttr("font", Bindings.flattenProperties(properties));
        /// Sets the background color of the slider grip while dragging.
        public static Box<ISliderProperty> activebgcolor(string val) => Interop.mkSliderAttr("activebgcolor", val);
        /// Sets the background color of the slider.
        public static Box<ISliderProperty> bgcolor(string val) => Interop.mkSliderAttr("bgcolor", val);
        /// Sets the color of the border enclosing the slider.
        public static Box<ISliderProperty> bordercolor(string val) => Interop.mkSliderAttr("bordercolor", val);
        /// Sets the width (in px) of the border enclosing the slider.
        public static Box<ISliderProperty> borderwidth(int val) => Interop.mkSliderAttr("borderwidth", val);
        /// Sets the width (in px) of the border enclosing the slider.
        public static Box<ISliderProperty> borderwidth(float val) => Interop.mkSliderAttr("borderwidth", val);
        /// Sets the length in pixels of step tick marks
        public static Box<ISliderProperty> ticklen(int val) => Interop.mkSliderAttr("ticklen", val);
        /// Sets the length in pixels of step tick marks
        public static Box<ISliderProperty> ticklen(float val) => Interop.mkSliderAttr("ticklen", val);
        /// Sets the color of the border enclosing the slider.
        public static Box<ISliderProperty> tickcolor(string val) => Interop.mkSliderAttr("tickcolor", val);
        /// Sets the tick width (in px).
        public static Box<ISliderProperty> tickwidth(int val) => Interop.mkSliderAttr("tickwidth", val);
        /// Sets the tick width (in px).
        public static Box<ISliderProperty> tickwidth(float val) => Interop.mkSliderAttr("tickwidth", val);
        /// Sets the length in pixels of minor step tick marks
        public static Box<ISliderProperty> minorticklen(int val) => Interop.mkSliderAttr("minorticklen", val);
        /// Sets the length in pixels of minor step tick marks
        public static Box<ISliderProperty> minorticklen(float val) => Interop.mkSliderAttr("minorticklen", val);
        /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
        public static Box<ISliderProperty> name(string val) => Interop.mkSliderAttr("name", val);
        /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
        public static Box<ISliderProperty> templateitemname(string val) => Interop.mkSliderAttr("templateitemname", val);
    }

    public static partial class Slider
    {
        /// Determines whether this slider length is set in units of plot *fraction* or in *pixels. Use `len` to set the value.
        public static partial class Lenmode
        {
            public static Box<ISliderProperty> fraction() => Interop.mkSliderAttr("lenmode", "fraction");
            public static Box<ISliderProperty> pixels() => Interop.mkSliderAttr("lenmode", "pixels");
        }

        /// Sets the slider's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the range selector.
        public static partial class Xanchor
        {
            public static Box<ISliderProperty> auto() => Interop.mkSliderAttr("xanchor", "auto");
            public static Box<ISliderProperty> center() => Interop.mkSliderAttr("xanchor", "center");
            public static Box<ISliderProperty> left() => Interop.mkSliderAttr("xanchor", "left");
            public static Box<ISliderProperty> right() => Interop.mkSliderAttr("xanchor", "right");
        }

        /// Sets the slider's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the range selector.
        public static partial class Yanchor
        {
            public static Box<ISliderProperty> auto() => Interop.mkSliderAttr("yanchor", "auto");
            public static Box<ISliderProperty> bottom() => Interop.mkSliderAttr("yanchor", "bottom");
            public static Box<ISliderProperty> middle() => Interop.mkSliderAttr("yanchor", "middle");
            public static Box<ISliderProperty> top() => Interop.mkSliderAttr("yanchor", "top");
        }
    }
}