namespace Plotly
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

    public static partial class Box
    {
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IBoxProperty> showlegend(bool val) => Interop.mkBoxAttr("showlegend", val);
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IBoxProperty> legendgroup(string val) => Interop.mkBoxAttr("legendgroup", val);
        /// Sets the opacity of the trace.
        public static Box<IBoxProperty> opacity(int val) => Interop.mkBoxAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<IBoxProperty> opacity(float val) => Interop.mkBoxAttr("opacity", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IBoxProperty> uid(string val) => Interop.mkBoxAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBoxProperty> ids(bool val) => Interop.mkBoxAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBoxProperty> ids(params bool[] values) => Interop.mkBoxAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBoxProperty> ids(System.DateTime val) => Interop.mkBoxAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBoxProperty> ids(params System.DateTime[] values) => Interop.mkBoxAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBoxProperty> ids(float val) => Interop.mkBoxAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBoxProperty> ids(params float[] values) => Interop.mkBoxAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBoxProperty> ids(int val) => Interop.mkBoxAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBoxProperty> ids(params int[] values) => Interop.mkBoxAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBoxProperty> ids(string val) => Interop.mkBoxAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBoxProperty> ids(params string[] values) => Interop.mkBoxAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBoxProperty> ids(IEnumerable<bool[]> values) => Interop.mkBoxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBoxProperty> ids(List<bool[]> values) => Interop.mkBoxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBoxProperty> ids(params bool[][] values) => Interop.mkBoxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBoxProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkBoxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBoxProperty> ids(List<string[]> values) => Interop.mkBoxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBoxProperty> ids(params string[][] values) => Interop.mkBoxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBoxProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkBoxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBoxProperty> ids(List<int[]> values) => Interop.mkBoxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBoxProperty> ids(params int[][] values) => Interop.mkBoxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBoxProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkBoxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBoxProperty> ids(List<float[]> values) => Interop.mkBoxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBoxProperty> ids(params float[][] values) => Interop.mkBoxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBoxProperty> ids(Literals.PlotData[] values) => Interop.mkBoxAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBoxProperty> ids(IEnumerable<bool?> values) => Interop.mkBoxAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBoxProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkBoxAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBoxProperty> ids(IEnumerable<int?> values) => Interop.mkBoxAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBoxProperty> ids(IEnumerable<float?> values) => Interop.mkBoxAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBoxProperty> customdata(bool val) => Interop.mkBoxAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBoxProperty> customdata(params bool[] values) => Interop.mkBoxAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBoxProperty> customdata(System.DateTime val) => Interop.mkBoxAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBoxProperty> customdata(params System.DateTime[] values) => Interop.mkBoxAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBoxProperty> customdata(float val) => Interop.mkBoxAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBoxProperty> customdata(params float[] values) => Interop.mkBoxAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBoxProperty> customdata(int val) => Interop.mkBoxAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBoxProperty> customdata(params int[] values) => Interop.mkBoxAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBoxProperty> customdata(string val) => Interop.mkBoxAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBoxProperty> customdata(params string[] values) => Interop.mkBoxAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBoxProperty> customdata(IEnumerable<bool[]> values) => Interop.mkBoxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBoxProperty> customdata(List<bool[]> values) => Interop.mkBoxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBoxProperty> customdata(params bool[][] values) => Interop.mkBoxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBoxProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkBoxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBoxProperty> customdata(List<string[]> values) => Interop.mkBoxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBoxProperty> customdata(params string[][] values) => Interop.mkBoxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBoxProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkBoxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBoxProperty> customdata(List<int[]> values) => Interop.mkBoxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBoxProperty> customdata(params int[][] values) => Interop.mkBoxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBoxProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkBoxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBoxProperty> customdata(List<float[]> values) => Interop.mkBoxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBoxProperty> customdata(params float[][] values) => Interop.mkBoxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBoxProperty> customdata(Literals.PlotData[] values) => Interop.mkBoxAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBoxProperty> customdata(IEnumerable<bool?> values) => Interop.mkBoxAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBoxProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkBoxAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBoxProperty> customdata(IEnumerable<int?> values) => Interop.mkBoxAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBoxProperty> customdata(IEnumerable<float?> values) => Interop.mkBoxAttr("customdata", values.ToArray());
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBoxProperty> selectedpoints(bool val) => Interop.mkBoxAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBoxProperty> selectedpoints(params bool[] values) => Interop.mkBoxAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBoxProperty> selectedpoints(System.DateTime val) => Interop.mkBoxAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBoxProperty> selectedpoints(params System.DateTime[] values) => Interop.mkBoxAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBoxProperty> selectedpoints(int val) => Interop.mkBoxAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBoxProperty> selectedpoints(params int[] values) => Interop.mkBoxAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBoxProperty> selectedpoints(float val) => Interop.mkBoxAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBoxProperty> selectedpoints(params float[] values) => Interop.mkBoxAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBoxProperty> selectedpoints(string val) => Interop.mkBoxAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBoxProperty> selectedpoints(params string[] values) => Interop.mkBoxAttr("selectedpoints", values);
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IBoxProperty> hoverinfo(params Box<IBoxProperty>[] properties) => Interop.mkBoxAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        public static Box<IBoxProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkBoxAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IBoxProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkBoxAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IBoxProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkBoxAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBoxProperty> uirevision(bool val) => Interop.mkBoxAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBoxProperty> uirevision(params bool[] values) => Interop.mkBoxAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBoxProperty> uirevision(System.DateTime val) => Interop.mkBoxAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBoxProperty> uirevision(params System.DateTime[] values) => Interop.mkBoxAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBoxProperty> uirevision(int val) => Interop.mkBoxAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBoxProperty> uirevision(params int[] values) => Interop.mkBoxAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBoxProperty> uirevision(float val) => Interop.mkBoxAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBoxProperty> uirevision(params float[] values) => Interop.mkBoxAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBoxProperty> uirevision(string val) => Interop.mkBoxAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBoxProperty> uirevision(params string[] values) => Interop.mkBoxAttr("uirevision", values);
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> y(bool val) => Interop.mkBoxAttr("y", new[]{val});
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> y(IEnumerable<bool> values) => Interop.mkBoxAttr("y", values.ToArray());
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> y(System.DateTime val) => Interop.mkBoxAttr("y", new[]{val});
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> y(IEnumerable<System.DateTime> values) => Interop.mkBoxAttr("y", values.ToArray());
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> y(float val) => Interop.mkBoxAttr("y", new[]{val});
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> y(IEnumerable<float> values) => Interop.mkBoxAttr("y", values.ToArray());
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> y(int val) => Interop.mkBoxAttr("y", new[]{val});
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> y(IEnumerable<int> values) => Interop.mkBoxAttr("y", values.ToArray());
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> y(string val) => Interop.mkBoxAttr("y", new[]{val});
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> y(IEnumerable<string> values) => Interop.mkBoxAttr("y", values.ToArray());
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> y(IEnumerable<bool[]> values) => Interop.mkBoxAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> y(List<bool[]> values) => Interop.mkBoxAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> y(params bool[][] values) => Interop.mkBoxAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> y(IEnumerable<IEnumerable<string>> values) => Interop.mkBoxAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> y(List<string[]> values) => Interop.mkBoxAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> y(params string[][] values) => Interop.mkBoxAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> y(IEnumerable<IEnumerable<int>> values) => Interop.mkBoxAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> y(List<int[]> values) => Interop.mkBoxAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> y(params int[][] values) => Interop.mkBoxAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> y(IEnumerable<IEnumerable<float>> values) => Interop.mkBoxAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> y(List<float[]> values) => Interop.mkBoxAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> y(params float[][] values) => Interop.mkBoxAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> y(Literals.PlotData[] values) => Interop.mkBoxAttr("y", values);
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> y(IEnumerable<bool?> values) => Interop.mkBoxAttr("y", values.ToArray());
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> y(IEnumerable<System.DateTime?> values) => Interop.mkBoxAttr("y", values.ToArray());
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> y(IEnumerable<int?> values) => Interop.mkBoxAttr("y", values.ToArray());
        /// Sets the y sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> y(IEnumerable<float?> values) => Interop.mkBoxAttr("y", values.ToArray());
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> x(bool val) => Interop.mkBoxAttr("x", new[]{val});
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> x(IEnumerable<bool> values) => Interop.mkBoxAttr("x", values.ToArray());
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> x(System.DateTime val) => Interop.mkBoxAttr("x", new[]{val});
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> x(IEnumerable<System.DateTime> values) => Interop.mkBoxAttr("x", values.ToArray());
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> x(float val) => Interop.mkBoxAttr("x", new[]{val});
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> x(IEnumerable<float> values) => Interop.mkBoxAttr("x", values.ToArray());
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> x(int val) => Interop.mkBoxAttr("x", new[]{val});
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> x(IEnumerable<int> values) => Interop.mkBoxAttr("x", values.ToArray());
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> x(string val) => Interop.mkBoxAttr("x", new[]{val});
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> x(IEnumerable<string> values) => Interop.mkBoxAttr("x", values.ToArray());
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> x(IEnumerable<bool[]> values) => Interop.mkBoxAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> x(List<bool[]> values) => Interop.mkBoxAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> x(params bool[][] values) => Interop.mkBoxAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> x(IEnumerable<IEnumerable<string>> values) => Interop.mkBoxAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> x(List<string[]> values) => Interop.mkBoxAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> x(params string[][] values) => Interop.mkBoxAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> x(IEnumerable<IEnumerable<int>> values) => Interop.mkBoxAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> x(List<int[]> values) => Interop.mkBoxAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> x(params int[][] values) => Interop.mkBoxAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> x(IEnumerable<IEnumerable<float>> values) => Interop.mkBoxAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> x(List<float[]> values) => Interop.mkBoxAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> x(params float[][] values) => Interop.mkBoxAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> x(Literals.PlotData[] values) => Interop.mkBoxAttr("x", values);
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> x(IEnumerable<bool?> values) => Interop.mkBoxAttr("x", values.ToArray());
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> x(IEnumerable<System.DateTime?> values) => Interop.mkBoxAttr("x", values.ToArray());
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> x(IEnumerable<int?> values) => Interop.mkBoxAttr("x", values.ToArray());
        /// Sets the x sample data or coordinates. See overview for more info.
        public static Box<IBoxProperty> x(IEnumerable<float?> values) => Interop.mkBoxAttr("x", values.ToArray());
        /// Sets the x coordinate of the box. See overview for more info.
        public static Box<IBoxProperty> x0(bool val) => Interop.mkBoxAttr("x0", val);
        /// Sets the x coordinate of the box. See overview for more info.
        public static Box<IBoxProperty> x0(params bool[] values) => Interop.mkBoxAttr("x0", values);
        /// Sets the x coordinate of the box. See overview for more info.
        public static Box<IBoxProperty> x0(System.DateTime val) => Interop.mkBoxAttr("x0", val);
        /// Sets the x coordinate of the box. See overview for more info.
        public static Box<IBoxProperty> x0(params System.DateTime[] values) => Interop.mkBoxAttr("x0", values);
        /// Sets the x coordinate of the box. See overview for more info.
        public static Box<IBoxProperty> x0(int val) => Interop.mkBoxAttr("x0", val);
        /// Sets the x coordinate of the box. See overview for more info.
        public static Box<IBoxProperty> x0(params int[] values) => Interop.mkBoxAttr("x0", values);
        /// Sets the x coordinate of the box. See overview for more info.
        public static Box<IBoxProperty> x0(float val) => Interop.mkBoxAttr("x0", val);
        /// Sets the x coordinate of the box. See overview for more info.
        public static Box<IBoxProperty> x0(params float[] values) => Interop.mkBoxAttr("x0", values);
        /// Sets the x coordinate of the box. See overview for more info.
        public static Box<IBoxProperty> x0(string val) => Interop.mkBoxAttr("x0", val);
        /// Sets the x coordinate of the box. See overview for more info.
        public static Box<IBoxProperty> x0(params string[] values) => Interop.mkBoxAttr("x0", values);
        /// Sets the y coordinate of the box. See overview for more info.
        public static Box<IBoxProperty> y0(bool val) => Interop.mkBoxAttr("y0", val);
        /// Sets the y coordinate of the box. See overview for more info.
        public static Box<IBoxProperty> y0(params bool[] values) => Interop.mkBoxAttr("y0", values);
        /// Sets the y coordinate of the box. See overview for more info.
        public static Box<IBoxProperty> y0(System.DateTime val) => Interop.mkBoxAttr("y0", val);
        /// Sets the y coordinate of the box. See overview for more info.
        public static Box<IBoxProperty> y0(params System.DateTime[] values) => Interop.mkBoxAttr("y0", values);
        /// Sets the y coordinate of the box. See overview for more info.
        public static Box<IBoxProperty> y0(int val) => Interop.mkBoxAttr("y0", val);
        /// Sets the y coordinate of the box. See overview for more info.
        public static Box<IBoxProperty> y0(params int[] values) => Interop.mkBoxAttr("y0", values);
        /// Sets the y coordinate of the box. See overview for more info.
        public static Box<IBoxProperty> y0(float val) => Interop.mkBoxAttr("y0", val);
        /// Sets the y coordinate of the box. See overview for more info.
        public static Box<IBoxProperty> y0(params float[] values) => Interop.mkBoxAttr("y0", values);
        /// Sets the y coordinate of the box. See overview for more info.
        public static Box<IBoxProperty> y0(string val) => Interop.mkBoxAttr("y0", val);
        /// Sets the y coordinate of the box. See overview for more info.
        public static Box<IBoxProperty> y0(params string[] values) => Interop.mkBoxAttr("y0", values);
        /// Sets the trace name. The trace name appear as the legend item and on hover. For box traces, the name will also be used for the position coordinate, if `x` and `x0` (`y` and `y0` if horizontal) are missing and the position axis is categorical
        public static Box<IBoxProperty> name(string val) => Interop.mkBoxAttr("name", val);
        /// Sets the text elements associated with each sample value. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IBoxProperty> text(string val) => Interop.mkBoxAttr("text", val);
        /// Sets the text elements associated with each sample value. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IBoxProperty> text(IEnumerable<string> values) => Interop.mkBoxAttr("text", values.ToArray());
        /// Same as `text`.
        public static Box<IBoxProperty> hovertext(string val) => Interop.mkBoxAttr("hovertext", val);
        /// Same as `text`.
        public static Box<IBoxProperty> hovertext(IEnumerable<string> values) => Interop.mkBoxAttr("hovertext", values.ToArray());
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IBoxProperty> hovertemplate(string val) => Interop.mkBoxAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IBoxProperty> hovertemplate(IEnumerable<string> values) => Interop.mkBoxAttr("hovertemplate", values.ToArray());
        /// Sets the width of the whiskers relative to the box' width. For example, with 1, the whiskers are as wide as the box(es).
        public static Box<IBoxProperty> whiskerwidth(int val) => Interop.mkBoxAttr("whiskerwidth", val);
        /// Sets the width of the whiskers relative to the box' width. For example, with 1, the whiskers are as wide as the box(es).
        public static Box<IBoxProperty> whiskerwidth(float val) => Interop.mkBoxAttr("whiskerwidth", val);
        /// Determines whether or not notches should be drawn.
        public static Box<IBoxProperty> notched(bool val) => Interop.mkBoxAttr("notched", val);
        /// Sets the width of the notches relative to the box' width. For example, with 0, the notches are as wide as the box(es).
        public static Box<IBoxProperty> notchwidth(int val) => Interop.mkBoxAttr("notchwidth", val);
        /// Sets the width of the notches relative to the box' width. For example, with 0, the notches are as wide as the box(es).
        public static Box<IBoxProperty> notchwidth(float val) => Interop.mkBoxAttr("notchwidth", val);
        /// Sets the amount of jitter in the sample points drawn. If *0*, the sample points align along the distribution axis. If *1*, the sample points are drawn in a random jitter of width equal to the width of the box(es).
        public static Box<IBoxProperty> jitter(int val) => Interop.mkBoxAttr("jitter", val);
        /// Sets the amount of jitter in the sample points drawn. If *0*, the sample points align along the distribution axis. If *1*, the sample points are drawn in a random jitter of width equal to the width of the box(es).
        public static Box<IBoxProperty> jitter(float val) => Interop.mkBoxAttr("jitter", val);
        /// Sets the position of the sample points in relation to the box(es). If *0*, the sample points are places over the center of the box(es). Positive (negative) values correspond to positions to the right (left) for vertical boxes and above (below) for horizontal boxes
        public static Box<IBoxProperty> pointpos(int val) => Interop.mkBoxAttr("pointpos", val);
        /// Sets the position of the sample points in relation to the box(es). If *0*, the sample points are places over the center of the box(es). Positive (negative) values correspond to positions to the right (left) for vertical boxes and above (below) for horizontal boxes
        public static Box<IBoxProperty> pointpos(float val) => Interop.mkBoxAttr("pointpos", val);
        /// Sets the width of the box in data coordinate If *0* (default value) the width is automatically selected based on the positions of other box traces in the same subplot.
        public static Box<IBoxProperty> width(int val) => Interop.mkBoxAttr("width", val);
        /// Sets the width of the box in data coordinate If *0* (default value) the width is automatically selected based on the positions of other box traces in the same subplot.
        public static Box<IBoxProperty> width(float val) => Interop.mkBoxAttr("width", val);
        public static Box<IBoxProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkBoxAttr("marker", Bindings.flattenProperties(properties));
        public static Box<IBoxProperty> line(params Box<ILineProperty>[] properties) => Interop.mkBoxAttr("line", Bindings.flattenProperties(properties));
        /// Sets the fill color. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
        public static Box<IBoxProperty> fillcolor(string val) => Interop.mkBoxAttr("fillcolor", val);
        /// Set several traces linked to the same position axis or matching axes to the same offsetgroup where bars of the same position coordinate will line up.
        public static Box<IBoxProperty> offsetgroup(string val) => Interop.mkBoxAttr("offsetgroup", val);
        /// Set several traces linked to the same position axis or matching axes to the same alignmentgroup. This controls whether bars compute their positional range dependently or independently.
        public static Box<IBoxProperty> alignmentgroup(string val) => Interop.mkBoxAttr("alignmentgroup", val);
        public static Box<IBoxProperty> selected(params Box<ISelectedProperty>[] properties) => Interop.mkBoxAttr("selected", Bindings.flattenProperties(properties));
        public static Box<IBoxProperty> unselected(params Box<IUnselectedProperty>[] properties) => Interop.mkBoxAttr("unselected", Bindings.flattenProperties(properties));
        /// Do the hover effects highlight individual boxes  or sample points or both?
        public static Box<IBoxProperty> hoveron(params Box<IBoxProperty>[] properties) => Interop.mkBoxAttr("hoveron", Bindings.joinEnumProperties(properties));
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IBoxProperty> xaxis(int anchorId) => Interop.mkBoxAttr("xaxis", anchorId > 1 ? $"x{anchorId}" : "");
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IBoxProperty> xaxis(string val) => Interop.mkBoxAttr("xaxis", val);
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IBoxProperty> yaxis(int anchorId) => Interop.mkBoxAttr("yaxis", anchorId > 1 ? $"y{anchorId}" : "");
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IBoxProperty> yaxis(string val) => Interop.mkBoxAttr("yaxis", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IBoxProperty> idssrc(string val) => Interop.mkBoxAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IBoxProperty> customdatasrc(string val) => Interop.mkBoxAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IBoxProperty> metasrc(string val) => Interop.mkBoxAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IBoxProperty> hoverinfosrc(string val) => Interop.mkBoxAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  y .
        public static Box<IBoxProperty> ysrc(string val) => Interop.mkBoxAttr("ysrc", val);
        /// Sets the source reference on plot.ly for  x .
        public static Box<IBoxProperty> xsrc(string val) => Interop.mkBoxAttr("xsrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IBoxProperty> textsrc(string val) => Interop.mkBoxAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IBoxProperty> hovertextsrc(string val) => Interop.mkBoxAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IBoxProperty> hovertemplatesrc(string val) => Interop.mkBoxAttr("hovertemplatesrc", val);
    }

    public static partial class Box
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IBoxProperty> legendonly() => Interop.mkBoxAttr("visible", "legendonly");
            public static Box<IBoxProperty> _false() => Interop.mkBoxAttr("visible", false);
            public static Box<IBoxProperty> _true() => Interop.mkBoxAttr("visible", true);
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IBoxProperty> all() => Interop.mkBoxAttr("hoverinfo", "all");
            public static Box<IBoxProperty> none() => Interop.mkBoxAttr("hoverinfo", "none");
            public static Box<IBoxProperty> skip() => Interop.mkBoxAttr("hoverinfo", "skip");
            public static Box<IBoxProperty> name() => Interop.mkBoxAttr("hoverinfo", "name");
            public static Box<IBoxProperty> text() => Interop.mkBoxAttr("hoverinfo", "text");
            public static Box<IBoxProperty> x() => Interop.mkBoxAttr("hoverinfo", "x");
            public static Box<IBoxProperty> y() => Interop.mkBoxAttr("hoverinfo", "y");
            public static Box<IBoxProperty> z() => Interop.mkBoxAttr("hoverinfo", "z");
        }

        /// If *outliers*, only the sample points lying outside the whiskers are shown If *suspectedoutliers*, the outlier points are shown and points either less than 4*Q1-3*Q3 or greater than 4*Q3-3*Q1 are highlighted (see `outliercolor`) If *all*, all sample points are shown If *false*, only the box(es) are shown with no sample points
        public static partial class Boxpoints
        {
            public static Box<IBoxProperty> all() => Interop.mkBoxAttr("boxpoints", "all");
            public static Box<IBoxProperty> outliers() => Interop.mkBoxAttr("boxpoints", "outliers");
            public static Box<IBoxProperty> suspectedoutliers() => Interop.mkBoxAttr("boxpoints", "suspectedoutliers");
            public static Box<IBoxProperty> _false() => Interop.mkBoxAttr("boxpoints", false);
        }

        /// If *true*, the mean of the box(es)' underlying distribution is drawn as a dashed line inside the box(es). If *sd* the standard deviation is also drawn.
        public static partial class Boxmean
        {
            public static Box<IBoxProperty> sd() => Interop.mkBoxAttr("boxmean", "sd");
            public static Box<IBoxProperty> _false() => Interop.mkBoxAttr("boxmean", false);
            public static Box<IBoxProperty> _true() => Interop.mkBoxAttr("boxmean", true);
        }

        /// Sets the orientation of the box(es). If *v* (*h*), the distribution is visualized along the vertical (horizontal).
        public static partial class Orientation
        {
            public static Box<IBoxProperty> h() => Interop.mkBoxAttr("orientation", "h");
            public static Box<IBoxProperty> v() => Interop.mkBoxAttr("orientation", "v");
        }

        /// Do the hover effects highlight individual boxes  or sample points or both?
        public static partial class Hoveron
        {
            public static Box<IBoxProperty> boxes() => Interop.mkBoxAttr("hoveron", "boxes");
            public static Box<IBoxProperty> points() => Interop.mkBoxAttr("hoveron", "points");
        }

        /// Sets the calendar system to use with `x` date data.
        public static partial class Xcalendar
        {
            public static Box<IBoxProperty> chinese() => Interop.mkBoxAttr("xcalendar", "chinese");
            public static Box<IBoxProperty> coptic() => Interop.mkBoxAttr("xcalendar", "coptic");
            public static Box<IBoxProperty> discworld() => Interop.mkBoxAttr("xcalendar", "discworld");
            public static Box<IBoxProperty> ethiopian() => Interop.mkBoxAttr("xcalendar", "ethiopian");
            public static Box<IBoxProperty> gregorian() => Interop.mkBoxAttr("xcalendar", "gregorian");
            public static Box<IBoxProperty> hebrew() => Interop.mkBoxAttr("xcalendar", "hebrew");
            public static Box<IBoxProperty> islamic() => Interop.mkBoxAttr("xcalendar", "islamic");
            public static Box<IBoxProperty> jalali() => Interop.mkBoxAttr("xcalendar", "jalali");
            public static Box<IBoxProperty> julian() => Interop.mkBoxAttr("xcalendar", "julian");
            public static Box<IBoxProperty> mayan() => Interop.mkBoxAttr("xcalendar", "mayan");
            public static Box<IBoxProperty> nanakshahi() => Interop.mkBoxAttr("xcalendar", "nanakshahi");
            public static Box<IBoxProperty> nepali() => Interop.mkBoxAttr("xcalendar", "nepali");
            public static Box<IBoxProperty> persian() => Interop.mkBoxAttr("xcalendar", "persian");
            public static Box<IBoxProperty> taiwan() => Interop.mkBoxAttr("xcalendar", "taiwan");
            public static Box<IBoxProperty> thai() => Interop.mkBoxAttr("xcalendar", "thai");
            public static Box<IBoxProperty> ummalqura() => Interop.mkBoxAttr("xcalendar", "ummalqura");
        }

        /// Sets the calendar system to use with `y` date data.
        public static partial class Ycalendar
        {
            public static Box<IBoxProperty> chinese() => Interop.mkBoxAttr("ycalendar", "chinese");
            public static Box<IBoxProperty> coptic() => Interop.mkBoxAttr("ycalendar", "coptic");
            public static Box<IBoxProperty> discworld() => Interop.mkBoxAttr("ycalendar", "discworld");
            public static Box<IBoxProperty> ethiopian() => Interop.mkBoxAttr("ycalendar", "ethiopian");
            public static Box<IBoxProperty> gregorian() => Interop.mkBoxAttr("ycalendar", "gregorian");
            public static Box<IBoxProperty> hebrew() => Interop.mkBoxAttr("ycalendar", "hebrew");
            public static Box<IBoxProperty> islamic() => Interop.mkBoxAttr("ycalendar", "islamic");
            public static Box<IBoxProperty> jalali() => Interop.mkBoxAttr("ycalendar", "jalali");
            public static Box<IBoxProperty> julian() => Interop.mkBoxAttr("ycalendar", "julian");
            public static Box<IBoxProperty> mayan() => Interop.mkBoxAttr("ycalendar", "mayan");
            public static Box<IBoxProperty> nanakshahi() => Interop.mkBoxAttr("ycalendar", "nanakshahi");
            public static Box<IBoxProperty> nepali() => Interop.mkBoxAttr("ycalendar", "nepali");
            public static Box<IBoxProperty> persian() => Interop.mkBoxAttr("ycalendar", "persian");
            public static Box<IBoxProperty> taiwan() => Interop.mkBoxAttr("ycalendar", "taiwan");
            public static Box<IBoxProperty> thai() => Interop.mkBoxAttr("ycalendar", "thai");
            public static Box<IBoxProperty> ummalqura() => Interop.mkBoxAttr("ycalendar", "ummalqura");
        }
    }
}