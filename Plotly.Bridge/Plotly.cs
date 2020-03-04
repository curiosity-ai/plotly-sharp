namespace PlotlyBridge
{
    /*////////////////////////////////
    /// THIS FILE IS AUTO-GENERATED //
    ///     by componentDocument    //
    ////////////////////////////////*/
    using System;
    using System.Collections.Generic;
    using Types;
    using Bridge;
    using static Retyped.dom;

    public sealed partial class Plot
    {
        ///Create a Plotly plot
        public Plot(params Box<IPlotProperty>[] props) => plot = Bindings.createPlot(props);
        private IPlot plot;
        ///Render the plot
        public HTMLElement Render() => plot.Render();
        ///Update the plot
        public void Update(params Box<IPlotProperty>[] props) => plot.Update(props);
        ///Create the plotly traces
        public static Box<IPlotProperty> traces(params Box<ITracesProperty>[] properties) => Bindings.extractTraces(properties);
        ///Create the plotly config
        public static Box<IPlotProperty> config(params Box<IConfigProperty>[] properties) => Bindings.extractConfig(properties);
        ///Create the plotly layout
        public static Box<IPlotProperty> layout(params Box<ILayoutProperty>[] properties) => Bindings.extractLayout(properties);
        ///When provided, causes the plot to update when the revision is incremented.
        public static Box<IPlotProperty> revision(int val) => Interop.mkPlotAttr("revision", val);
        ///When provided, causes the plot to update when the revision is incremented.
        public static Box<IPlotProperty> revision(float val) => Interop.mkPlotAttr("revision", val);
        ///Callback executed after plot is initialized.
        public static Box<IPlotProperty> onInitialized(Action handler, HTMLElement unit) => Interop.mkPlotAttr("onInitialized", handler);
        ///Callback executed when when a plot is updated due to new data or layout, or when user interacts with a plot.
        public static Box<IPlotProperty> onUpdate(Action<HTMLElement> handler) => Interop.mkPlotAttr("onUpdate", handler);
        ///Callback executed when component unmounts, before Plotly.purge strips the graphDiv of all private attributes.
        public static Box<IPlotProperty> onPurge(Action<HTMLElement> handler) => Interop.mkPlotAttr("onPurge", handler);
        ///Callback executed when a plotly.js API method rejects
        public static Box<IPlotProperty> onError(Action<Event> handler) => Interop.mkPlotAttr("onError", handler);
        ///Id assigned to the <div> into which the plot is rendered.
        public static Box<IPlotProperty> divId(string val) => Interop.mkPlotAttr("divId", val);
        ///Class applied to the <div> into which the plot is rendered
        public static Box<IPlotProperty> className(string val) => Interop.mkPlotAttr("className", val);
        ///Styles the <div> into which the plot is rendered - TODO, check if this should be a different interface than IStyleProperty
        public static Box<IStyleProperty> style(List<IStyleProperty> properties) => Interop.mkStyleAttr("style", properties);
        ///Assign the graph div to window.gd for debugging
        public static Box<IPlotProperty> debug(bool val) => Interop.mkPlotAttr("debug", val);
        ///When true, adds a call to Plotly.Plot.resize() as a window.resize event handler
        public static Box<IPlotProperty> useResizeHandler(bool val) => Interop.mkPlotAttr("useResizeHandler", val);
        public static Box<IPlotProperty> onAfterExport(Action handler) => Interop.mkPlotAttr("onClick", handler);
        public static Box<IPlotProperty> onAfterPlot(Action handler) => Interop.mkPlotAttr("onAfterPlot", handler);
        public static Box<IPlotProperty> onAnimated(Action handler) => Interop.mkPlotAttr("onAnimated", handler);
        public static Box<IPlotProperty> onAnimatingFrame(Action<Literals.FrameAnimationEvent> handler) => Interop.mkPlotAttr("onAnimatingFrame", handler);
        public static Box<IPlotProperty> onAnimationInterrupted(Action handler) => Interop.mkPlotAttr("onAnimationInterrupted", handler);
        public static Box<IPlotProperty> onAutoSize(Action handler) => Interop.mkPlotAttr("onAutoSize", handler);
        public static Box<IPlotProperty> onBeforeExport(Action handler) => Interop.mkPlotAttr("onBeforeExport", handler);
        public static Box<IPlotProperty> onButtonClicked(Action<Literals.ButtonClickEvent> handler) => Interop.mkPlotAttr("onButtonClicked", handler);
        public static Box<IPlotProperty> onClick(Action<Literals.PlotMouseEvent> handler) => Interop.mkPlotAttr("onClick", handler);
        public static Box<IPlotProperty> onClickAnnotation(Action<Literals.ClickAnnotationEvent> handler) => Interop.mkPlotAttr("onClickAnnotation", handler);
        public static Box<IPlotProperty> onDeselect(Action handler) => Interop.mkPlotAttr("onDeselect", handler);
        public static Box<IPlotProperty> onDoubleClick(Action handler) => Interop.mkPlotAttr("onDoubleClick", handler);
        public static Box<IPlotProperty> onFramework(Action handler) => Interop.mkPlotAttr("onFramework", handler);
        public static Box<IPlotProperty> onHover(Action<Literals.PlotMouseEvent> handler) => Interop.mkPlotAttr("onHover", handler);
        public static Box<IPlotProperty> onLegendClick(Action<Literals.LegendClickEvent> handler) => Interop.mkPlotAttr("onLegendClick", handler);
        public static Box<IPlotProperty> onLegendDoubleClick(Action<Literals.LegendClickEvent> handler) => Interop.mkPlotAttr("onLegendDoubleClick", handler);
        public static Box<IPlotProperty> onRelayout(Action<Literals.PlotRelayoutEvent> handler) => Interop.mkPlotAttr("onRelayout", handler);
        public static Box<IPlotProperty> onRestyle(Action<Literals.PlotRestyleEvent> handler) => Interop.mkPlotAttr("onRestyle", handler);
        public static Box<IPlotProperty> onRedraw(Action handler) => Interop.mkPlotAttr("onRedraw", handler);
        public static Box<IPlotProperty> onSelected(Action<Literals.PlotSelectionEvent> handler) => Interop.mkPlotAttr("onSelected", handler);
        public static Box<IPlotProperty> onSelecting(Action<Literals.PlotSelectionEvent> handler) => Interop.mkPlotAttr("onSelecting", handler);
        public static Box<IPlotProperty> onSliderChange(Action<Literals.SliderChangeEvent> handler) => Interop.mkPlotAttr("onSliderChange", handler);
        public static Box<IPlotProperty> onSliderEnd(Action<Literals.SliderEndEvent> handler) => Interop.mkPlotAttr("onSliderEnd", handler);
        public static Box<IPlotProperty> onSliderStart(Action<Literals.SliderStartEvent> handler) => Interop.mkPlotAttr("onSliderStart", handler);
        public static Box<IPlotProperty> onTransitioning(Action handler) => Interop.mkPlotAttr("onTransitioning", handler);
        public static Box<IPlotProperty> onTransitionInterrupted(Action handler) => Interop.mkPlotAttr("onTransitionInterrupted", handler);
        public static Box<IPlotProperty> onUnhover(Action<Literals.PlotMouseEvent> handler) => Interop.mkPlotAttr("onUnhover", handler);
    }
}