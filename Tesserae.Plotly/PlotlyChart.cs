using System;
using System.Collections.Generic;
using System.Linq;
using Tesserae;
using Transpose;
using Tesserae.Plotly.Types;
using static Transpose.Core.dom;
using static Tesserae.UI;

namespace Tesserae.Plotly
{
    /// <summary>
    /// A Tesserae <see cref="IComponent"/> that renders a Plotly.js chart.
    ///
    /// <para>
    /// The chart draws itself into a full-size container as soon as it is mounted (Plotly needs the
    /// element to be in the document so it can measure the available space) and keeps itself sized to
    /// that container through a <see cref="ResizeObserver"/>, so the standard Tesserae sizing helpers
    /// (<c>.WS()</c>, <c>.HS()</c>, <c>.S()</c>, <c>.W(..)</c>, <c>.H(..)</c>, <c>.Grow()</c>, …) work
    /// exactly as they do for any other component.
    /// </para>
    ///
    /// <para>
    /// The traces, layout and config are collected through the fluent API and the chart is drawn with
    /// <c>Plotly.newPlot</c> on first mount. Any later change — whether through a fluent setter or through
    /// <see cref="Update()"/> — is applied efficiently with <c>Plotly.react</c>, which diffs against the
    /// existing plot instead of tearing it down and rebuilding it.
    /// </para>
    /// </summary>
    [Transpose.Name("tss.PlotlyChart")]
    public sealed class PlotlyChart : IComponent, ISpecialCaseStyling
    {
        private readonly HTMLElement                _container;
        private readonly List<Box<ITracesProperty>> _traces;
        private readonly List<Box<ILayoutProperty>> _layout;
        private readonly List<Box<IConfigProperty>> _config;
        private readonly List<Box<IPlotProperty>>   _events;

        private ResizeObserver _resizeObserver;
        private bool           _wired;
        private bool           _rendered;
        private bool           _responsive = true;
        private double         _drawTimeout;
        private double         _resizeTimeout;

        /// <summary>The element that the sizing helpers write onto (this component opts out of the stack-item wrapper).</summary>
        public HTMLElement StylingContainer           => _container;
        /// <summary>This component styles its own container, so styling should not be propagated to a stack-item parent.</summary>
        public bool        PropagateToStackItemParent => false;

        /// <summary>Creates an empty chart. Add data with <see cref="Traces"/>/<see cref="AddTrace"/> and configure it fluently.</summary>
        public PlotlyChart()
        {
            _traces = new List<Box<ITracesProperty>>();
            _layout = new List<Box<ILayoutProperty>>();
            _config = new List<Box<IConfigProperty>>();
            _events = new List<Box<IPlotProperty>>();

            _container = Div(Att("tss-plotly"));
            _container.style.width  = "100%";
            _container.style.height = "100%";
            // Allow the chart to shrink below its content size inside flex containers (Stack/Grow),
            // otherwise the default min-width/height:auto of a flex item makes the plot overflow.
            _container.style.minWidth  = "0";
            _container.style.minHeight = "0";
        }

        /// <summary>Creates a chart with the given traces (e.g. <c>Traces.scatter(...)</c>, <c>Traces.bar(...)</c>).</summary>
        public PlotlyChart(params Box<ITracesProperty>[] traces) : this() => Traces(traces);

        // ---------------------------------------------------------------------------------------------
        // Data
        // ---------------------------------------------------------------------------------------------

        /// <summary>Replaces all traces (chart data). Each trace is created with the <c>Traces.*</c> factories.</summary>
        public PlotlyChart Traces(params Box<ITracesProperty>[] traces)
        {
            _traces.Clear();
            if (traces != null) _traces.AddRange(traces);
            return ScheduleDraw();
        }

        /// <summary>Appends one or more traces to the existing data.</summary>
        public PlotlyChart AddTrace(params Box<ITracesProperty>[] traces)
        {
            if (traces != null) _traces.AddRange(traces);
            return ScheduleDraw();
        }

        // ---------------------------------------------------------------------------------------------
        // Layout / Config (raw)
        // ---------------------------------------------------------------------------------------------

        /// <summary>Adds raw layout properties (created with the <c>Layout.*</c> factories).</summary>
        public PlotlyChart Layout(params Box<ILayoutProperty>[] properties)
        {
            if (properties != null) _layout.AddRange(properties);
            return ScheduleDraw();
        }

        /// <summary>Adds raw config properties (created with the <c>Config.*</c> factories).</summary>
        public PlotlyChart Config(params Box<IConfigProperty>[] properties)
        {
            if (properties != null) _config.AddRange(properties);
            return ScheduleDraw();
        }

