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

    public static partial class Sort
    {
        /// Determines whether this sort transform is enabled or disabled.
        public static Box<ISortProperty> enabled(bool val) => Interop.mkSortAttr("enabled", val);
        /// Sets the target by which the sort transform is applied. If a string, *target* is assumed to be a reference to a data array in the parent trace object. To sort about nested variables, use *.* to access them. For example, set `target` to *marker.size* to sort about the marker size array. If an array, *target* is then the data array by which the sort transform is applied.
        public static Box<ISortProperty> target(string val) => Interop.mkSortAttr("target", val);
        /// Sets the target by which the sort transform is applied. If a string, *target* is assumed to be a reference to a data array in the parent trace object. To sort about nested variables, use *.* to access them. For example, set `target` to *marker.size* to sort about the marker size array. If an array, *target* is then the data array by which the sort transform is applied.
        public static Box<ISortProperty> target(IEnumerable<string> values) => Interop.mkSortAttr("target", values.ToArray());
        /// Sets the source reference on plot.ly for  target .
        public static Box<ISortProperty> targetsrc(string val) => Interop.mkSortAttr("targetsrc", val);
    }

    public static partial class Sort
    {
        /// Sets the sort transform order.
        public static partial class Order
        {
            public static Box<ISortProperty> ascending() => Interop.mkSortAttr("order", "ascending");
            public static Box<ISortProperty> descending() => Interop.mkSortAttr("order", "descending");
        }
    }
}