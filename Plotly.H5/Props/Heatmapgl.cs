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

    public static partial class Heatmapgl
    {
        /// Sets the opacity of the trace.
        public static Box<IHeatmapglProperty> opacity(int val) => Interop.mkHeatmapglAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<IHeatmapglProperty> opacity(float val) => Interop.mkHeatmapglAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IHeatmapglProperty> name(string val) => Interop.mkHeatmapglAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IHeatmapglProperty> uid(string val) => Interop.mkHeatmapglAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapglProperty> ids(bool val) => Interop.mkHeatmapglAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapglProperty> ids(params bool[] values) => Interop.mkHeatmapglAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapglProperty> ids(System.DateTime val) => Interop.mkHeatmapglAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapglProperty> ids(params System.DateTime[] values) => Interop.mkHeatmapglAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapglProperty> ids(float val) => Interop.mkHeatmapglAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapglProperty> ids(params float[] values) => Interop.mkHeatmapglAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapglProperty> ids(int val) => Interop.mkHeatmapglAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapglProperty> ids(params int[] values) => Interop.mkHeatmapglAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapglProperty> ids(string val) => Interop.mkHeatmapglAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapglProperty> ids(params string[] values) => Interop.mkHeatmapglAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapglProperty> ids(IEnumerable<bool[]> values) => Interop.mkHeatmapglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapglProperty> ids(List<bool[]> values) => Interop.mkHeatmapglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapglProperty> ids(params bool[][] values) => Interop.mkHeatmapglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapglProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkHeatmapglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapglProperty> ids(List<string[]> values) => Interop.mkHeatmapglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapglProperty> ids(params string[][] values) => Interop.mkHeatmapglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapglProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkHeatmapglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapglProperty> ids(List<int[]> values) => Interop.mkHeatmapglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapglProperty> ids(params int[][] values) => Interop.mkHeatmapglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapglProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkHeatmapglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapglProperty> ids(List<float[]> values) => Interop.mkHeatmapglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapglProperty> ids(params float[][] values) => Interop.mkHeatmapglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapglProperty> ids(Literals.PlotData[] values) => Interop.mkHeatmapglAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapglProperty> ids(IEnumerable<bool?> values) => Interop.mkHeatmapglAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapglProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkHeatmapglAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapglProperty> ids(IEnumerable<int?> values) => Interop.mkHeatmapglAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHeatmapglProperty> ids(IEnumerable<float?> values) => Interop.mkHeatmapglAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapglProperty> customdata(bool val) => Interop.mkHeatmapglAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapglProperty> customdata(params bool[] values) => Interop.mkHeatmapglAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapglProperty> customdata(System.DateTime val) => Interop.mkHeatmapglAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapglProperty> customdata(params System.DateTime[] values) => Interop.mkHeatmapglAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapglProperty> customdata(float val) => Interop.mkHeatmapglAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapglProperty> customdata(params float[] values) => Interop.mkHeatmapglAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapglProperty> customdata(int val) => Interop.mkHeatmapglAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapglProperty> customdata(params int[] values) => Interop.mkHeatmapglAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapglProperty> customdata(string val) => Interop.mkHeatmapglAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapglProperty> customdata(params string[] values) => Interop.mkHeatmapglAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapglProperty> customdata(IEnumerable<bool[]> values) => Interop.mkHeatmapglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapglProperty> customdata(List<bool[]> values) => Interop.mkHeatmapglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapglProperty> customdata(params bool[][] values) => Interop.mkHeatmapglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapglProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkHeatmapglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapglProperty> customdata(List<string[]> values) => Interop.mkHeatmapglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapglProperty> customdata(params string[][] values) => Interop.mkHeatmapglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapglProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkHeatmapglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapglProperty> customdata(List<int[]> values) => Interop.mkHeatmapglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapglProperty> customdata(params int[][] values) => Interop.mkHeatmapglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapglProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkHeatmapglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapglProperty> customdata(List<float[]> values) => Interop.mkHeatmapglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapglProperty> customdata(params float[][] values) => Interop.mkHeatmapglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapglProperty> customdata(Literals.PlotData[] values) => Interop.mkHeatmapglAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapglProperty> customdata(IEnumerable<bool?> values) => Interop.mkHeatmapglAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapglProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkHeatmapglAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapglProperty> customdata(IEnumerable<int?> values) => Interop.mkHeatmapglAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHeatmapglProperty> customdata(IEnumerable<float?> values) => Interop.mkHeatmapglAttr("customdata", values.ToArray());
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IHeatmapglProperty> hoverinfo(params Box<IHeatmapglProperty>[] properties) => Interop.mkHeatmapglAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        public static Box<IHeatmapglProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkHeatmapglAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IHeatmapglProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkHeatmapglAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IHeatmapglProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkHeatmapglAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHeatmapglProperty> uirevision(bool val) => Interop.mkHeatmapglAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHeatmapglProperty> uirevision(params bool[] values) => Interop.mkHeatmapglAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHeatmapglProperty> uirevision(System.DateTime val) => Interop.mkHeatmapglAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHeatmapglProperty> uirevision(params System.DateTime[] values) => Interop.mkHeatmapglAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHeatmapglProperty> uirevision(int val) => Interop.mkHeatmapglAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHeatmapglProperty> uirevision(params int[] values) => Interop.mkHeatmapglAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHeatmapglProperty> uirevision(float val) => Interop.mkHeatmapglAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHeatmapglProperty> uirevision(params float[] values) => Interop.mkHeatmapglAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHeatmapglProperty> uirevision(string val) => Interop.mkHeatmapglAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHeatmapglProperty> uirevision(params string[] values) => Interop.mkHeatmapglAttr("uirevision", values);
        /// Sets the z data.
        public static Box<IHeatmapglProperty> z(bool val) => Interop.mkHeatmapglAttr("z", new[]{val});
        /// Sets the z data.
        public static Box<IHeatmapglProperty> z(params bool[] values) => Interop.mkHeatmapglAttr("z", values);
        /// Sets the z data.
        public static Box<IHeatmapglProperty> z(System.DateTime val) => Interop.mkHeatmapglAttr("z", new[]{val});
        /// Sets the z data.
        public static Box<IHeatmapglProperty> z(params System.DateTime[] values) => Interop.mkHeatmapglAttr("z", values);
        /// Sets the z data.
        public static Box<IHeatmapglProperty> z(float val) => Interop.mkHeatmapglAttr("z", new[]{val});
        /// Sets the z data.
        public static Box<IHeatmapglProperty> z(params float[] values) => Interop.mkHeatmapglAttr("z", values);
        /// Sets the z data.
        public static Box<IHeatmapglProperty> z(int val) => Interop.mkHeatmapglAttr("z", new[]{val});
        /// Sets the z data.
        public static Box<IHeatmapglProperty> z(params int[] values) => Interop.mkHeatmapglAttr("z", values);
        /// Sets the z data.
        public static Box<IHeatmapglProperty> z(string val) => Interop.mkHeatmapglAttr("z", new[]{val});
        /// Sets the z data.
        public static Box<IHeatmapglProperty> z(params string[] values) => Interop.mkHeatmapglAttr("z", values);
        /// Sets the z data.
        public static Box<IHeatmapglProperty> z(IEnumerable<bool[]> values) => Interop.mkHeatmapglAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IHeatmapglProperty> z(List<bool[]> values) => Interop.mkHeatmapglAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IHeatmapglProperty> z(params bool[][] values) => Interop.mkHeatmapglAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IHeatmapglProperty> z(IEnumerable<IEnumerable<string>> values) => Interop.mkHeatmapglAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IHeatmapglProperty> z(List<string[]> values) => Interop.mkHeatmapglAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IHeatmapglProperty> z(params string[][] values) => Interop.mkHeatmapglAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IHeatmapglProperty> z(IEnumerable<IEnumerable<int>> values) => Interop.mkHeatmapglAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IHeatmapglProperty> z(List<int[]> values) => Interop.mkHeatmapglAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IHeatmapglProperty> z(params int[][] values) => Interop.mkHeatmapglAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IHeatmapglProperty> z(IEnumerable<IEnumerable<float>> values) => Interop.mkHeatmapglAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IHeatmapglProperty> z(List<float[]> values) => Interop.mkHeatmapglAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IHeatmapglProperty> z(params float[][] values) => Interop.mkHeatmapglAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IHeatmapglProperty> z(Literals.PlotData[] values) => Interop.mkHeatmapglAttr("z", values);
        /// Sets the z data.
        public static Box<IHeatmapglProperty> z(IEnumerable<bool?> values) => Interop.mkHeatmapglAttr("z", values.ToArray());
        /// Sets the z data.
        public static Box<IHeatmapglProperty> z(IEnumerable<System.DateTime?> values) => Interop.mkHeatmapglAttr("z", values.ToArray());
        /// Sets the z data.
        public static Box<IHeatmapglProperty> z(IEnumerable<int?> values) => Interop.mkHeatmapglAttr("z", values.ToArray());
        /// Sets the z data.
        public static Box<IHeatmapglProperty> z(IEnumerable<float?> values) => Interop.mkHeatmapglAttr("z", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IHeatmapglProperty> x(bool val) => Interop.mkHeatmapglAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IHeatmapglProperty> x(params bool[] values) => Interop.mkHeatmapglAttr("x", values);
        /// Sets the x coordinates.
        public static Box<IHeatmapglProperty> x(System.DateTime val) => Interop.mkHeatmapglAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IHeatmapglProperty> x(params System.DateTime[] values) => Interop.mkHeatmapglAttr("x", values);
        /// Sets the x coordinates.
        public static Box<IHeatmapglProperty> x(float val) => Interop.mkHeatmapglAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IHeatmapglProperty> x(params float[] values) => Interop.mkHeatmapglAttr("x", values);
        /// Sets the x coordinates.
        public static Box<IHeatmapglProperty> x(int val) => Interop.mkHeatmapglAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IHeatmapglProperty> x(params int[] values) => Interop.mkHeatmapglAttr("x", values);
        /// Sets the x coordinates.
        public static Box<IHeatmapglProperty> x(string val) => Interop.mkHeatmapglAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IHeatmapglProperty> x(params string[] values) => Interop.mkHeatmapglAttr("x", values);
        /// Sets the x coordinates.
        public static Box<IHeatmapglProperty> x(IEnumerable<bool[]> values) => Interop.mkHeatmapglAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IHeatmapglProperty> x(List<bool[]> values) => Interop.mkHeatmapglAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IHeatmapglProperty> x(params bool[][] values) => Interop.mkHeatmapglAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IHeatmapglProperty> x(IEnumerable<IEnumerable<string>> values) => Interop.mkHeatmapglAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IHeatmapglProperty> x(List<string[]> values) => Interop.mkHeatmapglAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IHeatmapglProperty> x(params string[][] values) => Interop.mkHeatmapglAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IHeatmapglProperty> x(IEnumerable<IEnumerable<int>> values) => Interop.mkHeatmapglAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IHeatmapglProperty> x(List<int[]> values) => Interop.mkHeatmapglAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IHeatmapglProperty> x(params int[][] values) => Interop.mkHeatmapglAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IHeatmapglProperty> x(IEnumerable<IEnumerable<float>> values) => Interop.mkHeatmapglAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IHeatmapglProperty> x(List<float[]> values) => Interop.mkHeatmapglAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IHeatmapglProperty> x(params float[][] values) => Interop.mkHeatmapglAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IHeatmapglProperty> x(Literals.PlotData[] values) => Interop.mkHeatmapglAttr("x", values);
        /// Sets the x coordinates.
        public static Box<IHeatmapglProperty> x(IEnumerable<bool?> values) => Interop.mkHeatmapglAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IHeatmapglProperty> x(IEnumerable<System.DateTime?> values) => Interop.mkHeatmapglAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IHeatmapglProperty> x(IEnumerable<int?> values) => Interop.mkHeatmapglAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IHeatmapglProperty> x(IEnumerable<float?> values) => Interop.mkHeatmapglAttr("x", values.ToArray());
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IHeatmapglProperty> x0(bool val) => Interop.mkHeatmapglAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IHeatmapglProperty> x0(params bool[] values) => Interop.mkHeatmapglAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IHeatmapglProperty> x0(System.DateTime val) => Interop.mkHeatmapglAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IHeatmapglProperty> x0(params System.DateTime[] values) => Interop.mkHeatmapglAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IHeatmapglProperty> x0(int val) => Interop.mkHeatmapglAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IHeatmapglProperty> x0(params int[] values) => Interop.mkHeatmapglAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IHeatmapglProperty> x0(float val) => Interop.mkHeatmapglAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IHeatmapglProperty> x0(params float[] values) => Interop.mkHeatmapglAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IHeatmapglProperty> x0(string val) => Interop.mkHeatmapglAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IHeatmapglProperty> x0(params string[] values) => Interop.mkHeatmapglAttr("x0", values);
        /// Sets the x coordinate step. See `x0` for more info.
        public static Box<IHeatmapglProperty> dx(int val) => Interop.mkHeatmapglAttr("dx", val);
        /// Sets the x coordinate step. See `x0` for more info.
        public static Box<IHeatmapglProperty> dx(float val) => Interop.mkHeatmapglAttr("dx", val);
        /// Sets the y coordinates.
        public static Box<IHeatmapglProperty> y(bool val) => Interop.mkHeatmapglAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IHeatmapglProperty> y(params bool[] values) => Interop.mkHeatmapglAttr("y", values);
        /// Sets the y coordinates.
        public static Box<IHeatmapglProperty> y(System.DateTime val) => Interop.mkHeatmapglAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IHeatmapglProperty> y(params System.DateTime[] values) => Interop.mkHeatmapglAttr("y", values);
        /// Sets the y coordinates.
        public static Box<IHeatmapglProperty> y(float val) => Interop.mkHeatmapglAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IHeatmapglProperty> y(params float[] values) => Interop.mkHeatmapglAttr("y", values);
        /// Sets the y coordinates.
        public static Box<IHeatmapglProperty> y(int val) => Interop.mkHeatmapglAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IHeatmapglProperty> y(params int[] values) => Interop.mkHeatmapglAttr("y", values);
        /// Sets the y coordinates.
        public static Box<IHeatmapglProperty> y(string val) => Interop.mkHeatmapglAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IHeatmapglProperty> y(params string[] values) => Interop.mkHeatmapglAttr("y", values);
        /// Sets the y coordinates.
        public static Box<IHeatmapglProperty> y(IEnumerable<bool[]> values) => Interop.mkHeatmapglAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IHeatmapglProperty> y(List<bool[]> values) => Interop.mkHeatmapglAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IHeatmapglProperty> y(params bool[][] values) => Interop.mkHeatmapglAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IHeatmapglProperty> y(IEnumerable<IEnumerable<string>> values) => Interop.mkHeatmapglAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IHeatmapglProperty> y(List<string[]> values) => Interop.mkHeatmapglAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IHeatmapglProperty> y(params string[][] values) => Interop.mkHeatmapglAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IHeatmapglProperty> y(IEnumerable<IEnumerable<int>> values) => Interop.mkHeatmapglAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IHeatmapglProperty> y(List<int[]> values) => Interop.mkHeatmapglAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IHeatmapglProperty> y(params int[][] values) => Interop.mkHeatmapglAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IHeatmapglProperty> y(IEnumerable<IEnumerable<float>> values) => Interop.mkHeatmapglAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IHeatmapglProperty> y(List<float[]> values) => Interop.mkHeatmapglAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IHeatmapglProperty> y(params float[][] values) => Interop.mkHeatmapglAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IHeatmapglProperty> y(Literals.PlotData[] values) => Interop.mkHeatmapglAttr("y", values);
        /// Sets the y coordinates.
        public static Box<IHeatmapglProperty> y(IEnumerable<bool?> values) => Interop.mkHeatmapglAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IHeatmapglProperty> y(IEnumerable<System.DateTime?> values) => Interop.mkHeatmapglAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IHeatmapglProperty> y(IEnumerable<int?> values) => Interop.mkHeatmapglAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IHeatmapglProperty> y(IEnumerable<float?> values) => Interop.mkHeatmapglAttr("y", values.ToArray());
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IHeatmapglProperty> y0(bool val) => Interop.mkHeatmapglAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IHeatmapglProperty> y0(params bool[] values) => Interop.mkHeatmapglAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IHeatmapglProperty> y0(System.DateTime val) => Interop.mkHeatmapglAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IHeatmapglProperty> y0(params System.DateTime[] values) => Interop.mkHeatmapglAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IHeatmapglProperty> y0(int val) => Interop.mkHeatmapglAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IHeatmapglProperty> y0(params int[] values) => Interop.mkHeatmapglAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IHeatmapglProperty> y0(float val) => Interop.mkHeatmapglAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IHeatmapglProperty> y0(params float[] values) => Interop.mkHeatmapglAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IHeatmapglProperty> y0(string val) => Interop.mkHeatmapglAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IHeatmapglProperty> y0(params string[] values) => Interop.mkHeatmapglAttr("y0", values);
        /// Sets the y coordinate step. See `y0` for more info.
        public static Box<IHeatmapglProperty> dy(int val) => Interop.mkHeatmapglAttr("dy", val);
        /// Sets the y coordinate step. See `y0` for more info.
        public static Box<IHeatmapglProperty> dy(float val) => Interop.mkHeatmapglAttr("dy", val);
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapglProperty> text(bool val) => Interop.mkHeatmapglAttr("text", new[]{val});
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapglProperty> text(params bool[] values) => Interop.mkHeatmapglAttr("text", values);
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapglProperty> text(System.DateTime val) => Interop.mkHeatmapglAttr("text", new[]{val});
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapglProperty> text(params System.DateTime[] values) => Interop.mkHeatmapglAttr("text", values);
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapglProperty> text(float val) => Interop.mkHeatmapglAttr("text", new[]{val});
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapglProperty> text(params float[] values) => Interop.mkHeatmapglAttr("text", values);
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapglProperty> text(int val) => Interop.mkHeatmapglAttr("text", new[]{val});
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapglProperty> text(params int[] values) => Interop.mkHeatmapglAttr("text", values);
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapglProperty> text(string val) => Interop.mkHeatmapglAttr("text", new[]{val});
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapglProperty> text(params string[] values) => Interop.mkHeatmapglAttr("text", values);
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapglProperty> text(IEnumerable<bool[]> values) => Interop.mkHeatmapglAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapglProperty> text(List<bool[]> values) => Interop.mkHeatmapglAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapglProperty> text(params bool[][] values) => Interop.mkHeatmapglAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapglProperty> text(IEnumerable<IEnumerable<string>> values) => Interop.mkHeatmapglAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapglProperty> text(List<string[]> values) => Interop.mkHeatmapglAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapglProperty> text(params string[][] values) => Interop.mkHeatmapglAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapglProperty> text(IEnumerable<IEnumerable<int>> values) => Interop.mkHeatmapglAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapglProperty> text(List<int[]> values) => Interop.mkHeatmapglAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapglProperty> text(params int[][] values) => Interop.mkHeatmapglAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapglProperty> text(IEnumerable<IEnumerable<float>> values) => Interop.mkHeatmapglAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapglProperty> text(List<float[]> values) => Interop.mkHeatmapglAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapglProperty> text(params float[][] values) => Interop.mkHeatmapglAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapglProperty> text(Literals.PlotData[] values) => Interop.mkHeatmapglAttr("text", values);
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapglProperty> text(IEnumerable<bool?> values) => Interop.mkHeatmapglAttr("text", values.ToArray());
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapglProperty> text(IEnumerable<System.DateTime?> values) => Interop.mkHeatmapglAttr("text", values.ToArray());
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapglProperty> text(IEnumerable<int?> values) => Interop.mkHeatmapglAttr("text", values.ToArray());
        /// Sets the text elements associated with each z value.
        public static Box<IHeatmapglProperty> text(IEnumerable<float?> values) => Interop.mkHeatmapglAttr("text", values.ToArray());
        /// Transposes the z data.
        public static Box<IHeatmapglProperty> transpose(bool val) => Interop.mkHeatmapglAttr("transpose", val);
        /// Determines whether or not the color domain is computed with respect to the input data (here in `z`) or the bounds set in `zmin` and `zmax`  Defaults to `false` when `zmin` and `zmax` are set by the user.
        public static Box<IHeatmapglProperty> zauto(bool val) => Interop.mkHeatmapglAttr("zauto", val);
        /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
        public static Box<IHeatmapglProperty> zmin(int val) => Interop.mkHeatmapglAttr("zmin", val);
        /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
        public static Box<IHeatmapglProperty> zmin(float val) => Interop.mkHeatmapglAttr("zmin", val);
        /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
        public static Box<IHeatmapglProperty> zmax(int val) => Interop.mkHeatmapglAttr("zmax", val);
        /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
        public static Box<IHeatmapglProperty> zmax(float val) => Interop.mkHeatmapglAttr("zmax", val);
        /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
        public static Box<IHeatmapglProperty> zmid(int val) => Interop.mkHeatmapglAttr("zmid", val);
        /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
        public static Box<IHeatmapglProperty> zmid(float val) => Interop.mkHeatmapglAttr("zmid", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IHeatmapglProperty> colorscale(string val) => Interop.mkHeatmapglAttr("colorscale", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IHeatmapglProperty> colorscale(List<string[]> values) => Interop.mkHeatmapglAttr("colorscale", Bindings.flatten2DArrayIf1D(values));
        /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
        public static Box<IHeatmapglProperty> autocolorscale(bool val) => Interop.mkHeatmapglAttr("autocolorscale", val);
        /// Reverses the color mapping if true. If true, `zmin` will correspond to the last color in the array and `zmax` will correspond to the first color.
        public static Box<IHeatmapglProperty> reversescale(bool val) => Interop.mkHeatmapglAttr("reversescale", val);
        /// Determines whether or not a colorbar is displayed for this trace.
        public static Box<IHeatmapglProperty> showscale(bool val) => Interop.mkHeatmapglAttr("showscale", val);
        public static Box<IHeatmapglProperty> colorbar(params Box<IColorbarProperty>[] properties) => Interop.mkHeatmapglAttr("colorbar", Bindings.flattenProperties(properties));
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<IHeatmapglProperty> coloraxis(int anchorId) => Interop.mkHeatmapglAttr("coloraxis", anchorId > 1 ? $"coloraxis{anchorId}" : "");
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<IHeatmapglProperty> coloraxis(string val) => Interop.mkHeatmapglAttr("coloraxis", val);
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IHeatmapglProperty> xaxis(int anchorId) => Interop.mkHeatmapglAttr("xaxis", anchorId > 1 ? $"x{anchorId}" : "");
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IHeatmapglProperty> xaxis(string val) => Interop.mkHeatmapglAttr("xaxis", val);
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IHeatmapglProperty> yaxis(int anchorId) => Interop.mkHeatmapglAttr("yaxis", anchorId > 1 ? $"y{anchorId}" : "");
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IHeatmapglProperty> yaxis(string val) => Interop.mkHeatmapglAttr("yaxis", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IHeatmapglProperty> idssrc(string val) => Interop.mkHeatmapglAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IHeatmapglProperty> customdatasrc(string val) => Interop.mkHeatmapglAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IHeatmapglProperty> metasrc(string val) => Interop.mkHeatmapglAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IHeatmapglProperty> hoverinfosrc(string val) => Interop.mkHeatmapglAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  z .
        public static Box<IHeatmapglProperty> zsrc(string val) => Interop.mkHeatmapglAttr("zsrc", val);
        /// Sets the source reference on plot.ly for  x .
        public static Box<IHeatmapglProperty> xsrc(string val) => Interop.mkHeatmapglAttr("xsrc", val);
        /// Sets the source reference on plot.ly for  y .
        public static Box<IHeatmapglProperty> ysrc(string val) => Interop.mkHeatmapglAttr("ysrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IHeatmapglProperty> textsrc(string val) => Interop.mkHeatmapglAttr("textsrc", val);
    }

    public static partial class Heatmapgl
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IHeatmapglProperty> legendonly() => Interop.mkHeatmapglAttr("visible", "legendonly");
            public static Box<IHeatmapglProperty> _false() => Interop.mkHeatmapglAttr("visible", false);
            public static Box<IHeatmapglProperty> _true() => Interop.mkHeatmapglAttr("visible", true);
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IHeatmapglProperty> all() => Interop.mkHeatmapglAttr("hoverinfo", "all");
            public static Box<IHeatmapglProperty> none() => Interop.mkHeatmapglAttr("hoverinfo", "none");
            public static Box<IHeatmapglProperty> skip() => Interop.mkHeatmapglAttr("hoverinfo", "skip");
            public static Box<IHeatmapglProperty> name() => Interop.mkHeatmapglAttr("hoverinfo", "name");
            public static Box<IHeatmapglProperty> text() => Interop.mkHeatmapglAttr("hoverinfo", "text");
            public static Box<IHeatmapglProperty> x() => Interop.mkHeatmapglAttr("hoverinfo", "x");
            public static Box<IHeatmapglProperty> y() => Interop.mkHeatmapglAttr("hoverinfo", "y");
            public static Box<IHeatmapglProperty> z() => Interop.mkHeatmapglAttr("hoverinfo", "z");
        }

        /// If *array*, the heatmap's x coordinates are given by *x* (the default behavior when `x` is provided). If *scaled*, the heatmap's x coordinates are given by *x0* and *dx* (the default behavior when `x` is not provided).
        public static partial class Xtype
        {
            public static Box<IHeatmapglProperty> array() => Interop.mkHeatmapglAttr("xtype", "array");
            public static Box<IHeatmapglProperty> scaled() => Interop.mkHeatmapglAttr("xtype", "scaled");
        }

        /// If *array*, the heatmap's y coordinates are given by *y* (the default behavior when `y` is provided) If *scaled*, the heatmap's y coordinates are given by *y0* and *dy* (the default behavior when `y` is not provided)
        public static partial class Ytype
        {
            public static Box<IHeatmapglProperty> array() => Interop.mkHeatmapglAttr("ytype", "array");
            public static Box<IHeatmapglProperty> scaled() => Interop.mkHeatmapglAttr("ytype", "scaled");
        }
    }
}