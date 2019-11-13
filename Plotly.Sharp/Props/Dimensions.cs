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

    public static partial class Dimensions
    {
        public static Box<IDimensionsProperty> dimension(params Box<IDimensionProperty>[] properties) => Interop.mkDimensionsAttr("dimension", Bindings.flattenProperties(properties));
    }
}