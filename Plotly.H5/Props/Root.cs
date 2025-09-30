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

    public static partial class Root
    {
        /// sets the color of the root node for a sunburst/treemap/icicle trace. this has no effect when a colorscale is used to set the markers.
        public static Box<IRootProperty> color(string val) => Interop.mkRootAttr("color", val);
    }
}