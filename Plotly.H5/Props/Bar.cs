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

    public static partial class Bar
    {
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IBarProperty> showlegend(bool val) => Interop.mkBarAttr("showlegend", val);
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IBarProperty> legendgroup(string val) => Interop.mkBarAttr("legendgroup", val);
        /// Sets the opacity of the trace.
        public static Box<IBarProperty> opacity(int val) => Interop.mkBarAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<IBarProperty> opacity(float val) => Interop.mkBarAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IBarProperty> name(string val) => Interop.mkBarAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IBarProperty> uid(string val) => Interop.mkBarAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarProperty> ids(bool val) => Interop.mkBarAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarProperty> ids(params bool[] values) => Interop.mkBarAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarProperty> ids(System.DateTime val) => Interop.mkBarAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarProperty> ids(params System.DateTime[] values) => Interop.mkBarAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarProperty> ids(float val) => Interop.mkBarAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarProperty> ids(params float[] values) => Interop.mkBarAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarProperty> ids(int val) => Interop.mkBarAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarProperty> ids(params int[] values) => Interop.mkBarAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarProperty> ids(string val) => Interop.mkBarAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarProperty> ids(params string[] values) => Interop.mkBarAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarProperty> ids(IEnumerable<bool[]> values) => Interop.mkBarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarProperty> ids(List<bool[]> values) => Interop.mkBarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarProperty> ids(params bool[][] values) => Interop.mkBarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkBarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarProperty> ids(List<string[]> values) => Interop.mkBarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarProperty> ids(params string[][] values) => Interop.mkBarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkBarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarProperty> ids(List<int[]> values) => Interop.mkBarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarProperty> ids(params int[][] values) => Interop.mkBarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkBarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarProperty> ids(List<float[]> values) => Interop.mkBarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarProperty> ids(params float[][] values) => Interop.mkBarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarProperty> ids(Literals.PlotData[] values) => Interop.mkBarAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarProperty> ids(IEnumerable<bool?> values) => Interop.mkBarAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkBarAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarProperty> ids(IEnumerable<int?> values) => Interop.mkBarAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarProperty> ids(IEnumerable<float?> values) => Interop.mkBarAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarProperty> customdata(bool val) => Interop.mkBarAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarProperty> customdata(params bool[] values) => Interop.mkBarAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarProperty> customdata(System.DateTime val) => Interop.mkBarAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarProperty> customdata(params System.DateTime[] values) => Interop.mkBarAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarProperty> customdata(float val) => Interop.mkBarAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarProperty> customdata(params float[] values) => Interop.mkBarAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarProperty> customdata(int val) => Interop.mkBarAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarProperty> customdata(params int[] values) => Interop.mkBarAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarProperty> customdata(string val) => Interop.mkBarAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarProperty> customdata(params string[] values) => Interop.mkBarAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarProperty> customdata(IEnumerable<bool[]> values) => Interop.mkBarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarProperty> customdata(List<bool[]> values) => Interop.mkBarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarProperty> customdata(params bool[][] values) => Interop.mkBarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkBarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarProperty> customdata(List<string[]> values) => Interop.mkBarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarProperty> customdata(params string[][] values) => Interop.mkBarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkBarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarProperty> customdata(List<int[]> values) => Interop.mkBarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarProperty> customdata(params int[][] values) => Interop.mkBarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkBarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarProperty> customdata(List<float[]> values) => Interop.mkBarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarProperty> customdata(params float[][] values) => Interop.mkBarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarProperty> customdata(Literals.PlotData[] values) => Interop.mkBarAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarProperty> customdata(IEnumerable<bool?> values) => Interop.mkBarAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkBarAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarProperty> customdata(IEnumerable<int?> values) => Interop.mkBarAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarProperty> customdata(IEnumerable<float?> values) => Interop.mkBarAttr("customdata", values.ToArray());
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBarProperty> selectedpoints(bool val) => Interop.mkBarAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBarProperty> selectedpoints(params bool[] values) => Interop.mkBarAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBarProperty> selectedpoints(System.DateTime val) => Interop.mkBarAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBarProperty> selectedpoints(params System.DateTime[] values) => Interop.mkBarAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBarProperty> selectedpoints(int val) => Interop.mkBarAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBarProperty> selectedpoints(params int[] values) => Interop.mkBarAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBarProperty> selectedpoints(float val) => Interop.mkBarAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBarProperty> selectedpoints(params float[] values) => Interop.mkBarAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBarProperty> selectedpoints(string val) => Interop.mkBarAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBarProperty> selectedpoints(params string[] values) => Interop.mkBarAttr("selectedpoints", values);
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IBarProperty> hoverinfo(params Box<IBarProperty>[] properties) => Interop.mkBarAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        public static Box<IBarProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkBarAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IBarProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkBarAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IBarProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkBarAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBarProperty> uirevision(bool val) => Interop.mkBarAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBarProperty> uirevision(params bool[] values) => Interop.mkBarAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBarProperty> uirevision(System.DateTime val) => Interop.mkBarAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBarProperty> uirevision(params System.DateTime[] values) => Interop.mkBarAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBarProperty> uirevision(int val) => Interop.mkBarAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBarProperty> uirevision(params int[] values) => Interop.mkBarAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBarProperty> uirevision(float val) => Interop.mkBarAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBarProperty> uirevision(params float[] values) => Interop.mkBarAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBarProperty> uirevision(string val) => Interop.mkBarAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBarProperty> uirevision(params string[] values) => Interop.mkBarAttr("uirevision", values);
        /// Sets the x coordinates.
        public static Box<IBarProperty> x(bool val) => Interop.mkBarAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IBarProperty> x(IEnumerable<bool> values) => Interop.mkBarAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IBarProperty> x(System.DateTime val) => Interop.mkBarAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IBarProperty> x(IEnumerable<System.DateTime> values) => Interop.mkBarAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IBarProperty> x(float val) => Interop.mkBarAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IBarProperty> x(IEnumerable<float> values) => Interop.mkBarAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IBarProperty> x(int val) => Interop.mkBarAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IBarProperty> x(IEnumerable<int> values) => Interop.mkBarAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IBarProperty> x(string val) => Interop.mkBarAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IBarProperty> x(IEnumerable<string> values) => Interop.mkBarAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IBarProperty> x(IEnumerable<bool[]> values) => Interop.mkBarAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IBarProperty> x(List<bool[]> values) => Interop.mkBarAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IBarProperty> x(params bool[][] values) => Interop.mkBarAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IBarProperty> x(IEnumerable<IEnumerable<string>> values) => Interop.mkBarAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IBarProperty> x(List<string[]> values) => Interop.mkBarAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IBarProperty> x(params string[][] values) => Interop.mkBarAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IBarProperty> x(IEnumerable<IEnumerable<int>> values) => Interop.mkBarAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IBarProperty> x(List<int[]> values) => Interop.mkBarAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IBarProperty> x(params int[][] values) => Interop.mkBarAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IBarProperty> x(IEnumerable<IEnumerable<float>> values) => Interop.mkBarAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IBarProperty> x(List<float[]> values) => Interop.mkBarAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IBarProperty> x(params float[][] values) => Interop.mkBarAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IBarProperty> x(Literals.PlotData[] values) => Interop.mkBarAttr("x", values);
        /// Sets the x coordinates.
        public static Box<IBarProperty> x(IEnumerable<bool?> values) => Interop.mkBarAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IBarProperty> x(IEnumerable<System.DateTime?> values) => Interop.mkBarAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IBarProperty> x(IEnumerable<int?> values) => Interop.mkBarAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IBarProperty> x(IEnumerable<float?> values) => Interop.mkBarAttr("x", values.ToArray());
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IBarProperty> x0(bool val) => Interop.mkBarAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IBarProperty> x0(params bool[] values) => Interop.mkBarAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IBarProperty> x0(System.DateTime val) => Interop.mkBarAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IBarProperty> x0(params System.DateTime[] values) => Interop.mkBarAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IBarProperty> x0(int val) => Interop.mkBarAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IBarProperty> x0(params int[] values) => Interop.mkBarAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IBarProperty> x0(float val) => Interop.mkBarAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IBarProperty> x0(params float[] values) => Interop.mkBarAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IBarProperty> x0(string val) => Interop.mkBarAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IBarProperty> x0(params string[] values) => Interop.mkBarAttr("x0", values);
        /// Sets the x coordinate step. See `x0` for more info.
        public static Box<IBarProperty> dx(int val) => Interop.mkBarAttr("dx", val);
        /// Sets the x coordinate step. See `x0` for more info.
        public static Box<IBarProperty> dx(float val) => Interop.mkBarAttr("dx", val);
        /// Sets the y coordinates.
        public static Box<IBarProperty> y(bool val) => Interop.mkBarAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IBarProperty> y(IEnumerable<bool> values) => Interop.mkBarAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IBarProperty> y(System.DateTime val) => Interop.mkBarAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IBarProperty> y(IEnumerable<System.DateTime> values) => Interop.mkBarAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IBarProperty> y(float val) => Interop.mkBarAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IBarProperty> y(IEnumerable<float> values) => Interop.mkBarAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IBarProperty> y(int val) => Interop.mkBarAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IBarProperty> y(IEnumerable<int> values) => Interop.mkBarAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IBarProperty> y(string val) => Interop.mkBarAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IBarProperty> y(IEnumerable<string> values) => Interop.mkBarAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IBarProperty> y(IEnumerable<bool[]> values) => Interop.mkBarAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IBarProperty> y(List<bool[]> values) => Interop.mkBarAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IBarProperty> y(params bool[][] values) => Interop.mkBarAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IBarProperty> y(IEnumerable<IEnumerable<string>> values) => Interop.mkBarAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IBarProperty> y(List<string[]> values) => Interop.mkBarAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IBarProperty> y(params string[][] values) => Interop.mkBarAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IBarProperty> y(IEnumerable<IEnumerable<int>> values) => Interop.mkBarAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IBarProperty> y(List<int[]> values) => Interop.mkBarAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IBarProperty> y(params int[][] values) => Interop.mkBarAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IBarProperty> y(IEnumerable<IEnumerable<float>> values) => Interop.mkBarAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IBarProperty> y(List<float[]> values) => Interop.mkBarAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IBarProperty> y(params float[][] values) => Interop.mkBarAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IBarProperty> y(Literals.PlotData[] values) => Interop.mkBarAttr("y", values);
        /// Sets the y coordinates.
        public static Box<IBarProperty> y(IEnumerable<bool?> values) => Interop.mkBarAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IBarProperty> y(IEnumerable<System.DateTime?> values) => Interop.mkBarAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IBarProperty> y(IEnumerable<int?> values) => Interop.mkBarAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IBarProperty> y(IEnumerable<float?> values) => Interop.mkBarAttr("y", values.ToArray());
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IBarProperty> y0(bool val) => Interop.mkBarAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IBarProperty> y0(params bool[] values) => Interop.mkBarAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IBarProperty> y0(System.DateTime val) => Interop.mkBarAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IBarProperty> y0(params System.DateTime[] values) => Interop.mkBarAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IBarProperty> y0(int val) => Interop.mkBarAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IBarProperty> y0(params int[] values) => Interop.mkBarAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IBarProperty> y0(float val) => Interop.mkBarAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IBarProperty> y0(params float[] values) => Interop.mkBarAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IBarProperty> y0(string val) => Interop.mkBarAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IBarProperty> y0(params string[] values) => Interop.mkBarAttr("y0", values);
        /// Sets the y coordinate step. See `y0` for more info.
        public static Box<IBarProperty> dy(int val) => Interop.mkBarAttr("dy", val);
        /// Sets the y coordinate step. See `y0` for more info.
        public static Box<IBarProperty> dy(float val) => Interop.mkBarAttr("dy", val);
        /// Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IBarProperty> text(string val) => Interop.mkBarAttr("text", val);
        /// Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IBarProperty> text(IEnumerable<string> values) => Interop.mkBarAttr("text", values.ToArray());
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `value` and `label`.
        public static Box<IBarProperty> texttemplate(string val) => Interop.mkBarAttr("texttemplate", val);
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `value` and `label`.
        public static Box<IBarProperty> texttemplate(IEnumerable<string> values) => Interop.mkBarAttr("texttemplate", values.ToArray());
        /// Sets hover text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IBarProperty> hovertext(string val) => Interop.mkBarAttr("hovertext", val);
        /// Sets hover text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IBarProperty> hovertext(IEnumerable<string> values) => Interop.mkBarAttr("hovertext", values.ToArray());
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `value` and `label`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IBarProperty> hovertemplate(string val) => Interop.mkBarAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `value` and `label`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IBarProperty> hovertemplate(IEnumerable<string> values) => Interop.mkBarAttr("hovertemplate", values.ToArray());
        /// Specifies the location of the `text`. *inside* positions `text` inside, next to the bar end (rotated and scaled if needed). *outside* positions `text` outside, next to the bar end (scaled if needed), unless there is another bar stacked on this one, then the text gets pushed inside. *auto* tries to position `text` inside the bar, but if the bar is too small and no bar is stacked on this one the text is moved outside.
        public static Box<IBarProperty> textposition(IEnumerable<Box<IBarProperty>> properties) => Interop.mkBarAttr("textposition", Bindings.flattenProperties(properties));
        /// Sets the angle of the tick labels with respect to the bar. For example, a `tickangle` of -90 draws the tick labels vertically. With *auto* the texts may automatically be rotated to fit with the maximum size in bars.
        public static Box<IBarProperty> textangle(int val) => Interop.mkBarAttr("textangle", val);
        /// Sets the angle of the tick labels with respect to the bar. For example, a `tickangle` of -90 draws the tick labels vertically. With *auto* the texts may automatically be rotated to fit with the maximum size in bars.
        public static Box<IBarProperty> textangle(float val) => Interop.mkBarAttr("textangle", val);
        /// Sets the font used for `text`.
        public static Box<IBarProperty> textfont(params Box<ITextfontProperty>[] properties) => Interop.mkBarAttr("textfont", Bindings.flattenProperties(properties));
        /// Sets the font used for `text` lying inside the bar.
        public static Box<IBarProperty> insidetextfont(params Box<IInsidetextfontProperty>[] properties) => Interop.mkBarAttr("insidetextfont", Bindings.flattenProperties(properties));
        /// Sets the font used for `text` lying outside the bar.
        public static Box<IBarProperty> outsidetextfont(params Box<IOutsidetextfontProperty>[] properties) => Interop.mkBarAttr("outsidetextfont", Bindings.flattenProperties(properties));
        /// Determines whether the text nodes are clipped about the subplot axes. To show the text nodes above axis lines and tick labels, make sure to set `xaxis.layer` and `yaxis.layer` to *below traces*.
        public static Box<IBarProperty> cliponaxis(bool val) => Interop.mkBarAttr("cliponaxis", val);
        /// Sets where the bar base is drawn (in position axis units). In *stack* or *relative* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
        public static Box<IBarProperty> _base(bool val) => Interop.mkBarAttr("base", val);
        /// Sets where the bar base is drawn (in position axis units). In *stack* or *relative* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
        public static Box<IBarProperty> _base(params bool[] values) => Interop.mkBarAttr("base", values);
        /// Sets where the bar base is drawn (in position axis units). In *stack* or *relative* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
        public static Box<IBarProperty> _base(System.DateTime val) => Interop.mkBarAttr("base", val);
        /// Sets where the bar base is drawn (in position axis units). In *stack* or *relative* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
        public static Box<IBarProperty> _base(params System.DateTime[] values) => Interop.mkBarAttr("base", values);
        /// Sets where the bar base is drawn (in position axis units). In *stack* or *relative* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
        public static Box<IBarProperty> _base(int val) => Interop.mkBarAttr("base", val);
        /// Sets where the bar base is drawn (in position axis units). In *stack* or *relative* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
        public static Box<IBarProperty> _base(params int[] values) => Interop.mkBarAttr("base", values);
        /// Sets where the bar base is drawn (in position axis units). In *stack* or *relative* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
        public static Box<IBarProperty> _base(float val) => Interop.mkBarAttr("base", val);
        /// Sets where the bar base is drawn (in position axis units). In *stack* or *relative* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
        public static Box<IBarProperty> _base(params float[] values) => Interop.mkBarAttr("base", values);
        /// Sets where the bar base is drawn (in position axis units). In *stack* or *relative* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
        public static Box<IBarProperty> _base(string val) => Interop.mkBarAttr("base", val);
        /// Sets where the bar base is drawn (in position axis units). In *stack* or *relative* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
        public static Box<IBarProperty> _base(params string[] values) => Interop.mkBarAttr("base", values);
        /// Shifts the position where the bar is drawn (in position axis units). In *group* barmode, traces that set *offset* will be excluded and drawn in *overlay* mode instead.
        public static Box<IBarProperty> offset(int val) => Interop.mkBarAttr("offset", val);
        /// Shifts the position where the bar is drawn (in position axis units). In *group* barmode, traces that set *offset* will be excluded and drawn in *overlay* mode instead.
        public static Box<IBarProperty> offset(float val) => Interop.mkBarAttr("offset", val);
        /// Shifts the position where the bar is drawn (in position axis units). In *group* barmode, traces that set *offset* will be excluded and drawn in *overlay* mode instead.
        public static Box<IBarProperty> offset(IEnumerable<int> values) => Interop.mkBarAttr("offset", values.ToArray());
        /// Shifts the position where the bar is drawn (in position axis units). In *group* barmode, traces that set *offset* will be excluded and drawn in *overlay* mode instead.
        public static Box<IBarProperty> offset(IEnumerable<float> values) => Interop.mkBarAttr("offset", values.ToArray());
        /// Sets the bar width (in position axis units).
        public static Box<IBarProperty> width(int val) => Interop.mkBarAttr("width", val);
        /// Sets the bar width (in position axis units).
        public static Box<IBarProperty> width(float val) => Interop.mkBarAttr("width", val);
        /// Sets the bar width (in position axis units).
        public static Box<IBarProperty> width(IEnumerable<int> values) => Interop.mkBarAttr("width", values.ToArray());
        /// Sets the bar width (in position axis units).
        public static Box<IBarProperty> width(IEnumerable<float> values) => Interop.mkBarAttr("width", values.ToArray());
        public static Box<IBarProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkBarAttr("marker", Bindings.flattenProperties(properties));
        /// Set several traces linked to the same position axis or matching axes to the same offsetgroup where bars of the same position coordinate will line up.
        public static Box<IBarProperty> offsetgroup(string val) => Interop.mkBarAttr("offsetgroup", val);
        /// Set several traces linked to the same position axis or matching axes to the same alignmentgroup. This controls whether bars compute their positional range dependently or independently.
        public static Box<IBarProperty> alignmentgroup(string val) => Interop.mkBarAttr("alignmentgroup", val);
        public static Box<IBarProperty> selected(params Box<ISelectedProperty>[] properties) => Interop.mkBarAttr("selected", Bindings.flattenProperties(properties));
        public static Box<IBarProperty> unselected(params Box<IUnselectedProperty>[] properties) => Interop.mkBarAttr("unselected", Bindings.flattenProperties(properties));
        public static Box<IBarProperty> errorX(params Box<IErrorXProperty>[] properties) => Interop.mkBarAttr("error_x", Bindings.flattenProperties(properties));
        public static Box<IBarProperty> errorY(params Box<IErrorYProperty>[] properties) => Interop.mkBarAttr("error_y", Bindings.flattenProperties(properties));
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IBarProperty> xaxis(int anchorId) => Interop.mkBarAttr("xaxis", anchorId > 1 ? $"x{anchorId}" : "");
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IBarProperty> xaxis(string val) => Interop.mkBarAttr("xaxis", val);
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IBarProperty> yaxis(int anchorId) => Interop.mkBarAttr("yaxis", anchorId > 1 ? $"y{anchorId}" : "");
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IBarProperty> yaxis(string val) => Interop.mkBarAttr("yaxis", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IBarProperty> idssrc(string val) => Interop.mkBarAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IBarProperty> customdatasrc(string val) => Interop.mkBarAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IBarProperty> metasrc(string val) => Interop.mkBarAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IBarProperty> hoverinfosrc(string val) => Interop.mkBarAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  x .
        public static Box<IBarProperty> xsrc(string val) => Interop.mkBarAttr("xsrc", val);
        /// Sets the source reference on plot.ly for  y .
        public static Box<IBarProperty> ysrc(string val) => Interop.mkBarAttr("ysrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IBarProperty> textsrc(string val) => Interop.mkBarAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  texttemplate .
        public static Box<IBarProperty> texttemplatesrc(string val) => Interop.mkBarAttr("texttemplatesrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IBarProperty> hovertextsrc(string val) => Interop.mkBarAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IBarProperty> hovertemplatesrc(string val) => Interop.mkBarAttr("hovertemplatesrc", val);
        /// Sets the source reference on plot.ly for  textposition .
        public static Box<IBarProperty> textpositionsrc(string val) => Interop.mkBarAttr("textpositionsrc", val);
        /// Sets the source reference on plot.ly for  base .
        public static Box<IBarProperty> basesrc(string val) => Interop.mkBarAttr("basesrc", val);
        /// Sets the source reference on plot.ly for  offset .
        public static Box<IBarProperty> offsetsrc(string val) => Interop.mkBarAttr("offsetsrc", val);
        /// Sets the source reference on plot.ly for  width .
        public static Box<IBarProperty> widthsrc(string val) => Interop.mkBarAttr("widthsrc", val);
        /// Sets the source reference on plot.ly for  r .
        public static Box<IBarProperty> rsrc(string val) => Interop.mkBarAttr("rsrc", val);
        /// Sets the source reference on plot.ly for  t .
        public static Box<IBarProperty> tsrc(string val) => Interop.mkBarAttr("tsrc", val);
        /// Sets the background color of the arc.
        public static Box<IBarProperty> color(string val) => Interop.mkBarAttr("color", val);
        public static Box<IBarProperty> line(params Box<ILineProperty>[] properties) => Interop.mkBarAttr("line", Bindings.flattenProperties(properties));
        /// Sets the thickness of the bar as a fraction of the total thickness of the gauge.
        public static Box<IBarProperty> thickness(int val) => Interop.mkBarAttr("thickness", val);
        /// Sets the thickness of the bar as a fraction of the total thickness of the gauge.
        public static Box<IBarProperty> thickness(float val) => Interop.mkBarAttr("thickness", val);
    }

    public static partial class Bar
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IBarProperty> legendonly() => Interop.mkBarAttr("visible", "legendonly");
            public static Box<IBarProperty> _false() => Interop.mkBarAttr("visible", false);
            public static Box<IBarProperty> _true() => Interop.mkBarAttr("visible", true);
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IBarProperty> all() => Interop.mkBarAttr("hoverinfo", "all");
            public static Box<IBarProperty> none() => Interop.mkBarAttr("hoverinfo", "none");
            public static Box<IBarProperty> skip() => Interop.mkBarAttr("hoverinfo", "skip");
            public static Box<IBarProperty> name() => Interop.mkBarAttr("hoverinfo", "name");
            public static Box<IBarProperty> text() => Interop.mkBarAttr("hoverinfo", "text");
            public static Box<IBarProperty> x() => Interop.mkBarAttr("hoverinfo", "x");
            public static Box<IBarProperty> y() => Interop.mkBarAttr("hoverinfo", "y");
            public static Box<IBarProperty> z() => Interop.mkBarAttr("hoverinfo", "z");
        }

        /// Specifies the location of the `text`. *inside* positions `text` inside, next to the bar end (rotated and scaled if needed). *outside* positions `text` outside, next to the bar end (scaled if needed), unless there is another bar stacked on this one, then the text gets pushed inside. *auto* tries to position `text` inside the bar, but if the bar is too small and no bar is stacked on this one the text is moved outside.
        public static partial class Textposition
        {
            public static Box<IBarProperty> auto() => Interop.mkBarAttr("textposition", "auto");
            public static Box<IBarProperty> inside() => Interop.mkBarAttr("textposition", "inside");
            public static Box<IBarProperty> none() => Interop.mkBarAttr("textposition", "none");
            public static Box<IBarProperty> outside() => Interop.mkBarAttr("textposition", "outside");
        }

        /// Determines if texts are kept at center or start/end points in `textposition` *inside* mode.
        public static partial class Insidetextanchor
        {
            public static Box<IBarProperty> _end() => Interop.mkBarAttr("insidetextanchor", "end");
            public static Box<IBarProperty> middle() => Interop.mkBarAttr("insidetextanchor", "middle");
            public static Box<IBarProperty> start() => Interop.mkBarAttr("insidetextanchor", "start");
        }

        /// Constrain the size of text inside or outside a bar to be no larger than the bar itself.
        public static partial class Constraintext
        {
            public static Box<IBarProperty> both() => Interop.mkBarAttr("constraintext", "both");
            public static Box<IBarProperty> inside() => Interop.mkBarAttr("constraintext", "inside");
            public static Box<IBarProperty> none() => Interop.mkBarAttr("constraintext", "none");
            public static Box<IBarProperty> outside() => Interop.mkBarAttr("constraintext", "outside");
        }

        /// Sets the orientation of the bars. With *v* (*h*), the value of the each bar spans along the vertical (horizontal).
        public static partial class Orientation
        {
            public static Box<IBarProperty> h() => Interop.mkBarAttr("orientation", "h");
            public static Box<IBarProperty> v() => Interop.mkBarAttr("orientation", "v");
        }

        /// Sets the calendar system to use with `x` date data.
        public static partial class Xcalendar
        {
            public static Box<IBarProperty> chinese() => Interop.mkBarAttr("xcalendar", "chinese");
            public static Box<IBarProperty> coptic() => Interop.mkBarAttr("xcalendar", "coptic");
            public static Box<IBarProperty> discworld() => Interop.mkBarAttr("xcalendar", "discworld");
            public static Box<IBarProperty> ethiopian() => Interop.mkBarAttr("xcalendar", "ethiopian");
            public static Box<IBarProperty> gregorian() => Interop.mkBarAttr("xcalendar", "gregorian");
            public static Box<IBarProperty> hebrew() => Interop.mkBarAttr("xcalendar", "hebrew");
            public static Box<IBarProperty> islamic() => Interop.mkBarAttr("xcalendar", "islamic");
            public static Box<IBarProperty> jalali() => Interop.mkBarAttr("xcalendar", "jalali");
            public static Box<IBarProperty> julian() => Interop.mkBarAttr("xcalendar", "julian");
            public static Box<IBarProperty> mayan() => Interop.mkBarAttr("xcalendar", "mayan");
            public static Box<IBarProperty> nanakshahi() => Interop.mkBarAttr("xcalendar", "nanakshahi");
            public static Box<IBarProperty> nepali() => Interop.mkBarAttr("xcalendar", "nepali");
            public static Box<IBarProperty> persian() => Interop.mkBarAttr("xcalendar", "persian");
            public static Box<IBarProperty> taiwan() => Interop.mkBarAttr("xcalendar", "taiwan");
            public static Box<IBarProperty> thai() => Interop.mkBarAttr("xcalendar", "thai");
            public static Box<IBarProperty> ummalqura() => Interop.mkBarAttr("xcalendar", "ummalqura");
        }

        /// Sets the calendar system to use with `y` date data.
        public static partial class Ycalendar
        {
            public static Box<IBarProperty> chinese() => Interop.mkBarAttr("ycalendar", "chinese");
            public static Box<IBarProperty> coptic() => Interop.mkBarAttr("ycalendar", "coptic");
            public static Box<IBarProperty> discworld() => Interop.mkBarAttr("ycalendar", "discworld");
            public static Box<IBarProperty> ethiopian() => Interop.mkBarAttr("ycalendar", "ethiopian");
            public static Box<IBarProperty> gregorian() => Interop.mkBarAttr("ycalendar", "gregorian");
            public static Box<IBarProperty> hebrew() => Interop.mkBarAttr("ycalendar", "hebrew");
            public static Box<IBarProperty> islamic() => Interop.mkBarAttr("ycalendar", "islamic");
            public static Box<IBarProperty> jalali() => Interop.mkBarAttr("ycalendar", "jalali");
            public static Box<IBarProperty> julian() => Interop.mkBarAttr("ycalendar", "julian");
            public static Box<IBarProperty> mayan() => Interop.mkBarAttr("ycalendar", "mayan");
            public static Box<IBarProperty> nanakshahi() => Interop.mkBarAttr("ycalendar", "nanakshahi");
            public static Box<IBarProperty> nepali() => Interop.mkBarAttr("ycalendar", "nepali");
            public static Box<IBarProperty> persian() => Interop.mkBarAttr("ycalendar", "persian");
            public static Box<IBarProperty> taiwan() => Interop.mkBarAttr("ycalendar", "taiwan");
            public static Box<IBarProperty> thai() => Interop.mkBarAttr("ycalendar", "thai");
            public static Box<IBarProperty> ummalqura() => Interop.mkBarAttr("ycalendar", "ummalqura");
        }
    }
}