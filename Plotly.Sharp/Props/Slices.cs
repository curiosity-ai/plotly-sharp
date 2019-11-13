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

    public static partial class Slices
    {
        public static Box<ISlicesProperty> x(params Box<IXProperty>[] properties) => Interop.mkSlicesAttr("x", Bindings.flattenProperties(properties));
        public static Box<ISlicesProperty> y(params Box<IYProperty>[] properties) => Interop.mkSlicesAttr("y", Bindings.flattenProperties(properties));
        public static Box<ISlicesProperty> z(params Box<IZProperty>[] properties) => Interop.mkSlicesAttr("z", Bindings.flattenProperties(properties));
    }
}