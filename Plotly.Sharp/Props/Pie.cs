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

    public static partial class Pie
    {
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IPieProperty> showlegend(bool val) => Interop.mkPieAttr("showlegend", val);
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IPieProperty> legendgroup(string val) => Interop.mkPieAttr("legendgroup", val);
        /// Sets the opacity of the trace.
        public static Box<IPieProperty> opacity(int val) => Interop.mkPieAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<IPieProperty> opacity(float val) => Interop.mkPieAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IPieProperty> name(string val) => Interop.mkPieAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IPieProperty> uid(string val) => Interop.mkPieAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPieProperty> ids(bool val) => Interop.mkPieAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPieProperty> ids(params bool[] values) => Interop.mkPieAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPieProperty> ids(System.DateTime val) => Interop.mkPieAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPieProperty> ids(params System.DateTime[] values) => Interop.mkPieAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPieProperty> ids(float val) => Interop.mkPieAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPieProperty> ids(params float[] values) => Interop.mkPieAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPieProperty> ids(int val) => Interop.mkPieAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPieProperty> ids(params int[] values) => Interop.mkPieAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPieProperty> ids(string val) => Interop.mkPieAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPieProperty> ids(params string[] values) => Interop.mkPieAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPieProperty> ids(IEnumerable<bool[]> values) => Interop.mkPieAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPieProperty> ids(List<bool[]> values) => Interop.mkPieAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPieProperty> ids(params bool[][] values) => Interop.mkPieAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPieProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkPieAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPieProperty> ids(List<string[]> values) => Interop.mkPieAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPieProperty> ids(params string[][] values) => Interop.mkPieAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPieProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkPieAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPieProperty> ids(List<int[]> values) => Interop.mkPieAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPieProperty> ids(params int[][] values) => Interop.mkPieAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPieProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkPieAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPieProperty> ids(List<float[]> values) => Interop.mkPieAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPieProperty> ids(params float[][] values) => Interop.mkPieAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPieProperty> ids(Literals.PlotData[] values) => Interop.mkPieAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPieProperty> ids(IEnumerable<bool?> values) => Interop.mkPieAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPieProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkPieAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPieProperty> ids(IEnumerable<int?> values) => Interop.mkPieAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPieProperty> ids(IEnumerable<float?> values) => Interop.mkPieAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPieProperty> customdata(bool val) => Interop.mkPieAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPieProperty> customdata(params bool[] values) => Interop.mkPieAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPieProperty> customdata(System.DateTime val) => Interop.mkPieAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPieProperty> customdata(params System.DateTime[] values) => Interop.mkPieAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPieProperty> customdata(float val) => Interop.mkPieAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPieProperty> customdata(params float[] values) => Interop.mkPieAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPieProperty> customdata(int val) => Interop.mkPieAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPieProperty> customdata(params int[] values) => Interop.mkPieAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPieProperty> customdata(string val) => Interop.mkPieAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPieProperty> customdata(params string[] values) => Interop.mkPieAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPieProperty> customdata(IEnumerable<bool[]> values) => Interop.mkPieAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPieProperty> customdata(List<bool[]> values) => Interop.mkPieAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPieProperty> customdata(params bool[][] values) => Interop.mkPieAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPieProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkPieAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPieProperty> customdata(List<string[]> values) => Interop.mkPieAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPieProperty> customdata(params string[][] values) => Interop.mkPieAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPieProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkPieAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPieProperty> customdata(List<int[]> values) => Interop.mkPieAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPieProperty> customdata(params int[][] values) => Interop.mkPieAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPieProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkPieAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPieProperty> customdata(List<float[]> values) => Interop.mkPieAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPieProperty> customdata(params float[][] values) => Interop.mkPieAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPieProperty> customdata(Literals.PlotData[] values) => Interop.mkPieAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPieProperty> customdata(IEnumerable<bool?> values) => Interop.mkPieAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPieProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkPieAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPieProperty> customdata(IEnumerable<int?> values) => Interop.mkPieAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPieProperty> customdata(IEnumerable<float?> values) => Interop.mkPieAttr("customdata", values.ToArray());
        public static Box<IPieProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkPieAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IPieProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkPieAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IPieProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkPieAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IPieProperty> uirevision(bool val) => Interop.mkPieAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IPieProperty> uirevision(params bool[] values) => Interop.mkPieAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IPieProperty> uirevision(System.DateTime val) => Interop.mkPieAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IPieProperty> uirevision(params System.DateTime[] values) => Interop.mkPieAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IPieProperty> uirevision(int val) => Interop.mkPieAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IPieProperty> uirevision(params int[] values) => Interop.mkPieAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IPieProperty> uirevision(float val) => Interop.mkPieAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IPieProperty> uirevision(params float[] values) => Interop.mkPieAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IPieProperty> uirevision(string val) => Interop.mkPieAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IPieProperty> uirevision(params string[] values) => Interop.mkPieAttr("uirevision", values);
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IPieProperty> labels(bool val) => Interop.mkPieAttr("labels", new[]{val});
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IPieProperty> labels(params bool[] values) => Interop.mkPieAttr("labels", values);
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IPieProperty> labels(System.DateTime val) => Interop.mkPieAttr("labels", new[]{val});
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IPieProperty> labels(params System.DateTime[] values) => Interop.mkPieAttr("labels", values);
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IPieProperty> labels(float val) => Interop.mkPieAttr("labels", new[]{val});
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IPieProperty> labels(params float[] values) => Interop.mkPieAttr("labels", values);
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IPieProperty> labels(int val) => Interop.mkPieAttr("labels", new[]{val});
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IPieProperty> labels(params int[] values) => Interop.mkPieAttr("labels", values);
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IPieProperty> labels(string val) => Interop.mkPieAttr("labels", new[]{val});
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IPieProperty> labels(params string[] values) => Interop.mkPieAttr("labels", values);
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IPieProperty> labels(IEnumerable<bool[]> values) => Interop.mkPieAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IPieProperty> labels(List<bool[]> values) => Interop.mkPieAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IPieProperty> labels(params bool[][] values) => Interop.mkPieAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IPieProperty> labels(IEnumerable<IEnumerable<string>> values) => Interop.mkPieAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IPieProperty> labels(List<string[]> values) => Interop.mkPieAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IPieProperty> labels(params string[][] values) => Interop.mkPieAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IPieProperty> labels(IEnumerable<IEnumerable<int>> values) => Interop.mkPieAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IPieProperty> labels(List<int[]> values) => Interop.mkPieAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IPieProperty> labels(params int[][] values) => Interop.mkPieAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IPieProperty> labels(IEnumerable<IEnumerable<float>> values) => Interop.mkPieAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IPieProperty> labels(List<float[]> values) => Interop.mkPieAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IPieProperty> labels(params float[][] values) => Interop.mkPieAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IPieProperty> labels(Literals.PlotData[] values) => Interop.mkPieAttr("labels", values);
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IPieProperty> labels(IEnumerable<bool?> values) => Interop.mkPieAttr("labels", values.ToArray());
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IPieProperty> labels(IEnumerable<System.DateTime?> values) => Interop.mkPieAttr("labels", values.ToArray());
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IPieProperty> labels(IEnumerable<int?> values) => Interop.mkPieAttr("labels", values.ToArray());
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IPieProperty> labels(IEnumerable<float?> values) => Interop.mkPieAttr("labels", values.ToArray());
        /// Alternate to `labels`. Builds a numeric set of labels. Use with `dlabel` where `label0` is the starting label and `dlabel` the step.
        public static Box<IPieProperty> label0(int val) => Interop.mkPieAttr("label0", val);
        /// Alternate to `labels`. Builds a numeric set of labels. Use with `dlabel` where `label0` is the starting label and `dlabel` the step.
        public static Box<IPieProperty> label0(float val) => Interop.mkPieAttr("label0", val);
        /// Sets the label step. See `label0` for more info.
        public static Box<IPieProperty> dlabel(int val) => Interop.mkPieAttr("dlabel", val);
        /// Sets the label step. See `label0` for more info.
        public static Box<IPieProperty> dlabel(float val) => Interop.mkPieAttr("dlabel", val);
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IPieProperty> values(bool val) => Interop.mkPieAttr("values", new[]{val});
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IPieProperty> values(params bool[] values) => Interop.mkPieAttr("values", values);
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IPieProperty> values(System.DateTime val) => Interop.mkPieAttr("values", new[]{val});
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IPieProperty> values(params System.DateTime[] values) => Interop.mkPieAttr("values", values);
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IPieProperty> values(float val) => Interop.mkPieAttr("values", new[]{val});
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IPieProperty> values(params float[] values) => Interop.mkPieAttr("values", values);
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IPieProperty> values(int val) => Interop.mkPieAttr("values", new[]{val});
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IPieProperty> values(params int[] values) => Interop.mkPieAttr("values", values);
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IPieProperty> values(string val) => Interop.mkPieAttr("values", new[]{val});
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IPieProperty> values(params string[] values) => Interop.mkPieAttr("values", values);
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IPieProperty> values(IEnumerable<bool[]> values) => Interop.mkPieAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IPieProperty> values(List<bool[]> values) => Interop.mkPieAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IPieProperty> values(params bool[][] values) => Interop.mkPieAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IPieProperty> values(IEnumerable<IEnumerable<string>> values) => Interop.mkPieAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IPieProperty> values(List<string[]> values) => Interop.mkPieAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IPieProperty> values(params string[][] values) => Interop.mkPieAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IPieProperty> values(IEnumerable<IEnumerable<int>> values) => Interop.mkPieAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IPieProperty> values(List<int[]> values) => Interop.mkPieAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IPieProperty> values(params int[][] values) => Interop.mkPieAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IPieProperty> values(IEnumerable<IEnumerable<float>> values) => Interop.mkPieAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IPieProperty> values(List<float[]> values) => Interop.mkPieAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IPieProperty> values(params float[][] values) => Interop.mkPieAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IPieProperty> values(Literals.PlotData[] values) => Interop.mkPieAttr("values", values);
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IPieProperty> values(IEnumerable<bool?> values) => Interop.mkPieAttr("values", values.ToArray());
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IPieProperty> values(IEnumerable<System.DateTime?> values) => Interop.mkPieAttr("values", values.ToArray());
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IPieProperty> values(IEnumerable<int?> values) => Interop.mkPieAttr("values", values.ToArray());
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IPieProperty> values(IEnumerable<float?> values) => Interop.mkPieAttr("values", values.ToArray());
        public static Box<IPieProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkPieAttr("marker", Bindings.flattenProperties(properties));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPieProperty> text(bool val) => Interop.mkPieAttr("text", new[]{val});
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPieProperty> text(IEnumerable<bool> values) => Interop.mkPieAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPieProperty> text(System.DateTime val) => Interop.mkPieAttr("text", new[]{val});
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPieProperty> text(IEnumerable<System.DateTime> values) => Interop.mkPieAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPieProperty> text(float val) => Interop.mkPieAttr("text", new[]{val});
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPieProperty> text(IEnumerable<float> values) => Interop.mkPieAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPieProperty> text(int val) => Interop.mkPieAttr("text", new[]{val});
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPieProperty> text(IEnumerable<int> values) => Interop.mkPieAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPieProperty> text(string val) => Interop.mkPieAttr("text", new[]{val});
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPieProperty> text(IEnumerable<string> values) => Interop.mkPieAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPieProperty> text(IEnumerable<bool[]> values) => Interop.mkPieAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPieProperty> text(List<bool[]> values) => Interop.mkPieAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPieProperty> text(params bool[][] values) => Interop.mkPieAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPieProperty> text(IEnumerable<IEnumerable<string>> values) => Interop.mkPieAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPieProperty> text(List<string[]> values) => Interop.mkPieAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPieProperty> text(params string[][] values) => Interop.mkPieAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPieProperty> text(IEnumerable<IEnumerable<int>> values) => Interop.mkPieAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPieProperty> text(List<int[]> values) => Interop.mkPieAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPieProperty> text(params int[][] values) => Interop.mkPieAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPieProperty> text(IEnumerable<IEnumerable<float>> values) => Interop.mkPieAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPieProperty> text(List<float[]> values) => Interop.mkPieAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPieProperty> text(params float[][] values) => Interop.mkPieAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPieProperty> text(Literals.PlotData[] values) => Interop.mkPieAttr("text", values);
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPieProperty> text(IEnumerable<bool?> values) => Interop.mkPieAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPieProperty> text(IEnumerable<System.DateTime?> values) => Interop.mkPieAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPieProperty> text(IEnumerable<int?> values) => Interop.mkPieAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPieProperty> text(IEnumerable<float?> values) => Interop.mkPieAttr("text", values.ToArray());
        /// Sets hover text elements associated with each sector. If a single string, the same string appears for all data points. If an array of string, the items are mapped in order of this trace's sectors. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IPieProperty> hovertext(string val) => Interop.mkPieAttr("hovertext", val);
        /// Sets hover text elements associated with each sector. If a single string, the same string appears for all data points. If an array of string, the items are mapped in order of this trace's sectors. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IPieProperty> hovertext(IEnumerable<string> values) => Interop.mkPieAttr("hovertext", values.ToArray());
        /// If there are multiple pie charts that should be sized according to their totals, link them by providing a non-empty group id here shared by every trace in the same group.
        public static Box<IPieProperty> scalegroup(string val) => Interop.mkPieAttr("scalegroup", val);
        /// Determines which trace information appear on the graph.
        public static Box<IPieProperty> textinfo(params Box<IPieProperty>[] properties) => Interop.mkPieAttr("textinfo", Bindings.joinEnumProperties(properties));
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IPieProperty> hoverinfo(params Box<IPieProperty>[] properties) => Interop.mkPieAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `label`, `color`, `value`, `percent` and `text`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IPieProperty> hovertemplate(string val) => Interop.mkPieAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `label`, `color`, `value`, `percent` and `text`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IPieProperty> hovertemplate(IEnumerable<string> values) => Interop.mkPieAttr("hovertemplate", values.ToArray());
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `label`, `color`, `value`, `percent` and `text`.
        public static Box<IPieProperty> texttemplate(string val) => Interop.mkPieAttr("texttemplate", val);
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `label`, `color`, `value`, `percent` and `text`.
        public static Box<IPieProperty> texttemplate(IEnumerable<string> values) => Interop.mkPieAttr("texttemplate", values.ToArray());
        /// Specifies the location of the `textinfo`.
        public static Box<IPieProperty> textposition(IEnumerable<Box<IPieProperty>> properties) => Interop.mkPieAttr("textposition", Bindings.flattenProperties(properties));
        /// Sets the font used for `textinfo`.
        public static Box<IPieProperty> textfont(params Box<ITextfontProperty>[] properties) => Interop.mkPieAttr("textfont", Bindings.flattenProperties(properties));
        /// Sets the font used for `textinfo` lying inside the sector.
        public static Box<IPieProperty> insidetextfont(params Box<IInsidetextfontProperty>[] properties) => Interop.mkPieAttr("insidetextfont", Bindings.flattenProperties(properties));
        /// Sets the font used for `textinfo` lying outside the sector.
        public static Box<IPieProperty> outsidetextfont(params Box<IOutsidetextfontProperty>[] properties) => Interop.mkPieAttr("outsidetextfont", Bindings.flattenProperties(properties));
        /// Determines whether outside text labels can push the margins.
        public static Box<IPieProperty> automargin(bool val) => Interop.mkPieAttr("automargin", val);
        public static Box<IPieProperty> title(params Box<ITitleProperty>[] properties) => Interop.mkPieAttr("title", Bindings.flattenProperties(properties));
        public static Box<IPieProperty> domain(params Box<IDomainProperty>[] properties) => Interop.mkPieAttr("domain", Bindings.flattenProperties(properties));
        /// Sets the fraction of the radius to cut out of the pie. Use this to make a donut chart.
        public static Box<IPieProperty> hole(int val) => Interop.mkPieAttr("hole", val);
        /// Sets the fraction of the radius to cut out of the pie. Use this to make a donut chart.
        public static Box<IPieProperty> hole(float val) => Interop.mkPieAttr("hole", val);
        /// Determines whether or not the sectors are reordered from largest to smallest.
        public static Box<IPieProperty> sort(bool val) => Interop.mkPieAttr("sort", val);
        /// Instead of the first slice starting at 12 o'clock, rotate to some other angle.
        public static Box<IPieProperty> rotation(int val) => Interop.mkPieAttr("rotation", val);
        /// Instead of the first slice starting at 12 o'clock, rotate to some other angle.
        public static Box<IPieProperty> rotation(float val) => Interop.mkPieAttr("rotation", val);
        /// Sets the fraction of larger radius to pull the sectors out from the center. This can be a constant to pull all slices apart from each other equally or an array to highlight one or more slices.
        public static Box<IPieProperty> pull(int val) => Interop.mkPieAttr("pull", val);
        /// Sets the fraction of larger radius to pull the sectors out from the center. This can be a constant to pull all slices apart from each other equally or an array to highlight one or more slices.
        public static Box<IPieProperty> pull(float val) => Interop.mkPieAttr("pull", val);
        /// Sets the fraction of larger radius to pull the sectors out from the center. This can be a constant to pull all slices apart from each other equally or an array to highlight one or more slices.
        public static Box<IPieProperty> pull(IEnumerable<int> values) => Interop.mkPieAttr("pull", values.ToArray());
        /// Sets the fraction of larger radius to pull the sectors out from the center. This can be a constant to pull all slices apart from each other equally or an array to highlight one or more slices.
        public static Box<IPieProperty> pull(IEnumerable<float> values) => Interop.mkPieAttr("pull", values.ToArray());
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IPieProperty> idssrc(string val) => Interop.mkPieAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IPieProperty> customdatasrc(string val) => Interop.mkPieAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IPieProperty> metasrc(string val) => Interop.mkPieAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  labels .
        public static Box<IPieProperty> labelssrc(string val) => Interop.mkPieAttr("labelssrc", val);
        /// Sets the source reference on plot.ly for  values .
        public static Box<IPieProperty> valuessrc(string val) => Interop.mkPieAttr("valuessrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IPieProperty> textsrc(string val) => Interop.mkPieAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IPieProperty> hovertextsrc(string val) => Interop.mkPieAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IPieProperty> hoverinfosrc(string val) => Interop.mkPieAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IPieProperty> hovertemplatesrc(string val) => Interop.mkPieAttr("hovertemplatesrc", val);
        /// Sets the source reference on plot.ly for  texttemplate .
        public static Box<IPieProperty> texttemplatesrc(string val) => Interop.mkPieAttr("texttemplatesrc", val);
        /// Sets the source reference on plot.ly for  textposition .
        public static Box<IPieProperty> textpositionsrc(string val) => Interop.mkPieAttr("textpositionsrc", val);
        /// Sets the source reference on plot.ly for  pull .
        public static Box<IPieProperty> pullsrc(string val) => Interop.mkPieAttr("pullsrc", val);
    }

    public static partial class Pie
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IPieProperty> legendonly() => Interop.mkPieAttr("visible", "legendonly");
            public static Box<IPieProperty> _false() => Interop.mkPieAttr("visible", false);
            public static Box<IPieProperty> _true() => Interop.mkPieAttr("visible", true);
        }

        /// Determines which trace information appear on the graph.
        public static partial class Textinfo
        {
            public static Box<IPieProperty> none() => Interop.mkPieAttr("textinfo", "none");
            public static Box<IPieProperty> label() => Interop.mkPieAttr("textinfo", "label");
            public static Box<IPieProperty> percent() => Interop.mkPieAttr("textinfo", "percent");
            public static Box<IPieProperty> text() => Interop.mkPieAttr("textinfo", "text");
            public static Box<IPieProperty> value() => Interop.mkPieAttr("textinfo", "value");
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IPieProperty> all() => Interop.mkPieAttr("hoverinfo", "all");
            public static Box<IPieProperty> none() => Interop.mkPieAttr("hoverinfo", "none");
            public static Box<IPieProperty> skip() => Interop.mkPieAttr("hoverinfo", "skip");
            public static Box<IPieProperty> label() => Interop.mkPieAttr("hoverinfo", "label");
            public static Box<IPieProperty> name() => Interop.mkPieAttr("hoverinfo", "name");
            public static Box<IPieProperty> percent() => Interop.mkPieAttr("hoverinfo", "percent");
            public static Box<IPieProperty> text() => Interop.mkPieAttr("hoverinfo", "text");
            public static Box<IPieProperty> value() => Interop.mkPieAttr("hoverinfo", "value");
        }

        /// Specifies the location of the `textinfo`.
        public static partial class Textposition
        {
            public static Box<IPieProperty> auto() => Interop.mkPieAttr("textposition", "auto");
            public static Box<IPieProperty> inside() => Interop.mkPieAttr("textposition", "inside");
            public static Box<IPieProperty> none() => Interop.mkPieAttr("textposition", "none");
            public static Box<IPieProperty> outside() => Interop.mkPieAttr("textposition", "outside");
        }

        /// Specifies the direction at which succeeding sectors follow one another.
        public static partial class Direction
        {
            public static Box<IPieProperty> clockwise() => Interop.mkPieAttr("direction", "clockwise");
            public static Box<IPieProperty> counterclockwise() => Interop.mkPieAttr("direction", "counterclockwise");
        }
    }
}