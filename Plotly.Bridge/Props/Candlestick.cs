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

    public static partial class Candlestick
    {
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<ICandlestickProperty> showlegend(bool val) => Interop.mkCandlestickAttr("showlegend", val);
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<ICandlestickProperty> legendgroup(string val) => Interop.mkCandlestickAttr("legendgroup", val);
        /// Sets the opacity of the trace.
        public static Box<ICandlestickProperty> opacity(int val) => Interop.mkCandlestickAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<ICandlestickProperty> opacity(float val) => Interop.mkCandlestickAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<ICandlestickProperty> name(string val) => Interop.mkCandlestickAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<ICandlestickProperty> uid(string val) => Interop.mkCandlestickAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICandlestickProperty> ids(bool val) => Interop.mkCandlestickAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICandlestickProperty> ids(params bool[] values) => Interop.mkCandlestickAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICandlestickProperty> ids(System.DateTime val) => Interop.mkCandlestickAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICandlestickProperty> ids(params System.DateTime[] values) => Interop.mkCandlestickAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICandlestickProperty> ids(float val) => Interop.mkCandlestickAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICandlestickProperty> ids(params float[] values) => Interop.mkCandlestickAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICandlestickProperty> ids(int val) => Interop.mkCandlestickAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICandlestickProperty> ids(params int[] values) => Interop.mkCandlestickAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICandlestickProperty> ids(string val) => Interop.mkCandlestickAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICandlestickProperty> ids(params string[] values) => Interop.mkCandlestickAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICandlestickProperty> ids(IEnumerable<bool[]> values) => Interop.mkCandlestickAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICandlestickProperty> ids(List<bool[]> values) => Interop.mkCandlestickAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICandlestickProperty> ids(params bool[][] values) => Interop.mkCandlestickAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICandlestickProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkCandlestickAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICandlestickProperty> ids(List<string[]> values) => Interop.mkCandlestickAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICandlestickProperty> ids(params string[][] values) => Interop.mkCandlestickAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICandlestickProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkCandlestickAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICandlestickProperty> ids(List<int[]> values) => Interop.mkCandlestickAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICandlestickProperty> ids(params int[][] values) => Interop.mkCandlestickAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICandlestickProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkCandlestickAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICandlestickProperty> ids(List<float[]> values) => Interop.mkCandlestickAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICandlestickProperty> ids(params float[][] values) => Interop.mkCandlestickAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICandlestickProperty> ids(Literals.PlotData[] values) => Interop.mkCandlestickAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICandlestickProperty> ids(IEnumerable<bool?> values) => Interop.mkCandlestickAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICandlestickProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkCandlestickAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICandlestickProperty> ids(IEnumerable<int?> values) => Interop.mkCandlestickAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<ICandlestickProperty> ids(IEnumerable<float?> values) => Interop.mkCandlestickAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICandlestickProperty> customdata(bool val) => Interop.mkCandlestickAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICandlestickProperty> customdata(params bool[] values) => Interop.mkCandlestickAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICandlestickProperty> customdata(System.DateTime val) => Interop.mkCandlestickAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICandlestickProperty> customdata(params System.DateTime[] values) => Interop.mkCandlestickAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICandlestickProperty> customdata(float val) => Interop.mkCandlestickAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICandlestickProperty> customdata(params float[] values) => Interop.mkCandlestickAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICandlestickProperty> customdata(int val) => Interop.mkCandlestickAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICandlestickProperty> customdata(params int[] values) => Interop.mkCandlestickAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICandlestickProperty> customdata(string val) => Interop.mkCandlestickAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICandlestickProperty> customdata(params string[] values) => Interop.mkCandlestickAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICandlestickProperty> customdata(IEnumerable<bool[]> values) => Interop.mkCandlestickAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICandlestickProperty> customdata(List<bool[]> values) => Interop.mkCandlestickAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICandlestickProperty> customdata(params bool[][] values) => Interop.mkCandlestickAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICandlestickProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkCandlestickAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICandlestickProperty> customdata(List<string[]> values) => Interop.mkCandlestickAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICandlestickProperty> customdata(params string[][] values) => Interop.mkCandlestickAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICandlestickProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkCandlestickAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICandlestickProperty> customdata(List<int[]> values) => Interop.mkCandlestickAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICandlestickProperty> customdata(params int[][] values) => Interop.mkCandlestickAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICandlestickProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkCandlestickAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICandlestickProperty> customdata(List<float[]> values) => Interop.mkCandlestickAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICandlestickProperty> customdata(params float[][] values) => Interop.mkCandlestickAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICandlestickProperty> customdata(Literals.PlotData[] values) => Interop.mkCandlestickAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICandlestickProperty> customdata(IEnumerable<bool?> values) => Interop.mkCandlestickAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICandlestickProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkCandlestickAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICandlestickProperty> customdata(IEnumerable<int?> values) => Interop.mkCandlestickAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<ICandlestickProperty> customdata(IEnumerable<float?> values) => Interop.mkCandlestickAttr("customdata", values.ToArray());
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<ICandlestickProperty> selectedpoints(bool val) => Interop.mkCandlestickAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<ICandlestickProperty> selectedpoints(params bool[] values) => Interop.mkCandlestickAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<ICandlestickProperty> selectedpoints(System.DateTime val) => Interop.mkCandlestickAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<ICandlestickProperty> selectedpoints(params System.DateTime[] values) => Interop.mkCandlestickAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<ICandlestickProperty> selectedpoints(int val) => Interop.mkCandlestickAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<ICandlestickProperty> selectedpoints(params int[] values) => Interop.mkCandlestickAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<ICandlestickProperty> selectedpoints(float val) => Interop.mkCandlestickAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<ICandlestickProperty> selectedpoints(params float[] values) => Interop.mkCandlestickAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<ICandlestickProperty> selectedpoints(string val) => Interop.mkCandlestickAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<ICandlestickProperty> selectedpoints(params string[] values) => Interop.mkCandlestickAttr("selectedpoints", values);
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<ICandlestickProperty> hoverinfo(params Box<ICandlestickProperty>[] properties) => Interop.mkCandlestickAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        public static Box<ICandlestickProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkCandlestickAttr("stream", Bindings.flattenProperties(properties));
        public static Box<ICandlestickProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkCandlestickAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ICandlestickProperty> uirevision(bool val) => Interop.mkCandlestickAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ICandlestickProperty> uirevision(params bool[] values) => Interop.mkCandlestickAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ICandlestickProperty> uirevision(System.DateTime val) => Interop.mkCandlestickAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ICandlestickProperty> uirevision(params System.DateTime[] values) => Interop.mkCandlestickAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ICandlestickProperty> uirevision(int val) => Interop.mkCandlestickAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ICandlestickProperty> uirevision(params int[] values) => Interop.mkCandlestickAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ICandlestickProperty> uirevision(float val) => Interop.mkCandlestickAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ICandlestickProperty> uirevision(params float[] values) => Interop.mkCandlestickAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ICandlestickProperty> uirevision(string val) => Interop.mkCandlestickAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<ICandlestickProperty> uirevision(params string[] values) => Interop.mkCandlestickAttr("uirevision", values);
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<ICandlestickProperty> x(bool val) => Interop.mkCandlestickAttr("x", new[]{val});
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<ICandlestickProperty> x(IEnumerable<bool> values) => Interop.mkCandlestickAttr("x", values.ToArray());
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<ICandlestickProperty> x(System.DateTime val) => Interop.mkCandlestickAttr("x", new[]{val});
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<ICandlestickProperty> x(IEnumerable<System.DateTime> values) => Interop.mkCandlestickAttr("x", values.ToArray());
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<ICandlestickProperty> x(float val) => Interop.mkCandlestickAttr("x", new[]{val});
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<ICandlestickProperty> x(IEnumerable<float> values) => Interop.mkCandlestickAttr("x", values.ToArray());
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<ICandlestickProperty> x(int val) => Interop.mkCandlestickAttr("x", new[]{val});
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<ICandlestickProperty> x(IEnumerable<int> values) => Interop.mkCandlestickAttr("x", values.ToArray());
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<ICandlestickProperty> x(string val) => Interop.mkCandlestickAttr("x", new[]{val});
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<ICandlestickProperty> x(IEnumerable<string> values) => Interop.mkCandlestickAttr("x", values.ToArray());
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<ICandlestickProperty> x(IEnumerable<bool[]> values) => Interop.mkCandlestickAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<ICandlestickProperty> x(List<bool[]> values) => Interop.mkCandlestickAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<ICandlestickProperty> x(params bool[][] values) => Interop.mkCandlestickAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<ICandlestickProperty> x(IEnumerable<IEnumerable<string>> values) => Interop.mkCandlestickAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<ICandlestickProperty> x(List<string[]> values) => Interop.mkCandlestickAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<ICandlestickProperty> x(params string[][] values) => Interop.mkCandlestickAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<ICandlestickProperty> x(IEnumerable<IEnumerable<int>> values) => Interop.mkCandlestickAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<ICandlestickProperty> x(List<int[]> values) => Interop.mkCandlestickAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<ICandlestickProperty> x(params int[][] values) => Interop.mkCandlestickAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<ICandlestickProperty> x(IEnumerable<IEnumerable<float>> values) => Interop.mkCandlestickAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<ICandlestickProperty> x(List<float[]> values) => Interop.mkCandlestickAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<ICandlestickProperty> x(params float[][] values) => Interop.mkCandlestickAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<ICandlestickProperty> x(Literals.PlotData[] values) => Interop.mkCandlestickAttr("x", values);
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<ICandlestickProperty> x(IEnumerable<bool?> values) => Interop.mkCandlestickAttr("x", values.ToArray());
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<ICandlestickProperty> x(IEnumerable<System.DateTime?> values) => Interop.mkCandlestickAttr("x", values.ToArray());
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<ICandlestickProperty> x(IEnumerable<int?> values) => Interop.mkCandlestickAttr("x", values.ToArray());
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<ICandlestickProperty> x(IEnumerable<float?> values) => Interop.mkCandlestickAttr("x", values.ToArray());
        /// Sets the open values.
        public static Box<ICandlestickProperty> _open(bool val) => Interop.mkCandlestickAttr("open", new[]{val});
        /// Sets the open values.
        public static Box<ICandlestickProperty> _open(params bool[] values) => Interop.mkCandlestickAttr("open", values);
        /// Sets the open values.
        public static Box<ICandlestickProperty> _open(System.DateTime val) => Interop.mkCandlestickAttr("open", new[]{val});
        /// Sets the open values.
        public static Box<ICandlestickProperty> _open(params System.DateTime[] values) => Interop.mkCandlestickAttr("open", values);
        /// Sets the open values.
        public static Box<ICandlestickProperty> _open(float val) => Interop.mkCandlestickAttr("open", new[]{val});
        /// Sets the open values.
        public static Box<ICandlestickProperty> _open(params float[] values) => Interop.mkCandlestickAttr("open", values);
        /// Sets the open values.
        public static Box<ICandlestickProperty> _open(int val) => Interop.mkCandlestickAttr("open", new[]{val});
        /// Sets the open values.
        public static Box<ICandlestickProperty> _open(params int[] values) => Interop.mkCandlestickAttr("open", values);
        /// Sets the open values.
        public static Box<ICandlestickProperty> _open(string val) => Interop.mkCandlestickAttr("open", new[]{val});
        /// Sets the open values.
        public static Box<ICandlestickProperty> _open(params string[] values) => Interop.mkCandlestickAttr("open", values);
        /// Sets the open values.
        public static Box<ICandlestickProperty> _open(IEnumerable<bool[]> values) => Interop.mkCandlestickAttr("open", Bindings.flatten2DArrayIf1D(values));
        /// Sets the open values.
        public static Box<ICandlestickProperty> _open(List<bool[]> values) => Interop.mkCandlestickAttr("open", Bindings.flatten2DArrayIf1D(values));
        /// Sets the open values.
        public static Box<ICandlestickProperty> _open(params bool[][] values) => Interop.mkCandlestickAttr("open", Bindings.flatten2DArrayIf1D(values));
        /// Sets the open values.
        public static Box<ICandlestickProperty> _open(IEnumerable<IEnumerable<string>> values) => Interop.mkCandlestickAttr("open", Bindings.flatten2DArrayIf1D(values));
        /// Sets the open values.
        public static Box<ICandlestickProperty> _open(List<string[]> values) => Interop.mkCandlestickAttr("open", Bindings.flatten2DArrayIf1D(values));
        /// Sets the open values.
        public static Box<ICandlestickProperty> _open(params string[][] values) => Interop.mkCandlestickAttr("open", Bindings.flatten2DArrayIf1D(values));
        /// Sets the open values.
        public static Box<ICandlestickProperty> _open(IEnumerable<IEnumerable<int>> values) => Interop.mkCandlestickAttr("open", Bindings.flatten2DArrayIf1D(values));
        /// Sets the open values.
        public static Box<ICandlestickProperty> _open(List<int[]> values) => Interop.mkCandlestickAttr("open", Bindings.flatten2DArrayIf1D(values));
        /// Sets the open values.
        public static Box<ICandlestickProperty> _open(params int[][] values) => Interop.mkCandlestickAttr("open", Bindings.flatten2DArrayIf1D(values));
        /// Sets the open values.
        public static Box<ICandlestickProperty> _open(IEnumerable<IEnumerable<float>> values) => Interop.mkCandlestickAttr("open", Bindings.flatten2DArrayIf1D(values));
        /// Sets the open values.
        public static Box<ICandlestickProperty> _open(List<float[]> values) => Interop.mkCandlestickAttr("open", Bindings.flatten2DArrayIf1D(values));
        /// Sets the open values.
        public static Box<ICandlestickProperty> _open(params float[][] values) => Interop.mkCandlestickAttr("open", Bindings.flatten2DArrayIf1D(values));
        /// Sets the open values.
        public static Box<ICandlestickProperty> _open(Literals.PlotData[] values) => Interop.mkCandlestickAttr("open", values);
        /// Sets the open values.
        public static Box<ICandlestickProperty> _open(IEnumerable<bool?> values) => Interop.mkCandlestickAttr("open", values.ToArray());
        /// Sets the open values.
        public static Box<ICandlestickProperty> _open(IEnumerable<System.DateTime?> values) => Interop.mkCandlestickAttr("open", values.ToArray());
        /// Sets the open values.
        public static Box<ICandlestickProperty> _open(IEnumerable<int?> values) => Interop.mkCandlestickAttr("open", values.ToArray());
        /// Sets the open values.
        public static Box<ICandlestickProperty> _open(IEnumerable<float?> values) => Interop.mkCandlestickAttr("open", values.ToArray());
        /// Sets the high values.
        public static Box<ICandlestickProperty> high(bool val) => Interop.mkCandlestickAttr("high", new[]{val});
        /// Sets the high values.
        public static Box<ICandlestickProperty> high(params bool[] values) => Interop.mkCandlestickAttr("high", values);
        /// Sets the high values.
        public static Box<ICandlestickProperty> high(System.DateTime val) => Interop.mkCandlestickAttr("high", new[]{val});
        /// Sets the high values.
        public static Box<ICandlestickProperty> high(params System.DateTime[] values) => Interop.mkCandlestickAttr("high", values);
        /// Sets the high values.
        public static Box<ICandlestickProperty> high(float val) => Interop.mkCandlestickAttr("high", new[]{val});
        /// Sets the high values.
        public static Box<ICandlestickProperty> high(params float[] values) => Interop.mkCandlestickAttr("high", values);
        /// Sets the high values.
        public static Box<ICandlestickProperty> high(int val) => Interop.mkCandlestickAttr("high", new[]{val});
        /// Sets the high values.
        public static Box<ICandlestickProperty> high(params int[] values) => Interop.mkCandlestickAttr("high", values);
        /// Sets the high values.
        public static Box<ICandlestickProperty> high(string val) => Interop.mkCandlestickAttr("high", new[]{val});
        /// Sets the high values.
        public static Box<ICandlestickProperty> high(params string[] values) => Interop.mkCandlestickAttr("high", values);
        /// Sets the high values.
        public static Box<ICandlestickProperty> high(IEnumerable<bool[]> values) => Interop.mkCandlestickAttr("high", Bindings.flatten2DArrayIf1D(values));
        /// Sets the high values.
        public static Box<ICandlestickProperty> high(List<bool[]> values) => Interop.mkCandlestickAttr("high", Bindings.flatten2DArrayIf1D(values));
        /// Sets the high values.
        public static Box<ICandlestickProperty> high(params bool[][] values) => Interop.mkCandlestickAttr("high", Bindings.flatten2DArrayIf1D(values));
        /// Sets the high values.
        public static Box<ICandlestickProperty> high(IEnumerable<IEnumerable<string>> values) => Interop.mkCandlestickAttr("high", Bindings.flatten2DArrayIf1D(values));
        /// Sets the high values.
        public static Box<ICandlestickProperty> high(List<string[]> values) => Interop.mkCandlestickAttr("high", Bindings.flatten2DArrayIf1D(values));
        /// Sets the high values.
        public static Box<ICandlestickProperty> high(params string[][] values) => Interop.mkCandlestickAttr("high", Bindings.flatten2DArrayIf1D(values));
        /// Sets the high values.
        public static Box<ICandlestickProperty> high(IEnumerable<IEnumerable<int>> values) => Interop.mkCandlestickAttr("high", Bindings.flatten2DArrayIf1D(values));
        /// Sets the high values.
        public static Box<ICandlestickProperty> high(List<int[]> values) => Interop.mkCandlestickAttr("high", Bindings.flatten2DArrayIf1D(values));
        /// Sets the high values.
        public static Box<ICandlestickProperty> high(params int[][] values) => Interop.mkCandlestickAttr("high", Bindings.flatten2DArrayIf1D(values));
        /// Sets the high values.
        public static Box<ICandlestickProperty> high(IEnumerable<IEnumerable<float>> values) => Interop.mkCandlestickAttr("high", Bindings.flatten2DArrayIf1D(values));
        /// Sets the high values.
        public static Box<ICandlestickProperty> high(List<float[]> values) => Interop.mkCandlestickAttr("high", Bindings.flatten2DArrayIf1D(values));
        /// Sets the high values.
        public static Box<ICandlestickProperty> high(params float[][] values) => Interop.mkCandlestickAttr("high", Bindings.flatten2DArrayIf1D(values));
        /// Sets the high values.
        public static Box<ICandlestickProperty> high(Literals.PlotData[] values) => Interop.mkCandlestickAttr("high", values);
        /// Sets the high values.
        public static Box<ICandlestickProperty> high(IEnumerable<bool?> values) => Interop.mkCandlestickAttr("high", values.ToArray());
        /// Sets the high values.
        public static Box<ICandlestickProperty> high(IEnumerable<System.DateTime?> values) => Interop.mkCandlestickAttr("high", values.ToArray());
        /// Sets the high values.
        public static Box<ICandlestickProperty> high(IEnumerable<int?> values) => Interop.mkCandlestickAttr("high", values.ToArray());
        /// Sets the high values.
        public static Box<ICandlestickProperty> high(IEnumerable<float?> values) => Interop.mkCandlestickAttr("high", values.ToArray());
        /// Sets the low values.
        public static Box<ICandlestickProperty> low(bool val) => Interop.mkCandlestickAttr("low", new[]{val});
        /// Sets the low values.
        public static Box<ICandlestickProperty> low(params bool[] values) => Interop.mkCandlestickAttr("low", values);
        /// Sets the low values.
        public static Box<ICandlestickProperty> low(System.DateTime val) => Interop.mkCandlestickAttr("low", new[]{val});
        /// Sets the low values.
        public static Box<ICandlestickProperty> low(params System.DateTime[] values) => Interop.mkCandlestickAttr("low", values);
        /// Sets the low values.
        public static Box<ICandlestickProperty> low(float val) => Interop.mkCandlestickAttr("low", new[]{val});
        /// Sets the low values.
        public static Box<ICandlestickProperty> low(params float[] values) => Interop.mkCandlestickAttr("low", values);
        /// Sets the low values.
        public static Box<ICandlestickProperty> low(int val) => Interop.mkCandlestickAttr("low", new[]{val});
        /// Sets the low values.
        public static Box<ICandlestickProperty> low(params int[] values) => Interop.mkCandlestickAttr("low", values);
        /// Sets the low values.
        public static Box<ICandlestickProperty> low(string val) => Interop.mkCandlestickAttr("low", new[]{val});
        /// Sets the low values.
        public static Box<ICandlestickProperty> low(params string[] values) => Interop.mkCandlestickAttr("low", values);
        /// Sets the low values.
        public static Box<ICandlestickProperty> low(IEnumerable<bool[]> values) => Interop.mkCandlestickAttr("low", Bindings.flatten2DArrayIf1D(values));
        /// Sets the low values.
        public static Box<ICandlestickProperty> low(List<bool[]> values) => Interop.mkCandlestickAttr("low", Bindings.flatten2DArrayIf1D(values));
        /// Sets the low values.
        public static Box<ICandlestickProperty> low(params bool[][] values) => Interop.mkCandlestickAttr("low", Bindings.flatten2DArrayIf1D(values));
        /// Sets the low values.
        public static Box<ICandlestickProperty> low(IEnumerable<IEnumerable<string>> values) => Interop.mkCandlestickAttr("low", Bindings.flatten2DArrayIf1D(values));
        /// Sets the low values.
        public static Box<ICandlestickProperty> low(List<string[]> values) => Interop.mkCandlestickAttr("low", Bindings.flatten2DArrayIf1D(values));
        /// Sets the low values.
        public static Box<ICandlestickProperty> low(params string[][] values) => Interop.mkCandlestickAttr("low", Bindings.flatten2DArrayIf1D(values));
        /// Sets the low values.
        public static Box<ICandlestickProperty> low(IEnumerable<IEnumerable<int>> values) => Interop.mkCandlestickAttr("low", Bindings.flatten2DArrayIf1D(values));
        /// Sets the low values.
        public static Box<ICandlestickProperty> low(List<int[]> values) => Interop.mkCandlestickAttr("low", Bindings.flatten2DArrayIf1D(values));
        /// Sets the low values.
        public static Box<ICandlestickProperty> low(params int[][] values) => Interop.mkCandlestickAttr("low", Bindings.flatten2DArrayIf1D(values));
        /// Sets the low values.
        public static Box<ICandlestickProperty> low(IEnumerable<IEnumerable<float>> values) => Interop.mkCandlestickAttr("low", Bindings.flatten2DArrayIf1D(values));
        /// Sets the low values.
        public static Box<ICandlestickProperty> low(List<float[]> values) => Interop.mkCandlestickAttr("low", Bindings.flatten2DArrayIf1D(values));
        /// Sets the low values.
        public static Box<ICandlestickProperty> low(params float[][] values) => Interop.mkCandlestickAttr("low", Bindings.flatten2DArrayIf1D(values));
        /// Sets the low values.
        public static Box<ICandlestickProperty> low(Literals.PlotData[] values) => Interop.mkCandlestickAttr("low", values);
        /// Sets the low values.
        public static Box<ICandlestickProperty> low(IEnumerable<bool?> values) => Interop.mkCandlestickAttr("low", values.ToArray());
        /// Sets the low values.
        public static Box<ICandlestickProperty> low(IEnumerable<System.DateTime?> values) => Interop.mkCandlestickAttr("low", values.ToArray());
        /// Sets the low values.
        public static Box<ICandlestickProperty> low(IEnumerable<int?> values) => Interop.mkCandlestickAttr("low", values.ToArray());
        /// Sets the low values.
        public static Box<ICandlestickProperty> low(IEnumerable<float?> values) => Interop.mkCandlestickAttr("low", values.ToArray());
        /// Sets the close values.
        public static Box<ICandlestickProperty> close(bool val) => Interop.mkCandlestickAttr("close", new[]{val});
        /// Sets the close values.
        public static Box<ICandlestickProperty> close(params bool[] values) => Interop.mkCandlestickAttr("close", values);
        /// Sets the close values.
        public static Box<ICandlestickProperty> close(System.DateTime val) => Interop.mkCandlestickAttr("close", new[]{val});
        /// Sets the close values.
        public static Box<ICandlestickProperty> close(params System.DateTime[] values) => Interop.mkCandlestickAttr("close", values);
        /// Sets the close values.
        public static Box<ICandlestickProperty> close(float val) => Interop.mkCandlestickAttr("close", new[]{val});
        /// Sets the close values.
        public static Box<ICandlestickProperty> close(params float[] values) => Interop.mkCandlestickAttr("close", values);
        /// Sets the close values.
        public static Box<ICandlestickProperty> close(int val) => Interop.mkCandlestickAttr("close", new[]{val});
        /// Sets the close values.
        public static Box<ICandlestickProperty> close(params int[] values) => Interop.mkCandlestickAttr("close", values);
        /// Sets the close values.
        public static Box<ICandlestickProperty> close(string val) => Interop.mkCandlestickAttr("close", new[]{val});
        /// Sets the close values.
        public static Box<ICandlestickProperty> close(params string[] values) => Interop.mkCandlestickAttr("close", values);
        /// Sets the close values.
        public static Box<ICandlestickProperty> close(IEnumerable<bool[]> values) => Interop.mkCandlestickAttr("close", Bindings.flatten2DArrayIf1D(values));
        /// Sets the close values.
        public static Box<ICandlestickProperty> close(List<bool[]> values) => Interop.mkCandlestickAttr("close", Bindings.flatten2DArrayIf1D(values));
        /// Sets the close values.
        public static Box<ICandlestickProperty> close(params bool[][] values) => Interop.mkCandlestickAttr("close", Bindings.flatten2DArrayIf1D(values));
        /// Sets the close values.
        public static Box<ICandlestickProperty> close(IEnumerable<IEnumerable<string>> values) => Interop.mkCandlestickAttr("close", Bindings.flatten2DArrayIf1D(values));
        /// Sets the close values.
        public static Box<ICandlestickProperty> close(List<string[]> values) => Interop.mkCandlestickAttr("close", Bindings.flatten2DArrayIf1D(values));
        /// Sets the close values.
        public static Box<ICandlestickProperty> close(params string[][] values) => Interop.mkCandlestickAttr("close", Bindings.flatten2DArrayIf1D(values));
        /// Sets the close values.
        public static Box<ICandlestickProperty> close(IEnumerable<IEnumerable<int>> values) => Interop.mkCandlestickAttr("close", Bindings.flatten2DArrayIf1D(values));
        /// Sets the close values.
        public static Box<ICandlestickProperty> close(List<int[]> values) => Interop.mkCandlestickAttr("close", Bindings.flatten2DArrayIf1D(values));
        /// Sets the close values.
        public static Box<ICandlestickProperty> close(params int[][] values) => Interop.mkCandlestickAttr("close", Bindings.flatten2DArrayIf1D(values));
        /// Sets the close values.
        public static Box<ICandlestickProperty> close(IEnumerable<IEnumerable<float>> values) => Interop.mkCandlestickAttr("close", Bindings.flatten2DArrayIf1D(values));
        /// Sets the close values.
        public static Box<ICandlestickProperty> close(List<float[]> values) => Interop.mkCandlestickAttr("close", Bindings.flatten2DArrayIf1D(values));
        /// Sets the close values.
        public static Box<ICandlestickProperty> close(params float[][] values) => Interop.mkCandlestickAttr("close", Bindings.flatten2DArrayIf1D(values));
        /// Sets the close values.
        public static Box<ICandlestickProperty> close(Literals.PlotData[] values) => Interop.mkCandlestickAttr("close", values);
        /// Sets the close values.
        public static Box<ICandlestickProperty> close(IEnumerable<bool?> values) => Interop.mkCandlestickAttr("close", values.ToArray());
        /// Sets the close values.
        public static Box<ICandlestickProperty> close(IEnumerable<System.DateTime?> values) => Interop.mkCandlestickAttr("close", values.ToArray());
        /// Sets the close values.
        public static Box<ICandlestickProperty> close(IEnumerable<int?> values) => Interop.mkCandlestickAttr("close", values.ToArray());
        /// Sets the close values.
        public static Box<ICandlestickProperty> close(IEnumerable<float?> values) => Interop.mkCandlestickAttr("close", values.ToArray());
        public static Box<ICandlestickProperty> line(params Box<ILineProperty>[] properties) => Interop.mkCandlestickAttr("line", Bindings.flattenProperties(properties));
        public static Box<ICandlestickProperty> increasing(params Box<IIncreasingProperty>[] properties) => Interop.mkCandlestickAttr("increasing", Bindings.flattenProperties(properties));
        public static Box<ICandlestickProperty> decreasing(params Box<IDecreasingProperty>[] properties) => Interop.mkCandlestickAttr("decreasing", Bindings.flattenProperties(properties));
        /// Sets hover text elements associated with each sample point. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to this trace's sample points.
        public static Box<ICandlestickProperty> text(string val) => Interop.mkCandlestickAttr("text", val);
        /// Sets hover text elements associated with each sample point. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to this trace's sample points.
        public static Box<ICandlestickProperty> text(IEnumerable<string> values) => Interop.mkCandlestickAttr("text", values.ToArray());
        /// Same as `text`.
        public static Box<ICandlestickProperty> hovertext(string val) => Interop.mkCandlestickAttr("hovertext", val);
        /// Same as `text`.
        public static Box<ICandlestickProperty> hovertext(IEnumerable<string> values) => Interop.mkCandlestickAttr("hovertext", values.ToArray());
        /// Sets the width of the whiskers relative to the box' width. For example, with 1, the whiskers are as wide as the box(es).
        public static Box<ICandlestickProperty> whiskerwidth(int val) => Interop.mkCandlestickAttr("whiskerwidth", val);
        /// Sets the width of the whiskers relative to the box' width. For example, with 1, the whiskers are as wide as the box(es).
        public static Box<ICandlestickProperty> whiskerwidth(float val) => Interop.mkCandlestickAttr("whiskerwidth", val);
        public static Box<ICandlestickProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkCandlestickAttr("hoverlabel", Bindings.flattenProperties(properties));
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<ICandlestickProperty> xaxis(int anchorId) => Interop.mkCandlestickAttr("xaxis", anchorId > 1 ? $"x{anchorId}" : "");
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<ICandlestickProperty> xaxis(string val) => Interop.mkCandlestickAttr("xaxis", val);
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<ICandlestickProperty> yaxis(int anchorId) => Interop.mkCandlestickAttr("yaxis", anchorId > 1 ? $"y{anchorId}" : "");
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<ICandlestickProperty> yaxis(string val) => Interop.mkCandlestickAttr("yaxis", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<ICandlestickProperty> idssrc(string val) => Interop.mkCandlestickAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<ICandlestickProperty> customdatasrc(string val) => Interop.mkCandlestickAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<ICandlestickProperty> metasrc(string val) => Interop.mkCandlestickAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<ICandlestickProperty> hoverinfosrc(string val) => Interop.mkCandlestickAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  x .
        public static Box<ICandlestickProperty> xsrc(string val) => Interop.mkCandlestickAttr("xsrc", val);
        /// Sets the source reference on plot.ly for  open .
        public static Box<ICandlestickProperty> opensrc(string val) => Interop.mkCandlestickAttr("opensrc", val);
        /// Sets the source reference on plot.ly for  high .
        public static Box<ICandlestickProperty> highsrc(string val) => Interop.mkCandlestickAttr("highsrc", val);
        /// Sets the source reference on plot.ly for  low .
        public static Box<ICandlestickProperty> lowsrc(string val) => Interop.mkCandlestickAttr("lowsrc", val);
        /// Sets the source reference on plot.ly for  close .
        public static Box<ICandlestickProperty> closesrc(string val) => Interop.mkCandlestickAttr("closesrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<ICandlestickProperty> textsrc(string val) => Interop.mkCandlestickAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<ICandlestickProperty> hovertextsrc(string val) => Interop.mkCandlestickAttr("hovertextsrc", val);
    }

    public static partial class Candlestick
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<ICandlestickProperty> legendonly() => Interop.mkCandlestickAttr("visible", "legendonly");
            public static Box<ICandlestickProperty> _false() => Interop.mkCandlestickAttr("visible", false);
            public static Box<ICandlestickProperty> _true() => Interop.mkCandlestickAttr("visible", true);
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<ICandlestickProperty> all() => Interop.mkCandlestickAttr("hoverinfo", "all");
            public static Box<ICandlestickProperty> none() => Interop.mkCandlestickAttr("hoverinfo", "none");
            public static Box<ICandlestickProperty> skip() => Interop.mkCandlestickAttr("hoverinfo", "skip");
            public static Box<ICandlestickProperty> name() => Interop.mkCandlestickAttr("hoverinfo", "name");
            public static Box<ICandlestickProperty> text() => Interop.mkCandlestickAttr("hoverinfo", "text");
            public static Box<ICandlestickProperty> x() => Interop.mkCandlestickAttr("hoverinfo", "x");
            public static Box<ICandlestickProperty> y() => Interop.mkCandlestickAttr("hoverinfo", "y");
            public static Box<ICandlestickProperty> z() => Interop.mkCandlestickAttr("hoverinfo", "z");
        }

        /// Sets the calendar system to use with `x` date data.
        public static partial class Xcalendar
        {
            public static Box<ICandlestickProperty> chinese() => Interop.mkCandlestickAttr("xcalendar", "chinese");
            public static Box<ICandlestickProperty> coptic() => Interop.mkCandlestickAttr("xcalendar", "coptic");
            public static Box<ICandlestickProperty> discworld() => Interop.mkCandlestickAttr("xcalendar", "discworld");
            public static Box<ICandlestickProperty> ethiopian() => Interop.mkCandlestickAttr("xcalendar", "ethiopian");
            public static Box<ICandlestickProperty> gregorian() => Interop.mkCandlestickAttr("xcalendar", "gregorian");
            public static Box<ICandlestickProperty> hebrew() => Interop.mkCandlestickAttr("xcalendar", "hebrew");
            public static Box<ICandlestickProperty> islamic() => Interop.mkCandlestickAttr("xcalendar", "islamic");
            public static Box<ICandlestickProperty> jalali() => Interop.mkCandlestickAttr("xcalendar", "jalali");
            public static Box<ICandlestickProperty> julian() => Interop.mkCandlestickAttr("xcalendar", "julian");
            public static Box<ICandlestickProperty> mayan() => Interop.mkCandlestickAttr("xcalendar", "mayan");
            public static Box<ICandlestickProperty> nanakshahi() => Interop.mkCandlestickAttr("xcalendar", "nanakshahi");
            public static Box<ICandlestickProperty> nepali() => Interop.mkCandlestickAttr("xcalendar", "nepali");
            public static Box<ICandlestickProperty> persian() => Interop.mkCandlestickAttr("xcalendar", "persian");
            public static Box<ICandlestickProperty> taiwan() => Interop.mkCandlestickAttr("xcalendar", "taiwan");
            public static Box<ICandlestickProperty> thai() => Interop.mkCandlestickAttr("xcalendar", "thai");
            public static Box<ICandlestickProperty> ummalqura() => Interop.mkCandlestickAttr("xcalendar", "ummalqura");
        }
    }
}