        // ---------------------------------------------------------------------------------------------
        // Key layout properties surfaced as fluent helpers
        // ---------------------------------------------------------------------------------------------

        /// <summary>Sets the chart title.</summary>
        public PlotlyChart Title(string title) => Layout(Tesserae.Plotly.Layout.title(Tesserae.Plotly.Title.text(title)));

        /// <summary>Sets both the paper (outer) and plot (inner) background colors.</summary>
        public PlotlyChart Background(string color) => PaperBackground(color).PlotBackground(color);

        /// <summary>Sets the paper (outer, around the plotting area) background color.</summary>
        public PlotlyChart PaperBackground(string color) => Layout(Tesserae.Plotly.Layout.paperBgcolor(color));

        /// <summary>Sets the plot (inner, the plotting area) background color.</summary>
        public PlotlyChart PlotBackground(string color) => Layout(Tesserae.Plotly.Layout.plotBgcolor(color));

        /// <summary>Sets whether the legend is shown.</summary>
        public PlotlyChart ShowLegend(bool show = true) => Layout(Tesserae.Plotly.Layout.showlegend(show));

        /// <summary>Sets the plot margins (in pixels).</summary>
        public PlotlyChart Margin(int left, int right, int top, int bottom) =>
            Layout(Tesserae.Plotly.Layout.margin(
                Tesserae.Plotly.Margin.l(left),
                Tesserae.Plotly.Margin.r(right),
                Tesserae.Plotly.Margin.t(top),
                Tesserae.Plotly.Margin.b(bottom)));

        /// <summary>Sets the global font used for the chart.</summary>
        public PlotlyChart Font(string family = null, float size = 0, string color = null)
        {
            var props = new List<Box<IFontProperty>>();
            if (!string.IsNullOrEmpty(family)) props.Add(Tesserae.Plotly.Font.family(family));
            if (size > 0)                      props.Add(Tesserae.Plotly.Font.size(size));
            if (!string.IsNullOrEmpty(color))  props.Add(Tesserae.Plotly.Font.color(color));
            return props.Count == 0 ? this : Layout(Tesserae.Plotly.Layout.font(props.ToArray()));
        }

        /// <summary>Sets how bars from multiple traces are combined: <c>"group"</c>, <c>"stack"</c>, <c>"overlay"</c> or <c>"relative"</c>.</summary>
        public PlotlyChart BarMode(string mode) => Layout(Interop.mkLayoutAttr("barmode", mode));

        // ---------------------------------------------------------------------------------------------
        // Key config properties surfaced as fluent helpers
        // ---------------------------------------------------------------------------------------------

        /// <summary>
        /// When responsive (the default), the chart fills its container and follows both window and
        /// container size changes. Turn this off to let an explicit <c>Layout.width/height</c> win.
        /// </summary>
        public PlotlyChart Responsive(bool responsive = true)
        {
            _responsive = responsive;
            return ScheduleDraw();
        }

        /// <summary>Renders a non-interactive, static image of the chart (no zoom/pan/hover/mode bar).</summary>
        public PlotlyChart StaticPlot(bool @static = true) => Config(Tesserae.Plotly.Config.staticPlot(@static));

        /// <summary>Shows or hides the Plotly mode bar (the zoom/pan/download toolbar).</summary>
        public PlotlyChart DisplayModeBar(bool display) => Config(Interop.mkConfigAttr("displayModeBar", display));

        /// <summary>Shows or hides the Plotly logo in the mode bar.</summary>
        public PlotlyChart DisplayLogo(bool display) => Config(Tesserae.Plotly.Config.displaylogo(display));

        // ---------------------------------------------------------------------------------------------
        // Events (reuse the strongly-typed Plot.on* helpers)
        // ---------------------------------------------------------------------------------------------

        /// <summary>Adds one or more event handlers, created with the <c>Plot.on*</c> factories (e.g. <c>Plot.onClick(...)</c>).</summary>
        public PlotlyChart Events(params Box<IPlotProperty>[] events)
        {
            if (events != null) _events.AddRange(events);
            if (_rendered) Bindings.BindPlotlyEvents(Bindings.flattenProperties(_events), _container);
            return this;
        }

