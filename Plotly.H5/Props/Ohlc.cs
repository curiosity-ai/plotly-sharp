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

    public static partial class Ohlc
    {
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IOhlcProperty> showlegend(bool val) => Interop.mkOhlcAttr("showlegend", val);
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IOhlcProperty> legendgroup(string val) => Interop.mkOhlcAttr("legendgroup", val);
        /// Sets the opacity of the trace.
        public static Box<IOhlcProperty> opacity(int val) => Interop.mkOhlcAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<IOhlcProperty> opacity(float val) => Interop.mkOhlcAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IOhlcProperty> name(string val) => Interop.mkOhlcAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IOhlcProperty> uid(string val) => Interop.mkOhlcAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IOhlcProperty> ids(bool val) => Interop.mkOhlcAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IOhlcProperty> ids(params bool[] values) => Interop.mkOhlcAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IOhlcProperty> ids(System.DateTime val) => Interop.mkOhlcAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IOhlcProperty> ids(params System.DateTime[] values) => Interop.mkOhlcAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IOhlcProperty> ids(float val) => Interop.mkOhlcAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IOhlcProperty> ids(params float[] values) => Interop.mkOhlcAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IOhlcProperty> ids(int val) => Interop.mkOhlcAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IOhlcProperty> ids(params int[] values) => Interop.mkOhlcAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IOhlcProperty> ids(string val) => Interop.mkOhlcAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IOhlcProperty> ids(params string[] values) => Interop.mkOhlcAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IOhlcProperty> ids(IEnumerable<bool[]> values) => Interop.mkOhlcAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IOhlcProperty> ids(List<bool[]> values) => Interop.mkOhlcAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IOhlcProperty> ids(params bool[][] values) => Interop.mkOhlcAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IOhlcProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkOhlcAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IOhlcProperty> ids(List<string[]> values) => Interop.mkOhlcAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IOhlcProperty> ids(params string[][] values) => Interop.mkOhlcAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IOhlcProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkOhlcAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IOhlcProperty> ids(List<int[]> values) => Interop.mkOhlcAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IOhlcProperty> ids(params int[][] values) => Interop.mkOhlcAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IOhlcProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkOhlcAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IOhlcProperty> ids(List<float[]> values) => Interop.mkOhlcAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IOhlcProperty> ids(params float[][] values) => Interop.mkOhlcAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IOhlcProperty> ids(Literals.PlotData[] values) => Interop.mkOhlcAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IOhlcProperty> ids(IEnumerable<bool?> values) => Interop.mkOhlcAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IOhlcProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkOhlcAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IOhlcProperty> ids(IEnumerable<int?> values) => Interop.mkOhlcAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IOhlcProperty> ids(IEnumerable<float?> values) => Interop.mkOhlcAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IOhlcProperty> customdata(bool val) => Interop.mkOhlcAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IOhlcProperty> customdata(params bool[] values) => Interop.mkOhlcAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IOhlcProperty> customdata(System.DateTime val) => Interop.mkOhlcAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IOhlcProperty> customdata(params System.DateTime[] values) => Interop.mkOhlcAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IOhlcProperty> customdata(float val) => Interop.mkOhlcAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IOhlcProperty> customdata(params float[] values) => Interop.mkOhlcAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IOhlcProperty> customdata(int val) => Interop.mkOhlcAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IOhlcProperty> customdata(params int[] values) => Interop.mkOhlcAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IOhlcProperty> customdata(string val) => Interop.mkOhlcAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IOhlcProperty> customdata(params string[] values) => Interop.mkOhlcAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IOhlcProperty> customdata(IEnumerable<bool[]> values) => Interop.mkOhlcAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IOhlcProperty> customdata(List<bool[]> values) => Interop.mkOhlcAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IOhlcProperty> customdata(params bool[][] values) => Interop.mkOhlcAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IOhlcProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkOhlcAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IOhlcProperty> customdata(List<string[]> values) => Interop.mkOhlcAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IOhlcProperty> customdata(params string[][] values) => Interop.mkOhlcAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IOhlcProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkOhlcAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IOhlcProperty> customdata(List<int[]> values) => Interop.mkOhlcAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IOhlcProperty> customdata(params int[][] values) => Interop.mkOhlcAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IOhlcProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkOhlcAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IOhlcProperty> customdata(List<float[]> values) => Interop.mkOhlcAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IOhlcProperty> customdata(params float[][] values) => Interop.mkOhlcAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IOhlcProperty> customdata(Literals.PlotData[] values) => Interop.mkOhlcAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IOhlcProperty> customdata(IEnumerable<bool?> values) => Interop.mkOhlcAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IOhlcProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkOhlcAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IOhlcProperty> customdata(IEnumerable<int?> values) => Interop.mkOhlcAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IOhlcProperty> customdata(IEnumerable<float?> values) => Interop.mkOhlcAttr("customdata", values.ToArray());
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IOhlcProperty> selectedpoints(bool val) => Interop.mkOhlcAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IOhlcProperty> selectedpoints(params bool[] values) => Interop.mkOhlcAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IOhlcProperty> selectedpoints(System.DateTime val) => Interop.mkOhlcAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IOhlcProperty> selectedpoints(params System.DateTime[] values) => Interop.mkOhlcAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IOhlcProperty> selectedpoints(int val) => Interop.mkOhlcAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IOhlcProperty> selectedpoints(params int[] values) => Interop.mkOhlcAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IOhlcProperty> selectedpoints(float val) => Interop.mkOhlcAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IOhlcProperty> selectedpoints(params float[] values) => Interop.mkOhlcAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IOhlcProperty> selectedpoints(string val) => Interop.mkOhlcAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IOhlcProperty> selectedpoints(params string[] values) => Interop.mkOhlcAttr("selectedpoints", values);
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IOhlcProperty> hoverinfo(params Box<IOhlcProperty>[] properties) => Interop.mkOhlcAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        public static Box<IOhlcProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkOhlcAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IOhlcProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkOhlcAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IOhlcProperty> uirevision(bool val) => Interop.mkOhlcAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IOhlcProperty> uirevision(params bool[] values) => Interop.mkOhlcAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IOhlcProperty> uirevision(System.DateTime val) => Interop.mkOhlcAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IOhlcProperty> uirevision(params System.DateTime[] values) => Interop.mkOhlcAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IOhlcProperty> uirevision(int val) => Interop.mkOhlcAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IOhlcProperty> uirevision(params int[] values) => Interop.mkOhlcAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IOhlcProperty> uirevision(float val) => Interop.mkOhlcAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IOhlcProperty> uirevision(params float[] values) => Interop.mkOhlcAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IOhlcProperty> uirevision(string val) => Interop.mkOhlcAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IOhlcProperty> uirevision(params string[] values) => Interop.mkOhlcAttr("uirevision", values);
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<IOhlcProperty> x(bool val) => Interop.mkOhlcAttr("x", new[]{val});
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<IOhlcProperty> x(IEnumerable<bool> values) => Interop.mkOhlcAttr("x", values.ToArray());
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<IOhlcProperty> x(System.DateTime val) => Interop.mkOhlcAttr("x", new[]{val});
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<IOhlcProperty> x(IEnumerable<System.DateTime> values) => Interop.mkOhlcAttr("x", values.ToArray());
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<IOhlcProperty> x(float val) => Interop.mkOhlcAttr("x", new[]{val});
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<IOhlcProperty> x(IEnumerable<float> values) => Interop.mkOhlcAttr("x", values.ToArray());
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<IOhlcProperty> x(int val) => Interop.mkOhlcAttr("x", new[]{val});
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<IOhlcProperty> x(IEnumerable<int> values) => Interop.mkOhlcAttr("x", values.ToArray());
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<IOhlcProperty> x(string val) => Interop.mkOhlcAttr("x", new[]{val});
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<IOhlcProperty> x(IEnumerable<string> values) => Interop.mkOhlcAttr("x", values.ToArray());
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<IOhlcProperty> x(IEnumerable<bool[]> values) => Interop.mkOhlcAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<IOhlcProperty> x(List<bool[]> values) => Interop.mkOhlcAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<IOhlcProperty> x(params bool[][] values) => Interop.mkOhlcAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<IOhlcProperty> x(IEnumerable<IEnumerable<string>> values) => Interop.mkOhlcAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<IOhlcProperty> x(List<string[]> values) => Interop.mkOhlcAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<IOhlcProperty> x(params string[][] values) => Interop.mkOhlcAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<IOhlcProperty> x(IEnumerable<IEnumerable<int>> values) => Interop.mkOhlcAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<IOhlcProperty> x(List<int[]> values) => Interop.mkOhlcAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<IOhlcProperty> x(params int[][] values) => Interop.mkOhlcAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<IOhlcProperty> x(IEnumerable<IEnumerable<float>> values) => Interop.mkOhlcAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<IOhlcProperty> x(List<float[]> values) => Interop.mkOhlcAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<IOhlcProperty> x(params float[][] values) => Interop.mkOhlcAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<IOhlcProperty> x(Literals.PlotData[] values) => Interop.mkOhlcAttr("x", values);
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<IOhlcProperty> x(IEnumerable<bool?> values) => Interop.mkOhlcAttr("x", values.ToArray());
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<IOhlcProperty> x(IEnumerable<System.DateTime?> values) => Interop.mkOhlcAttr("x", values.ToArray());
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<IOhlcProperty> x(IEnumerable<int?> values) => Interop.mkOhlcAttr("x", values.ToArray());
        /// Sets the x coordinates. If absent, linear coordinate will be generated.
        public static Box<IOhlcProperty> x(IEnumerable<float?> values) => Interop.mkOhlcAttr("x", values.ToArray());
        /// Sets the open values.
        public static Box<IOhlcProperty> _open(bool val) => Interop.mkOhlcAttr("open", new[]{val});
        /// Sets the open values.
        public static Box<IOhlcProperty> _open(params bool[] values) => Interop.mkOhlcAttr("open", values);
        /// Sets the open values.
        public static Box<IOhlcProperty> _open(System.DateTime val) => Interop.mkOhlcAttr("open", new[]{val});
        /// Sets the open values.
        public static Box<IOhlcProperty> _open(params System.DateTime[] values) => Interop.mkOhlcAttr("open", values);
        /// Sets the open values.
        public static Box<IOhlcProperty> _open(float val) => Interop.mkOhlcAttr("open", new[]{val});
        /// Sets the open values.
        public static Box<IOhlcProperty> _open(params float[] values) => Interop.mkOhlcAttr("open", values);
        /// Sets the open values.
        public static Box<IOhlcProperty> _open(int val) => Interop.mkOhlcAttr("open", new[]{val});
        /// Sets the open values.
        public static Box<IOhlcProperty> _open(params int[] values) => Interop.mkOhlcAttr("open", values);
        /// Sets the open values.
        public static Box<IOhlcProperty> _open(string val) => Interop.mkOhlcAttr("open", new[]{val});
        /// Sets the open values.
        public static Box<IOhlcProperty> _open(params string[] values) => Interop.mkOhlcAttr("open", values);
        /// Sets the open values.
        public static Box<IOhlcProperty> _open(IEnumerable<bool[]> values) => Interop.mkOhlcAttr("open", Bindings.flatten2DArrayIf1D(values));
        /// Sets the open values.
        public static Box<IOhlcProperty> _open(List<bool[]> values) => Interop.mkOhlcAttr("open", Bindings.flatten2DArrayIf1D(values));
        /// Sets the open values.
        public static Box<IOhlcProperty> _open(params bool[][] values) => Interop.mkOhlcAttr("open", Bindings.flatten2DArrayIf1D(values));
        /// Sets the open values.
        public static Box<IOhlcProperty> _open(IEnumerable<IEnumerable<string>> values) => Interop.mkOhlcAttr("open", Bindings.flatten2DArrayIf1D(values));
        /// Sets the open values.
        public static Box<IOhlcProperty> _open(List<string[]> values) => Interop.mkOhlcAttr("open", Bindings.flatten2DArrayIf1D(values));
        /// Sets the open values.
        public static Box<IOhlcProperty> _open(params string[][] values) => Interop.mkOhlcAttr("open", Bindings.flatten2DArrayIf1D(values));
        /// Sets the open values.
        public static Box<IOhlcProperty> _open(IEnumerable<IEnumerable<int>> values) => Interop.mkOhlcAttr("open", Bindings.flatten2DArrayIf1D(values));
        /// Sets the open values.
        public static Box<IOhlcProperty> _open(List<int[]> values) => Interop.mkOhlcAttr("open", Bindings.flatten2DArrayIf1D(values));
        /// Sets the open values.
        public static Box<IOhlcProperty> _open(params int[][] values) => Interop.mkOhlcAttr("open", Bindings.flatten2DArrayIf1D(values));
        /// Sets the open values.
        public static Box<IOhlcProperty> _open(IEnumerable<IEnumerable<float>> values) => Interop.mkOhlcAttr("open", Bindings.flatten2DArrayIf1D(values));
        /// Sets the open values.
        public static Box<IOhlcProperty> _open(List<float[]> values) => Interop.mkOhlcAttr("open", Bindings.flatten2DArrayIf1D(values));
        /// Sets the open values.
        public static Box<IOhlcProperty> _open(params float[][] values) => Interop.mkOhlcAttr("open", Bindings.flatten2DArrayIf1D(values));
        /// Sets the open values.
        public static Box<IOhlcProperty> _open(Literals.PlotData[] values) => Interop.mkOhlcAttr("open", values);
        /// Sets the open values.
        public static Box<IOhlcProperty> _open(IEnumerable<bool?> values) => Interop.mkOhlcAttr("open", values.ToArray());
        /// Sets the open values.
        public static Box<IOhlcProperty> _open(IEnumerable<System.DateTime?> values) => Interop.mkOhlcAttr("open", values.ToArray());
        /// Sets the open values.
        public static Box<IOhlcProperty> _open(IEnumerable<int?> values) => Interop.mkOhlcAttr("open", values.ToArray());
        /// Sets the open values.
        public static Box<IOhlcProperty> _open(IEnumerable<float?> values) => Interop.mkOhlcAttr("open", values.ToArray());
        /// Sets the high values.
        public static Box<IOhlcProperty> high(bool val) => Interop.mkOhlcAttr("high", new[]{val});
        /// Sets the high values.
        public static Box<IOhlcProperty> high(params bool[] values) => Interop.mkOhlcAttr("high", values);
        /// Sets the high values.
        public static Box<IOhlcProperty> high(System.DateTime val) => Interop.mkOhlcAttr("high", new[]{val});
        /// Sets the high values.
        public static Box<IOhlcProperty> high(params System.DateTime[] values) => Interop.mkOhlcAttr("high", values);
        /// Sets the high values.
        public static Box<IOhlcProperty> high(float val) => Interop.mkOhlcAttr("high", new[]{val});
        /// Sets the high values.
        public static Box<IOhlcProperty> high(params float[] values) => Interop.mkOhlcAttr("high", values);
        /// Sets the high values.
        public static Box<IOhlcProperty> high(int val) => Interop.mkOhlcAttr("high", new[]{val});
        /// Sets the high values.
        public static Box<IOhlcProperty> high(params int[] values) => Interop.mkOhlcAttr("high", values);
        /// Sets the high values.
        public static Box<IOhlcProperty> high(string val) => Interop.mkOhlcAttr("high", new[]{val});
        /// Sets the high values.
        public static Box<IOhlcProperty> high(params string[] values) => Interop.mkOhlcAttr("high", values);
        /// Sets the high values.
        public static Box<IOhlcProperty> high(IEnumerable<bool[]> values) => Interop.mkOhlcAttr("high", Bindings.flatten2DArrayIf1D(values));
        /// Sets the high values.
        public static Box<IOhlcProperty> high(List<bool[]> values) => Interop.mkOhlcAttr("high", Bindings.flatten2DArrayIf1D(values));
        /// Sets the high values.
        public static Box<IOhlcProperty> high(params bool[][] values) => Interop.mkOhlcAttr("high", Bindings.flatten2DArrayIf1D(values));
        /// Sets the high values.
        public static Box<IOhlcProperty> high(IEnumerable<IEnumerable<string>> values) => Interop.mkOhlcAttr("high", Bindings.flatten2DArrayIf1D(values));
        /// Sets the high values.
        public static Box<IOhlcProperty> high(List<string[]> values) => Interop.mkOhlcAttr("high", Bindings.flatten2DArrayIf1D(values));
        /// Sets the high values.
        public static Box<IOhlcProperty> high(params string[][] values) => Interop.mkOhlcAttr("high", Bindings.flatten2DArrayIf1D(values));
        /// Sets the high values.
        public static Box<IOhlcProperty> high(IEnumerable<IEnumerable<int>> values) => Interop.mkOhlcAttr("high", Bindings.flatten2DArrayIf1D(values));
        /// Sets the high values.
        public static Box<IOhlcProperty> high(List<int[]> values) => Interop.mkOhlcAttr("high", Bindings.flatten2DArrayIf1D(values));
        /// Sets the high values.
        public static Box<IOhlcProperty> high(params int[][] values) => Interop.mkOhlcAttr("high", Bindings.flatten2DArrayIf1D(values));
        /// Sets the high values.
        public static Box<IOhlcProperty> high(IEnumerable<IEnumerable<float>> values) => Interop.mkOhlcAttr("high", Bindings.flatten2DArrayIf1D(values));
        /// Sets the high values.
        public static Box<IOhlcProperty> high(List<float[]> values) => Interop.mkOhlcAttr("high", Bindings.flatten2DArrayIf1D(values));
        /// Sets the high values.
        public static Box<IOhlcProperty> high(params float[][] values) => Interop.mkOhlcAttr("high", Bindings.flatten2DArrayIf1D(values));
        /// Sets the high values.
        public static Box<IOhlcProperty> high(Literals.PlotData[] values) => Interop.mkOhlcAttr("high", values);
        /// Sets the high values.
        public static Box<IOhlcProperty> high(IEnumerable<bool?> values) => Interop.mkOhlcAttr("high", values.ToArray());
        /// Sets the high values.
        public static Box<IOhlcProperty> high(IEnumerable<System.DateTime?> values) => Interop.mkOhlcAttr("high", values.ToArray());
        /// Sets the high values.
        public static Box<IOhlcProperty> high(IEnumerable<int?> values) => Interop.mkOhlcAttr("high", values.ToArray());
        /// Sets the high values.
        public static Box<IOhlcProperty> high(IEnumerable<float?> values) => Interop.mkOhlcAttr("high", values.ToArray());
        /// Sets the low values.
        public static Box<IOhlcProperty> low(bool val) => Interop.mkOhlcAttr("low", new[]{val});
        /// Sets the low values.
        public static Box<IOhlcProperty> low(params bool[] values) => Interop.mkOhlcAttr("low", values);
        /// Sets the low values.
        public static Box<IOhlcProperty> low(System.DateTime val) => Interop.mkOhlcAttr("low", new[]{val});
        /// Sets the low values.
        public static Box<IOhlcProperty> low(params System.DateTime[] values) => Interop.mkOhlcAttr("low", values);
        /// Sets the low values.
        public static Box<IOhlcProperty> low(float val) => Interop.mkOhlcAttr("low", new[]{val});
        /// Sets the low values.
        public static Box<IOhlcProperty> low(params float[] values) => Interop.mkOhlcAttr("low", values);
        /// Sets the low values.
        public static Box<IOhlcProperty> low(int val) => Interop.mkOhlcAttr("low", new[]{val});
        /// Sets the low values.
        public static Box<IOhlcProperty> low(params int[] values) => Interop.mkOhlcAttr("low", values);
        /// Sets the low values.
        public static Box<IOhlcProperty> low(string val) => Interop.mkOhlcAttr("low", new[]{val});
        /// Sets the low values.
        public static Box<IOhlcProperty> low(params string[] values) => Interop.mkOhlcAttr("low", values);
        /// Sets the low values.
        public static Box<IOhlcProperty> low(IEnumerable<bool[]> values) => Interop.mkOhlcAttr("low", Bindings.flatten2DArrayIf1D(values));
        /// Sets the low values.
        public static Box<IOhlcProperty> low(List<bool[]> values) => Interop.mkOhlcAttr("low", Bindings.flatten2DArrayIf1D(values));
        /// Sets the low values.
        public static Box<IOhlcProperty> low(params bool[][] values) => Interop.mkOhlcAttr("low", Bindings.flatten2DArrayIf1D(values));
        /// Sets the low values.
        public static Box<IOhlcProperty> low(IEnumerable<IEnumerable<string>> values) => Interop.mkOhlcAttr("low", Bindings.flatten2DArrayIf1D(values));
        /// Sets the low values.
        public static Box<IOhlcProperty> low(List<string[]> values) => Interop.mkOhlcAttr("low", Bindings.flatten2DArrayIf1D(values));
        /// Sets the low values.
        public static Box<IOhlcProperty> low(params string[][] values) => Interop.mkOhlcAttr("low", Bindings.flatten2DArrayIf1D(values));
        /// Sets the low values.
        public static Box<IOhlcProperty> low(IEnumerable<IEnumerable<int>> values) => Interop.mkOhlcAttr("low", Bindings.flatten2DArrayIf1D(values));
        /// Sets the low values.
        public static Box<IOhlcProperty> low(List<int[]> values) => Interop.mkOhlcAttr("low", Bindings.flatten2DArrayIf1D(values));
        /// Sets the low values.
        public static Box<IOhlcProperty> low(params int[][] values) => Interop.mkOhlcAttr("low", Bindings.flatten2DArrayIf1D(values));
        /// Sets the low values.
        public static Box<IOhlcProperty> low(IEnumerable<IEnumerable<float>> values) => Interop.mkOhlcAttr("low", Bindings.flatten2DArrayIf1D(values));
        /// Sets the low values.
        public static Box<IOhlcProperty> low(List<float[]> values) => Interop.mkOhlcAttr("low", Bindings.flatten2DArrayIf1D(values));
        /// Sets the low values.
        public static Box<IOhlcProperty> low(params float[][] values) => Interop.mkOhlcAttr("low", Bindings.flatten2DArrayIf1D(values));
        /// Sets the low values.
        public static Box<IOhlcProperty> low(Literals.PlotData[] values) => Interop.mkOhlcAttr("low", values);
        /// Sets the low values.
        public static Box<IOhlcProperty> low(IEnumerable<bool?> values) => Interop.mkOhlcAttr("low", values.ToArray());
        /// Sets the low values.
        public static Box<IOhlcProperty> low(IEnumerable<System.DateTime?> values) => Interop.mkOhlcAttr("low", values.ToArray());
        /// Sets the low values.
        public static Box<IOhlcProperty> low(IEnumerable<int?> values) => Interop.mkOhlcAttr("low", values.ToArray());
        /// Sets the low values.
        public static Box<IOhlcProperty> low(IEnumerable<float?> values) => Interop.mkOhlcAttr("low", values.ToArray());
        /// Sets the close values.
        public static Box<IOhlcProperty> close(bool val) => Interop.mkOhlcAttr("close", new[]{val});
        /// Sets the close values.
        public static Box<IOhlcProperty> close(params bool[] values) => Interop.mkOhlcAttr("close", values);
        /// Sets the close values.
        public static Box<IOhlcProperty> close(System.DateTime val) => Interop.mkOhlcAttr("close", new[]{val});
        /// Sets the close values.
        public static Box<IOhlcProperty> close(params System.DateTime[] values) => Interop.mkOhlcAttr("close", values);
        /// Sets the close values.
        public static Box<IOhlcProperty> close(float val) => Interop.mkOhlcAttr("close", new[]{val});
        /// Sets the close values.
        public static Box<IOhlcProperty> close(params float[] values) => Interop.mkOhlcAttr("close", values);
        /// Sets the close values.
        public static Box<IOhlcProperty> close(int val) => Interop.mkOhlcAttr("close", new[]{val});
        /// Sets the close values.
        public static Box<IOhlcProperty> close(params int[] values) => Interop.mkOhlcAttr("close", values);
        /// Sets the close values.
        public static Box<IOhlcProperty> close(string val) => Interop.mkOhlcAttr("close", new[]{val});
        /// Sets the close values.
        public static Box<IOhlcProperty> close(params string[] values) => Interop.mkOhlcAttr("close", values);
        /// Sets the close values.
        public static Box<IOhlcProperty> close(IEnumerable<bool[]> values) => Interop.mkOhlcAttr("close", Bindings.flatten2DArrayIf1D(values));
        /// Sets the close values.
        public static Box<IOhlcProperty> close(List<bool[]> values) => Interop.mkOhlcAttr("close", Bindings.flatten2DArrayIf1D(values));
        /// Sets the close values.
        public static Box<IOhlcProperty> close(params bool[][] values) => Interop.mkOhlcAttr("close", Bindings.flatten2DArrayIf1D(values));
        /// Sets the close values.
        public static Box<IOhlcProperty> close(IEnumerable<IEnumerable<string>> values) => Interop.mkOhlcAttr("close", Bindings.flatten2DArrayIf1D(values));
        /// Sets the close values.
        public static Box<IOhlcProperty> close(List<string[]> values) => Interop.mkOhlcAttr("close", Bindings.flatten2DArrayIf1D(values));
        /// Sets the close values.
        public static Box<IOhlcProperty> close(params string[][] values) => Interop.mkOhlcAttr("close", Bindings.flatten2DArrayIf1D(values));
        /// Sets the close values.
        public static Box<IOhlcProperty> close(IEnumerable<IEnumerable<int>> values) => Interop.mkOhlcAttr("close", Bindings.flatten2DArrayIf1D(values));
        /// Sets the close values.
        public static Box<IOhlcProperty> close(List<int[]> values) => Interop.mkOhlcAttr("close", Bindings.flatten2DArrayIf1D(values));
        /// Sets the close values.
        public static Box<IOhlcProperty> close(params int[][] values) => Interop.mkOhlcAttr("close", Bindings.flatten2DArrayIf1D(values));
        /// Sets the close values.
        public static Box<IOhlcProperty> close(IEnumerable<IEnumerable<float>> values) => Interop.mkOhlcAttr("close", Bindings.flatten2DArrayIf1D(values));
        /// Sets the close values.
        public static Box<IOhlcProperty> close(List<float[]> values) => Interop.mkOhlcAttr("close", Bindings.flatten2DArrayIf1D(values));
        /// Sets the close values.
        public static Box<IOhlcProperty> close(params float[][] values) => Interop.mkOhlcAttr("close", Bindings.flatten2DArrayIf1D(values));
        /// Sets the close values.
        public static Box<IOhlcProperty> close(Literals.PlotData[] values) => Interop.mkOhlcAttr("close", values);
        /// Sets the close values.
        public static Box<IOhlcProperty> close(IEnumerable<bool?> values) => Interop.mkOhlcAttr("close", values.ToArray());
        /// Sets the close values.
        public static Box<IOhlcProperty> close(IEnumerable<System.DateTime?> values) => Interop.mkOhlcAttr("close", values.ToArray());
        /// Sets the close values.
        public static Box<IOhlcProperty> close(IEnumerable<int?> values) => Interop.mkOhlcAttr("close", values.ToArray());
        /// Sets the close values.
        public static Box<IOhlcProperty> close(IEnumerable<float?> values) => Interop.mkOhlcAttr("close", values.ToArray());
        public static Box<IOhlcProperty> line(params Box<ILineProperty>[] properties) => Interop.mkOhlcAttr("line", Bindings.flattenProperties(properties));
        public static Box<IOhlcProperty> increasing(params Box<IIncreasingProperty>[] properties) => Interop.mkOhlcAttr("increasing", Bindings.flattenProperties(properties));
        public static Box<IOhlcProperty> decreasing(params Box<IDecreasingProperty>[] properties) => Interop.mkOhlcAttr("decreasing", Bindings.flattenProperties(properties));
        /// Sets hover text elements associated with each sample point. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to this trace's sample points.
        public static Box<IOhlcProperty> text(string val) => Interop.mkOhlcAttr("text", val);
        /// Sets hover text elements associated with each sample point. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to this trace's sample points.
        public static Box<IOhlcProperty> text(IEnumerable<string> values) => Interop.mkOhlcAttr("text", values.ToArray());
        /// Same as `text`.
        public static Box<IOhlcProperty> hovertext(string val) => Interop.mkOhlcAttr("hovertext", val);
        /// Same as `text`.
        public static Box<IOhlcProperty> hovertext(IEnumerable<string> values) => Interop.mkOhlcAttr("hovertext", values.ToArray());
        /// Sets the width of the open/close tick marks relative to the *x* minimal interval.
        public static Box<IOhlcProperty> tickwidth(int val) => Interop.mkOhlcAttr("tickwidth", val);
        /// Sets the width of the open/close tick marks relative to the *x* minimal interval.
        public static Box<IOhlcProperty> tickwidth(float val) => Interop.mkOhlcAttr("tickwidth", val);
        public static Box<IOhlcProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkOhlcAttr("hoverlabel", Bindings.flattenProperties(properties));
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IOhlcProperty> xaxis(int anchorId) => Interop.mkOhlcAttr("xaxis", anchorId > 1 ? $"x{anchorId}" : "");
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IOhlcProperty> xaxis(string val) => Interop.mkOhlcAttr("xaxis", val);
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IOhlcProperty> yaxis(int anchorId) => Interop.mkOhlcAttr("yaxis", anchorId > 1 ? $"y{anchorId}" : "");
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IOhlcProperty> yaxis(string val) => Interop.mkOhlcAttr("yaxis", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IOhlcProperty> idssrc(string val) => Interop.mkOhlcAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IOhlcProperty> customdatasrc(string val) => Interop.mkOhlcAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IOhlcProperty> metasrc(string val) => Interop.mkOhlcAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IOhlcProperty> hoverinfosrc(string val) => Interop.mkOhlcAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  x .
        public static Box<IOhlcProperty> xsrc(string val) => Interop.mkOhlcAttr("xsrc", val);
        /// Sets the source reference on plot.ly for  open .
        public static Box<IOhlcProperty> opensrc(string val) => Interop.mkOhlcAttr("opensrc", val);
        /// Sets the source reference on plot.ly for  high .
        public static Box<IOhlcProperty> highsrc(string val) => Interop.mkOhlcAttr("highsrc", val);
        /// Sets the source reference on plot.ly for  low .
        public static Box<IOhlcProperty> lowsrc(string val) => Interop.mkOhlcAttr("lowsrc", val);
        /// Sets the source reference on plot.ly for  close .
        public static Box<IOhlcProperty> closesrc(string val) => Interop.mkOhlcAttr("closesrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IOhlcProperty> textsrc(string val) => Interop.mkOhlcAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IOhlcProperty> hovertextsrc(string val) => Interop.mkOhlcAttr("hovertextsrc", val);
    }

    public static partial class Ohlc
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IOhlcProperty> legendonly() => Interop.mkOhlcAttr("visible", "legendonly");
            public static Box<IOhlcProperty> _false() => Interop.mkOhlcAttr("visible", false);
            public static Box<IOhlcProperty> _true() => Interop.mkOhlcAttr("visible", true);
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IOhlcProperty> all() => Interop.mkOhlcAttr("hoverinfo", "all");
            public static Box<IOhlcProperty> none() => Interop.mkOhlcAttr("hoverinfo", "none");
            public static Box<IOhlcProperty> skip() => Interop.mkOhlcAttr("hoverinfo", "skip");
            public static Box<IOhlcProperty> name() => Interop.mkOhlcAttr("hoverinfo", "name");
            public static Box<IOhlcProperty> text() => Interop.mkOhlcAttr("hoverinfo", "text");
            public static Box<IOhlcProperty> x() => Interop.mkOhlcAttr("hoverinfo", "x");
            public static Box<IOhlcProperty> y() => Interop.mkOhlcAttr("hoverinfo", "y");
            public static Box<IOhlcProperty> z() => Interop.mkOhlcAttr("hoverinfo", "z");
        }

        /// Sets the calendar system to use with `x` date data.
        public static partial class Xcalendar
        {
            public static Box<IOhlcProperty> chinese() => Interop.mkOhlcAttr("xcalendar", "chinese");
            public static Box<IOhlcProperty> coptic() => Interop.mkOhlcAttr("xcalendar", "coptic");
            public static Box<IOhlcProperty> discworld() => Interop.mkOhlcAttr("xcalendar", "discworld");
            public static Box<IOhlcProperty> ethiopian() => Interop.mkOhlcAttr("xcalendar", "ethiopian");
            public static Box<IOhlcProperty> gregorian() => Interop.mkOhlcAttr("xcalendar", "gregorian");
            public static Box<IOhlcProperty> hebrew() => Interop.mkOhlcAttr("xcalendar", "hebrew");
            public static Box<IOhlcProperty> islamic() => Interop.mkOhlcAttr("xcalendar", "islamic");
            public static Box<IOhlcProperty> jalali() => Interop.mkOhlcAttr("xcalendar", "jalali");
            public static Box<IOhlcProperty> julian() => Interop.mkOhlcAttr("xcalendar", "julian");
            public static Box<IOhlcProperty> mayan() => Interop.mkOhlcAttr("xcalendar", "mayan");
            public static Box<IOhlcProperty> nanakshahi() => Interop.mkOhlcAttr("xcalendar", "nanakshahi");
            public static Box<IOhlcProperty> nepali() => Interop.mkOhlcAttr("xcalendar", "nepali");
            public static Box<IOhlcProperty> persian() => Interop.mkOhlcAttr("xcalendar", "persian");
            public static Box<IOhlcProperty> taiwan() => Interop.mkOhlcAttr("xcalendar", "taiwan");
            public static Box<IOhlcProperty> thai() => Interop.mkOhlcAttr("xcalendar", "thai");
            public static Box<IOhlcProperty> ummalqura() => Interop.mkOhlcAttr("xcalendar", "ummalqura");
        }
    }
}