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

    public static partial class Scattergl
    {
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IScatterglProperty> showlegend(bool val) => Interop.mkScatterglAttr("showlegend", val);
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IScatterglProperty> legendgroup(string val) => Interop.mkScatterglAttr("legendgroup", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IScatterglProperty> name(string val) => Interop.mkScatterglAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IScatterglProperty> uid(string val) => Interop.mkScatterglAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterglProperty> ids(bool val) => Interop.mkScatterglAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterglProperty> ids(params bool[] values) => Interop.mkScatterglAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterglProperty> ids(System.DateTime val) => Interop.mkScatterglAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterglProperty> ids(params System.DateTime[] values) => Interop.mkScatterglAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterglProperty> ids(float val) => Interop.mkScatterglAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterglProperty> ids(params float[] values) => Interop.mkScatterglAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterglProperty> ids(int val) => Interop.mkScatterglAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterglProperty> ids(params int[] values) => Interop.mkScatterglAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterglProperty> ids(string val) => Interop.mkScatterglAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterglProperty> ids(params string[] values) => Interop.mkScatterglAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterglProperty> ids(IEnumerable<bool[]> values) => Interop.mkScatterglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterglProperty> ids(List<bool[]> values) => Interop.mkScatterglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterglProperty> ids(params bool[][] values) => Interop.mkScatterglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterglProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkScatterglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterglProperty> ids(List<string[]> values) => Interop.mkScatterglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterglProperty> ids(params string[][] values) => Interop.mkScatterglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterglProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkScatterglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterglProperty> ids(List<int[]> values) => Interop.mkScatterglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterglProperty> ids(params int[][] values) => Interop.mkScatterglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterglProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkScatterglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterglProperty> ids(List<float[]> values) => Interop.mkScatterglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterglProperty> ids(params float[][] values) => Interop.mkScatterglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterglProperty> ids(Literals.PlotData[] values) => Interop.mkScatterglAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterglProperty> ids(IEnumerable<bool?> values) => Interop.mkScatterglAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterglProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkScatterglAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterglProperty> ids(IEnumerable<int?> values) => Interop.mkScatterglAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterglProperty> ids(IEnumerable<float?> values) => Interop.mkScatterglAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterglProperty> customdata(bool val) => Interop.mkScatterglAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterglProperty> customdata(params bool[] values) => Interop.mkScatterglAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterglProperty> customdata(System.DateTime val) => Interop.mkScatterglAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterglProperty> customdata(params System.DateTime[] values) => Interop.mkScatterglAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterglProperty> customdata(float val) => Interop.mkScatterglAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterglProperty> customdata(params float[] values) => Interop.mkScatterglAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterglProperty> customdata(int val) => Interop.mkScatterglAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterglProperty> customdata(params int[] values) => Interop.mkScatterglAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterglProperty> customdata(string val) => Interop.mkScatterglAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterglProperty> customdata(params string[] values) => Interop.mkScatterglAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterglProperty> customdata(IEnumerable<bool[]> values) => Interop.mkScatterglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterglProperty> customdata(List<bool[]> values) => Interop.mkScatterglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterglProperty> customdata(params bool[][] values) => Interop.mkScatterglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterglProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkScatterglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterglProperty> customdata(List<string[]> values) => Interop.mkScatterglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterglProperty> customdata(params string[][] values) => Interop.mkScatterglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterglProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkScatterglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterglProperty> customdata(List<int[]> values) => Interop.mkScatterglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterglProperty> customdata(params int[][] values) => Interop.mkScatterglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterglProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkScatterglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterglProperty> customdata(List<float[]> values) => Interop.mkScatterglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterglProperty> customdata(params float[][] values) => Interop.mkScatterglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterglProperty> customdata(Literals.PlotData[] values) => Interop.mkScatterglAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterglProperty> customdata(IEnumerable<bool?> values) => Interop.mkScatterglAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterglProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkScatterglAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterglProperty> customdata(IEnumerable<int?> values) => Interop.mkScatterglAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterglProperty> customdata(IEnumerable<float?> values) => Interop.mkScatterglAttr("customdata", values.ToArray());
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterglProperty> selectedpoints(bool val) => Interop.mkScatterglAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterglProperty> selectedpoints(params bool[] values) => Interop.mkScatterglAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterglProperty> selectedpoints(System.DateTime val) => Interop.mkScatterglAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterglProperty> selectedpoints(params System.DateTime[] values) => Interop.mkScatterglAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterglProperty> selectedpoints(int val) => Interop.mkScatterglAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterglProperty> selectedpoints(params int[] values) => Interop.mkScatterglAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterglProperty> selectedpoints(float val) => Interop.mkScatterglAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterglProperty> selectedpoints(params float[] values) => Interop.mkScatterglAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterglProperty> selectedpoints(string val) => Interop.mkScatterglAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterglProperty> selectedpoints(params string[] values) => Interop.mkScatterglAttr("selectedpoints", values);
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IScatterglProperty> hoverinfo(params Box<IScatterglProperty>[] properties) => Interop.mkScatterglAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        public static Box<IScatterglProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkScatterglAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IScatterglProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkScatterglAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IScatterglProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkScatterglAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterglProperty> uirevision(bool val) => Interop.mkScatterglAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterglProperty> uirevision(params bool[] values) => Interop.mkScatterglAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterglProperty> uirevision(System.DateTime val) => Interop.mkScatterglAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterglProperty> uirevision(params System.DateTime[] values) => Interop.mkScatterglAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterglProperty> uirevision(int val) => Interop.mkScatterglAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterglProperty> uirevision(params int[] values) => Interop.mkScatterglAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterglProperty> uirevision(float val) => Interop.mkScatterglAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterglProperty> uirevision(params float[] values) => Interop.mkScatterglAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterglProperty> uirevision(string val) => Interop.mkScatterglAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterglProperty> uirevision(params string[] values) => Interop.mkScatterglAttr("uirevision", values);
        /// Sets the x coordinates.
        public static Box<IScatterglProperty> x(bool val) => Interop.mkScatterglAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IScatterglProperty> x(IEnumerable<bool> values) => Interop.mkScatterglAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IScatterglProperty> x(System.DateTime val) => Interop.mkScatterglAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IScatterglProperty> x(IEnumerable<System.DateTime> values) => Interop.mkScatterglAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IScatterglProperty> x(float val) => Interop.mkScatterglAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IScatterglProperty> x(IEnumerable<float> values) => Interop.mkScatterglAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IScatterglProperty> x(int val) => Interop.mkScatterglAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IScatterglProperty> x(IEnumerable<int> values) => Interop.mkScatterglAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IScatterglProperty> x(string val) => Interop.mkScatterglAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IScatterglProperty> x(IEnumerable<string> values) => Interop.mkScatterglAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IScatterglProperty> x(IEnumerable<bool[]> values) => Interop.mkScatterglAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatterglProperty> x(List<bool[]> values) => Interop.mkScatterglAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatterglProperty> x(params bool[][] values) => Interop.mkScatterglAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatterglProperty> x(IEnumerable<IEnumerable<string>> values) => Interop.mkScatterglAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatterglProperty> x(List<string[]> values) => Interop.mkScatterglAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatterglProperty> x(params string[][] values) => Interop.mkScatterglAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatterglProperty> x(IEnumerable<IEnumerable<int>> values) => Interop.mkScatterglAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatterglProperty> x(List<int[]> values) => Interop.mkScatterglAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatterglProperty> x(params int[][] values) => Interop.mkScatterglAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatterglProperty> x(IEnumerable<IEnumerable<float>> values) => Interop.mkScatterglAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatterglProperty> x(List<float[]> values) => Interop.mkScatterglAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatterglProperty> x(params float[][] values) => Interop.mkScatterglAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatterglProperty> x(Literals.PlotData[] values) => Interop.mkScatterglAttr("x", values);
        /// Sets the x coordinates.
        public static Box<IScatterglProperty> x(IEnumerable<bool?> values) => Interop.mkScatterglAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IScatterglProperty> x(IEnumerable<System.DateTime?> values) => Interop.mkScatterglAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IScatterglProperty> x(IEnumerable<int?> values) => Interop.mkScatterglAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IScatterglProperty> x(IEnumerable<float?> values) => Interop.mkScatterglAttr("x", values.ToArray());
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IScatterglProperty> x0(bool val) => Interop.mkScatterglAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IScatterglProperty> x0(params bool[] values) => Interop.mkScatterglAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IScatterglProperty> x0(System.DateTime val) => Interop.mkScatterglAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IScatterglProperty> x0(params System.DateTime[] values) => Interop.mkScatterglAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IScatterglProperty> x0(int val) => Interop.mkScatterglAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IScatterglProperty> x0(params int[] values) => Interop.mkScatterglAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IScatterglProperty> x0(float val) => Interop.mkScatterglAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IScatterglProperty> x0(params float[] values) => Interop.mkScatterglAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IScatterglProperty> x0(string val) => Interop.mkScatterglAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IScatterglProperty> x0(params string[] values) => Interop.mkScatterglAttr("x0", values);
        /// Sets the x coordinate step. See `x0` for more info.
        public static Box<IScatterglProperty> dx(int val) => Interop.mkScatterglAttr("dx", val);
        /// Sets the x coordinate step. See `x0` for more info.
        public static Box<IScatterglProperty> dx(float val) => Interop.mkScatterglAttr("dx", val);
        /// Sets the y coordinates.
        public static Box<IScatterglProperty> y(bool val) => Interop.mkScatterglAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IScatterglProperty> y(IEnumerable<bool> values) => Interop.mkScatterglAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IScatterglProperty> y(System.DateTime val) => Interop.mkScatterglAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IScatterglProperty> y(IEnumerable<System.DateTime> values) => Interop.mkScatterglAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IScatterglProperty> y(float val) => Interop.mkScatterglAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IScatterglProperty> y(IEnumerable<float> values) => Interop.mkScatterglAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IScatterglProperty> y(int val) => Interop.mkScatterglAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IScatterglProperty> y(IEnumerable<int> values) => Interop.mkScatterglAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IScatterglProperty> y(string val) => Interop.mkScatterglAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IScatterglProperty> y(IEnumerable<string> values) => Interop.mkScatterglAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IScatterglProperty> y(IEnumerable<bool[]> values) => Interop.mkScatterglAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatterglProperty> y(List<bool[]> values) => Interop.mkScatterglAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatterglProperty> y(params bool[][] values) => Interop.mkScatterglAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatterglProperty> y(IEnumerable<IEnumerable<string>> values) => Interop.mkScatterglAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatterglProperty> y(List<string[]> values) => Interop.mkScatterglAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatterglProperty> y(params string[][] values) => Interop.mkScatterglAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatterglProperty> y(IEnumerable<IEnumerable<int>> values) => Interop.mkScatterglAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatterglProperty> y(List<int[]> values) => Interop.mkScatterglAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatterglProperty> y(params int[][] values) => Interop.mkScatterglAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatterglProperty> y(IEnumerable<IEnumerable<float>> values) => Interop.mkScatterglAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatterglProperty> y(List<float[]> values) => Interop.mkScatterglAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatterglProperty> y(params float[][] values) => Interop.mkScatterglAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatterglProperty> y(Literals.PlotData[] values) => Interop.mkScatterglAttr("y", values);
        /// Sets the y coordinates.
        public static Box<IScatterglProperty> y(IEnumerable<bool?> values) => Interop.mkScatterglAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IScatterglProperty> y(IEnumerable<System.DateTime?> values) => Interop.mkScatterglAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IScatterglProperty> y(IEnumerable<int?> values) => Interop.mkScatterglAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IScatterglProperty> y(IEnumerable<float?> values) => Interop.mkScatterglAttr("y", values.ToArray());
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IScatterglProperty> y0(bool val) => Interop.mkScatterglAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IScatterglProperty> y0(params bool[] values) => Interop.mkScatterglAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IScatterglProperty> y0(System.DateTime val) => Interop.mkScatterglAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IScatterglProperty> y0(params System.DateTime[] values) => Interop.mkScatterglAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IScatterglProperty> y0(int val) => Interop.mkScatterglAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IScatterglProperty> y0(params int[] values) => Interop.mkScatterglAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IScatterglProperty> y0(float val) => Interop.mkScatterglAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IScatterglProperty> y0(params float[] values) => Interop.mkScatterglAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IScatterglProperty> y0(string val) => Interop.mkScatterglAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IScatterglProperty> y0(params string[] values) => Interop.mkScatterglAttr("y0", values);
        /// Sets the y coordinate step. See `y0` for more info.
        public static Box<IScatterglProperty> dy(int val) => Interop.mkScatterglAttr("dy", val);
        /// Sets the y coordinate step. See `y0` for more info.
        public static Box<IScatterglProperty> dy(float val) => Interop.mkScatterglAttr("dy", val);
        /// Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IScatterglProperty> text(string val) => Interop.mkScatterglAttr("text", val);
        /// Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IScatterglProperty> text(IEnumerable<string> values) => Interop.mkScatterglAttr("text", values.ToArray());
        /// Sets hover text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IScatterglProperty> hovertext(string val) => Interop.mkScatterglAttr("hovertext", val);
        /// Sets hover text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IScatterglProperty> hovertext(IEnumerable<string> values) => Interop.mkScatterglAttr("hovertext", values.ToArray());
        /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
        public static Box<IScatterglProperty> textposition(IEnumerable<Box<IScatterglProperty>> properties) => Interop.mkScatterglAttr("textposition", Bindings.flattenProperties(properties));
        /// Sets the text font.
        public static Box<IScatterglProperty> textfont(params Box<ITextfontProperty>[] properties) => Interop.mkScatterglAttr("textfont", Bindings.flattenProperties(properties));
        /// Determines the drawing mode for this scatter trace.
        public static Box<IScatterglProperty> mode(params Box<IScatterglProperty>[] properties) => Interop.mkScatterglAttr("mode", Bindings.joinEnumProperties(properties));
        public static Box<IScatterglProperty> line(params Box<ILineProperty>[] properties) => Interop.mkScatterglAttr("line", Bindings.flattenProperties(properties));
        public static Box<IScatterglProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkScatterglAttr("marker", Bindings.flattenProperties(properties));
        /// Determines whether or not gaps (i.e. {nan} or missing values) in the provided data arrays are connected.
        public static Box<IScatterglProperty> connectgaps(bool val) => Interop.mkScatterglAttr("connectgaps", val);
        /// Sets the fill color. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
        public static Box<IScatterglProperty> fillcolor(string val) => Interop.mkScatterglAttr("fillcolor", val);
        public static Box<IScatterglProperty> selected(params Box<ISelectedProperty>[] properties) => Interop.mkScatterglAttr("selected", Bindings.flattenProperties(properties));
        public static Box<IScatterglProperty> unselected(params Box<IUnselectedProperty>[] properties) => Interop.mkScatterglAttr("unselected", Bindings.flattenProperties(properties));
        /// Sets the opacity of the trace.
        public static Box<IScatterglProperty> opacity(int val) => Interop.mkScatterglAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<IScatterglProperty> opacity(float val) => Interop.mkScatterglAttr("opacity", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IScatterglProperty> hovertemplate(string val) => Interop.mkScatterglAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IScatterglProperty> hovertemplate(IEnumerable<string> values) => Interop.mkScatterglAttr("hovertemplate", values.ToArray());
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.
        public static Box<IScatterglProperty> texttemplate(string val) => Interop.mkScatterglAttr("texttemplate", val);
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.
        public static Box<IScatterglProperty> texttemplate(IEnumerable<string> values) => Interop.mkScatterglAttr("texttemplate", values.ToArray());
        public static Box<IScatterglProperty> errorX(params Box<IErrorXProperty>[] properties) => Interop.mkScatterglAttr("error_x", Bindings.flattenProperties(properties));
        public static Box<IScatterglProperty> errorY(params Box<IErrorYProperty>[] properties) => Interop.mkScatterglAttr("error_y", Bindings.flattenProperties(properties));
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IScatterglProperty> xaxis(int anchorId) => Interop.mkScatterglAttr("xaxis", anchorId > 1 ? $"x{anchorId}" : "");
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IScatterglProperty> xaxis(string val) => Interop.mkScatterglAttr("xaxis", val);
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IScatterglProperty> yaxis(int anchorId) => Interop.mkScatterglAttr("yaxis", anchorId > 1 ? $"y{anchorId}" : "");
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IScatterglProperty> yaxis(string val) => Interop.mkScatterglAttr("yaxis", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IScatterglProperty> idssrc(string val) => Interop.mkScatterglAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IScatterglProperty> customdatasrc(string val) => Interop.mkScatterglAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IScatterglProperty> metasrc(string val) => Interop.mkScatterglAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IScatterglProperty> hoverinfosrc(string val) => Interop.mkScatterglAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  x .
        public static Box<IScatterglProperty> xsrc(string val) => Interop.mkScatterglAttr("xsrc", val);
        /// Sets the source reference on plot.ly for  y .
        public static Box<IScatterglProperty> ysrc(string val) => Interop.mkScatterglAttr("ysrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IScatterglProperty> textsrc(string val) => Interop.mkScatterglAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IScatterglProperty> hovertextsrc(string val) => Interop.mkScatterglAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  textposition .
        public static Box<IScatterglProperty> textpositionsrc(string val) => Interop.mkScatterglAttr("textpositionsrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IScatterglProperty> hovertemplatesrc(string val) => Interop.mkScatterglAttr("hovertemplatesrc", val);
        /// Sets the source reference on plot.ly for  texttemplate .
        public static Box<IScatterglProperty> texttemplatesrc(string val) => Interop.mkScatterglAttr("texttemplatesrc", val);
    }

    public static partial class Scattergl
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IScatterglProperty> legendonly() => Interop.mkScatterglAttr("visible", "legendonly");
            public static Box<IScatterglProperty> _false() => Interop.mkScatterglAttr("visible", false);
            public static Box<IScatterglProperty> _true() => Interop.mkScatterglAttr("visible", true);
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IScatterglProperty> all() => Interop.mkScatterglAttr("hoverinfo", "all");
            public static Box<IScatterglProperty> none() => Interop.mkScatterglAttr("hoverinfo", "none");
            public static Box<IScatterglProperty> skip() => Interop.mkScatterglAttr("hoverinfo", "skip");
            public static Box<IScatterglProperty> name() => Interop.mkScatterglAttr("hoverinfo", "name");
            public static Box<IScatterglProperty> text() => Interop.mkScatterglAttr("hoverinfo", "text");
            public static Box<IScatterglProperty> x() => Interop.mkScatterglAttr("hoverinfo", "x");
            public static Box<IScatterglProperty> y() => Interop.mkScatterglAttr("hoverinfo", "y");
            public static Box<IScatterglProperty> z() => Interop.mkScatterglAttr("hoverinfo", "z");
        }

        /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
        public static partial class Textposition
        {
            public static Box<IScatterglProperty> bottomCenter() => Interop.mkScatterglAttr("textposition", "bottom center");
            public static Box<IScatterglProperty> bottomLeft() => Interop.mkScatterglAttr("textposition", "bottom left");
            public static Box<IScatterglProperty> bottomRight() => Interop.mkScatterglAttr("textposition", "bottom right");
            public static Box<IScatterglProperty> middleCenter() => Interop.mkScatterglAttr("textposition", "middle center");
            public static Box<IScatterglProperty> middleLeft() => Interop.mkScatterglAttr("textposition", "middle left");
            public static Box<IScatterglProperty> middleRight() => Interop.mkScatterglAttr("textposition", "middle right");
            public static Box<IScatterglProperty> topCenter() => Interop.mkScatterglAttr("textposition", "top center");
            public static Box<IScatterglProperty> topLeft() => Interop.mkScatterglAttr("textposition", "top left");
            public static Box<IScatterglProperty> topRight() => Interop.mkScatterglAttr("textposition", "top right");
        }

        /// Determines the drawing mode for this scatter trace.
        public static partial class Mode
        {
            public static Box<IScatterglProperty> none() => Interop.mkScatterglAttr("mode", "none");
            public static Box<IScatterglProperty> lines() => Interop.mkScatterglAttr("mode", "lines");
            public static Box<IScatterglProperty> markers() => Interop.mkScatterglAttr("mode", "markers");
            public static Box<IScatterglProperty> text() => Interop.mkScatterglAttr("mode", "text");
        }

        /// Sets the area to fill with a solid color. Defaults to *none* unless this trace is stacked, then it gets *tonexty* (*tonextx*) if `orientation` is *v* (*h*) Use with `fillcolor` if not *none*. *tozerox* and *tozeroy* fill to x=0 and y=0 respectively. *tonextx* and *tonexty* fill between the endpoints of this trace and the endpoints of the trace before it, connecting those endpoints with straight lines (to make a stacked area graph); if there is no trace before it, they behave like *tozerox* and *tozeroy*. *toself* connects the endpoints of the trace (or each segment of the trace if it has gaps) into a closed shape. *tonext* fills the space between two traces if one completely encloses the other (eg consecutive contour lines), and behaves like *toself* if there is no trace before it. *tonext* should not be used if one trace does not enclose the other. Traces in a `stackgroup` will only fill to (or be filled to) other traces in the same group. With multiple `stackgroup`s or some traces stacked and some not, if fill-linked traces are not already consecutive, the later ones will be pushed down in the drawing order.
        public static partial class Fill
        {
            public static Box<IScatterglProperty> none() => Interop.mkScatterglAttr("fill", "none");
            public static Box<IScatterglProperty> tonext() => Interop.mkScatterglAttr("fill", "tonext");
            public static Box<IScatterglProperty> tonextx() => Interop.mkScatterglAttr("fill", "tonextx");
            public static Box<IScatterglProperty> tonexty() => Interop.mkScatterglAttr("fill", "tonexty");
            public static Box<IScatterglProperty> toself() => Interop.mkScatterglAttr("fill", "toself");
            public static Box<IScatterglProperty> tozerox() => Interop.mkScatterglAttr("fill", "tozerox");
            public static Box<IScatterglProperty> tozeroy() => Interop.mkScatterglAttr("fill", "tozeroy");
        }

        /// Sets the calendar system to use with `x` date data.
        public static partial class Xcalendar
        {
            public static Box<IScatterglProperty> chinese() => Interop.mkScatterglAttr("xcalendar", "chinese");
            public static Box<IScatterglProperty> coptic() => Interop.mkScatterglAttr("xcalendar", "coptic");
            public static Box<IScatterglProperty> discworld() => Interop.mkScatterglAttr("xcalendar", "discworld");
            public static Box<IScatterglProperty> ethiopian() => Interop.mkScatterglAttr("xcalendar", "ethiopian");
            public static Box<IScatterglProperty> gregorian() => Interop.mkScatterglAttr("xcalendar", "gregorian");
            public static Box<IScatterglProperty> hebrew() => Interop.mkScatterglAttr("xcalendar", "hebrew");
            public static Box<IScatterglProperty> islamic() => Interop.mkScatterglAttr("xcalendar", "islamic");
            public static Box<IScatterglProperty> jalali() => Interop.mkScatterglAttr("xcalendar", "jalali");
            public static Box<IScatterglProperty> julian() => Interop.mkScatterglAttr("xcalendar", "julian");
            public static Box<IScatterglProperty> mayan() => Interop.mkScatterglAttr("xcalendar", "mayan");
            public static Box<IScatterglProperty> nanakshahi() => Interop.mkScatterglAttr("xcalendar", "nanakshahi");
            public static Box<IScatterglProperty> nepali() => Interop.mkScatterglAttr("xcalendar", "nepali");
            public static Box<IScatterglProperty> persian() => Interop.mkScatterglAttr("xcalendar", "persian");
            public static Box<IScatterglProperty> taiwan() => Interop.mkScatterglAttr("xcalendar", "taiwan");
            public static Box<IScatterglProperty> thai() => Interop.mkScatterglAttr("xcalendar", "thai");
            public static Box<IScatterglProperty> ummalqura() => Interop.mkScatterglAttr("xcalendar", "ummalqura");
        }

        /// Sets the calendar system to use with `y` date data.
        public static partial class Ycalendar
        {
            public static Box<IScatterglProperty> chinese() => Interop.mkScatterglAttr("ycalendar", "chinese");
            public static Box<IScatterglProperty> coptic() => Interop.mkScatterglAttr("ycalendar", "coptic");
            public static Box<IScatterglProperty> discworld() => Interop.mkScatterglAttr("ycalendar", "discworld");
            public static Box<IScatterglProperty> ethiopian() => Interop.mkScatterglAttr("ycalendar", "ethiopian");
            public static Box<IScatterglProperty> gregorian() => Interop.mkScatterglAttr("ycalendar", "gregorian");
            public static Box<IScatterglProperty> hebrew() => Interop.mkScatterglAttr("ycalendar", "hebrew");
            public static Box<IScatterglProperty> islamic() => Interop.mkScatterglAttr("ycalendar", "islamic");
            public static Box<IScatterglProperty> jalali() => Interop.mkScatterglAttr("ycalendar", "jalali");
            public static Box<IScatterglProperty> julian() => Interop.mkScatterglAttr("ycalendar", "julian");
            public static Box<IScatterglProperty> mayan() => Interop.mkScatterglAttr("ycalendar", "mayan");
            public static Box<IScatterglProperty> nanakshahi() => Interop.mkScatterglAttr("ycalendar", "nanakshahi");
            public static Box<IScatterglProperty> nepali() => Interop.mkScatterglAttr("ycalendar", "nepali");
            public static Box<IScatterglProperty> persian() => Interop.mkScatterglAttr("ycalendar", "persian");
            public static Box<IScatterglProperty> taiwan() => Interop.mkScatterglAttr("ycalendar", "taiwan");
            public static Box<IScatterglProperty> thai() => Interop.mkScatterglAttr("ycalendar", "thai");
            public static Box<IScatterglProperty> ummalqura() => Interop.mkScatterglAttr("ycalendar", "ummalqura");
        }
    }
}