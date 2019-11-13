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

    public static partial class Isosurface
    {
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IIsosurfaceProperty> name(string val) => Interop.mkIsosurfaceAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IIsosurfaceProperty> uid(string val) => Interop.mkIsosurfaceAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIsosurfaceProperty> ids(bool val) => Interop.mkIsosurfaceAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIsosurfaceProperty> ids(params bool[] values) => Interop.mkIsosurfaceAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIsosurfaceProperty> ids(System.DateTime val) => Interop.mkIsosurfaceAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIsosurfaceProperty> ids(params System.DateTime[] values) => Interop.mkIsosurfaceAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIsosurfaceProperty> ids(float val) => Interop.mkIsosurfaceAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIsosurfaceProperty> ids(params float[] values) => Interop.mkIsosurfaceAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIsosurfaceProperty> ids(int val) => Interop.mkIsosurfaceAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIsosurfaceProperty> ids(params int[] values) => Interop.mkIsosurfaceAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIsosurfaceProperty> ids(string val) => Interop.mkIsosurfaceAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIsosurfaceProperty> ids(params string[] values) => Interop.mkIsosurfaceAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIsosurfaceProperty> ids(IEnumerable<bool[]> values) => Interop.mkIsosurfaceAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIsosurfaceProperty> ids(List<bool[]> values) => Interop.mkIsosurfaceAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIsosurfaceProperty> ids(params bool[][] values) => Interop.mkIsosurfaceAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIsosurfaceProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkIsosurfaceAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIsosurfaceProperty> ids(List<string[]> values) => Interop.mkIsosurfaceAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIsosurfaceProperty> ids(params string[][] values) => Interop.mkIsosurfaceAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIsosurfaceProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkIsosurfaceAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIsosurfaceProperty> ids(List<int[]> values) => Interop.mkIsosurfaceAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIsosurfaceProperty> ids(params int[][] values) => Interop.mkIsosurfaceAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIsosurfaceProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkIsosurfaceAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIsosurfaceProperty> ids(List<float[]> values) => Interop.mkIsosurfaceAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIsosurfaceProperty> ids(params float[][] values) => Interop.mkIsosurfaceAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIsosurfaceProperty> ids(Literals.PlotData[] values) => Interop.mkIsosurfaceAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIsosurfaceProperty> ids(IEnumerable<bool?> values) => Interop.mkIsosurfaceAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIsosurfaceProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkIsosurfaceAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIsosurfaceProperty> ids(IEnumerable<int?> values) => Interop.mkIsosurfaceAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIsosurfaceProperty> ids(IEnumerable<float?> values) => Interop.mkIsosurfaceAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIsosurfaceProperty> customdata(bool val) => Interop.mkIsosurfaceAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIsosurfaceProperty> customdata(params bool[] values) => Interop.mkIsosurfaceAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIsosurfaceProperty> customdata(System.DateTime val) => Interop.mkIsosurfaceAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIsosurfaceProperty> customdata(params System.DateTime[] values) => Interop.mkIsosurfaceAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIsosurfaceProperty> customdata(float val) => Interop.mkIsosurfaceAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIsosurfaceProperty> customdata(params float[] values) => Interop.mkIsosurfaceAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIsosurfaceProperty> customdata(int val) => Interop.mkIsosurfaceAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIsosurfaceProperty> customdata(params int[] values) => Interop.mkIsosurfaceAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIsosurfaceProperty> customdata(string val) => Interop.mkIsosurfaceAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIsosurfaceProperty> customdata(params string[] values) => Interop.mkIsosurfaceAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIsosurfaceProperty> customdata(IEnumerable<bool[]> values) => Interop.mkIsosurfaceAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIsosurfaceProperty> customdata(List<bool[]> values) => Interop.mkIsosurfaceAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIsosurfaceProperty> customdata(params bool[][] values) => Interop.mkIsosurfaceAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIsosurfaceProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkIsosurfaceAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIsosurfaceProperty> customdata(List<string[]> values) => Interop.mkIsosurfaceAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIsosurfaceProperty> customdata(params string[][] values) => Interop.mkIsosurfaceAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIsosurfaceProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkIsosurfaceAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIsosurfaceProperty> customdata(List<int[]> values) => Interop.mkIsosurfaceAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIsosurfaceProperty> customdata(params int[][] values) => Interop.mkIsosurfaceAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIsosurfaceProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkIsosurfaceAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIsosurfaceProperty> customdata(List<float[]> values) => Interop.mkIsosurfaceAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIsosurfaceProperty> customdata(params float[][] values) => Interop.mkIsosurfaceAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIsosurfaceProperty> customdata(Literals.PlotData[] values) => Interop.mkIsosurfaceAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIsosurfaceProperty> customdata(IEnumerable<bool?> values) => Interop.mkIsosurfaceAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIsosurfaceProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkIsosurfaceAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIsosurfaceProperty> customdata(IEnumerable<int?> values) => Interop.mkIsosurfaceAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIsosurfaceProperty> customdata(IEnumerable<float?> values) => Interop.mkIsosurfaceAttr("customdata", values.ToArray());
        public static Box<IIsosurfaceProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkIsosurfaceAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IIsosurfaceProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkIsosurfaceAttr("stream", Bindings.flattenProperties(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIsosurfaceProperty> uirevision(bool val) => Interop.mkIsosurfaceAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIsosurfaceProperty> uirevision(params bool[] values) => Interop.mkIsosurfaceAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIsosurfaceProperty> uirevision(System.DateTime val) => Interop.mkIsosurfaceAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIsosurfaceProperty> uirevision(params System.DateTime[] values) => Interop.mkIsosurfaceAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIsosurfaceProperty> uirevision(int val) => Interop.mkIsosurfaceAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIsosurfaceProperty> uirevision(params int[] values) => Interop.mkIsosurfaceAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIsosurfaceProperty> uirevision(float val) => Interop.mkIsosurfaceAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIsosurfaceProperty> uirevision(params float[] values) => Interop.mkIsosurfaceAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIsosurfaceProperty> uirevision(string val) => Interop.mkIsosurfaceAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIsosurfaceProperty> uirevision(params string[] values) => Interop.mkIsosurfaceAttr("uirevision", values);
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IIsosurfaceProperty> x(bool val) => Interop.mkIsosurfaceAttr("x", new[]{val});
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IIsosurfaceProperty> x(IEnumerable<bool> values) => Interop.mkIsosurfaceAttr("x", values.ToArray());
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IIsosurfaceProperty> x(System.DateTime val) => Interop.mkIsosurfaceAttr("x", new[]{val});
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IIsosurfaceProperty> x(IEnumerable<System.DateTime> values) => Interop.mkIsosurfaceAttr("x", values.ToArray());
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IIsosurfaceProperty> x(float val) => Interop.mkIsosurfaceAttr("x", new[]{val});
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IIsosurfaceProperty> x(IEnumerable<float> values) => Interop.mkIsosurfaceAttr("x", values.ToArray());
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IIsosurfaceProperty> x(int val) => Interop.mkIsosurfaceAttr("x", new[]{val});
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IIsosurfaceProperty> x(IEnumerable<int> values) => Interop.mkIsosurfaceAttr("x", values.ToArray());
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IIsosurfaceProperty> x(string val) => Interop.mkIsosurfaceAttr("x", new[]{val});
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IIsosurfaceProperty> x(IEnumerable<string> values) => Interop.mkIsosurfaceAttr("x", values.ToArray());
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IIsosurfaceProperty> x(IEnumerable<bool[]> values) => Interop.mkIsosurfaceAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IIsosurfaceProperty> x(List<bool[]> values) => Interop.mkIsosurfaceAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IIsosurfaceProperty> x(params bool[][] values) => Interop.mkIsosurfaceAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IIsosurfaceProperty> x(IEnumerable<IEnumerable<string>> values) => Interop.mkIsosurfaceAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IIsosurfaceProperty> x(List<string[]> values) => Interop.mkIsosurfaceAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IIsosurfaceProperty> x(params string[][] values) => Interop.mkIsosurfaceAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IIsosurfaceProperty> x(IEnumerable<IEnumerable<int>> values) => Interop.mkIsosurfaceAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IIsosurfaceProperty> x(List<int[]> values) => Interop.mkIsosurfaceAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IIsosurfaceProperty> x(params int[][] values) => Interop.mkIsosurfaceAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IIsosurfaceProperty> x(IEnumerable<IEnumerable<float>> values) => Interop.mkIsosurfaceAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IIsosurfaceProperty> x(List<float[]> values) => Interop.mkIsosurfaceAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IIsosurfaceProperty> x(params float[][] values) => Interop.mkIsosurfaceAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IIsosurfaceProperty> x(Literals.PlotData[] values) => Interop.mkIsosurfaceAttr("x", values);
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IIsosurfaceProperty> x(IEnumerable<bool?> values) => Interop.mkIsosurfaceAttr("x", values.ToArray());
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IIsosurfaceProperty> x(IEnumerable<System.DateTime?> values) => Interop.mkIsosurfaceAttr("x", values.ToArray());
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IIsosurfaceProperty> x(IEnumerable<int?> values) => Interop.mkIsosurfaceAttr("x", values.ToArray());
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IIsosurfaceProperty> x(IEnumerable<float?> values) => Interop.mkIsosurfaceAttr("x", values.ToArray());
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IIsosurfaceProperty> y(bool val) => Interop.mkIsosurfaceAttr("y", new[]{val});
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IIsosurfaceProperty> y(IEnumerable<bool> values) => Interop.mkIsosurfaceAttr("y", values.ToArray());
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IIsosurfaceProperty> y(System.DateTime val) => Interop.mkIsosurfaceAttr("y", new[]{val});
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IIsosurfaceProperty> y(IEnumerable<System.DateTime> values) => Interop.mkIsosurfaceAttr("y", values.ToArray());
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IIsosurfaceProperty> y(float val) => Interop.mkIsosurfaceAttr("y", new[]{val});
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IIsosurfaceProperty> y(IEnumerable<float> values) => Interop.mkIsosurfaceAttr("y", values.ToArray());
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IIsosurfaceProperty> y(int val) => Interop.mkIsosurfaceAttr("y", new[]{val});
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IIsosurfaceProperty> y(IEnumerable<int> values) => Interop.mkIsosurfaceAttr("y", values.ToArray());
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IIsosurfaceProperty> y(string val) => Interop.mkIsosurfaceAttr("y", new[]{val});
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IIsosurfaceProperty> y(IEnumerable<string> values) => Interop.mkIsosurfaceAttr("y", values.ToArray());
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IIsosurfaceProperty> y(IEnumerable<bool[]> values) => Interop.mkIsosurfaceAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IIsosurfaceProperty> y(List<bool[]> values) => Interop.mkIsosurfaceAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IIsosurfaceProperty> y(params bool[][] values) => Interop.mkIsosurfaceAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IIsosurfaceProperty> y(IEnumerable<IEnumerable<string>> values) => Interop.mkIsosurfaceAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IIsosurfaceProperty> y(List<string[]> values) => Interop.mkIsosurfaceAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IIsosurfaceProperty> y(params string[][] values) => Interop.mkIsosurfaceAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IIsosurfaceProperty> y(IEnumerable<IEnumerable<int>> values) => Interop.mkIsosurfaceAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IIsosurfaceProperty> y(List<int[]> values) => Interop.mkIsosurfaceAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IIsosurfaceProperty> y(params int[][] values) => Interop.mkIsosurfaceAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IIsosurfaceProperty> y(IEnumerable<IEnumerable<float>> values) => Interop.mkIsosurfaceAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IIsosurfaceProperty> y(List<float[]> values) => Interop.mkIsosurfaceAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IIsosurfaceProperty> y(params float[][] values) => Interop.mkIsosurfaceAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IIsosurfaceProperty> y(Literals.PlotData[] values) => Interop.mkIsosurfaceAttr("y", values);
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IIsosurfaceProperty> y(IEnumerable<bool?> values) => Interop.mkIsosurfaceAttr("y", values.ToArray());
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IIsosurfaceProperty> y(IEnumerable<System.DateTime?> values) => Interop.mkIsosurfaceAttr("y", values.ToArray());
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IIsosurfaceProperty> y(IEnumerable<int?> values) => Interop.mkIsosurfaceAttr("y", values.ToArray());
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IIsosurfaceProperty> y(IEnumerable<float?> values) => Interop.mkIsosurfaceAttr("y", values.ToArray());
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IIsosurfaceProperty> z(bool val) => Interop.mkIsosurfaceAttr("z", new[]{val});
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IIsosurfaceProperty> z(IEnumerable<bool> values) => Interop.mkIsosurfaceAttr("z", values.ToArray());
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IIsosurfaceProperty> z(System.DateTime val) => Interop.mkIsosurfaceAttr("z", new[]{val});
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IIsosurfaceProperty> z(IEnumerable<System.DateTime> values) => Interop.mkIsosurfaceAttr("z", values.ToArray());
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IIsosurfaceProperty> z(float val) => Interop.mkIsosurfaceAttr("z", new[]{val});
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IIsosurfaceProperty> z(IEnumerable<float> values) => Interop.mkIsosurfaceAttr("z", values.ToArray());
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IIsosurfaceProperty> z(int val) => Interop.mkIsosurfaceAttr("z", new[]{val});
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IIsosurfaceProperty> z(IEnumerable<int> values) => Interop.mkIsosurfaceAttr("z", values.ToArray());
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IIsosurfaceProperty> z(string val) => Interop.mkIsosurfaceAttr("z", new[]{val});
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IIsosurfaceProperty> z(IEnumerable<string> values) => Interop.mkIsosurfaceAttr("z", values.ToArray());
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IIsosurfaceProperty> z(IEnumerable<bool[]> values) => Interop.mkIsosurfaceAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IIsosurfaceProperty> z(List<bool[]> values) => Interop.mkIsosurfaceAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IIsosurfaceProperty> z(params bool[][] values) => Interop.mkIsosurfaceAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IIsosurfaceProperty> z(IEnumerable<IEnumerable<string>> values) => Interop.mkIsosurfaceAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IIsosurfaceProperty> z(List<string[]> values) => Interop.mkIsosurfaceAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IIsosurfaceProperty> z(params string[][] values) => Interop.mkIsosurfaceAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IIsosurfaceProperty> z(IEnumerable<IEnumerable<int>> values) => Interop.mkIsosurfaceAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IIsosurfaceProperty> z(List<int[]> values) => Interop.mkIsosurfaceAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IIsosurfaceProperty> z(params int[][] values) => Interop.mkIsosurfaceAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IIsosurfaceProperty> z(IEnumerable<IEnumerable<float>> values) => Interop.mkIsosurfaceAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IIsosurfaceProperty> z(List<float[]> values) => Interop.mkIsosurfaceAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IIsosurfaceProperty> z(params float[][] values) => Interop.mkIsosurfaceAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IIsosurfaceProperty> z(Literals.PlotData[] values) => Interop.mkIsosurfaceAttr("z", values);
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IIsosurfaceProperty> z(IEnumerable<bool?> values) => Interop.mkIsosurfaceAttr("z", values.ToArray());
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IIsosurfaceProperty> z(IEnumerable<System.DateTime?> values) => Interop.mkIsosurfaceAttr("z", values.ToArray());
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IIsosurfaceProperty> z(IEnumerable<int?> values) => Interop.mkIsosurfaceAttr("z", values.ToArray());
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IIsosurfaceProperty> z(IEnumerable<float?> values) => Interop.mkIsosurfaceAttr("z", values.ToArray());
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IIsosurfaceProperty> value(bool val) => Interop.mkIsosurfaceAttr("value", new[]{val});
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IIsosurfaceProperty> value(IEnumerable<bool> values) => Interop.mkIsosurfaceAttr("value", values.ToArray());
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IIsosurfaceProperty> value(System.DateTime val) => Interop.mkIsosurfaceAttr("value", new[]{val});
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IIsosurfaceProperty> value(IEnumerable<System.DateTime> values) => Interop.mkIsosurfaceAttr("value", values.ToArray());
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IIsosurfaceProperty> value(float val) => Interop.mkIsosurfaceAttr("value", new[]{val});
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IIsosurfaceProperty> value(IEnumerable<float> values) => Interop.mkIsosurfaceAttr("value", values.ToArray());
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IIsosurfaceProperty> value(int val) => Interop.mkIsosurfaceAttr("value", new[]{val});
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IIsosurfaceProperty> value(IEnumerable<int> values) => Interop.mkIsosurfaceAttr("value", values.ToArray());
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IIsosurfaceProperty> value(string val) => Interop.mkIsosurfaceAttr("value", new[]{val});
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IIsosurfaceProperty> value(IEnumerable<string> values) => Interop.mkIsosurfaceAttr("value", values.ToArray());
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IIsosurfaceProperty> value(IEnumerable<bool[]> values) => Interop.mkIsosurfaceAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IIsosurfaceProperty> value(List<bool[]> values) => Interop.mkIsosurfaceAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IIsosurfaceProperty> value(params bool[][] values) => Interop.mkIsosurfaceAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IIsosurfaceProperty> value(IEnumerable<IEnumerable<string>> values) => Interop.mkIsosurfaceAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IIsosurfaceProperty> value(List<string[]> values) => Interop.mkIsosurfaceAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IIsosurfaceProperty> value(params string[][] values) => Interop.mkIsosurfaceAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IIsosurfaceProperty> value(IEnumerable<IEnumerable<int>> values) => Interop.mkIsosurfaceAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IIsosurfaceProperty> value(List<int[]> values) => Interop.mkIsosurfaceAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IIsosurfaceProperty> value(params int[][] values) => Interop.mkIsosurfaceAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IIsosurfaceProperty> value(IEnumerable<IEnumerable<float>> values) => Interop.mkIsosurfaceAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IIsosurfaceProperty> value(List<float[]> values) => Interop.mkIsosurfaceAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IIsosurfaceProperty> value(params float[][] values) => Interop.mkIsosurfaceAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IIsosurfaceProperty> value(Literals.PlotData[] values) => Interop.mkIsosurfaceAttr("value", values);
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IIsosurfaceProperty> value(IEnumerable<bool?> values) => Interop.mkIsosurfaceAttr("value", values.ToArray());
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IIsosurfaceProperty> value(IEnumerable<System.DateTime?> values) => Interop.mkIsosurfaceAttr("value", values.ToArray());
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IIsosurfaceProperty> value(IEnumerable<int?> values) => Interop.mkIsosurfaceAttr("value", values.ToArray());
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IIsosurfaceProperty> value(IEnumerable<float?> values) => Interop.mkIsosurfaceAttr("value", values.ToArray());
        /// Sets the minimum boundary for iso-surface plot.
        public static Box<IIsosurfaceProperty> isomin(int val) => Interop.mkIsosurfaceAttr("isomin", val);
        /// Sets the minimum boundary for iso-surface plot.
        public static Box<IIsosurfaceProperty> isomin(float val) => Interop.mkIsosurfaceAttr("isomin", val);
        /// Sets the maximum boundary for iso-surface plot.
        public static Box<IIsosurfaceProperty> isomax(int val) => Interop.mkIsosurfaceAttr("isomax", val);
        /// Sets the maximum boundary for iso-surface plot.
        public static Box<IIsosurfaceProperty> isomax(float val) => Interop.mkIsosurfaceAttr("isomax", val);
        public static Box<IIsosurfaceProperty> surface(params Box<ISurfaceProperty>[] properties) => Interop.mkIsosurfaceAttr("surface", Bindings.flattenProperties(properties));
        public static Box<IIsosurfaceProperty> spaceframe(params Box<ISpaceframeProperty>[] properties) => Interop.mkIsosurfaceAttr("spaceframe", Bindings.flattenProperties(properties));
        public static Box<IIsosurfaceProperty> slices(params Box<ISlicesProperty>[] properties) => Interop.mkIsosurfaceAttr("slices", Bindings.flattenProperties(properties));
        public static Box<IIsosurfaceProperty> caps(params Box<ICapsProperty>[] properties) => Interop.mkIsosurfaceAttr("caps", Bindings.flattenProperties(properties));
        /// Sets the text elements associated with the vertices. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIsosurfaceProperty> text(string val) => Interop.mkIsosurfaceAttr("text", val);
        /// Sets the text elements associated with the vertices. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IIsosurfaceProperty> text(IEnumerable<string> values) => Interop.mkIsosurfaceAttr("text", values.ToArray());
        /// Same as `text`.
        public static Box<IIsosurfaceProperty> hovertext(string val) => Interop.mkIsosurfaceAttr("hovertext", val);
        /// Same as `text`.
        public static Box<IIsosurfaceProperty> hovertext(IEnumerable<string> values) => Interop.mkIsosurfaceAttr("hovertext", values.ToArray());
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IIsosurfaceProperty> hovertemplate(string val) => Interop.mkIsosurfaceAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IIsosurfaceProperty> hovertemplate(IEnumerable<string> values) => Interop.mkIsosurfaceAttr("hovertemplate", values.ToArray());
        /// Determines whether or not the color domain is computed with respect to the input data (here `value`) or the bounds set in `cmin` and `cmax`  Defaults to `false` when `cmin` and `cmax` are set by the user.
        public static Box<IIsosurfaceProperty> cauto(bool val) => Interop.mkIsosurfaceAttr("cauto", val);
        /// Sets the lower bound of the color domain. Value should have the same units as `value` and if set, `cmax` must be set as well.
        public static Box<IIsosurfaceProperty> cmin(int val) => Interop.mkIsosurfaceAttr("cmin", val);
        /// Sets the lower bound of the color domain. Value should have the same units as `value` and if set, `cmax` must be set as well.
        public static Box<IIsosurfaceProperty> cmin(float val) => Interop.mkIsosurfaceAttr("cmin", val);
        /// Sets the upper bound of the color domain. Value should have the same units as `value` and if set, `cmin` must be set as well.
        public static Box<IIsosurfaceProperty> cmax(int val) => Interop.mkIsosurfaceAttr("cmax", val);
        /// Sets the upper bound of the color domain. Value should have the same units as `value` and if set, `cmin` must be set as well.
        public static Box<IIsosurfaceProperty> cmax(float val) => Interop.mkIsosurfaceAttr("cmax", val);
        /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as `value`. Has no effect when `cauto` is `false`.
        public static Box<IIsosurfaceProperty> cmid(int val) => Interop.mkIsosurfaceAttr("cmid", val);
        /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as `value`. Has no effect when `cauto` is `false`.
        public static Box<IIsosurfaceProperty> cmid(float val) => Interop.mkIsosurfaceAttr("cmid", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IIsosurfaceProperty> colorscale(string val) => Interop.mkIsosurfaceAttr("colorscale", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IIsosurfaceProperty> colorscale(List<string[]> values) => Interop.mkIsosurfaceAttr("colorscale", Bindings.flatten2DArrayIf1D(values));
        /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
        public static Box<IIsosurfaceProperty> autocolorscale(bool val) => Interop.mkIsosurfaceAttr("autocolorscale", val);
        /// Reverses the color mapping if true. If true, `cmin` will correspond to the last color in the array and `cmax` will correspond to the first color.
        public static Box<IIsosurfaceProperty> reversescale(bool val) => Interop.mkIsosurfaceAttr("reversescale", val);
        /// Determines whether or not a colorbar is displayed for this trace.
        public static Box<IIsosurfaceProperty> showscale(bool val) => Interop.mkIsosurfaceAttr("showscale", val);
        public static Box<IIsosurfaceProperty> colorbar(params Box<IColorbarProperty>[] properties) => Interop.mkIsosurfaceAttr("colorbar", Bindings.flattenProperties(properties));
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<IIsosurfaceProperty> coloraxis(int anchorId) => Interop.mkIsosurfaceAttr("coloraxis", anchorId > 1 ? $"coloraxis{anchorId}" : "");
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<IIsosurfaceProperty> coloraxis(string val) => Interop.mkIsosurfaceAttr("coloraxis", val);
        /// Sets the opacity of the surface. Please note that in the case of using high `opacity` values for example a value greater than or equal to 0.5 on two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent surfaces may not perfectly be sorted in depth by the webgl API. This behavior may be improved in the near future and is subject to change.
        public static Box<IIsosurfaceProperty> opacity(int val) => Interop.mkIsosurfaceAttr("opacity", val);
        /// Sets the opacity of the surface. Please note that in the case of using high `opacity` values for example a value greater than or equal to 0.5 on two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent surfaces may not perfectly be sorted in depth by the webgl API. This behavior may be improved in the near future and is subject to change.
        public static Box<IIsosurfaceProperty> opacity(float val) => Interop.mkIsosurfaceAttr("opacity", val);
        public static Box<IIsosurfaceProperty> lightposition(params Box<ILightpositionProperty>[] properties) => Interop.mkIsosurfaceAttr("lightposition", Bindings.flattenProperties(properties));
        public static Box<IIsosurfaceProperty> lighting(params Box<ILightingProperty>[] properties) => Interop.mkIsosurfaceAttr("lighting", Bindings.flattenProperties(properties));
        /// Determines whether or not normal smoothing is applied to the meshes, creating meshes with an angular, low-poly look via flat reflections.
        public static Box<IIsosurfaceProperty> flatshading(bool val) => Interop.mkIsosurfaceAttr("flatshading", val);
        public static Box<IIsosurfaceProperty> contour(params Box<IContourProperty>[] properties) => Interop.mkIsosurfaceAttr("contour", Bindings.flattenProperties(properties));
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IIsosurfaceProperty> hoverinfo(params Box<IIsosurfaceProperty>[] properties) => Interop.mkIsosurfaceAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        /// Sets a reference between this trace's 3D coordinate system and a 3D scene. If *scene* (the default value), the (x,y,z) coordinates refer to `layout.scene`. If *scene2*, the (x,y,z) coordinates refer to `layout.scene2`, and so on.
        public static Box<IIsosurfaceProperty> scene(int anchorId) => Interop.mkIsosurfaceAttr("scene", anchorId > 1 ? $"scene{anchorId}" : "");
        /// Sets a reference between this trace's 3D coordinate system and a 3D scene. If *scene* (the default value), the (x,y,z) coordinates refer to `layout.scene`. If *scene2*, the (x,y,z) coordinates refer to `layout.scene2`, and so on.
        public static Box<IIsosurfaceProperty> scene(string val) => Interop.mkIsosurfaceAttr("scene", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IIsosurfaceProperty> idssrc(string val) => Interop.mkIsosurfaceAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IIsosurfaceProperty> customdatasrc(string val) => Interop.mkIsosurfaceAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IIsosurfaceProperty> metasrc(string val) => Interop.mkIsosurfaceAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  x .
        public static Box<IIsosurfaceProperty> xsrc(string val) => Interop.mkIsosurfaceAttr("xsrc", val);
        /// Sets the source reference on plot.ly for  y .
        public static Box<IIsosurfaceProperty> ysrc(string val) => Interop.mkIsosurfaceAttr("ysrc", val);
        /// Sets the source reference on plot.ly for  z .
        public static Box<IIsosurfaceProperty> zsrc(string val) => Interop.mkIsosurfaceAttr("zsrc", val);
        /// Sets the source reference on plot.ly for  value .
        public static Box<IIsosurfaceProperty> valuesrc(string val) => Interop.mkIsosurfaceAttr("valuesrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IIsosurfaceProperty> textsrc(string val) => Interop.mkIsosurfaceAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IIsosurfaceProperty> hovertextsrc(string val) => Interop.mkIsosurfaceAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IIsosurfaceProperty> hovertemplatesrc(string val) => Interop.mkIsosurfaceAttr("hovertemplatesrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IIsosurfaceProperty> hoverinfosrc(string val) => Interop.mkIsosurfaceAttr("hoverinfosrc", val);
    }

    public static partial class Isosurface
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IIsosurfaceProperty> legendonly() => Interop.mkIsosurfaceAttr("visible", "legendonly");
            public static Box<IIsosurfaceProperty> _false() => Interop.mkIsosurfaceAttr("visible", false);
            public static Box<IIsosurfaceProperty> _true() => Interop.mkIsosurfaceAttr("visible", true);
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IIsosurfaceProperty> all() => Interop.mkIsosurfaceAttr("hoverinfo", "all");
            public static Box<IIsosurfaceProperty> none() => Interop.mkIsosurfaceAttr("hoverinfo", "none");
            public static Box<IIsosurfaceProperty> skip() => Interop.mkIsosurfaceAttr("hoverinfo", "skip");
            public static Box<IIsosurfaceProperty> name() => Interop.mkIsosurfaceAttr("hoverinfo", "name");
            public static Box<IIsosurfaceProperty> text() => Interop.mkIsosurfaceAttr("hoverinfo", "text");
            public static Box<IIsosurfaceProperty> x() => Interop.mkIsosurfaceAttr("hoverinfo", "x");
            public static Box<IIsosurfaceProperty> y() => Interop.mkIsosurfaceAttr("hoverinfo", "y");
            public static Box<IIsosurfaceProperty> z() => Interop.mkIsosurfaceAttr("hoverinfo", "z");
        }
    }
}