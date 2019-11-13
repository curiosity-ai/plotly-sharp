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

    public static partial class Layout
    {
        /// Sets the gap (in plot fraction) between bars of adjacent location coordinates.
        public static Box<ILayoutProperty> bargap(int val) => Interop.mkLayoutAttr("bargap", val);
        /// Sets the gap (in plot fraction) between bars of adjacent location coordinates.
        public static Box<ILayoutProperty> bargap(float val) => Interop.mkLayoutAttr("bargap", val);
        /// Sets the gap (in plot fraction) between bars of the same location coordinate.
        public static Box<ILayoutProperty> bargroupgap(int val) => Interop.mkLayoutAttr("bargroupgap", val);
        /// Sets the gap (in plot fraction) between bars of the same location coordinate.
        public static Box<ILayoutProperty> bargroupgap(float val) => Interop.mkLayoutAttr("bargroupgap", val);
        /// Sets the gap (in plot fraction) between boxes of adjacent location coordinates. Has no effect on traces that have *width* set.
        public static Box<ILayoutProperty> boxgap(int val) => Interop.mkLayoutAttr("boxgap", val);
        /// Sets the gap (in plot fraction) between boxes of adjacent location coordinates. Has no effect on traces that have *width* set.
        public static Box<ILayoutProperty> boxgap(float val) => Interop.mkLayoutAttr("boxgap", val);
        /// Sets the gap (in plot fraction) between boxes of the same location coordinate. Has no effect on traces that have *width* set.
        public static Box<ILayoutProperty> boxgroupgap(int val) => Interop.mkLayoutAttr("boxgroupgap", val);
        /// Sets the gap (in plot fraction) between boxes of the same location coordinate. Has no effect on traces that have *width* set.
        public static Box<ILayoutProperty> boxgroupgap(float val) => Interop.mkLayoutAttr("boxgroupgap", val);
        /// Sets the gap (in plot fraction) between violins of adjacent location coordinates. Has no effect on traces that have *width* set.
        public static Box<ILayoutProperty> violingap(int val) => Interop.mkLayoutAttr("violingap", val);
        /// Sets the gap (in plot fraction) between violins of adjacent location coordinates. Has no effect on traces that have *width* set.
        public static Box<ILayoutProperty> violingap(float val) => Interop.mkLayoutAttr("violingap", val);
        /// Sets the gap (in plot fraction) between violins of the same location coordinate. Has no effect on traces that have *width* set.
        public static Box<ILayoutProperty> violingroupgap(int val) => Interop.mkLayoutAttr("violingroupgap", val);
        /// Sets the gap (in plot fraction) between violins of the same location coordinate. Has no effect on traces that have *width* set.
        public static Box<ILayoutProperty> violingroupgap(float val) => Interop.mkLayoutAttr("violingroupgap", val);
        /// Sets the gap (in plot fraction) between bars of adjacent location coordinates.
        public static Box<ILayoutProperty> funnelgap(int val) => Interop.mkLayoutAttr("funnelgap", val);
        /// Sets the gap (in plot fraction) between bars of adjacent location coordinates.
        public static Box<ILayoutProperty> funnelgap(float val) => Interop.mkLayoutAttr("funnelgap", val);
        /// Sets the gap (in plot fraction) between bars of the same location coordinate.
        public static Box<ILayoutProperty> funnelgroupgap(int val) => Interop.mkLayoutAttr("funnelgroupgap", val);
        /// Sets the gap (in plot fraction) between bars of the same location coordinate.
        public static Box<ILayoutProperty> funnelgroupgap(float val) => Interop.mkLayoutAttr("funnelgroupgap", val);
        /// Sets the gap (in plot fraction) between bars of adjacent location coordinates.
        public static Box<ILayoutProperty> waterfallgap(int val) => Interop.mkLayoutAttr("waterfallgap", val);
        /// Sets the gap (in plot fraction) between bars of adjacent location coordinates.
        public static Box<ILayoutProperty> waterfallgap(float val) => Interop.mkLayoutAttr("waterfallgap", val);
        /// Sets the gap (in plot fraction) between bars of the same location coordinate.
        public static Box<ILayoutProperty> waterfallgroupgap(int val) => Interop.mkLayoutAttr("waterfallgroupgap", val);
        /// Sets the gap (in plot fraction) between bars of the same location coordinate.
        public static Box<ILayoutProperty> waterfallgroupgap(float val) => Interop.mkLayoutAttr("waterfallgroupgap", val);
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        public static Box<ILayoutProperty> hiddenlabels(bool val) => Interop.mkLayoutAttr("hiddenlabels", new[]{val});
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        public static Box<ILayoutProperty> hiddenlabels(params bool[] values) => Interop.mkLayoutAttr("hiddenlabels", values);
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        public static Box<ILayoutProperty> hiddenlabels(System.DateTime val) => Interop.mkLayoutAttr("hiddenlabels", new[]{val});
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        public static Box<ILayoutProperty> hiddenlabels(params System.DateTime[] values) => Interop.mkLayoutAttr("hiddenlabels", values);
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        public static Box<ILayoutProperty> hiddenlabels(float val) => Interop.mkLayoutAttr("hiddenlabels", new[]{val});
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        public static Box<ILayoutProperty> hiddenlabels(params float[] values) => Interop.mkLayoutAttr("hiddenlabels", values);
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        public static Box<ILayoutProperty> hiddenlabels(int val) => Interop.mkLayoutAttr("hiddenlabels", new[]{val});
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        public static Box<ILayoutProperty> hiddenlabels(params int[] values) => Interop.mkLayoutAttr("hiddenlabels", values);
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        public static Box<ILayoutProperty> hiddenlabels(string val) => Interop.mkLayoutAttr("hiddenlabels", new[]{val});
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        public static Box<ILayoutProperty> hiddenlabels(params string[] values) => Interop.mkLayoutAttr("hiddenlabels", values);
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        public static Box<ILayoutProperty> hiddenlabels(IEnumerable<bool[]> values) => Interop.mkLayoutAttr("hiddenlabels", Bindings.flatten2DArrayIf1D(values));
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        public static Box<ILayoutProperty> hiddenlabels(List<bool[]> values) => Interop.mkLayoutAttr("hiddenlabels", Bindings.flatten2DArrayIf1D(values));
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        public static Box<ILayoutProperty> hiddenlabels(params bool[][] values) => Interop.mkLayoutAttr("hiddenlabels", Bindings.flatten2DArrayIf1D(values));
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        public static Box<ILayoutProperty> hiddenlabels(IEnumerable<IEnumerable<string>> values) => Interop.mkLayoutAttr("hiddenlabels", Bindings.flatten2DArrayIf1D(values));
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        public static Box<ILayoutProperty> hiddenlabels(List<string[]> values) => Interop.mkLayoutAttr("hiddenlabels", Bindings.flatten2DArrayIf1D(values));
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        public static Box<ILayoutProperty> hiddenlabels(params string[][] values) => Interop.mkLayoutAttr("hiddenlabels", Bindings.flatten2DArrayIf1D(values));
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        public static Box<ILayoutProperty> hiddenlabels(IEnumerable<IEnumerable<int>> values) => Interop.mkLayoutAttr("hiddenlabels", Bindings.flatten2DArrayIf1D(values));
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        public static Box<ILayoutProperty> hiddenlabels(List<int[]> values) => Interop.mkLayoutAttr("hiddenlabels", Bindings.flatten2DArrayIf1D(values));
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        public static Box<ILayoutProperty> hiddenlabels(params int[][] values) => Interop.mkLayoutAttr("hiddenlabels", Bindings.flatten2DArrayIf1D(values));
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        public static Box<ILayoutProperty> hiddenlabels(IEnumerable<IEnumerable<float>> values) => Interop.mkLayoutAttr("hiddenlabels", Bindings.flatten2DArrayIf1D(values));
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        public static Box<ILayoutProperty> hiddenlabels(List<float[]> values) => Interop.mkLayoutAttr("hiddenlabels", Bindings.flatten2DArrayIf1D(values));
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        public static Box<ILayoutProperty> hiddenlabels(params float[][] values) => Interop.mkLayoutAttr("hiddenlabels", Bindings.flatten2DArrayIf1D(values));
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        public static Box<ILayoutProperty> hiddenlabels(Literals.PlotData[] values) => Interop.mkLayoutAttr("hiddenlabels", values);
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        public static Box<ILayoutProperty> hiddenlabels(IEnumerable<bool?> values) => Interop.mkLayoutAttr("hiddenlabels", values.ToArray());
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        public static Box<ILayoutProperty> hiddenlabels(IEnumerable<System.DateTime?> values) => Interop.mkLayoutAttr("hiddenlabels", values.ToArray());
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        public static Box<ILayoutProperty> hiddenlabels(IEnumerable<int?> values) => Interop.mkLayoutAttr("hiddenlabels", values.ToArray());
        /// hiddenlabels is the funnelarea & pie chart analog of visible:'legendonly' but it can contain many labels, and can simultaneously hide slices from several pies/funnelarea charts
        public static Box<ILayoutProperty> hiddenlabels(IEnumerable<float?> values) => Interop.mkLayoutAttr("hiddenlabels", values.ToArray());
        /// Sets the default pie slice colors. Defaults to the main `colorway` used for trace colors. If you specify a new list here it can still be extended with lighter and darker colors, see `extendpiecolors`.
        public static Box<ILayoutProperty> piecolorway(string val) => Interop.mkLayoutAttr("piecolorway", new[]{val});
        /// Sets the default pie slice colors. Defaults to the main `colorway` used for trace colors. If you specify a new list here it can still be extended with lighter and darker colors, see `extendpiecolors`.
        public static Box<ILayoutProperty> piecolorway(IEnumerable<string> values) => Interop.mkLayoutAttr("piecolorway", values.ToArray());
        /// If `true`, the pie slice colors (whether given by `piecolorway` or inherited from `colorway`) will be extended to three times its original length by first repeating every color 20% lighter then each color 20% darker. This is intended to reduce the likelihood of reusing the same color when you have many slices, but you can set `false` to disable. Colors provided in the trace, using `marker.colors`, are never extended.
        public static Box<ILayoutProperty> extendpiecolors(bool val) => Interop.mkLayoutAttr("extendpiecolors", val);
        /// Sets the source reference on plot.ly for  hiddenlabels .
        public static Box<ILayoutProperty> hiddenlabelssrc(string val) => Interop.mkLayoutAttr("hiddenlabelssrc", val);
        /// Sets the default sunburst slice colors. Defaults to the main `colorway` used for trace colors. If you specify a new list here it can still be extended with lighter and darker colors, see `extendsunburstcolors`.
        public static Box<ILayoutProperty> sunburstcolorway(string val) => Interop.mkLayoutAttr("sunburstcolorway", new[]{val});
        /// Sets the default sunburst slice colors. Defaults to the main `colorway` used for trace colors. If you specify a new list here it can still be extended with lighter and darker colors, see `extendsunburstcolors`.
        public static Box<ILayoutProperty> sunburstcolorway(IEnumerable<string> values) => Interop.mkLayoutAttr("sunburstcolorway", values.ToArray());
        /// If `true`, the sunburst slice colors (whether given by `sunburstcolorway` or inherited from `colorway`) will be extended to three times its original length by first repeating every color 20% lighter then each color 20% darker. This is intended to reduce the likelihood of reusing the same color when you have many slices, but you can set `false` to disable. Colors provided in the trace, using `marker.colors`, are never extended.
        public static Box<ILayoutProperty> extendsunburstcolors(bool val) => Interop.mkLayoutAttr("extendsunburstcolors", val);
        /// Sets the default treemap slice colors. Defaults to the main `colorway` used for trace colors. If you specify a new list here it can still be extended with lighter and darker colors, see `extendtreemapcolors`.
        public static Box<ILayoutProperty> treemapcolorway(string val) => Interop.mkLayoutAttr("treemapcolorway", new[]{val});
        /// Sets the default treemap slice colors. Defaults to the main `colorway` used for trace colors. If you specify a new list here it can still be extended with lighter and darker colors, see `extendtreemapcolors`.
        public static Box<ILayoutProperty> treemapcolorway(IEnumerable<string> values) => Interop.mkLayoutAttr("treemapcolorway", values.ToArray());
        /// If `true`, the treemap slice colors (whether given by `treemapcolorway` or inherited from `colorway`) will be extended to three times its original length by first repeating every color 20% lighter then each color 20% darker. This is intended to reduce the likelihood of reusing the same color when you have many slices, but you can set `false` to disable. Colors provided in the trace, using `marker.colors`, are never extended.
        public static Box<ILayoutProperty> extendtreemapcolors(bool val) => Interop.mkLayoutAttr("extendtreemapcolors", val);
        /// Sets the default funnelarea slice colors. Defaults to the main `colorway` used for trace colors. If you specify a new list here it can still be extended with lighter and darker colors, see `extendfunnelareacolors`.
        public static Box<ILayoutProperty> funnelareacolorway(string val) => Interop.mkLayoutAttr("funnelareacolorway", new[]{val});
        /// Sets the default funnelarea slice colors. Defaults to the main `colorway` used for trace colors. If you specify a new list here it can still be extended with lighter and darker colors, see `extendfunnelareacolors`.
        public static Box<ILayoutProperty> funnelareacolorway(IEnumerable<string> values) => Interop.mkLayoutAttr("funnelareacolorway", values.ToArray());
        /// If `true`, the funnelarea slice colors (whether given by `funnelareacolorway` or inherited from `colorway`) will be extended to three times its original length by first repeating every color 20% lighter then each color 20% darker. This is intended to reduce the likelihood of reusing the same color when you have many slices, but you can set `false` to disable. Colors provided in the trace, using `marker.colors`, are never extended.
        public static Box<ILayoutProperty> extendfunnelareacolors(bool val) => Interop.mkLayoutAttr("extendfunnelareacolors", val);
        /// Sets the global font. Note that fonts used in traces and other layout components inherit from the global font.
        public static Box<ILayoutProperty> font(params Box<IFontProperty>[] properties) => Interop.mkLayoutAttr("font", Bindings.flattenProperties(properties));
        public static Box<ILayoutProperty> title(params Box<ITitleProperty>[] properties) => Interop.mkLayoutAttr("title", Bindings.flattenProperties(properties));
        /// Determines whether or not a layout width or height that has been left undefined by the user is initialized on each relayout. Note that, regardless of this attribute, an undefined layout width or height is always initialized on the first call to plot.
        public static Box<ILayoutProperty> autosize(bool val) => Interop.mkLayoutAttr("autosize", val);
        /// Sets the plot's width (in px).
        public static Box<ILayoutProperty> width(int val) => Interop.mkLayoutAttr("width", val);
        /// Sets the plot's width (in px).
        public static Box<ILayoutProperty> width(float val) => Interop.mkLayoutAttr("width", val);
        /// Sets the plot's height (in px).
        public static Box<ILayoutProperty> height(int val) => Interop.mkLayoutAttr("height", val);
        /// Sets the plot's height (in px).
        public static Box<ILayoutProperty> height(float val) => Interop.mkLayoutAttr("height", val);
        public static Box<ILayoutProperty> margin(params Box<IMarginProperty>[] properties) => Interop.mkLayoutAttr("margin", Bindings.flattenProperties(properties));
        /// Sets the color of paper where the graph is drawn.
        public static Box<ILayoutProperty> paperBgcolor(string val) => Interop.mkLayoutAttr("paper_bgcolor", val);
        /// Sets the color of plotting area in-between x and y axes.
        public static Box<ILayoutProperty> plotBgcolor(string val) => Interop.mkLayoutAttr("plot_bgcolor", val);
        /// Sets the decimal and thousand separators. For example, *. * puts a '.' before decimals and a space between thousands. In English locales, dflt is *.,* but other locales may alter this default.
        public static Box<ILayoutProperty> separators(string val) => Interop.mkLayoutAttr("separators", val);
        /// Determines whether or not a text link citing the data source is placed at the bottom-right cored of the figure. Has only an effect only on graphs that have been generated via forked graphs from the plotly service (at https://plot.ly or on-premise).
        public static Box<ILayoutProperty> hidesources(bool val) => Interop.mkLayoutAttr("hidesources", val);
        /// Determines whether or not a legend is drawn. Default is `true` if there is a trace to show and any of these: a) Two or more traces would by default be shown in the legend. b) One pie trace is shown in the legend. c) One trace is explicitly given with `showlegend: true`.
        public static Box<ILayoutProperty> showlegend(bool val) => Interop.mkLayoutAttr("showlegend", val);
        /// Sets the default trace colors.
        public static Box<ILayoutProperty> colorway(string val) => Interop.mkLayoutAttr("colorway", new[]{val});
        /// Sets the default trace colors.
        public static Box<ILayoutProperty> colorway(IEnumerable<string> values) => Interop.mkLayoutAttr("colorway", values.ToArray());
        /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
        public static Box<ILayoutProperty> datarevision(bool val) => Interop.mkLayoutAttr("datarevision", val);
        /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
        public static Box<ILayoutProperty> datarevision(params bool[] values) => Interop.mkLayoutAttr("datarevision", values);
        /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
        public static Box<ILayoutProperty> datarevision(System.DateTime val) => Interop.mkLayoutAttr("datarevision", val);
        /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
        public static Box<ILayoutProperty> datarevision(params System.DateTime[] values) => Interop.mkLayoutAttr("datarevision", values);
        /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
        public static Box<ILayoutProperty> datarevision(int val) => Interop.mkLayoutAttr("datarevision", val);
        /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
        public static Box<ILayoutProperty> datarevision(params int[] values) => Interop.mkLayoutAttr("datarevision", values);
        /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
        public static Box<ILayoutProperty> datarevision(float val) => Interop.mkLayoutAttr("datarevision", val);
        /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
        public static Box<ILayoutProperty> datarevision(params float[] values) => Interop.mkLayoutAttr("datarevision", values);
        /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
        public static Box<ILayoutProperty> datarevision(string val) => Interop.mkLayoutAttr("datarevision", val);
        /// If provided, a changed value tells `Plotly.react` that one or more data arrays has changed. This way you can modify arrays in-place rather than making a complete new copy for an incremental change. If NOT provided, `Plotly.react` assumes that data arrays are being treated as immutable, thus any data array with a different identity from its predecessor contains new data.
        public static Box<ILayoutProperty> datarevision(params string[] values) => Interop.mkLayoutAttr("datarevision", values);
        /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
        public static Box<ILayoutProperty> uirevision(bool val) => Interop.mkLayoutAttr("uirevision", val);
        /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
        public static Box<ILayoutProperty> uirevision(params bool[] values) => Interop.mkLayoutAttr("uirevision", values);
        /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
        public static Box<ILayoutProperty> uirevision(System.DateTime val) => Interop.mkLayoutAttr("uirevision", val);
        /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
        public static Box<ILayoutProperty> uirevision(params System.DateTime[] values) => Interop.mkLayoutAttr("uirevision", values);
        /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
        public static Box<ILayoutProperty> uirevision(int val) => Interop.mkLayoutAttr("uirevision", val);
        /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
        public static Box<ILayoutProperty> uirevision(params int[] values) => Interop.mkLayoutAttr("uirevision", values);
        /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
        public static Box<ILayoutProperty> uirevision(float val) => Interop.mkLayoutAttr("uirevision", val);
        /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
        public static Box<ILayoutProperty> uirevision(params float[] values) => Interop.mkLayoutAttr("uirevision", values);
        /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
        public static Box<ILayoutProperty> uirevision(string val) => Interop.mkLayoutAttr("uirevision", val);
        /// Used to allow user interactions with the plot to persist after `Plotly.react` calls that are unaware of these interactions. If `uirevision` is omitted, or if it is given and it changed from the previous `Plotly.react` call, the exact new figure is used. If `uirevision` is truthy and did NOT change, any attribute that has been affected by user interactions and did not receive a different value in the new figure will keep the interaction value. `layout.uirevision` attribute serves as the default for `uirevision` attributes in various sub-containers. For finer control you can set these sub-attributes directly. For example, if your app separately controls the data on the x and y axes you might set `xaxis.uirevision=*time*` and `yaxis.uirevision=*cost*`. Then if only the y data is changed, you can update `yaxis.uirevision=*quantity*` and the y axis range will reset but the x axis range will retain any user-driven zoom.
        public static Box<ILayoutProperty> uirevision(params string[] values) => Interop.mkLayoutAttr("uirevision", values);
        /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
        public static Box<ILayoutProperty> editrevision(bool val) => Interop.mkLayoutAttr("editrevision", val);
        /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
        public static Box<ILayoutProperty> editrevision(params bool[] values) => Interop.mkLayoutAttr("editrevision", values);
        /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
        public static Box<ILayoutProperty> editrevision(System.DateTime val) => Interop.mkLayoutAttr("editrevision", val);
        /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
        public static Box<ILayoutProperty> editrevision(params System.DateTime[] values) => Interop.mkLayoutAttr("editrevision", values);
        /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
        public static Box<ILayoutProperty> editrevision(int val) => Interop.mkLayoutAttr("editrevision", val);
        /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
        public static Box<ILayoutProperty> editrevision(params int[] values) => Interop.mkLayoutAttr("editrevision", values);
        /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
        public static Box<ILayoutProperty> editrevision(float val) => Interop.mkLayoutAttr("editrevision", val);
        /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
        public static Box<ILayoutProperty> editrevision(params float[] values) => Interop.mkLayoutAttr("editrevision", values);
        /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
        public static Box<ILayoutProperty> editrevision(string val) => Interop.mkLayoutAttr("editrevision", val);
        /// Controls persistence of user-driven changes in `editable: true` configuration, other than trace names and axis titles. Defaults to `layout.uirevision`.
        public static Box<ILayoutProperty> editrevision(params string[] values) => Interop.mkLayoutAttr("editrevision", values);
        /// Controls persistence of user-driven changes in selected points from all traces.
        public static Box<ILayoutProperty> selectionrevision(bool val) => Interop.mkLayoutAttr("selectionrevision", val);
        /// Controls persistence of user-driven changes in selected points from all traces.
        public static Box<ILayoutProperty> selectionrevision(params bool[] values) => Interop.mkLayoutAttr("selectionrevision", values);
        /// Controls persistence of user-driven changes in selected points from all traces.
        public static Box<ILayoutProperty> selectionrevision(System.DateTime val) => Interop.mkLayoutAttr("selectionrevision", val);
        /// Controls persistence of user-driven changes in selected points from all traces.
        public static Box<ILayoutProperty> selectionrevision(params System.DateTime[] values) => Interop.mkLayoutAttr("selectionrevision", values);
        /// Controls persistence of user-driven changes in selected points from all traces.
        public static Box<ILayoutProperty> selectionrevision(int val) => Interop.mkLayoutAttr("selectionrevision", val);
        /// Controls persistence of user-driven changes in selected points from all traces.
        public static Box<ILayoutProperty> selectionrevision(params int[] values) => Interop.mkLayoutAttr("selectionrevision", values);
        /// Controls persistence of user-driven changes in selected points from all traces.
        public static Box<ILayoutProperty> selectionrevision(float val) => Interop.mkLayoutAttr("selectionrevision", val);
        /// Controls persistence of user-driven changes in selected points from all traces.
        public static Box<ILayoutProperty> selectionrevision(params float[] values) => Interop.mkLayoutAttr("selectionrevision", values);
        /// Controls persistence of user-driven changes in selected points from all traces.
        public static Box<ILayoutProperty> selectionrevision(string val) => Interop.mkLayoutAttr("selectionrevision", val);
        /// Controls persistence of user-driven changes in selected points from all traces.
        public static Box<ILayoutProperty> selectionrevision(params string[] values) => Interop.mkLayoutAttr("selectionrevision", values);
        /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
        public static Box<ILayoutProperty> template(bool val) => Interop.mkLayoutAttr("template", val);
        /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
        public static Box<ILayoutProperty> template(params bool[] values) => Interop.mkLayoutAttr("template", values);
        /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
        public static Box<ILayoutProperty> template(System.DateTime val) => Interop.mkLayoutAttr("template", val);
        /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
        public static Box<ILayoutProperty> template(params System.DateTime[] values) => Interop.mkLayoutAttr("template", values);
        /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
        public static Box<ILayoutProperty> template(int val) => Interop.mkLayoutAttr("template", val);
        /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
        public static Box<ILayoutProperty> template(params int[] values) => Interop.mkLayoutAttr("template", values);
        /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
        public static Box<ILayoutProperty> template(float val) => Interop.mkLayoutAttr("template", val);
        /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
        public static Box<ILayoutProperty> template(params float[] values) => Interop.mkLayoutAttr("template", values);
        /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
        public static Box<ILayoutProperty> template(string val) => Interop.mkLayoutAttr("template", val);
        /// Default attributes to be applied to the plot. Templates can be created from existing plots using `Plotly.makeTemplate`, or created manually. They should be objects with format: `{layout: layoutTemplate, data: {[type]: [traceTemplate, ...]}, ...}` `layoutTemplate` and `traceTemplate` are objects matching the attribute structure of `layout` and a data trace.  Trace templates are applied cyclically to traces of each type. Container arrays (eg `annotations`) have special handling: An object ending in `defaults` (eg `annotationdefaults`) is applied to each array item. But if an item has a `templateitemname` key we look in the template array for an item with matching `name` and apply that instead. If no matching `name` is found we mark the item invisible. Any named template item not referenced is appended to the end of the array, so you can use this for a watermark annotation or a logo image, for example. To omit one of these items on the plot, make an item with matching `templateitemname` and `visible: false`.
        public static Box<ILayoutProperty> template(params string[] values) => Interop.mkLayoutAttr("template", values);
        public static Box<ILayoutProperty> modebar(params Box<IModebarProperty>[] properties) => Interop.mkLayoutAttr("modebar", Bindings.flattenProperties(properties));
        /// Sets transition options used during Plotly.react updates.
        public static Box<ILayoutProperty> transition(params Box<ITransitionProperty>[] properties) => Interop.mkLayoutAttr("transition", Bindings.flattenProperties(properties));
        /// Determines the mode of single click interactions. *event* is the default value and emits the `plotly_click` event. In addition this mode emits the `plotly_selected` event in drag modes *lasso* and *select*, but with no event data attached (kept for compatibility reasons). The *select* flag enables selecting single data points via click. This mode also supports persistent selections, meaning that pressing Shift while clicking, adds to / subtracts from an existing selection. *select* with `hovermode`: *x* can be confusing, consider explicitly setting `hovermode`: *closest* when using this feature. Selection events are sent accordingly as long as *event* flag is set as well. When the *event* flag is missing, `plotly_click` and `plotly_selected` events are not fired.
        public static Box<ILayoutProperty> clickmode(params Box<ILayoutProperty>[] properties) => Interop.mkLayoutAttr("clickmode", Script.Write<object>("{0}.join('+')", properties));
        /// Sets the default distance (in pixels) to look for data to add hover labels (-1 means no cutoff, 0 means no looking for data). This is only a real distance for hovering on point-like objects, like scatter points. For area-like objects (bars, scatter fills, etc) hovering is on inside the area and off outside, but these objects will not supersede hover on point-like objects in case of conflict.
        public static Box<ILayoutProperty> hoverdistance(int val) => Interop.mkLayoutAttr("hoverdistance", val);
        /// Sets the default distance (in pixels) to look for data to draw spikelines to (-1 means no cutoff, 0 means no looking for data). As with hoverdistance, distance does not apply to area-like objects. In addition, some objects can be hovered on but will not generate spikelines, such as scatter fills.
        public static Box<ILayoutProperty> spikedistance(int val) => Interop.mkLayoutAttr("spikedistance", val);
        public static Box<ILayoutProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkLayoutAttr("hoverlabel", Bindings.flattenProperties(properties));
        public static Box<ILayoutProperty> grid(params Box<IGridProperty>[] properties) => Interop.mkLayoutAttr("grid", Bindings.flattenProperties(properties));
        public static Box<ILayoutProperty> xaxis(int id, params Box<IXaxisProperty>[] properties) => Interop.mkLayoutAttr($"xaxis{id}", Bindings.flattenProperties(properties));
        public static Box<ILayoutProperty> xaxis(params Box<IXaxisProperty>[] properties) => Interop.mkLayoutAttr("xaxis", Bindings.flattenProperties(properties));
        public static Box<ILayoutProperty> yaxis(int id, params Box<IYaxisProperty>[] properties) => Interop.mkLayoutAttr($"yaxis{id}", Bindings.flattenProperties(properties));
        public static Box<ILayoutProperty> yaxis(params Box<IYaxisProperty>[] properties) => Interop.mkLayoutAttr("yaxis", Bindings.flattenProperties(properties));
        public static Box<ILayoutProperty> ternary(int id, params Box<ITernaryProperty>[] properties) => Interop.mkLayoutAttr($"ternary{id}", Bindings.flattenProperties(properties));
        public static Box<ILayoutProperty> ternary(params Box<ITernaryProperty>[] properties) => Interop.mkLayoutAttr("ternary", Bindings.flattenProperties(properties));
        public static Box<ILayoutProperty> scene(int id, params Box<ISceneProperty>[] properties) => Interop.mkLayoutAttr($"scene{id}", Bindings.flattenProperties(properties));
        public static Box<ILayoutProperty> scene(params Box<ISceneProperty>[] properties) => Interop.mkLayoutAttr("scene", Bindings.flattenProperties(properties));
        public static Box<ILayoutProperty> geo(int id, params Box<IGeoProperty>[] properties) => Interop.mkLayoutAttr($"geo{id}", Bindings.flattenProperties(properties));
        public static Box<ILayoutProperty> geo(params Box<IGeoProperty>[] properties) => Interop.mkLayoutAttr("geo", Bindings.flattenProperties(properties));
        public static Box<ILayoutProperty> mapbox(int id, params Box<IMapboxProperty>[] properties) => Interop.mkLayoutAttr($"mapbox{id}", Bindings.flattenProperties(properties));
        public static Box<ILayoutProperty> mapbox(params Box<IMapboxProperty>[] properties) => Interop.mkLayoutAttr("mapbox", Bindings.flattenProperties(properties));
        public static Box<ILayoutProperty> polar(int id, params Box<IPolarProperty>[] properties) => Interop.mkLayoutAttr($"polar{id}", Bindings.flattenProperties(properties));
        public static Box<ILayoutProperty> polar(params Box<IPolarProperty>[] properties) => Interop.mkLayoutAttr("polar", Bindings.flattenProperties(properties));
        public static Box<ILayoutProperty> legend(params Box<ILegendProperty>[] properties) => Interop.mkLayoutAttr("legend", Bindings.flattenProperties(properties));
        public static Box<ILayoutProperty> annotations(params Box<IAnnotationsProperty>[] properties) => Interop.mkLayoutAttr("annotations", Bindings.flattenPropertiesToArray(properties));
        public static Box<ILayoutProperty> shapes(params Box<IShapesProperty>[] properties) => Interop.mkLayoutAttr("shapes", Bindings.flattenProperties(properties));
        public static Box<ILayoutProperty> images(params Box<IImagesProperty>[] properties) => Interop.mkLayoutAttr("images", Bindings.flattenProperties(properties));
        public static Box<ILayoutProperty> updatemenus(params Box<IUpdatemenusProperty>[] properties) => Interop.mkLayoutAttr("updatemenus", Bindings.flattenProperties(properties));
        public static Box<ILayoutProperty> sliders(params Box<ISlidersProperty>[] properties) => Interop.mkLayoutAttr("sliders", Bindings.flattenProperties(properties));
        public static Box<ILayoutProperty> colorscale(params Box<IColorscaleProperty>[] properties) => Interop.mkLayoutAttr("colorscale", Bindings.flattenProperties(properties));
        public static Box<ILayoutProperty> coloraxis(int id, params Box<IColoraxisProperty>[] properties) => Interop.mkLayoutAttr($"coloraxis{id}", Bindings.flattenProperties(properties));
        public static Box<ILayoutProperty> coloraxis(params Box<IColoraxisProperty>[] properties) => Interop.mkLayoutAttr("coloraxis", Bindings.flattenProperties(properties));
        /// Sets the source reference on plot.ly for  meta .
        public static Box<ILayoutProperty> metasrc(string val) => Interop.mkLayoutAttr("metasrc", val);
    }

    public static partial class Layout
    {
        /// Determines how bars at the same location coordinate are displayed on the graph. With *stack*, the bars are stacked on top of one another With *relative*, the bars are stacked on top of one another, with negative values below the axis, positive values above With *group*, the bars are plotted next to one another centered around the shared location. With *overlay*, the bars are plotted over one another, you might need to an *opacity* to see multiple bars.
        public static partial class Barmode
        {
            public static Box<ILayoutProperty> group() => Interop.mkLayoutAttr("barmode", "group");
            public static Box<ILayoutProperty> overlay() => Interop.mkLayoutAttr("barmode", "overlay");
            public static Box<ILayoutProperty> relative() => Interop.mkLayoutAttr("barmode", "relative");
            public static Box<ILayoutProperty> stack() => Interop.mkLayoutAttr("barmode", "stack");
        }

        /// Sets the normalization for bar traces on the graph. With *fraction*, the value of each bar is divided by the sum of all values at that location coordinate. *percent* is the same but multiplied by 100 to show percentages.
        public static partial class Barnorm
        {
            public static Box<ILayoutProperty> none() => Interop.mkLayoutAttr("barnorm", "");
            public static Box<ILayoutProperty> fraction() => Interop.mkLayoutAttr("barnorm", "fraction");
            public static Box<ILayoutProperty> percent() => Interop.mkLayoutAttr("barnorm", "percent");
        }

        /// Determines how boxes at the same location coordinate are displayed on the graph. If *group*, the boxes are plotted next to one another centered around the shared location. If *overlay*, the boxes are plotted over one another, you might need to set *opacity* to see them multiple boxes. Has no effect on traces that have *width* set.
        public static partial class Boxmode
        {
            public static Box<ILayoutProperty> group() => Interop.mkLayoutAttr("boxmode", "group");
            public static Box<ILayoutProperty> overlay() => Interop.mkLayoutAttr("boxmode", "overlay");
        }

        /// Determines how violins at the same location coordinate are displayed on the graph. If *group*, the violins are plotted next to one another centered around the shared location. If *overlay*, the violins are plotted over one another, you might need to set *opacity* to see them multiple violins. Has no effect on traces that have *width* set.
        public static partial class Violinmode
        {
            public static Box<ILayoutProperty> group() => Interop.mkLayoutAttr("violinmode", "group");
            public static Box<ILayoutProperty> overlay() => Interop.mkLayoutAttr("violinmode", "overlay");
        }

        /// Determines how bars at the same location coordinate are displayed on the graph. With *stack*, the bars are stacked on top of one another With *group*, the bars are plotted next to one another centered around the shared location. With *overlay*, the bars are plotted over one another, you might need to an *opacity* to see multiple bars.
        public static partial class Funnelmode
        {
            public static Box<ILayoutProperty> group() => Interop.mkLayoutAttr("funnelmode", "group");
            public static Box<ILayoutProperty> overlay() => Interop.mkLayoutAttr("funnelmode", "overlay");
            public static Box<ILayoutProperty> stack() => Interop.mkLayoutAttr("funnelmode", "stack");
        }

        /// Determines how bars at the same location coordinate are displayed on the graph. With *group*, the bars are plotted next to one another centered around the shared location. With *overlay*, the bars are plotted over one another, you might need to an *opacity* to see multiple bars.
        public static partial class Waterfallmode
        {
            public static Box<ILayoutProperty> group() => Interop.mkLayoutAttr("waterfallmode", "group");
            public static Box<ILayoutProperty> overlay() => Interop.mkLayoutAttr("waterfallmode", "overlay");
        }

        /// Determines the mode of single click interactions. *event* is the default value and emits the `plotly_click` event. In addition this mode emits the `plotly_selected` event in drag modes *lasso* and *select*, but with no event data attached (kept for compatibility reasons). The *select* flag enables selecting single data points via click. This mode also supports persistent selections, meaning that pressing Shift while clicking, adds to / subtracts from an existing selection. *select* with `hovermode`: *x* can be confusing, consider explicitly setting `hovermode`: *closest* when using this feature. Selection events are sent accordingly as long as *event* flag is set as well. When the *event* flag is missing, `plotly_click` and `plotly_selected` events are not fired.
        public static partial class Clickmode
        {
            public static Box<ILayoutProperty> none() => Interop.mkLayoutAttr("clickmode", "none");
            public static Box<ILayoutProperty> _event() => Interop.mkLayoutAttr("clickmode", "event");
            public static Box<ILayoutProperty> select() => Interop.mkLayoutAttr("clickmode", "select");
        }

        /// Determines the mode of drag interactions. *select* and *lasso* apply only to scatter traces with markers or text. *orbit* and *turntable* apply only to 3D scenes.
        public static partial class Dragmode
        {
            public static Box<ILayoutProperty> lasso() => Interop.mkLayoutAttr("dragmode", "lasso");
            public static Box<ILayoutProperty> orbit() => Interop.mkLayoutAttr("dragmode", "orbit");
            public static Box<ILayoutProperty> pan() => Interop.mkLayoutAttr("dragmode", "pan");
            public static Box<ILayoutProperty> select() => Interop.mkLayoutAttr("dragmode", "select");
            public static Box<ILayoutProperty> turntable() => Interop.mkLayoutAttr("dragmode", "turntable");
            public static Box<ILayoutProperty> zoom() => Interop.mkLayoutAttr("dragmode", "zoom");
            public static Box<ILayoutProperty> _false() => Interop.mkLayoutAttr("dragmode", false);
        }

        /// Determines the mode of hover interactions. If `clickmode` includes the *select* flag, `hovermode` defaults to *closest*. If `clickmode` lacks the *select* flag, it defaults to *x* or *y* (depending on the trace's `orientation` value) for plots based on cartesian coordinates. For anything else the default value is *closest*.
        public static partial class Hovermode
        {
            public static Box<ILayoutProperty> closest() => Interop.mkLayoutAttr("hovermode", "closest");
            public static Box<ILayoutProperty> x() => Interop.mkLayoutAttr("hovermode", "x");
            public static Box<ILayoutProperty> y() => Interop.mkLayoutAttr("hovermode", "y");
            public static Box<ILayoutProperty> _false() => Interop.mkLayoutAttr("hovermode", false);
        }

        /// When \"dragmode\" is set to \"select\", this limits the selection of the drag to horizontal, vertical or diagonal. \"h\" only allows horizontal selection, \"v\" only vertical, \"d\" only diagonal and \"any\" sets no limit.
        public static partial class Selectdirection
        {
            public static Box<ILayoutProperty> any() => Interop.mkLayoutAttr("selectdirection", "any");
            public static Box<ILayoutProperty> d() => Interop.mkLayoutAttr("selectdirection", "d");
            public static Box<ILayoutProperty> h() => Interop.mkLayoutAttr("selectdirection", "h");
            public static Box<ILayoutProperty> v() => Interop.mkLayoutAttr("selectdirection", "v");
        }

        /// Sets the default calendar system to use for interpreting and displaying dates throughout the plot.
        public static partial class Calendar
        {
            public static Box<ILayoutProperty> chinese() => Interop.mkLayoutAttr("calendar", "chinese");
            public static Box<ILayoutProperty> coptic() => Interop.mkLayoutAttr("calendar", "coptic");
            public static Box<ILayoutProperty> discworld() => Interop.mkLayoutAttr("calendar", "discworld");
            public static Box<ILayoutProperty> ethiopian() => Interop.mkLayoutAttr("calendar", "ethiopian");
            public static Box<ILayoutProperty> gregorian() => Interop.mkLayoutAttr("calendar", "gregorian");
            public static Box<ILayoutProperty> hebrew() => Interop.mkLayoutAttr("calendar", "hebrew");
            public static Box<ILayoutProperty> islamic() => Interop.mkLayoutAttr("calendar", "islamic");
            public static Box<ILayoutProperty> jalali() => Interop.mkLayoutAttr("calendar", "jalali");
            public static Box<ILayoutProperty> julian() => Interop.mkLayoutAttr("calendar", "julian");
            public static Box<ILayoutProperty> mayan() => Interop.mkLayoutAttr("calendar", "mayan");
            public static Box<ILayoutProperty> nanakshahi() => Interop.mkLayoutAttr("calendar", "nanakshahi");
            public static Box<ILayoutProperty> nepali() => Interop.mkLayoutAttr("calendar", "nepali");
            public static Box<ILayoutProperty> persian() => Interop.mkLayoutAttr("calendar", "persian");
            public static Box<ILayoutProperty> taiwan() => Interop.mkLayoutAttr("calendar", "taiwan");
            public static Box<ILayoutProperty> thai() => Interop.mkLayoutAttr("calendar", "thai");
            public static Box<ILayoutProperty> ummalqura() => Interop.mkLayoutAttr("calendar", "ummalqura");
        }
    }
}