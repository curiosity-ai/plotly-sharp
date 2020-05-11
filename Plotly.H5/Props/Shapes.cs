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

    public static partial class Shapes
    {
        public static Box<IShapesProperty> shape(params Box<IShapeProperty>[] properties) => Interop.mkShapesAttr("shape", Bindings.flattenProperties(properties));
    }
}