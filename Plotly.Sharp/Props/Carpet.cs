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

    public static partial class Carpet
    {
        /// Sets the opacity of the trace.
        public static Box<ICarpetProperty> opacity(int val) => Interop.mkCarpetAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<ICarpetProperty> opacity(float val) => Interop.mkCarpetAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<ICarpetProperty> name(string val) => Interop.mkCarpetAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<ICarpetProperty> uid(string val) => Interop.mkCarpetAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICarpetProperty> ids(bool val) => Interop.mkCarpetAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICarpetProperty> ids(params bool[] values) => Interop.mkCarpetAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICarpetProperty> ids(System.DateTime val) => Interop.mkCarpetAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICarpetProperty> ids(params System.DateTime[] values) => Interop.mkCarpetAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICarpetProperty> ids(float val) => Interop.mkCarpetAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICarpetProperty> ids(params float[] values) => Interop.mkCarpetAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICarpetProperty> ids(int val) => Interop.mkCarpetAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICarpetProperty> ids(params int[] values) => Interop.mkCarpetAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICarpetProperty> ids(string val) => Interop.mkCarpetAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICarpetProperty> ids(params string[] values) => Interop.mkCarpetAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICarpetProperty> ids(IEnumerable<bool[]> values) => Interop.mkCarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICarpetProperty> ids(List<bool[]> values) => Interop.mkCarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICarpetProperty> ids(params bool[][] values) => Interop.mkCarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICarpetProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkCarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICarpetProperty> ids(List<string[]> values) => Interop.mkCarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICarpetProperty> ids(params string[][] values) => Interop.mkCarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICarpetProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkCarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICarpetProperty> ids(List<int[]> values) => Interop.mkCarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICarpetProperty> ids(params int[][] values) => Interop.mkCarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICarpetProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkCarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICarpetProperty> ids(List<float[]> values) => Interop.mkCarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICarpetProperty> ids(params float[][] values) => Interop.mkCarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICarpetProperty> ids(Literals.PlotData[] values) => Interop.mkCarpetAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICarpetProperty> ids(IEnumerable<bool?> values) => Interop.mkCarpetAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICarpetProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkCarpetAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICarpetProperty> ids(IEnumerable<int?> values) => Interop.mkCarpetAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICarpetProperty> ids(IEnumerable<float?> values) => Interop.mkCarpetAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICarpetProperty> customdata(bool val) => Interop.mkCarpetAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICarpetProperty> customdata(params bool[] values) => Interop.mkCarpetAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICarpetProperty> customdata(System.DateTime val) => Interop.mkCarpetAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICarpetProperty> customdata(params System.DateTime[] values) => Interop.mkCarpetAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICarpetProperty> customdata(float val) => Interop.mkCarpetAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICarpetProperty> customdata(params float[] values) => Interop.mkCarpetAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICarpetProperty> customdata(int val) => Interop.mkCarpetAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICarpetProperty> customdata(params int[] values) => Interop.mkCarpetAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICarpetProperty> customdata(string val) => Interop.mkCarpetAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICarpetProperty> customdata(params string[] values) => Interop.mkCarpetAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICarpetProperty> customdata(IEnumerable<bool[]> values) => Interop.mkCarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICarpetProperty> customdata(List<bool[]> values) => Interop.mkCarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICarpetProperty> customdata(params bool[][] values) => Interop.mkCarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICarpetProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkCarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICarpetProperty> customdata(List<string[]> values) => Interop.mkCarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICarpetProperty> customdata(params string[][] values) => Interop.mkCarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICarpetProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkCarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICarpetProperty> customdata(List<int[]> values) => Interop.mkCarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICarpetProperty> customdata(params int[][] values) => Interop.mkCarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICarpetProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkCarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICarpetProperty> customdata(List<float[]> values) => Interop.mkCarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICarpetProperty> customdata(params float[][] values) => Interop.mkCarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICarpetProperty> customdata(Literals.PlotData[] values) => Interop.mkCarpetAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICarpetProperty> customdata(IEnumerable<bool?> values) => Interop.mkCarpetAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICarpetProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkCarpetAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICarpetProperty> customdata(IEnumerable<int?> values) => Interop.mkCarpetAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICarpetProperty> customdata(IEnumerable<float?> values) => Interop.mkCarpetAttr("customdata", values.ToArray());
        public static Box<ICarpetProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkCarpetAttr("stream", Bindings.flattenProperties(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ICarpetProperty> uirevision(bool val) => Interop.mkCarpetAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ICarpetProperty> uirevision(params bool[] values) => Interop.mkCarpetAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ICarpetProperty> uirevision(System.DateTime val) => Interop.mkCarpetAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ICarpetProperty> uirevision(params System.DateTime[] values) => Interop.mkCarpetAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ICarpetProperty> uirevision(int val) => Interop.mkCarpetAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ICarpetProperty> uirevision(params int[] values) => Interop.mkCarpetAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ICarpetProperty> uirevision(float val) => Interop.mkCarpetAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ICarpetProperty> uirevision(params float[] values) => Interop.mkCarpetAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ICarpetProperty> uirevision(string val) => Interop.mkCarpetAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ICarpetProperty> uirevision(params string[] values) => Interop.mkCarpetAttr("uirevision", values);
        /// An identifier for this carpet, so that `scattercarpet` and `contourcarpet` traces can specify a carpet plot on which they lie
        public static Box<ICarpetProperty> carpet(string val) => Interop.mkCarpetAttr("carpet", val);
        /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
        public static Box<ICarpetProperty> x(bool val) => Interop.mkCarpetAttr("x", new[]{val});
        /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
        public static Box<ICarpetProperty> x(IEnumerable<bool> values) => Interop.mkCarpetAttr("x", values.ToArray());
        /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
        public static Box<ICarpetProperty> x(System.DateTime val) => Interop.mkCarpetAttr("x", new[]{val});
        /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
        public static Box<ICarpetProperty> x(IEnumerable<System.DateTime> values) => Interop.mkCarpetAttr("x", values.ToArray());
        /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
        public static Box<ICarpetProperty> x(float val) => Interop.mkCarpetAttr("x", new[]{val});
        /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
        public static Box<ICarpetProperty> x(IEnumerable<float> values) => Interop.mkCarpetAttr("x", values.ToArray());
        /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
        public static Box<ICarpetProperty> x(int val) => Interop.mkCarpetAttr("x", new[]{val});
        /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
        public static Box<ICarpetProperty> x(IEnumerable<int> values) => Interop.mkCarpetAttr("x", values.ToArray());
        /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
        public static Box<ICarpetProperty> x(string val) => Interop.mkCarpetAttr("x", new[]{val});
        /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
        public static Box<ICarpetProperty> x(IEnumerable<string> values) => Interop.mkCarpetAttr("x", values.ToArray());
        /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
        public static Box<ICarpetProperty> x(IEnumerable<bool[]> values) => Interop.mkCarpetAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
        public static Box<ICarpetProperty> x(List<bool[]> values) => Interop.mkCarpetAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
        public static Box<ICarpetProperty> x(params bool[][] values) => Interop.mkCarpetAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
        public static Box<ICarpetProperty> x(IEnumerable<IEnumerable<string>> values) => Interop.mkCarpetAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
        public static Box<ICarpetProperty> x(List<string[]> values) => Interop.mkCarpetAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
        public static Box<ICarpetProperty> x(params string[][] values) => Interop.mkCarpetAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
        public static Box<ICarpetProperty> x(IEnumerable<IEnumerable<int>> values) => Interop.mkCarpetAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
        public static Box<ICarpetProperty> x(List<int[]> values) => Interop.mkCarpetAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
        public static Box<ICarpetProperty> x(params int[][] values) => Interop.mkCarpetAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
        public static Box<ICarpetProperty> x(IEnumerable<IEnumerable<float>> values) => Interop.mkCarpetAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
        public static Box<ICarpetProperty> x(List<float[]> values) => Interop.mkCarpetAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
        public static Box<ICarpetProperty> x(params float[][] values) => Interop.mkCarpetAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
        public static Box<ICarpetProperty> x(Literals.PlotData[] values) => Interop.mkCarpetAttr("x", values);
        /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
        public static Box<ICarpetProperty> x(IEnumerable<bool?> values) => Interop.mkCarpetAttr("x", values.ToArray());
        /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
        public static Box<ICarpetProperty> x(IEnumerable<System.DateTime?> values) => Interop.mkCarpetAttr("x", values.ToArray());
        /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
        public static Box<ICarpetProperty> x(IEnumerable<int?> values) => Interop.mkCarpetAttr("x", values.ToArray());
        /// A two dimensional array of x coordinates at each carpet point. If ommitted, the plot is a cheater plot and the xaxis is hidden by default.
        public static Box<ICarpetProperty> x(IEnumerable<float?> values) => Interop.mkCarpetAttr("x", values.ToArray());
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> y(bool val) => Interop.mkCarpetAttr("y", new[]{val});
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> y(IEnumerable<bool> values) => Interop.mkCarpetAttr("y", values.ToArray());
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> y(System.DateTime val) => Interop.mkCarpetAttr("y", new[]{val});
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> y(IEnumerable<System.DateTime> values) => Interop.mkCarpetAttr("y", values.ToArray());
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> y(float val) => Interop.mkCarpetAttr("y", new[]{val});
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> y(IEnumerable<float> values) => Interop.mkCarpetAttr("y", values.ToArray());
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> y(int val) => Interop.mkCarpetAttr("y", new[]{val});
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> y(IEnumerable<int> values) => Interop.mkCarpetAttr("y", values.ToArray());
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> y(string val) => Interop.mkCarpetAttr("y", new[]{val});
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> y(IEnumerable<string> values) => Interop.mkCarpetAttr("y", values.ToArray());
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> y(IEnumerable<bool[]> values) => Interop.mkCarpetAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> y(List<bool[]> values) => Interop.mkCarpetAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> y(params bool[][] values) => Interop.mkCarpetAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> y(IEnumerable<IEnumerable<string>> values) => Interop.mkCarpetAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> y(List<string[]> values) => Interop.mkCarpetAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> y(params string[][] values) => Interop.mkCarpetAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> y(IEnumerable<IEnumerable<int>> values) => Interop.mkCarpetAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> y(List<int[]> values) => Interop.mkCarpetAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> y(params int[][] values) => Interop.mkCarpetAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> y(IEnumerable<IEnumerable<float>> values) => Interop.mkCarpetAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> y(List<float[]> values) => Interop.mkCarpetAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> y(params float[][] values) => Interop.mkCarpetAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> y(Literals.PlotData[] values) => Interop.mkCarpetAttr("y", values);
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> y(IEnumerable<bool?> values) => Interop.mkCarpetAttr("y", values.ToArray());
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> y(IEnumerable<System.DateTime?> values) => Interop.mkCarpetAttr("y", values.ToArray());
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> y(IEnumerable<int?> values) => Interop.mkCarpetAttr("y", values.ToArray());
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> y(IEnumerable<float?> values) => Interop.mkCarpetAttr("y", values.ToArray());
        /// An array containing values of the first parameter value
        public static Box<ICarpetProperty> a(bool val) => Interop.mkCarpetAttr("a", new[]{val});
        /// An array containing values of the first parameter value
        public static Box<ICarpetProperty> a(params bool[] values) => Interop.mkCarpetAttr("a", values);
        /// An array containing values of the first parameter value
        public static Box<ICarpetProperty> a(System.DateTime val) => Interop.mkCarpetAttr("a", new[]{val});
        /// An array containing values of the first parameter value
        public static Box<ICarpetProperty> a(params System.DateTime[] values) => Interop.mkCarpetAttr("a", values);
        /// An array containing values of the first parameter value
        public static Box<ICarpetProperty> a(float val) => Interop.mkCarpetAttr("a", new[]{val});
        /// An array containing values of the first parameter value
        public static Box<ICarpetProperty> a(params float[] values) => Interop.mkCarpetAttr("a", values);
        /// An array containing values of the first parameter value
        public static Box<ICarpetProperty> a(int val) => Interop.mkCarpetAttr("a", new[]{val});
        /// An array containing values of the first parameter value
        public static Box<ICarpetProperty> a(params int[] values) => Interop.mkCarpetAttr("a", values);
        /// An array containing values of the first parameter value
        public static Box<ICarpetProperty> a(string val) => Interop.mkCarpetAttr("a", new[]{val});
        /// An array containing values of the first parameter value
        public static Box<ICarpetProperty> a(params string[] values) => Interop.mkCarpetAttr("a", values);
        /// An array containing values of the first parameter value
        public static Box<ICarpetProperty> a(IEnumerable<bool[]> values) => Interop.mkCarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// An array containing values of the first parameter value
        public static Box<ICarpetProperty> a(List<bool[]> values) => Interop.mkCarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// An array containing values of the first parameter value
        public static Box<ICarpetProperty> a(params bool[][] values) => Interop.mkCarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// An array containing values of the first parameter value
        public static Box<ICarpetProperty> a(IEnumerable<IEnumerable<string>> values) => Interop.mkCarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// An array containing values of the first parameter value
        public static Box<ICarpetProperty> a(List<string[]> values) => Interop.mkCarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// An array containing values of the first parameter value
        public static Box<ICarpetProperty> a(params string[][] values) => Interop.mkCarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// An array containing values of the first parameter value
        public static Box<ICarpetProperty> a(IEnumerable<IEnumerable<int>> values) => Interop.mkCarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// An array containing values of the first parameter value
        public static Box<ICarpetProperty> a(List<int[]> values) => Interop.mkCarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// An array containing values of the first parameter value
        public static Box<ICarpetProperty> a(params int[][] values) => Interop.mkCarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// An array containing values of the first parameter value
        public static Box<ICarpetProperty> a(IEnumerable<IEnumerable<float>> values) => Interop.mkCarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// An array containing values of the first parameter value
        public static Box<ICarpetProperty> a(List<float[]> values) => Interop.mkCarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// An array containing values of the first parameter value
        public static Box<ICarpetProperty> a(params float[][] values) => Interop.mkCarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// An array containing values of the first parameter value
        public static Box<ICarpetProperty> a(Literals.PlotData[] values) => Interop.mkCarpetAttr("a", values);
        /// An array containing values of the first parameter value
        public static Box<ICarpetProperty> a(IEnumerable<bool?> values) => Interop.mkCarpetAttr("a", values.ToArray());
        /// An array containing values of the first parameter value
        public static Box<ICarpetProperty> a(IEnumerable<System.DateTime?> values) => Interop.mkCarpetAttr("a", values.ToArray());
        /// An array containing values of the first parameter value
        public static Box<ICarpetProperty> a(IEnumerable<int?> values) => Interop.mkCarpetAttr("a", values.ToArray());
        /// An array containing values of the first parameter value
        public static Box<ICarpetProperty> a(IEnumerable<float?> values) => Interop.mkCarpetAttr("a", values.ToArray());
        /// Alternate to `a`. Builds a linear space of a coordinates. Use with `da` where `a0` is the starting coordinate and `da` the step.
        public static Box<ICarpetProperty> a0(int val) => Interop.mkCarpetAttr("a0", val);
        /// Alternate to `a`. Builds a linear space of a coordinates. Use with `da` where `a0` is the starting coordinate and `da` the step.
        public static Box<ICarpetProperty> a0(float val) => Interop.mkCarpetAttr("a0", val);
        /// Sets the a coordinate step. See `a0` for more info.
        public static Box<ICarpetProperty> da(int val) => Interop.mkCarpetAttr("da", val);
        /// Sets the a coordinate step. See `a0` for more info.
        public static Box<ICarpetProperty> da(float val) => Interop.mkCarpetAttr("da", val);
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> b(bool val) => Interop.mkCarpetAttr("b", new[]{val});
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> b(params bool[] values) => Interop.mkCarpetAttr("b", values);
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> b(System.DateTime val) => Interop.mkCarpetAttr("b", new[]{val});
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> b(params System.DateTime[] values) => Interop.mkCarpetAttr("b", values);
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> b(float val) => Interop.mkCarpetAttr("b", new[]{val});
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> b(params float[] values) => Interop.mkCarpetAttr("b", values);
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> b(int val) => Interop.mkCarpetAttr("b", new[]{val});
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> b(params int[] values) => Interop.mkCarpetAttr("b", values);
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> b(string val) => Interop.mkCarpetAttr("b", new[]{val});
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> b(params string[] values) => Interop.mkCarpetAttr("b", values);
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> b(IEnumerable<bool[]> values) => Interop.mkCarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> b(List<bool[]> values) => Interop.mkCarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> b(params bool[][] values) => Interop.mkCarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> b(IEnumerable<IEnumerable<string>> values) => Interop.mkCarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> b(List<string[]> values) => Interop.mkCarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> b(params string[][] values) => Interop.mkCarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> b(IEnumerable<IEnumerable<int>> values) => Interop.mkCarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> b(List<int[]> values) => Interop.mkCarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> b(params int[][] values) => Interop.mkCarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> b(IEnumerable<IEnumerable<float>> values) => Interop.mkCarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> b(List<float[]> values) => Interop.mkCarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> b(params float[][] values) => Interop.mkCarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> b(Literals.PlotData[] values) => Interop.mkCarpetAttr("b", values);
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> b(IEnumerable<bool?> values) => Interop.mkCarpetAttr("b", values.ToArray());
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> b(IEnumerable<System.DateTime?> values) => Interop.mkCarpetAttr("b", values.ToArray());
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> b(IEnumerable<int?> values) => Interop.mkCarpetAttr("b", values.ToArray());
        /// A two dimensional array of y coordinates at each carpet point.
        public static Box<ICarpetProperty> b(IEnumerable<float?> values) => Interop.mkCarpetAttr("b", values.ToArray());
        /// Alternate to `b`. Builds a linear space of a coordinates. Use with `db` where `b0` is the starting coordinate and `db` the step.
        public static Box<ICarpetProperty> b0(int val) => Interop.mkCarpetAttr("b0", val);
        /// Alternate to `b`. Builds a linear space of a coordinates. Use with `db` where `b0` is the starting coordinate and `db` the step.
        public static Box<ICarpetProperty> b0(float val) => Interop.mkCarpetAttr("b0", val);
        /// Sets the b coordinate step. See `b0` for more info.
        public static Box<ICarpetProperty> db(int val) => Interop.mkCarpetAttr("db", val);
        /// Sets the b coordinate step. See `b0` for more info.
        public static Box<ICarpetProperty> db(float val) => Interop.mkCarpetAttr("db", val);
        /// The shift applied to each successive row of data in creating a cheater plot. Only used if `x` is been ommitted.
        public static Box<ICarpetProperty> cheaterslope(int val) => Interop.mkCarpetAttr("cheaterslope", val);
        /// The shift applied to each successive row of data in creating a cheater plot. Only used if `x` is been ommitted.
        public static Box<ICarpetProperty> cheaterslope(float val) => Interop.mkCarpetAttr("cheaterslope", val);
        public static Box<ICarpetProperty> aaxis(params Box<IAaxisProperty>[] properties) => Interop.mkCarpetAttr("aaxis", Bindings.flattenProperties(properties));
        public static Box<ICarpetProperty> baxis(params Box<IBaxisProperty>[] properties) => Interop.mkCarpetAttr("baxis", Bindings.flattenProperties(properties));
        /// The default font used for axis & tick labels on this carpet
        public static Box<ICarpetProperty> font(params Box<IFontProperty>[] properties) => Interop.mkCarpetAttr("font", Bindings.flattenProperties(properties));
        /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
        public static Box<ICarpetProperty> color(string val) => Interop.mkCarpetAttr("color", val);
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<ICarpetProperty> xaxis(int anchorId) => Interop.mkCarpetAttr("xaxis", anchorId > 1 ? $"x{anchorId}" : "");
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<ICarpetProperty> xaxis(string val) => Interop.mkCarpetAttr("xaxis", val);
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<ICarpetProperty> yaxis(int anchorId) => Interop.mkCarpetAttr("yaxis", anchorId > 1 ? $"y{anchorId}" : "");
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<ICarpetProperty> yaxis(string val) => Interop.mkCarpetAttr("yaxis", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<ICarpetProperty> idssrc(string val) => Interop.mkCarpetAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<ICarpetProperty> customdatasrc(string val) => Interop.mkCarpetAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<ICarpetProperty> metasrc(string val) => Interop.mkCarpetAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  x .
        public static Box<ICarpetProperty> xsrc(string val) => Interop.mkCarpetAttr("xsrc", val);
        /// Sets the source reference on plot.ly for  y .
        public static Box<ICarpetProperty> ysrc(string val) => Interop.mkCarpetAttr("ysrc", val);
        /// Sets the source reference on plot.ly for  a .
        public static Box<ICarpetProperty> asrc(string val) => Interop.mkCarpetAttr("asrc", val);
        /// Sets the source reference on plot.ly for  b .
        public static Box<ICarpetProperty> bsrc(string val) => Interop.mkCarpetAttr("bsrc", val);
    }

    public static partial class Carpet
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<ICarpetProperty> legendonly() => Interop.mkCarpetAttr("visible", "legendonly");
            public static Box<ICarpetProperty> _false() => Interop.mkCarpetAttr("visible", false);
            public static Box<ICarpetProperty> _true() => Interop.mkCarpetAttr("visible", true);
        }
    }
}