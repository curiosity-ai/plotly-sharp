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

    public static partial class Scatter3d
    {
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IScatter3dProperty> showlegend(bool val) => Interop.mkScatter3dAttr("showlegend", val);
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IScatter3dProperty> legendgroup(string val) => Interop.mkScatter3dAttr("legendgroup", val);
        /// Sets the opacity of the trace.
        public static Box<IScatter3dProperty> opacity(int val) => Interop.mkScatter3dAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<IScatter3dProperty> opacity(float val) => Interop.mkScatter3dAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IScatter3dProperty> name(string val) => Interop.mkScatter3dAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IScatter3dProperty> uid(string val) => Interop.mkScatter3dAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatter3dProperty> ids(bool val) => Interop.mkScatter3dAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatter3dProperty> ids(params bool[] values) => Interop.mkScatter3dAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatter3dProperty> ids(System.DateTime val) => Interop.mkScatter3dAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatter3dProperty> ids(params System.DateTime[] values) => Interop.mkScatter3dAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatter3dProperty> ids(float val) => Interop.mkScatter3dAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatter3dProperty> ids(params float[] values) => Interop.mkScatter3dAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatter3dProperty> ids(int val) => Interop.mkScatter3dAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatter3dProperty> ids(params int[] values) => Interop.mkScatter3dAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatter3dProperty> ids(string val) => Interop.mkScatter3dAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatter3dProperty> ids(params string[] values) => Interop.mkScatter3dAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatter3dProperty> ids(IEnumerable<bool[]> values) => Interop.mkScatter3dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatter3dProperty> ids(List<bool[]> values) => Interop.mkScatter3dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatter3dProperty> ids(params bool[][] values) => Interop.mkScatter3dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatter3dProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkScatter3dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatter3dProperty> ids(List<string[]> values) => Interop.mkScatter3dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatter3dProperty> ids(params string[][] values) => Interop.mkScatter3dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatter3dProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkScatter3dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatter3dProperty> ids(List<int[]> values) => Interop.mkScatter3dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatter3dProperty> ids(params int[][] values) => Interop.mkScatter3dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatter3dProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkScatter3dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatter3dProperty> ids(List<float[]> values) => Interop.mkScatter3dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatter3dProperty> ids(params float[][] values) => Interop.mkScatter3dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatter3dProperty> ids(Literals.PlotData[] values) => Interop.mkScatter3dAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatter3dProperty> ids(IEnumerable<bool?> values) => Interop.mkScatter3dAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatter3dProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkScatter3dAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatter3dProperty> ids(IEnumerable<int?> values) => Interop.mkScatter3dAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatter3dProperty> ids(IEnumerable<float?> values) => Interop.mkScatter3dAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatter3dProperty> customdata(bool val) => Interop.mkScatter3dAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatter3dProperty> customdata(params bool[] values) => Interop.mkScatter3dAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatter3dProperty> customdata(System.DateTime val) => Interop.mkScatter3dAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatter3dProperty> customdata(params System.DateTime[] values) => Interop.mkScatter3dAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatter3dProperty> customdata(float val) => Interop.mkScatter3dAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatter3dProperty> customdata(params float[] values) => Interop.mkScatter3dAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatter3dProperty> customdata(int val) => Interop.mkScatter3dAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatter3dProperty> customdata(params int[] values) => Interop.mkScatter3dAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatter3dProperty> customdata(string val) => Interop.mkScatter3dAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatter3dProperty> customdata(params string[] values) => Interop.mkScatter3dAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatter3dProperty> customdata(IEnumerable<bool[]> values) => Interop.mkScatter3dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatter3dProperty> customdata(List<bool[]> values) => Interop.mkScatter3dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatter3dProperty> customdata(params bool[][] values) => Interop.mkScatter3dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatter3dProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkScatter3dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatter3dProperty> customdata(List<string[]> values) => Interop.mkScatter3dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatter3dProperty> customdata(params string[][] values) => Interop.mkScatter3dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatter3dProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkScatter3dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatter3dProperty> customdata(List<int[]> values) => Interop.mkScatter3dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatter3dProperty> customdata(params int[][] values) => Interop.mkScatter3dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatter3dProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkScatter3dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatter3dProperty> customdata(List<float[]> values) => Interop.mkScatter3dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatter3dProperty> customdata(params float[][] values) => Interop.mkScatter3dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatter3dProperty> customdata(Literals.PlotData[] values) => Interop.mkScatter3dAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatter3dProperty> customdata(IEnumerable<bool?> values) => Interop.mkScatter3dAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatter3dProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkScatter3dAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatter3dProperty> customdata(IEnumerable<int?> values) => Interop.mkScatter3dAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatter3dProperty> customdata(IEnumerable<float?> values) => Interop.mkScatter3dAttr("customdata", values.ToArray());
        public static Box<IScatter3dProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkScatter3dAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IScatter3dProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkScatter3dAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IScatter3dProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkScatter3dAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatter3dProperty> uirevision(bool val) => Interop.mkScatter3dAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatter3dProperty> uirevision(params bool[] values) => Interop.mkScatter3dAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatter3dProperty> uirevision(System.DateTime val) => Interop.mkScatter3dAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatter3dProperty> uirevision(params System.DateTime[] values) => Interop.mkScatter3dAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatter3dProperty> uirevision(int val) => Interop.mkScatter3dAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatter3dProperty> uirevision(params int[] values) => Interop.mkScatter3dAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatter3dProperty> uirevision(float val) => Interop.mkScatter3dAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatter3dProperty> uirevision(params float[] values) => Interop.mkScatter3dAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatter3dProperty> uirevision(string val) => Interop.mkScatter3dAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatter3dProperty> uirevision(params string[] values) => Interop.mkScatter3dAttr("uirevision", values);
        /// Sets the x coordinates.
        public static Box<IScatter3dProperty> x(bool val) => Interop.mkScatter3dAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IScatter3dProperty> x(IEnumerable<bool> values) => Interop.mkScatter3dAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IScatter3dProperty> x(System.DateTime val) => Interop.mkScatter3dAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IScatter3dProperty> x(IEnumerable<System.DateTime> values) => Interop.mkScatter3dAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IScatter3dProperty> x(float val) => Interop.mkScatter3dAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IScatter3dProperty> x(IEnumerable<float> values) => Interop.mkScatter3dAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IScatter3dProperty> x(int val) => Interop.mkScatter3dAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IScatter3dProperty> x(IEnumerable<int> values) => Interop.mkScatter3dAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IScatter3dProperty> x(string val) => Interop.mkScatter3dAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IScatter3dProperty> x(IEnumerable<string> values) => Interop.mkScatter3dAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IScatter3dProperty> x(IEnumerable<bool[]> values) => Interop.mkScatter3dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatter3dProperty> x(List<bool[]> values) => Interop.mkScatter3dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatter3dProperty> x(params bool[][] values) => Interop.mkScatter3dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatter3dProperty> x(IEnumerable<IEnumerable<string>> values) => Interop.mkScatter3dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatter3dProperty> x(List<string[]> values) => Interop.mkScatter3dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatter3dProperty> x(params string[][] values) => Interop.mkScatter3dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatter3dProperty> x(IEnumerable<IEnumerable<int>> values) => Interop.mkScatter3dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatter3dProperty> x(List<int[]> values) => Interop.mkScatter3dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatter3dProperty> x(params int[][] values) => Interop.mkScatter3dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatter3dProperty> x(IEnumerable<IEnumerable<float>> values) => Interop.mkScatter3dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatter3dProperty> x(List<float[]> values) => Interop.mkScatter3dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatter3dProperty> x(params float[][] values) => Interop.mkScatter3dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatter3dProperty> x(Literals.PlotData[] values) => Interop.mkScatter3dAttr("x", values);
        /// Sets the x coordinates.
        public static Box<IScatter3dProperty> x(IEnumerable<bool?> values) => Interop.mkScatter3dAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IScatter3dProperty> x(IEnumerable<System.DateTime?> values) => Interop.mkScatter3dAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IScatter3dProperty> x(IEnumerable<int?> values) => Interop.mkScatter3dAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IScatter3dProperty> x(IEnumerable<float?> values) => Interop.mkScatter3dAttr("x", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IScatter3dProperty> y(bool val) => Interop.mkScatter3dAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IScatter3dProperty> y(IEnumerable<bool> values) => Interop.mkScatter3dAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IScatter3dProperty> y(System.DateTime val) => Interop.mkScatter3dAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IScatter3dProperty> y(IEnumerable<System.DateTime> values) => Interop.mkScatter3dAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IScatter3dProperty> y(float val) => Interop.mkScatter3dAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IScatter3dProperty> y(IEnumerable<float> values) => Interop.mkScatter3dAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IScatter3dProperty> y(int val) => Interop.mkScatter3dAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IScatter3dProperty> y(IEnumerable<int> values) => Interop.mkScatter3dAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IScatter3dProperty> y(string val) => Interop.mkScatter3dAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IScatter3dProperty> y(IEnumerable<string> values) => Interop.mkScatter3dAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IScatter3dProperty> y(IEnumerable<bool[]> values) => Interop.mkScatter3dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatter3dProperty> y(List<bool[]> values) => Interop.mkScatter3dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatter3dProperty> y(params bool[][] values) => Interop.mkScatter3dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatter3dProperty> y(IEnumerable<IEnumerable<string>> values) => Interop.mkScatter3dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatter3dProperty> y(List<string[]> values) => Interop.mkScatter3dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatter3dProperty> y(params string[][] values) => Interop.mkScatter3dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatter3dProperty> y(IEnumerable<IEnumerable<int>> values) => Interop.mkScatter3dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatter3dProperty> y(List<int[]> values) => Interop.mkScatter3dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatter3dProperty> y(params int[][] values) => Interop.mkScatter3dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatter3dProperty> y(IEnumerable<IEnumerable<float>> values) => Interop.mkScatter3dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatter3dProperty> y(List<float[]> values) => Interop.mkScatter3dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatter3dProperty> y(params float[][] values) => Interop.mkScatter3dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatter3dProperty> y(Literals.PlotData[] values) => Interop.mkScatter3dAttr("y", values);
        /// Sets the y coordinates.
        public static Box<IScatter3dProperty> y(IEnumerable<bool?> values) => Interop.mkScatter3dAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IScatter3dProperty> y(IEnumerable<System.DateTime?> values) => Interop.mkScatter3dAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IScatter3dProperty> y(IEnumerable<int?> values) => Interop.mkScatter3dAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IScatter3dProperty> y(IEnumerable<float?> values) => Interop.mkScatter3dAttr("y", values.ToArray());
        /// Sets the z coordinates.
        public static Box<IScatter3dProperty> z(bool val) => Interop.mkScatter3dAttr("z", new[]{val});
        /// Sets the z coordinates.
        public static Box<IScatter3dProperty> z(IEnumerable<bool> values) => Interop.mkScatter3dAttr("z", values.ToArray());
        /// Sets the z coordinates.
        public static Box<IScatter3dProperty> z(System.DateTime val) => Interop.mkScatter3dAttr("z", new[]{val});
        /// Sets the z coordinates.
        public static Box<IScatter3dProperty> z(IEnumerable<System.DateTime> values) => Interop.mkScatter3dAttr("z", values.ToArray());
        /// Sets the z coordinates.
        public static Box<IScatter3dProperty> z(float val) => Interop.mkScatter3dAttr("z", new[]{val});
        /// Sets the z coordinates.
        public static Box<IScatter3dProperty> z(IEnumerable<float> values) => Interop.mkScatter3dAttr("z", values.ToArray());
        /// Sets the z coordinates.
        public static Box<IScatter3dProperty> z(int val) => Interop.mkScatter3dAttr("z", new[]{val});
        /// Sets the z coordinates.
        public static Box<IScatter3dProperty> z(IEnumerable<int> values) => Interop.mkScatter3dAttr("z", values.ToArray());
        /// Sets the z coordinates.
        public static Box<IScatter3dProperty> z(string val) => Interop.mkScatter3dAttr("z", new[]{val});
        /// Sets the z coordinates.
        public static Box<IScatter3dProperty> z(IEnumerable<string> values) => Interop.mkScatter3dAttr("z", values.ToArray());
        /// Sets the z coordinates.
        public static Box<IScatter3dProperty> z(IEnumerable<bool[]> values) => Interop.mkScatter3dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates.
        public static Box<IScatter3dProperty> z(List<bool[]> values) => Interop.mkScatter3dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates.
        public static Box<IScatter3dProperty> z(params bool[][] values) => Interop.mkScatter3dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates.
        public static Box<IScatter3dProperty> z(IEnumerable<IEnumerable<string>> values) => Interop.mkScatter3dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates.
        public static Box<IScatter3dProperty> z(List<string[]> values) => Interop.mkScatter3dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates.
        public static Box<IScatter3dProperty> z(params string[][] values) => Interop.mkScatter3dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates.
        public static Box<IScatter3dProperty> z(IEnumerable<IEnumerable<int>> values) => Interop.mkScatter3dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates.
        public static Box<IScatter3dProperty> z(List<int[]> values) => Interop.mkScatter3dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates.
        public static Box<IScatter3dProperty> z(params int[][] values) => Interop.mkScatter3dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates.
        public static Box<IScatter3dProperty> z(IEnumerable<IEnumerable<float>> values) => Interop.mkScatter3dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates.
        public static Box<IScatter3dProperty> z(List<float[]> values) => Interop.mkScatter3dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates.
        public static Box<IScatter3dProperty> z(params float[][] values) => Interop.mkScatter3dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates.
        public static Box<IScatter3dProperty> z(Literals.PlotData[] values) => Interop.mkScatter3dAttr("z", values);
        /// Sets the z coordinates.
        public static Box<IScatter3dProperty> z(IEnumerable<bool?> values) => Interop.mkScatter3dAttr("z", values.ToArray());
        /// Sets the z coordinates.
        public static Box<IScatter3dProperty> z(IEnumerable<System.DateTime?> values) => Interop.mkScatter3dAttr("z", values.ToArray());
        /// Sets the z coordinates.
        public static Box<IScatter3dProperty> z(IEnumerable<int?> values) => Interop.mkScatter3dAttr("z", values.ToArray());
        /// Sets the z coordinates.
        public static Box<IScatter3dProperty> z(IEnumerable<float?> values) => Interop.mkScatter3dAttr("z", values.ToArray());
        /// Sets text elements associated with each (x,y,z) triplet. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y,z) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IScatter3dProperty> text(string val) => Interop.mkScatter3dAttr("text", val);
        /// Sets text elements associated with each (x,y,z) triplet. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y,z) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IScatter3dProperty> text(IEnumerable<string> values) => Interop.mkScatter3dAttr("text", values.ToArray());
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.
        public static Box<IScatter3dProperty> texttemplate(string val) => Interop.mkScatter3dAttr("texttemplate", val);
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.
        public static Box<IScatter3dProperty> texttemplate(IEnumerable<string> values) => Interop.mkScatter3dAttr("texttemplate", values.ToArray());
        /// Sets text elements associated with each (x,y,z) triplet. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y,z) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IScatter3dProperty> hovertext(string val) => Interop.mkScatter3dAttr("hovertext", val);
        /// Sets text elements associated with each (x,y,z) triplet. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y,z) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IScatter3dProperty> hovertext(IEnumerable<string> values) => Interop.mkScatter3dAttr("hovertext", values.ToArray());
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IScatter3dProperty> hovertemplate(string val) => Interop.mkScatter3dAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IScatter3dProperty> hovertemplate(IEnumerable<string> values) => Interop.mkScatter3dAttr("hovertemplate", values.ToArray());
        /// Determines the drawing mode for this scatter trace. If the provided `mode` includes *text* then the `text` elements appear at the coordinates. Otherwise, the `text` elements appear on hover. If there are less than 20 points and the trace is not stacked then the default is *lines+markers*. Otherwise, *lines*.
        public static Box<IScatter3dProperty> mode(params Box<IScatter3dProperty>[] properties) => Interop.mkScatter3dAttr("mode", Bindings.joinEnumProperties(properties));
        /// Sets the surface fill color.
        public static Box<IScatter3dProperty> surfacecolor(string val) => Interop.mkScatter3dAttr("surfacecolor", val);
        public static Box<IScatter3dProperty> projection(params Box<IProjectionProperty>[] properties) => Interop.mkScatter3dAttr("projection", Bindings.flattenProperties(properties));
        /// Determines whether or not gaps (i.e. {nan} or missing values) in the provided data arrays are connected.
        public static Box<IScatter3dProperty> connectgaps(bool val) => Interop.mkScatter3dAttr("connectgaps", val);
        public static Box<IScatter3dProperty> line(params Box<ILineProperty>[] properties) => Interop.mkScatter3dAttr("line", Bindings.flattenProperties(properties));
        public static Box<IScatter3dProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkScatter3dAttr("marker", Bindings.flattenProperties(properties));
        /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
        public static Box<IScatter3dProperty> textposition(IEnumerable<Box<IScatter3dProperty>> properties) => Interop.mkScatter3dAttr("textposition", Bindings.flattenProperties(properties));
        public static Box<IScatter3dProperty> textfont(params Box<ITextfontProperty>[] properties) => Interop.mkScatter3dAttr("textfont", Bindings.flattenProperties(properties));
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IScatter3dProperty> hoverinfo(params Box<IScatter3dProperty>[] properties) => Interop.mkScatter3dAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        public static Box<IScatter3dProperty> errorX(params Box<IErrorXProperty>[] properties) => Interop.mkScatter3dAttr("error_x", Bindings.flattenProperties(properties));
        public static Box<IScatter3dProperty> errorY(params Box<IErrorYProperty>[] properties) => Interop.mkScatter3dAttr("error_y", Bindings.flattenProperties(properties));
        public static Box<IScatter3dProperty> errorZ(params Box<IErrorZProperty>[] properties) => Interop.mkScatter3dAttr("error_z", Bindings.flattenProperties(properties));
        /// Sets a reference between this trace's 3D coordinate system and a 3D scene. If *scene* (the default value), the (x,y,z) coordinates refer to `layout.scene`. If *scene2*, the (x,y,z) coordinates refer to `layout.scene2`, and so on.
        public static Box<IScatter3dProperty> scene(int anchorId) => Interop.mkScatter3dAttr("scene", anchorId > 1 ? $"scene{anchorId}" : "");
        /// Sets a reference between this trace's 3D coordinate system and a 3D scene. If *scene* (the default value), the (x,y,z) coordinates refer to `layout.scene`. If *scene2*, the (x,y,z) coordinates refer to `layout.scene2`, and so on.
        public static Box<IScatter3dProperty> scene(string val) => Interop.mkScatter3dAttr("scene", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IScatter3dProperty> idssrc(string val) => Interop.mkScatter3dAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IScatter3dProperty> customdatasrc(string val) => Interop.mkScatter3dAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IScatter3dProperty> metasrc(string val) => Interop.mkScatter3dAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  x .
        public static Box<IScatter3dProperty> xsrc(string val) => Interop.mkScatter3dAttr("xsrc", val);
        /// Sets the source reference on plot.ly for  y .
        public static Box<IScatter3dProperty> ysrc(string val) => Interop.mkScatter3dAttr("ysrc", val);
        /// Sets the source reference on plot.ly for  z .
        public static Box<IScatter3dProperty> zsrc(string val) => Interop.mkScatter3dAttr("zsrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IScatter3dProperty> textsrc(string val) => Interop.mkScatter3dAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  texttemplate .
        public static Box<IScatter3dProperty> texttemplatesrc(string val) => Interop.mkScatter3dAttr("texttemplatesrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IScatter3dProperty> hovertextsrc(string val) => Interop.mkScatter3dAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IScatter3dProperty> hovertemplatesrc(string val) => Interop.mkScatter3dAttr("hovertemplatesrc", val);
        /// Sets the source reference on plot.ly for  textposition .
        public static Box<IScatter3dProperty> textpositionsrc(string val) => Interop.mkScatter3dAttr("textpositionsrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IScatter3dProperty> hoverinfosrc(string val) => Interop.mkScatter3dAttr("hoverinfosrc", val);
    }

    public static partial class Scatter3d
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IScatter3dProperty> legendonly() => Interop.mkScatter3dAttr("visible", "legendonly");
            public static Box<IScatter3dProperty> _false() => Interop.mkScatter3dAttr("visible", false);
            public static Box<IScatter3dProperty> _true() => Interop.mkScatter3dAttr("visible", true);
        }

        /// Determines the drawing mode for this scatter trace. If the provided `mode` includes *text* then the `text` elements appear at the coordinates. Otherwise, the `text` elements appear on hover. If there are less than 20 points and the trace is not stacked then the default is *lines+markers*. Otherwise, *lines*.
        public static partial class Mode
        {
            public static Box<IScatter3dProperty> none() => Interop.mkScatter3dAttr("mode", "none");
            public static Box<IScatter3dProperty> lines() => Interop.mkScatter3dAttr("mode", "lines");
            public static Box<IScatter3dProperty> markers() => Interop.mkScatter3dAttr("mode", "markers");
            public static Box<IScatter3dProperty> text() => Interop.mkScatter3dAttr("mode", "text");
        }

        /// If *-1*, the scatter points are not fill with a surface If *0*, *1*, *2*, the scatter points are filled with a Delaunay surface about the x, y, z respectively.
        public static partial class Surfaceaxis
        {
            public static Box<IScatter3dProperty> neg1() => Interop.mkScatter3dAttr("surfaceaxis", "-1");
            public static Box<IScatter3dProperty> _0() => Interop.mkScatter3dAttr("surfaceaxis", "0");
            public static Box<IScatter3dProperty> _1() => Interop.mkScatter3dAttr("surfaceaxis", "1");
            public static Box<IScatter3dProperty> _2() => Interop.mkScatter3dAttr("surfaceaxis", "2");
        }

        /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
        public static partial class Textposition
        {
            public static Box<IScatter3dProperty> bottomCenter() => Interop.mkScatter3dAttr("textposition", "bottom center");
            public static Box<IScatter3dProperty> bottomLeft() => Interop.mkScatter3dAttr("textposition", "bottom left");
            public static Box<IScatter3dProperty> bottomRight() => Interop.mkScatter3dAttr("textposition", "bottom right");
            public static Box<IScatter3dProperty> middleCenter() => Interop.mkScatter3dAttr("textposition", "middle center");
            public static Box<IScatter3dProperty> middleLeft() => Interop.mkScatter3dAttr("textposition", "middle left");
            public static Box<IScatter3dProperty> middleRight() => Interop.mkScatter3dAttr("textposition", "middle right");
            public static Box<IScatter3dProperty> topCenter() => Interop.mkScatter3dAttr("textposition", "top center");
            public static Box<IScatter3dProperty> topLeft() => Interop.mkScatter3dAttr("textposition", "top left");
            public static Box<IScatter3dProperty> topRight() => Interop.mkScatter3dAttr("textposition", "top right");
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IScatter3dProperty> all() => Interop.mkScatter3dAttr("hoverinfo", "all");
            public static Box<IScatter3dProperty> none() => Interop.mkScatter3dAttr("hoverinfo", "none");
            public static Box<IScatter3dProperty> skip() => Interop.mkScatter3dAttr("hoverinfo", "skip");
            public static Box<IScatter3dProperty> name() => Interop.mkScatter3dAttr("hoverinfo", "name");
            public static Box<IScatter3dProperty> text() => Interop.mkScatter3dAttr("hoverinfo", "text");
            public static Box<IScatter3dProperty> x() => Interop.mkScatter3dAttr("hoverinfo", "x");
            public static Box<IScatter3dProperty> y() => Interop.mkScatter3dAttr("hoverinfo", "y");
            public static Box<IScatter3dProperty> z() => Interop.mkScatter3dAttr("hoverinfo", "z");
        }

        /// Sets the calendar system to use with `x` date data.
        public static partial class Xcalendar
        {
            public static Box<IScatter3dProperty> chinese() => Interop.mkScatter3dAttr("xcalendar", "chinese");
            public static Box<IScatter3dProperty> coptic() => Interop.mkScatter3dAttr("xcalendar", "coptic");
            public static Box<IScatter3dProperty> discworld() => Interop.mkScatter3dAttr("xcalendar", "discworld");
            public static Box<IScatter3dProperty> ethiopian() => Interop.mkScatter3dAttr("xcalendar", "ethiopian");
            public static Box<IScatter3dProperty> gregorian() => Interop.mkScatter3dAttr("xcalendar", "gregorian");
            public static Box<IScatter3dProperty> hebrew() => Interop.mkScatter3dAttr("xcalendar", "hebrew");
            public static Box<IScatter3dProperty> islamic() => Interop.mkScatter3dAttr("xcalendar", "islamic");
            public static Box<IScatter3dProperty> jalali() => Interop.mkScatter3dAttr("xcalendar", "jalali");
            public static Box<IScatter3dProperty> julian() => Interop.mkScatter3dAttr("xcalendar", "julian");
            public static Box<IScatter3dProperty> mayan() => Interop.mkScatter3dAttr("xcalendar", "mayan");
            public static Box<IScatter3dProperty> nanakshahi() => Interop.mkScatter3dAttr("xcalendar", "nanakshahi");
            public static Box<IScatter3dProperty> nepali() => Interop.mkScatter3dAttr("xcalendar", "nepali");
            public static Box<IScatter3dProperty> persian() => Interop.mkScatter3dAttr("xcalendar", "persian");
            public static Box<IScatter3dProperty> taiwan() => Interop.mkScatter3dAttr("xcalendar", "taiwan");
            public static Box<IScatter3dProperty> thai() => Interop.mkScatter3dAttr("xcalendar", "thai");
            public static Box<IScatter3dProperty> ummalqura() => Interop.mkScatter3dAttr("xcalendar", "ummalqura");
        }

        /// Sets the calendar system to use with `y` date data.
        public static partial class Ycalendar
        {
            public static Box<IScatter3dProperty> chinese() => Interop.mkScatter3dAttr("ycalendar", "chinese");
            public static Box<IScatter3dProperty> coptic() => Interop.mkScatter3dAttr("ycalendar", "coptic");
            public static Box<IScatter3dProperty> discworld() => Interop.mkScatter3dAttr("ycalendar", "discworld");
            public static Box<IScatter3dProperty> ethiopian() => Interop.mkScatter3dAttr("ycalendar", "ethiopian");
            public static Box<IScatter3dProperty> gregorian() => Interop.mkScatter3dAttr("ycalendar", "gregorian");
            public static Box<IScatter3dProperty> hebrew() => Interop.mkScatter3dAttr("ycalendar", "hebrew");
            public static Box<IScatter3dProperty> islamic() => Interop.mkScatter3dAttr("ycalendar", "islamic");
            public static Box<IScatter3dProperty> jalali() => Interop.mkScatter3dAttr("ycalendar", "jalali");
            public static Box<IScatter3dProperty> julian() => Interop.mkScatter3dAttr("ycalendar", "julian");
            public static Box<IScatter3dProperty> mayan() => Interop.mkScatter3dAttr("ycalendar", "mayan");
            public static Box<IScatter3dProperty> nanakshahi() => Interop.mkScatter3dAttr("ycalendar", "nanakshahi");
            public static Box<IScatter3dProperty> nepali() => Interop.mkScatter3dAttr("ycalendar", "nepali");
            public static Box<IScatter3dProperty> persian() => Interop.mkScatter3dAttr("ycalendar", "persian");
            public static Box<IScatter3dProperty> taiwan() => Interop.mkScatter3dAttr("ycalendar", "taiwan");
            public static Box<IScatter3dProperty> thai() => Interop.mkScatter3dAttr("ycalendar", "thai");
            public static Box<IScatter3dProperty> ummalqura() => Interop.mkScatter3dAttr("ycalendar", "ummalqura");
        }

        /// Sets the calendar system to use with `z` date data.
        public static partial class Zcalendar
        {
            public static Box<IScatter3dProperty> chinese() => Interop.mkScatter3dAttr("zcalendar", "chinese");
            public static Box<IScatter3dProperty> coptic() => Interop.mkScatter3dAttr("zcalendar", "coptic");
            public static Box<IScatter3dProperty> discworld() => Interop.mkScatter3dAttr("zcalendar", "discworld");
            public static Box<IScatter3dProperty> ethiopian() => Interop.mkScatter3dAttr("zcalendar", "ethiopian");
            public static Box<IScatter3dProperty> gregorian() => Interop.mkScatter3dAttr("zcalendar", "gregorian");
            public static Box<IScatter3dProperty> hebrew() => Interop.mkScatter3dAttr("zcalendar", "hebrew");
            public static Box<IScatter3dProperty> islamic() => Interop.mkScatter3dAttr("zcalendar", "islamic");
            public static Box<IScatter3dProperty> jalali() => Interop.mkScatter3dAttr("zcalendar", "jalali");
            public static Box<IScatter3dProperty> julian() => Interop.mkScatter3dAttr("zcalendar", "julian");
            public static Box<IScatter3dProperty> mayan() => Interop.mkScatter3dAttr("zcalendar", "mayan");
            public static Box<IScatter3dProperty> nanakshahi() => Interop.mkScatter3dAttr("zcalendar", "nanakshahi");
            public static Box<IScatter3dProperty> nepali() => Interop.mkScatter3dAttr("zcalendar", "nepali");
            public static Box<IScatter3dProperty> persian() => Interop.mkScatter3dAttr("zcalendar", "persian");
            public static Box<IScatter3dProperty> taiwan() => Interop.mkScatter3dAttr("zcalendar", "taiwan");
            public static Box<IScatter3dProperty> thai() => Interop.mkScatter3dAttr("zcalendar", "thai");
            public static Box<IScatter3dProperty> ummalqura() => Interop.mkScatter3dAttr("zcalendar", "ummalqura");
        }
    }
}