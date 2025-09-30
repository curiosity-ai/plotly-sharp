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



    public static partial class Newshape
    {
        public static Box<INewshapeProperty> line(params Box<ILineProperty>[] properties) => Interop.mkNewshapeAttr("line", Bindings.flattenProperties(properties));
        /// Sets the color filling new shapes' interior. Please note that if using a fillcolor with alpha greater than half, drag inside the active shape starts moving the shape underneath, otherwise a new shape could be started over.
        public static Box<INewshapeProperty> fillcolor(string val) => Interop.mkNewshapeAttr("fillcolor", val);
        /// Sets the opacity of new shapes.
        public static Box<INewshapeProperty> opacity(int val) => Interop.mkNewshapeAttr("opacity", val);
        /// Sets the opacity of new shapes.
        public static Box<INewshapeProperty> opacity(float val) => Interop.mkNewshapeAttr("opacity", val);
    }

    public static partial class Newshape
    {
        /// Determines the path's interior. For more info please visit https://developer.mozilla.org/en-US/docs/Web/SVG/Attribute/fill-rule
        public static partial class Fillrule
        {
            public static Box<INewshapeProperty> evenodd() => Interop.mkNewshapeAttr("fillrule", "evenodd");
            public static Box<INewshapeProperty> nonzero() => Interop.mkNewshapeAttr("fillrule", "nonzero");
        }

        /// Specifies whether new shapes are drawn below or above traces.
        public static partial class Layer
        {
            public static Box<INewshapeProperty> above() => Interop.mkNewshapeAttr("layer", "above");
            public static Box<INewshapeProperty> below() => Interop.mkNewshapeAttr("layer", "below");
        }

        /// When `dragmode` is set to *drawrect*, *drawline* or *drawcircle* this limits the drag to be horizontal, vertical or diagonal. Using *diagonal* there is no limit e.g. in drawing lines in any direction. *ortho* limits the draw to be either horizontal or vertical. *horizontal* allows horizontal extend. *vertical* allows vertical extend.
        public static partial class Drawdirection
        {
            public static Box<INewshapeProperty> diagonal() => Interop.mkNewshapeAttr("drawdirection", "diagonal");
            public static Box<INewshapeProperty> horizontal() => Interop.mkNewshapeAttr("drawdirection", "horizontal");
            public static Box<INewshapeProperty> ortho() => Interop.mkNewshapeAttr("drawdirection", "ortho");
            public static Box<INewshapeProperty> vertical() => Interop.mkNewshapeAttr("drawdirection", "vertical");
        }
    }
}