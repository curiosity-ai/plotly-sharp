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

    public static partial class Contour
    {
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IContourProperty> showlegend(bool val) => Interop.mkContourAttr("showlegend", val);
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IContourProperty> legendgroup(string val) => Interop.mkContourAttr("legendgroup", val);
        /// Sets the opacity of the trace.
        public static Box<IContourProperty> opacity(int val) => Interop.mkContourAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<IContourProperty> opacity(float val) => Interop.mkContourAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IContourProperty> name(string val) => Interop.mkContourAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IContourProperty> uid(string val) => Interop.mkContourAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourProperty> ids(bool val) => Interop.mkContourAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourProperty> ids(params bool[] values) => Interop.mkContourAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourProperty> ids(System.DateTime val) => Interop.mkContourAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourProperty> ids(params System.DateTime[] values) => Interop.mkContourAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourProperty> ids(float val) => Interop.mkContourAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourProperty> ids(params float[] values) => Interop.mkContourAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourProperty> ids(int val) => Interop.mkContourAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourProperty> ids(params int[] values) => Interop.mkContourAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourProperty> ids(string val) => Interop.mkContourAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourProperty> ids(params string[] values) => Interop.mkContourAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourProperty> ids(IEnumerable<bool[]> values) => Interop.mkContourAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourProperty> ids(List<bool[]> values) => Interop.mkContourAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourProperty> ids(params bool[][] values) => Interop.mkContourAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkContourAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourProperty> ids(List<string[]> values) => Interop.mkContourAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourProperty> ids(params string[][] values) => Interop.mkContourAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkContourAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourProperty> ids(List<int[]> values) => Interop.mkContourAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourProperty> ids(params int[][] values) => Interop.mkContourAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkContourAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourProperty> ids(List<float[]> values) => Interop.mkContourAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourProperty> ids(params float[][] values) => Interop.mkContourAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourProperty> ids(Literals.PlotData[] values) => Interop.mkContourAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourProperty> ids(IEnumerable<bool?> values) => Interop.mkContourAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkContourAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourProperty> ids(IEnumerable<int?> values) => Interop.mkContourAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IContourProperty> ids(IEnumerable<float?> values) => Interop.mkContourAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourProperty> customdata(bool val) => Interop.mkContourAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourProperty> customdata(params bool[] values) => Interop.mkContourAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourProperty> customdata(System.DateTime val) => Interop.mkContourAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourProperty> customdata(params System.DateTime[] values) => Interop.mkContourAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourProperty> customdata(float val) => Interop.mkContourAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourProperty> customdata(params float[] values) => Interop.mkContourAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourProperty> customdata(int val) => Interop.mkContourAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourProperty> customdata(params int[] values) => Interop.mkContourAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourProperty> customdata(string val) => Interop.mkContourAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourProperty> customdata(params string[] values) => Interop.mkContourAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourProperty> customdata(IEnumerable<bool[]> values) => Interop.mkContourAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourProperty> customdata(List<bool[]> values) => Interop.mkContourAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourProperty> customdata(params bool[][] values) => Interop.mkContourAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkContourAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourProperty> customdata(List<string[]> values) => Interop.mkContourAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourProperty> customdata(params string[][] values) => Interop.mkContourAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkContourAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourProperty> customdata(List<int[]> values) => Interop.mkContourAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourProperty> customdata(params int[][] values) => Interop.mkContourAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkContourAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourProperty> customdata(List<float[]> values) => Interop.mkContourAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourProperty> customdata(params float[][] values) => Interop.mkContourAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourProperty> customdata(Literals.PlotData[] values) => Interop.mkContourAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourProperty> customdata(IEnumerable<bool?> values) => Interop.mkContourAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkContourAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourProperty> customdata(IEnumerable<int?> values) => Interop.mkContourAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IContourProperty> customdata(IEnumerable<float?> values) => Interop.mkContourAttr("customdata", values.ToArray());
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IContourProperty> hoverinfo(params Box<IContourProperty>[] properties) => Interop.mkContourAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        public static Box<IContourProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkContourAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IContourProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkContourAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IContourProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkContourAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IContourProperty> uirevision(bool val) => Interop.mkContourAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IContourProperty> uirevision(params bool[] values) => Interop.mkContourAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IContourProperty> uirevision(System.DateTime val) => Interop.mkContourAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IContourProperty> uirevision(params System.DateTime[] values) => Interop.mkContourAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IContourProperty> uirevision(int val) => Interop.mkContourAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IContourProperty> uirevision(params int[] values) => Interop.mkContourAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IContourProperty> uirevision(float val) => Interop.mkContourAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IContourProperty> uirevision(params float[] values) => Interop.mkContourAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IContourProperty> uirevision(string val) => Interop.mkContourAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IContourProperty> uirevision(params string[] values) => Interop.mkContourAttr("uirevision", values);
        /// Sets the z data.
        public static Box<IContourProperty> z(bool val) => Interop.mkContourAttr("z", new[]{val});
        /// Sets the z data.
        public static Box<IContourProperty> z(params bool[] values) => Interop.mkContourAttr("z", values);
        /// Sets the z data.
        public static Box<IContourProperty> z(System.DateTime val) => Interop.mkContourAttr("z", new[]{val});
        /// Sets the z data.
        public static Box<IContourProperty> z(params System.DateTime[] values) => Interop.mkContourAttr("z", values);
        /// Sets the z data.
        public static Box<IContourProperty> z(float val) => Interop.mkContourAttr("z", new[]{val});
        /// Sets the z data.
        public static Box<IContourProperty> z(params float[] values) => Interop.mkContourAttr("z", values);
        /// Sets the z data.
        public static Box<IContourProperty> z(int val) => Interop.mkContourAttr("z", new[]{val});
        /// Sets the z data.
        public static Box<IContourProperty> z(params int[] values) => Interop.mkContourAttr("z", values);
        /// Sets the z data.
        public static Box<IContourProperty> z(string val) => Interop.mkContourAttr("z", new[]{val});
        /// Sets the z data.
        public static Box<IContourProperty> z(params string[] values) => Interop.mkContourAttr("z", values);
        /// Sets the z data.
        public static Box<IContourProperty> z(IEnumerable<bool[]> values) => Interop.mkContourAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IContourProperty> z(List<bool[]> values) => Interop.mkContourAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IContourProperty> z(params bool[][] values) => Interop.mkContourAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IContourProperty> z(IEnumerable<IEnumerable<string>> values) => Interop.mkContourAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IContourProperty> z(List<string[]> values) => Interop.mkContourAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IContourProperty> z(params string[][] values) => Interop.mkContourAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IContourProperty> z(IEnumerable<IEnumerable<int>> values) => Interop.mkContourAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IContourProperty> z(List<int[]> values) => Interop.mkContourAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IContourProperty> z(params int[][] values) => Interop.mkContourAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IContourProperty> z(IEnumerable<IEnumerable<float>> values) => Interop.mkContourAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IContourProperty> z(List<float[]> values) => Interop.mkContourAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IContourProperty> z(params float[][] values) => Interop.mkContourAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the z data.
        public static Box<IContourProperty> z(Literals.PlotData[] values) => Interop.mkContourAttr("z", values);
        /// Sets the z data.
        public static Box<IContourProperty> z(IEnumerable<bool?> values) => Interop.mkContourAttr("z", values.ToArray());
        /// Sets the z data.
        public static Box<IContourProperty> z(IEnumerable<System.DateTime?> values) => Interop.mkContourAttr("z", values.ToArray());
        /// Sets the z data.
        public static Box<IContourProperty> z(IEnumerable<int?> values) => Interop.mkContourAttr("z", values.ToArray());
        /// Sets the z data.
        public static Box<IContourProperty> z(IEnumerable<float?> values) => Interop.mkContourAttr("z", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IContourProperty> x(bool val) => Interop.mkContourAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IContourProperty> x(IEnumerable<bool> values) => Interop.mkContourAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IContourProperty> x(System.DateTime val) => Interop.mkContourAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IContourProperty> x(IEnumerable<System.DateTime> values) => Interop.mkContourAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IContourProperty> x(float val) => Interop.mkContourAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IContourProperty> x(IEnumerable<float> values) => Interop.mkContourAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IContourProperty> x(int val) => Interop.mkContourAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IContourProperty> x(IEnumerable<int> values) => Interop.mkContourAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IContourProperty> x(string val) => Interop.mkContourAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IContourProperty> x(IEnumerable<string> values) => Interop.mkContourAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IContourProperty> x(IEnumerable<bool[]> values) => Interop.mkContourAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IContourProperty> x(List<bool[]> values) => Interop.mkContourAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IContourProperty> x(params bool[][] values) => Interop.mkContourAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IContourProperty> x(IEnumerable<IEnumerable<string>> values) => Interop.mkContourAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IContourProperty> x(List<string[]> values) => Interop.mkContourAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IContourProperty> x(params string[][] values) => Interop.mkContourAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IContourProperty> x(IEnumerable<IEnumerable<int>> values) => Interop.mkContourAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IContourProperty> x(List<int[]> values) => Interop.mkContourAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IContourProperty> x(params int[][] values) => Interop.mkContourAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IContourProperty> x(IEnumerable<IEnumerable<float>> values) => Interop.mkContourAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IContourProperty> x(List<float[]> values) => Interop.mkContourAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IContourProperty> x(params float[][] values) => Interop.mkContourAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IContourProperty> x(Literals.PlotData[] values) => Interop.mkContourAttr("x", values);
        /// Sets the x coordinates.
        public static Box<IContourProperty> x(IEnumerable<bool?> values) => Interop.mkContourAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IContourProperty> x(IEnumerable<System.DateTime?> values) => Interop.mkContourAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IContourProperty> x(IEnumerable<int?> values) => Interop.mkContourAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IContourProperty> x(IEnumerable<float?> values) => Interop.mkContourAttr("x", values.ToArray());
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IContourProperty> x0(bool val) => Interop.mkContourAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IContourProperty> x0(params bool[] values) => Interop.mkContourAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IContourProperty> x0(System.DateTime val) => Interop.mkContourAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IContourProperty> x0(params System.DateTime[] values) => Interop.mkContourAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IContourProperty> x0(int val) => Interop.mkContourAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IContourProperty> x0(params int[] values) => Interop.mkContourAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IContourProperty> x0(float val) => Interop.mkContourAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IContourProperty> x0(params float[] values) => Interop.mkContourAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IContourProperty> x0(string val) => Interop.mkContourAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IContourProperty> x0(params string[] values) => Interop.mkContourAttr("x0", values);
        /// Sets the x coordinate step. See `x0` for more info.
        public static Box<IContourProperty> dx(int val) => Interop.mkContourAttr("dx", val);
        /// Sets the x coordinate step. See `x0` for more info.
        public static Box<IContourProperty> dx(float val) => Interop.mkContourAttr("dx", val);
        /// Sets the y coordinates.
        public static Box<IContourProperty> y(bool val) => Interop.mkContourAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IContourProperty> y(IEnumerable<bool> values) => Interop.mkContourAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IContourProperty> y(System.DateTime val) => Interop.mkContourAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IContourProperty> y(IEnumerable<System.DateTime> values) => Interop.mkContourAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IContourProperty> y(float val) => Interop.mkContourAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IContourProperty> y(IEnumerable<float> values) => Interop.mkContourAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IContourProperty> y(int val) => Interop.mkContourAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IContourProperty> y(IEnumerable<int> values) => Interop.mkContourAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IContourProperty> y(string val) => Interop.mkContourAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IContourProperty> y(IEnumerable<string> values) => Interop.mkContourAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IContourProperty> y(IEnumerable<bool[]> values) => Interop.mkContourAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IContourProperty> y(List<bool[]> values) => Interop.mkContourAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IContourProperty> y(params bool[][] values) => Interop.mkContourAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IContourProperty> y(IEnumerable<IEnumerable<string>> values) => Interop.mkContourAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IContourProperty> y(List<string[]> values) => Interop.mkContourAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IContourProperty> y(params string[][] values) => Interop.mkContourAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IContourProperty> y(IEnumerable<IEnumerable<int>> values) => Interop.mkContourAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IContourProperty> y(List<int[]> values) => Interop.mkContourAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IContourProperty> y(params int[][] values) => Interop.mkContourAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IContourProperty> y(IEnumerable<IEnumerable<float>> values) => Interop.mkContourAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IContourProperty> y(List<float[]> values) => Interop.mkContourAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IContourProperty> y(params float[][] values) => Interop.mkContourAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IContourProperty> y(Literals.PlotData[] values) => Interop.mkContourAttr("y", values);
        /// Sets the y coordinates.
        public static Box<IContourProperty> y(IEnumerable<bool?> values) => Interop.mkContourAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IContourProperty> y(IEnumerable<System.DateTime?> values) => Interop.mkContourAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IContourProperty> y(IEnumerable<int?> values) => Interop.mkContourAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IContourProperty> y(IEnumerable<float?> values) => Interop.mkContourAttr("y", values.ToArray());
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IContourProperty> y0(bool val) => Interop.mkContourAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IContourProperty> y0(params bool[] values) => Interop.mkContourAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IContourProperty> y0(System.DateTime val) => Interop.mkContourAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IContourProperty> y0(params System.DateTime[] values) => Interop.mkContourAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IContourProperty> y0(int val) => Interop.mkContourAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IContourProperty> y0(params int[] values) => Interop.mkContourAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IContourProperty> y0(float val) => Interop.mkContourAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IContourProperty> y0(params float[] values) => Interop.mkContourAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IContourProperty> y0(string val) => Interop.mkContourAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IContourProperty> y0(params string[] values) => Interop.mkContourAttr("y0", values);
        /// Sets the y coordinate step. See `y0` for more info.
        public static Box<IContourProperty> dy(int val) => Interop.mkContourAttr("dy", val);
        /// Sets the y coordinate step. See `y0` for more info.
        public static Box<IContourProperty> dy(float val) => Interop.mkContourAttr("dy", val);
        /// Sets the text elements associated with each z value.
        public static Box<IContourProperty> text(bool val) => Interop.mkContourAttr("text", new[]{val});
        /// Sets the text elements associated with each z value.
        public static Box<IContourProperty> text(params bool[] values) => Interop.mkContourAttr("text", values);
        /// Sets the text elements associated with each z value.
        public static Box<IContourProperty> text(System.DateTime val) => Interop.mkContourAttr("text", new[]{val});
        /// Sets the text elements associated with each z value.
        public static Box<IContourProperty> text(params System.DateTime[] values) => Interop.mkContourAttr("text", values);
        /// Sets the text elements associated with each z value.
        public static Box<IContourProperty> text(float val) => Interop.mkContourAttr("text", new[]{val});
        /// Sets the text elements associated with each z value.
        public static Box<IContourProperty> text(params float[] values) => Interop.mkContourAttr("text", values);
        /// Sets the text elements associated with each z value.
        public static Box<IContourProperty> text(int val) => Interop.mkContourAttr("text", new[]{val});
        /// Sets the text elements associated with each z value.
        public static Box<IContourProperty> text(params int[] values) => Interop.mkContourAttr("text", values);
        /// Sets the text elements associated with each z value.
        public static Box<IContourProperty> text(string val) => Interop.mkContourAttr("text", new[]{val});
        /// Sets the text elements associated with each z value.
        public static Box<IContourProperty> text(params string[] values) => Interop.mkContourAttr("text", values);
        /// Sets the text elements associated with each z value.
        public static Box<IContourProperty> text(IEnumerable<bool[]> values) => Interop.mkContourAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IContourProperty> text(List<bool[]> values) => Interop.mkContourAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IContourProperty> text(params bool[][] values) => Interop.mkContourAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IContourProperty> text(IEnumerable<IEnumerable<string>> values) => Interop.mkContourAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IContourProperty> text(List<string[]> values) => Interop.mkContourAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IContourProperty> text(params string[][] values) => Interop.mkContourAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IContourProperty> text(IEnumerable<IEnumerable<int>> values) => Interop.mkContourAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IContourProperty> text(List<int[]> values) => Interop.mkContourAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IContourProperty> text(params int[][] values) => Interop.mkContourAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IContourProperty> text(IEnumerable<IEnumerable<float>> values) => Interop.mkContourAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IContourProperty> text(List<float[]> values) => Interop.mkContourAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IContourProperty> text(params float[][] values) => Interop.mkContourAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IContourProperty> text(Literals.PlotData[] values) => Interop.mkContourAttr("text", values);
        /// Sets the text elements associated with each z value.
        public static Box<IContourProperty> text(IEnumerable<bool?> values) => Interop.mkContourAttr("text", values.ToArray());
        /// Sets the text elements associated with each z value.
        public static Box<IContourProperty> text(IEnumerable<System.DateTime?> values) => Interop.mkContourAttr("text", values.ToArray());
        /// Sets the text elements associated with each z value.
        public static Box<IContourProperty> text(IEnumerable<int?> values) => Interop.mkContourAttr("text", values.ToArray());
        /// Sets the text elements associated with each z value.
        public static Box<IContourProperty> text(IEnumerable<float?> values) => Interop.mkContourAttr("text", values.ToArray());
        /// Same as `text`.
        public static Box<IContourProperty> hovertext(bool val) => Interop.mkContourAttr("hovertext", new[]{val});
        /// Same as `text`.
        public static Box<IContourProperty> hovertext(params bool[] values) => Interop.mkContourAttr("hovertext", values);
        /// Same as `text`.
        public static Box<IContourProperty> hovertext(System.DateTime val) => Interop.mkContourAttr("hovertext", new[]{val});
        /// Same as `text`.
        public static Box<IContourProperty> hovertext(params System.DateTime[] values) => Interop.mkContourAttr("hovertext", values);
        /// Same as `text`.
        public static Box<IContourProperty> hovertext(float val) => Interop.mkContourAttr("hovertext", new[]{val});
        /// Same as `text`.
        public static Box<IContourProperty> hovertext(params float[] values) => Interop.mkContourAttr("hovertext", values);
        /// Same as `text`.
        public static Box<IContourProperty> hovertext(int val) => Interop.mkContourAttr("hovertext", new[]{val});
        /// Same as `text`.
        public static Box<IContourProperty> hovertext(params int[] values) => Interop.mkContourAttr("hovertext", values);
        /// Same as `text`.
        public static Box<IContourProperty> hovertext(string val) => Interop.mkContourAttr("hovertext", new[]{val});
        /// Same as `text`.
        public static Box<IContourProperty> hovertext(params string[] values) => Interop.mkContourAttr("hovertext", values);
        /// Same as `text`.
        public static Box<IContourProperty> hovertext(IEnumerable<bool[]> values) => Interop.mkContourAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IContourProperty> hovertext(List<bool[]> values) => Interop.mkContourAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IContourProperty> hovertext(params bool[][] values) => Interop.mkContourAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IContourProperty> hovertext(IEnumerable<IEnumerable<string>> values) => Interop.mkContourAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IContourProperty> hovertext(List<string[]> values) => Interop.mkContourAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IContourProperty> hovertext(params string[][] values) => Interop.mkContourAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IContourProperty> hovertext(IEnumerable<IEnumerable<int>> values) => Interop.mkContourAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IContourProperty> hovertext(List<int[]> values) => Interop.mkContourAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IContourProperty> hovertext(params int[][] values) => Interop.mkContourAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IContourProperty> hovertext(IEnumerable<IEnumerable<float>> values) => Interop.mkContourAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IContourProperty> hovertext(List<float[]> values) => Interop.mkContourAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IContourProperty> hovertext(params float[][] values) => Interop.mkContourAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IContourProperty> hovertext(Literals.PlotData[] values) => Interop.mkContourAttr("hovertext", values);
        /// Same as `text`.
        public static Box<IContourProperty> hovertext(IEnumerable<bool?> values) => Interop.mkContourAttr("hovertext", values.ToArray());
        /// Same as `text`.
        public static Box<IContourProperty> hovertext(IEnumerable<System.DateTime?> values) => Interop.mkContourAttr("hovertext", values.ToArray());
        /// Same as `text`.
        public static Box<IContourProperty> hovertext(IEnumerable<int?> values) => Interop.mkContourAttr("hovertext", values.ToArray());
        /// Same as `text`.
        public static Box<IContourProperty> hovertext(IEnumerable<float?> values) => Interop.mkContourAttr("hovertext", values.ToArray());
        /// Transposes the z data.
        public static Box<IContourProperty> transpose(bool val) => Interop.mkContourAttr("transpose", val);
        /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. See: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IContourProperty> zhoverformat(string val) => Interop.mkContourAttr("zhoverformat", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IContourProperty> hovertemplate(string val) => Interop.mkContourAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IContourProperty> hovertemplate(IEnumerable<string> values) => Interop.mkContourAttr("hovertemplate", values.ToArray());
        /// Determines whether or not gaps (i.e. {nan} or missing values) in the `z` data have hover labels associated with them.
        public static Box<IContourProperty> hoverongaps(bool val) => Interop.mkContourAttr("hoverongaps", val);
        /// Determines whether or not gaps (i.e. {nan} or missing values) in the `z` data are filled in. It is defaulted to true if `z` is a one dimensional array otherwise it is defaulted to false.
        public static Box<IContourProperty> connectgaps(bool val) => Interop.mkContourAttr("connectgaps", val);
        /// Sets the fill color if `contours.type` is *constraint*. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
        public static Box<IContourProperty> fillcolor(string val) => Interop.mkContourAttr("fillcolor", val);
        /// Determines whether or not the contour level attributes are picked by an algorithm. If *true*, the number of contour levels can be set in `ncontours`. If *false*, set the contour level attributes in `contours`.
        public static Box<IContourProperty> autocontour(bool val) => Interop.mkContourAttr("autocontour", val);
        /// Sets the maximum number of contour levels. The actual number of contours will be chosen automatically to be less than or equal to the value of `ncontours`. Has an effect only if `autocontour` is *true* or if `contours.size` is missing.
        public static Box<IContourProperty> ncontours(int val) => Interop.mkContourAttr("ncontours", val);
        public static Box<IContourProperty> contours(params Box<IContoursProperty>[] properties) => Interop.mkContourAttr("contours", Bindings.flattenProperties(properties));
        public static Box<IContourProperty> line(params Box<ILineProperty>[] properties) => Interop.mkContourAttr("line", Bindings.flattenProperties(properties));
        /// Determines whether or not the color domain is computed with respect to the input data (here in `z`) or the bounds set in `zmin` and `zmax`  Defaults to `false` when `zmin` and `zmax` are set by the user.
        public static Box<IContourProperty> zauto(bool val) => Interop.mkContourAttr("zauto", val);
        /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
        public static Box<IContourProperty> zmin(int val) => Interop.mkContourAttr("zmin", val);
        /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
        public static Box<IContourProperty> zmin(float val) => Interop.mkContourAttr("zmin", val);
        /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
        public static Box<IContourProperty> zmax(int val) => Interop.mkContourAttr("zmax", val);
        /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
        public static Box<IContourProperty> zmax(float val) => Interop.mkContourAttr("zmax", val);
        /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
        public static Box<IContourProperty> zmid(int val) => Interop.mkContourAttr("zmid", val);
        /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
        public static Box<IContourProperty> zmid(float val) => Interop.mkContourAttr("zmid", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IContourProperty> colorscale(string val) => Interop.mkContourAttr("colorscale", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IContourProperty> colorscale(List<string[]> values) => Interop.mkContourAttr("colorscale", Bindings.flatten2DArrayIf1D(values));
        /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
        public static Box<IContourProperty> autocolorscale(bool val) => Interop.mkContourAttr("autocolorscale", val);
        /// Reverses the color mapping if true. If true, `zmin` will correspond to the last color in the array and `zmax` will correspond to the first color.
        public static Box<IContourProperty> reversescale(bool val) => Interop.mkContourAttr("reversescale", val);
        /// Determines whether or not a colorbar is displayed for this trace.
        public static Box<IContourProperty> showscale(bool val) => Interop.mkContourAttr("showscale", val);
        public static Box<IContourProperty> colorbar(params Box<IColorbarProperty>[] properties) => Interop.mkContourAttr("colorbar", Bindings.flattenProperties(properties));
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<IContourProperty> coloraxis(int anchorId) => Interop.mkContourAttr("coloraxis", anchorId > 1 ? $"coloraxis{anchorId}" : "");
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<IContourProperty> coloraxis(string val) => Interop.mkContourAttr("coloraxis", val);
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IContourProperty> xaxis(int anchorId) => Interop.mkContourAttr("xaxis", anchorId > 1 ? $"x{anchorId}" : "");
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IContourProperty> xaxis(string val) => Interop.mkContourAttr("xaxis", val);
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IContourProperty> yaxis(int anchorId) => Interop.mkContourAttr("yaxis", anchorId > 1 ? $"y{anchorId}" : "");
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IContourProperty> yaxis(string val) => Interop.mkContourAttr("yaxis", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IContourProperty> idssrc(string val) => Interop.mkContourAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IContourProperty> customdatasrc(string val) => Interop.mkContourAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IContourProperty> metasrc(string val) => Interop.mkContourAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IContourProperty> hoverinfosrc(string val) => Interop.mkContourAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  z .
        public static Box<IContourProperty> zsrc(string val) => Interop.mkContourAttr("zsrc", val);
        /// Sets the source reference on plot.ly for  x .
        public static Box<IContourProperty> xsrc(string val) => Interop.mkContourAttr("xsrc", val);
        /// Sets the source reference on plot.ly for  y .
        public static Box<IContourProperty> ysrc(string val) => Interop.mkContourAttr("ysrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IContourProperty> textsrc(string val) => Interop.mkContourAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IContourProperty> hovertextsrc(string val) => Interop.mkContourAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IContourProperty> hovertemplatesrc(string val) => Interop.mkContourAttr("hovertemplatesrc", val);
        /// Sets whether or not dynamic contours are shown on hover
        public static Box<IContourProperty> show(bool val) => Interop.mkContourAttr("show", val);
        /// Sets the color of the contour lines.
        public static Box<IContourProperty> color(string val) => Interop.mkContourAttr("color", val);
        /// Sets the width of the contour lines.
        public static Box<IContourProperty> width(int val) => Interop.mkContourAttr("width", val);
        /// Sets the width of the contour lines.
        public static Box<IContourProperty> width(float val) => Interop.mkContourAttr("width", val);
    }

    public static partial class Contour
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IContourProperty> legendonly() => Interop.mkContourAttr("visible", "legendonly");
            public static Box<IContourProperty> _false() => Interop.mkContourAttr("visible", false);
            public static Box<IContourProperty> _true() => Interop.mkContourAttr("visible", true);
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IContourProperty> all() => Interop.mkContourAttr("hoverinfo", "all");
            public static Box<IContourProperty> none() => Interop.mkContourAttr("hoverinfo", "none");
            public static Box<IContourProperty> skip() => Interop.mkContourAttr("hoverinfo", "skip");
            public static Box<IContourProperty> name() => Interop.mkContourAttr("hoverinfo", "name");
            public static Box<IContourProperty> text() => Interop.mkContourAttr("hoverinfo", "text");
            public static Box<IContourProperty> x() => Interop.mkContourAttr("hoverinfo", "x");
            public static Box<IContourProperty> y() => Interop.mkContourAttr("hoverinfo", "y");
            public static Box<IContourProperty> z() => Interop.mkContourAttr("hoverinfo", "z");
        }

        /// If *array*, the heatmap's x coordinates are given by *x* (the default behavior when `x` is provided). If *scaled*, the heatmap's x coordinates are given by *x0* and *dx* (the default behavior when `x` is not provided).
        public static partial class Xtype
        {
            public static Box<IContourProperty> array() => Interop.mkContourAttr("xtype", "array");
            public static Box<IContourProperty> scaled() => Interop.mkContourAttr("xtype", "scaled");
        }

        /// If *array*, the heatmap's y coordinates are given by *y* (the default behavior when `y` is provided) If *scaled*, the heatmap's y coordinates are given by *y0* and *dy* (the default behavior when `y` is not provided)
        public static partial class Ytype
        {
            public static Box<IContourProperty> array() => Interop.mkContourAttr("ytype", "array");
            public static Box<IContourProperty> scaled() => Interop.mkContourAttr("ytype", "scaled");
        }

        /// Sets the calendar system to use with `x` date data.
        public static partial class Xcalendar
        {
            public static Box<IContourProperty> chinese() => Interop.mkContourAttr("xcalendar", "chinese");
            public static Box<IContourProperty> coptic() => Interop.mkContourAttr("xcalendar", "coptic");
            public static Box<IContourProperty> discworld() => Interop.mkContourAttr("xcalendar", "discworld");
            public static Box<IContourProperty> ethiopian() => Interop.mkContourAttr("xcalendar", "ethiopian");
            public static Box<IContourProperty> gregorian() => Interop.mkContourAttr("xcalendar", "gregorian");
            public static Box<IContourProperty> hebrew() => Interop.mkContourAttr("xcalendar", "hebrew");
            public static Box<IContourProperty> islamic() => Interop.mkContourAttr("xcalendar", "islamic");
            public static Box<IContourProperty> jalali() => Interop.mkContourAttr("xcalendar", "jalali");
            public static Box<IContourProperty> julian() => Interop.mkContourAttr("xcalendar", "julian");
            public static Box<IContourProperty> mayan() => Interop.mkContourAttr("xcalendar", "mayan");
            public static Box<IContourProperty> nanakshahi() => Interop.mkContourAttr("xcalendar", "nanakshahi");
            public static Box<IContourProperty> nepali() => Interop.mkContourAttr("xcalendar", "nepali");
            public static Box<IContourProperty> persian() => Interop.mkContourAttr("xcalendar", "persian");
            public static Box<IContourProperty> taiwan() => Interop.mkContourAttr("xcalendar", "taiwan");
            public static Box<IContourProperty> thai() => Interop.mkContourAttr("xcalendar", "thai");
            public static Box<IContourProperty> ummalqura() => Interop.mkContourAttr("xcalendar", "ummalqura");
        }

        /// Sets the calendar system to use with `y` date data.
        public static partial class Ycalendar
        {
            public static Box<IContourProperty> chinese() => Interop.mkContourAttr("ycalendar", "chinese");
            public static Box<IContourProperty> coptic() => Interop.mkContourAttr("ycalendar", "coptic");
            public static Box<IContourProperty> discworld() => Interop.mkContourAttr("ycalendar", "discworld");
            public static Box<IContourProperty> ethiopian() => Interop.mkContourAttr("ycalendar", "ethiopian");
            public static Box<IContourProperty> gregorian() => Interop.mkContourAttr("ycalendar", "gregorian");
            public static Box<IContourProperty> hebrew() => Interop.mkContourAttr("ycalendar", "hebrew");
            public static Box<IContourProperty> islamic() => Interop.mkContourAttr("ycalendar", "islamic");
            public static Box<IContourProperty> jalali() => Interop.mkContourAttr("ycalendar", "jalali");
            public static Box<IContourProperty> julian() => Interop.mkContourAttr("ycalendar", "julian");
            public static Box<IContourProperty> mayan() => Interop.mkContourAttr("ycalendar", "mayan");
            public static Box<IContourProperty> nanakshahi() => Interop.mkContourAttr("ycalendar", "nanakshahi");
            public static Box<IContourProperty> nepali() => Interop.mkContourAttr("ycalendar", "nepali");
            public static Box<IContourProperty> persian() => Interop.mkContourAttr("ycalendar", "persian");
            public static Box<IContourProperty> taiwan() => Interop.mkContourAttr("ycalendar", "taiwan");
            public static Box<IContourProperty> thai() => Interop.mkContourAttr("ycalendar", "thai");
            public static Box<IContourProperty> ummalqura() => Interop.mkContourAttr("ycalendar", "ummalqura");
        }
    }
}