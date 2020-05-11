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

    public static partial class Splom
    {
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<ISplomProperty> showlegend(bool val) => Interop.mkSplomAttr("showlegend", val);
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<ISplomProperty> legendgroup(string val) => Interop.mkSplomAttr("legendgroup", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<ISplomProperty> name(string val) => Interop.mkSplomAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<ISplomProperty> uid(string val) => Interop.mkSplomAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISplomProperty> ids(bool val) => Interop.mkSplomAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISplomProperty> ids(params bool[] values) => Interop.mkSplomAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISplomProperty> ids(System.DateTime val) => Interop.mkSplomAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISplomProperty> ids(params System.DateTime[] values) => Interop.mkSplomAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISplomProperty> ids(float val) => Interop.mkSplomAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISplomProperty> ids(params float[] values) => Interop.mkSplomAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISplomProperty> ids(int val) => Interop.mkSplomAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISplomProperty> ids(params int[] values) => Interop.mkSplomAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISplomProperty> ids(string val) => Interop.mkSplomAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISplomProperty> ids(params string[] values) => Interop.mkSplomAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISplomProperty> ids(IEnumerable<bool[]> values) => Interop.mkSplomAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISplomProperty> ids(List<bool[]> values) => Interop.mkSplomAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISplomProperty> ids(params bool[][] values) => Interop.mkSplomAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISplomProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkSplomAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISplomProperty> ids(List<string[]> values) => Interop.mkSplomAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISplomProperty> ids(params string[][] values) => Interop.mkSplomAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISplomProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkSplomAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISplomProperty> ids(List<int[]> values) => Interop.mkSplomAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISplomProperty> ids(params int[][] values) => Interop.mkSplomAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISplomProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkSplomAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISplomProperty> ids(List<float[]> values) => Interop.mkSplomAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISplomProperty> ids(params float[][] values) => Interop.mkSplomAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISplomProperty> ids(Literals.PlotData[] values) => Interop.mkSplomAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISplomProperty> ids(IEnumerable<bool?> values) => Interop.mkSplomAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISplomProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkSplomAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISplomProperty> ids(IEnumerable<int?> values) => Interop.mkSplomAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ISplomProperty> ids(IEnumerable<float?> values) => Interop.mkSplomAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISplomProperty> customdata(bool val) => Interop.mkSplomAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISplomProperty> customdata(params bool[] values) => Interop.mkSplomAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISplomProperty> customdata(System.DateTime val) => Interop.mkSplomAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISplomProperty> customdata(params System.DateTime[] values) => Interop.mkSplomAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISplomProperty> customdata(float val) => Interop.mkSplomAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISplomProperty> customdata(params float[] values) => Interop.mkSplomAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISplomProperty> customdata(int val) => Interop.mkSplomAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISplomProperty> customdata(params int[] values) => Interop.mkSplomAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISplomProperty> customdata(string val) => Interop.mkSplomAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISplomProperty> customdata(params string[] values) => Interop.mkSplomAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISplomProperty> customdata(IEnumerable<bool[]> values) => Interop.mkSplomAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISplomProperty> customdata(List<bool[]> values) => Interop.mkSplomAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISplomProperty> customdata(params bool[][] values) => Interop.mkSplomAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISplomProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkSplomAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISplomProperty> customdata(List<string[]> values) => Interop.mkSplomAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISplomProperty> customdata(params string[][] values) => Interop.mkSplomAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISplomProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkSplomAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISplomProperty> customdata(List<int[]> values) => Interop.mkSplomAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISplomProperty> customdata(params int[][] values) => Interop.mkSplomAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISplomProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkSplomAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISplomProperty> customdata(List<float[]> values) => Interop.mkSplomAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISplomProperty> customdata(params float[][] values) => Interop.mkSplomAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISplomProperty> customdata(Literals.PlotData[] values) => Interop.mkSplomAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISplomProperty> customdata(IEnumerable<bool?> values) => Interop.mkSplomAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISplomProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkSplomAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISplomProperty> customdata(IEnumerable<int?> values) => Interop.mkSplomAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ISplomProperty> customdata(IEnumerable<float?> values) => Interop.mkSplomAttr("customdata", values.ToArray());
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<ISplomProperty> selectedpoints(bool val) => Interop.mkSplomAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<ISplomProperty> selectedpoints(params bool[] values) => Interop.mkSplomAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<ISplomProperty> selectedpoints(System.DateTime val) => Interop.mkSplomAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<ISplomProperty> selectedpoints(params System.DateTime[] values) => Interop.mkSplomAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<ISplomProperty> selectedpoints(int val) => Interop.mkSplomAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<ISplomProperty> selectedpoints(params int[] values) => Interop.mkSplomAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<ISplomProperty> selectedpoints(float val) => Interop.mkSplomAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<ISplomProperty> selectedpoints(params float[] values) => Interop.mkSplomAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<ISplomProperty> selectedpoints(string val) => Interop.mkSplomAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<ISplomProperty> selectedpoints(params string[] values) => Interop.mkSplomAttr("selectedpoints", values);
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<ISplomProperty> hoverinfo(params Box<ISplomProperty>[] properties) => Interop.mkSplomAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        public static Box<ISplomProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkSplomAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<ISplomProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkSplomAttr("stream", Bindings.flattenProperties(properties));
        public static Box<ISplomProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkSplomAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISplomProperty> uirevision(bool val) => Interop.mkSplomAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISplomProperty> uirevision(params bool[] values) => Interop.mkSplomAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISplomProperty> uirevision(System.DateTime val) => Interop.mkSplomAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISplomProperty> uirevision(params System.DateTime[] values) => Interop.mkSplomAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISplomProperty> uirevision(int val) => Interop.mkSplomAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISplomProperty> uirevision(params int[] values) => Interop.mkSplomAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISplomProperty> uirevision(float val) => Interop.mkSplomAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISplomProperty> uirevision(params float[] values) => Interop.mkSplomAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISplomProperty> uirevision(string val) => Interop.mkSplomAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ISplomProperty> uirevision(params string[] values) => Interop.mkSplomAttr("uirevision", values);
        public static Box<ISplomProperty> dimensions(params Box<IDimensionsProperty>[] properties) => Interop.mkSplomAttr("dimensions", Bindings.flattenPropertiesToArray(properties));
        /// Sets text elements associated with each (x,y) pair to appear on hover. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates.
        public static Box<ISplomProperty> text(string val) => Interop.mkSplomAttr("text", val);
        /// Sets text elements associated with each (x,y) pair to appear on hover. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates.
        public static Box<ISplomProperty> text(IEnumerable<string> values) => Interop.mkSplomAttr("text", values.ToArray());
        /// Same as `text`.
        public static Box<ISplomProperty> hovertext(string val) => Interop.mkSplomAttr("hovertext", val);
        /// Same as `text`.
        public static Box<ISplomProperty> hovertext(IEnumerable<string> values) => Interop.mkSplomAttr("hovertext", values.ToArray());
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<ISplomProperty> hovertemplate(string val) => Interop.mkSplomAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<ISplomProperty> hovertemplate(IEnumerable<string> values) => Interop.mkSplomAttr("hovertemplate", values.ToArray());
        public static Box<ISplomProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkSplomAttr("marker", Bindings.flattenProperties(properties));
        /// Sets the list of x axes corresponding to dimensions of this splom trace. By default, a splom will match the first N xaxes where N is the number of input dimensions. Note that, in case where `diagonal.visible` is false and `showupperhalf` or `showlowerhalf` is false, this splom trace will generate one less x-axis and one less y-axis.
        public static Box<ISplomProperty> xaxes(string val) => Interop.mkSplomAttr("xaxes", new[]{val});
        /// Sets the list of x axes corresponding to dimensions of this splom trace. By default, a splom will match the first N xaxes where N is the number of input dimensions. Note that, in case where `diagonal.visible` is false and `showupperhalf` or `showlowerhalf` is false, this splom trace will generate one less x-axis and one less y-axis.
        public static Box<ISplomProperty> xaxes(IEnumerable<string> values) => Interop.mkSplomAttr("xaxes", values.ToArray());
        /// Sets the list of y axes corresponding to dimensions of this splom trace. By default, a splom will match the first N yaxes where N is the number of input dimensions. Note that, in case where `diagonal.visible` is false and `showupperhalf` or `showlowerhalf` is false, this splom trace will generate one less x-axis and one less y-axis.
        public static Box<ISplomProperty> yaxes(string val) => Interop.mkSplomAttr("yaxes", new[]{val});
        /// Sets the list of y axes corresponding to dimensions of this splom trace. By default, a splom will match the first N yaxes where N is the number of input dimensions. Note that, in case where `diagonal.visible` is false and `showupperhalf` or `showlowerhalf` is false, this splom trace will generate one less x-axis and one less y-axis.
        public static Box<ISplomProperty> yaxes(IEnumerable<string> values) => Interop.mkSplomAttr("yaxes", values.ToArray());
        public static Box<ISplomProperty> diagonal(params Box<IDiagonalProperty>[] properties) => Interop.mkSplomAttr("diagonal", Bindings.flattenProperties(properties));
        /// Determines whether or not subplots on the upper half from the diagonal are displayed.
        public static Box<ISplomProperty> showupperhalf(bool val) => Interop.mkSplomAttr("showupperhalf", val);
        /// Determines whether or not subplots on the lower half from the diagonal are displayed.
        public static Box<ISplomProperty> showlowerhalf(bool val) => Interop.mkSplomAttr("showlowerhalf", val);
        public static Box<ISplomProperty> selected(params Box<ISelectedProperty>[] properties) => Interop.mkSplomAttr("selected", Bindings.flattenProperties(properties));
        public static Box<ISplomProperty> unselected(params Box<IUnselectedProperty>[] properties) => Interop.mkSplomAttr("unselected", Bindings.flattenProperties(properties));
        /// Sets the opacity of the trace.
        public static Box<ISplomProperty> opacity(int val) => Interop.mkSplomAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<ISplomProperty> opacity(float val) => Interop.mkSplomAttr("opacity", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<ISplomProperty> idssrc(string val) => Interop.mkSplomAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<ISplomProperty> customdatasrc(string val) => Interop.mkSplomAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<ISplomProperty> metasrc(string val) => Interop.mkSplomAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<ISplomProperty> hoverinfosrc(string val) => Interop.mkSplomAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<ISplomProperty> textsrc(string val) => Interop.mkSplomAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<ISplomProperty> hovertextsrc(string val) => Interop.mkSplomAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<ISplomProperty> hovertemplatesrc(string val) => Interop.mkSplomAttr("hovertemplatesrc", val);
    }

    public static partial class Splom
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<ISplomProperty> legendonly() => Interop.mkSplomAttr("visible", "legendonly");
            public static Box<ISplomProperty> _false() => Interop.mkSplomAttr("visible", false);
            public static Box<ISplomProperty> _true() => Interop.mkSplomAttr("visible", true);
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<ISplomProperty> all() => Interop.mkSplomAttr("hoverinfo", "all");
            public static Box<ISplomProperty> none() => Interop.mkSplomAttr("hoverinfo", "none");
            public static Box<ISplomProperty> skip() => Interop.mkSplomAttr("hoverinfo", "skip");
            public static Box<ISplomProperty> name() => Interop.mkSplomAttr("hoverinfo", "name");
            public static Box<ISplomProperty> text() => Interop.mkSplomAttr("hoverinfo", "text");
            public static Box<ISplomProperty> x() => Interop.mkSplomAttr("hoverinfo", "x");
            public static Box<ISplomProperty> y() => Interop.mkSplomAttr("hoverinfo", "y");
            public static Box<ISplomProperty> z() => Interop.mkSplomAttr("hoverinfo", "z");
        }
    }
}