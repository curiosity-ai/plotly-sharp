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

    public static partial class Funnelarea
    {
        /// Determines whether or not an item corresponding to this trace is shown in the legend.
        public static Box<IFunnelareaProperty> showlegend(bool val) => Interop.mkFunnelareaAttr("showlegend", val);
        /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
        public static Box<IFunnelareaProperty> legendgroup(string val) => Interop.mkFunnelareaAttr("legendgroup", val);
        /// Sets the opacity of the trace.
        public static Box<IFunnelareaProperty> opacity(int val) => Interop.mkFunnelareaAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<IFunnelareaProperty> opacity(float val) => Interop.mkFunnelareaAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IFunnelareaProperty> name(string val) => Interop.mkFunnelareaAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IFunnelareaProperty> uid(string val) => Interop.mkFunnelareaAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelareaProperty> ids(bool val) => Interop.mkFunnelareaAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelareaProperty> ids(params bool[] values) => Interop.mkFunnelareaAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelareaProperty> ids(System.DateTime val) => Interop.mkFunnelareaAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelareaProperty> ids(params System.DateTime[] values) => Interop.mkFunnelareaAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelareaProperty> ids(float val) => Interop.mkFunnelareaAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelareaProperty> ids(params float[] values) => Interop.mkFunnelareaAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelareaProperty> ids(int val) => Interop.mkFunnelareaAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelareaProperty> ids(params int[] values) => Interop.mkFunnelareaAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelareaProperty> ids(string val) => Interop.mkFunnelareaAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelareaProperty> ids(params string[] values) => Interop.mkFunnelareaAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelareaProperty> ids(IEnumerable<bool[]> values) => Interop.mkFunnelareaAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelareaProperty> ids(List<bool[]> values) => Interop.mkFunnelareaAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelareaProperty> ids(params bool[][] values) => Interop.mkFunnelareaAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelareaProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkFunnelareaAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelareaProperty> ids(List<string[]> values) => Interop.mkFunnelareaAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelareaProperty> ids(params string[][] values) => Interop.mkFunnelareaAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelareaProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkFunnelareaAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelareaProperty> ids(List<int[]> values) => Interop.mkFunnelareaAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelareaProperty> ids(params int[][] values) => Interop.mkFunnelareaAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelareaProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkFunnelareaAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelareaProperty> ids(List<float[]> values) => Interop.mkFunnelareaAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelareaProperty> ids(params float[][] values) => Interop.mkFunnelareaAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelareaProperty> ids(Literals.PlotData[] values) => Interop.mkFunnelareaAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelareaProperty> ids(IEnumerable<bool?> values) => Interop.mkFunnelareaAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelareaProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkFunnelareaAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelareaProperty> ids(IEnumerable<int?> values) => Interop.mkFunnelareaAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IFunnelareaProperty> ids(IEnumerable<float?> values) => Interop.mkFunnelareaAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelareaProperty> customdata(bool val) => Interop.mkFunnelareaAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelareaProperty> customdata(params bool[] values) => Interop.mkFunnelareaAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelareaProperty> customdata(System.DateTime val) => Interop.mkFunnelareaAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelareaProperty> customdata(params System.DateTime[] values) => Interop.mkFunnelareaAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelareaProperty> customdata(float val) => Interop.mkFunnelareaAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelareaProperty> customdata(params float[] values) => Interop.mkFunnelareaAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelareaProperty> customdata(int val) => Interop.mkFunnelareaAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelareaProperty> customdata(params int[] values) => Interop.mkFunnelareaAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelareaProperty> customdata(string val) => Interop.mkFunnelareaAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelareaProperty> customdata(params string[] values) => Interop.mkFunnelareaAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelareaProperty> customdata(IEnumerable<bool[]> values) => Interop.mkFunnelareaAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelareaProperty> customdata(List<bool[]> values) => Interop.mkFunnelareaAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelareaProperty> customdata(params bool[][] values) => Interop.mkFunnelareaAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelareaProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkFunnelareaAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelareaProperty> customdata(List<string[]> values) => Interop.mkFunnelareaAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelareaProperty> customdata(params string[][] values) => Interop.mkFunnelareaAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelareaProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkFunnelareaAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelareaProperty> customdata(List<int[]> values) => Interop.mkFunnelareaAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelareaProperty> customdata(params int[][] values) => Interop.mkFunnelareaAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelareaProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkFunnelareaAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelareaProperty> customdata(List<float[]> values) => Interop.mkFunnelareaAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelareaProperty> customdata(params float[][] values) => Interop.mkFunnelareaAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelareaProperty> customdata(Literals.PlotData[] values) => Interop.mkFunnelareaAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelareaProperty> customdata(IEnumerable<bool?> values) => Interop.mkFunnelareaAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelareaProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkFunnelareaAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelareaProperty> customdata(IEnumerable<int?> values) => Interop.mkFunnelareaAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IFunnelareaProperty> customdata(IEnumerable<float?> values) => Interop.mkFunnelareaAttr("customdata", values.ToArray());
        public static Box<IFunnelareaProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkFunnelareaAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IFunnelareaProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkFunnelareaAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IFunnelareaProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkFunnelareaAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IFunnelareaProperty> uirevision(bool val) => Interop.mkFunnelareaAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IFunnelareaProperty> uirevision(params bool[] values) => Interop.mkFunnelareaAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IFunnelareaProperty> uirevision(System.DateTime val) => Interop.mkFunnelareaAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IFunnelareaProperty> uirevision(params System.DateTime[] values) => Interop.mkFunnelareaAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IFunnelareaProperty> uirevision(int val) => Interop.mkFunnelareaAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IFunnelareaProperty> uirevision(params int[] values) => Interop.mkFunnelareaAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IFunnelareaProperty> uirevision(float val) => Interop.mkFunnelareaAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IFunnelareaProperty> uirevision(params float[] values) => Interop.mkFunnelareaAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IFunnelareaProperty> uirevision(string val) => Interop.mkFunnelareaAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IFunnelareaProperty> uirevision(params string[] values) => Interop.mkFunnelareaAttr("uirevision", values);
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IFunnelareaProperty> labels(bool val) => Interop.mkFunnelareaAttr("labels", new[]{val});
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IFunnelareaProperty> labels(params bool[] values) => Interop.mkFunnelareaAttr("labels", values);
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IFunnelareaProperty> labels(System.DateTime val) => Interop.mkFunnelareaAttr("labels", new[]{val});
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IFunnelareaProperty> labels(params System.DateTime[] values) => Interop.mkFunnelareaAttr("labels", values);
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IFunnelareaProperty> labels(float val) => Interop.mkFunnelareaAttr("labels", new[]{val});
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IFunnelareaProperty> labels(params float[] values) => Interop.mkFunnelareaAttr("labels", values);
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IFunnelareaProperty> labels(int val) => Interop.mkFunnelareaAttr("labels", new[]{val});
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IFunnelareaProperty> labels(params int[] values) => Interop.mkFunnelareaAttr("labels", values);
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IFunnelareaProperty> labels(string val) => Interop.mkFunnelareaAttr("labels", new[]{val});
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IFunnelareaProperty> labels(params string[] values) => Interop.mkFunnelareaAttr("labels", values);
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IFunnelareaProperty> labels(IEnumerable<bool[]> values) => Interop.mkFunnelareaAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IFunnelareaProperty> labels(List<bool[]> values) => Interop.mkFunnelareaAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IFunnelareaProperty> labels(params bool[][] values) => Interop.mkFunnelareaAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IFunnelareaProperty> labels(IEnumerable<IEnumerable<string>> values) => Interop.mkFunnelareaAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IFunnelareaProperty> labels(List<string[]> values) => Interop.mkFunnelareaAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IFunnelareaProperty> labels(params string[][] values) => Interop.mkFunnelareaAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IFunnelareaProperty> labels(IEnumerable<IEnumerable<int>> values) => Interop.mkFunnelareaAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IFunnelareaProperty> labels(List<int[]> values) => Interop.mkFunnelareaAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IFunnelareaProperty> labels(params int[][] values) => Interop.mkFunnelareaAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IFunnelareaProperty> labels(IEnumerable<IEnumerable<float>> values) => Interop.mkFunnelareaAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IFunnelareaProperty> labels(List<float[]> values) => Interop.mkFunnelareaAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IFunnelareaProperty> labels(params float[][] values) => Interop.mkFunnelareaAttr("labels", Bindings.flatten2DArrayIf1D(values));
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IFunnelareaProperty> labels(Literals.PlotData[] values) => Interop.mkFunnelareaAttr("labels", values);
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IFunnelareaProperty> labels(IEnumerable<bool?> values) => Interop.mkFunnelareaAttr("labels", values.ToArray());
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IFunnelareaProperty> labels(IEnumerable<System.DateTime?> values) => Interop.mkFunnelareaAttr("labels", values.ToArray());
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IFunnelareaProperty> labels(IEnumerable<int?> values) => Interop.mkFunnelareaAttr("labels", values.ToArray());
        /// Sets the sector labels. If `labels` entries are duplicated, we sum associated `values` or simply count occurrences if `values` is not provided. For other array attributes (including color) we use the first non-empty entry among all occurrences of the label.
        public static Box<IFunnelareaProperty> labels(IEnumerable<float?> values) => Interop.mkFunnelareaAttr("labels", values.ToArray());
        /// Alternate to `labels`. Builds a numeric set of labels. Use with `dlabel` where `label0` is the starting label and `dlabel` the step.
        public static Box<IFunnelareaProperty> label0(int val) => Interop.mkFunnelareaAttr("label0", val);
        /// Alternate to `labels`. Builds a numeric set of labels. Use with `dlabel` where `label0` is the starting label and `dlabel` the step.
        public static Box<IFunnelareaProperty> label0(float val) => Interop.mkFunnelareaAttr("label0", val);
        /// Sets the label step. See `label0` for more info.
        public static Box<IFunnelareaProperty> dlabel(int val) => Interop.mkFunnelareaAttr("dlabel", val);
        /// Sets the label step. See `label0` for more info.
        public static Box<IFunnelareaProperty> dlabel(float val) => Interop.mkFunnelareaAttr("dlabel", val);
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IFunnelareaProperty> values(bool val) => Interop.mkFunnelareaAttr("values", new[]{val});
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IFunnelareaProperty> values(params bool[] values) => Interop.mkFunnelareaAttr("values", values);
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IFunnelareaProperty> values(System.DateTime val) => Interop.mkFunnelareaAttr("values", new[]{val});
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IFunnelareaProperty> values(params System.DateTime[] values) => Interop.mkFunnelareaAttr("values", values);
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IFunnelareaProperty> values(float val) => Interop.mkFunnelareaAttr("values", new[]{val});
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IFunnelareaProperty> values(params float[] values) => Interop.mkFunnelareaAttr("values", values);
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IFunnelareaProperty> values(int val) => Interop.mkFunnelareaAttr("values", new[]{val});
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IFunnelareaProperty> values(params int[] values) => Interop.mkFunnelareaAttr("values", values);
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IFunnelareaProperty> values(string val) => Interop.mkFunnelareaAttr("values", new[]{val});
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IFunnelareaProperty> values(params string[] values) => Interop.mkFunnelareaAttr("values", values);
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IFunnelareaProperty> values(IEnumerable<bool[]> values) => Interop.mkFunnelareaAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IFunnelareaProperty> values(List<bool[]> values) => Interop.mkFunnelareaAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IFunnelareaProperty> values(params bool[][] values) => Interop.mkFunnelareaAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IFunnelareaProperty> values(IEnumerable<IEnumerable<string>> values) => Interop.mkFunnelareaAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IFunnelareaProperty> values(List<string[]> values) => Interop.mkFunnelareaAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IFunnelareaProperty> values(params string[][] values) => Interop.mkFunnelareaAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IFunnelareaProperty> values(IEnumerable<IEnumerable<int>> values) => Interop.mkFunnelareaAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IFunnelareaProperty> values(List<int[]> values) => Interop.mkFunnelareaAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IFunnelareaProperty> values(params int[][] values) => Interop.mkFunnelareaAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IFunnelareaProperty> values(IEnumerable<IEnumerable<float>> values) => Interop.mkFunnelareaAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IFunnelareaProperty> values(List<float[]> values) => Interop.mkFunnelareaAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IFunnelareaProperty> values(params float[][] values) => Interop.mkFunnelareaAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IFunnelareaProperty> values(Literals.PlotData[] values) => Interop.mkFunnelareaAttr("values", values);
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IFunnelareaProperty> values(IEnumerable<bool?> values) => Interop.mkFunnelareaAttr("values", values.ToArray());
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IFunnelareaProperty> values(IEnumerable<System.DateTime?> values) => Interop.mkFunnelareaAttr("values", values.ToArray());
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IFunnelareaProperty> values(IEnumerable<int?> values) => Interop.mkFunnelareaAttr("values", values.ToArray());
        /// Sets the values of the sectors. If omitted, we count occurrences of each label.
        public static Box<IFunnelareaProperty> values(IEnumerable<float?> values) => Interop.mkFunnelareaAttr("values", values.ToArray());
        public static Box<IFunnelareaProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkFunnelareaAttr("marker", Bindings.flattenProperties(properties));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelareaProperty> text(bool val) => Interop.mkFunnelareaAttr("text", new[]{val});
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelareaProperty> text(IEnumerable<bool> values) => Interop.mkFunnelareaAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelareaProperty> text(System.DateTime val) => Interop.mkFunnelareaAttr("text", new[]{val});
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelareaProperty> text(IEnumerable<System.DateTime> values) => Interop.mkFunnelareaAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelareaProperty> text(float val) => Interop.mkFunnelareaAttr("text", new[]{val});
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelareaProperty> text(IEnumerable<float> values) => Interop.mkFunnelareaAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelareaProperty> text(int val) => Interop.mkFunnelareaAttr("text", new[]{val});
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelareaProperty> text(IEnumerable<int> values) => Interop.mkFunnelareaAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelareaProperty> text(string val) => Interop.mkFunnelareaAttr("text", new[]{val});
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelareaProperty> text(IEnumerable<string> values) => Interop.mkFunnelareaAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelareaProperty> text(IEnumerable<bool[]> values) => Interop.mkFunnelareaAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelareaProperty> text(List<bool[]> values) => Interop.mkFunnelareaAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelareaProperty> text(params bool[][] values) => Interop.mkFunnelareaAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelareaProperty> text(IEnumerable<IEnumerable<string>> values) => Interop.mkFunnelareaAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelareaProperty> text(List<string[]> values) => Interop.mkFunnelareaAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelareaProperty> text(params string[][] values) => Interop.mkFunnelareaAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelareaProperty> text(IEnumerable<IEnumerable<int>> values) => Interop.mkFunnelareaAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelareaProperty> text(List<int[]> values) => Interop.mkFunnelareaAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelareaProperty> text(params int[][] values) => Interop.mkFunnelareaAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelareaProperty> text(IEnumerable<IEnumerable<float>> values) => Interop.mkFunnelareaAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelareaProperty> text(List<float[]> values) => Interop.mkFunnelareaAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelareaProperty> text(params float[][] values) => Interop.mkFunnelareaAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelareaProperty> text(Literals.PlotData[] values) => Interop.mkFunnelareaAttr("text", values);
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelareaProperty> text(IEnumerable<bool?> values) => Interop.mkFunnelareaAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelareaProperty> text(IEnumerable<System.DateTime?> values) => Interop.mkFunnelareaAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelareaProperty> text(IEnumerable<int?> values) => Interop.mkFunnelareaAttr("text", values.ToArray());
        /// Sets text elements associated with each sector. If trace `textinfo` contains a *text* flag, these elements will be seen on the chart. If trace `hoverinfo` contains a *text* flag and *hovertext* is not set, these elements will be seen in the hover labels.
        public static Box<IFunnelareaProperty> text(IEnumerable<float?> values) => Interop.mkFunnelareaAttr("text", values.ToArray());
        /// Sets hover text elements associated with each sector. If a single string, the same string appears for all data points. If an array of string, the items are mapped in order of this trace's sectors. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IFunnelareaProperty> hovertext(string val) => Interop.mkFunnelareaAttr("hovertext", val);
        /// Sets hover text elements associated with each sector. If a single string, the same string appears for all data points. If an array of string, the items are mapped in order of this trace's sectors. To be seen, trace `hoverinfo` must contain a *text* flag.
        public static Box<IFunnelareaProperty> hovertext(IEnumerable<string> values) => Interop.mkFunnelareaAttr("hovertext", values.ToArray());
        /// If there are multiple funnelareas that should be sized according to their totals, link them by providing a non-empty group id here shared by every trace in the same group.
        public static Box<IFunnelareaProperty> scalegroup(string val) => Interop.mkFunnelareaAttr("scalegroup", val);
        /// Determines which trace information appear on the graph.
        public static Box<IFunnelareaProperty> textinfo(params Box<IFunnelareaProperty>[] properties) => Interop.mkFunnelareaAttr("textinfo", Bindings.joinEnumProperties(properties));
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `label`, `color`, `value`, `text` and `percent`.
        public static Box<IFunnelareaProperty> texttemplate(string val) => Interop.mkFunnelareaAttr("texttemplate", val);
        /// Template string used for rendering the information text that appear on points. Note that this will override `textinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. Every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `label`, `color`, `value`, `text` and `percent`.
        public static Box<IFunnelareaProperty> texttemplate(IEnumerable<string> values) => Interop.mkFunnelareaAttr("texttemplate", values.ToArray());
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IFunnelareaProperty> hoverinfo(params Box<IFunnelareaProperty>[] properties) => Interop.mkFunnelareaAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `label`, `color`, `value`, `text` and `percent`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IFunnelareaProperty> hovertemplate(string val) => Interop.mkFunnelareaAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `label`, `color`, `value`, `text` and `percent`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IFunnelareaProperty> hovertemplate(IEnumerable<string> values) => Interop.mkFunnelareaAttr("hovertemplate", values.ToArray());
        /// Specifies the location of the `textinfo`.
        public static Box<IFunnelareaProperty> textposition(IEnumerable<Box<IFunnelareaProperty>> properties) => Interop.mkFunnelareaAttr("textposition", Bindings.flattenProperties(properties));
        /// Sets the font used for `textinfo`.
        public static Box<IFunnelareaProperty> textfont(params Box<ITextfontProperty>[] properties) => Interop.mkFunnelareaAttr("textfont", Bindings.flattenProperties(properties));
        /// Sets the font used for `textinfo` lying inside the sector.
        public static Box<IFunnelareaProperty> insidetextfont(params Box<IInsidetextfontProperty>[] properties) => Interop.mkFunnelareaAttr("insidetextfont", Bindings.flattenProperties(properties));
        public static Box<IFunnelareaProperty> title(params Box<ITitleProperty>[] properties) => Interop.mkFunnelareaAttr("title", Bindings.flattenProperties(properties));
        public static Box<IFunnelareaProperty> domain(params Box<IDomainProperty>[] properties) => Interop.mkFunnelareaAttr("domain", Bindings.flattenProperties(properties));
        /// Sets the ratio between height and width
        public static Box<IFunnelareaProperty> aspectratio(int val) => Interop.mkFunnelareaAttr("aspectratio", val);
        /// Sets the ratio between height and width
        public static Box<IFunnelareaProperty> aspectratio(float val) => Interop.mkFunnelareaAttr("aspectratio", val);
        /// Sets the ratio between bottom length and maximum top length.
        public static Box<IFunnelareaProperty> baseratio(int val) => Interop.mkFunnelareaAttr("baseratio", val);
        /// Sets the ratio between bottom length and maximum top length.
        public static Box<IFunnelareaProperty> baseratio(float val) => Interop.mkFunnelareaAttr("baseratio", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IFunnelareaProperty> idssrc(string val) => Interop.mkFunnelareaAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IFunnelareaProperty> customdatasrc(string val) => Interop.mkFunnelareaAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IFunnelareaProperty> metasrc(string val) => Interop.mkFunnelareaAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  labels .
        public static Box<IFunnelareaProperty> labelssrc(string val) => Interop.mkFunnelareaAttr("labelssrc", val);
        /// Sets the source reference on plot.ly for  values .
        public static Box<IFunnelareaProperty> valuessrc(string val) => Interop.mkFunnelareaAttr("valuessrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IFunnelareaProperty> textsrc(string val) => Interop.mkFunnelareaAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IFunnelareaProperty> hovertextsrc(string val) => Interop.mkFunnelareaAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  texttemplate .
        public static Box<IFunnelareaProperty> texttemplatesrc(string val) => Interop.mkFunnelareaAttr("texttemplatesrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IFunnelareaProperty> hoverinfosrc(string val) => Interop.mkFunnelareaAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IFunnelareaProperty> hovertemplatesrc(string val) => Interop.mkFunnelareaAttr("hovertemplatesrc", val);
        /// Sets the source reference on plot.ly for  textposition .
        public static Box<IFunnelareaProperty> textpositionsrc(string val) => Interop.mkFunnelareaAttr("textpositionsrc", val);
    }

    public static partial class Funnelarea
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IFunnelareaProperty> legendonly() => Interop.mkFunnelareaAttr("visible", "legendonly");
            public static Box<IFunnelareaProperty> _false() => Interop.mkFunnelareaAttr("visible", false);
            public static Box<IFunnelareaProperty> _true() => Interop.mkFunnelareaAttr("visible", true);
        }

        /// Determines which trace information appear on the graph.
        public static partial class Textinfo
        {
            public static Box<IFunnelareaProperty> none() => Interop.mkFunnelareaAttr("textinfo", "none");
            public static Box<IFunnelareaProperty> label() => Interop.mkFunnelareaAttr("textinfo", "label");
            public static Box<IFunnelareaProperty> percent() => Interop.mkFunnelareaAttr("textinfo", "percent");
            public static Box<IFunnelareaProperty> text() => Interop.mkFunnelareaAttr("textinfo", "text");
            public static Box<IFunnelareaProperty> value() => Interop.mkFunnelareaAttr("textinfo", "value");
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IFunnelareaProperty> all() => Interop.mkFunnelareaAttr("hoverinfo", "all");
            public static Box<IFunnelareaProperty> none() => Interop.mkFunnelareaAttr("hoverinfo", "none");
            public static Box<IFunnelareaProperty> skip() => Interop.mkFunnelareaAttr("hoverinfo", "skip");
            public static Box<IFunnelareaProperty> label() => Interop.mkFunnelareaAttr("hoverinfo", "label");
            public static Box<IFunnelareaProperty> name() => Interop.mkFunnelareaAttr("hoverinfo", "name");
            public static Box<IFunnelareaProperty> percent() => Interop.mkFunnelareaAttr("hoverinfo", "percent");
            public static Box<IFunnelareaProperty> text() => Interop.mkFunnelareaAttr("hoverinfo", "text");
            public static Box<IFunnelareaProperty> value() => Interop.mkFunnelareaAttr("hoverinfo", "value");
        }

        /// Specifies the location of the `textinfo`.
        public static partial class Textposition
        {
            public static Box<IFunnelareaProperty> inside() => Interop.mkFunnelareaAttr("textposition", "inside");
            public static Box<IFunnelareaProperty> none() => Interop.mkFunnelareaAttr("textposition", "none");
        }
    }
}