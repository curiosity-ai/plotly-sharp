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

    public static partial class Image
    {
        /// Sets the opacity of the trace.
        public static Box<IImageProperty> opacity(int val) => Interop.mkImageAttr("opacity", val);
        /// Sets the opacity of the trace.
        public static Box<IImageProperty> opacity(float val) => Interop.mkImageAttr("opacity", val);
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IImageProperty> name(string val) => Interop.mkImageAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IImageProperty> uid(string val) => Interop.mkImageAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IImageProperty> ids(bool val) => Interop.mkImageAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IImageProperty> ids(params bool[] values) => Interop.mkImageAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IImageProperty> ids(System.DateTime val) => Interop.mkImageAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IImageProperty> ids(params System.DateTime[] values) => Interop.mkImageAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IImageProperty> ids(float val) => Interop.mkImageAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IImageProperty> ids(params float[] values) => Interop.mkImageAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IImageProperty> ids(int val) => Interop.mkImageAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IImageProperty> ids(params int[] values) => Interop.mkImageAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IImageProperty> ids(string val) => Interop.mkImageAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IImageProperty> ids(params string[] values) => Interop.mkImageAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IImageProperty> ids(IEnumerable<bool[]> values) => Interop.mkImageAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IImageProperty> ids(List<bool[]> values) => Interop.mkImageAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IImageProperty> ids(params bool[][] values) => Interop.mkImageAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IImageProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkImageAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IImageProperty> ids(List<string[]> values) => Interop.mkImageAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IImageProperty> ids(params string[][] values) => Interop.mkImageAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IImageProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkImageAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IImageProperty> ids(List<int[]> values) => Interop.mkImageAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IImageProperty> ids(params int[][] values) => Interop.mkImageAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IImageProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkImageAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IImageProperty> ids(List<float[]> values) => Interop.mkImageAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IImageProperty> ids(params float[][] values) => Interop.mkImageAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IImageProperty> ids(Literals.PlotData[] values) => Interop.mkImageAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IImageProperty> ids(IEnumerable<bool?> values) => Interop.mkImageAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IImageProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkImageAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IImageProperty> ids(IEnumerable<int?> values) => Interop.mkImageAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IImageProperty> ids(IEnumerable<float?> values) => Interop.mkImageAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IImageProperty> customdata(bool val) => Interop.mkImageAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IImageProperty> customdata(params bool[] values) => Interop.mkImageAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IImageProperty> customdata(System.DateTime val) => Interop.mkImageAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IImageProperty> customdata(params System.DateTime[] values) => Interop.mkImageAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IImageProperty> customdata(float val) => Interop.mkImageAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IImageProperty> customdata(params float[] values) => Interop.mkImageAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IImageProperty> customdata(int val) => Interop.mkImageAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IImageProperty> customdata(params int[] values) => Interop.mkImageAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IImageProperty> customdata(string val) => Interop.mkImageAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IImageProperty> customdata(params string[] values) => Interop.mkImageAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IImageProperty> customdata(IEnumerable<bool[]> values) => Interop.mkImageAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IImageProperty> customdata(List<bool[]> values) => Interop.mkImageAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IImageProperty> customdata(params bool[][] values) => Interop.mkImageAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IImageProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkImageAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IImageProperty> customdata(List<string[]> values) => Interop.mkImageAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IImageProperty> customdata(params string[][] values) => Interop.mkImageAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IImageProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkImageAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IImageProperty> customdata(List<int[]> values) => Interop.mkImageAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IImageProperty> customdata(params int[][] values) => Interop.mkImageAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IImageProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkImageAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IImageProperty> customdata(List<float[]> values) => Interop.mkImageAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IImageProperty> customdata(params float[][] values) => Interop.mkImageAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IImageProperty> customdata(Literals.PlotData[] values) => Interop.mkImageAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IImageProperty> customdata(IEnumerable<bool?> values) => Interop.mkImageAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IImageProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkImageAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IImageProperty> customdata(IEnumerable<int?> values) => Interop.mkImageAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IImageProperty> customdata(IEnumerable<float?> values) => Interop.mkImageAttr("customdata", values.ToArray());
        public static Box<IImageProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkImageAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<IImageProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkImageAttr("stream", Bindings.flattenProperties(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IImageProperty> uirevision(bool val) => Interop.mkImageAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IImageProperty> uirevision(params bool[] values) => Interop.mkImageAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IImageProperty> uirevision(System.DateTime val) => Interop.mkImageAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IImageProperty> uirevision(params System.DateTime[] values) => Interop.mkImageAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IImageProperty> uirevision(int val) => Interop.mkImageAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IImageProperty> uirevision(params int[] values) => Interop.mkImageAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IImageProperty> uirevision(float val) => Interop.mkImageAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IImageProperty> uirevision(params float[] values) => Interop.mkImageAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IImageProperty> uirevision(string val) => Interop.mkImageAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IImageProperty> uirevision(params string[] values) => Interop.mkImageAttr("uirevision", values);
        /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
        public static Box<IImageProperty> z(bool val) => Interop.mkImageAttr("z", new[]{val});
        /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
        public static Box<IImageProperty> z(params bool[] values) => Interop.mkImageAttr("z", values);
        /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
        public static Box<IImageProperty> z(System.DateTime val) => Interop.mkImageAttr("z", new[]{val});
        /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
        public static Box<IImageProperty> z(params System.DateTime[] values) => Interop.mkImageAttr("z", values);
        /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
        public static Box<IImageProperty> z(float val) => Interop.mkImageAttr("z", new[]{val});
        /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
        public static Box<IImageProperty> z(params float[] values) => Interop.mkImageAttr("z", values);
        /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
        public static Box<IImageProperty> z(int val) => Interop.mkImageAttr("z", new[]{val});
        /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
        public static Box<IImageProperty> z(params int[] values) => Interop.mkImageAttr("z", values);
        /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
        public static Box<IImageProperty> z(string val) => Interop.mkImageAttr("z", new[]{val});
        /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
        public static Box<IImageProperty> z(params string[] values) => Interop.mkImageAttr("z", values);
        /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
        public static Box<IImageProperty> z(IEnumerable<bool[]> values) => Interop.mkImageAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
        public static Box<IImageProperty> z(List<bool[]> values) => Interop.mkImageAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
        public static Box<IImageProperty> z(params bool[][] values) => Interop.mkImageAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
        public static Box<IImageProperty> z(IEnumerable<IEnumerable<string>> values) => Interop.mkImageAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
        public static Box<IImageProperty> z(List<string[]> values) => Interop.mkImageAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
        public static Box<IImageProperty> z(params string[][] values) => Interop.mkImageAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
        public static Box<IImageProperty> z(IEnumerable<IEnumerable<int>> values) => Interop.mkImageAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
        public static Box<IImageProperty> z(List<int[]> values) => Interop.mkImageAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
        public static Box<IImageProperty> z(params int[][] values) => Interop.mkImageAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
        public static Box<IImageProperty> z(IEnumerable<IEnumerable<float>> values) => Interop.mkImageAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
        public static Box<IImageProperty> z(List<float[]> values) => Interop.mkImageAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
        public static Box<IImageProperty> z(params float[][] values) => Interop.mkImageAttr("z", Bindings.flatten2DArrayIf1D(values));
        /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
        public static Box<IImageProperty> z(Literals.PlotData[] values) => Interop.mkImageAttr("z", values);
        /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
        public static Box<IImageProperty> z(IEnumerable<bool?> values) => Interop.mkImageAttr("z", values.ToArray());
        /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
        public static Box<IImageProperty> z(IEnumerable<System.DateTime?> values) => Interop.mkImageAttr("z", values.ToArray());
        /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
        public static Box<IImageProperty> z(IEnumerable<int?> values) => Interop.mkImageAttr("z", values.ToArray());
        /// A 2-dimensional array in which each element is an array of 3 or 4 numbers representing a color.
        public static Box<IImageProperty> z(IEnumerable<float?> values) => Interop.mkImageAttr("z", values.ToArray());
        /// Array defining the lower bound for each color component. Note that the default value will depend on the colormodel. For the `rgb` colormodel, it is [0, 0, 0]. For the `rgba` colormodel, it is [0, 0, 0, 0]. For the `hsl` colormodel, it is [0, 0, 0]. For the `hsla` colormodel, it is [0, 0, 0, 0].
        public static Box<IImageProperty> zmin(int val) => Interop.mkImageAttr("zmin", new[]{val});
        /// Array defining the lower bound for each color component. Note that the default value will depend on the colormodel. For the `rgb` colormodel, it is [0, 0, 0]. For the `rgba` colormodel, it is [0, 0, 0, 0]. For the `hsl` colormodel, it is [0, 0, 0]. For the `hsla` colormodel, it is [0, 0, 0, 0].
        public static Box<IImageProperty> zmin(IEnumerable<int> values) => Interop.mkImageAttr("zmin", values.ToArray());
        /// Array defining the lower bound for each color component. Note that the default value will depend on the colormodel. For the `rgb` colormodel, it is [0, 0, 0]. For the `rgba` colormodel, it is [0, 0, 0, 0]. For the `hsl` colormodel, it is [0, 0, 0]. For the `hsla` colormodel, it is [0, 0, 0, 0].
        public static Box<IImageProperty> zmin(float val) => Interop.mkImageAttr("zmin", new[]{val});
        /// Array defining the lower bound for each color component. Note that the default value will depend on the colormodel. For the `rgb` colormodel, it is [0, 0, 0]. For the `rgba` colormodel, it is [0, 0, 0, 0]. For the `hsl` colormodel, it is [0, 0, 0]. For the `hsla` colormodel, it is [0, 0, 0, 0].
        public static Box<IImageProperty> zmin(IEnumerable<float> values) => Interop.mkImageAttr("zmin", values.ToArray());
        /// Array defining the higher bound for each color component. Note that the default value will depend on the colormodel. For the `rgb` colormodel, it is [255, 255, 255]. For the `rgba` colormodel, it is [255, 255, 255, 1]. For the `hsl` colormodel, it is [360, 100, 100]. For the `hsla` colormodel, it is [360, 100, 100, 1].
        public static Box<IImageProperty> zmax(int val) => Interop.mkImageAttr("zmax", new[]{val});
        /// Array defining the higher bound for each color component. Note that the default value will depend on the colormodel. For the `rgb` colormodel, it is [255, 255, 255]. For the `rgba` colormodel, it is [255, 255, 255, 1]. For the `hsl` colormodel, it is [360, 100, 100]. For the `hsla` colormodel, it is [360, 100, 100, 1].
        public static Box<IImageProperty> zmax(IEnumerable<int> values) => Interop.mkImageAttr("zmax", values.ToArray());
        /// Array defining the higher bound for each color component. Note that the default value will depend on the colormodel. For the `rgb` colormodel, it is [255, 255, 255]. For the `rgba` colormodel, it is [255, 255, 255, 1]. For the `hsl` colormodel, it is [360, 100, 100]. For the `hsla` colormodel, it is [360, 100, 100, 1].
        public static Box<IImageProperty> zmax(float val) => Interop.mkImageAttr("zmax", new[]{val});
        /// Array defining the higher bound for each color component. Note that the default value will depend on the colormodel. For the `rgb` colormodel, it is [255, 255, 255]. For the `rgba` colormodel, it is [255, 255, 255, 1]. For the `hsl` colormodel, it is [360, 100, 100]. For the `hsla` colormodel, it is [360, 100, 100, 1].
        public static Box<IImageProperty> zmax(IEnumerable<float> values) => Interop.mkImageAttr("zmax", values.ToArray());
        /// Set the image's x position.
        public static Box<IImageProperty> x0(bool val) => Interop.mkImageAttr("x0", val);
        /// Set the image's x position.
        public static Box<IImageProperty> x0(params bool[] values) => Interop.mkImageAttr("x0", values);
        /// Set the image's x position.
        public static Box<IImageProperty> x0(System.DateTime val) => Interop.mkImageAttr("x0", val);
        /// Set the image's x position.
        public static Box<IImageProperty> x0(params System.DateTime[] values) => Interop.mkImageAttr("x0", values);
        /// Set the image's x position.
        public static Box<IImageProperty> x0(int val) => Interop.mkImageAttr("x0", val);
        /// Set the image's x position.
        public static Box<IImageProperty> x0(params int[] values) => Interop.mkImageAttr("x0", values);
        /// Set the image's x position.
        public static Box<IImageProperty> x0(float val) => Interop.mkImageAttr("x0", val);
        /// Set the image's x position.
        public static Box<IImageProperty> x0(params float[] values) => Interop.mkImageAttr("x0", values);
        /// Set the image's x position.
        public static Box<IImageProperty> x0(string val) => Interop.mkImageAttr("x0", val);
        /// Set the image's x position.
        public static Box<IImageProperty> x0(params string[] values) => Interop.mkImageAttr("x0", values);
        /// Set the image's y position.
        public static Box<IImageProperty> y0(bool val) => Interop.mkImageAttr("y0", val);
        /// Set the image's y position.
        public static Box<IImageProperty> y0(params bool[] values) => Interop.mkImageAttr("y0", values);
        /// Set the image's y position.
        public static Box<IImageProperty> y0(System.DateTime val) => Interop.mkImageAttr("y0", val);
        /// Set the image's y position.
        public static Box<IImageProperty> y0(params System.DateTime[] values) => Interop.mkImageAttr("y0", values);
        /// Set the image's y position.
        public static Box<IImageProperty> y0(int val) => Interop.mkImageAttr("y0", val);
        /// Set the image's y position.
        public static Box<IImageProperty> y0(params int[] values) => Interop.mkImageAttr("y0", values);
        /// Set the image's y position.
        public static Box<IImageProperty> y0(float val) => Interop.mkImageAttr("y0", val);
        /// Set the image's y position.
        public static Box<IImageProperty> y0(params float[] values) => Interop.mkImageAttr("y0", values);
        /// Set the image's y position.
        public static Box<IImageProperty> y0(string val) => Interop.mkImageAttr("y0", val);
        /// Set the image's y position.
        public static Box<IImageProperty> y0(params string[] values) => Interop.mkImageAttr("y0", values);
        /// Set the pixel's horizontal size.
        public static Box<IImageProperty> dx(int val) => Interop.mkImageAttr("dx", val);
        /// Set the pixel's horizontal size.
        public static Box<IImageProperty> dx(float val) => Interop.mkImageAttr("dx", val);
        /// Set the pixel's vertical size
        public static Box<IImageProperty> dy(int val) => Interop.mkImageAttr("dy", val);
        /// Set the pixel's vertical size
        public static Box<IImageProperty> dy(float val) => Interop.mkImageAttr("dy", val);
        /// Sets the text elements associated with each z value.
        public static Box<IImageProperty> text(bool val) => Interop.mkImageAttr("text", new[]{val});
        /// Sets the text elements associated with each z value.
        public static Box<IImageProperty> text(IEnumerable<bool> values) => Interop.mkImageAttr("text", values.ToArray());
        /// Sets the text elements associated with each z value.
        public static Box<IImageProperty> text(System.DateTime val) => Interop.mkImageAttr("text", new[]{val});
        /// Sets the text elements associated with each z value.
        public static Box<IImageProperty> text(IEnumerable<System.DateTime> values) => Interop.mkImageAttr("text", values.ToArray());
        /// Sets the text elements associated with each z value.
        public static Box<IImageProperty> text(float val) => Interop.mkImageAttr("text", new[]{val});
        /// Sets the text elements associated with each z value.
        public static Box<IImageProperty> text(IEnumerable<float> values) => Interop.mkImageAttr("text", values.ToArray());
        /// Sets the text elements associated with each z value.
        public static Box<IImageProperty> text(int val) => Interop.mkImageAttr("text", new[]{val});
        /// Sets the text elements associated with each z value.
        public static Box<IImageProperty> text(IEnumerable<int> values) => Interop.mkImageAttr("text", values.ToArray());
        /// Sets the text elements associated with each z value.
        public static Box<IImageProperty> text(string val) => Interop.mkImageAttr("text", new[]{val});
        /// Sets the text elements associated with each z value.
        public static Box<IImageProperty> text(IEnumerable<string> values) => Interop.mkImageAttr("text", values.ToArray());
        /// Sets the text elements associated with each z value.
        public static Box<IImageProperty> text(IEnumerable<bool[]> values) => Interop.mkImageAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IImageProperty> text(List<bool[]> values) => Interop.mkImageAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IImageProperty> text(params bool[][] values) => Interop.mkImageAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IImageProperty> text(IEnumerable<IEnumerable<string>> values) => Interop.mkImageAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IImageProperty> text(List<string[]> values) => Interop.mkImageAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IImageProperty> text(params string[][] values) => Interop.mkImageAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IImageProperty> text(IEnumerable<IEnumerable<int>> values) => Interop.mkImageAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IImageProperty> text(List<int[]> values) => Interop.mkImageAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IImageProperty> text(params int[][] values) => Interop.mkImageAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IImageProperty> text(IEnumerable<IEnumerable<float>> values) => Interop.mkImageAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IImageProperty> text(List<float[]> values) => Interop.mkImageAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IImageProperty> text(params float[][] values) => Interop.mkImageAttr("text", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text elements associated with each z value.
        public static Box<IImageProperty> text(Literals.PlotData[] values) => Interop.mkImageAttr("text", values);
        /// Sets the text elements associated with each z value.
        public static Box<IImageProperty> text(IEnumerable<bool?> values) => Interop.mkImageAttr("text", values.ToArray());
        /// Sets the text elements associated with each z value.
        public static Box<IImageProperty> text(IEnumerable<System.DateTime?> values) => Interop.mkImageAttr("text", values.ToArray());
        /// Sets the text elements associated with each z value.
        public static Box<IImageProperty> text(IEnumerable<int?> values) => Interop.mkImageAttr("text", values.ToArray());
        /// Sets the text elements associated with each z value.
        public static Box<IImageProperty> text(IEnumerable<float?> values) => Interop.mkImageAttr("text", values.ToArray());
        /// Same as `text`.
        public static Box<IImageProperty> hovertext(bool val) => Interop.mkImageAttr("hovertext", new[]{val});
        /// Same as `text`.
        public static Box<IImageProperty> hovertext(IEnumerable<bool> values) => Interop.mkImageAttr("hovertext", values.ToArray());
        /// Same as `text`.
        public static Box<IImageProperty> hovertext(System.DateTime val) => Interop.mkImageAttr("hovertext", new[]{val});
        /// Same as `text`.
        public static Box<IImageProperty> hovertext(IEnumerable<System.DateTime> values) => Interop.mkImageAttr("hovertext", values.ToArray());
        /// Same as `text`.
        public static Box<IImageProperty> hovertext(float val) => Interop.mkImageAttr("hovertext", new[]{val});
        /// Same as `text`.
        public static Box<IImageProperty> hovertext(IEnumerable<float> values) => Interop.mkImageAttr("hovertext", values.ToArray());
        /// Same as `text`.
        public static Box<IImageProperty> hovertext(int val) => Interop.mkImageAttr("hovertext", new[]{val});
        /// Same as `text`.
        public static Box<IImageProperty> hovertext(IEnumerable<int> values) => Interop.mkImageAttr("hovertext", values.ToArray());
        /// Same as `text`.
        public static Box<IImageProperty> hovertext(string val) => Interop.mkImageAttr("hovertext", new[]{val});
        /// Same as `text`.
        public static Box<IImageProperty> hovertext(IEnumerable<string> values) => Interop.mkImageAttr("hovertext", values.ToArray());
        /// Same as `text`.
        public static Box<IImageProperty> hovertext(IEnumerable<bool[]> values) => Interop.mkImageAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IImageProperty> hovertext(List<bool[]> values) => Interop.mkImageAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IImageProperty> hovertext(params bool[][] values) => Interop.mkImageAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IImageProperty> hovertext(IEnumerable<IEnumerable<string>> values) => Interop.mkImageAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IImageProperty> hovertext(List<string[]> values) => Interop.mkImageAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IImageProperty> hovertext(params string[][] values) => Interop.mkImageAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IImageProperty> hovertext(IEnumerable<IEnumerable<int>> values) => Interop.mkImageAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IImageProperty> hovertext(List<int[]> values) => Interop.mkImageAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IImageProperty> hovertext(params int[][] values) => Interop.mkImageAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IImageProperty> hovertext(IEnumerable<IEnumerable<float>> values) => Interop.mkImageAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IImageProperty> hovertext(List<float[]> values) => Interop.mkImageAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IImageProperty> hovertext(params float[][] values) => Interop.mkImageAttr("hovertext", Bindings.flatten2DArrayIf1D(values));
        /// Same as `text`.
        public static Box<IImageProperty> hovertext(Literals.PlotData[] values) => Interop.mkImageAttr("hovertext", values);
        /// Same as `text`.
        public static Box<IImageProperty> hovertext(IEnumerable<bool?> values) => Interop.mkImageAttr("hovertext", values.ToArray());
        /// Same as `text`.
        public static Box<IImageProperty> hovertext(IEnumerable<System.DateTime?> values) => Interop.mkImageAttr("hovertext", values.ToArray());
        /// Same as `text`.
        public static Box<IImageProperty> hovertext(IEnumerable<int?> values) => Interop.mkImageAttr("hovertext", values.ToArray());
        /// Same as `text`.
        public static Box<IImageProperty> hovertext(IEnumerable<float?> values) => Interop.mkImageAttr("hovertext", values.ToArray());
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IImageProperty> hoverinfo(params Box<IImageProperty>[] properties) => Interop.mkImageAttr("hoverinfo", Bindings.joinEnumProperties(properties));
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `z`, `color` and `colormodel`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IImageProperty> hovertemplate(string val) => Interop.mkImageAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `z`, `color` and `colormodel`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IImageProperty> hovertemplate(IEnumerable<string> values) => Interop.mkImageAttr("hovertemplate", values.ToArray());
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IImageProperty> xaxis(int anchorId) => Interop.mkImageAttr("xaxis", anchorId > 1 ? $"x{anchorId}" : "");
        /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
        public static Box<IImageProperty> xaxis(string val) => Interop.mkImageAttr("xaxis", val);
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IImageProperty> yaxis(int anchorId) => Interop.mkImageAttr("yaxis", anchorId > 1 ? $"y{anchorId}" : "");
        /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
        public static Box<IImageProperty> yaxis(string val) => Interop.mkImageAttr("yaxis", val);
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IImageProperty> idssrc(string val) => Interop.mkImageAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IImageProperty> customdatasrc(string val) => Interop.mkImageAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IImageProperty> metasrc(string val) => Interop.mkImageAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  z .
        public static Box<IImageProperty> zsrc(string val) => Interop.mkImageAttr("zsrc", val);
        /// Sets the source reference on plot.ly for  text .
        public static Box<IImageProperty> textsrc(string val) => Interop.mkImageAttr("textsrc", val);
        /// Sets the source reference on plot.ly for  hovertext .
        public static Box<IImageProperty> hovertextsrc(string val) => Interop.mkImageAttr("hovertextsrc", val);
        /// Sets the source reference on plot.ly for  hoverinfo .
        public static Box<IImageProperty> hoverinfosrc(string val) => Interop.mkImageAttr("hoverinfosrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<IImageProperty> hovertemplatesrc(string val) => Interop.mkImageAttr("hovertemplatesrc", val);
        /// Specifies the URL of the image to be used. The URL must be accessible from the domain where the plot code is run, and can be either relative or absolute.
        public static Box<IImageProperty> source(string val) => Interop.mkImageAttr("source", val);
        /// Sets the image container size horizontally. The image will be sized based on the `position` value. When `xref` is set to `paper`, units are sized relative to the plot width.
        public static Box<IImageProperty> sizex(int val) => Interop.mkImageAttr("sizex", val);
        /// Sets the image container size horizontally. The image will be sized based on the `position` value. When `xref` is set to `paper`, units are sized relative to the plot width.
        public static Box<IImageProperty> sizex(float val) => Interop.mkImageAttr("sizex", val);
        /// Sets the image container size vertically. The image will be sized based on the `position` value. When `yref` is set to `paper`, units are sized relative to the plot height.
        public static Box<IImageProperty> sizey(int val) => Interop.mkImageAttr("sizey", val);
        /// Sets the image container size vertically. The image will be sized based on the `position` value. When `yref` is set to `paper`, units are sized relative to the plot height.
        public static Box<IImageProperty> sizey(float val) => Interop.mkImageAttr("sizey", val);
        /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
        public static Box<IImageProperty> x(bool val) => Interop.mkImageAttr("x", val);
        /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
        public static Box<IImageProperty> x(params bool[] values) => Interop.mkImageAttr("x", values);
        /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
        public static Box<IImageProperty> x(System.DateTime val) => Interop.mkImageAttr("x", val);
        /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
        public static Box<IImageProperty> x(params System.DateTime[] values) => Interop.mkImageAttr("x", values);
        /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
        public static Box<IImageProperty> x(int val) => Interop.mkImageAttr("x", val);
        /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
        public static Box<IImageProperty> x(params int[] values) => Interop.mkImageAttr("x", values);
        /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
        public static Box<IImageProperty> x(float val) => Interop.mkImageAttr("x", val);
        /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
        public static Box<IImageProperty> x(params float[] values) => Interop.mkImageAttr("x", values);
        /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
        public static Box<IImageProperty> x(string val) => Interop.mkImageAttr("x", val);
        /// Sets the image's x position. When `xref` is set to `paper`, units are sized relative to the plot height. See `xref` for more info
        public static Box<IImageProperty> x(params string[] values) => Interop.mkImageAttr("x", values);
        /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
        public static Box<IImageProperty> y(bool val) => Interop.mkImageAttr("y", val);
        /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
        public static Box<IImageProperty> y(params bool[] values) => Interop.mkImageAttr("y", values);
        /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
        public static Box<IImageProperty> y(System.DateTime val) => Interop.mkImageAttr("y", val);
        /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
        public static Box<IImageProperty> y(params System.DateTime[] values) => Interop.mkImageAttr("y", values);
        /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
        public static Box<IImageProperty> y(int val) => Interop.mkImageAttr("y", val);
        /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
        public static Box<IImageProperty> y(params int[] values) => Interop.mkImageAttr("y", values);
        /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
        public static Box<IImageProperty> y(float val) => Interop.mkImageAttr("y", val);
        /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
        public static Box<IImageProperty> y(params float[] values) => Interop.mkImageAttr("y", values);
        /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
        public static Box<IImageProperty> y(string val) => Interop.mkImageAttr("y", val);
        /// Sets the image's y position. When `yref` is set to `paper`, units are sized relative to the plot height. See `yref` for more info
        public static Box<IImageProperty> y(params string[] values) => Interop.mkImageAttr("y", values);
        /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
        public static Box<IImageProperty> templateitemname(string val) => Interop.mkImageAttr("templateitemname", val);
    }

    public static partial class Image
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IImageProperty> legendonly() => Interop.mkImageAttr("visible", "legendonly");
            public static Box<IImageProperty> _false() => Interop.mkImageAttr("visible", false);
            public static Box<IImageProperty> _true() => Interop.mkImageAttr("visible", true);
        }

        /// Color model used to map the numerical color components described in `z` into colors.
        public static partial class Colormodel
        {
            public static Box<IImageProperty> hsl() => Interop.mkImageAttr("colormodel", "hsl");
            public static Box<IImageProperty> hsla() => Interop.mkImageAttr("colormodel", "hsla");
            public static Box<IImageProperty> rgb() => Interop.mkImageAttr("colormodel", "rgb");
            public static Box<IImageProperty> rgba() => Interop.mkImageAttr("colormodel", "rgba");
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IImageProperty> all() => Interop.mkImageAttr("hoverinfo", "all");
            public static Box<IImageProperty> none() => Interop.mkImageAttr("hoverinfo", "none");
            public static Box<IImageProperty> skip() => Interop.mkImageAttr("hoverinfo", "skip");
            public static Box<IImageProperty> color() => Interop.mkImageAttr("hoverinfo", "color");
            public static Box<IImageProperty> name() => Interop.mkImageAttr("hoverinfo", "name");
            public static Box<IImageProperty> text() => Interop.mkImageAttr("hoverinfo", "text");
            public static Box<IImageProperty> x() => Interop.mkImageAttr("hoverinfo", "x");
            public static Box<IImageProperty> y() => Interop.mkImageAttr("hoverinfo", "y");
            public static Box<IImageProperty> z() => Interop.mkImageAttr("hoverinfo", "z");
        }

        /// Specifies whether images are drawn below or above traces. When `xref` and `yref` are both set to `paper`, image is drawn below the entire plot area.
        public static partial class Layer
        {
            public static Box<IImageProperty> above() => Interop.mkImageAttr("layer", "above");
            public static Box<IImageProperty> below() => Interop.mkImageAttr("layer", "below");
        }

        /// Specifies which dimension of the image to constrain.
        public static partial class Sizing
        {
            public static Box<IImageProperty> contain() => Interop.mkImageAttr("sizing", "contain");
            public static Box<IImageProperty> fill() => Interop.mkImageAttr("sizing", "fill");
            public static Box<IImageProperty> stretch() => Interop.mkImageAttr("sizing", "stretch");
        }

        /// Sets the anchor for the x position
        public static partial class Xanchor
        {
            public static Box<IImageProperty> center() => Interop.mkImageAttr("xanchor", "center");
            public static Box<IImageProperty> left() => Interop.mkImageAttr("xanchor", "left");
            public static Box<IImageProperty> right() => Interop.mkImageAttr("xanchor", "right");
        }

        /// Sets the anchor for the y position.
        public static partial class Yanchor
        {
            public static Box<IImageProperty> bottom() => Interop.mkImageAttr("yanchor", "bottom");
            public static Box<IImageProperty> middle() => Interop.mkImageAttr("yanchor", "middle");
            public static Box<IImageProperty> top() => Interop.mkImageAttr("yanchor", "top");
        }

        /// Sets the images's x coordinate axis. If set to a x axis id (e.g. *x* or *x2*), the `x` position refers to an x data coordinate If set to *paper*, the `x` position refers to the distance from the left of plot in normalized coordinates where *0* (*1*) corresponds to the left (right).
        public static partial class Xref
        {
            public static Box<IImageProperty> paper() => Interop.mkImageAttr("xref", "paper");
            public static Box<IImageProperty> custom(string val) => Interop.mkImageAttr("xref", val);
            public static Box<IImageProperty> x(int anchorId) => Interop.mkImageAttr("xref", anchorId > 1 ? $"x{anchorId}" : "");
        }

        /// Sets the images's y coordinate axis. If set to a y axis id (e.g. *y* or *y2*), the `y` position refers to a y data coordinate. If set to *paper*, the `y` position refers to the distance from the bottom of the plot in normalized coordinates where *0* (*1*) corresponds to the bottom (top).
        public static partial class Yref
        {
            public static Box<IImageProperty> paper() => Interop.mkImageAttr("yref", "paper");
            public static Box<IImageProperty> custom(string val) => Interop.mkImageAttr("yref", val);
            public static Box<IImageProperty> y(int anchorId) => Interop.mkImageAttr("yref", anchorId > 1 ? $"y{anchorId}" : "");
        }
    }
}