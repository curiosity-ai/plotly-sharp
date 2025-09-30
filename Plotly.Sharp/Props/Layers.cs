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



    public static partial class Layers
    {
        public static Box<ILayersProperty> layer(params Box<ILayerProperty>[] properties) => Interop.mkLayersAttr("layer", Bindings.flattenProperties(properties));
    }
}