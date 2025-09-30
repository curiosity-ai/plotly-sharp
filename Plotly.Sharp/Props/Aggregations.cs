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



    public static partial class Aggregations
    {
        public static Box<IAggregationsProperty> aggregation(params Box<IAggregationProperty>[] properties) => Interop.mkAggregationsAttr("aggregation", Bindings.flattenProperties(properties));
    }
}