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

    public static partial class Surface
    {
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<ISurfaceProperty> legendgroup(string val) => Interop.mkSurfaceAttr("legendgroup", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<ISurfaceProperty> name(string val) => Interop.mkSurfaceAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<ISurfaceProperty> uid(string val) => Interop.mkSurfaceAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISurfaceProperty> ids(bool val) => Interop.mkSurfaceAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISurfaceProperty> ids(params bool[] values) => Interop.mkSurfaceAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISurfaceProperty> ids(System.DateTime val) => Interop.mkSurfaceAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISurfaceProperty> ids(params System.DateTime[] values) => Interop.mkSurfaceAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISurfaceProperty> ids(float val) => Interop.mkSurfaceAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISurfaceProperty> ids(params float[] values) => Interop.mkSurfaceAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISurfaceProperty> ids(int val) => Interop.mkSurfaceAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISurfaceProperty> ids(params int[] values) => Interop.mkSurfaceAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISurfaceProperty> ids(string val) => Interop.mkSurfaceAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISurfaceProperty> ids(params string[] values) => Interop.mkSurfaceAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISurfaceProperty> ids(IEnumerable<bool[]> values) => Interop.mkSurfaceAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISurfaceProperty> ids(List<bool[]> values) => Interop.mkSurfaceAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISurfaceProperty> ids(params bool[][] values) => Interop.mkSurfaceAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISurfaceProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkSurfaceAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISurfaceProperty> ids(List<string[]> values) => Interop.mkSurfaceAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISurfaceProperty> ids(params string[][] values) => Interop.mkSurfaceAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISurfaceProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkSurfaceAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISurfaceProperty> ids(List<int[]> values) => Interop.mkSurfaceAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISurfaceProperty> ids(params int[][] values) => Interop.mkSurfaceAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISurfaceProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkSurfaceAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISurfaceProperty> ids(List<float[]> values) => Interop.mkSurfaceAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISurfaceProperty> ids(params float[][] values) => Interop.mkSurfaceAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISurfaceProperty> ids(Literals.PlotData[] values) => Interop.mkSurfaceAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISurfaceProperty> ids(IEnumerable<bool?> values) => Interop.mkSurfaceAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISurfaceProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkSurfaceAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISurfaceProperty> ids(IEnumerable<int?> values) => Interop.mkSurfaceAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISurfaceProperty> ids(IEnumerable<float?> values) => Interop.mkSurfaceAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISurfaceProperty> customdata(bool val) => Interop.mkSurfaceAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISurfaceProperty> customdata(params bool[] values) => Interop.mkSurfaceAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISurfaceProperty> customdata(System.DateTime val) => Interop.mkSurfaceAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISurfaceProperty> customdata(params System.DateTime[] values) => Interop.mkSurfaceAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISurfaceProperty> customdata(float val) => Interop.mkSurfaceAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISurfaceProperty> customdata(params float[] values) => Interop.mkSurfaceAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISurfaceProperty> customdata(int val) => Interop.mkSurfaceAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISurfaceProperty> customdata(params int[] values) => Interop.mkSurfaceAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISurfaceProperty> customdata(string val) => Interop.mkSurfaceAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISurfaceProperty> customdata(params string[] values) => Interop.mkSurfaceAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISurfaceProperty> customdata(IEnumerable<bool[]> values) => Interop.mkSurfaceAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISurfaceProperty> customdata(List<bool[]> values) => Interop.mkSurfaceAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISurfaceProperty> customdata(params bool[][] values) => Interop.mkSurfaceAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISurfaceProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkSurfaceAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISurfaceProperty> customdata(List<string[]> values) => Interop.mkSurfaceAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISurfaceProperty> customdata(params string[][] values) => Interop.mkSurfaceAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISurfaceProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkSurfaceAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISurfaceProperty> customdata(List<int[]> values) => Interop.mkSurfaceAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISurfaceProperty> customdata(params int[][] values) => Interop.mkSurfaceAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISurfaceProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkSurfaceAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISurfaceProperty> customdata(List<float[]> values) => Interop.mkSurfaceAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISurfaceProperty> customdata(params float[][] values) => Interop.mkSurfaceAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISurfaceProperty> customdata(Literals.PlotData[] values) => Interop.mkSurfaceAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISurfaceProperty> customdata(IEnumerable<bool?> values) => Interop.mkSurfaceAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISurfaceProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkSurfaceAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISurfaceProperty> customdata(IEnumerable<int?> values) => Interop.mkSurfaceAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISurfaceProperty> customdata(IEnumerable<float?> values) => Interop.mkSurfaceAttr("customdata", values.ToArray());
        public static Box<ISurfaceProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkSurfaceAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<ISurfaceProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkSurfaceAttr("stream", Bindings.flattenProperties(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISurfaceProperty> uirevision(bool val) => Interop.mkSurfaceAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISurfaceProperty> uirevision(params bool[] values) => Interop.mkSurfaceAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISurfaceProperty> uirevision(System.DateTime val) => Interop.mkSurfaceAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISurfaceProperty> uirevision(params System.DateTime[] values) => Interop.mkSurfaceAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISurfaceProperty> uirevision(int val) => Interop.mkSurfaceAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISurfaceProperty> uirevision(params int[] values) => Interop.mkSurfaceAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISurfaceProperty> uirevision(float val) => Interop.mkSurfaceAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISurfaceProperty> uirevision(params float[] values) => Interop.mkSurfaceAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISurfaceProperty> uirevision(string val) => Interop.mkSurfaceAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISurfaceProperty> uirevision(params string[] values) => Interop.mkSurfaceAttr("uirevision", values);
        /// Sets the z coordinates.
        public static Box<ISurfaceProperty> z(bool val) => Interop.mkSurfaceAttr("z", new[]{val});
        /// Sets the z coordinates.
        public static Box<ISurfaceProperty> z(IEnumerable<bool> values) => Interop.mkSurfaceAttr("z", values.ToArray());
        /// Sets the z coordinates.
        public static Box<ISurfaceProperty> z(System.DateTime val) => Interop.mkSurfaceAttr("z", new[]{val});
        /// Sets the z coordinates.
        public static Box<ISurfaceProperty> z(IEnumerable<System.DateTime> values) => Interop.mkSurfaceAttr("z", values.ToArray());
        /// Sets the z coordinates.
        public static Box<ISurfaceProperty> z(float val) => Interop.mkSurfaceAttr("z", new[]{val});
        /// Sets the z coordinates.
        public static Box<ISurfaceProperty> z(IEnumerable<float> values) => Interop.mkSurfaceAttr("z", values.ToArray());
        /// Sets the z coordinates.
        public static Box<ISurfaceProperty> z(int val) => Interop.mkSurfaceAttr("z", new[]{val});
        /// Sets the z coordinates.
        public static Box<ISurfaceProperty> z(IEnumerable<int> values) => Interop.mkSurfaceAttr("z", values.ToArray());
        /// Sets the z coordinates.
        public static Box<ISurfaceProperty> z(string val) => Interop.mkSurfaceAttr("z", new[]{val});
        /// Sets the z coordinates.
        public static Box<ISurfaceProperty> z(IEnumerable<string> values) => Interop.mkSurfaceAttr("z", values.ToArray());
        /// Sets the z coordinates.
        public static Box<ISurfaceProperty> z(IEnumerable<bool[]> values) => Interop.mkSurfaceAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates.
        public static Box<ISurfaceProperty> z(List<bool[]> values) => Interop.mkSurfaceAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates.
        public static Box<ISurfaceProperty> z(params bool[][] values) => Interop.mkSurfaceAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates.
        public static Box<ISurfaceProperty> z(IEnumerable<IEnumerable<string>> values) => Interop.mkSurfaceAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates.
        public static Box<ISurfaceProperty> z(List<string[]> values) => Interop.mkSurfaceAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates.
        public static Box<ISurfaceProperty> z(params string[][] values) => Interop.mkSurfaceAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates.
        public static Box<ISurfaceProperty> z(IEnumerable<IEnumerable<int>> values) => Interop.mkSurfaceAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates.
        public static Box<ISurfaceProperty> z(List<int[]> values) => Interop.mkSurfaceAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates.
        public static Box<ISurfaceProperty> z(params int[][] values) => Interop.mkSurfaceAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates.
        public static Box<ISurfaceProperty> z(IEnumerable<IEnumerable<float>> values) => Interop.mkSurfaceAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates.
        public static Box<ISurfaceProperty> z(List<float[]> values) => Interop.mkSurfaceAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates.
        public static Box<ISurfaceProperty> z(params float[][] values) => Interop.mkSurfaceAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates.
        public static Box<ISurfaceProperty> z(Literals.PlotData[] values) => Interop.mkSurfaceAttr("z", values);
        /// Sets the z coordinates.
        public static Box<ISurfaceProperty> z(IEnumerable<bool?> values) => Interop.mkSurfaceAttr("z", values.ToArray());
        /// Sets the z coordinates.
        public static Box<ISurfaceProperty> z(IEnumerable<System.DateTime?> values) => Interop.mkSurfaceAttr("z", values.ToArray());
        /// Sets the z coordinates.
        public static Box<ISurfaceProperty> z(IEnumerable<int?> values) => Interop.mkSurfaceAttr("z", values.ToArray());
        /// Sets the z coordinates.
        public static Box<ISurfaceProperty> z(IEnumerable<float?> values) => Interop.mkSurfaceAttr("z", values.ToArray());
        /// Sets the x coordinates.
        public static Box<ISurfaceProperty> x(bool val) => Interop.mkSurfaceAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<ISurfaceProperty> x(IEnumerable<bool> values) => Interop.mkSurfaceAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<ISurfaceProperty> x(System.DateTime val) => Interop.mkSurfaceAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<ISurfaceProperty> x(IEnumerable<System.DateTime> values) => Interop.mkSurfaceAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<ISurfaceProperty> x(float val) => Interop.mkSurfaceAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<ISurfaceProperty> x(IEnumerable<float> values) => Interop.mkSurfaceAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<ISurfaceProperty> x(int val) => Interop.mkSurfaceAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<ISurfaceProperty> x(IEnumerable<int> values) => Interop.mkSurfaceAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<ISurfaceProperty> x(string val) => Interop.mkSurfaceAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<ISurfaceProperty> x(IEnumerable<string> values) => Interop.mkSurfaceAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<ISurfaceProperty> x(IEnumerable<bool[]> values) => Interop.mkSurfaceAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<ISurfaceProperty> x(List<bool[]> values) => Interop.mkSurfaceAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<ISurfaceProperty> x(params bool[][] values) => Interop.mkSurfaceAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<ISurfaceProperty> x(IEnumerable<IEnumerable<string>> values) => Interop.mkSurfaceAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<ISurfaceProperty> x(List<string[]> values) => Interop.mkSurfaceAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<ISurfaceProperty> x(params string[][] values) => Interop.mkSurfaceAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<ISurfaceProperty> x(IEnumerable<IEnumerable<int>> values) => Interop.mkSurfaceAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<ISurfaceProperty> x(List<int[]> values) => Interop.mkSurfaceAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<ISurfaceProperty> x(params int[][] values) => Interop.mkSurfaceAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<ISurfaceProperty> x(IEnumerable<IEnumerable<float>> values) => Interop.mkSurfaceAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<ISurfaceProperty> x(List<float[]> values) => Interop.mkSurfaceAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<ISurfaceProperty> x(params float[][] values) => Interop.mkSurfaceAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<ISurfaceProperty> x(Literals.PlotData[] values) => Interop.mkSurfaceAttr("x", values);
        /// Sets the x coordinates.
        public static Box<ISurfaceProperty> x(IEnumerable<bool?> values) => Interop.mkSurfaceAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<ISurfaceProperty> x(IEnumerable<System.DateTime?> values) => Interop.mkSurfaceAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<ISurfaceProperty> x(IEnumerable<int?> values) => Interop.mkSurfaceAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<ISurfaceProperty> x(IEnumerable<float?> values) => Interop.mkSurfaceAttr("x", values.ToArray());
        /// Sets the y coordinates.
        public static Box<ISurfaceProperty> y(bool val) => Interop.mkSurfaceAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<ISurfaceProperty> y(IEnumerable<bool> values) => Interop.mkSurfaceAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<ISurfaceProperty> y(System.DateTime val) => Interop.mkSurfaceAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<ISurfaceProperty> y(IEnumerable<System.DateTime> values) => Interop.mkSurfaceAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<ISurfaceProperty> y(float val) => Interop.mkSurfaceAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<ISurfaceProperty> y(IEnumerable<float> values) => Interop.mkSurfaceAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<ISurfaceProperty> y(int val) => Interop.mkSurfaceAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<ISurfaceProperty> y(IEnumerable<int> values) => Interop.mkSurfaceAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<ISurfaceProperty> y(string val) => Interop.mkSurfaceAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<ISurfaceProperty> y(IEnumerable<string> values) => Interop.mkSurfaceAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<ISurfaceProperty> y(IEnumerable<bool[]> values) => Interop.mkSurfaceAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<ISurfaceProperty> y(List<bool[]> values) => Interop.mkSurfaceAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<ISurfaceProperty> y(params bool[][] values) => Interop.mkSurfaceAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<ISurfaceProperty> y(IEnumerable<IEnumerable<string>> values) => Interop.mkSurfaceAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<ISurfaceProperty> y(List<string[]> values) => Interop.mkSurfaceAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<ISurfaceProperty> y(params string[][] values) => Interop.mkSurfaceAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<ISurfaceProperty> y(IEnumerable<IEnumerable<int>> values) => Interop.mkSurfaceAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<ISurfaceProperty> y(List<int[]> values) => Interop.mkSurfaceAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<ISurfaceProperty> y(params int[][] values) => Interop.mkSurfaceAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<ISurfaceProperty> y(IEnumerable<IEnumerable<float>> values) => Interop.mkSurfaceAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<ISurfaceProperty> y(List<float[]> values) => Interop.mkSurfaceAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<ISurfaceProperty> y(params float[][] values) => Interop.mkSurfaceAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<ISurfaceProperty> y(Literals.PlotData[] values) => Interop.mkSurfaceAttr("y", values);
        /// Sets the y coordinates.
        public static Box<ISurfaceProperty> y(IEnumerable<bool?> values) => Interop.mkSurfaceAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<ISurfaceProperty> y(IEnumerable<System.DateTime?> values) => Interop.mkSurfaceAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<ISurfaceProperty> y(IEnumerable<int?> values) => Interop.mkSurfaceAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<ISurfaceProperty> y(IEnumerable<float?> values) => Interop.mkSurfaceAttr("y", values.ToArray());
        /// Sets the text elements associated with each z value. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISurfaceProperty> text(string val) => Interop.mkSurfaceAttr("text", val);
        /// Sets the text elements associated with each z value. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<ISurfaceProperty> text(IEnumerable<string> values) => Interop.mkSurfaceAttr("text", values.ToArray());
        /// Same as `text`.
        public static Box<ISurfaceProperty> hovertext(string val) => Interop.mkSurfaceAttr("hovertext", val);
        /// Same as `text`.
        public static Box<ISurfaceProperty> hovertext(IEnumerable<string> values) => Interop.mkSurfaceAttr("hovertext", values.ToArray());
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<ISurfaceProperty> hovertemplate(string val) => Interop.mkSurfaceAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<ISurfaceProperty> hovertemplate(IEnumerable<string> values) => Interop.mkSurfaceAttr("hovertemplate", values.ToArray());
        /// Determines whether or not gaps (i.e. {nan} or missing values) in the `z` data are filled in.
        public static Box<ISurfaceProperty> connectgaps(bool val) => Interop.mkSurfaceAttr("connectgaps", val);
        /// Sets the surface color values, used for setting a color scale independent of `z`.
        public static Box<ISurfaceProperty> surfacecolor(bool val) => Interop.mkSurfaceAttr("surfacecolor", new[]{val});
        /// Sets the surface color values, used for setting a color scale independent of `z`.
        public static Box<ISurfaceProperty> surfacecolor(params bool[] values) => Interop.mkSurfaceAttr("surfacecolor", values);
        /// Sets the surface color values, used for setting a color scale independent of `z`.
        public static Box<ISurfaceProperty> surfacecolor(System.DateTime val) => Interop.mkSurfaceAttr("surfacecolor", new[]{val});
        /// Sets the surface color values, used for setting a color scale independent of `z`.
        public static Box<ISurfaceProperty> surfacecolor(params System.DateTime[] values) => Interop.mkSurfaceAttr("surfacecolor", values);
        /// Sets the surface color values, used for setting a color scale independent of `z`.
        public static Box<ISurfaceProperty> surfacecolor(float val) => Interop.mkSurfaceAttr("surfacecolor", new[]{val});
        /// Sets the surface color values, used for setting a color scale independent of `z`.
        public static Box<ISurfaceProperty> surfacecolor(params float[] values) => Interop.mkSurfaceAttr("surfacecolor", values);
        /// Sets the surface color values, used for setting a color scale independent of `z`.
        public static Box<ISurfaceProperty> surfacecolor(int val) => Interop.mkSurfaceAttr("surfacecolor", new[]{val});
        /// Sets the surface color values, used for setting a color scale independent of `z`.
        public static Box<ISurfaceProperty> surfacecolor(params int[] values) => Interop.mkSurfaceAttr("surfacecolor", values);
        /// Sets the surface color values, used for setting a color scale independent of `z`.
        public static Box<ISurfaceProperty> surfacecolor(string val) => Interop.mkSurfaceAttr("surfacecolor", new[]{val});
        /// Sets the surface color values, used for setting a color scale independent of `z`.
        public static Box<ISurfaceProperty> surfacecolor(params string[] values) => Interop.mkSurfaceAttr("surfacecolor", values);
        /// Sets the surface color values, used for setting a color scale independent of `z`.
        public static Box<ISurfaceProperty> surfacecolor(IEnumerable<bool[]> values) => Interop.mkSurfaceAttr("surfacecolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the surface color values, used for setting a color scale independent of `z`.
        public static Box<ISurfaceProperty> surfacecolor(List<bool[]> values) => Interop.mkSurfaceAttr("surfacecolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the surface color values, used for setting a color scale independent of `z`.
        public static Box<ISurfaceProperty> surfacecolor(params bool[][] values) => Interop.mkSurfaceAttr("surfacecolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the surface color values, used for setting a color scale independent of `z`.
        public static Box<ISurfaceProperty> surfacecolor(IEnumerable<IEnumerable<string>> values) => Interop.mkSurfaceAttr("surfacecolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the surface color values, used for setting a color scale independent of `z`.
        public static Box<ISurfaceProperty> surfacecolor(List<string[]> values) => Interop.mkSurfaceAttr("surfacecolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the surface color values, used for setting a color scale independent of `z`.
        public static Box<ISurfaceProperty> surfacecolor(params string[][] values) => Interop.mkSurfaceAttr("surfacecolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the surface color values, used for setting a color scale independent of `z`.
        public static Box<ISurfaceProperty> surfacecolor(IEnumerable<IEnumerable<int>> values) => Interop.mkSurfaceAttr("surfacecolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the surface color values, used for setting a color scale independent of `z`.
        public static Box<ISurfaceProperty> surfacecolor(List<int[]> values) => Interop.mkSurfaceAttr("surfacecolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the surface color values, used for setting a color scale independent of `z`.
        public static Box<ISurfaceProperty> surfacecolor(params int[][] values) => Interop.mkSurfaceAttr("surfacecolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the surface color values, used for setting a color scale independent of `z`.
        public static Box<ISurfaceProperty> surfacecolor(IEnumerable<IEnumerable<float>> values) => Interop.mkSurfaceAttr("surfacecolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the surface color values, used for setting a color scale independent of `z`.
        public static Box<ISurfaceProperty> surfacecolor(List<float[]> values) => Interop.mkSurfaceAttr("surfacecolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the surface color values, used for setting a color scale independent of `z`.
        public static Box<ISurfaceProperty> surfacecolor(params float[][] values) => Interop.mkSurfaceAttr("surfacecolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the surface color values, used for setting a color scale independent of `z`.
        public static Box<ISurfaceProperty> surfacecolor(Literals.PlotData[] values) => Interop.mkSurfaceAttr("surfacecolor", values);
        /// Sets the surface color values, used for setting a color scale independent of `z`.
        public static Box<ISurfaceProperty> surfacecolor(IEnumerable<bool?> values) => Interop.mkSurfaceAttr("surfacecolor", values.ToArray());
        /// Sets the surface color values, used for setting a color scale independent of `z`.
        public static Box<ISurfaceProperty> surfacecolor(IEnumerable<System.DateTime?> values) => Interop.mkSurfaceAttr("surfacecolor", values.ToArray());
        /// Sets the surface color values, used for setting a color scale independent of `z`.
        public static Box<ISurfaceProperty> surfacecolor(IEnumerable<int?> values) => Interop.mkSurfaceAttr("surfacecolor", values.ToArray());
        /// Sets the surface color values, used for setting a color scale independent of `z`.
        public static Box<ISurfaceProperty> surfacecolor(IEnumerable<float?> values) => Interop.mkSurfaceAttr("surfacecolor", values.ToArray());
        /// Determines whether or not the color domain is computed with respect to the input data (here z or surfacecolor) or the bounds set in `cmin` and `cmax`  Defaults to `false` when `cmin` and `cmax` are set by the user.
        public static Box<ISurfaceProperty> cauto(bool val) => Interop.mkSurfaceAttr("cauto", val);
        /// Sets the lower bound of the color domain. Value should have the same units as z or surfacecolor and if set, `cmax` must be set as well.
        public static Box<ISurfaceProperty> cmin(int val) => Interop.mkSurfaceAttr("cmin", val);
        /// Sets the lower bound of the color domain. Value should have the same units as z or surfacecolor and if set, `cmax` must be set as well.
        public static Box<ISurfaceProperty> cmin(float val) => Interop.mkSurfaceAttr("cmin", val);
        /// Sets the upper bound of the color domain. Value should have the same units as z or surfacecolor and if set, `cmin` must be set as well.
        public static Box<ISurfaceProperty> cmax(int val) => Interop.mkSurfaceAttr("cmax", val);
        /// Sets the upper bound of the color domain. Value should have the same units as z or surfacecolor and if set, `cmin` must be set as well.
        public static Box<ISurfaceProperty> cmax(float val) => Interop.mkSurfaceAttr("cmax", val);
        /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as z or surfacecolor. Has no effect when `cauto` is `false`.
        public static Box<ISurfaceProperty> cmid(int val) => Interop.mkSurfaceAttr("cmid", val);
        /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as z or surfacecolor. Has no effect when `cauto` is `false`.
        public static Box<ISurfaceProperty> cmid(float val) => Interop.mkSurfaceAttr("cmid", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<ISurfaceProperty> colorscale(string val) => Interop.mkSurfaceAttr("colorscale", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<ISurfaceProperty> colorscale(List<string[]> values) => Interop.mkSurfaceAttr("colorscale", Bindings.flatten2DArrayIf1D(values));
        /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
        public static Box<ISurfaceProperty> autocolorscale(bool val) => Interop.mkSurfaceAttr("autocolorscale", val);
        /// Reverses the color mapping if true. If true, `cmin` will correspond to the last color in the array and `cmax` will correspond to the first color.
        public static Box<ISurfaceProperty> reversescale(bool val) => Interop.mkSurfaceAttr("reversescale", val);
        /// Determines whether or not a colorbar is displayed for this trace.
        public static Box<ISurfaceProperty> showscale(bool val) => Interop.mkSurfaceAttr("showscale", val);
        public static Box<ISurfaceProperty> colorbar(params Box<IColorbarProperty>[] properties) => Interop.mkSurfaceAttr("colorbar", Bindings.flattenProperties(properties));
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<ISurfaceProperty> coloraxis(int anchorId) => Interop.mkSurfaceAttr("coloraxis", anchorId > 1 ? $"coloraxis{anchorId}" : "");
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<ISurfaceProperty> coloraxis(string val) => Interop.mkSurfaceAttr("coloraxis", val);
        public static Box<ISurfaceProperty> contours(params Box<IContoursProperty>[] properties) => Interop.mkSurfaceAttr("contours", Bindings.flattenProperties(properties));
        /// Determines whether or not a surface is drawn. For example, set `hidesurface` to *false* `contours.x.show` to *true* and `contours.y.show` to *true* to draw a wire frame plot.
        public static Box<ISurfaceProperty> hidesurface(bool val) => Interop.mkSurfaceAttr("hidesurface", val);
        public static Box<ISurfaceProperty> lightposition(params Box<ILightpositionProperty>[] properties) => Interop.mkSurfaceAttr("lightposition", Bindings.flattenProperties(properties));
        public static Box<ISurfaceProperty> lighting(params Box<ILightingProperty>[] properties) => Interop.mkSurfaceAttr("lighting", Bindings.flattenProperties(properties));
        /// Sets the opacity of the surface. Please note that in the case of using high `opacity` values for example a value greater than or equal to 0.5 on two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent surfaces may not perfectly be sorted in depth by the webgl API. This behavior may be improved in the near future and is subject to change.
        public static Box<ISurfaceProperty> opacity(int val) => Interop.mkSurfaceAttr("opacity", val);
        /// Sets the opacity of the surface. Please note that in the case of using high `opacity` values for example a value greater than or equal to 0.5 on two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent surfaces may not perfectly be sorted in depth by the webgl API. This behavior may be improved in the near future and is subject to change.
        public static Box<ISurfaceProperty> opacity(float val) => Interop.mkSurfaceAttr("opacity", val);
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<ISurfaceProperty> hoverinfo(params Box<ISurfaceProperty>[] properties) => Interop.mkSurfaceAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<ISurfaceProperty> showlegend(bool val) => Interop.mkSurfaceAttr("showlegend", val);
        /// Sets a reference between this trace's 3D coordinate system and a 3D scene. If *scene* (the default value), the (x,y,z) coordinates refer to `layout.scene`. If *scene2*, the (x,y,z) coordinates refer to `layout.scene2`, and so on.
        public static Box<ISurfaceProperty> scene(int anchorId) => Interop.mkSurfaceAttr("scene", anchorId > 1 ? $"scene{anchorId}" : "");
        /// Sets a reference between this trace's 3D coordinate system and a 3D scene. If *scene* (the default value), the (x,y,z) coordinates refer to `layout.scene`. If *scene2*, the (x,y,z) coordinates refer to `layout.scene2`, and so on.
        public static Box<ISurfaceProperty> scene(string val) => Interop.mkSurfaceAttr("scene", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<ISurfaceProperty> idssrc(string val) => Interop.mkSurfaceAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<ISurfaceProperty> customdatasrc(string val) => Interop.mkSurfaceAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<ISurfaceProperty> metasrc(string val) => Interop.mkSurfaceAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  z .
        public static Box<ISurfaceProperty> zsrc(string val) => Interop.mkSurfaceAttr("zsrc", val);
        /// Sets the source reference on plot.ly for  x .
        public static Box<ISurfaceProperty> xsrc(string val) => Interop.mkSurfaceAttr("xsrc", val);
        /// Sets the source reference on plot.ly for  y .
        public static Box<ISurfaceProperty> ysrc(string val) => Interop.mkSurfaceAttr("ysrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<ISurfaceProperty> textsrc(string val) => Interop.mkSurfaceAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<ISurfaceProperty> hovertextsrc(string val) => Interop.mkSurfaceAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<ISurfaceProperty> hovertemplatesrc(string val) => Interop.mkSurfaceAttr("hovertemplatesrc", val);
        /// Sets the source reference on plot.ly for  surfacecolor .
        public static Box<ISurfaceProperty> surfacecolorsrc(string val) => Interop.mkSurfaceAttr("surfacecolorsrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<ISurfaceProperty> hoverinfosrc(string val) => Interop.mkSurfaceAttr("hoverinfosrc", val);
        /// Hides/displays surfaces between minimum and maximum iso-values.
        public static Box<ISurfaceProperty> show(bool val) => Interop.mkSurfaceAttr("show", val);
        /// Sets the number of iso-surfaces between minimum and maximum iso-values. By default this value is 2 meaning that only minimum and maximum surfaces would be drawn.
        public static Box<ISurfaceProperty> count(int val) => Interop.mkSurfaceAttr("count", val);
        /// Sets the fill ratio of the iso-surface. The default fill value of the surface is 1 meaning that they are entirely shaded. On the other hand Applying a `fill` ratio less than one would allow the creation of openings parallel to the edges.
        public static Box<ISurfaceProperty> fill(int val) => Interop.mkSurfaceAttr("fill", val);
        /// Sets the fill ratio of the iso-surface. The default fill value of the surface is 1 meaning that they are entirely shaded. On the other hand Applying a `fill` ratio less than one would allow the creation of openings parallel to the edges.
        public static Box<ISurfaceProperty> fill(float val) => Interop.mkSurfaceAttr("fill", val);
        /// Sets the surface pattern of the iso-surface 3-D sections. The default pattern of the surface is `all` meaning that the rest of surface elements would be shaded. The check options (either 1 or 2) could be used to draw half of the squares on the surface. Using various combinations of capital `A`, `B`, `C`, `D` and `E` may also be used to reduce the number of triangles on the iso-surfaces and creating other patterns of interest.
        public static Box<ISurfaceProperty> pattern(params Box<ISurfaceProperty>[] properties) => Interop.mkSurfaceAttr("pattern", Bindings.joinEnumProperties(properties));
    }

    public static partial class Surface
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<ISurfaceProperty> legendonly() => Interop.mkSurfaceAttr("visible", "legendonly");
            public static Box<ISurfaceProperty> _false() => Interop.mkSurfaceAttr("visible", false);
            public static Box<ISurfaceProperty> _true() => Interop.mkSurfaceAttr("visible", true);
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<ISurfaceProperty> all() => Interop.mkSurfaceAttr("hoverinfo", "all");
            public static Box<ISurfaceProperty> none() => Interop.mkSurfaceAttr("hoverinfo", "none");
            public static Box<ISurfaceProperty> skip() => Interop.mkSurfaceAttr("hoverinfo", "skip");
            public static Box<ISurfaceProperty> name() => Interop.mkSurfaceAttr("hoverinfo", "name");
            public static Box<ISurfaceProperty> text() => Interop.mkSurfaceAttr("hoverinfo", "text");
            public static Box<ISurfaceProperty> x() => Interop.mkSurfaceAttr("hoverinfo", "x");
            public static Box<ISurfaceProperty> y() => Interop.mkSurfaceAttr("hoverinfo", "y");
            public static Box<ISurfaceProperty> z() => Interop.mkSurfaceAttr("hoverinfo", "z");
        }

        /// Sets the calendar system to use with `x` date data.
        public static partial class Xcalendar
        {
            public static Box<ISurfaceProperty> chinese() => Interop.mkSurfaceAttr("xcalendar", "chinese");
            public static Box<ISurfaceProperty> coptic() => Interop.mkSurfaceAttr("xcalendar", "coptic");
            public static Box<ISurfaceProperty> discworld() => Interop.mkSurfaceAttr("xcalendar", "discworld");
            public static Box<ISurfaceProperty> ethiopian() => Interop.mkSurfaceAttr("xcalendar", "ethiopian");
            public static Box<ISurfaceProperty> gregorian() => Interop.mkSurfaceAttr("xcalendar", "gregorian");
            public static Box<ISurfaceProperty> hebrew() => Interop.mkSurfaceAttr("xcalendar", "hebrew");
            public static Box<ISurfaceProperty> islamic() => Interop.mkSurfaceAttr("xcalendar", "islamic");
            public static Box<ISurfaceProperty> jalali() => Interop.mkSurfaceAttr("xcalendar", "jalali");
            public static Box<ISurfaceProperty> julian() => Interop.mkSurfaceAttr("xcalendar", "julian");
            public static Box<ISurfaceProperty> mayan() => Interop.mkSurfaceAttr("xcalendar", "mayan");
            public static Box<ISurfaceProperty> nanakshahi() => Interop.mkSurfaceAttr("xcalendar", "nanakshahi");
            public static Box<ISurfaceProperty> nepali() => Interop.mkSurfaceAttr("xcalendar", "nepali");
            public static Box<ISurfaceProperty> persian() => Interop.mkSurfaceAttr("xcalendar", "persian");
            public static Box<ISurfaceProperty> taiwan() => Interop.mkSurfaceAttr("xcalendar", "taiwan");
            public static Box<ISurfaceProperty> thai() => Interop.mkSurfaceAttr("xcalendar", "thai");
            public static Box<ISurfaceProperty> ummalqura() => Interop.mkSurfaceAttr("xcalendar", "ummalqura");
        }

        /// Sets the calendar system to use with `y` date data.
        public static partial class Ycalendar
        {
            public static Box<ISurfaceProperty> chinese() => Interop.mkSurfaceAttr("ycalendar", "chinese");
            public static Box<ISurfaceProperty> coptic() => Interop.mkSurfaceAttr("ycalendar", "coptic");
            public static Box<ISurfaceProperty> discworld() => Interop.mkSurfaceAttr("ycalendar", "discworld");
            public static Box<ISurfaceProperty> ethiopian() => Interop.mkSurfaceAttr("ycalendar", "ethiopian");
            public static Box<ISurfaceProperty> gregorian() => Interop.mkSurfaceAttr("ycalendar", "gregorian");
            public static Box<ISurfaceProperty> hebrew() => Interop.mkSurfaceAttr("ycalendar", "hebrew");
            public static Box<ISurfaceProperty> islamic() => Interop.mkSurfaceAttr("ycalendar", "islamic");
            public static Box<ISurfaceProperty> jalali() => Interop.mkSurfaceAttr("ycalendar", "jalali");
            public static Box<ISurfaceProperty> julian() => Interop.mkSurfaceAttr("ycalendar", "julian");
            public static Box<ISurfaceProperty> mayan() => Interop.mkSurfaceAttr("ycalendar", "mayan");
            public static Box<ISurfaceProperty> nanakshahi() => Interop.mkSurfaceAttr("ycalendar", "nanakshahi");
            public static Box<ISurfaceProperty> nepali() => Interop.mkSurfaceAttr("ycalendar", "nepali");
            public static Box<ISurfaceProperty> persian() => Interop.mkSurfaceAttr("ycalendar", "persian");
            public static Box<ISurfaceProperty> taiwan() => Interop.mkSurfaceAttr("ycalendar", "taiwan");
            public static Box<ISurfaceProperty> thai() => Interop.mkSurfaceAttr("ycalendar", "thai");
            public static Box<ISurfaceProperty> ummalqura() => Interop.mkSurfaceAttr("ycalendar", "ummalqura");
        }

        /// Sets the calendar system to use with `z` date data.
        public static partial class Zcalendar
        {
            public static Box<ISurfaceProperty> chinese() => Interop.mkSurfaceAttr("zcalendar", "chinese");
            public static Box<ISurfaceProperty> coptic() => Interop.mkSurfaceAttr("zcalendar", "coptic");
            public static Box<ISurfaceProperty> discworld() => Interop.mkSurfaceAttr("zcalendar", "discworld");
            public static Box<ISurfaceProperty> ethiopian() => Interop.mkSurfaceAttr("zcalendar", "ethiopian");
            public static Box<ISurfaceProperty> gregorian() => Interop.mkSurfaceAttr("zcalendar", "gregorian");
            public static Box<ISurfaceProperty> hebrew() => Interop.mkSurfaceAttr("zcalendar", "hebrew");
            public static Box<ISurfaceProperty> islamic() => Interop.mkSurfaceAttr("zcalendar", "islamic");
            public static Box<ISurfaceProperty> jalali() => Interop.mkSurfaceAttr("zcalendar", "jalali");
            public static Box<ISurfaceProperty> julian() => Interop.mkSurfaceAttr("zcalendar", "julian");
            public static Box<ISurfaceProperty> mayan() => Interop.mkSurfaceAttr("zcalendar", "mayan");
            public static Box<ISurfaceProperty> nanakshahi() => Interop.mkSurfaceAttr("zcalendar", "nanakshahi");
            public static Box<ISurfaceProperty> nepali() => Interop.mkSurfaceAttr("zcalendar", "nepali");
            public static Box<ISurfaceProperty> persian() => Interop.mkSurfaceAttr("zcalendar", "persian");
            public static Box<ISurfaceProperty> taiwan() => Interop.mkSurfaceAttr("zcalendar", "taiwan");
            public static Box<ISurfaceProperty> thai() => Interop.mkSurfaceAttr("zcalendar", "thai");
            public static Box<ISurfaceProperty> ummalqura() => Interop.mkSurfaceAttr("zcalendar", "ummalqura");
        }

        /// Sets the surface pattern of the iso-surface 3-D sections. The default pattern of the surface is `all` meaning that the rest of surface elements would be shaded. The check options (either 1 or 2) could be used to draw half of the squares on the surface. Using various combinations of capital `A`, `B`, `C`, `D` and `E` may also be used to reduce the number of triangles on the iso-surfaces and creating other patterns of interest.
        public static partial class Pattern
        {
            public static Box<ISurfaceProperty> all() => Interop.mkSurfaceAttr("pattern", "all");
            public static Box<ISurfaceProperty> even() => Interop.mkSurfaceAttr("pattern", "even");
            public static Box<ISurfaceProperty> odd() => Interop.mkSurfaceAttr("pattern", "odd");
            public static Box<ISurfaceProperty> A() => Interop.mkSurfaceAttr("pattern", "A");
            public static Box<ISurfaceProperty> B() => Interop.mkSurfaceAttr("pattern", "B");
            public static Box<ISurfaceProperty> C() => Interop.mkSurfaceAttr("pattern", "C");
            public static Box<ISurfaceProperty> D() => Interop.mkSurfaceAttr("pattern", "D");
            public static Box<ISurfaceProperty> E() => Interop.mkSurfaceAttr("pattern", "E");
        }
    }
}