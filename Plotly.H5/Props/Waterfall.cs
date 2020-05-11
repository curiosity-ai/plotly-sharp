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

    public static partial class Waterfall
    {
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IWaterfallProperty> showlegend(bool val) => Interop.mkWaterfallAttr("showlegend", val);
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IWaterfallProperty> legendgroup(string val) => Interop.mkWaterfallAttr("legendgroup", val);
        /// Sets the opacity of the trace.
        public static Box<IWaterfallProperty> opacity(int val) => Interop.mkWaterfallAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<IWaterfallProperty> opacity(float val) => Interop.mkWaterfallAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IWaterfallProperty> name(string val) => Interop.mkWaterfallAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IWaterfallProperty> uid(string val) => Interop.mkWaterfallAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IWaterfallProperty> ids(bool val) => Interop.mkWaterfallAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IWaterfallProperty> ids(params bool[] values) => Interop.mkWaterfallAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IWaterfallProperty> ids(System.DateTime val) => Interop.mkWaterfallAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IWaterfallProperty> ids(params System.DateTime[] values) => Interop.mkWaterfallAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IWaterfallProperty> ids(float val) => Interop.mkWaterfallAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IWaterfallProperty> ids(params float[] values) => Interop.mkWaterfallAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IWaterfallProperty> ids(int val) => Interop.mkWaterfallAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IWaterfallProperty> ids(params int[] values) => Interop.mkWaterfallAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IWaterfallProperty> ids(string val) => Interop.mkWaterfallAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IWaterfallProperty> ids(params string[] values) => Interop.mkWaterfallAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IWaterfallProperty> ids(IEnumerable<bool[]> values) => Interop.mkWaterfallAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IWaterfallProperty> ids(List<bool[]> values) => Interop.mkWaterfallAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IWaterfallProperty> ids(params bool[][] values) => Interop.mkWaterfallAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IWaterfallProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkWaterfallAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IWaterfallProperty> ids(List<string[]> values) => Interop.mkWaterfallAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IWaterfallProperty> ids(params string[][] values) => Interop.mkWaterfallAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IWaterfallProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkWaterfallAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IWaterfallProperty> ids(List<int[]> values) => Interop.mkWaterfallAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IWaterfallProperty> ids(params int[][] values) => Interop.mkWaterfallAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IWaterfallProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkWaterfallAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IWaterfallProperty> ids(List<float[]> values) => Interop.mkWaterfallAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IWaterfallProperty> ids(params float[][] values) => Interop.mkWaterfallAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IWaterfallProperty> ids(Literals.PlotData[] values) => Interop.mkWaterfallAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IWaterfallProperty> ids(IEnumerable<bool?> values) => Interop.mkWaterfallAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IWaterfallProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkWaterfallAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IWaterfallProperty> ids(IEnumerable<int?> values) => Interop.mkWaterfallAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IWaterfallProperty> ids(IEnumerable<float?> values) => Interop.mkWaterfallAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IWaterfallProperty> customdata(bool val) => Interop.mkWaterfallAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IWaterfallProperty> customdata(params bool[] values) => Interop.mkWaterfallAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IWaterfallProperty> customdata(System.DateTime val) => Interop.mkWaterfallAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IWaterfallProperty> customdata(params System.DateTime[] values) => Interop.mkWaterfallAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IWaterfallProperty> customdata(float val) => Interop.mkWaterfallAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IWaterfallProperty> customdata(params float[] values) => Interop.mkWaterfallAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IWaterfallProperty> customdata(int val) => Interop.mkWaterfallAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IWaterfallProperty> customdata(params int[] values) => Interop.mkWaterfallAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IWaterfallProperty> customdata(string val) => Interop.mkWaterfallAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IWaterfallProperty> customdata(params string[] values) => Interop.mkWaterfallAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IWaterfallProperty> customdata(IEnumerable<bool[]> values) => Interop.mkWaterfallAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IWaterfallProperty> customdata(List<bool[]> values) => Interop.mkWaterfallAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IWaterfallProperty> customdata(params bool[][] values) => Interop.mkWaterfallAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IWaterfallProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkWaterfallAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IWaterfallProperty> customdata(List<string[]> values) => Interop.mkWaterfallAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IWaterfallProperty> customdata(params string[][] values) => Interop.mkWaterfallAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IWaterfallProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkWaterfallAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IWaterfallProperty> customdata(List<int[]> values) => Interop.mkWaterfallAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IWaterfallProperty> customdata(params int[][] values) => Interop.mkWaterfallAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IWaterfallProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkWaterfallAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IWaterfallProperty> customdata(List<float[]> values) => Interop.mkWaterfallAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IWaterfallProperty> customdata(params float[][] values) => Interop.mkWaterfallAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IWaterfallProperty> customdata(Literals.PlotData[] values) => Interop.mkWaterfallAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IWaterfallProperty> customdata(IEnumerable<bool?> values) => Interop.mkWaterfallAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IWaterfallProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkWaterfallAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IWaterfallProperty> customdata(IEnumerable<int?> values) => Interop.mkWaterfallAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IWaterfallProperty> customdata(IEnumerable<float?> values) => Interop.mkWaterfallAttr("customdata", values.ToArray());
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IWaterfallProperty> selectedpoints(bool val) => Interop.mkWaterfallAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IWaterfallProperty> selectedpoints(params bool[] values) => Interop.mkWaterfallAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IWaterfallProperty> selectedpoints(System.DateTime val) => Interop.mkWaterfallAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IWaterfallProperty> selectedpoints(params System.DateTime[] values) => Interop.mkWaterfallAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IWaterfallProperty> selectedpoints(int val) => Interop.mkWaterfallAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IWaterfallProperty> selectedpoints(params int[] values) => Interop.mkWaterfallAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IWaterfallProperty> selectedpoints(float val) => Interop.mkWaterfallAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IWaterfallProperty> selectedpoints(params float[] values) => Interop.mkWaterfallAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IWaterfallProperty> selectedpoints(string val) => Interop.mkWaterfallAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IWaterfallProperty> selectedpoints(params string[] values) => Interop.mkWaterfallAttr("selectedpoints", values);
        public static Box<IWaterfallProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkWaterfallAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IWaterfallProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkWaterfallAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IWaterfallProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkWaterfallAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IWaterfallProperty> uirevision(bool val) => Interop.mkWaterfallAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IWaterfallProperty> uirevision(params bool[] values) => Interop.mkWaterfallAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IWaterfallProperty> uirevision(System.DateTime val) => Interop.mkWaterfallAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IWaterfallProperty> uirevision(params System.DateTime[] values) => Interop.mkWaterfallAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IWaterfallProperty> uirevision(int val) => Interop.mkWaterfallAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IWaterfallProperty> uirevision(params int[] values) => Interop.mkWaterfallAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IWaterfallProperty> uirevision(float val) => Interop.mkWaterfallAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IWaterfallProperty> uirevision(params float[] values) => Interop.mkWaterfallAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IWaterfallProperty> uirevision(string val) => Interop.mkWaterfallAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IWaterfallProperty> uirevision(params string[] values) => Interop.mkWaterfallAttr("uirevision", values);
        /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
        public static Box<IWaterfallProperty> measure(bool val) => Interop.mkWaterfallAttr("measure", new[]{val});
        /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
        public static Box<IWaterfallProperty> measure(params bool[] values) => Interop.mkWaterfallAttr("measure", values);
        /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
        public static Box<IWaterfallProperty> measure(System.DateTime val) => Interop.mkWaterfallAttr("measure", new[]{val});
        /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
        public static Box<IWaterfallProperty> measure(params System.DateTime[] values) => Interop.mkWaterfallAttr("measure", values);
        /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
        public static Box<IWaterfallProperty> measure(float val) => Interop.mkWaterfallAttr("measure", new[]{val});
        /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
        public static Box<IWaterfallProperty> measure(params float[] values) => Interop.mkWaterfallAttr("measure", values);
        /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
        public static Box<IWaterfallProperty> measure(int val) => Interop.mkWaterfallAttr("measure", new[]{val});
        /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
        public static Box<IWaterfallProperty> measure(params int[] values) => Interop.mkWaterfallAttr("measure", values);
        /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
        public static Box<IWaterfallProperty> measure(string val) => Interop.mkWaterfallAttr("measure", new[]{val});
        /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
        public static Box<IWaterfallProperty> measure(params string[] values) => Interop.mkWaterfallAttr("measure", values);
        /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
        public static Box<IWaterfallProperty> measure(IEnumerable<bool[]> values) => Interop.mkWaterfallAttr("measure", Bindings.flatten2DArrayIf1D(values));
        /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
        public static Box<IWaterfallProperty> measure(List<bool[]> values) => Interop.mkWaterfallAttr("measure", Bindings.flatten2DArrayIf1D(values));
        /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
        public static Box<IWaterfallProperty> measure(params bool[][] values) => Interop.mkWaterfallAttr("measure", Bindings.flatten2DArrayIf1D(values));
        /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
        public static Box<IWaterfallProperty> measure(IEnumerable<IEnumerable<string>> values) => Interop.mkWaterfallAttr("measure", Bindings.flatten2DArrayIf1D(values));
        /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
        public static Box<IWaterfallProperty> measure(List<string[]> values) => Interop.mkWaterfallAttr("measure", Bindings.flatten2DArrayIf1D(values));
        /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
        public static Box<IWaterfallProperty> measure(params string[][] values) => Interop.mkWaterfallAttr("measure", Bindings.flatten2DArrayIf1D(values));
        /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
        public static Box<IWaterfallProperty> measure(IEnumerable<IEnumerable<int>> values) => Interop.mkWaterfallAttr("measure", Bindings.flatten2DArrayIf1D(values));
        /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
        public static Box<IWaterfallProperty> measure(List<int[]> values) => Interop.mkWaterfallAttr("measure", Bindings.flatten2DArrayIf1D(values));
        /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
        public static Box<IWaterfallProperty> measure(params int[][] values) => Interop.mkWaterfallAttr("measure", Bindings.flatten2DArrayIf1D(values));
        /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
        public static Box<IWaterfallProperty> measure(IEnumerable<IEnumerable<float>> values) => Interop.mkWaterfallAttr("measure", Bindings.flatten2DArrayIf1D(values));
        /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
        public static Box<IWaterfallProperty> measure(List<float[]> values) => Interop.mkWaterfallAttr("measure", Bindings.flatten2DArrayIf1D(values));
        /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
        public static Box<IWaterfallProperty> measure(params float[][] values) => Interop.mkWaterfallAttr("measure", Bindings.flatten2DArrayIf1D(values));
        /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
        public static Box<IWaterfallProperty> measure(Literals.PlotData[] values) => Interop.mkWaterfallAttr("measure", values);
        /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
        public static Box<IWaterfallProperty> measure(IEnumerable<bool?> values) => Interop.mkWaterfallAttr("measure", values.ToArray());
        /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
        public static Box<IWaterfallProperty> measure(IEnumerable<System.DateTime?> values) => Interop.mkWaterfallAttr("measure", values.ToArray());
        /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
        public static Box<IWaterfallProperty> measure(IEnumerable<int?> values) => Interop.mkWaterfallAttr("measure", values.ToArray());
        /// An array containing types of values. By default the values are considered as 'relative'. However; it is possible to use 'total' to compute the sums. Also 'absolute' could be applied to reset the computed total or to declare an initial value where needed.
        public static Box<IWaterfallProperty> measure(IEnumerable<float?> values) => Interop.mkWaterfallAttr("measure", values.ToArray());
        /// Sets where the bar base is drawn (in position axis units).
        public static Box<IWaterfallProperty> _base(int val) => Interop.mkWaterfallAttr("base", val);
        /// Sets where the bar base is drawn (in position axis units).
        public static Box<IWaterfallProperty> _base(float val) => Interop.mkWaterfallAttr("base", val);
        /// Sets the x coordinates.
        public static Box<IWaterfallProperty> x(bool val) => Interop.mkWaterfallAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IWaterfallProperty> x(IEnumerable<bool> values) => Interop.mkWaterfallAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IWaterfallProperty> x(System.DateTime val) => Interop.mkWaterfallAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IWaterfallProperty> x(IEnumerable<System.DateTime> values) => Interop.mkWaterfallAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IWaterfallProperty> x(float val) => Interop.mkWaterfallAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IWaterfallProperty> x(IEnumerable<float> values) => Interop.mkWaterfallAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IWaterfallProperty> x(int val) => Interop.mkWaterfallAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IWaterfallProperty> x(IEnumerable<int> values) => Interop.mkWaterfallAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IWaterfallProperty> x(string val) => Interop.mkWaterfallAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IWaterfallProperty> x(IEnumerable<string> values) => Interop.mkWaterfallAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IWaterfallProperty> x(IEnumerable<bool[]> values) => Interop.mkWaterfallAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IWaterfallProperty> x(List<bool[]> values) => Interop.mkWaterfallAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IWaterfallProperty> x(params bool[][] values) => Interop.mkWaterfallAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IWaterfallProperty> x(IEnumerable<IEnumerable<string>> values) => Interop.mkWaterfallAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IWaterfallProperty> x(List<string[]> values) => Interop.mkWaterfallAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IWaterfallProperty> x(params string[][] values) => Interop.mkWaterfallAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IWaterfallProperty> x(IEnumerable<IEnumerable<int>> values) => Interop.mkWaterfallAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IWaterfallProperty> x(List<int[]> values) => Interop.mkWaterfallAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IWaterfallProperty> x(params int[][] values) => Interop.mkWaterfallAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IWaterfallProperty> x(IEnumerable<IEnumerable<float>> values) => Interop.mkWaterfallAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IWaterfallProperty> x(List<float[]> values) => Interop.mkWaterfallAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IWaterfallProperty> x(params float[][] values) => Interop.mkWaterfallAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IWaterfallProperty> x(Literals.PlotData[] values) => Interop.mkWaterfallAttr("x", values);
        /// Sets the x coordinates.
        public static Box<IWaterfallProperty> x(IEnumerable<bool?> values) => Interop.mkWaterfallAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IWaterfallProperty> x(IEnumerable<System.DateTime?> values) => Interop.mkWaterfallAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IWaterfallProperty> x(IEnumerable<int?> values) => Interop.mkWaterfallAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IWaterfallProperty> x(IEnumerable<float?> values) => Interop.mkWaterfallAttr("x", values.ToArray());
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IWaterfallProperty> x0(bool val) => Interop.mkWaterfallAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IWaterfallProperty> x0(params bool[] values) => Interop.mkWaterfallAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IWaterfallProperty> x0(System.DateTime val) => Interop.mkWaterfallAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IWaterfallProperty> x0(params System.DateTime[] values) => Interop.mkWaterfallAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IWaterfallProperty> x0(int val) => Interop.mkWaterfallAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IWaterfallProperty> x0(params int[] values) => Interop.mkWaterfallAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IWaterfallProperty> x0(float val) => Interop.mkWaterfallAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IWaterfallProperty> x0(params float[] values) => Interop.mkWaterfallAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IWaterfallProperty> x0(string val) => Interop.mkWaterfallAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IWaterfallProperty> x0(params string[] values) => Interop.mkWaterfallAttr("x0", values);
        /// Sets the x coordinate step. See `x0` for more info.
        public static Box<IWaterfallProperty> dx(int val) => Interop.mkWaterfallAttr("dx", val);
        /// Sets the x coordinate step. See `x0` for more info.
        public static Box<IWaterfallProperty> dx(float val) => Interop.mkWaterfallAttr("dx", val);
        /// Sets the y coordinates.
        public static Box<IWaterfallProperty> y(bool val) => Interop.mkWaterfallAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IWaterfallProperty> y(IEnumerable<bool> values) => Interop.mkWaterfallAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IWaterfallProperty> y(System.DateTime val) => Interop.mkWaterfallAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IWaterfallProperty> y(IEnumerable<System.DateTime> values) => Interop.mkWaterfallAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IWaterfallProperty> y(float val) => Interop.mkWaterfallAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IWaterfallProperty> y(IEnumerable<float> values) => Interop.mkWaterfallAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IWaterfallProperty> y(int val) => Interop.mkWaterfallAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IWaterfallProperty> y(IEnumerable<int> values) => Interop.mkWaterfallAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IWaterfallProperty> y(string val) => Interop.mkWaterfallAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IWaterfallProperty> y(IEnumerable<string> values) => Interop.mkWaterfallAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IWaterfallProperty> y(IEnumerable<bool[]> values) => Interop.mkWaterfallAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IWaterfallProperty> y(List<bool[]> values) => Interop.mkWaterfallAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IWaterfallProperty> y(params bool[][] values) => Interop.mkWaterfallAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IWaterfallProperty> y(IEnumerable<IEnumerable<string>> values) => Interop.mkWaterfallAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IWaterfallProperty> y(List<string[]> values) => Interop.mkWaterfallAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IWaterfallProperty> y(params string[][] values) => Interop.mkWaterfallAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IWaterfallProperty> y(IEnumerable<IEnumerable<int>> values) => Interop.mkWaterfallAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IWaterfallProperty> y(List<int[]> values) => Interop.mkWaterfallAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IWaterfallProperty> y(params int[][] values) => Interop.mkWaterfallAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IWaterfallProperty> y(IEnumerable<IEnumerable<float>> values) => Interop.mkWaterfallAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IWaterfallProperty> y(List<float[]> values) => Interop.mkWaterfallAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IWaterfallProperty> y(params float[][] values) => Interop.mkWaterfallAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IWaterfallProperty> y(Literals.PlotData[] values) => Interop.mkWaterfallAttr("y", values);
        /// Sets the y coordinates.
        public static Box<IWaterfallProperty> y(IEnumerable<bool?> values) => Interop.mkWaterfallAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IWaterfallProperty> y(IEnumerable<System.DateTime?> values) => Interop.mkWaterfallAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IWaterfallProperty> y(IEnumerable<int?> values) => Interop.mkWaterfallAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IWaterfallProperty> y(IEnumerable<float?> values) => Interop.mkWaterfallAttr("y", values.ToArray());
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IWaterfallProperty> y0(bool val) => Interop.mkWaterfallAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IWaterfallProperty> y0(params bool[] values) => Interop.mkWaterfallAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IWaterfallProperty> y0(System.DateTime val) => Interop.mkWaterfallAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IWaterfallProperty> y0(params System.DateTime[] values) => Interop.mkWaterfallAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IWaterfallProperty> y0(int val) => Interop.mkWaterfallAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IWaterfallProperty> y0(params int[] values) => Interop.mkWaterfallAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IWaterfallProperty> y0(float val) => Interop.mkWaterfallAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IWaterfallProperty> y0(params float[] values) => Interop.mkWaterfallAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IWaterfallProperty> y0(string val) => Interop.mkWaterfallAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IWaterfallProperty> y0(params string[] values) => Interop.mkWaterfallAttr("y0", values);
        /// Sets the y coordinate step. See `y0` for more info.
        public static Box<IWaterfallProperty> dy(int val) => Interop.mkWaterfallAttr("dy", val);
        /// Sets the y coordinate step. See `y0` for more info.
        public static Box<IWaterfallProperty> dy(float val) => Interop.mkWaterfallAttr("dy", val);
        /// Sets hover text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IWaterfallProperty> hovertext(string val) => Interop.mkWaterfallAttr("hovertext", val);
        /// Sets hover text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IWaterfallProperty> hovertext(IEnumerable<string> values) => Interop.mkWaterfallAttr("hovertext", values.ToArray());
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `initial`, `delta` and `final`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IWaterfallProperty> hovertemplate(string val) => Interop.mkWaterfallAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `initial`, `delta` and `final`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IWaterfallProperty> hovertemplate(IEnumerable<string> values) => Interop.mkWaterfallAttr("hovertemplate", values.ToArray());
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IWaterfallProperty> hoverinfo(params Box<IWaterfallProperty>[] properties) => Interop.mkWaterfallAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        /// Determines which trace information appear on the graph. In the case of having multiple waterfalls, totals are computed separately (per trace).
        public static Box<IWaterfallProperty> textinfo(params Box<IWaterfallProperty>[] properties) => Interop.mkWaterfallAttr("textinfo", Bindings.joinEnumProperties(properties));
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `initial`, `delta`, `final` and `label`.
        public static Box<IWaterfallProperty> texttemplate(string val) => Interop.mkWaterfallAttr("texttemplate", val);
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `initial`, `delta`, `final` and `label`.
        public static Box<IWaterfallProperty> texttemplate(IEnumerable<string> values) => Interop.mkWaterfallAttr("texttemplate", values.ToArray());
        /// Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IWaterfallProperty> text(string val) => Interop.mkWaterfallAttr("text", val);
        /// Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IWaterfallProperty> text(IEnumerable<string> values) => Interop.mkWaterfallAttr("text", values.ToArray());
        /// Specifies the location of the `text`. *inside* positions `text` inside, next to the bar end (rotated and scaled if needed). *outside* positions `text` outside, next to the bar end (scaled if needed), unless there is another bar stacked on this one, then the text gets pushed inside. *auto* tries to position `text` inside the bar, but if the bar is too small and no bar is stacked on this one the text is moved outside.
        public static Box<IWaterfallProperty> textposition(IEnumerable<Box<IWaterfallProperty>> properties) => Interop.mkWaterfallAttr("textposition", Bindings.flattenProperties(properties));
        /// Sets the angle of the tick labels with respect to the bar. For example, a `tickangle` of -90 draws the tick labels vertically. With *auto* the texts may automatically be rotated to fit with the maximum size in bars.
        public static Box<IWaterfallProperty> textangle(int val) => Interop.mkWaterfallAttr("textangle", val);
        /// Sets the angle of the tick labels with respect to the bar. For example, a `tickangle` of -90 draws the tick labels vertically. With *auto* the texts may automatically be rotated to fit with the maximum size in bars.
        public static Box<IWaterfallProperty> textangle(float val) => Interop.mkWaterfallAttr("textangle", val);
        /// Sets the font used for `text`.
        public static Box<IWaterfallProperty> textfont(params Box<ITextfontProperty>[] properties) => Interop.mkWaterfallAttr("textfont", Bindings.flattenProperties(properties));
        /// Sets the font used for `text` lying inside the bar.
        public static Box<IWaterfallProperty> insidetextfont(params Box<IInsidetextfontProperty>[] properties) => Interop.mkWaterfallAttr("insidetextfont", Bindings.flattenProperties(properties));
        /// Sets the font used for `text` lying outside the bar.
        public static Box<IWaterfallProperty> outsidetextfont(params Box<IOutsidetextfontProperty>[] properties) => Interop.mkWaterfallAttr("outsidetextfont", Bindings.flattenProperties(properties));
        /// Determines whether the text nodes are clipped about the subplot axes. To show the text nodes above axis lines and tick labels, make sure to set `xaxis.layer` and `yaxis.layer` to *below traces*.
        public static Box<IWaterfallProperty> cliponaxis(bool val) => Interop.mkWaterfallAttr("cliponaxis", val);
        /// Shifts the position where the bar is drawn (in position axis units). In *group* barmode, traces that set *offset* will be excluded and drawn in *overlay* mode instead.
        public static Box<IWaterfallProperty> offset(int val) => Interop.mkWaterfallAttr("offset", val);
        /// Shifts the position where the bar is drawn (in position axis units). In *group* barmode, traces that set *offset* will be excluded and drawn in *overlay* mode instead.
        public static Box<IWaterfallProperty> offset(float val) => Interop.mkWaterfallAttr("offset", val);
        /// Shifts the position where the bar is drawn (in position axis units). In *group* barmode, traces that set *offset* will be excluded and drawn in *overlay* mode instead.
        public static Box<IWaterfallProperty> offset(IEnumerable<int> values) => Interop.mkWaterfallAttr("offset", values.ToArray());
        /// Shifts the position where the bar is drawn (in position axis units). In *group* barmode, traces that set *offset* will be excluded and drawn in *overlay* mode instead.
        public static Box<IWaterfallProperty> offset(IEnumerable<float> values) => Interop.mkWaterfallAttr("offset", values.ToArray());
        /// Sets the bar width (in position axis units).
        public static Box<IWaterfallProperty> width(int val) => Interop.mkWaterfallAttr("width", val);
        /// Sets the bar width (in position axis units).
        public static Box<IWaterfallProperty> width(float val) => Interop.mkWaterfallAttr("width", val);
        /// Sets the bar width (in position axis units).
        public static Box<IWaterfallProperty> width(IEnumerable<int> values) => Interop.mkWaterfallAttr("width", values.ToArray());
        /// Sets the bar width (in position axis units).
        public static Box<IWaterfallProperty> width(IEnumerable<float> values) => Interop.mkWaterfallAttr("width", values.ToArray());
        public static Box<IWaterfallProperty> increasing(params Box<IIncreasingProperty>[] properties) => Interop.mkWaterfallAttr("increasing", Bindings.flattenProperties(properties));
        public static Box<IWaterfallProperty> decreasing(params Box<IDecreasingProperty>[] properties) => Interop.mkWaterfallAttr("decreasing", Bindings.flattenProperties(properties));
        public static Box<IWaterfallProperty> totals(params Box<ITotalsProperty>[] properties) => Interop.mkWaterfallAttr("totals", Bindings.flattenProperties(properties));
        public static Box<IWaterfallProperty> connector(params Box<IConnectorProperty>[] properties) => Interop.mkWaterfallAttr("connector", Bindings.flattenProperties(properties));
        /// Set several traces linked to the same position axis or matching axes to the same offsetgroup where bars of the same position coordinate will line up.
        public static Box<IWaterfallProperty> offsetgroup(string val) => Interop.mkWaterfallAttr("offsetgroup", val);
        /// Set several traces linked to the same position axis or matching axes to the same alignmentgroup. This controls whether bars compute their positional range dependently or independently.
        public static Box<IWaterfallProperty> alignmentgroup(string val) => Interop.mkWaterfallAttr("alignmentgroup", val);
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IWaterfallProperty> xaxis(int anchorId) => Interop.mkWaterfallAttr("xaxis", anchorId > 1 ? $"x{anchorId}" : "");
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IWaterfallProperty> xaxis(string val) => Interop.mkWaterfallAttr("xaxis", val);
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IWaterfallProperty> yaxis(int anchorId) => Interop.mkWaterfallAttr("yaxis", anchorId > 1 ? $"y{anchorId}" : "");
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IWaterfallProperty> yaxis(string val) => Interop.mkWaterfallAttr("yaxis", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IWaterfallProperty> idssrc(string val) => Interop.mkWaterfallAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IWaterfallProperty> customdatasrc(string val) => Interop.mkWaterfallAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IWaterfallProperty> metasrc(string val) => Interop.mkWaterfallAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  measure .
        public static Box<IWaterfallProperty> measuresrc(string val) => Interop.mkWaterfallAttr("measuresrc", val);
        /// Sets the source reference on plot.ly for  x .
        public static Box<IWaterfallProperty> xsrc(string val) => Interop.mkWaterfallAttr("xsrc", val);
        /// Sets the source reference on plot.ly for  y .
        public static Box<IWaterfallProperty> ysrc(string val) => Interop.mkWaterfallAttr("ysrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IWaterfallProperty> hovertextsrc(string val) => Interop.mkWaterfallAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IWaterfallProperty> hovertemplatesrc(string val) => Interop.mkWaterfallAttr("hovertemplatesrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IWaterfallProperty> hoverinfosrc(string val) => Interop.mkWaterfallAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  texttemplate .
        public static Box<IWaterfallProperty> texttemplatesrc(string val) => Interop.mkWaterfallAttr("texttemplatesrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IWaterfallProperty> textsrc(string val) => Interop.mkWaterfallAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  textposition .
        public static Box<IWaterfallProperty> textpositionsrc(string val) => Interop.mkWaterfallAttr("textpositionsrc", val);
        /// Sets the source reference on plot.ly for  offset .
        public static Box<IWaterfallProperty> offsetsrc(string val) => Interop.mkWaterfallAttr("offsetsrc", val);
        /// Sets the source reference on plot.ly for  width .
        public static Box<IWaterfallProperty> widthsrc(string val) => Interop.mkWaterfallAttr("widthsrc", val);
    }

    public static partial class Waterfall
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IWaterfallProperty> legendonly() => Interop.mkWaterfallAttr("visible", "legendonly");
            public static Box<IWaterfallProperty> _false() => Interop.mkWaterfallAttr("visible", false);
            public static Box<IWaterfallProperty> _true() => Interop.mkWaterfallAttr("visible", true);
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IWaterfallProperty> all() => Interop.mkWaterfallAttr("hoverinfo", "all");
            public static Box<IWaterfallProperty> none() => Interop.mkWaterfallAttr("hoverinfo", "none");
            public static Box<IWaterfallProperty> skip() => Interop.mkWaterfallAttr("hoverinfo", "skip");
            public static Box<IWaterfallProperty> delta() => Interop.mkWaterfallAttr("hoverinfo", "delta");
            public static Box<IWaterfallProperty> final() => Interop.mkWaterfallAttr("hoverinfo", "final");
            public static Box<IWaterfallProperty> initial() => Interop.mkWaterfallAttr("hoverinfo", "initial");
            public static Box<IWaterfallProperty> name() => Interop.mkWaterfallAttr("hoverinfo", "name");
            public static Box<IWaterfallProperty> text() => Interop.mkWaterfallAttr("hoverinfo", "text");
            public static Box<IWaterfallProperty> x() => Interop.mkWaterfallAttr("hoverinfo", "x");
            public static Box<IWaterfallProperty> y() => Interop.mkWaterfallAttr("hoverinfo", "y");
        }

        /// Determines which trace information appear on the graph. In the case of having multiple waterfalls, totals are computed separately (per trace).
        public static partial class Textinfo
        {
            public static Box<IWaterfallProperty> none() => Interop.mkWaterfallAttr("textinfo", "none");
            public static Box<IWaterfallProperty> delta() => Interop.mkWaterfallAttr("textinfo", "delta");
            public static Box<IWaterfallProperty> final() => Interop.mkWaterfallAttr("textinfo", "final");
            public static Box<IWaterfallProperty> initial() => Interop.mkWaterfallAttr("textinfo", "initial");
            public static Box<IWaterfallProperty> label() => Interop.mkWaterfallAttr("textinfo", "label");
            public static Box<IWaterfallProperty> text() => Interop.mkWaterfallAttr("textinfo", "text");
        }

        /// Specifies the location of the `text`. *inside* positions `text` inside, next to the bar end (rotated and scaled if needed). *outside* positions `text` outside, next to the bar end (scaled if needed), unless there is another bar stacked on this one, then the text gets pushed inside. *auto* tries to position `text` inside the bar, but if the bar is too small and no bar is stacked on this one the text is moved outside.
        public static partial class Textposition
        {
            public static Box<IWaterfallProperty> auto() => Interop.mkWaterfallAttr("textposition", "auto");
            public static Box<IWaterfallProperty> inside() => Interop.mkWaterfallAttr("textposition", "inside");
            public static Box<IWaterfallProperty> none() => Interop.mkWaterfallAttr("textposition", "none");
            public static Box<IWaterfallProperty> outside() => Interop.mkWaterfallAttr("textposition", "outside");
        }

        /// Determines if texts are kept at center or start/end points in `textposition` *inside* mode.
        public static partial class Insidetextanchor
        {
            public static Box<IWaterfallProperty> _end() => Interop.mkWaterfallAttr("insidetextanchor", "end");
            public static Box<IWaterfallProperty> middle() => Interop.mkWaterfallAttr("insidetextanchor", "middle");
            public static Box<IWaterfallProperty> start() => Interop.mkWaterfallAttr("insidetextanchor", "start");
        }

        /// Constrain the size of text inside or outside a bar to be no larger than the bar itself.
        public static partial class Constraintext
        {
            public static Box<IWaterfallProperty> both() => Interop.mkWaterfallAttr("constraintext", "both");
            public static Box<IWaterfallProperty> inside() => Interop.mkWaterfallAttr("constraintext", "inside");
            public static Box<IWaterfallProperty> none() => Interop.mkWaterfallAttr("constraintext", "none");
            public static Box<IWaterfallProperty> outside() => Interop.mkWaterfallAttr("constraintext", "outside");
        }

        /// Sets the orientation of the bars. With *v* (*h*), the value of the each bar spans along the vertical (horizontal).
        public static partial class Orientation
        {
            public static Box<IWaterfallProperty> h() => Interop.mkWaterfallAttr("orientation", "h");
            public static Box<IWaterfallProperty> v() => Interop.mkWaterfallAttr("orientation", "v");
        }
    }
}