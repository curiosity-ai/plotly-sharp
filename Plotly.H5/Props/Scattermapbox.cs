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

    public static partial class Scattermapbox
    {
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IScattermapboxProperty> showlegend(bool val) => Interop.mkScattermapboxAttr("showlegend", val);
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IScattermapboxProperty> legendgroup(string val) => Interop.mkScattermapboxAttr("legendgroup", val);
        /// Sets the opacity of the trace.
        public static Box<IScattermapboxProperty> opacity(int val) => Interop.mkScattermapboxAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<IScattermapboxProperty> opacity(float val) => Interop.mkScattermapboxAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IScattermapboxProperty> name(string val) => Interop.mkScattermapboxAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IScattermapboxProperty> uid(string val) => Interop.mkScattermapboxAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattermapboxProperty> ids(bool val) => Interop.mkScattermapboxAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattermapboxProperty> ids(params bool[] values) => Interop.mkScattermapboxAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattermapboxProperty> ids(System.DateTime val) => Interop.mkScattermapboxAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattermapboxProperty> ids(params System.DateTime[] values) => Interop.mkScattermapboxAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattermapboxProperty> ids(float val) => Interop.mkScattermapboxAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattermapboxProperty> ids(params float[] values) => Interop.mkScattermapboxAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattermapboxProperty> ids(int val) => Interop.mkScattermapboxAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattermapboxProperty> ids(params int[] values) => Interop.mkScattermapboxAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattermapboxProperty> ids(string val) => Interop.mkScattermapboxAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattermapboxProperty> ids(params string[] values) => Interop.mkScattermapboxAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattermapboxProperty> ids(IEnumerable<bool[]> values) => Interop.mkScattermapboxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattermapboxProperty> ids(List<bool[]> values) => Interop.mkScattermapboxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattermapboxProperty> ids(params bool[][] values) => Interop.mkScattermapboxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattermapboxProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkScattermapboxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattermapboxProperty> ids(List<string[]> values) => Interop.mkScattermapboxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattermapboxProperty> ids(params string[][] values) => Interop.mkScattermapboxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattermapboxProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkScattermapboxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattermapboxProperty> ids(List<int[]> values) => Interop.mkScattermapboxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattermapboxProperty> ids(params int[][] values) => Interop.mkScattermapboxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattermapboxProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkScattermapboxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattermapboxProperty> ids(List<float[]> values) => Interop.mkScattermapboxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattermapboxProperty> ids(params float[][] values) => Interop.mkScattermapboxAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattermapboxProperty> ids(Literals.PlotData[] values) => Interop.mkScattermapboxAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattermapboxProperty> ids(IEnumerable<bool?> values) => Interop.mkScattermapboxAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattermapboxProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkScattermapboxAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattermapboxProperty> ids(IEnumerable<int?> values) => Interop.mkScattermapboxAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattermapboxProperty> ids(IEnumerable<float?> values) => Interop.mkScattermapboxAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattermapboxProperty> customdata(bool val) => Interop.mkScattermapboxAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattermapboxProperty> customdata(params bool[] values) => Interop.mkScattermapboxAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattermapboxProperty> customdata(System.DateTime val) => Interop.mkScattermapboxAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattermapboxProperty> customdata(params System.DateTime[] values) => Interop.mkScattermapboxAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattermapboxProperty> customdata(float val) => Interop.mkScattermapboxAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattermapboxProperty> customdata(params float[] values) => Interop.mkScattermapboxAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattermapboxProperty> customdata(int val) => Interop.mkScattermapboxAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattermapboxProperty> customdata(params int[] values) => Interop.mkScattermapboxAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattermapboxProperty> customdata(string val) => Interop.mkScattermapboxAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattermapboxProperty> customdata(params string[] values) => Interop.mkScattermapboxAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattermapboxProperty> customdata(IEnumerable<bool[]> values) => Interop.mkScattermapboxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattermapboxProperty> customdata(List<bool[]> values) => Interop.mkScattermapboxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattermapboxProperty> customdata(params bool[][] values) => Interop.mkScattermapboxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattermapboxProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkScattermapboxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattermapboxProperty> customdata(List<string[]> values) => Interop.mkScattermapboxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattermapboxProperty> customdata(params string[][] values) => Interop.mkScattermapboxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattermapboxProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkScattermapboxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattermapboxProperty> customdata(List<int[]> values) => Interop.mkScattermapboxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattermapboxProperty> customdata(params int[][] values) => Interop.mkScattermapboxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattermapboxProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkScattermapboxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattermapboxProperty> customdata(List<float[]> values) => Interop.mkScattermapboxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattermapboxProperty> customdata(params float[][] values) => Interop.mkScattermapboxAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattermapboxProperty> customdata(Literals.PlotData[] values) => Interop.mkScattermapboxAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattermapboxProperty> customdata(IEnumerable<bool?> values) => Interop.mkScattermapboxAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattermapboxProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkScattermapboxAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattermapboxProperty> customdata(IEnumerable<int?> values) => Interop.mkScattermapboxAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattermapboxProperty> customdata(IEnumerable<float?> values) => Interop.mkScattermapboxAttr("customdata", values.ToArray());
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattermapboxProperty> selectedpoints(bool val) => Interop.mkScattermapboxAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattermapboxProperty> selectedpoints(params bool[] values) => Interop.mkScattermapboxAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattermapboxProperty> selectedpoints(System.DateTime val) => Interop.mkScattermapboxAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattermapboxProperty> selectedpoints(params System.DateTime[] values) => Interop.mkScattermapboxAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattermapboxProperty> selectedpoints(int val) => Interop.mkScattermapboxAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattermapboxProperty> selectedpoints(params int[] values) => Interop.mkScattermapboxAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattermapboxProperty> selectedpoints(float val) => Interop.mkScattermapboxAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattermapboxProperty> selectedpoints(params float[] values) => Interop.mkScattermapboxAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattermapboxProperty> selectedpoints(string val) => Interop.mkScattermapboxAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattermapboxProperty> selectedpoints(params string[] values) => Interop.mkScattermapboxAttr("selectedpoints", values);
        public static Box<IScattermapboxProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkScattermapboxAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IScattermapboxProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkScattermapboxAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IScattermapboxProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkScattermapboxAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattermapboxProperty> uirevision(bool val) => Interop.mkScattermapboxAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattermapboxProperty> uirevision(params bool[] values) => Interop.mkScattermapboxAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattermapboxProperty> uirevision(System.DateTime val) => Interop.mkScattermapboxAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattermapboxProperty> uirevision(params System.DateTime[] values) => Interop.mkScattermapboxAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattermapboxProperty> uirevision(int val) => Interop.mkScattermapboxAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattermapboxProperty> uirevision(params int[] values) => Interop.mkScattermapboxAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattermapboxProperty> uirevision(float val) => Interop.mkScattermapboxAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattermapboxProperty> uirevision(params float[] values) => Interop.mkScattermapboxAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattermapboxProperty> uirevision(string val) => Interop.mkScattermapboxAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattermapboxProperty> uirevision(params string[] values) => Interop.mkScattermapboxAttr("uirevision", values);
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattermapboxProperty> lon(bool val) => Interop.mkScattermapboxAttr("lon", new[]{val});
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattermapboxProperty> lon(params bool[] values) => Interop.mkScattermapboxAttr("lon", values);
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattermapboxProperty> lon(System.DateTime val) => Interop.mkScattermapboxAttr("lon", new[]{val});
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattermapboxProperty> lon(params System.DateTime[] values) => Interop.mkScattermapboxAttr("lon", values);
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattermapboxProperty> lon(float val) => Interop.mkScattermapboxAttr("lon", new[]{val});
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattermapboxProperty> lon(params float[] values) => Interop.mkScattermapboxAttr("lon", values);
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattermapboxProperty> lon(int val) => Interop.mkScattermapboxAttr("lon", new[]{val});
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattermapboxProperty> lon(params int[] values) => Interop.mkScattermapboxAttr("lon", values);
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattermapboxProperty> lon(string val) => Interop.mkScattermapboxAttr("lon", new[]{val});
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattermapboxProperty> lon(params string[] values) => Interop.mkScattermapboxAttr("lon", values);
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattermapboxProperty> lon(IEnumerable<bool[]> values) => Interop.mkScattermapboxAttr("lon", Bindings.flatten2DArrayIf1D(values));
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattermapboxProperty> lon(List<bool[]> values) => Interop.mkScattermapboxAttr("lon", Bindings.flatten2DArrayIf1D(values));
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattermapboxProperty> lon(params bool[][] values) => Interop.mkScattermapboxAttr("lon", Bindings.flatten2DArrayIf1D(values));
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattermapboxProperty> lon(IEnumerable<IEnumerable<string>> values) => Interop.mkScattermapboxAttr("lon", Bindings.flatten2DArrayIf1D(values));
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattermapboxProperty> lon(List<string[]> values) => Interop.mkScattermapboxAttr("lon", Bindings.flatten2DArrayIf1D(values));
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattermapboxProperty> lon(params string[][] values) => Interop.mkScattermapboxAttr("lon", Bindings.flatten2DArrayIf1D(values));
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattermapboxProperty> lon(IEnumerable<IEnumerable<int>> values) => Interop.mkScattermapboxAttr("lon", Bindings.flatten2DArrayIf1D(values));
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattermapboxProperty> lon(List<int[]> values) => Interop.mkScattermapboxAttr("lon", Bindings.flatten2DArrayIf1D(values));
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattermapboxProperty> lon(params int[][] values) => Interop.mkScattermapboxAttr("lon", Bindings.flatten2DArrayIf1D(values));
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattermapboxProperty> lon(IEnumerable<IEnumerable<float>> values) => Interop.mkScattermapboxAttr("lon", Bindings.flatten2DArrayIf1D(values));
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattermapboxProperty> lon(List<float[]> values) => Interop.mkScattermapboxAttr("lon", Bindings.flatten2DArrayIf1D(values));
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattermapboxProperty> lon(params float[][] values) => Interop.mkScattermapboxAttr("lon", Bindings.flatten2DArrayIf1D(values));
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattermapboxProperty> lon(Literals.PlotData[] values) => Interop.mkScattermapboxAttr("lon", values);
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattermapboxProperty> lon(IEnumerable<bool?> values) => Interop.mkScattermapboxAttr("lon", values.ToArray());
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattermapboxProperty> lon(IEnumerable<System.DateTime?> values) => Interop.mkScattermapboxAttr("lon", values.ToArray());
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattermapboxProperty> lon(IEnumerable<int?> values) => Interop.mkScattermapboxAttr("lon", values.ToArray());
        /// Sets the longitude coordinates (in degrees East).
        public static Box<IScattermapboxProperty> lon(IEnumerable<float?> values) => Interop.mkScattermapboxAttr("lon", values.ToArray());
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattermapboxProperty> lat(bool val) => Interop.mkScattermapboxAttr("lat", new[]{val});
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattermapboxProperty> lat(params bool[] values) => Interop.mkScattermapboxAttr("lat", values);
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattermapboxProperty> lat(System.DateTime val) => Interop.mkScattermapboxAttr("lat", new[]{val});
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattermapboxProperty> lat(params System.DateTime[] values) => Interop.mkScattermapboxAttr("lat", values);
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattermapboxProperty> lat(float val) => Interop.mkScattermapboxAttr("lat", new[]{val});
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattermapboxProperty> lat(params float[] values) => Interop.mkScattermapboxAttr("lat", values);
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattermapboxProperty> lat(int val) => Interop.mkScattermapboxAttr("lat", new[]{val});
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattermapboxProperty> lat(params int[] values) => Interop.mkScattermapboxAttr("lat", values);
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattermapboxProperty> lat(string val) => Interop.mkScattermapboxAttr("lat", new[]{val});
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattermapboxProperty> lat(params string[] values) => Interop.mkScattermapboxAttr("lat", values);
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattermapboxProperty> lat(IEnumerable<bool[]> values) => Interop.mkScattermapboxAttr("lat", Bindings.flatten2DArrayIf1D(values));
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattermapboxProperty> lat(List<bool[]> values) => Interop.mkScattermapboxAttr("lat", Bindings.flatten2DArrayIf1D(values));
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattermapboxProperty> lat(params bool[][] values) => Interop.mkScattermapboxAttr("lat", Bindings.flatten2DArrayIf1D(values));
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattermapboxProperty> lat(IEnumerable<IEnumerable<string>> values) => Interop.mkScattermapboxAttr("lat", Bindings.flatten2DArrayIf1D(values));
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattermapboxProperty> lat(List<string[]> values) => Interop.mkScattermapboxAttr("lat", Bindings.flatten2DArrayIf1D(values));
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattermapboxProperty> lat(params string[][] values) => Interop.mkScattermapboxAttr("lat", Bindings.flatten2DArrayIf1D(values));
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattermapboxProperty> lat(IEnumerable<IEnumerable<int>> values) => Interop.mkScattermapboxAttr("lat", Bindings.flatten2DArrayIf1D(values));
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattermapboxProperty> lat(List<int[]> values) => Interop.mkScattermapboxAttr("lat", Bindings.flatten2DArrayIf1D(values));
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattermapboxProperty> lat(params int[][] values) => Interop.mkScattermapboxAttr("lat", Bindings.flatten2DArrayIf1D(values));
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattermapboxProperty> lat(IEnumerable<IEnumerable<float>> values) => Interop.mkScattermapboxAttr("lat", Bindings.flatten2DArrayIf1D(values));
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattermapboxProperty> lat(List<float[]> values) => Interop.mkScattermapboxAttr("lat", Bindings.flatten2DArrayIf1D(values));
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattermapboxProperty> lat(params float[][] values) => Interop.mkScattermapboxAttr("lat", Bindings.flatten2DArrayIf1D(values));
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattermapboxProperty> lat(Literals.PlotData[] values) => Interop.mkScattermapboxAttr("lat", values);
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattermapboxProperty> lat(IEnumerable<bool?> values) => Interop.mkScattermapboxAttr("lat", values.ToArray());
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattermapboxProperty> lat(IEnumerable<System.DateTime?> values) => Interop.mkScattermapboxAttr("lat", values.ToArray());
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattermapboxProperty> lat(IEnumerable<int?> values) => Interop.mkScattermapboxAttr("lat", values.ToArray());
        /// Sets the latitude coordinates (in degrees North).
        public static Box<IScattermapboxProperty> lat(IEnumerable<float?> values) => Interop.mkScattermapboxAttr("lat", values.ToArray());
        /// Determines the drawing mode for this scatter trace. If the provided `mode` includes *text* then the `text` elements appear at the coordinates. Otherwise, the `text` elements appear on hover.
        public static Box<IScattermapboxProperty> mode(params Box<IScattermapboxProperty>[] properties) => Interop.mkScattermapboxAttr("mode", Bindings.joinEnumProperties(properties));
        /// Sets text elements associated with each (lon,lat) pair If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (lon,lat) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IScattermapboxProperty> text(string val) => Interop.mkScattermapboxAttr("text", val);
        /// Sets text elements associated with each (lon,lat) pair If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (lon,lat) coordinates. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IScattermapboxProperty> text(IEnumerable<string> values) => Interop.mkScattermapboxAttr("text", values.ToArray());
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `lat`, `lon` and `text`.
        public static Box<IScattermapboxProperty> texttemplate(string val) => Interop.mkScattermapboxAttr("texttemplate", val);
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `lat`, `lon` and `text`.
        public static Box<IScattermapboxProperty> texttemplate(IEnumerable<string> values) => Interop.mkScattermapboxAttr("texttemplate", values.ToArray());
        /// Sets hover text elements associated with each (lon,lat) pair If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (lon,lat) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IScattermapboxProperty> hovertext(string val) => Interop.mkScattermapboxAttr("hovertext", val);
        /// Sets hover text elements associated with each (lon,lat) pair If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to the this trace's (lon,lat) coordinates. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IScattermapboxProperty> hovertext(IEnumerable<string> values) => Interop.mkScattermapboxAttr("hovertext", values.ToArray());
        public static Box<IScattermapboxProperty> line(params Box<ILineProperty>[] properties) => Interop.mkScattermapboxAttr("line", Bindings.flattenProperties(properties));
        /// Determines whether or not gaps (i.e. {nan} or missing values) in the provided data arrays are connected.
        public static Box<IScattermapboxProperty> connectgaps(bool val) => Interop.mkScattermapboxAttr("connectgaps", val);
        public static Box<IScattermapboxProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkScattermapboxAttr("marker", Bindings.flattenProperties(properties));
        /// Sets the fill color. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
        public static Box<IScattermapboxProperty> fillcolor(string val) => Interop.mkScattermapboxAttr("fillcolor", val);
        /// Sets the icon text font (color=mapbox.layer.paint.text-color, size=mapbox.layer.layout.text-size). Has an effect only when `type` is set to *symbol*.
        public static Box<IScattermapboxProperty> textfont(params Box<ITextfontProperty>[] properties) => Interop.mkScattermapboxAttr("textfont", Bindings.flattenProperties(properties));
        /// Determines if this scattermapbox trace's layers are to be inserted before the layer with the specified ID. By default, scattermapbox layers are inserted above all the base layers. To place the scattermapbox layers above every other layer, set `below` to *''*.
        public static Box<IScattermapboxProperty> below(string val) => Interop.mkScattermapboxAttr("below", val);
        public static Box<IScattermapboxProperty> selected(params Box<ISelectedProperty>[] properties) => Interop.mkScattermapboxAttr("selected", Bindings.flattenProperties(properties));
        public static Box<IScattermapboxProperty> unselected(params Box<IUnselectedProperty>[] properties) => Interop.mkScattermapboxAttr("unselected", Bindings.flattenProperties(properties));
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IScattermapboxProperty> hoverinfo(params Box<IScattermapboxProperty>[] properties) => Interop.mkScattermapboxAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IScattermapboxProperty> hovertemplate(string val) => Interop.mkScattermapboxAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IScattermapboxProperty> hovertemplate(IEnumerable<string> values) => Interop.mkScattermapboxAttr("hovertemplate", values.ToArray());
        /// Sets a reference between this trace's data coordinates and a mapbox subplot. If *mapbox* (the default value), the data refer to `layout.mapbox`. If *mapbox2*, the data refer to `layout.mapbox2`, and so on.
        public static Box<IScattermapboxProperty> subplot(int anchorId) => Interop.mkScattermapboxAttr("subplot", anchorId > 1 ? $"mapbox{anchorId}" : "");
        /// Sets a reference between this trace's data coordinates and a mapbox subplot. If *mapbox* (the default value), the data refer to `layout.mapbox`. If *mapbox2*, the data refer to `layout.mapbox2`, and so on.
        public static Box<IScattermapboxProperty> subplot(string val) => Interop.mkScattermapboxAttr("subplot", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IScattermapboxProperty> idssrc(string val) => Interop.mkScattermapboxAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IScattermapboxProperty> customdatasrc(string val) => Interop.mkScattermapboxAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IScattermapboxProperty> metasrc(string val) => Interop.mkScattermapboxAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  lon .
        public static Box<IScattermapboxProperty> lonsrc(string val) => Interop.mkScattermapboxAttr("lonsrc", val);
        /// Sets the source reference on plot.ly for  lat .
        public static Box<IScattermapboxProperty> latsrc(string val) => Interop.mkScattermapboxAttr("latsrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IScattermapboxProperty> textsrc(string val) => Interop.mkScattermapboxAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  texttemplate .
        public static Box<IScattermapboxProperty> texttemplatesrc(string val) => Interop.mkScattermapboxAttr("texttemplatesrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IScattermapboxProperty> hovertextsrc(string val) => Interop.mkScattermapboxAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IScattermapboxProperty> hoverinfosrc(string val) => Interop.mkScattermapboxAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IScattermapboxProperty> hovertemplatesrc(string val) => Interop.mkScattermapboxAttr("hovertemplatesrc", val);
    }

    public static partial class Scattermapbox
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IScattermapboxProperty> legendonly() => Interop.mkScattermapboxAttr("visible", "legendonly");
            public static Box<IScattermapboxProperty> _false() => Interop.mkScattermapboxAttr("visible", false);
            public static Box<IScattermapboxProperty> _true() => Interop.mkScattermapboxAttr("visible", true);
        }

        /// Determines the drawing mode for this scatter trace. If the provided `mode` includes *text* then the `text` elements appear at the coordinates. Otherwise, the `text` elements appear on hover.
        public static partial class Mode
        {
            public static Box<IScattermapboxProperty> none() => Interop.mkScattermapboxAttr("mode", "none");
            public static Box<IScattermapboxProperty> lines() => Interop.mkScattermapboxAttr("mode", "lines");
            public static Box<IScattermapboxProperty> markers() => Interop.mkScattermapboxAttr("mode", "markers");
            public static Box<IScattermapboxProperty> text() => Interop.mkScattermapboxAttr("mode", "text");
        }

        /// Sets the area to fill with a solid color. Use with `fillcolor` if not *none*. *toself* connects the endpoints of the trace (or each segment of the trace if it has gaps) into a closed shape.
        public static partial class Fill
        {
            public static Box<IScattermapboxProperty> none() => Interop.mkScattermapboxAttr("fill", "none");
            public static Box<IScattermapboxProperty> toself() => Interop.mkScattermapboxAttr("fill", "toself");
        }

        /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
        public static partial class Textposition
        {
            public static Box<IScattermapboxProperty> bottomCenter() => Interop.mkScattermapboxAttr("textposition", "bottom center");
            public static Box<IScattermapboxProperty> bottomLeft() => Interop.mkScattermapboxAttr("textposition", "bottom left");
            public static Box<IScattermapboxProperty> bottomRight() => Interop.mkScattermapboxAttr("textposition", "bottom right");
            public static Box<IScattermapboxProperty> middleCenter() => Interop.mkScattermapboxAttr("textposition", "middle center");
            public static Box<IScattermapboxProperty> middleLeft() => Interop.mkScattermapboxAttr("textposition", "middle left");
            public static Box<IScattermapboxProperty> middleRight() => Interop.mkScattermapboxAttr("textposition", "middle right");
            public static Box<IScattermapboxProperty> topCenter() => Interop.mkScattermapboxAttr("textposition", "top center");
            public static Box<IScattermapboxProperty> topLeft() => Interop.mkScattermapboxAttr("textposition", "top left");
            public static Box<IScattermapboxProperty> topRight() => Interop.mkScattermapboxAttr("textposition", "top right");
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IScattermapboxProperty> all() => Interop.mkScattermapboxAttr("hoverinfo", "all");
            public static Box<IScattermapboxProperty> none() => Interop.mkScattermapboxAttr("hoverinfo", "none");
            public static Box<IScattermapboxProperty> skip() => Interop.mkScattermapboxAttr("hoverinfo", "skip");
            public static Box<IScattermapboxProperty> lat() => Interop.mkScattermapboxAttr("hoverinfo", "lat");
            public static Box<IScattermapboxProperty> lon() => Interop.mkScattermapboxAttr("hoverinfo", "lon");
            public static Box<IScattermapboxProperty> name() => Interop.mkScattermapboxAttr("hoverinfo", "name");
            public static Box<IScattermapboxProperty> text() => Interop.mkScattermapboxAttr("hoverinfo", "text");
        }
    }
}