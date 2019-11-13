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

    public static partial class Funnel
    {
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IFunnelProperty> showlegend(bool val) => Interop.mkFunnelAttr("showlegend", val);
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IFunnelProperty> legendgroup(string val) => Interop.mkFunnelAttr("legendgroup", val);
        /// Sets the opacity of the trace.
        public static Box<IFunnelProperty> opacity(int val) => Interop.mkFunnelAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<IFunnelProperty> opacity(float val) => Interop.mkFunnelAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IFunnelProperty> name(string val) => Interop.mkFunnelAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IFunnelProperty> uid(string val) => Interop.mkFunnelAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelProperty> ids(bool val) => Interop.mkFunnelAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelProperty> ids(params bool[] values) => Interop.mkFunnelAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelProperty> ids(System.DateTime val) => Interop.mkFunnelAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelProperty> ids(params System.DateTime[] values) => Interop.mkFunnelAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelProperty> ids(float val) => Interop.mkFunnelAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelProperty> ids(params float[] values) => Interop.mkFunnelAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelProperty> ids(int val) => Interop.mkFunnelAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelProperty> ids(params int[] values) => Interop.mkFunnelAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelProperty> ids(string val) => Interop.mkFunnelAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelProperty> ids(params string[] values) => Interop.mkFunnelAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelProperty> ids(IEnumerable<bool[]> values) => Interop.mkFunnelAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelProperty> ids(List<bool[]> values) => Interop.mkFunnelAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelProperty> ids(params bool[][] values) => Interop.mkFunnelAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkFunnelAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelProperty> ids(List<string[]> values) => Interop.mkFunnelAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelProperty> ids(params string[][] values) => Interop.mkFunnelAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkFunnelAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelProperty> ids(List<int[]> values) => Interop.mkFunnelAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelProperty> ids(params int[][] values) => Interop.mkFunnelAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkFunnelAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelProperty> ids(List<float[]> values) => Interop.mkFunnelAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelProperty> ids(params float[][] values) => Interop.mkFunnelAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelProperty> ids(Literals.PlotData[] values) => Interop.mkFunnelAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelProperty> ids(IEnumerable<bool?> values) => Interop.mkFunnelAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkFunnelAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelProperty> ids(IEnumerable<int?> values) => Interop.mkFunnelAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelProperty> ids(IEnumerable<float?> values) => Interop.mkFunnelAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelProperty> customdata(bool val) => Interop.mkFunnelAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelProperty> customdata(params bool[] values) => Interop.mkFunnelAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelProperty> customdata(System.DateTime val) => Interop.mkFunnelAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelProperty> customdata(params System.DateTime[] values) => Interop.mkFunnelAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelProperty> customdata(float val) => Interop.mkFunnelAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelProperty> customdata(params float[] values) => Interop.mkFunnelAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelProperty> customdata(int val) => Interop.mkFunnelAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelProperty> customdata(params int[] values) => Interop.mkFunnelAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelProperty> customdata(string val) => Interop.mkFunnelAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelProperty> customdata(params string[] values) => Interop.mkFunnelAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelProperty> customdata(IEnumerable<bool[]> values) => Interop.mkFunnelAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelProperty> customdata(List<bool[]> values) => Interop.mkFunnelAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelProperty> customdata(params bool[][] values) => Interop.mkFunnelAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkFunnelAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelProperty> customdata(List<string[]> values) => Interop.mkFunnelAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelProperty> customdata(params string[][] values) => Interop.mkFunnelAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkFunnelAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelProperty> customdata(List<int[]> values) => Interop.mkFunnelAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelProperty> customdata(params int[][] values) => Interop.mkFunnelAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkFunnelAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelProperty> customdata(List<float[]> values) => Interop.mkFunnelAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelProperty> customdata(params float[][] values) => Interop.mkFunnelAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelProperty> customdata(Literals.PlotData[] values) => Interop.mkFunnelAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelProperty> customdata(IEnumerable<bool?> values) => Interop.mkFunnelAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkFunnelAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelProperty> customdata(IEnumerable<int?> values) => Interop.mkFunnelAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelProperty> customdata(IEnumerable<float?> values) => Interop.mkFunnelAttr("customdata", values.ToArray());
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IFunnelProperty> selectedpoints(bool val) => Interop.mkFunnelAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IFunnelProperty> selectedpoints(params bool[] values) => Interop.mkFunnelAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IFunnelProperty> selectedpoints(System.DateTime val) => Interop.mkFunnelAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IFunnelProperty> selectedpoints(params System.DateTime[] values) => Interop.mkFunnelAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IFunnelProperty> selectedpoints(int val) => Interop.mkFunnelAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IFunnelProperty> selectedpoints(params int[] values) => Interop.mkFunnelAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IFunnelProperty> selectedpoints(float val) => Interop.mkFunnelAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IFunnelProperty> selectedpoints(params float[] values) => Interop.mkFunnelAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IFunnelProperty> selectedpoints(string val) => Interop.mkFunnelAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IFunnelProperty> selectedpoints(params string[] values) => Interop.mkFunnelAttr("selectedpoints", values);
        public static Box<IFunnelProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkFunnelAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IFunnelProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkFunnelAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IFunnelProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkFunnelAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IFunnelProperty> uirevision(bool val) => Interop.mkFunnelAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IFunnelProperty> uirevision(params bool[] values) => Interop.mkFunnelAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IFunnelProperty> uirevision(System.DateTime val) => Interop.mkFunnelAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IFunnelProperty> uirevision(params System.DateTime[] values) => Interop.mkFunnelAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IFunnelProperty> uirevision(int val) => Interop.mkFunnelAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IFunnelProperty> uirevision(params int[] values) => Interop.mkFunnelAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IFunnelProperty> uirevision(float val) => Interop.mkFunnelAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IFunnelProperty> uirevision(params float[] values) => Interop.mkFunnelAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IFunnelProperty> uirevision(string val) => Interop.mkFunnelAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IFunnelProperty> uirevision(params string[] values) => Interop.mkFunnelAttr("uirevision", values);
        /// Sets the x coordinates.
        public static Box<IFunnelProperty> x(bool val) => Interop.mkFunnelAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IFunnelProperty> x(IEnumerable<bool> values) => Interop.mkFunnelAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IFunnelProperty> x(System.DateTime val) => Interop.mkFunnelAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IFunnelProperty> x(IEnumerable<System.DateTime> values) => Interop.mkFunnelAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IFunnelProperty> x(float val) => Interop.mkFunnelAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IFunnelProperty> x(IEnumerable<float> values) => Interop.mkFunnelAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IFunnelProperty> x(int val) => Interop.mkFunnelAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IFunnelProperty> x(IEnumerable<int> values) => Interop.mkFunnelAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IFunnelProperty> x(string val) => Interop.mkFunnelAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IFunnelProperty> x(IEnumerable<string> values) => Interop.mkFunnelAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IFunnelProperty> x(IEnumerable<bool[]> values) => Interop.mkFunnelAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IFunnelProperty> x(List<bool[]> values) => Interop.mkFunnelAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IFunnelProperty> x(params bool[][] values) => Interop.mkFunnelAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IFunnelProperty> x(IEnumerable<IEnumerable<string>> values) => Interop.mkFunnelAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IFunnelProperty> x(List<string[]> values) => Interop.mkFunnelAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IFunnelProperty> x(params string[][] values) => Interop.mkFunnelAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IFunnelProperty> x(IEnumerable<IEnumerable<int>> values) => Interop.mkFunnelAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IFunnelProperty> x(List<int[]> values) => Interop.mkFunnelAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IFunnelProperty> x(params int[][] values) => Interop.mkFunnelAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IFunnelProperty> x(IEnumerable<IEnumerable<float>> values) => Interop.mkFunnelAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IFunnelProperty> x(List<float[]> values) => Interop.mkFunnelAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IFunnelProperty> x(params float[][] values) => Interop.mkFunnelAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IFunnelProperty> x(Literals.PlotData[] values) => Interop.mkFunnelAttr("x", values);
        /// Sets the x coordinates.
        public static Box<IFunnelProperty> x(IEnumerable<bool?> values) => Interop.mkFunnelAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IFunnelProperty> x(IEnumerable<System.DateTime?> values) => Interop.mkFunnelAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IFunnelProperty> x(IEnumerable<int?> values) => Interop.mkFunnelAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IFunnelProperty> x(IEnumerable<float?> values) => Interop.mkFunnelAttr("x", values.ToArray());
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IFunnelProperty> x0(bool val) => Interop.mkFunnelAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IFunnelProperty> x0(params bool[] values) => Interop.mkFunnelAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IFunnelProperty> x0(System.DateTime val) => Interop.mkFunnelAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IFunnelProperty> x0(params System.DateTime[] values) => Interop.mkFunnelAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IFunnelProperty> x0(int val) => Interop.mkFunnelAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IFunnelProperty> x0(params int[] values) => Interop.mkFunnelAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IFunnelProperty> x0(float val) => Interop.mkFunnelAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IFunnelProperty> x0(params float[] values) => Interop.mkFunnelAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IFunnelProperty> x0(string val) => Interop.mkFunnelAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IFunnelProperty> x0(params string[] values) => Interop.mkFunnelAttr("x0", values);
        /// Sets the x coordinate step. See `x0` for more info.
        public static Box<IFunnelProperty> dx(int val) => Interop.mkFunnelAttr("dx", val);
        /// Sets the x coordinate step. See `x0` for more info.
        public static Box<IFunnelProperty> dx(float val) => Interop.mkFunnelAttr("dx", val);
        /// Sets the y coordinates.
        public static Box<IFunnelProperty> y(bool val) => Interop.mkFunnelAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IFunnelProperty> y(IEnumerable<bool> values) => Interop.mkFunnelAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IFunnelProperty> y(System.DateTime val) => Interop.mkFunnelAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IFunnelProperty> y(IEnumerable<System.DateTime> values) => Interop.mkFunnelAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IFunnelProperty> y(float val) => Interop.mkFunnelAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IFunnelProperty> y(IEnumerable<float> values) => Interop.mkFunnelAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IFunnelProperty> y(int val) => Interop.mkFunnelAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IFunnelProperty> y(IEnumerable<int> values) => Interop.mkFunnelAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IFunnelProperty> y(string val) => Interop.mkFunnelAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IFunnelProperty> y(IEnumerable<string> values) => Interop.mkFunnelAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IFunnelProperty> y(IEnumerable<bool[]> values) => Interop.mkFunnelAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IFunnelProperty> y(List<bool[]> values) => Interop.mkFunnelAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IFunnelProperty> y(params bool[][] values) => Interop.mkFunnelAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IFunnelProperty> y(IEnumerable<IEnumerable<string>> values) => Interop.mkFunnelAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IFunnelProperty> y(List<string[]> values) => Interop.mkFunnelAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IFunnelProperty> y(params string[][] values) => Interop.mkFunnelAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IFunnelProperty> y(IEnumerable<IEnumerable<int>> values) => Interop.mkFunnelAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IFunnelProperty> y(List<int[]> values) => Interop.mkFunnelAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IFunnelProperty> y(params int[][] values) => Interop.mkFunnelAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IFunnelProperty> y(IEnumerable<IEnumerable<float>> values) => Interop.mkFunnelAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IFunnelProperty> y(List<float[]> values) => Interop.mkFunnelAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IFunnelProperty> y(params float[][] values) => Interop.mkFunnelAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IFunnelProperty> y(Literals.PlotData[] values) => Interop.mkFunnelAttr("y", values);
        /// Sets the y coordinates.
        public static Box<IFunnelProperty> y(IEnumerable<bool?> values) => Interop.mkFunnelAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IFunnelProperty> y(IEnumerable<System.DateTime?> values) => Interop.mkFunnelAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IFunnelProperty> y(IEnumerable<int?> values) => Interop.mkFunnelAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IFunnelProperty> y(IEnumerable<float?> values) => Interop.mkFunnelAttr("y", values.ToArray());
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IFunnelProperty> y0(bool val) => Interop.mkFunnelAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IFunnelProperty> y0(params bool[] values) => Interop.mkFunnelAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IFunnelProperty> y0(System.DateTime val) => Interop.mkFunnelAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IFunnelProperty> y0(params System.DateTime[] values) => Interop.mkFunnelAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IFunnelProperty> y0(int val) => Interop.mkFunnelAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IFunnelProperty> y0(params int[] values) => Interop.mkFunnelAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IFunnelProperty> y0(float val) => Interop.mkFunnelAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IFunnelProperty> y0(params float[] values) => Interop.mkFunnelAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IFunnelProperty> y0(string val) => Interop.mkFunnelAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IFunnelProperty> y0(params string[] values) => Interop.mkFunnelAttr("y0", values);
        /// Sets the y coordinate step. See `y0` for more info.
        public static Box<IFunnelProperty> dy(int val) => Interop.mkFunnelAttr("dy", val);
        /// Sets the y coordinate step. See `y0` for more info.
        public static Box<IFunnelProperty> dy(float val) => Interop.mkFunnelAttr("dy", val);
        /// Sets hover text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IFunnelProperty> hovertext(string val) => Interop.mkFunnelAttr("hovertext", val);
        /// Sets hover text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IFunnelProperty> hovertext(IEnumerable<string> values) => Interop.mkFunnelAttr("hovertext", values.ToArray());
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `percentInitial`, `percentPrevious` and `percentTotal`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IFunnelProperty> hovertemplate(string val) => Interop.mkFunnelAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `percentInitial`, `percentPrevious` and `percentTotal`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IFunnelProperty> hovertemplate(IEnumerable<string> values) => Interop.mkFunnelAttr("hovertemplate", values.ToArray());
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IFunnelProperty> hoverinfo(params Box<IFunnelProperty>[] properties) => Interop.mkFunnelAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        /// Determines which trace information appear on the graph. In the case of having multiple funnels, percentages & totals are computed separately (per trace).
        public static Box<IFunnelProperty> textinfo(params Box<IFunnelProperty>[] properties) => Interop.mkFunnelAttr("textinfo", Bindings.joinEnumProperties(properties));
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `percentInitial`, `percentPrevious`, `percentTotal`, `label` and `value`.
        public static Box<IFunnelProperty> texttemplate(string val) => Interop.mkFunnelAttr("texttemplate", val);
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `percentInitial`, `percentPrevious`, `percentTotal`, `label` and `value`.
        public static Box<IFunnelProperty> texttemplate(IEnumerable<string> values) => Interop.mkFunnelAttr("texttemplate", values.ToArray());
        /// Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelProperty> text(string val) => Interop.mkFunnelAttr("text", val);
        /// Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelProperty> text(IEnumerable<string> values) => Interop.mkFunnelAttr("text", values.ToArray());
        /// Specifies the location of the `text`. *inside* positions `text` inside, next to the bar end (rotated and scaled if needed). *outside* positions `text` outside, next to the bar end (scaled if needed), unless there is another bar stacked on this one, then the text gets pushed inside. *auto* tries to position `text` inside the bar, but if the bar is too small and no bar is stacked on this one the text is moved outside.
        public static Box<IFunnelProperty> textposition(IEnumerable<Box<IFunnelProperty>> properties) => Interop.mkFunnelAttr("textposition", Bindings.flattenProperties(properties));
        /// Sets the angle of the tick labels with respect to the bar. For example, a `tickangle` of -90 draws the tick labels vertically. With *auto* the texts may automatically be rotated to fit with the maximum size in bars.
        public static Box<IFunnelProperty> textangle(int val) => Interop.mkFunnelAttr("textangle", val);
        /// Sets the angle of the tick labels with respect to the bar. For example, a `tickangle` of -90 draws the tick labels vertically. With *auto* the texts may automatically be rotated to fit with the maximum size in bars.
        public static Box<IFunnelProperty> textangle(float val) => Interop.mkFunnelAttr("textangle", val);
        /// Sets the font used for `text`.
        public static Box<IFunnelProperty> textfont(params Box<ITextfontProperty>[] properties) => Interop.mkFunnelAttr("textfont", Bindings.flattenProperties(properties));
        /// Sets the font used for `text` lying inside the bar.
        public static Box<IFunnelProperty> insidetextfont(params Box<IInsidetextfontProperty>[] properties) => Interop.mkFunnelAttr("insidetextfont", Bindings.flattenProperties(properties));
        /// Sets the font used for `text` lying outside the bar.
        public static Box<IFunnelProperty> outsidetextfont(params Box<IOutsidetextfontProperty>[] properties) => Interop.mkFunnelAttr("outsidetextfont", Bindings.flattenProperties(properties));
        /// Determines whether the text nodes are clipped about the subplot axes. To show the text nodes above axis lines and tick labels, make sure to set `xaxis.layer` and `yaxis.layer` to *below traces*.
        public static Box<IFunnelProperty> cliponaxis(bool val) => Interop.mkFunnelAttr("cliponaxis", val);
        /// Shifts the position where the bar is drawn (in position axis units). In *group* barmode, traces that set *offset* will be excluded and drawn in *overlay* mode instead.
        public static Box<IFunnelProperty> offset(int val) => Interop.mkFunnelAttr("offset", val);
        /// Shifts the position where the bar is drawn (in position axis units). In *group* barmode, traces that set *offset* will be excluded and drawn in *overlay* mode instead.
        public static Box<IFunnelProperty> offset(float val) => Interop.mkFunnelAttr("offset", val);
        /// Sets the bar width (in position axis units).
        public static Box<IFunnelProperty> width(int val) => Interop.mkFunnelAttr("width", val);
        /// Sets the bar width (in position axis units).
        public static Box<IFunnelProperty> width(float val) => Interop.mkFunnelAttr("width", val);
        public static Box<IFunnelProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkFunnelAttr("marker", Bindings.flattenProperties(properties));
        public static Box<IFunnelProperty> connector(params Box<IConnectorProperty>[] properties) => Interop.mkFunnelAttr("connector", Bindings.flattenProperties(properties));
        /// Set several traces linked to the same position axis or matching axes to the same offsetgroup where bars of the same position coordinate will line up.
        public static Box<IFunnelProperty> offsetgroup(string val) => Interop.mkFunnelAttr("offsetgroup", val);
        /// Set several traces linked to the same position axis or matching axes to the same alignmentgroup. This controls whether bars compute their positional range dependently or independently.
        public static Box<IFunnelProperty> alignmentgroup(string val) => Interop.mkFunnelAttr("alignmentgroup", val);
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IFunnelProperty> xaxis(int anchorId) => Interop.mkFunnelAttr("xaxis", anchorId > 1 ? $"x{anchorId}" : "");
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IFunnelProperty> xaxis(string val) => Interop.mkFunnelAttr("xaxis", val);
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IFunnelProperty> yaxis(int anchorId) => Interop.mkFunnelAttr("yaxis", anchorId > 1 ? $"y{anchorId}" : "");
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IFunnelProperty> yaxis(string val) => Interop.mkFunnelAttr("yaxis", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IFunnelProperty> idssrc(string val) => Interop.mkFunnelAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IFunnelProperty> customdatasrc(string val) => Interop.mkFunnelAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IFunnelProperty> metasrc(string val) => Interop.mkFunnelAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  x .
        public static Box<IFunnelProperty> xsrc(string val) => Interop.mkFunnelAttr("xsrc", val);
        /// Sets the source reference on plot.ly for  y .
        public static Box<IFunnelProperty> ysrc(string val) => Interop.mkFunnelAttr("ysrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IFunnelProperty> hovertextsrc(string val) => Interop.mkFunnelAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IFunnelProperty> hovertemplatesrc(string val) => Interop.mkFunnelAttr("hovertemplatesrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IFunnelProperty> hoverinfosrc(string val) => Interop.mkFunnelAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  texttemplate .
        public static Box<IFunnelProperty> texttemplatesrc(string val) => Interop.mkFunnelAttr("texttemplatesrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IFunnelProperty> textsrc(string val) => Interop.mkFunnelAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  textposition .
        public static Box<IFunnelProperty> textpositionsrc(string val) => Interop.mkFunnelAttr("textpositionsrc", val);
    }

    public static partial class Funnel
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IFunnelProperty> legendonly() => Interop.mkFunnelAttr("visible", "legendonly");
            public static Box<IFunnelProperty> _false() => Interop.mkFunnelAttr("visible", false);
            public static Box<IFunnelProperty> _true() => Interop.mkFunnelAttr("visible", true);
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IFunnelProperty> all() => Interop.mkFunnelAttr("hoverinfo", "all");
            public static Box<IFunnelProperty> none() => Interop.mkFunnelAttr("hoverinfo", "none");
            public static Box<IFunnelProperty> skip() => Interop.mkFunnelAttr("hoverinfo", "skip");
            public static Box<IFunnelProperty> name() => Interop.mkFunnelAttr("hoverinfo", "name");
            public static Box<IFunnelProperty> percentInitial() => Interop.mkFunnelAttr("hoverinfo", "percent initial");
            public static Box<IFunnelProperty> percentPrevious() => Interop.mkFunnelAttr("hoverinfo", "percent previous");
            public static Box<IFunnelProperty> percentTotal() => Interop.mkFunnelAttr("hoverinfo", "percent total");
            public static Box<IFunnelProperty> text() => Interop.mkFunnelAttr("hoverinfo", "text");
            public static Box<IFunnelProperty> x() => Interop.mkFunnelAttr("hoverinfo", "x");
            public static Box<IFunnelProperty> y() => Interop.mkFunnelAttr("hoverinfo", "y");
        }

        /// Determines which trace information appear on the graph. In the case of having multiple funnels, percentages & totals are computed separately (per trace).
        public static partial class Textinfo
        {
            public static Box<IFunnelProperty> none() => Interop.mkFunnelAttr("textinfo", "none");
            public static Box<IFunnelProperty> label() => Interop.mkFunnelAttr("textinfo", "label");
            public static Box<IFunnelProperty> percentInitial() => Interop.mkFunnelAttr("textinfo", "percent initial");
            public static Box<IFunnelProperty> percentPrevious() => Interop.mkFunnelAttr("textinfo", "percent previous");
            public static Box<IFunnelProperty> percentTotal() => Interop.mkFunnelAttr("textinfo", "percent total");
            public static Box<IFunnelProperty> text() => Interop.mkFunnelAttr("textinfo", "text");
            public static Box<IFunnelProperty> value() => Interop.mkFunnelAttr("textinfo", "value");
        }

        /// Specifies the location of the `text`. *inside* positions `text` inside, next to the bar end (rotated and scaled if needed). *outside* positions `text` outside, next to the bar end (scaled if needed), unless there is another bar stacked on this one, then the text gets pushed inside. *auto* tries to position `text` inside the bar, but if the bar is too small and no bar is stacked on this one the text is moved outside.
        public static partial class Textposition
        {
            public static Box<IFunnelProperty> auto() => Interop.mkFunnelAttr("textposition", "auto");
            public static Box<IFunnelProperty> inside() => Interop.mkFunnelAttr("textposition", "inside");
            public static Box<IFunnelProperty> none() => Interop.mkFunnelAttr("textposition", "none");
            public static Box<IFunnelProperty> outside() => Interop.mkFunnelAttr("textposition", "outside");
        }

        /// Determines if texts are kept at center or start/end points in `textposition` *inside* mode.
        public static partial class Insidetextanchor
        {
            public static Box<IFunnelProperty> _end() => Interop.mkFunnelAttr("insidetextanchor", "end");
            public static Box<IFunnelProperty> middle() => Interop.mkFunnelAttr("insidetextanchor", "middle");
            public static Box<IFunnelProperty> start() => Interop.mkFunnelAttr("insidetextanchor", "start");
        }

        /// Constrain the size of text inside or outside a bar to be no larger than the bar itself.
        public static partial class Constraintext
        {
            public static Box<IFunnelProperty> both() => Interop.mkFunnelAttr("constraintext", "both");
            public static Box<IFunnelProperty> inside() => Interop.mkFunnelAttr("constraintext", "inside");
            public static Box<IFunnelProperty> none() => Interop.mkFunnelAttr("constraintext", "none");
            public static Box<IFunnelProperty> outside() => Interop.mkFunnelAttr("constraintext", "outside");
        }

        /// Sets the orientation of the funnels. With *v* (*h*), the value of the each bar spans along the vertical (horizontal). By default funnels are tend to be oriented horizontally; unless only *y* array is presented or orientation is set to *v*. Also regarding graphs including only 'horizontal' funnels, *autorange* on the *y-axis* are set to *reversed*.
        public static partial class Orientation
        {
            public static Box<IFunnelProperty> h() => Interop.mkFunnelAttr("orientation", "h");
            public static Box<IFunnelProperty> v() => Interop.mkFunnelAttr("orientation", "v");
        }
    }
}