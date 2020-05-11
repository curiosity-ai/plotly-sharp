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

    public static partial class Scattercarpet
    {
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IScattercarpetProperty> showlegend(bool val) => Interop.mkScattercarpetAttr("showlegend", val);
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IScattercarpetProperty> legendgroup(string val) => Interop.mkScattercarpetAttr("legendgroup", val);
        /// Sets the opacity of the trace.
        public static Box<IScattercarpetProperty> opacity(int val) => Interop.mkScattercarpetAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<IScattercarpetProperty> opacity(float val) => Interop.mkScattercarpetAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IScattercarpetProperty> name(string val) => Interop.mkScattercarpetAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IScattercarpetProperty> uid(string val) => Interop.mkScattercarpetAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattercarpetProperty> ids(bool val) => Interop.mkScattercarpetAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattercarpetProperty> ids(params bool[] values) => Interop.mkScattercarpetAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattercarpetProperty> ids(System.DateTime val) => Interop.mkScattercarpetAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattercarpetProperty> ids(params System.DateTime[] values) => Interop.mkScattercarpetAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattercarpetProperty> ids(float val) => Interop.mkScattercarpetAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattercarpetProperty> ids(params float[] values) => Interop.mkScattercarpetAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattercarpetProperty> ids(int val) => Interop.mkScattercarpetAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattercarpetProperty> ids(params int[] values) => Interop.mkScattercarpetAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattercarpetProperty> ids(string val) => Interop.mkScattercarpetAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattercarpetProperty> ids(params string[] values) => Interop.mkScattercarpetAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattercarpetProperty> ids(IEnumerable<bool[]> values) => Interop.mkScattercarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattercarpetProperty> ids(List<bool[]> values) => Interop.mkScattercarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattercarpetProperty> ids(params bool[][] values) => Interop.mkScattercarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattercarpetProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkScattercarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattercarpetProperty> ids(List<string[]> values) => Interop.mkScattercarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattercarpetProperty> ids(params string[][] values) => Interop.mkScattercarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattercarpetProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkScattercarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattercarpetProperty> ids(List<int[]> values) => Interop.mkScattercarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattercarpetProperty> ids(params int[][] values) => Interop.mkScattercarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattercarpetProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkScattercarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattercarpetProperty> ids(List<float[]> values) => Interop.mkScattercarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattercarpetProperty> ids(params float[][] values) => Interop.mkScattercarpetAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattercarpetProperty> ids(Literals.PlotData[] values) => Interop.mkScattercarpetAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattercarpetProperty> ids(IEnumerable<bool?> values) => Interop.mkScattercarpetAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattercarpetProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkScattercarpetAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattercarpetProperty> ids(IEnumerable<int?> values) => Interop.mkScattercarpetAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IScattercarpetProperty> ids(IEnumerable<float?> values) => Interop.mkScattercarpetAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattercarpetProperty> customdata(bool val) => Interop.mkScattercarpetAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattercarpetProperty> customdata(params bool[] values) => Interop.mkScattercarpetAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattercarpetProperty> customdata(System.DateTime val) => Interop.mkScattercarpetAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattercarpetProperty> customdata(params System.DateTime[] values) => Interop.mkScattercarpetAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattercarpetProperty> customdata(float val) => Interop.mkScattercarpetAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattercarpetProperty> customdata(params float[] values) => Interop.mkScattercarpetAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattercarpetProperty> customdata(int val) => Interop.mkScattercarpetAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattercarpetProperty> customdata(params int[] values) => Interop.mkScattercarpetAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattercarpetProperty> customdata(string val) => Interop.mkScattercarpetAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattercarpetProperty> customdata(params string[] values) => Interop.mkScattercarpetAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattercarpetProperty> customdata(IEnumerable<bool[]> values) => Interop.mkScattercarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattercarpetProperty> customdata(List<bool[]> values) => Interop.mkScattercarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattercarpetProperty> customdata(params bool[][] values) => Interop.mkScattercarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattercarpetProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkScattercarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattercarpetProperty> customdata(List<string[]> values) => Interop.mkScattercarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattercarpetProperty> customdata(params string[][] values) => Interop.mkScattercarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattercarpetProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkScattercarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattercarpetProperty> customdata(List<int[]> values) => Interop.mkScattercarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattercarpetProperty> customdata(params int[][] values) => Interop.mkScattercarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattercarpetProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkScattercarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattercarpetProperty> customdata(List<float[]> values) => Interop.mkScattercarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattercarpetProperty> customdata(params float[][] values) => Interop.mkScattercarpetAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattercarpetProperty> customdata(Literals.PlotData[] values) => Interop.mkScattercarpetAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattercarpetProperty> customdata(IEnumerable<bool?> values) => Interop.mkScattercarpetAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattercarpetProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkScattercarpetAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattercarpetProperty> customdata(IEnumerable<int?> values) => Interop.mkScattercarpetAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IScattercarpetProperty> customdata(IEnumerable<float?> values) => Interop.mkScattercarpetAttr("customdata", values.ToArray());
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattercarpetProperty> selectedpoints(bool val) => Interop.mkScattercarpetAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattercarpetProperty> selectedpoints(params bool[] values) => Interop.mkScattercarpetAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattercarpetProperty> selectedpoints(System.DateTime val) => Interop.mkScattercarpetAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattercarpetProperty> selectedpoints(params System.DateTime[] values) => Interop.mkScattercarpetAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattercarpetProperty> selectedpoints(int val) => Interop.mkScattercarpetAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattercarpetProperty> selectedpoints(params int[] values) => Interop.mkScattercarpetAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattercarpetProperty> selectedpoints(float val) => Interop.mkScattercarpetAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattercarpetProperty> selectedpoints(params float[] values) => Interop.mkScattercarpetAttr("selectedpoints", values);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattercarpetProperty> selectedpoints(string val) => Interop.mkScattercarpetAttr("selectedpoints", val);
        /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
        public static Box<IScattercarpetProperty> selectedpoints(params string[] values) => Interop.mkScattercarpetAttr("selectedpoints", values);
        public static Box<IScattercarpetProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkScattercarpetAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IScattercarpetProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkScattercarpetAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IScattercarpetProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkScattercarpetAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattercarpetProperty> uirevision(bool val) => Interop.mkScattercarpetAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattercarpetProperty> uirevision(params bool[] values) => Interop.mkScattercarpetAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattercarpetProperty> uirevision(System.DateTime val) => Interop.mkScattercarpetAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattercarpetProperty> uirevision(params System.DateTime[] values) => Interop.mkScattercarpetAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattercarpetProperty> uirevision(int val) => Interop.mkScattercarpetAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattercarpetProperty> uirevision(params int[] values) => Interop.mkScattercarpetAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattercarpetProperty> uirevision(float val) => Interop.mkScattercarpetAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattercarpetProperty> uirevision(params float[] values) => Interop.mkScattercarpetAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattercarpetProperty> uirevision(string val) => Interop.mkScattercarpetAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IScattercarpetProperty> uirevision(params string[] values) => Interop.mkScattercarpetAttr("uirevision", values);
        /// An identifier for this carpet, so that `scattercarpet` and `contourcarpet` traces can specify a carpet plot on which they lie
        public static Box<IScattercarpetProperty> carpet(string val) => Interop.mkScattercarpetAttr("carpet", val);
        /// Sets the a-axis coordinates.
        public static Box<IScattercarpetProperty> a(bool val) => Interop.mkScattercarpetAttr("a", new[]{val});
        /// Sets the a-axis coordinates.
        public static Box<IScattercarpetProperty> a(params bool[] values) => Interop.mkScattercarpetAttr("a", values);
        /// Sets the a-axis coordinates.
        public static Box<IScattercarpetProperty> a(System.DateTime val) => Interop.mkScattercarpetAttr("a", new[]{val});
        /// Sets the a-axis coordinates.
        public static Box<IScattercarpetProperty> a(params System.DateTime[] values) => Interop.mkScattercarpetAttr("a", values);
        /// Sets the a-axis coordinates.
        public static Box<IScattercarpetProperty> a(float val) => Interop.mkScattercarpetAttr("a", new[]{val});
        /// Sets the a-axis coordinates.
        public static Box<IScattercarpetProperty> a(params float[] values) => Interop.mkScattercarpetAttr("a", values);
        /// Sets the a-axis coordinates.
        public static Box<IScattercarpetProperty> a(int val) => Interop.mkScattercarpetAttr("a", new[]{val});
        /// Sets the a-axis coordinates.
        public static Box<IScattercarpetProperty> a(params int[] values) => Interop.mkScattercarpetAttr("a", values);
        /// Sets the a-axis coordinates.
        public static Box<IScattercarpetProperty> a(string val) => Interop.mkScattercarpetAttr("a", new[]{val});
        /// Sets the a-axis coordinates.
        public static Box<IScattercarpetProperty> a(params string[] values) => Interop.mkScattercarpetAttr("a", values);
        /// Sets the a-axis coordinates.
        public static Box<IScattercarpetProperty> a(IEnumerable<bool[]> values) => Interop.mkScattercarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the a-axis coordinates.
        public static Box<IScattercarpetProperty> a(List<bool[]> values) => Interop.mkScattercarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the a-axis coordinates.
        public static Box<IScattercarpetProperty> a(params bool[][] values) => Interop.mkScattercarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the a-axis coordinates.
        public static Box<IScattercarpetProperty> a(IEnumerable<IEnumerable<string>> values) => Interop.mkScattercarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the a-axis coordinates.
        public static Box<IScattercarpetProperty> a(List<string[]> values) => Interop.mkScattercarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the a-axis coordinates.
        public static Box<IScattercarpetProperty> a(params string[][] values) => Interop.mkScattercarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the a-axis coordinates.
        public static Box<IScattercarpetProperty> a(IEnumerable<IEnumerable<int>> values) => Interop.mkScattercarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the a-axis coordinates.
        public static Box<IScattercarpetProperty> a(List<int[]> values) => Interop.mkScattercarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the a-axis coordinates.
        public static Box<IScattercarpetProperty> a(params int[][] values) => Interop.mkScattercarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the a-axis coordinates.
        public static Box<IScattercarpetProperty> a(IEnumerable<IEnumerable<float>> values) => Interop.mkScattercarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the a-axis coordinates.
        public static Box<IScattercarpetProperty> a(List<float[]> values) => Interop.mkScattercarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the a-axis coordinates.
        public static Box<IScattercarpetProperty> a(params float[][] values) => Interop.mkScattercarpetAttr("a", Bindings.flatten2DArrayIf1D(values));
        /// Sets the a-axis coordinates.
        public static Box<IScattercarpetProperty> a(Literals.PlotData[] values) => Interop.mkScattercarpetAttr("a", values);
        /// Sets the a-axis coordinates.
        public static Box<IScattercarpetProperty> a(IEnumerable<bool?> values) => Interop.mkScattercarpetAttr("a", values.ToArray());
        /// Sets the a-axis coordinates.
        public static Box<IScattercarpetProperty> a(IEnumerable<System.DateTime?> values) => Interop.mkScattercarpetAttr("a", values.ToArray());
        /// Sets the a-axis coordinates.
        public static Box<IScattercarpetProperty> a(IEnumerable<int?> values) => Interop.mkScattercarpetAttr("a", values.ToArray());
        /// Sets the a-axis coordinates.
        public static Box<IScattercarpetProperty> a(IEnumerable<float?> values) => Interop.mkScattercarpetAttr("a", values.ToArray());
        /// Sets the b-axis coordinates.
        public static Box<IScattercarpetProperty> b(bool val) => Interop.mkScattercarpetAttr("b", new[]{val});
        /// Sets the b-axis coordinates.
        public static Box<IScattercarpetProperty> b(params bool[] values) => Interop.mkScattercarpetAttr("b", values);
        /// Sets the b-axis coordinates.
        public static Box<IScattercarpetProperty> b(System.DateTime val) => Interop.mkScattercarpetAttr("b", new[]{val});
        /// Sets the b-axis coordinates.
        public static Box<IScattercarpetProperty> b(params System.DateTime[] values) => Interop.mkScattercarpetAttr("b", values);
        /// Sets the b-axis coordinates.
        public static Box<IScattercarpetProperty> b(float val) => Interop.mkScattercarpetAttr("b", new[]{val});
        /// Sets the b-axis coordinates.
        public static Box<IScattercarpetProperty> b(params float[] values) => Interop.mkScattercarpetAttr("b", values);
        /// Sets the b-axis coordinates.
        public static Box<IScattercarpetProperty> b(int val) => Interop.mkScattercarpetAttr("b", new[]{val});
        /// Sets the b-axis coordinates.
        public static Box<IScattercarpetProperty> b(params int[] values) => Interop.mkScattercarpetAttr("b", values);
        /// Sets the b-axis coordinates.
        public static Box<IScattercarpetProperty> b(string val) => Interop.mkScattercarpetAttr("b", new[]{val});
        /// Sets the b-axis coordinates.
        public static Box<IScattercarpetProperty> b(params string[] values) => Interop.mkScattercarpetAttr("b", values);
        /// Sets the b-axis coordinates.
        public static Box<IScattercarpetProperty> b(IEnumerable<bool[]> values) => Interop.mkScattercarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the b-axis coordinates.
        public static Box<IScattercarpetProperty> b(List<bool[]> values) => Interop.mkScattercarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the b-axis coordinates.
        public static Box<IScattercarpetProperty> b(params bool[][] values) => Interop.mkScattercarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the b-axis coordinates.
        public static Box<IScattercarpetProperty> b(IEnumerable<IEnumerable<string>> values) => Interop.mkScattercarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the b-axis coordinates.
        public static Box<IScattercarpetProperty> b(List<string[]> values) => Interop.mkScattercarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the b-axis coordinates.
        public static Box<IScattercarpetProperty> b(params string[][] values) => Interop.mkScattercarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the b-axis coordinates.
        public static Box<IScattercarpetProperty> b(IEnumerable<IEnumerable<int>> values) => Interop.mkScattercarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the b-axis coordinates.
        public static Box<IScattercarpetProperty> b(List<int[]> values) => Interop.mkScattercarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the b-axis coordinates.
        public static Box<IScattercarpetProperty> b(params int[][] values) => Interop.mkScattercarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the b-axis coordinates.
        public static Box<IScattercarpetProperty> b(IEnumerable<IEnumerable<float>> values) => Interop.mkScattercarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the b-axis coordinates.
        public static Box<IScattercarpetProperty> b(List<float[]> values) => Interop.mkScattercarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the b-axis coordinates.
        public static Box<IScattercarpetProperty> b(params float[][] values) => Interop.mkScattercarpetAttr("b", Bindings.flatten2DArrayIf1D(values));
        /// Sets the b-axis coordinates.
        public static Box<IScattercarpetProperty> b(Literals.PlotData[] values) => Interop.mkScattercarpetAttr("b", values);
        /// Sets the b-axis coordinates.
        public static Box<IScattercarpetProperty> b(IEnumerable<bool?> values) => Interop.mkScattercarpetAttr("b", values.ToArray());
        /// Sets the b-axis coordinates.
        public static Box<IScattercarpetProperty> b(IEnumerable<System.DateTime?> values) => Interop.mkScattercarpetAttr("b", values.ToArray());
        /// Sets the b-axis coordinates.
        public static Box<IScattercarpetProperty> b(IEnumerable<int?> values) => Interop.mkScattercarpetAttr("b", values.ToArray());
        /// Sets the b-axis coordinates.
        public static Box<IScattercarpetProperty> b(IEnumerable<float?> values) => Interop.mkScattercarpetAttr("b", values.ToArray());
        /// Determines the drawing mode for this scatter trace. If the provided `mode` includes *text* then the `text` elements appear at the coordinates. Otherwise, the `text` elements appear on hover. If there are less than 20 points and the trace is not stacked then the default is *lines+markers*. Otherwise, *lines*.
        public static Box<IScattercarpetProperty> mode(params Box<IScattercarpetProperty>[] properties) => Interop.mkScattercarpetAttr("mode", Bindings.joinEnumProperties(properties));
        /// Sets text elements associated with each (a,b) point. If a single string, the same string appears over all the data points. If an array of strings, the items are mapped in order to the the data points in (a,b). If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IScattercarpetProperty> text(string val) => Interop.mkScattercarpetAttr("text", val);
        /// Sets text elements associated with each (a,b) point. If a single string, the same string appears over all the data points. If an array of strings, the items are mapped in order to the the data points in (a,b). If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IScattercarpetProperty> text(IEnumerable<string> values) => Interop.mkScattercarpetAttr("text", values.ToArray());
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `a`, `b` and `text`.
        public static Box<IScattercarpetProperty> texttemplate(string val) => Interop.mkScattercarpetAttr("texttemplate", val);
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `a`, `b` and `text`.
        public static Box<IScattercarpetProperty> texttemplate(IEnumerable<string> values) => Interop.mkScattercarpetAttr("texttemplate", values.ToArray());
        /// Sets hover text elements associated with each (a,b) point. If a single string, the same string appears over all the data points. If an array of strings, the items are mapped in order to the the data points in (a,b). To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IScattercarpetProperty> hovertext(string val) => Interop.mkScattercarpetAttr("hovertext", val);
        /// Sets hover text elements associated with each (a,b) point. If a single string, the same string appears over all the data points. If an array of strings, the items are mapped in order to the the data points in (a,b). To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IScattercarpetProperty> hovertext(IEnumerable<string> values) => Interop.mkScattercarpetAttr("hovertext", values.ToArray());
        public static Box<IScattercarpetProperty> line(params Box<ILineProperty>[] properties) => Interop.mkScattercarpetAttr("line", Bindings.flattenProperties(properties));
        /// Determines whether or not gaps (i.e. {nan} or missing values) in the provided data arrays are connected.
        public static Box<IScattercarpetProperty> connectgaps(bool val) => Interop.mkScattercarpetAttr("connectgaps", val);
        /// Sets the fill color. Defaults to a half-transparent variant of the line color, marker color, or marker line color, whichever is available.
        public static Box<IScattercarpetProperty> fillcolor(string val) => Interop.mkScattercarpetAttr("fillcolor", val);
        public static Box<IScattercarpetProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkScattercarpetAttr("marker", Bindings.flattenProperties(properties));
        /// Sets the text font.
        public static Box<IScattercarpetProperty> textfont(params Box<ITextfontProperty>[] properties) => Interop.mkScattercarpetAttr("textfont", Bindings.flattenProperties(properties));
        /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
        public static Box<IScattercarpetProperty> textposition(IEnumerable<Box<IScattercarpetProperty>> properties) => Interop.mkScattercarpetAttr("textposition", Bindings.flattenProperties(properties));
        public static Box<IScattercarpetProperty> selected(params Box<ISelectedProperty>[] properties) => Interop.mkScattercarpetAttr("selected", Bindings.flattenProperties(properties));
        public static Box<IScattercarpetProperty> unselected(params Box<IUnselectedProperty>[] properties) => Interop.mkScattercarpetAttr("unselected", Bindings.flattenProperties(properties));
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IScattercarpetProperty> hoverinfo(params Box<IScattercarpetProperty>[] properties) => Interop.mkScattercarpetAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        /// Do the hover effects highlight individual points (markers or line points) or do they highlight filled regions? If the fill is *toself* or *tonext* and there are no markers or text, then the default is *fills*, otherwise it is *points*.
        public static Box<IScattercarpetProperty> hoveron(params Box<IScattercarpetProperty>[] properties) => Interop.mkScattercarpetAttr("hoveron", Bindings.joinEnumProperties(properties));
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IScattercarpetProperty> hovertemplate(string val) => Interop.mkScattercarpetAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available.  Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IScattercarpetProperty> hovertemplate(IEnumerable<string> values) => Interop.mkScattercarpetAttr("hovertemplate", values.ToArray());
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IScattercarpetProperty> xaxis(int anchorId) => Interop.mkScattercarpetAttr("xaxis", anchorId > 1 ? $"x{anchorId}" : "");
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IScattercarpetProperty> xaxis(string val) => Interop.mkScattercarpetAttr("xaxis", val);
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IScattercarpetProperty> yaxis(int anchorId) => Interop.mkScattercarpetAttr("yaxis", anchorId > 1 ? $"y{anchorId}" : "");
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IScattercarpetProperty> yaxis(string val) => Interop.mkScattercarpetAttr("yaxis", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IScattercarpetProperty> idssrc(string val) => Interop.mkScattercarpetAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IScattercarpetProperty> customdatasrc(string val) => Interop.mkScattercarpetAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IScattercarpetProperty> metasrc(string val) => Interop.mkScattercarpetAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  a .
        public static Box<IScattercarpetProperty> asrc(string val) => Interop.mkScattercarpetAttr("asrc", val);
        /// Sets the source reference on plot.ly for  b .
        public static Box<IScattercarpetProperty> bsrc(string val) => Interop.mkScattercarpetAttr("bsrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IScattercarpetProperty> textsrc(string val) => Interop.mkScattercarpetAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  texttemplate .
        public static Box<IScattercarpetProperty> texttemplatesrc(string val) => Interop.mkScattercarpetAttr("texttemplatesrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IScattercarpetProperty> hovertextsrc(string val) => Interop.mkScattercarpetAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  textposition .
        public static Box<IScattercarpetProperty> textpositionsrc(string val) => Interop.mkScattercarpetAttr("textpositionsrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IScattercarpetProperty> hoverinfosrc(string val) => Interop.mkScattercarpetAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IScattercarpetProperty> hovertemplatesrc(string val) => Interop.mkScattercarpetAttr("hovertemplatesrc", val);
    }

    public static partial class Scattercarpet
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IScattercarpetProperty> legendonly() => Interop.mkScattercarpetAttr("visible", "legendonly");
            public static Box<IScattercarpetProperty> _false() => Interop.mkScattercarpetAttr("visible", false);
            public static Box<IScattercarpetProperty> _true() => Interop.mkScattercarpetAttr("visible", true);
        }

        /// Determines the drawing mode for this scatter trace. If the provided `mode` includes *text* then the `text` elements appear at the coordinates. Otherwise, the `text` elements appear on hover. If there are less than 20 points and the trace is not stacked then the default is *lines+markers*. Otherwise, *lines*.
        public static partial class Mode
        {
            public static Box<IScattercarpetProperty> none() => Interop.mkScattercarpetAttr("mode", "none");
            public static Box<IScattercarpetProperty> lines() => Interop.mkScattercarpetAttr("mode", "lines");
            public static Box<IScattercarpetProperty> markers() => Interop.mkScattercarpetAttr("mode", "markers");
            public static Box<IScattercarpetProperty> text() => Interop.mkScattercarpetAttr("mode", "text");
        }

        /// Sets the area to fill with a solid color. Use with `fillcolor` if not *none*. scatterternary has a subset of the options available to scatter. *toself* connects the endpoints of the trace (or each segment of the trace if it has gaps) into a closed shape. *tonext* fills the space between two traces if one completely encloses the other (eg consecutive contour lines), and behaves like *toself* if there is no trace before it. *tonext* should not be used if one trace does not enclose the other.
        public static partial class Fill
        {
            public static Box<IScattercarpetProperty> none() => Interop.mkScattercarpetAttr("fill", "none");
            public static Box<IScattercarpetProperty> tonext() => Interop.mkScattercarpetAttr("fill", "tonext");
            public static Box<IScattercarpetProperty> toself() => Interop.mkScattercarpetAttr("fill", "toself");
        }

        /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
        public static partial class Textposition
        {
            public static Box<IScattercarpetProperty> bottomCenter() => Interop.mkScattercarpetAttr("textposition", "bottom center");
            public static Box<IScattercarpetProperty> bottomLeft() => Interop.mkScattercarpetAttr("textposition", "bottom left");
            public static Box<IScattercarpetProperty> bottomRight() => Interop.mkScattercarpetAttr("textposition", "bottom right");
            public static Box<IScattercarpetProperty> middleCenter() => Interop.mkScattercarpetAttr("textposition", "middle center");
            public static Box<IScattercarpetProperty> middleLeft() => Interop.mkScattercarpetAttr("textposition", "middle left");
            public static Box<IScattercarpetProperty> middleRight() => Interop.mkScattercarpetAttr("textposition", "middle right");
            public static Box<IScattercarpetProperty> topCenter() => Interop.mkScattercarpetAttr("textposition", "top center");
            public static Box<IScattercarpetProperty> topLeft() => Interop.mkScattercarpetAttr("textposition", "top left");
            public static Box<IScattercarpetProperty> topRight() => Interop.mkScattercarpetAttr("textposition", "top right");
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IScattercarpetProperty> all() => Interop.mkScattercarpetAttr("hoverinfo", "all");
            public static Box<IScattercarpetProperty> none() => Interop.mkScattercarpetAttr("hoverinfo", "none");
            public static Box<IScattercarpetProperty> skip() => Interop.mkScattercarpetAttr("hoverinfo", "skip");
            public static Box<IScattercarpetProperty> a() => Interop.mkScattercarpetAttr("hoverinfo", "a");
            public static Box<IScattercarpetProperty> b() => Interop.mkScattercarpetAttr("hoverinfo", "b");
            public static Box<IScattercarpetProperty> name() => Interop.mkScattercarpetAttr("hoverinfo", "name");
            public static Box<IScattercarpetProperty> text() => Interop.mkScattercarpetAttr("hoverinfo", "text");
        }

        /// Do the hover effects highlight individual points (markers or line points) or do they highlight filled regions? If the fill is *toself* or *tonext* and there are no markers or text, then the default is *fills*, otherwise it is *points*.
        public static partial class Hoveron
        {
            public static Box<IScattercarpetProperty> fills() => Interop.mkScattercarpetAttr("hoveron", "fills");
            public static Box<IScattercarpetProperty> points() => Interop.mkScattercarpetAttr("hoveron", "points");
        }
    }
}