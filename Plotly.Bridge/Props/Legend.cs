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

    public static partial class Legend
    {
        /// Sets the legend background color. Defaults to `layout.paper_bgcolor`.
        public static Box<ILegendProperty> bgcolor(string val) => Interop.mkLegendAttr("bgcolor", val);
        /// Sets the color of the border enclosing the legend.
        public static Box<ILegendProperty> bordercolor(string val) => Interop.mkLegendAttr("bordercolor", val);
        /// Sets the width (in px) of the border enclosing the legend.
        public static Box<ILegendProperty> borderwidth(int val) => Interop.mkLegendAttr("borderwidth", val);
        /// Sets the width (in px) of the border enclosing the legend.
        public static Box<ILegendProperty> borderwidth(float val) => Interop.mkLegendAttr("borderwidth", val);
        /// Sets the font used to text the legend items.
        public static Box<ILegendProperty> font(params Box<IFontProperty>[] properties) => Interop.mkLegendAttr("font", Bindings.flattenProperties(properties));
        /// Determines the order at which the legend items are displayed. If *normal*, the items are displayed top-to-bottom in the same order as the input data. If *reversed*, the items are displayed in the opposite order as *normal*. If *grouped*, the items are displayed in groups (when a trace `legendgroup` is provided). if *grouped+reversed*, the items are displayed in the opposite order as *grouped*.
        public static Box<ILegendProperty> traceorder(params Box<ILegendProperty>[] properties) => Interop.mkLegendAttr("traceorder", Bindings.joinEnumProperties(properties));
        /// Sets the amount of vertical space (in px) between legend groups.
        public static Box<ILegendProperty> tracegroupgap(int val) => Interop.mkLegendAttr("tracegroupgap", val);
        /// Sets the amount of vertical space (in px) between legend groups.
        public static Box<ILegendProperty> tracegroupgap(float val) => Interop.mkLegendAttr("tracegroupgap", val);
        /// Sets the x position (in normalized coordinates) of the legend. Defaults to *1.02* for vertical legends and defaults to *0* for horizontal legends.
        public static Box<ILegendProperty> x(int val) => Interop.mkLegendAttr("x", val);
        /// Sets the x position (in normalized coordinates) of the legend. Defaults to *1.02* for vertical legends and defaults to *0* for horizontal legends.
        public static Box<ILegendProperty> x(float val) => Interop.mkLegendAttr("x", val);
        /// Sets the y position (in normalized coordinates) of the legend. Defaults to *1* for vertical legends, defaults to *-0.1* for horizontal legends on graphs w/o range sliders and defaults to *1.1* for horizontal legends on graph with one or multiple range sliders.
        public static Box<ILegendProperty> y(int val) => Interop.mkLegendAttr("y", val);
        /// Sets the y position (in normalized coordinates) of the legend. Defaults to *1* for vertical legends, defaults to *-0.1* for horizontal legends on graphs w/o range sliders and defaults to *1.1* for horizontal legends on graph with one or multiple range sliders.
        public static Box<ILegendProperty> y(float val) => Interop.mkLegendAttr("y", val);
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        public static Box<ILegendProperty> uirevision(bool val) => Interop.mkLegendAttr("uirevision", val);
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        public static Box<ILegendProperty> uirevision(params bool[] values) => Interop.mkLegendAttr("uirevision", values);
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        public static Box<ILegendProperty> uirevision(System.DateTime val) => Interop.mkLegendAttr("uirevision", val);
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        public static Box<ILegendProperty> uirevision(params System.DateTime[] values) => Interop.mkLegendAttr("uirevision", values);
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        public static Box<ILegendProperty> uirevision(int val) => Interop.mkLegendAttr("uirevision", val);
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        public static Box<ILegendProperty> uirevision(params int[] values) => Interop.mkLegendAttr("uirevision", values);
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        public static Box<ILegendProperty> uirevision(float val) => Interop.mkLegendAttr("uirevision", val);
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        public static Box<ILegendProperty> uirevision(params float[] values) => Interop.mkLegendAttr("uirevision", values);
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        public static Box<ILegendProperty> uirevision(string val) => Interop.mkLegendAttr("uirevision", val);
        /// Controls persistence of legend-driven changes in trace and pie label visibility. Defaults to `layout.uirevision`.
        public static Box<ILegendProperty> uirevision(params string[] values) => Interop.mkLegendAttr("uirevision", values);
        public static Box<ILegendProperty> title(params Box<ITitleProperty>[] properties) => Interop.mkLegendAttr("title", Bindings.flattenProperties(properties));
    }

    public static partial class Legend
    {
        /// Sets the orientation of the legend.
        public static partial class Orientation
        {
            public static Box<ILegendProperty> h() => Interop.mkLegendAttr("orientation", "h");
            public static Box<ILegendProperty> v() => Interop.mkLegendAttr("orientation", "v");
        }

        /// Determines the order at which the legend items are displayed. If *normal*, the items are displayed top-to-bottom in the same order as the input data. If *reversed*, the items are displayed in the opposite order as *normal*. If *grouped*, the items are displayed in groups (when a trace `legendgroup` is provided). if *grouped+reversed*, the items are displayed in the opposite order as *grouped*.
        public static partial class Traceorder
        {
            public static Box<ILegendProperty> normal() => Interop.mkLegendAttr("traceorder", "normal");
            public static Box<ILegendProperty> grouped() => Interop.mkLegendAttr("traceorder", "grouped");
            public static Box<ILegendProperty> reversed() => Interop.mkLegendAttr("traceorder", "reversed");
        }

        /// Determines if the legend items symbols scale with their corresponding *trace* attributes or remain *constant* independent of the symbol size on the graph.
        public static partial class Itemsizing
        {
            public static Box<ILegendProperty> constant() => Interop.mkLegendAttr("itemsizing", "constant");
            public static Box<ILegendProperty> trace() => Interop.mkLegendAttr("itemsizing", "trace");
        }

        /// Determines the behavior on legend item click. *toggle* toggles the visibility of the item clicked on the graph. *toggleothers* makes the clicked item the sole visible item on the graph. *false* disable legend item click interactions.
        public static partial class Itemclick
        {
            public static Box<ILegendProperty> toggle() => Interop.mkLegendAttr("itemclick", "toggle");
            public static Box<ILegendProperty> toggleothers() => Interop.mkLegendAttr("itemclick", "toggleothers");
            public static Box<ILegendProperty> _false() => Interop.mkLegendAttr("itemclick", false);
        }

        /// Determines the behavior on legend item double-click. *toggle* toggles the visibility of the item clicked on the graph. *toggleothers* makes the clicked item the sole visible item on the graph. *false* disable legend item double-click interactions.
        public static partial class Itemdoubleclick
        {
            public static Box<ILegendProperty> toggle() => Interop.mkLegendAttr("itemdoubleclick", "toggle");
            public static Box<ILegendProperty> toggleothers() => Interop.mkLegendAttr("itemdoubleclick", "toggleothers");
            public static Box<ILegendProperty> _false() => Interop.mkLegendAttr("itemdoubleclick", false);
        }

        /// Sets the legend's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the legend. Value *auto* anchors legends to the right for `x` values greater than or equal to 2/3, anchors legends to the left for `x` values less than or equal to 1/3 and anchors legends with respect to their center otherwise.
        public static partial class Xanchor
        {
            public static Box<ILegendProperty> auto() => Interop.mkLegendAttr("xanchor", "auto");
            public static Box<ILegendProperty> center() => Interop.mkLegendAttr("xanchor", "center");
            public static Box<ILegendProperty> left() => Interop.mkLegendAttr("xanchor", "left");
            public static Box<ILegendProperty> right() => Interop.mkLegendAttr("xanchor", "right");
        }

        /// Sets the legend's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the legend. Value *auto* anchors legends at their bottom for `y` values less than or equal to 1/3, anchors legends to at their top for `y` values greater than or equal to 2/3 and anchors legends with respect to their middle otherwise.
        public static partial class Yanchor
        {
            public static Box<ILegendProperty> auto() => Interop.mkLegendAttr("yanchor", "auto");
            public static Box<ILegendProperty> bottom() => Interop.mkLegendAttr("yanchor", "bottom");
            public static Box<ILegendProperty> middle() => Interop.mkLegendAttr("yanchor", "middle");
            public static Box<ILegendProperty> top() => Interop.mkLegendAttr("yanchor", "top");
        }

        /// Sets the vertical alignment of the symbols with respect to their associated text.
        public static partial class Valign
        {
            public static Box<ILegendProperty> bottom() => Interop.mkLegendAttr("valign", "bottom");
            public static Box<ILegendProperty> middle() => Interop.mkLegendAttr("valign", "middle");
            public static Box<ILegendProperty> top() => Interop.mkLegendAttr("valign", "top");
        }
    }
}