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

    public static partial class Parcats
    {
        /// Sets the trace name. The trace name appear as the legend item and on hover.
        public static Box<IParcatsProperty> name(string val) => Interop.mkParcatsAttr("name", val);
        /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
        public static Box<IParcatsProperty> uid(string val) => Interop.mkParcatsAttr("uid", val);
        public static Box<IParcatsProperty> stream(params Box<IStreamProperty>[] properties) => Interop.mkParcatsAttr("stream", Bindings.flattenProperties(properties));
        public static Box<IParcatsProperty> transforms(params Box<ITransformsProperty>[] properties) => Interop.mkParcatsAttr("transforms", Bindings.flattenPropertiesToArray(properties));
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IParcatsProperty> uirevision(bool val) => Interop.mkParcatsAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IParcatsProperty> uirevision(params bool[] values) => Interop.mkParcatsAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IParcatsProperty> uirevision(System.DateTime val) => Interop.mkParcatsAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IParcatsProperty> uirevision(params System.DateTime[] values) => Interop.mkParcatsAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IParcatsProperty> uirevision(int val) => Interop.mkParcatsAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IParcatsProperty> uirevision(params int[] values) => Interop.mkParcatsAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IParcatsProperty> uirevision(float val) => Interop.mkParcatsAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IParcatsProperty> uirevision(params float[] values) => Interop.mkParcatsAttr("uirevision", values);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IParcatsProperty> uirevision(string val) => Interop.mkParcatsAttr("uirevision", val);
        /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
        public static Box<IParcatsProperty> uirevision(params string[] values) => Interop.mkParcatsAttr("uirevision", values);
        public static Box<IParcatsProperty> domain(params Box<IDomainProperty>[] properties) => Interop.mkParcatsAttr("domain", Bindings.flattenProperties(properties));
        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static Box<IParcatsProperty> hoverinfo(params Box<IParcatsProperty>[] properties) => Interop.mkParcatsAttr("hoverinfo", Script.Write<object>("{0}.join('+')", properties));
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `count`, `probability`, `category`, `categorycount`, `colorcount` and `bandcolorcount`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<IParcatsProperty> hovertemplate(string val) => Interop.mkParcatsAttr("hovertemplate", val);
        /// Sort paths so that like colors are bundled together within each category.
        public static Box<IParcatsProperty> bundlecolors(bool val) => Interop.mkParcatsAttr("bundlecolors", val);
        /// Sets the font for the `dimension` labels.
        public static Box<IParcatsProperty> labelfont(params Box<ILabelfontProperty>[] properties) => Interop.mkParcatsAttr("labelfont", Bindings.flattenProperties(properties));
        /// Sets the font for the `category` labels.
        public static Box<IParcatsProperty> tickfont(params Box<ITickfontProperty>[] properties) => Interop.mkParcatsAttr("tickfont", Bindings.flattenProperties(properties));
        public static Box<IParcatsProperty> dimensions(params Box<IDimensionsProperty>[] properties) => Interop.mkParcatsAttr("dimensions", Bindings.flattenPropertiesToArray(properties));
        public static Box<IParcatsProperty> line(params Box<ILineProperty>[] properties) => Interop.mkParcatsAttr("line", Bindings.flattenProperties(properties));
        /// The number of observations represented by each state. Defaults to 1 so that each state represents one observation
        public static Box<IParcatsProperty> counts(int val) => Interop.mkParcatsAttr("counts", val);
        /// The number of observations represented by each state. Defaults to 1 so that each state represents one observation
        public static Box<IParcatsProperty> counts(float val) => Interop.mkParcatsAttr("counts", val);
        /// The number of observations represented by each state. Defaults to 1 so that each state represents one observation
        public static Box<IParcatsProperty> counts(IEnumerable<int> values) => Interop.mkParcatsAttr("counts", values.ToArray());
        /// The number of observations represented by each state. Defaults to 1 so that each state represents one observation
        public static Box<IParcatsProperty> counts(IEnumerable<float> values) => Interop.mkParcatsAttr("counts", values.ToArray());
        /// Sets the source reference on plot.ly for  meta .
        public static Box<IParcatsProperty> metasrc(string val) => Interop.mkParcatsAttr("metasrc", val);
        /// Sets the source reference on plot.ly for  counts .
        public static Box<IParcatsProperty> countssrc(string val) => Interop.mkParcatsAttr("countssrc", val);
    }

    public static partial class Parcats
    {
        /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
        public static partial class Visible
        {
            public static Box<IParcatsProperty> legendonly() => Interop.mkParcatsAttr("visible", "legendonly");
            public static Box<IParcatsProperty> _false() => Interop.mkParcatsAttr("visible", false);
            public static Box<IParcatsProperty> _true() => Interop.mkParcatsAttr("visible", true);
        }

        /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<IParcatsProperty> all() => Interop.mkParcatsAttr("hoverinfo", "all");
            public static Box<IParcatsProperty> none() => Interop.mkParcatsAttr("hoverinfo", "none");
            public static Box<IParcatsProperty> skip() => Interop.mkParcatsAttr("hoverinfo", "skip");
            public static Box<IParcatsProperty> count() => Interop.mkParcatsAttr("hoverinfo", "count");
            public static Box<IParcatsProperty> probability() => Interop.mkParcatsAttr("hoverinfo", "probability");
        }

        /// Sets the hover interaction mode for the parcats diagram. If `category`, hover interaction take place per category. If `color`, hover interactions take place per color per category. If `dimension`, hover interactions take place across all categories per dimension.
        public static partial class Hoveron
        {
            public static Box<IParcatsProperty> category() => Interop.mkParcatsAttr("hoveron", "category");
            public static Box<IParcatsProperty> color() => Interop.mkParcatsAttr("hoveron", "color");
            public static Box<IParcatsProperty> dimension() => Interop.mkParcatsAttr("hoveron", "dimension");
        }

        /// Sets the drag interaction mode for categories and dimensions. If `perpendicular`, the categories can only move along a line perpendicular to the paths. If `freeform`, the categories can freely move on the plane. If `fixed`, the categories and dimensions are stationary.
        public static partial class Arrangement
        {
            public static Box<IParcatsProperty> _fixed() => Interop.mkParcatsAttr("arrangement", "fixed");
            public static Box<IParcatsProperty> freeform() => Interop.mkParcatsAttr("arrangement", "freeform");
            public static Box<IParcatsProperty> perpendicular() => Interop.mkParcatsAttr("arrangement", "perpendicular");
        }

        /// Sets the path sorting algorithm. If `forward`, sort paths based on dimension categories from left to right. If `backward`, sort paths based on dimensions categories from right to left.
        public static partial class Sortpaths
        {
            public static Box<IParcatsProperty> backward() => Interop.mkParcatsAttr("sortpaths", "backward");
            public static Box<IParcatsProperty> forward() => Interop.mkParcatsAttr("sortpaths", "forward");
        }
    }
}