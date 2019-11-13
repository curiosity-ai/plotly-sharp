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

    public static partial class Styles
    {
        public static Box<IStylesProperty> style(params Box<IStyleProperty>[] properties) => Interop.mkStylesAttr("style", Bindings.flattenProperties(properties));
    }
}