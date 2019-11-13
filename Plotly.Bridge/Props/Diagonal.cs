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

    public static partial class Diagonal
    {
        /// Determines whether or not subplots on the diagonal are displayed.
        public static Box<IDiagonalProperty> visible(bool val) => Interop.mkDiagonalAttr("visible", val);
    }
}