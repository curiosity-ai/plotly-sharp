namespace PlotlyBridge
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

    public static partial class Heatmap
    {
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IHeatmapProperty> legendgroup(string val) => Interop.mkHeatmapAttr("legendgroup", val);
        /// Sets the opacity of the trace.
        public static Box<IHeatmapProperty> opacity(int val) => Interop.mkHeatmapAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<IHeatmapProperty> opacity(float val) => Interop.mkHeatmapAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IHeatmapProperty> name(string val) => Interop.mkHeatmapAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IHeatmapProperty> uid(string val) => Interop.mkHeatmapAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapProperty> ids(bool val) => Interop.mkHeatmapAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapProperty> ids(params bool[] values) => Interop.mkHeatmapAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapProperty> ids(System.DateTime val) => Interop.mkHeatmapAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapProperty> ids(params System.DateTime[] values) => Interop.mkHeatmapAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapProperty> ids(float val) => Interop.mkHeatmapAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapProperty> ids(params float[] values) => Interop.mkHeatmapAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapProperty> ids(int val) => Interop.mkHeatmapAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapProperty> ids(params int[] values) => Interop.mkHeatmapAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapProperty> ids(string val) => Interop.mkHeatmapAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapProperty> ids(params string[] values) => Interop.mkHeatmapAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapProperty> ids(IEnumerable<bool[]> values) => Interop.mkHeatmapAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapProperty> ids(List<bool[]> values) => Interop.mkHeatmapAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapProperty> ids(params bool[][] values) => Interop.mkHeatmapAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkHeatmapAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapProperty> ids(List<string[]> values) => Interop.mkHeatmapAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapProperty> ids(params string[][] values) => Interop.mkHeatmapAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkHeatmapAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapProperty> ids(List<int[]> values) => Interop.mkHeatmapAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapProperty> ids(params int[][] values) => Interop.mkHeatmapAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkHeatmapAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapProperty> ids(List<float[]> values) => Interop.mkHeatmapAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapProperty> ids(params float[][] values) => Interop.mkHeatmapAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapProperty> ids(Literals.PlotData[] values) => Interop.mkHeatmapAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapProperty> ids(IEnumerable<bool?> values) => Interop.mkHeatmapAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkHeatmapAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapProperty> ids(IEnumerable<int?> values) => Interop.mkHeatmapAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapProperty> ids(IEnumerable<float?> values) => Interop.mkHeatmapAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapProperty> customdata(bool val) => Interop.mkHeatmapAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapProperty> customdata(params bool[] values) => Interop.mkHeatmapAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapProperty> customdata(System.DateTime val) => Interop.mkHeatmapAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapProperty> customdata(params System.DateTime[] values) => Interop.mkHeatmapAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapProperty> customdata(float val) => Interop.mkHeatmapAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapProperty> customdata(params float[] values) => Interop.mkHeatmapAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapProperty> customdata(int val) => Interop.mkHeatmapAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapProperty> customdata(params int[] values) => Interop.mkHeatmapAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapProperty> customdata(string val) => Interop.mkHeatmapAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapProperty> customdata(params string[] values) => Interop.mkHeatmapAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapProperty> customdata(IEnumerable<bool[]> values) => Interop.mkHeatmapAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapProperty> customdata(List<bool[]> values) => Interop.mkHeatmapAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapProperty> customdata(params bool[][] values) => Interop.mkHeatmapAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkHeatmapAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapProperty> customdata(List<string[]> values) => Interop.mkHeatmapAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapProperty> customdata(params string[][] values) => Interop.mkHeatmapAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkHeatmapAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapProperty> customdata(List<int[]> values) => Interop.mkHeatmapAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapProperty> customdata(params int[][] values) => Interop.mkHeatmapAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkHeatmapAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapProperty> customdata(List<float[]> values) => Interop.mkHeatmapAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapProperty> customdata(params float[][] values) => Interop.mkHeatmapAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapProperty> customdata(Literals.PlotData[] values) => Interop.mkHeatmapAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapProperty> customdata(IEnumerable<bool?> values) => Interop.mkHeatmapAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkHeatmapAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapProperty> customdata(IEnumerable<int?> values) => Interop.mkHeatmapAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapProperty> customdata(IEnumerable<float?> values) => Interop.mkHeatmapAttr("customdata", values.ToArray());
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IHeatmapProperty> hoverinfo(params Box<IHeatmapProperty>[] properties) => Interop.mkHeatmapAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        public static Box<IHeatmapProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkHeatmapAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IHeatmapProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkHeatmapAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IHeatmapProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkHeatmapAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHeatmapProperty> uirevision(bool val) => Interop.mkHeatmapAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHeatmapProperty> uirevision(params bool[] values) => Interop.mkHeatmapAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHeatmapProperty> uirevision(System.DateTime val) => Interop.mkHeatmapAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHeatmapProperty> uirevision(params System.DateTime[] values) => Interop.mkHeatmapAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHeatmapProperty> uirevision(int val) => Interop.mkHeatmapAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHeatmapProperty> uirevision(params int[] values) => Interop.mkHeatmapAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHeatmapProperty> uirevision(float val) => Interop.mkHeatmapAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHeatmapProperty> uirevision(params float[] values) => Interop.mkHeatmapAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHeatmapProperty> uirevision(string val) => Interop.mkHeatmapAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHeatmapProperty> uirevision(params string[] values) => Interop.mkHeatmapAttr("uirevision", values);
        /// Sets the z data.
        public static Box<IHeatmapProperty> z(bool val) => Interop.mkHeatmapAttr("z", new[]{val});
        /// Sets the z data.
        public static Box<IHeatmapProperty> z(params bool[] values) => Interop.mkHeatmapAttr("z", values);
        /// Sets the z data.
        public static Box<IHeatmapProperty> z(System.DateTime val) => Interop.mkHeatmapAttr("z", new[]{val});
        /// Sets the z data.
        public static Box<IHeatmapProperty> z(params System.DateTime[] values) => Interop.mkHeatmapAttr("z", values);
        /// Sets the z data.
        public static Box<IHeatmapProperty> z(float val) => Interop.mkHeatmapAttr("z", new[]{val});
        /// Sets the z data.
        public static Box<IHeatmapProperty> z(params float[] values) => Interop.mkHeatmapAttr("z", values);
        /// Sets the z data.
        public static Box<IHeatmapProperty> z(int val) => Interop.mkHeatmapAttr("z", new[]{val});
        /// Sets the z data.
        public static Box<IHeatmapProperty> z(params int[] values) => Interop.mkHeatmapAttr("z", values);
        /// Sets the z data.
        public static Box<IHeatmapProperty> z(string val) => Interop.mkHeatmapAttr("z", new[]{val});
        /// Sets the z data.
        public static Box<IHeatmapProperty> z(params string[] values) => Interop.mkHeatmapAttr("z", values);
        /// Sets the z data.
        public static Box<IHeatmapProperty> z(IEnumerable<bool[]> values) => Interop.mkHeatmapAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IHeatmapProperty> z(List<bool[]> values) => Interop.mkHeatmapAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IHeatmapProperty> z(params bool[][] values) => Interop.mkHeatmapAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IHeatmapProperty> z(IEnumerable<IEnumerable<string>> values) => Interop.mkHeatmapAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IHeatmapProperty> z(List<string[]> values) => Interop.mkHeatmapAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IHeatmapProperty> z(params string[][] values) => Interop.mkHeatmapAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IHeatmapProperty> z(IEnumerable<IEnumerable<int>> values) => Interop.mkHeatmapAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IHeatmapProperty> z(List<int[]> values) => Interop.mkHeatmapAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IHeatmapProperty> z(params int[][] values) => Interop.mkHeatmapAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IHeatmapProperty> z(IEnumerable<IEnumerable<float>> values) => Interop.mkHeatmapAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IHeatmapProperty> z(List<float[]> values) => Interop.mkHeatmapAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IHeatmapProperty> z(params float[][] values) => Interop.mkHeatmapAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IHeatmapProperty> z(Literals.PlotData[] values) => Interop.mkHeatmapAttr("z", values);
        /// Sets the z data.
        public static Box<IHeatmapProperty> z(IEnumerable<bool?> values) => Interop.mkHeatmapAttr("z", values.ToArray());
        /// Sets the z data.
        public static Box<IHeatmapProperty> z(IEnumerable<System.DateTime?> values) => Interop.mkHeatmapAttr("z", values.ToArray());
        /// Sets the z data.
        public static Box<IHeatmapProperty> z(IEnumerable<int?> values) => Interop.mkHeatmapAttr("z", values.ToArray());
        /// Sets the z data.
        public static Box<IHeatmapProperty> z(IEnumerable<float?> values) => Interop.mkHeatmapAttr("z", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IHeatmapProperty> x(bool val) => Interop.mkHeatmapAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IHeatmapProperty> x(IEnumerable<bool> values) => Interop.mkHeatmapAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IHeatmapProperty> x(System.DateTime val) => Interop.mkHeatmapAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IHeatmapProperty> x(IEnumerable<System.DateTime> values) => Interop.mkHeatmapAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IHeatmapProperty> x(float val) => Interop.mkHeatmapAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IHeatmapProperty> x(IEnumerable<float> values) => Interop.mkHeatmapAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IHeatmapProperty> x(int val) => Interop.mkHeatmapAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IHeatmapProperty> x(IEnumerable<int> values) => Interop.mkHeatmapAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IHeatmapProperty> x(string val) => Interop.mkHeatmapAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IHeatmapProperty> x(IEnumerable<string> values) => Interop.mkHeatmapAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IHeatmapProperty> x(IEnumerable<bool[]> values) => Interop.mkHeatmapAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IHeatmapProperty> x(List<bool[]> values) => Interop.mkHeatmapAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IHeatmapProperty> x(params bool[][] values) => Interop.mkHeatmapAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IHeatmapProperty> x(IEnumerable<IEnumerable<string>> values) => Interop.mkHeatmapAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IHeatmapProperty> x(List<string[]> values) => Interop.mkHeatmapAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IHeatmapProperty> x(params string[][] values) => Interop.mkHeatmapAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IHeatmapProperty> x(IEnumerable<IEnumerable<int>> values) => Interop.mkHeatmapAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IHeatmapProperty> x(List<int[]> values) => Interop.mkHeatmapAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IHeatmapProperty> x(params int[][] values) => Interop.mkHeatmapAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IHeatmapProperty> x(IEnumerable<IEnumerable<float>> values) => Interop.mkHeatmapAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IHeatmapProperty> x(List<float[]> values) => Interop.mkHeatmapAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IHeatmapProperty> x(params float[][] values) => Interop.mkHeatmapAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IHeatmapProperty> x(Literals.PlotData[] values) => Interop.mkHeatmapAttr("x", values);
        /// Sets the x coordinates.
        public static Box<IHeatmapProperty> x(IEnumerable<bool?> values) => Interop.mkHeatmapAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IHeatmapProperty> x(IEnumerable<System.DateTime?> values) => Interop.mkHeatmapAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IHeatmapProperty> x(IEnumerable<int?> values) => Interop.mkHeatmapAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IHeatmapProperty> x(IEnumerable<float?> values) => Interop.mkHeatmapAttr("x", values.ToArray());
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IHeatmapProperty> x0(bool val) => Interop.mkHeatmapAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IHeatmapProperty> x0(params bool[] values) => Interop.mkHeatmapAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IHeatmapProperty> x0(System.DateTime val) => Interop.mkHeatmapAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IHeatmapProperty> x0(params System.DateTime[] values) => Interop.mkHeatmapAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IHeatmapProperty> x0(int val) => Interop.mkHeatmapAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IHeatmapProperty> x0(params int[] values) => Interop.mkHeatmapAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IHeatmapProperty> x0(float val) => Interop.mkHeatmapAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IHeatmapProperty> x0(params float[] values) => Interop.mkHeatmapAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IHeatmapProperty> x0(string val) => Interop.mkHeatmapAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IHeatmapProperty> x0(params string[] values) => Interop.mkHeatmapAttr("x0", values);
        /// Sets the x coordinate step. See `x0` for more info.
        public static Box<IHeatmapProperty> dx(int val) => Interop.mkHeatmapAttr("dx", val);
        /// Sets the x coordinate step. See `x0` for more info.
        public static Box<IHeatmapProperty> dx(float val) => Interop.mkHeatmapAttr("dx", val);
        /// Sets the y coordinates.
        public static Box<IHeatmapProperty> y(bool val) => Interop.mkHeatmapAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IHeatmapProperty> y(IEnumerable<bool> values) => Interop.mkHeatmapAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IHeatmapProperty> y(System.DateTime val) => Interop.mkHeatmapAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IHeatmapProperty> y(IEnumerable<System.DateTime> values) => Interop.mkHeatmapAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IHeatmapProperty> y(float val) => Interop.mkHeatmapAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IHeatmapProperty> y(IEnumerable<float> values) => Interop.mkHeatmapAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IHeatmapProperty> y(int val) => Interop.mkHeatmapAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IHeatmapProperty> y(IEnumerable<int> values) => Interop.mkHeatmapAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IHeatmapProperty> y(string val) => Interop.mkHeatmapAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IHeatmapProperty> y(IEnumerable<string> values) => Interop.mkHeatmapAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IHeatmapProperty> y(IEnumerable<bool[]> values) => Interop.mkHeatmapAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IHeatmapProperty> y(List<bool[]> values) => Interop.mkHeatmapAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IHeatmapProperty> y(params bool[][] values) => Interop.mkHeatmapAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IHeatmapProperty> y(IEnumerable<IEnumerable<string>> values) => Interop.mkHeatmapAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IHeatmapProperty> y(List<string[]> values) => Interop.mkHeatmapAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IHeatmapProperty> y(params string[][] values) => Interop.mkHeatmapAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IHeatmapProperty> y(IEnumerable<IEnumerable<int>> values) => Interop.mkHeatmapAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IHeatmapProperty> y(List<int[]> values) => Interop.mkHeatmapAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IHeatmapProperty> y(params int[][] values) => Interop.mkHeatmapAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IHeatmapProperty> y(IEnumerable<IEnumerable<float>> values) => Interop.mkHeatmapAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IHeatmapProperty> y(List<float[]> values) => Interop.mkHeatmapAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IHeatmapProperty> y(params float[][] values) => Interop.mkHeatmapAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IHeatmapProperty> y(Literals.PlotData[] values) => Interop.mkHeatmapAttr("y", values);
        /// Sets the y coordinates.
        public static Box<IHeatmapProperty> y(IEnumerable<bool?> values) => Interop.mkHeatmapAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IHeatmapProperty> y(IEnumerable<System.DateTime?> values) => Interop.mkHeatmapAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IHeatmapProperty> y(IEnumerable<int?> values) => Interop.mkHeatmapAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IHeatmapProperty> y(IEnumerable<float?> values) => Interop.mkHeatmapAttr("y", values.ToArray());
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IHeatmapProperty> y0(bool val) => Interop.mkHeatmapAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IHeatmapProperty> y0(params bool[] values) => Interop.mkHeatmapAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IHeatmapProperty> y0(System.DateTime val) => Interop.mkHeatmapAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IHeatmapProperty> y0(params System.DateTime[] values) => Interop.mkHeatmapAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IHeatmapProperty> y0(int val) => Interop.mkHeatmapAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IHeatmapProperty> y0(params int[] values) => Interop.mkHeatmapAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IHeatmapProperty> y0(float val) => Interop.mkHeatmapAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IHeatmapProperty> y0(params float[] values) => Interop.mkHeatmapAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IHeatmapProperty> y0(string val) => Interop.mkHeatmapAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IHeatmapProperty> y0(params string[] values) => Interop.mkHeatmapAttr("y0", values);
        /// Sets the y coordinate step. See `y0` for more info.
        public static Box<IHeatmapProperty> dy(int val) => Interop.mkHeatmapAttr("dy", val);
        /// Sets the y coordinate step. See `y0` for more info.
        public static Box<IHeatmapProperty> dy(float val) => Interop.mkHeatmapAttr("dy", val);
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapProperty> text(bool val) => Interop.mkHeatmapAttr("text", new[]{val});
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapProperty> text(params bool[] values) => Interop.mkHeatmapAttr("text", values);
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapProperty> text(System.DateTime val) => Interop.mkHeatmapAttr("text", new[]{val});
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapProperty> text(params System.DateTime[] values) => Interop.mkHeatmapAttr("text", values);
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapProperty> text(float val) => Interop.mkHeatmapAttr("text", new[]{val});
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapProperty> text(params float[] values) => Interop.mkHeatmapAttr("text", values);
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapProperty> text(int val) => Interop.mkHeatmapAttr("text", new[]{val});
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapProperty> text(params int[] values) => Interop.mkHeatmapAttr("text", values);
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapProperty> text(string val) => Interop.mkHeatmapAttr("text", new[]{val});
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapProperty> text(params string[] values) => Interop.mkHeatmapAttr("text", values);
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapProperty> text(IEnumerable<bool[]> values) => Interop.mkHeatmapAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapProperty> text(List<bool[]> values) => Interop.mkHeatmapAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapProperty> text(params bool[][] values) => Interop.mkHeatmapAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapProperty> text(IEnumerable<IEnumerable<string>> values) => Interop.mkHeatmapAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapProperty> text(List<string[]> values) => Interop.mkHeatmapAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapProperty> text(params string[][] values) => Interop.mkHeatmapAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapProperty> text(IEnumerable<IEnumerable<int>> values) => Interop.mkHeatmapAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapProperty> text(List<int[]> values) => Interop.mkHeatmapAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapProperty> text(params int[][] values) => Interop.mkHeatmapAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapProperty> text(IEnumerable<IEnumerable<float>> values) => Interop.mkHeatmapAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapProperty> text(List<float[]> values) => Interop.mkHeatmapAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapProperty> text(params float[][] values) => Interop.mkHeatmapAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapProperty> text(Literals.PlotData[] values) => Interop.mkHeatmapAttr("text", values);
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapProperty> text(IEnumerable<bool?> values) => Interop.mkHeatmapAttr("text", values.ToArray());
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapProperty> text(IEnumerable<System.DateTime?> values) => Interop.mkHeatmapAttr("text", values.ToArray());
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapProperty> text(IEnumerable<int?> values) => Interop.mkHeatmapAttr("text", values.ToArray());
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapProperty> text(IEnumerable<float?> values) => Interop.mkHeatmapAttr("text", values.ToArray());
        /// Same as `text`.
        public static Box<IHeatmapProperty> hovertext(bool val) => Interop.mkHeatmapAttr("hovertext", new[]{val});
        /// Same as `text`.
        public static Box<IHeatmapProperty> hovertext(params bool[] values) => Interop.mkHeatmapAttr("hovertext", values);
        /// Same as `text`.
        public static Box<IHeatmapProperty> hovertext(System.DateTime val) => Interop.mkHeatmapAttr("hovertext", new[]{val});
        /// Same as `text`.
        public static Box<IHeatmapProperty> hovertext(params System.DateTime[] values) => Interop.mkHeatmapAttr("hovertext", values);
        /// Same as `text`.
        public static Box<IHeatmapProperty> hovertext(float val) => Interop.mkHeatmapAttr("hovertext", new[]{val});
        /// Same as `text`.
        public static Box<IHeatmapProperty> hovertext(params float[] values) => Interop.mkHeatmapAttr("hovertext", values);
        /// Same as `text`.
        public static Box<IHeatmapProperty> hovertext(int val) => Interop.mkHeatmapAttr("hovertext", new[]{val});
        /// Same as `text`.
        public static Box<IHeatmapProperty> hovertext(params int[] values) => Interop.mkHeatmapAttr("hovertext", values);
        /// Same as `text`.
        public static Box<IHeatmapProperty> hovertext(string val) => Interop.mkHeatmapAttr("hovertext", new[]{val});
        /// Same as `text`.
        public static Box<IHeatmapProperty> hovertext(params string[] values) => Interop.mkHeatmapAttr("hovertext", values);
        /// Same as `text`.
        public static Box<IHeatmapProperty> hovertext(IEnumerable<bool[]> values) => Interop.mkHeatmapAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IHeatmapProperty> hovertext(List<bool[]> values) => Interop.mkHeatmapAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IHeatmapProperty> hovertext(params bool[][] values) => Interop.mkHeatmapAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IHeatmapProperty> hovertext(IEnumerable<IEnumerable<string>> values) => Interop.mkHeatmapAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IHeatmapProperty> hovertext(List<string[]> values) => Interop.mkHeatmapAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IHeatmapProperty> hovertext(params string[][] values) => Interop.mkHeatmapAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IHeatmapProperty> hovertext(IEnumerable<IEnumerable<int>> values) => Interop.mkHeatmapAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IHeatmapProperty> hovertext(List<int[]> values) => Interop.mkHeatmapAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IHeatmapProperty> hovertext(params int[][] values) => Interop.mkHeatmapAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IHeatmapProperty> hovertext(IEnumerable<IEnumerable<float>> values) => Interop.mkHeatmapAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IHeatmapProperty> hovertext(List<float[]> values) => Interop.mkHeatmapAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IHeatmapProperty> hovertext(params float[][] values) => Interop.mkHeatmapAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IHeatmapProperty> hovertext(Literals.PlotData[] values) => Interop.mkHeatmapAttr("hovertext", values);
        /// Same as `text`.
        public static Box<IHeatmapProperty> hovertext(IEnumerable<bool?> values) => Interop.mkHeatmapAttr("hovertext", values.ToArray());
        /// Same as `text`.
        public static Box<IHeatmapProperty> hovertext(IEnumerable<System.DateTime?> values) => Interop.mkHeatmapAttr("hovertext", values.ToArray());
        /// Same as `text`.
        public static Box<IHeatmapProperty> hovertext(IEnumerable<int?> values) => Interop.mkHeatmapAttr("hovertext", values.ToArray());
        /// Same as `text`.
        public static Box<IHeatmapProperty> hovertext(IEnumerable<float?> values) => Interop.mkHeatmapAttr("hovertext", values.ToArray());
        /// Transposes the z data.
        public static Box<IHeatmapProperty> transpose(bool val) => Interop.mkHeatmapAttr("transpose", val);
        /// Determines whether or not gaps (i.e. {nan} or missing values) in the `z` data have hover labels associated with them.
        public static Box<IHeatmapProperty> hoverongaps(bool val) => Interop.mkHeatmapAttr("hoverongaps", val);
        /// Determines whether or not gaps (i.e. {nan} or missing values) in the `z` data are filled in. It is defaulted to true if `z` is a one dimensional array and `zsmooth` is not false; otherwise it is defaulted to false.
        public static Box<IHeatmapProperty> connectgaps(bool val) => Interop.mkHeatmapAttr("connectgaps", val);
        /// Sets the horizontal gap (in pixels) between bricks.
        public static Box<IHeatmapProperty> xgap(int val) => Interop.mkHeatmapAttr("xgap", val);
        /// Sets the horizontal gap (in pixels) between bricks.
        public static Box<IHeatmapProperty> xgap(float val) => Interop.mkHeatmapAttr("xgap", val);
        /// Sets the vertical gap (in pixels) between bricks.
        public static Box<IHeatmapProperty> ygap(int val) => Interop.mkHeatmapAttr("ygap", val);
        /// Sets the vertical gap (in pixels) between bricks.
        public static Box<IHeatmapProperty> ygap(float val) => Interop.mkHeatmapAttr("ygap", val);
        /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. See: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHeatmapProperty> zhoverformat(string val) => Interop.mkHeatmapAttr("zhoverformat", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IHeatmapProperty> hovertemplate(string val) => Interop.mkHeatmapAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IHeatmapProperty> hovertemplate(IEnumerable<string> values) => Interop.mkHeatmapAttr("hovertemplate", values.ToArray());
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IHeatmapProperty> showlegend(bool val) => Interop.mkHeatmapAttr("showlegend", val);
        /// Determines whether or not the color domain is computed with respect to the input data (here in `z`) or the bounds set in `zmin` and `zmax`  Defaults to `false` when `zmin` and `zmax` are set by the user.
        public static Box<IHeatmapProperty> zauto(bool val) => Interop.mkHeatmapAttr("zauto", val);
        /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
        public static Box<IHeatmapProperty> zmin(int val) => Interop.mkHeatmapAttr("zmin", val);
        /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
        public static Box<IHeatmapProperty> zmin(float val) => Interop.mkHeatmapAttr("zmin", val);
        /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
        public static Box<IHeatmapProperty> zmax(int val) => Interop.mkHeatmapAttr("zmax", val);
        /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
        public static Box<IHeatmapProperty> zmax(float val) => Interop.mkHeatmapAttr("zmax", val);
        /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
        public static Box<IHeatmapProperty> zmid(int val) => Interop.mkHeatmapAttr("zmid", val);
        /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
        public static Box<IHeatmapProperty> zmid(float val) => Interop.mkHeatmapAttr("zmid", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IHeatmapProperty> colorscale(string val) => Interop.mkHeatmapAttr("colorscale", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IHeatmapProperty> colorscale(List<string[]> values) => Interop.mkHeatmapAttr("colorscale", Bindings.flatten2DArrayIf1D(values));
        /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
        public static Box<IHeatmapProperty> autocolorscale(bool val) => Interop.mkHeatmapAttr("autocolorscale", val);
        /// Reverses the color mapping if true. If true, `zmin` will correspond to the last color in the array and `zmax` will correspond to the first color.
        public static Box<IHeatmapProperty> reversescale(bool val) => Interop.mkHeatmapAttr("reversescale", val);
        /// Determines whether or not a colorbar is displayed for this trace.
        public static Box<IHeatmapProperty> showscale(bool val) => Interop.mkHeatmapAttr("showscale", val);
        public static Box<IHeatmapProperty> colorbar(params Box<IColorbarProperty>[] properties) => Interop.mkHeatmapAttr("colorbar", Bindings.flattenProperties(properties));
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<IHeatmapProperty> coloraxis(int anchorId) => Interop.mkHeatmapAttr("coloraxis", anchorId > 1 ? $"coloraxis{anchorId}" : "");
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<IHeatmapProperty> coloraxis(string val) => Interop.mkHeatmapAttr("coloraxis", val);
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IHeatmapProperty> xaxis(int anchorId) => Interop.mkHeatmapAttr("xaxis", anchorId > 1 ? $"x{anchorId}" : "");
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IHeatmapProperty> xaxis(string val) => Interop.mkHeatmapAttr("xaxis", val);
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IHeatmapProperty> yaxis(int anchorId) => Interop.mkHeatmapAttr("yaxis", anchorId > 1 ? $"y{anchorId}" : "");
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IHeatmapProperty> yaxis(string val) => Interop.mkHeatmapAttr("yaxis", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IHeatmapProperty> idssrc(string val) => Interop.mkHeatmapAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IHeatmapProperty> customdatasrc(string val) => Interop.mkHeatmapAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IHeatmapProperty> metasrc(string val) => Interop.mkHeatmapAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IHeatmapProperty> hoverinfosrc(string val) => Interop.mkHeatmapAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  z .
        public static Box<IHeatmapProperty> zsrc(string val) => Interop.mkHeatmapAttr("zsrc", val);
        /// Sets the source reference on plot.ly for  x .
        public static Box<IHeatmapProperty> xsrc(string val) => Interop.mkHeatmapAttr("xsrc", val);
        /// Sets the source reference on plot.ly for  y .
        public static Box<IHeatmapProperty> ysrc(string val) => Interop.mkHeatmapAttr("ysrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IHeatmapProperty> textsrc(string val) => Interop.mkHeatmapAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IHeatmapProperty> hovertextsrc(string val) => Interop.mkHeatmapAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IHeatmapProperty> hovertemplatesrc(string val) => Interop.mkHeatmapAttr("hovertemplatesrc", val);
    }

    public static partial class Heatmap
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IHeatmapProperty> legendonly() => Interop.mkHeatmapAttr("visible", "legendonly");
            public static Box<IHeatmapProperty> _false() => Interop.mkHeatmapAttr("visible", false);
            public static Box<IHeatmapProperty> _true() => Interop.mkHeatmapAttr("visible", true);
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IHeatmapProperty> all() => Interop.mkHeatmapAttr("hoverinfo", "all");
            public static Box<IHeatmapProperty> none() => Interop.mkHeatmapAttr("hoverinfo", "none");
            public static Box<IHeatmapProperty> skip() => Interop.mkHeatmapAttr("hoverinfo", "skip");
            public static Box<IHeatmapProperty> name() => Interop.mkHeatmapAttr("hoverinfo", "name");
            public static Box<IHeatmapProperty> text() => Interop.mkHeatmapAttr("hoverinfo", "text");
            public static Box<IHeatmapProperty> x() => Interop.mkHeatmapAttr("hoverinfo", "x");
            public static Box<IHeatmapProperty> y() => Interop.mkHeatmapAttr("hoverinfo", "y");
            public static Box<IHeatmapProperty> z() => Interop.mkHeatmapAttr("hoverinfo", "z");
        }

        /// If *array*, the heatmap's x coordinates are given by *x* (the default behavior when `x` is provided). If *scaled*, the heatmap's x coordinates are given by *x0* and *dx* (the default behavior when `x` is not provided).
        public static partial class Xtype
        {
            public static Box<IHeatmapProperty> array() => Interop.mkHeatmapAttr("xtype", "array");
            public static Box<IHeatmapProperty> scaled() => Interop.mkHeatmapAttr("xtype", "scaled");
        }

        /// If *array*, the heatmap's y coordinates are given by *y* (the default behavior when `y` is provided) If *scaled*, the heatmap's y coordinates are given by *y0* and *dy* (the default behavior when `y` is not provided)
        public static partial class Ytype
        {
            public static Box<IHeatmapProperty> array() => Interop.mkHeatmapAttr("ytype", "array");
            public static Box<IHeatmapProperty> scaled() => Interop.mkHeatmapAttr("ytype", "scaled");
        }

        /// Picks a smoothing algorithm use to smooth `z` data.
        public static partial class Zsmooth
        {
            public static Box<IHeatmapProperty> best() => Interop.mkHeatmapAttr("zsmooth", "best");
            public static Box<IHeatmapProperty> fast() => Interop.mkHeatmapAttr("zsmooth", "fast");
            public static Box<IHeatmapProperty> _false() => Interop.mkHeatmapAttr("zsmooth", false);
        }

        /// Sets the calendar system to use with `x` date data.
        public static partial class Xcalendar
        {
            public static Box<IHeatmapProperty> chinese() => Interop.mkHeatmapAttr("xcalendar", "chinese");
            public static Box<IHeatmapProperty> coptic() => Interop.mkHeatmapAttr("xcalendar", "coptic");
            public static Box<IHeatmapProperty> discworld() => Interop.mkHeatmapAttr("xcalendar", "discworld");
            public static Box<IHeatmapProperty> ethiopian() => Interop.mkHeatmapAttr("xcalendar", "ethiopian");
            public static Box<IHeatmapProperty> gregorian() => Interop.mkHeatmapAttr("xcalendar", "gregorian");
            public static Box<IHeatmapProperty> hebrew() => Interop.mkHeatmapAttr("xcalendar", "hebrew");
            public static Box<IHeatmapProperty> islamic() => Interop.mkHeatmapAttr("xcalendar", "islamic");
            public static Box<IHeatmapProperty> jalali() => Interop.mkHeatmapAttr("xcalendar", "jalali");
            public static Box<IHeatmapProperty> julian() => Interop.mkHeatmapAttr("xcalendar", "julian");
            public static Box<IHeatmapProperty> mayan() => Interop.mkHeatmapAttr("xcalendar", "mayan");
            public static Box<IHeatmapProperty> nanakshahi() => Interop.mkHeatmapAttr("xcalendar", "nanakshahi");
            public static Box<IHeatmapProperty> nepali() => Interop.mkHeatmapAttr("xcalendar", "nepali");
            public static Box<IHeatmapProperty> persian() => Interop.mkHeatmapAttr("xcalendar", "persian");
            public static Box<IHeatmapProperty> taiwan() => Interop.mkHeatmapAttr("xcalendar", "taiwan");
            public static Box<IHeatmapProperty> thai() => Interop.mkHeatmapAttr("xcalendar", "thai");
            public static Box<IHeatmapProperty> ummalqura() => Interop.mkHeatmapAttr("xcalendar", "ummalqura");
        }

        /// Sets the calendar system to use with `y` date data.
        public static partial class Ycalendar
        {
            public static Box<IHeatmapProperty> chinese() => Interop.mkHeatmapAttr("ycalendar", "chinese");
            public static Box<IHeatmapProperty> coptic() => Interop.mkHeatmapAttr("ycalendar", "coptic");
            public static Box<IHeatmapProperty> discworld() => Interop.mkHeatmapAttr("ycalendar", "discworld");
            public static Box<IHeatmapProperty> ethiopian() => Interop.mkHeatmapAttr("ycalendar", "ethiopian");
            public static Box<IHeatmapProperty> gregorian() => Interop.mkHeatmapAttr("ycalendar", "gregorian");
            public static Box<IHeatmapProperty> hebrew() => Interop.mkHeatmapAttr("ycalendar", "hebrew");
            public static Box<IHeatmapProperty> islamic() => Interop.mkHeatmapAttr("ycalendar", "islamic");
            public static Box<IHeatmapProperty> jalali() => Interop.mkHeatmapAttr("ycalendar", "jalali");
            public static Box<IHeatmapProperty> julian() => Interop.mkHeatmapAttr("ycalendar", "julian");
            public static Box<IHeatmapProperty> mayan() => Interop.mkHeatmapAttr("ycalendar", "mayan");
            public static Box<IHeatmapProperty> nanakshahi() => Interop.mkHeatmapAttr("ycalendar", "nanakshahi");
            public static Box<IHeatmapProperty> nepali() => Interop.mkHeatmapAttr("ycalendar", "nepali");
            public static Box<IHeatmapProperty> persian() => Interop.mkHeatmapAttr("ycalendar", "persian");
            public static Box<IHeatmapProperty> taiwan() => Interop.mkHeatmapAttr("ycalendar", "taiwan");
            public static Box<IHeatmapProperty> thai() => Interop.mkHeatmapAttr("ycalendar", "thai");
            public static Box<IHeatmapProperty> ummalqura() => Interop.mkHeatmapAttr("ycalendar", "ummalqura");
        }
    }
}