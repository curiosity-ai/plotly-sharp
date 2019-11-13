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

    public static partial class Pointcloud
    {
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IPointcloudProperty> showlegend(bool val) => Interop.mkPointcloudAttr("showlegend", val);
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IPointcloudProperty> legendgroup(string val) => Interop.mkPointcloudAttr("legendgroup", val);
        /// Sets the opacity of the trace.
        public static Box<IPointcloudProperty> opacity(int val) => Interop.mkPointcloudAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<IPointcloudProperty> opacity(float val) => Interop.mkPointcloudAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IPointcloudProperty> name(string val) => Interop.mkPointcloudAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IPointcloudProperty> uid(string val) => Interop.mkPointcloudAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPointcloudProperty> ids(bool val) => Interop.mkPointcloudAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPointcloudProperty> ids(params bool[] values) => Interop.mkPointcloudAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPointcloudProperty> ids(System.DateTime val) => Interop.mkPointcloudAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPointcloudProperty> ids(params System.DateTime[] values) => Interop.mkPointcloudAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPointcloudProperty> ids(float val) => Interop.mkPointcloudAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPointcloudProperty> ids(params float[] values) => Interop.mkPointcloudAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPointcloudProperty> ids(int val) => Interop.mkPointcloudAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPointcloudProperty> ids(params int[] values) => Interop.mkPointcloudAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPointcloudProperty> ids(string val) => Interop.mkPointcloudAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPointcloudProperty> ids(params string[] values) => Interop.mkPointcloudAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPointcloudProperty> ids(IEnumerable<bool[]> values) => Interop.mkPointcloudAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPointcloudProperty> ids(List<bool[]> values) => Interop.mkPointcloudAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPointcloudProperty> ids(params bool[][] values) => Interop.mkPointcloudAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPointcloudProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkPointcloudAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPointcloudProperty> ids(List<string[]> values) => Interop.mkPointcloudAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPointcloudProperty> ids(params string[][] values) => Interop.mkPointcloudAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPointcloudProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkPointcloudAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPointcloudProperty> ids(List<int[]> values) => Interop.mkPointcloudAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPointcloudProperty> ids(params int[][] values) => Interop.mkPointcloudAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPointcloudProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkPointcloudAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPointcloudProperty> ids(List<float[]> values) => Interop.mkPointcloudAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPointcloudProperty> ids(params float[][] values) => Interop.mkPointcloudAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPointcloudProperty> ids(Literals.PlotData[] values) => Interop.mkPointcloudAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPointcloudProperty> ids(IEnumerable<bool?> values) => Interop.mkPointcloudAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPointcloudProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkPointcloudAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPointcloudProperty> ids(IEnumerable<int?> values) => Interop.mkPointcloudAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IPointcloudProperty> ids(IEnumerable<float?> values) => Interop.mkPointcloudAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPointcloudProperty> customdata(bool val) => Interop.mkPointcloudAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPointcloudProperty> customdata(params bool[] values) => Interop.mkPointcloudAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPointcloudProperty> customdata(System.DateTime val) => Interop.mkPointcloudAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPointcloudProperty> customdata(params System.DateTime[] values) => Interop.mkPointcloudAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPointcloudProperty> customdata(float val) => Interop.mkPointcloudAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPointcloudProperty> customdata(params float[] values) => Interop.mkPointcloudAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPointcloudProperty> customdata(int val) => Interop.mkPointcloudAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPointcloudProperty> customdata(params int[] values) => Interop.mkPointcloudAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPointcloudProperty> customdata(string val) => Interop.mkPointcloudAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPointcloudProperty> customdata(params string[] values) => Interop.mkPointcloudAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPointcloudProperty> customdata(IEnumerable<bool[]> values) => Interop.mkPointcloudAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPointcloudProperty> customdata(List<bool[]> values) => Interop.mkPointcloudAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPointcloudProperty> customdata(params bool[][] values) => Interop.mkPointcloudAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPointcloudProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkPointcloudAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPointcloudProperty> customdata(List<string[]> values) => Interop.mkPointcloudAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPointcloudProperty> customdata(params string[][] values) => Interop.mkPointcloudAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPointcloudProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkPointcloudAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPointcloudProperty> customdata(List<int[]> values) => Interop.mkPointcloudAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPointcloudProperty> customdata(params int[][] values) => Interop.mkPointcloudAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPointcloudProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkPointcloudAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPointcloudProperty> customdata(List<float[]> values) => Interop.mkPointcloudAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPointcloudProperty> customdata(params float[][] values) => Interop.mkPointcloudAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPointcloudProperty> customdata(Literals.PlotData[] values) => Interop.mkPointcloudAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPointcloudProperty> customdata(IEnumerable<bool?> values) => Interop.mkPointcloudAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPointcloudProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkPointcloudAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPointcloudProperty> customdata(IEnumerable<int?> values) => Interop.mkPointcloudAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IPointcloudProperty> customdata(IEnumerable<float?> values) => Interop.mkPointcloudAttr("customdata", values.ToArray());
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IPointcloudProperty> hoverinfo(params Box<IPointcloudProperty>[] properties) => Interop.mkPointcloudAttr("hoverinfo", Script.Write<object>("{0}.join('+')", properties));
        public static Box<IPointcloudProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkPointcloudAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IPointcloudProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkPointcloudAttr("stream", Bindings.flattenProperties(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IPointcloudProperty> uirevision(bool val) => Interop.mkPointcloudAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IPointcloudProperty> uirevision(params bool[] values) => Interop.mkPointcloudAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IPointcloudProperty> uirevision(System.DateTime val) => Interop.mkPointcloudAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IPointcloudProperty> uirevision(params System.DateTime[] values) => Interop.mkPointcloudAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IPointcloudProperty> uirevision(int val) => Interop.mkPointcloudAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IPointcloudProperty> uirevision(params int[] values) => Interop.mkPointcloudAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IPointcloudProperty> uirevision(float val) => Interop.mkPointcloudAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IPointcloudProperty> uirevision(params float[] values) => Interop.mkPointcloudAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IPointcloudProperty> uirevision(string val) => Interop.mkPointcloudAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IPointcloudProperty> uirevision(params string[] values) => Interop.mkPointcloudAttr("uirevision", values);
        /// Sets the x coordinates.
        public static Box<IPointcloudProperty> x(bool val) => Interop.mkPointcloudAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IPointcloudProperty> x(IEnumerable<bool> values) => Interop.mkPointcloudAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IPointcloudProperty> x(System.DateTime val) => Interop.mkPointcloudAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IPointcloudProperty> x(IEnumerable<System.DateTime> values) => Interop.mkPointcloudAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IPointcloudProperty> x(float val) => Interop.mkPointcloudAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IPointcloudProperty> x(IEnumerable<float> values) => Interop.mkPointcloudAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IPointcloudProperty> x(int val) => Interop.mkPointcloudAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IPointcloudProperty> x(IEnumerable<int> values) => Interop.mkPointcloudAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IPointcloudProperty> x(string val) => Interop.mkPointcloudAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IPointcloudProperty> x(IEnumerable<string> values) => Interop.mkPointcloudAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IPointcloudProperty> x(IEnumerable<bool[]> values) => Interop.mkPointcloudAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IPointcloudProperty> x(List<bool[]> values) => Interop.mkPointcloudAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IPointcloudProperty> x(params bool[][] values) => Interop.mkPointcloudAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IPointcloudProperty> x(IEnumerable<IEnumerable<string>> values) => Interop.mkPointcloudAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IPointcloudProperty> x(List<string[]> values) => Interop.mkPointcloudAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IPointcloudProperty> x(params string[][] values) => Interop.mkPointcloudAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IPointcloudProperty> x(IEnumerable<IEnumerable<int>> values) => Interop.mkPointcloudAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IPointcloudProperty> x(List<int[]> values) => Interop.mkPointcloudAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IPointcloudProperty> x(params int[][] values) => Interop.mkPointcloudAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IPointcloudProperty> x(IEnumerable<IEnumerable<float>> values) => Interop.mkPointcloudAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IPointcloudProperty> x(List<float[]> values) => Interop.mkPointcloudAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IPointcloudProperty> x(params float[][] values) => Interop.mkPointcloudAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IPointcloudProperty> x(Literals.PlotData[] values) => Interop.mkPointcloudAttr("x", values);
        /// Sets the x coordinates.
        public static Box<IPointcloudProperty> x(IEnumerable<bool?> values) => Interop.mkPointcloudAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IPointcloudProperty> x(IEnumerable<System.DateTime?> values) => Interop.mkPointcloudAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IPointcloudProperty> x(IEnumerable<int?> values) => Interop.mkPointcloudAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IPointcloudProperty> x(IEnumerable<float?> values) => Interop.mkPointcloudAttr("x", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IPointcloudProperty> y(bool val) => Interop.mkPointcloudAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IPointcloudProperty> y(IEnumerable<bool> values) => Interop.mkPointcloudAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IPointcloudProperty> y(System.DateTime val) => Interop.mkPointcloudAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IPointcloudProperty> y(IEnumerable<System.DateTime> values) => Interop.mkPointcloudAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IPointcloudProperty> y(float val) => Interop.mkPointcloudAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IPointcloudProperty> y(IEnumerable<float> values) => Interop.mkPointcloudAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IPointcloudProperty> y(int val) => Interop.mkPointcloudAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IPointcloudProperty> y(IEnumerable<int> values) => Interop.mkPointcloudAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IPointcloudProperty> y(string val) => Interop.mkPointcloudAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IPointcloudProperty> y(IEnumerable<string> values) => Interop.mkPointcloudAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IPointcloudProperty> y(IEnumerable<bool[]> values) => Interop.mkPointcloudAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IPointcloudProperty> y(List<bool[]> values) => Interop.mkPointcloudAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IPointcloudProperty> y(params bool[][] values) => Interop.mkPointcloudAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IPointcloudProperty> y(IEnumerable<IEnumerable<string>> values) => Interop.mkPointcloudAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IPointcloudProperty> y(List<string[]> values) => Interop.mkPointcloudAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IPointcloudProperty> y(params string[][] values) => Interop.mkPointcloudAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IPointcloudProperty> y(IEnumerable<IEnumerable<int>> values) => Interop.mkPointcloudAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IPointcloudProperty> y(List<int[]> values) => Interop.mkPointcloudAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IPointcloudProperty> y(params int[][] values) => Interop.mkPointcloudAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IPointcloudProperty> y(IEnumerable<IEnumerable<float>> values) => Interop.mkPointcloudAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IPointcloudProperty> y(List<float[]> values) => Interop.mkPointcloudAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IPointcloudProperty> y(params float[][] values) => Interop.mkPointcloudAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IPointcloudProperty> y(Literals.PlotData[] values) => Interop.mkPointcloudAttr("y", values);
        /// Sets the y coordinates.
        public static Box<IPointcloudProperty> y(IEnumerable<bool?> values) => Interop.mkPointcloudAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IPointcloudProperty> y(IEnumerable<System.DateTime?> values) => Interop.mkPointcloudAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IPointcloudProperty> y(IEnumerable<int?> values) => Interop.mkPointcloudAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IPointcloudProperty> y(IEnumerable<float?> values) => Interop.mkPointcloudAttr("y", values.ToArray());
        /// Faster alternative to specifying `x` and `y` separately. If supplied, it must be a typed `Float32Array` array that represents points such that `xy[i * 2] = x[i]` and `xy[i * 2 + 1] = y[i]`
        public static Box<IPointcloudProperty> xy(params int[] values) => Interop.mkPointcloudAttr("xy", values);
        /// Faster alternative to specifying `x` and `y` separately. If supplied, it must be a typed `Float32Array` array that represents points such that `xy[i * 2] = x[i]` and `xy[i * 2 + 1] = y[i]`
        public static Box<IPointcloudProperty> xy(float[] values) => Interop.mkPointcloudAttr("xy", values);
        /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
        public static Box<IPointcloudProperty> indices(bool val) => Interop.mkPointcloudAttr("indices", new[]{val});
        /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
        public static Box<IPointcloudProperty> indices(params bool[] values) => Interop.mkPointcloudAttr("indices", values);
        /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
        public static Box<IPointcloudProperty> indices(System.DateTime val) => Interop.mkPointcloudAttr("indices", new[]{val});
        /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
        public static Box<IPointcloudProperty> indices(params System.DateTime[] values) => Interop.mkPointcloudAttr("indices", values);
        /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
        public static Box<IPointcloudProperty> indices(float val) => Interop.mkPointcloudAttr("indices", new[]{val});
        /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
        public static Box<IPointcloudProperty> indices(params float[] values) => Interop.mkPointcloudAttr("indices", values);
        /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
        public static Box<IPointcloudProperty> indices(int val) => Interop.mkPointcloudAttr("indices", new[]{val});
        /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
        public static Box<IPointcloudProperty> indices(params int[] values) => Interop.mkPointcloudAttr("indices", values);
        /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
        public static Box<IPointcloudProperty> indices(string val) => Interop.mkPointcloudAttr("indices", new[]{val});
        /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
        public static Box<IPointcloudProperty> indices(params string[] values) => Interop.mkPointcloudAttr("indices", values);
        /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
        public static Box<IPointcloudProperty> indices(IEnumerable<bool[]> values) => Interop.mkPointcloudAttr("indices", Bindings.flatten2DArrayIf1D(values));
        /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
        public static Box<IPointcloudProperty> indices(List<bool[]> values) => Interop.mkPointcloudAttr("indices", Bindings.flatten2DArrayIf1D(values));
        /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
        public static Box<IPointcloudProperty> indices(params bool[][] values) => Interop.mkPointcloudAttr("indices", Bindings.flatten2DArrayIf1D(values));
        /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
        public static Box<IPointcloudProperty> indices(IEnumerable<IEnumerable<string>> values) => Interop.mkPointcloudAttr("indices", Bindings.flatten2DArrayIf1D(values));
        /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
        public static Box<IPointcloudProperty> indices(List<string[]> values) => Interop.mkPointcloudAttr("indices", Bindings.flatten2DArrayIf1D(values));
        /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
        public static Box<IPointcloudProperty> indices(params string[][] values) => Interop.mkPointcloudAttr("indices", Bindings.flatten2DArrayIf1D(values));
        /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
        public static Box<IPointcloudProperty> indices(IEnumerable<IEnumerable<int>> values) => Interop.mkPointcloudAttr("indices", Bindings.flatten2DArrayIf1D(values));
        /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
        public static Box<IPointcloudProperty> indices(List<int[]> values) => Interop.mkPointcloudAttr("indices", Bindings.flatten2DArrayIf1D(values));
        /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
        public static Box<IPointcloudProperty> indices(params int[][] values) => Interop.mkPointcloudAttr("indices", Bindings.flatten2DArrayIf1D(values));
        /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
        public static Box<IPointcloudProperty> indices(IEnumerable<IEnumerable<float>> values) => Interop.mkPointcloudAttr("indices", Bindings.flatten2DArrayIf1D(values));
        /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
        public static Box<IPointcloudProperty> indices(List<float[]> values) => Interop.mkPointcloudAttr("indices", Bindings.flatten2DArrayIf1D(values));
        /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
        public static Box<IPointcloudProperty> indices(params float[][] values) => Interop.mkPointcloudAttr("indices", Bindings.flatten2DArrayIf1D(values));
        /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
        public static Box<IPointcloudProperty> indices(Literals.PlotData[] values) => Interop.mkPointcloudAttr("indices", values);
        /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
        public static Box<IPointcloudProperty> indices(IEnumerable<bool?> values) => Interop.mkPointcloudAttr("indices", values.ToArray());
        /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
        public static Box<IPointcloudProperty> indices(IEnumerable<System.DateTime?> values) => Interop.mkPointcloudAttr("indices", values.ToArray());
        /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
        public static Box<IPointcloudProperty> indices(IEnumerable<int?> values) => Interop.mkPointcloudAttr("indices", values.ToArray());
        /// A sequential value, 0..n, supply it to avoid creating this array inside plotting. If specified, it must be a typed `Int32Array` array. Its length must be equal to or greater than the number of points. For the best performance and memory use, create one large `indices` typed array that is guaranteed to be at least as long as the largest number of points during use, and reuse it on each `Plotly.restyle()` call.
        public static Box<IPointcloudProperty> indices(IEnumerable<float?> values) => Interop.mkPointcloudAttr("indices", values.ToArray());
        /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
        public static Box<IPointcloudProperty> xbounds(bool val) => Interop.mkPointcloudAttr("xbounds", new[]{val});
        /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
        public static Box<IPointcloudProperty> xbounds(params bool[] values) => Interop.mkPointcloudAttr("xbounds", values);
        /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
        public static Box<IPointcloudProperty> xbounds(System.DateTime val) => Interop.mkPointcloudAttr("xbounds", new[]{val});
        /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
        public static Box<IPointcloudProperty> xbounds(params System.DateTime[] values) => Interop.mkPointcloudAttr("xbounds", values);
        /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
        public static Box<IPointcloudProperty> xbounds(float val) => Interop.mkPointcloudAttr("xbounds", new[]{val});
        /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
        public static Box<IPointcloudProperty> xbounds(params float[] values) => Interop.mkPointcloudAttr("xbounds", values);
        /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
        public static Box<IPointcloudProperty> xbounds(int val) => Interop.mkPointcloudAttr("xbounds", new[]{val});
        /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
        public static Box<IPointcloudProperty> xbounds(params int[] values) => Interop.mkPointcloudAttr("xbounds", values);
        /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
        public static Box<IPointcloudProperty> xbounds(string val) => Interop.mkPointcloudAttr("xbounds", new[]{val});
        /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
        public static Box<IPointcloudProperty> xbounds(params string[] values) => Interop.mkPointcloudAttr("xbounds", values);
        /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
        public static Box<IPointcloudProperty> xbounds(IEnumerable<bool[]> values) => Interop.mkPointcloudAttr("xbounds", Bindings.flatten2DArrayIf1D(values));
        /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
        public static Box<IPointcloudProperty> xbounds(List<bool[]> values) => Interop.mkPointcloudAttr("xbounds", Bindings.flatten2DArrayIf1D(values));
        /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
        public static Box<IPointcloudProperty> xbounds(params bool[][] values) => Interop.mkPointcloudAttr("xbounds", Bindings.flatten2DArrayIf1D(values));
        /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
        public static Box<IPointcloudProperty> xbounds(IEnumerable<IEnumerable<string>> values) => Interop.mkPointcloudAttr("xbounds", Bindings.flatten2DArrayIf1D(values));
        /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
        public static Box<IPointcloudProperty> xbounds(List<string[]> values) => Interop.mkPointcloudAttr("xbounds", Bindings.flatten2DArrayIf1D(values));
        /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
        public static Box<IPointcloudProperty> xbounds(params string[][] values) => Interop.mkPointcloudAttr("xbounds", Bindings.flatten2DArrayIf1D(values));
        /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
        public static Box<IPointcloudProperty> xbounds(IEnumerable<IEnumerable<int>> values) => Interop.mkPointcloudAttr("xbounds", Bindings.flatten2DArrayIf1D(values));
        /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
        public static Box<IPointcloudProperty> xbounds(List<int[]> values) => Interop.mkPointcloudAttr("xbounds", Bindings.flatten2DArrayIf1D(values));
        /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
        public static Box<IPointcloudProperty> xbounds(params int[][] values) => Interop.mkPointcloudAttr("xbounds", Bindings.flatten2DArrayIf1D(values));
        /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
        public static Box<IPointcloudProperty> xbounds(IEnumerable<IEnumerable<float>> values) => Interop.mkPointcloudAttr("xbounds", Bindings.flatten2DArrayIf1D(values));
        /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
        public static Box<IPointcloudProperty> xbounds(List<float[]> values) => Interop.mkPointcloudAttr("xbounds", Bindings.flatten2DArrayIf1D(values));
        /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
        public static Box<IPointcloudProperty> xbounds(params float[][] values) => Interop.mkPointcloudAttr("xbounds", Bindings.flatten2DArrayIf1D(values));
        /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
        public static Box<IPointcloudProperty> xbounds(Literals.PlotData[] values) => Interop.mkPointcloudAttr("xbounds", values);
        /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
        public static Box<IPointcloudProperty> xbounds(IEnumerable<bool?> values) => Interop.mkPointcloudAttr("xbounds", values.ToArray());
        /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
        public static Box<IPointcloudProperty> xbounds(IEnumerable<System.DateTime?> values) => Interop.mkPointcloudAttr("xbounds", values.ToArray());
        /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
        public static Box<IPointcloudProperty> xbounds(IEnumerable<int?> values) => Interop.mkPointcloudAttr("xbounds", values.ToArray());
        /// Specify `xbounds` in the shape of `[xMin, xMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `ybounds` for the performance benefits.
        public static Box<IPointcloudProperty> xbounds(IEnumerable<float?> values) => Interop.mkPointcloudAttr("xbounds", values.ToArray());
        /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
        public static Box<IPointcloudProperty> ybounds(bool val) => Interop.mkPointcloudAttr("ybounds", new[]{val});
        /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
        public static Box<IPointcloudProperty> ybounds(params bool[] values) => Interop.mkPointcloudAttr("ybounds", values);
        /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
        public static Box<IPointcloudProperty> ybounds(System.DateTime val) => Interop.mkPointcloudAttr("ybounds", new[]{val});
        /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
        public static Box<IPointcloudProperty> ybounds(params System.DateTime[] values) => Interop.mkPointcloudAttr("ybounds", values);
        /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
        public static Box<IPointcloudProperty> ybounds(float val) => Interop.mkPointcloudAttr("ybounds", new[]{val});
        /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
        public static Box<IPointcloudProperty> ybounds(params float[] values) => Interop.mkPointcloudAttr("ybounds", values);
        /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
        public static Box<IPointcloudProperty> ybounds(int val) => Interop.mkPointcloudAttr("ybounds", new[]{val});
        /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
        public static Box<IPointcloudProperty> ybounds(params int[] values) => Interop.mkPointcloudAttr("ybounds", values);
        /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
        public static Box<IPointcloudProperty> ybounds(string val) => Interop.mkPointcloudAttr("ybounds", new[]{val});
        /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
        public static Box<IPointcloudProperty> ybounds(params string[] values) => Interop.mkPointcloudAttr("ybounds", values);
        /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
        public static Box<IPointcloudProperty> ybounds(IEnumerable<bool[]> values) => Interop.mkPointcloudAttr("ybounds", Bindings.flatten2DArrayIf1D(values));
        /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
        public static Box<IPointcloudProperty> ybounds(List<bool[]> values) => Interop.mkPointcloudAttr("ybounds", Bindings.flatten2DArrayIf1D(values));
        /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
        public static Box<IPointcloudProperty> ybounds(params bool[][] values) => Interop.mkPointcloudAttr("ybounds", Bindings.flatten2DArrayIf1D(values));
        /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
        public static Box<IPointcloudProperty> ybounds(IEnumerable<IEnumerable<string>> values) => Interop.mkPointcloudAttr("ybounds", Bindings.flatten2DArrayIf1D(values));
        /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
        public static Box<IPointcloudProperty> ybounds(List<string[]> values) => Interop.mkPointcloudAttr("ybounds", Bindings.flatten2DArrayIf1D(values));
        /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
        public static Box<IPointcloudProperty> ybounds(params string[][] values) => Interop.mkPointcloudAttr("ybounds", Bindings.flatten2DArrayIf1D(values));
        /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
        public static Box<IPointcloudProperty> ybounds(IEnumerable<IEnumerable<int>> values) => Interop.mkPointcloudAttr("ybounds", Bindings.flatten2DArrayIf1D(values));
        /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
        public static Box<IPointcloudProperty> ybounds(List<int[]> values) => Interop.mkPointcloudAttr("ybounds", Bindings.flatten2DArrayIf1D(values));
        /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
        public static Box<IPointcloudProperty> ybounds(params int[][] values) => Interop.mkPointcloudAttr("ybounds", Bindings.flatten2DArrayIf1D(values));
        /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
        public static Box<IPointcloudProperty> ybounds(IEnumerable<IEnumerable<float>> values) => Interop.mkPointcloudAttr("ybounds", Bindings.flatten2DArrayIf1D(values));
        /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
        public static Box<IPointcloudProperty> ybounds(List<float[]> values) => Interop.mkPointcloudAttr("ybounds", Bindings.flatten2DArrayIf1D(values));
        /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
        public static Box<IPointcloudProperty> ybounds(params float[][] values) => Interop.mkPointcloudAttr("ybounds", Bindings.flatten2DArrayIf1D(values));
        /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
        public static Box<IPointcloudProperty> ybounds(Literals.PlotData[] values) => Interop.mkPointcloudAttr("ybounds", values);
        /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
        public static Box<IPointcloudProperty> ybounds(IEnumerable<bool?> values) => Interop.mkPointcloudAttr("ybounds", values.ToArray());
        /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
        public static Box<IPointcloudProperty> ybounds(IEnumerable<System.DateTime?> values) => Interop.mkPointcloudAttr("ybounds", values.ToArray());
        /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
        public static Box<IPointcloudProperty> ybounds(IEnumerable<int?> values) => Interop.mkPointcloudAttr("ybounds", values.ToArray());
        /// Specify `ybounds` in the shape of `[yMin, yMax] to avoid looping through the `xy` typed array. Use it in conjunction with `xy` and `xbounds` for the performance benefits.
        public static Box<IPointcloudProperty> ybounds(IEnumerable<float?> values) => Interop.mkPointcloudAttr("ybounds", values.ToArray());
        /// Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPointcloudProperty> text(string val) => Interop.mkPointcloudAttr("text", val);
        /// Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IPointcloudProperty> text(IEnumerable<string> values) => Interop.mkPointcloudAttr("text", values.ToArray());
        public static Box<IPointcloudProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkPointcloudAttr("marker", Bindings.flattenProperties(properties));
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IPointcloudProperty> xaxis(int anchorId) => Interop.mkPointcloudAttr("xaxis", anchorId > 1 ? $"x{anchorId}" : "");
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IPointcloudProperty> xaxis(string val) => Interop.mkPointcloudAttr("xaxis", val);
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IPointcloudProperty> yaxis(int anchorId) => Interop.mkPointcloudAttr("yaxis", anchorId > 1 ? $"y{anchorId}" : "");
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IPointcloudProperty> yaxis(string val) => Interop.mkPointcloudAttr("yaxis", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IPointcloudProperty> idssrc(string val) => Interop.mkPointcloudAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IPointcloudProperty> customdatasrc(string val) => Interop.mkPointcloudAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IPointcloudProperty> metasrc(string val) => Interop.mkPointcloudAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IPointcloudProperty> hoverinfosrc(string val) => Interop.mkPointcloudAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  x .
        public static Box<IPointcloudProperty> xsrc(string val) => Interop.mkPointcloudAttr("xsrc", val);
        /// Sets the source reference on plot.ly for  y .
        public static Box<IPointcloudProperty> ysrc(string val) => Interop.mkPointcloudAttr("ysrc", val);
        /// Sets the source reference on plot.ly for  xy .
        public static Box<IPointcloudProperty> xysrc(string val) => Interop.mkPointcloudAttr("xysrc", val);
        /// Sets the source reference on plot.ly for  indices .
        public static Box<IPointcloudProperty> indicessrc(string val) => Interop.mkPointcloudAttr("indicessrc", val);
        /// Sets the source reference on plot.ly for  xbounds .
        public static Box<IPointcloudProperty> xboundssrc(string val) => Interop.mkPointcloudAttr("xboundssrc", val);
        /// Sets the source reference on plot.ly for  ybounds .
        public static Box<IPointcloudProperty> yboundssrc(string val) => Interop.mkPointcloudAttr("yboundssrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IPointcloudProperty> textsrc(string val) => Interop.mkPointcloudAttr("textsrc", val);
    }

    public static partial class Pointcloud
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IPointcloudProperty> legendonly() => Interop.mkPointcloudAttr("visible", "legendonly");
            public static Box<IPointcloudProperty> _false() => Interop.mkPointcloudAttr("visible", false);
            public static Box<IPointcloudProperty> _true() => Interop.mkPointcloudAttr("visible", true);
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IPointcloudProperty> all() => Interop.mkPointcloudAttr("hoverinfo", "all");
            public static Box<IPointcloudProperty> none() => Interop.mkPointcloudAttr("hoverinfo", "none");
            public static Box<IPointcloudProperty> skip() => Interop.mkPointcloudAttr("hoverinfo", "skip");
            public static Box<IPointcloudProperty> name() => Interop.mkPointcloudAttr("hoverinfo", "name");
            public static Box<IPointcloudProperty> text() => Interop.mkPointcloudAttr("hoverinfo", "text");
            public static Box<IPointcloudProperty> x() => Interop.mkPointcloudAttr("hoverinfo", "x");
            public static Box<IPointcloudProperty> y() => Interop.mkPointcloudAttr("hoverinfo", "y");
            public static Box<IPointcloudProperty> z() => Interop.mkPointcloudAttr("hoverinfo", "z");
        }
    }
}