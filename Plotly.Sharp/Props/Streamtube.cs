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

    public static partial class Streamtube
    {
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IStreamtubeProperty> legendgroup(string val) => Interop.mkStreamtubeAttr("legendgroup", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IStreamtubeProperty> name(string val) => Interop.mkStreamtubeAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IStreamtubeProperty> uid(string val) => Interop.mkStreamtubeAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IStreamtubeProperty> ids(bool val) => Interop.mkStreamtubeAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IStreamtubeProperty> ids(params bool[] values) => Interop.mkStreamtubeAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IStreamtubeProperty> ids(System.DateTime val) => Interop.mkStreamtubeAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IStreamtubeProperty> ids(params System.DateTime[] values) => Interop.mkStreamtubeAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IStreamtubeProperty> ids(float val) => Interop.mkStreamtubeAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IStreamtubeProperty> ids(params float[] values) => Interop.mkStreamtubeAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IStreamtubeProperty> ids(int val) => Interop.mkStreamtubeAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IStreamtubeProperty> ids(params int[] values) => Interop.mkStreamtubeAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IStreamtubeProperty> ids(string val) => Interop.mkStreamtubeAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IStreamtubeProperty> ids(params string[] values) => Interop.mkStreamtubeAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IStreamtubeProperty> ids(IEnumerable<bool[]> values) => Interop.mkStreamtubeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IStreamtubeProperty> ids(List<bool[]> values) => Interop.mkStreamtubeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IStreamtubeProperty> ids(params bool[][] values) => Interop.mkStreamtubeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IStreamtubeProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkStreamtubeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IStreamtubeProperty> ids(List<string[]> values) => Interop.mkStreamtubeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IStreamtubeProperty> ids(params string[][] values) => Interop.mkStreamtubeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IStreamtubeProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkStreamtubeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IStreamtubeProperty> ids(List<int[]> values) => Interop.mkStreamtubeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IStreamtubeProperty> ids(params int[][] values) => Interop.mkStreamtubeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IStreamtubeProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkStreamtubeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IStreamtubeProperty> ids(List<float[]> values) => Interop.mkStreamtubeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IStreamtubeProperty> ids(params float[][] values) => Interop.mkStreamtubeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IStreamtubeProperty> ids(Literals.PlotData[] values) => Interop.mkStreamtubeAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IStreamtubeProperty> ids(IEnumerable<bool?> values) => Interop.mkStreamtubeAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IStreamtubeProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkStreamtubeAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IStreamtubeProperty> ids(IEnumerable<int?> values) => Interop.mkStreamtubeAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IStreamtubeProperty> ids(IEnumerable<float?> values) => Interop.mkStreamtubeAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IStreamtubeProperty> customdata(bool val) => Interop.mkStreamtubeAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IStreamtubeProperty> customdata(params bool[] values) => Interop.mkStreamtubeAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IStreamtubeProperty> customdata(System.DateTime val) => Interop.mkStreamtubeAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IStreamtubeProperty> customdata(params System.DateTime[] values) => Interop.mkStreamtubeAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IStreamtubeProperty> customdata(float val) => Interop.mkStreamtubeAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IStreamtubeProperty> customdata(params float[] values) => Interop.mkStreamtubeAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IStreamtubeProperty> customdata(int val) => Interop.mkStreamtubeAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IStreamtubeProperty> customdata(params int[] values) => Interop.mkStreamtubeAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IStreamtubeProperty> customdata(string val) => Interop.mkStreamtubeAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IStreamtubeProperty> customdata(params string[] values) => Interop.mkStreamtubeAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IStreamtubeProperty> customdata(IEnumerable<bool[]> values) => Interop.mkStreamtubeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IStreamtubeProperty> customdata(List<bool[]> values) => Interop.mkStreamtubeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IStreamtubeProperty> customdata(params bool[][] values) => Interop.mkStreamtubeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IStreamtubeProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkStreamtubeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IStreamtubeProperty> customdata(List<string[]> values) => Interop.mkStreamtubeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IStreamtubeProperty> customdata(params string[][] values) => Interop.mkStreamtubeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IStreamtubeProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkStreamtubeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IStreamtubeProperty> customdata(List<int[]> values) => Interop.mkStreamtubeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IStreamtubeProperty> customdata(params int[][] values) => Interop.mkStreamtubeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IStreamtubeProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkStreamtubeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IStreamtubeProperty> customdata(List<float[]> values) => Interop.mkStreamtubeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IStreamtubeProperty> customdata(params float[][] values) => Interop.mkStreamtubeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IStreamtubeProperty> customdata(Literals.PlotData[] values) => Interop.mkStreamtubeAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IStreamtubeProperty> customdata(IEnumerable<bool?> values) => Interop.mkStreamtubeAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IStreamtubeProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkStreamtubeAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IStreamtubeProperty> customdata(IEnumerable<int?> values) => Interop.mkStreamtubeAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IStreamtubeProperty> customdata(IEnumerable<float?> values) => Interop.mkStreamtubeAttr("customdata", values.ToArray());
        public static Box<IStreamtubeProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkStreamtubeAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IStreamtubeProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkStreamtubeAttr("stream", Bindings.flattenProperties(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IStreamtubeProperty> uirevision(bool val) => Interop.mkStreamtubeAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IStreamtubeProperty> uirevision(params bool[] values) => Interop.mkStreamtubeAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IStreamtubeProperty> uirevision(System.DateTime val) => Interop.mkStreamtubeAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IStreamtubeProperty> uirevision(params System.DateTime[] values) => Interop.mkStreamtubeAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IStreamtubeProperty> uirevision(int val) => Interop.mkStreamtubeAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IStreamtubeProperty> uirevision(params int[] values) => Interop.mkStreamtubeAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IStreamtubeProperty> uirevision(float val) => Interop.mkStreamtubeAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IStreamtubeProperty> uirevision(params float[] values) => Interop.mkStreamtubeAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IStreamtubeProperty> uirevision(string val) => Interop.mkStreamtubeAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IStreamtubeProperty> uirevision(params string[] values) => Interop.mkStreamtubeAttr("uirevision", values);
        /// Sets the x coordinates of the vector field.
        public static Box<IStreamtubeProperty> x(bool val) => Interop.mkStreamtubeAttr("x", new[]{val});
        /// Sets the x coordinates of the vector field.
        public static Box<IStreamtubeProperty> x(IEnumerable<bool> values) => Interop.mkStreamtubeAttr("x", values.ToArray());
        /// Sets the x coordinates of the vector field.
        public static Box<IStreamtubeProperty> x(System.DateTime val) => Interop.mkStreamtubeAttr("x", new[]{val});
        /// Sets the x coordinates of the vector field.
        public static Box<IStreamtubeProperty> x(IEnumerable<System.DateTime> values) => Interop.mkStreamtubeAttr("x", values.ToArray());
        /// Sets the x coordinates of the vector field.
        public static Box<IStreamtubeProperty> x(float val) => Interop.mkStreamtubeAttr("x", new[]{val});
        /// Sets the x coordinates of the vector field.
        public static Box<IStreamtubeProperty> x(IEnumerable<float> values) => Interop.mkStreamtubeAttr("x", values.ToArray());
        /// Sets the x coordinates of the vector field.
        public static Box<IStreamtubeProperty> x(int val) => Interop.mkStreamtubeAttr("x", new[]{val});
        /// Sets the x coordinates of the vector field.
        public static Box<IStreamtubeProperty> x(IEnumerable<int> values) => Interop.mkStreamtubeAttr("x", values.ToArray());
        /// Sets the x coordinates of the vector field.
        public static Box<IStreamtubeProperty> x(string val) => Interop.mkStreamtubeAttr("x", new[]{val});
        /// Sets the x coordinates of the vector field.
        public static Box<IStreamtubeProperty> x(IEnumerable<string> values) => Interop.mkStreamtubeAttr("x", values.ToArray());
        /// Sets the x coordinates of the vector field.
        public static Box<IStreamtubeProperty> x(IEnumerable<bool[]> values) => Interop.mkStreamtubeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates of the vector field.
        public static Box<IStreamtubeProperty> x(List<bool[]> values) => Interop.mkStreamtubeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates of the vector field.
        public static Box<IStreamtubeProperty> x(params bool[][] values) => Interop.mkStreamtubeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates of the vector field.
        public static Box<IStreamtubeProperty> x(IEnumerable<IEnumerable<string>> values) => Interop.mkStreamtubeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates of the vector field.
        public static Box<IStreamtubeProperty> x(List<string[]> values) => Interop.mkStreamtubeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates of the vector field.
        public static Box<IStreamtubeProperty> x(params string[][] values) => Interop.mkStreamtubeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates of the vector field.
        public static Box<IStreamtubeProperty> x(IEnumerable<IEnumerable<int>> values) => Interop.mkStreamtubeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates of the vector field.
        public static Box<IStreamtubeProperty> x(List<int[]> values) => Interop.mkStreamtubeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates of the vector field.
        public static Box<IStreamtubeProperty> x(params int[][] values) => Interop.mkStreamtubeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates of the vector field.
        public static Box<IStreamtubeProperty> x(IEnumerable<IEnumerable<float>> values) => Interop.mkStreamtubeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates of the vector field.
        public static Box<IStreamtubeProperty> x(List<float[]> values) => Interop.mkStreamtubeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates of the vector field.
        public static Box<IStreamtubeProperty> x(params float[][] values) => Interop.mkStreamtubeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates of the vector field.
        public static Box<IStreamtubeProperty> x(Literals.PlotData[] values) => Interop.mkStreamtubeAttr("x", values);
        /// Sets the x coordinates of the vector field.
        public static Box<IStreamtubeProperty> x(IEnumerable<bool?> values) => Interop.mkStreamtubeAttr("x", values.ToArray());
        /// Sets the x coordinates of the vector field.
        public static Box<IStreamtubeProperty> x(IEnumerable<System.DateTime?> values) => Interop.mkStreamtubeAttr("x", values.ToArray());
        /// Sets the x coordinates of the vector field.
        public static Box<IStreamtubeProperty> x(IEnumerable<int?> values) => Interop.mkStreamtubeAttr("x", values.ToArray());
        /// Sets the x coordinates of the vector field.
        public static Box<IStreamtubeProperty> x(IEnumerable<float?> values) => Interop.mkStreamtubeAttr("x", values.ToArray());
        /// Sets the y coordinates of the vector field.
        public static Box<IStreamtubeProperty> y(bool val) => Interop.mkStreamtubeAttr("y", new[]{val});
        /// Sets the y coordinates of the vector field.
        public static Box<IStreamtubeProperty> y(IEnumerable<bool> values) => Interop.mkStreamtubeAttr("y", values.ToArray());
        /// Sets the y coordinates of the vector field.
        public static Box<IStreamtubeProperty> y(System.DateTime val) => Interop.mkStreamtubeAttr("y", new[]{val});
        /// Sets the y coordinates of the vector field.
        public static Box<IStreamtubeProperty> y(IEnumerable<System.DateTime> values) => Interop.mkStreamtubeAttr("y", values.ToArray());
        /// Sets the y coordinates of the vector field.
        public static Box<IStreamtubeProperty> y(float val) => Interop.mkStreamtubeAttr("y", new[]{val});
        /// Sets the y coordinates of the vector field.
        public static Box<IStreamtubeProperty> y(IEnumerable<float> values) => Interop.mkStreamtubeAttr("y", values.ToArray());
        /// Sets the y coordinates of the vector field.
        public static Box<IStreamtubeProperty> y(int val) => Interop.mkStreamtubeAttr("y", new[]{val});
        /// Sets the y coordinates of the vector field.
        public static Box<IStreamtubeProperty> y(IEnumerable<int> values) => Interop.mkStreamtubeAttr("y", values.ToArray());
        /// Sets the y coordinates of the vector field.
        public static Box<IStreamtubeProperty> y(string val) => Interop.mkStreamtubeAttr("y", new[]{val});
        /// Sets the y coordinates of the vector field.
        public static Box<IStreamtubeProperty> y(IEnumerable<string> values) => Interop.mkStreamtubeAttr("y", values.ToArray());
        /// Sets the y coordinates of the vector field.
        public static Box<IStreamtubeProperty> y(IEnumerable<bool[]> values) => Interop.mkStreamtubeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates of the vector field.
        public static Box<IStreamtubeProperty> y(List<bool[]> values) => Interop.mkStreamtubeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates of the vector field.
        public static Box<IStreamtubeProperty> y(params bool[][] values) => Interop.mkStreamtubeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates of the vector field.
        public static Box<IStreamtubeProperty> y(IEnumerable<IEnumerable<string>> values) => Interop.mkStreamtubeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates of the vector field.
        public static Box<IStreamtubeProperty> y(List<string[]> values) => Interop.mkStreamtubeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates of the vector field.
        public static Box<IStreamtubeProperty> y(params string[][] values) => Interop.mkStreamtubeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates of the vector field.
        public static Box<IStreamtubeProperty> y(IEnumerable<IEnumerable<int>> values) => Interop.mkStreamtubeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates of the vector field.
        public static Box<IStreamtubeProperty> y(List<int[]> values) => Interop.mkStreamtubeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates of the vector field.
        public static Box<IStreamtubeProperty> y(params int[][] values) => Interop.mkStreamtubeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates of the vector field.
        public static Box<IStreamtubeProperty> y(IEnumerable<IEnumerable<float>> values) => Interop.mkStreamtubeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates of the vector field.
        public static Box<IStreamtubeProperty> y(List<float[]> values) => Interop.mkStreamtubeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates of the vector field.
        public static Box<IStreamtubeProperty> y(params float[][] values) => Interop.mkStreamtubeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates of the vector field.
        public static Box<IStreamtubeProperty> y(Literals.PlotData[] values) => Interop.mkStreamtubeAttr("y", values);
        /// Sets the y coordinates of the vector field.
        public static Box<IStreamtubeProperty> y(IEnumerable<bool?> values) => Interop.mkStreamtubeAttr("y", values.ToArray());
        /// Sets the y coordinates of the vector field.
        public static Box<IStreamtubeProperty> y(IEnumerable<System.DateTime?> values) => Interop.mkStreamtubeAttr("y", values.ToArray());
        /// Sets the y coordinates of the vector field.
        public static Box<IStreamtubeProperty> y(IEnumerable<int?> values) => Interop.mkStreamtubeAttr("y", values.ToArray());
        /// Sets the y coordinates of the vector field.
        public static Box<IStreamtubeProperty> y(IEnumerable<float?> values) => Interop.mkStreamtubeAttr("y", values.ToArray());
        /// Sets the z coordinates of the vector field.
        public static Box<IStreamtubeProperty> z(bool val) => Interop.mkStreamtubeAttr("z", new[]{val});
        /// Sets the z coordinates of the vector field.
        public static Box<IStreamtubeProperty> z(IEnumerable<bool> values) => Interop.mkStreamtubeAttr("z", values.ToArray());
        /// Sets the z coordinates of the vector field.
        public static Box<IStreamtubeProperty> z(System.DateTime val) => Interop.mkStreamtubeAttr("z", new[]{val});
        /// Sets the z coordinates of the vector field.
        public static Box<IStreamtubeProperty> z(IEnumerable<System.DateTime> values) => Interop.mkStreamtubeAttr("z", values.ToArray());
        /// Sets the z coordinates of the vector field.
        public static Box<IStreamtubeProperty> z(float val) => Interop.mkStreamtubeAttr("z", new[]{val});
        /// Sets the z coordinates of the vector field.
        public static Box<IStreamtubeProperty> z(IEnumerable<float> values) => Interop.mkStreamtubeAttr("z", values.ToArray());
        /// Sets the z coordinates of the vector field.
        public static Box<IStreamtubeProperty> z(int val) => Interop.mkStreamtubeAttr("z", new[]{val});
        /// Sets the z coordinates of the vector field.
        public static Box<IStreamtubeProperty> z(IEnumerable<int> values) => Interop.mkStreamtubeAttr("z", values.ToArray());
        /// Sets the z coordinates of the vector field.
        public static Box<IStreamtubeProperty> z(string val) => Interop.mkStreamtubeAttr("z", new[]{val});
        /// Sets the z coordinates of the vector field.
        public static Box<IStreamtubeProperty> z(IEnumerable<string> values) => Interop.mkStreamtubeAttr("z", values.ToArray());
        /// Sets the z coordinates of the vector field.
        public static Box<IStreamtubeProperty> z(IEnumerable<bool[]> values) => Interop.mkStreamtubeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates of the vector field.
        public static Box<IStreamtubeProperty> z(List<bool[]> values) => Interop.mkStreamtubeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates of the vector field.
        public static Box<IStreamtubeProperty> z(params bool[][] values) => Interop.mkStreamtubeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates of the vector field.
        public static Box<IStreamtubeProperty> z(IEnumerable<IEnumerable<string>> values) => Interop.mkStreamtubeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates of the vector field.
        public static Box<IStreamtubeProperty> z(List<string[]> values) => Interop.mkStreamtubeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates of the vector field.
        public static Box<IStreamtubeProperty> z(params string[][] values) => Interop.mkStreamtubeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates of the vector field.
        public static Box<IStreamtubeProperty> z(IEnumerable<IEnumerable<int>> values) => Interop.mkStreamtubeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates of the vector field.
        public static Box<IStreamtubeProperty> z(List<int[]> values) => Interop.mkStreamtubeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates of the vector field.
        public static Box<IStreamtubeProperty> z(params int[][] values) => Interop.mkStreamtubeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates of the vector field.
        public static Box<IStreamtubeProperty> z(IEnumerable<IEnumerable<float>> values) => Interop.mkStreamtubeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates of the vector field.
        public static Box<IStreamtubeProperty> z(List<float[]> values) => Interop.mkStreamtubeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates of the vector field.
        public static Box<IStreamtubeProperty> z(params float[][] values) => Interop.mkStreamtubeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates of the vector field.
        public static Box<IStreamtubeProperty> z(Literals.PlotData[] values) => Interop.mkStreamtubeAttr("z", values);
        /// Sets the z coordinates of the vector field.
        public static Box<IStreamtubeProperty> z(IEnumerable<bool?> values) => Interop.mkStreamtubeAttr("z", values.ToArray());
        /// Sets the z coordinates of the vector field.
        public static Box<IStreamtubeProperty> z(IEnumerable<System.DateTime?> values) => Interop.mkStreamtubeAttr("z", values.ToArray());
        /// Sets the z coordinates of the vector field.
        public static Box<IStreamtubeProperty> z(IEnumerable<int?> values) => Interop.mkStreamtubeAttr("z", values.ToArray());
        /// Sets the z coordinates of the vector field.
        public static Box<IStreamtubeProperty> z(IEnumerable<float?> values) => Interop.mkStreamtubeAttr("z", values.ToArray());
        /// Sets the x components of the vector field.
        public static Box<IStreamtubeProperty> u(bool val) => Interop.mkStreamtubeAttr("u", new[]{val});
        /// Sets the x components of the vector field.
        public static Box<IStreamtubeProperty> u(params bool[] values) => Interop.mkStreamtubeAttr("u", values);
        /// Sets the x components of the vector field.
        public static Box<IStreamtubeProperty> u(System.DateTime val) => Interop.mkStreamtubeAttr("u", new[]{val});
        /// Sets the x components of the vector field.
        public static Box<IStreamtubeProperty> u(params System.DateTime[] values) => Interop.mkStreamtubeAttr("u", values);
        /// Sets the x components of the vector field.
        public static Box<IStreamtubeProperty> u(float val) => Interop.mkStreamtubeAttr("u", new[]{val});
        /// Sets the x components of the vector field.
        public static Box<IStreamtubeProperty> u(params float[] values) => Interop.mkStreamtubeAttr("u", values);
        /// Sets the x components of the vector field.
        public static Box<IStreamtubeProperty> u(int val) => Interop.mkStreamtubeAttr("u", new[]{val});
        /// Sets the x components of the vector field.
        public static Box<IStreamtubeProperty> u(params int[] values) => Interop.mkStreamtubeAttr("u", values);
        /// Sets the x components of the vector field.
        public static Box<IStreamtubeProperty> u(string val) => Interop.mkStreamtubeAttr("u", new[]{val});
        /// Sets the x components of the vector field.
        public static Box<IStreamtubeProperty> u(params string[] values) => Interop.mkStreamtubeAttr("u", values);
        /// Sets the x components of the vector field.
        public static Box<IStreamtubeProperty> u(IEnumerable<bool[]> values) => Interop.mkStreamtubeAttr("u", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x components of the vector field.
        public static Box<IStreamtubeProperty> u(List<bool[]> values) => Interop.mkStreamtubeAttr("u", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x components of the vector field.
        public static Box<IStreamtubeProperty> u(params bool[][] values) => Interop.mkStreamtubeAttr("u", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x components of the vector field.
        public static Box<IStreamtubeProperty> u(IEnumerable<IEnumerable<string>> values) => Interop.mkStreamtubeAttr("u", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x components of the vector field.
        public static Box<IStreamtubeProperty> u(List<string[]> values) => Interop.mkStreamtubeAttr("u", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x components of the vector field.
        public static Box<IStreamtubeProperty> u(params string[][] values) => Interop.mkStreamtubeAttr("u", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x components of the vector field.
        public static Box<IStreamtubeProperty> u(IEnumerable<IEnumerable<int>> values) => Interop.mkStreamtubeAttr("u", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x components of the vector field.
        public static Box<IStreamtubeProperty> u(List<int[]> values) => Interop.mkStreamtubeAttr("u", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x components of the vector field.
        public static Box<IStreamtubeProperty> u(params int[][] values) => Interop.mkStreamtubeAttr("u", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x components of the vector field.
        public static Box<IStreamtubeProperty> u(IEnumerable<IEnumerable<float>> values) => Interop.mkStreamtubeAttr("u", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x components of the vector field.
        public static Box<IStreamtubeProperty> u(List<float[]> values) => Interop.mkStreamtubeAttr("u", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x components of the vector field.
        public static Box<IStreamtubeProperty> u(params float[][] values) => Interop.mkStreamtubeAttr("u", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x components of the vector field.
        public static Box<IStreamtubeProperty> u(Literals.PlotData[] values) => Interop.mkStreamtubeAttr("u", values);
        /// Sets the x components of the vector field.
        public static Box<IStreamtubeProperty> u(IEnumerable<bool?> values) => Interop.mkStreamtubeAttr("u", values.ToArray());
        /// Sets the x components of the vector field.
        public static Box<IStreamtubeProperty> u(IEnumerable<System.DateTime?> values) => Interop.mkStreamtubeAttr("u", values.ToArray());
        /// Sets the x components of the vector field.
        public static Box<IStreamtubeProperty> u(IEnumerable<int?> values) => Interop.mkStreamtubeAttr("u", values.ToArray());
        /// Sets the x components of the vector field.
        public static Box<IStreamtubeProperty> u(IEnumerable<float?> values) => Interop.mkStreamtubeAttr("u", values.ToArray());
        /// Sets the y components of the vector field.
        public static Box<IStreamtubeProperty> v(bool val) => Interop.mkStreamtubeAttr("v", new[]{val});
        /// Sets the y components of the vector field.
        public static Box<IStreamtubeProperty> v(params bool[] values) => Interop.mkStreamtubeAttr("v", values);
        /// Sets the y components of the vector field.
        public static Box<IStreamtubeProperty> v(System.DateTime val) => Interop.mkStreamtubeAttr("v", new[]{val});
        /// Sets the y components of the vector field.
        public static Box<IStreamtubeProperty> v(params System.DateTime[] values) => Interop.mkStreamtubeAttr("v", values);
        /// Sets the y components of the vector field.
        public static Box<IStreamtubeProperty> v(float val) => Interop.mkStreamtubeAttr("v", new[]{val});
        /// Sets the y components of the vector field.
        public static Box<IStreamtubeProperty> v(params float[] values) => Interop.mkStreamtubeAttr("v", values);
        /// Sets the y components of the vector field.
        public static Box<IStreamtubeProperty> v(int val) => Interop.mkStreamtubeAttr("v", new[]{val});
        /// Sets the y components of the vector field.
        public static Box<IStreamtubeProperty> v(params int[] values) => Interop.mkStreamtubeAttr("v", values);
        /// Sets the y components of the vector field.
        public static Box<IStreamtubeProperty> v(string val) => Interop.mkStreamtubeAttr("v", new[]{val});
        /// Sets the y components of the vector field.
        public static Box<IStreamtubeProperty> v(params string[] values) => Interop.mkStreamtubeAttr("v", values);
        /// Sets the y components of the vector field.
        public static Box<IStreamtubeProperty> v(IEnumerable<bool[]> values) => Interop.mkStreamtubeAttr("v", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y components of the vector field.
        public static Box<IStreamtubeProperty> v(List<bool[]> values) => Interop.mkStreamtubeAttr("v", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y components of the vector field.
        public static Box<IStreamtubeProperty> v(params bool[][] values) => Interop.mkStreamtubeAttr("v", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y components of the vector field.
        public static Box<IStreamtubeProperty> v(IEnumerable<IEnumerable<string>> values) => Interop.mkStreamtubeAttr("v", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y components of the vector field.
        public static Box<IStreamtubeProperty> v(List<string[]> values) => Interop.mkStreamtubeAttr("v", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y components of the vector field.
        public static Box<IStreamtubeProperty> v(params string[][] values) => Interop.mkStreamtubeAttr("v", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y components of the vector field.
        public static Box<IStreamtubeProperty> v(IEnumerable<IEnumerable<int>> values) => Interop.mkStreamtubeAttr("v", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y components of the vector field.
        public static Box<IStreamtubeProperty> v(List<int[]> values) => Interop.mkStreamtubeAttr("v", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y components of the vector field.
        public static Box<IStreamtubeProperty> v(params int[][] values) => Interop.mkStreamtubeAttr("v", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y components of the vector field.
        public static Box<IStreamtubeProperty> v(IEnumerable<IEnumerable<float>> values) => Interop.mkStreamtubeAttr("v", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y components of the vector field.
        public static Box<IStreamtubeProperty> v(List<float[]> values) => Interop.mkStreamtubeAttr("v", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y components of the vector field.
        public static Box<IStreamtubeProperty> v(params float[][] values) => Interop.mkStreamtubeAttr("v", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y components of the vector field.
        public static Box<IStreamtubeProperty> v(Literals.PlotData[] values) => Interop.mkStreamtubeAttr("v", values);
        /// Sets the y components of the vector field.
        public static Box<IStreamtubeProperty> v(IEnumerable<bool?> values) => Interop.mkStreamtubeAttr("v", values.ToArray());
        /// Sets the y components of the vector field.
        public static Box<IStreamtubeProperty> v(IEnumerable<System.DateTime?> values) => Interop.mkStreamtubeAttr("v", values.ToArray());
        /// Sets the y components of the vector field.
        public static Box<IStreamtubeProperty> v(IEnumerable<int?> values) => Interop.mkStreamtubeAttr("v", values.ToArray());
        /// Sets the y components of the vector field.
        public static Box<IStreamtubeProperty> v(IEnumerable<float?> values) => Interop.mkStreamtubeAttr("v", values.ToArray());
        /// Sets the z components of the vector field.
        public static Box<IStreamtubeProperty> w(bool val) => Interop.mkStreamtubeAttr("w", new[]{val});
        /// Sets the z components of the vector field.
        public static Box<IStreamtubeProperty> w(params bool[] values) => Interop.mkStreamtubeAttr("w", values);
        /// Sets the z components of the vector field.
        public static Box<IStreamtubeProperty> w(System.DateTime val) => Interop.mkStreamtubeAttr("w", new[]{val});
        /// Sets the z components of the vector field.
        public static Box<IStreamtubeProperty> w(params System.DateTime[] values) => Interop.mkStreamtubeAttr("w", values);
        /// Sets the z components of the vector field.
        public static Box<IStreamtubeProperty> w(float val) => Interop.mkStreamtubeAttr("w", new[]{val});
        /// Sets the z components of the vector field.
        public static Box<IStreamtubeProperty> w(params float[] values) => Interop.mkStreamtubeAttr("w", values);
        /// Sets the z components of the vector field.
        public static Box<IStreamtubeProperty> w(int val) => Interop.mkStreamtubeAttr("w", new[]{val});
        /// Sets the z components of the vector field.
        public static Box<IStreamtubeProperty> w(params int[] values) => Interop.mkStreamtubeAttr("w", values);
        /// Sets the z components of the vector field.
        public static Box<IStreamtubeProperty> w(string val) => Interop.mkStreamtubeAttr("w", new[]{val});
        /// Sets the z components of the vector field.
        public static Box<IStreamtubeProperty> w(params string[] values) => Interop.mkStreamtubeAttr("w", values);
        /// Sets the z components of the vector field.
        public static Box<IStreamtubeProperty> w(IEnumerable<bool[]> values) => Interop.mkStreamtubeAttr("w", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z components of the vector field.
        public static Box<IStreamtubeProperty> w(List<bool[]> values) => Interop.mkStreamtubeAttr("w", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z components of the vector field.
        public static Box<IStreamtubeProperty> w(params bool[][] values) => Interop.mkStreamtubeAttr("w", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z components of the vector field.
        public static Box<IStreamtubeProperty> w(IEnumerable<IEnumerable<string>> values) => Interop.mkStreamtubeAttr("w", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z components of the vector field.
        public static Box<IStreamtubeProperty> w(List<string[]> values) => Interop.mkStreamtubeAttr("w", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z components of the vector field.
        public static Box<IStreamtubeProperty> w(params string[][] values) => Interop.mkStreamtubeAttr("w", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z components of the vector field.
        public static Box<IStreamtubeProperty> w(IEnumerable<IEnumerable<int>> values) => Interop.mkStreamtubeAttr("w", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z components of the vector field.
        public static Box<IStreamtubeProperty> w(List<int[]> values) => Interop.mkStreamtubeAttr("w", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z components of the vector field.
        public static Box<IStreamtubeProperty> w(params int[][] values) => Interop.mkStreamtubeAttr("w", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z components of the vector field.
        public static Box<IStreamtubeProperty> w(IEnumerable<IEnumerable<float>> values) => Interop.mkStreamtubeAttr("w", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z components of the vector field.
        public static Box<IStreamtubeProperty> w(List<float[]> values) => Interop.mkStreamtubeAttr("w", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z components of the vector field.
        public static Box<IStreamtubeProperty> w(params float[][] values) => Interop.mkStreamtubeAttr("w", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z components of the vector field.
        public static Box<IStreamtubeProperty> w(Literals.PlotData[] values) => Interop.mkStreamtubeAttr("w", values);
        /// Sets the z components of the vector field.
        public static Box<IStreamtubeProperty> w(IEnumerable<bool?> values) => Interop.mkStreamtubeAttr("w", values.ToArray());
        /// Sets the z components of the vector field.
        public static Box<IStreamtubeProperty> w(IEnumerable<System.DateTime?> values) => Interop.mkStreamtubeAttr("w", values.ToArray());
        /// Sets the z components of the vector field.
        public static Box<IStreamtubeProperty> w(IEnumerable<int?> values) => Interop.mkStreamtubeAttr("w", values.ToArray());
        /// Sets the z components of the vector field.
        public static Box<IStreamtubeProperty> w(IEnumerable<float?> values) => Interop.mkStreamtubeAttr("w", values.ToArray());
        public static Box<IStreamtubeProperty> starts(params Box<IStartsProperty>[] properties) => Interop.mkStreamtubeAttr("starts", Bindings.flattenProperties(properties));
        /// The maximum number of displayed segments in a streamtube.
        public static Box<IStreamtubeProperty> maxdisplayed(int val) => Interop.mkStreamtubeAttr("maxdisplayed", val);
        /// The scaling factor for the streamtubes. The default is 1, which avoids two max divergence tubes from touching at adjacent starting positions.
        public static Box<IStreamtubeProperty> sizeref(int val) => Interop.mkStreamtubeAttr("sizeref", val);
        /// The scaling factor for the streamtubes. The default is 1, which avoids two max divergence tubes from touching at adjacent starting positions.
        public static Box<IStreamtubeProperty> sizeref(float val) => Interop.mkStreamtubeAttr("sizeref", val);
        /// Sets a text element associated with this trace. If trace `hoverinfo` contains a *text* flag, this text element will be seen in all hover labels. Note that streamtube traces do not support array `text` values.
        public static Box<IStreamtubeProperty> text(string val) => Interop.mkStreamtubeAttr("text", val);
        /// Same as `text`.
        public static Box<IStreamtubeProperty> hovertext(string val) => Interop.mkStreamtubeAttr("hovertext", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `tubex`, `tubey`, `tubez`, `tubeu`, `tubev`, `tubew`, `norm` and `divergence`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IStreamtubeProperty> hovertemplate(string val) => Interop.mkStreamtubeAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `tubex`, `tubey`, `tubez`, `tubeu`, `tubev`, `tubew`, `norm` and `divergence`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IStreamtubeProperty> hovertemplate(IEnumerable<string> values) => Interop.mkStreamtubeAttr("hovertemplate", values.ToArray());
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IStreamtubeProperty> showlegend(bool val) => Interop.mkStreamtubeAttr("showlegend", val);
        /// Determines whether or not the color domain is computed with respect to the input data (here u/v/w norm) or the bounds set in `cmin` and `cmax`  Defaults to `false` when `cmin` and `cmax` are set by the user.
        public static Box<IStreamtubeProperty> cauto(bool val) => Interop.mkStreamtubeAttr("cauto", val);
        /// Sets the lower bound of the color domain. Value should have the same units as u/v/w norm and if set, `cmax` must be set as well.
        public static Box<IStreamtubeProperty> cmin(int val) => Interop.mkStreamtubeAttr("cmin", val);
        /// Sets the lower bound of the color domain. Value should have the same units as u/v/w norm and if set, `cmax` must be set as well.
        public static Box<IStreamtubeProperty> cmin(float val) => Interop.mkStreamtubeAttr("cmin", val);
        /// Sets the upper bound of the color domain. Value should have the same units as u/v/w norm and if set, `cmin` must be set as well.
        public static Box<IStreamtubeProperty> cmax(int val) => Interop.mkStreamtubeAttr("cmax", val);
        /// Sets the upper bound of the color domain. Value should have the same units as u/v/w norm and if set, `cmin` must be set as well.
        public static Box<IStreamtubeProperty> cmax(float val) => Interop.mkStreamtubeAttr("cmax", val);
        /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as u/v/w norm. Has no effect when `cauto` is `false`.
        public static Box<IStreamtubeProperty> cmid(int val) => Interop.mkStreamtubeAttr("cmid", val);
        /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as u/v/w norm. Has no effect when `cauto` is `false`.
        public static Box<IStreamtubeProperty> cmid(float val) => Interop.mkStreamtubeAttr("cmid", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IStreamtubeProperty> colorscale(string val) => Interop.mkStreamtubeAttr("colorscale", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IStreamtubeProperty> colorscale(List<string[]> values) => Interop.mkStreamtubeAttr("colorscale", Bindings.flatten2DArrayIf1D(values));
        /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
        public static Box<IStreamtubeProperty> autocolorscale(bool val) => Interop.mkStreamtubeAttr("autocolorscale", val);
        /// Reverses the color mapping if true. If true, `cmin` will correspond to the last color in the array and `cmax` will correspond to the first color.
        public static Box<IStreamtubeProperty> reversescale(bool val) => Interop.mkStreamtubeAttr("reversescale", val);
        /// Determines whether or not a colorbar is displayed for this trace.
        public static Box<IStreamtubeProperty> showscale(bool val) => Interop.mkStreamtubeAttr("showscale", val);
        public static Box<IStreamtubeProperty> colorbar(params Box<IColorbarProperty>[] properties) => Interop.mkStreamtubeAttr("colorbar", Bindings.flattenProperties(properties));
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<IStreamtubeProperty> coloraxis(int anchorId) => Interop.mkStreamtubeAttr("coloraxis", anchorId > 1 ? $"coloraxis{anchorId}" : "");
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<IStreamtubeProperty> coloraxis(string val) => Interop.mkStreamtubeAttr("coloraxis", val);
        /// Sets the opacity of the surface. Please note that in the case of using high `opacity` values for example a value greater than or equal to 0.5 on two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent surfaces may not perfectly be sorted in depth by the webgl API. This behavior may be improved in the near future and is subject to change.
        public static Box<IStreamtubeProperty> opacity(int val) => Interop.mkStreamtubeAttr("opacity", val);
        /// Sets the opacity of the surface. Please note that in the case of using high `opacity` values for example a value greater than or equal to 0.5 on two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent surfaces may not perfectly be sorted in depth by the webgl API. This behavior may be improved in the near future and is subject to change.
        public static Box<IStreamtubeProperty> opacity(float val) => Interop.mkStreamtubeAttr("opacity", val);
        public static Box<IStreamtubeProperty> lightposition(params Box<ILightpositionProperty>[] properties) => Interop.mkStreamtubeAttr("lightposition", Bindings.flattenProperties(properties));
        public static Box<IStreamtubeProperty> lighting(params Box<ILightingProperty>[] properties) => Interop.mkStreamtubeAttr("lighting", Bindings.flattenProperties(properties));
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IStreamtubeProperty> hoverinfo(params Box<IStreamtubeProperty>[] properties) => Interop.mkStreamtubeAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        /// Sets a reference between this trace's 3D coordinate system and a 3D scene. If *scene* (the default value), the (x,y,z) coordinates refer to `layout.scene`. If *scene2*, the (x,y,z) coordinates refer to `layout.scene2`, and so on.
        public static Box<IStreamtubeProperty> scene(int anchorId) => Interop.mkStreamtubeAttr("scene", anchorId > 1 ? $"scene{anchorId}" : "");
        /// Sets a reference between this trace's 3D coordinate system and a 3D scene. If *scene* (the default value), the (x,y,z) coordinates refer to `layout.scene`. If *scene2*, the (x,y,z) coordinates refer to `layout.scene2`, and so on.
        public static Box<IStreamtubeProperty> scene(string val) => Interop.mkStreamtubeAttr("scene", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IStreamtubeProperty> idssrc(string val) => Interop.mkStreamtubeAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IStreamtubeProperty> customdatasrc(string val) => Interop.mkStreamtubeAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IStreamtubeProperty> metasrc(string val) => Interop.mkStreamtubeAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  x .
        public static Box<IStreamtubeProperty> xsrc(string val) => Interop.mkStreamtubeAttr("xsrc", val);
        /// Sets the source reference on plot.ly for  y .
        public static Box<IStreamtubeProperty> ysrc(string val) => Interop.mkStreamtubeAttr("ysrc", val);
        /// Sets the source reference on plot.ly for  z .
        public static Box<IStreamtubeProperty> zsrc(string val) => Interop.mkStreamtubeAttr("zsrc", val);
        /// Sets the source reference on plot.ly for  u .
        public static Box<IStreamtubeProperty> usrc(string val) => Interop.mkStreamtubeAttr("usrc", val);
        /// Sets the source reference on plot.ly for  v .
        public static Box<IStreamtubeProperty> vsrc(string val) => Interop.mkStreamtubeAttr("vsrc", val);
        /// Sets the source reference on plot.ly for  w .
        public static Box<IStreamtubeProperty> wsrc(string val) => Interop.mkStreamtubeAttr("wsrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IStreamtubeProperty> hovertemplatesrc(string val) => Interop.mkStreamtubeAttr("hovertemplatesrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IStreamtubeProperty> hoverinfosrc(string val) => Interop.mkStreamtubeAttr("hoverinfosrc", val);
    }

    public static partial class Streamtube
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IStreamtubeProperty> legendonly() => Interop.mkStreamtubeAttr("visible", "legendonly");
            public static Box<IStreamtubeProperty> _false() => Interop.mkStreamtubeAttr("visible", false);
            public static Box<IStreamtubeProperty> _true() => Interop.mkStreamtubeAttr("visible", true);
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IStreamtubeProperty> all() => Interop.mkStreamtubeAttr("hoverinfo", "all");
            public static Box<IStreamtubeProperty> none() => Interop.mkStreamtubeAttr("hoverinfo", "none");
            public static Box<IStreamtubeProperty> skip() => Interop.mkStreamtubeAttr("hoverinfo", "skip");
            public static Box<IStreamtubeProperty> divergence() => Interop.mkStreamtubeAttr("hoverinfo", "divergence");
            public static Box<IStreamtubeProperty> name() => Interop.mkStreamtubeAttr("hoverinfo", "name");
            public static Box<IStreamtubeProperty> norm() => Interop.mkStreamtubeAttr("hoverinfo", "norm");
            public static Box<IStreamtubeProperty> text() => Interop.mkStreamtubeAttr("hoverinfo", "text");
            public static Box<IStreamtubeProperty> u() => Interop.mkStreamtubeAttr("hoverinfo", "u");
            public static Box<IStreamtubeProperty> v() => Interop.mkStreamtubeAttr("hoverinfo", "v");
            public static Box<IStreamtubeProperty> w() => Interop.mkStreamtubeAttr("hoverinfo", "w");
            public static Box<IStreamtubeProperty> x() => Interop.mkStreamtubeAttr("hoverinfo", "x");
            public static Box<IStreamtubeProperty> y() => Interop.mkStreamtubeAttr("hoverinfo", "y");
            public static Box<IStreamtubeProperty> z() => Interop.mkStreamtubeAttr("hoverinfo", "z");
        }
    }
}