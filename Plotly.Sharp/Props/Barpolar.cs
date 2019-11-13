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

    public static partial class Barpolar
    {
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IBarpolarProperty> showlegend(bool val) => Interop.mkBarpolarAttr("showlegend", val);
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IBarpolarProperty> legendgroup(string val) => Interop.mkBarpolarAttr("legendgroup", val);
        /// Sets the opacity of the trace.
        public static Box<IBarpolarProperty> opacity(int val) => Interop.mkBarpolarAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<IBarpolarProperty> opacity(float val) => Interop.mkBarpolarAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IBarpolarProperty> name(string val) => Interop.mkBarpolarAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IBarpolarProperty> uid(string val) => Interop.mkBarpolarAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarpolarProperty> ids(bool val) => Interop.mkBarpolarAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarpolarProperty> ids(params bool[] values) => Interop.mkBarpolarAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarpolarProperty> ids(System.DateTime val) => Interop.mkBarpolarAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarpolarProperty> ids(params System.DateTime[] values) => Interop.mkBarpolarAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarpolarProperty> ids(float val) => Interop.mkBarpolarAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarpolarProperty> ids(params float[] values) => Interop.mkBarpolarAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarpolarProperty> ids(int val) => Interop.mkBarpolarAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarpolarProperty> ids(params int[] values) => Interop.mkBarpolarAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarpolarProperty> ids(string val) => Interop.mkBarpolarAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarpolarProperty> ids(params string[] values) => Interop.mkBarpolarAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarpolarProperty> ids(IEnumerable<bool[]> values) => Interop.mkBarpolarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarpolarProperty> ids(List<bool[]> values) => Interop.mkBarpolarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarpolarProperty> ids(params bool[][] values) => Interop.mkBarpolarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarpolarProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkBarpolarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarpolarProperty> ids(List<string[]> values) => Interop.mkBarpolarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarpolarProperty> ids(params string[][] values) => Interop.mkBarpolarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarpolarProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkBarpolarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarpolarProperty> ids(List<int[]> values) => Interop.mkBarpolarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarpolarProperty> ids(params int[][] values) => Interop.mkBarpolarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarpolarProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkBarpolarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarpolarProperty> ids(List<float[]> values) => Interop.mkBarpolarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarpolarProperty> ids(params float[][] values) => Interop.mkBarpolarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarpolarProperty> ids(Literals.PlotData[] values) => Interop.mkBarpolarAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarpolarProperty> ids(IEnumerable<bool?> values) => Interop.mkBarpolarAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarpolarProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkBarpolarAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarpolarProperty> ids(IEnumerable<int?> values) => Interop.mkBarpolarAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IBarpolarProperty> ids(IEnumerable<float?> values) => Interop.mkBarpolarAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarpolarProperty> customdata(bool val) => Interop.mkBarpolarAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarpolarProperty> customdata(params bool[] values) => Interop.mkBarpolarAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarpolarProperty> customdata(System.DateTime val) => Interop.mkBarpolarAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarpolarProperty> customdata(params System.DateTime[] values) => Interop.mkBarpolarAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarpolarProperty> customdata(float val) => Interop.mkBarpolarAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarpolarProperty> customdata(params float[] values) => Interop.mkBarpolarAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarpolarProperty> customdata(int val) => Interop.mkBarpolarAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarpolarProperty> customdata(params int[] values) => Interop.mkBarpolarAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarpolarProperty> customdata(string val) => Interop.mkBarpolarAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarpolarProperty> customdata(params string[] values) => Interop.mkBarpolarAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarpolarProperty> customdata(IEnumerable<bool[]> values) => Interop.mkBarpolarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarpolarProperty> customdata(List<bool[]> values) => Interop.mkBarpolarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarpolarProperty> customdata(params bool[][] values) => Interop.mkBarpolarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarpolarProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkBarpolarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarpolarProperty> customdata(List<string[]> values) => Interop.mkBarpolarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarpolarProperty> customdata(params string[][] values) => Interop.mkBarpolarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarpolarProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkBarpolarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarpolarProperty> customdata(List<int[]> values) => Interop.mkBarpolarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarpolarProperty> customdata(params int[][] values) => Interop.mkBarpolarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarpolarProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkBarpolarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarpolarProperty> customdata(List<float[]> values) => Interop.mkBarpolarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarpolarProperty> customdata(params float[][] values) => Interop.mkBarpolarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarpolarProperty> customdata(Literals.PlotData[] values) => Interop.mkBarpolarAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarpolarProperty> customdata(IEnumerable<bool?> values) => Interop.mkBarpolarAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarpolarProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkBarpolarAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarpolarProperty> customdata(IEnumerable<int?> values) => Interop.mkBarpolarAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IBarpolarProperty> customdata(IEnumerable<float?> values) => Interop.mkBarpolarAttr("customdata", values.ToArray());
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBarpolarProperty> selectedpoints(bool val) => Interop.mkBarpolarAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBarpolarProperty> selectedpoints(params bool[] values) => Interop.mkBarpolarAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBarpolarProperty> selectedpoints(System.DateTime val) => Interop.mkBarpolarAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBarpolarProperty> selectedpoints(params System.DateTime[] values) => Interop.mkBarpolarAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBarpolarProperty> selectedpoints(int val) => Interop.mkBarpolarAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBarpolarProperty> selectedpoints(params int[] values) => Interop.mkBarpolarAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBarpolarProperty> selectedpoints(float val) => Interop.mkBarpolarAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBarpolarProperty> selectedpoints(params float[] values) => Interop.mkBarpolarAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBarpolarProperty> selectedpoints(string val) => Interop.mkBarpolarAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IBarpolarProperty> selectedpoints(params string[] values) => Interop.mkBarpolarAttr("selectedpoints", values);
        public static Box<IBarpolarProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkBarpolarAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IBarpolarProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkBarpolarAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IBarpolarProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkBarpolarAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBarpolarProperty> uirevision(bool val) => Interop.mkBarpolarAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBarpolarProperty> uirevision(params bool[] values) => Interop.mkBarpolarAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBarpolarProperty> uirevision(System.DateTime val) => Interop.mkBarpolarAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBarpolarProperty> uirevision(params System.DateTime[] values) => Interop.mkBarpolarAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBarpolarProperty> uirevision(int val) => Interop.mkBarpolarAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBarpolarProperty> uirevision(params int[] values) => Interop.mkBarpolarAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBarpolarProperty> uirevision(float val) => Interop.mkBarpolarAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBarpolarProperty> uirevision(params float[] values) => Interop.mkBarpolarAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBarpolarProperty> uirevision(string val) => Interop.mkBarpolarAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IBarpolarProperty> uirevision(params string[] values) => Interop.mkBarpolarAttr("uirevision", values);
        /// Sets the radial coordinates
        public static Box<IBarpolarProperty> r(bool val) => Interop.mkBarpolarAttr("r", new[]{val});
        /// Sets the radial coordinates
        public static Box<IBarpolarProperty> r(IEnumerable<bool> values) => Interop.mkBarpolarAttr("r", values.ToArray());
        /// Sets the radial coordinates
        public static Box<IBarpolarProperty> r(System.DateTime val) => Interop.mkBarpolarAttr("r", new[]{val});
        /// Sets the radial coordinates
        public static Box<IBarpolarProperty> r(IEnumerable<System.DateTime> values) => Interop.mkBarpolarAttr("r", values.ToArray());
        /// Sets the radial coordinates
        public static Box<IBarpolarProperty> r(float val) => Interop.mkBarpolarAttr("r", new[]{val});
        /// Sets the radial coordinates
        public static Box<IBarpolarProperty> r(IEnumerable<float> values) => Interop.mkBarpolarAttr("r", values.ToArray());
        /// Sets the radial coordinates
        public static Box<IBarpolarProperty> r(int val) => Interop.mkBarpolarAttr("r", new[]{val});
        /// Sets the radial coordinates
        public static Box<IBarpolarProperty> r(IEnumerable<int> values) => Interop.mkBarpolarAttr("r", values.ToArray());
        /// Sets the radial coordinates
        public static Box<IBarpolarProperty> r(string val) => Interop.mkBarpolarAttr("r", new[]{val});
        /// Sets the radial coordinates
        public static Box<IBarpolarProperty> r(IEnumerable<string> values) => Interop.mkBarpolarAttr("r", values.ToArray());
        /// Sets the radial coordinates
        public static Box<IBarpolarProperty> r(IEnumerable<bool[]> values) => Interop.mkBarpolarAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IBarpolarProperty> r(List<bool[]> values) => Interop.mkBarpolarAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IBarpolarProperty> r(params bool[][] values) => Interop.mkBarpolarAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IBarpolarProperty> r(IEnumerable<IEnumerable<string>> values) => Interop.mkBarpolarAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IBarpolarProperty> r(List<string[]> values) => Interop.mkBarpolarAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IBarpolarProperty> r(params string[][] values) => Interop.mkBarpolarAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IBarpolarProperty> r(IEnumerable<IEnumerable<int>> values) => Interop.mkBarpolarAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IBarpolarProperty> r(List<int[]> values) => Interop.mkBarpolarAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IBarpolarProperty> r(params int[][] values) => Interop.mkBarpolarAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IBarpolarProperty> r(IEnumerable<IEnumerable<float>> values) => Interop.mkBarpolarAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IBarpolarProperty> r(List<float[]> values) => Interop.mkBarpolarAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IBarpolarProperty> r(params float[][] values) => Interop.mkBarpolarAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IBarpolarProperty> r(Literals.PlotData[] values) => Interop.mkBarpolarAttr("r", values);
        /// Sets the radial coordinates
        public static Box<IBarpolarProperty> r(IEnumerable<bool?> values) => Interop.mkBarpolarAttr("r", values.ToArray());
        /// Sets the radial coordinates
        public static Box<IBarpolarProperty> r(IEnumerable<System.DateTime?> values) => Interop.mkBarpolarAttr("r", values.ToArray());
        /// Sets the radial coordinates
        public static Box<IBarpolarProperty> r(IEnumerable<int?> values) => Interop.mkBarpolarAttr("r", values.ToArray());
        /// Sets the radial coordinates
        public static Box<IBarpolarProperty> r(IEnumerable<float?> values) => Interop.mkBarpolarAttr("r", values.ToArray());
        /// Sets the angular coordinates
        public static Box<IBarpolarProperty> theta(bool val) => Interop.mkBarpolarAttr("theta", new[]{val});
        /// Sets the angular coordinates
        public static Box<IBarpolarProperty> theta(IEnumerable<bool> values) => Interop.mkBarpolarAttr("theta", values.ToArray());
        /// Sets the angular coordinates
        public static Box<IBarpolarProperty> theta(System.DateTime val) => Interop.mkBarpolarAttr("theta", new[]{val});
        /// Sets the angular coordinates
        public static Box<IBarpolarProperty> theta(IEnumerable<System.DateTime> values) => Interop.mkBarpolarAttr("theta", values.ToArray());
        /// Sets the angular coordinates
        public static Box<IBarpolarProperty> theta(float val) => Interop.mkBarpolarAttr("theta", new[]{val});
        /// Sets the angular coordinates
        public static Box<IBarpolarProperty> theta(IEnumerable<float> values) => Interop.mkBarpolarAttr("theta", values.ToArray());
        /// Sets the angular coordinates
        public static Box<IBarpolarProperty> theta(int val) => Interop.mkBarpolarAttr("theta", new[]{val});
        /// Sets the angular coordinates
        public static Box<IBarpolarProperty> theta(IEnumerable<int> values) => Interop.mkBarpolarAttr("theta", values.ToArray());
        /// Sets the angular coordinates
        public static Box<IBarpolarProperty> theta(string val) => Interop.mkBarpolarAttr("theta", new[]{val});
        /// Sets the angular coordinates
        public static Box<IBarpolarProperty> theta(IEnumerable<string> values) => Interop.mkBarpolarAttr("theta", values.ToArray());
        /// Sets the angular coordinates
        public static Box<IBarpolarProperty> theta(IEnumerable<bool[]> values) => Interop.mkBarpolarAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IBarpolarProperty> theta(List<bool[]> values) => Interop.mkBarpolarAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IBarpolarProperty> theta(params bool[][] values) => Interop.mkBarpolarAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IBarpolarProperty> theta(IEnumerable<IEnumerable<string>> values) => Interop.mkBarpolarAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IBarpolarProperty> theta(List<string[]> values) => Interop.mkBarpolarAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IBarpolarProperty> theta(params string[][] values) => Interop.mkBarpolarAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IBarpolarProperty> theta(IEnumerable<IEnumerable<int>> values) => Interop.mkBarpolarAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IBarpolarProperty> theta(List<int[]> values) => Interop.mkBarpolarAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IBarpolarProperty> theta(params int[][] values) => Interop.mkBarpolarAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IBarpolarProperty> theta(IEnumerable<IEnumerable<float>> values) => Interop.mkBarpolarAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IBarpolarProperty> theta(List<float[]> values) => Interop.mkBarpolarAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IBarpolarProperty> theta(params float[][] values) => Interop.mkBarpolarAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IBarpolarProperty> theta(Literals.PlotData[] values) => Interop.mkBarpolarAttr("theta", values);
        /// Sets the angular coordinates
        public static Box<IBarpolarProperty> theta(IEnumerable<bool?> values) => Interop.mkBarpolarAttr("theta", values.ToArray());
        /// Sets the angular coordinates
        public static Box<IBarpolarProperty> theta(IEnumerable<System.DateTime?> values) => Interop.mkBarpolarAttr("theta", values.ToArray());
        /// Sets the angular coordinates
        public static Box<IBarpolarProperty> theta(IEnumerable<int?> values) => Interop.mkBarpolarAttr("theta", values.ToArray());
        /// Sets the angular coordinates
        public static Box<IBarpolarProperty> theta(IEnumerable<float?> values) => Interop.mkBarpolarAttr("theta", values.ToArray());
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IBarpolarProperty> r0(bool val) => Interop.mkBarpolarAttr("r0", val);
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IBarpolarProperty> r0(params bool[] values) => Interop.mkBarpolarAttr("r0", values);
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IBarpolarProperty> r0(System.DateTime val) => Interop.mkBarpolarAttr("r0", val);
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IBarpolarProperty> r0(params System.DateTime[] values) => Interop.mkBarpolarAttr("r0", values);
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IBarpolarProperty> r0(int val) => Interop.mkBarpolarAttr("r0", val);
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IBarpolarProperty> r0(params int[] values) => Interop.mkBarpolarAttr("r0", values);
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IBarpolarProperty> r0(float val) => Interop.mkBarpolarAttr("r0", val);
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IBarpolarProperty> r0(params float[] values) => Interop.mkBarpolarAttr("r0", values);
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IBarpolarProperty> r0(string val) => Interop.mkBarpolarAttr("r0", val);
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IBarpolarProperty> r0(params string[] values) => Interop.mkBarpolarAttr("r0", values);
        /// Sets the r coordinate step.
        public static Box<IBarpolarProperty> dr(int val) => Interop.mkBarpolarAttr("dr", val);
        /// Sets the r coordinate step.
        public static Box<IBarpolarProperty> dr(float val) => Interop.mkBarpolarAttr("dr", val);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IBarpolarProperty> theta0(bool val) => Interop.mkBarpolarAttr("theta0", val);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IBarpolarProperty> theta0(params bool[] values) => Interop.mkBarpolarAttr("theta0", values);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IBarpolarProperty> theta0(System.DateTime val) => Interop.mkBarpolarAttr("theta0", val);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IBarpolarProperty> theta0(params System.DateTime[] values) => Interop.mkBarpolarAttr("theta0", values);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IBarpolarProperty> theta0(int val) => Interop.mkBarpolarAttr("theta0", val);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IBarpolarProperty> theta0(params int[] values) => Interop.mkBarpolarAttr("theta0", values);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IBarpolarProperty> theta0(float val) => Interop.mkBarpolarAttr("theta0", val);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IBarpolarProperty> theta0(params float[] values) => Interop.mkBarpolarAttr("theta0", values);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IBarpolarProperty> theta0(string val) => Interop.mkBarpolarAttr("theta0", val);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IBarpolarProperty> theta0(params string[] values) => Interop.mkBarpolarAttr("theta0", values);
        /// Sets the theta coordinate step. By default, the `dtheta` step equals the subplot's period divided by the length of the `r` coordinates.
        public static Box<IBarpolarProperty> dtheta(int val) => Interop.mkBarpolarAttr("dtheta", val);
        /// Sets the theta coordinate step. By default, the `dtheta` step equals the subplot's period divided by the length of the `r` coordinates.
        public static Box<IBarpolarProperty> dtheta(float val) => Interop.mkBarpolarAttr("dtheta", val);
        /// Sets where the bar base is drawn (in radial axis units). In *stack* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
        public static Box<IBarpolarProperty> _base(bool val) => Interop.mkBarpolarAttr("base", val);
        /// Sets where the bar base is drawn (in radial axis units). In *stack* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
        public static Box<IBarpolarProperty> _base(params bool[] values) => Interop.mkBarpolarAttr("base", values);
        /// Sets where the bar base is drawn (in radial axis units). In *stack* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
        public static Box<IBarpolarProperty> _base(System.DateTime val) => Interop.mkBarpolarAttr("base", val);
        /// Sets where the bar base is drawn (in radial axis units). In *stack* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
        public static Box<IBarpolarProperty> _base(params System.DateTime[] values) => Interop.mkBarpolarAttr("base", values);
        /// Sets where the bar base is drawn (in radial axis units). In *stack* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
        public static Box<IBarpolarProperty> _base(int val) => Interop.mkBarpolarAttr("base", val);
        /// Sets where the bar base is drawn (in radial axis units). In *stack* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
        public static Box<IBarpolarProperty> _base(params int[] values) => Interop.mkBarpolarAttr("base", values);
        /// Sets where the bar base is drawn (in radial axis units). In *stack* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
        public static Box<IBarpolarProperty> _base(float val) => Interop.mkBarpolarAttr("base", val);
        /// Sets where the bar base is drawn (in radial axis units). In *stack* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
        public static Box<IBarpolarProperty> _base(params float[] values) => Interop.mkBarpolarAttr("base", values);
        /// Sets where the bar base is drawn (in radial axis units). In *stack* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
        public static Box<IBarpolarProperty> _base(string val) => Interop.mkBarpolarAttr("base", val);
        /// Sets where the bar base is drawn (in radial axis units). In *stack* barmode, traces that set *base* will be excluded and drawn in *overlay* mode instead.
        public static Box<IBarpolarProperty> _base(params string[] values) => Interop.mkBarpolarAttr("base", values);
        /// Shifts the angular position where the bar is drawn (in *thetatunit* units).
        public static Box<IBarpolarProperty> offset(int val) => Interop.mkBarpolarAttr("offset", val);
        /// Shifts the angular position where the bar is drawn (in *thetatunit* units).
        public static Box<IBarpolarProperty> offset(float val) => Interop.mkBarpolarAttr("offset", val);
        /// Shifts the angular position where the bar is drawn (in *thetatunit* units).
        public static Box<IBarpolarProperty> offset(IEnumerable<int> values) => Interop.mkBarpolarAttr("offset", values.ToArray());
        /// Shifts the angular position where the bar is drawn (in *thetatunit* units).
        public static Box<IBarpolarProperty> offset(IEnumerable<float> values) => Interop.mkBarpolarAttr("offset", values.ToArray());
        /// Sets the bar angular width (in *thetaunit* units).
        public static Box<IBarpolarProperty> width(int val) => Interop.mkBarpolarAttr("width", val);
        /// Sets the bar angular width (in *thetaunit* units).
        public static Box<IBarpolarProperty> width(float val) => Interop.mkBarpolarAttr("width", val);
        /// Sets the bar angular width (in *thetaunit* units).
        public static Box<IBarpolarProperty> width(IEnumerable<int> values) => Interop.mkBarpolarAttr("width", values.ToArray());
        /// Sets the bar angular width (in *thetaunit* units).
        public static Box<IBarpolarProperty> width(IEnumerable<float> values) => Interop.mkBarpolarAttr("width", values.ToArray());
        /// Sets hover text elements associated with each bar. If a single string, the same string appears over all bars. If an array of string, the items are mapped in order to the this trace's coordinates.
        public static Box<IBarpolarProperty> text(string val) => Interop.mkBarpolarAttr("text", val);
        /// Sets hover text elements associated with each bar. If a single string, the same string appears over all bars. If an array of string, the items are mapped in order to the this trace's coordinates.
        public static Box<IBarpolarProperty> text(IEnumerable<string> values) => Interop.mkBarpolarAttr("text", values.ToArray());
        /// Same as `text`.
        public static Box<IBarpolarProperty> hovertext(string val) => Interop.mkBarpolarAttr("hovertext", val);
        /// Same as `text`.
        public static Box<IBarpolarProperty> hovertext(IEnumerable<string> values) => Interop.mkBarpolarAttr("hovertext", values.ToArray());
        public static Box<IBarpolarProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkBarpolarAttr("marker", Bindings.flattenProperties(properties));
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IBarpolarProperty> hoverinfo(params Box<IBarpolarProperty>[] properties) => Interop.mkBarpolarAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IBarpolarProperty> hovertemplate(string val) => Interop.mkBarpolarAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IBarpolarProperty> hovertemplate(IEnumerable<string> values) => Interop.mkBarpolarAttr("hovertemplate", values.ToArray());
        public static Box<IBarpolarProperty> selected(params Box<ISelectedProperty>[] properties) => Interop.mkBarpolarAttr("selected", Bindings.flattenProperties(properties));
        public static Box<IBarpolarProperty> unselected(params Box<IUnselectedProperty>[] properties) => Interop.mkBarpolarAttr("unselected", Bindings.flattenProperties(properties));
        /// Sets a reference between this trace's data coordinates and a polar subplot. If *polar* (the default value), the data refer to `layout.polar`. If *polar2*, the data refer to `layout.polar2`, and so on.
        public static Box<IBarpolarProperty> subplot(int anchorId) => Interop.mkBarpolarAttr("subplot", anchorId > 1 ? $"polar{anchorId}" : "");
        /// Sets a reference between this trace's data coordinates and a polar subplot. If *polar* (the default value), the data refer to `layout.polar`. If *polar2*, the data refer to `layout.polar2`, and so on.
        public static Box<IBarpolarProperty> subplot(string val) => Interop.mkBarpolarAttr("subplot", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IBarpolarProperty> idssrc(string val) => Interop.mkBarpolarAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IBarpolarProperty> customdatasrc(string val) => Interop.mkBarpolarAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IBarpolarProperty> metasrc(string val) => Interop.mkBarpolarAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  r .
        public static Box<IBarpolarProperty> rsrc(string val) => Interop.mkBarpolarAttr("rsrc", val);
        /// Sets the source reference on plot.ly for  theta .
        public static Box<IBarpolarProperty> thetasrc(string val) => Interop.mkBarpolarAttr("thetasrc", val);
        /// Sets the source reference on plot.ly for  base .
        public static Box<IBarpolarProperty> basesrc(string val) => Interop.mkBarpolarAttr("basesrc", val);
        /// Sets the source reference on plot.ly for  offset .
        public static Box<IBarpolarProperty> offsetsrc(string val) => Interop.mkBarpolarAttr("offsetsrc", val);
        /// Sets the source reference on plot.ly for  width .
        public static Box<IBarpolarProperty> widthsrc(string val) => Interop.mkBarpolarAttr("widthsrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IBarpolarProperty> textsrc(string val) => Interop.mkBarpolarAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IBarpolarProperty> hovertextsrc(string val) => Interop.mkBarpolarAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IBarpolarProperty> hoverinfosrc(string val) => Interop.mkBarpolarAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IBarpolarProperty> hovertemplatesrc(string val) => Interop.mkBarpolarAttr("hovertemplatesrc", val);
    }

    public static partial class Barpolar
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IBarpolarProperty> legendonly() => Interop.mkBarpolarAttr("visible", "legendonly");
            public static Box<IBarpolarProperty> _false() => Interop.mkBarpolarAttr("visible", false);
            public static Box<IBarpolarProperty> _true() => Interop.mkBarpolarAttr("visible", true);
        }

        /// Sets the unit of input *theta* values. Has an effect only when on *linear* angular axes.
        public static partial class Thetaunit
        {
            public static Box<IBarpolarProperty> degrees() => Interop.mkBarpolarAttr("thetaunit", "degrees");
            public static Box<IBarpolarProperty> gradians() => Interop.mkBarpolarAttr("thetaunit", "gradians");
            public static Box<IBarpolarProperty> radians() => Interop.mkBarpolarAttr("thetaunit", "radians");
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IBarpolarProperty> all() => Interop.mkBarpolarAttr("hoverinfo", "all");
            public static Box<IBarpolarProperty> none() => Interop.mkBarpolarAttr("hoverinfo", "none");
            public static Box<IBarpolarProperty> skip() => Interop.mkBarpolarAttr("hoverinfo", "skip");
            public static Box<IBarpolarProperty> name() => Interop.mkBarpolarAttr("hoverinfo", "name");
            public static Box<IBarpolarProperty> r() => Interop.mkBarpolarAttr("hoverinfo", "r");
            public static Box<IBarpolarProperty> text() => Interop.mkBarpolarAttr("hoverinfo", "text");
            public static Box<IBarpolarProperty> theta() => Interop.mkBarpolarAttr("hoverinfo", "theta");
        }
    }
}