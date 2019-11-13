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

    public static partial class Histogram2d
    {
        /// Sets the opacity of the trace.
        public static Box<IHistogram2dProperty> opacity(int val) => Interop.mkHistogram2dAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<IHistogram2dProperty> opacity(float val) => Interop.mkHistogram2dAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IHistogram2dProperty> name(string val) => Interop.mkHistogram2dAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IHistogram2dProperty> uid(string val) => Interop.mkHistogram2dAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dProperty> ids(bool val) => Interop.mkHistogram2dAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dProperty> ids(params bool[] values) => Interop.mkHistogram2dAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dProperty> ids(System.DateTime val) => Interop.mkHistogram2dAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dProperty> ids(params System.DateTime[] values) => Interop.mkHistogram2dAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dProperty> ids(float val) => Interop.mkHistogram2dAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dProperty> ids(params float[] values) => Interop.mkHistogram2dAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dProperty> ids(int val) => Interop.mkHistogram2dAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dProperty> ids(params int[] values) => Interop.mkHistogram2dAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dProperty> ids(string val) => Interop.mkHistogram2dAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dProperty> ids(params string[] values) => Interop.mkHistogram2dAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dProperty> ids(IEnumerable<bool[]> values) => Interop.mkHistogram2dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dProperty> ids(List<bool[]> values) => Interop.mkHistogram2dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dProperty> ids(params bool[][] values) => Interop.mkHistogram2dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkHistogram2dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dProperty> ids(List<string[]> values) => Interop.mkHistogram2dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dProperty> ids(params string[][] values) => Interop.mkHistogram2dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkHistogram2dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dProperty> ids(List<int[]> values) => Interop.mkHistogram2dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dProperty> ids(params int[][] values) => Interop.mkHistogram2dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkHistogram2dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dProperty> ids(List<float[]> values) => Interop.mkHistogram2dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dProperty> ids(params float[][] values) => Interop.mkHistogram2dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dProperty> ids(Literals.PlotData[] values) => Interop.mkHistogram2dAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dProperty> ids(IEnumerable<bool?> values) => Interop.mkHistogram2dAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkHistogram2dAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dProperty> ids(IEnumerable<int?> values) => Interop.mkHistogram2dAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dProperty> ids(IEnumerable<float?> values) => Interop.mkHistogram2dAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dProperty> customdata(bool val) => Interop.mkHistogram2dAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dProperty> customdata(params bool[] values) => Interop.mkHistogram2dAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dProperty> customdata(System.DateTime val) => Interop.mkHistogram2dAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dProperty> customdata(params System.DateTime[] values) => Interop.mkHistogram2dAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dProperty> customdata(float val) => Interop.mkHistogram2dAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dProperty> customdata(params float[] values) => Interop.mkHistogram2dAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dProperty> customdata(int val) => Interop.mkHistogram2dAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dProperty> customdata(params int[] values) => Interop.mkHistogram2dAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dProperty> customdata(string val) => Interop.mkHistogram2dAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dProperty> customdata(params string[] values) => Interop.mkHistogram2dAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dProperty> customdata(IEnumerable<bool[]> values) => Interop.mkHistogram2dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dProperty> customdata(List<bool[]> values) => Interop.mkHistogram2dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dProperty> customdata(params bool[][] values) => Interop.mkHistogram2dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkHistogram2dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dProperty> customdata(List<string[]> values) => Interop.mkHistogram2dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dProperty> customdata(params string[][] values) => Interop.mkHistogram2dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkHistogram2dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dProperty> customdata(List<int[]> values) => Interop.mkHistogram2dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dProperty> customdata(params int[][] values) => Interop.mkHistogram2dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkHistogram2dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dProperty> customdata(List<float[]> values) => Interop.mkHistogram2dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dProperty> customdata(params float[][] values) => Interop.mkHistogram2dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dProperty> customdata(Literals.PlotData[] values) => Interop.mkHistogram2dAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dProperty> customdata(IEnumerable<bool?> values) => Interop.mkHistogram2dAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkHistogram2dAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dProperty> customdata(IEnumerable<int?> values) => Interop.mkHistogram2dAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dProperty> customdata(IEnumerable<float?> values) => Interop.mkHistogram2dAttr("customdata", values.ToArray());
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IHistogram2dProperty> hoverinfo(params Box<IHistogram2dProperty>[] properties) => Interop.mkHistogram2dAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        public static Box<IHistogram2dProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkHistogram2dAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IHistogram2dProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkHistogram2dAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IHistogram2dProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkHistogram2dAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogram2dProperty> uirevision(bool val) => Interop.mkHistogram2dAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogram2dProperty> uirevision(params bool[] values) => Interop.mkHistogram2dAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogram2dProperty> uirevision(System.DateTime val) => Interop.mkHistogram2dAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogram2dProperty> uirevision(params System.DateTime[] values) => Interop.mkHistogram2dAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogram2dProperty> uirevision(int val) => Interop.mkHistogram2dAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogram2dProperty> uirevision(params int[] values) => Interop.mkHistogram2dAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogram2dProperty> uirevision(float val) => Interop.mkHistogram2dAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogram2dProperty> uirevision(params float[] values) => Interop.mkHistogram2dAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogram2dProperty> uirevision(string val) => Interop.mkHistogram2dAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogram2dProperty> uirevision(params string[] values) => Interop.mkHistogram2dAttr("uirevision", values);
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dProperty> x(bool val) => Interop.mkHistogram2dAttr("x", new[]{val});
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dProperty> x(IEnumerable<bool> values) => Interop.mkHistogram2dAttr("x", values.ToArray());
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dProperty> x(System.DateTime val) => Interop.mkHistogram2dAttr("x", new[]{val});
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dProperty> x(IEnumerable<System.DateTime> values) => Interop.mkHistogram2dAttr("x", values.ToArray());
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dProperty> x(float val) => Interop.mkHistogram2dAttr("x", new[]{val});
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dProperty> x(IEnumerable<float> values) => Interop.mkHistogram2dAttr("x", values.ToArray());
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dProperty> x(int val) => Interop.mkHistogram2dAttr("x", new[]{val});
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dProperty> x(IEnumerable<int> values) => Interop.mkHistogram2dAttr("x", values.ToArray());
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dProperty> x(string val) => Interop.mkHistogram2dAttr("x", new[]{val});
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dProperty> x(IEnumerable<string> values) => Interop.mkHistogram2dAttr("x", values.ToArray());
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dProperty> x(IEnumerable<bool[]> values) => Interop.mkHistogram2dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dProperty> x(List<bool[]> values) => Interop.mkHistogram2dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dProperty> x(params bool[][] values) => Interop.mkHistogram2dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dProperty> x(IEnumerable<IEnumerable<string>> values) => Interop.mkHistogram2dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dProperty> x(List<string[]> values) => Interop.mkHistogram2dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dProperty> x(params string[][] values) => Interop.mkHistogram2dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dProperty> x(IEnumerable<IEnumerable<int>> values) => Interop.mkHistogram2dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dProperty> x(List<int[]> values) => Interop.mkHistogram2dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dProperty> x(params int[][] values) => Interop.mkHistogram2dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dProperty> x(IEnumerable<IEnumerable<float>> values) => Interop.mkHistogram2dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dProperty> x(List<float[]> values) => Interop.mkHistogram2dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dProperty> x(params float[][] values) => Interop.mkHistogram2dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dProperty> x(Literals.PlotData[] values) => Interop.mkHistogram2dAttr("x", values);
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dProperty> x(IEnumerable<bool?> values) => Interop.mkHistogram2dAttr("x", values.ToArray());
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dProperty> x(IEnumerable<System.DateTime?> values) => Interop.mkHistogram2dAttr("x", values.ToArray());
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dProperty> x(IEnumerable<int?> values) => Interop.mkHistogram2dAttr("x", values.ToArray());
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dProperty> x(IEnumerable<float?> values) => Interop.mkHistogram2dAttr("x", values.ToArray());
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dProperty> y(bool val) => Interop.mkHistogram2dAttr("y", new[]{val});
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dProperty> y(IEnumerable<bool> values) => Interop.mkHistogram2dAttr("y", values.ToArray());
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dProperty> y(System.DateTime val) => Interop.mkHistogram2dAttr("y", new[]{val});
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dProperty> y(IEnumerable<System.DateTime> values) => Interop.mkHistogram2dAttr("y", values.ToArray());
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dProperty> y(float val) => Interop.mkHistogram2dAttr("y", new[]{val});
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dProperty> y(IEnumerable<float> values) => Interop.mkHistogram2dAttr("y", values.ToArray());
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dProperty> y(int val) => Interop.mkHistogram2dAttr("y", new[]{val});
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dProperty> y(IEnumerable<int> values) => Interop.mkHistogram2dAttr("y", values.ToArray());
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dProperty> y(string val) => Interop.mkHistogram2dAttr("y", new[]{val});
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dProperty> y(IEnumerable<string> values) => Interop.mkHistogram2dAttr("y", values.ToArray());
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dProperty> y(IEnumerable<bool[]> values) => Interop.mkHistogram2dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dProperty> y(List<bool[]> values) => Interop.mkHistogram2dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dProperty> y(params bool[][] values) => Interop.mkHistogram2dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dProperty> y(IEnumerable<IEnumerable<string>> values) => Interop.mkHistogram2dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dProperty> y(List<string[]> values) => Interop.mkHistogram2dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dProperty> y(params string[][] values) => Interop.mkHistogram2dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dProperty> y(IEnumerable<IEnumerable<int>> values) => Interop.mkHistogram2dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dProperty> y(List<int[]> values) => Interop.mkHistogram2dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dProperty> y(params int[][] values) => Interop.mkHistogram2dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dProperty> y(IEnumerable<IEnumerable<float>> values) => Interop.mkHistogram2dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dProperty> y(List<float[]> values) => Interop.mkHistogram2dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dProperty> y(params float[][] values) => Interop.mkHistogram2dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dProperty> y(Literals.PlotData[] values) => Interop.mkHistogram2dAttr("y", values);
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dProperty> y(IEnumerable<bool?> values) => Interop.mkHistogram2dAttr("y", values.ToArray());
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dProperty> y(IEnumerable<System.DateTime?> values) => Interop.mkHistogram2dAttr("y", values.ToArray());
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dProperty> y(IEnumerable<int?> values) => Interop.mkHistogram2dAttr("y", values.ToArray());
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dProperty> y(IEnumerable<float?> values) => Interop.mkHistogram2dAttr("y", values.ToArray());
        /// Sets the aggregation data.
        public static Box<IHistogram2dProperty> z(bool val) => Interop.mkHistogram2dAttr("z", new[]{val});
        /// Sets the aggregation data.
        public static Box<IHistogram2dProperty> z(params bool[] values) => Interop.mkHistogram2dAttr("z", values);
        /// Sets the aggregation data.
        public static Box<IHistogram2dProperty> z(System.DateTime val) => Interop.mkHistogram2dAttr("z", new[]{val});
        /// Sets the aggregation data.
        public static Box<IHistogram2dProperty> z(params System.DateTime[] values) => Interop.mkHistogram2dAttr("z", values);
        /// Sets the aggregation data.
        public static Box<IHistogram2dProperty> z(float val) => Interop.mkHistogram2dAttr("z", new[]{val});
        /// Sets the aggregation data.
        public static Box<IHistogram2dProperty> z(params float[] values) => Interop.mkHistogram2dAttr("z", values);
        /// Sets the aggregation data.
        public static Box<IHistogram2dProperty> z(int val) => Interop.mkHistogram2dAttr("z", new[]{val});
        /// Sets the aggregation data.
        public static Box<IHistogram2dProperty> z(params int[] values) => Interop.mkHistogram2dAttr("z", values);
        /// Sets the aggregation data.
        public static Box<IHistogram2dProperty> z(string val) => Interop.mkHistogram2dAttr("z", new[]{val});
        /// Sets the aggregation data.
        public static Box<IHistogram2dProperty> z(params string[] values) => Interop.mkHistogram2dAttr("z", values);
        /// Sets the aggregation data.
        public static Box<IHistogram2dProperty> z(IEnumerable<bool[]> values) => Interop.mkHistogram2dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the aggregation data.
        public static Box<IHistogram2dProperty> z(List<bool[]> values) => Interop.mkHistogram2dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the aggregation data.
        public static Box<IHistogram2dProperty> z(params bool[][] values) => Interop.mkHistogram2dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the aggregation data.
        public static Box<IHistogram2dProperty> z(IEnumerable<IEnumerable<string>> values) => Interop.mkHistogram2dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the aggregation data.
        public static Box<IHistogram2dProperty> z(List<string[]> values) => Interop.mkHistogram2dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the aggregation data.
        public static Box<IHistogram2dProperty> z(params string[][] values) => Interop.mkHistogram2dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the aggregation data.
        public static Box<IHistogram2dProperty> z(IEnumerable<IEnumerable<int>> values) => Interop.mkHistogram2dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the aggregation data.
        public static Box<IHistogram2dProperty> z(List<int[]> values) => Interop.mkHistogram2dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the aggregation data.
        public static Box<IHistogram2dProperty> z(params int[][] values) => Interop.mkHistogram2dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the aggregation data.
        public static Box<IHistogram2dProperty> z(IEnumerable<IEnumerable<float>> values) => Interop.mkHistogram2dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the aggregation data.
        public static Box<IHistogram2dProperty> z(List<float[]> values) => Interop.mkHistogram2dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the aggregation data.
        public static Box<IHistogram2dProperty> z(params float[][] values) => Interop.mkHistogram2dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the aggregation data.
        public static Box<IHistogram2dProperty> z(Literals.PlotData[] values) => Interop.mkHistogram2dAttr("z", values);
        /// Sets the aggregation data.
        public static Box<IHistogram2dProperty> z(IEnumerable<bool?> values) => Interop.mkHistogram2dAttr("z", values.ToArray());
        /// Sets the aggregation data.
        public static Box<IHistogram2dProperty> z(IEnumerable<System.DateTime?> values) => Interop.mkHistogram2dAttr("z", values.ToArray());
        /// Sets the aggregation data.
        public static Box<IHistogram2dProperty> z(IEnumerable<int?> values) => Interop.mkHistogram2dAttr("z", values.ToArray());
        /// Sets the aggregation data.
        public static Box<IHistogram2dProperty> z(IEnumerable<float?> values) => Interop.mkHistogram2dAttr("z", values.ToArray());
        public static Box<IHistogram2dProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkHistogram2dAttr("marker", Bindings.flattenProperties(properties));
        /// Specifies the maximum number of desired bins. This value will be used in an algorithm that will decide the optimal bin size such that the histogram best visualizes the distribution of the data. Ignored if `xbins.size` is provided.
        public static Box<IHistogram2dProperty> nbinsx(int val) => Interop.mkHistogram2dAttr("nbinsx", val);
        public static Box<IHistogram2dProperty> xbins(params Box<IXbinsProperty>[] properties) => Interop.mkHistogram2dAttr("xbins", Bindings.flattenProperties(properties));
        /// Specifies the maximum number of desired bins. This value will be used in an algorithm that will decide the optimal bin size such that the histogram best visualizes the distribution of the data. Ignored if `ybins.size` is provided.
        public static Box<IHistogram2dProperty> nbinsy(int val) => Interop.mkHistogram2dAttr("nbinsy", val);
        public static Box<IHistogram2dProperty> ybins(params Box<IYbinsProperty>[] properties) => Interop.mkHistogram2dAttr("ybins", Bindings.flattenProperties(properties));
        /// Obsolete: since v1.42 each bin attribute is auto-determined separately and `autobinx` is not needed. However, we accept `autobinx: true` or `false` and will update `xbins` accordingly before deleting `autobinx` from the trace.
        public static Box<IHistogram2dProperty> autobinx(bool val) => Interop.mkHistogram2dAttr("autobinx", val);
        /// Obsolete: since v1.42 each bin attribute is auto-determined separately and `autobiny` is not needed. However, we accept `autobiny: true` or `false` and will update `ybins` accordingly before deleting `autobiny` from the trace.
        public static Box<IHistogram2dProperty> autobiny(bool val) => Interop.mkHistogram2dAttr("autobiny", val);
        /// Set the `xbingroup` and `ybingroup` default prefix For example, setting a `bingroup` of *1* on two histogram2d traces will make them their x-bins and y-bins match separately.
        public static Box<IHistogram2dProperty> bingroup(string val) => Interop.mkHistogram2dAttr("bingroup", val);
        /// Set a group of histogram traces which will have compatible x-bin settings. Using `xbingroup`, histogram2d and histogram2dcontour traces  (on axes of the same axis type) can have compatible x-bin settings. Note that the same `xbingroup` value can be used to set (1D) histogram `bingroup`
        public static Box<IHistogram2dProperty> xbingroup(string val) => Interop.mkHistogram2dAttr("xbingroup", val);
        /// Set a group of histogram traces which will have compatible y-bin settings. Using `ybingroup`, histogram2d and histogram2dcontour traces  (on axes of the same axis type) can have compatible y-bin settings. Note that the same `ybingroup` value can be used to set (1D) histogram `bingroup`
        public static Box<IHistogram2dProperty> ybingroup(string val) => Interop.mkHistogram2dAttr("ybingroup", val);
        /// Sets the horizontal gap (in pixels) between bricks.
        public static Box<IHistogram2dProperty> xgap(int val) => Interop.mkHistogram2dAttr("xgap", val);
        /// Sets the horizontal gap (in pixels) between bricks.
        public static Box<IHistogram2dProperty> xgap(float val) => Interop.mkHistogram2dAttr("xgap", val);
        /// Sets the vertical gap (in pixels) between bricks.
        public static Box<IHistogram2dProperty> ygap(int val) => Interop.mkHistogram2dAttr("ygap", val);
        /// Sets the vertical gap (in pixels) between bricks.
        public static Box<IHistogram2dProperty> ygap(float val) => Interop.mkHistogram2dAttr("ygap", val);
        /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. See: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHistogram2dProperty> zhoverformat(string val) => Interop.mkHistogram2dAttr("zhoverformat", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variable `z` Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IHistogram2dProperty> hovertemplate(string val) => Interop.mkHistogram2dAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variable `z` Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IHistogram2dProperty> hovertemplate(IEnumerable<string> values) => Interop.mkHistogram2dAttr("hovertemplate", values.ToArray());
        /// Determines whether or not the color domain is computed with respect to the input data (here in `z`) or the bounds set in `zmin` and `zmax`  Defaults to `false` when `zmin` and `zmax` are set by the user.
        public static Box<IHistogram2dProperty> zauto(bool val) => Interop.mkHistogram2dAttr("zauto", val);
        /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
        public static Box<IHistogram2dProperty> zmin(int val) => Interop.mkHistogram2dAttr("zmin", val);
        /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
        public static Box<IHistogram2dProperty> zmin(float val) => Interop.mkHistogram2dAttr("zmin", val);
        /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
        public static Box<IHistogram2dProperty> zmax(int val) => Interop.mkHistogram2dAttr("zmax", val);
        /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
        public static Box<IHistogram2dProperty> zmax(float val) => Interop.mkHistogram2dAttr("zmax", val);
        /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
        public static Box<IHistogram2dProperty> zmid(int val) => Interop.mkHistogram2dAttr("zmid", val);
        /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
        public static Box<IHistogram2dProperty> zmid(float val) => Interop.mkHistogram2dAttr("zmid", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IHistogram2dProperty> colorscale(string val) => Interop.mkHistogram2dAttr("colorscale", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IHistogram2dProperty> colorscale(List<string[]> values) => Interop.mkHistogram2dAttr("colorscale", Bindings.flatten2DArrayIf1D(values));
        /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
        public static Box<IHistogram2dProperty> autocolorscale(bool val) => Interop.mkHistogram2dAttr("autocolorscale", val);
        /// Reverses the color mapping if true. If true, `zmin` will correspond to the last color in the array and `zmax` will correspond to the first color.
        public static Box<IHistogram2dProperty> reversescale(bool val) => Interop.mkHistogram2dAttr("reversescale", val);
        /// Determines whether or not a colorbar is displayed for this trace.
        public static Box<IHistogram2dProperty> showscale(bool val) => Interop.mkHistogram2dAttr("showscale", val);
        public static Box<IHistogram2dProperty> colorbar(params Box<IColorbarProperty>[] properties) => Interop.mkHistogram2dAttr("colorbar", Bindings.flattenProperties(properties));
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<IHistogram2dProperty> coloraxis(int anchorId) => Interop.mkHistogram2dAttr("coloraxis", anchorId > 1 ? $"coloraxis{anchorId}" : "");
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<IHistogram2dProperty> coloraxis(string val) => Interop.mkHistogram2dAttr("coloraxis", val);
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IHistogram2dProperty> xaxis(int anchorId) => Interop.mkHistogram2dAttr("xaxis", anchorId > 1 ? $"x{anchorId}" : "");
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IHistogram2dProperty> xaxis(string val) => Interop.mkHistogram2dAttr("xaxis", val);
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IHistogram2dProperty> yaxis(int anchorId) => Interop.mkHistogram2dAttr("yaxis", anchorId > 1 ? $"y{anchorId}" : "");
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IHistogram2dProperty> yaxis(string val) => Interop.mkHistogram2dAttr("yaxis", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IHistogram2dProperty> idssrc(string val) => Interop.mkHistogram2dAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IHistogram2dProperty> customdatasrc(string val) => Interop.mkHistogram2dAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IHistogram2dProperty> metasrc(string val) => Interop.mkHistogram2dAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IHistogram2dProperty> hoverinfosrc(string val) => Interop.mkHistogram2dAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  x .
        public static Box<IHistogram2dProperty> xsrc(string val) => Interop.mkHistogram2dAttr("xsrc", val);
        /// Sets the source reference on plot.ly for  y .
        public static Box<IHistogram2dProperty> ysrc(string val) => Interop.mkHistogram2dAttr("ysrc", val);
        /// Sets the source reference on plot.ly for  z .
        public static Box<IHistogram2dProperty> zsrc(string val) => Interop.mkHistogram2dAttr("zsrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IHistogram2dProperty> hovertemplatesrc(string val) => Interop.mkHistogram2dAttr("hovertemplatesrc", val);
    }

    public static partial class Histogram2d
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IHistogram2dProperty> legendonly() => Interop.mkHistogram2dAttr("visible", "legendonly");
            public static Box<IHistogram2dProperty> _false() => Interop.mkHistogram2dAttr("visible", false);
            public static Box<IHistogram2dProperty> _true() => Interop.mkHistogram2dAttr("visible", true);
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IHistogram2dProperty> all() => Interop.mkHistogram2dAttr("hoverinfo", "all");
            public static Box<IHistogram2dProperty> none() => Interop.mkHistogram2dAttr("hoverinfo", "none");
            public static Box<IHistogram2dProperty> skip() => Interop.mkHistogram2dAttr("hoverinfo", "skip");
            public static Box<IHistogram2dProperty> name() => Interop.mkHistogram2dAttr("hoverinfo", "name");
            public static Box<IHistogram2dProperty> text() => Interop.mkHistogram2dAttr("hoverinfo", "text");
            public static Box<IHistogram2dProperty> x() => Interop.mkHistogram2dAttr("hoverinfo", "x");
            public static Box<IHistogram2dProperty> y() => Interop.mkHistogram2dAttr("hoverinfo", "y");
            public static Box<IHistogram2dProperty> z() => Interop.mkHistogram2dAttr("hoverinfo", "z");
        }

        /// Specifies the type of normalization used for this histogram trace. If **, the span of each bar corresponds to the number of occurrences (i.e. the number of data points lying inside the bins). If *percent* / *probability*, the span of each bar corresponds to the percentage / fraction of occurrences with respect to the total number of sample points (here, the sum of all bin HEIGHTS equals 100% / 1). If *density*, the span of each bar corresponds to the number of occurrences in a bin divided by the size of the bin interval (here, the sum of all bin AREAS equals the total number of sample points). If *probability density*, the area of each bar corresponds to the probability that an event will fall into the corresponding bin (here, the sum of all bin AREAS equals 1).
        public static partial class Histnorm
        {
            public static Box<IHistogram2dProperty> none() => Interop.mkHistogram2dAttr("histnorm", "");
            public static Box<IHistogram2dProperty> density() => Interop.mkHistogram2dAttr("histnorm", "density");
            public static Box<IHistogram2dProperty> percent() => Interop.mkHistogram2dAttr("histnorm", "percent");
            public static Box<IHistogram2dProperty> probabilityDensity() => Interop.mkHistogram2dAttr("histnorm", "probability density");
            public static Box<IHistogram2dProperty> probability() => Interop.mkHistogram2dAttr("histnorm", "probability");
        }

        /// Specifies the binning function used for this histogram trace. If *count*, the histogram values are computed by counting the number of values lying inside each bin. If *sum*, *avg*, *min*, *max*, the histogram values are computed using the sum, the average, the minimum or the maximum of the values lying inside each bin respectively.
        public static partial class Histfunc
        {
            public static Box<IHistogram2dProperty> avg() => Interop.mkHistogram2dAttr("histfunc", "avg");
            public static Box<IHistogram2dProperty> count() => Interop.mkHistogram2dAttr("histfunc", "count");
            public static Box<IHistogram2dProperty> max() => Interop.mkHistogram2dAttr("histfunc", "max");
            public static Box<IHistogram2dProperty> min() => Interop.mkHistogram2dAttr("histfunc", "min");
            public static Box<IHistogram2dProperty> sum() => Interop.mkHistogram2dAttr("histfunc", "sum");
        }

        /// Picks a smoothing algorithm use to smooth `z` data.
        public static partial class Zsmooth
        {
            public static Box<IHistogram2dProperty> best() => Interop.mkHistogram2dAttr("zsmooth", "best");
            public static Box<IHistogram2dProperty> fast() => Interop.mkHistogram2dAttr("zsmooth", "fast");
            public static Box<IHistogram2dProperty> _false() => Interop.mkHistogram2dAttr("zsmooth", false);
        }

        /// Sets the calendar system to use with `x` date data.
        public static partial class Xcalendar
        {
            public static Box<IHistogram2dProperty> chinese() => Interop.mkHistogram2dAttr("xcalendar", "chinese");
            public static Box<IHistogram2dProperty> coptic() => Interop.mkHistogram2dAttr("xcalendar", "coptic");
            public static Box<IHistogram2dProperty> discworld() => Interop.mkHistogram2dAttr("xcalendar", "discworld");
            public static Box<IHistogram2dProperty> ethiopian() => Interop.mkHistogram2dAttr("xcalendar", "ethiopian");
            public static Box<IHistogram2dProperty> gregorian() => Interop.mkHistogram2dAttr("xcalendar", "gregorian");
            public static Box<IHistogram2dProperty> hebrew() => Interop.mkHistogram2dAttr("xcalendar", "hebrew");
            public static Box<IHistogram2dProperty> islamic() => Interop.mkHistogram2dAttr("xcalendar", "islamic");
            public static Box<IHistogram2dProperty> jalali() => Interop.mkHistogram2dAttr("xcalendar", "jalali");
            public static Box<IHistogram2dProperty> julian() => Interop.mkHistogram2dAttr("xcalendar", "julian");
            public static Box<IHistogram2dProperty> mayan() => Interop.mkHistogram2dAttr("xcalendar", "mayan");
            public static Box<IHistogram2dProperty> nanakshahi() => Interop.mkHistogram2dAttr("xcalendar", "nanakshahi");
            public static Box<IHistogram2dProperty> nepali() => Interop.mkHistogram2dAttr("xcalendar", "nepali");
            public static Box<IHistogram2dProperty> persian() => Interop.mkHistogram2dAttr("xcalendar", "persian");
            public static Box<IHistogram2dProperty> taiwan() => Interop.mkHistogram2dAttr("xcalendar", "taiwan");
            public static Box<IHistogram2dProperty> thai() => Interop.mkHistogram2dAttr("xcalendar", "thai");
            public static Box<IHistogram2dProperty> ummalqura() => Interop.mkHistogram2dAttr("xcalendar", "ummalqura");
        }

        /// Sets the calendar system to use with `y` date data.
        public static partial class Ycalendar
        {
            public static Box<IHistogram2dProperty> chinese() => Interop.mkHistogram2dAttr("ycalendar", "chinese");
            public static Box<IHistogram2dProperty> coptic() => Interop.mkHistogram2dAttr("ycalendar", "coptic");
            public static Box<IHistogram2dProperty> discworld() => Interop.mkHistogram2dAttr("ycalendar", "discworld");
            public static Box<IHistogram2dProperty> ethiopian() => Interop.mkHistogram2dAttr("ycalendar", "ethiopian");
            public static Box<IHistogram2dProperty> gregorian() => Interop.mkHistogram2dAttr("ycalendar", "gregorian");
            public static Box<IHistogram2dProperty> hebrew() => Interop.mkHistogram2dAttr("ycalendar", "hebrew");
            public static Box<IHistogram2dProperty> islamic() => Interop.mkHistogram2dAttr("ycalendar", "islamic");
            public static Box<IHistogram2dProperty> jalali() => Interop.mkHistogram2dAttr("ycalendar", "jalali");
            public static Box<IHistogram2dProperty> julian() => Interop.mkHistogram2dAttr("ycalendar", "julian");
            public static Box<IHistogram2dProperty> mayan() => Interop.mkHistogram2dAttr("ycalendar", "mayan");
            public static Box<IHistogram2dProperty> nanakshahi() => Interop.mkHistogram2dAttr("ycalendar", "nanakshahi");
            public static Box<IHistogram2dProperty> nepali() => Interop.mkHistogram2dAttr("ycalendar", "nepali");
            public static Box<IHistogram2dProperty> persian() => Interop.mkHistogram2dAttr("ycalendar", "persian");
            public static Box<IHistogram2dProperty> taiwan() => Interop.mkHistogram2dAttr("ycalendar", "taiwan");
            public static Box<IHistogram2dProperty> thai() => Interop.mkHistogram2dAttr("ycalendar", "thai");
            public static Box<IHistogram2dProperty> ummalqura() => Interop.mkHistogram2dAttr("ycalendar", "ummalqura");
        }
    }
}