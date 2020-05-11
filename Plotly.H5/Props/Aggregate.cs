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
    using static Retyped.dom;

    public static partial class Aggregate
    {
        /// Determines whether this aggregate transform is enabled or disabled.
        public static Box<IAggregateProperty> enabled(bool val) => Interop.mkAggregateAttr("enabled", val);
        /// Sets the grouping target to which the aggregation is applied. Data points with matching group values will be coalesced into one point, using the supplied aggregation functions to reduce data in other data arrays. If a string, `groups` is assumed to be a reference to a data array in the parent trace object. To aggregate by nested variables, use *.* to access them. For example, set `groups` to *marker.color* to aggregate about the marker color array. If an array, `groups` is itself the data array by which we aggregate.
        public static Box<IAggregateProperty> groups(string val) => Interop.mkAggregateAttr("groups", val);
        /// Sets the grouping target to which the aggregation is applied. Data points with matching group values will be coalesced into one point, using the supplied aggregation functions to reduce data in other data arrays. If a string, `groups` is assumed to be a reference to a data array in the parent trace object. To aggregate by nested variables, use *.* to access them. For example, set `groups` to *marker.color* to aggregate about the marker color array. If an array, `groups` is itself the data array by which we aggregate.
        public static Box<IAggregateProperty> groups(IEnumerable<string> values) => Interop.mkAggregateAttr("groups", values.ToArray());
        public static Box<IAggregateProperty> aggregations(params Box<IAggregationsProperty>[] properties) => Interop.mkAggregateAttr("aggregations", Bindings.flattenProperties(properties));
        /// Sets the source reference on plot.ly for  groups .
        public static Box<IAggregateProperty> groupssrc(string val) => Interop.mkAggregateAttr("groupssrc", val);
    }
}