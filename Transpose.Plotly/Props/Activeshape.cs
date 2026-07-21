namespace Transpose.Plotly
{
    /*////////////////////////////////
    /// THIS FILE IS AUTO-GENERATED //
    ///      by propsDocument       //
    ////////////////////////////////*/
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Types;
    using Transpose;
    using static Transpose.Core.dom;

    public static partial class Activeshape
    {
        /// Sets the color filling the active shape' interior.
        public static Box<IActiveshapeProperty> fillcolor(string val) => Interop.mkActiveshapeAttr("fillcolor", val);
        /// Sets the opacity of the active shape.
        public static Box<IActiveshapeProperty> opacity(int val) => Interop.mkActiveshapeAttr("opacity", val);
        /// Sets the opacity of the active shape.
        public static Box<IActiveshapeProperty> opacity(float val) => Interop.mkActiveshapeAttr("opacity", val);
    }
}