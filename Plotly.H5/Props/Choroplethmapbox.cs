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

    public static partial class Choroplethmapbox
    {
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IChoroplethmapboxProperty> legendgroup(string val) => Interop.mkChoroplethmapboxAttr("legendgroup", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IChoroplethmapboxProperty> name(string val) => Interop.mkChoroplethmapboxAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IChoroplethmapboxProperty> uid(string val) => Interop.mkChoroplethmapboxAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethmapboxProperty> ids(bool val) => Interop.mkChoroplethmapboxAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethmapboxProperty> ids(params bool[] values) => Interop.mkChoroplethmapboxAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethmapboxProperty> ids(System.DateTime val) => Interop.mkChoroplethmapboxAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethmapboxProperty> ids(params System.DateTime[] values) => Interop.mkChoroplethmapboxAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethmapboxProperty> ids(float val) => Interop.mkChoroplethmapboxAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethmapboxProperty> ids(params float[] values) => Interop.mkChoroplethmapboxAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethmapboxProperty> ids(int val) => Interop.mkChoroplethmapboxAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethmapboxProperty> ids(params int[] values) => Interop.mkChoroplethmapboxAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethmapboxProperty> ids(string val) => Interop.mkChoroplethmapboxAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethmapboxProperty> ids(params string[] values) => Interop.mkChoroplethmapboxAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethmapboxProperty> ids(IEnumerable<bool[]> values) => Interop.mkChoroplethmapboxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethmapboxProperty> ids(List<bool[]> values) => Interop.mkChoroplethmapboxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethmapboxProperty> ids(params bool[][] values) => Interop.mkChoroplethmapboxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethmapboxProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkChoroplethmapboxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethmapboxProperty> ids(List<string[]> values) => Interop.mkChoroplethmapboxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethmapboxProperty> ids(params string[][] values) => Interop.mkChoroplethmapboxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethmapboxProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkChoroplethmapboxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethmapboxProperty> ids(List<int[]> values) => Interop.mkChoroplethmapboxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethmapboxProperty> ids(params int[][] values) => Interop.mkChoroplethmapboxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethmapboxProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkChoroplethmapboxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethmapboxProperty> ids(List<float[]> values) => Interop.mkChoroplethmapboxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethmapboxProperty> ids(params float[][] values) => Interop.mkChoroplethmapboxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethmapboxProperty> ids(Literals.PlotData[] values) => Interop.mkChoroplethmapboxAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethmapboxProperty> ids(IEnumerable<bool?> values) => Interop.mkChoroplethmapboxAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethmapboxProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkChoroplethmapboxAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethmapboxProperty> ids(IEnumerable<int?> values) => Interop.mkChoroplethmapboxAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IChoroplethmapboxProperty> ids(IEnumerable<float?> values) => Interop.mkChoroplethmapboxAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethmapboxProperty> customdata(bool val) => Interop.mkChoroplethmapboxAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethmapboxProperty> customdata(params bool[] values) => Interop.mkChoroplethmapboxAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethmapboxProperty> customdata(System.DateTime val) => Interop.mkChoroplethmapboxAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethmapboxProperty> customdata(params System.DateTime[] values) => Interop.mkChoroplethmapboxAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethmapboxProperty> customdata(float val) => Interop.mkChoroplethmapboxAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethmapboxProperty> customdata(params float[] values) => Interop.mkChoroplethmapboxAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethmapboxProperty> customdata(int val) => Interop.mkChoroplethmapboxAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethmapboxProperty> customdata(params int[] values) => Interop.mkChoroplethmapboxAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethmapboxProperty> customdata(string val) => Interop.mkChoroplethmapboxAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethmapboxProperty> customdata(params string[] values) => Interop.mkChoroplethmapboxAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethmapboxProperty> customdata(IEnumerable<bool[]> values) => Interop.mkChoroplethmapboxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethmapboxProperty> customdata(List<bool[]> values) => Interop.mkChoroplethmapboxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethmapboxProperty> customdata(params bool[][] values) => Interop.mkChoroplethmapboxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethmapboxProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkChoroplethmapboxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethmapboxProperty> customdata(List<string[]> values) => Interop.mkChoroplethmapboxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethmapboxProperty> customdata(params string[][] values) => Interop.mkChoroplethmapboxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethmapboxProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkChoroplethmapboxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethmapboxProperty> customdata(List<int[]> values) => Interop.mkChoroplethmapboxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethmapboxProperty> customdata(params int[][] values) => Interop.mkChoroplethmapboxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethmapboxProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkChoroplethmapboxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethmapboxProperty> customdata(List<float[]> values) => Interop.mkChoroplethmapboxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethmapboxProperty> customdata(params float[][] values) => Interop.mkChoroplethmapboxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethmapboxProperty> customdata(Literals.PlotData[] values) => Interop.mkChoroplethmapboxAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethmapboxProperty> customdata(IEnumerable<bool?> values) => Interop.mkChoroplethmapboxAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethmapboxProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkChoroplethmapboxAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethmapboxProperty> customdata(IEnumerable<int?> values) => Interop.mkChoroplethmapboxAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IChoroplethmapboxProperty> customdata(IEnumerable<float?> values) => Interop.mkChoroplethmapboxAttr("customdata", values.ToArray());
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IChoroplethmapboxProperty> selectedpoints(bool val) => Interop.mkChoroplethmapboxAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IChoroplethmapboxProperty> selectedpoints(params bool[] values) => Interop.mkChoroplethmapboxAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IChoroplethmapboxProperty> selectedpoints(System.DateTime val) => Interop.mkChoroplethmapboxAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IChoroplethmapboxProperty> selectedpoints(params System.DateTime[] values) => Interop.mkChoroplethmapboxAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IChoroplethmapboxProperty> selectedpoints(int val) => Interop.mkChoroplethmapboxAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IChoroplethmapboxProperty> selectedpoints(params int[] values) => Interop.mkChoroplethmapboxAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IChoroplethmapboxProperty> selectedpoints(float val) => Interop.mkChoroplethmapboxAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IChoroplethmapboxProperty> selectedpoints(params float[] values) => Interop.mkChoroplethmapboxAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IChoroplethmapboxProperty> selectedpoints(string val) => Interop.mkChoroplethmapboxAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IChoroplethmapboxProperty> selectedpoints(params string[] values) => Interop.mkChoroplethmapboxAttr("selectedpoints", values);
        public static Box<IChoroplethmapboxProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkChoroplethmapboxAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IChoroplethmapboxProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkChoroplethmapboxAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IChoroplethmapboxProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkChoroplethmapboxAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IChoroplethmapboxProperty> uirevision(bool val) => Interop.mkChoroplethmapboxAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IChoroplethmapboxProperty> uirevision(params bool[] values) => Interop.mkChoroplethmapboxAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IChoroplethmapboxProperty> uirevision(System.DateTime val) => Interop.mkChoroplethmapboxAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IChoroplethmapboxProperty> uirevision(params System.DateTime[] values) => Interop.mkChoroplethmapboxAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IChoroplethmapboxProperty> uirevision(int val) => Interop.mkChoroplethmapboxAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IChoroplethmapboxProperty> uirevision(params int[] values) => Interop.mkChoroplethmapboxAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IChoroplethmapboxProperty> uirevision(float val) => Interop.mkChoroplethmapboxAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IChoroplethmapboxProperty> uirevision(params float[] values) => Interop.mkChoroplethmapboxAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IChoroplethmapboxProperty> uirevision(string val) => Interop.mkChoroplethmapboxAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IChoroplethmapboxProperty> uirevision(params string[] values) => Interop.mkChoroplethmapboxAttr("uirevision", values);
        /// Sets which features found in *geojson* to plot using their feature `id` field.
        public static Box<IChoroplethmapboxProperty> locations(bool val) => Interop.mkChoroplethmapboxAttr("locations", new[]{val});
        /// Sets which features found in *geojson* to plot using their feature `id` field.
        public static Box<IChoroplethmapboxProperty> locations(params bool[] values) => Interop.mkChoroplethmapboxAttr("locations", values);
        /// Sets which features found in *geojson* to plot using their feature `id` field.
        public static Box<IChoroplethmapboxProperty> locations(System.DateTime val) => Interop.mkChoroplethmapboxAttr("locations", new[]{val});
        /// Sets which features found in *geojson* to plot using their feature `id` field.
        public static Box<IChoroplethmapboxProperty> locations(params System.DateTime[] values) => Interop.mkChoroplethmapboxAttr("locations", values);
        /// Sets which features found in *geojson* to plot using their feature `id` field.
        public static Box<IChoroplethmapboxProperty> locations(float val) => Interop.mkChoroplethmapboxAttr("locations", new[]{val});
        /// Sets which features found in *geojson* to plot using their feature `id` field.
        public static Box<IChoroplethmapboxProperty> locations(params float[] values) => Interop.mkChoroplethmapboxAttr("locations", values);
        /// Sets which features found in *geojson* to plot using their feature `id` field.
        public static Box<IChoroplethmapboxProperty> locations(int val) => Interop.mkChoroplethmapboxAttr("locations", new[]{val});
        /// Sets which features found in *geojson* to plot using their feature `id` field.
        public static Box<IChoroplethmapboxProperty> locations(params int[] values) => Interop.mkChoroplethmapboxAttr("locations", values);
        /// Sets which features found in *geojson* to plot using their feature `id` field.
        public static Box<IChoroplethmapboxProperty> locations(string val) => Interop.mkChoroplethmapboxAttr("locations", new[]{val});
        /// Sets which features found in *geojson* to plot using their feature `id` field.
        public static Box<IChoroplethmapboxProperty> locations(params string[] values) => Interop.mkChoroplethmapboxAttr("locations", values);
        /// Sets which features found in *geojson* to plot using their feature `id` field.
        public static Box<IChoroplethmapboxProperty> locations(IEnumerable<bool[]> values) => Interop.mkChoroplethmapboxAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets which features found in *geojson* to plot using their feature `id` field.
        public static Box<IChoroplethmapboxProperty> locations(List<bool[]> values) => Interop.mkChoroplethmapboxAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets which features found in *geojson* to plot using their feature `id` field.
        public static Box<IChoroplethmapboxProperty> locations(params bool[][] values) => Interop.mkChoroplethmapboxAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets which features found in *geojson* to plot using their feature `id` field.
        public static Box<IChoroplethmapboxProperty> locations(IEnumerable<IEnumerable<string>> values) => Interop.mkChoroplethmapboxAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets which features found in *geojson* to plot using their feature `id` field.
        public static Box<IChoroplethmapboxProperty> locations(List<string[]> values) => Interop.mkChoroplethmapboxAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets which features found in *geojson* to plot using their feature `id` field.
        public static Box<IChoroplethmapboxProperty> locations(params string[][] values) => Interop.mkChoroplethmapboxAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets which features found in *geojson* to plot using their feature `id` field.
        public static Box<IChoroplethmapboxProperty> locations(IEnumerable<IEnumerable<int>> values) => Interop.mkChoroplethmapboxAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets which features found in *geojson* to plot using their feature `id` field.
        public static Box<IChoroplethmapboxProperty> locations(List<int[]> values) => Interop.mkChoroplethmapboxAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets which features found in *geojson* to plot using their feature `id` field.
        public static Box<IChoroplethmapboxProperty> locations(params int[][] values) => Interop.mkChoroplethmapboxAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets which features found in *geojson* to plot using their feature `id` field.
        public static Box<IChoroplethmapboxProperty> locations(IEnumerable<IEnumerable<float>> values) => Interop.mkChoroplethmapboxAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets which features found in *geojson* to plot using their feature `id` field.
        public static Box<IChoroplethmapboxProperty> locations(List<float[]> values) => Interop.mkChoroplethmapboxAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets which features found in *geojson* to plot using their feature `id` field.
        public static Box<IChoroplethmapboxProperty> locations(params float[][] values) => Interop.mkChoroplethmapboxAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Sets which features found in *geojson* to plot using their feature `id` field.
        public static Box<IChoroplethmapboxProperty> locations(Literals.PlotData[] values) => Interop.mkChoroplethmapboxAttr("locations", values);
        /// Sets which features found in *geojson* to plot using their feature `id` field.
        public static Box<IChoroplethmapboxProperty> locations(IEnumerable<bool?> values) => Interop.mkChoroplethmapboxAttr("locations", values.ToArray());
        /// Sets which features found in *geojson* to plot using their feature `id` field.
        public static Box<IChoroplethmapboxProperty> locations(IEnumerable<System.DateTime?> values) => Interop.mkChoroplethmapboxAttr("locations", values.ToArray());
        /// Sets which features found in *geojson* to plot using their feature `id` field.
        public static Box<IChoroplethmapboxProperty> locations(IEnumerable<int?> values) => Interop.mkChoroplethmapboxAttr("locations", values.ToArray());
        /// Sets which features found in *geojson* to plot using their feature `id` field.
        public static Box<IChoroplethmapboxProperty> locations(IEnumerable<float?> values) => Interop.mkChoroplethmapboxAttr("locations", values.ToArray());
        /// Sets the color values.
        public static Box<IChoroplethmapboxProperty> z(bool val) => Interop.mkChoroplethmapboxAttr("z", new[]{val});
        /// Sets the color values.
        public static Box<IChoroplethmapboxProperty> z(params bool[] values) => Interop.mkChoroplethmapboxAttr("z", values);
        /// Sets the color values.
        public static Box<IChoroplethmapboxProperty> z(System.DateTime val) => Interop.mkChoroplethmapboxAttr("z", new[]{val});
        /// Sets the color values.
        public static Box<IChoroplethmapboxProperty> z(params System.DateTime[] values) => Interop.mkChoroplethmapboxAttr("z", values);
        /// Sets the color values.
        public static Box<IChoroplethmapboxProperty> z(float val) => Interop.mkChoroplethmapboxAttr("z", new[]{val});
        /// Sets the color values.
        public static Box<IChoroplethmapboxProperty> z(params float[] values) => Interop.mkChoroplethmapboxAttr("z", values);
        /// Sets the color values.
        public static Box<IChoroplethmapboxProperty> z(int val) => Interop.mkChoroplethmapboxAttr("z", new[]{val});
        /// Sets the color values.
        public static Box<IChoroplethmapboxProperty> z(params int[] values) => Interop.mkChoroplethmapboxAttr("z", values);
        /// Sets the color values.
        public static Box<IChoroplethmapboxProperty> z(string val) => Interop.mkChoroplethmapboxAttr("z", new[]{val});
        /// Sets the color values.
        public static Box<IChoroplethmapboxProperty> z(params string[] values) => Interop.mkChoroplethmapboxAttr("z", values);
        /// Sets the color values.
        public static Box<IChoroplethmapboxProperty> z(IEnumerable<bool[]> values) => Interop.mkChoroplethmapboxAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color values.
        public static Box<IChoroplethmapboxProperty> z(List<bool[]> values) => Interop.mkChoroplethmapboxAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color values.
        public static Box<IChoroplethmapboxProperty> z(params bool[][] values) => Interop.mkChoroplethmapboxAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color values.
        public static Box<IChoroplethmapboxProperty> z(IEnumerable<IEnumerable<string>> values) => Interop.mkChoroplethmapboxAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color values.
        public static Box<IChoroplethmapboxProperty> z(List<string[]> values) => Interop.mkChoroplethmapboxAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color values.
        public static Box<IChoroplethmapboxProperty> z(params string[][] values) => Interop.mkChoroplethmapboxAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color values.
        public static Box<IChoroplethmapboxProperty> z(IEnumerable<IEnumerable<int>> values) => Interop.mkChoroplethmapboxAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color values.
        public static Box<IChoroplethmapboxProperty> z(List<int[]> values) => Interop.mkChoroplethmapboxAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color values.
        public static Box<IChoroplethmapboxProperty> z(params int[][] values) => Interop.mkChoroplethmapboxAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color values.
        public static Box<IChoroplethmapboxProperty> z(IEnumerable<IEnumerable<float>> values) => Interop.mkChoroplethmapboxAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color values.
        public static Box<IChoroplethmapboxProperty> z(List<float[]> values) => Interop.mkChoroplethmapboxAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color values.
        public static Box<IChoroplethmapboxProperty> z(params float[][] values) => Interop.mkChoroplethmapboxAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// Sets the color values.
        public static Box<IChoroplethmapboxProperty> z(Literals.PlotData[] values) => Interop.mkChoroplethmapboxAttr("z", values);
        /// Sets the color values.
        public static Box<IChoroplethmapboxProperty> z(IEnumerable<bool?> values) => Interop.mkChoroplethmapboxAttr("z", values.ToArray());
        /// Sets the color values.
        public static Box<IChoroplethmapboxProperty> z(IEnumerable<System.DateTime?> values) => Interop.mkChoroplethmapboxAttr("z", values.ToArray());
        /// Sets the color values.
        public static Box<IChoroplethmapboxProperty> z(IEnumerable<int?> values) => Interop.mkChoroplethmapboxAttr("z", values.ToArray());
        /// Sets the color values.
        public static Box<IChoroplethmapboxProperty> z(IEnumerable<float?> values) => Interop.mkChoroplethmapboxAttr("z", values.ToArray());
        /// Sets the GeoJSON data associated with this trace. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
        public static Box<IChoroplethmapboxProperty> geojson(bool val) => Interop.mkChoroplethmapboxAttr("geojson", val);
        /// Sets the GeoJSON data associated with this trace. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
        public static Box<IChoroplethmapboxProperty> geojson(params bool[] values) => Interop.mkChoroplethmapboxAttr("geojson", values);
        /// Sets the GeoJSON data associated with this trace. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
        public static Box<IChoroplethmapboxProperty> geojson(System.DateTime val) => Interop.mkChoroplethmapboxAttr("geojson", val);
        /// Sets the GeoJSON data associated with this trace. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
        public static Box<IChoroplethmapboxProperty> geojson(params System.DateTime[] values) => Interop.mkChoroplethmapboxAttr("geojson", values);
        /// Sets the GeoJSON data associated with this trace. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
        public static Box<IChoroplethmapboxProperty> geojson(int val) => Interop.mkChoroplethmapboxAttr("geojson", val);
        /// Sets the GeoJSON data associated with this trace. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
        public static Box<IChoroplethmapboxProperty> geojson(params int[] values) => Interop.mkChoroplethmapboxAttr("geojson", values);
        /// Sets the GeoJSON data associated with this trace. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
        public static Box<IChoroplethmapboxProperty> geojson(float val) => Interop.mkChoroplethmapboxAttr("geojson", val);
        /// Sets the GeoJSON data associated with this trace. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
        public static Box<IChoroplethmapboxProperty> geojson(params float[] values) => Interop.mkChoroplethmapboxAttr("geojson", values);
        /// Sets the GeoJSON data associated with this trace. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
        public static Box<IChoroplethmapboxProperty> geojson(string val) => Interop.mkChoroplethmapboxAttr("geojson", val);
        /// Sets the GeoJSON data associated with this trace. It can be set as a valid GeoJSON object or as a URL string. Note that we only accept GeoJSONs of type *FeatureCollection* or *Feature* with geometries of type *Polygon* or *MultiPolygon*.
        public static Box<IChoroplethmapboxProperty> geojson(params string[] values) => Interop.mkChoroplethmapboxAttr("geojson", values);
        /// Sets the key in GeoJSON features which is used as id to match the items included in the `locations` array. Support nested property, for example *properties.name*.
        public static Box<IChoroplethmapboxProperty> featureidkey(string val) => Interop.mkChoroplethmapboxAttr("featureidkey", val);
        /// Determines if the choropleth polygons will be inserted before the layer with the specified ID. By default, choroplethmapbox traces are placed above the water layers. If set to '', the layer will be inserted above every existing layer.
        public static Box<IChoroplethmapboxProperty> below(string val) => Interop.mkChoroplethmapboxAttr("below", val);
        /// Sets the text elements associated with each location.
        public static Box<IChoroplethmapboxProperty> text(string val) => Interop.mkChoroplethmapboxAttr("text", val);
        /// Sets the text elements associated with each location.
        public static Box<IChoroplethmapboxProperty> text(IEnumerable<string> values) => Interop.mkChoroplethmapboxAttr("text", values.ToArray());
        /// Same as `text`.
        public static Box<IChoroplethmapboxProperty> hovertext(string val) => Interop.mkChoroplethmapboxAttr("hovertext", val);
        /// Same as `text`.
        public static Box<IChoroplethmapboxProperty> hovertext(IEnumerable<string> values) => Interop.mkChoroplethmapboxAttr("hovertext", values.ToArray());
        public static Box<IChoroplethmapboxProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkChoroplethmapboxAttr("marker", Bindings.flattenProperties(properties));
        public static Box<IChoroplethmapboxProperty> selected(params Box<ISelectedProperty>[] properties) => Interop.mkChoroplethmapboxAttr("selected", Bindings.flattenProperties(properties));
        public static Box<IChoroplethmapboxProperty> unselected(params Box<IUnselectedProperty>[] properties) => Interop.mkChoroplethmapboxAttr("unselected", Bindings.flattenProperties(properties));
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IChoroplethmapboxProperty> hoverinfo(params Box<IChoroplethmapboxProperty>[] properties) => Interop.mkChoroplethmapboxAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variable `properties` Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IChoroplethmapboxProperty> hovertemplate(string val) => Interop.mkChoroplethmapboxAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variable `properties` Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IChoroplethmapboxProperty> hovertemplate(IEnumerable<string> values) => Interop.mkChoroplethmapboxAttr("hovertemplate", values.ToArray());
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IChoroplethmapboxProperty> showlegend(bool val) => Interop.mkChoroplethmapboxAttr("showlegend", val);
        /// Determines whether or not the color domain is computed with respect to the input data (here in `z`) or the bounds set in `zmin` and `zmax`  Defaults to `false` when `zmin` and `zmax` are set by the user.
        public static Box<IChoroplethmapboxProperty> zauto(bool val) => Interop.mkChoroplethmapboxAttr("zauto", val);
        /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
        public static Box<IChoroplethmapboxProperty> zmin(int val) => Interop.mkChoroplethmapboxAttr("zmin", val);
        /// Sets the lower bound of the color domain. Value should have the same units as in `z` and if set, `zmax` must be set as well.
        public static Box<IChoroplethmapboxProperty> zmin(float val) => Interop.mkChoroplethmapboxAttr("zmin", val);
        /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
        public static Box<IChoroplethmapboxProperty> zmax(int val) => Interop.mkChoroplethmapboxAttr("zmax", val);
        /// Sets the upper bound of the color domain. Value should have the same units as in `z` and if set, `zmin` must be set as well.
        public static Box<IChoroplethmapboxProperty> zmax(float val) => Interop.mkChoroplethmapboxAttr("zmax", val);
        /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
        public static Box<IChoroplethmapboxProperty> zmid(int val) => Interop.mkChoroplethmapboxAttr("zmid", val);
        /// Sets the mid-point of the color domain by scaling `zmin` and/or `zmax` to be equidistant to this point. Value should have the same units as in `z`. Has no effect when `zauto` is `false`.
        public static Box<IChoroplethmapboxProperty> zmid(float val) => Interop.mkChoroplethmapboxAttr("zmid", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IChoroplethmapboxProperty> colorscale(string val) => Interop.mkChoroplethmapboxAttr("colorscale", val);
        /// Sets the colorscale. The colorscale must be an array containing arrays mapping a normalized value to an rgb, rgba, hex, hsl, hsv, or named color string. At minimum, a mapping for the lowest (0) and highest (1) values are required. For example, `[[0, 'rgb(0,0,255)'], [1, 'rgb(255,0,0)']]`. To control the bounds of the colorscale in color space, use`zmin` and `zmax`. Alternatively, `colorscale` may be a palette name string of the following list: Greys,YlGnBu,Greens,YlOrRd,Bluered,RdBu,Reds,Blues,Picnic,Rainbow,Portland,Jet,Hot,Blackbody,Earth,Electric,Viridis,Cividis.
        public static Box<IChoroplethmapboxProperty> colorscale(List<string[]> values) => Interop.mkChoroplethmapboxAttr("colorscale", Bindings.flatten2DArrayIf1D(values));
        /// Determines whether the colorscale is a default palette (`autocolorscale: true`) or the palette determined by `colorscale`. In case `colorscale` is unspecified or `autocolorscale` is true, the default  palette will be chosen according to whether numbers in the `color` array are all positive, all negative or mixed.
        public static Box<IChoroplethmapboxProperty> autocolorscale(bool val) => Interop.mkChoroplethmapboxAttr("autocolorscale", val);
        /// Reverses the color mapping if true. If true, `zmin` will correspond to the last color in the array and `zmax` will correspond to the first color.
        public static Box<IChoroplethmapboxProperty> reversescale(bool val) => Interop.mkChoroplethmapboxAttr("reversescale", val);
        /// Determines whether or not a colorbar is displayed for this trace.
        public static Box<IChoroplethmapboxProperty> showscale(bool val) => Interop.mkChoroplethmapboxAttr("showscale", val);
        public static Box<IChoroplethmapboxProperty> colorbar(params Box<IColorbarProperty>[] properties) => Interop.mkChoroplethmapboxAttr("colorbar", Bindings.flattenProperties(properties));
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<IChoroplethmapboxProperty> coloraxis(int anchorId) => Interop.mkChoroplethmapboxAttr("coloraxis", anchorId > 1 ? $"coloraxis{anchorId}" : "");
        /// Sets a reference to a shared color axis. References to these shared color axes are *coloraxis*, *coloraxis2*, *coloraxis3*, etc. Settings for these shared color axes are set in the layout, under `layout.coloraxis`, `layout.coloraxis2`, etc. Note that multiple color scales can be linked to the same color axis.
        public static Box<IChoroplethmapboxProperty> coloraxis(string val) => Interop.mkChoroplethmapboxAttr("coloraxis", val);
        /// Sets a reference between this trace's data coordinates and a mapbox subplot. If *mapbox* (the default value), the data refer to `layout.mapbox`. If *mapbox2*, the data refer to `layout.mapbox2`, and so on.
        public static Box<IChoroplethmapboxProperty> subplot(int anchorId) => Interop.mkChoroplethmapboxAttr("subplot", anchorId > 1 ? $"mapbox{anchorId}" : "");
        /// Sets a reference between this trace's data coordinates and a mapbox subplot. If *mapbox* (the default value), the data refer to `layout.mapbox`. If *mapbox2*, the data refer to `layout.mapbox2`, and so on.
        public static Box<IChoroplethmapboxProperty> subplot(string val) => Interop.mkChoroplethmapboxAttr("subplot", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IChoroplethmapboxProperty> idssrc(string val) => Interop.mkChoroplethmapboxAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IChoroplethmapboxProperty> customdatasrc(string val) => Interop.mkChoroplethmapboxAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IChoroplethmapboxProperty> metasrc(string val) => Interop.mkChoroplethmapboxAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  locations .
        public static Box<IChoroplethmapboxProperty> locationssrc(string val) => Interop.mkChoroplethmapboxAttr("locationssrc", val);
        /// Sets the source reference on plot.ly for  z .
        public static Box<IChoroplethmapboxProperty> zsrc(string val) => Interop.mkChoroplethmapboxAttr("zsrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IChoroplethmapboxProperty> textsrc(string val) => Interop.mkChoroplethmapboxAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IChoroplethmapboxProperty> hovertextsrc(string val) => Interop.mkChoroplethmapboxAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IChoroplethmapboxProperty> hoverinfosrc(string val) => Interop.mkChoroplethmapboxAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IChoroplethmapboxProperty> hovertemplatesrc(string val) => Interop.mkChoroplethmapboxAttr("hovertemplatesrc", val);
    }

    public static partial class Choroplethmapbox
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IChoroplethmapboxProperty> legendonly() => Interop.mkChoroplethmapboxAttr("visible", "legendonly");
            public static Box<IChoroplethmapboxProperty> _false() => Interop.mkChoroplethmapboxAttr("visible", false);
            public static Box<IChoroplethmapboxProperty> _true() => Interop.mkChoroplethmapboxAttr("visible", true);
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IChoroplethmapboxProperty> all() => Interop.mkChoroplethmapboxAttr("hoverinfo", "all");
            public static Box<IChoroplethmapboxProperty> none() => Interop.mkChoroplethmapboxAttr("hoverinfo", "none");
            public static Box<IChoroplethmapboxProperty> skip() => Interop.mkChoroplethmapboxAttr("hoverinfo", "skip");
            public static Box<IChoroplethmapboxProperty> location() => Interop.mkChoroplethmapboxAttr("hoverinfo", "location");
            public static Box<IChoroplethmapboxProperty> name() => Interop.mkChoroplethmapboxAttr("hoverinfo", "name");
            public static Box<IChoroplethmapboxProperty> text() => Interop.mkChoroplethmapboxAttr("hoverinfo", "text");
            public static Box<IChoroplethmapboxProperty> z() => Interop.mkChoroplethmapboxAttr("hoverinfo", "z");
        }
    }
}