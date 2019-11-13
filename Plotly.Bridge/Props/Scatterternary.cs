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

    public static partial class Scatterternary
    {
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IScatterternaryProperty> showlegend(bool val) => Interop.mkScatterternaryAttr("showlegend", val);
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IScatterternaryProperty> legendgroup(string val) => Interop.mkScatterternaryAttr("legendgroup", val);
        /// Sets the opacity of the trace.
        public static Box<IScatterternaryProperty> opacity(int val) => Interop.mkScatterternaryAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<IScatterternaryProperty> opacity(float val) => Interop.mkScatterternaryAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IScatterternaryProperty> name(string val) => Interop.mkScatterternaryAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IScatterternaryProperty> uid(string val) => Interop.mkScatterternaryAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterternaryProperty> ids(bool val) => Interop.mkScatterternaryAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterternaryProperty> ids(params bool[] values) => Interop.mkScatterternaryAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterternaryProperty> ids(System.DateTime val) => Interop.mkScatterternaryAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterternaryProperty> ids(params System.DateTime[] values) => Interop.mkScatterternaryAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterternaryProperty> ids(float val) => Interop.mkScatterternaryAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterternaryProperty> ids(params float[] values) => Interop.mkScatterternaryAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterternaryProperty> ids(int val) => Interop.mkScatterternaryAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterternaryProperty> ids(params int[] values) => Interop.mkScatterternaryAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterternaryProperty> ids(string val) => Interop.mkScatterternaryAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterternaryProperty> ids(params string[] values) => Interop.mkScatterternaryAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterternaryProperty> ids(IEnumerable<bool[]> values) => Interop.mkScatterternaryAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterternaryProperty> ids(List<bool[]> values) => Interop.mkScatterternaryAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterternaryProperty> ids(params bool[][] values) => Interop.mkScatterternaryAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterternaryProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkScatterternaryAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterternaryProperty> ids(List<string[]> values) => Interop.mkScatterternaryAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterternaryProperty> ids(params string[][] values) => Interop.mkScatterternaryAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterternaryProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkScatterternaryAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterternaryProperty> ids(List<int[]> values) => Interop.mkScatterternaryAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterternaryProperty> ids(params int[][] values) => Interop.mkScatterternaryAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterternaryProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkScatterternaryAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterternaryProperty> ids(List<float[]> values) => Interop.mkScatterternaryAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterternaryProperty> ids(params float[][] values) => Interop.mkScatterternaryAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterternaryProperty> ids(Literals.PlotData[] values) => Interop.mkScatterternaryAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterternaryProperty> ids(IEnumerable<bool?> values) => Interop.mkScatterternaryAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterternaryProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkScatterternaryAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterternaryProperty> ids(IEnumerable<int?> values) => Interop.mkScatterternaryAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterternaryProperty> ids(IEnumerable<float?> values) => Interop.mkScatterternaryAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterternaryProperty> customdata(bool val) => Interop.mkScatterternaryAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterternaryProperty> customdata(params bool[] values) => Interop.mkScatterternaryAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterternaryProperty> customdata(System.DateTime val) => Interop.mkScatterternaryAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterternaryProperty> customdata(params System.DateTime[] values) => Interop.mkScatterternaryAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterternaryProperty> customdata(float val) => Interop.mkScatterternaryAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterternaryProperty> customdata(params float[] values) => Interop.mkScatterternaryAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterternaryProperty> customdata(int val) => Interop.mkScatterternaryAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterternaryProperty> customdata(params int[] values) => Interop.mkScatterternaryAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterternaryProperty> customdata(string val) => Interop.mkScatterternaryAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterternaryProperty> customdata(params string[] values) => Interop.mkScatterternaryAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterternaryProperty> customdata(IEnumerable<bool[]> values) => Interop.mkScatterternaryAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterternaryProperty> customdata(List<bool[]> values) => Interop.mkScatterternaryAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterternaryProperty> customdata(params bool[][] values) => Interop.mkScatterternaryAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterternaryProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkScatterternaryAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterternaryProperty> customdata(List<string[]> values) => Interop.mkScatterternaryAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterternaryProperty> customdata(params string[][] values) => Interop.mkScatterternaryAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterternaryProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkScatterternaryAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterternaryProperty> customdata(List<int[]> values) => Interop.mkScatterternaryAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterternaryProperty> customdata(params int[][] values) => Interop.mkScatterternaryAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterternaryProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkScatterternaryAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterternaryProperty> customdata(List<float[]> values) => Interop.mkScatterternaryAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterternaryProperty> customdata(params float[][] values) => Interop.mkScatterternaryAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterternaryProperty> customdata(Literals.PlotData[] values) => Interop.mkScatterternaryAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterternaryProperty> customdata(IEnumerable<bool?> values) => Interop.mkScatterternaryAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterternaryProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkScatterternaryAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterternaryProperty> customdata(IEnumerable<int?> values) => Interop.mkScatterternaryAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterternaryProperty> customdata(IEnumerable<float?> values) => Interop.mkScatterternaryAttr("customdata", values.ToArray());
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterternaryProperty> selectedpoints(bool val) => Interop.mkScatterternaryAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterternaryProperty> selectedpoints(params bool[] values) => Interop.mkScatterternaryAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterternaryProperty> selectedpoints(System.DateTime val) => Interop.mkScatterternaryAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterternaryProperty> selectedpoints(params System.DateTime[] values) => Interop.mkScatterternaryAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterternaryProperty> selectedpoints(int val) => Interop.mkScatterternaryAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterternaryProperty> selectedpoints(params int[] values) => Interop.mkScatterternaryAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterternaryProperty> selectedpoints(float val) => Interop.mkScatterternaryAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterternaryProperty> selectedpoints(params float[] values) => Interop.mkScatterternaryAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterternaryProperty> selectedpoints(string val) => Interop.mkScatterternaryAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterternaryProperty> selectedpoints(params string[] values) => Interop.mkScatterternaryAttr("selectedpoints", values);
        public static Box<IScatterternaryProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkScatterternaryAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IScatterternaryProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkScatterternaryAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IScatterternaryProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkScatterternaryAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterternaryProperty> uirevision(bool val) => Interop.mkScatterternaryAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterternaryProperty> uirevision(params bool[] values) => Interop.mkScatterternaryAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterternaryProperty> uirevision(System.DateTime val) => Interop.mkScatterternaryAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterternaryProperty> uirevision(params System.DateTime[] values) => Interop.mkScatterternaryAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterternaryProperty> uirevision(int val) => Interop.mkScatterternaryAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterternaryProperty> uirevision(params int[] values) => Interop.mkScatterternaryAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterternaryProperty> uirevision(float val) => Interop.mkScatterternaryAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterternaryProperty> uirevision(params float[] values) => Interop.mkScatterternaryAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterternaryProperty> uirevision(string val) => Interop.mkScatterternaryAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterternaryProperty> uirevision(params string[] values) => Interop.mkScatterternaryAttr("uirevision", values);
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> a(bool val) => Interop.mkScatterternaryAttr("a", new[]{val});
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> a(params bool[] values) => Interop.mkScatterternaryAttr("a", values);
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> a(System.DateTime val) => Interop.mkScatterternaryAttr("a", new[]{val});
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> a(params System.DateTime[] values) => Interop.mkScatterternaryAttr("a", values);
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> a(float val) => Interop.mkScatterternaryAttr("a", new[]{val});
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> a(params float[] values) => Interop.mkScatterternaryAttr("a", values);
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> a(int val) => Interop.mkScatterternaryAttr("a", new[]{val});
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> a(params int[] values) => Interop.mkScatterternaryAttr("a", values);
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> a(string val) => Interop.mkScatterternaryAttr("a", new[]{val});
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> a(params string[] values) => Interop.mkScatterternaryAttr("a", values);
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> a(IEnumerable<bool[]> values) => Interop.mkScatterternaryAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> a(List<bool[]> values) => Interop.mkScatterternaryAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> a(params bool[][] values) => Interop.mkScatterternaryAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> a(IEnumerable<IEnumerable<string>> values) => Interop.mkScatterternaryAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> a(List<string[]> values) => Interop.mkScatterternaryAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> a(params string[][] values) => Interop.mkScatterternaryAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> a(IEnumerable<IEnumerable<int>> values) => Interop.mkScatterternaryAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> a(List<int[]> values) => Interop.mkScatterternaryAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> a(params int[][] values) => Interop.mkScatterternaryAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> a(IEnumerable<IEnumerable<float>> values) => Interop.mkScatterternaryAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> a(List<float[]> values) => Interop.mkScatterternaryAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> a(params float[][] values) => Interop.mkScatterternaryAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> a(Literals.PlotData[] values) => Interop.mkScatterternaryAttr("a", values);
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> a(IEnumerable<bool?> values) => Interop.mkScatterternaryAttr("a", values.ToArray());
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> a(IEnumerable<System.DateTime?> values) => Interop.mkScatterternaryAttr("a", values.ToArray());
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> a(IEnumerable<int?> values) => Interop.mkScatterternaryAttr("a", values.ToArray());
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> a(IEnumerable<float?> values) => Interop.mkScatterternaryAttr("a", values.ToArray());
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> b(bool val) => Interop.mkScatterternaryAttr("b", new[]{val});
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> b(params bool[] values) => Interop.mkScatterternaryAttr("b", values);
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> b(System.DateTime val) => Interop.mkScatterternaryAttr("b", new[]{val});
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> b(params System.DateTime[] values) => Interop.mkScatterternaryAttr("b", values);
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> b(float val) => Interop.mkScatterternaryAttr("b", new[]{val});
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> b(params float[] values) => Interop.mkScatterternaryAttr("b", values);
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> b(int val) => Interop.mkScatterternaryAttr("b", new[]{val});
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> b(params int[] values) => Interop.mkScatterternaryAttr("b", values);
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> b(string val) => Interop.mkScatterternaryAttr("b", new[]{val});
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> b(params string[] values) => Interop.mkScatterternaryAttr("b", values);
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> b(IEnumerable<bool[]> values) => Interop.mkScatterternaryAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> b(List<bool[]> values) => Interop.mkScatterternaryAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> b(params bool[][] values) => Interop.mkScatterternaryAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> b(IEnumerable<IEnumerable<string>> values) => Interop.mkScatterternaryAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> b(List<string[]> values) => Interop.mkScatterternaryAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> b(params string[][] values) => Interop.mkScatterternaryAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> b(IEnumerable<IEnumerable<int>> values) => Interop.mkScatterternaryAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> b(List<int[]> values) => Interop.mkScatterternaryAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> b(params int[][] values) => Interop.mkScatterternaryAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> b(IEnumerable<IEnumerable<float>> values) => Interop.mkScatterternaryAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> b(List<float[]> values) => Interop.mkScatterternaryAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> b(params float[][] values) => Interop.mkScatterternaryAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> b(Literals.PlotData[] values) => Interop.mkScatterternaryAttr("b", values);
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> b(IEnumerable<bool?> values) => Interop.mkScatterternaryAttr("b", values.ToArray());
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> b(IEnumerable<System.DateTime?> values) => Interop.mkScatterternaryAttr("b", values.ToArray());
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> b(IEnumerable<int?> values) => Interop.mkScatterternaryAttr("b", values.ToArray());
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> b(IEnumerable<float?> values) => Interop.mkScatterternaryAttr("b", values.ToArray());
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> c(bool val) => Interop.mkScatterternaryAttr("c", new[]{val});
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> c(params bool[] values) => Interop.mkScatterternaryAttr("c", values);
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> c(System.DateTime val) => Interop.mkScatterternaryAttr("c", new[]{val});
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> c(params System.DateTime[] values) => Interop.mkScatterternaryAttr("c", values);
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> c(float val) => Interop.mkScatterternaryAttr("c", new[]{val});
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> c(params float[] values) => Interop.mkScatterternaryAttr("c", values);
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> c(int val) => Interop.mkScatterternaryAttr("c", new[]{val});
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> c(params int[] values) => Interop.mkScatterternaryAttr("c", values);
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> c(string val) => Interop.mkScatterternaryAttr("c", new[]{val});
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> c(params string[] values) => Interop.mkScatterternaryAttr("c", values);
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> c(IEnumerable<bool[]> values) => Interop.mkScatterternaryAttr("c", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> c(List<bool[]> values) => Interop.mkScatterternaryAttr("c", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> c(params bool[][] values) => Interop.mkScatterternaryAttr("c", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> c(IEnumerable<IEnumerable<string>> values) => Interop.mkScatterternaryAttr("c", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> c(List<string[]> values) => Interop.mkScatterternaryAttr("c", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> c(params string[][] values) => Interop.mkScatterternaryAttr("c", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> c(IEnumerable<IEnumerable<int>> values) => Interop.mkScatterternaryAttr("c", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> c(List<int[]> values) => Interop.mkScatterternaryAttr("c", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> c(params int[][] values) => Interop.mkScatterternaryAttr("c", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> c(IEnumerable<IEnumerable<float>> values) => Interop.mkScatterternaryAttr("c", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> c(List<float[]> values) => Interop.mkScatterternaryAttr("c", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> c(params float[][] values) => Interop.mkScatterternaryAttr("c", Bindings.flatten2DArrayIf1D(values));
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> c(Literals.PlotData[] values) => Interop.mkScatterternaryAttr("c", values);
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> c(IEnumerable<bool?> values) => Interop.mkScatterternaryAttr("c", values.ToArray());
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> c(IEnumerable<System.DateTime?> values) => Interop.mkScatterternaryAttr("c", values.ToArray());
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> c(IEnumerable<int?> values) => Interop.mkScatterternaryAttr("c", values.ToArray());
        /// Sets the quantity of component `a` in each data point. If `a`, `b`, and `c` are all provided, they need not be normalized, only the relative values matter. If only two arrays are provided they must be normalized to match `ternary<i>.sum`.
        public static Box<IScatterternaryProperty> c(IEnumerable<float?> values) => Interop.mkScatterternaryAttr("c", values.ToArray());
        /// The number each triplet should sum to, if only two of `a`, `b`, and `c` are provided. This overrides `ternary<i>.sum` to normalize this specific trace, but does not affect the values displayed on the axes. 0 (or missing) means to use ternary<i>.sum
        public static Box<IScatterternaryProperty> sum(int val) => Interop.mkScatterternaryAttr("sum", val);
        /// The number each triplet should sum to, if only two of `a`, `b`, and `c` are provided. This overrides `ternary<i>.sum` to normalize this specific trace, but does not affect the values displayed on the axes. 0 (or missing) means to use ternary<i>.sum
        public static Box<IScatterternaryProperty> sum(float val) => Interop.mkScatterternaryAttr("sum", val);
        /// Determines the drawing mode for this scatter trace. If the provided `mode` includes *text* then the `text` elements appear at the coordinates. Otherwise, the `text` elements appear on hover. If there are less than 20 points and the trace is not stacked then the default is *lines+markers*. Otherwise, *lines*.
        public static Box<IScatterternaryProperty> mode(params Box<IScatterternaryProperty>[] properties) => Interop.mkScatterternaryAttr("mode", Bindings.joinEnumProperties(properties));
        /// Sets text elements associated with each (a,b,c) point. If a single string, the same string appears over all the data points. If an array of strings, the items are mapped in order to the the data points in (a,b,c). If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IScatterternaryProperty> text(string val) => Interop.mkScatterternaryAttr("text", val);
        /// Sets text elements associated with each (a,b,c) point. If a single string, the same string appears over all the data points. If an array of strings, the items are mapped in order to the the data points in (a,b,c). If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IScatterternaryProperty> text(IEnumerable<string> values) => Interop.mkScatterternaryAttr("text", values.ToArray());
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `a`, `b`, `c` and `text`.
        public static Box<IScatterternaryProperty> texttemplate(string val) => Interop.mkScatterternaryAttr("texttemplate", val);
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `a`, `b`, `c` and `text`.
        public static Box<IScatterternaryProperty> texttemplate(IEnumerable<string> values) => Interop.mkScatterternaryAttr("texttemplate", values.ToArray());
        /// Sets hover text elements associated with each (a,b,c) point. If a single string, the same string appears over all the data points. If an array of strings, the items are mapped in order to the the data points in (a,b,c). To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IScatterternaryProperty> hovertext(string val) => Interop.mkScatterternaryAttr("hovertext", val);
        /// Sets hover text elements associated with each (a,b,c) point. If a single string, the same string appears over all the data points. If an array of strings, the items are mapped in order to the the data points in (a,b,c). To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IScatterternaryProperty> hovertext(IEnumerable<string> values) => Interop.mkScatterternaryAttr("hovertext", values.ToArray());
        public static Box<IScatterternaryProperty> line(params Box<ILineProperty>[] properties) => Interop.mkScatterternaryAttr("line", Bindings.flattenProperties(properties));
        /// Determines whether or not gaps (i.e. {nan} or missing values) in the provided data arrays are connected.
        public static Box<IScatterternaryProperty> connectgaps(bool val) => Interop.mkScatterternaryAttr("connectgaps", val);
        /// Determines whether or not markers and text nodes are clipped about the subplot axes. To show markers and text nodes above axis lines and tick labels, make sure to set `xaxis.layer` and `yaxis.layer` to *below traces*.
        public static Box<IScatterternaryProperty> cliponaxis(bool val) => Interop.mkScatterternaryAttr("cliponaxis", val);
        /// Sets the fill color. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
        public static Box<IScatterternaryProperty> fillcolor(string val) => Interop.mkScatterternaryAttr("fillcolor", val);
        public static Box<IScatterternaryProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkScatterternaryAttr("marker", Bindings.flattenProperties(properties));
        /// Sets the text font.
        public static Box<IScatterternaryProperty> textfont(params Box<ITextfontProperty>[] properties) => Interop.mkScatterternaryAttr("textfont", Bindings.flattenProperties(properties));
        /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
        public static Box<IScatterternaryProperty> textposition(IEnumerable<Box<IScatterternaryProperty>> properties) => Interop.mkScatterternaryAttr("textposition", Bindings.flattenProperties(properties));
        public static Box<IScatterternaryProperty> selected(params Box<ISelectedProperty>[] properties) => Interop.mkScatterternaryAttr("selected", Bindings.flattenProperties(properties));
        public static Box<IScatterternaryProperty> unselected(params Box<IUnselectedProperty>[] properties) => Interop.mkScatterternaryAttr("unselected", Bindings.flattenProperties(properties));
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IScatterternaryProperty> hoverinfo(params Box<IScatterternaryProperty>[] properties) => Interop.mkScatterternaryAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        /// Do the hover effects highlight individual points (markers or line points) or do they highlight filled regions? If the fill is *toself* or *tonext* and there are no markers or text, then the default is *fills*, otherwise it is *points*.
        public static Box<IScatterternaryProperty> hoveron(params Box<IScatterternaryProperty>[] properties) => Interop.mkScatterternaryAttr("hoveron", Bindings.joinEnumProperties(properties));
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IScatterternaryProperty> hovertemplate(string val) => Interop.mkScatterternaryAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IScatterternaryProperty> hovertemplate(IEnumerable<string> values) => Interop.mkScatterternaryAttr("hovertemplate", values.ToArray());
        /// Sets a reference between this trace's data coordinates and a ternary subplot. If *ternary* (the default value), the data refer to `layout.ternary`. If *ternary2*, the data refer to `layout.ternary2`, and so on.
        public static Box<IScatterternaryProperty> subplot(int anchorId) => Interop.mkScatterternaryAttr("subplot", anchorId > 1 ? $"ternary{anchorId}" : "");
        /// Sets a reference between this trace's data coordinates and a ternary subplot. If *ternary* (the default value), the data refer to `layout.ternary`. If *ternary2*, the data refer to `layout.ternary2`, and so on.
        public static Box<IScatterternaryProperty> subplot(string val) => Interop.mkScatterternaryAttr("subplot", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IScatterternaryProperty> idssrc(string val) => Interop.mkScatterternaryAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IScatterternaryProperty> customdatasrc(string val) => Interop.mkScatterternaryAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IScatterternaryProperty> metasrc(string val) => Interop.mkScatterternaryAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  a .
        public static Box<IScatterternaryProperty> asrc(string val) => Interop.mkScatterternaryAttr("asrc", val);
        /// Sets the source reference on plot.ly for  b .
        public static Box<IScatterternaryProperty> bsrc(string val) => Interop.mkScatterternaryAttr("bsrc", val);
        /// Sets the source reference on plot.ly for  c .
        public static Box<IScatterternaryProperty> csrc(string val) => Interop.mkScatterternaryAttr("csrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IScatterternaryProperty> textsrc(string val) => Interop.mkScatterternaryAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  texttemplate .
        public static Box<IScatterternaryProperty> texttemplatesrc(string val) => Interop.mkScatterternaryAttr("texttemplatesrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IScatterternaryProperty> hovertextsrc(string val) => Interop.mkScatterternaryAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  textposition .
        public static Box<IScatterternaryProperty> textpositionsrc(string val) => Interop.mkScatterternaryAttr("textpositionsrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IScatterternaryProperty> hoverinfosrc(string val) => Interop.mkScatterternaryAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IScatterternaryProperty> hovertemplatesrc(string val) => Interop.mkScatterternaryAttr("hovertemplatesrc", val);
    }

    public static partial class Scatterternary
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IScatterternaryProperty> legendonly() => Interop.mkScatterternaryAttr("visible", "legendonly");
            public static Box<IScatterternaryProperty> _false() => Interop.mkScatterternaryAttr("visible", false);
            public static Box<IScatterternaryProperty> _true() => Interop.mkScatterternaryAttr("visible", true);
        }

        /// Determines the drawing mode for this scatter trace. If the provided `mode` includes *text* then the `text` elements appear at the coordinates. Otherwise, the `text` elements appear on hover. If there are less than 20 points and the trace is not stacked then the default is *lines+markers*. Otherwise, *lines*.
        public static partial class Mode
        {
            public static Box<IScatterternaryProperty> none() => Interop.mkScatterternaryAttr("mode", "none");
            public static Box<IScatterternaryProperty> lines() => Interop.mkScatterternaryAttr("mode", "lines");
            public static Box<IScatterternaryProperty> markers() => Interop.mkScatterternaryAttr("mode", "markers");
            public static Box<IScatterternaryProperty> text() => Interop.mkScatterternaryAttr("mode", "text");
        }

        /// Sets the area to fill with a solid color. Use with `fillcolor` if not *none*. scatterternary has a subset of the options available to scatter. *toself* connects the endpoints of the trace (or each segment of the trace if it has gaps) into a closed shape. *tonext* fills the space between two traces if one completely encloses the other (eg consecutive contour lines), and behaves like *toself* if there is no trace before it. *tonext* should not be used if one trace does not enclose the other.
        public static partial class Fill
        {
            public static Box<IScatterternaryProperty> none() => Interop.mkScatterternaryAttr("fill", "none");
            public static Box<IScatterternaryProperty> tonext() => Interop.mkScatterternaryAttr("fill", "tonext");
            public static Box<IScatterternaryProperty> toself() => Interop.mkScatterternaryAttr("fill", "toself");
        }

        /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
        public static partial class Textposition
        {
            public static Box<IScatterternaryProperty> bottomCenter() => Interop.mkScatterternaryAttr("textposition", "bottom center");
            public static Box<IScatterternaryProperty> bottomLeft() => Interop.mkScatterternaryAttr("textposition", "bottom left");
            public static Box<IScatterternaryProperty> bottomRight() => Interop.mkScatterternaryAttr("textposition", "bottom right");
            public static Box<IScatterternaryProperty> middleCenter() => Interop.mkScatterternaryAttr("textposition", "middle center");
            public static Box<IScatterternaryProperty> middleLeft() => Interop.mkScatterternaryAttr("textposition", "middle left");
            public static Box<IScatterternaryProperty> middleRight() => Interop.mkScatterternaryAttr("textposition", "middle right");
            public static Box<IScatterternaryProperty> topCenter() => Interop.mkScatterternaryAttr("textposition", "top center");
            public static Box<IScatterternaryProperty> topLeft() => Interop.mkScatterternaryAttr("textposition", "top left");
            public static Box<IScatterternaryProperty> topRight() => Interop.mkScatterternaryAttr("textposition", "top right");
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IScatterternaryProperty> all() => Interop.mkScatterternaryAttr("hoverinfo", "all");
            public static Box<IScatterternaryProperty> none() => Interop.mkScatterternaryAttr("hoverinfo", "none");
            public static Box<IScatterternaryProperty> skip() => Interop.mkScatterternaryAttr("hoverinfo", "skip");
            public static Box<IScatterternaryProperty> a() => Interop.mkScatterternaryAttr("hoverinfo", "a");
            public static Box<IScatterternaryProperty> b() => Interop.mkScatterternaryAttr("hoverinfo", "b");
            public static Box<IScatterternaryProperty> c() => Interop.mkScatterternaryAttr("hoverinfo", "c");
            public static Box<IScatterternaryProperty> name() => Interop.mkScatterternaryAttr("hoverinfo", "name");
            public static Box<IScatterternaryProperty> text() => Interop.mkScatterternaryAttr("hoverinfo", "text");
        }

        /// Do the hover effects highlight individual points (markers or line points) or do they highlight filled regions? If the fill is *toself* or *tonext* and there are no markers or text, then the default is *fills*, otherwise it is *points*.
        public static partial class Hoveron
        {
            public static Box<IScatterternaryProperty> fills() => Interop.mkScatterternaryAttr("hoveron", "fills");
            public static Box<IScatterternaryProperty> points() => Interop.mkScatterternaryAttr("hoveron", "points");
        }
    }
}