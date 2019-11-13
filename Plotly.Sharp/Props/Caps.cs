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

    public static partial class Caps
    {
        public static Box<ICapsProperty> x(params Box<IXProperty>[] properties) => Interop.mkCapsAttr("x", Bindings.flattenProperties(properties));
        public static Box<ICapsProperty> y(params Box<IYProperty>[] properties) => Interop.mkCapsAttr("y", Bindings.flattenProperties(properties));
        public static Box<ICapsProperty> z(params Box<IZProperty>[] properties) => Interop.mkCapsAttr("z", Bindings.flattenProperties(properties));
    }
}