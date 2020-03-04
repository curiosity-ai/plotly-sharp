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

    public static partial class Volume
    {
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IVolumeProperty> legendgroup(string val) => Interop.mkVolumeAttr("legendgroup", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IVolumeProperty> name(string val) => Interop.mkVolumeAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IVolumeProperty> uid(string val) => Interop.mkVolumeAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IVolumeProperty> ids(bool val) => Interop.mkVolumeAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IVolumeProperty> ids(params bool[] values) => Interop.mkVolumeAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IVolumeProperty> ids(System.DateTime val) => Interop.mkVolumeAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IVolumeProperty> ids(params System.DateTime[] values) => Interop.mkVolumeAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IVolumeProperty> ids(float val) => Interop.mkVolumeAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IVolumeProperty> ids(params float[] values) => Interop.mkVolumeAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IVolumeProperty> ids(int val) => Interop.mkVolumeAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IVolumeProperty> ids(params int[] values) => Interop.mkVolumeAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IVolumeProperty> ids(string val) => Interop.mkVolumeAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IVolumeProperty> ids(params string[] values) => Interop.mkVolumeAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IVolumeProperty> ids(IEnumerable<bool[]> values) => Interop.mkVolumeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IVolumeProperty> ids(List<bool[]> values) => Interop.mkVolumeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IVolumeProperty> ids(params bool[][] values) => Interop.mkVolumeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IVolumeProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkVolumeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IVolumeProperty> ids(List<string[]> values) => Interop.mkVolumeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IVolumeProperty> ids(params string[][] values) => Interop.mkVolumeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IVolumeProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkVolumeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IVolumeProperty> ids(List<int[]> values) => Interop.mkVolumeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IVolumeProperty> ids(params int[][] values) => Interop.mkVolumeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IVolumeProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkVolumeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IVolumeProperty> ids(List<float[]> values) => Interop.mkVolumeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IVolumeProperty> ids(params float[][] values) => Interop.mkVolumeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IVolumeProperty> ids(Literals.PlotData[] values) => Interop.mkVolumeAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IVolumeProperty> ids(IEnumerable<bool?> values) => Interop.mkVolumeAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IVolumeProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkVolumeAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IVolumeProperty> ids(IEnumerable<int?> values) => Interop.mkVolumeAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IVolumeProperty> ids(IEnumerable<float?> values) => Interop.mkVolumeAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IVolumeProperty> customdata(bool val) => Interop.mkVolumeAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IVolumeProperty> customdata(params bool[] values) => Interop.mkVolumeAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IVolumeProperty> customdata(System.DateTime val) => Interop.mkVolumeAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IVolumeProperty> customdata(params System.DateTime[] values) => Interop.mkVolumeAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IVolumeProperty> customdata(float val) => Interop.mkVolumeAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IVolumeProperty> customdata(params float[] values) => Interop.mkVolumeAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IVolumeProperty> customdata(int val) => Interop.mkVolumeAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IVolumeProperty> customdata(params int[] values) => Interop.mkVolumeAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IVolumeProperty> customdata(string val) => Interop.mkVolumeAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IVolumeProperty> customdata(params string[] values) => Interop.mkVolumeAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IVolumeProperty> customdata(IEnumerable<bool[]> values) => Interop.mkVolumeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IVolumeProperty> customdata(List<bool[]> values) => Interop.mkVolumeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IVolumeProperty> customdata(params bool[][] values) => Interop.mkVolumeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IVolumeProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkVolumeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IVolumeProperty> customdata(List<string[]> values) => Interop.mkVolumeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IVolumeProperty> customdata(params string[][] values) => Interop.mkVolumeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IVolumeProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkVolumeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IVolumeProperty> customdata(List<int[]> values) => Interop.mkVolumeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IVolumeProperty> customdata(params int[][] values) => Interop.mkVolumeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IVolumeProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkVolumeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IVolumeProperty> customdata(List<float[]> values) => Interop.mkVolumeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IVolumeProperty> customdata(params float[][] values) => Interop.mkVolumeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IVolumeProperty> customdata(Literals.PlotData[] values) => Interop.mkVolumeAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IVolumeProperty> customdata(IEnumerable<bool?> values) => Interop.mkVolumeAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IVolumeProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkVolumeAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IVolumeProperty> customdata(IEnumerable<int?> values) => Interop.mkVolumeAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IVolumeProperty> customdata(IEnumerable<float?> values) => Interop.mkVolumeAttr("customdata", values.ToArray());
        public static Box<IVolumeProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkVolumeAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IVolumeProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkVolumeAttr("stream", Bindings.flattenProperties(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IVolumeProperty> uirevision(bool val) => Interop.mkVolumeAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IVolumeProperty> uirevision(params bool[] values) => Interop.mkVolumeAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IVolumeProperty> uirevision(System.DateTime val) => Interop.mkVolumeAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IVolumeProperty> uirevision(params System.DateTime[] values) => Interop.mkVolumeAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IVolumeProperty> uirevision(int val) => Interop.mkVolumeAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IVolumeProperty> uirevision(params int[] values) => Interop.mkVolumeAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IVolumeProperty> uirevision(float val) => Interop.mkVolumeAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IVolumeProperty> uirevision(params float[] values) => Interop.mkVolumeAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IVolumeProperty> uirevision(string val) => Interop.mkVolumeAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IVolumeProperty> uirevision(params string[] values) => Interop.mkVolumeAttr("uirevision", values);
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IVolumeProperty> x(bool val) => Interop.mkVolumeAttr("x", new[]{val});
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IVolumeProperty> x(IEnumerable<bool> values) => Interop.mkVolumeAttr("x", values.ToArray());
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IVolumeProperty> x(System.DateTime val) => Interop.mkVolumeAttr("x", new[]{val});
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IVolumeProperty> x(IEnumerable<System.DateTime> values) => Interop.mkVolumeAttr("x", values.ToArray());
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IVolumeProperty> x(float val) => Interop.mkVolumeAttr("x", new[]{val});
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IVolumeProperty> x(IEnumerable<float> values) => Interop.mkVolumeAttr("x", values.ToArray());
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IVolumeProperty> x(int val) => Interop.mkVolumeAttr("x", new[]{val});
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IVolumeProperty> x(IEnumerable<int> values) => Interop.mkVolumeAttr("x", values.ToArray());
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IVolumeProperty> x(string val) => Interop.mkVolumeAttr("x", new[]{val});
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IVolumeProperty> x(IEnumerable<string> values) => Interop.mkVolumeAttr("x", values.ToArray());
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IVolumeProperty> x(IEnumerable<bool[]> values) => Interop.mkVolumeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IVolumeProperty> x(List<bool[]> values) => Interop.mkVolumeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IVolumeProperty> x(params bool[][] values) => Interop.mkVolumeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IVolumeProperty> x(IEnumerable<IEnumerable<string>> values) => Interop.mkVolumeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IVolumeProperty> x(List<string[]> values) => Interop.mkVolumeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IVolumeProperty> x(params string[][] values) => Interop.mkVolumeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IVolumeProperty> x(IEnumerable<IEnumerable<int>> values) => Interop.mkVolumeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IVolumeProperty> x(List<int[]> values) => Interop.mkVolumeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IVolumeProperty> x(params int[][] values) => Interop.mkVolumeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IVolumeProperty> x(IEnumerable<IEnumerable<float>> values) => Interop.mkVolumeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IVolumeProperty> x(List<float[]> values) => Interop.mkVolumeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IVolumeProperty> x(params float[][] values) => Interop.mkVolumeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IVolumeProperty> x(Literals.PlotData[] values) => Interop.mkVolumeAttr("x", values);
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IVolumeProperty> x(IEnumerable<bool?> values) => Interop.mkVolumeAttr("x", values.ToArray());
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IVolumeProperty> x(IEnumerable<System.DateTime?> values) => Interop.mkVolumeAttr("x", values.ToArray());
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IVolumeProperty> x(IEnumerable<int?> values) => Interop.mkVolumeAttr("x", values.ToArray());
        /// Sets the X coordinates of the vertices on X axis.
        public static Box<IVolumeProperty> x(IEnumerable<float?> values) => Interop.mkVolumeAttr("x", values.ToArray());
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IVolumeProperty> y(bool val) => Interop.mkVolumeAttr("y", new[]{val});
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IVolumeProperty> y(IEnumerable<bool> values) => Interop.mkVolumeAttr("y", values.ToArray());
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IVolumeProperty> y(System.DateTime val) => Interop.mkVolumeAttr("y", new[]{val});
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IVolumeProperty> y(IEnumerable<System.DateTime> values) => Interop.mkVolumeAttr("y", values.ToArray());
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IVolumeProperty> y(float val) => Interop.mkVolumeAttr("y", new[]{val});
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IVolumeProperty> y(IEnumerable<float> values) => Interop.mkVolumeAttr("y", values.ToArray());
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IVolumeProperty> y(int val) => Interop.mkVolumeAttr("y", new[]{val});
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IVolumeProperty> y(IEnumerable<int> values) => Interop.mkVolumeAttr("y", values.ToArray());
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IVolumeProperty> y(string val) => Interop.mkVolumeAttr("y", new[]{val});
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IVolumeProperty> y(IEnumerable<string> values) => Interop.mkVolumeAttr("y", values.ToArray());
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IVolumeProperty> y(IEnumerable<bool[]> values) => Interop.mkVolumeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IVolumeProperty> y(List<bool[]> values) => Interop.mkVolumeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IVolumeProperty> y(params bool[][] values) => Interop.mkVolumeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IVolumeProperty> y(IEnumerable<IEnumerable<string>> values) => Interop.mkVolumeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IVolumeProperty> y(List<string[]> values) => Interop.mkVolumeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IVolumeProperty> y(params string[][] values) => Interop.mkVolumeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IVolumeProperty> y(IEnumerable<IEnumerable<int>> values) => Interop.mkVolumeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IVolumeProperty> y(List<int[]> values) => Interop.mkVolumeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IVolumeProperty> y(params int[][] values) => Interop.mkVolumeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IVolumeProperty> y(IEnumerable<IEnumerable<float>> values) => Interop.mkVolumeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IVolumeProperty> y(List<float[]> values) => Interop.mkVolumeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IVolumeProperty> y(params float[][] values) => Interop.mkVolumeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IVolumeProperty> y(Literals.PlotData[] values) => Interop.mkVolumeAttr("y", values);
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IVolumeProperty> y(IEnumerable<bool?> values) => Interop.mkVolumeAttr("y", values.ToArray());
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IVolumeProperty> y(IEnumerable<System.DateTime?> values) => Interop.mkVolumeAttr("y", values.ToArray());
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IVolumeProperty> y(IEnumerable<int?> values) => Interop.mkVolumeAttr("y", values.ToArray());
        /// Sets the Y coordinates of the vertices on Y axis.
        public static Box<IVolumeProperty> y(IEnumerable<float?> values) => Interop.mkVolumeAttr("y", values.ToArray());
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IVolumeProperty> z(bool val) => Interop.mkVolumeAttr("z", new[]{val});
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IVolumeProperty> z(IEnumerable<bool> values) => Interop.mkVolumeAttr("z", values.ToArray());
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IVolumeProperty> z(System.DateTime val) => Interop.mkVolumeAttr("z", new[]{val});
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IVolumeProperty> z(IEnumerable<System.DateTime> values) => Interop.mkVolumeAttr("z", values.ToArray());
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IVolumeProperty> z(float val) => Interop.mkVolumeAttr("z", new[]{val});
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IVolumeProperty> z(IEnumerable<float> values) => Interop.mkVolumeAttr("z", values.ToArray());
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IVolumeProperty> z(int val) => Interop.mkVolumeAttr("z", new[]{val});
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IVolumeProperty> z(IEnumerable<int> values) => Interop.mkVolumeAttr("z", values.ToArray());
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IVolumeProperty> z(string val) => Interop.mkVolumeAttr("z", new[]{val});
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IVolumeProperty> z(IEnumerable<string> values) => Interop.mkVolumeAttr("z", values.ToArray());
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IVolumeProperty> z(IEnumerable<bool[]> values) => Interop.mkVolumeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IVolumeProperty> z(List<bool[]> values) => Interop.mkVolumeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IVolumeProperty> z(params bool[][] values) => Interop.mkVolumeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IVolumeProperty> z(IEnumerable<IEnumerable<string>> values) => Interop.mkVolumeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IVolumeProperty> z(List<string[]> values) => Interop.mkVolumeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IVolumeProperty> z(params string[][] values) => Interop.mkVolumeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IVolumeProperty> z(IEnumerable<IEnumerable<int>> values) => Interop.mkVolumeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IVolumeProperty> z(List<int[]> values) => Interop.mkVolumeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IVolumeProperty> z(params int[][] values) => Interop.mkVolumeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IVolumeProperty> z(IEnumerable<IEnumerable<float>> values) => Interop.mkVolumeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IVolumeProperty> z(List<float[]> values) => Interop.mkVolumeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IVolumeProperty> z(params float[][] values) => Interop.mkVolumeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IVolumeProperty> z(Literals.PlotData[] values) => Interop.mkVolumeAttr("z", values);
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IVolumeProperty> z(IEnumerable<bool?> values) => Interop.mkVolumeAttr("z", values.ToArray());
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IVolumeProperty> z(IEnumerable<System.DateTime?> values) => Interop.mkVolumeAttr("z", values.ToArray());
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IVolumeProperty> z(IEnumerable<int?> values) => Interop.mkVolumeAttr("z", values.ToArray());
        /// Sets the Z coordinates of the vertices on Z axis.
        public static Box<IVolumeProperty> z(IEnumerable<float?> values) => Interop.mkVolumeAttr("z", values.ToArray());
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IVolumeProperty> value(bool val) => Interop.mkVolumeAttr("value", new[]{val});
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IVolumeProperty> value(IEnumerable<bool> values) => Interop.mkVolumeAttr("value", values.ToArray());
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IVolumeProperty> value(System.DateTime val) => Interop.mkVolumeAttr("value", new[]{val});
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IVolumeProperty> value(IEnumerable<System.DateTime> values) => Interop.mkVolumeAttr("value", values.ToArray());
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IVolumeProperty> value(float val) => Interop.mkVolumeAttr("value", new[]{val});
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IVolumeProperty> value(IEnumerable<float> values) => Interop.mkVolumeAttr("value", values.ToArray());
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IVolumeProperty> value(int val) => Interop.mkVolumeAttr("value", new[]{val});
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IVolumeProperty> value(IEnumerable<int> values) => Interop.mkVolumeAttr("value", values.ToArray());
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IVolumeProperty> value(string val) => Interop.mkVolumeAttr("value", new[]{val});
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IVolumeProperty> value(IEnumerable<string> values) => Interop.mkVolumeAttr("value", values.ToArray());
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IVolumeProperty> value(IEnumerable<bool[]> values) => Interop.mkVolumeAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IVolumeProperty> value(List<bool[]> values) => Interop.mkVolumeAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IVolumeProperty> value(params bool[][] values) => Interop.mkVolumeAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IVolumeProperty> value(IEnumerable<IEnumerable<string>> values) => Interop.mkVolumeAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IVolumeProperty> value(List<string[]> values) => Interop.mkVolumeAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IVolumeProperty> value(params string[][] values) => Interop.mkVolumeAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IVolumeProperty> value(IEnumerable<IEnumerable<int>> values) => Interop.mkVolumeAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IVolumeProperty> value(List<int[]> values) => Interop.mkVolumeAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IVolumeProperty> value(params int[][] values) => Interop.mkVolumeAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IVolumeProperty> value(IEnumerable<IEnumerable<float>> values) => Interop.mkVolumeAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IVolumeProperty> value(List<float[]> values) => Interop.mkVolumeAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IVolumeProperty> value(params float[][] values) => Interop.mkVolumeAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IVolumeProperty> value(Literals.PlotData[] values) => Interop.mkVolumeAttr("value", values);
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IVolumeProperty> value(IEnumerable<bool?> values) => Interop.mkVolumeAttr("value", values.ToArray());
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IVolumeProperty> value(IEnumerable<System.DateTime?> values) => Interop.mkVolumeAttr("value", values.ToArray());
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IVolumeProperty> value(IEnumerable<int?> values) => Interop.mkVolumeAttr("value", values.ToArray());
        /// Sets the 4th dimension (value) of the vertices.
        public static Box<IVolumeProperty> value(IEnumerable<float?> values) => Interop.mkVolumeAttr("value", values.ToArray());
        /// Sets the minimum boundary for iso-surface plot.
        public static Box<IVolumeProperty> isomin(int val) => Interop.mkVolumeAttr("isomin", val);
        /// Sets the minimum boundary for iso-surface plot.
        public static Box<IVolumeProperty> isomin(float val) => Interop.mkVolumeAttr("isomin", val);
        /// Sets the maximum boundary for iso-surface plot.
        public static Box<IVolumeProperty> isomax(int val) => Interop.mkVolumeAttr("isomax", val);
        /// Sets the maximum boundary for iso-surface plot.
        public static Box<IVolumeProperty> isomax(float val) => Interop.mkVolumeAttr("isomax", val);
        public static Box<IVolumeProperty> surface(params Box<ISurfaceProperty>[] properties) => Interop.mkVolumeAttr("surface", Bindings.flattenProperties(properties));
        public static Box<IVolumeProperty> spaceframe(params Box<ISpaceframeProperty>[] properties) => Interop.mkVolumeAttr("spaceframe", Bindings.flattenProperties(properties));
        public static Box<IVolumeProperty> slices(params Box<ISlicesProperty>[] properties) => Interop.mkVolumeAttr("slices", Bindings.flattenProperties(properties));
        public static Box<IVolumeProperty> caps(params Box<ICapsProperty>[] properties) => Interop.mkVolumeAttr("caps", Bindings.flattenProperties(properties));
        /// Sets the text elements associated with the vertices. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IVolumeProperty> text(string val) => Interop.mkVolumeAttr("text", val);
        /// Sets the text elements associated with the vertices. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IVolumeProperty> text(IEnumerable<string> values) => Interop.mkVolumeAttr("text", values.ToArray());
        /// Same as `text`.
        public static Box<IVolumeProperty> hovertext(string val) => Interop.mkVolumeAttr("hovertext", val);
        /// Same as `text`.
        public static Box<IVolumeProperty> hovertext(IEnumerable<string> values) => Interop.mkVolumeAttr("hovertext", values.ToArray());
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IVolumeProperty> hovertemplate(string val) => Interop.mkVolumeAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IVolumeProperty> hovertemplate(IEnumerable<string> values) => Interop.mkVolumeAttr("hovertemplate", values.ToArray());
        /// Determines whether or not the color domain is computed with respect to the input data (here `value`) or the bounds set in `cmin` and `cmax`  Defaults to `false` when `cmin` and `cmax` are set by the user.
        public static Box<IVolumeProperty> cauto(bool val) => Interop.mkVolumeAttr("cauto", val);
        /// Sets the lower bound of the color domain. Value should have the same units as `value` and if set, `cmax` must be set as well.
        public static Box<IVolumeProperty> cmin(int val) => Interop.mkVolumeAttr("cmin", val);
        /// Sets the lower bound of the color domain. Value should have the same units as `value` and if set, `cmax` must be set as well.
        public static Box<IVolumeProperty> cmin(float val) => Interop.mkVolumeAttr("cmin", val);
        /// Sets the upper bound of the color domain. Value should have the same units as `value` and if set, `cmin` must be set as well.
        public static Box<IVolumeProperty> cmax(int val) => Interop.mkVolumeAttr("cmax", val);
        /// Sets the upper bound of the color domain. Value should have the same units as `value` and if set, `cmin` must be set as well.
        public static Box<IVolumeProperty> cmax(float val) => Interop.mkVolumeAttr("cmax", val);
        /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as `value`. Has no effect when `cauto` is `false`.
        public static Box<IVolumeProperty> cmid(int val) => Interop.mkVolumeAttr("cmid", val);
        /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as `value`. Has no effect when `cauto` is `false`.
        public static Box<IVolumeProperty> cmid(float val) => Interop.mkVolumeAttr("cmid", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IVolumeProperty> colorscale(string val) => Interop.mkVolumeAttr("colorscale", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IVolumeProperty> colorscale(List<string[]> values) => Interop.mkVolumeAttr("colorscale", Bindings.flatten2DArrayIf1D(values));
        /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
        public static Box<IVolumeProperty> autocolorscale(bool val) => Interop.mkVolumeAttr("autocolorscale", val);
        /// Reverses the color mapping if true. If true, `cmin` will correspond to the last color in the array and `cmax` will correspond to the first color.
        public static Box<IVolumeProperty> reversescale(bool val) => Interop.mkVolumeAttr("reversescale", val);
        /// Determines whether or not a colorbar is displayed for this trace.
        public static Box<IVolumeProperty> showscale(bool val) => Interop.mkVolumeAttr("showscale", val);
        public static Box<IVolumeProperty> colorbar(params Box<IColorbarProperty>[] properties) => Interop.mkVolumeAttr("colorbar", Bindings.flattenProperties(properties));
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<IVolumeProperty> coloraxis(int anchorId) => Interop.mkVolumeAttr("coloraxis", anchorId > 1 ? $"coloraxis{anchorId}" : "");
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<IVolumeProperty> coloraxis(string val) => Interop.mkVolumeAttr("coloraxis", val);
        /// Sets the opacity of the surface. Please note that in the case of using high `opacity` values for example a value greater than or equal to 0.5 on two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent surfaces may not perfectly be sorted in depth by the webgl API. This behavior may be improved in the near future and is subject to change.
        public static Box<IVolumeProperty> opacity(int val) => Interop.mkVolumeAttr("opacity", val);
        /// Sets the opacity of the surface. Please note that in the case of using high `opacity` values for example a value greater than or equal to 0.5 on two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent surfaces may not perfectly be sorted in depth by the webgl API. This behavior may be improved in the near future and is subject to change.
        public static Box<IVolumeProperty> opacity(float val) => Interop.mkVolumeAttr("opacity", val);
        /// Sets the opacityscale. The opacityscale must be an array containing arrays mapping a normalized value to an opacity value. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 1], [0.5, 0.2], [1, 1]]` means that higher/lower values would have higher opacity values and those in the middle would be more transparent Alternatively, `opacityscale` may be a palette name string of the following list: 'min', 'max', 'extremes' and 'uniform'. The default is 'uniform'.
        public static Box<IVolumeProperty> opacityscale(bool val) => Interop.mkVolumeAttr("opacityscale", val);
        /// Sets the opacityscale. The opacityscale must be an array containing arrays mapping a normalized value to an opacity value. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 1], [0.5, 0.2], [1, 1]]` means that higher/lower values would have higher opacity values and those in the middle would be more transparent Alternatively, `opacityscale` may be a palette name string of the following list: 'min', 'max', 'extremes' and 'uniform'. The default is 'uniform'.
        public static Box<IVolumeProperty> opacityscale(params bool[] values) => Interop.mkVolumeAttr("opacityscale", values);
        /// Sets the opacityscale. The opacityscale must be an array containing arrays mapping a normalized value to an opacity value. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 1], [0.5, 0.2], [1, 1]]` means that higher/lower values would have higher opacity values and those in the middle would be more transparent Alternatively, `opacityscale` may be a palette name string of the following list: 'min', 'max', 'extremes' and 'uniform'. The default is 'uniform'.
        public static Box<IVolumeProperty> opacityscale(System.DateTime val) => Interop.mkVolumeAttr("opacityscale", val);
        /// Sets the opacityscale. The opacityscale must be an array containing arrays mapping a normalized value to an opacity value. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 1], [0.5, 0.2], [1, 1]]` means that higher/lower values would have higher opacity values and those in the middle would be more transparent Alternatively, `opacityscale` may be a palette name string of the following list: 'min', 'max', 'extremes' and 'uniform'. The default is 'uniform'.
        public static Box<IVolumeProperty> opacityscale(params System.DateTime[] values) => Interop.mkVolumeAttr("opacityscale", values);
        /// Sets the opacityscale. The opacityscale must be an array containing arrays mapping a normalized value to an opacity value. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 1], [0.5, 0.2], [1, 1]]` means that higher/lower values would have higher opacity values and those in the middle would be more transparent Alternatively, `opacityscale` may be a palette name string of the following list: 'min', 'max', 'extremes' and 'uniform'. The default is 'uniform'.
        public static Box<IVolumeProperty> opacityscale(int val) => Interop.mkVolumeAttr("opacityscale", val);
        /// Sets the opacityscale. The opacityscale must be an array containing arrays mapping a normalized value to an opacity value. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 1], [0.5, 0.2], [1, 1]]` means that higher/lower values would have higher opacity values and those in the middle would be more transparent Alternatively, `opacityscale` may be a palette name string of the following list: 'min', 'max', 'extremes' and 'uniform'. The default is 'uniform'.
        public static Box<IVolumeProperty> opacityscale(params int[] values) => Interop.mkVolumeAttr("opacityscale", values);
        /// Sets the opacityscale. The opacityscale must be an array containing arrays mapping a normalized value to an opacity value. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 1], [0.5, 0.2], [1, 1]]` means that higher/lower values would have higher opacity values and those in the middle would be more transparent Alternatively, `opacityscale` may be a palette name string of the following list: 'min', 'max', 'extremes' and 'uniform'. The default is 'uniform'.
        public static Box<IVolumeProperty> opacityscale(float val) => Interop.mkVolumeAttr("opacityscale", val);
        /// Sets the opacityscale. The opacityscale must be an array containing arrays mapping a normalized value to an opacity value. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 1], [0.5, 0.2], [1, 1]]` means that higher/lower values would have higher opacity values and those in the middle would be more transparent Alternatively, `opacityscale` may be a palette name string of the following list: 'min', 'max', 'extremes' and 'uniform'. The default is 'uniform'.
        public static Box<IVolumeProperty> opacityscale(params float[] values) => Interop.mkVolumeAttr("opacityscale", values);
        /// Sets the opacityscale. The opacityscale must be an array containing arrays mapping a normalized value to an opacity value. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 1], [0.5, 0.2], [1, 1]]` means that higher/lower values would have higher opacity values and those in the middle would be more transparent Alternatively, `opacityscale` may be a palette name string of the following list: 'min', 'max', 'extremes' and 'uniform'. The default is 'uniform'.
        public static Box<IVolumeProperty> opacityscale(string val) => Interop.mkVolumeAttr("opacityscale", val);
        /// Sets the opacityscale. The opacityscale must be an array containing arrays mapping a normalized value to an opacity value. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 1], [0.5, 0.2], [1, 1]]` means that higher/lower values would have higher opacity values and those in the middle would be more transparent Alternatively, `opacityscale` may be a palette name string of the following list: 'min', 'max', 'extremes' and 'uniform'. The default is 'uniform'.
        public static Box<IVolumeProperty> opacityscale(params string[] values) => Interop.mkVolumeAttr("opacityscale", values);
        public static Box<IVolumeProperty> lightposition(params Box<ILightpositionProperty>[] properties) => Interop.mkVolumeAttr("lightposition", Bindings.flattenProperties(properties));
        public static Box<IVolumeProperty> lighting(params Box<ILightingProperty>[] properties) => Interop.mkVolumeAttr("lighting", Bindings.flattenProperties(properties));
        /// Determines whether or not normal smoothing is applied to the meshes, creating meshes with an angular, low-poly look via flat reflections.
        public static Box<IVolumeProperty> flatshading(bool val) => Interop.mkVolumeAttr("flatshading", val);
        public static Box<IVolumeProperty> contour(params Box<IContourProperty>[] properties) => Interop.mkVolumeAttr("contour", Bindings.flattenProperties(properties));
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IVolumeProperty> hoverinfo(params Box<IVolumeProperty>[] properties) => Interop.mkVolumeAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IVolumeProperty> showlegend(bool val) => Interop.mkVolumeAttr("showlegend", val);
        /// Sets a reference between this trace's 3D coordinate system and a 3D scene. If *scene* (the default value), the (x,y,z) coordinates refer to `layout.scene`. If *scene2*, the (x,y,z) coordinates refer to `layout.scene2`, and so on.
        public static Box<IVolumeProperty> scene(int anchorId) => Interop.mkVolumeAttr("scene", anchorId > 1 ? $"scene{anchorId}" : "");
        /// Sets a reference between this trace's 3D coordinate system and a 3D scene. If *scene* (the default value), the (x,y,z) coordinates refer to `layout.scene`. If *scene2*, the (x,y,z) coordinates refer to `layout.scene2`, and so on.
        public static Box<IVolumeProperty> scene(string val) => Interop.mkVolumeAttr("scene", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IVolumeProperty> idssrc(string val) => Interop.mkVolumeAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IVolumeProperty> customdatasrc(string val) => Interop.mkVolumeAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IVolumeProperty> metasrc(string val) => Interop.mkVolumeAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  x .
        public static Box<IVolumeProperty> xsrc(string val) => Interop.mkVolumeAttr("xsrc", val);
        /// Sets the source reference on plot.ly for  y .
        public static Box<IVolumeProperty> ysrc(string val) => Interop.mkVolumeAttr("ysrc", val);
        /// Sets the source reference on plot.ly for  z .
        public static Box<IVolumeProperty> zsrc(string val) => Interop.mkVolumeAttr("zsrc", val);
        /// Sets the source reference on plot.ly for  value .
        public static Box<IVolumeProperty> valuesrc(string val) => Interop.mkVolumeAttr("valuesrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IVolumeProperty> textsrc(string val) => Interop.mkVolumeAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IVolumeProperty> hovertextsrc(string val) => Interop.mkVolumeAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IVolumeProperty> hovertemplatesrc(string val) => Interop.mkVolumeAttr("hovertemplatesrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IVolumeProperty> hoverinfosrc(string val) => Interop.mkVolumeAttr("hoverinfosrc", val);
    }

    public static partial class Volume
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IVolumeProperty> legendonly() => Interop.mkVolumeAttr("visible", "legendonly");
            public static Box<IVolumeProperty> _false() => Interop.mkVolumeAttr("visible", false);
            public static Box<IVolumeProperty> _true() => Interop.mkVolumeAttr("visible", true);
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IVolumeProperty> all() => Interop.mkVolumeAttr("hoverinfo", "all");
            public static Box<IVolumeProperty> none() => Interop.mkVolumeAttr("hoverinfo", "none");
            public static Box<IVolumeProperty> skip() => Interop.mkVolumeAttr("hoverinfo", "skip");
            public static Box<IVolumeProperty> name() => Interop.mkVolumeAttr("hoverinfo", "name");
            public static Box<IVolumeProperty> text() => Interop.mkVolumeAttr("hoverinfo", "text");
            public static Box<IVolumeProperty> x() => Interop.mkVolumeAttr("hoverinfo", "x");
            public static Box<IVolumeProperty> y() => Interop.mkVolumeAttr("hoverinfo", "y");
            public static Box<IVolumeProperty> z() => Interop.mkVolumeAttr("hoverinfo", "z");
        }
    }
}