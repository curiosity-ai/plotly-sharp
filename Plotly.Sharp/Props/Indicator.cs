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

    public static partial class Indicator
    {
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IIndicatorProperty> name(string val) => Interop.mkIndicatorAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IIndicatorProperty> uid(string val) => Interop.mkIndicatorAttr("uid", val);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIndicatorProperty> ids(bool val) => Interop.mkIndicatorAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIndicatorProperty> ids(params bool[] values) => Interop.mkIndicatorAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIndicatorProperty> ids(System.DateTime val) => Interop.mkIndicatorAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIndicatorProperty> ids(params System.DateTime[] values) => Interop.mkIndicatorAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIndicatorProperty> ids(float val) => Interop.mkIndicatorAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIndicatorProperty> ids(params float[] values) => Interop.mkIndicatorAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIndicatorProperty> ids(int val) => Interop.mkIndicatorAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIndicatorProperty> ids(params int[] values) => Interop.mkIndicatorAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIndicatorProperty> ids(string val) => Interop.mkIndicatorAttr("ids", new[]{val});
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIndicatorProperty> ids(params string[] values) => Interop.mkIndicatorAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIndicatorProperty> ids(IEnumerable<bool[]> values) => Interop.mkIndicatorAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIndicatorProperty> ids(List<bool[]> values) => Interop.mkIndicatorAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIndicatorProperty> ids(params bool[][] values) => Interop.mkIndicatorAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIndicatorProperty> ids(IEnumerable<IEnumerable<string>> values) => Interop.mkIndicatorAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIndicatorProperty> ids(List<string[]> values) => Interop.mkIndicatorAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIndicatorProperty> ids(params string[][] values) => Interop.mkIndicatorAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIndicatorProperty> ids(IEnumerable<IEnumerable<int>> values) => Interop.mkIndicatorAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIndicatorProperty> ids(List<int[]> values) => Interop.mkIndicatorAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIndicatorProperty> ids(params int[][] values) => Interop.mkIndicatorAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIndicatorProperty> ids(IEnumerable<IEnumerable<float>> values) => Interop.mkIndicatorAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIndicatorProperty> ids(List<float[]> values) => Interop.mkIndicatorAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIndicatorProperty> ids(params float[][] values) => Interop.mkIndicatorAttr("ids", Bindings.flatten2DArrayIf1D(values));
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIndicatorProperty> ids(Literals.PlotData[] values) => Interop.mkIndicatorAttr("ids", values);
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIndicatorProperty> ids(IEnumerable<bool?> values) => Interop.mkIndicatorAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIndicatorProperty> ids(IEnumerable<System.DateTime?> values) => Interop.mkIndicatorAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIndicatorProperty> ids(IEnumerable<int?> values) => Interop.mkIndicatorAttr("ids", values.ToArray());
        /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
        public static Box<IIndicatorProperty> ids(IEnumerable<float?> values) => Interop.mkIndicatorAttr("ids", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIndicatorProperty> customdata(bool val) => Interop.mkIndicatorAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIndicatorProperty> customdata(params bool[] values) => Interop.mkIndicatorAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIndicatorProperty> customdata(System.DateTime val) => Interop.mkIndicatorAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIndicatorProperty> customdata(params System.DateTime[] values) => Interop.mkIndicatorAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIndicatorProperty> customdata(float val) => Interop.mkIndicatorAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIndicatorProperty> customdata(params float[] values) => Interop.mkIndicatorAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIndicatorProperty> customdata(int val) => Interop.mkIndicatorAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIndicatorProperty> customdata(params int[] values) => Interop.mkIndicatorAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIndicatorProperty> customdata(string val) => Interop.mkIndicatorAttr("customdata", new[]{val});
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIndicatorProperty> customdata(params string[] values) => Interop.mkIndicatorAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIndicatorProperty> customdata(IEnumerable<bool[]> values) => Interop.mkIndicatorAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIndicatorProperty> customdata(List<bool[]> values) => Interop.mkIndicatorAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIndicatorProperty> customdata(params bool[][] values) => Interop.mkIndicatorAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIndicatorProperty> customdata(IEnumerable<IEnumerable<string>> values) => Interop.mkIndicatorAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIndicatorProperty> customdata(List<string[]> values) => Interop.mkIndicatorAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIndicatorProperty> customdata(params string[][] values) => Interop.mkIndicatorAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIndicatorProperty> customdata(IEnumerable<IEnumerable<int>> values) => Interop.mkIndicatorAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIndicatorProperty> customdata(List<int[]> values) => Interop.mkIndicatorAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIndicatorProperty> customdata(params int[][] values) => Interop.mkIndicatorAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIndicatorProperty> customdata(IEnumerable<IEnumerable<float>> values) => Interop.mkIndicatorAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIndicatorProperty> customdata(List<float[]> values) => Interop.mkIndicatorAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIndicatorProperty> customdata(params float[][] values) => Interop.mkIndicatorAttr("customdata", Bindings.flatten2DArrayIf1D(values));
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIndicatorProperty> customdata(Literals.PlotData[] values) => Interop.mkIndicatorAttr("customdata", values);
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIndicatorProperty> customdata(IEnumerable<bool?> values) => Interop.mkIndicatorAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIndicatorProperty> customdata(IEnumerable<System.DateTime?> values) => Interop.mkIndicatorAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIndicatorProperty> customdata(IEnumerable<int?> values) => Interop.mkIndicatorAttr("customdata", values.ToArray());
        /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
        public static Box<IIndicatorProperty> customdata(IEnumerable<float?> values) => Interop.mkIndicatorAttr("customdata", values.ToArray());
        public static Box<IIndicatorProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkIndicatorAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IIndicatorProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkIndicatorAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIndicatorProperty> uirevision(bool val) => Interop.mkIndicatorAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIndicatorProperty> uirevision(params bool[] values) => Interop.mkIndicatorAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIndicatorProperty> uirevision(System.DateTime val) => Interop.mkIndicatorAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIndicatorProperty> uirevision(params System.DateTime[] values) => Interop.mkIndicatorAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIndicatorProperty> uirevision(int val) => Interop.mkIndicatorAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIndicatorProperty> uirevision(params int[] values) => Interop.mkIndicatorAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIndicatorProperty> uirevision(float val) => Interop.mkIndicatorAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIndicatorProperty> uirevision(params float[] values) => Interop.mkIndicatorAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIndicatorProperty> uirevision(string val) => Interop.mkIndicatorAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IIndicatorProperty> uirevision(params string[] values) => Interop.mkIndicatorAttr("uirevision", values);
        /// Determines how the value is displayed on the graph. `number` displays the value numerically in text. `delta` displays the difference to a reference value in text. Finally, `gauge` displays the value graphically on an axis.
        public static Box<IIndicatorProperty> mode(params Box<IIndicatorProperty>[] properties) => Interop.mkIndicatorAttr("mode", Bindings.joinEnumProperties(properties));
        /// Sets the number to be displayed.
        public static Box<IIndicatorProperty> value(int val) => Interop.mkIndicatorAttr("value", val);
        /// Sets the number to be displayed.
        public static Box<IIndicatorProperty> value(float val) => Interop.mkIndicatorAttr("value", val);
        public static Box<IIndicatorProperty> domain(params Box<IDomainProperty>[] properties) => Interop.mkIndicatorAttr("domain", Bindings.flattenProperties(properties));
        public static Box<IIndicatorProperty> title(params Box<ITitleProperty>[] properties) => Interop.mkIndicatorAttr("title", Bindings.flattenProperties(properties));
        public static Box<IIndicatorProperty> number(params Box<INumberProperty>[] properties) => Interop.mkIndicatorAttr("number", Bindings.flattenProperties(properties));
        public static Box<IIndicatorProperty> delta(params Box<IDeltaProperty>[] properties) => Interop.mkIndicatorAttr("delta", Bindings.flattenProperties(properties));
        /// The gauge of the Indicator plot.
        public static Box<IIndicatorProperty> gauge(params Box<IGaugeProperty>[] properties) => Interop.mkIndicatorAttr("gauge", Bindings.flattenProperties(properties));
        /// Sets the source reference on plot.ly for  ids .
        public static Box<IIndicatorProperty> idssrc(string val) => Interop.mkIndicatorAttr("idssrc", val);
        /// Sets the source reference on plot.ly for  customdata .
        public static Box<IIndicatorProperty> customdatasrc(string val) => Interop.mkIndicatorAttr("customdatasrc", val);
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IIndicatorProperty> metasrc(string val) => Interop.mkIndicatorAttr("metasrc", val);
    }

    public static partial class Indicator
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IIndicatorProperty> legendonly() => Interop.mkIndicatorAttr("visible", "legendonly");
            public static Box<IIndicatorProperty> _false() => Interop.mkIndicatorAttr("visible", false);
            public static Box<IIndicatorProperty> _true() => Interop.mkIndicatorAttr("visible", true);
        }

        /// Determines how the value is displayed on the graph. `number` displays the value numerically in text. `delta` displays the difference to a reference value in text. Finally, `gauge` displays the value graphically on an axis.
        public static partial class Mode
        {
            public static Box<IIndicatorProperty> delta() => Interop.mkIndicatorAttr("mode", "delta");
            public static Box<IIndicatorProperty> gauge() => Interop.mkIndicatorAttr("mode", "gauge");
            public static Box<IIndicatorProperty> number() => Interop.mkIndicatorAttr("mode", "number");
        }

        /// Sets the horizontal alignment of the `text` within the box. Note that this attribute has no effect if an angular gauge is displayed: in this case, it is always centered
        public static partial class Align
        {
            public static Box<IIndicatorProperty> center() => Interop.mkIndicatorAttr("align", "center");
            public static Box<IIndicatorProperty> left() => Interop.mkIndicatorAttr("align", "left");
            public static Box<IIndicatorProperty> right() => Interop.mkIndicatorAttr("align", "right");
        }
    }
}