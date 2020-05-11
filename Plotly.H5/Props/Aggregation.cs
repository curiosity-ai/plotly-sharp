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

    public static partial class Aggregation
    {
        /// A reference to the data array in the parent trace to aggregate. To aggregate by nested variables, use *.* to access them. For example, set `groups` to *marker.color* to aggregate over the marker color array. The referenced array must already exist, unless `func` is *count*, and each array may only be referenced once.
        public static Box<IAggregationProperty> target(string val) => Interop.mkAggregationAttr("target", val);
        /// Determines whether this aggregation function is enabled or disabled.
        public static Box<IAggregationProperty> enabled(bool val) => Interop.mkAggregationAttr("enabled", val);
    }

    public static partial class Aggregation
    {
        /// Sets the aggregation function. All values from the linked `target`, corresponding to the same value in the `groups` array, are collected and reduced by this function. *count* is simply the number of values in the `groups` array, so does not even require the linked array to exist. *first* (*last*) is just the first (last) linked value. Invalid values are ignored, so for example in *avg* they do not contribute to either the numerator or the denominator. Any data type (numeric, date, category) may be aggregated with any function, even though in certain cases it is unlikely to make sense, for example a sum of dates or average of categories. *median* will return the average of the two central values if there is an even count. *mode* will return the first value to reach the maximum count, in case of a tie. *change* will return the difference between the first and last linked values. *range* will return the difference between the min and max linked values.
        public static partial class Func
        {
            public static Box<IAggregationProperty> avg() => Interop.mkAggregationAttr("func", "avg");
            public static Box<IAggregationProperty> change() => Interop.mkAggregationAttr("func", "change");
            public static Box<IAggregationProperty> count() => Interop.mkAggregationAttr("func", "count");
            public static Box<IAggregationProperty> first() => Interop.mkAggregationAttr("func", "first");
            public static Box<IAggregationProperty> last() => Interop.mkAggregationAttr("func", "last");
            public static Box<IAggregationProperty> max() => Interop.mkAggregationAttr("func", "max");
            public static Box<IAggregationProperty> median() => Interop.mkAggregationAttr("func", "median");
            public static Box<IAggregationProperty> min() => Interop.mkAggregationAttr("func", "min");
            public static Box<IAggregationProperty> mode() => Interop.mkAggregationAttr("func", "mode");
            public static Box<IAggregationProperty> range() => Interop.mkAggregationAttr("func", "range");
            public static Box<IAggregationProperty> rms() => Interop.mkAggregationAttr("func", "rms");
            public static Box<IAggregationProperty> stddev() => Interop.mkAggregationAttr("func", "stddev");
            public static Box<IAggregationProperty> sum() => Interop.mkAggregationAttr("func", "sum");
        }

        /// *stddev* supports two formula variants: *sample* (normalize by N-1) and *population* (normalize by N).
        public static partial class Funcmode
        {
            public static Box<IAggregationProperty> population() => Interop.mkAggregationAttr("funcmode", "population");
            public static Box<IAggregationProperty> sample() => Interop.mkAggregationAttr("funcmode", "sample");
        }
    }
}