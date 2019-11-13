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

    public static partial class Border
    {
        /// Sets the stroke color. It accepts a specific color. If the color is not fully opaque and there are hundreds of thousands of points, it may cause slower zooming and panning.
        public static Box<IBorderProperty> color(string val) => Interop.mkBorderAttr("color", val);
        /// Specifies what fraction of the marker area is covered with the border.
        public static Box<IBorderProperty> arearatio(int val) => Interop.mkBorderAttr("arearatio", val);
        /// Specifies what fraction of the marker area is covered with the border.
        public static Box<IBorderProperty> arearatio(float val) => Interop.mkBorderAttr("arearatio", val);
    }
}