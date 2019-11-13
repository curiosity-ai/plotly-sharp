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

    public static partial class Sunburst
    {
        /// Sets the opacity of the trace.
        public static Box<ISunburstProperty> opacity(int val) => Interop.mkSunburstAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<ISunburstProperty> opacity(float val) => Interop.mkSunburstAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<ISunburstProperty> name(string val) => Interop.mkSunburstAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<ISunburstProperty> uid(string val) => Interop.mkSunburstAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISunburstProperty> ids(bool val) => Interop.mkSunburstAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISunburstProperty> ids(params bool[] values) => Interop.mkSunburstAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISunburstProperty> ids(System.DateTime val) => Interop.mkSunburstAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISunburstProperty> ids(params System.DateTime[] values) => Interop.mkSunburstAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISunburstProperty> ids(float val) => Interop.mkSunburstAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISunburstProperty> ids(params float[] values) => Interop.mkSunburstAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISunburstProperty> ids(int val) => Interop.mkSunburstAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISunburstProperty> ids(params int[] values) => Interop.mkSunburstAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISunburstProperty> ids(string val) => Interop.mkSunburstAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISunburstProperty> ids(params string[] values) => Interop.mkSunburstAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISunburstProperty> ids(IEnumerable<bool[]> values) => Interop.mkSunburstAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISunburstProperty> ids(List<bool[]> values) => Interop.mkSunburstAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISunburstProperty> ids(params bool[][] values) => Interop.mkSunburstAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISunburstProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkSunburstAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISunburstProperty> ids(List<string[]> values) => Interop.mkSunburstAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISunburstProperty> ids(params string[][] values) => Interop.mkSunburstAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISunburstProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkSunburstAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISunburstProperty> ids(List<int[]> values) => Interop.mkSunburstAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISunburstProperty> ids(params int[][] values) => Interop.mkSunburstAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISunburstProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkSunburstAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISunburstProperty> ids(List<float[]> values) => Interop.mkSunburstAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISunburstProperty> ids(params float[][] values) => Interop.mkSunburstAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISunburstProperty> ids(Literals.PlotData[] values) => Interop.mkSunburstAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISunburstProperty> ids(IEnumerable<bool?> values) => Interop.mkSunburstAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISunburstProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkSunburstAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISunburstProperty> ids(IEnumerable<int?> values) => Interop.mkSunburstAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISunburstProperty> ids(IEnumerable<float?> values) => Interop.mkSunburstAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISunburstProperty> customdata(bool val) => Interop.mkSunburstAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISunburstProperty> customdata(params bool[] values) => Interop.mkSunburstAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISunburstProperty> customdata(System.DateTime val) => Interop.mkSunburstAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISunburstProperty> customdata(params System.DateTime[] values) => Interop.mkSunburstAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISunburstProperty> customdata(float val) => Interop.mkSunburstAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISunburstProperty> customdata(params float[] values) => Interop.mkSunburstAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISunburstProperty> customdata(int val) => Interop.mkSunburstAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISunburstProperty> customdata(params int[] values) => Interop.mkSunburstAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISunburstProperty> customdata(string val) => Interop.mkSunburstAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISunburstProperty> customdata(params string[] values) => Interop.mkSunburstAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISunburstProperty> customdata(IEnumerable<bool[]> values) => Interop.mkSunburstAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISunburstProperty> customdata(List<bool[]> values) => Interop.mkSunburstAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISunburstProperty> customdata(params bool[][] values) => Interop.mkSunburstAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISunburstProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkSunburstAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISunburstProperty> customdata(List<string[]> values) => Interop.mkSunburstAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISunburstProperty> customdata(params string[][] values) => Interop.mkSunburstAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISunburstProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkSunburstAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISunburstProperty> customdata(List<int[]> values) => Interop.mkSunburstAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISunburstProperty> customdata(params int[][] values) => Interop.mkSunburstAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISunburstProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkSunburstAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISunburstProperty> customdata(List<float[]> values) => Interop.mkSunburstAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISunburstProperty> customdata(params float[][] values) => Interop.mkSunburstAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISunburstProperty> customdata(Literals.PlotData[] values) => Interop.mkSunburstAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISunburstProperty> customdata(IEnumerable<bool?> values) => Interop.mkSunburstAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISunburstProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkSunburstAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISunburstProperty> customdata(IEnumerable<int?> values) => Interop.mkSunburstAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISunburstProperty> customdata(IEnumerable<float?> values) => Interop.mkSunburstAttr("customdata", values.ToArray());
        public static Box<ISunburstProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkSunburstAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<ISunburstProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkSunburstAttr("stream", Bindings.flattenProperties(properties));
        public static Box<ISunburstProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkSunburstAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISunburstProperty> uirevision(bool val) => Interop.mkSunburstAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISunburstProperty> uirevision(params bool[] values) => Interop.mkSunburstAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISunburstProperty> uirevision(System.DateTime val) => Interop.mkSunburstAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISunburstProperty> uirevision(params System.DateTime[] values) => Interop.mkSunburstAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISunburstProperty> uirevision(int val) => Interop.mkSunburstAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISunburstProperty> uirevision(params int[] values) => Interop.mkSunburstAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISunburstProperty> uirevision(float val) => Interop.mkSunburstAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISunburstProperty> uirevision(params float[] values) => Interop.mkSunburstAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISunburstProperty> uirevision(string val) => Interop.mkSunburstAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISunburstProperty> uirevision(params string[] values) => Interop.mkSunburstAttr("uirevision", values);
        /// Sets the labels of each of the sectors.
        public static Box<ISunburstProperty> labels(bool val) => Interop.mkSunburstAttr("labels", new[]{val});
        /// Sets the labels of each of the sectors.
        public static Box<ISunburstProperty> labels(params bool[] values) => Interop.mkSunburstAttr("labels", values);
        /// Sets the labels of each of the sectors.
        public static Box<ISunburstProperty> labels(System.DateTime val) => Interop.mkSunburstAttr("labels", new[]{val});
        /// Sets the labels of each of the sectors.
        public static Box<ISunburstProperty> labels(params System.DateTime[] values) => Interop.mkSunburstAttr("labels", values);
        /// Sets the labels of each of the sectors.
        public static Box<ISunburstProperty> labels(float val) => Interop.mkSunburstAttr("labels", new[]{val});
        /// Sets the labels of each of the sectors.
        public static Box<ISunburstProperty> labels(params float[] values) => Interop.mkSunburstAttr("labels", values);
        /// Sets the labels of each of the sectors.
        public static Box<ISunburstProperty> labels(int val) => Interop.mkSunburstAttr("labels", new[]{val});
        /// Sets the labels of each of the sectors.
        public static Box<ISunburstProperty> labels(params int[] values) => Interop.mkSunburstAttr("labels", values);
        /// Sets the labels of each of the sectors.
        public static Box<ISunburstProperty> labels(string val) => Interop.mkSunburstAttr("labels", new[]{val});
        /// Sets the labels of each of the sectors.
        public static Box<ISunburstProperty> labels(params string[] values) => Interop.mkSunburstAttr("labels", values);
        /// Sets the labels of each of the sectors.
        public static Box<ISunburstProperty> labels(IEnumerable<bool[]> values) => Interop.mkSunburstAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<ISunburstProperty> labels(List<bool[]> values) => Interop.mkSunburstAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<ISunburstProperty> labels(params bool[][] values) => Interop.mkSunburstAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<ISunburstProperty> labels(IEnumerable<IEnumerable<string>> values) => Interop.mkSunburstAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<ISunburstProperty> labels(List<string[]> values) => Interop.mkSunburstAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<ISunburstProperty> labels(params string[][] values) => Interop.mkSunburstAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<ISunburstProperty> labels(IEnumerable<IEnumerable<int>> values) => Interop.mkSunburstAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<ISunburstProperty> labels(List<int[]> values) => Interop.mkSunburstAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<ISunburstProperty> labels(params int[][] values) => Interop.mkSunburstAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<ISunburstProperty> labels(IEnumerable<IEnumerable<float>> values) => Interop.mkSunburstAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<ISunburstProperty> labels(List<float[]> values) => Interop.mkSunburstAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<ISunburstProperty> labels(params float[][] values) => Interop.mkSunburstAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the labels of each of the sectors.
        public static Box<ISunburstProperty> labels(Literals.PlotData[] values) => Interop.mkSunburstAttr("labels", values);
        /// Sets the labels of each of the sectors.
        public static Box<ISunburstProperty> labels(IEnumerable<bool?> values) => Interop.mkSunburstAttr("labels", values.ToArray());
        /// Sets the labels of each of the sectors.
        public static Box<ISunburstProperty> labels(IEnumerable<System.DateTime?> values) => Interop.mkSunburstAttr("labels", values.ToArray());
        /// Sets the labels of each of the sectors.
        public static Box<ISunburstProperty> labels(IEnumerable<int?> values) => Interop.mkSunburstAttr("labels", values.ToArray());
        /// Sets the labels of each of the sectors.
        public static Box<ISunburstProperty> labels(IEnumerable<float?> values) => Interop.mkSunburstAttr("labels", values.ToArray());
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ISunburstProperty> parents(bool val) => Interop.mkSunburstAttr("parents", new[]{val});
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ISunburstProperty> parents(params bool[] values) => Interop.mkSunburstAttr("parents", values);
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ISunburstProperty> parents(System.DateTime val) => Interop.mkSunburstAttr("parents", new[]{val});
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ISunburstProperty> parents(params System.DateTime[] values) => Interop.mkSunburstAttr("parents", values);
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ISunburstProperty> parents(float val) => Interop.mkSunburstAttr("parents", new[]{val});
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ISunburstProperty> parents(params float[] values) => Interop.mkSunburstAttr("parents", values);
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ISunburstProperty> parents(int val) => Interop.mkSunburstAttr("parents", new[]{val});
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ISunburstProperty> parents(params int[] values) => Interop.mkSunburstAttr("parents", values);
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ISunburstProperty> parents(string val) => Interop.mkSunburstAttr("parents", new[]{val});
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ISunburstProperty> parents(params string[] values) => Interop.mkSunburstAttr("parents", values);
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ISunburstProperty> parents(IEnumerable<bool[]> values) => Interop.mkSunburstAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ISunburstProperty> parents(List<bool[]> values) => Interop.mkSunburstAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ISunburstProperty> parents(params bool[][] values) => Interop.mkSunburstAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ISunburstProperty> parents(IEnumerable<IEnumerable<string>> values) => Interop.mkSunburstAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ISunburstProperty> parents(List<string[]> values) => Interop.mkSunburstAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ISunburstProperty> parents(params string[][] values) => Interop.mkSunburstAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ISunburstProperty> parents(IEnumerable<IEnumerable<int>> values) => Interop.mkSunburstAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ISunburstProperty> parents(List<int[]> values) => Interop.mkSunburstAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ISunburstProperty> parents(params int[][] values) => Interop.mkSunburstAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ISunburstProperty> parents(IEnumerable<IEnumerable<float>> values) => Interop.mkSunburstAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ISunburstProperty> parents(List<float[]> values) => Interop.mkSunburstAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ISunburstProperty> parents(params float[][] values) => Interop.mkSunburstAttr("parents", Bindings.flatten2DArrayIf1D(values));
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ISunburstProperty> parents(Literals.PlotData[] values) => Interop.mkSunburstAttr("parents", values);
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ISunburstProperty> parents(IEnumerable<bool?> values) => Interop.mkSunburstAttr("parents", values.ToArray());
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ISunburstProperty> parents(IEnumerable<System.DateTime?> values) => Interop.mkSunburstAttr("parents", values.ToArray());
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ISunburstProperty> parents(IEnumerable<int?> values) => Interop.mkSunburstAttr("parents", values.ToArray());
        /// Sets the parent sectors for each of the sectors. Empty string items '' are understood to reference the root node in the hierarchy. If `ids` is filled, `parents` items are understood to be \"ids\" themselves. When `ids` is not set, plotly attempts to find matching items in `labels`, but beware they must be unique.
        public static Box<ISunburstProperty> parents(IEnumerable<float?> values) => Interop.mkSunburstAttr("parents", values.ToArray());
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ISunburstProperty> values(bool val) => Interop.mkSunburstAttr("values", new[]{val});
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ISunburstProperty> values(params bool[] values) => Interop.mkSunburstAttr("values", values);
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ISunburstProperty> values(System.DateTime val) => Interop.mkSunburstAttr("values", new[]{val});
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ISunburstProperty> values(params System.DateTime[] values) => Interop.mkSunburstAttr("values", values);
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ISunburstProperty> values(float val) => Interop.mkSunburstAttr("values", new[]{val});
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ISunburstProperty> values(params float[] values) => Interop.mkSunburstAttr("values", values);
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ISunburstProperty> values(int val) => Interop.mkSunburstAttr("values", new[]{val});
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ISunburstProperty> values(params int[] values) => Interop.mkSunburstAttr("values", values);
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ISunburstProperty> values(string val) => Interop.mkSunburstAttr("values", new[]{val});
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ISunburstProperty> values(params string[] values) => Interop.mkSunburstAttr("values", values);
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ISunburstProperty> values(IEnumerable<bool[]> values) => Interop.mkSunburstAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ISunburstProperty> values(List<bool[]> values) => Interop.mkSunburstAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ISunburstProperty> values(params bool[][] values) => Interop.mkSunburstAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ISunburstProperty> values(IEnumerable<IEnumerable<string>> values) => Interop.mkSunburstAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ISunburstProperty> values(List<string[]> values) => Interop.mkSunburstAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ISunburstProperty> values(params string[][] values) => Interop.mkSunburstAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ISunburstProperty> values(IEnumerable<IEnumerable<int>> values) => Interop.mkSunburstAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ISunburstProperty> values(List<int[]> values) => Interop.mkSunburstAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ISunburstProperty> values(params int[][] values) => Interop.mkSunburstAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ISunburstProperty> values(IEnumerable<IEnumerable<float>> values) => Interop.mkSunburstAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ISunburstProperty> values(List<float[]> values) => Interop.mkSunburstAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ISunburstProperty> values(params float[][] values) => Interop.mkSunburstAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ISunburstProperty> values(Literals.PlotData[] values) => Interop.mkSunburstAttr("values", values);
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ISunburstProperty> values(IEnumerable<bool?> values) => Interop.mkSunburstAttr("values", values.ToArray());
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ISunburstProperty> values(IEnumerable<System.DateTime?> values) => Interop.mkSunburstAttr("values", values.ToArray());
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ISunburstProperty> values(IEnumerable<int?> values) => Interop.mkSunburstAttr("values", values.ToArray());
        /// Sets the values associated with each of the sectors. Use with `branchvalues` to determine how the values are summed.
        public static Box<ISunburstProperty> values(IEnumerable<float?> values) => Interop.mkSunburstAttr("values", values.ToArray());
        /// Determines default for `values` when it is not provided, by inferring a 1 for each of the *leaves* and/or *branches*, otherwise 0.
        public static Box<ISunburstProperty> count(params Box<ISunburstProperty>[] properties) => Interop.mkSunburstAttr("count", Bindings.joinEnumProperties(properties));
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<ISunburstProperty> level(bool val) => Interop.mkSunburstAttr("level", val);
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<ISunburstProperty> level(params bool[] values) => Interop.mkSunburstAttr("level", values);
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<ISunburstProperty> level(System.DateTime val) => Interop.mkSunburstAttr("level", val);
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<ISunburstProperty> level(params System.DateTime[] values) => Interop.mkSunburstAttr("level", values);
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<ISunburstProperty> level(int val) => Interop.mkSunburstAttr("level", val);
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<ISunburstProperty> level(params int[] values) => Interop.mkSunburstAttr("level", values);
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<ISunburstProperty> level(float val) => Interop.mkSunburstAttr("level", val);
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<ISunburstProperty> level(params float[] values) => Interop.mkSunburstAttr("level", values);
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<ISunburstProperty> level(string val) => Interop.mkSunburstAttr("level", val);
        /// Sets the level from which this trace hierarchy is rendered. Set `level` to `''` to start from the root node in the hierarchy. Must be an \"id\" if `ids` is filled in, otherwise plotly attempts to find a matching item in `labels`.
        public static Box<ISunburstProperty> level(params string[] values) => Interop.mkSunburstAttr("level", values);
        /// Sets the number of rendered sectors from any given `level`. Set `maxdepth` to *-1* to render all the levels in the hierarchy.
        public static Box<ISunburstProperty> maxdepth(int val) => Interop.mkSunburstAttr("maxdepth", val);
        public static Box<ISunburstProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkSunburstAttr("marker", Bindings.flattenProperties(properties));
        public static Box<ISunburstProperty> leaf(params Box<ILeafProperty>[] properties) => Interop.mkSunburstAttr("leaf", Bindings.flattenProperties(properties));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISunburstProperty> text(bool val) => Interop.mkSunburstAttr("text", new[]{val});
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISunburstProperty> text(IEnumerable<bool> values) => Interop.mkSunburstAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISunburstProperty> text(System.DateTime val) => Interop.mkSunburstAttr("text", new[]{val});
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISunburstProperty> text(IEnumerable<System.DateTime> values) => Interop.mkSunburstAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISunburstProperty> text(float val) => Interop.mkSunburstAttr("text", new[]{val});
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISunburstProperty> text(IEnumerable<float> values) => Interop.mkSunburstAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISunburstProperty> text(int val) => Interop.mkSunburstAttr("text", new[]{val});
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISunburstProperty> text(IEnumerable<int> values) => Interop.mkSunburstAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISunburstProperty> text(string val) => Interop.mkSunburstAttr("text", new[]{val});
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISunburstProperty> text(IEnumerable<string> values) => Interop.mkSunburstAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISunburstProperty> text(IEnumerable<bool[]> values) => Interop.mkSunburstAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISunburstProperty> text(List<bool[]> values) => Interop.mkSunburstAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISunburstProperty> text(params bool[][] values) => Interop.mkSunburstAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISunburstProperty> text(IEnumerable<IEnumerable<string>> values) => Interop.mkSunburstAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISunburstProperty> text(List<string[]> values) => Interop.mkSunburstAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISunburstProperty> text(params string[][] values) => Interop.mkSunburstAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISunburstProperty> text(IEnumerable<IEnumerable<int>> values) => Interop.mkSunburstAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISunburstProperty> text(List<int[]> values) => Interop.mkSunburstAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISunburstProperty> text(params int[][] values) => Interop.mkSunburstAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISunburstProperty> text(IEnumerable<IEnumerable<float>> values) => Interop.mkSunburstAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISunburstProperty> text(List<float[]> values) => Interop.mkSunburstAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISunburstProperty> text(params float[][] values) => Interop.mkSunburstAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISunburstProperty> text(Literals.PlotData[] values) => Interop.mkSunburstAttr("text", values);
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISunburstProperty> text(IEnumerable<bool?> values) => Interop.mkSunburstAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISunburstProperty> text(IEnumerable<System.DateTime?> values) => Interop.mkSunburstAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISunburstProperty> text(IEnumerable<int?> values) => Interop.mkSunburstAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISunburstProperty> text(IEnumerable<float?> values) => Interop.mkSunburstAttr("text", values.ToArray());
        /// Determines which trace information appear on the graph.
        public static Box<ISunburstProperty> textinfo(params Box<ISunburstProperty>[] properties) => Interop.mkSunburstAttr("textinfo", Bindings.joinEnumProperties(properties));
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry`, `percentParent`, `label` and `value`.
        public static Box<ISunburstProperty> texttemplate(string val) => Interop.mkSunburstAttr("texttemplate", val);
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry`, `percentParent`, `label` and `value`.
        public static Box<ISunburstProperty> texttemplate(IEnumerable<string> values) => Interop.mkSunburstAttr("texttemplate", values.ToArray());
        /// Sets hover text elements associated with each sector. If a single string, the same string appears for all data points. If an array of string, the items are mapped in order of this trace's sectors. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<ISunburstProperty> hovertext(string val) => Interop.mkSunburstAttr("hovertext", val);
        /// Sets hover text elements associated with each sector. If a single string, the same string appears for all data points. If an array of string, the items are mapped in order of this trace's sectors. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<ISunburstProperty> hovertext(IEnumerable<string> values) => Interop.mkSunburstAttr("hovertext", values.ToArray());
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<ISunburstProperty> hoverinfo(params Box<ISunburstProperty>[] properties) => Interop.mkSunburstAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry` and `percentParent`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<ISunburstProperty> hovertemplate(string val) => Interop.mkSunburstAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `currentPath`, `root`, `entry`, `percentRoot`, `percentEntry` and `percentParent`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<ISunburstProperty> hovertemplate(IEnumerable<string> values) => Interop.mkSunburstAttr("hovertemplate", values.ToArray());
        /// Sets the font used for `textinfo`.
        public static Box<ISunburstProperty> textfont(params Box<ITextfontProperty>[] properties) => Interop.mkSunburstAttr("textfont", Bindings.flattenProperties(properties));
        /// Sets the font used for `textinfo` lying inside the sector.
        public static Box<ISunburstProperty> insidetextfont(params Box<IInsidetextfontProperty>[] properties) => Interop.mkSunburstAttr("insidetextfont", Bindings.flattenProperties(properties));
        /// Sets the font used for `textinfo` lying outside the sector.
        public static Box<ISunburstProperty> outsidetextfont(params Box<IOutsidetextfontProperty>[] properties) => Interop.mkSunburstAttr("outsidetextfont", Bindings.flattenProperties(properties));
        public static Box<ISunburstProperty> domain(params Box<IDomainProperty>[] properties) => Interop.mkSunburstAttr("domain", Bindings.flattenProperties(properties));
        /// Sets the source reference on plot.ly for  ids .
        public static Box<ISunburstProperty> idssrc(string val) => Interop.mkSunburstAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<ISunburstProperty> customdatasrc(string val) => Interop.mkSunburstAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<ISunburstProperty> metasrc(string val) => Interop.mkSunburstAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  labels .
        public static Box<ISunburstProperty> labelssrc(string val) => Interop.mkSunburstAttr("labelssrc", val);
        /// Sets the source reference on plot.ly for  parents .
        public static Box<ISunburstProperty> parentssrc(string val) => Interop.mkSunburstAttr("parentssrc", val);
        /// Sets the source reference on plot.ly for  values .
        public static Box<ISunburstProperty> valuessrc(string val) => Interop.mkSunburstAttr("valuessrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<ISunburstProperty> textsrc(string val) => Interop.mkSunburstAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  texttemplate .
        public static Box<ISunburstProperty> texttemplatesrc(string val) => Interop.mkSunburstAttr("texttemplatesrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<ISunburstProperty> hovertextsrc(string val) => Interop.mkSunburstAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<ISunburstProperty> hoverinfosrc(string val) => Interop.mkSunburstAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<ISunburstProperty> hovertemplatesrc(string val) => Interop.mkSunburstAttr("hovertemplatesrc", val);
    }

    public static partial class Sunburst
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<ISunburstProperty> legendonly() => Interop.mkSunburstAttr("visible", "legendonly");
            public static Box<ISunburstProperty> _false() => Interop.mkSunburstAttr("visible", false);
            public static Box<ISunburstProperty> _true() => Interop.mkSunburstAttr("visible", true);
        }

        /// Determines how the items in `values` are summed. When set to *total*, items in `values` are taken to be value of all its descendants. When set to *remainder*, items in `values` corresponding to the root and the branches sectors are taken to be the extra part not part of the sum of the values at their leaves.
        public static partial class Branchvalues
        {
            public static Box<ISunburstProperty> remainder() => Interop.mkSunburstAttr("branchvalues", "remainder");
            public static Box<ISunburstProperty> total() => Interop.mkSunburstAttr("branchvalues", "total");
        }

        /// Determines default for `values` when it is not provided, by inferring a 1 for each of the *leaves* and/or *branches*, otherwise 0.
        public static partial class Count
        {
            public static Box<ISunburstProperty> branches() => Interop.mkSunburstAttr("count", "branches");
            public static Box<ISunburstProperty> leaves() => Interop.mkSunburstAttr("count", "leaves");
        }

        /// Determines which trace information appear on the graph.
        public static partial class Textinfo
        {
            public static Box<ISunburstProperty> none() => Interop.mkSunburstAttr("textinfo", "none");
            public static Box<ISunburstProperty> currentPath() => Interop.mkSunburstAttr("textinfo", "current path");
            public static Box<ISunburstProperty> label() => Interop.mkSunburstAttr("textinfo", "label");
            public static Box<ISunburstProperty> percentEntry() => Interop.mkSunburstAttr("textinfo", "percent entry");
            public static Box<ISunburstProperty> percentParent() => Interop.mkSunburstAttr("textinfo", "percent parent");
            public static Box<ISunburstProperty> percentRoot() => Interop.mkSunburstAttr("textinfo", "percent root");
            public static Box<ISunburstProperty> text() => Interop.mkSunburstAttr("textinfo", "text");
            public static Box<ISunburstProperty> value() => Interop.mkSunburstAttr("textinfo", "value");
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<ISunburstProperty> all() => Interop.mkSunburstAttr("hoverinfo", "all");
            public static Box<ISunburstProperty> none() => Interop.mkSunburstAttr("hoverinfo", "none");
            public static Box<ISunburstProperty> skip() => Interop.mkSunburstAttr("hoverinfo", "skip");
            public static Box<ISunburstProperty> currentPath() => Interop.mkSunburstAttr("hoverinfo", "current path");
            public static Box<ISunburstProperty> label() => Interop.mkSunburstAttr("hoverinfo", "label");
            public static Box<ISunburstProperty> name() => Interop.mkSunburstAttr("hoverinfo", "name");
            public static Box<ISunburstProperty> percentEntry() => Interop.mkSunburstAttr("hoverinfo", "percent entry");
            public static Box<ISunburstProperty> percentParent() => Interop.mkSunburstAttr("hoverinfo", "percent parent");
            public static Box<ISunburstProperty> percentRoot() => Interop.mkSunburstAttr("hoverinfo", "percent root");
            public static Box<ISunburstProperty> text() => Interop.mkSunburstAttr("hoverinfo", "text");
            public static Box<ISunburstProperty> value() => Interop.mkSunburstAttr("hoverinfo", "value");
        }
    }
}