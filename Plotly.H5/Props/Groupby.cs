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

    public static partial class Groupby
    {
        /// Determines whether this group-by transform is enabled or disabled.
        public static Box<IGroupbyProperty> enabled(bool val) => Interop.mkGroupbyAttr("enabled", val);
        /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
        public static Box<IGroupbyProperty> groups(bool val) => Interop.mkGroupbyAttr("groups", new[]{val});
        /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
        public static Box<IGroupbyProperty> groups(params bool[] values) => Interop.mkGroupbyAttr("groups", values);
        /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
        public static Box<IGroupbyProperty> groups(System.DateTime val) => Interop.mkGroupbyAttr("groups", new[]{val});
        /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
        public static Box<IGroupbyProperty> groups(params System.DateTime[] values) => Interop.mkGroupbyAttr("groups", values);
        /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
        public static Box<IGroupbyProperty> groups(float val) => Interop.mkGroupbyAttr("groups", new[]{val});
        /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
        public static Box<IGroupbyProperty> groups(params float[] values) => Interop.mkGroupbyAttr("groups", values);
        /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
        public static Box<IGroupbyProperty> groups(int val) => Interop.mkGroupbyAttr("groups", new[]{val});
        /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
        public static Box<IGroupbyProperty> groups(params int[] values) => Interop.mkGroupbyAttr("groups", values);
        /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
        public static Box<IGroupbyProperty> groups(string val) => Interop.mkGroupbyAttr("groups", new[]{val});
        /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
        public static Box<IGroupbyProperty> groups(params string[] values) => Interop.mkGroupbyAttr("groups", values);
        /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
        public static Box<IGroupbyProperty> groups(IEnumerable<bool[]> values) => Interop.mkGroupbyAttr("groups", Bindings.flatten2DArrayIf1D(values));
        /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
        public static Box<IGroupbyProperty> groups(List<bool[]> values) => Interop.mkGroupbyAttr("groups", Bindings.flatten2DArrayIf1D(values));
        /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
        public static Box<IGroupbyProperty> groups(params bool[][] values) => Interop.mkGroupbyAttr("groups", Bindings.flatten2DArrayIf1D(values));
        /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
        public static Box<IGroupbyProperty> groups(IEnumerable<IEnumerable<string>> values) => Interop.mkGroupbyAttr("groups", Bindings.flatten2DArrayIf1D(values));
        /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
        public static Box<IGroupbyProperty> groups(List<string[]> values) => Interop.mkGroupbyAttr("groups", Bindings.flatten2DArrayIf1D(values));
        /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
        public static Box<IGroupbyProperty> groups(params string[][] values) => Interop.mkGroupbyAttr("groups", Bindings.flatten2DArrayIf1D(values));
        /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
        public static Box<IGroupbyProperty> groups(IEnumerable<IEnumerable<int>> values) => Interop.mkGroupbyAttr("groups", Bindings.flatten2DArrayIf1D(values));
        /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
        public static Box<IGroupbyProperty> groups(List<int[]> values) => Interop.mkGroupbyAttr("groups", Bindings.flatten2DArrayIf1D(values));
        /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
        public static Box<IGroupbyProperty> groups(params int[][] values) => Interop.mkGroupbyAttr("groups", Bindings.flatten2DArrayIf1D(values));
        /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
        public static Box<IGroupbyProperty> groups(IEnumerable<IEnumerable<float>> values) => Interop.mkGroupbyAttr("groups", Bindings.flatten2DArrayIf1D(values));
        /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
        public static Box<IGroupbyProperty> groups(List<float[]> values) => Interop.mkGroupbyAttr("groups", Bindings.flatten2DArrayIf1D(values));
        /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
        public static Box<IGroupbyProperty> groups(params float[][] values) => Interop.mkGroupbyAttr("groups", Bindings.flatten2DArrayIf1D(values));
        /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
        public static Box<IGroupbyProperty> groups(Literals.PlotData[] values) => Interop.mkGroupbyAttr("groups", values);
        /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
        public static Box<IGroupbyProperty> groups(IEnumerable<bool?> values) => Interop.mkGroupbyAttr("groups", values.ToArray());
        /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
        public static Box<IGroupbyProperty> groups(IEnumerable<System.DateTime?> values) => Interop.mkGroupbyAttr("groups", values.ToArray());
        /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
        public static Box<IGroupbyProperty> groups(IEnumerable<int?> values) => Interop.mkGroupbyAttr("groups", values.ToArray());
        /// Sets the groups in which the trace data will be split. For example, with `x` set to *[1, 2, 3, 4]* and `groups` set to *['a', 'b', 'a', 'b']*, the groupby transform with split in one trace with `x` [1, 3] and one trace with `x` [2, 4].
        public static Box<IGroupbyProperty> groups(IEnumerable<float?> values) => Interop.mkGroupbyAttr("groups", values.ToArray());
        /// Pattern by which grouped traces are named. If only one trace is present, defaults to the group name (`\"%{group}\"`), otherwise defaults to the group name with trace name (`\"%{group} (%{trace})\"`). Available escape sequences are `%{group}`, which inserts the group name, and `%{trace}`, which inserts the trace name. If grouping GDP data by country when more than one trace is present, for example, the default \"%{group} (%{trace})\" would return \"Monaco (GDP per capita)\".
        public static Box<IGroupbyProperty> nameformat(string val) => Interop.mkGroupbyAttr("nameformat", val);
        public static Box<IGroupbyProperty> styles(params Box<IStylesProperty>[] properties) => Interop.mkGroupbyAttr("styles", Bindings.flattenPropertiesToArray(properties));
        /// Sets the source reference on plot.ly for  groups .
        public static Box<IGroupbyProperty> groupssrc(string val) => Interop.mkGroupbyAttr("groupssrc", val);
    }
}