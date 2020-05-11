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

    public static partial class Choropleth
    {
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IChoroplethProperty> legendgroup(string val) => Interop.mkChoroplethAttr("legendgroup", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IChoroplethProperty> name(string val) => Interop.mkChoroplethAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IChoroplethProperty> uid(string val) => Interop.mkChoroplethAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethProperty> ids(bool val) => Interop.mkChoroplethAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethProperty> ids(params bool[] values) => Interop.mkChoroplethAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethProperty> ids(System.DateTime val) => Interop.mkChoroplethAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethProperty> ids(params System.DateTime[] values) => Interop.mkChoroplethAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethProperty> ids(float val) => Interop.mkChoroplethAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethProperty> ids(params float[] values) => Interop.mkChoroplethAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethProperty> ids(int val) => Interop.mkChoroplethAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethProperty> ids(params int[] values) => Interop.mkChoroplethAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethProperty> ids(string val) => Interop.mkChoroplethAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethProperty> ids(params string[] values) => Interop.mkChoroplethAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethProperty> ids(IEnumerable<bool[]> values) => Interop.mkChoroplethAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethProperty> ids(List<bool[]> values) => Interop.mkChoroplethAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethProperty> ids(params bool[][] values) => Interop.mkChoroplethAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkChoroplethAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethProperty> ids(List<string[]> values) => Interop.mkChoroplethAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethProperty> ids(params string[][] values) => Interop.mkChoroplethAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkChoroplethAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethProperty> ids(List<int[]> values) => Interop.mkChoroplethAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethProperty> ids(params int[][] values) => Interop.mkChoroplethAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkChoroplethAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethProperty> ids(List<float[]> values) => Interop.mkChoroplethAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethProperty> ids(params float[][] values) => Interop.mkChoroplethAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethProperty> ids(Literals.PlotData[] values) => Interop.mkChoroplethAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethProperty> ids(IEnumerable<bool?> values) => Interop.mkChoroplethAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkChoroplethAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethProperty> ids(IEnumerable<int?> values) => Interop.mkChoroplethAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethProperty> ids(IEnumerable<float?> values) => Interop.mkChoroplethAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethProperty> customdata(bool val) => Interop.mkChoroplethAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethProperty> customdata(params bool[] values) => Interop.mkChoroplethAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethProperty> customdata(System.DateTime val) => Interop.mkChoroplethAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethProperty> customdata(params System.DateTime[] values) => Interop.mkChoroplethAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethProperty> customdata(float val) => Interop.mkChoroplethAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethProperty> customdata(params float[] values) => Interop.mkChoroplethAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethProperty> customdata(int val) => Interop.mkChoroplethAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethProperty> customdata(params int[] values) => Interop.mkChoroplethAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethProperty> customdata(string val) => Interop.mkChoroplethAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethProperty> customdata(params string[] values) => Interop.mkChoroplethAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethProperty> customdata(IEnumerable<bool[]> values) => Interop.mkChoroplethAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethProperty> customdata(List<bool[]> values) => Interop.mkChoroplethAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethProperty> customdata(params bool[][] values) => Interop.mkChoroplethAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkChoroplethAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethProperty> customdata(List<string[]> values) => Interop.mkChoroplethAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethProperty> customdata(params string[][] values) => Interop.mkChoroplethAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkChoroplethAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethProperty> customdata(List<int[]> values) => Interop.mkChoroplethAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethProperty> customdata(params int[][] values) => Interop.mkChoroplethAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkChoroplethAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethProperty> customdata(List<float[]> values) => Interop.mkChoroplethAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethProperty> customdata(params float[][] values) => Interop.mkChoroplethAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethProperty> customdata(Literals.PlotData[] values) => Interop.mkChoroplethAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethProperty> customdata(IEnumerable<bool?> values) => Interop.mkChoroplethAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkChoroplethAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethProperty> customdata(IEnumerable<int?> values) => Interop.mkChoroplethAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethProperty> customdata(IEnumerable<float?> values) => Interop.mkChoroplethAttr("customdata", values.ToArray());
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IChoroplethProperty> selectedpoints(bool val) => Interop.mkChoroplethAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IChoroplethProperty> selectedpoints(params bool[] values) => Interop.mkChoroplethAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IChoroplethProperty> selectedpoints(System.DateTime val) => Interop.mkChoroplethAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IChoroplethProperty> selectedpoints(params System.DateTime[] values) => Interop.mkChoroplethAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IChoroplethProperty> selectedpoints(int val) => Interop.mkChoroplethAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IChoroplethProperty> selectedpoints(params int[] values) => Interop.mkChoroplethAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IChoroplethProperty> selectedpoints(float val) => Interop.mkChoroplethAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IChoroplethProperty> selectedpoints(params float[] values) => Interop.mkChoroplethAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IChoroplethProperty> selectedpoints(string val) => Interop.mkChoroplethAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IChoroplethProperty> selectedpoints(params string[] values) => Interop.mkChoroplethAttr("selectedpoints", values);
        public static Box<IChoroplethProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkChoroplethAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IChoroplethProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkChoroplethAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IChoroplethProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkChoroplethAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IChoroplethProperty> uirevision(bool val) => Interop.mkChoroplethAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IChoroplethProperty> uirevision(params bool[] values) => Interop.mkChoroplethAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IChoroplethProperty> uirevision(System.DateTime val) => Interop.mkChoroplethAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IChoroplethProperty> uirevision(params System.DateTime[] values) => Interop.mkChoroplethAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IChoroplethProperty> uirevision(int val) => Interop.mkChoroplethAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IChoroplethProperty> uirevision(params int[] values) => Interop.mkChoroplethAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IChoroplethProperty> uirevision(float val) => Interop.mkChoroplethAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IChoroplethProperty> uirevision(params float[] values) => Interop.mkChoroplethAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IChoroplethProperty> uirevision(string val) => Interop.mkChoroplethAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IChoroplethProperty> uirevision(params string[] values) => Interop.mkChoroplethAttr("uirevision", values);
        /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
        public static Box<IChoroplethProperty> locations(bool val) => Interop.mkChoroplethAttr("locations", new[]{val});
        /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
        public static Box<IChoroplethProperty> locations(params bool[] values) => Interop.mkChoroplethAttr("locations", values);
        /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
        public static Box<IChoroplethProperty> locations(System.DateTime val) => Interop.mkChoroplethAttr("locations", new[]{val});
        /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
        public static Box<IChoroplethProperty> locations(params System.DateTime[] values) => Interop.mkChoroplethAttr("locations", values);
        /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
        public static Box<IChoroplethProperty> locations(float val) => Interop.mkChoroplethAttr("locations", new[]{val});
        /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
        public static Box<IChoroplethProperty> locations(params float[] values) => Interop.mkChoroplethAttr("locations", values);
        /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
        public static Box<IChoroplethProperty> locations(int val) => Interop.mkChoroplethAttr("locations", new[]{val});
        /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
        public static Box<IChoroplethProperty> locations(params int[] values) => Interop.mkChoroplethAttr("locations", values);
        /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
        public static Box<IChoroplethProperty> locations(string val) => Interop.mkChoroplethAttr("locations", new[]{val});
        /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
        public static Box<IChoroplethProperty> locations(params string[] values) => Interop.mkChoroplethAttr("locations", values);
        /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
        public static Box<IChoroplethProperty> locations(IEnumerable<bool[]> values) => Interop.mkChoroplethAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
        public static Box<IChoroplethProperty> locations(List<bool[]> values) => Interop.mkChoroplethAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
        public static Box<IChoroplethProperty> locations(params bool[][] values) => Interop.mkChoroplethAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
        public static Box<IChoroplethProperty> locations(IEnumerable<IEnumerable<string>> values) => Interop.mkChoroplethAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
        public static Box<IChoroplethProperty> locations(List<string[]> values) => Interop.mkChoroplethAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
        public static Box<IChoroplethProperty> locations(params string[][] values) => Interop.mkChoroplethAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
        public static Box<IChoroplethProperty> locations(IEnumerable<IEnumerable<int>> values) => Interop.mkChoroplethAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
        public static Box<IChoroplethProperty> locations(List<int[]> values) => Interop.mkChoroplethAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
        public static Box<IChoroplethProperty> locations(params int[][] values) => Interop.mkChoroplethAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
        public static Box<IChoroplethProperty> locations(IEnumerable<IEnumerable<float>> values) => Interop.mkChoroplethAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
        public static Box<IChoroplethProperty> locations(List<float[]> values) => Interop.mkChoroplethAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
        public static Box<IChoroplethProperty> locations(params float[][] values) => Interop.mkChoroplethAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
        public static Box<IChoroplethProperty> locations(Literals.PlotData[] values) => Interop.mkChoroplethAttr("locations", values);
        /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
        public static Box<IChoroplethProperty> locations(IEnumerable<bool?> values) => Interop.mkChoroplethAttr("locations", values.ToArray());
        /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
        public static Box<IChoroplethProperty> locations(IEnumerable<System.DateTime?> values) => Interop.mkChoroplethAttr("locations", values.ToArray());
        /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
        public static Box<IChoroplethProperty> locations(IEnumerable<int?> values) => Interop.mkChoroplethAttr("locations", values.ToArray());
        /// Sets the coordinates via location IDs or names. See `locationmode` for more info.
        public static Box<IChoroplethProperty> locations(IEnumerable<float?> values) => Interop.mkChoroplethAttr("locations", values.ToArray());
        /// Sets the color values.
        public static Box<IChoroplethProperty> z(bool val) => Interop.mkChoroplethAttr("z", new[]{val});
        /// Sets the color values.
        public static Box<IChoroplethProperty> z(params bool[] values) => Interop.mkChoroplethAttr("z", values);
        /// Sets the color values.
        public static Box<IChoroplethProperty> z(System.DateTime val) => Interop.mkChoroplethAttr("z", new[]{val});
        /// Sets the color values.
        public static Box<IChoroplethProperty> z(params System.DateTime[] values) => Interop.mkChoroplethAttr("z", values);
        /// Sets the color values.
        public static Box<IChoroplethProperty> z(float val) => Interop.mkChoroplethAttr("z", new[]{val});
        /// Sets the color values.
        public static Box<IChoroplethProperty> z(params float[] values) => Interop.mkChoroplethAttr("z", values);
        /// Sets the color values.
        public static Box<IChoroplethProperty> z(int val) => Interop.mkChoroplethAttr("z", new[]{val});
        /// Sets the color values.
        public static Box<IChoroplethProperty> z(params int[] values) => Interop.mkChoroplethAttr("z", values);
        /// Sets the color values.
        public static Box<IChoroplethProperty> z(string val) => Interop.mkChoroplethAttr("z", new[]{val});
        /// Sets the color values.
        public static Box<IChoroplethProperty> z(params string[] values) => Interop.mkChoroplethAttr("z", values);
        /// Sets the color values.
        public static Box<IChoroplethProperty> z(IEnumerable<bool[]> values) => Interop.mkChoroplethAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color values.
        public static Box<IChoroplethProperty> z(List<bool[]> values) => Interop.mkChoroplethAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color values.
        public static Box<IChoroplethProperty> z(params bool[][] values) => Interop.mkChoroplethAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color values.
        public static Box<IChoroplethProperty> z(IEnumerable<IEnumerable<string>> values) => Interop.mkChoroplethAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color values.
        public static Box<IChoroplethProperty> z(List<string[]> values) => Interop.mkChoroplethAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color values.
        public static Box<IChoroplethProperty> z(params string[][] values) => Interop.mkChoroplethAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color values.
        public static Box<IChoroplethProperty> z(IEnumerable<IEnumerable<int>> values) => Interop.mkChoroplethAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color values.
        public static Box<IChoroplethProperty> z(List<int[]> values) => Interop.mkChoroplethAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color values.
        public static Box<IChoroplethProperty> z(params int[][] values) => Interop.mkChoroplethAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color values.
        public static Box<IChoroplethProperty> z(IEnumerable<IEnumerable<float>> values) => Interop.mkChoroplethAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color values.
        public static Box<IChoroplethProperty> z(List<float[]> values) => Interop.mkChoroplethAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color values.
        public static Box<IChoroplethProperty> z(params float[][] values) => Interop.mkChoroplethAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color values.
        public static Box<IChoroplethProperty> z(Literals.PlotData[] values) => Interop.mkChoroplethAttr("z", values);
        /// Sets the color values.
        public static Box<IChoroplethProperty> z(IEnumerable<bool?> values) => Interop.mkChoroplethAttr("z", values.ToArray());
        /// Sets the color values.
        public static Box<IChoroplethProperty> z(IEnumerable<System.DateTime?> values) => Interop.mkChoroplethAttr("z", values.ToArray());
        /// Sets the color values.
        public static Box<IChoroplethProperty> z(IEnumerable<int?> values) => Interop.mkChoroplethAttr("z", values.ToArray());
        /// Sets the color values.
        public static Box<IChoroplethProperty> z(IEnumerable<float?> values) => Interop.mkChoroplethAttr("z", values.ToArray());
        /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
        public static Box<IChoroplethProperty> geojson(bool val) => Interop.mkChoroplethAttr("geojson", val);
        /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
        public static Box<IChoroplethProperty> geojson(params bool[] values) => Interop.mkChoroplethAttr("geojson", values);
        /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
        public static Box<IChoroplethProperty> geojson(System.DateTime val) => Interop.mkChoroplethAttr("geojson", val);
        /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
        public static Box<IChoroplethProperty> geojson(params System.DateTime[] values) => Interop.mkChoroplethAttr("geojson", values);
        /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
        public static Box<IChoroplethProperty> geojson(int val) => Interop.mkChoroplethAttr("geojson", val);
        /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
        public static Box<IChoroplethProperty> geojson(params int[] values) => Interop.mkChoroplethAttr("geojson", values);
        /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
        public static Box<IChoroplethProperty> geojson(float val) => Interop.mkChoroplethAttr("geojson", val);
        /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
        public static Box<IChoroplethProperty> geojson(params float[] values) => Interop.mkChoroplethAttr("geojson", values);
        /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
        public static Box<IChoroplethProperty> geojson(string val) => Interop.mkChoroplethAttr("geojson", val);
        /// Sets optional GeoJSON data associated with this trace. If not given, the features on the base map are used. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
        public static Box<IChoroplethProperty> geojson(params string[] values) => Interop.mkChoroplethAttr("geojson", values);
        /// Sets the key in GeoJSON features which is used as id to match the items included in the `locations` array. Only has an effect when `geojson` is set. Support nested property, for example *properties.name*.
        public static Box<IChoroplethProperty> featureidkey(string val) => Interop.mkChoroplethAttr("featureidkey", val);
        /// Sets the text elements associated with each location.
        public static Box<IChoroplethProperty> text(string val) => Interop.mkChoroplethAttr("text", val);
        /// Sets the text elements associated with each location.
        public static Box<IChoroplethProperty> text(IEnumerable<string> values) => Interop.mkChoroplethAttr("text", values.ToArray());
        /// Same as `text`.
        public static Box<IChoroplethProperty> hovertext(string val) => Interop.mkChoroplethAttr("hovertext", val);
        /// Same as `text`.
        public static Box<IChoroplethProperty> hovertext(IEnumerable<string> values) => Interop.mkChoroplethAttr("hovertext", values.ToArray());
        public static Box<IChoroplethProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkChoroplethAttr("marker", Bindings.flattenProperties(properties));
        public static Box<IChoroplethProperty> selected(params Box<ISelectedProperty>[] properties) => Interop.mkChoroplethAttr("selected", Bindings.flattenProperties(properties));
        public static Box<IChoroplethProperty> unselected(params Box<IUnselectedProperty>[] properties) => Interop.mkChoroplethAttr("unselected", Bindings.flattenProperties(properties));
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IChoroplethProperty> hoverinfo(params Box<IChoroplethProperty>[] properties) => Interop.mkChoroplethAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IChoroplethProperty> hovertemplate(string val) => Interop.mkChoroplethAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IChoroplethProperty> hovertemplate(IEnumerable<string> values) => Interop.mkChoroplethAttr("hovertemplate", values.ToArray());
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IChoroplethProperty> showlegend(bool val) => Interop.mkChoroplethAttr("showlegend", val);
        /// Determines whether or not the color domain is computed with respect to the input data (here in `z`) or the bounds set in `zmin` and `zmax`  Defaults to `false` when `zmin` and `zmax` are set by the user.
        public static Box<IChoroplethProperty> zauto(bool val) => Interop.mkChoroplethAttr("zauto", val);
        /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
        public static Box<IChoroplethProperty> zmin(int val) => Interop.mkChoroplethAttr("zmin", val);
        /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
        public static Box<IChoroplethProperty> zmin(float val) => Interop.mkChoroplethAttr("zmin", val);
        /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
        public static Box<IChoroplethProperty> zmax(int val) => Interop.mkChoroplethAttr("zmax", val);
        /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
        public static Box<IChoroplethProperty> zmax(float val) => Interop.mkChoroplethAttr("zmax", val);
        /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
        public static Box<IChoroplethProperty> zmid(int val) => Interop.mkChoroplethAttr("zmid", val);
        /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
        public static Box<IChoroplethProperty> zmid(float val) => Interop.mkChoroplethAttr("zmid", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IChoroplethProperty> colorscale(string val) => Interop.mkChoroplethAttr("colorscale", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IChoroplethProperty> colorscale(List<string[]> values) => Interop.mkChoroplethAttr("colorscale", Bindings.flatten2DArrayIf1D(values));
        /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
        public static Box<IChoroplethProperty> autocolorscale(bool val) => Interop.mkChoroplethAttr("autocolorscale", val);
        /// Reverses the color mapping if true. If true, `zmin` will correspond to the last color in the array and `zmax` will correspond to the first color.
        public static Box<IChoroplethProperty> reversescale(bool val) => Interop.mkChoroplethAttr("reversescale", val);
        /// Determines whether or not a colorbar is displayed for this trace.
        public static Box<IChoroplethProperty> showscale(bool val) => Interop.mkChoroplethAttr("showscale", val);
        public static Box<IChoroplethProperty> colorbar(params Box<IColorbarProperty>[] properties) => Interop.mkChoroplethAttr("colorbar", Bindings.flattenProperties(properties));
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<IChoroplethProperty> coloraxis(int anchorId) => Interop.mkChoroplethAttr("coloraxis", anchorId > 1 ? $"coloraxis{anchorId}" : "");
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<IChoroplethProperty> coloraxis(string val) => Interop.mkChoroplethAttr("coloraxis", val);
        /// Sets a reference between this trace's geospatial coordinates and a geographic map. If *geo* (the default value), the geospatial coordinates refer to `layout.geo`. If *geo2*, the geospatial coordinates refer to `layout.geo2`, and so on.
        public static Box<IChoroplethProperty> geo(int anchorId) => Interop.mkChoroplethAttr("geo", anchorId > 1 ? $"geo{anchorId}" : "");
        /// Sets a reference between this trace's geospatial coordinates and a geographic map. If *geo* (the default value), the geospatial coordinates refer to `layout.geo`. If *geo2*, the geospatial coordinates refer to `layout.geo2`, and so on.
        public static Box<IChoroplethProperty> geo(string val) => Interop.mkChoroplethAttr("geo", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IChoroplethProperty> idssrc(string val) => Interop.mkChoroplethAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IChoroplethProperty> customdatasrc(string val) => Interop.mkChoroplethAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IChoroplethProperty> metasrc(string val) => Interop.mkChoroplethAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  locations .
        public static Box<IChoroplethProperty> locationssrc(string val) => Interop.mkChoroplethAttr("locationssrc", val);
        /// Sets the source reference on plot.ly for  z .
        public static Box<IChoroplethProperty> zsrc(string val) => Interop.mkChoroplethAttr("zsrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IChoroplethProperty> textsrc(string val) => Interop.mkChoroplethAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IChoroplethProperty> hovertextsrc(string val) => Interop.mkChoroplethAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IChoroplethProperty> hoverinfosrc(string val) => Interop.mkChoroplethAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IChoroplethProperty> hovertemplatesrc(string val) => Interop.mkChoroplethAttr("hovertemplatesrc", val);
    }

    public static partial class Choropleth
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IChoroplethProperty> legendonly() => Interop.mkChoroplethAttr("visible", "legendonly");
            public static Box<IChoroplethProperty> _false() => Interop.mkChoroplethAttr("visible", false);
            public static Box<IChoroplethProperty> _true() => Interop.mkChoroplethAttr("visible", true);
        }

        /// Determines the set of locations used to match entries in `locations` to regions on the map. Values *ISO-3*, *USA-states*, *country names* correspond to features on the base map and value *geojson-id* corresponds to features from a custom GeoJSON linked to the `geojson` attribute.
        public static partial class Locationmode
        {
            public static Box<IChoroplethProperty> ISO3() => Interop.mkChoroplethAttr("locationmode", "ISO-3");
            public static Box<IChoroplethProperty> USAStates() => Interop.mkChoroplethAttr("locationmode", "USA-states");
            public static Box<IChoroplethProperty> countryNames() => Interop.mkChoroplethAttr("locationmode", "country names");
            public static Box<IChoroplethProperty> geojsonId() => Interop.mkChoroplethAttr("locationmode", "geojson-id");
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IChoroplethProperty> all() => Interop.mkChoroplethAttr("hoverinfo", "all");
            public static Box<IChoroplethProperty> none() => Interop.mkChoroplethAttr("hoverinfo", "none");
            public static Box<IChoroplethProperty> skip() => Interop.mkChoroplethAttr("hoverinfo", "skip");
            public static Box<IChoroplethProperty> location() => Interop.mkChoroplethAttr("hoverinfo", "location");
            public static Box<IChoroplethProperty> name() => Interop.mkChoroplethAttr("hoverinfo", "name");
            public static Box<IChoroplethProperty> text() => Interop.mkChoroplethAttr("hoverinfo", "text");
            public static Box<IChoroplethProperty> z() => Interop.mkChoroplethAttr("hoverinfo", "z");
        }
    }
}