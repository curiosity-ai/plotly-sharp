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

    public static partial class Parcoords
    {
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IParcoordsProperty> name(string val) => Interop.mkParcoordsAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IParcoordsProperty> uid(string val) => Interop.mkParcoordsAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IParcoordsProperty> ids(bool val) => Interop.mkParcoordsAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IParcoordsProperty> ids(params bool[] values) => Interop.mkParcoordsAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IParcoordsProperty> ids(System.DateTime val) => Interop.mkParcoordsAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IParcoordsProperty> ids(params System.DateTime[] values) => Interop.mkParcoordsAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IParcoordsProperty> ids(float val) => Interop.mkParcoordsAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IParcoordsProperty> ids(params float[] values) => Interop.mkParcoordsAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IParcoordsProperty> ids(int val) => Interop.mkParcoordsAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IParcoordsProperty> ids(params int[] values) => Interop.mkParcoordsAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IParcoordsProperty> ids(string val) => Interop.mkParcoordsAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IParcoordsProperty> ids(params string[] values) => Interop.mkParcoordsAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IParcoordsProperty> ids(IEnumerable<bool[]> values) => Interop.mkParcoordsAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IParcoordsProperty> ids(List<bool[]> values) => Interop.mkParcoordsAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IParcoordsProperty> ids(params bool[][] values) => Interop.mkParcoordsAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IParcoordsProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkParcoordsAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IParcoordsProperty> ids(List<string[]> values) => Interop.mkParcoordsAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IParcoordsProperty> ids(params string[][] values) => Interop.mkParcoordsAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IParcoordsProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkParcoordsAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IParcoordsProperty> ids(List<int[]> values) => Interop.mkParcoordsAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IParcoordsProperty> ids(params int[][] values) => Interop.mkParcoordsAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IParcoordsProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkParcoordsAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IParcoordsProperty> ids(List<float[]> values) => Interop.mkParcoordsAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IParcoordsProperty> ids(params float[][] values) => Interop.mkParcoordsAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IParcoordsProperty> ids(Literals.PlotData[] values) => Interop.mkParcoordsAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IParcoordsProperty> ids(IEnumerable<bool?> values) => Interop.mkParcoordsAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IParcoordsProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkParcoordsAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IParcoordsProperty> ids(IEnumerable<int?> values) => Interop.mkParcoordsAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IParcoordsProperty> ids(IEnumerable<float?> values) => Interop.mkParcoordsAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IParcoordsProperty> customdata(bool val) => Interop.mkParcoordsAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IParcoordsProperty> customdata(params bool[] values) => Interop.mkParcoordsAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IParcoordsProperty> customdata(System.DateTime val) => Interop.mkParcoordsAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IParcoordsProperty> customdata(params System.DateTime[] values) => Interop.mkParcoordsAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IParcoordsProperty> customdata(float val) => Interop.mkParcoordsAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IParcoordsProperty> customdata(params float[] values) => Interop.mkParcoordsAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IParcoordsProperty> customdata(int val) => Interop.mkParcoordsAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IParcoordsProperty> customdata(params int[] values) => Interop.mkParcoordsAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IParcoordsProperty> customdata(string val) => Interop.mkParcoordsAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IParcoordsProperty> customdata(params string[] values) => Interop.mkParcoordsAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IParcoordsProperty> customdata(IEnumerable<bool[]> values) => Interop.mkParcoordsAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IParcoordsProperty> customdata(List<bool[]> values) => Interop.mkParcoordsAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IParcoordsProperty> customdata(params bool[][] values) => Interop.mkParcoordsAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IParcoordsProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkParcoordsAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IParcoordsProperty> customdata(List<string[]> values) => Interop.mkParcoordsAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IParcoordsProperty> customdata(params string[][] values) => Interop.mkParcoordsAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IParcoordsProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkParcoordsAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IParcoordsProperty> customdata(List<int[]> values) => Interop.mkParcoordsAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IParcoordsProperty> customdata(params int[][] values) => Interop.mkParcoordsAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IParcoordsProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkParcoordsAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IParcoordsProperty> customdata(List<float[]> values) => Interop.mkParcoordsAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IParcoordsProperty> customdata(params float[][] values) => Interop.mkParcoordsAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IParcoordsProperty> customdata(Literals.PlotData[] values) => Interop.mkParcoordsAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IParcoordsProperty> customdata(IEnumerable<bool?> values) => Interop.mkParcoordsAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IParcoordsProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkParcoordsAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IParcoordsProperty> customdata(IEnumerable<int?> values) => Interop.mkParcoordsAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IParcoordsProperty> customdata(IEnumerable<float?> values) => Interop.mkParcoordsAttr("customdata", values.ToArray());
        public static Box<IParcoordsProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkParcoordsAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IParcoordsProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkParcoordsAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IParcoordsProperty> uirevision(bool val) => Interop.mkParcoordsAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IParcoordsProperty> uirevision(params bool[] values) => Interop.mkParcoordsAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IParcoordsProperty> uirevision(System.DateTime val) => Interop.mkParcoordsAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IParcoordsProperty> uirevision(params System.DateTime[] values) => Interop.mkParcoordsAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IParcoordsProperty> uirevision(int val) => Interop.mkParcoordsAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IParcoordsProperty> uirevision(params int[] values) => Interop.mkParcoordsAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IParcoordsProperty> uirevision(float val) => Interop.mkParcoordsAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IParcoordsProperty> uirevision(params float[] values) => Interop.mkParcoordsAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IParcoordsProperty> uirevision(string val) => Interop.mkParcoordsAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IParcoordsProperty> uirevision(params string[] values) => Interop.mkParcoordsAttr("uirevision", values);
        public static Box<IParcoordsProperty> domain(params Box<IDomainProperty>[] properties) => Interop.mkParcoordsAttr("domain", Bindings.flattenProperties(properties));
        /// Sets the angle of the labels with respect to the horizontal. For example, a `tickangle` of -90 draws the labels vertically. Tilted labels with *labelangle* may be positioned better inside margins when `labelposition` is set to *bottom*.
        public static Box<IParcoordsProperty> labelangle(int val) => Interop.mkParcoordsAttr("labelangle", val);
        /// Sets the angle of the labels with respect to the horizontal. For example, a `tickangle` of -90 draws the labels vertically. Tilted labels with *labelangle* may be positioned better inside margins when `labelposition` is set to *bottom*.
        public static Box<IParcoordsProperty> labelangle(float val) => Interop.mkParcoordsAttr("labelangle", val);
        /// Sets the font for the `dimension` labels.
        public static Box<IParcoordsProperty> labelfont(params Box<ILabelfontProperty>[] properties) => Interop.mkParcoordsAttr("labelfont", Bindings.flattenProperties(properties));
        /// Sets the font for the `dimension` tick values.
        public static Box<IParcoordsProperty> tickfont(params Box<ITickfontProperty>[] properties) => Interop.mkParcoordsAttr("tickfont", Bindings.flattenProperties(properties));
        /// Sets the font for the `dimension` range values.
        public static Box<IParcoordsProperty> rangefont(params Box<IRangefontProperty>[] properties) => Interop.mkParcoordsAttr("rangefont", Bindings.flattenProperties(properties));
        public static Box<IParcoordsProperty> dimensions(params Box<IDimensionsProperty>[] properties) => Interop.mkParcoordsAttr("dimensions", Bindings.flattenPropertiesToArray(properties));
        public static Box<IParcoordsProperty> line(params Box<ILineProperty>[] properties) => Interop.mkParcoordsAttr("line", Bindings.flattenProperties(properties));
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IParcoordsProperty> idssrc(string val) => Interop.mkParcoordsAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IParcoordsProperty> customdatasrc(string val) => Interop.mkParcoordsAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IParcoordsProperty> metasrc(string val) => Interop.mkParcoordsAttr("metasrc", val);
    }

    public static partial class Parcoords
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IParcoordsProperty> legendonly() => Interop.mkParcoordsAttr("visible", "legendonly");
            public static Box<IParcoordsProperty> _false() => Interop.mkParcoordsAttr("visible", false);
            public static Box<IParcoordsProperty> _true() => Interop.mkParcoordsAttr("visible", true);
        }

        /// Specifies the location of the `label`. *top* positions labels above, next to the title *bottom* positions labels below the graph Tilted labels with *labelangle* may be positioned better inside margins when `labelposition` is set to *bottom*.
        public static partial class Labelside
        {
            public static Box<IParcoordsProperty> bottom() => Interop.mkParcoordsAttr("labelside", "bottom");
            public static Box<IParcoordsProperty> top() => Interop.mkParcoordsAttr("labelside", "top");
        }
    }
}