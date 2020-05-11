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

    public static partial class Contourcarpet
    {
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IContourcarpetProperty> showlegend(bool val) => Interop.mkContourcarpetAttr("showlegend", val);
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IContourcarpetProperty> legendgroup(string val) => Interop.mkContourcarpetAttr("legendgroup", val);
        /// Sets the opacity of the trace.
        public static Box<IContourcarpetProperty> opacity(int val) => Interop.mkContourcarpetAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<IContourcarpetProperty> opacity(float val) => Interop.mkContourcarpetAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IContourcarpetProperty> name(string val) => Interop.mkContourcarpetAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IContourcarpetProperty> uid(string val) => Interop.mkContourcarpetAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourcarpetProperty> ids(bool val) => Interop.mkContourcarpetAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourcarpetProperty> ids(params bool[] values) => Interop.mkContourcarpetAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourcarpetProperty> ids(System.DateTime val) => Interop.mkContourcarpetAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourcarpetProperty> ids(params System.DateTime[] values) => Interop.mkContourcarpetAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourcarpetProperty> ids(float val) => Interop.mkContourcarpetAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourcarpetProperty> ids(params float[] values) => Interop.mkContourcarpetAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourcarpetProperty> ids(int val) => Interop.mkContourcarpetAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourcarpetProperty> ids(params int[] values) => Interop.mkContourcarpetAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourcarpetProperty> ids(string val) => Interop.mkContourcarpetAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourcarpetProperty> ids(params string[] values) => Interop.mkContourcarpetAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourcarpetProperty> ids(IEnumerable<bool[]> values) => Interop.mkContourcarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourcarpetProperty> ids(List<bool[]> values) => Interop.mkContourcarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourcarpetProperty> ids(params bool[][] values) => Interop.mkContourcarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourcarpetProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkContourcarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourcarpetProperty> ids(List<string[]> values) => Interop.mkContourcarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourcarpetProperty> ids(params string[][] values) => Interop.mkContourcarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourcarpetProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkContourcarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourcarpetProperty> ids(List<int[]> values) => Interop.mkContourcarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourcarpetProperty> ids(params int[][] values) => Interop.mkContourcarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourcarpetProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkContourcarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourcarpetProperty> ids(List<float[]> values) => Interop.mkContourcarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourcarpetProperty> ids(params float[][] values) => Interop.mkContourcarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourcarpetProperty> ids(Literals.PlotData[] values) => Interop.mkContourcarpetAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourcarpetProperty> ids(IEnumerable<bool?> values) => Interop.mkContourcarpetAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourcarpetProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkContourcarpetAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourcarpetProperty> ids(IEnumerable<int?> values) => Interop.mkContourcarpetAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourcarpetProperty> ids(IEnumerable<float?> values) => Interop.mkContourcarpetAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourcarpetProperty> customdata(bool val) => Interop.mkContourcarpetAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourcarpetProperty> customdata(params bool[] values) => Interop.mkContourcarpetAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourcarpetProperty> customdata(System.DateTime val) => Interop.mkContourcarpetAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourcarpetProperty> customdata(params System.DateTime[] values) => Interop.mkContourcarpetAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourcarpetProperty> customdata(float val) => Interop.mkContourcarpetAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourcarpetProperty> customdata(params float[] values) => Interop.mkContourcarpetAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourcarpetProperty> customdata(int val) => Interop.mkContourcarpetAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourcarpetProperty> customdata(params int[] values) => Interop.mkContourcarpetAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourcarpetProperty> customdata(string val) => Interop.mkContourcarpetAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourcarpetProperty> customdata(params string[] values) => Interop.mkContourcarpetAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourcarpetProperty> customdata(IEnumerable<bool[]> values) => Interop.mkContourcarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourcarpetProperty> customdata(List<bool[]> values) => Interop.mkContourcarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourcarpetProperty> customdata(params bool[][] values) => Interop.mkContourcarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourcarpetProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkContourcarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourcarpetProperty> customdata(List<string[]> values) => Interop.mkContourcarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourcarpetProperty> customdata(params string[][] values) => Interop.mkContourcarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourcarpetProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkContourcarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourcarpetProperty> customdata(List<int[]> values) => Interop.mkContourcarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourcarpetProperty> customdata(params int[][] values) => Interop.mkContourcarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourcarpetProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkContourcarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourcarpetProperty> customdata(List<float[]> values) => Interop.mkContourcarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourcarpetProperty> customdata(params float[][] values) => Interop.mkContourcarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourcarpetProperty> customdata(Literals.PlotData[] values) => Interop.mkContourcarpetAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourcarpetProperty> customdata(IEnumerable<bool?> values) => Interop.mkContourcarpetAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourcarpetProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkContourcarpetAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourcarpetProperty> customdata(IEnumerable<int?> values) => Interop.mkContourcarpetAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourcarpetProperty> customdata(IEnumerable<float?> values) => Interop.mkContourcarpetAttr("customdata", values.ToArray());
        public static Box<IContourcarpetProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkContourcarpetAttr("stream", Bindings.flattenProperties(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IContourcarpetProperty> uirevision(bool val) => Interop.mkContourcarpetAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IContourcarpetProperty> uirevision(params bool[] values) => Interop.mkContourcarpetAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IContourcarpetProperty> uirevision(System.DateTime val) => Interop.mkContourcarpetAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IContourcarpetProperty> uirevision(params System.DateTime[] values) => Interop.mkContourcarpetAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IContourcarpetProperty> uirevision(int val) => Interop.mkContourcarpetAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IContourcarpetProperty> uirevision(params int[] values) => Interop.mkContourcarpetAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IContourcarpetProperty> uirevision(float val) => Interop.mkContourcarpetAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IContourcarpetProperty> uirevision(params float[] values) => Interop.mkContourcarpetAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IContourcarpetProperty> uirevision(string val) => Interop.mkContourcarpetAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IContourcarpetProperty> uirevision(params string[] values) => Interop.mkContourcarpetAttr("uirevision", values);
        /// The `carpet` of the carpet axes on which this contour trace lies
        public static Box<IContourcarpetProperty> carpet(string val) => Interop.mkContourcarpetAttr("carpet", val);
        /// Sets the z data.
        public static Box<IContourcarpetProperty> z(bool val) => Interop.mkContourcarpetAttr("z", new[]{val});
        /// Sets the z data.
        public static Box<IContourcarpetProperty> z(params bool[] values) => Interop.mkContourcarpetAttr("z", values);
        /// Sets the z data.
        public static Box<IContourcarpetProperty> z(System.DateTime val) => Interop.mkContourcarpetAttr("z", new[]{val});
        /// Sets the z data.
        public static Box<IContourcarpetProperty> z(params System.DateTime[] values) => Interop.mkContourcarpetAttr("z", values);
        /// Sets the z data.
        public static Box<IContourcarpetProperty> z(float val) => Interop.mkContourcarpetAttr("z", new[]{val});
        /// Sets the z data.
        public static Box<IContourcarpetProperty> z(params float[] values) => Interop.mkContourcarpetAttr("z", values);
        /// Sets the z data.
        public static Box<IContourcarpetProperty> z(int val) => Interop.mkContourcarpetAttr("z", new[]{val});
        /// Sets the z data.
        public static Box<IContourcarpetProperty> z(params int[] values) => Interop.mkContourcarpetAttr("z", values);
        /// Sets the z data.
        public static Box<IContourcarpetProperty> z(string val) => Interop.mkContourcarpetAttr("z", new[]{val});
        /// Sets the z data.
        public static Box<IContourcarpetProperty> z(params string[] values) => Interop.mkContourcarpetAttr("z", values);
        /// Sets the z data.
        public static Box<IContourcarpetProperty> z(IEnumerable<bool[]> values) => Interop.mkContourcarpetAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IContourcarpetProperty> z(List<bool[]> values) => Interop.mkContourcarpetAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IContourcarpetProperty> z(params bool[][] values) => Interop.mkContourcarpetAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IContourcarpetProperty> z(IEnumerable<IEnumerable<string>> values) => Interop.mkContourcarpetAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IContourcarpetProperty> z(List<string[]> values) => Interop.mkContourcarpetAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IContourcarpetProperty> z(params string[][] values) => Interop.mkContourcarpetAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IContourcarpetProperty> z(IEnumerable<IEnumerable<int>> values) => Interop.mkContourcarpetAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IContourcarpetProperty> z(List<int[]> values) => Interop.mkContourcarpetAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IContourcarpetProperty> z(params int[][] values) => Interop.mkContourcarpetAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IContourcarpetProperty> z(IEnumerable<IEnumerable<float>> values) => Interop.mkContourcarpetAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IContourcarpetProperty> z(List<float[]> values) => Interop.mkContourcarpetAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IContourcarpetProperty> z(params float[][] values) => Interop.mkContourcarpetAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IContourcarpetProperty> z(Literals.PlotData[] values) => Interop.mkContourcarpetAttr("z", values);
        /// Sets the z data.
        public static Box<IContourcarpetProperty> z(IEnumerable<bool?> values) => Interop.mkContourcarpetAttr("z", values.ToArray());
        /// Sets the z data.
        public static Box<IContourcarpetProperty> z(IEnumerable<System.DateTime?> values) => Interop.mkContourcarpetAttr("z", values.ToArray());
        /// Sets the z data.
        public static Box<IContourcarpetProperty> z(IEnumerable<int?> values) => Interop.mkContourcarpetAttr("z", values.ToArray());
        /// Sets the z data.
        public static Box<IContourcarpetProperty> z(IEnumerable<float?> values) => Interop.mkContourcarpetAttr("z", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IContourcarpetProperty> a(bool val) => Interop.mkContourcarpetAttr("a", new[]{val});
        /// Sets the x coordinates.
        public static Box<IContourcarpetProperty> a(IEnumerable<bool> values) => Interop.mkContourcarpetAttr("a", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IContourcarpetProperty> a(System.DateTime val) => Interop.mkContourcarpetAttr("a", new[]{val});
        /// Sets the x coordinates.
        public static Box<IContourcarpetProperty> a(IEnumerable<System.DateTime> values) => Interop.mkContourcarpetAttr("a", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IContourcarpetProperty> a(float val) => Interop.mkContourcarpetAttr("a", new[]{val});
        /// Sets the x coordinates.
        public static Box<IContourcarpetProperty> a(IEnumerable<float> values) => Interop.mkContourcarpetAttr("a", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IContourcarpetProperty> a(int val) => Interop.mkContourcarpetAttr("a", new[]{val});
        /// Sets the x coordinates.
        public static Box<IContourcarpetProperty> a(IEnumerable<int> values) => Interop.mkContourcarpetAttr("a", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IContourcarpetProperty> a(string val) => Interop.mkContourcarpetAttr("a", new[]{val});
        /// Sets the x coordinates.
        public static Box<IContourcarpetProperty> a(IEnumerable<string> values) => Interop.mkContourcarpetAttr("a", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IContourcarpetProperty> a(IEnumerable<bool[]> values) => Interop.mkContourcarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IContourcarpetProperty> a(List<bool[]> values) => Interop.mkContourcarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IContourcarpetProperty> a(params bool[][] values) => Interop.mkContourcarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IContourcarpetProperty> a(IEnumerable<IEnumerable<string>> values) => Interop.mkContourcarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IContourcarpetProperty> a(List<string[]> values) => Interop.mkContourcarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IContourcarpetProperty> a(params string[][] values) => Interop.mkContourcarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IContourcarpetProperty> a(IEnumerable<IEnumerable<int>> values) => Interop.mkContourcarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IContourcarpetProperty> a(List<int[]> values) => Interop.mkContourcarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IContourcarpetProperty> a(params int[][] values) => Interop.mkContourcarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IContourcarpetProperty> a(IEnumerable<IEnumerable<float>> values) => Interop.mkContourcarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IContourcarpetProperty> a(List<float[]> values) => Interop.mkContourcarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IContourcarpetProperty> a(params float[][] values) => Interop.mkContourcarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IContourcarpetProperty> a(Literals.PlotData[] values) => Interop.mkContourcarpetAttr("a", values);
        /// Sets the x coordinates.
        public static Box<IContourcarpetProperty> a(IEnumerable<bool?> values) => Interop.mkContourcarpetAttr("a", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IContourcarpetProperty> a(IEnumerable<System.DateTime?> values) => Interop.mkContourcarpetAttr("a", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IContourcarpetProperty> a(IEnumerable<int?> values) => Interop.mkContourcarpetAttr("a", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IContourcarpetProperty> a(IEnumerable<float?> values) => Interop.mkContourcarpetAttr("a", values.ToArray());
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IContourcarpetProperty> a0(bool val) => Interop.mkContourcarpetAttr("a0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IContourcarpetProperty> a0(params bool[] values) => Interop.mkContourcarpetAttr("a0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IContourcarpetProperty> a0(System.DateTime val) => Interop.mkContourcarpetAttr("a0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IContourcarpetProperty> a0(params System.DateTime[] values) => Interop.mkContourcarpetAttr("a0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IContourcarpetProperty> a0(int val) => Interop.mkContourcarpetAttr("a0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IContourcarpetProperty> a0(params int[] values) => Interop.mkContourcarpetAttr("a0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IContourcarpetProperty> a0(float val) => Interop.mkContourcarpetAttr("a0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IContourcarpetProperty> a0(params float[] values) => Interop.mkContourcarpetAttr("a0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IContourcarpetProperty> a0(string val) => Interop.mkContourcarpetAttr("a0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IContourcarpetProperty> a0(params string[] values) => Interop.mkContourcarpetAttr("a0", values);
        /// Sets the x coordinate step. See `x0` for more info.
        public static Box<IContourcarpetProperty> da(int val) => Interop.mkContourcarpetAttr("da", val);
        /// Sets the x coordinate step. See `x0` for more info.
        public static Box<IContourcarpetProperty> da(float val) => Interop.mkContourcarpetAttr("da", val);
        /// Sets the y coordinates.
        public static Box<IContourcarpetProperty> b(bool val) => Interop.mkContourcarpetAttr("b", new[]{val});
        /// Sets the y coordinates.
        public static Box<IContourcarpetProperty> b(IEnumerable<bool> values) => Interop.mkContourcarpetAttr("b", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IContourcarpetProperty> b(System.DateTime val) => Interop.mkContourcarpetAttr("b", new[]{val});
        /// Sets the y coordinates.
        public static Box<IContourcarpetProperty> b(IEnumerable<System.DateTime> values) => Interop.mkContourcarpetAttr("b", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IContourcarpetProperty> b(float val) => Interop.mkContourcarpetAttr("b", new[]{val});
        /// Sets the y coordinates.
        public static Box<IContourcarpetProperty> b(IEnumerable<float> values) => Interop.mkContourcarpetAttr("b", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IContourcarpetProperty> b(int val) => Interop.mkContourcarpetAttr("b", new[]{val});
        /// Sets the y coordinates.
        public static Box<IContourcarpetProperty> b(IEnumerable<int> values) => Interop.mkContourcarpetAttr("b", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IContourcarpetProperty> b(string val) => Interop.mkContourcarpetAttr("b", new[]{val});
        /// Sets the y coordinates.
        public static Box<IContourcarpetProperty> b(IEnumerable<string> values) => Interop.mkContourcarpetAttr("b", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IContourcarpetProperty> b(IEnumerable<bool[]> values) => Interop.mkContourcarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IContourcarpetProperty> b(List<bool[]> values) => Interop.mkContourcarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IContourcarpetProperty> b(params bool[][] values) => Interop.mkContourcarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IContourcarpetProperty> b(IEnumerable<IEnumerable<string>> values) => Interop.mkContourcarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IContourcarpetProperty> b(List<string[]> values) => Interop.mkContourcarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IContourcarpetProperty> b(params string[][] values) => Interop.mkContourcarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IContourcarpetProperty> b(IEnumerable<IEnumerable<int>> values) => Interop.mkContourcarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IContourcarpetProperty> b(List<int[]> values) => Interop.mkContourcarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IContourcarpetProperty> b(params int[][] values) => Interop.mkContourcarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IContourcarpetProperty> b(IEnumerable<IEnumerable<float>> values) => Interop.mkContourcarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IContourcarpetProperty> b(List<float[]> values) => Interop.mkContourcarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IContourcarpetProperty> b(params float[][] values) => Interop.mkContourcarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IContourcarpetProperty> b(Literals.PlotData[] values) => Interop.mkContourcarpetAttr("b", values);
        /// Sets the y coordinates.
        public static Box<IContourcarpetProperty> b(IEnumerable<bool?> values) => Interop.mkContourcarpetAttr("b", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IContourcarpetProperty> b(IEnumerable<System.DateTime?> values) => Interop.mkContourcarpetAttr("b", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IContourcarpetProperty> b(IEnumerable<int?> values) => Interop.mkContourcarpetAttr("b", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IContourcarpetProperty> b(IEnumerable<float?> values) => Interop.mkContourcarpetAttr("b", values.ToArray());
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IContourcarpetProperty> b0(bool val) => Interop.mkContourcarpetAttr("b0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IContourcarpetProperty> b0(params bool[] values) => Interop.mkContourcarpetAttr("b0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IContourcarpetProperty> b0(System.DateTime val) => Interop.mkContourcarpetAttr("b0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IContourcarpetProperty> b0(params System.DateTime[] values) => Interop.mkContourcarpetAttr("b0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IContourcarpetProperty> b0(int val) => Interop.mkContourcarpetAttr("b0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IContourcarpetProperty> b0(params int[] values) => Interop.mkContourcarpetAttr("b0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IContourcarpetProperty> b0(float val) => Interop.mkContourcarpetAttr("b0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IContourcarpetProperty> b0(params float[] values) => Interop.mkContourcarpetAttr("b0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IContourcarpetProperty> b0(string val) => Interop.mkContourcarpetAttr("b0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IContourcarpetProperty> b0(params string[] values) => Interop.mkContourcarpetAttr("b0", values);
        /// Sets the y coordinate step. See `y0` for more info.
        public static Box<IContourcarpetProperty> db(int val) => Interop.mkContourcarpetAttr("db", val);
        /// Sets the y coordinate step. See `y0` for more info.
        public static Box<IContourcarpetProperty> db(float val) => Interop.mkContourcarpetAttr("db", val);
        /// Sets the text elements associated with each z value.
        public static Box<IContourcarpetProperty> text(bool val) => Interop.mkContourcarpetAttr("text", new[]{val});
        /// Sets the text elements associated with each z value.
        public static Box<IContourcarpetProperty> text(params bool[] values) => Interop.mkContourcarpetAttr("text", values);
        /// Sets the text elements associated with each z value.
        public static Box<IContourcarpetProperty> text(System.DateTime val) => Interop.mkContourcarpetAttr("text", new[]{val});
        /// Sets the text elements associated with each z value.
        public static Box<IContourcarpetProperty> text(params System.DateTime[] values) => Interop.mkContourcarpetAttr("text", values);
        /// Sets the text elements associated with each z value.
        public static Box<IContourcarpetProperty> text(float val) => Interop.mkContourcarpetAttr("text", new[]{val});
        /// Sets the text elements associated with each z value.
        public static Box<IContourcarpetProperty> text(params float[] values) => Interop.mkContourcarpetAttr("text", values);
        /// Sets the text elements associated with each z value.
        public static Box<IContourcarpetProperty> text(int val) => Interop.mkContourcarpetAttr("text", new[]{val});
        /// Sets the text elements associated with each z value.
        public static Box<IContourcarpetProperty> text(params int[] values) => Interop.mkContourcarpetAttr("text", values);
        /// Sets the text elements associated with each z value.
        public static Box<IContourcarpetProperty> text(string val) => Interop.mkContourcarpetAttr("text", new[]{val});
        /// Sets the text elements associated with each z value.
        public static Box<IContourcarpetProperty> text(params string[] values) => Interop.mkContourcarpetAttr("text", values);
        /// Sets the text elements associated with each z value.
        public static Box<IContourcarpetProperty> text(IEnumerable<bool[]> values) => Interop.mkContourcarpetAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IContourcarpetProperty> text(List<bool[]> values) => Interop.mkContourcarpetAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IContourcarpetProperty> text(params bool[][] values) => Interop.mkContourcarpetAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IContourcarpetProperty> text(IEnumerable<IEnumerable<string>> values) => Interop.mkContourcarpetAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IContourcarpetProperty> text(List<string[]> values) => Interop.mkContourcarpetAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IContourcarpetProperty> text(params string[][] values) => Interop.mkContourcarpetAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IContourcarpetProperty> text(IEnumerable<IEnumerable<int>> values) => Interop.mkContourcarpetAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IContourcarpetProperty> text(List<int[]> values) => Interop.mkContourcarpetAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IContourcarpetProperty> text(params int[][] values) => Interop.mkContourcarpetAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IContourcarpetProperty> text(IEnumerable<IEnumerable<float>> values) => Interop.mkContourcarpetAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IContourcarpetProperty> text(List<float[]> values) => Interop.mkContourcarpetAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IContourcarpetProperty> text(params float[][] values) => Interop.mkContourcarpetAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IContourcarpetProperty> text(Literals.PlotData[] values) => Interop.mkContourcarpetAttr("text", values);
        /// Sets the text elements associated with each z value.
        public static Box<IContourcarpetProperty> text(IEnumerable<bool?> values) => Interop.mkContourcarpetAttr("text", values.ToArray());
        /// Sets the text elements associated with each z value.
        public static Box<IContourcarpetProperty> text(IEnumerable<System.DateTime?> values) => Interop.mkContourcarpetAttr("text", values.ToArray());
        /// Sets the text elements associated with each z value.
        public static Box<IContourcarpetProperty> text(IEnumerable<int?> values) => Interop.mkContourcarpetAttr("text", values.ToArray());
        /// Sets the text elements associated with each z value.
        public static Box<IContourcarpetProperty> text(IEnumerable<float?> values) => Interop.mkContourcarpetAttr("text", values.ToArray());
        /// Same as `text`.
        public static Box<IContourcarpetProperty> hovertext(bool val) => Interop.mkContourcarpetAttr("hovertext", new[]{val});
        /// Same as `text`.
        public static Box<IContourcarpetProperty> hovertext(params bool[] values) => Interop.mkContourcarpetAttr("hovertext", values);
        /// Same as `text`.
        public static Box<IContourcarpetProperty> hovertext(System.DateTime val) => Interop.mkContourcarpetAttr("hovertext", new[]{val});
        /// Same as `text`.
        public static Box<IContourcarpetProperty> hovertext(params System.DateTime[] values) => Interop.mkContourcarpetAttr("hovertext", values);
        /// Same as `text`.
        public static Box<IContourcarpetProperty> hovertext(float val) => Interop.mkContourcarpetAttr("hovertext", new[]{val});
        /// Same as `text`.
        public static Box<IContourcarpetProperty> hovertext(params float[] values) => Interop.mkContourcarpetAttr("hovertext", values);
        /// Same as `text`.
        public static Box<IContourcarpetProperty> hovertext(int val) => Interop.mkContourcarpetAttr("hovertext", new[]{val});
        /// Same as `text`.
        public static Box<IContourcarpetProperty> hovertext(params int[] values) => Interop.mkContourcarpetAttr("hovertext", values);
        /// Same as `text`.
        public static Box<IContourcarpetProperty> hovertext(string val) => Interop.mkContourcarpetAttr("hovertext", new[]{val});
        /// Same as `text`.
        public static Box<IContourcarpetProperty> hovertext(params string[] values) => Interop.mkContourcarpetAttr("hovertext", values);
        /// Same as `text`.
        public static Box<IContourcarpetProperty> hovertext(IEnumerable<bool[]> values) => Interop.mkContourcarpetAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IContourcarpetProperty> hovertext(List<bool[]> values) => Interop.mkContourcarpetAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IContourcarpetProperty> hovertext(params bool[][] values) => Interop.mkContourcarpetAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IContourcarpetProperty> hovertext(IEnumerable<IEnumerable<string>> values) => Interop.mkContourcarpetAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IContourcarpetProperty> hovertext(List<string[]> values) => Interop.mkContourcarpetAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IContourcarpetProperty> hovertext(params string[][] values) => Interop.mkContourcarpetAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IContourcarpetProperty> hovertext(IEnumerable<IEnumerable<int>> values) => Interop.mkContourcarpetAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IContourcarpetProperty> hovertext(List<int[]> values) => Interop.mkContourcarpetAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IContourcarpetProperty> hovertext(params int[][] values) => Interop.mkContourcarpetAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IContourcarpetProperty> hovertext(IEnumerable<IEnumerable<float>> values) => Interop.mkContourcarpetAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IContourcarpetProperty> hovertext(List<float[]> values) => Interop.mkContourcarpetAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IContourcarpetProperty> hovertext(params float[][] values) => Interop.mkContourcarpetAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IContourcarpetProperty> hovertext(Literals.PlotData[] values) => Interop.mkContourcarpetAttr("hovertext", values);
        /// Same as `text`.
        public static Box<IContourcarpetProperty> hovertext(IEnumerable<bool?> values) => Interop.mkContourcarpetAttr("hovertext", values.ToArray());
        /// Same as `text`.
        public static Box<IContourcarpetProperty> hovertext(IEnumerable<System.DateTime?> values) => Interop.mkContourcarpetAttr("hovertext", values.ToArray());
        /// Same as `text`.
        public static Box<IContourcarpetProperty> hovertext(IEnumerable<int?> values) => Interop.mkContourcarpetAttr("hovertext", values.ToArray());
        /// Same as `text`.
        public static Box<IContourcarpetProperty> hovertext(IEnumerable<float?> values) => Interop.mkContourcarpetAttr("hovertext", values.ToArray());
        /// Transposes the z data.
        public static Box<IContourcarpetProperty> transpose(bool val) => Interop.mkContourcarpetAttr("transpose", val);
        /// Sets the fill color if `contours.type` is *constraint*. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
        public static Box<IContourcarpetProperty> fillcolor(string val) => Interop.mkContourcarpetAttr("fillcolor", val);
        /// Determines whether or not the contour level attributes are picked by an algorithm. If *true*, the number of contour levels can be set in `ncontours`. If *false*, set the contour level attributes in `contours`.
        public static Box<IContourcarpetProperty> autocontour(bool val) => Interop.mkContourcarpetAttr("autocontour", val);
        /// Sets the maximum number of contour levels. The actual number of contours will be chosen automatically to be less than or equal to the value of `ncontours`. Has an effect only if `autocontour` is *true* or if `contours.size` is missing.
        public static Box<IContourcarpetProperty> ncontours(int val) => Interop.mkContourcarpetAttr("ncontours", val);
        public static Box<IContourcarpetProperty> contours(params Box<IContoursProperty>[] properties) => Interop.mkContourcarpetAttr("contours", Bindings.flattenProperties(properties));
        public static Box<IContourcarpetProperty> line(params Box<ILineProperty>[] properties) => Interop.mkContourcarpetAttr("line", Bindings.flattenProperties(properties));
        /// Determines whether or not the color domain is computed with respect to the input data (here in `z`) or the bounds set in `zmin` and `zmax`  Defaults to `false` when `zmin` and `zmax` are set by the user.
        public static Box<IContourcarpetProperty> zauto(bool val) => Interop.mkContourcarpetAttr("zauto", val);
        /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
        public static Box<IContourcarpetProperty> zmin(int val) => Interop.mkContourcarpetAttr("zmin", val);
        /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
        public static Box<IContourcarpetProperty> zmin(float val) => Interop.mkContourcarpetAttr("zmin", val);
        /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
        public static Box<IContourcarpetProperty> zmax(int val) => Interop.mkContourcarpetAttr("zmax", val);
        /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
        public static Box<IContourcarpetProperty> zmax(float val) => Interop.mkContourcarpetAttr("zmax", val);
        /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
        public static Box<IContourcarpetProperty> zmid(int val) => Interop.mkContourcarpetAttr("zmid", val);
        /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
        public static Box<IContourcarpetProperty> zmid(float val) => Interop.mkContourcarpetAttr("zmid", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IContourcarpetProperty> colorscale(string val) => Interop.mkContourcarpetAttr("colorscale", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IContourcarpetProperty> colorscale(List<string[]> values) => Interop.mkContourcarpetAttr("colorscale", Bindings.flatten2DArrayIf1D(values));
        /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
        public static Box<IContourcarpetProperty> autocolorscale(bool val) => Interop.mkContourcarpetAttr("autocolorscale", val);
        /// Reverses the color mapping if true. If true, `zmin` will correspond to the last color in the array and `zmax` will correspond to the first color.
        public static Box<IContourcarpetProperty> reversescale(bool val) => Interop.mkContourcarpetAttr("reversescale", val);
        /// Determines whether or not a colorbar is displayed for this trace.
        public static Box<IContourcarpetProperty> showscale(bool val) => Interop.mkContourcarpetAttr("showscale", val);
        public static Box<IContourcarpetProperty> colorbar(params Box<IColorbarProperty>[] properties) => Interop.mkContourcarpetAttr("colorbar", Bindings.flattenProperties(properties));
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<IContourcarpetProperty> coloraxis(int anchorId) => Interop.mkContourcarpetAttr("coloraxis", anchorId > 1 ? $"coloraxis{anchorId}" : "");
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<IContourcarpetProperty> coloraxis(string val) => Interop.mkContourcarpetAttr("coloraxis", val);
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IContourcarpetProperty> xaxis(int anchorId) => Interop.mkContourcarpetAttr("xaxis", anchorId > 1 ? $"x{anchorId}" : "");
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IContourcarpetProperty> xaxis(string val) => Interop.mkContourcarpetAttr("xaxis", val);
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IContourcarpetProperty> yaxis(int anchorId) => Interop.mkContourcarpetAttr("yaxis", anchorId > 1 ? $"y{anchorId}" : "");
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IContourcarpetProperty> yaxis(string val) => Interop.mkContourcarpetAttr("yaxis", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IContourcarpetProperty> idssrc(string val) => Interop.mkContourcarpetAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IContourcarpetProperty> customdatasrc(string val) => Interop.mkContourcarpetAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IContourcarpetProperty> metasrc(string val) => Interop.mkContourcarpetAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  z .
        public static Box<IContourcarpetProperty> zsrc(string val) => Interop.mkContourcarpetAttr("zsrc", val);
        /// Sets the source reference on plot.ly for  a .
        public static Box<IContourcarpetProperty> asrc(string val) => Interop.mkContourcarpetAttr("asrc", val);
        /// Sets the source reference on plot.ly for  b .
        public static Box<IContourcarpetProperty> bsrc(string val) => Interop.mkContourcarpetAttr("bsrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IContourcarpetProperty> textsrc(string val) => Interop.mkContourcarpetAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IContourcarpetProperty> hovertextsrc(string val) => Interop.mkContourcarpetAttr("hovertextsrc", val);
    }

    public static partial class Contourcarpet
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IContourcarpetProperty> legendonly() => Interop.mkContourcarpetAttr("visible", "legendonly");
            public static Box<IContourcarpetProperty> _false() => Interop.mkContourcarpetAttr("visible", false);
            public static Box<IContourcarpetProperty> _true() => Interop.mkContourcarpetAttr("visible", true);
        }

        /// If *array*, the heatmap's x coordinates are given by *x* (the default behavior when `x` is provided). If *scaled*, the heatmap's x coordinates are given by *x0* and *dx* (the default behavior when `x` is not provided).
        public static partial class Atype
        {
            public static Box<IContourcarpetProperty> array() => Interop.mkContourcarpetAttr("atype", "array");
            public static Box<IContourcarpetProperty> scaled() => Interop.mkContourcarpetAttr("atype", "scaled");
        }

        /// If *array*, the heatmap's y coordinates are given by *y* (the default behavior when `y` is provided) If *scaled*, the heatmap's y coordinates are given by *y0* and *dy* (the default behavior when `y` is not provided)
        public static partial class Btype
        {
            public static Box<IContourcarpetProperty> array() => Interop.mkContourcarpetAttr("btype", "array");
            public static Box<IContourcarpetProperty> scaled() => Interop.mkContourcarpetAttr("btype", "scaled");
        }
    }
}