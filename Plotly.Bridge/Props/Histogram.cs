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

    public static partial class Histogram
    {
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IHistogramProperty> showlegend(bool val) => Interop.mkHistogramAttr("showlegend", val);
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IHistogramProperty> legendgroup(string val) => Interop.mkHistogramAttr("legendgroup", val);
        /// Sets the opacity of the trace.
        public static Box<IHistogramProperty> opacity(int val) => Interop.mkHistogramAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<IHistogramProperty> opacity(float val) => Interop.mkHistogramAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IHistogramProperty> name(string val) => Interop.mkHistogramAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IHistogramProperty> uid(string val) => Interop.mkHistogramAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogramProperty> ids(bool val) => Interop.mkHistogramAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogramProperty> ids(params bool[] values) => Interop.mkHistogramAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogramProperty> ids(System.DateTime val) => Interop.mkHistogramAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogramProperty> ids(params System.DateTime[] values) => Interop.mkHistogramAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogramProperty> ids(float val) => Interop.mkHistogramAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogramProperty> ids(params float[] values) => Interop.mkHistogramAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogramProperty> ids(int val) => Interop.mkHistogramAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogramProperty> ids(params int[] values) => Interop.mkHistogramAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogramProperty> ids(string val) => Interop.mkHistogramAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogramProperty> ids(params string[] values) => Interop.mkHistogramAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogramProperty> ids(IEnumerable<bool[]> values) => Interop.mkHistogramAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogramProperty> ids(List<bool[]> values) => Interop.mkHistogramAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogramProperty> ids(params bool[][] values) => Interop.mkHistogramAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogramProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkHistogramAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogramProperty> ids(List<string[]> values) => Interop.mkHistogramAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogramProperty> ids(params string[][] values) => Interop.mkHistogramAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogramProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkHistogramAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogramProperty> ids(List<int[]> values) => Interop.mkHistogramAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogramProperty> ids(params int[][] values) => Interop.mkHistogramAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogramProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkHistogramAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogramProperty> ids(List<float[]> values) => Interop.mkHistogramAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogramProperty> ids(params float[][] values) => Interop.mkHistogramAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogramProperty> ids(Literals.PlotData[] values) => Interop.mkHistogramAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogramProperty> ids(IEnumerable<bool?> values) => Interop.mkHistogramAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogramProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkHistogramAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogramProperty> ids(IEnumerable<int?> values) => Interop.mkHistogramAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IHistogramProperty> ids(IEnumerable<float?> values) => Interop.mkHistogramAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogramProperty> customdata(bool val) => Interop.mkHistogramAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogramProperty> customdata(params bool[] values) => Interop.mkHistogramAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogramProperty> customdata(System.DateTime val) => Interop.mkHistogramAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogramProperty> customdata(params System.DateTime[] values) => Interop.mkHistogramAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogramProperty> customdata(float val) => Interop.mkHistogramAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogramProperty> customdata(params float[] values) => Interop.mkHistogramAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogramProperty> customdata(int val) => Interop.mkHistogramAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogramProperty> customdata(params int[] values) => Interop.mkHistogramAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogramProperty> customdata(string val) => Interop.mkHistogramAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogramProperty> customdata(params string[] values) => Interop.mkHistogramAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogramProperty> customdata(IEnumerable<bool[]> values) => Interop.mkHistogramAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogramProperty> customdata(List<bool[]> values) => Interop.mkHistogramAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogramProperty> customdata(params bool[][] values) => Interop.mkHistogramAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogramProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkHistogramAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogramProperty> customdata(List<string[]> values) => Interop.mkHistogramAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogramProperty> customdata(params string[][] values) => Interop.mkHistogramAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogramProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkHistogramAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogramProperty> customdata(List<int[]> values) => Interop.mkHistogramAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogramProperty> customdata(params int[][] values) => Interop.mkHistogramAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogramProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkHistogramAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogramProperty> customdata(List<float[]> values) => Interop.mkHistogramAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogramProperty> customdata(params float[][] values) => Interop.mkHistogramAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogramProperty> customdata(Literals.PlotData[] values) => Interop.mkHistogramAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogramProperty> customdata(IEnumerable<bool?> values) => Interop.mkHistogramAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogramProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkHistogramAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogramProperty> customdata(IEnumerable<int?> values) => Interop.mkHistogramAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IHistogramProperty> customdata(IEnumerable<float?> values) => Interop.mkHistogramAttr("customdata", values.ToArray());
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IHistogramProperty> selectedpoints(bool val) => Interop.mkHistogramAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IHistogramProperty> selectedpoints(params bool[] values) => Interop.mkHistogramAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IHistogramProperty> selectedpoints(System.DateTime val) => Interop.mkHistogramAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IHistogramProperty> selectedpoints(params System.DateTime[] values) => Interop.mkHistogramAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IHistogramProperty> selectedpoints(int val) => Interop.mkHistogramAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IHistogramProperty> selectedpoints(params int[] values) => Interop.mkHistogramAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IHistogramProperty> selectedpoints(float val) => Interop.mkHistogramAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IHistogramProperty> selectedpoints(params float[] values) => Interop.mkHistogramAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IHistogramProperty> selectedpoints(string val) => Interop.mkHistogramAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IHistogramProperty> selectedpoints(params string[] values) => Interop.mkHistogramAttr("selectedpoints", values);
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IHistogramProperty> hoverinfo(params Box<IHistogramProperty>[] properties) => Interop.mkHistogramAttr("hoverinfo", Script.Write<object>("{0}.join('+')", properties));
        public static Box<IHistogramProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkHistogramAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IHistogramProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkHistogramAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IHistogramProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkHistogramAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogramProperty> uirevision(bool val) => Interop.mkHistogramAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogramProperty> uirevision(params bool[] values) => Interop.mkHistogramAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogramProperty> uirevision(System.DateTime val) => Interop.mkHistogramAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogramProperty> uirevision(params System.DateTime[] values) => Interop.mkHistogramAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogramProperty> uirevision(int val) => Interop.mkHistogramAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogramProperty> uirevision(params int[] values) => Interop.mkHistogramAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogramProperty> uirevision(float val) => Interop.mkHistogramAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogramProperty> uirevision(params float[] values) => Interop.mkHistogramAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogramProperty> uirevision(string val) => Interop.mkHistogramAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IHistogramProperty> uirevision(params string[] values) => Interop.mkHistogramAttr("uirevision", values);
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogramProperty> x(bool val) => Interop.mkHistogramAttr("x", new[]{val});
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogramProperty> x(IEnumerable<bool> values) => Interop.mkHistogramAttr("x", values.ToArray());
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogramProperty> x(System.DateTime val) => Interop.mkHistogramAttr("x", new[]{val});
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogramProperty> x(IEnumerable<System.DateTime> values) => Interop.mkHistogramAttr("x", values.ToArray());
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogramProperty> x(float val) => Interop.mkHistogramAttr("x", new[]{val});
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogramProperty> x(IEnumerable<float> values) => Interop.mkHistogramAttr("x", values.ToArray());
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogramProperty> x(int val) => Interop.mkHistogramAttr("x", new[]{val});
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogramProperty> x(IEnumerable<int> values) => Interop.mkHistogramAttr("x", values.ToArray());
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogramProperty> x(string val) => Interop.mkHistogramAttr("x", new[]{val});
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogramProperty> x(IEnumerable<string> values) => Interop.mkHistogramAttr("x", values.ToArray());
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogramProperty> x(IEnumerable<bool[]> values) => Interop.mkHistogramAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogramProperty> x(List<bool[]> values) => Interop.mkHistogramAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogramProperty> x(params bool[][] values) => Interop.mkHistogramAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogramProperty> x(IEnumerable<IEnumerable<string>> values) => Interop.mkHistogramAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogramProperty> x(List<string[]> values) => Interop.mkHistogramAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogramProperty> x(params string[][] values) => Interop.mkHistogramAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogramProperty> x(IEnumerable<IEnumerable<int>> values) => Interop.mkHistogramAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogramProperty> x(List<int[]> values) => Interop.mkHistogramAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogramProperty> x(params int[][] values) => Interop.mkHistogramAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogramProperty> x(IEnumerable<IEnumerable<float>> values) => Interop.mkHistogramAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogramProperty> x(List<float[]> values) => Interop.mkHistogramAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogramProperty> x(params float[][] values) => Interop.mkHistogramAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogramProperty> x(Literals.PlotData[] values) => Interop.mkHistogramAttr("x", values);
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogramProperty> x(IEnumerable<bool?> values) => Interop.mkHistogramAttr("x", values.ToArray());
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogramProperty> x(IEnumerable<System.DateTime?> values) => Interop.mkHistogramAttr("x", values.ToArray());
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogramProperty> x(IEnumerable<int?> values) => Interop.mkHistogramAttr("x", values.ToArray());
        /// Sets the sample data to be binned on the x axis.
        public static Box<IHistogramProperty> x(IEnumerable<float?> values) => Interop.mkHistogramAttr("x", values.ToArray());
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogramProperty> y(bool val) => Interop.mkHistogramAttr("y", new[]{val});
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogramProperty> y(IEnumerable<bool> values) => Interop.mkHistogramAttr("y", values.ToArray());
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogramProperty> y(System.DateTime val) => Interop.mkHistogramAttr("y", new[]{val});
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogramProperty> y(IEnumerable<System.DateTime> values) => Interop.mkHistogramAttr("y", values.ToArray());
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogramProperty> y(float val) => Interop.mkHistogramAttr("y", new[]{val});
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogramProperty> y(IEnumerable<float> values) => Interop.mkHistogramAttr("y", values.ToArray());
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogramProperty> y(int val) => Interop.mkHistogramAttr("y", new[]{val});
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogramProperty> y(IEnumerable<int> values) => Interop.mkHistogramAttr("y", values.ToArray());
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogramProperty> y(string val) => Interop.mkHistogramAttr("y", new[]{val});
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogramProperty> y(IEnumerable<string> values) => Interop.mkHistogramAttr("y", values.ToArray());
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogramProperty> y(IEnumerable<bool[]> values) => Interop.mkHistogramAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogramProperty> y(List<bool[]> values) => Interop.mkHistogramAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogramProperty> y(params bool[][] values) => Interop.mkHistogramAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogramProperty> y(IEnumerable<IEnumerable<string>> values) => Interop.mkHistogramAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogramProperty> y(List<string[]> values) => Interop.mkHistogramAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogramProperty> y(params string[][] values) => Interop.mkHistogramAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogramProperty> y(IEnumerable<IEnumerable<int>> values) => Interop.mkHistogramAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogramProperty> y(List<int[]> values) => Interop.mkHistogramAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogramProperty> y(params int[][] values) => Interop.mkHistogramAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogramProperty> y(IEnumerable<IEnumerable<float>> values) => Interop.mkHistogramAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogramProperty> y(List<float[]> values) => Interop.mkHistogramAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogramProperty> y(params float[][] values) => Interop.mkHistogramAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogramProperty> y(Literals.PlotData[] values) => Interop.mkHistogramAttr("y", values);
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogramProperty> y(IEnumerable<bool?> values) => Interop.mkHistogramAttr("y", values.ToArray());
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogramProperty> y(IEnumerable<System.DateTime?> values) => Interop.mkHistogramAttr("y", values.ToArray());
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogramProperty> y(IEnumerable<int?> values) => Interop.mkHistogramAttr("y", values.ToArray());
        /// Sets the sample data to be binned on the y axis.
        public static Box<IHistogramProperty> y(IEnumerable<float?> values) => Interop.mkHistogramAttr("y", values.ToArray());
        /// Sets hover text elements associated with each bar. If a single string, the same string appears over all bars. If an array of string, the items are mapped in order to the this trace's coordinates.
        public static Box<IHistogramProperty> text(string val) => Interop.mkHistogramAttr("text", val);
        /// Sets hover text elements associated with each bar. If a single string, the same string appears over all bars. If an array of string, the items are mapped in order to the this trace's coordinates.
        public static Box<IHistogramProperty> text(IEnumerable<string> values) => Interop.mkHistogramAttr("text", values.ToArray());
        /// Same as `text`.
        public static Box<IHistogramProperty> hovertext(string val) => Interop.mkHistogramAttr("hovertext", val);
        /// Same as `text`.
        public static Box<IHistogramProperty> hovertext(IEnumerable<string> values) => Interop.mkHistogramAttr("hovertext", values.ToArray());
        public static Box<IHistogramProperty> cumulative(params Box<ICumulativeProperty>[] properties) => Interop.mkHistogramAttr("cumulative", Bindings.flattenProperties(properties));
        /// Specifies the maximum number of desired bins. This value will be used in an algorithm that will decide the optimal bin size such that the histogram best visualizes the distribution of the data. Ignored if `xbins.size` is provided.
        public static Box<IHistogramProperty> nbinsx(int val) => Interop.mkHistogramAttr("nbinsx", val);
        public static Box<IHistogramProperty> xbins(params Box<IXbinsProperty>[] properties) => Interop.mkHistogramAttr("xbins", Bindings.flattenProperties(properties));
        /// Specifies the maximum number of desired bins. This value will be used in an algorithm that will decide the optimal bin size such that the histogram best visualizes the distribution of the data. Ignored if `ybins.size` is provided.
        public static Box<IHistogramProperty> nbinsy(int val) => Interop.mkHistogramAttr("nbinsy", val);
        public static Box<IHistogramProperty> ybins(params Box<IYbinsProperty>[] properties) => Interop.mkHistogramAttr("ybins", Bindings.flattenProperties(properties));
        /// Obsolete: since v1.42 each bin attribute is auto-determined separately and `autobinx` is not needed. However, we accept `autobinx: true` or `false` and will update `xbins` accordingly before deleting `autobinx` from the trace.
        public static Box<IHistogramProperty> autobinx(bool val) => Interop.mkHistogramAttr("autobinx", val);
        /// Obsolete: since v1.42 each bin attribute is auto-determined separately and `autobiny` is not needed. However, we accept `autobiny: true` or `false` and will update `ybins` accordingly before deleting `autobiny` from the trace.
        public static Box<IHistogramProperty> autobiny(bool val) => Interop.mkHistogramAttr("autobiny", val);
        /// Set a group of histogram traces which will have compatible bin settings. Note that traces on the same subplot and with the same *orientation* under `barmode` *stack*, *relative* and *group* are forced into the same bingroup, Using `bingroup`, traces under `barmode` *overlay* and on different axes (of the same axis type) can have compatible bin settings. Note that histogram and histogram2d* trace can share the same `bingroup`
        public static Box<IHistogramProperty> bingroup(string val) => Interop.mkHistogramAttr("bingroup", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variable `binNumber` Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IHistogramProperty> hovertemplate(string val) => Interop.mkHistogramAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variable `binNumber` Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IHistogramProperty> hovertemplate(IEnumerable<string> values) => Interop.mkHistogramAttr("hovertemplate", values.ToArray());
        public static Box<IHistogramProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkHistogramAttr("marker", Bindings.flattenProperties(properties));
        /// Set several traces linked to the same position axis or matching axes to the same offsetgroup where bars of the same position coordinate will line up.
        public static Box<IHistogramProperty> offsetgroup(string val) => Interop.mkHistogramAttr("offsetgroup", val);
        /// Set several traces linked to the same position axis or matching axes to the same alignmentgroup. This controls whether bars compute their positional range dependently or independently.
        public static Box<IHistogramProperty> alignmentgroup(string val) => Interop.mkHistogramAttr("alignmentgroup", val);
        public static Box<IHistogramProperty> selected(params Box<ISelectedProperty>[] properties) => Interop.mkHistogramAttr("selected", Bindings.flattenProperties(properties));
        public static Box<IHistogramProperty> unselected(params Box<IUnselectedProperty>[] properties) => Interop.mkHistogramAttr("unselected", Bindings.flattenProperties(properties));
        public static Box<IHistogramProperty> errorX(params Box<IErrorXProperty>[] properties) => Interop.mkHistogramAttr("error_x", Bindings.flattenProperties(properties));
        public static Box<IHistogramProperty> errorY(params Box<IErrorYProperty>[] properties) => Interop.mkHistogramAttr("error_y", Bindings.flattenProperties(properties));
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IHistogramProperty> xaxis(int anchorId) => Interop.mkHistogramAttr("xaxis", anchorId > 1 ? $"x{anchorId}" : "");
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IHistogramProperty> xaxis(string val) => Interop.mkHistogramAttr("xaxis", val);
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IHistogramProperty> yaxis(int anchorId) => Interop.mkHistogramAttr("yaxis", anchorId > 1 ? $"y{anchorId}" : "");
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IHistogramProperty> yaxis(string val) => Interop.mkHistogramAttr("yaxis", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IHistogramProperty> idssrc(string val) => Interop.mkHistogramAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IHistogramProperty> customdatasrc(string val) => Interop.mkHistogramAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IHistogramProperty> metasrc(string val) => Interop.mkHistogramAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IHistogramProperty> hoverinfosrc(string val) => Interop.mkHistogramAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  x .
        public static Box<IHistogramProperty> xsrc(string val) => Interop.mkHistogramAttr("xsrc", val);
        /// Sets the source reference on plot.ly for  y .
        public static Box<IHistogramProperty> ysrc(string val) => Interop.mkHistogramAttr("ysrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IHistogramProperty> textsrc(string val) => Interop.mkHistogramAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IHistogramProperty> hovertextsrc(string val) => Interop.mkHistogramAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IHistogramProperty> hovertemplatesrc(string val) => Interop.mkHistogramAttr("hovertemplatesrc", val);
    }

    public static partial class Histogram
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IHistogramProperty> legendonly() => Interop.mkHistogramAttr("visible", "legendonly");
            public static Box<IHistogramProperty> _false() => Interop.mkHistogramAttr("visible", false);
            public static Box<IHistogramProperty> _true() => Interop.mkHistogramAttr("visible", true);
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IHistogramProperty> all() => Interop.mkHistogramAttr("hoverinfo", "all");
            public static Box<IHistogramProperty> none() => Interop.mkHistogramAttr("hoverinfo", "none");
            public static Box<IHistogramProperty> skip() => Interop.mkHistogramAttr("hoverinfo", "skip");
            public static Box<IHistogramProperty> name() => Interop.mkHistogramAttr("hoverinfo", "name");
            public static Box<IHistogramProperty> text() => Interop.mkHistogramAttr("hoverinfo", "text");
            public static Box<IHistogramProperty> x() => Interop.mkHistogramAttr("hoverinfo", "x");
            public static Box<IHistogramProperty> y() => Interop.mkHistogramAttr("hoverinfo", "y");
            public static Box<IHistogramProperty> z() => Interop.mkHistogramAttr("hoverinfo", "z");
        }

        /// Sets the orientation of the bars. With *v* (*h*), the value of the each bar spans along the vertical (horizontal).
        public static partial class Orientation
        {
            public static Box<IHistogramProperty> h() => Interop.mkHistogramAttr("orientation", "h");
            public static Box<IHistogramProperty> v() => Interop.mkHistogramAttr("orientation", "v");
        }

        /// Specifies the binning function used for this histogram trace. If *count*, the histogram values are computed by counting the number of values lying inside each bin. If *sum*, *avg*, *min*, *max*, the histogram values are computed using the sum, the average, the minimum or the maximum of the values lying inside each bin respectively.
        public static partial class Histfunc
        {
            public static Box<IHistogramProperty> avg() => Interop.mkHistogramAttr("histfunc", "avg");
            public static Box<IHistogramProperty> count() => Interop.mkHistogramAttr("histfunc", "count");
            public static Box<IHistogramProperty> max() => Interop.mkHistogramAttr("histfunc", "max");
            public static Box<IHistogramProperty> min() => Interop.mkHistogramAttr("histfunc", "min");
            public static Box<IHistogramProperty> sum() => Interop.mkHistogramAttr("histfunc", "sum");
        }

        /// Specifies the type of normalization used for this histogram trace. If **, the span of each bar corresponds to the number of occurrences (i.e. the number of data points lying inside the bins). If *percent* / *probability*, the span of each bar corresponds to the percentage / fraction of occurrences with respect to the total number of sample points (here, the sum of all bin HEIGHTS equals 100% / 1). If *density*, the span of each bar corresponds to the number of occurrences in a bin divided by the size of the bin interval (here, the sum of all bin AREAS equals the total number of sample points). If *probability density*, the area of each bar corresponds to the probability that an event will fall into the corresponding bin (here, the sum of all bin AREAS equals 1).
        public static partial class Histnorm
        {
            public static Box<IHistogramProperty> none() => Interop.mkHistogramAttr("histnorm", "");
            public static Box<IHistogramProperty> density() => Interop.mkHistogramAttr("histnorm", "density");
            public static Box<IHistogramProperty> percent() => Interop.mkHistogramAttr("histnorm", "percent");
            public static Box<IHistogramProperty> probabilityDensity() => Interop.mkHistogramAttr("histnorm", "probability density");
            public static Box<IHistogramProperty> probability() => Interop.mkHistogramAttr("histnorm", "probability");
        }

        /// Sets the calendar system to use with `x` date data.
        public static partial class Xcalendar
        {
            public static Box<IHistogramProperty> chinese() => Interop.mkHistogramAttr("xcalendar", "chinese");
            public static Box<IHistogramProperty> coptic() => Interop.mkHistogramAttr("xcalendar", "coptic");
            public static Box<IHistogramProperty> discworld() => Interop.mkHistogramAttr("xcalendar", "discworld");
            public static Box<IHistogramProperty> ethiopian() => Interop.mkHistogramAttr("xcalendar", "ethiopian");
            public static Box<IHistogramProperty> gregorian() => Interop.mkHistogramAttr("xcalendar", "gregorian");
            public static Box<IHistogramProperty> hebrew() => Interop.mkHistogramAttr("xcalendar", "hebrew");
            public static Box<IHistogramProperty> islamic() => Interop.mkHistogramAttr("xcalendar", "islamic");
            public static Box<IHistogramProperty> jalali() => Interop.mkHistogramAttr("xcalendar", "jalali");
            public static Box<IHistogramProperty> julian() => Interop.mkHistogramAttr("xcalendar", "julian");
            public static Box<IHistogramProperty> mayan() => Interop.mkHistogramAttr("xcalendar", "mayan");
            public static Box<IHistogramProperty> nanakshahi() => Interop.mkHistogramAttr("xcalendar", "nanakshahi");
            public static Box<IHistogramProperty> nepali() => Interop.mkHistogramAttr("xcalendar", "nepali");
            public static Box<IHistogramProperty> persian() => Interop.mkHistogramAttr("xcalendar", "persian");
            public static Box<IHistogramProperty> taiwan() => Interop.mkHistogramAttr("xcalendar", "taiwan");
            public static Box<IHistogramProperty> thai() => Interop.mkHistogramAttr("xcalendar", "thai");
            public static Box<IHistogramProperty> ummalqura() => Interop.mkHistogramAttr("xcalendar", "ummalqura");
        }

        /// Sets the calendar system to use with `y` date data.
        public static partial class Ycalendar
        {
            public static Box<IHistogramProperty> chinese() => Interop.mkHistogramAttr("ycalendar", "chinese");
            public static Box<IHistogramProperty> coptic() => Interop.mkHistogramAttr("ycalendar", "coptic");
            public static Box<IHistogramProperty> discworld() => Interop.mkHistogramAttr("ycalendar", "discworld");
            public static Box<IHistogramProperty> ethiopian() => Interop.mkHistogramAttr("ycalendar", "ethiopian");
            public static Box<IHistogramProperty> gregorian() => Interop.mkHistogramAttr("ycalendar", "gregorian");
            public static Box<IHistogramProperty> hebrew() => Interop.mkHistogramAttr("ycalendar", "hebrew");
            public static Box<IHistogramProperty> islamic() => Interop.mkHistogramAttr("ycalendar", "islamic");
            public static Box<IHistogramProperty> jalali() => Interop.mkHistogramAttr("ycalendar", "jalali");
            public static Box<IHistogramProperty> julian() => Interop.mkHistogramAttr("ycalendar", "julian");
            public static Box<IHistogramProperty> mayan() => Interop.mkHistogramAttr("ycalendar", "mayan");
            public static Box<IHistogramProperty> nanakshahi() => Interop.mkHistogramAttr("ycalendar", "nanakshahi");
            public static Box<IHistogramProperty> nepali() => Interop.mkHistogramAttr("ycalendar", "nepali");
            public static Box<IHistogramProperty> persian() => Interop.mkHistogramAttr("ycalendar", "persian");
            public static Box<IHistogramProperty> taiwan() => Interop.mkHistogramAttr("ycalendar", "taiwan");
            public static Box<IHistogramProperty> thai() => Interop.mkHistogramAttr("ycalendar", "thai");
            public static Box<IHistogramProperty> ummalqura() => Interop.mkHistogramAttr("ycalendar", "ummalqura");
        }
    }
}