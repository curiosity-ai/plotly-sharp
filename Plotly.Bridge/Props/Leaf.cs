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

    public static partial class Leaf
    {
        /// Sets the opacity of the leaves. With colorscale it is defaulted to 1; otherwise it is defaulted to 0.7
        public static Box<ILeafProperty> opacity(int val) => Interop.mkLeafAttr("opacity", val);
        /// Sets the opacity of the leaves. With colorscale it is defaulted to 1; otherwise it is defaulted to 0.7
        public static Box<ILeafProperty> opacity(float val) => Interop.mkLeafAttr("opacity", val);
    }
}