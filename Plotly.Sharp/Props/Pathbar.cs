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

    public static partial class Pathbar
    {
        /// Determines if the path bar is drawn i.e. outside the trace `domain` and with one pixel gap.
        public static Box<IPathbarProperty> visible(bool val) => Interop.mkPathbarAttr("visible", val);
        /// Sets the thickness of `pathbar` (in px). If not specified the `pathbar.textfont.size` is used with 3 pixles extra padding on each side.
        public static Box<IPathbarProperty> thickness(int val) => Interop.mkPathbarAttr("thickness", val);
        /// Sets the thickness of `pathbar` (in px). If not specified the `pathbar.textfont.size` is used with 3 pixles extra padding on each side.
        public static Box<IPathbarProperty> thickness(float val) => Interop.mkPathbarAttr("thickness", val);
        /// Sets the font used inside `pathbar`.
        public static Box<IPathbarProperty> textfont(params Box<ITextfontProperty>[] properties) => Interop.mkPathbarAttr("textfont", Bindings.flattenProperties(properties));
    }

    public static partial class Pathbar
    {
        /// Determines on which side of the the treemap the `pathbar` should be presented.
        public static partial class Side
        {
            public static Box<IPathbarProperty> bottom() => Interop.mkPathbarAttr("side", "bottom");
            public static Box<IPathbarProperty> top() => Interop.mkPathbarAttr("side", "top");
        }

        /// Determines which shape is used for edges between `barpath` labels.
        public static partial class Edgeshape
        {
            public static Box<IPathbarProperty> rightSlant() => Interop.mkPathbarAttr("edgeshape", "/");
            public static Box<IPathbarProperty> pointedLeft() => Interop.mkPathbarAttr("edgeshape", "<");
            public static Box<IPathbarProperty> pointedRight() => Interop.mkPathbarAttr("edgeshape", ">");
            public static Box<IPathbarProperty> leftSlant() => Interop.mkPathbarAttr("edgeshape", "\\");
            public static Box<IPathbarProperty> straight() => Interop.mkPathbarAttr("edgeshape", "|");
        }
    }
}