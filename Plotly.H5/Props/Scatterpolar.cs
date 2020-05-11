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

    public static partial class Scatterpolar
    {
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IScatterpolarProperty> showlegend(bool val) => Interop.mkScatterpolarAttr("showlegend", val);
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IScatterpolarProperty> legendgroup(string val) => Interop.mkScatterpolarAttr("legendgroup", val);
        /// Sets the opacity of the trace.
        public static Box<IScatterpolarProperty> opacity(int val) => Interop.mkScatterpolarAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<IScatterpolarProperty> opacity(float val) => Interop.mkScatterpolarAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IScatterpolarProperty> name(string val) => Interop.mkScatterpolarAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IScatterpolarProperty> uid(string val) => Interop.mkScatterpolarAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarProperty> ids(bool val) => Interop.mkScatterpolarAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarProperty> ids(params bool[] values) => Interop.mkScatterpolarAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarProperty> ids(System.DateTime val) => Interop.mkScatterpolarAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarProperty> ids(params System.DateTime[] values) => Interop.mkScatterpolarAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarProperty> ids(float val) => Interop.mkScatterpolarAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarProperty> ids(params float[] values) => Interop.mkScatterpolarAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarProperty> ids(int val) => Interop.mkScatterpolarAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarProperty> ids(params int[] values) => Interop.mkScatterpolarAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarProperty> ids(string val) => Interop.mkScatterpolarAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarProperty> ids(params string[] values) => Interop.mkScatterpolarAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarProperty> ids(IEnumerable<bool[]> values) => Interop.mkScatterpolarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarProperty> ids(List<bool[]> values) => Interop.mkScatterpolarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarProperty> ids(params bool[][] values) => Interop.mkScatterpolarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkScatterpolarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarProperty> ids(List<string[]> values) => Interop.mkScatterpolarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarProperty> ids(params string[][] values) => Interop.mkScatterpolarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkScatterpolarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarProperty> ids(List<int[]> values) => Interop.mkScatterpolarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarProperty> ids(params int[][] values) => Interop.mkScatterpolarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkScatterpolarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarProperty> ids(List<float[]> values) => Interop.mkScatterpolarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarProperty> ids(params float[][] values) => Interop.mkScatterpolarAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarProperty> ids(Literals.PlotData[] values) => Interop.mkScatterpolarAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarProperty> ids(IEnumerable<bool?> values) => Interop.mkScatterpolarAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkScatterpolarAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarProperty> ids(IEnumerable<int?> values) => Interop.mkScatterpolarAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarProperty> ids(IEnumerable<float?> values) => Interop.mkScatterpolarAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarProperty> customdata(bool val) => Interop.mkScatterpolarAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarProperty> customdata(params bool[] values) => Interop.mkScatterpolarAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarProperty> customdata(System.DateTime val) => Interop.mkScatterpolarAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarProperty> customdata(params System.DateTime[] values) => Interop.mkScatterpolarAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarProperty> customdata(float val) => Interop.mkScatterpolarAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarProperty> customdata(params float[] values) => Interop.mkScatterpolarAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarProperty> customdata(int val) => Interop.mkScatterpolarAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarProperty> customdata(params int[] values) => Interop.mkScatterpolarAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarProperty> customdata(string val) => Interop.mkScatterpolarAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarProperty> customdata(params string[] values) => Interop.mkScatterpolarAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarProperty> customdata(IEnumerable<bool[]> values) => Interop.mkScatterpolarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarProperty> customdata(List<bool[]> values) => Interop.mkScatterpolarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarProperty> customdata(params bool[][] values) => Interop.mkScatterpolarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkScatterpolarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarProperty> customdata(List<string[]> values) => Interop.mkScatterpolarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarProperty> customdata(params string[][] values) => Interop.mkScatterpolarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkScatterpolarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarProperty> customdata(List<int[]> values) => Interop.mkScatterpolarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarProperty> customdata(params int[][] values) => Interop.mkScatterpolarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkScatterpolarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarProperty> customdata(List<float[]> values) => Interop.mkScatterpolarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarProperty> customdata(params float[][] values) => Interop.mkScatterpolarAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarProperty> customdata(Literals.PlotData[] values) => Interop.mkScatterpolarAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarProperty> customdata(IEnumerable<bool?> values) => Interop.mkScatterpolarAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkScatterpolarAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarProperty> customdata(IEnumerable<int?> values) => Interop.mkScatterpolarAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarProperty> customdata(IEnumerable<float?> values) => Interop.mkScatterpolarAttr("customdata", values.ToArray());
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterpolarProperty> selectedpoints(bool val) => Interop.mkScatterpolarAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterpolarProperty> selectedpoints(params bool[] values) => Interop.mkScatterpolarAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterpolarProperty> selectedpoints(System.DateTime val) => Interop.mkScatterpolarAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterpolarProperty> selectedpoints(params System.DateTime[] values) => Interop.mkScatterpolarAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterpolarProperty> selectedpoints(int val) => Interop.mkScatterpolarAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterpolarProperty> selectedpoints(params int[] values) => Interop.mkScatterpolarAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterpolarProperty> selectedpoints(float val) => Interop.mkScatterpolarAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterpolarProperty> selectedpoints(params float[] values) => Interop.mkScatterpolarAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterpolarProperty> selectedpoints(string val) => Interop.mkScatterpolarAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterpolarProperty> selectedpoints(params string[] values) => Interop.mkScatterpolarAttr("selectedpoints", values);
        public static Box<IScatterpolarProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkScatterpolarAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IScatterpolarProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkScatterpolarAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IScatterpolarProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkScatterpolarAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterpolarProperty> uirevision(bool val) => Interop.mkScatterpolarAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterpolarProperty> uirevision(params bool[] values) => Interop.mkScatterpolarAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterpolarProperty> uirevision(System.DateTime val) => Interop.mkScatterpolarAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterpolarProperty> uirevision(params System.DateTime[] values) => Interop.mkScatterpolarAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterpolarProperty> uirevision(int val) => Interop.mkScatterpolarAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterpolarProperty> uirevision(params int[] values) => Interop.mkScatterpolarAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterpolarProperty> uirevision(float val) => Interop.mkScatterpolarAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterpolarProperty> uirevision(params float[] values) => Interop.mkScatterpolarAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterpolarProperty> uirevision(string val) => Interop.mkScatterpolarAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterpolarProperty> uirevision(params string[] values) => Interop.mkScatterpolarAttr("uirevision", values);
        /// Determines the drawing mode for this scatter trace. If the provided `mode` includes *text* then the `text` elements appear at the coordinates. Otherwise, the `text` elements appear on hover. If there are less than 20 points and the trace is not stacked then the default is *lines+markers*. Otherwise, *lines*.
        public static Box<IScatterpolarProperty> mode(params Box<IScatterpolarProperty>[] properties) => Interop.mkScatterpolarAttr("mode", Bindings.joinEnumProperties(properties));
        /// Sets the radial coordinates
        public static Box<IScatterpolarProperty> r(bool val) => Interop.mkScatterpolarAttr("r", new[]{val});
        /// Sets the radial coordinates
        public static Box<IScatterpolarProperty> r(IEnumerable<bool> values) => Interop.mkScatterpolarAttr("r", values.ToArray());
        /// Sets the radial coordinates
        public static Box<IScatterpolarProperty> r(System.DateTime val) => Interop.mkScatterpolarAttr("r", new[]{val});
        /// Sets the radial coordinates
        public static Box<IScatterpolarProperty> r(IEnumerable<System.DateTime> values) => Interop.mkScatterpolarAttr("r", values.ToArray());
        /// Sets the radial coordinates
        public static Box<IScatterpolarProperty> r(float val) => Interop.mkScatterpolarAttr("r", new[]{val});
        /// Sets the radial coordinates
        public static Box<IScatterpolarProperty> r(IEnumerable<float> values) => Interop.mkScatterpolarAttr("r", values.ToArray());
        /// Sets the radial coordinates
        public static Box<IScatterpolarProperty> r(int val) => Interop.mkScatterpolarAttr("r", new[]{val});
        /// Sets the radial coordinates
        public static Box<IScatterpolarProperty> r(IEnumerable<int> values) => Interop.mkScatterpolarAttr("r", values.ToArray());
        /// Sets the radial coordinates
        public static Box<IScatterpolarProperty> r(string val) => Interop.mkScatterpolarAttr("r", new[]{val});
        /// Sets the radial coordinates
        public static Box<IScatterpolarProperty> r(IEnumerable<string> values) => Interop.mkScatterpolarAttr("r", values.ToArray());
        /// Sets the radial coordinates
        public static Box<IScatterpolarProperty> r(IEnumerable<bool[]> values) => Interop.mkScatterpolarAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IScatterpolarProperty> r(List<bool[]> values) => Interop.mkScatterpolarAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IScatterpolarProperty> r(params bool[][] values) => Interop.mkScatterpolarAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IScatterpolarProperty> r(IEnumerable<IEnumerable<string>> values) => Interop.mkScatterpolarAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IScatterpolarProperty> r(List<string[]> values) => Interop.mkScatterpolarAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IScatterpolarProperty> r(params string[][] values) => Interop.mkScatterpolarAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IScatterpolarProperty> r(IEnumerable<IEnumerable<int>> values) => Interop.mkScatterpolarAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IScatterpolarProperty> r(List<int[]> values) => Interop.mkScatterpolarAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IScatterpolarProperty> r(params int[][] values) => Interop.mkScatterpolarAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IScatterpolarProperty> r(IEnumerable<IEnumerable<float>> values) => Interop.mkScatterpolarAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IScatterpolarProperty> r(List<float[]> values) => Interop.mkScatterpolarAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IScatterpolarProperty> r(params float[][] values) => Interop.mkScatterpolarAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IScatterpolarProperty> r(Literals.PlotData[] values) => Interop.mkScatterpolarAttr("r", values);
        /// Sets the radial coordinates
        public static Box<IScatterpolarProperty> r(IEnumerable<bool?> values) => Interop.mkScatterpolarAttr("r", values.ToArray());
        /// Sets the radial coordinates
        public static Box<IScatterpolarProperty> r(IEnumerable<System.DateTime?> values) => Interop.mkScatterpolarAttr("r", values.ToArray());
        /// Sets the radial coordinates
        public static Box<IScatterpolarProperty> r(IEnumerable<int?> values) => Interop.mkScatterpolarAttr("r", values.ToArray());
        /// Sets the radial coordinates
        public static Box<IScatterpolarProperty> r(IEnumerable<float?> values) => Interop.mkScatterpolarAttr("r", values.ToArray());
        /// Sets the angular coordinates
        public static Box<IScatterpolarProperty> theta(bool val) => Interop.mkScatterpolarAttr("theta", new[]{val});
        /// Sets the angular coordinates
        public static Box<IScatterpolarProperty> theta(IEnumerable<bool> values) => Interop.mkScatterpolarAttr("theta", values.ToArray());
        /// Sets the angular coordinates
        public static Box<IScatterpolarProperty> theta(System.DateTime val) => Interop.mkScatterpolarAttr("theta", new[]{val});
        /// Sets the angular coordinates
        public static Box<IScatterpolarProperty> theta(IEnumerable<System.DateTime> values) => Interop.mkScatterpolarAttr("theta", values.ToArray());
        /// Sets the angular coordinates
        public static Box<IScatterpolarProperty> theta(float val) => Interop.mkScatterpolarAttr("theta", new[]{val});
        /// Sets the angular coordinates
        public static Box<IScatterpolarProperty> theta(IEnumerable<float> values) => Interop.mkScatterpolarAttr("theta", values.ToArray());
        /// Sets the angular coordinates
        public static Box<IScatterpolarProperty> theta(int val) => Interop.mkScatterpolarAttr("theta", new[]{val});
        /// Sets the angular coordinates
        public static Box<IScatterpolarProperty> theta(IEnumerable<int> values) => Interop.mkScatterpolarAttr("theta", values.ToArray());
        /// Sets the angular coordinates
        public static Box<IScatterpolarProperty> theta(string val) => Interop.mkScatterpolarAttr("theta", new[]{val});
        /// Sets the angular coordinates
        public static Box<IScatterpolarProperty> theta(IEnumerable<string> values) => Interop.mkScatterpolarAttr("theta", values.ToArray());
        /// Sets the angular coordinates
        public static Box<IScatterpolarProperty> theta(IEnumerable<bool[]> values) => Interop.mkScatterpolarAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IScatterpolarProperty> theta(List<bool[]> values) => Interop.mkScatterpolarAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IScatterpolarProperty> theta(params bool[][] values) => Interop.mkScatterpolarAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IScatterpolarProperty> theta(IEnumerable<IEnumerable<string>> values) => Interop.mkScatterpolarAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IScatterpolarProperty> theta(List<string[]> values) => Interop.mkScatterpolarAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IScatterpolarProperty> theta(params string[][] values) => Interop.mkScatterpolarAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IScatterpolarProperty> theta(IEnumerable<IEnumerable<int>> values) => Interop.mkScatterpolarAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IScatterpolarProperty> theta(List<int[]> values) => Interop.mkScatterpolarAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IScatterpolarProperty> theta(params int[][] values) => Interop.mkScatterpolarAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IScatterpolarProperty> theta(IEnumerable<IEnumerable<float>> values) => Interop.mkScatterpolarAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IScatterpolarProperty> theta(List<float[]> values) => Interop.mkScatterpolarAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IScatterpolarProperty> theta(params float[][] values) => Interop.mkScatterpolarAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IScatterpolarProperty> theta(Literals.PlotData[] values) => Interop.mkScatterpolarAttr("theta", values);
        /// Sets the angular coordinates
        public static Box<IScatterpolarProperty> theta(IEnumerable<bool?> values) => Interop.mkScatterpolarAttr("theta", values.ToArray());
        /// Sets the angular coordinates
        public static Box<IScatterpolarProperty> theta(IEnumerable<System.DateTime?> values) => Interop.mkScatterpolarAttr("theta", values.ToArray());
        /// Sets the angular coordinates
        public static Box<IScatterpolarProperty> theta(IEnumerable<int?> values) => Interop.mkScatterpolarAttr("theta", values.ToArray());
        /// Sets the angular coordinates
        public static Box<IScatterpolarProperty> theta(IEnumerable<float?> values) => Interop.mkScatterpolarAttr("theta", values.ToArray());
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IScatterpolarProperty> r0(bool val) => Interop.mkScatterpolarAttr("r0", val);
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IScatterpolarProperty> r0(params bool[] values) => Interop.mkScatterpolarAttr("r0", values);
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IScatterpolarProperty> r0(System.DateTime val) => Interop.mkScatterpolarAttr("r0", val);
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IScatterpolarProperty> r0(params System.DateTime[] values) => Interop.mkScatterpolarAttr("r0", values);
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IScatterpolarProperty> r0(int val) => Interop.mkScatterpolarAttr("r0", val);
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IScatterpolarProperty> r0(params int[] values) => Interop.mkScatterpolarAttr("r0", values);
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IScatterpolarProperty> r0(float val) => Interop.mkScatterpolarAttr("r0", val);
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IScatterpolarProperty> r0(params float[] values) => Interop.mkScatterpolarAttr("r0", values);
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IScatterpolarProperty> r0(string val) => Interop.mkScatterpolarAttr("r0", val);
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IScatterpolarProperty> r0(params string[] values) => Interop.mkScatterpolarAttr("r0", values);
        /// Sets the r coordinate step.
        public static Box<IScatterpolarProperty> dr(int val) => Interop.mkScatterpolarAttr("dr", val);
        /// Sets the r coordinate step.
        public static Box<IScatterpolarProperty> dr(float val) => Interop.mkScatterpolarAttr("dr", val);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IScatterpolarProperty> theta0(bool val) => Interop.mkScatterpolarAttr("theta0", val);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IScatterpolarProperty> theta0(params bool[] values) => Interop.mkScatterpolarAttr("theta0", values);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IScatterpolarProperty> theta0(System.DateTime val) => Interop.mkScatterpolarAttr("theta0", val);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IScatterpolarProperty> theta0(params System.DateTime[] values) => Interop.mkScatterpolarAttr("theta0", values);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IScatterpolarProperty> theta0(int val) => Interop.mkScatterpolarAttr("theta0", val);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IScatterpolarProperty> theta0(params int[] values) => Interop.mkScatterpolarAttr("theta0", values);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IScatterpolarProperty> theta0(float val) => Interop.mkScatterpolarAttr("theta0", val);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IScatterpolarProperty> theta0(params float[] values) => Interop.mkScatterpolarAttr("theta0", values);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IScatterpolarProperty> theta0(string val) => Interop.mkScatterpolarAttr("theta0", val);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IScatterpolarProperty> theta0(params string[] values) => Interop.mkScatterpolarAttr("theta0", values);
        /// Sets the theta coordinate step. By default, the `dtheta` step equals the subplot's period divided by the length of the `r` coordinates.
        public static Box<IScatterpolarProperty> dtheta(int val) => Interop.mkScatterpolarAttr("dtheta", val);
        /// Sets the theta coordinate step. By default, the `dtheta` step equals the subplot's period divided by the length of the `r` coordinates.
        public static Box<IScatterpolarProperty> dtheta(float val) => Interop.mkScatterpolarAttr("dtheta", val);
        /// Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IScatterpolarProperty> text(string val) => Interop.mkScatterpolarAttr("text", val);
        /// Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IScatterpolarProperty> text(IEnumerable<string> values) => Interop.mkScatterpolarAttr("text", values.ToArray());
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `r`, `theta` and `text`.
        public static Box<IScatterpolarProperty> texttemplate(string val) => Interop.mkScatterpolarAttr("texttemplate", val);
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `r`, `theta` and `text`.
        public static Box<IScatterpolarProperty> texttemplate(IEnumerable<string> values) => Interop.mkScatterpolarAttr("texttemplate", values.ToArray());
        /// Sets hover text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IScatterpolarProperty> hovertext(string val) => Interop.mkScatterpolarAttr("hovertext", val);
        /// Sets hover text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IScatterpolarProperty> hovertext(IEnumerable<string> values) => Interop.mkScatterpolarAttr("hovertext", values.ToArray());
        public static Box<IScatterpolarProperty> line(params Box<ILineProperty>[] properties) => Interop.mkScatterpolarAttr("line", Bindings.flattenProperties(properties));
        /// Determines whether or not gaps (i.e. {nan} or missing values) in the provided data arrays are connected.
        public static Box<IScatterpolarProperty> connectgaps(bool val) => Interop.mkScatterpolarAttr("connectgaps", val);
        public static Box<IScatterpolarProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkScatterpolarAttr("marker", Bindings.flattenProperties(properties));
        /// Determines whether or not markers and text nodes are clipped about the subplot axes. To show markers and text nodes above axis lines and tick labels, make sure to set `xaxis.layer` and `yaxis.layer` to *below traces*.
        public static Box<IScatterpolarProperty> cliponaxis(bool val) => Interop.mkScatterpolarAttr("cliponaxis", val);
        /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
        public static Box<IScatterpolarProperty> textposition(IEnumerable<Box<IScatterpolarProperty>> properties) => Interop.mkScatterpolarAttr("textposition", Bindings.flattenProperties(properties));
        /// Sets the text font.
        public static Box<IScatterpolarProperty> textfont(params Box<ITextfontProperty>[] properties) => Interop.mkScatterpolarAttr("textfont", Bindings.flattenProperties(properties));
        /// Sets the fill color. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
        public static Box<IScatterpolarProperty> fillcolor(string val) => Interop.mkScatterpolarAttr("fillcolor", val);
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IScatterpolarProperty> hoverinfo(params Box<IScatterpolarProperty>[] properties) => Interop.mkScatterpolarAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        /// Do the hover effects highlight individual points (markers or line points) or do they highlight filled regions? If the fill is *toself* or *tonext* and there are no markers or text, then the default is *fills*, otherwise it is *points*.
        public static Box<IScatterpolarProperty> hoveron(params Box<IScatterpolarProperty>[] properties) => Interop.mkScatterpolarAttr("hoveron", Bindings.joinEnumProperties(properties));
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IScatterpolarProperty> hovertemplate(string val) => Interop.mkScatterpolarAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IScatterpolarProperty> hovertemplate(IEnumerable<string> values) => Interop.mkScatterpolarAttr("hovertemplate", values.ToArray());
        public static Box<IScatterpolarProperty> selected(params Box<ISelectedProperty>[] properties) => Interop.mkScatterpolarAttr("selected", Bindings.flattenProperties(properties));
        public static Box<IScatterpolarProperty> unselected(params Box<IUnselectedProperty>[] properties) => Interop.mkScatterpolarAttr("unselected", Bindings.flattenProperties(properties));
        /// Sets a reference between this trace's data coordinates and a polar subplot. If *polar* (the default value), the data refer to `layout.polar`. If *polar2*, the data refer to `layout.polar2`, and so on.
        public static Box<IScatterpolarProperty> subplot(int anchorId) => Interop.mkScatterpolarAttr("subplot", anchorId > 1 ? $"polar{anchorId}" : "");
        /// Sets a reference between this trace's data coordinates and a polar subplot. If *polar* (the default value), the data refer to `layout.polar`. If *polar2*, the data refer to `layout.polar2`, and so on.
        public static Box<IScatterpolarProperty> subplot(string val) => Interop.mkScatterpolarAttr("subplot", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IScatterpolarProperty> idssrc(string val) => Interop.mkScatterpolarAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IScatterpolarProperty> customdatasrc(string val) => Interop.mkScatterpolarAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IScatterpolarProperty> metasrc(string val) => Interop.mkScatterpolarAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  r .
        public static Box<IScatterpolarProperty> rsrc(string val) => Interop.mkScatterpolarAttr("rsrc", val);
        /// Sets the source reference on plot.ly for  theta .
        public static Box<IScatterpolarProperty> thetasrc(string val) => Interop.mkScatterpolarAttr("thetasrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IScatterpolarProperty> textsrc(string val) => Interop.mkScatterpolarAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  texttemplate .
        public static Box<IScatterpolarProperty> texttemplatesrc(string val) => Interop.mkScatterpolarAttr("texttemplatesrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IScatterpolarProperty> hovertextsrc(string val) => Interop.mkScatterpolarAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  textposition .
        public static Box<IScatterpolarProperty> textpositionsrc(string val) => Interop.mkScatterpolarAttr("textpositionsrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IScatterpolarProperty> hoverinfosrc(string val) => Interop.mkScatterpolarAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IScatterpolarProperty> hovertemplatesrc(string val) => Interop.mkScatterpolarAttr("hovertemplatesrc", val);
    }

    public static partial class Scatterpolar
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IScatterpolarProperty> legendonly() => Interop.mkScatterpolarAttr("visible", "legendonly");
            public static Box<IScatterpolarProperty> _false() => Interop.mkScatterpolarAttr("visible", false);
            public static Box<IScatterpolarProperty> _true() => Interop.mkScatterpolarAttr("visible", true);
        }

        /// Determines the drawing mode for this scatter trace. If the provided `mode` includes *text* then the `text` elements appear at the coordinates. Otherwise, the `text` elements appear on hover. If there are less than 20 points and the trace is not stacked then the default is *lines+markers*. Otherwise, *lines*.
        public static partial class Mode
        {
            public static Box<IScatterpolarProperty> none() => Interop.mkScatterpolarAttr("mode", "none");
            public static Box<IScatterpolarProperty> lines() => Interop.mkScatterpolarAttr("mode", "lines");
            public static Box<IScatterpolarProperty> markers() => Interop.mkScatterpolarAttr("mode", "markers");
            public static Box<IScatterpolarProperty> text() => Interop.mkScatterpolarAttr("mode", "text");
        }

        /// Sets the unit of input *theta* values. Has an effect only when on *linear* angular axes.
        public static partial class Thetaunit
        {
            public static Box<IScatterpolarProperty> degrees() => Interop.mkScatterpolarAttr("thetaunit", "degrees");
            public static Box<IScatterpolarProperty> gradians() => Interop.mkScatterpolarAttr("thetaunit", "gradians");
            public static Box<IScatterpolarProperty> radians() => Interop.mkScatterpolarAttr("thetaunit", "radians");
        }

        /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
        public static partial class Textposition
        {
            public static Box<IScatterpolarProperty> bottomCenter() => Interop.mkScatterpolarAttr("textposition", "bottom center");
            public static Box<IScatterpolarProperty> bottomLeft() => Interop.mkScatterpolarAttr("textposition", "bottom left");
            public static Box<IScatterpolarProperty> bottomRight() => Interop.mkScatterpolarAttr("textposition", "bottom right");
            public static Box<IScatterpolarProperty> middleCenter() => Interop.mkScatterpolarAttr("textposition", "middle center");
            public static Box<IScatterpolarProperty> middleLeft() => Interop.mkScatterpolarAttr("textposition", "middle left");
            public static Box<IScatterpolarProperty> middleRight() => Interop.mkScatterpolarAttr("textposition", "middle right");
            public static Box<IScatterpolarProperty> topCenter() => Interop.mkScatterpolarAttr("textposition", "top center");
            public static Box<IScatterpolarProperty> topLeft() => Interop.mkScatterpolarAttr("textposition", "top left");
            public static Box<IScatterpolarProperty> topRight() => Interop.mkScatterpolarAttr("textposition", "top right");
        }

        /// Sets the area to fill with a solid color. Use with `fillcolor` if not *none*. scatterpolar has a subset of the options available to scatter. *toself* connects the endpoints of the trace (or each segment of the trace if it has gaps) into a closed shape. *tonext* fills the space between two traces if one completely encloses the other (eg consecutive contour lines), and behaves like *toself* if there is no trace before it. *tonext* should not be used if one trace does not enclose the other.
        public static partial class Fill
        {
            public static Box<IScatterpolarProperty> none() => Interop.mkScatterpolarAttr("fill", "none");
            public static Box<IScatterpolarProperty> tonext() => Interop.mkScatterpolarAttr("fill", "tonext");
            public static Box<IScatterpolarProperty> toself() => Interop.mkScatterpolarAttr("fill", "toself");
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IScatterpolarProperty> all() => Interop.mkScatterpolarAttr("hoverinfo", "all");
            public static Box<IScatterpolarProperty> none() => Interop.mkScatterpolarAttr("hoverinfo", "none");
            public static Box<IScatterpolarProperty> skip() => Interop.mkScatterpolarAttr("hoverinfo", "skip");
            public static Box<IScatterpolarProperty> name() => Interop.mkScatterpolarAttr("hoverinfo", "name");
            public static Box<IScatterpolarProperty> r() => Interop.mkScatterpolarAttr("hoverinfo", "r");
            public static Box<IScatterpolarProperty> text() => Interop.mkScatterpolarAttr("hoverinfo", "text");
            public static Box<IScatterpolarProperty> theta() => Interop.mkScatterpolarAttr("hoverinfo", "theta");
        }

        /// Do the hover effects highlight individual points (markers or line points) or do they highlight filled regions? If the fill is *toself* or *tonext* and there are no markers or text, then the default is *fills*, otherwise it is *points*.
        public static partial class Hoveron
        {
            public static Box<IScatterpolarProperty> fills() => Interop.mkScatterpolarAttr("hoveron", "fills");
            public static Box<IScatterpolarProperty> points() => Interop.mkScatterpolarAttr("hoveron", "points");
        }
    }
}