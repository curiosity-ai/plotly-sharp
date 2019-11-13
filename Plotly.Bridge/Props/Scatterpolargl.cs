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

    public static partial class Scatterpolargl
    {
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IScatterpolarglProperty> showlegend(bool val) => Interop.mkScatterpolarglAttr("showlegend", val);
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IScatterpolarglProperty> legendgroup(string val) => Interop.mkScatterpolarglAttr("legendgroup", val);
        /// Sets the opacity of the trace.
        public static Box<IScatterpolarglProperty> opacity(int val) => Interop.mkScatterpolarglAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<IScatterpolarglProperty> opacity(float val) => Interop.mkScatterpolarglAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IScatterpolarglProperty> name(string val) => Interop.mkScatterpolarglAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IScatterpolarglProperty> uid(string val) => Interop.mkScatterpolarglAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarglProperty> ids(bool val) => Interop.mkScatterpolarglAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarglProperty> ids(params bool[] values) => Interop.mkScatterpolarglAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarglProperty> ids(System.DateTime val) => Interop.mkScatterpolarglAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarglProperty> ids(params System.DateTime[] values) => Interop.mkScatterpolarglAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarglProperty> ids(float val) => Interop.mkScatterpolarglAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarglProperty> ids(params float[] values) => Interop.mkScatterpolarglAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarglProperty> ids(int val) => Interop.mkScatterpolarglAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarglProperty> ids(params int[] values) => Interop.mkScatterpolarglAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarglProperty> ids(string val) => Interop.mkScatterpolarglAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarglProperty> ids(params string[] values) => Interop.mkScatterpolarglAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarglProperty> ids(IEnumerable<bool[]> values) => Interop.mkScatterpolarglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarglProperty> ids(List<bool[]> values) => Interop.mkScatterpolarglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarglProperty> ids(params bool[][] values) => Interop.mkScatterpolarglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarglProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkScatterpolarglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarglProperty> ids(List<string[]> values) => Interop.mkScatterpolarglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarglProperty> ids(params string[][] values) => Interop.mkScatterpolarglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarglProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkScatterpolarglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarglProperty> ids(List<int[]> values) => Interop.mkScatterpolarglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarglProperty> ids(params int[][] values) => Interop.mkScatterpolarglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarglProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkScatterpolarglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarglProperty> ids(List<float[]> values) => Interop.mkScatterpolarglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarglProperty> ids(params float[][] values) => Interop.mkScatterpolarglAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarglProperty> ids(Literals.PlotData[] values) => Interop.mkScatterpolarglAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarglProperty> ids(IEnumerable<bool?> values) => Interop.mkScatterpolarglAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarglProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkScatterpolarglAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarglProperty> ids(IEnumerable<int?> values) => Interop.mkScatterpolarglAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScatterpolarglProperty> ids(IEnumerable<float?> values) => Interop.mkScatterpolarglAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarglProperty> customdata(bool val) => Interop.mkScatterpolarglAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarglProperty> customdata(params bool[] values) => Interop.mkScatterpolarglAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarglProperty> customdata(System.DateTime val) => Interop.mkScatterpolarglAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarglProperty> customdata(params System.DateTime[] values) => Interop.mkScatterpolarglAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarglProperty> customdata(float val) => Interop.mkScatterpolarglAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarglProperty> customdata(params float[] values) => Interop.mkScatterpolarglAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarglProperty> customdata(int val) => Interop.mkScatterpolarglAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarglProperty> customdata(params int[] values) => Interop.mkScatterpolarglAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarglProperty> customdata(string val) => Interop.mkScatterpolarglAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarglProperty> customdata(params string[] values) => Interop.mkScatterpolarglAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarglProperty> customdata(IEnumerable<bool[]> values) => Interop.mkScatterpolarglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarglProperty> customdata(List<bool[]> values) => Interop.mkScatterpolarglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarglProperty> customdata(params bool[][] values) => Interop.mkScatterpolarglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarglProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkScatterpolarglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarglProperty> customdata(List<string[]> values) => Interop.mkScatterpolarglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarglProperty> customdata(params string[][] values) => Interop.mkScatterpolarglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarglProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkScatterpolarglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarglProperty> customdata(List<int[]> values) => Interop.mkScatterpolarglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarglProperty> customdata(params int[][] values) => Interop.mkScatterpolarglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarglProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkScatterpolarglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarglProperty> customdata(List<float[]> values) => Interop.mkScatterpolarglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarglProperty> customdata(params float[][] values) => Interop.mkScatterpolarglAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarglProperty> customdata(Literals.PlotData[] values) => Interop.mkScatterpolarglAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarglProperty> customdata(IEnumerable<bool?> values) => Interop.mkScatterpolarglAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarglProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkScatterpolarglAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarglProperty> customdata(IEnumerable<int?> values) => Interop.mkScatterpolarglAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScatterpolarglProperty> customdata(IEnumerable<float?> values) => Interop.mkScatterpolarglAttr("customdata", values.ToArray());
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterpolarglProperty> selectedpoints(bool val) => Interop.mkScatterpolarglAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterpolarglProperty> selectedpoints(params bool[] values) => Interop.mkScatterpolarglAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterpolarglProperty> selectedpoints(System.DateTime val) => Interop.mkScatterpolarglAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterpolarglProperty> selectedpoints(params System.DateTime[] values) => Interop.mkScatterpolarglAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterpolarglProperty> selectedpoints(int val) => Interop.mkScatterpolarglAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterpolarglProperty> selectedpoints(params int[] values) => Interop.mkScatterpolarglAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterpolarglProperty> selectedpoints(float val) => Interop.mkScatterpolarglAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterpolarglProperty> selectedpoints(params float[] values) => Interop.mkScatterpolarglAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterpolarglProperty> selectedpoints(string val) => Interop.mkScatterpolarglAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScatterpolarglProperty> selectedpoints(params string[] values) => Interop.mkScatterpolarglAttr("selectedpoints", values);
        public static Box<IScatterpolarglProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkScatterpolarglAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IScatterpolarglProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkScatterpolarglAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IScatterpolarglProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkScatterpolarglAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterpolarglProperty> uirevision(bool val) => Interop.mkScatterpolarglAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterpolarglProperty> uirevision(params bool[] values) => Interop.mkScatterpolarglAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterpolarglProperty> uirevision(System.DateTime val) => Interop.mkScatterpolarglAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterpolarglProperty> uirevision(params System.DateTime[] values) => Interop.mkScatterpolarglAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterpolarglProperty> uirevision(int val) => Interop.mkScatterpolarglAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterpolarglProperty> uirevision(params int[] values) => Interop.mkScatterpolarglAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterpolarglProperty> uirevision(float val) => Interop.mkScatterpolarglAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterpolarglProperty> uirevision(params float[] values) => Interop.mkScatterpolarglAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterpolarglProperty> uirevision(string val) => Interop.mkScatterpolarglAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScatterpolarglProperty> uirevision(params string[] values) => Interop.mkScatterpolarglAttr("uirevision", values);
        /// Determines the drawing mode for this scatter trace. If the provided `mode` includes *text* then the `text` elements appear at the coordinates. Otherwise, the `text` elements appear on hover. If there are less than 20 points and the trace is not stacked then the default is *lines+markers*. Otherwise, *lines*.
        public static Box<IScatterpolarglProperty> mode(params Box<IScatterpolarglProperty>[] properties) => Interop.mkScatterpolarglAttr("mode", Script.Write<object>("{0}.join('+')", properties));
        /// Sets the radial coordinates
        public static Box<IScatterpolarglProperty> r(bool val) => Interop.mkScatterpolarglAttr("r", new[]{val});
        /// Sets the radial coordinates
        public static Box<IScatterpolarglProperty> r(IEnumerable<bool> values) => Interop.mkScatterpolarglAttr("r", values.ToArray());
        /// Sets the radial coordinates
        public static Box<IScatterpolarglProperty> r(System.DateTime val) => Interop.mkScatterpolarglAttr("r", new[]{val});
        /// Sets the radial coordinates
        public static Box<IScatterpolarglProperty> r(IEnumerable<System.DateTime> values) => Interop.mkScatterpolarglAttr("r", values.ToArray());
        /// Sets the radial coordinates
        public static Box<IScatterpolarglProperty> r(float val) => Interop.mkScatterpolarglAttr("r", new[]{val});
        /// Sets the radial coordinates
        public static Box<IScatterpolarglProperty> r(IEnumerable<float> values) => Interop.mkScatterpolarglAttr("r", values.ToArray());
        /// Sets the radial coordinates
        public static Box<IScatterpolarglProperty> r(int val) => Interop.mkScatterpolarglAttr("r", new[]{val});
        /// Sets the radial coordinates
        public static Box<IScatterpolarglProperty> r(IEnumerable<int> values) => Interop.mkScatterpolarglAttr("r", values.ToArray());
        /// Sets the radial coordinates
        public static Box<IScatterpolarglProperty> r(string val) => Interop.mkScatterpolarglAttr("r", new[]{val});
        /// Sets the radial coordinates
        public static Box<IScatterpolarglProperty> r(IEnumerable<string> values) => Interop.mkScatterpolarglAttr("r", values.ToArray());
        /// Sets the radial coordinates
        public static Box<IScatterpolarglProperty> r(IEnumerable<bool[]> values) => Interop.mkScatterpolarglAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IScatterpolarglProperty> r(List<bool[]> values) => Interop.mkScatterpolarglAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IScatterpolarglProperty> r(params bool[][] values) => Interop.mkScatterpolarglAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IScatterpolarglProperty> r(IEnumerable<IEnumerable<string>> values) => Interop.mkScatterpolarglAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IScatterpolarglProperty> r(List<string[]> values) => Interop.mkScatterpolarglAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IScatterpolarglProperty> r(params string[][] values) => Interop.mkScatterpolarglAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IScatterpolarglProperty> r(IEnumerable<IEnumerable<int>> values) => Interop.mkScatterpolarglAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IScatterpolarglProperty> r(List<int[]> values) => Interop.mkScatterpolarglAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IScatterpolarglProperty> r(params int[][] values) => Interop.mkScatterpolarglAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IScatterpolarglProperty> r(IEnumerable<IEnumerable<float>> values) => Interop.mkScatterpolarglAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IScatterpolarglProperty> r(List<float[]> values) => Interop.mkScatterpolarglAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IScatterpolarglProperty> r(params float[][] values) => Interop.mkScatterpolarglAttr("r", Bindings.flatten2DArrayIf1D(values));
        /// Sets the radial coordinates
        public static Box<IScatterpolarglProperty> r(Literals.PlotData[] values) => Interop.mkScatterpolarglAttr("r", values);
        /// Sets the radial coordinates
        public static Box<IScatterpolarglProperty> r(IEnumerable<bool?> values) => Interop.mkScatterpolarglAttr("r", values.ToArray());
        /// Sets the radial coordinates
        public static Box<IScatterpolarglProperty> r(IEnumerable<System.DateTime?> values) => Interop.mkScatterpolarglAttr("r", values.ToArray());
        /// Sets the radial coordinates
        public static Box<IScatterpolarglProperty> r(IEnumerable<int?> values) => Interop.mkScatterpolarglAttr("r", values.ToArray());
        /// Sets the radial coordinates
        public static Box<IScatterpolarglProperty> r(IEnumerable<float?> values) => Interop.mkScatterpolarglAttr("r", values.ToArray());
        /// Sets the angular coordinates
        public static Box<IScatterpolarglProperty> theta(bool val) => Interop.mkScatterpolarglAttr("theta", new[]{val});
        /// Sets the angular coordinates
        public static Box<IScatterpolarglProperty> theta(IEnumerable<bool> values) => Interop.mkScatterpolarglAttr("theta", values.ToArray());
        /// Sets the angular coordinates
        public static Box<IScatterpolarglProperty> theta(System.DateTime val) => Interop.mkScatterpolarglAttr("theta", new[]{val});
        /// Sets the angular coordinates
        public static Box<IScatterpolarglProperty> theta(IEnumerable<System.DateTime> values) => Interop.mkScatterpolarglAttr("theta", values.ToArray());
        /// Sets the angular coordinates
        public static Box<IScatterpolarglProperty> theta(float val) => Interop.mkScatterpolarglAttr("theta", new[]{val});
        /// Sets the angular coordinates
        public static Box<IScatterpolarglProperty> theta(IEnumerable<float> values) => Interop.mkScatterpolarglAttr("theta", values.ToArray());
        /// Sets the angular coordinates
        public static Box<IScatterpolarglProperty> theta(int val) => Interop.mkScatterpolarglAttr("theta", new[]{val});
        /// Sets the angular coordinates
        public static Box<IScatterpolarglProperty> theta(IEnumerable<int> values) => Interop.mkScatterpolarglAttr("theta", values.ToArray());
        /// Sets the angular coordinates
        public static Box<IScatterpolarglProperty> theta(string val) => Interop.mkScatterpolarglAttr("theta", new[]{val});
        /// Sets the angular coordinates
        public static Box<IScatterpolarglProperty> theta(IEnumerable<string> values) => Interop.mkScatterpolarglAttr("theta", values.ToArray());
        /// Sets the angular coordinates
        public static Box<IScatterpolarglProperty> theta(IEnumerable<bool[]> values) => Interop.mkScatterpolarglAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IScatterpolarglProperty> theta(List<bool[]> values) => Interop.mkScatterpolarglAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IScatterpolarglProperty> theta(params bool[][] values) => Interop.mkScatterpolarglAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IScatterpolarglProperty> theta(IEnumerable<IEnumerable<string>> values) => Interop.mkScatterpolarglAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IScatterpolarglProperty> theta(List<string[]> values) => Interop.mkScatterpolarglAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IScatterpolarglProperty> theta(params string[][] values) => Interop.mkScatterpolarglAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IScatterpolarglProperty> theta(IEnumerable<IEnumerable<int>> values) => Interop.mkScatterpolarglAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IScatterpolarglProperty> theta(List<int[]> values) => Interop.mkScatterpolarglAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IScatterpolarglProperty> theta(params int[][] values) => Interop.mkScatterpolarglAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IScatterpolarglProperty> theta(IEnumerable<IEnumerable<float>> values) => Interop.mkScatterpolarglAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IScatterpolarglProperty> theta(List<float[]> values) => Interop.mkScatterpolarglAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IScatterpolarglProperty> theta(params float[][] values) => Interop.mkScatterpolarglAttr("theta", Bindings.flatten2DArrayIf1D(values));
        /// Sets the angular coordinates
        public static Box<IScatterpolarglProperty> theta(Literals.PlotData[] values) => Interop.mkScatterpolarglAttr("theta", values);
        /// Sets the angular coordinates
        public static Box<IScatterpolarglProperty> theta(IEnumerable<bool?> values) => Interop.mkScatterpolarglAttr("theta", values.ToArray());
        /// Sets the angular coordinates
        public static Box<IScatterpolarglProperty> theta(IEnumerable<System.DateTime?> values) => Interop.mkScatterpolarglAttr("theta", values.ToArray());
        /// Sets the angular coordinates
        public static Box<IScatterpolarglProperty> theta(IEnumerable<int?> values) => Interop.mkScatterpolarglAttr("theta", values.ToArray());
        /// Sets the angular coordinates
        public static Box<IScatterpolarglProperty> theta(IEnumerable<float?> values) => Interop.mkScatterpolarglAttr("theta", values.ToArray());
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IScatterpolarglProperty> r0(bool val) => Interop.mkScatterpolarglAttr("r0", val);
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IScatterpolarglProperty> r0(params bool[] values) => Interop.mkScatterpolarglAttr("r0", values);
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IScatterpolarglProperty> r0(System.DateTime val) => Interop.mkScatterpolarglAttr("r0", val);
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IScatterpolarglProperty> r0(params System.DateTime[] values) => Interop.mkScatterpolarglAttr("r0", values);
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IScatterpolarglProperty> r0(int val) => Interop.mkScatterpolarglAttr("r0", val);
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IScatterpolarglProperty> r0(params int[] values) => Interop.mkScatterpolarglAttr("r0", values);
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IScatterpolarglProperty> r0(float val) => Interop.mkScatterpolarglAttr("r0", val);
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IScatterpolarglProperty> r0(params float[] values) => Interop.mkScatterpolarglAttr("r0", values);
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IScatterpolarglProperty> r0(string val) => Interop.mkScatterpolarglAttr("r0", val);
        /// Alternate to `r`. Builds a linear space of r coordinates. Use with `dr` where `r0` is the starting coordinate and `dr` the step.
        public static Box<IScatterpolarglProperty> r0(params string[] values) => Interop.mkScatterpolarglAttr("r0", values);
        /// Sets the r coordinate step.
        public static Box<IScatterpolarglProperty> dr(int val) => Interop.mkScatterpolarglAttr("dr", val);
        /// Sets the r coordinate step.
        public static Box<IScatterpolarglProperty> dr(float val) => Interop.mkScatterpolarglAttr("dr", val);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IScatterpolarglProperty> theta0(bool val) => Interop.mkScatterpolarglAttr("theta0", val);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IScatterpolarglProperty> theta0(params bool[] values) => Interop.mkScatterpolarglAttr("theta0", values);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IScatterpolarglProperty> theta0(System.DateTime val) => Interop.mkScatterpolarglAttr("theta0", val);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IScatterpolarglProperty> theta0(params System.DateTime[] values) => Interop.mkScatterpolarglAttr("theta0", values);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IScatterpolarglProperty> theta0(int val) => Interop.mkScatterpolarglAttr("theta0", val);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IScatterpolarglProperty> theta0(params int[] values) => Interop.mkScatterpolarglAttr("theta0", values);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IScatterpolarglProperty> theta0(float val) => Interop.mkScatterpolarglAttr("theta0", val);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IScatterpolarglProperty> theta0(params float[] values) => Interop.mkScatterpolarglAttr("theta0", values);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IScatterpolarglProperty> theta0(string val) => Interop.mkScatterpolarglAttr("theta0", val);
        /// Alternate to `theta`. Builds a linear space of theta coordinates. Use with `dtheta` where `theta0` is the starting coordinate and `dtheta` the step.
        public static Box<IScatterpolarglProperty> theta0(params string[] values) => Interop.mkScatterpolarglAttr("theta0", values);
        /// Sets the theta coordinate step. By default, the `dtheta` step equals the subplot's period divided by the length of the `r` coordinates.
        public static Box<IScatterpolarglProperty> dtheta(int val) => Interop.mkScatterpolarglAttr("dtheta", val);
        /// Sets the theta coordinate step. By default, the `dtheta` step equals the subplot's period divided by the length of the `r` coordinates.
        public static Box<IScatterpolarglProperty> dtheta(float val) => Interop.mkScatterpolarglAttr("dtheta", val);
        /// Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IScatterpolarglProperty> text(string val) => Interop.mkScatterpolarglAttr("text", val);
        /// Sets text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IScatterpolarglProperty> text(IEnumerable<string> values) => Interop.mkScatterpolarglAttr("text", values.ToArray());
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `r`, `theta` and `text`.
        public static Box<IScatterpolarglProperty> texttemplate(string val) => Interop.mkScatterpolarglAttr("texttemplate", val);
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `r`, `theta` and `text`.
        public static Box<IScatterpolarglProperty> texttemplate(IEnumerable<string> values) => Interop.mkScatterpolarglAttr("texttemplate", values.ToArray());
        /// Sets hover text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IScatterpolarglProperty> hovertext(string val) => Interop.mkScatterpolarglAttr("hovertext", val);
        /// Sets hover text elements associated with each (x,y) pair. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (x,y) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IScatterpolarglProperty> hovertext(IEnumerable<string> values) => Interop.mkScatterpolarglAttr("hovertext", values.ToArray());
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IScatterpolarglProperty> hovertemplate(string val) => Interop.mkScatterpolarglAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IScatterpolarglProperty> hovertemplate(IEnumerable<string> values) => Interop.mkScatterpolarglAttr("hovertemplate", values.ToArray());
        public static Box<IScatterpolarglProperty> line(params Box<ILineProperty>[] properties) => Interop.mkScatterpolarglAttr("line", Bindings.flattenProperties(properties));
        /// Determines whether or not gaps (i.e. {nan} or missing values) in the provided data arrays are connected.
        public static Box<IScatterpolarglProperty> connectgaps(bool val) => Interop.mkScatterpolarglAttr("connectgaps", val);
        public static Box<IScatterpolarglProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkScatterpolarglAttr("marker", Bindings.flattenProperties(properties));
        /// Sets the fill color. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
        public static Box<IScatterpolarglProperty> fillcolor(string val) => Interop.mkScatterpolarglAttr("fillcolor", val);
        /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
        public static Box<IScatterpolarglProperty> textposition(IEnumerable<Box<IScatterpolarglProperty>> properties) => Interop.mkScatterpolarglAttr("textposition", Bindings.flattenProperties(properties));
        /// Sets the text font.
        public static Box<IScatterpolarglProperty> textfont(params Box<ITextfontProperty>[] properties) => Interop.mkScatterpolarglAttr("textfont", Bindings.flattenProperties(properties));
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IScatterpolarglProperty> hoverinfo(params Box<IScatterpolarglProperty>[] properties) => Interop.mkScatterpolarglAttr("hoverinfo", Script.Write<object>("{0}.join('+')", properties));
        public static Box<IScatterpolarglProperty> selected(params Box<ISelectedProperty>[] properties) => Interop.mkScatterpolarglAttr("selected", Bindings.flattenProperties(properties));
        public static Box<IScatterpolarglProperty> unselected(params Box<IUnselectedProperty>[] properties) => Interop.mkScatterpolarglAttr("unselected", Bindings.flattenProperties(properties));
        /// Sets a reference between this trace's data coordinates and a polar subplot. If *polar* (the default value), the data refer to `layout.polar`. If *polar2*, the data refer to `layout.polar2`, and so on.
        public static Box<IScatterpolarglProperty> subplot(int anchorId) => Interop.mkScatterpolarglAttr("subplot", anchorId > 1 ? $"polar{anchorId}" : "");
        /// Sets a reference between this trace's data coordinates and a polar subplot. If *polar* (the default value), the data refer to `layout.polar`. If *polar2*, the data refer to `layout.polar2`, and so on.
        public static Box<IScatterpolarglProperty> subplot(string val) => Interop.mkScatterpolarglAttr("subplot", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IScatterpolarglProperty> idssrc(string val) => Interop.mkScatterpolarglAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IScatterpolarglProperty> customdatasrc(string val) => Interop.mkScatterpolarglAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IScatterpolarglProperty> metasrc(string val) => Interop.mkScatterpolarglAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  r .
        public static Box<IScatterpolarglProperty> rsrc(string val) => Interop.mkScatterpolarglAttr("rsrc", val);
        /// Sets the source reference on plot.ly for  theta .
        public static Box<IScatterpolarglProperty> thetasrc(string val) => Interop.mkScatterpolarglAttr("thetasrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IScatterpolarglProperty> textsrc(string val) => Interop.mkScatterpolarglAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  texttemplate .
        public static Box<IScatterpolarglProperty> texttemplatesrc(string val) => Interop.mkScatterpolarglAttr("texttemplatesrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IScatterpolarglProperty> hovertextsrc(string val) => Interop.mkScatterpolarglAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IScatterpolarglProperty> hovertemplatesrc(string val) => Interop.mkScatterpolarglAttr("hovertemplatesrc", val);
        /// Sets the source reference on plot.ly for  textposition .
        public static Box<IScatterpolarglProperty> textpositionsrc(string val) => Interop.mkScatterpolarglAttr("textpositionsrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IScatterpolarglProperty> hoverinfosrc(string val) => Interop.mkScatterpolarglAttr("hoverinfosrc", val);
    }

    public static partial class Scatterpolargl
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IScatterpolarglProperty> legendonly() => Interop.mkScatterpolarglAttr("visible", "legendonly");
            public static Box<IScatterpolarglProperty> _false() => Interop.mkScatterpolarglAttr("visible", false);
            public static Box<IScatterpolarglProperty> _true() => Interop.mkScatterpolarglAttr("visible", true);
        }

        /// Determines the drawing mode for this scatter trace. If the provided `mode` includes *text* then the `text` elements appear at the coordinates. Otherwise, the `text` elements appear on hover. If there are less than 20 points and the trace is not stacked then the default is *lines+markers*. Otherwise, *lines*.
        public static partial class Mode
        {
            public static Box<IScatterpolarglProperty> none() => Interop.mkScatterpolarglAttr("mode", "none");
            public static Box<IScatterpolarglProperty> lines() => Interop.mkScatterpolarglAttr("mode", "lines");
            public static Box<IScatterpolarglProperty> markers() => Interop.mkScatterpolarglAttr("mode", "markers");
            public static Box<IScatterpolarglProperty> text() => Interop.mkScatterpolarglAttr("mode", "text");
        }

        /// Sets the unit of input *theta* values. Has an effect only when on *linear* angular axes.
        public static partial class Thetaunit
        {
            public static Box<IScatterpolarglProperty> degrees() => Interop.mkScatterpolarglAttr("thetaunit", "degrees");
            public static Box<IScatterpolarglProperty> gradians() => Interop.mkScatterpolarglAttr("thetaunit", "gradians");
            public static Box<IScatterpolarglProperty> radians() => Interop.mkScatterpolarglAttr("thetaunit", "radians");
        }

        /// Sets the area to fill with a solid color. Defaults to *none* unless this trace is stacked, then it gets *tonexty* (*tonextx*) if `orientation` is *v* (*h*) Use with `fillcolor` if not *none*. *tozerox* and *tozeroy* fill to x=0 and y=0 respectively. *tonextx* and *tonexty* fill between the endpoints of this trace and the endpoints of the trace before it, connecting those endpoints with straight lines (to make a stacked area graph); if there is no trace before it, they behave like *tozerox* and *tozeroy*. *toself* connects the endpoints of the trace (or each segment of the trace if it has gaps) into a closed shape. *tonext* fills the space between two traces if one completely encloses the other (eg consecutive contour lines), and behaves like *toself* if there is no trace before it. *tonext* should not be used if one trace does not enclose the other. Traces in a `stackgroup` will only fill to (or be filled to) other traces in the same group. With multiple `stackgroup`s or some traces stacked and some not, if fill-linked traces are not already consecutive, the later ones will be pushed down in the drawing order.
        public static partial class Fill
        {
            public static Box<IScatterpolarglProperty> none() => Interop.mkScatterpolarglAttr("fill", "none");
            public static Box<IScatterpolarglProperty> tonext() => Interop.mkScatterpolarglAttr("fill", "tonext");
            public static Box<IScatterpolarglProperty> tonextx() => Interop.mkScatterpolarglAttr("fill", "tonextx");
            public static Box<IScatterpolarglProperty> tonexty() => Interop.mkScatterpolarglAttr("fill", "tonexty");
            public static Box<IScatterpolarglProperty> toself() => Interop.mkScatterpolarglAttr("fill", "toself");
            public static Box<IScatterpolarglProperty> tozerox() => Interop.mkScatterpolarglAttr("fill", "tozerox");
            public static Box<IScatterpolarglProperty> tozeroy() => Interop.mkScatterpolarglAttr("fill", "tozeroy");
        }

        /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
        public static partial class Textposition
        {
            public static Box<IScatterpolarglProperty> bottomCenter() => Interop.mkScatterpolarglAttr("textposition", "bottom center");
            public static Box<IScatterpolarglProperty> bottomLeft() => Interop.mkScatterpolarglAttr("textposition", "bottom left");
            public static Box<IScatterpolarglProperty> bottomRight() => Interop.mkScatterpolarglAttr("textposition", "bottom right");
            public static Box<IScatterpolarglProperty> middleCenter() => Interop.mkScatterpolarglAttr("textposition", "middle center");
            public static Box<IScatterpolarglProperty> middleLeft() => Interop.mkScatterpolarglAttr("textposition", "middle left");
            public static Box<IScatterpolarglProperty> middleRight() => Interop.mkScatterpolarglAttr("textposition", "middle right");
            public static Box<IScatterpolarglProperty> topCenter() => Interop.mkScatterpolarglAttr("textposition", "top center");
            public static Box<IScatterpolarglProperty> topLeft() => Interop.mkScatterpolarglAttr("textposition", "top left");
            public static Box<IScatterpolarglProperty> topRight() => Interop.mkScatterpolarglAttr("textposition", "top right");
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IScatterpolarglProperty> all() => Interop.mkScatterpolarglAttr("hoverinfo", "all");
            public static Box<IScatterpolarglProperty> none() => Interop.mkScatterpolarglAttr("hoverinfo", "none");
            public static Box<IScatterpolarglProperty> skip() => Interop.mkScatterpolarglAttr("hoverinfo", "skip");
            public static Box<IScatterpolarglProperty> name() => Interop.mkScatterpolarglAttr("hoverinfo", "name");
            public static Box<IScatterpolarglProperty> r() => Interop.mkScatterpolarglAttr("hoverinfo", "r");
            public static Box<IScatterpolarglProperty> text() => Interop.mkScatterpolarglAttr("hoverinfo", "text");
            public static Box<IScatterpolarglProperty> theta() => Interop.mkScatterpolarglAttr("hoverinfo", "theta");
        }
    }
}