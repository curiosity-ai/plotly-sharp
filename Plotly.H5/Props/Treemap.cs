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

    public static partial class Treemap
    {
        /// Sets the opacity of the trace.
        public static Box<ITreemapProperty> opacity(int val) => Interop.mkTreemapAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<ITreemapProperty> opacity(float val) => Interop.mkTreemapAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<ITreemapProperty> name(string val) => Interop.mkTreemapAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<ITreemapProperty> uid(string val) => Interop.mkTreemapAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITreemapProperty> ids(bool val) => Interop.mkTreemapAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITreemapProperty> ids(params bool[] values) => Interop.mkTreemapAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITreemapProperty> ids(System.DateTime val) => Interop.mkTreemapAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITreemapProperty> ids(params System.DateTime[] values) => Interop.mkTreemapAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITreemapProperty> ids(float val) => Interop.mkTreemapAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITreemapProperty> ids(params float[] values) => Interop.mkTreemapAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITreemapProperty> ids(int val) => Interop.mkTreemapAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITreemapProperty> ids(params int[] values) => Interop.mkTreemapAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITreemapProperty> ids(string val) => Interop.mkTreemapAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITreemapProperty> ids(params string[] values) => Interop.mkTreemapAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITreemapProperty> ids(IEnumerable<bool[]> values) => Interop.mkTreemapAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITreemapProperty> ids(List<bool[]> values) => Interop.mkTreemapAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITreemapProperty> ids(params bool[][] values) => Interop.mkTreemapAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITreemapProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkTreemapAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITreemapProperty> ids(List<string[]> values) => Interop.mkTreemapAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITreemapProperty> ids(params string[][] values) => Interop.mkTreemapAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITreemapProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkTreemapAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITreemapProperty> ids(List<int[]> values) => Interop.mkTreemapAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITreemapProperty> ids(params int[][] values) => Interop.mkTreemapAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITreemapProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkTreemapAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITreemapProperty> ids(List<float[]> values) => Interop.mkTreemapAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITreemapProperty> ids(params float[][] values) => Interop.mkTreemapAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITreemapProperty> ids(Literals.PlotData[] values) => Interop.mkTreemapAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITreemapProperty> ids(IEnumerable<bool?> values) => Interop.mkTreemapAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITreemapProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkTreemapAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITreemapProperty> ids(IEnumerable<int?> values) => Interop.mkTreemapAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ITreemapProperty> ids(IEnumerable<float?> values) => Interop.mkTreemapAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITreemapProperty> customdata(bool val) => Interop.mkTreemapAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITreemapProperty> customdata(params bool[] values) => Interop.mkTreemapAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITreemapProperty> customdata(System.DateTime val) => Interop.mkTreemapAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITreemapProperty> customdata(params System.DateTime[] values) => Interop.mkTreemapAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITreemapProperty> customdata(float val) => Interop.mkTreemapAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITreemapProperty> customdata(params float[] values) => Interop.mkTreemapAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITreemapProperty> customdata(int val) => Interop.mkTreemapAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITreemapProperty> customdata(params int[] values) => Interop.mkTreemapAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITreemapProperty> customdata(string val) => Interop.mkTreemapAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITreemapProperty> customdata(params string[] values) => Interop.mkTreemapAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITreemapProperty> customdata(IEnumerable<bool[]> values) => Interop.mkTreemapAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITreemapProperty> customdata(List<bool[]> values) => Interop.mkTreemapAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITreemapProperty> customdata(params bool[][] values) => Interop.mkTreemapAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITreemapProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkTreemapAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITreemapProperty> customdata(List<string[]> values) => Interop.mkTreemapAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITreemapProperty> customdata(params string[][] values) => Interop.mkTreemapAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITreemapProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkTreemapAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITreemapProperty> customdata(List<int[]> values) => Interop.mkTreemapAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITreemapProperty> customdata(params int[][] values) => Interop.mkTreemapAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITreemapProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkTreemapAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITreemapProperty> customdata(List<float[]> values) => Interop.mkTreemapAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITreemapProperty> customdata(params float[][] values) => Interop.mkTreemapAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITreemapProperty> customdata(Literals.PlotData[] values) => Interop.mkTreemapAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITreemapProperty> customdata(IEnumerable<bool?> values) => Interop.mkTreemapAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITreemapProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkTreemapAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITreemapProperty> customdata(IEnumerable<int?> values) => Interop.mkTreemapAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ITreemapProperty> customdata(IEnumerable<float?> values) => Interop.mkTreemapAttr("customdata", values.ToArray());
        public static Box<ITreemapProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkTreemapAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<ITreemapProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkTreemapAttr("stream", Bindings.flattenProperties(properties));
        public static Box<ITreemapProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkTreemapAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ITreemapProperty> uirevision(bool val) => Interop.mkTreemapAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ITreemapProperty> uirevision(params bool[] values) => Interop.mkTreemapAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ITreemapProperty> uirevision(System.DateTime val) => Interop.mkTreemapAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ITreemapProperty> uirevision(params System.DateTime[] values) => Interop.mkTreemapAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ITreemapProperty> uirevision(int val) => Interop.mkTreemapAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ITreemapProperty> uirevision(params int[] values) => Interop.mkTreemapAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ITreemapProperty> uirevision(float val) => Interop.mkTreemapAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ITreemapProperty> uirevision(params float[] values) => Interop.mkTreemapAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ITreemapProperty> uirevision(string val) => Interop.mkTreemapAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ITreemapProperty> uirevision(params string[] values) => Interop.mkTreemapAttr("uirevision", values);
        /// Sets the labels of each of the sectors.
        public static Box<ITreemapProperty> labels(bool val) => Interop.mkTreemapAttr("labels", new[]{val});
        /// Sets the labels of each of the sectors.
        public static Box<ITreemapProperty> labels(params bool[] values) => Interop.mkTreemapAttr("labels", values);
        /// Sets the labels of each of the sectors.
        public static Box<ITreemapProperty> labels(System.DateTime val) => Interop.mkTreemapAttr("labels", new[]{val});
        /// Sets the labels of each of the sectors.
        public static Box<ITreemapProperty> labels(params System.DateTime[] values) => Interop.mkTreemapAttr("labels", values);
        /// Sets the labels of each of the sectors.
        public static Box<ITreemapProperty> labels(float val) => Interop.mkTreemapAttr("labels", new[]{val});
        /// Sets the labels of each of the sectors.
        public static Box<ITreemapProperty> labels(params float[] values) => Interop.mkTreemapAttr("labels", values);
        /// Sets the labels of each of the sectors.
        public static Box<ITreemapProperty> labels(int val) => Interop.mkTreemapAttr("labels", new[]{val});
        /// Sets the labels of each of the sectors.
        public static Box<ITreemapProperty> labels(params int[] values) => Interop.mkTreemapAttr("labels", values);
        /// Sets the labels of each of the sectors.
        public static Box<ITreemapProperty> labels(string val) => Interop.mkTreemapAttr("labels", new[]{val});
        /// Sets the labels of each of the sectors.
        public static Box<ITreemapProperty> labels(params string[] values) => Interop.mkTreemapAttr("labels", values);
        /// Sets the labels of each of the sectors.
        public static Box<ITreemapProperty> labels(IEnumerable<bool[]> values) => Interop.mkTreemapAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<ITreemapProperty> labels(List<bool[]> values) => Interop.mkTreemapAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<ITreemapProperty> labels(params bool[][] values) => Interop.mkTreemapAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<ITreemapProperty> labels(IEnumerable<IEnumerable<string>> values) => Interop.mkTreemapAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<ITreemapProperty> labels(List<string[]> values) => Interop.mkTreemapAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<ITreemapProperty> labels(params string[][] values) => Interop.mkTreemapAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<ITreemapProperty> labels(IEnumerable<IEnumerable<int>> values) => Interop.mkTreemapAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<ITreemapProperty> labels(List<int[]> values) => Interop.mkTreemapAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<ITreemapProperty> labels(params int[][] values) => Interop.mkTreemapAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<ITreemapProperty> labels(IEnumerable<IEnumerable<float>> values) => Interop.mkTreemapAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<ITreemapProperty> labels(List<float[]> values) => Interop.mkTreemapAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<ITreemapProperty> labels(params float[][] values) => Interop.mkTreemapAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<ITreemapProperty> labels(Literals.PlotData[] values) => Interop.mkTreemapAttr("labels", values);
        /// Sets the labels of each of the sectors.
        public static Box<ITreemapProperty> labels(IEnumerable<bool?> values) => Interop.mkTreemapAttr("labels", values.ToArray());
        /// Sets the labels of each of the sectors.
        public static Box<ITreemapProperty> labels(IEnumerable<System.DateTime?> values) => Interop.mkTreemapAttr("labels", values.ToArray());
        /// Sets the labels of each of the sectors.
        public static Box<ITreemapProperty> labels(IEnumerable<int?> values) => Interop.mkTreemapAttr("labels", values.ToArray());
        /// Sets the labels of each of the sectors.
        public static Box<ITreemapProperty> labels(IEnumerable<float?> values) => Interop.mkTreemapAttr("labels", values.ToArray());
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ITreemapProperty> parents(bool val) => Interop.mkTreemapAttr("parents", new[]{val});
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ITreemapProperty> parents(params bool[] values) => Interop.mkTreemapAttr("parents", values);
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ITreemapProperty> parents(System.DateTime val) => Interop.mkTreemapAttr("parents", new[]{val});
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ITreemapProperty> parents(params System.DateTime[] values) => Interop.mkTreemapAttr("parents", values);
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ITreemapProperty> parents(float val) => Interop.mkTreemapAttr("parents", new[]{val});
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ITreemapProperty> parents(params float[] values) => Interop.mkTreemapAttr("parents", values);
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ITreemapProperty> parents(int val) => Interop.mkTreemapAttr("parents", new[]{val});
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ITreemapProperty> parents(params int[] values) => Interop.mkTreemapAttr("parents", values);
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ITreemapProperty> parents(string val) => Interop.mkTreemapAttr("parents", new[]{val});
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ITreemapProperty> parents(params string[] values) => Interop.mkTreemapAttr("parents", values);
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ITreemapProperty> parents(IEnumerable<bool[]> values) => Interop.mkTreemapAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ITreemapProperty> parents(List<bool[]> values) => Interop.mkTreemapAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ITreemapProperty> parents(params bool[][] values) => Interop.mkTreemapAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ITreemapProperty> parents(IEnumerable<IEnumerable<string>> values) => Interop.mkTreemapAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ITreemapProperty> parents(List<string[]> values) => Interop.mkTreemapAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ITreemapProperty> parents(params string[][] values) => Interop.mkTreemapAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ITreemapProperty> parents(IEnumerable<IEnumerable<int>> values) => Interop.mkTreemapAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ITreemapProperty> parents(List<int[]> values) => Interop.mkTreemapAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ITreemapProperty> parents(params int[][] values) => Interop.mkTreemapAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ITreemapProperty> parents(IEnumerable<IEnumerable<float>> values) => Interop.mkTreemapAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ITreemapProperty> parents(List<float[]> values) => Interop.mkTreemapAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ITreemapProperty> parents(params float[][] values) => Interop.mkTreemapAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ITreemapProperty> parents(Literals.PlotData[] values) => Interop.mkTreemapAttr("parents", values);
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ITreemapProperty> parents(IEnumerable<bool?> values) => Interop.mkTreemapAttr("parents", values.ToArray());
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ITreemapProperty> parents(IEnumerable<System.DateTime?> values) => Interop.mkTreemapAttr("parents", values.ToArray());
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ITreemapProperty> parents(IEnumerable<int?> values) => Interop.mkTreemapAttr("parents", values.ToArray());
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ITreemapProperty> parents(IEnumerable<float?> values) => Interop.mkTreemapAttr("parents", values.ToArray());
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ITreemapProperty> values(bool val) => Interop.mkTreemapAttr("values", new[]{val});
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ITreemapProperty> values(params bool[] values) => Interop.mkTreemapAttr("values", values);
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ITreemapProperty> values(System.DateTime val) => Interop.mkTreemapAttr("values", new[]{val});
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ITreemapProperty> values(params System.DateTime[] values) => Interop.mkTreemapAttr("values", values);
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ITreemapProperty> values(float val) => Interop.mkTreemapAttr("values", new[]{val});
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ITreemapProperty> values(params float[] values) => Interop.mkTreemapAttr("values", values);
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ITreemapProperty> values(int val) => Interop.mkTreemapAttr("values", new[]{val});
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ITreemapProperty> values(params int[] values) => Interop.mkTreemapAttr("values", values);
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ITreemapProperty> values(string val) => Interop.mkTreemapAttr("values", new[]{val});
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ITreemapProperty> values(params string[] values) => Interop.mkTreemapAttr("values", values);
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ITreemapProperty> values(IEnumerable<bool[]> values) => Interop.mkTreemapAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ITreemapProperty> values(List<bool[]> values) => Interop.mkTreemapAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ITreemapProperty> values(params bool[][] values) => Interop.mkTreemapAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ITreemapProperty> values(IEnumerable<IEnumerable<string>> values) => Interop.mkTreemapAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ITreemapProperty> values(List<string[]> values) => Interop.mkTreemapAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ITreemapProperty> values(params string[][] values) => Interop.mkTreemapAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ITreemapProperty> values(IEnumerable<IEnumerable<int>> values) => Interop.mkTreemapAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ITreemapProperty> values(List<int[]> values) => Interop.mkTreemapAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ITreemapProperty> values(params int[][] values) => Interop.mkTreemapAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ITreemapProperty> values(IEnumerable<IEnumerable<float>> values) => Interop.mkTreemapAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ITreemapProperty> values(List<float[]> values) => Interop.mkTreemapAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ITreemapProperty> values(params float[][] values) => Interop.mkTreemapAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ITreemapProperty> values(Literals.PlotData[] values) => Interop.mkTreemapAttr("values", values);
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ITreemapProperty> values(IEnumerable<bool?> values) => Interop.mkTreemapAttr("values", values.ToArray());
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ITreemapProperty> values(IEnumerable<System.DateTime?> values) => Interop.mkTreemapAttr("values", values.ToArray());
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ITreemapProperty> values(IEnumerable<int?> values) => Interop.mkTreemapAttr("values", values.ToArray());
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ITreemapProperty> values(IEnumerable<float?> values) => Interop.mkTreemapAttr("values", values.ToArray());
        /// Determines default for `values` when it is not provided, by inferring a 1 for each of the *leaves* and/or *branches*, otherwise 0.
        public static Box<ITreemapProperty> count(params Box<ITreemapProperty>[] properties) => Interop.mkTreemapAttr("count", Bindings.joinEnumProperties(properties));
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<ITreemapProperty> level(bool val) => Interop.mkTreemapAttr("level", val);
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<ITreemapProperty> level(params bool[] values) => Interop.mkTreemapAttr("level", values);
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<ITreemapProperty> level(System.DateTime val) => Interop.mkTreemapAttr("level", val);
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<ITreemapProperty> level(params System.DateTime[] values) => Interop.mkTreemapAttr("level", values);
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<ITreemapProperty> level(int val) => Interop.mkTreemapAttr("level", val);
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<ITreemapProperty> level(params int[] values) => Interop.mkTreemapAttr("level", values);
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<ITreemapProperty> level(float val) => Interop.mkTreemapAttr("level", val);
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<ITreemapProperty> level(params float[] values) => Interop.mkTreemapAttr("level", values);
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<ITreemapProperty> level(string val) => Interop.mkTreemapAttr("level", val);
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<ITreemapProperty> level(params string[] values) => Interop.mkTreemapAttr("level", values);
        /// Sets the number of rendered sectors from any given `level`. Set `maxdepth` to *-1* to render all the levels in the hierarchy.
        public static Box<ITreemapProperty> maxdepth(int val) => Interop.mkTreemapAttr("maxdepth", val);
        public static Box<ITreemapProperty> tiling(params Box<ITilingProperty>[] properties) => Interop.mkTreemapAttr("tiling", Bindings.flattenProperties(properties));
        public static Box<ITreemapProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkTreemapAttr("marker", Bindings.flattenProperties(properties));
        public static Box<ITreemapProperty> pathbar(params Box<IPathbarProperty>[] properties) => Interop.mkTreemapAttr("pathbar", Bindings.flattenProperties(properties));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ITreemapProperty> text(bool val) => Interop.mkTreemapAttr("text", new[]{val});
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ITreemapProperty> text(IEnumerable<bool> values) => Interop.mkTreemapAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ITreemapProperty> text(System.DateTime val) => Interop.mkTreemapAttr("text", new[]{val});
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ITreemapProperty> text(IEnumerable<System.DateTime> values) => Interop.mkTreemapAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ITreemapProperty> text(float val) => Interop.mkTreemapAttr("text", new[]{val});
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ITreemapProperty> text(IEnumerable<float> values) => Interop.mkTreemapAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ITreemapProperty> text(int val) => Interop.mkTreemapAttr("text", new[]{val});
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ITreemapProperty> text(IEnumerable<int> values) => Interop.mkTreemapAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ITreemapProperty> text(string val) => Interop.mkTreemapAttr("text", new[]{val});
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ITreemapProperty> text(IEnumerable<string> values) => Interop.mkTreemapAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ITreemapProperty> text(IEnumerable<bool[]> values) => Interop.mkTreemapAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ITreemapProperty> text(List<bool[]> values) => Interop.mkTreemapAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ITreemapProperty> text(params bool[][] values) => Interop.mkTreemapAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ITreemapProperty> text(IEnumerable<IEnumerable<string>> values) => Interop.mkTreemapAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ITreemapProperty> text(List<string[]> values) => Interop.mkTreemapAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ITreemapProperty> text(params string[][] values) => Interop.mkTreemapAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ITreemapProperty> text(IEnumerable<IEnumerable<int>> values) => Interop.mkTreemapAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ITreemapProperty> text(List<int[]> values) => Interop.mkTreemapAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ITreemapProperty> text(params int[][] values) => Interop.mkTreemapAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ITreemapProperty> text(IEnumerable<IEnumerable<float>> values) => Interop.mkTreemapAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ITreemapProperty> text(List<float[]> values) => Interop.mkTreemapAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ITreemapProperty> text(params float[][] values) => Interop.mkTreemapAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ITreemapProperty> text(Literals.PlotData[] values) => Interop.mkTreemapAttr("text", values);
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ITreemapProperty> text(IEnumerable<bool?> values) => Interop.mkTreemapAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ITreemapProperty> text(IEnumerable<System.DateTime?> values) => Interop.mkTreemapAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ITreemapProperty> text(IEnumerable<int?> values) => Interop.mkTreemapAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ITreemapProperty> text(IEnumerable<float?> values) => Interop.mkTreemapAttr("text", values.ToArray());
        /// Determines which trace information appear on the graph.
        public static Box<ITreemapProperty> textinfo(params Box<ITreemapProperty>[] properties) => Interop.mkTreemapAttr("textinfo", Bindings.joinEnumProperties(properties));
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry`, `percentParent`, `label` and `value`.
        public static Box<ITreemapProperty> texttemplate(string val) => Interop.mkTreemapAttr("texttemplate", val);
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry`, `percentParent`, `label` and `value`.
        public static Box<ITreemapProperty> texttemplate(IEnumerable<string> values) => Interop.mkTreemapAttr("texttemplate", values.ToArray());
        /// Sets hover text elements associated with each sector. If a single string, the same string appears for all data points. If an array of string, the items are mapped in order of this trace's sectors. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<ITreemapProperty> hovertext(string val) => Interop.mkTreemapAttr("hovertext", val);
        /// Sets hover text elements associated with each sector. If a single string, the same string appears for all data points. If an array of string, the items are mapped in order of this trace's sectors. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<ITreemapProperty> hovertext(IEnumerable<string> values) => Interop.mkTreemapAttr("hovertext", values.ToArray());
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<ITreemapProperty> hoverinfo(params Box<ITreemapProperty>[] properties) => Interop.mkTreemapAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry` and `percentParent`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<ITreemapProperty> hovertemplate(string val) => Interop.mkTreemapAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry` and `percentParent`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<ITreemapProperty> hovertemplate(IEnumerable<string> values) => Interop.mkTreemapAttr("hovertemplate", values.ToArray());
        /// Sets the font used for `textinfo`.
        public static Box<ITreemapProperty> textfont(params Box<ITextfontProperty>[] properties) => Interop.mkTreemapAttr("textfont", Bindings.flattenProperties(properties));
        /// Sets the font used for `textinfo` lying inside the sector.
        public static Box<ITreemapProperty> insidetextfont(params Box<IInsidetextfontProperty>[] properties) => Interop.mkTreemapAttr("insidetextfont", Bindings.flattenProperties(properties));
        /// Sets the font used for `textinfo` lying outside the sector. This option refers to the root of the hierarchy presented on top left corner of a treemap graph. Please note that if a hierarchy has multiple root nodes, this option won't have any effect and `insidetextfont` would be used.
        public static Box<ITreemapProperty> outsidetextfont(params Box<IOutsidetextfontProperty>[] properties) => Interop.mkTreemapAttr("outsidetextfont", Bindings.flattenProperties(properties));
        public static Box<ITreemapProperty> domain(params Box<IDomainProperty>[] properties) => Interop.mkTreemapAttr("domain", Bindings.flattenProperties(properties));
        /// Sets the source reference on plot.ly for  ids .
        public static Box<ITreemapProperty> idssrc(string val) => Interop.mkTreemapAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<ITreemapProperty> customdatasrc(string val) => Interop.mkTreemapAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<ITreemapProperty> metasrc(string val) => Interop.mkTreemapAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  labels .
        public static Box<ITreemapProperty> labelssrc(string val) => Interop.mkTreemapAttr("labelssrc", val);
        /// Sets the source reference on plot.ly for  parents .
        public static Box<ITreemapProperty> parentssrc(string val) => Interop.mkTreemapAttr("parentssrc", val);
        /// Sets the source reference on plot.ly for  values .
        public static Box<ITreemapProperty> valuessrc(string val) => Interop.mkTreemapAttr("valuessrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<ITreemapProperty> textsrc(string val) => Interop.mkTreemapAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  texttemplate .
        public static Box<ITreemapProperty> texttemplatesrc(string val) => Interop.mkTreemapAttr("texttemplatesrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<ITreemapProperty> hovertextsrc(string val) => Interop.mkTreemapAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<ITreemapProperty> hoverinfosrc(string val) => Interop.mkTreemapAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<ITreemapProperty> hovertemplatesrc(string val) => Interop.mkTreemapAttr("hovertemplatesrc", val);
    }

    public static partial class Treemap
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<ITreemapProperty> legendonly() => Interop.mkTreemapAttr("visible", "legendonly");
            public static Box<ITreemapProperty> _false() => Interop.mkTreemapAttr("visible", false);
            public static Box<ITreemapProperty> _true() => Interop.mkTreemapAttr("visible", true);
        }

        /// Determines how the items in `values` are summed. When set to *total*, items in `values` are taken to be value of all its descendants. When set to *remainder*, items in `values` corresponding to the root and the branches sectors are taken to be the extra part not part of the sum of the values at their leaves.
        public static partial class Branchvalues
        {
            public static Box<ITreemapProperty> remainder() => Interop.mkTreemapAttr("branchvalues", "remainder");
            public static Box<ITreemapProperty> total() => Interop.mkTreemapAttr("branchvalues", "total");
        }

        /// Determines default for `values` when it is not provided, by inferring a 1 for each of the *leaves* and/or *branches*, otherwise 0.
        public static partial class Count
        {
            public static Box<ITreemapProperty> branches() => Interop.mkTreemapAttr("count", "branches");
            public static Box<ITreemapProperty> leaves() => Interop.mkTreemapAttr("count", "leaves");
        }

        /// Determines which trace information appear on the graph.
        public static partial class Textinfo
        {
            public static Box<ITreemapProperty> none() => Interop.mkTreemapAttr("textinfo", "none");
            public static Box<ITreemapProperty> currentPath() => Interop.mkTreemapAttr("textinfo", "current path");
            public static Box<ITreemapProperty> label() => Interop.mkTreemapAttr("textinfo", "label");
            public static Box<ITreemapProperty> percentEntry() => Interop.mkTreemapAttr("textinfo", "percent entry");
            public static Box<ITreemapProperty> percentParent() => Interop.mkTreemapAttr("textinfo", "percent parent");
            public static Box<ITreemapProperty> percentRoot() => Interop.mkTreemapAttr("textinfo", "percent root");
            public static Box<ITreemapProperty> text() => Interop.mkTreemapAttr("textinfo", "text");
            public static Box<ITreemapProperty> value() => Interop.mkTreemapAttr("textinfo", "value");
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<ITreemapProperty> all() => Interop.mkTreemapAttr("hoverinfo", "all");
            public static Box<ITreemapProperty> none() => Interop.mkTreemapAttr("hoverinfo", "none");
            public static Box<ITreemapProperty> skip() => Interop.mkTreemapAttr("hoverinfo", "skip");
            public static Box<ITreemapProperty> currentPath() => Interop.mkTreemapAttr("hoverinfo", "current path");
            public static Box<ITreemapProperty> label() => Interop.mkTreemapAttr("hoverinfo", "label");
            public static Box<ITreemapProperty> name() => Interop.mkTreemapAttr("hoverinfo", "name");
            public static Box<ITreemapProperty> percentEntry() => Interop.mkTreemapAttr("hoverinfo", "percent entry");
            public static Box<ITreemapProperty> percentParent() => Interop.mkTreemapAttr("hoverinfo", "percent parent");
            public static Box<ITreemapProperty> percentRoot() => Interop.mkTreemapAttr("hoverinfo", "percent root");
            public static Box<ITreemapProperty> text() => Interop.mkTreemapAttr("hoverinfo", "text");
            public static Box<ITreemapProperty> value() => Interop.mkTreemapAttr("hoverinfo", "value");
        }

        /// Sets the positions of the `text` elements.
        public static partial class Textposition
        {
            public static Box<ITreemapProperty> bottomCenter() => Interop.mkTreemapAttr("textposition", "bottom center");
            public static Box<ITreemapProperty> bottomLeft() => Interop.mkTreemapAttr("textposition", "bottom left");
            public static Box<ITreemapProperty> bottomRight() => Interop.mkTreemapAttr("textposition", "bottom right");
            public static Box<ITreemapProperty> middleCenter() => Interop.mkTreemapAttr("textposition", "middle center");
            public static Box<ITreemapProperty> middleLeft() => Interop.mkTreemapAttr("textposition", "middle left");
            public static Box<ITreemapProperty> middleRight() => Interop.mkTreemapAttr("textposition", "middle right");
            public static Box<ITreemapProperty> topCenter() => Interop.mkTreemapAttr("textposition", "top center");
            public static Box<ITreemapProperty> topLeft() => Interop.mkTreemapAttr("textposition", "top left");
            public static Box<ITreemapProperty> topRight() => Interop.mkTreemapAttr("textposition", "top right");
        }
    }
}