        /// <summary>Handles clicks on plotted points.</summary>
        public PlotlyChart OnClick(Action<Literals.PlotMouseEvent> handler) => Events(Plot.onClick(handler));
        /// <summary>Handles hovering over plotted points.</summary>
        public PlotlyChart OnHover(Action<Literals.PlotMouseEvent> handler) => Events(Plot.onHover(handler));
        /// <summary>Handles the pointer leaving a plotted point.</summary>
        public PlotlyChart OnUnhover(Action<Literals.PlotMouseEvent> handler) => Events(Plot.onUnhover(handler));
        /// <summary>Handles relayout events (zoom/pan/axis range changes).</summary>
        public PlotlyChart OnRelayout(Action<Literals.PlotRelayoutEvent> handler) => Events(Plot.onRelayout(handler));
        /// <summary>Handles box/lasso selection.</summary>
        public PlotlyChart OnSelected(Action<Literals.PlotSelectionEvent> handler) => Events(Plot.onSelected(handler));
        /// <summary>Handles clicks on legend entries.</summary>
        public PlotlyChart OnLegendClick(Action<Literals.LegendClickEvent> handler) => Events(Plot.onLegendClick(handler));

        // ---------------------------------------------------------------------------------------------
        // Updating an existing plot
        // ---------------------------------------------------------------------------------------------

        /// <summary>Re-renders the chart from its current traces/layout/config (uses <c>Plotly.react</c> when already drawn).</summary>
        public PlotlyChart Update()
        {
            if (_rendered) Draw();
            return this;
        }

        /// <summary>Replaces the traces and re-renders the existing plot.</summary>
        public PlotlyChart Update(params Box<ITracesProperty>[] traces) => Traces(traces).Update();

        // ---------------------------------------------------------------------------------------------
        // Rendering
        // ---------------------------------------------------------------------------------------------

        /// <summary>Returns the chart's container element and wires up mount/resize handling the first time it is called.</summary>
        public HTMLElement Render()
        {
            if (!_wired)
            {
                _wired = true;

                _resizeObserver = new ResizeObserver((entries, obs) => ScheduleResize());
                _resizeObserver.observe(_container);

                Tesserae.DomObserver.WhenMounted(_container, () => Draw());
                Tesserae.DomObserver.WhenRemoved(_container, () =>
                {
                    _resizeObserver.unobserve(_container);
                    if (_rendered)
                    {
                        try { Script.Write("Plotly.purge({0})", _container); } catch { }
                        _rendered = false;
                    }
                });
            }
            return _container;
        }

        private PlotlyChart ScheduleDraw()
        {
            if (_rendered)
            {
                window.clearTimeout(_drawTimeout);
                _drawTimeout = window.setTimeout((_) => Draw(), 16);
            }
            return this;
        }

        private void ScheduleResize()
        {
            if (!_rendered || !_container.IsMounted()) return;
            window.clearTimeout(_resizeTimeout);
            _resizeTimeout = window.setTimeout((_) =>
            {
                try { Script.Write("Plotly.Plots.resize({0})", _container); } catch { }
            }, 16);
        }

        private void Draw()
        {
            // Plotly needs the element to be part of the document so it can measure the space it has.
            if (!_container.IsMounted()) return;

            EnsurePlotly(() =>
            {
                var data   = Bindings.flattenPropertiesToArray(_traces.ToArray());
                var layout = Bindings.flattenProperties(_layout);
                var config = Bindings.flattenProperties(_config);

                // The responsive flag drives Plotly's own container-fitting/window-resize behaviour.
                Script.Write("{0}.responsive = {1}", config, _responsive);

                if (_rendered)
                {
                    Script.Write("Plotly.react({0}, {1}, {2}, {3})", _container, data, layout, config);
                }
                else
                {
                    Script.Write("Plotly.newPlot({0}, {1}, {2}, {3})", _container, data, layout, config);
                    _rendered = true;
                    if (_events.Count > 0) Bindings.BindPlotlyEvents(Bindings.flattenProperties(_events), _container);
                }

                ScheduleResize();
            });
        }

        // Plotly.js is shipped as a bundled resource that is injected into the page with `defer`, so the
        // global may not be defined yet the instant the chart mounts. Poll briefly until it is available.
        private static void EnsurePlotly(Action then)
        {
            if (PlotlyIsLoaded()) { then(); return; }

            var tries  = 0;
            double handle = 0;
            handle = window.setInterval((_) =>
            {
                tries++;
                if (PlotlyIsLoaded())
                {
                    window.clearInterval(handle);
                    then();
                }
                else if (tries > 400) // ~10s
                {
                    window.clearInterval(handle);
                    console.error("Tesserae.Plotly: Plotly.js global was not found - make sure the Tesserae.Plotly package resources are bundled.");
                }
            }, 25);
        }

        private static bool PlotlyIsLoaded() => Script.Write<bool>("(typeof Plotly !== 'undefined')");
    }
}
