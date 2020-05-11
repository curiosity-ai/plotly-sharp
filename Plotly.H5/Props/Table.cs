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

    public static partial class Table
    {
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<ITableProperty> name(string val) => Interop.mkTableAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<ITableProperty> uid(string val) => Interop.mkTableAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITableProperty> ids(bool val) => Interop.mkTableAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITableProperty> ids(params bool[] values) => Interop.mkTableAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITableProperty> ids(System.DateTime val) => Interop.mkTableAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITableProperty> ids(params System.DateTime[] values) => Interop.mkTableAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITableProperty> ids(float val) => Interop.mkTableAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITableProperty> ids(params float[] values) => Interop.mkTableAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITableProperty> ids(int val) => Interop.mkTableAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITableProperty> ids(params int[] values) => Interop.mkTableAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITableProperty> ids(string val) => Interop.mkTableAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITableProperty> ids(params string[] values) => Interop.mkTableAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITableProperty> ids(IEnumerable<bool[]> values) => Interop.mkTableAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITableProperty> ids(List<bool[]> values) => Interop.mkTableAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITableProperty> ids(params bool[][] values) => Interop.mkTableAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITableProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkTableAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITableProperty> ids(List<string[]> values) => Interop.mkTableAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITableProperty> ids(params string[][] values) => Interop.mkTableAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITableProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkTableAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITableProperty> ids(List<int[]> values) => Interop.mkTableAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITableProperty> ids(params int[][] values) => Interop.mkTableAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITableProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkTableAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITableProperty> ids(List<float[]> values) => Interop.mkTableAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITableProperty> ids(params float[][] values) => Interop.mkTableAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITableProperty> ids(Literals.PlotData[] values) => Interop.mkTableAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITableProperty> ids(IEnumerable<bool?> values) => Interop.mkTableAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITableProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkTableAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITableProperty> ids(IEnumerable<int?> values) => Interop.mkTableAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITableProperty> ids(IEnumerable<float?> values) => Interop.mkTableAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITableProperty> customdata(bool val) => Interop.mkTableAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITableProperty> customdata(params bool[] values) => Interop.mkTableAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITableProperty> customdata(System.DateTime val) => Interop.mkTableAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITableProperty> customdata(params System.DateTime[] values) => Interop.mkTableAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITableProperty> customdata(float val) => Interop.mkTableAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITableProperty> customdata(params float[] values) => Interop.mkTableAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITableProperty> customdata(int val) => Interop.mkTableAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITableProperty> customdata(params int[] values) => Interop.mkTableAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITableProperty> customdata(string val) => Interop.mkTableAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITableProperty> customdata(params string[] values) => Interop.mkTableAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITableProperty> customdata(IEnumerable<bool[]> values) => Interop.mkTableAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITableProperty> customdata(List<bool[]> values) => Interop.mkTableAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITableProperty> customdata(params bool[][] values) => Interop.mkTableAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITableProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkTableAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITableProperty> customdata(List<string[]> values) => Interop.mkTableAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITableProperty> customdata(params string[][] values) => Interop.mkTableAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITableProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkTableAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITableProperty> customdata(List<int[]> values) => Interop.mkTableAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITableProperty> customdata(params int[][] values) => Interop.mkTableAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITableProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkTableAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITableProperty> customdata(List<float[]> values) => Interop.mkTableAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITableProperty> customdata(params float[][] values) => Interop.mkTableAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITableProperty> customdata(Literals.PlotData[] values) => Interop.mkTableAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITableProperty> customdata(IEnumerable<bool?> values) => Interop.mkTableAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITableProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkTableAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITableProperty> customdata(IEnumerable<int?> values) => Interop.mkTableAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITableProperty> customdata(IEnumerable<float?> values) => Interop.mkTableAttr("customdata", values.ToArray());
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<ITableProperty> hoverinfo(params Box<ITableProperty>[] properties) => Interop.mkTableAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        public static Box<ITableProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkTableAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<ITableProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkTableAttr("stream", Bindings.flattenProperties(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ITableProperty> uirevision(bool val) => Interop.mkTableAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ITableProperty> uirevision(params bool[] values) => Interop.mkTableAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ITableProperty> uirevision(System.DateTime val) => Interop.mkTableAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ITableProperty> uirevision(params System.DateTime[] values) => Interop.mkTableAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ITableProperty> uirevision(int val) => Interop.mkTableAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ITableProperty> uirevision(params int[] values) => Interop.mkTableAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ITableProperty> uirevision(float val) => Interop.mkTableAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ITableProperty> uirevision(params float[] values) => Interop.mkTableAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ITableProperty> uirevision(string val) => Interop.mkTableAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ITableProperty> uirevision(params string[] values) => Interop.mkTableAttr("uirevision", values);
        public static Box<ITableProperty> domain(params Box<IDomainProperty>[] properties) => Interop.mkTableAttr("domain", Bindings.flattenProperties(properties));
        /// The width of columns expressed as a ratio. Columns fill the available width in proportion of their specified column widths.
        public static Box<ITableProperty> columnwidth(int val) => Interop.mkTableAttr("columnwidth", val);
        /// The width of columns expressed as a ratio. Columns fill the available width in proportion of their specified column widths.
        public static Box<ITableProperty> columnwidth(float val) => Interop.mkTableAttr("columnwidth", val);
        /// The width of columns expressed as a ratio. Columns fill the available width in proportion of their specified column widths.
        public static Box<ITableProperty> columnwidth(IEnumerable<int> values) => Interop.mkTableAttr("columnwidth", values.ToArray());
        /// The width of columns expressed as a ratio. Columns fill the available width in proportion of their specified column widths.
        public static Box<ITableProperty> columnwidth(IEnumerable<float> values) => Interop.mkTableAttr("columnwidth", values.ToArray());
        /// Specifies the rendered order of the data columns; for example, a value `2` at position `0` means that column index `0` in the data will be rendered as the third column, as columns have an index base of zero.
        public static Box<ITableProperty> columnorder(bool val) => Interop.mkTableAttr("columnorder", new[]{val});
        /// Specifies the rendered order of the data columns; for example, a value `2` at position `0` means that column index `0` in the data will be rendered as the third column, as columns have an index base of zero.
        public static Box<ITableProperty> columnorder(params bool[] values) => Interop.mkTableAttr("columnorder", values);
        /// Specifies the rendered order of the data columns; for example, a value `2` at position `0` means that column index `0` in the data will be rendered as the third column, as columns have an index base of zero.
        public static Box<ITableProperty> columnorder(System.DateTime val) => Interop.mkTableAttr("columnorder", new[]{val});
        /// Specifies the rendered order of the data columns; for example, a value `2` at position `0` means that column index `0` in the data will be rendered as the third column, as columns have an index base of zero.
        public static Box<ITableProperty> columnorder(params System.DateTime[] values) => Interop.mkTableAttr("columnorder", values);
        /// Specifies the rendered order of the data columns; for example, a value `2` at position `0` means that column index `0` in the data will be rendered as the third column, as columns have an index base of zero.
        public static Box<ITableProperty> columnorder(float val) => Interop.mkTableAttr("columnorder", new[]{val});
        /// Specifies the rendered order of the data columns; for example, a value `2` at position `0` means that column index `0` in the data will be rendered as the third column, as columns have an index base of zero.
        public static Box<ITableProperty> columnorder(params float[] values) => Interop.mkTableAttr("columnorder", values);
        /// Specifies the rendered order of the data columns; for example, a value `2` at position `0` means that column index `0` in the data will be rendered as the third column, as columns have an index base of zero.
        public static Box<ITableProperty> columnorder(int val) => Interop.mkTableAttr("columnorder", new[]{val});
        /// Specifies the rendered order of the data columns; for example, a value `2` at position `0` means that column index `0` in the data will be rendered as the third column, as columns have an index base of zero.
        public static Box<ITableProperty> columnorder(params int[] values) => Interop.mkTableAttr("columnorder", values);
        /// Specifies the rendered order of the data columns; for example, a value `2` at position `0` means that column index `0` in the data will be rendered as the third column, as columns have an index base of zero.
        public static Box<ITableProperty> columnorder(string val) => Interop.mkTableAttr("columnorder", new[]{val});
        /// Specifies the rendered order of the data columns; for example, a value `2` at position `0` means that column index `0` in the data will be rendered as the third column, as columns have an index base of zero.
        public static Box<ITableProperty> columnorder(params string[] values) => Interop.mkTableAttr("columnorder", values);
        /// Specifies the rendered order of the data columns; for example, a value `2` at position `0` means that column index `0` in the data will be rendered as the third column, as columns have an index base of zero.
        public static Box<ITableProperty> columnorder(IEnumerable<bool[]> values) => Interop.mkTableAttr("columnorder", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the rendered order of the data columns; for example, a value `2` at position `0` means that column index `0` in the data will be rendered as the third column, as columns have an index base of zero.
        public static Box<ITableProperty> columnorder(List<bool[]> values) => Interop.mkTableAttr("columnorder", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the rendered order of the data columns; for example, a value `2` at position `0` means that column index `0` in the data will be rendered as the third column, as columns have an index base of zero.
        public static Box<ITableProperty> columnorder(params bool[][] values) => Interop.mkTableAttr("columnorder", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the rendered order of the data columns; for example, a value `2` at position `0` means that column index `0` in the data will be rendered as the third column, as columns have an index base of zero.
        public static Box<ITableProperty> columnorder(IEnumerable<IEnumerable<string>> values) => Interop.mkTableAttr("columnorder", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the rendered order of the data columns; for example, a value `2` at position `0` means that column index `0` in the data will be rendered as the third column, as columns have an index base of zero.
        public static Box<ITableProperty> columnorder(List<string[]> values) => Interop.mkTableAttr("columnorder", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the rendered order of the data columns; for example, a value `2` at position `0` means that column index `0` in the data will be rendered as the third column, as columns have an index base of zero.
        public static Box<ITableProperty> columnorder(params string[][] values) => Interop.mkTableAttr("columnorder", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the rendered order of the data columns; for example, a value `2` at position `0` means that column index `0` in the data will be rendered as the third column, as columns have an index base of zero.
        public static Box<ITableProperty> columnorder(IEnumerable<IEnumerable<int>> values) => Interop.mkTableAttr("columnorder", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the rendered order of the data columns; for example, a value `2` at position `0` means that column index `0` in the data will be rendered as the third column, as columns have an index base of zero.
        public static Box<ITableProperty> columnorder(List<int[]> values) => Interop.mkTableAttr("columnorder", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the rendered order of the data columns; for example, a value `2` at position `0` means that column index `0` in the data will be rendered as the third column, as columns have an index base of zero.
        public static Box<ITableProperty> columnorder(params int[][] values) => Interop.mkTableAttr("columnorder", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the rendered order of the data columns; for example, a value `2` at position `0` means that column index `0` in the data will be rendered as the third column, as columns have an index base of zero.
        public static Box<ITableProperty> columnorder(IEnumerable<IEnumerable<float>> values) => Interop.mkTableAttr("columnorder", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the rendered order of the data columns; for example, a value `2` at position `0` means that column index `0` in the data will be rendered as the third column, as columns have an index base of zero.
        public static Box<ITableProperty> columnorder(List<float[]> values) => Interop.mkTableAttr("columnorder", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the rendered order of the data columns; for example, a value `2` at position `0` means that column index `0` in the data will be rendered as the third column, as columns have an index base of zero.
        public static Box<ITableProperty> columnorder(params float[][] values) => Interop.mkTableAttr("columnorder", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the rendered order of the data columns; for example, a value `2` at position `0` means that column index `0` in the data will be rendered as the third column, as columns have an index base of zero.
        public static Box<ITableProperty> columnorder(Literals.PlotData[] values) => Interop.mkTableAttr("columnorder", values);
        /// Specifies the rendered order of the data columns; for example, a value `2` at position `0` means that column index `0` in the data will be rendered as the third column, as columns have an index base of zero.
        public static Box<ITableProperty> columnorder(IEnumerable<bool?> values) => Interop.mkTableAttr("columnorder", values.ToArray());
        /// Specifies the rendered order of the data columns; for example, a value `2` at position `0` means that column index `0` in the data will be rendered as the third column, as columns have an index base of zero.
        public static Box<ITableProperty> columnorder(IEnumerable<System.DateTime?> values) => Interop.mkTableAttr("columnorder", values.ToArray());
        /// Specifies the rendered order of the data columns; for example, a value `2` at position `0` means that column index `0` in the data will be rendered as the third column, as columns have an index base of zero.
        public static Box<ITableProperty> columnorder(IEnumerable<int?> values) => Interop.mkTableAttr("columnorder", values.ToArray());
        /// Specifies the rendered order of the data columns; for example, a value `2` at position `0` means that column index `0` in the data will be rendered as the third column, as columns have an index base of zero.
        public static Box<ITableProperty> columnorder(IEnumerable<float?> values) => Interop.mkTableAttr("columnorder", values.ToArray());
        public static Box<ITableProperty> header(params Box<IHeaderProperty>[] properties) => Interop.mkTableAttr("header", Bindings.flattenProperties(properties));
        public static Box<ITableProperty> cells(params Box<ICellsProperty>[] properties) => Interop.mkTableAttr("cells", Bindings.flattenProperties(properties));
        /// Sets the source reference on plot.ly for  ids .
        public static Box<ITableProperty> idssrc(string val) => Interop.mkTableAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<ITableProperty> customdatasrc(string val) => Interop.mkTableAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<ITableProperty> metasrc(string val) => Interop.mkTableAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<ITableProperty> hoverinfosrc(string val) => Interop.mkTableAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  columnwidth .
        public static Box<ITableProperty> columnwidthsrc(string val) => Interop.mkTableAttr("columnwidthsrc", val);
        /// Sets the source reference on plot.ly for  columnorder .
        public static Box<ITableProperty> columnordersrc(string val) => Interop.mkTableAttr("columnordersrc", val);
    }

    public static partial class Table
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<ITableProperty> legendonly() => Interop.mkTableAttr("visible", "legendonly");
            public static Box<ITableProperty> _false() => Interop.mkTableAttr("visible", false);
            public static Box<ITableProperty> _true() => Interop.mkTableAttr("visible", true);
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<ITableProperty> all() => Interop.mkTableAttr("hoverinfo", "all");
            public static Box<ITableProperty> none() => Interop.mkTableAttr("hoverinfo", "none");
            public static Box<ITableProperty> skip() => Interop.mkTableAttr("hoverinfo", "skip");
            public static Box<ITableProperty> name() => Interop.mkTableAttr("hoverinfo", "name");
            public static Box<ITableProperty> text() => Interop.mkTableAttr("hoverinfo", "text");
            public static Box<ITableProperty> x() => Interop.mkTableAttr("hoverinfo", "x");
            public static Box<ITableProperty> y() => Interop.mkTableAttr("hoverinfo", "y");
            public static Box<ITableProperty> z() => Interop.mkTableAttr("hoverinfo", "z");
        }
    }
}