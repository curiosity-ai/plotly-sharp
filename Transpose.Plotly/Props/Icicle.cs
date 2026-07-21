namespace Transpose.Plotly
{
    /*////////////////////////////////
    /// THIS FILE IS AUTO-GENERATED //
    ///      by propsDocument       //
    ////////////////////////////////*/
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Types;
    using Transpose;
    using static Transpose.Core.dom;

    public static partial class Icicle
    {
        public static Box<IIcicleProperty> legendgrouptitle(params Box<ILegendgrouptitleProperty>[] properties) => Interop.mkIcicleAttr("legendgrouptitle", Bindings.flattenProperties(properties));
        /// Sets the legend rank for this trace. Items and groups with smaller ranks are presented on top/left side while with `*reversed* `legend.traceorder` they are on bottom/right side. The default legendrank is 1000, so that you can use ranks less than 1000 to place certain items before all unranked items, and ranks greater than 1000 to go after all unranked items.
        public static Box<IIcicleProperty> legendrank(int val) => Interop.mkIcicleAttr("legendrank", val);
        /// Sets the legend rank for this trace. Items and groups with smaller ranks are presented on top/left side while with `*reversed* `legend.traceorder` they are on bottom/right side. The default legendrank is 1000, so that you can use ranks less than 1000 to place certain items before all unranked items, and ranks greater than 1000 to go after all unranked items.
        public static Box<IIcicleProperty> legendrank(float val) => Interop.mkIcicleAttr("legendrank", val);
        /// Sets the opacity of the trace.
        public static Box<IIcicleProperty> opacity(int val) => Interop.mkIcicleAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<IIcicleProperty> opacity(float val) => Interop.mkIcicleAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IIcicleProperty> name(string val) => Interop.mkIcicleAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IIcicleProperty> uid(string val) => Interop.mkIcicleAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIcicleProperty> ids(bool val) => Interop.mkIcicleAttr("ids", new[] { val });
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIcicleProperty> ids(IEnumerable<bool> values) => Interop.mkIcicleAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIcicleProperty> ids(System.DateTime val) => Interop.mkIcicleAttr("ids", new[] { val });
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIcicleProperty> ids(IEnumerable<System.DateTime> values) => Interop.mkIcicleAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIcicleProperty> ids(float val) => Interop.mkIcicleAttr("ids", new[] { val });
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIcicleProperty> ids(IEnumerable<float> values) => Interop.mkIcicleAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIcicleProperty> ids(int val) => Interop.mkIcicleAttr("ids", new[] { val });
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIcicleProperty> ids(IEnumerable<int> values) => Interop.mkIcicleAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIcicleProperty> ids(string val) => Interop.mkIcicleAttr("ids", new[] { val });
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIcicleProperty> ids(IEnumerable<string> values) => Interop.mkIcicleAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIcicleProperty> ids(IEnumerable<bool[]> values) => Interop.mkIcicleAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIcicleProperty> ids(List<bool[]> values) => Interop.mkIcicleAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIcicleProperty> ids(params bool[][] values) => Interop.mkIcicleAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIcicleProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkIcicleAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIcicleProperty> ids(List<string[]> values) => Interop.mkIcicleAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIcicleProperty> ids(params string[][] values) => Interop.mkIcicleAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIcicleProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkIcicleAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIcicleProperty> ids(List<int[]> values) => Interop.mkIcicleAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIcicleProperty> ids(params int[][] values) => Interop.mkIcicleAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIcicleProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkIcicleAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIcicleProperty> ids(List<float[]> values) => Interop.mkIcicleAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIcicleProperty> ids(params float[][] values) => Interop.mkIcicleAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIcicleProperty> ids(Literals.PlotData[] values) => Interop.mkIcicleAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIcicleProperty> ids(IEnumerable<bool?> values) => Interop.mkIcicleAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIcicleProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkIcicleAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIcicleProperty> ids(IEnumerable<int?> values) => Interop.mkIcicleAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIcicleProperty> ids(IEnumerable<float?> values) => Interop.mkIcicleAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIcicleProperty> customdata(bool val) => Interop.mkIcicleAttr("customdata", new[] { val });
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIcicleProperty> customdata(IEnumerable<bool> values) => Interop.mkIcicleAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIcicleProperty> customdata(System.DateTime val) => Interop.mkIcicleAttr("customdata", new[] { val });
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIcicleProperty> customdata(IEnumerable<System.DateTime> values) => Interop.mkIcicleAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIcicleProperty> customdata(float val) => Interop.mkIcicleAttr("customdata", new[] { val });
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIcicleProperty> customdata(IEnumerable<float> values) => Interop.mkIcicleAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIcicleProperty> customdata(int val) => Interop.mkIcicleAttr("customdata", new[] { val });
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIcicleProperty> customdata(IEnumerable<int> values) => Interop.mkIcicleAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIcicleProperty> customdata(string val) => Interop.mkIcicleAttr("customdata", new[] { val });
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIcicleProperty> customdata(IEnumerable<string> values) => Interop.mkIcicleAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIcicleProperty> customdata(IEnumerable<bool[]> values) => Interop.mkIcicleAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIcicleProperty> customdata(List<bool[]> values) => Interop.mkIcicleAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIcicleProperty> customdata(params bool[][] values) => Interop.mkIcicleAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIcicleProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkIcicleAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIcicleProperty> customdata(List<string[]> values) => Interop.mkIcicleAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIcicleProperty> customdata(params string[][] values) => Interop.mkIcicleAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIcicleProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkIcicleAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIcicleProperty> customdata(List<int[]> values) => Interop.mkIcicleAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIcicleProperty> customdata(params int[][] values) => Interop.mkIcicleAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIcicleProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkIcicleAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIcicleProperty> customdata(List<float[]> values) => Interop.mkIcicleAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIcicleProperty> customdata(params float[][] values) => Interop.mkIcicleAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIcicleProperty> customdata(Literals.PlotData[] values) => Interop.mkIcicleAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIcicleProperty> customdata(IEnumerable<bool?> values) => Interop.mkIcicleAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIcicleProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkIcicleAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIcicleProperty> customdata(IEnumerable<int?> values) => Interop.mkIcicleAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIcicleProperty> customdata(IEnumerable<float?> values) => Interop.mkIcicleAttr("customdata", values.ToArray());
        public static Box<IIcicleProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkIcicleAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IIcicleProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkIcicleAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IIcicleProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkIcicleAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIcicleProperty> uirevision(bool val) => Interop.mkIcicleAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIcicleProperty> uirevision(params bool[] values) => Interop.mkIcicleAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIcicleProperty> uirevision(System.DateTime val) => Interop.mkIcicleAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIcicleProperty> uirevision(params System.DateTime[] values) => Interop.mkIcicleAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIcicleProperty> uirevision(int val) => Interop.mkIcicleAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIcicleProperty> uirevision(params int[] values) => Interop.mkIcicleAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIcicleProperty> uirevision(float val) => Interop.mkIcicleAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIcicleProperty> uirevision(params float[] values) => Interop.mkIcicleAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIcicleProperty> uirevision(string val) => Interop.mkIcicleAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIcicleProperty> uirevision(params string[] values) => Interop.mkIcicleAttr("uirevision", values);
        /// Sets the labels of each of the sectors.
        public static Box<IIcicleProperty> labels(bool val) => Interop.mkIcicleAttr("labels", new[] { val });
        /// Sets the labels of each of the sectors.
        public static Box<IIcicleProperty> labels(IEnumerable<bool> values) => Interop.mkIcicleAttr("labels", values.ToArray());
        /// Sets the labels of each of the sectors.
        public static Box<IIcicleProperty> labels(System.DateTime val) => Interop.mkIcicleAttr("labels", new[] { val });
        /// Sets the labels of each of the sectors.
        public static Box<IIcicleProperty> labels(IEnumerable<System.DateTime> values) => Interop.mkIcicleAttr("labels", values.ToArray());
        /// Sets the labels of each of the sectors.
        public static Box<IIcicleProperty> labels(float val) => Interop.mkIcicleAttr("labels", new[] { val });
        /// Sets the labels of each of the sectors.
        public static Box<IIcicleProperty> labels(IEnumerable<float> values) => Interop.mkIcicleAttr("labels", values.ToArray());
        /// Sets the labels of each of the sectors.
        public static Box<IIcicleProperty> labels(int val) => Interop.mkIcicleAttr("labels", new[] { val });
        /// Sets the labels of each of the sectors.
        public static Box<IIcicleProperty> labels(IEnumerable<int> values) => Interop.mkIcicleAttr("labels", values.ToArray());
        /// Sets the labels of each of the sectors.
        public static Box<IIcicleProperty> labels(string val) => Interop.mkIcicleAttr("labels", new[] { val });
        /// Sets the labels of each of the sectors.
        public static Box<IIcicleProperty> labels(IEnumerable<string> values) => Interop.mkIcicleAttr("labels", values.ToArray());
        /// Sets the labels of each of the sectors.
        public static Box<IIcicleProperty> labels(IEnumerable<bool[]> values) => Interop.mkIcicleAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<IIcicleProperty> labels(List<bool[]> values) => Interop.mkIcicleAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<IIcicleProperty> labels(params bool[][] values) => Interop.mkIcicleAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<IIcicleProperty> labels(IEnumerable<IEnumerable<string>> values) => Interop.mkIcicleAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<IIcicleProperty> labels(List<string[]> values) => Interop.mkIcicleAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<IIcicleProperty> labels(params string[][] values) => Interop.mkIcicleAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<IIcicleProperty> labels(IEnumerable<IEnumerable<int>> values) => Interop.mkIcicleAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<IIcicleProperty> labels(List<int[]> values) => Interop.mkIcicleAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<IIcicleProperty> labels(params int[][] values) => Interop.mkIcicleAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<IIcicleProperty> labels(IEnumerable<IEnumerable<float>> values) => Interop.mkIcicleAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<IIcicleProperty> labels(List<float[]> values) => Interop.mkIcicleAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<IIcicleProperty> labels(params float[][] values) => Interop.mkIcicleAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<IIcicleProperty> labels(Literals.PlotData[] values) => Interop.mkIcicleAttr("labels", values);
        /// Sets the labels of each of the sectors.
        public static Box<IIcicleProperty> labels(IEnumerable<bool?> values) => Interop.mkIcicleAttr("labels", values.ToArray());
        /// Sets the labels of each of the sectors.
        public static Box<IIcicleProperty> labels(IEnumerable<System.DateTime?> values) => Interop.mkIcicleAttr("labels", values.ToArray());
        /// Sets the labels of each of the sectors.
        public static Box<IIcicleProperty> labels(IEnumerable<int?> values) => Interop.mkIcicleAttr("labels", values.ToArray());
        /// Sets the labels of each of the sectors.
        public static Box<IIcicleProperty> labels(IEnumerable<float?> values) => Interop.mkIcicleAttr("labels", values.ToArray());
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<IIcicleProperty> parents(bool val) => Interop.mkIcicleAttr("parents", new[] { val });
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<IIcicleProperty> parents(IEnumerable<bool> values) => Interop.mkIcicleAttr("parents", values.ToArray());
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<IIcicleProperty> parents(System.DateTime val) => Interop.mkIcicleAttr("parents", new[] { val });
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<IIcicleProperty> parents(IEnumerable<System.DateTime> values) => Interop.mkIcicleAttr("parents", values.ToArray());
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<IIcicleProperty> parents(float val) => Interop.mkIcicleAttr("parents", new[] { val });
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<IIcicleProperty> parents(IEnumerable<float> values) => Interop.mkIcicleAttr("parents", values.ToArray());
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<IIcicleProperty> parents(int val) => Interop.mkIcicleAttr("parents", new[] { val });
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<IIcicleProperty> parents(IEnumerable<int> values) => Interop.mkIcicleAttr("parents", values.ToArray());
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<IIcicleProperty> parents(string val) => Interop.mkIcicleAttr("parents", new[] { val });
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<IIcicleProperty> parents(IEnumerable<string> values) => Interop.mkIcicleAttr("parents", values.ToArray());
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<IIcicleProperty> parents(IEnumerable<bool[]> values) => Interop.mkIcicleAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<IIcicleProperty> parents(List<bool[]> values) => Interop.mkIcicleAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<IIcicleProperty> parents(params bool[][] values) => Interop.mkIcicleAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<IIcicleProperty> parents(IEnumerable<IEnumerable<string>> values) => Interop.mkIcicleAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<IIcicleProperty> parents(List<string[]> values) => Interop.mkIcicleAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<IIcicleProperty> parents(params string[][] values) => Interop.mkIcicleAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<IIcicleProperty> parents(IEnumerable<IEnumerable<int>> values) => Interop.mkIcicleAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<IIcicleProperty> parents(List<int[]> values) => Interop.mkIcicleAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<IIcicleProperty> parents(params int[][] values) => Interop.mkIcicleAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<IIcicleProperty> parents(IEnumerable<IEnumerable<float>> values) => Interop.mkIcicleAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<IIcicleProperty> parents(List<float[]> values) => Interop.mkIcicleAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<IIcicleProperty> parents(params float[][] values) => Interop.mkIcicleAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<IIcicleProperty> parents(Literals.PlotData[] values) => Interop.mkIcicleAttr("parents", values);
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<IIcicleProperty> parents(IEnumerable<bool?> values) => Interop.mkIcicleAttr("parents", values.ToArray());
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<IIcicleProperty> parents(IEnumerable<System.DateTime?> values) => Interop.mkIcicleAttr("parents", values.ToArray());
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<IIcicleProperty> parents(IEnumerable<int?> values) => Interop.mkIcicleAttr("parents", values.ToArray());
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<IIcicleProperty> parents(IEnumerable<float?> values) => Interop.mkIcicleAttr("parents", values.ToArray());
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<IIcicleProperty> values(bool val) => Interop.mkIcicleAttr("values", new[] { val });
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<IIcicleProperty> values(IEnumerable<bool> values) => Interop.mkIcicleAttr("values", values.ToArray());
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<IIcicleProperty> values(System.DateTime val) => Interop.mkIcicleAttr("values", new[] { val });
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<IIcicleProperty> values(IEnumerable<System.DateTime> values) => Interop.mkIcicleAttr("values", values.ToArray());
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<IIcicleProperty> values(float val) => Interop.mkIcicleAttr("values", new[] { val });
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<IIcicleProperty> values(IEnumerable<float> values) => Interop.mkIcicleAttr("values", values.ToArray());
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<IIcicleProperty> values(int val) => Interop.mkIcicleAttr("values", new[] { val });
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<IIcicleProperty> values(IEnumerable<int> values) => Interop.mkIcicleAttr("values", values.ToArray());
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<IIcicleProperty> values(string val) => Interop.mkIcicleAttr("values", new[] { val });
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<IIcicleProperty> values(IEnumerable<string> values) => Interop.mkIcicleAttr("values", values.ToArray());
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<IIcicleProperty> values(IEnumerable<bool[]> values) => Interop.mkIcicleAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<IIcicleProperty> values(List<bool[]> values) => Interop.mkIcicleAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<IIcicleProperty> values(params bool[][] values) => Interop.mkIcicleAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<IIcicleProperty> values(IEnumerable<IEnumerable<string>> values) => Interop.mkIcicleAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<IIcicleProperty> values(List<string[]> values) => Interop.mkIcicleAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<IIcicleProperty> values(params string[][] values) => Interop.mkIcicleAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<IIcicleProperty> values(IEnumerable<IEnumerable<int>> values) => Interop.mkIcicleAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<IIcicleProperty> values(List<int[]> values) => Interop.mkIcicleAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<IIcicleProperty> values(params int[][] values) => Interop.mkIcicleAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<IIcicleProperty> values(IEnumerable<IEnumerable<float>> values) => Interop.mkIcicleAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<IIcicleProperty> values(List<float[]> values) => Interop.mkIcicleAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<IIcicleProperty> values(params float[][] values) => Interop.mkIcicleAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<IIcicleProperty> values(Literals.PlotData[] values) => Interop.mkIcicleAttr("values", values);
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<IIcicleProperty> values(IEnumerable<bool?> values) => Interop.mkIcicleAttr("values", values.ToArray());
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<IIcicleProperty> values(IEnumerable<System.DateTime?> values) => Interop.mkIcicleAttr("values", values.ToArray());
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<IIcicleProperty> values(IEnumerable<int?> values) => Interop.mkIcicleAttr("values", values.ToArray());
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<IIcicleProperty> values(IEnumerable<float?> values) => Interop.mkIcicleAttr("values", values.ToArray());
        /// Determines default for `values` when it is not provided, by inferring a 1 for each of the *leaves* and/or *branches*, otherwise 0.
        public static Box<IIcicleProperty> count(params Box<IIcicleProperty>[] properties) => Interop.mkIcicleAttr("count", Bindings.joinEnumProperties(properties));
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<IIcicleProperty> level(bool val) => Interop.mkIcicleAttr("level", val);
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<IIcicleProperty> level(params bool[] values) => Interop.mkIcicleAttr("level", values);
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<IIcicleProperty> level(System.DateTime val) => Interop.mkIcicleAttr("level", val);
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<IIcicleProperty> level(params System.DateTime[] values) => Interop.mkIcicleAttr("level", values);
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<IIcicleProperty> level(int val) => Interop.mkIcicleAttr("level", val);
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<IIcicleProperty> level(params int[] values) => Interop.mkIcicleAttr("level", values);
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<IIcicleProperty> level(float val) => Interop.mkIcicleAttr("level", val);
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<IIcicleProperty> level(params float[] values) => Interop.mkIcicleAttr("level", values);
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<IIcicleProperty> level(string val) => Interop.mkIcicleAttr("level", val);
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<IIcicleProperty> level(params string[] values) => Interop.mkIcicleAttr("level", values);
        /// Sets the number of rendered sectors from any given `level`. Set `maxdepth` to *-1* to render all the levels in the hierarchy.
        public static Box<IIcicleProperty> maxdepth(int val) => Interop.mkIcicleAttr("maxdepth", val);
        public static Box<IIcicleProperty> tiling(params Box<ITilingProperty>[] properties) => Interop.mkIcicleAttr("tiling", Bindings.flattenProperties(properties));
        public static Box<IIcicleProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkIcicleAttr("marker", Bindings.flattenProperties(properties));
        public static Box<IIcicleProperty> leaf(params Box<ILeafProperty>[] properties) => Interop.mkIcicleAttr("leaf", Bindings.flattenProperties(properties));
        public static Box<IIcicleProperty> pathbar(params Box<IPathbarProperty>[] properties) => Interop.mkIcicleAttr("pathbar", Bindings.flattenProperties(properties));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIcicleProperty> text(bool val) => Interop.mkIcicleAttr("text", new[] { val });
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIcicleProperty> text(IEnumerable<bool> values) => Interop.mkIcicleAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIcicleProperty> text(System.DateTime val) => Interop.mkIcicleAttr("text", new[] { val });
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIcicleProperty> text(IEnumerable<System.DateTime> values) => Interop.mkIcicleAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIcicleProperty> text(float val) => Interop.mkIcicleAttr("text", new[] { val });
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIcicleProperty> text(IEnumerable<float> values) => Interop.mkIcicleAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIcicleProperty> text(int val) => Interop.mkIcicleAttr("text", new[] { val });
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIcicleProperty> text(IEnumerable<int> values) => Interop.mkIcicleAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIcicleProperty> text(string val) => Interop.mkIcicleAttr("text", new[] { val });
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIcicleProperty> text(IEnumerable<string> values) => Interop.mkIcicleAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIcicleProperty> text(IEnumerable<bool[]> values) => Interop.mkIcicleAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIcicleProperty> text(List<bool[]> values) => Interop.mkIcicleAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIcicleProperty> text(params bool[][] values) => Interop.mkIcicleAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIcicleProperty> text(IEnumerable<IEnumerable<string>> values) => Interop.mkIcicleAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIcicleProperty> text(List<string[]> values) => Interop.mkIcicleAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIcicleProperty> text(params string[][] values) => Interop.mkIcicleAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIcicleProperty> text(IEnumerable<IEnumerable<int>> values) => Interop.mkIcicleAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIcicleProperty> text(List<int[]> values) => Interop.mkIcicleAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIcicleProperty> text(params int[][] values) => Interop.mkIcicleAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIcicleProperty> text(IEnumerable<IEnumerable<float>> values) => Interop.mkIcicleAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIcicleProperty> text(List<float[]> values) => Interop.mkIcicleAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIcicleProperty> text(params float[][] values) => Interop.mkIcicleAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIcicleProperty> text(Literals.PlotData[] values) => Interop.mkIcicleAttr("text", values);
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIcicleProperty> text(IEnumerable<bool?> values) => Interop.mkIcicleAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIcicleProperty> text(IEnumerable<System.DateTime?> values) => Interop.mkIcicleAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIcicleProperty> text(IEnumerable<int?> values) => Interop.mkIcicleAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIcicleProperty> text(IEnumerable<float?> values) => Interop.mkIcicleAttr("text", values.ToArray());
        /// Determines which trace information appear on the graph.
        public static Box<IIcicleProperty> textinfo(params Box<IIcicleProperty>[] properties) => Interop.mkIcicleAttr("textinfo", Bindings.joinEnumProperties(properties));
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-time-format#locale_format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry`, `percentParent`, `label` and `value`.
        public static Box<IIcicleProperty> texttemplate(string val) => Interop.mkIcicleAttr("texttemplate", val);
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-time-format#locale_format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry`, `percentParent`, `label` and `value`.
        public static Box<IIcicleProperty> texttemplate(IEnumerable<string> values) => Interop.mkIcicleAttr("texttemplate", values.ToArray());
        /// Sets hover text elements associated with each sector. If a single string, the same string appears for all data points. If an array of string, the items are mapped in order of this trace's sectors. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IIcicleProperty> hovertext(string val) => Interop.mkIcicleAttr("hovertext", val);
        /// Sets hover text elements associated with each sector. If a single string, the same string appears for all data points. If an array of string, the items are mapped in order of this trace's sectors. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IIcicleProperty> hovertext(IEnumerable<string> values) => Interop.mkIcicleAttr("hovertext", values.ToArray());
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IIcicleProperty> hoverinfo(params Box<IIcicleProperty>[] properties) => Interop.mkIcicleAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\" as well as %{xother}, {%_xother}, {%_xother_}, {%xother_}. When showing info for several points, *xother* will be added to those with different x positions from the first point. An underscore before or after *(x|y)other* will add a space on that side, only when this field is shown. Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-time-format#locale_format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry` and `percentParent`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IIcicleProperty> hovertemplate(string val) => Interop.mkIcicleAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\" as well as %{xother}, {%_xother}, {%_xother_}, {%xother_}. When showing info for several points, *xother* will be added to those with different x positions from the first point. An underscore before or after *(x|y)other* will add a space on that side, only when this field is shown. Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-time-format#locale_format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plotly.com/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry` and `percentParent`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IIcicleProperty> hovertemplate(IEnumerable<string> values) => Interop.mkIcicleAttr("hovertemplate", values.ToArray());
        /// Sets the font used for `textinfo`.
        public static Box<IIcicleProperty> textfont(params Box<ITextfontProperty>[] properties) => Interop.mkIcicleAttr("textfont", Bindings.flattenProperties(properties));
        /// Sets the font used for `textinfo` lying inside the sector.
        public static Box<IIcicleProperty> insidetextfont(params Box<IInsidetextfontProperty>[] properties) => Interop.mkIcicleAttr("insidetextfont", Bindings.flattenProperties(properties));
        /// Sets the font used for `textinfo` lying outside the sector. This option refers to the root of the hierarchy presented on top left corner of a treemap graph. Please note that if a hierarchy has multiple root nodes, this option won't have any effect and `insidetextfont` would be used.
        public static Box<IIcicleProperty> outsidetextfont(params Box<IOutsidetextfontProperty>[] properties) => Interop.mkIcicleAttr("outsidetextfont", Bindings.flattenProperties(properties));
        /// Determines whether or not the sectors are reordered from largest to smallest.
        public static Box<IIcicleProperty> sort(bool val) => Interop.mkIcicleAttr("sort", val);
        public static Box<IIcicleProperty> root(params Box<IRootProperty>[] properties) => Interop.mkIcicleAttr("root", Bindings.flattenProperties(properties));
        public static Box<IIcicleProperty> domain(params Box<IDomainProperty>[] properties) => Interop.mkIcicleAttr("domain", Bindings.flattenProperties(properties));
        /// Sets the source reference on Chart Studio Cloud for  ids .
        public static Box<IIcicleProperty> idssrc(string val) => Interop.mkIcicleAttr("idssrc", val);
        /// Sets the source reference on Chart Studio Cloud for  customdata .
        public static Box<IIcicleProperty> customdatasrc(string val) => Interop.mkIcicleAttr("customdatasrc", val);
        /// Sets the source reference on Chart Studio Cloud for  meta .
        public static Box<IIcicleProperty> metasrc(string val) => Interop.mkIcicleAttr("metasrc", val);
        /// Sets the source reference on Chart Studio Cloud for  labels .
        public static Box<IIcicleProperty> labelssrc(string val) => Interop.mkIcicleAttr("labelssrc", val);
        /// Sets the source reference on Chart Studio Cloud for  parents .
        public static Box<IIcicleProperty> parentssrc(string val) => Interop.mkIcicleAttr("parentssrc", val);
        /// Sets the source reference on Chart Studio Cloud for  values .
        public static Box<IIcicleProperty> valuessrc(string val) => Interop.mkIcicleAttr("valuessrc", val);
        /// Sets the source reference on Chart Studio Cloud for  text .
        public static Box<IIcicleProperty> textsrc(string val) => Interop.mkIcicleAttr("textsrc", val);
        /// Sets the source reference on Chart Studio Cloud for  texttemplate .
        public static Box<IIcicleProperty> texttemplatesrc(string val) => Interop.mkIcicleAttr("texttemplatesrc", val);
        /// Sets the source reference on Chart Studio Cloud for  hovertext .
        public static Box<IIcicleProperty> hovertextsrc(string val) => Interop.mkIcicleAttr("hovertextsrc", val);
        /// Sets the source reference on Chart Studio Cloud for  hoverinfo .
        public static Box<IIcicleProperty> hoverinfosrc(string val) => Interop.mkIcicleAttr("hoverinfosrc", val);
        /// Sets the source reference on Chart Studio Cloud for  hovertemplate .
        public static Box<IIcicleProperty> hovertemplatesrc(string val) => Interop.mkIcicleAttr("hovertemplatesrc", val);
    }

    public static partial class Icicle
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IIcicleProperty> legendonly() => Interop.mkIcicleAttr("visible", "legendonly");
            public static Box<IIcicleProperty> _false() => Interop.mkIcicleAttr("visible", false);
            public static Box<IIcicleProperty> _true() => Interop.mkIcicleAttr("visible", true);
        }

        /// Determines how the items in `values` are summed. When set to *total*, items in `values` are taken to be value of all its descendants. When set to *remainder*, items in `values` corresponding to the root and the branches sectors are taken to be the extra part not part of the sum of the values at their leaves.
        public static partial class Branchvalues
        {
            public static Box<IIcicleProperty> remainder() => Interop.mkIcicleAttr("branchvalues", "remainder");
            public static Box<IIcicleProperty> total() => Interop.mkIcicleAttr("branchvalues", "total");
        }

        /// Determines default for `values` when it is not provided, by inferring a 1 for each of the *leaves* and/or *branches*, otherwise 0.
        public static partial class Count
        {
            public static Box<IIcicleProperty> branches() => Interop.mkIcicleAttr("count", "branches");
            public static Box<IIcicleProperty> leaves() => Interop.mkIcicleAttr("count", "leaves");
        }

        /// Determines which trace information appear on the graph.
        public static partial class Textinfo
        {
            public static Box<IIcicleProperty> none() => Interop.mkIcicleAttr("textinfo", "none");
            public static Box<IIcicleProperty> currentPath() => Interop.mkIcicleAttr("textinfo", "current path");
            public static Box<IIcicleProperty> label() => Interop.mkIcicleAttr("textinfo", "label");
            public static Box<IIcicleProperty> percentEntry() => Interop.mkIcicleAttr("textinfo", "percent entry");
            public static Box<IIcicleProperty> percentParent() => Interop.mkIcicleAttr("textinfo", "percent parent");
            public static Box<IIcicleProperty> percentRoot() => Interop.mkIcicleAttr("textinfo", "percent root");
            public static Box<IIcicleProperty> text() => Interop.mkIcicleAttr("textinfo", "text");
            public static Box<IIcicleProperty> value() => Interop.mkIcicleAttr("textinfo", "value");
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IIcicleProperty> all() => Interop.mkIcicleAttr("hoverinfo", "all");
            public static Box<IIcicleProperty> none() => Interop.mkIcicleAttr("hoverinfo", "none");
            public static Box<IIcicleProperty> skip() => Interop.mkIcicleAttr("hoverinfo", "skip");
            public static Box<IIcicleProperty> currentPath() => Interop.mkIcicleAttr("hoverinfo", "current path");
            public static Box<IIcicleProperty> label() => Interop.mkIcicleAttr("hoverinfo", "label");
            public static Box<IIcicleProperty> name() => Interop.mkIcicleAttr("hoverinfo", "name");
            public static Box<IIcicleProperty> percentEntry() => Interop.mkIcicleAttr("hoverinfo", "percent entry");
            public static Box<IIcicleProperty> percentParent() => Interop.mkIcicleAttr("hoverinfo", "percent parent");
            public static Box<IIcicleProperty> percentRoot() => Interop.mkIcicleAttr("hoverinfo", "percent root");
            public static Box<IIcicleProperty> text() => Interop.mkIcicleAttr("hoverinfo", "text");
            public static Box<IIcicleProperty> value() => Interop.mkIcicleAttr("hoverinfo", "value");
        }

        /// Sets the positions of the `text` elements.
        public static partial class Textposition
        {
            public static Box<IIcicleProperty> bottomCenter() => Interop.mkIcicleAttr("textposition", "bottom center");
            public static Box<IIcicleProperty> bottomLeft() => Interop.mkIcicleAttr("textposition", "bottom left");
            public static Box<IIcicleProperty> bottomRight() => Interop.mkIcicleAttr("textposition", "bottom right");
            public static Box<IIcicleProperty> middleCenter() => Interop.mkIcicleAttr("textposition", "middle center");
            public static Box<IIcicleProperty> middleLeft() => Interop.mkIcicleAttr("textposition", "middle left");
            public static Box<IIcicleProperty> middleRight() => Interop.mkIcicleAttr("textposition", "middle right");
            public static Box<IIcicleProperty> topCenter() => Interop.mkIcicleAttr("textposition", "top center");
            public static Box<IIcicleProperty> topLeft() => Interop.mkIcicleAttr("textposition", "top left");
            public static Box<IIcicleProperty> topRight() => Interop.mkIcicleAttr("textposition", "top right");
        }
    }
}