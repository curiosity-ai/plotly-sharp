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

    public static partial class Decreasing
    {
        public static Box<IDecreasingProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkDecreasingAttr("marker", Bindings.flattenProperties(properties));
        /// Sets the symbol to display for increasing value
        public static Box<IDecreasingProperty> symbol(string val) => Interop.mkDecreasingAttr("symbol", val);
        /// Sets the color for increasing value.
        public static Box<IDecreasingProperty> color(string val) => Interop.mkDecreasingAttr("color", val);
        public static Box<IDecreasingProperty> line(params Box<ILineProperty>[] properties) => Interop.mkDecreasingAttr("line", Bindings.flattenProperties(properties));
        /// Sets the fill color. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
        public static Box<IDecreasingProperty> fillcolor(string val) => Interop.mkDecreasingAttr("fillcolor", val);
    }
}