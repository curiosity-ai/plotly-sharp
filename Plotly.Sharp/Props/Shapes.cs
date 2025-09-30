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



    public static partial class Shapes
    {
        public static Box<IShapesProperty> shape(params Box<IShapeProperty>[] properties) => Interop.mkShapesAttr("shape", Bindings.flattenProperties(properties));
    }
}