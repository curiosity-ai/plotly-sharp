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

    public static partial class Violin
    {
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IViolinProperty> showlegend(bool val) => Interop.mkViolinAttr("showlegend", val);
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IViolinProperty> legendgroup(string val) => Interop.mkViolinAttr("legendgroup", val);
        /// Sets the opacity of the trace.
        public static Box<IViolinProperty> opacity(int val) => Interop.mkViolinAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<IViolinProperty> opacity(float val) => Interop.mkViolinAttr("opacity", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IViolinProperty> uid(string val) => Interop.mkViolinAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IViolinProperty> ids(bool val) => Interop.mkViolinAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IViolinProperty> ids(params bool[] values) => Interop.mkViolinAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IViolinProperty> ids(System.DateTime val) => Interop.mkViolinAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IViolinProperty> ids(params System.DateTime[] values) => Interop.mkViolinAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IViolinProperty> ids(float val) => Interop.mkViolinAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IViolinProperty> ids(params float[] values) => Interop.mkViolinAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IViolinProperty> ids(int val) => Interop.mkViolinAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IViolinProperty> ids(params int[] values) => Interop.mkViolinAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IViolinProperty> ids(string val) => Interop.mkViolinAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IViolinProperty> ids(params string[] values) => Interop.mkViolinAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IViolinProperty> ids(IEnumerable<bool[]> values) => Interop.mkViolinAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IViolinProperty> ids(List<bool[]> values) => Interop.mkViolinAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IViolinProperty> ids(params bool[][] values) => Interop.mkViolinAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IViolinProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkViolinAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IViolinProperty> ids(List<string[]> values) => Interop.mkViolinAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IViolinProperty> ids(params string[][] values) => Interop.mkViolinAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IViolinProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkViolinAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IViolinProperty> ids(List<int[]> values) => Interop.mkViolinAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IViolinProperty> ids(params int[][] values) => Interop.mkViolinAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IViolinProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkViolinAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IViolinProperty> ids(List<float[]> values) => Interop.mkViolinAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IViolinProperty> ids(params float[][] values) => Interop.mkViolinAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IViolinProperty> ids(Literals.PlotData[] values) => Interop.mkViolinAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IViolinProperty> ids(IEnumerable<bool?> values) => Interop.mkViolinAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IViolinProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkViolinAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IViolinProperty> ids(IEnumerable<int?> values) => Interop.mkViolinAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IViolinProperty> ids(IEnumerable<float?> values) => Interop.mkViolinAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IViolinProperty> customdata(bool val) => Interop.mkViolinAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IViolinProperty> customdata(params bool[] values) => Interop.mkViolinAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IViolinProperty> customdata(System.DateTime val) => Interop.mkViolinAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IViolinProperty> customdata(params System.DateTime[] values) => Interop.mkViolinAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IViolinProperty> customdata(float val) => Interop.mkViolinAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IViolinProperty> customdata(params float[] values) => Interop.mkViolinAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IViolinProperty> customdata(int val) => Interop.mkViolinAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IViolinProperty> customdata(params int[] values) => Interop.mkViolinAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IViolinProperty> customdata(string val) => Interop.mkViolinAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IViolinProperty> customdata(params string[] values) => Interop.mkViolinAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IViolinProperty> customdata(IEnumerable<bool[]> values) => Interop.mkViolinAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IViolinProperty> customdata(List<bool[]> values) => Interop.mkViolinAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IViolinProperty> customdata(params bool[][] values) => Interop.mkViolinAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IViolinProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkViolinAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IViolinProperty> customdata(List<string[]> values) => Interop.mkViolinAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IViolinProperty> customdata(params string[][] values) => Interop.mkViolinAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IViolinProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkViolinAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IViolinProperty> customdata(List<int[]> values) => Interop.mkViolinAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IViolinProperty> customdata(params int[][] values) => Interop.mkViolinAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IViolinProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkViolinAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IViolinProperty> customdata(List<float[]> values) => Interop.mkViolinAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IViolinProperty> customdata(params float[][] values) => Interop.mkViolinAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IViolinProperty> customdata(Literals.PlotData[] values) => Interop.mkViolinAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IViolinProperty> customdata(IEnumerable<bool?> values) => Interop.mkViolinAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IViolinProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkViolinAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IViolinProperty> customdata(IEnumerable<int?> values) => Interop.mkViolinAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IViolinProperty> customdata(IEnumerable<float?> values) => Interop.mkViolinAttr("customdata", values.ToArray());
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IViolinProperty> selectedpoints(bool val) => Interop.mkViolinAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IViolinProperty> selectedpoints(params bool[] values) => Interop.mkViolinAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IViolinProperty> selectedpoints(System.DateTime val) => Interop.mkViolinAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IViolinProperty> selectedpoints(params System.DateTime[] values) => Interop.mkViolinAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IViolinProperty> selectedpoints(int val) => Interop.mkViolinAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IViolinProperty> selectedpoints(params int[] values) => Interop.mkViolinAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IViolinProperty> selectedpoints(float val) => Interop.mkViolinAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IViolinProperty> selectedpoints(params float[] values) => Interop.mkViolinAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IViolinProperty> selectedpoints(string val) => Interop.mkViolinAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IViolinProperty> selectedpoints(params string[] values) => Interop.mkViolinAttr("selectedpoints", values);
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IViolinProperty> hoverinfo(params Box<IViolinProperty>[] properties) => Interop.mkViolinAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        public static Box<IViolinProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkViolinAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IViolinProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkViolinAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IViolinProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkViolinAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IViolinProperty> uirevision(bool val) => Interop.mkViolinAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IViolinProperty> uirevision(params bool[] values) => Interop.mkViolinAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IViolinProperty> uirevision(System.DateTime val) => Interop.mkViolinAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IViolinProperty> uirevision(params System.DateTime[] values) => Interop.mkViolinAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IViolinProperty> uirevision(int val) => Interop.mkViolinAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IViolinProperty> uirevision(params int[] values) => Interop.mkViolinAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IViolinProperty> uirevision(float val) => Interop.mkViolinAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IViolinProperty> uirevision(params float[] values) => Interop.mkViolinAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IViolinProperty> uirevision(string val) => Interop.mkViolinAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IViolinProperty> uirevision(params string[] values) => Interop.mkViolinAttr("uirevision", values);
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> y(bool val) => Interop.mkViolinAttr("y", new[]{val});
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> y(IEnumerable<bool> values) => Interop.mkViolinAttr("y", values.ToArray());
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> y(System.DateTime val) => Interop.mkViolinAttr("y", new[]{val});
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> y(IEnumerable<System.DateTime> values) => Interop.mkViolinAttr("y", values.ToArray());
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> y(float val) => Interop.mkViolinAttr("y", new[]{val});
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> y(IEnumerable<float> values) => Interop.mkViolinAttr("y", values.ToArray());
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> y(int val) => Interop.mkViolinAttr("y", new[]{val});
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> y(IEnumerable<int> values) => Interop.mkViolinAttr("y", values.ToArray());
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> y(string val) => Interop.mkViolinAttr("y", new[]{val});
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> y(IEnumerable<string> values) => Interop.mkViolinAttr("y", values.ToArray());
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> y(IEnumerable<bool[]> values) => Interop.mkViolinAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> y(List<bool[]> values) => Interop.mkViolinAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> y(params bool[][] values) => Interop.mkViolinAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> y(IEnumerable<IEnumerable<string>> values) => Interop.mkViolinAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> y(List<string[]> values) => Interop.mkViolinAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> y(params string[][] values) => Interop.mkViolinAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> y(IEnumerable<IEnumerable<int>> values) => Interop.mkViolinAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> y(List<int[]> values) => Interop.mkViolinAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> y(params int[][] values) => Interop.mkViolinAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> y(IEnumerable<IEnumerable<float>> values) => Interop.mkViolinAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> y(List<float[]> values) => Interop.mkViolinAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> y(params float[][] values) => Interop.mkViolinAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> y(Literals.PlotData[] values) => Interop.mkViolinAttr("y", values);
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> y(IEnumerable<bool?> values) => Interop.mkViolinAttr("y", values.ToArray());
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> y(IEnumerable<System.DateTime?> values) => Interop.mkViolinAttr("y", values.ToArray());
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> y(IEnumerable<int?> values) => Interop.mkViolinAttr("y", values.ToArray());
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> y(IEnumerable<float?> values) => Interop.mkViolinAttr("y", values.ToArray());
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> x(bool val) => Interop.mkViolinAttr("x", new[]{val});
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> x(IEnumerable<bool> values) => Interop.mkViolinAttr("x", values.ToArray());
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> x(System.DateTime val) => Interop.mkViolinAttr("x", new[]{val});
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> x(IEnumerable<System.DateTime> values) => Interop.mkViolinAttr("x", values.ToArray());
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> x(float val) => Interop.mkViolinAttr("x", new[]{val});
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> x(IEnumerable<float> values) => Interop.mkViolinAttr("x", values.ToArray());
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> x(int val) => Interop.mkViolinAttr("x", new[]{val});
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> x(IEnumerable<int> values) => Interop.mkViolinAttr("x", values.ToArray());
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> x(string val) => Interop.mkViolinAttr("x", new[]{val});
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> x(IEnumerable<string> values) => Interop.mkViolinAttr("x", values.ToArray());
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> x(IEnumerable<bool[]> values) => Interop.mkViolinAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> x(List<bool[]> values) => Interop.mkViolinAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> x(params bool[][] values) => Interop.mkViolinAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> x(IEnumerable<IEnumerable<string>> values) => Interop.mkViolinAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> x(List<string[]> values) => Interop.mkViolinAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> x(params string[][] values) => Interop.mkViolinAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> x(IEnumerable<IEnumerable<int>> values) => Interop.mkViolinAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> x(List<int[]> values) => Interop.mkViolinAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> x(params int[][] values) => Interop.mkViolinAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> x(IEnumerable<IEnumerable<float>> values) => Interop.mkViolinAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> x(List<float[]> values) => Interop.mkViolinAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> x(params float[][] values) => Interop.mkViolinAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> x(Literals.PlotData[] values) => Interop.mkViolinAttr("x", values);
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> x(IEnumerable<bool?> values) => Interop.mkViolinAttr("x", values.ToArray());
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> x(IEnumerable<System.DateTime?> values) => Interop.mkViolinAttr("x", values.ToArray());
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> x(IEnumerable<int?> values) => Interop.mkViolinAttr("x", values.ToArray());
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IViolinProperty> x(IEnumerable<float?> values) => Interop.mkViolinAttr("x", values.ToArray());
        /// Sets the x coordinate of the box. See overview for more info.
        public static Box<IViolinProperty> x0(bool val) => Interop.mkViolinAttr("x0", val);
        /// Sets the x coordinate of the box. See overview for more info.
        public static Box<IViolinProperty> x0(params bool[] values) => Interop.mkViolinAttr("x0", values);
        /// Sets the x coordinate of the box. See overview for more info.
        public static Box<IViolinProperty> x0(System.DateTime val) => Interop.mkViolinAttr("x0", val);
        /// Sets the x coordinate of the box. See overview for more info.
        public static Box<IViolinProperty> x0(params System.DateTime[] values) => Interop.mkViolinAttr("x0", values);
        /// Sets the x coordinate of the box. See overview for more info.
        public static Box<IViolinProperty> x0(int val) => Interop.mkViolinAttr("x0", val);
        /// Sets the x coordinate of the box. See overview for more info.
        public static Box<IViolinProperty> x0(params int[] values) => Interop.mkViolinAttr("x0", values);
        /// Sets the x coordinate of the box. See overview for more info.
        public static Box<IViolinProperty> x0(float val) => Interop.mkViolinAttr("x0", val);
        /// Sets the x coordinate of the box. See overview for more info.
        public static Box<IViolinProperty> x0(params float[] values) => Interop.mkViolinAttr("x0", values);
        /// Sets the x coordinate of the box. See overview for more info.
        public static Box<IViolinProperty> x0(string val) => Interop.mkViolinAttr("x0", val);
        /// Sets the x coordinate of the box. See overview for more info.
        public static Box<IViolinProperty> x0(params string[] values) => Interop.mkViolinAttr("x0", values);
        /// Sets the y coordinate of the box. See overview for more info.
        public static Box<IViolinProperty> y0(bool val) => Interop.mkViolinAttr("y0", val);
        /// Sets the y coordinate of the box. See overview for more info.
        public static Box<IViolinProperty> y0(params bool[] values) => Interop.mkViolinAttr("y0", values);
        /// Sets the y coordinate of the box. See overview for more info.
        public static Box<IViolinProperty> y0(System.DateTime val) => Interop.mkViolinAttr("y0", val);
        /// Sets the y coordinate of the box. See overview for more info.
        public static Box<IViolinProperty> y0(params System.DateTime[] values) => Interop.mkViolinAttr("y0", values);
        /// Sets the y coordinate of the box. See overview for more info.
        public static Box<IViolinProperty> y0(int val) => Interop.mkViolinAttr("y0", val);
        /// Sets the y coordinate of the box. See overview for more info.
        public static Box<IViolinProperty> y0(params int[] values) => Interop.mkViolinAttr("y0", values);
        /// Sets the y coordinate of the box. See overview for more info.
        public static Box<IViolinProperty> y0(float val) => Interop.mkViolinAttr("y0", val);
        /// Sets the y coordinate of the box. See overview for more info.
        public static Box<IViolinProperty> y0(params float[] values) => Interop.mkViolinAttr("y0", values);
        /// Sets the y coordinate of the box. See overview for more info.
        public static Box<IViolinProperty> y0(string val) => Interop.mkViolinAttr("y0", val);
        /// Sets the y coordinate of the box. See overview for more info.
        public static Box<IViolinProperty> y0(params string[] values) => Interop.mkViolinAttr("y0", values);
        /// Sets the trace name. The trace name appear as the legend item and on hover. For violin traces, the name will also be used for the position coordinate, if `x` and `x0` (`y` and `y0` if horizontal) are missing and the position axis is categorical. Note that the trace name is also used as a default value for attribute `scalegroup` (please see its description for details).
        public static Box<IViolinProperty> name(string val) => Interop.mkViolinAttr("name", val);
        /// Sets the bandwidth used to compute the kernel density estimate. By default, the bandwidth is determined by Silverman's rule of thumb.
        public static Box<IViolinProperty> bandwidth(int val) => Interop.mkViolinAttr("bandwidth", val);
        /// Sets the bandwidth used to compute the kernel density estimate. By default, the bandwidth is determined by Silverman's rule of thumb.
        public static Box<IViolinProperty> bandwidth(float val) => Interop.mkViolinAttr("bandwidth", val);
        /// If there are multiple violins that should be sized according to to some metric (see `scalemode`), link them by providing a non-empty group id here shared by every trace in the same group. If a violin's `width` is undefined, `scalegroup` will default to the trace's name. In this case, violins with the same names will be linked together
        public static Box<IViolinProperty> scalegroup(string val) => Interop.mkViolinAttr("scalegroup", val);
        /// Sets the span in data space for which the density function will be computed. Has an effect only when `spanmode` is set to *manual*.
        public static Box<IViolinProperty> span(bool val) => Interop.mkViolinAttr("span", new[]{val});
        /// Sets the span in data space for which the density function will be computed. Has an effect only when `spanmode` is set to *manual*.
        public static Box<IViolinProperty> span(IEnumerable<bool> values) => Interop.mkViolinAttr("span", values.ToArray());
        /// Sets the span in data space for which the density function will be computed. Has an effect only when `spanmode` is set to *manual*.
        public static Box<IViolinProperty> span(System.DateTime val) => Interop.mkViolinAttr("span", new[]{val});
        /// Sets the span in data space for which the density function will be computed. Has an effect only when `spanmode` is set to *manual*.
        public static Box<IViolinProperty> span(IEnumerable<System.DateTime> values) => Interop.mkViolinAttr("span", values.ToArray());
        /// Sets the span in data space for which the density function will be computed. Has an effect only when `spanmode` is set to *manual*.
        public static Box<IViolinProperty> span(float val) => Interop.mkViolinAttr("span", new[]{val});
        /// Sets the span in data space for which the density function will be computed. Has an effect only when `spanmode` is set to *manual*.
        public static Box<IViolinProperty> span(IEnumerable<float> values) => Interop.mkViolinAttr("span", values.ToArray());
        /// Sets the span in data space for which the density function will be computed. Has an effect only when `spanmode` is set to *manual*.
        public static Box<IViolinProperty> span(int val) => Interop.mkViolinAttr("span", new[]{val});
        /// Sets the span in data space for which the density function will be computed. Has an effect only when `spanmode` is set to *manual*.
        public static Box<IViolinProperty> span(IEnumerable<int> values) => Interop.mkViolinAttr("span", values.ToArray());
        /// Sets the span in data space for which the density function will be computed. Has an effect only when `spanmode` is set to *manual*.
        public static Box<IViolinProperty> span(string val) => Interop.mkViolinAttr("span", new[]{val});
        /// Sets the span in data space for which the density function will be computed. Has an effect only when `spanmode` is set to *manual*.
        public static Box<IViolinProperty> span(IEnumerable<string> values) => Interop.mkViolinAttr("span", values.ToArray());
        public static Box<IViolinProperty> line(params Box<ILineProperty>[] properties) => Interop.mkViolinAttr("line", Bindings.flattenProperties(properties));
        /// Sets the fill color. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
        public static Box<IViolinProperty> fillcolor(string val) => Interop.mkViolinAttr("fillcolor", val);
        /// Sets the amount of jitter in the sample points drawn. If *0*, the sample points align along the distribution axis. If *1*, the sample points are drawn in a random jitter of width equal to the width of the violins.
        public static Box<IViolinProperty> jitter(int val) => Interop.mkViolinAttr("jitter", val);
        /// Sets the amount of jitter in the sample points drawn. If *0*, the sample points align along the distribution axis. If *1*, the sample points are drawn in a random jitter of width equal to the width of the violins.
        public static Box<IViolinProperty> jitter(float val) => Interop.mkViolinAttr("jitter", val);
        /// Sets the position of the sample points in relation to the violins. If *0*, the sample points are places over the center of the violins. Positive (negative) values correspond to positions to the right (left) for vertical violins and above (below) for horizontal violins.
        public static Box<IViolinProperty> pointpos(int val) => Interop.mkViolinAttr("pointpos", val);
        /// Sets the position of the sample points in relation to the violins. If *0*, the sample points are places over the center of the violins. Positive (negative) values correspond to positions to the right (left) for vertical violins and above (below) for horizontal violins.
        public static Box<IViolinProperty> pointpos(float val) => Interop.mkViolinAttr("pointpos", val);
        /// Sets the width of the violin in data coordinates. If *0* (default value) the width is automatically selected based on the positions of other violin traces in the same subplot.
        public static Box<IViolinProperty> width(int val) => Interop.mkViolinAttr("width", val);
        /// Sets the width of the violin in data coordinates. If *0* (default value) the width is automatically selected based on the positions of other violin traces in the same subplot.
        public static Box<IViolinProperty> width(float val) => Interop.mkViolinAttr("width", val);
        public static Box<IViolinProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkViolinAttr("marker", Bindings.flattenProperties(properties));
        /// Sets the text elements associated with each sample value. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IViolinProperty> text(string val) => Interop.mkViolinAttr("text", val);
        /// Sets the text elements associated with each sample value. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IViolinProperty> text(IEnumerable<string> values) => Interop.mkViolinAttr("text", values.ToArray());
        /// Same as `text`.
        public static Box<IViolinProperty> hovertext(string val) => Interop.mkViolinAttr("hovertext", val);
        /// Same as `text`.
        public static Box<IViolinProperty> hovertext(IEnumerable<string> values) => Interop.mkViolinAttr("hovertext", values.ToArray());
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IViolinProperty> hovertemplate(string val) => Interop.mkViolinAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IViolinProperty> hovertemplate(IEnumerable<string> values) => Interop.mkViolinAttr("hovertemplate", values.ToArray());
        public static Box<IViolinProperty> box(params Box<IBoxProperty>[] properties) => Interop.mkViolinAttr("box", Bindings.flattenProperties(properties));
        public static Box<IViolinProperty> meanline(params Box<IMeanlineProperty>[] properties) => Interop.mkViolinAttr("meanline", Bindings.flattenProperties(properties));
        /// Set several traces linked to the same position axis or matching axes to the same offsetgroup where bars of the same position coordinate will line up.
        public static Box<IViolinProperty> offsetgroup(string val) => Interop.mkViolinAttr("offsetgroup", val);
        /// Set several traces linked to the same position axis or matching axes to the same alignmentgroup. This controls whether bars compute their positional range dependently or independently.
        public static Box<IViolinProperty> alignmentgroup(string val) => Interop.mkViolinAttr("alignmentgroup", val);
        public static Box<IViolinProperty> selected(params Box<ISelectedProperty>[] properties) => Interop.mkViolinAttr("selected", Bindings.flattenProperties(properties));
        public static Box<IViolinProperty> unselected(params Box<IUnselectedProperty>[] properties) => Interop.mkViolinAttr("unselected", Bindings.flattenProperties(properties));
        /// Do the hover effects highlight individual violins or sample points or the kernel density estimate or any combination of them?
        public static Box<IViolinProperty> hoveron(params Box<IViolinProperty>[] properties) => Interop.mkViolinAttr("hoveron", Bindings.joinEnumProperties(properties));
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IViolinProperty> xaxis(int anchorId) => Interop.mkViolinAttr("xaxis", anchorId > 1 ? $"x{anchorId}" : "");
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IViolinProperty> xaxis(string val) => Interop.mkViolinAttr("xaxis", val);
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IViolinProperty> yaxis(int anchorId) => Interop.mkViolinAttr("yaxis", anchorId > 1 ? $"y{anchorId}" : "");
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IViolinProperty> yaxis(string val) => Interop.mkViolinAttr("yaxis", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IViolinProperty> idssrc(string val) => Interop.mkViolinAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IViolinProperty> customdatasrc(string val) => Interop.mkViolinAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IViolinProperty> metasrc(string val) => Interop.mkViolinAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IViolinProperty> hoverinfosrc(string val) => Interop.mkViolinAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  y .
        public static Box<IViolinProperty> ysrc(string val) => Interop.mkViolinAttr("ysrc", val);
        /// Sets the source reference on plot.ly for  x .
        public static Box<IViolinProperty> xsrc(string val) => Interop.mkViolinAttr("xsrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IViolinProperty> textsrc(string val) => Interop.mkViolinAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IViolinProperty> hovertextsrc(string val) => Interop.mkViolinAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IViolinProperty> hovertemplatesrc(string val) => Interop.mkViolinAttr("hovertemplatesrc", val);
    }

    public static partial class Violin
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IViolinProperty> legendonly() => Interop.mkViolinAttr("visible", "legendonly");
            public static Box<IViolinProperty> _false() => Interop.mkViolinAttr("visible", false);
            public static Box<IViolinProperty> _true() => Interop.mkViolinAttr("visible", true);
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IViolinProperty> all() => Interop.mkViolinAttr("hoverinfo", "all");
            public static Box<IViolinProperty> none() => Interop.mkViolinAttr("hoverinfo", "none");
            public static Box<IViolinProperty> skip() => Interop.mkViolinAttr("hoverinfo", "skip");
            public static Box<IViolinProperty> name() => Interop.mkViolinAttr("hoverinfo", "name");
            public static Box<IViolinProperty> text() => Interop.mkViolinAttr("hoverinfo", "text");
            public static Box<IViolinProperty> x() => Interop.mkViolinAttr("hoverinfo", "x");
            public static Box<IViolinProperty> y() => Interop.mkViolinAttr("hoverinfo", "y");
            public static Box<IViolinProperty> z() => Interop.mkViolinAttr("hoverinfo", "z");
        }

        /// Sets the orientation of the violin(s). If *v* (*h*), the distribution is visualized along the vertical (horizontal).
        public static partial class Orientation
        {
            public static Box<IViolinProperty> h() => Interop.mkViolinAttr("orientation", "h");
            public static Box<IViolinProperty> v() => Interop.mkViolinAttr("orientation", "v");
        }

        /// Sets the metric by which the width of each violin is determined.*width* means each violin has the same (max) width*count* means the violins are scaled by the number of sample points makingup each violin.
        public static partial class Scalemode
        {
            public static Box<IViolinProperty> count() => Interop.mkViolinAttr("scalemode", "count");
            public static Box<IViolinProperty> width() => Interop.mkViolinAttr("scalemode", "width");
        }

        /// Sets the method by which the span in data space where the density function will be computed. *soft* means the span goes from the sample's minimum value minus two bandwidths to the sample's maximum value plus two bandwidths. *hard* means the span goes from the sample's minimum to its maximum value. For custom span settings, use mode *manual* and fill in the `span` attribute.
        public static partial class Spanmode
        {
            public static Box<IViolinProperty> hard() => Interop.mkViolinAttr("spanmode", "hard");
            public static Box<IViolinProperty> manual() => Interop.mkViolinAttr("spanmode", "manual");
            public static Box<IViolinProperty> soft() => Interop.mkViolinAttr("spanmode", "soft");
        }

        /// If *outliers*, only the sample points lying outside the whiskers are shown If *suspectedoutliers*, the outlier points are shown and points either less than 4*Q1-3*Q3 or greater than 4*Q3-3*Q1 are highlighted (see `outliercolor`) If *all*, all sample points are shown If *false*, only the violins are shown with no sample points
        public static partial class Points
        {
            public static Box<IViolinProperty> all() => Interop.mkViolinAttr("points", "all");
            public static Box<IViolinProperty> outliers() => Interop.mkViolinAttr("points", "outliers");
            public static Box<IViolinProperty> suspectedoutliers() => Interop.mkViolinAttr("points", "suspectedoutliers");
            public static Box<IViolinProperty> _false() => Interop.mkViolinAttr("points", false);
        }

        /// Determines on which side of the position value the density function making up one half of a violin is plotted. Useful when comparing two violin traces under *overlay* mode, where one trace has `side` set to *positive* and the other to *negative*.
        public static partial class Side
        {
            public static Box<IViolinProperty> both() => Interop.mkViolinAttr("side", "both");
            public static Box<IViolinProperty> negative() => Interop.mkViolinAttr("side", "negative");
            public static Box<IViolinProperty> positive() => Interop.mkViolinAttr("side", "positive");
        }

        /// Do the hover effects highlight individual violins or sample points or the kernel density estimate or any combination of them?
        public static partial class Hoveron
        {
            public static Box<IViolinProperty> all() => Interop.mkViolinAttr("hoveron", "all");
            public static Box<IViolinProperty> kde() => Interop.mkViolinAttr("hoveron", "kde");
            public static Box<IViolinProperty> points() => Interop.mkViolinAttr("hoveron", "points");
            public static Box<IViolinProperty> violins() => Interop.mkViolinAttr("hoveron", "violins");
        }
    }
}