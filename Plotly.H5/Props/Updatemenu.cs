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

    public static partial class Updatemenu
    {
        /// Determines whether or not the update menu is visible.
        public static Box<IUpdatemenuProperty> visible(bool val) => Interop.mkUpdatemenuAttr("visible", val);
        /// Determines which button (by index starting from 0) is considered active.
        public static Box<IUpdatemenuProperty> active(int val) => Interop.mkUpdatemenuAttr("active", val);
        /// Highlights active dropdown item or active button if true.
        public static Box<IUpdatemenuProperty> showactive(bool val) => Interop.mkUpdatemenuAttr("showactive", val);
        public static Box<IUpdatemenuProperty> buttons(params Box<IButtonsProperty>[] properties) => Interop.mkUpdatemenuAttr("buttons", Bindings.flattenProperties(properties));
        /// Sets the x position (in normalized coordinates) of the update menu.
        public static Box<IUpdatemenuProperty> x(int val) => Interop.mkUpdatemenuAttr("x", val);
        /// Sets the x position (in normalized coordinates) of the update menu.
        public static Box<IUpdatemenuProperty> x(float val) => Interop.mkUpdatemenuAttr("x", val);
        /// Sets the y position (in normalized coordinates) of the update menu.
        public static Box<IUpdatemenuProperty> y(int val) => Interop.mkUpdatemenuAttr("y", val);
        /// Sets the y position (in normalized coordinates) of the update menu.
        public static Box<IUpdatemenuProperty> y(float val) => Interop.mkUpdatemenuAttr("y", val);
        /// Sets the padding around the buttons or dropdown menu.
        public static Box<IUpdatemenuProperty> pad(params Box<IPadProperty>[] properties) => Interop.mkUpdatemenuAttr("pad", Bindings.flattenProperties(properties));
        /// Sets the font of the update menu button text.
        public static Box<IUpdatemenuProperty> font(params Box<IFontProperty>[] properties) => Interop.mkUpdatemenuAttr("font", Bindings.flattenProperties(properties));
        /// Sets the background color of the update menu buttons.
        public static Box<IUpdatemenuProperty> bgcolor(string val) => Interop.mkUpdatemenuAttr("bgcolor", val);
        /// Sets the color of the border enclosing the update menu.
        public static Box<IUpdatemenuProperty> bordercolor(string val) => Interop.mkUpdatemenuAttr("bordercolor", val);
        /// Sets the width (in px) of the border enclosing the update menu.
        public static Box<IUpdatemenuProperty> borderwidth(int val) => Interop.mkUpdatemenuAttr("borderwidth", val);
        /// Sets the width (in px) of the border enclosing the update menu.
        public static Box<IUpdatemenuProperty> borderwidth(float val) => Interop.mkUpdatemenuAttr("borderwidth", val);
        /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
        public static Box<IUpdatemenuProperty> name(string val) => Interop.mkUpdatemenuAttr("name", val);
        /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
        public static Box<IUpdatemenuProperty> templateitemname(string val) => Interop.mkUpdatemenuAttr("templateitemname", val);
    }

    public static partial class Updatemenu
    {
        /// Determines whether the buttons are accessible via a dropdown menu or whether the buttons are stacked horizontally or vertically
        public static partial class _type
        {
            public static Box<IUpdatemenuProperty> buttons() => Interop.mkUpdatemenuAttr("type", "buttons");
            public static Box<IUpdatemenuProperty> dropdown() => Interop.mkUpdatemenuAttr("type", "dropdown");
        }

        /// Determines the direction in which the buttons are laid out, whether in a dropdown menu or a row/column of buttons. For `left` and `up`, the buttons will still appear in left-to-right or top-to-bottom order respectively.
        public static partial class Direction
        {
            public static Box<IUpdatemenuProperty> down() => Interop.mkUpdatemenuAttr("direction", "down");
            public static Box<IUpdatemenuProperty> left() => Interop.mkUpdatemenuAttr("direction", "left");
            public static Box<IUpdatemenuProperty> right() => Interop.mkUpdatemenuAttr("direction", "right");
            public static Box<IUpdatemenuProperty> up() => Interop.mkUpdatemenuAttr("direction", "up");
        }

        /// Sets the update menu's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the range selector.
        public static partial class Xanchor
        {
            public static Box<IUpdatemenuProperty> auto() => Interop.mkUpdatemenuAttr("xanchor", "auto");
            public static Box<IUpdatemenuProperty> center() => Interop.mkUpdatemenuAttr("xanchor", "center");
            public static Box<IUpdatemenuProperty> left() => Interop.mkUpdatemenuAttr("xanchor", "left");
            public static Box<IUpdatemenuProperty> right() => Interop.mkUpdatemenuAttr("xanchor", "right");
        }

        /// Sets the update menu's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the range selector.
        public static partial class Yanchor
        {
            public static Box<IUpdatemenuProperty> auto() => Interop.mkUpdatemenuAttr("yanchor", "auto");
            public static Box<IUpdatemenuProperty> bottom() => Interop.mkUpdatemenuAttr("yanchor", "bottom");
            public static Box<IUpdatemenuProperty> middle() => Interop.mkUpdatemenuAttr("yanchor", "middle");
            public static Box<IUpdatemenuProperty> top() => Interop.mkUpdatemenuAttr("yanchor", "top");
        }
    }
}