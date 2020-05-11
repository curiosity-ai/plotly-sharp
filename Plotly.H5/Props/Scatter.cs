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

    public static partial class Scatter
    {
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IScatterProperty> showlegend(bool val) => Interop.mkScatterAttr("showlegend", val);
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IScatterProperty> legendgroup(string val) => Interop.mkScatterAttr("legendgroup", val);
        /// Sets the opacity of the trace.
        public static Box<IScatterProperty> opacity(int val) => Interop.mkScatterAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<IScatterProperty> opacity(float val) => Interop.mkScatterAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IScatterProperty> name(string val) => Interop.mkScatterAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IScatterProperty> uid(string val) => Interop.mkScatterAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterProperty> ids(bool val) => Interop.mkScatterAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterProperty> ids(params bool[] values) => Interop.mkScatterAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterProperty> ids(System.DateTime val) => Interop.mkScatterAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterProperty> ids(params System.DateTime[] values) => Interop.mkScatterAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterProperty> ids(float val) => Interop.mkScatterAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterProperty> ids(params float[] values) => Interop.mkScatterAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterProperty> ids(int val) => Interop.mkScatterAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterProperty> ids(params int[] values) => Interop.mkScatterAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterProperty> ids(string val) => Interop.mkScatterAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterProperty> ids(params string[] values) => Interop.mkScatterAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterProperty> ids(IEnumerable<bool[]> values) => Interop.mkScatterAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterProperty> ids(List<bool[]> values) => Interop.mkScatterAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterProperty> ids(params bool[][] values) => Interop.mkScatterAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkScatterAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterProperty> ids(List<string[]> values) => Interop.mkScatterAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterProperty> ids(params string[][] values) => Interop.mkScatterAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkScatterAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterProperty> ids(List<int[]> values) => Interop.mkScatterAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterProperty> ids(params int[][] values) => Interop.mkScatterAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkScatterAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterProperty> ids(List<float[]> values) => Interop.mkScatterAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterProperty> ids(params float[][] values) => Interop.mkScatterAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterProperty> ids(Literals.PlotData[] values) => Interop.mkScatterAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterProperty> ids(IEnumerable<bool?> values) => Interop.mkScatterAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkScatterAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterProperty> ids(IEnumerable<int?> values) => Interop.mkScatterAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterProperty> ids(IEnumerable<float?> values) => Interop.mkScatterAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterProperty> customdata(bool val) => Interop.mkScatterAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterProperty> customdata(params bool[] values) => Interop.mkScatterAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterProperty> customdata(System.DateTime val) => Interop.mkScatterAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterProperty> customdata(params System.DateTime[] values) => Interop.mkScatterAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterProperty> customdata(float val) => Interop.mkScatterAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterProperty> customdata(params float[] values) => Interop.mkScatterAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterProperty> customdata(int val) => Interop.mkScatterAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterProperty> customdata(params int[] values) => Interop.mkScatterAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterProperty> customdata(string val) => Interop.mkScatterAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterProperty> customdata(params string[] values) => Interop.mkScatterAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterProperty> customdata(IEnumerable<bool[]> values) => Interop.mkScatterAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterProperty> customdata(List<bool[]> values) => Interop.mkScatterAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterProperty> customdata(params bool[][] values) => Interop.mkScatterAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkScatterAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterProperty> customdata(List<string[]> values) => Interop.mkScatterAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterProperty> customdata(params string[][] values) => Interop.mkScatterAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkScatterAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterProperty> customdata(List<int[]> values) => Interop.mkScatterAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterProperty> customdata(params int[][] values) => Interop.mkScatterAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkScatterAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterProperty> customdata(List<float[]> values) => Interop.mkScatterAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterProperty> customdata(params float[][] values) => Interop.mkScatterAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterProperty> customdata(Literals.PlotData[] values) => Interop.mkScatterAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterProperty> customdata(IEnumerable<bool?> values) => Interop.mkScatterAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkScatterAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterProperty> customdata(IEnumerable<int?> values) => Interop.mkScatterAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterProperty> customdata(IEnumerable<float?> values) => Interop.mkScatterAttr("customdata", values.ToArray());
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterProperty> selectedpoints(bool val) => Interop.mkScatterAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterProperty> selectedpoints(params bool[] values) => Interop.mkScatterAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterProperty> selectedpoints(System.DateTime val) => Interop.mkScatterAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterProperty> selectedpoints(params System.DateTime[] values) => Interop.mkScatterAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterProperty> selectedpoints(int val) => Interop.mkScatterAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterProperty> selectedpoints(params int[] values) => Interop.mkScatterAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterProperty> selectedpoints(float val) => Interop.mkScatterAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterProperty> selectedpoints(params float[] values) => Interop.mkScatterAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterProperty> selectedpoints(string val) => Interop.mkScatterAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterProperty> selectedpoints(params string[] values) => Interop.mkScatterAttr("selectedpoints", values);
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IScatterProperty> hoverinfo(params Box<IScatterProperty>[] properties) => Interop.mkScatterAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        public static Box<IScatterProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkScatterAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IScatterProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkScatterAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IScatterProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkScatterAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterProperty> uirevision(bool val) => Interop.mkScatterAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterProperty> uirevision(params bool[] values) => Interop.mkScatterAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterProperty> uirevision(System.DateTime val) => Interop.mkScatterAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterProperty> uirevision(params System.DateTime[] values) => Interop.mkScatterAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterProperty> uirevision(int val) => Interop.mkScatterAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterProperty> uirevision(params int[] values) => Interop.mkScatterAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterProperty> uirevision(float val) => Interop.mkScatterAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterProperty> uirevision(params float[] values) => Interop.mkScatterAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterProperty> uirevision(string val) => Interop.mkScatterAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterProperty> uirevision(params string[] values) => Interop.mkScatterAttr("uirevision", values);
        /// Sets the x coordinates.
        public static Box<IScatterProperty> x(bool val) => Interop.mkScatterAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IScatterProperty> x(IEnumerable<bool> values) => Interop.mkScatterAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IScatterProperty> x(System.DateTime val) => Interop.mkScatterAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IScatterProperty> x(IEnumerable<System.DateTime> values) => Interop.mkScatterAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IScatterProperty> x(float val) => Interop.mkScatterAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IScatterProperty> x(IEnumerable<float> values) => Interop.mkScatterAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IScatterProperty> x(int val) => Interop.mkScatterAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IScatterProperty> x(IEnumerable<int> values) => Interop.mkScatterAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IScatterProperty> x(string val) => Interop.mkScatterAttr("x", new[]{val});
        /// Sets the x coordinates.
        public static Box<IScatterProperty> x(IEnumerable<string> values) => Interop.mkScatterAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IScatterProperty> x(IEnumerable<bool[]> values) => Interop.mkScatterAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatterProperty> x(List<bool[]> values) => Interop.mkScatterAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatterProperty> x(params bool[][] values) => Interop.mkScatterAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatterProperty> x(IEnumerable<IEnumerable<string>> values) => Interop.mkScatterAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatterProperty> x(List<string[]> values) => Interop.mkScatterAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatterProperty> x(params string[][] values) => Interop.mkScatterAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatterProperty> x(IEnumerable<IEnumerable<int>> values) => Interop.mkScatterAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatterProperty> x(List<int[]> values) => Interop.mkScatterAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatterProperty> x(params int[][] values) => Interop.mkScatterAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatterProperty> x(IEnumerable<IEnumerable<float>> values) => Interop.mkScatterAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatterProperty> x(List<float[]> values) => Interop.mkScatterAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatterProperty> x(params float[][] values) => Interop.mkScatterAttr("x", Bindings.flatten2DArrayIf1D(values));
        /// Sets the x coordinates.
        public static Box<IScatterProperty> x(Literals.PlotData[] values) => Interop.mkScatterAttr("x", values);
        /// Sets the x coordinates.
        public static Box<IScatterProperty> x(IEnumerable<bool?> values) => Interop.mkScatterAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IScatterProperty> x(IEnumerable<System.DateTime?> values) => Interop.mkScatterAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IScatterProperty> x(IEnumerable<int?> values) => Interop.mkScatterAttr("x", values.ToArray());
        /// Sets the x coordinates.
        public static Box<IScatterProperty> x(IEnumerable<float?> values) => Interop.mkScatterAttr("x", values.ToArray());
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IScatterProperty> x0(bool val) => Interop.mkScatterAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IScatterProperty> x0(params bool[] values) => Interop.mkScatterAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IScatterProperty> x0(System.DateTime val) => Interop.mkScatterAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IScatterProperty> x0(params System.DateTime[] values) => Interop.mkScatterAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IScatterProperty> x0(int val) => Interop.mkScatterAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IScatterProperty> x0(params int[] values) => Interop.mkScatterAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IScatterProperty> x0(float val) => Interop.mkScatterAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IScatterProperty> x0(params float[] values) => Interop.mkScatterAttr("x0", values);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IScatterProperty> x0(string val) => Interop.mkScatterAttr("x0", val);
        /// Alternate to `x`. Builds a linear space of x coordinates. Use with `dx` where `x0` is the starting coordinate and `dx` the step.
        public static Box<IScatterProperty> x0(params string[] values) => Interop.mkScatterAttr("x0", values);
        /// Sets the x coordinate step. See `x0` for more info.
        public static Box<IScatterProperty> dx(int val) => Interop.mkScatterAttr("dx", val);
        /// Sets the x coordinate step. See `x0` for more info.
        public static Box<IScatterProperty> dx(float val) => Interop.mkScatterAttr("dx", val);
        /// Sets the y coordinates.
        public static Box<IScatterProperty> y(bool val) => Interop.mkScatterAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IScatterProperty> y(IEnumerable<bool> values) => Interop.mkScatterAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IScatterProperty> y(System.DateTime val) => Interop.mkScatterAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IScatterProperty> y(IEnumerable<System.DateTime> values) => Interop.mkScatterAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IScatterProperty> y(float val) => Interop.mkScatterAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IScatterProperty> y(IEnumerable<float> values) => Interop.mkScatterAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IScatterProperty> y(int val) => Interop.mkScatterAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IScatterProperty> y(IEnumerable<int> values) => Interop.mkScatterAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IScatterProperty> y(string val) => Interop.mkScatterAttr("y", new[]{val});
        /// Sets the y coordinates.
        public static Box<IScatterProperty> y(IEnumerable<string> values) => Interop.mkScatterAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IScatterProperty> y(IEnumerable<bool[]> values) => Interop.mkScatterAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatterProperty> y(List<bool[]> values) => Interop.mkScatterAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatterProperty> y(params bool[][] values) => Interop.mkScatterAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatterProperty> y(IEnumerable<IEnumerable<string>> values) => Interop.mkScatterAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatterProperty> y(List<string[]> values) => Interop.mkScatterAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatterProperty> y(params string[][] values) => Interop.mkScatterAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatterProperty> y(IEnumerable<IEnumerable<int>> values) => Interop.mkScatterAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatterProperty> y(List<int[]> values) => Interop.mkScatterAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatterProperty> y(params int[][] values) => Interop.mkScatterAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatterProperty> y(IEnumerable<IEnumerable<float>> values) => Interop.mkScatterAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatterProperty> y(List<float[]> values) => Interop.mkScatterAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatterProperty> y(params float[][] values) => Interop.mkScatterAttr("y", Bindings.flatten2DArrayIf1D(values));
        /// Sets the y coordinates.
        public static Box<IScatterProperty> y(Literals.PlotData[] values) => Interop.mkScatterAttr("y", values);
        /// Sets the y coordinates.
        public static Box<IScatterProperty> y(IEnumerable<bool?> values) => Interop.mkScatterAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IScatterProperty> y(IEnumerable<System.DateTime?> values) => Interop.mkScatterAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IScatterProperty> y(IEnumerable<int?> values) => Interop.mkScatterAttr("y", values.ToArray());
        /// Sets the y coordinates.
        public static Box<IScatterProperty> y(IEnumerable<float?> values) => Interop.mkScatterAttr("y", values.ToArray());
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IScatterProperty> y0(bool val) => Interop.mkScatterAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IScatterProperty> y0(params bool[] values) => Interop.mkScatterAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IScatterProperty> y0(System.DateTime val) => Interop.mkScatterAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IScatterProperty> y0(params System.DateTime[] values) => Interop.mkScatterAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IScatterProperty> y0(int val) => Interop.mkScatterAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IScatterProperty> y0(params int[] values) => Interop.mkScatterAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IScatterProperty> y0(float val) => Interop.mkScatterAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IScatterProperty> y0(params float[] values) => Interop.mkScatterAttr("y0", values);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IScatterProperty> y0(string val) => Interop.mkScatterAttr("y0", val);
        /// Alternate to `y`. Builds a linear space of y coordinates. Use with `dy` where `y0` is the starting coordinate and `dy` the step.
        public static Box<IScatterProperty> y0(params string[] values) => Interop.mkScatterAttr("y0", values);
        /// Sets the y coordinate step. See `y0` for more info.
        public static Box<IScatterProperty> dy(int val) => Interop.mkScatterAttr("dy", val);
        /// Sets the y coordinate step. See `y0` for more info.
        public static Box<IScatterProperty> dy(float val) => Interop.mkScatterAttr("dy", val);
        /// Set several scatter traces (on the same subplot) to the same stackgroup in order to add their y values (or their x values if `orientation` is *h*). If blank or omitted this trace will not be stacked. Stacking also turns `fill` on by default, using *tonexty* (*tonextx*) if `orientation` is *h* (*v*) and sets the default `mode` to *lines* irrespective of point count. You can only stack on a numeric (linear or log) axis. Traces in a `stackgroup` will only fill to (or be filled to) other traces in the same group. With multiple `stackgroup`s or some traces stacked and some not, if fill-linked traces are not already consecutive, the later ones will be pushed down in the drawing order.
        public static Box<IScatterProperty> stackgroup(string val) => Interop.mkScatterAttr("stackgroup", val);
        /// Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IScatterProperty> text(string val) => Interop.mkScatterAttr("text", val);
        /// Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IScatterProperty> text(IEnumerable<string> values) => Interop.mkScatterAttr("text", values.ToArray());
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.
        public static Box<IScatterProperty> texttemplate(string val) => Interop.mkScatterAttr("texttemplate", val);
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.
        public static Box<IScatterProperty> texttemplate(IEnumerable<string> values) => Interop.mkScatterAttr("texttemplate", values.ToArray());
        /// Sets hover text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IScatterProperty> hovertext(string val) => Interop.mkScatterAttr("hovertext", val);
        /// Sets hover text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IScatterProperty> hovertext(IEnumerable<string> values) => Interop.mkScatterAttr("hovertext", values.ToArray());
        /// Determines the drawing mode for this scatter trace. If the provided `mode` includes *text* then the `text` elements appear at the coordinates. Otherwise, the `text` elements appear on hover. If there are less than 20 points and the trace is not stacked then the default is *lines+markers*. Otherwise, *lines*.
        public static Box<IScatterProperty> mode(params Box<IScatterProperty>[] properties) => Interop.mkScatterAttr("mode", Bindings.joinEnumProperties(properties));
        /// Do the hover effects highlight individual points (markers or line points) or do they highlight filled regions? If the fill is *toself* or *tonext* and there are no markers or text, then the default is *fills*, otherwise it is *points*.
        public static Box<IScatterProperty> hoveron(params Box<IScatterProperty>[] properties) => Interop.mkScatterAttr("hoveron", Bindings.joinEnumProperties(properties));
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IScatterProperty> hovertemplate(string val) => Interop.mkScatterAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IScatterProperty> hovertemplate(IEnumerable<string> values) => Interop.mkScatterAttr("hovertemplate", values.ToArray());
        public static Box<IScatterProperty> line(params Box<ILineProperty>[] properties) => Interop.mkScatterAttr("line", Bindings.flattenProperties(properties));
        /// Determines whether or not gaps (i.e. {nan} or missing values) in the provided data arrays are connected.
        public static Box<IScatterProperty> connectgaps(bool val) => Interop.mkScatterAttr("connectgaps", val);
        /// Determines whether or not markers and text nodes are clipped about the subplot axes. To show markers and text nodes above axis lines and tick labels, make sure to set `xaxis.layer` and `yaxis.layer` to *below traces*.
        public static Box<IScatterProperty> cliponaxis(bool val) => Interop.mkScatterAttr("cliponaxis", val);
        /// Sets the fill color. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
        public static Box<IScatterProperty> fillcolor(string val) => Interop.mkScatterAttr("fillcolor", val);
        public static Box<IScatterProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkScatterAttr("marker", Bindings.flattenProperties(properties));
        public static Box<IScatterProperty> selected(params Box<ISelectedProperty>[] properties) => Interop.mkScatterAttr("selected", Bindings.flattenProperties(properties));
        public static Box<IScatterProperty> unselected(params Box<IUnselectedProperty>[] properties) => Interop.mkScatterAttr("unselected", Bindings.flattenProperties(properties));
        /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
        public static Box<IScatterProperty> textposition(IEnumerable<Box<IScatterProperty>> properties) => Interop.mkScatterAttr("textposition", Bindings.flattenProperties(properties));
        /// Sets the text font.
        public static Box<IScatterProperty> textfont(params Box<ITextfontProperty>[] properties) => Interop.mkScatterAttr("textfont", Bindings.flattenProperties(properties));
        public static Box<IScatterProperty> errorX(params Box<IErrorXProperty>[] properties) => Interop.mkScatterAttr("error_x", Bindings.flattenProperties(properties));
        public static Box<IScatterProperty> errorY(params Box<IErrorYProperty>[] properties) => Interop.mkScatterAttr("error_y", Bindings.flattenProperties(properties));
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IScatterProperty> xaxis(int anchorId) => Interop.mkScatterAttr("xaxis", anchorId > 1 ? $"x{anchorId}" : "");
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IScatterProperty> xaxis(string val) => Interop.mkScatterAttr("xaxis", val);
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IScatterProperty> yaxis(int anchorId) => Interop.mkScatterAttr("yaxis", anchorId > 1 ? $"y{anchorId}" : "");
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IScatterProperty> yaxis(string val) => Interop.mkScatterAttr("yaxis", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IScatterProperty> idssrc(string val) => Interop.mkScatterAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IScatterProperty> customdatasrc(string val) => Interop.mkScatterAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IScatterProperty> metasrc(string val) => Interop.mkScatterAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IScatterProperty> hoverinfosrc(string val) => Interop.mkScatterAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  x .
        public static Box<IScatterProperty> xsrc(string val) => Interop.mkScatterAttr("xsrc", val);
        /// Sets the source reference on plot.ly for  y .
        public static Box<IScatterProperty> ysrc(string val) => Interop.mkScatterAttr("ysrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IScatterProperty> textsrc(string val) => Interop.mkScatterAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  texttemplate .
        public static Box<IScatterProperty> texttemplatesrc(string val) => Interop.mkScatterAttr("texttemplatesrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IScatterProperty> hovertextsrc(string val) => Interop.mkScatterAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IScatterProperty> hovertemplatesrc(string val) => Interop.mkScatterAttr("hovertemplatesrc", val);
        /// Sets the source reference on plot.ly for  textposition .
        public static Box<IScatterProperty> textpositionsrc(string val) => Interop.mkScatterAttr("textpositionsrc", val);
        /// Sets the source reference on plot.ly for  r .
        public static Box<IScatterProperty> rsrc(string val) => Interop.mkScatterAttr("rsrc", val);
        /// Sets the source reference on plot.ly for  t .
        public static Box<IScatterProperty> tsrc(string val) => Interop.mkScatterAttr("tsrc", val);
    }

    public static partial class Scatter
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IScatterProperty> legendonly() => Interop.mkScatterAttr("visible", "legendonly");
            public static Box<IScatterProperty> _false() => Interop.mkScatterAttr("visible", false);
            public static Box<IScatterProperty> _true() => Interop.mkScatterAttr("visible", true);
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IScatterProperty> all() => Interop.mkScatterAttr("hoverinfo", "all");
            public static Box<IScatterProperty> none() => Interop.mkScatterAttr("hoverinfo", "none");
            public static Box<IScatterProperty> skip() => Interop.mkScatterAttr("hoverinfo", "skip");
            public static Box<IScatterProperty> name() => Interop.mkScatterAttr("hoverinfo", "name");
            public static Box<IScatterProperty> text() => Interop.mkScatterAttr("hoverinfo", "text");
            public static Box<IScatterProperty> x() => Interop.mkScatterAttr("hoverinfo", "x");
            public static Box<IScatterProperty> y() => Interop.mkScatterAttr("hoverinfo", "y");
            public static Box<IScatterProperty> z() => Interop.mkScatterAttr("hoverinfo", "z");
        }

        /// Only relevant when `stackgroup` is used, and only the first `orientation` found in the `stackgroup` will be used - including if `visible` is *legendonly* but not if it is `false`. Sets the stacking direction. With *v* (*h*), the y (x) values of subsequent traces are added. Also affects the default value of `fill`.
        public static partial class Orientation
        {
            public static Box<IScatterProperty> h() => Interop.mkScatterAttr("orientation", "h");
            public static Box<IScatterProperty> v() => Interop.mkScatterAttr("orientation", "v");
        }

        /// Only relevant when `stackgroup` is used, and only the first `groupnorm` found in the `stackgroup` will be used - including if `visible` is *legendonly* but not if it is `false`. Sets the normalization for the sum of this `stackgroup`. With *fraction*, the value of each trace at each location is divided by the sum of all trace values at that location. *percent* is the same but multiplied by 100 to show percentages. If there are multiple subplots, or multiple `stackgroup`s on one subplot, each will be normalized within its own set.
        public static partial class Groupnorm
        {
            public static Box<IScatterProperty> none() => Interop.mkScatterAttr("groupnorm", "");
            public static Box<IScatterProperty> fraction() => Interop.mkScatterAttr("groupnorm", "fraction");
            public static Box<IScatterProperty> percent() => Interop.mkScatterAttr("groupnorm", "percent");
        }

        /// Only relevant when `stackgroup` is used, and only the first `stackgaps` found in the `stackgroup` will be used - including if `visible` is *legendonly* but not if it is `false`. Determines how we handle locations at which other traces in this group have data but this one does not. With *infer zero* we insert a zero at these locations. With *interpolate* we linearly interpolate between existing values, and extrapolate a constant beyond the existing values.
        public static partial class Stackgaps
        {
            public static Box<IScatterProperty> inferZero() => Interop.mkScatterAttr("stackgaps", "infer zero");
            public static Box<IScatterProperty> interpolate() => Interop.mkScatterAttr("stackgaps", "interpolate");
        }

        /// Determines the drawing mode for this scatter trace. If the provided `mode` includes *text* then the `text` elements appear at the coordinates. Otherwise, the `text` elements appear on hover. If there are less than 20 points and the trace is not stacked then the default is *lines+markers*. Otherwise, *lines*.
        public static partial class Mode
        {
            public static Box<IScatterProperty> none() => Interop.mkScatterAttr("mode", "none");
            public static Box<IScatterProperty> lines() => Interop.mkScatterAttr("mode", "lines");
            public static Box<IScatterProperty> markers() => Interop.mkScatterAttr("mode", "markers");
            public static Box<IScatterProperty> text() => Interop.mkScatterAttr("mode", "text");
        }

        /// Do the hover effects highlight individual points (markers or line points) or do they highlight filled regions? If the fill is *toself* or *tonext* and there are no markers or text, then the default is *fills*, otherwise it is *points*.
        public static partial class Hoveron
        {
            public static Box<IScatterProperty> fills() => Interop.mkScatterAttr("hoveron", "fills");
            public static Box<IScatterProperty> points() => Interop.mkScatterAttr("hoveron", "points");
        }

        /// Sets the area to fill with a solid color. Defaults to *none* unless this trace is stacked, then it gets *tonexty* (*tonextx*) if `orientation` is *v* (*h*) Use with `fillcolor` if not *none*. *tozerox* and *tozeroy* fill to x=0 and y=0 respectively. *tonextx* and *tonexty* fill between the endpoints of this trace and the endpoints of the trace before it, connecting those endpoints with straight lines (to make a stacked area graph); if there is no trace before it, they behave like *tozerox* and *tozeroy*. *toself* connects the endpoints of the trace (or each segment of the trace if it has gaps) into a closed shape. *tonext* fills the space between two traces if one completely encloses the other (eg consecutive contour lines), and behaves like *toself* if there is no trace before it. *tonext* should not be used if one trace does not enclose the other. Traces in a `stackgroup` will only fill to (or be filled to) other traces in the same group. With multiple `stackgroup`s or some traces stacked and some not, if fill-linked traces are not already consecutive, the later ones will be pushed down in the drawing order.
        public static partial class Fill
        {
            public static Box<IScatterProperty> none() => Interop.mkScatterAttr("fill", "none");
            public static Box<IScatterProperty> tonext() => Interop.mkScatterAttr("fill", "tonext");
            public static Box<IScatterProperty> tonextx() => Interop.mkScatterAttr("fill", "tonextx");
            public static Box<IScatterProperty> tonexty() => Interop.mkScatterAttr("fill", "tonexty");
            public static Box<IScatterProperty> toself() => Interop.mkScatterAttr("fill", "toself");
            public static Box<IScatterProperty> tozerox() => Interop.mkScatterAttr("fill", "tozerox");
            public static Box<IScatterProperty> tozeroy() => Interop.mkScatterAttr("fill", "tozeroy");
        }

        /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
        public static partial class Textposition
        {
            public static Box<IScatterProperty> bottomCenter() => Interop.mkScatterAttr("textposition", "bottom center");
            public static Box<IScatterProperty> bottomLeft() => Interop.mkScatterAttr("textposition", "bottom left");
            public static Box<IScatterProperty> bottomRight() => Interop.mkScatterAttr("textposition", "bottom right");
            public static Box<IScatterProperty> middleCenter() => Interop.mkScatterAttr("textposition", "middle center");
            public static Box<IScatterProperty> middleLeft() => Interop.mkScatterAttr("textposition", "middle left");
            public static Box<IScatterProperty> middleRight() => Interop.mkScatterAttr("textposition", "middle right");
            public static Box<IScatterProperty> topCenter() => Interop.mkScatterAttr("textposition", "top center");
            public static Box<IScatterProperty> topLeft() => Interop.mkScatterAttr("textposition", "top left");
            public static Box<IScatterProperty> topRight() => Interop.mkScatterAttr("textposition", "top right");
        }

        /// Sets the calendar system to use with `x` date data.
        public static partial class Xcalendar
        {
            public static Box<IScatterProperty> chinese() => Interop.mkScatterAttr("xcalendar", "chinese");
            public static Box<IScatterProperty> coptic() => Interop.mkScatterAttr("xcalendar", "coptic");
            public static Box<IScatterProperty> discworld() => Interop.mkScatterAttr("xcalendar", "discworld");
            public static Box<IScatterProperty> ethiopian() => Interop.mkScatterAttr("xcalendar", "ethiopian");
            public static Box<IScatterProperty> gregorian() => Interop.mkScatterAttr("xcalendar", "gregorian");
            public static Box<IScatterProperty> hebrew() => Interop.mkScatterAttr("xcalendar", "hebrew");
            public static Box<IScatterProperty> islamic() => Interop.mkScatterAttr("xcalendar", "islamic");
            public static Box<IScatterProperty> jalali() => Interop.mkScatterAttr("xcalendar", "jalali");
            public static Box<IScatterProperty> julian() => Interop.mkScatterAttr("xcalendar", "julian");
            public static Box<IScatterProperty> mayan() => Interop.mkScatterAttr("xcalendar", "mayan");
            public static Box<IScatterProperty> nanakshahi() => Interop.mkScatterAttr("xcalendar", "nanakshahi");
            public static Box<IScatterProperty> nepali() => Interop.mkScatterAttr("xcalendar", "nepali");
            public static Box<IScatterProperty> persian() => Interop.mkScatterAttr("xcalendar", "persian");
            public static Box<IScatterProperty> taiwan() => Interop.mkScatterAttr("xcalendar", "taiwan");
            public static Box<IScatterProperty> thai() => Interop.mkScatterAttr("xcalendar", "thai");
            public static Box<IScatterProperty> ummalqura() => Interop.mkScatterAttr("xcalendar", "ummalqura");
        }

        /// Sets the calendar system to use with `y` date data.
        public static partial class Ycalendar
        {
            public static Box<IScatterProperty> chinese() => Interop.mkScatterAttr("ycalendar", "chinese");
            public static Box<IScatterProperty> coptic() => Interop.mkScatterAttr("ycalendar", "coptic");
            public static Box<IScatterProperty> discworld() => Interop.mkScatterAttr("ycalendar", "discworld");
            public static Box<IScatterProperty> ethiopian() => Interop.mkScatterAttr("ycalendar", "ethiopian");
            public static Box<IScatterProperty> gregorian() => Interop.mkScatterAttr("ycalendar", "gregorian");
            public static Box<IScatterProperty> hebrew() => Interop.mkScatterAttr("ycalendar", "hebrew");
            public static Box<IScatterProperty> islamic() => Interop.mkScatterAttr("ycalendar", "islamic");
            public static Box<IScatterProperty> jalali() => Interop.mkScatterAttr("ycalendar", "jalali");
            public static Box<IScatterProperty> julian() => Interop.mkScatterAttr("ycalendar", "julian");
            public static Box<IScatterProperty> mayan() => Interop.mkScatterAttr("ycalendar", "mayan");
            public static Box<IScatterProperty> nanakshahi() => Interop.mkScatterAttr("ycalendar", "nanakshahi");
            public static Box<IScatterProperty> nepali() => Interop.mkScatterAttr("ycalendar", "nepali");
            public static Box<IScatterProperty> persian() => Interop.mkScatterAttr("ycalendar", "persian");
            public static Box<IScatterProperty> taiwan() => Interop.mkScatterAttr("ycalendar", "taiwan");
            public static Box<IScatterProperty> thai() => Interop.mkScatterAttr("ycalendar", "thai");
            public static Box<IScatterProperty> ummalqura() => Interop.mkScatterAttr("ycalendar", "ummalqura");
        }
    }
}