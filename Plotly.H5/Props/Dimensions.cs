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

    public static partial class Dimensions
    {
        public static Box<IDimensionsProperty> dimension(params Box<IDimensionProperty>[] properties) => Interop.mkDimensionsAttr("dimension", Bindings.flattenProperties(properties));
    }
}