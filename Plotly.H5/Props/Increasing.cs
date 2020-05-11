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

    public static partial class Increasing
    {
        public static Box<IIncreasingProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkIncreasingAttr("marker", Bindings.flattenProperties(properties));
        /// Sets the symbol to display for increasing value
        public static Box<IIncreasingProperty> symbol(string val) => Interop.mkIncreasingAttr("symbol", val);
        /// Sets the color for increasing value.
        public static Box<IIncreasingProperty> color(string val) => Interop.mkIncreasingAttr("color", val);
        public static Box<IIncreasingProperty> line(params Box<ILineProperty>[] properties) => Interop.mkIncreasingAttr("line", Bindings.flattenProperties(properties));
        /// Sets the fill color. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
        public static Box<IIncreasingProperty> fillcolor(string val) => Interop.mkIncreasingAttr("fillcolor", val);
    }
}