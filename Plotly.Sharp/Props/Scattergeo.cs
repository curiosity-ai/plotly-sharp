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

    public static partial class Scattergeo
    {
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IScattergeoProperty> showlegend(bool val) => Interop.mkScattergeoAttr("showlegend", val);
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IScattergeoProperty> legendgroup(string val) => Interop.mkScattergeoAttr("legendgroup", val);
        /// Sets the opacity of the trace.
        public static Box<IScattergeoProperty> opacity(int val) => Interop.mkScattergeoAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<IScattergeoProperty> opacity(float val) => Interop.mkScattergeoAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IScattergeoProperty> name(string val) => Interop.mkScattergeoAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IScattergeoProperty> uid(string val) => Interop.mkScattergeoAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattergeoProperty> ids(bool val) => Interop.mkScattergeoAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattergeoProperty> ids(params bool[] values) => Interop.mkScattergeoAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattergeoProperty> ids(System.DateTime val) => Interop.mkScattergeoAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattergeoProperty> ids(params System.DateTime[] values) => Interop.mkScattergeoAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattergeoProperty> ids(float val) => Interop.mkScattergeoAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattergeoProperty> ids(params float[] values) => Interop.mkScattergeoAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattergeoProperty> ids(int val) => Interop.mkScattergeoAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattergeoProperty> ids(params int[] values) => Interop.mkScattergeoAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattergeoProperty> ids(string val) => Interop.mkScattergeoAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattergeoProperty> ids(params string[] values) => Interop.mkScattergeoAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattergeoProperty> ids(IEnumerable<bool[]> values) => Interop.mkScattergeoAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattergeoProperty> ids(List<bool[]> values) => Interop.mkScattergeoAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattergeoProperty> ids(params bool[][] values) => Interop.mkScattergeoAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattergeoProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkScattergeoAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattergeoProperty> ids(List<string[]> values) => Interop.mkScattergeoAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattergeoProperty> ids(params string[][] values) => Interop.mkScattergeoAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattergeoProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkScattergeoAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattergeoProperty> ids(List<int[]> values) => Interop.mkScattergeoAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattergeoProperty> ids(params int[][] values) => Interop.mkScattergeoAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattergeoProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkScattergeoAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattergeoProperty> ids(List<float[]> values) => Interop.mkScattergeoAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattergeoProperty> ids(params float[][] values) => Interop.mkScattergeoAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattergeoProperty> ids(Literals.PlotData[] values) => Interop.mkScattergeoAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattergeoProperty> ids(IEnumerable<bool?> values) => Interop.mkScattergeoAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattergeoProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkScattergeoAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattergeoProperty> ids(IEnumerable<int?> values) => Interop.mkScattergeoAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattergeoProperty> ids(IEnumerable<float?> values) => Interop.mkScattergeoAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattergeoProperty> customdata(bool val) => Interop.mkScattergeoAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattergeoProperty> customdata(params bool[] values) => Interop.mkScattergeoAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattergeoProperty> customdata(System.DateTime val) => Interop.mkScattergeoAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattergeoProperty> customdata(params System.DateTime[] values) => Interop.mkScattergeoAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattergeoProperty> customdata(float val) => Interop.mkScattergeoAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattergeoProperty> customdata(params float[] values) => Interop.mkScattergeoAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattergeoProperty> customdata(int val) => Interop.mkScattergeoAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattergeoProperty> customdata(params int[] values) => Interop.mkScattergeoAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattergeoProperty> customdata(string val) => Interop.mkScattergeoAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattergeoProperty> customdata(params string[] values) => Interop.mkScattergeoAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattergeoProperty> customdata(IEnumerable<bool[]> values) => Interop.mkScattergeoAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattergeoProperty> customdata(List<bool[]> values) => Interop.mkScattergeoAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattergeoProperty> customdata(params bool[][] values) => Interop.mkScattergeoAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattergeoProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkScattergeoAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattergeoProperty> customdata(List<string[]> values) => Interop.mkScattergeoAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattergeoProperty> customdata(params string[][] values) => Interop.mkScattergeoAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattergeoProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkScattergeoAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattergeoProperty> customdata(List<int[]> values) => Interop.mkScattergeoAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattergeoProperty> customdata(params int[][] values) => Interop.mkScattergeoAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattergeoProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkScattergeoAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattergeoProperty> customdata(List<float[]> values) => Interop.mkScattergeoAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattergeoProperty> customdata(params float[][] values) => Interop.mkScattergeoAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattergeoProperty> customdata(Literals.PlotData[] values) => Interop.mkScattergeoAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattergeoProperty> customdata(IEnumerable<bool?> values) => Interop.mkScattergeoAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattergeoProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkScattergeoAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattergeoProperty> customdata(IEnumerable<int?> values) => Interop.mkScattergeoAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattergeoProperty> customdata(IEnumerable<float?> values) => Interop.mkScattergeoAttr("customdata", values.ToArray());
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattergeoProperty> selectedpoints(bool val) => Interop.mkScattergeoAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattergeoProperty> selectedpoints(params bool[] values) => Interop.mkScattergeoAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattergeoProperty> selectedpoints(System.DateTime val) => Interop.mkScattergeoAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattergeoProperty> selectedpoints(params System.DateTime[] values) => Interop.mkScattergeoAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattergeoProperty> selectedpoints(int val) => Interop.mkScattergeoAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattergeoProperty> selectedpoints(params int[] values) => Interop.mkScattergeoAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattergeoProperty> selectedpoints(float val) => Interop.mkScattergeoAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattergeoProperty> selectedpoints(params float[] values) => Interop.mkScattergeoAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattergeoProperty> selectedpoints(string val) => Interop.mkScattergeoAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattergeoProperty> selectedpoints(params string[] values) => Interop.mkScattergeoAttr("selectedpoints", values);
        public static Box<IScattergeoProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkScattergeoAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IScattergeoProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkScattergeoAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IScattergeoProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkScattergeoAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattergeoProperty> uirevision(bool val) => Interop.mkScattergeoAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattergeoProperty> uirevision(params bool[] values) => Interop.mkScattergeoAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattergeoProperty> uirevision(System.DateTime val) => Interop.mkScattergeoAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattergeoProperty> uirevision(params System.DateTime[] values) => Interop.mkScattergeoAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattergeoProperty> uirevision(int val) => Interop.mkScattergeoAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattergeoProperty> uirevision(params int[] values) => Interop.mkScattergeoAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattergeoProperty> uirevision(float val) => Interop.mkScattergeoAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattergeoProperty> uirevision(params float[] values) => Interop.mkScattergeoAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattergeoProperty> uirevision(string val) => Interop.mkScattergeoAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattergeoProperty> uirevision(params string[] values) => Interop.mkScattergeoAttr("uirevision", values);
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattergeoProperty> lon(bool val) => Interop.mkScattergeoAttr("lon", new[]{val});
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattergeoProperty> lon(params bool[] values) => Interop.mkScattergeoAttr("lon", values);
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattergeoProperty> lon(System.DateTime val) => Interop.mkScattergeoAttr("lon", new[]{val});
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattergeoProperty> lon(params System.DateTime[] values) => Interop.mkScattergeoAttr("lon", values);
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattergeoProperty> lon(float val) => Interop.mkScattergeoAttr("lon", new[]{val});
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattergeoProperty> lon(params float[] values) => Interop.mkScattergeoAttr("lon", values);
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattergeoProperty> lon(int val) => Interop.mkScattergeoAttr("lon", new[]{val});
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattergeoProperty> lon(params int[] values) => Interop.mkScattergeoAttr("lon", values);
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattergeoProperty> lon(string val) => Interop.mkScattergeoAttr("lon", new[]{val});
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattergeoProperty> lon(params string[] values) => Interop.mkScattergeoAttr("lon", values);
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattergeoProperty> lon(IEnumerable<bool[]> values) => Interop.mkScattergeoAttr("lon", Bindings.flatten2DArrayIf1D(values));
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattergeoProperty> lon(List<bool[]> values) => Interop.mkScattergeoAttr("lon", Bindings.flatten2DArrayIf1D(values));
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattergeoProperty> lon(params bool[][] values) => Interop.mkScattergeoAttr("lon", Bindings.flatten2DArrayIf1D(values));
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattergeoProperty> lon(IEnumerable<IEnumerable<string>> values) => Interop.mkScattergeoAttr("lon", Bindings.flatten2DArrayIf1D(values));
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattergeoProperty> lon(List<string[]> values) => Interop.mkScattergeoAttr("lon", Bindings.flatten2DArrayIf1D(values));
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattergeoProperty> lon(params string[][] values) => Interop.mkScattergeoAttr("lon", Bindings.flatten2DArrayIf1D(values));
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattergeoProperty> lon(IEnumerable<IEnumerable<int>> values) => Interop.mkScattergeoAttr("lon", Bindings.flatten2DArrayIf1D(values));
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattergeoProperty> lon(List<int[]> values) => Interop.mkScattergeoAttr("lon", Bindings.flatten2DArrayIf1D(values));
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattergeoProperty> lon(params int[][] values) => Interop.mkScattergeoAttr("lon", Bindings.flatten2DArrayIf1D(values));
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattergeoProperty> lon(IEnumerable<IEnumerable<float>> values) => Interop.mkScattergeoAttr("lon", Bindings.flatten2DArrayIf1D(values));
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattergeoProperty> lon(List<float[]> values) => Interop.mkScattergeoAttr("lon", Bindings.flatten2DArrayIf1D(values));
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattergeoProperty> lon(params float[][] values) => Interop.mkScattergeoAttr("lon", Bindings.flatten2DArrayIf1D(values));
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattergeoProperty> lon(Literals.PlotData[] values) => Interop.mkScattergeoAttr("lon", values);
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattergeoProperty> lon(IEnumerable<bool?> values) => Interop.mkScattergeoAttr("lon", values.ToArray());
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattergeoProperty> lon(IEnumerable<System.DateTime?> values) => Interop.mkScattergeoAttr("lon", values.ToArray());
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattergeoProperty> lon(IEnumerable<int?> values) => Interop.mkScattergeoAttr("lon", values.ToArray());
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattergeoProperty> lon(IEnumerable<float?> values) => Interop.mkScattergeoAttr("lon", values.ToArray());
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattergeoProperty> lat(bool val) => Interop.mkScattergeoAttr("lat", new[]{val});
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattergeoProperty> lat(params bool[] values) => Interop.mkScattergeoAttr("lat", values);
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattergeoProperty> lat(System.DateTime val) => Interop.mkScattergeoAttr("lat", new[]{val});
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattergeoProperty> lat(params System.DateTime[] values) => Interop.mkScattergeoAttr("lat", values);
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattergeoProperty> lat(float val) => Interop.mkScattergeoAttr("lat", new[]{val});
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattergeoProperty> lat(params float[] values) => Interop.mkScattergeoAttr("lat", values);
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattergeoProperty> lat(int val) => Interop.mkScattergeoAttr("lat", new[]{val});
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattergeoProperty> lat(params int[] values) => Interop.mkScattergeoAttr("lat", values);
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattergeoProperty> lat(string val) => Interop.mkScattergeoAttr("lat", new[]{val});
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattergeoProperty> lat(params string[] values) => Interop.mkScattergeoAttr("lat", values);
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattergeoProperty> lat(IEnumerable<bool[]> values) => Interop.mkScattergeoAttr("lat", Bindings.flatten2DArrayIf1D(values));
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattergeoProperty> lat(List<bool[]> values) => Interop.mkScattergeoAttr("lat", Bindings.flatten2DArrayIf1D(values));
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattergeoProperty> lat(params bool[][] values) => Interop.mkScattergeoAttr("lat", Bindings.flatten2DArrayIf1D(values));
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattergeoProperty> lat(IEnumerable<IEnumerable<string>> values) => Interop.mkScattergeoAttr("lat", Bindings.flatten2DArrayIf1D(values));
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattergeoProperty> lat(List<string[]> values) => Interop.mkScattergeoAttr("lat", Bindings.flatten2DArrayIf1D(values));
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattergeoProperty> lat(params string[][] values) => Interop.mkScattergeoAttr("lat", Bindings.flatten2DArrayIf1D(values));
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattergeoProperty> lat(IEnumerable<IEnumerable<int>> values) => Interop.mkScattergeoAttr("lat", Bindings.flatten2DArrayIf1D(values));
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattergeoProperty> lat(List<int[]> values) => Interop.mkScattergeoAttr("lat", Bindings.flatten2DArrayIf1D(values));
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattergeoProperty> lat(params int[][] values) => Interop.mkScattergeoAttr("lat", Bindings.flatten2DArrayIf1D(values));
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattergeoProperty> lat(IEnumerable<IEnumerable<float>> values) => Interop.mkScattergeoAttr("lat", Bindings.flatten2DArrayIf1D(values));
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattergeoProperty> lat(List<float[]> values) => Interop.mkScattergeoAttr("lat", Bindings.flatten2DArrayIf1D(values));
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattergeoProperty> lat(params float[][] values) => Interop.mkScattergeoAttr("lat", Bindings.flatten2DArrayIf1D(values));
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattergeoProperty> lat(Literals.PlotData[] values) => Interop.mkScattergeoAttr("lat", values);
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattergeoProperty> lat(IEnumerable<bool?> values) => Interop.mkScattergeoAttr("lat", values.ToArray());
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattergeoProperty> lat(IEnumerable<System.DateTime?> values) => Interop.mkScattergeoAttr("lat", values.ToArray());
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattergeoProperty> lat(IEnumerable<int?> values) => Interop.mkScattergeoAttr("lat", values.ToArray());
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattergeoProperty> lat(IEnumerable<float?> values) => Interop.mkScattergeoAttr("lat", values.ToArray());
        /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
        public static Box<IScattergeoProperty> locations(bool val) => Interop.mkScattergeoAttr("locations", new[]{val});
        /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
        public static Box<IScattergeoProperty> locations(params bool[] values) => Interop.mkScattergeoAttr("locations", values);
        /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
        public static Box<IScattergeoProperty> locations(System.DateTime val) => Interop.mkScattergeoAttr("locations", new[]{val});
        /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
        public static Box<IScattergeoProperty> locations(params System.DateTime[] values) => Interop.mkScattergeoAttr("locations", values);
        /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
        public static Box<IScattergeoProperty> locations(float val) => Interop.mkScattergeoAttr("locations", new[]{val});
        /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
        public static Box<IScattergeoProperty> locations(params float[] values) => Interop.mkScattergeoAttr("locations", values);
        /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
        public static Box<IScattergeoProperty> locations(int val) => Interop.mkScattergeoAttr("locations", new[]{val});
        /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
        public static Box<IScattergeoProperty> locations(params int[] values) => Interop.mkScattergeoAttr("locations", values);
        /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
        public static Box<IScattergeoProperty> locations(string val) => Interop.mkScattergeoAttr("locations", new[]{val});
        /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
        public static Box<IScattergeoProperty> locations(params string[] values) => Interop.mkScattergeoAttr("locations", values);
        /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
        public static Box<IScattergeoProperty> locations(IEnumerable<bool[]> values) => Interop.mkScattergeoAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
        public static Box<IScattergeoProperty> locations(List<bool[]> values) => Interop.mkScattergeoAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
        public static Box<IScattergeoProperty> locations(params bool[][] values) => Interop.mkScattergeoAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
        public static Box<IScattergeoProperty> locations(IEnumerable<IEnumerable<string>> values) => Interop.mkScattergeoAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
        public static Box<IScattergeoProperty> locations(List<string[]> values) => Interop.mkScattergeoAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
        public static Box<IScattergeoProperty> locations(params string[][] values) => Interop.mkScattergeoAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
        public static Box<IScattergeoProperty> locations(IEnumerable<IEnumerable<int>> values) => Interop.mkScattergeoAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
        public static Box<IScattergeoProperty> locations(List<int[]> values) => Interop.mkScattergeoAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
        public static Box<IScattergeoProperty> locations(params int[][] values) => Interop.mkScattergeoAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
        public static Box<IScattergeoProperty> locations(IEnumerable<IEnumerable<float>> values) => Interop.mkScattergeoAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
        public static Box<IScattergeoProperty> locations(List<float[]> values) => Interop.mkScattergeoAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
        public static Box<IScattergeoProperty> locations(params float[][] values) => Interop.mkScattergeoAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
        public static Box<IScattergeoProperty> locations(Literals.PlotData[] values) => Interop.mkScattergeoAttr("locations", values);
        /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
        public static Box<IScattergeoProperty> locations(IEnumerable<bool?> values) => Interop.mkScattergeoAttr("locations", values.ToArray());
        /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
        public static Box<IScattergeoProperty> locations(IEnumerable<System.DateTime?> values) => Interop.mkScattergeoAttr("locations", values.ToArray());
        /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
        public static Box<IScattergeoProperty> locations(IEnumerable<int?> values) => Interop.mkScattergeoAttr("locations", values.ToArray());
        /// Sets the coordinates via location IDs or names. Coordinates correspond to the centroid of each location given. See `locationmode` for more info.
        public static Box<IScattergeoProperty> locations(IEnumerable<float?> values) => Interop.mkScattergeoAttr("locations", values.ToArray());
        /// Determines the drawing mode for this scatter trace. If the provided `mode` includes *text* then the `text` elements appear at the coordinates. Otherwise, the `text` elements appear on hover. If there are less than 20 points and the trace is not stacked then the default is *lines+markers*. Otherwise, *lines*.
        public static Box<IScattergeoProperty> mode(params Box<IScattergeoProperty>[] properties) => Interop.mkScattergeoAttr("mode", Bindings.joinEnumProperties(properties));
        /// Sets text elements associated with each (lon,lat) pair or item in `locations`. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (lon,lat) or `locations` coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IScattergeoProperty> text(string val) => Interop.mkScattergeoAttr("text", val);
        /// Sets text elements associated with each (lon,lat) pair or item in `locations`. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (lon,lat) or `locations` coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IScattergeoProperty> text(IEnumerable<string> values) => Interop.mkScattergeoAttr("text", values.ToArray());
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `lat`, `lon`, `location` and `text`.
        public static Box<IScattergeoProperty> texttemplate(string val) => Interop.mkScattergeoAttr("texttemplate", val);
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `lat`, `lon`, `location` and `text`.
        public static Box<IScattergeoProperty> texttemplate(IEnumerable<string> values) => Interop.mkScattergeoAttr("texttemplate", values.ToArray());
        /// Sets hover text elements associated with each (lon,lat) pair or item in `locations`. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (lon,lat) or `locations` coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IScattergeoProperty> hovertext(string val) => Interop.mkScattergeoAttr("hovertext", val);
        /// Sets hover text elements associated with each (lon,lat) pair or item in `locations`. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (lon,lat) or `locations` coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IScattergeoProperty> hovertext(IEnumerable<string> values) => Interop.mkScattergeoAttr("hovertext", values.ToArray());
        /// Sets the text font.
        public static Box<IScattergeoProperty> textfont(params Box<ITextfontProperty>[] properties) => Interop.mkScattergeoAttr("textfont", Bindings.flattenProperties(properties));
        /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
        public static Box<IScattergeoProperty> textposition(IEnumerable<Box<IScattergeoProperty>> properties) => Interop.mkScattergeoAttr("textposition", Bindings.flattenProperties(properties));
        public static Box<IScattergeoProperty> line(params Box<ILineProperty>[] properties) => Interop.mkScattergeoAttr("line", Bindings.flattenProperties(properties));
        /// Determines whether or not gaps (i.e. {nan} or missing values) in the provided data arrays are connected.
        public static Box<IScattergeoProperty> connectgaps(bool val) => Interop.mkScattergeoAttr("connectgaps", val);
        public static Box<IScattergeoProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkScattergeoAttr("marker", Bindings.flattenProperties(properties));
        /// Sets the fill color. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
        public static Box<IScattergeoProperty> fillcolor(string val) => Interop.mkScattergeoAttr("fillcolor", val);
        public static Box<IScattergeoProperty> selected(params Box<ISelectedProperty>[] properties) => Interop.mkScattergeoAttr("selected", Bindings.flattenProperties(properties));
        public static Box<IScattergeoProperty> unselected(params Box<IUnselectedProperty>[] properties) => Interop.mkScattergeoAttr("unselected", Bindings.flattenProperties(properties));
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IScattergeoProperty> hoverinfo(params Box<IScattergeoProperty>[] properties) => Interop.mkScattergeoAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IScattergeoProperty> hovertemplate(string val) => Interop.mkScattergeoAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IScattergeoProperty> hovertemplate(IEnumerable<string> values) => Interop.mkScattergeoAttr("hovertemplate", values.ToArray());
        /// Sets a reference between this trace's geospatial coordinates and a geographic map. If *geo* (the default value), the geospatial coordinates refer to `layout.geo`. If *geo2*, the geospatial coordinates refer to `layout.geo2`, and so on.
        public static Box<IScattergeoProperty> geo(int anchorId) => Interop.mkScattergeoAttr("geo", anchorId > 1 ? $"geo{anchorId}" : "");
        /// Sets a reference between this trace's geospatial coordinates and a geographic map. If *geo* (the default value), the geospatial coordinates refer to `layout.geo`. If *geo2*, the geospatial coordinates refer to `layout.geo2`, and so on.
        public static Box<IScattergeoProperty> geo(string val) => Interop.mkScattergeoAttr("geo", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IScattergeoProperty> idssrc(string val) => Interop.mkScattergeoAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IScattergeoProperty> customdatasrc(string val) => Interop.mkScattergeoAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IScattergeoProperty> metasrc(string val) => Interop.mkScattergeoAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  lon .
        public static Box<IScattergeoProperty> lonsrc(string val) => Interop.mkScattergeoAttr("lonsrc", val);
        /// Sets the source reference on plot.ly for  lat .
        public static Box<IScattergeoProperty> latsrc(string val) => Interop.mkScattergeoAttr("latsrc", val);
        /// Sets the source reference on plot.ly for  locations .
        public static Box<IScattergeoProperty> locationssrc(string val) => Interop.mkScattergeoAttr("locationssrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IScattergeoProperty> textsrc(string val) => Interop.mkScattergeoAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  texttemplate .
        public static Box<IScattergeoProperty> texttemplatesrc(string val) => Interop.mkScattergeoAttr("texttemplatesrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IScattergeoProperty> hovertextsrc(string val) => Interop.mkScattergeoAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  textposition .
        public static Box<IScattergeoProperty> textpositionsrc(string val) => Interop.mkScattergeoAttr("textpositionsrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IScattergeoProperty> hoverinfosrc(string val) => Interop.mkScattergeoAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IScattergeoProperty> hovertemplatesrc(string val) => Interop.mkScattergeoAttr("hovertemplatesrc", val);
    }

    public static partial class Scattergeo
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IScattergeoProperty> legendonly() => Interop.mkScattergeoAttr("visible", "legendonly");
            public static Box<IScattergeoProperty> _false() => Interop.mkScattergeoAttr("visible", false);
            public static Box<IScattergeoProperty> _true() => Interop.mkScattergeoAttr("visible", true);
        }

        /// Determines the set of locations used to match entries in `locations` to regions on the map.
        public static partial class Locationmode
        {
            public static Box<IScattergeoProperty> ISO3() => Interop.mkScattergeoAttr("locationmode", "ISO-3");
            public static Box<IScattergeoProperty> USAStates() => Interop.mkScattergeoAttr("locationmode", "USA-states");
            public static Box<IScattergeoProperty> countryNames() => Interop.mkScattergeoAttr("locationmode", "country names");
        }

        /// Determines the drawing mode for this scatter trace. If the provided `mode` includes *text* then the `text` elements appear at the coordinates. Otherwise, the `text` elements appear on hover. If there are less than 20 points and the trace is not stacked then the default is *lines+markers*. Otherwise, *lines*.
        public static partial class Mode
        {
            public static Box<IScattergeoProperty> none() => Interop.mkScattergeoAttr("mode", "none");
            public static Box<IScattergeoProperty> lines() => Interop.mkScattergeoAttr("mode", "lines");
            public static Box<IScattergeoProperty> markers() => Interop.mkScattergeoAttr("mode", "markers");
            public static Box<IScattergeoProperty> text() => Interop.mkScattergeoAttr("mode", "text");
        }

        /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
        public static partial class Textposition
        {
            public static Box<IScattergeoProperty> bottomCenter() => Interop.mkScattergeoAttr("textposition", "bottom center");
            public static Box<IScattergeoProperty> bottomLeft() => Interop.mkScattergeoAttr("textposition", "bottom left");
            public static Box<IScattergeoProperty> bottomRight() => Interop.mkScattergeoAttr("textposition", "bottom right");
            public static Box<IScattergeoProperty> middleCenter() => Interop.mkScattergeoAttr("textposition", "middle center");
            public static Box<IScattergeoProperty> middleLeft() => Interop.mkScattergeoAttr("textposition", "middle left");
            public static Box<IScattergeoProperty> middleRight() => Interop.mkScattergeoAttr("textposition", "middle right");
            public static Box<IScattergeoProperty> topCenter() => Interop.mkScattergeoAttr("textposition", "top center");
            public static Box<IScattergeoProperty> topLeft() => Interop.mkScattergeoAttr("textposition", "top left");
            public static Box<IScattergeoProperty> topRight() => Interop.mkScattergeoAttr("textposition", "top right");
        }

        /// Sets the area to fill with a solid color. Use with `fillcolor` if not *none*. *toself* connects the endpoints of the trace (or each segment of the trace if it has gaps) into a closed shape.
        public static partial class Fill
        {
            public static Box<IScattergeoProperty> none() => Interop.mkScattergeoAttr("fill", "none");
            public static Box<IScattergeoProperty> toself() => Interop.mkScattergeoAttr("fill", "toself");
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IScattergeoProperty> all() => Interop.mkScattergeoAttr("hoverinfo", "all");
            public static Box<IScattergeoProperty> none() => Interop.mkScattergeoAttr("hoverinfo", "none");
            public static Box<IScattergeoProperty> skip() => Interop.mkScattergeoAttr("hoverinfo", "skip");
            public static Box<IScattergeoProperty> lat() => Interop.mkScattergeoAttr("hoverinfo", "lat");
            public static Box<IScattergeoProperty> location() => Interop.mkScattergeoAttr("hoverinfo", "location");
            public static Box<IScattergeoProperty> lon() => Interop.mkScattergeoAttr("hoverinfo", "lon");
            public static Box<IScattergeoProperty> name() => Interop.mkScattergeoAttr("hoverinfo", "name");
            public static Box<IScattergeoProperty> text() => Interop.mkScattergeoAttr("hoverinfo", "text");
        }
    }
}