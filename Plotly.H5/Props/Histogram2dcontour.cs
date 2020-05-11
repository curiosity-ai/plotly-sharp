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

    public static partial class Histogram2dcontour
    {
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IHistogram2dcontourProperty> showlegend(bool val) => Interop.mkHistogram2dcontourAttr("showlegend", val);
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IHistogram2dcontourProperty> legendgroup(string val) => Interop.mkHistogram2dcontourAttr("legendgroup", val);
        /// Sets the opacity of the trace.
        public static Box<IHistogram2dcontourProperty> opacity(int val) => Interop.mkHistogram2dcontourAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<IHistogram2dcontourProperty> opacity(float val) => Interop.mkHistogram2dcontourAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IHistogram2dcontourProperty> name(string val) => Interop.mkHistogram2dcontourAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IHistogram2dcontourProperty> uid(string val) => Interop.mkHistogram2dcontourAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dcontourProperty> ids(bool val) => Interop.mkHistogram2dcontourAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dcontourProperty> ids(params bool[] values) => Interop.mkHistogram2dcontourAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dcontourProperty> ids(System.DateTime val) => Interop.mkHistogram2dcontourAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dcontourProperty> ids(params System.DateTime[] values) => Interop.mkHistogram2dcontourAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dcontourProperty> ids(float val) => Interop.mkHistogram2dcontourAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dcontourProperty> ids(params float[] values) => Interop.mkHistogram2dcontourAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dcontourProperty> ids(int val) => Interop.mkHistogram2dcontourAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dcontourProperty> ids(params int[] values) => Interop.mkHistogram2dcontourAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dcontourProperty> ids(string val) => Interop.mkHistogram2dcontourAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dcontourProperty> ids(params string[] values) => Interop.mkHistogram2dcontourAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dcontourProperty> ids(IEnumerable<bool[]> values) => Interop.mkHistogram2dcontourAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dcontourProperty> ids(List<bool[]> values) => Interop.mkHistogram2dcontourAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dcontourProperty> ids(params bool[][] values) => Interop.mkHistogram2dcontourAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dcontourProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkHistogram2dcontourAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dcontourProperty> ids(List<string[]> values) => Interop.mkHistogram2dcontourAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dcontourProperty> ids(params string[][] values) => Interop.mkHistogram2dcontourAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dcontourProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkHistogram2dcontourAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dcontourProperty> ids(List<int[]> values) => Interop.mkHistogram2dcontourAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dcontourProperty> ids(params int[][] values) => Interop.mkHistogram2dcontourAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dcontourProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkHistogram2dcontourAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dcontourProperty> ids(List<float[]> values) => Interop.mkHistogram2dcontourAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dcontourProperty> ids(params float[][] values) => Interop.mkHistogram2dcontourAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dcontourProperty> ids(Literals.PlotData[] values) => Interop.mkHistogram2dcontourAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dcontourProperty> ids(IEnumerable<bool?> values) => Interop.mkHistogram2dcontourAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dcontourProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkHistogram2dcontourAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dcontourProperty> ids(IEnumerable<int?> values) => Interop.mkHistogram2dcontourAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogram2dcontourProperty> ids(IEnumerable<float?> values) => Interop.mkHistogram2dcontourAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dcontourProperty> customdata(bool val) => Interop.mkHistogram2dcontourAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dcontourProperty> customdata(params bool[] values) => Interop.mkHistogram2dcontourAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dcontourProperty> customdata(System.DateTime val) => Interop.mkHistogram2dcontourAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dcontourProperty> customdata(params System.DateTime[] values) => Interop.mkHistogram2dcontourAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dcontourProperty> customdata(float val) => Interop.mkHistogram2dcontourAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dcontourProperty> customdata(params float[] values) => Interop.mkHistogram2dcontourAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dcontourProperty> customdata(int val) => Interop.mkHistogram2dcontourAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dcontourProperty> customdata(params int[] values) => Interop.mkHistogram2dcontourAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dcontourProperty> customdata(string val) => Interop.mkHistogram2dcontourAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dcontourProperty> customdata(params string[] values) => Interop.mkHistogram2dcontourAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dcontourProperty> customdata(IEnumerable<bool[]> values) => Interop.mkHistogram2dcontourAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dcontourProperty> customdata(List<bool[]> values) => Interop.mkHistogram2dcontourAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dcontourProperty> customdata(params bool[][] values) => Interop.mkHistogram2dcontourAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dcontourProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkHistogram2dcontourAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dcontourProperty> customdata(List<string[]> values) => Interop.mkHistogram2dcontourAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dcontourProperty> customdata(params string[][] values) => Interop.mkHistogram2dcontourAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dcontourProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkHistogram2dcontourAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dcontourProperty> customdata(List<int[]> values) => Interop.mkHistogram2dcontourAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dcontourProperty> customdata(params int[][] values) => Interop.mkHistogram2dcontourAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dcontourProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkHistogram2dcontourAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dcontourProperty> customdata(List<float[]> values) => Interop.mkHistogram2dcontourAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dcontourProperty> customdata(params float[][] values) => Interop.mkHistogram2dcontourAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dcontourProperty> customdata(Literals.PlotData[] values) => Interop.mkHistogram2dcontourAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dcontourProperty> customdata(IEnumerable<bool?> values) => Interop.mkHistogram2dcontourAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dcontourProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkHistogram2dcontourAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dcontourProperty> customdata(IEnumerable<int?> values) => Interop.mkHistogram2dcontourAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogram2dcontourProperty> customdata(IEnumerable<float?> values) => Interop.mkHistogram2dcontourAttr("customdata", values.ToArray());
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IHistogram2dcontourProperty> hoverinfo(params Box<IHistogram2dcontourProperty>[] properties) => Interop.mkHistogram2dcontourAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        public static Box<IHistogram2dcontourProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkHistogram2dcontourAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IHistogram2dcontourProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkHistogram2dcontourAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IHistogram2dcontourProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkHistogram2dcontourAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogram2dcontourProperty> uirevision(bool val) => Interop.mkHistogram2dcontourAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogram2dcontourProperty> uirevision(params bool[] values) => Interop.mkHistogram2dcontourAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogram2dcontourProperty> uirevision(System.DateTime val) => Interop.mkHistogram2dcontourAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogram2dcontourProperty> uirevision(params System.DateTime[] values) => Interop.mkHistogram2dcontourAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogram2dcontourProperty> uirevision(int val) => Interop.mkHistogram2dcontourAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogram2dcontourProperty> uirevision(params int[] values) => Interop.mkHistogram2dcontourAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogram2dcontourProperty> uirevision(float val) => Interop.mkHistogram2dcontourAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogram2dcontourProperty> uirevision(params float[] values) => Interop.mkHistogram2dcontourAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogram2dcontourProperty> uirevision(string val) => Interop.mkHistogram2dcontourAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogram2dcontourProperty> uirevision(params string[] values) => Interop.mkHistogram2dcontourAttr("uirevision", values);
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dcontourProperty> x(bool val) => Interop.mkHistogram2dcontourAttr("x", new[]{val});
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dcontourProperty> x(IEnumerable<bool> values) => Interop.mkHistogram2dcontourAttr("x", values.ToArray());
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dcontourProperty> x(System.DateTime val) => Interop.mkHistogram2dcontourAttr("x", new[]{val});
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dcontourProperty> x(IEnumerable<System.DateTime> values) => Interop.mkHistogram2dcontourAttr("x", values.ToArray());
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dcontourProperty> x(float val) => Interop.mkHistogram2dcontourAttr("x", new[]{val});
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dcontourProperty> x(IEnumerable<float> values) => Interop.mkHistogram2dcontourAttr("x", values.ToArray());
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dcontourProperty> x(int val) => Interop.mkHistogram2dcontourAttr("x", new[]{val});
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dcontourProperty> x(IEnumerable<int> values) => Interop.mkHistogram2dcontourAttr("x", values.ToArray());
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dcontourProperty> x(string val) => Interop.mkHistogram2dcontourAttr("x", new[]{val});
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dcontourProperty> x(IEnumerable<string> values) => Interop.mkHistogram2dcontourAttr("x", values.ToArray());
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dcontourProperty> x(IEnumerable<bool[]> values) => Interop.mkHistogram2dcontourAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dcontourProperty> x(List<bool[]> values) => Interop.mkHistogram2dcontourAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dcontourProperty> x(params bool[][] values) => Interop.mkHistogram2dcontourAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dcontourProperty> x(IEnumerable<IEnumerable<string>> values) => Interop.mkHistogram2dcontourAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dcontourProperty> x(List<string[]> values) => Interop.mkHistogram2dcontourAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dcontourProperty> x(params string[][] values) => Interop.mkHistogram2dcontourAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dcontourProperty> x(IEnumerable<IEnumerable<int>> values) => Interop.mkHistogram2dcontourAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dcontourProperty> x(List<int[]> values) => Interop.mkHistogram2dcontourAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dcontourProperty> x(params int[][] values) => Interop.mkHistogram2dcontourAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dcontourProperty> x(IEnumerable<IEnumerable<float>> values) => Interop.mkHistogram2dcontourAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dcontourProperty> x(List<float[]> values) => Interop.mkHistogram2dcontourAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dcontourProperty> x(params float[][] values) => Interop.mkHistogram2dcontourAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dcontourProperty> x(Literals.PlotData[] values) => Interop.mkHistogram2dcontourAttr("x", values);
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dcontourProperty> x(IEnumerable<bool?> values) => Interop.mkHistogram2dcontourAttr("x", values.ToArray());
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dcontourProperty> x(IEnumerable<System.DateTime?> values) => Interop.mkHistogram2dcontourAttr("x", values.ToArray());
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dcontourProperty> x(IEnumerable<int?> values) => Interop.mkHistogram2dcontourAttr("x", values.ToArray());
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogram2dcontourProperty> x(IEnumerable<float?> values) => Interop.mkHistogram2dcontourAttr("x", values.ToArray());
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dcontourProperty> y(bool val) => Interop.mkHistogram2dcontourAttr("y", new[]{val});
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dcontourProperty> y(IEnumerable<bool> values) => Interop.mkHistogram2dcontourAttr("y", values.ToArray());
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dcontourProperty> y(System.DateTime val) => Interop.mkHistogram2dcontourAttr("y", new[]{val});
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dcontourProperty> y(IEnumerable<System.DateTime> values) => Interop.mkHistogram2dcontourAttr("y", values.ToArray());
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dcontourProperty> y(float val) => Interop.mkHistogram2dcontourAttr("y", new[]{val});
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dcontourProperty> y(IEnumerable<float> values) => Interop.mkHistogram2dcontourAttr("y", values.ToArray());
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dcontourProperty> y(int val) => Interop.mkHistogram2dcontourAttr("y", new[]{val});
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dcontourProperty> y(IEnumerable<int> values) => Interop.mkHistogram2dcontourAttr("y", values.ToArray());
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dcontourProperty> y(string val) => Interop.mkHistogram2dcontourAttr("y", new[]{val});
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dcontourProperty> y(IEnumerable<string> values) => Interop.mkHistogram2dcontourAttr("y", values.ToArray());
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dcontourProperty> y(IEnumerable<bool[]> values) => Interop.mkHistogram2dcontourAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dcontourProperty> y(List<bool[]> values) => Interop.mkHistogram2dcontourAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dcontourProperty> y(params bool[][] values) => Interop.mkHistogram2dcontourAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dcontourProperty> y(IEnumerable<IEnumerable<string>> values) => Interop.mkHistogram2dcontourAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dcontourProperty> y(List<string[]> values) => Interop.mkHistogram2dcontourAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dcontourProperty> y(params string[][] values) => Interop.mkHistogram2dcontourAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dcontourProperty> y(IEnumerable<IEnumerable<int>> values) => Interop.mkHistogram2dcontourAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dcontourProperty> y(List<int[]> values) => Interop.mkHistogram2dcontourAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dcontourProperty> y(params int[][] values) => Interop.mkHistogram2dcontourAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dcontourProperty> y(IEnumerable<IEnumerable<float>> values) => Interop.mkHistogram2dcontourAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dcontourProperty> y(List<float[]> values) => Interop.mkHistogram2dcontourAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dcontourProperty> y(params float[][] values) => Interop.mkHistogram2dcontourAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dcontourProperty> y(Literals.PlotData[] values) => Interop.mkHistogram2dcontourAttr("y", values);
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dcontourProperty> y(IEnumerable<bool?> values) => Interop.mkHistogram2dcontourAttr("y", values.ToArray());
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dcontourProperty> y(IEnumerable<System.DateTime?> values) => Interop.mkHistogram2dcontourAttr("y", values.ToArray());
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dcontourProperty> y(IEnumerable<int?> values) => Interop.mkHistogram2dcontourAttr("y", values.ToArray());
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogram2dcontourProperty> y(IEnumerable<float?> values) => Interop.mkHistogram2dcontourAttr("y", values.ToArray());
        /// Sets the aggregation data.
        public static Box<IHistogram2dcontourProperty> z(bool val) => Interop.mkHistogram2dcontourAttr("z", new[]{val});
        /// Sets the aggregation data.
        public static Box<IHistogram2dcontourProperty> z(params bool[] values) => Interop.mkHistogram2dcontourAttr("z", values);
        /// Sets the aggregation data.
        public static Box<IHistogram2dcontourProperty> z(System.DateTime val) => Interop.mkHistogram2dcontourAttr("z", new[]{val});
        /// Sets the aggregation data.
        public static Box<IHistogram2dcontourProperty> z(params System.DateTime[] values) => Interop.mkHistogram2dcontourAttr("z", values);
        /// Sets the aggregation data.
        public static Box<IHistogram2dcontourProperty> z(float val) => Interop.mkHistogram2dcontourAttr("z", new[]{val});
        /// Sets the aggregation data.
        public static Box<IHistogram2dcontourProperty> z(params float[] values) => Interop.mkHistogram2dcontourAttr("z", values);
        /// Sets the aggregation data.
        public static Box<IHistogram2dcontourProperty> z(int val) => Interop.mkHistogram2dcontourAttr("z", new[]{val});
        /// Sets the aggregation data.
        public static Box<IHistogram2dcontourProperty> z(params int[] values) => Interop.mkHistogram2dcontourAttr("z", values);
        /// Sets the aggregation data.
        public static Box<IHistogram2dcontourProperty> z(string val) => Interop.mkHistogram2dcontourAttr("z", new[]{val});
        /// Sets the aggregation data.
        public static Box<IHistogram2dcontourProperty> z(params string[] values) => Interop.mkHistogram2dcontourAttr("z", values);
        /// Sets the aggregation data.
        public static Box<IHistogram2dcontourProperty> z(IEnumerable<bool[]> values) => Interop.mkHistogram2dcontourAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the aggregation data.
        public static Box<IHistogram2dcontourProperty> z(List<bool[]> values) => Interop.mkHistogram2dcontourAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the aggregation data.
        public static Box<IHistogram2dcontourProperty> z(params bool[][] values) => Interop.mkHistogram2dcontourAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the aggregation data.
        public static Box<IHistogram2dcontourProperty> z(IEnumerable<IEnumerable<string>> values) => Interop.mkHistogram2dcontourAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the aggregation data.
        public static Box<IHistogram2dcontourProperty> z(List<string[]> values) => Interop.mkHistogram2dcontourAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the aggregation data.
        public static Box<IHistogram2dcontourProperty> z(params string[][] values) => Interop.mkHistogram2dcontourAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the aggregation data.
        public static Box<IHistogram2dcontourProperty> z(IEnumerable<IEnumerable<int>> values) => Interop.mkHistogram2dcontourAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the aggregation data.
        public static Box<IHistogram2dcontourProperty> z(List<int[]> values) => Interop.mkHistogram2dcontourAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the aggregation data.
        public static Box<IHistogram2dcontourProperty> z(params int[][] values) => Interop.mkHistogram2dcontourAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the aggregation data.
        public static Box<IHistogram2dcontourProperty> z(IEnumerable<IEnumerable<float>> values) => Interop.mkHistogram2dcontourAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the aggregation data.
        public static Box<IHistogram2dcontourProperty> z(List<float[]> values) => Interop.mkHistogram2dcontourAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the aggregation data.
        public static Box<IHistogram2dcontourProperty> z(params float[][] values) => Interop.mkHistogram2dcontourAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the aggregation data.
        public static Box<IHistogram2dcontourProperty> z(Literals.PlotData[] values) => Interop.mkHistogram2dcontourAttr("z", values);
        /// Sets the aggregation data.
        public static Box<IHistogram2dcontourProperty> z(IEnumerable<bool?> values) => Interop.mkHistogram2dcontourAttr("z", values.ToArray());
        /// Sets the aggregation data.
        public static Box<IHistogram2dcontourProperty> z(IEnumerable<System.DateTime?> values) => Interop.mkHistogram2dcontourAttr("z", values.ToArray());
        /// Sets the aggregation data.
        public static Box<IHistogram2dcontourProperty> z(IEnumerable<int?> values) => Interop.mkHistogram2dcontourAttr("z", values.ToArray());
        /// Sets the aggregation data.
        public static Box<IHistogram2dcontourProperty> z(IEnumerable<float?> values) => Interop.mkHistogram2dcontourAttr("z", values.ToArray());
        public static Box<IHistogram2dcontourProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkHistogram2dcontourAttr("marker", Bindings.flattenProperties(properties));
        /// Specifies the maximum number of desired bins. This value will be used in an algorithm that will decide the optimal bin size such that the histogram best visualizes the distribution of the data. Ignored if `xbins.size` is provided.
        public static Box<IHistogram2dcontourProperty> nbinsx(int val) => Interop.mkHistogram2dcontourAttr("nbinsx", val);
        public static Box<IHistogram2dcontourProperty> xbins(params Box<IXbinsProperty>[] properties) => Interop.mkHistogram2dcontourAttr("xbins", Bindings.flattenProperties(properties));
        /// Specifies the maximum number of desired bins. This value will be used in an algorithm that will decide the optimal bin size such that the histogram best visualizes the distribution of the data. Ignored if `ybins.size` is provided.
        public static Box<IHistogram2dcontourProperty> nbinsy(int val) => Interop.mkHistogram2dcontourAttr("nbinsy", val);
        public static Box<IHistogram2dcontourProperty> ybins(params Box<IYbinsProperty>[] properties) => Interop.mkHistogram2dcontourAttr("ybins", Bindings.flattenProperties(properties));
        /// Obsolete: since v1.42 each bin attribute is auto-determined separately and `autobinx` is not needed. However, we accept `autobinx: true` or `false` and will update `xbins` accordingly before deleting `autobinx` from the trace.
        public static Box<IHistogram2dcontourProperty> autobinx(bool val) => Interop.mkHistogram2dcontourAttr("autobinx", val);
        /// Obsolete: since v1.42 each bin attribute is auto-determined separately and `autobiny` is not needed. However, we accept `autobiny: true` or `false` and will update `ybins` accordingly before deleting `autobiny` from the trace.
        public static Box<IHistogram2dcontourProperty> autobiny(bool val) => Interop.mkHistogram2dcontourAttr("autobiny", val);
        /// Set the `xbingroup` and `ybingroup` default prefix For example, setting a `bingroup` of *1* on two histogram2d traces will make them their x-bins and y-bins match separately.
        public static Box<IHistogram2dcontourProperty> bingroup(string val) => Interop.mkHistogram2dcontourAttr("bingroup", val);
        /// Set a group of histogram traces which will have compatible x-bin settings. Using `xbingroup`, histogram2d and histogram2dcontour traces  (on axes of the same axis type) can have compatible x-bin settings. Note that the same `xbingroup` value can be used to set (1D) histogram `bingroup`
        public static Box<IHistogram2dcontourProperty> xbingroup(string val) => Interop.mkHistogram2dcontourAttr("xbingroup", val);
        /// Set a group of histogram traces which will have compatible y-bin settings. Using `ybingroup`, histogram2d and histogram2dcontour traces  (on axes of the same axis type) can have compatible y-bin settings. Note that the same `ybingroup` value can be used to set (1D) histogram `bingroup`
        public static Box<IHistogram2dcontourProperty> ybingroup(string val) => Interop.mkHistogram2dcontourAttr("ybingroup", val);
        /// Determines whether or not the contour level attributes are picked by an algorithm. If *true*, the number of contour levels can be set in `ncontours`. If *false*, set the contour level attributes in `contours`.
        public static Box<IHistogram2dcontourProperty> autocontour(bool val) => Interop.mkHistogram2dcontourAttr("autocontour", val);
        /// Sets the maximum number of contour levels. The actual number of contours will be chosen automatically to be less than or equal to the value of `ncontours`. Has an effect only if `autocontour` is *true* or if `contours.size` is missing.
        public static Box<IHistogram2dcontourProperty> ncontours(int val) => Interop.mkHistogram2dcontourAttr("ncontours", val);
        public static Box<IHistogram2dcontourProperty> contours(params Box<IContoursProperty>[] properties) => Interop.mkHistogram2dcontourAttr("contours", Bindings.flattenProperties(properties));
        public static Box<IHistogram2dcontourProperty> line(params Box<ILineProperty>[] properties) => Interop.mkHistogram2dcontourAttr("line", Bindings.flattenProperties(properties));
        /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. See: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHistogram2dcontourProperty> zhoverformat(string val) => Interop.mkHistogram2dcontourAttr("zhoverformat", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variable `z` Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IHistogram2dcontourProperty> hovertemplate(string val) => Interop.mkHistogram2dcontourAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variable `z` Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IHistogram2dcontourProperty> hovertemplate(IEnumerable<string> values) => Interop.mkHistogram2dcontourAttr("hovertemplate", values.ToArray());
        /// Determines whether or not the color domain is computed with respect to the input data (here in `z`) or the bounds set in `zmin` and `zmax`  Defaults to `false` when `zmin` and `zmax` are set by the user.
        public static Box<IHistogram2dcontourProperty> zauto(bool val) => Interop.mkHistogram2dcontourAttr("zauto", val);
        /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
        public static Box<IHistogram2dcontourProperty> zmin(int val) => Interop.mkHistogram2dcontourAttr("zmin", val);
        /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
        public static Box<IHistogram2dcontourProperty> zmin(float val) => Interop.mkHistogram2dcontourAttr("zmin", val);
        /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
        public static Box<IHistogram2dcontourProperty> zmax(int val) => Interop.mkHistogram2dcontourAttr("zmax", val);
        /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
        public static Box<IHistogram2dcontourProperty> zmax(float val) => Interop.mkHistogram2dcontourAttr("zmax", val);
        /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
        public static Box<IHistogram2dcontourProperty> zmid(int val) => Interop.mkHistogram2dcontourAttr("zmid", val);
        /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
        public static Box<IHistogram2dcontourProperty> zmid(float val) => Interop.mkHistogram2dcontourAttr("zmid", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IHistogram2dcontourProperty> colorscale(string val) => Interop.mkHistogram2dcontourAttr("colorscale", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IHistogram2dcontourProperty> colorscale(List<string[]> values) => Interop.mkHistogram2dcontourAttr("colorscale", Bindings.flatten2DArrayIf1D(values));
        /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
        public static Box<IHistogram2dcontourProperty> autocolorscale(bool val) => Interop.mkHistogram2dcontourAttr("autocolorscale", val);
        /// Reverses the color mapping if true. If true, `zmin` will correspond to the last color in the array and `zmax` will correspond to the first color.
        public static Box<IHistogram2dcontourProperty> reversescale(bool val) => Interop.mkHistogram2dcontourAttr("reversescale", val);
        /// Determines whether or not a colorbar is displayed for this trace.
        public static Box<IHistogram2dcontourProperty> showscale(bool val) => Interop.mkHistogram2dcontourAttr("showscale", val);
        public static Box<IHistogram2dcontourProperty> colorbar(params Box<IColorbarProperty>[] properties) => Interop.mkHistogram2dcontourAttr("colorbar", Bindings.flattenProperties(properties));
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<IHistogram2dcontourProperty> coloraxis(int anchorId) => Interop.mkHistogram2dcontourAttr("coloraxis", anchorId > 1 ? $"coloraxis{anchorId}" : "");
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<IHistogram2dcontourProperty> coloraxis(string val) => Interop.mkHistogram2dcontourAttr("coloraxis", val);
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IHistogram2dcontourProperty> xaxis(int anchorId) => Interop.mkHistogram2dcontourAttr("xaxis", anchorId > 1 ? $"x{anchorId}" : "");
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IHistogram2dcontourProperty> xaxis(string val) => Interop.mkHistogram2dcontourAttr("xaxis", val);
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IHistogram2dcontourProperty> yaxis(int anchorId) => Interop.mkHistogram2dcontourAttr("yaxis", anchorId > 1 ? $"y{anchorId}" : "");
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IHistogram2dcontourProperty> yaxis(string val) => Interop.mkHistogram2dcontourAttr("yaxis", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IHistogram2dcontourProperty> idssrc(string val) => Interop.mkHistogram2dcontourAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IHistogram2dcontourProperty> customdatasrc(string val) => Interop.mkHistogram2dcontourAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IHistogram2dcontourProperty> metasrc(string val) => Interop.mkHistogram2dcontourAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IHistogram2dcontourProperty> hoverinfosrc(string val) => Interop.mkHistogram2dcontourAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  x .
        public static Box<IHistogram2dcontourProperty> xsrc(string val) => Interop.mkHistogram2dcontourAttr("xsrc", val);
        /// Sets the source reference on plot.ly for  y .
        public static Box<IHistogram2dcontourProperty> ysrc(string val) => Interop.mkHistogram2dcontourAttr("ysrc", val);
        /// Sets the source reference on plot.ly for  z .
        public static Box<IHistogram2dcontourProperty> zsrc(string val) => Interop.mkHistogram2dcontourAttr("zsrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IHistogram2dcontourProperty> hovertemplatesrc(string val) => Interop.mkHistogram2dcontourAttr("hovertemplatesrc", val);
    }

    public static partial class Histogram2dcontour
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IHistogram2dcontourProperty> legendonly() => Interop.mkHistogram2dcontourAttr("visible", "legendonly");
            public static Box<IHistogram2dcontourProperty> _false() => Interop.mkHistogram2dcontourAttr("visible", false);
            public static Box<IHistogram2dcontourProperty> _true() => Interop.mkHistogram2dcontourAttr("visible", true);
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IHistogram2dcontourProperty> all() => Interop.mkHistogram2dcontourAttr("hoverinfo", "all");
            public static Box<IHistogram2dcontourProperty> none() => Interop.mkHistogram2dcontourAttr("hoverinfo", "none");
            public static Box<IHistogram2dcontourProperty> skip() => Interop.mkHistogram2dcontourAttr("hoverinfo", "skip");
            public static Box<IHistogram2dcontourProperty> name() => Interop.mkHistogram2dcontourAttr("hoverinfo", "name");
            public static Box<IHistogram2dcontourProperty> text() => Interop.mkHistogram2dcontourAttr("hoverinfo", "text");
            public static Box<IHistogram2dcontourProperty> x() => Interop.mkHistogram2dcontourAttr("hoverinfo", "x");
            public static Box<IHistogram2dcontourProperty> y() => Interop.mkHistogram2dcontourAttr("hoverinfo", "y");
            public static Box<IHistogram2dcontourProperty> z() => Interop.mkHistogram2dcontourAttr("hoverinfo", "z");
        }

        /// Specifies the type of normalization used for this histogram trace. If **, the span of each bar corresponds to the number of occurrences (i.e. the number of data points lying inside the bins). If *percent* / *probability*, the span of each bar corresponds to the percentage / fraction of occurrences with respect to the total number of sample points (here, the sum of all bin HEIGHTS equals 100% / 1). If *density*, the span of each bar corresponds to the number of occurrences in a bin divided by the size of the bin interval (here, the sum of all bin AREAS equals the total number of sample points). If *probability density*, the area of each bar corresponds to the probability that an event will fall into the corresponding bin (here, the sum of all bin AREAS equals 1).
        public static partial class Histnorm
        {
            public static Box<IHistogram2dcontourProperty> none() => Interop.mkHistogram2dcontourAttr("histnorm", "");
            public static Box<IHistogram2dcontourProperty> density() => Interop.mkHistogram2dcontourAttr("histnorm", "density");
            public static Box<IHistogram2dcontourProperty> percent() => Interop.mkHistogram2dcontourAttr("histnorm", "percent");
            public static Box<IHistogram2dcontourProperty> probabilityDensity() => Interop.mkHistogram2dcontourAttr("histnorm", "probability density");
            public static Box<IHistogram2dcontourProperty> probability() => Interop.mkHistogram2dcontourAttr("histnorm", "probability");
        }

        /// Specifies the binning function used for this histogram trace. If *count*, the histogram values are computed by counting the number of values lying inside each bin. If *sum*, *avg*, *min*, *max*, the histogram values are computed using the sum, the average, the minimum or the maximum of the values lying inside each bin respectively.
        public static partial class Histfunc
        {
            public static Box<IHistogram2dcontourProperty> avg() => Interop.mkHistogram2dcontourAttr("histfunc", "avg");
            public static Box<IHistogram2dcontourProperty> count() => Interop.mkHistogram2dcontourAttr("histfunc", "count");
            public static Box<IHistogram2dcontourProperty> max() => Interop.mkHistogram2dcontourAttr("histfunc", "max");
            public static Box<IHistogram2dcontourProperty> min() => Interop.mkHistogram2dcontourAttr("histfunc", "min");
            public static Box<IHistogram2dcontourProperty> sum() => Interop.mkHistogram2dcontourAttr("histfunc", "sum");
        }

        /// Sets the calendar system to use with `x` date data.
        public static partial class Xcalendar
        {
            public static Box<IHistogram2dcontourProperty> chinese() => Interop.mkHistogram2dcontourAttr("xcalendar", "chinese");
            public static Box<IHistogram2dcontourProperty> coptic() => Interop.mkHistogram2dcontourAttr("xcalendar", "coptic");
            public static Box<IHistogram2dcontourProperty> discworld() => Interop.mkHistogram2dcontourAttr("xcalendar", "discworld");
            public static Box<IHistogram2dcontourProperty> ethiopian() => Interop.mkHistogram2dcontourAttr("xcalendar", "ethiopian");
            public static Box<IHistogram2dcontourProperty> gregorian() => Interop.mkHistogram2dcontourAttr("xcalendar", "gregorian");
            public static Box<IHistogram2dcontourProperty> hebrew() => Interop.mkHistogram2dcontourAttr("xcalendar", "hebrew");
            public static Box<IHistogram2dcontourProperty> islamic() => Interop.mkHistogram2dcontourAttr("xcalendar", "islamic");
            public static Box<IHistogram2dcontourProperty> jalali() => Interop.mkHistogram2dcontourAttr("xcalendar", "jalali");
            public static Box<IHistogram2dcontourProperty> julian() => Interop.mkHistogram2dcontourAttr("xcalendar", "julian");
            public static Box<IHistogram2dcontourProperty> mayan() => Interop.mkHistogram2dcontourAttr("xcalendar", "mayan");
            public static Box<IHistogram2dcontourProperty> nanakshahi() => Interop.mkHistogram2dcontourAttr("xcalendar", "nanakshahi");
            public static Box<IHistogram2dcontourProperty> nepali() => Interop.mkHistogram2dcontourAttr("xcalendar", "nepali");
            public static Box<IHistogram2dcontourProperty> persian() => Interop.mkHistogram2dcontourAttr("xcalendar", "persian");
            public static Box<IHistogram2dcontourProperty> taiwan() => Interop.mkHistogram2dcontourAttr("xcalendar", "taiwan");
            public static Box<IHistogram2dcontourProperty> thai() => Interop.mkHistogram2dcontourAttr("xcalendar", "thai");
            public static Box<IHistogram2dcontourProperty> ummalqura() => Interop.mkHistogram2dcontourAttr("xcalendar", "ummalqura");
        }

        /// Sets the calendar system to use with `y` date data.
        public static partial class Ycalendar
        {
            public static Box<IHistogram2dcontourProperty> chinese() => Interop.mkHistogram2dcontourAttr("ycalendar", "chinese");
            public static Box<IHistogram2dcontourProperty> coptic() => Interop.mkHistogram2dcontourAttr("ycalendar", "coptic");
            public static Box<IHistogram2dcontourProperty> discworld() => Interop.mkHistogram2dcontourAttr("ycalendar", "discworld");
            public static Box<IHistogram2dcontourProperty> ethiopian() => Interop.mkHistogram2dcontourAttr("ycalendar", "ethiopian");
            public static Box<IHistogram2dcontourProperty> gregorian() => Interop.mkHistogram2dcontourAttr("ycalendar", "gregorian");
            public static Box<IHistogram2dcontourProperty> hebrew() => Interop.mkHistogram2dcontourAttr("ycalendar", "hebrew");
            public static Box<IHistogram2dcontourProperty> islamic() => Interop.mkHistogram2dcontourAttr("ycalendar", "islamic");
            public static Box<IHistogram2dcontourProperty> jalali() => Interop.mkHistogram2dcontourAttr("ycalendar", "jalali");
            public static Box<IHistogram2dcontourProperty> julian() => Interop.mkHistogram2dcontourAttr("ycalendar", "julian");
            public static Box<IHistogram2dcontourProperty> mayan() => Interop.mkHistogram2dcontourAttr("ycalendar", "mayan");
            public static Box<IHistogram2dcontourProperty> nanakshahi() => Interop.mkHistogram2dcontourAttr("ycalendar", "nanakshahi");
            public static Box<IHistogram2dcontourProperty> nepali() => Interop.mkHistogram2dcontourAttr("ycalendar", "nepali");
            public static Box<IHistogram2dcontourProperty> persian() => Interop.mkHistogram2dcontourAttr("ycalendar", "persian");
            public static Box<IHistogram2dcontourProperty> taiwan() => Interop.mkHistogram2dcontourAttr("ycalendar", "taiwan");
            public static Box<IHistogram2dcontourProperty> thai() => Interop.mkHistogram2dcontourAttr("ycalendar", "thai");
            public static Box<IHistogram2dcontourProperty> ummalqura() => Interop.mkHistogram2dcontourAttr("ycalendar", "ummalqura");
        }
    }
}