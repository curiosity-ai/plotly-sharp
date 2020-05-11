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

    public static partial class Layers
    {
        public static Box<ILayersProperty> layer(params Box<ILayerProperty>[] properties) => Interop.mkLayersAttr("layer", Bindings.flattenProperties(properties));
    }
}