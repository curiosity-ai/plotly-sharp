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

    public static partial class Cone
    {
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IConeProperty> legendgroup(string val) => Interop.mkConeAttr("legendgroup", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IConeProperty> name(string val) => Interop.mkConeAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IConeProperty> uid(string val) => Interop.mkConeAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IConeProperty> ids(bool val) => Interop.mkConeAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IConeProperty> ids(params bool[] values) => Interop.mkConeAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IConeProperty> ids(System.DateTime val) => Interop.mkConeAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IConeProperty> ids(params System.DateTime[] values) => Interop.mkConeAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IConeProperty> ids(float val) => Interop.mkConeAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IConeProperty> ids(params float[] values) => Interop.mkConeAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IConeProperty> ids(int val) => Interop.mkConeAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IConeProperty> ids(params int[] values) => Interop.mkConeAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IConeProperty> ids(string val) => Interop.mkConeAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IConeProperty> ids(params string[] values) => Interop.mkConeAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IConeProperty> ids(IEnumerable<bool[]> values) => Interop.mkConeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IConeProperty> ids(List<bool[]> values) => Interop.mkConeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IConeProperty> ids(params bool[][] values) => Interop.mkConeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IConeProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkConeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IConeProperty> ids(List<string[]> values) => Interop.mkConeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IConeProperty> ids(params string[][] values) => Interop.mkConeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IConeProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkConeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IConeProperty> ids(List<int[]> values) => Interop.mkConeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IConeProperty> ids(params int[][] values) => Interop.mkConeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IConeProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkConeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IConeProperty> ids(List<float[]> values) => Interop.mkConeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IConeProperty> ids(params float[][] values) => Interop.mkConeAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IConeProperty> ids(Literals.PlotData[] values) => Interop.mkConeAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IConeProperty> ids(IEnumerable<bool?> values) => Interop.mkConeAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IConeProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkConeAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IConeProperty> ids(IEnumerable<int?> values) => Interop.mkConeAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IConeProperty> ids(IEnumerable<float?> values) => Interop.mkConeAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IConeProperty> customdata(bool val) => Interop.mkConeAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IConeProperty> customdata(params bool[] values) => Interop.mkConeAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IConeProperty> customdata(System.DateTime val) => Interop.mkConeAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IConeProperty> customdata(params System.DateTime[] values) => Interop.mkConeAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IConeProperty> customdata(float val) => Interop.mkConeAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IConeProperty> customdata(params float[] values) => Interop.mkConeAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IConeProperty> customdata(int val) => Interop.mkConeAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IConeProperty> customdata(params int[] values) => Interop.mkConeAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IConeProperty> customdata(string val) => Interop.mkConeAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IConeProperty> customdata(params string[] values) => Interop.mkConeAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IConeProperty> customdata(IEnumerable<bool[]> values) => Interop.mkConeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IConeProperty> customdata(List<bool[]> values) => Interop.mkConeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IConeProperty> customdata(params bool[][] values) => Interop.mkConeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IConeProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkConeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IConeProperty> customdata(List<string[]> values) => Interop.mkConeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IConeProperty> customdata(params string[][] values) => Interop.mkConeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IConeProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkConeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IConeProperty> customdata(List<int[]> values) => Interop.mkConeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IConeProperty> customdata(params int[][] values) => Interop.mkConeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IConeProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkConeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IConeProperty> customdata(List<float[]> values) => Interop.mkConeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IConeProperty> customdata(params float[][] values) => Interop.mkConeAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IConeProperty> customdata(Literals.PlotData[] values) => Interop.mkConeAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IConeProperty> customdata(IEnumerable<bool?> values) => Interop.mkConeAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IConeProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkConeAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IConeProperty> customdata(IEnumerable<int?> values) => Interop.mkConeAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IConeProperty> customdata(IEnumerable<float?> values) => Interop.mkConeAttr("customdata", values.ToArray());
        public static Box<IConeProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkConeAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IConeProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkConeAttr("stream", Bindings.flattenProperties(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IConeProperty> uirevision(bool val) => Interop.mkConeAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IConeProperty> uirevision(params bool[] values) => Interop.mkConeAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IConeProperty> uirevision(System.DateTime val) => Interop.mkConeAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IConeProperty> uirevision(params System.DateTime[] values) => Interop.mkConeAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IConeProperty> uirevision(int val) => Interop.mkConeAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IConeProperty> uirevision(params int[] values) => Interop.mkConeAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IConeProperty> uirevision(float val) => Interop.mkConeAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IConeProperty> uirevision(params float[] values) => Interop.mkConeAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IConeProperty> uirevision(string val) => Interop.mkConeAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IConeProperty> uirevision(params string[] values) => Interop.mkConeAttr("uirevision", values);
        /// Sets the x coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> x(bool val) => Interop.mkConeAttr("x", new[]{val});
        /// Sets the x coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> x(IEnumerable<bool> values) => Interop.mkConeAttr("x", values.ToArray());
        /// Sets the x coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> x(System.DateTime val) => Interop.mkConeAttr("x", new[]{val});
        /// Sets the x coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> x(IEnumerable<System.DateTime> values) => Interop.mkConeAttr("x", values.ToArray());
        /// Sets the x coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> x(float val) => Interop.mkConeAttr("x", new[]{val});
        /// Sets the x coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> x(IEnumerable<float> values) => Interop.mkConeAttr("x", values.ToArray());
        /// Sets the x coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> x(int val) => Interop.mkConeAttr("x", new[]{val});
        /// Sets the x coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> x(IEnumerable<int> values) => Interop.mkConeAttr("x", values.ToArray());
        /// Sets the x coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> x(string val) => Interop.mkConeAttr("x", new[]{val});
        /// Sets the x coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> x(IEnumerable<string> values) => Interop.mkConeAttr("x", values.ToArray());
        /// Sets the x coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> x(IEnumerable<bool[]> values) => Interop.mkConeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> x(List<bool[]> values) => Interop.mkConeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> x(params bool[][] values) => Interop.mkConeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> x(IEnumerable<IEnumerable<string>> values) => Interop.mkConeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> x(List<string[]> values) => Interop.mkConeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> x(params string[][] values) => Interop.mkConeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> x(IEnumerable<IEnumerable<int>> values) => Interop.mkConeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> x(List<int[]> values) => Interop.mkConeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> x(params int[][] values) => Interop.mkConeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> x(IEnumerable<IEnumerable<float>> values) => Interop.mkConeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> x(List<float[]> values) => Interop.mkConeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> x(params float[][] values) => Interop.mkConeAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> x(Literals.PlotData[] values) => Interop.mkConeAttr("x", values);
        /// Sets the x coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> x(IEnumerable<bool?> values) => Interop.mkConeAttr("x", values.ToArray());
        /// Sets the x coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> x(IEnumerable<System.DateTime?> values) => Interop.mkConeAttr("x", values.ToArray());
        /// Sets the x coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> x(IEnumerable<int?> values) => Interop.mkConeAttr("x", values.ToArray());
        /// Sets the x coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> x(IEnumerable<float?> values) => Interop.mkConeAttr("x", values.ToArray());
        /// Sets the y coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> y(bool val) => Interop.mkConeAttr("y", new[]{val});
        /// Sets the y coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> y(IEnumerable<bool> values) => Interop.mkConeAttr("y", values.ToArray());
        /// Sets the y coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> y(System.DateTime val) => Interop.mkConeAttr("y", new[]{val});
        /// Sets the y coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> y(IEnumerable<System.DateTime> values) => Interop.mkConeAttr("y", values.ToArray());
        /// Sets the y coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> y(float val) => Interop.mkConeAttr("y", new[]{val});
        /// Sets the y coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> y(IEnumerable<float> values) => Interop.mkConeAttr("y", values.ToArray());
        /// Sets the y coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> y(int val) => Interop.mkConeAttr("y", new[]{val});
        /// Sets the y coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> y(IEnumerable<int> values) => Interop.mkConeAttr("y", values.ToArray());
        /// Sets the y coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> y(string val) => Interop.mkConeAttr("y", new[]{val});
        /// Sets the y coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> y(IEnumerable<string> values) => Interop.mkConeAttr("y", values.ToArray());
        /// Sets the y coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> y(IEnumerable<bool[]> values) => Interop.mkConeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> y(List<bool[]> values) => Interop.mkConeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> y(params bool[][] values) => Interop.mkConeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> y(IEnumerable<IEnumerable<string>> values) => Interop.mkConeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> y(List<string[]> values) => Interop.mkConeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> y(params string[][] values) => Interop.mkConeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> y(IEnumerable<IEnumerable<int>> values) => Interop.mkConeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> y(List<int[]> values) => Interop.mkConeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> y(params int[][] values) => Interop.mkConeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> y(IEnumerable<IEnumerable<float>> values) => Interop.mkConeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> y(List<float[]> values) => Interop.mkConeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> y(params float[][] values) => Interop.mkConeAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> y(Literals.PlotData[] values) => Interop.mkConeAttr("y", values);
        /// Sets the y coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> y(IEnumerable<bool?> values) => Interop.mkConeAttr("y", values.ToArray());
        /// Sets the y coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> y(IEnumerable<System.DateTime?> values) => Interop.mkConeAttr("y", values.ToArray());
        /// Sets the y coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> y(IEnumerable<int?> values) => Interop.mkConeAttr("y", values.ToArray());
        /// Sets the y coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> y(IEnumerable<float?> values) => Interop.mkConeAttr("y", values.ToArray());
        /// Sets the z coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> z(bool val) => Interop.mkConeAttr("z", new[]{val});
        /// Sets the z coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> z(IEnumerable<bool> values) => Interop.mkConeAttr("z", values.ToArray());
        /// Sets the z coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> z(System.DateTime val) => Interop.mkConeAttr("z", new[]{val});
        /// Sets the z coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> z(IEnumerable<System.DateTime> values) => Interop.mkConeAttr("z", values.ToArray());
        /// Sets the z coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> z(float val) => Interop.mkConeAttr("z", new[]{val});
        /// Sets the z coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> z(IEnumerable<float> values) => Interop.mkConeAttr("z", values.ToArray());
        /// Sets the z coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> z(int val) => Interop.mkConeAttr("z", new[]{val});
        /// Sets the z coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> z(IEnumerable<int> values) => Interop.mkConeAttr("z", values.ToArray());
        /// Sets the z coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> z(string val) => Interop.mkConeAttr("z", new[]{val});
        /// Sets the z coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> z(IEnumerable<string> values) => Interop.mkConeAttr("z", values.ToArray());
        /// Sets the z coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> z(IEnumerable<bool[]> values) => Interop.mkConeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> z(List<bool[]> values) => Interop.mkConeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> z(params bool[][] values) => Interop.mkConeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> z(IEnumerable<IEnumerable<string>> values) => Interop.mkConeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> z(List<string[]> values) => Interop.mkConeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> z(params string[][] values) => Interop.mkConeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> z(IEnumerable<IEnumerable<int>> values) => Interop.mkConeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> z(List<int[]> values) => Interop.mkConeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> z(params int[][] values) => Interop.mkConeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> z(IEnumerable<IEnumerable<float>> values) => Interop.mkConeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> z(List<float[]> values) => Interop.mkConeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> z(params float[][] values) => Interop.mkConeAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> z(Literals.PlotData[] values) => Interop.mkConeAttr("z", values);
        /// Sets the z coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> z(IEnumerable<bool?> values) => Interop.mkConeAttr("z", values.ToArray());
        /// Sets the z coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> z(IEnumerable<System.DateTime?> values) => Interop.mkConeAttr("z", values.ToArray());
        /// Sets the z coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> z(IEnumerable<int?> values) => Interop.mkConeAttr("z", values.ToArray());
        /// Sets the z coordinates of the vector field and of the displayed cones.
        public static Box<IConeProperty> z(IEnumerable<float?> values) => Interop.mkConeAttr("z", values.ToArray());
        /// Sets the x components of the vector field.
        public static Box<IConeProperty> u(bool val) => Interop.mkConeAttr("u", new[]{val});
        /// Sets the x components of the vector field.
        public static Box<IConeProperty> u(params bool[] values) => Interop.mkConeAttr("u", values);
        /// Sets the x components of the vector field.
        public static Box<IConeProperty> u(System.DateTime val) => Interop.mkConeAttr("u", new[]{val});
        /// Sets the x components of the vector field.
        public static Box<IConeProperty> u(params System.DateTime[] values) => Interop.mkConeAttr("u", values);
        /// Sets the x components of the vector field.
        public static Box<IConeProperty> u(float val) => Interop.mkConeAttr("u", new[]{val});
        /// Sets the x components of the vector field.
        public static Box<IConeProperty> u(params float[] values) => Interop.mkConeAttr("u", values);
        /// Sets the x components of the vector field.
        public static Box<IConeProperty> u(int val) => Interop.mkConeAttr("u", new[]{val});
        /// Sets the x components of the vector field.
        public static Box<IConeProperty> u(params int[] values) => Interop.mkConeAttr("u", values);
        /// Sets the x components of the vector field.
        public static Box<IConeProperty> u(string val) => Interop.mkConeAttr("u", new[]{val});
        /// Sets the x components of the vector field.
        public static Box<IConeProperty> u(params string[] values) => Interop.mkConeAttr("u", values);
        /// Sets the x components of the vector field.
        public static Box<IConeProperty> u(IEnumerable<bool[]> values) => Interop.mkConeAttr("u", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x components of the vector field.
        public static Box<IConeProperty> u(List<bool[]> values) => Interop.mkConeAttr("u", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x components of the vector field.
        public static Box<IConeProperty> u(params bool[][] values) => Interop.mkConeAttr("u", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x components of the vector field.
        public static Box<IConeProperty> u(IEnumerable<IEnumerable<string>> values) => Interop.mkConeAttr("u", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x components of the vector field.
        public static Box<IConeProperty> u(List<string[]> values) => Interop.mkConeAttr("u", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x components of the vector field.
        public static Box<IConeProperty> u(params string[][] values) => Interop.mkConeAttr("u", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x components of the vector field.
        public static Box<IConeProperty> u(IEnumerable<IEnumerable<int>> values) => Interop.mkConeAttr("u", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x components of the vector field.
        public static Box<IConeProperty> u(List<int[]> values) => Interop.mkConeAttr("u", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x components of the vector field.
        public static Box<IConeProperty> u(params int[][] values) => Interop.mkConeAttr("u", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x components of the vector field.
        public static Box<IConeProperty> u(IEnumerable<IEnumerable<float>> values) => Interop.mkConeAttr("u", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x components of the vector field.
        public static Box<IConeProperty> u(List<float[]> values) => Interop.mkConeAttr("u", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x components of the vector field.
        public static Box<IConeProperty> u(params float[][] values) => Interop.mkConeAttr("u", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x components of the vector field.
        public static Box<IConeProperty> u(Literals.PlotData[] values) => Interop.mkConeAttr("u", values);
        /// Sets the x components of the vector field.
        public static Box<IConeProperty> u(IEnumerable<bool?> values) => Interop.mkConeAttr("u", values.ToArray());
        /// Sets the x components of the vector field.
        public static Box<IConeProperty> u(IEnumerable<System.DateTime?> values) => Interop.mkConeAttr("u", values.ToArray());
        /// Sets the x components of the vector field.
        public static Box<IConeProperty> u(IEnumerable<int?> values) => Interop.mkConeAttr("u", values.ToArray());
        /// Sets the x components of the vector field.
        public static Box<IConeProperty> u(IEnumerable<float?> values) => Interop.mkConeAttr("u", values.ToArray());
        /// Sets the y components of the vector field.
        public static Box<IConeProperty> v(bool val) => Interop.mkConeAttr("v", new[]{val});
        /// Sets the y components of the vector field.
        public static Box<IConeProperty> v(params bool[] values) => Interop.mkConeAttr("v", values);
        /// Sets the y components of the vector field.
        public static Box<IConeProperty> v(System.DateTime val) => Interop.mkConeAttr("v", new[]{val});
        /// Sets the y components of the vector field.
        public static Box<IConeProperty> v(params System.DateTime[] values) => Interop.mkConeAttr("v", values);
        /// Sets the y components of the vector field.
        public static Box<IConeProperty> v(float val) => Interop.mkConeAttr("v", new[]{val});
        /// Sets the y components of the vector field.
        public static Box<IConeProperty> v(params float[] values) => Interop.mkConeAttr("v", values);
        /// Sets the y components of the vector field.
        public static Box<IConeProperty> v(int val) => Interop.mkConeAttr("v", new[]{val});
        /// Sets the y components of the vector field.
        public static Box<IConeProperty> v(params int[] values) => Interop.mkConeAttr("v", values);
        /// Sets the y components of the vector field.
        public static Box<IConeProperty> v(string val) => Interop.mkConeAttr("v", new[]{val});
        /// Sets the y components of the vector field.
        public static Box<IConeProperty> v(params string[] values) => Interop.mkConeAttr("v", values);
        /// Sets the y components of the vector field.
        public static Box<IConeProperty> v(IEnumerable<bool[]> values) => Interop.mkConeAttr("v", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y components of the vector field.
        public static Box<IConeProperty> v(List<bool[]> values) => Interop.mkConeAttr("v", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y components of the vector field.
        public static Box<IConeProperty> v(params bool[][] values) => Interop.mkConeAttr("v", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y components of the vector field.
        public static Box<IConeProperty> v(IEnumerable<IEnumerable<string>> values) => Interop.mkConeAttr("v", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y components of the vector field.
        public static Box<IConeProperty> v(List<string[]> values) => Interop.mkConeAttr("v", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y components of the vector field.
        public static Box<IConeProperty> v(params string[][] values) => Interop.mkConeAttr("v", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y components of the vector field.
        public static Box<IConeProperty> v(IEnumerable<IEnumerable<int>> values) => Interop.mkConeAttr("v", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y components of the vector field.
        public static Box<IConeProperty> v(List<int[]> values) => Interop.mkConeAttr("v", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y components of the vector field.
        public static Box<IConeProperty> v(params int[][] values) => Interop.mkConeAttr("v", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y components of the vector field.
        public static Box<IConeProperty> v(IEnumerable<IEnumerable<float>> values) => Interop.mkConeAttr("v", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y components of the vector field.
        public static Box<IConeProperty> v(List<float[]> values) => Interop.mkConeAttr("v", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y components of the vector field.
        public static Box<IConeProperty> v(params float[][] values) => Interop.mkConeAttr("v", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y components of the vector field.
        public static Box<IConeProperty> v(Literals.PlotData[] values) => Interop.mkConeAttr("v", values);
        /// Sets the y components of the vector field.
        public static Box<IConeProperty> v(IEnumerable<bool?> values) => Interop.mkConeAttr("v", values.ToArray());
        /// Sets the y components of the vector field.
        public static Box<IConeProperty> v(IEnumerable<System.DateTime?> values) => Interop.mkConeAttr("v", values.ToArray());
        /// Sets the y components of the vector field.
        public static Box<IConeProperty> v(IEnumerable<int?> values) => Interop.mkConeAttr("v", values.ToArray());
        /// Sets the y components of the vector field.
        public static Box<IConeProperty> v(IEnumerable<float?> values) => Interop.mkConeAttr("v", values.ToArray());
        /// Sets the z components of the vector field.
        public static Box<IConeProperty> w(bool val) => Interop.mkConeAttr("w", new[]{val});
        /// Sets the z components of the vector field.
        public static Box<IConeProperty> w(params bool[] values) => Interop.mkConeAttr("w", values);
        /// Sets the z components of the vector field.
        public static Box<IConeProperty> w(System.DateTime val) => Interop.mkConeAttr("w", new[]{val});
        /// Sets the z components of the vector field.
        public static Box<IConeProperty> w(params System.DateTime[] values) => Interop.mkConeAttr("w", values);
        /// Sets the z components of the vector field.
        public static Box<IConeProperty> w(float val) => Interop.mkConeAttr("w", new[]{val});
        /// Sets the z components of the vector field.
        public static Box<IConeProperty> w(params float[] values) => Interop.mkConeAttr("w", values);
        /// Sets the z components of the vector field.
        public static Box<IConeProperty> w(int val) => Interop.mkConeAttr("w", new[]{val});
        /// Sets the z components of the vector field.
        public static Box<IConeProperty> w(params int[] values) => Interop.mkConeAttr("w", values);
        /// Sets the z components of the vector field.
        public static Box<IConeProperty> w(string val) => Interop.mkConeAttr("w", new[]{val});
        /// Sets the z components of the vector field.
        public static Box<IConeProperty> w(params string[] values) => Interop.mkConeAttr("w", values);
        /// Sets the z components of the vector field.
        public static Box<IConeProperty> w(IEnumerable<bool[]> values) => Interop.mkConeAttr("w", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z components of the vector field.
        public static Box<IConeProperty> w(List<bool[]> values) => Interop.mkConeAttr("w", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z components of the vector field.
        public static Box<IConeProperty> w(params bool[][] values) => Interop.mkConeAttr("w", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z components of the vector field.
        public static Box<IConeProperty> w(IEnumerable<IEnumerable<string>> values) => Interop.mkConeAttr("w", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z components of the vector field.
        public static Box<IConeProperty> w(List<string[]> values) => Interop.mkConeAttr("w", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z components of the vector field.
        public static Box<IConeProperty> w(params string[][] values) => Interop.mkConeAttr("w", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z components of the vector field.
        public static Box<IConeProperty> w(IEnumerable<IEnumerable<int>> values) => Interop.mkConeAttr("w", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z components of the vector field.
        public static Box<IConeProperty> w(List<int[]> values) => Interop.mkConeAttr("w", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z components of the vector field.
        public static Box<IConeProperty> w(params int[][] values) => Interop.mkConeAttr("w", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z components of the vector field.
        public static Box<IConeProperty> w(IEnumerable<IEnumerable<float>> values) => Interop.mkConeAttr("w", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z components of the vector field.
        public static Box<IConeProperty> w(List<float[]> values) => Interop.mkConeAttr("w", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z components of the vector field.
        public static Box<IConeProperty> w(params float[][] values) => Interop.mkConeAttr("w", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z components of the vector field.
        public static Box<IConeProperty> w(Literals.PlotData[] values) => Interop.mkConeAttr("w", values);
        /// Sets the z components of the vector field.
        public static Box<IConeProperty> w(IEnumerable<bool?> values) => Interop.mkConeAttr("w", values.ToArray());
        /// Sets the z components of the vector field.
        public static Box<IConeProperty> w(IEnumerable<System.DateTime?> values) => Interop.mkConeAttr("w", values.ToArray());
        /// Sets the z components of the vector field.
        public static Box<IConeProperty> w(IEnumerable<int?> values) => Interop.mkConeAttr("w", values.ToArray());
        /// Sets the z components of the vector field.
        public static Box<IConeProperty> w(IEnumerable<float?> values) => Interop.mkConeAttr("w", values.ToArray());
        /// Adjusts the cone size scaling. The size of the cones is determined by their u/v/w norm multiplied a factor and `sizeref`. This factor (computed internally) corresponds to the minimum \"time\" to travel across two successive x/y/z positions at the average velocity of those two successive positions. All cones in a given trace use the same factor. With `sizemode` set to *scaled*, `sizeref` is unitless, its default value is *0.5* With `sizemode` set to *absolute*, `sizeref` has the same units as the u/v/w vector field, its the default value is half the sample's maximum vector norm.
        public static Box<IConeProperty> sizeref(int val) => Interop.mkConeAttr("sizeref", val);
        /// Adjusts the cone size scaling. The size of the cones is determined by their u/v/w norm multiplied a factor and `sizeref`. This factor (computed internally) corresponds to the minimum \"time\" to travel across two successive x/y/z positions at the average velocity of those two successive positions. All cones in a given trace use the same factor. With `sizemode` set to *scaled*, `sizeref` is unitless, its default value is *0.5* With `sizemode` set to *absolute*, `sizeref` has the same units as the u/v/w vector field, its the default value is half the sample's maximum vector norm.
        public static Box<IConeProperty> sizeref(float val) => Interop.mkConeAttr("sizeref", val);
        /// Sets the text elements associated with the cones. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IConeProperty> text(string val) => Interop.mkConeAttr("text", val);
        /// Sets the text elements associated with the cones. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IConeProperty> text(IEnumerable<string> values) => Interop.mkConeAttr("text", values.ToArray());
        /// Same as `text`.
        public static Box<IConeProperty> hovertext(string val) => Interop.mkConeAttr("hovertext", val);
        /// Same as `text`.
        public static Box<IConeProperty> hovertext(IEnumerable<string> values) => Interop.mkConeAttr("hovertext", values.ToArray());
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variable `norm` Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IConeProperty> hovertemplate(string val) => Interop.mkConeAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variable `norm` Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IConeProperty> hovertemplate(IEnumerable<string> values) => Interop.mkConeAttr("hovertemplate", values.ToArray());
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IConeProperty> showlegend(bool val) => Interop.mkConeAttr("showlegend", val);
        /// Determines whether or not the color domain is computed with respect to the input data (here u/v/w norm) or the bounds set in `cmin` and `cmax`  Defaults to `false` when `cmin` and `cmax` are set by the user.
        public static Box<IConeProperty> cauto(bool val) => Interop.mkConeAttr("cauto", val);
        /// Sets the lower bound of the color domain. Value should have the same units as u/v/w norm and if set, `cmax` must be set as well.
        public static Box<IConeProperty> cmin(int val) => Interop.mkConeAttr("cmin", val);
        /// Sets the lower bound of the color domain. Value should have the same units as u/v/w norm and if set, `cmax` must be set as well.
        public static Box<IConeProperty> cmin(float val) => Interop.mkConeAttr("cmin", val);
        /// Sets the upper bound of the color domain. Value should have the same units as u/v/w norm and if set, `cmin` must be set as well.
        public static Box<IConeProperty> cmax(int val) => Interop.mkConeAttr("cmax", val);
        /// Sets the upper bound of the color domain. Value should have the same units as u/v/w norm and if set, `cmin` must be set as well.
        public static Box<IConeProperty> cmax(float val) => Interop.mkConeAttr("cmax", val);
        /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as u/v/w norm. Has no effect when `cauto` is `false`.
        public static Box<IConeProperty> cmid(int val) => Interop.mkConeAttr("cmid", val);
        /// Sets the mid-point of the color domain by scaling `cmin` and/or `cmax` to be equidistant to this point. Value should have the same units as u/v/w norm. Has no effect when `cauto` is `false`.
        public static Box<IConeProperty> cmid(float val) => Interop.mkConeAttr("cmid", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IConeProperty> colorscale(string val) => Interop.mkConeAttr("colorscale", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`cmin` and `cmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IConeProperty> colorscale(List<string[]> values) => Interop.mkConeAttr("colorscale", Bindings.flatten2DArrayIf1D(values));
        /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
        public static Box<IConeProperty> autocolorscale(bool val) => Interop.mkConeAttr("autocolorscale", val);
        /// Reverses the color mapping if true. If true, `cmin` will correspond to the last color in the array and `cmax` will correspond to the first color.
        public static Box<IConeProperty> reversescale(bool val) => Interop.mkConeAttr("reversescale", val);
        /// Determines whether or not a colorbar is displayed for this trace.
        public static Box<IConeProperty> showscale(bool val) => Interop.mkConeAttr("showscale", val);
        public static Box<IConeProperty> colorbar(params Box<IColorbarProperty>[] properties) => Interop.mkConeAttr("colorbar", Bindings.flattenProperties(properties));
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<IConeProperty> coloraxis(int anchorId) => Interop.mkConeAttr("coloraxis", anchorId > 1 ? $"coloraxis{anchorId}" : "");
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<IConeProperty> coloraxis(string val) => Interop.mkConeAttr("coloraxis", val);
        /// Sets the opacity of the surface. Please note that in the case of using high `opacity` values for example a value greater than or equal to 0.5 on two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent surfaces may not perfectly be sorted in depth by the webgl API. This behavior may be improved in the near future and is subject to change.
        public static Box<IConeProperty> opacity(int val) => Interop.mkConeAttr("opacity", val);
        /// Sets the opacity of the surface. Please note that in the case of using high `opacity` values for example a value greater than or equal to 0.5 on two surfaces (and 0.25 with four surfaces), an overlay of multiple transparent surfaces may not perfectly be sorted in depth by the webgl API. This behavior may be improved in the near future and is subject to change.
        public static Box<IConeProperty> opacity(float val) => Interop.mkConeAttr("opacity", val);
        public static Box<IConeProperty> lightposition(params Box<ILightpositionProperty>[] properties) => Interop.mkConeAttr("lightposition", Bindings.flattenProperties(properties));
        public static Box<IConeProperty> lighting(params Box<ILightingProperty>[] properties) => Interop.mkConeAttr("lighting", Bindings.flattenProperties(properties));
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IConeProperty> hoverinfo(params Box<IConeProperty>[] properties) => Interop.mkConeAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        /// Sets a reference between this trace's 3D coordinate system and a 3D scene. If *scene* (the default value), the (x,y,z) coordinates refer to `layout.scene`. If *scene2*, the (x,y,z) coordinates refer to `layout.scene2`, and so on.
        public static Box<IConeProperty> scene(int anchorId) => Interop.mkConeAttr("scene", anchorId > 1 ? $"scene{anchorId}" : "");
        /// Sets a reference between this trace's 3D coordinate system and a 3D scene. If *scene* (the default value), the (x,y,z) coordinates refer to `layout.scene`. If *scene2*, the (x,y,z) coordinates refer to `layout.scene2`, and so on.
        public static Box<IConeProperty> scene(string val) => Interop.mkConeAttr("scene", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IConeProperty> idssrc(string val) => Interop.mkConeAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IConeProperty> customdatasrc(string val) => Interop.mkConeAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IConeProperty> metasrc(string val) => Interop.mkConeAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  x .
        public static Box<IConeProperty> xsrc(string val) => Interop.mkConeAttr("xsrc", val);
        /// Sets the source reference on plot.ly for  y .
        public static Box<IConeProperty> ysrc(string val) => Interop.mkConeAttr("ysrc", val);
        /// Sets the source reference on plot.ly for  z .
        public static Box<IConeProperty> zsrc(string val) => Interop.mkConeAttr("zsrc", val);
        /// Sets the source reference on plot.ly for  u .
        public static Box<IConeProperty> usrc(string val) => Interop.mkConeAttr("usrc", val);
        /// Sets the source reference on plot.ly for  v .
        public static Box<IConeProperty> vsrc(string val) => Interop.mkConeAttr("vsrc", val);
        /// Sets the source reference on plot.ly for  w .
        public static Box<IConeProperty> wsrc(string val) => Interop.mkConeAttr("wsrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IConeProperty> textsrc(string val) => Interop.mkConeAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IConeProperty> hovertextsrc(string val) => Interop.mkConeAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IConeProperty> hovertemplatesrc(string val) => Interop.mkConeAttr("hovertemplatesrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IConeProperty> hoverinfosrc(string val) => Interop.mkConeAttr("hoverinfosrc", val);
    }

    public static partial class Cone
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IConeProperty> legendonly() => Interop.mkConeAttr("visible", "legendonly");
            public static Box<IConeProperty> _false() => Interop.mkConeAttr("visible", false);
            public static Box<IConeProperty> _true() => Interop.mkConeAttr("visible", true);
        }

        /// Determines whether `sizeref` is set as a *scaled* (i.e unitless) scalar (normalized by the max u/v/w norm in the vector field) or as *absolute* value (in the same units as the vector field).
        public static partial class Sizemode
        {
            public static Box<IConeProperty> absolute() => Interop.mkConeAttr("sizemode", "absolute");
            public static Box<IConeProperty> scaled() => Interop.mkConeAttr("sizemode", "scaled");
        }

        /// Sets the cones' anchor with respect to their x/y/z positions. Note that *cm* denote the cone's center of mass which corresponds to 1/4 from the tail to tip.
        public static partial class Anchor
        {
            public static Box<IConeProperty> center() => Interop.mkConeAttr("anchor", "center");
            public static Box<IConeProperty> cm() => Interop.mkConeAttr("anchor", "cm");
            public static Box<IConeProperty> tail() => Interop.mkConeAttr("anchor", "tail");
            public static Box<IConeProperty> tip() => Interop.mkConeAttr("anchor", "tip");
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IConeProperty> all() => Interop.mkConeAttr("hoverinfo", "all");
            public static Box<IConeProperty> none() => Interop.mkConeAttr("hoverinfo", "none");
            public static Box<IConeProperty> skip() => Interop.mkConeAttr("hoverinfo", "skip");
            public static Box<IConeProperty> name() => Interop.mkConeAttr("hoverinfo", "name");
            public static Box<IConeProperty> norm() => Interop.mkConeAttr("hoverinfo", "norm");
            public static Box<IConeProperty> text() => Interop.mkConeAttr("hoverinfo", "text");
            public static Box<IConeProperty> u() => Interop.mkConeAttr("hoverinfo", "u");
            public static Box<IConeProperty> v() => Interop.mkConeAttr("hoverinfo", "v");
            public static Box<IConeProperty> w() => Interop.mkConeAttr("hoverinfo", "w");
            public static Box<IConeProperty> x() => Interop.mkConeAttr("hoverinfo", "x");
            public static Box<IConeProperty> y() => Interop.mkConeAttr("hoverinfo", "y");
            public static Box<IConeProperty> z() => Interop.mkConeAttr("hoverinfo", "z");
        }
    }
}