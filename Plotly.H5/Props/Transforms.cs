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

    public static partial class Transforms
    {
        public static Box<ITransformsProperty> aggregate(params Box<IAggregateProperty>[] properties) => Interop.mkTransformsAttr("aggregate", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkAggregateAttr("type", "aggregate")})));
        public static Box<ITransformsProperty> filter(params Box<IFilterProperty>[] properties) => Interop.mkTransformsAttr("filter", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkFilterAttr("type", "filter")})));
        public static Box<ITransformsProperty> groupby(params Box<IGroupbyProperty>[] properties) => Interop.mkTransformsAttr("groupby", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkGroupbyAttr("type", "groupby")})));
        public static Box<ITransformsProperty> sort(params Box<ISortProperty>[] properties) => Interop.mkTransformsAttr("sort", Bindings.flattenProperties(properties.Concat(new[]{Interop.mkSortAttr("type", "sort")})));
    }
}