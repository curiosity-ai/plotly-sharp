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

    public static partial class Mesh3d
    {
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IMesh3dProperty> legendgroup(string val) => Interop.mkMesh3dAttr("legendgroup", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IMesh3dProperty> name(string val) => Interop.mkMesh3dAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IMesh3dProperty> uid(string val) => Interop.mkMesh3dAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IMesh3dProperty> ids(bool val) => Interop.mkMesh3dAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IMesh3dProperty> ids(params bool[] values) => Interop.mkMesh3dAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IMesh3dProperty> ids(System.DateTime val) => Interop.mkMesh3dAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IMesh3dProperty> ids(params System.DateTime[] values) => Interop.mkMesh3dAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IMesh3dProperty> ids(float val) => Interop.mkMesh3dAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IMesh3dProperty> ids(params float[] values) => Interop.mkMesh3dAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IMesh3dProperty> ids(int val) => Interop.mkMesh3dAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IMesh3dProperty> ids(params int[] values) => Interop.mkMesh3dAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IMesh3dProperty> ids(string val) => Interop.mkMesh3dAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IMesh3dProperty> ids(params string[] values) => Interop.mkMesh3dAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IMesh3dProperty> ids(IEnumerable<bool[]> values) => Interop.mkMesh3dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IMesh3dProperty> ids(List<bool[]> values) => Interop.mkMesh3dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IMesh3dProperty> ids(params bool[][] values) => Interop.mkMesh3dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IMesh3dProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkMesh3dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IMesh3dProperty> ids(List<string[]> values) => Interop.mkMesh3dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IMesh3dProperty> ids(params string[][] values) => Interop.mkMesh3dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IMesh3dProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkMesh3dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IMesh3dProperty> ids(List<int[]> values) => Interop.mkMesh3dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IMesh3dProperty> ids(params int[][] values) => Interop.mkMesh3dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IMesh3dProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkMesh3dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IMesh3dProperty> ids(List<float[]> values) => Interop.mkMesh3dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IMesh3dProperty> ids(params float[][] values) => Interop.mkMesh3dAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IMesh3dProperty> ids(Literals.PlotData[] values) => Interop.mkMesh3dAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IMesh3dProperty> ids(IEnumerable<bool?> values) => Interop.mkMesh3dAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IMesh3dProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkMesh3dAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IMesh3dProperty> ids(IEnumerable<int?> values) => Interop.mkMesh3dAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IMesh3dProperty> ids(IEnumerable<float?> values) => Interop.mkMesh3dAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IMesh3dProperty> customdata(bool val) => Interop.mkMesh3dAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IMesh3dProperty> customdata(params bool[] values) => Interop.mkMesh3dAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IMesh3dProperty> customdata(System.DateTime val) => Interop.mkMesh3dAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IMesh3dProperty> customdata(params System.DateTime[] values) => Interop.mkMesh3dAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IMesh3dProperty> customdata(float val) => Interop.mkMesh3dAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IMesh3dProperty> customdata(params float[] values) => Interop.mkMesh3dAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IMesh3dProperty> customdata(int val) => Interop.mkMesh3dAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IMesh3dProperty> customdata(params int[] values) => Interop.mkMesh3dAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IMesh3dProperty> customdata(string val) => Interop.mkMesh3dAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IMesh3dProperty> customdata(params string[] values) => Interop.mkMesh3dAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IMesh3dProperty> customdata(IEnumerable<bool[]> values) => Interop.mkMesh3dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IMesh3dProperty> customdata(List<bool[]> values) => Interop.mkMesh3dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IMesh3dProperty> customdata(params bool[][] values) => Interop.mkMesh3dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IMesh3dProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkMesh3dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IMesh3dProperty> customdata(List<string[]> values) => Interop.mkMesh3dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IMesh3dProperty> customdata(params string[][] values) => Interop.mkMesh3dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IMesh3dProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkMesh3dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IMesh3dProperty> customdata(List<int[]> values) => Interop.mkMesh3dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IMesh3dProperty> customdata(params int[][] values) => Interop.mkMesh3dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IMesh3dProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkMesh3dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IMesh3dProperty> customdata(List<float[]> values) => Interop.mkMesh3dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IMesh3dProperty> customdata(params float[][] values) => Interop.mkMesh3dAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IMesh3dProperty> customdata(Literals.PlotData[] values) => Interop.mkMesh3dAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IMesh3dProperty> customdata(IEnumerable<bool?> values) => Interop.mkMesh3dAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IMesh3dProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkMesh3dAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IMesh3dProperty> customdata(IEnumerable<int?> values) => Interop.mkMesh3dAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IMesh3dProperty> customdata(IEnumerable<float?> values) => Interop.mkMesh3dAttr("customdata", values.ToArray());
        public static Box<IMesh3dProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkMesh3dAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IMesh3dProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkMesh3dAttr("stream", Bindings.flattenProperties(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IMesh3dProperty> uirevision(bool val) => Interop.mkMesh3dAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IMesh3dProperty> uirevision(params bool[] values) => Interop.mkMesh3dAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IMesh3dProperty> uirevision(System.DateTime val) => Interop.mkMesh3dAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IMesh3dProperty> uirevision(params System.DateTime[] values) => Interop.mkMesh3dAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IMesh3dProperty> uirevision(int val) => Interop.mkMesh3dAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IMesh3dProperty> uirevision(params int[] values) => Interop.mkMesh3dAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IMesh3dProperty> uirevision(float val) => Interop.mkMesh3dAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IMesh3dProperty> uirevision(params float[] values) => Interop.mkMesh3dAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IMesh3dProperty> uirevision(string val) => Interop.mkMesh3dAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IMesh3dProperty> uirevision(params string[] values) => Interop.mkMesh3dAttr("uirevision", values);
        /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> x(bool val) => Interop.mkMesh3dAttr("x", new[]{val});
        /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> x(IEnumerable<bool> values) => Interop.mkMesh3dAttr("x", values.ToArray());
        /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> x(System.DateTime val) => Interop.mkMesh3dAttr("x", new[]{val});
        /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> x(IEnumerable<System.DateTime> values) => Interop.mkMesh3dAttr("x", values.ToArray());
        /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> x(float val) => Interop.mkMesh3dAttr("x", new[]{val});
        /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> x(IEnumerable<float> values) => Interop.mkMesh3dAttr("x", values.ToArray());
        /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> x(int val) => Interop.mkMesh3dAttr("x", new[]{val});
        /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> x(IEnumerable<int> values) => Interop.mkMesh3dAttr("x", values.ToArray());
        /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> x(string val) => Interop.mkMesh3dAttr("x", new[]{val});
        /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> x(IEnumerable<string> values) => Interop.mkMesh3dAttr("x", values.ToArray());
        /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> x(IEnumerable<bool[]> values) => Interop.mkMesh3dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> x(List<bool[]> values) => Interop.mkMesh3dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> x(params bool[][] values) => Interop.mkMesh3dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> x(IEnumerable<IEnumerable<string>> values) => Interop.mkMesh3dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> x(List<string[]> values) => Interop.mkMesh3dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> x(params string[][] values) => Interop.mkMesh3dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> x(IEnumerable<IEnumerable<int>> values) => Interop.mkMesh3dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> x(List<int[]> values) => Interop.mkMesh3dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> x(params int[][] values) => Interop.mkMesh3dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> x(IEnumerable<IEnumerable<float>> values) => Interop.mkMesh3dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> x(List<float[]> values) => Interop.mkMesh3dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> x(params float[][] values) => Interop.mkMesh3dAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> x(Literals.PlotData[] values) => Interop.mkMesh3dAttr("x", values);
        /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> x(IEnumerable<bool?> values) => Interop.mkMesh3dAttr("x", values.ToArray());
        /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> x(IEnumerable<System.DateTime?> values) => Interop.mkMesh3dAttr("x", values.ToArray());
        /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> x(IEnumerable<int?> values) => Interop.mkMesh3dAttr("x", values.ToArray());
        /// Sets the X coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> x(IEnumerable<float?> values) => Interop.mkMesh3dAttr("x", values.ToArray());
        /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> y(bool val) => Interop.mkMesh3dAttr("y", new[]{val});
        /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> y(IEnumerable<bool> values) => Interop.mkMesh3dAttr("y", values.ToArray());
        /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> y(System.DateTime val) => Interop.mkMesh3dAttr("y", new[]{val});
        /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> y(IEnumerable<System.DateTime> values) => Interop.mkMesh3dAttr("y", values.ToArray());
        /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> y(float val) => Interop.mkMesh3dAttr("y", new[]{val});
        /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> y(IEnumerable<float> values) => Interop.mkMesh3dAttr("y", values.ToArray());
        /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> y(int val) => Interop.mkMesh3dAttr("y", new[]{val});
        /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> y(IEnumerable<int> values) => Interop.mkMesh3dAttr("y", values.ToArray());
        /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> y(string val) => Interop.mkMesh3dAttr("y", new[]{val});
        /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> y(IEnumerable<string> values) => Interop.mkMesh3dAttr("y", values.ToArray());
        /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> y(IEnumerable<bool[]> values) => Interop.mkMesh3dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> y(List<bool[]> values) => Interop.mkMesh3dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> y(params bool[][] values) => Interop.mkMesh3dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> y(IEnumerable<IEnumerable<string>> values) => Interop.mkMesh3dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> y(List<string[]> values) => Interop.mkMesh3dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> y(params string[][] values) => Interop.mkMesh3dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> y(IEnumerable<IEnumerable<int>> values) => Interop.mkMesh3dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> y(List<int[]> values) => Interop.mkMesh3dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> y(params int[][] values) => Interop.mkMesh3dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> y(IEnumerable<IEnumerable<float>> values) => Interop.mkMesh3dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> y(List<float[]> values) => Interop.mkMesh3dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> y(params float[][] values) => Interop.mkMesh3dAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> y(Literals.PlotData[] values) => Interop.mkMesh3dAttr("y", values);
        /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> y(IEnumerable<bool?> values) => Interop.mkMesh3dAttr("y", values.ToArray());
        /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> y(IEnumerable<System.DateTime?> values) => Interop.mkMesh3dAttr("y", values.ToArray());
        /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> y(IEnumerable<int?> values) => Interop.mkMesh3dAttr("y", values.ToArray());
        /// Sets the Y coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> y(IEnumerable<float?> values) => Interop.mkMesh3dAttr("y", values.ToArray());
        /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> z(bool val) => Interop.mkMesh3dAttr("z", new[]{val});
        /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> z(IEnumerable<bool> values) => Interop.mkMesh3dAttr("z", values.ToArray());
        /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> z(System.DateTime val) => Interop.mkMesh3dAttr("z", new[]{val});
        /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> z(IEnumerable<System.DateTime> values) => Interop.mkMesh3dAttr("z", values.ToArray());
        /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> z(float val) => Interop.mkMesh3dAttr("z", new[]{val});
        /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> z(IEnumerable<float> values) => Interop.mkMesh3dAttr("z", values.ToArray());
        /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> z(int val) => Interop.mkMesh3dAttr("z", new[]{val});
        /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> z(IEnumerable<int> values) => Interop.mkMesh3dAttr("z", values.ToArray());
        /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> z(string val) => Interop.mkMesh3dAttr("z", new[]{val});
        /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> z(IEnumerable<string> values) => Interop.mkMesh3dAttr("z", values.ToArray());
        /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> z(IEnumerable<bool[]> values) => Interop.mkMesh3dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> z(List<bool[]> values) => Interop.mkMesh3dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> z(params bool[][] values) => Interop.mkMesh3dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> z(IEnumerable<IEnumerable<string>> values) => Interop.mkMesh3dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> z(List<string[]> values) => Interop.mkMesh3dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> z(params string[][] values) => Interop.mkMesh3dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> z(IEnumerable<IEnumerable<int>> values) => Interop.mkMesh3dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> z(List<int[]> values) => Interop.mkMesh3dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> z(params int[][] values) => Interop.mkMesh3dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> z(IEnumerable<IEnumerable<float>> values) => Interop.mkMesh3dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> z(List<float[]> values) => Interop.mkMesh3dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> z(params float[][] values) => Interop.mkMesh3dAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> z(Literals.PlotData[] values) => Interop.mkMesh3dAttr("z", values);
        /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> z(IEnumerable<bool?> values) => Interop.mkMesh3dAttr("z", values.ToArray());
        /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> z(IEnumerable<System.DateTime?> values) => Interop.mkMesh3dAttr("z", values.ToArray());
        /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> z(IEnumerable<int?> values) => Interop.mkMesh3dAttr("z", values.ToArray());
        /// Sets the Z coordinates of the vertices. The nth element of vectors `x`, `y` and `z` jointly represent the X, Y and Z coordinates of the nth vertex.
        public static Box<IMesh3dProperty> z(IEnumerable<float?> values) => Interop.mkMesh3dAttr("z", values.ToArray());
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
        public static Box<IMesh3dProperty> i(bool val) => Interop.mkMesh3dAttr("i", new[]{val});
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
        public static Box<IMesh3dProperty> i(params bool[] values) => Interop.mkMesh3dAttr("i", values);
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
        public static Box<IMesh3dProperty> i(System.DateTime val) => Interop.mkMesh3dAttr("i", new[]{val});
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
        public static Box<IMesh3dProperty> i(params System.DateTime[] values) => Interop.mkMesh3dAttr("i", values);
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
        public static Box<IMesh3dProperty> i(float val) => Interop.mkMesh3dAttr("i", new[]{val});
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
        public static Box<IMesh3dProperty> i(params float[] values) => Interop.mkMesh3dAttr("i", values);
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
        public static Box<IMesh3dProperty> i(int val) => Interop.mkMesh3dAttr("i", new[]{val});
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
        public static Box<IMesh3dProperty> i(params int[] values) => Interop.mkMesh3dAttr("i", values);
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
        public static Box<IMesh3dProperty> i(string val) => Interop.mkMesh3dAttr("i", new[]{val});
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
        public static Box<IMesh3dProperty> i(params string[] values) => Interop.mkMesh3dAttr("i", values);
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
        public static Box<IMesh3dProperty> i(IEnumerable<bool[]> values) => Interop.mkMesh3dAttr("i", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
        public static Box<IMesh3dProperty> i(List<bool[]> values) => Interop.mkMesh3dAttr("i", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
        public static Box<IMesh3dProperty> i(params bool[][] values) => Interop.mkMesh3dAttr("i", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
        public static Box<IMesh3dProperty> i(IEnumerable<IEnumerable<string>> values) => Interop.mkMesh3dAttr("i", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
        public static Box<IMesh3dProperty> i(List<string[]> values) => Interop.mkMesh3dAttr("i", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
        public static Box<IMesh3dProperty> i(params string[][] values) => Interop.mkMesh3dAttr("i", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
        public static Box<IMesh3dProperty> i(IEnumerable<IEnumerable<int>> values) => Interop.mkMesh3dAttr("i", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
        public static Box<IMesh3dProperty> i(List<int[]> values) => Interop.mkMesh3dAttr("i", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
        public static Box<IMesh3dProperty> i(params int[][] values) => Interop.mkMesh3dAttr("i", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
        public static Box<IMesh3dProperty> i(IEnumerable<IEnumerable<float>> values) => Interop.mkMesh3dAttr("i", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
        public static Box<IMesh3dProperty> i(List<float[]> values) => Interop.mkMesh3dAttr("i", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
        public static Box<IMesh3dProperty> i(params float[][] values) => Interop.mkMesh3dAttr("i", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
        public static Box<IMesh3dProperty> i(Literals.PlotData[] values) => Interop.mkMesh3dAttr("i", values);
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
        public static Box<IMesh3dProperty> i(IEnumerable<bool?> values) => Interop.mkMesh3dAttr("i", values.ToArray());
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
        public static Box<IMesh3dProperty> i(IEnumerable<System.DateTime?> values) => Interop.mkMesh3dAttr("i", values.ToArray());
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
        public static Box<IMesh3dProperty> i(IEnumerable<int?> values) => Interop.mkMesh3dAttr("i", values.ToArray());
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *first* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `i[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `i` represents a point in space, which is the first vertex of a triangle.
        public static Box<IMesh3dProperty> i(IEnumerable<float?> values) => Interop.mkMesh3dAttr("i", values.ToArray());
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
        public static Box<IMesh3dProperty> j(bool val) => Interop.mkMesh3dAttr("j", new[]{val});
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
        public static Box<IMesh3dProperty> j(params bool[] values) => Interop.mkMesh3dAttr("j", values);
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
        public static Box<IMesh3dProperty> j(System.DateTime val) => Interop.mkMesh3dAttr("j", new[]{val});
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
        public static Box<IMesh3dProperty> j(params System.DateTime[] values) => Interop.mkMesh3dAttr("j", values);
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
        public static Box<IMesh3dProperty> j(float val) => Interop.mkMesh3dAttr("j", new[]{val});
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
        public static Box<IMesh3dProperty> j(params float[] values) => Interop.mkMesh3dAttr("j", values);
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
        public static Box<IMesh3dProperty> j(int val) => Interop.mkMesh3dAttr("j", new[]{val});
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
        public static Box<IMesh3dProperty> j(params int[] values) => Interop.mkMesh3dAttr("j", values);
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
        public static Box<IMesh3dProperty> j(string val) => Interop.mkMesh3dAttr("j", new[]{val});
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
        public static Box<IMesh3dProperty> j(params string[] values) => Interop.mkMesh3dAttr("j", values);
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
        public static Box<IMesh3dProperty> j(IEnumerable<bool[]> values) => Interop.mkMesh3dAttr("j", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
        public static Box<IMesh3dProperty> j(List<bool[]> values) => Interop.mkMesh3dAttr("j", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
        public static Box<IMesh3dProperty> j(params bool[][] values) => Interop.mkMesh3dAttr("j", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
        public static Box<IMesh3dProperty> j(IEnumerable<IEnumerable<string>> values) => Interop.mkMesh3dAttr("j", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
        public static Box<IMesh3dProperty> j(List<string[]> values) => Interop.mkMesh3dAttr("j", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
        public static Box<IMesh3dProperty> j(params string[][] values) => Interop.mkMesh3dAttr("j", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
        public static Box<IMesh3dProperty> j(IEnumerable<IEnumerable<int>> values) => Interop.mkMesh3dAttr("j", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
        public static Box<IMesh3dProperty> j(List<int[]> values) => Interop.mkMesh3dAttr("j", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
        public static Box<IMesh3dProperty> j(params int[][] values) => Interop.mkMesh3dAttr("j", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
        public static Box<IMesh3dProperty> j(IEnumerable<IEnumerable<float>> values) => Interop.mkMesh3dAttr("j", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
        public static Box<IMesh3dProperty> j(List<float[]> values) => Interop.mkMesh3dAttr("j", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
        public static Box<IMesh3dProperty> j(params float[][] values) => Interop.mkMesh3dAttr("j", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
        public static Box<IMesh3dProperty> j(Literals.PlotData[] values) => Interop.mkMesh3dAttr("j", values);
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
        public static Box<IMesh3dProperty> j(IEnumerable<bool?> values) => Interop.mkMesh3dAttr("j", values.ToArray());
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
        public static Box<IMesh3dProperty> j(IEnumerable<System.DateTime?> values) => Interop.mkMesh3dAttr("j", values.ToArray());
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
        public static Box<IMesh3dProperty> j(IEnumerable<int?> values) => Interop.mkMesh3dAttr("j", values.ToArray());
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *second* vertex of a triangle. For example, `{i[m], j[m], k[m]}`  together represent face m (triangle m) in the mesh, where `j[m] = n` points to the triplet `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `j` represents a point in space, which is the second vertex of a triangle.
        public static Box<IMesh3dProperty> j(IEnumerable<float?> values) => Interop.mkMesh3dAttr("j", values.ToArray());
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
        public static Box<IMesh3dProperty> k(bool val) => Interop.mkMesh3dAttr("k", new[]{val});
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
        public static Box<IMesh3dProperty> k(params bool[] values) => Interop.mkMesh3dAttr("k", values);
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
        public static Box<IMesh3dProperty> k(System.DateTime val) => Interop.mkMesh3dAttr("k", new[]{val});
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
        public static Box<IMesh3dProperty> k(params System.DateTime[] values) => Interop.mkMesh3dAttr("k", values);
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
        public static Box<IMesh3dProperty> k(float val) => Interop.mkMesh3dAttr("k", new[]{val});
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
        public static Box<IMesh3dProperty> k(params float[] values) => Interop.mkMesh3dAttr("k", values);
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
        public static Box<IMesh3dProperty> k(int val) => Interop.mkMesh3dAttr("k", new[]{val});
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
        public static Box<IMesh3dProperty> k(params int[] values) => Interop.mkMesh3dAttr("k", values);
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
        public static Box<IMesh3dProperty> k(string val) => Interop.mkMesh3dAttr("k", new[]{val});
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
        public static Box<IMesh3dProperty> k(params string[] values) => Interop.mkMesh3dAttr("k", values);
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
        public static Box<IMesh3dProperty> k(IEnumerable<bool[]> values) => Interop.mkMesh3dAttr("k", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
        public static Box<IMesh3dProperty> k(List<bool[]> values) => Interop.mkMesh3dAttr("k", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
        public static Box<IMesh3dProperty> k(params bool[][] values) => Interop.mkMesh3dAttr("k", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
        public static Box<IMesh3dProperty> k(IEnumerable<IEnumerable<string>> values) => Interop.mkMesh3dAttr("k", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
        public static Box<IMesh3dProperty> k(List<string[]> values) => Interop.mkMesh3dAttr("k", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
        public static Box<IMesh3dProperty> k(params string[][] values) => Interop.mkMesh3dAttr("k", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
        public static Box<IMesh3dProperty> k(IEnumerable<IEnumerable<int>> values) => Interop.mkMesh3dAttr("k", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
        public static Box<IMesh3dProperty> k(List<int[]> values) => Interop.mkMesh3dAttr("k", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
        public static Box<IMesh3dProperty> k(params int[][] values) => Interop.mkMesh3dAttr("k", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
        public static Box<IMesh3dProperty> k(IEnumerable<IEnumerable<float>> values) => Interop.mkMesh3dAttr("k", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
        public static Box<IMesh3dProperty> k(List<float[]> values) => Interop.mkMesh3dAttr("k", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
        public static Box<IMesh3dProperty> k(params float[][] values) => Interop.mkMesh3dAttr("k", Bindings.flatten2DArrayIf1D(values));
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
        public static Box<IMesh3dProperty> k(Literals.PlotData[] values) => Interop.mkMesh3dAttr("k", values);
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
        public static Box<IMesh3dProperty> k(IEnumerable<bool?> values) => Interop.mkMesh3dAttr("k", values.ToArray());
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
        public static Box<IMesh3dProperty> k(IEnumerable<System.DateTime?> values) => Interop.mkMesh3dAttr("k", values.ToArray());
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
        public static Box<IMesh3dProperty> k(IEnumerable<int?> values) => Interop.mkMesh3dAttr("k", values.ToArray());
        /// A vector of vertex indices, i.e. integer values between 0 and the length of the vertex vectors, representing the *third* vertex of a triangle. For example, `{i[m], j[m], k[m]}` together represent face m (triangle m) in the mesh, where `k[m] = n` points to the triplet  `{x[n], y[n], z[n]}` in the vertex arrays. Therefore, each element in `k` represents a point in space, which is the third vertex of a triangle.
        public static Box<IMesh3dProperty> k(IEnumerable<float?> values) => Interop.mkMesh3dAttr("k", values.ToArray());
        /// Sets the text elements associated with the vertices. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IMesh3dProperty> text(string val) => Interop.mkMesh3dAttr("text", val);
        /// Sets the text elements associated with the vertices. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IMesh3dProperty> text(IEnumerable<string> values) => Interop.mkMesh3dAttr("text", values.ToArray());
        /// Same as `text`.
        public static Box<IMesh3dProperty> hovertext(string val) => Interop.mkMesh3dAttr("hovertext", val);
        /// Same as `text`.
        public static Box<IMesh3dProperty> hovertext(IEnumerable<string> values) => Interop.mkMesh3dAttr("hovertext", values.ToArray());
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IMesh3dProperty> hovertemplate(string val) => Interop.mkMesh3dAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IMesh3dProperty> hovertemplate(IEnumerable<string> values) => Interop.mkMesh3dAttr("hovertemplate", values.ToArray());
        /// Determines how the mesh surface triangles are derived from the set of vertices (points) represented by the `x`, `y` and `z` arrays, if the `i`, `j`, `k` arrays are not supplied. For general use of `mesh3d` it is preferred that `i`, `j`, `k` are supplied. If *-1*, Delaunay triangulation is used, which is mainly suitable if the mesh is a single, more or less layer surface that is perpendicular to `delaunayaxis`. In case the `delaunayaxis` intersects the mesh surface at more than one point it will result triangles that are very long in the dimension of `delaunayaxis`. If *>0*, the alpha-shape algorithm is used. In this case, the positive `alphahull` value signals the use of the alpha-shape algorithm, _and_ its value acts as the parameter for the mesh fitting. If *0*,  the convex-hull algorithm is used. It is suitable for convex bodies or if the intention is to enclose the `x`, `y` and `z` point set into a convex hull.
        public static Box<IMesh3dProperty> alphahull(int val) => Interop.mkMesh3dAttr("alphahull", val);
        /// Determines how the mesh surface triangles are derived from the set of vertices (points) represented by the `x`, `y` and `z` arrays, if the `i`, `j`, `k` arrays are not supplied. For general use of `mesh3d` it is preferred that `i`, `j`, `k` are supplied. If *-1*, Delaunay triangulation is used, which is mainly suitable if the mesh is a single, more or less layer surface that is perpendicular to `delaunayaxis`. In case the `delaunayaxis` intersects the mesh surface at more than one point it will result triangles that are very long in the dimension of `delaunayaxis`. If *>0*, the alpha-shape algorithm is used. In this case, the positive `alphahull` value signals the use of the alpha-shape algorithm, _and_ its value acts as the parameter for the mesh fitting. If *0*,  the convex-hull algorithm is used. It is suitable for convex bodies or if the intention is to enclose the `x`, `y` and `z` point set into a convex hull.
        public static Box<IMesh3dProperty> alphahull(float val) => Interop.mkMesh3dAttr("alphahull", val);
        /// Sets the intensity values for vertices or cells as defined by `intensitymode`. It can be used for plotting fields on meshes.
        public static Box<IMesh3dProperty> intensity(bool val) => Interop.mkMesh3dAttr("intensity", new[]{val});
        /// Sets the intensity values for vertices or cells as defined by `intensitymode`. It can be used for plotting fields on meshes.
        public static Box<IMesh3dProperty> intensity(params bool[] values) => Interop.mkMesh3dAttr("intensity", values);
        /// Sets the intensity values for vertices or cells as defined by `intensitymode`. It can be used for plotting fields on meshes.
        public static Box<IMesh3dProperty> intensity(System.DateTime val) => Interop.mkMesh3dAttr("intensity", new[]{val});
        /// Sets the intensity values for vertices or cells as defined by `intensitymode`. It can be used for plotting fields on meshes.
        public static Box<IMesh3dProperty> intensity(params System.DateTime[] values) => Interop.mkMesh3dAttr("intensity", values);
        /// Sets the intensity values for vertices or cells as defined by `intensitymode`. It can be used for plotting fields on meshes.
        public static Box<IMesh3dProperty> intensity(float val) => Interop.mkMesh3dAttr("intensity", new[]{val});
        /// Sets the intensity values for vertices or cells as defined by `intensitymode`. It can be used for plotting fields on meshes.
        public static Box<IMesh3dProperty> intensity(params float[] values) => Interop.mkMesh3dAttr("intensity", values);
        /// Sets the intensity values for vertices or cells as defined by `intensitymode`. It can be used for plotting fields on meshes.
        public static Box<IMesh3dProperty> intensity(int val) => Interop.mkMesh3dAttr("intensity", new[]{val});
        /// Sets the intensity values for vertices or cells as defined by `intensitymode`. It can be used for plotting fields on meshes.
        public static Box<IMesh3dProperty> intensity(params int[] values) => Interop.mkMesh3dAttr("intensity", values);
        /// Sets the intensity values for vertices or cells as defined by `intensitymode`. It can be used for plotting fields on meshes.
        public static Box<IMesh3dProperty> intensity(string val) => Interop.mkMesh3dAttr("intensity", new[]{val});
        /// Sets the intensity values for vertices or cells as defined by `intensitymode`. It can be used for plotting fields on meshes.
        public static Box<IMesh3dProperty> intensity(params string[] values) => Interop.mkMesh3dAttr("intensity", values);
        /// Sets the intensity values for vertices or cells as defined by `intensitymode`. It can be used for plotting fields on meshes.
        public static Box<IMesh3dProperty> intensity(IEnumerable<bool[]> values) => Interop.mkMesh3dAttr("intensity", Bindings.flatten2DArrayIf1D(values));
        /// Sets the intensity values for vertices or cells as defined by `intensitymode`. It can be used for plotting fields on meshes.
        public static Box<IMesh3dProperty> intensity(List<bool[]> values) => Interop.mkMesh3dAttr("intensity", Bindings.flatten2DArrayIf1D(values));
        /// Sets the intensity values for vertices or cells as defined by `intensitymode`. It can be used for plotting fields on meshes.
        public static Box<IMesh3dProperty> intensity(params bool[][] values) => Interop.mkMesh3dAttr("intensity", Bindings.flatten2DArrayIf1D(values));
        /// Sets the intensity values for vertices or cells as defined by `intensitymode`. It can be used for plotting fields on meshes.
        public static Box<IMesh3dProperty> intensity(IEnumerable<IEnumerable<string>> values) => Interop.mkMesh3dAttr("intensity", Bindings.flatten2DArrayIf1D(values));
        /// Sets the intensity values for vertices or cells as defined by `intensitymode`. It can be used for plotting fields on meshes.
        public static Box<IMesh3dProperty> intensity(List<string[]> values) => Interop.mkMesh3dAttr("intensity", Bindings.flatten2DArrayIf1D(values));
        /// Sets the intensity values for vertices or cells as defined by `intensitymode`. It can be used for plotting fields on meshes.
        public static Box<IMesh3dProperty> intensity(params string[][] values) => Interop.mkMesh3dAttr("intensity", Bindings.flatten2DArrayIf1D(values));
        /// Sets the intensity values for vertices or cells as defined by `intensitymode`. It can be used for plotting fields on meshes.
        public static Box<IMesh3dProperty> intensity(IEnumerable<IEnumerable<int>> values) => Interop.mkMesh3dAttr("intensity", Bindings.flatten2DArrayIf1D(values));
        /// Sets the intensity values for vertices or cells as defined by `intensitymode`. It can be used for plotting fields on meshes.
        public static Box<IMesh3dProperty> intensity(List<int[]> values) => Interop.mkMesh3dAttr("intensity", Bindings.flatten2DArrayIf1D(values));
        /// Sets the intensity values for vertices or cells as defined by `intensitymode`. It can be used for plotting fields on meshes.
        public static Box<IMesh3dProperty> intensity(params int[][] values) => Interop.mkMesh3dAttr("intensity", Bindings.flatten2DArrayIf1D(values));
        /// Sets the intensity values for vertices or cells as defined by `intensitymode`. It can be used for plotting fields on meshes.
        public static Box<IMesh3dProperty> intensity(IEnumerable<IEnumerable<float>> values) => Interop.mkMesh3dAttr("intensity", Bindings.flatten2DArrayIf1D(values));
        /// Sets the intensity values for vertices or cells as defined by `intensitymode`. It can be used for plotting fields on meshes.
        public static Box<IMesh3dProperty> intensity(List<float[]> values) => Interop.mkMesh3dAttr("intensity", Bindings.flatten2DArrayIf1D(values));
        /// Sets the intensity values for vertices or cells as defined by `intensitymode`. It can be used for plotting fields on meshes.
        public static Box<IMesh3dProperty> intensity(params float[][] values) => Interop.mkMesh3dAttr("intensity", Bindings.flatten2DArrayIf1D(values));
        /// Sets the intensity values for vertices or cells as defined by `intensitymode`. It can be used for plotting fields on meshes.
        public static Box<IMesh3dProperty> intensity(Literals.PlotData[] values) => Interop.mkMesh3dAttr("intensity", values);
        /// Sets the intensity values for vertices or cells as defined by `intensitymode`. It can be used for plotting fields on meshes.
        public static Box<IMesh3dProperty> intensity(IEnumerable<bool?> values) => Interop.mkMesh3dAttr("intensity", values.ToArray());
        /// Sets the intensity values for vertices or cells as defined by `intensitymode`. It can be used for plotting fields on meshes.
        public static Box<IMesh3dProperty> intensity(IEnumerable<System.DateTime?> values) => Interop.mkMesh3dAttr("intensity", values.ToArray());
        /// Sets the intensity values for vertices or cells as defined by `intensitymode`. It can be used for plotting fields on meshes.
        public static Box<IMesh3dProperty> intensity(IEnumerable<int?> values) => Interop.mkMesh3dAttr("intensity", values.ToArray());
        /// Sets the intensity values for vertices or cells as defined by `intensitymode`. It can be used for plotting fields on meshes.
        public static Box<IMesh3dProperty> intensity(IEnumerable<float?> values) => Interop.mkMesh3dAttr("intensity", values.ToArray());
        /// Sets the color of the whole mesh
        public static Box<IMesh3dProperty> color(string val) => Interop.mkMesh3dAttr("color", val);
        /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
        public static Box<IMesh3dProperty> vertexcolor(bool val) => Interop.mkMesh3dAttr("vertexcolor", new[]{val});
        /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
        public static Box<IMesh3dProperty> vertexcolor(params bool[] values) => Interop.mkMesh3dAttr("vertexcolor", values);
        /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
        public static Box<IMesh3dProperty> vertexcolor(System.DateTime val) => Interop.mkMesh3dAttr("vertexcolor", new[]{val});
        /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
        public static Box<IMesh3dProperty> vertexcolor(params System.DateTime[] values) => Interop.mkMesh3dAttr("vertexcolor", values);
        /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
        public static Box<IMesh3dProperty> vertexcolor(float val) => Interop.mkMesh3dAttr("vertexcolor", new[]{val});
        /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
        public static Box<IMesh3dProperty> vertexcolor(params float[] values) => Interop.mkMesh3dAttr("vertexcolor", values);
        /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
        public static Box<IMesh3dProperty> vertexcolor(int val) => Interop.mkMesh3dAttr("vertexcolor", new[]{val});
        /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
        public static Box<IMesh3dProperty> vertexcolor(params int[] values) => Interop.mkMesh3dAttr("vertexcolor", values);
        /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
        public static Box<IMesh3dProperty> vertexcolor(string val) => Interop.mkMesh3dAttr("vertexcolor", new[]{val});
        /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
        public static Box<IMesh3dProperty> vertexcolor(params string[] values) => Interop.mkMesh3dAttr("vertexcolor", values);
        /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
        public static Box<IMesh3dProperty> vertexcolor(IEnumerable<bool[]> values) => Interop.mkMesh3dAttr("vertexcolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
        public static Box<IMesh3dProperty> vertexcolor(List<bool[]> values) => Interop.mkMesh3dAttr("vertexcolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
        public static Box<IMesh3dProperty> vertexcolor(params bool[][] values) => Interop.mkMesh3dAttr("vertexcolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
        public static Box<IMesh3dProperty> vertexcolor(IEnumerable<IEnumerable<string>> values) => Interop.mkMesh3dAttr("vertexcolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
        public static Box<IMesh3dProperty> vertexcolor(List<string[]> values) => Interop.mkMesh3dAttr("vertexcolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
        public static Box<IMesh3dProperty> vertexcolor(params string[][] values) => Interop.mkMesh3dAttr("vertexcolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
        public static Box<IMesh3dProperty> vertexcolor(IEnumerable<IEnumerable<int>> values) => Interop.mkMesh3dAttr("vertexcolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
        public static Box<IMesh3dProperty> vertexcolor(List<int[]> values) => Interop.mkMesh3dAttr("vertexcolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
        public static Box<IMesh3dProperty> vertexcolor(params int[][] values) => Interop.mkMesh3dAttr("vertexcolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
        public static Box<IMesh3dProperty> vertexcolor(IEnumerable<IEnumerable<float>> values) => Interop.mkMesh3dAttr("vertexcolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
        public static Box<IMesh3dProperty> vertexcolor(List<float[]> values) => Interop.mkMesh3dAttr("vertexcolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
        public static Box<IMesh3dProperty> vertexcolor(params float[][] values) => Interop.mkMesh3dAttr("vertexcolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
        public static Box<IMesh3dProperty> vertexcolor(Literals.PlotData[] values) => Interop.mkMesh3dAttr("vertexcolor", values);
        /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
        public static Box<IMesh3dProperty> vertexcolor(IEnumerable<bool?> values) => Interop.mkMesh3dAttr("vertexcolor", values.ToArray());
        /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
        public static Box<IMesh3dProperty> vertexcolor(IEnumerable<System.DateTime?> values) => Interop.mkMesh3dAttr("vertexcolor", values.ToArray());
        /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
        public static Box<IMesh3dProperty> vertexcolor(IEnumerable<int?> values) => Interop.mkMesh3dAttr("vertexcolor", values.ToArray());
        /// Sets the color of each vertex Overrides *color*. While Red, green and blue colors are in the range of 0 and 255; in the case of having vertex color data in RGBA format, the alpha color should be normalized to be between 0 and 1.
        public static Box<IMesh3dProperty> vertexcolor(IEnumerable<float?> values) => Interop.mkMesh3dAttr("vertexcolor", values.ToArray());
        /// Sets the color of each face Overrides *color* and *vertexcolor*.
        public static Box<IMesh3dProperty> facecolor(bool val) => Interop.mkMesh3dAttr("facecolor", new[]{val});
        /// Sets the color of each face Overrides *color* and *vertexcolor*.
        public static Box<IMesh3dProperty> facecolor(params bool[] values) => Interop.mkMesh3dAttr("facecolor", values);
        /// Sets the color of each face Overrides *color* and *vertexcolor*.
        public static Box<IMesh3dProperty> facecolor(System.DateTime val) => Interop.mkMesh3dAttr("facecolor", new[]{val});
        /// Sets the color of each face Overrides *color* and *vertexcolor*.
        public static Box<IMesh3dProperty> facecolor(params System.DateTime[] values) => Interop.mkMesh3dAttr("facecolor", values);
        /// Sets the color of each face Overrides *color* and *vertexcolor*.
        public static Box<IMesh3dProperty> facecolor(float val) => Interop.mkMesh3dAttr("facecolor", new[]{val});
        /// Sets the color of each face Overrides *color* and *vertexcolor*.
        public static Box<IMesh3dProperty> facecolor(params float[] values) => Interop.mkMesh3dAttr("facecolor", values);
        /// Sets the color of each face Overrides *color* and *vertexcolor*.
        public static Box<IMesh3dProperty> facecolor(int val) => Interop.mkMesh3dAttr("facecolor", new[]{val});
        /// Sets the color of each face Overrides *color* and *vertexcolor*.
        public static Box<IMesh3dProperty> facecolor(params int[] values) => Interop.mkMesh3dAttr("facecolor", values);
        /// Sets the color of each face Overrides *color* and *vertexcolor*.
        public static Box<IMesh3dProperty> facecolor(string val) => Interop.mkMesh3dAttr("facecolor", new[]{val});
        /// Sets the color of each face Overrides *color* and *vertexcolor*.
        public static Box<IMesh3dProperty> facecolor(params string[] values) => Interop.mkMesh3dAttr("facecolor", values);
        /// Sets the color of each face Overrides *color* and *vertexcolor*.
        public static Box<IMesh3dProperty> facecolor(IEnumerable<bool[]> values) => Interop.mkMesh3dAttr("facecolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each face Overrides *color* and *vertexcolor*.
        public static Box<IMesh3dProperty> facecolor(List<bool[]> values) => Interop.mkMesh3dAttr("facecolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each face Overrides *color* and *vertexcolor*.
        public static Box<IMesh3dProperty> facecolor(params bool[][] values) => Interop.mkMesh3dAttr("facecolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each face Overrides *color* and *vertexcolor*.
        public static Box<IMesh3dProperty> facecolor(IEnumerable<IEnumerable<string>> values) => Interop.mkMesh3dAttr("facecolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each face Overrides *color* and *vertexcolor*.
        public static Box<IMesh3dProperty> facecolor(List<string[]> values) => Interop.mkMesh3dAttr("facecolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each face Overrides *color* and *vertexcolor*.
        public static Box<IMesh3dProperty> facecolor(params string[][] values) => Interop.mkMesh3dAttr("facecolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each face Overrides *color* and *vertexcolor*.
        public static Box<IMesh3dProperty> facecolor(IEnumerable<IEnumerable<int>> values) => Interop.mkMesh3dAttr("facecolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each face Overrides *color* and *vertexcolor*.
        public static Box<IMesh3dProperty> facecolor(List<int[]> values) => Interop.mkMesh3dAttr("facecolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each face Overrides *color* and *vertexcolor*.
        public static Box<IMesh3dProperty> facecolor(params int[][] values) => Interop.mkMesh3dAttr("facecolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each face Overrides *color* and *vertexcolor*.
        public static Box<IMesh3dProperty> facecolor(IEnumerable<IEnumerable<float>> values) => Interop.mkMesh3dAttr("facecolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each face Overrides *color* and *vertexcolor*.
        public static Box<IMesh3dProperty> facecolor(List<float[]> values) => Interop.mkMesh3dAttr("facecolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each face Overrides *color* and *vertexcolor*.
        public static Box<IMesh3dProperty> facecolor(params float[][] values) => Interop.mkMesh3dAttr("facecolor", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color of each face Overrides *color* and *vertexcolor*.
        public static Box<IMesh3dProperty> facecolor(Literals.PlotData[] values) => Interop.mkMesh3dAttr("facecolor", values);
        /// Sets the color of each face Overrides *color* and *vertexcolor*.
        public static Box<IMesh3dProperty> facecolor(IEnumerable<bool?> values) => Interop.mkMesh3dAttr("facecolor", values.ToArray());
        /// Sets the color of each face Overrides *color* and *vertexcolor*.
        public static Box<IMesh3dProperty> facecolor(IEnumerable<System.DateTime?> values) => Interop.mkMesh3dAttr("facecolor", values.ToArray());
        /// Sets the color of each face Overrides *color* and *vertexcolor*.
        public static Box<IMesh3dProperty> facecolor(IEnumerable<int?> values) => Interop.mkMesh3dAttr("facecolor", values.ToArray());
        /// Sets the color of each face Overrides *color* and *vertexcolor*.
        public static Box<IMesh3dProperty> facecolor(IEnumerable<float?> values) => Interop.mkMesh3dAttr("facecolor", values.ToArray());
        /// Determines whether or not the color domain is computed with respect to the input data (here `intensity`) or the bounds set in `cmin` and `cmax`  Defaults to `false` when `cmin` and `cmax` are set by the user.
        public static Box<IMesh3dProperty> cauto(bool val) => Interop.mkMesh3dAttr("cauto", val);
        /// Sets the lower bound of the color domain. Value should have the same units as `intensity` and if set, `cmax` must be set as well.
        public static Box<IMesh3dProperty> cmin(int val) => Interop.mkMesh3dAttr("cmin", val);
        /// Sets the lower bound of the color domain. Value should have the same units as `intensity` and if set, `cmax` must be set as well.
        public static Box<IMesh3dProperty> cmin(float val) => Interop.mkMesh3dAttr("cmin", val);
        /// Sets the upper bound of the color domain. Value should have the same units as `intensity` and if set, `cmin` must be set as well.
        public static Box<IMesh3dProperty> cmax(int val) => Interop.mkMesh3dAttr("cmax", val);
        /// Sets the upper bound of the color domain. Value should have the same units as `intensity` and if set, `cmin` must be set as well.
        public static Box<IMesh3dProperty> cmax(float val) => Interop.mkMesh3dAttr("cmax", val);
        /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as `intensity`. Has no effect when `cauto` is `false`.
        public static Box<IMesh3dProperty> cmid(int val) => Interop.mkMesh3dAttr("cmid", val);
        /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as `intensity`. Has no effect when `cauto` is `false`.
        public static Box<IMesh3dProperty> cmid(float val) => Interop.mkMesh3dAttr("cmid", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IMesh3dProperty> colorscale(string val) => Interop.mkMesh3dAttr("colorscale", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IMesh3dProperty> colorscale(List<string[]> values) => Interop.mkMesh3dAttr("colorscale", Bindings.flatten2DArrayIf1D(values));
        /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
        public static Box<IMesh3dProperty> autocolorscale(bool val) => Interop.mkMesh3dAttr("autocolorscale", val);
        /// Reverses the color mapping if true. If true, `cmin` will correspond to the last color in the array and `cmax` will correspond to the first color.
        public static Box<IMesh3dProperty> reversescale(bool val) => Interop.mkMesh3dAttr("reversescale", val);
        /// Determines whether or not a colorbar is displayed for this trace.
        public static Box<IMesh3dProperty> showscale(bool val) => Interop.mkMesh3dAttr("showscale", val);
        public static Box<IMesh3dProperty> colorbar(params Box<IColorbarProperty>[] properties) => Interop.mkMesh3dAttr("colorbar", Bindings.flattenProperties(properties));
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<IMesh3dProperty> coloraxis(int anchorId) => Interop.mkMesh3dAttr("coloraxis", anchorId > 1 ? $"coloraxis{anchorId}" : "");
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<IMesh3dProperty> coloraxis(string val) => Interop.mkMesh3dAttr("coloraxis", val);
        /// Sets the opacity of the surface. Please note that in the case of using high `opacity` values for example a value greater than or equal to 0.5 on two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent surfaces may not perfectly be sorted in depth by the webgl API. This behavior may be improved in the near future and is subject to change.
        public static Box<IMesh3dProperty> opacity(int val) => Interop.mkMesh3dAttr("opacity", val);
        /// Sets the opacity of the surface. Please note that in the case of using high `opacity` values for example a value greater than or equal to 0.5 on two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent surfaces may not perfectly be sorted in depth by the webgl API. This behavior may be improved in the near future and is subject to change.
        public static Box<IMesh3dProperty> opacity(float val) => Interop.mkMesh3dAttr("opacity", val);
        /// Determines whether or not normal smoothing is applied to the meshes, creating meshes with an angular, low-poly look via flat reflections.
        public static Box<IMesh3dProperty> flatshading(bool val) => Interop.mkMesh3dAttr("flatshading", val);
        public static Box<IMesh3dProperty> contour(params Box<IContourProperty>[] properties) => Interop.mkMesh3dAttr("contour", Bindings.flattenProperties(properties));
        public static Box<IMesh3dProperty> lightposition(params Box<ILightpositionProperty>[] properties) => Interop.mkMesh3dAttr("lightposition", Bindings.flattenProperties(properties));
        public static Box<IMesh3dProperty> lighting(params Box<ILightingProperty>[] properties) => Interop.mkMesh3dAttr("lighting", Bindings.flattenProperties(properties));
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IMesh3dProperty> hoverinfo(params Box<IMesh3dProperty>[] properties) => Interop.mkMesh3dAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IMesh3dProperty> showlegend(bool val) => Interop.mkMesh3dAttr("showlegend", val);
        /// Sets a reference between this trace's 3D coordinate system and a 3D scene. If *scene* (the default value), the (x,y,z) coordinates refer to `layout.scene`. If *scene2*, the (x,y,z) coordinates refer to `layout.scene2`, and so on.
        public static Box<IMesh3dProperty> scene(int anchorId) => Interop.mkMesh3dAttr("scene", anchorId > 1 ? $"scene{anchorId}" : "");
        /// Sets a reference between this trace's 3D coordinate system and a 3D scene. If *scene* (the default value), the (x,y,z) coordinates refer to `layout.scene`. If *scene2*, the (x,y,z) coordinates refer to `layout.scene2`, and so on.
        public static Box<IMesh3dProperty> scene(string val) => Interop.mkMesh3dAttr("scene", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IMesh3dProperty> idssrc(string val) => Interop.mkMesh3dAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IMesh3dProperty> customdatasrc(string val) => Interop.mkMesh3dAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IMesh3dProperty> metasrc(string val) => Interop.mkMesh3dAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  x .
        public static Box<IMesh3dProperty> xsrc(string val) => Interop.mkMesh3dAttr("xsrc", val);
        /// Sets the source reference on plot.ly for  y .
        public static Box<IMesh3dProperty> ysrc(string val) => Interop.mkMesh3dAttr("ysrc", val);
        /// Sets the source reference on plot.ly for  z .
        public static Box<IMesh3dProperty> zsrc(string val) => Interop.mkMesh3dAttr("zsrc", val);
        /// Sets the source reference on plot.ly for  i .
        public static Box<IMesh3dProperty> isrc(string val) => Interop.mkMesh3dAttr("isrc", val);
        /// Sets the source reference on plot.ly for  j .
        public static Box<IMesh3dProperty> jsrc(string val) => Interop.mkMesh3dAttr("jsrc", val);
        /// Sets the source reference on plot.ly for  k .
        public static Box<IMesh3dProperty> ksrc(string val) => Interop.mkMesh3dAttr("ksrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IMesh3dProperty> textsrc(string val) => Interop.mkMesh3dAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IMesh3dProperty> hovertextsrc(string val) => Interop.mkMesh3dAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IMesh3dProperty> hovertemplatesrc(string val) => Interop.mkMesh3dAttr("hovertemplatesrc", val);
        /// Sets the source reference on plot.ly for  intensity .
        public static Box<IMesh3dProperty> intensitysrc(string val) => Interop.mkMesh3dAttr("intensitysrc", val);
        /// Sets the source reference on plot.ly for  vertexcolor .
        public static Box<IMesh3dProperty> vertexcolorsrc(string val) => Interop.mkMesh3dAttr("vertexcolorsrc", val);
        /// Sets the source reference on plot.ly for  facecolor .
        public static Box<IMesh3dProperty> facecolorsrc(string val) => Interop.mkMesh3dAttr("facecolorsrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IMesh3dProperty> hoverinfosrc(string val) => Interop.mkMesh3dAttr("hoverinfosrc", val);
    }

    public static partial class Mesh3d
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IMesh3dProperty> legendonly() => Interop.mkMesh3dAttr("visible", "legendonly");
            public static Box<IMesh3dProperty> _false() => Interop.mkMesh3dAttr("visible", false);
            public static Box<IMesh3dProperty> _true() => Interop.mkMesh3dAttr("visible", true);
        }

        /// Sets the Delaunay axis, which is the axis that is perpendicular to the surface of the Delaunay triangulation. It has an effect if `i`, `j`, `k` are not provided and `alphahull` is set to indicate Delaunay triangulation.
        public static partial class Delaunayaxis
        {
            public static Box<IMesh3dProperty> x() => Interop.mkMesh3dAttr("delaunayaxis", "x");
            public static Box<IMesh3dProperty> y() => Interop.mkMesh3dAttr("delaunayaxis", "y");
            public static Box<IMesh3dProperty> z() => Interop.mkMesh3dAttr("delaunayaxis", "z");
        }

        /// Determines the source of `intensity` values.
        public static partial class Intensitymode
        {
            public static Box<IMesh3dProperty> cell() => Interop.mkMesh3dAttr("intensitymode", "cell");
            public static Box<IMesh3dProperty> vertex() => Interop.mkMesh3dAttr("intensitymode", "vertex");
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IMesh3dProperty> all() => Interop.mkMesh3dAttr("hoverinfo", "all");
            public static Box<IMesh3dProperty> none() => Interop.mkMesh3dAttr("hoverinfo", "none");
            public static Box<IMesh3dProperty> skip() => Interop.mkMesh3dAttr("hoverinfo", "skip");
            public static Box<IMesh3dProperty> name() => Interop.mkMesh3dAttr("hoverinfo", "name");
            public static Box<IMesh3dProperty> text() => Interop.mkMesh3dAttr("hoverinfo", "text");
            public static Box<IMesh3dProperty> x() => Interop.mkMesh3dAttr("hoverinfo", "x");
            public static Box<IMesh3dProperty> y() => Interop.mkMesh3dAttr("hoverinfo", "y");
            public static Box<IMesh3dProperty> z() => Interop.mkMesh3dAttr("hoverinfo", "z");
        }

        /// Sets the calendar system to use with `x` date data.
        public static partial class Xcalendar
        {
            public static Box<IMesh3dProperty> chinese() => Interop.mkMesh3dAttr("xcalendar", "chinese");
            public static Box<IMesh3dProperty> coptic() => Interop.mkMesh3dAttr("xcalendar", "coptic");
            public static Box<IMesh3dProperty> discworld() => Interop.mkMesh3dAttr("xcalendar", "discworld");
            public static Box<IMesh3dProperty> ethiopian() => Interop.mkMesh3dAttr("xcalendar", "ethiopian");
            public static Box<IMesh3dProperty> gregorian() => Interop.mkMesh3dAttr("xcalendar", "gregorian");
            public static Box<IMesh3dProperty> hebrew() => Interop.mkMesh3dAttr("xcalendar", "hebrew");
            public static Box<IMesh3dProperty> islamic() => Interop.mkMesh3dAttr("xcalendar", "islamic");
            public static Box<IMesh3dProperty> jalali() => Interop.mkMesh3dAttr("xcalendar", "jalali");
            public static Box<IMesh3dProperty> julian() => Interop.mkMesh3dAttr("xcalendar", "julian");
            public static Box<IMesh3dProperty> mayan() => Interop.mkMesh3dAttr("xcalendar", "mayan");
            public static Box<IMesh3dProperty> nanakshahi() => Interop.mkMesh3dAttr("xcalendar", "nanakshahi");
            public static Box<IMesh3dProperty> nepali() => Interop.mkMesh3dAttr("xcalendar", "nepali");
            public static Box<IMesh3dProperty> persian() => Interop.mkMesh3dAttr("xcalendar", "persian");
            public static Box<IMesh3dProperty> taiwan() => Interop.mkMesh3dAttr("xcalendar", "taiwan");
            public static Box<IMesh3dProperty> thai() => Interop.mkMesh3dAttr("xcalendar", "thai");
            public static Box<IMesh3dProperty> ummalqura() => Interop.mkMesh3dAttr("xcalendar", "ummalqura");
        }

        /// Sets the calendar system to use with `y` date data.
        public static partial class Ycalendar
        {
            public static Box<IMesh3dProperty> chinese() => Interop.mkMesh3dAttr("ycalendar", "chinese");
            public static Box<IMesh3dProperty> coptic() => Interop.mkMesh3dAttr("ycalendar", "coptic");
            public static Box<IMesh3dProperty> discworld() => Interop.mkMesh3dAttr("ycalendar", "discworld");
            public static Box<IMesh3dProperty> ethiopian() => Interop.mkMesh3dAttr("ycalendar", "ethiopian");
            public static Box<IMesh3dProperty> gregorian() => Interop.mkMesh3dAttr("ycalendar", "gregorian");
            public static Box<IMesh3dProperty> hebrew() => Interop.mkMesh3dAttr("ycalendar", "hebrew");
            public static Box<IMesh3dProperty> islamic() => Interop.mkMesh3dAttr("ycalendar", "islamic");
            public static Box<IMesh3dProperty> jalali() => Interop.mkMesh3dAttr("ycalendar", "jalali");
            public static Box<IMesh3dProperty> julian() => Interop.mkMesh3dAttr("ycalendar", "julian");
            public static Box<IMesh3dProperty> mayan() => Interop.mkMesh3dAttr("ycalendar", "mayan");
            public static Box<IMesh3dProperty> nanakshahi() => Interop.mkMesh3dAttr("ycalendar", "nanakshahi");
            public static Box<IMesh3dProperty> nepali() => Interop.mkMesh3dAttr("ycalendar", "nepali");
            public static Box<IMesh3dProperty> persian() => Interop.mkMesh3dAttr("ycalendar", "persian");
            public static Box<IMesh3dProperty> taiwan() => Interop.mkMesh3dAttr("ycalendar", "taiwan");
            public static Box<IMesh3dProperty> thai() => Interop.mkMesh3dAttr("ycalendar", "thai");
            public static Box<IMesh3dProperty> ummalqura() => Interop.mkMesh3dAttr("ycalendar", "ummalqura");
        }

        /// Sets the calendar system to use with `z` date data.
        public static partial class Zcalendar
        {
            public static Box<IMesh3dProperty> chinese() => Interop.mkMesh3dAttr("zcalendar", "chinese");
            public static Box<IMesh3dProperty> coptic() => Interop.mkMesh3dAttr("zcalendar", "coptic");
            public static Box<IMesh3dProperty> discworld() => Interop.mkMesh3dAttr("zcalendar", "discworld");
            public static Box<IMesh3dProperty> ethiopian() => Interop.mkMesh3dAttr("zcalendar", "ethiopian");
            public static Box<IMesh3dProperty> gregorian() => Interop.mkMesh3dAttr("zcalendar", "gregorian");
            public static Box<IMesh3dProperty> hebrew() => Interop.mkMesh3dAttr("zcalendar", "hebrew");
            public static Box<IMesh3dProperty> islamic() => Interop.mkMesh3dAttr("zcalendar", "islamic");
            public static Box<IMesh3dProperty> jalali() => Interop.mkMesh3dAttr("zcalendar", "jalali");
            public static Box<IMesh3dProperty> julian() => Interop.mkMesh3dAttr("zcalendar", "julian");
            public static Box<IMesh3dProperty> mayan() => Interop.mkMesh3dAttr("zcalendar", "mayan");
            public static Box<IMesh3dProperty> nanakshahi() => Interop.mkMesh3dAttr("zcalendar", "nanakshahi");
            public static Box<IMesh3dProperty> nepali() => Interop.mkMesh3dAttr("zcalendar", "nepali");
            public static Box<IMesh3dProperty> persian() => Interop.mkMesh3dAttr("zcalendar", "persian");
            public static Box<IMesh3dProperty> taiwan() => Interop.mkMesh3dAttr("zcalendar", "taiwan");
            public static Box<IMesh3dProperty> thai() => Interop.mkMesh3dAttr("zcalendar", "thai");
            public static Box<IMesh3dProperty> ummalqura() => Interop.mkMesh3dAttr("zcalendar", "ummalqura");
        }
    }
}