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

    public static partial class Annotation
    {
        /// Determines whether or not this annotation is visible.
        public static Box<IAnnotationProperty> visible(bool val) => Interop.mkAnnotationAttr("visible", val);
        /// Sets the annotation's x position.
        public static Box<IAnnotationProperty> x(bool val) => Interop.mkAnnotationAttr("x", val);
        /// Sets the annotation's x position.
        public static Box<IAnnotationProperty> x(params bool[] values) => Interop.mkAnnotationAttr("x", values);
        /// Sets the annotation's x position.
        public static Box<IAnnotationProperty> x(System.DateTime val) => Interop.mkAnnotationAttr("x", val);
        /// Sets the annotation's x position.
        public static Box<IAnnotationProperty> x(params System.DateTime[] values) => Interop.mkAnnotationAttr("x", values);
        /// Sets the annotation's x position.
        public static Box<IAnnotationProperty> x(int val) => Interop.mkAnnotationAttr("x", val);
        /// Sets the annotation's x position.
        public static Box<IAnnotationProperty> x(params int[] values) => Interop.mkAnnotationAttr("x", values);
        /// Sets the annotation's x position.
        public static Box<IAnnotationProperty> x(float val) => Interop.mkAnnotationAttr("x", val);
        /// Sets the annotation's x position.
        public static Box<IAnnotationProperty> x(params float[] values) => Interop.mkAnnotationAttr("x", values);
        /// Sets the annotation's x position.
        public static Box<IAnnotationProperty> x(string val) => Interop.mkAnnotationAttr("x", val);
        /// Sets the annotation's x position.
        public static Box<IAnnotationProperty> x(params string[] values) => Interop.mkAnnotationAttr("x", values);
        /// Sets the annotation's y position.
        public static Box<IAnnotationProperty> y(bool val) => Interop.mkAnnotationAttr("y", val);
        /// Sets the annotation's y position.
        public static Box<IAnnotationProperty> y(params bool[] values) => Interop.mkAnnotationAttr("y", values);
        /// Sets the annotation's y position.
        public static Box<IAnnotationProperty> y(System.DateTime val) => Interop.mkAnnotationAttr("y", val);
        /// Sets the annotation's y position.
        public static Box<IAnnotationProperty> y(params System.DateTime[] values) => Interop.mkAnnotationAttr("y", values);
        /// Sets the annotation's y position.
        public static Box<IAnnotationProperty> y(int val) => Interop.mkAnnotationAttr("y", val);
        /// Sets the annotation's y position.
        public static Box<IAnnotationProperty> y(params int[] values) => Interop.mkAnnotationAttr("y", values);
        /// Sets the annotation's y position.
        public static Box<IAnnotationProperty> y(float val) => Interop.mkAnnotationAttr("y", val);
        /// Sets the annotation's y position.
        public static Box<IAnnotationProperty> y(params float[] values) => Interop.mkAnnotationAttr("y", values);
        /// Sets the annotation's y position.
        public static Box<IAnnotationProperty> y(string val) => Interop.mkAnnotationAttr("y", val);
        /// Sets the annotation's y position.
        public static Box<IAnnotationProperty> y(params string[] values) => Interop.mkAnnotationAttr("y", values);
        /// Sets the annotation's z position.
        public static Box<IAnnotationProperty> z(bool val) => Interop.mkAnnotationAttr("z", val);
        /// Sets the annotation's z position.
        public static Box<IAnnotationProperty> z(params bool[] values) => Interop.mkAnnotationAttr("z", values);
        /// Sets the annotation's z position.
        public static Box<IAnnotationProperty> z(System.DateTime val) => Interop.mkAnnotationAttr("z", val);
        /// Sets the annotation's z position.
        public static Box<IAnnotationProperty> z(params System.DateTime[] values) => Interop.mkAnnotationAttr("z", values);
        /// Sets the annotation's z position.
        public static Box<IAnnotationProperty> z(int val) => Interop.mkAnnotationAttr("z", val);
        /// Sets the annotation's z position.
        public static Box<IAnnotationProperty> z(params int[] values) => Interop.mkAnnotationAttr("z", values);
        /// Sets the annotation's z position.
        public static Box<IAnnotationProperty> z(float val) => Interop.mkAnnotationAttr("z", val);
        /// Sets the annotation's z position.
        public static Box<IAnnotationProperty> z(params float[] values) => Interop.mkAnnotationAttr("z", values);
        /// Sets the annotation's z position.
        public static Box<IAnnotationProperty> z(string val) => Interop.mkAnnotationAttr("z", val);
        /// Sets the annotation's z position.
        public static Box<IAnnotationProperty> z(params string[] values) => Interop.mkAnnotationAttr("z", values);
        /// Sets the x component of the arrow tail about the arrow head (in pixels).
        public static Box<IAnnotationProperty> ax(int val) => Interop.mkAnnotationAttr("ax", val);
        /// Sets the x component of the arrow tail about the arrow head (in pixels).
        public static Box<IAnnotationProperty> ax(float val) => Interop.mkAnnotationAttr("ax", val);
        /// Sets the y component of the arrow tail about the arrow head (in pixels).
        public static Box<IAnnotationProperty> ay(int val) => Interop.mkAnnotationAttr("ay", val);
        /// Sets the y component of the arrow tail about the arrow head (in pixels).
        public static Box<IAnnotationProperty> ay(float val) => Interop.mkAnnotationAttr("ay", val);
        /// Shifts the position of the whole annotation and arrow to the right (positive) or left (negative) by this many pixels.
        public static Box<IAnnotationProperty> xshift(int val) => Interop.mkAnnotationAttr("xshift", val);
        /// Shifts the position of the whole annotation and arrow to the right (positive) or left (negative) by this many pixels.
        public static Box<IAnnotationProperty> xshift(float val) => Interop.mkAnnotationAttr("xshift", val);
        /// Shifts the position of the whole annotation and arrow up (positive) or down (negative) by this many pixels.
        public static Box<IAnnotationProperty> yshift(int val) => Interop.mkAnnotationAttr("yshift", val);
        /// Shifts the position of the whole annotation and arrow up (positive) or down (negative) by this many pixels.
        public static Box<IAnnotationProperty> yshift(float val) => Interop.mkAnnotationAttr("yshift", val);
        /// Sets the text associated with this annotation. Plotly uses a subset of HTML tags to do things like newline (<br>), bold (<b></b>), italics (<i></i>), hyperlinks (<a href = '...'></a>). Tags <em>, <sup>, <sub> <span> are also supported.
        public static Box<IAnnotationProperty> text(string val) => Interop.mkAnnotationAttr("text", val);
        /// Sets the angle at which the `text` is drawn with respect to the horizontal.
        public static Box<IAnnotationProperty> textangle(int val) => Interop.mkAnnotationAttr("textangle", val);
        /// Sets the angle at which the `text` is drawn with respect to the horizontal.
        public static Box<IAnnotationProperty> textangle(float val) => Interop.mkAnnotationAttr("textangle", val);
        /// Sets the annotation text font.
        public static Box<IAnnotationProperty> font(params Box<IFontProperty>[] properties) => Interop.mkAnnotationAttr("font", Bindings.flattenProperties(properties));
        /// Sets an explicit width for the text box. null (default) lets the text set the box width. Wider text will be clipped. There is no automatic wrapping; use <br> to start a new line.
        public static Box<IAnnotationProperty> width(int val) => Interop.mkAnnotationAttr("width", val);
        /// Sets an explicit width for the text box. null (default) lets the text set the box width. Wider text will be clipped. There is no automatic wrapping; use <br> to start a new line.
        public static Box<IAnnotationProperty> width(float val) => Interop.mkAnnotationAttr("width", val);
        /// Sets an explicit height for the text box. null (default) lets the text set the box height. Taller text will be clipped.
        public static Box<IAnnotationProperty> height(int val) => Interop.mkAnnotationAttr("height", val);
        /// Sets an explicit height for the text box. null (default) lets the text set the box height. Taller text will be clipped.
        public static Box<IAnnotationProperty> height(float val) => Interop.mkAnnotationAttr("height", val);
        /// Sets the opacity of the annotation (text + arrow).
        public static Box<IAnnotationProperty> opacity(int val) => Interop.mkAnnotationAttr("opacity", val);
        /// Sets the opacity of the annotation (text + arrow).
        public static Box<IAnnotationProperty> opacity(float val) => Interop.mkAnnotationAttr("opacity", val);
        /// Sets the background color of the annotation.
        public static Box<IAnnotationProperty> bgcolor(string val) => Interop.mkAnnotationAttr("bgcolor", val);
        /// Sets the color of the border enclosing the annotation `text`.
        public static Box<IAnnotationProperty> bordercolor(string val) => Interop.mkAnnotationAttr("bordercolor", val);
        /// Sets the padding (in px) between the `text` and the enclosing border.
        public static Box<IAnnotationProperty> borderpad(int val) => Interop.mkAnnotationAttr("borderpad", val);
        /// Sets the padding (in px) between the `text` and the enclosing border.
        public static Box<IAnnotationProperty> borderpad(float val) => Interop.mkAnnotationAttr("borderpad", val);
        /// Sets the width (in px) of the border enclosing the annotation `text`.
        public static Box<IAnnotationProperty> borderwidth(int val) => Interop.mkAnnotationAttr("borderwidth", val);
        /// Sets the width (in px) of the border enclosing the annotation `text`.
        public static Box<IAnnotationProperty> borderwidth(float val) => Interop.mkAnnotationAttr("borderwidth", val);
        /// Determines whether or not the annotation is drawn with an arrow. If *true*, `text` is placed near the arrow's tail. If *false*, `text` lines up with the `x` and `y` provided.
        public static Box<IAnnotationProperty> showarrow(bool val) => Interop.mkAnnotationAttr("showarrow", val);
        /// Sets the color of the annotation arrow.
        public static Box<IAnnotationProperty> arrowcolor(string val) => Interop.mkAnnotationAttr("arrowcolor", val);
        /// Sets the end annotation arrow head style.
        public static Box<IAnnotationProperty> arrowhead(int val) => Interop.mkAnnotationAttr("arrowhead", val);
        /// Sets the start annotation arrow head style.
        public static Box<IAnnotationProperty> startarrowhead(int val) => Interop.mkAnnotationAttr("startarrowhead", val);
        /// Sets the annotation arrow head position.
        public static Box<IAnnotationProperty> arrowside(params Box<IAnnotationProperty>[] properties) => Interop.mkAnnotationAttr("arrowside", Bindings.joinEnumProperties(properties));
        /// Sets the size of the end annotation arrow head, relative to `arrowwidth`. A value of 1 (default) gives a head about 3x as wide as the line.
        public static Box<IAnnotationProperty> arrowsize(int val) => Interop.mkAnnotationAttr("arrowsize", val);
        /// Sets the size of the end annotation arrow head, relative to `arrowwidth`. A value of 1 (default) gives a head about 3x as wide as the line.
        public static Box<IAnnotationProperty> arrowsize(float val) => Interop.mkAnnotationAttr("arrowsize", val);
        /// Sets the size of the start annotation arrow head, relative to `arrowwidth`. A value of 1 (default) gives a head about 3x as wide as the line.
        public static Box<IAnnotationProperty> startarrowsize(int val) => Interop.mkAnnotationAttr("startarrowsize", val);
        /// Sets the size of the start annotation arrow head, relative to `arrowwidth`. A value of 1 (default) gives a head about 3x as wide as the line.
        public static Box<IAnnotationProperty> startarrowsize(float val) => Interop.mkAnnotationAttr("startarrowsize", val);
        /// Sets the width (in px) of annotation arrow line.
        public static Box<IAnnotationProperty> arrowwidth(int val) => Interop.mkAnnotationAttr("arrowwidth", val);
        /// Sets the width (in px) of annotation arrow line.
        public static Box<IAnnotationProperty> arrowwidth(float val) => Interop.mkAnnotationAttr("arrowwidth", val);
        /// Sets a distance, in pixels, to move the end arrowhead away from the position it is pointing at, for example to point at the edge of a marker independent of zoom. Note that this shortens the arrow from the `ax` / `ay` vector, in contrast to `xshift` / `yshift` which moves everything by this amount.
        public static Box<IAnnotationProperty> standoff(int val) => Interop.mkAnnotationAttr("standoff", val);
        /// Sets a distance, in pixels, to move the end arrowhead away from the position it is pointing at, for example to point at the edge of a marker independent of zoom. Note that this shortens the arrow from the `ax` / `ay` vector, in contrast to `xshift` / `yshift` which moves everything by this amount.
        public static Box<IAnnotationProperty> standoff(float val) => Interop.mkAnnotationAttr("standoff", val);
        /// Sets a distance, in pixels, to move the start arrowhead away from the position it is pointing at, for example to point at the edge of a marker independent of zoom. Note that this shortens the arrow from the `ax` / `ay` vector, in contrast to `xshift` / `yshift` which moves everything by this amount.
        public static Box<IAnnotationProperty> startstandoff(int val) => Interop.mkAnnotationAttr("startstandoff", val);
        /// Sets a distance, in pixels, to move the start arrowhead away from the position it is pointing at, for example to point at the edge of a marker independent of zoom. Note that this shortens the arrow from the `ax` / `ay` vector, in contrast to `xshift` / `yshift` which moves everything by this amount.
        public static Box<IAnnotationProperty> startstandoff(float val) => Interop.mkAnnotationAttr("startstandoff", val);
        /// Sets text to appear when hovering over this annotation. If omitted or blank, no hover label will appear.
        public static Box<IAnnotationProperty> hovertext(string val) => Interop.mkAnnotationAttr("hovertext", val);
        public static Box<IAnnotationProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkAnnotationAttr("hoverlabel", Bindings.flattenProperties(properties));
        /// Determines whether the annotation text box captures mouse move and click events, or allows those events to pass through to data points in the plot that may be behind the annotation. By default `captureevents` is *false* unless `hovertext` is provided. If you use the event `plotly_clickannotation` without `hovertext` you must explicitly enable `captureevents`.
        public static Box<IAnnotationProperty> captureevents(bool val) => Interop.mkAnnotationAttr("captureevents", val);
        /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
        public static Box<IAnnotationProperty> name(string val) => Interop.mkAnnotationAttr("name", val);
        /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
        public static Box<IAnnotationProperty> templateitemname(string val) => Interop.mkAnnotationAttr("templateitemname", val);
        /// Toggle this annotation when clicking a data point whose `x` value is `xclick` rather than the annotation's `x` value.
        public static Box<IAnnotationProperty> xclick(bool val) => Interop.mkAnnotationAttr("xclick", val);
        /// Toggle this annotation when clicking a data point whose `x` value is `xclick` rather than the annotation's `x` value.
        public static Box<IAnnotationProperty> xclick(params bool[] values) => Interop.mkAnnotationAttr("xclick", values);
        /// Toggle this annotation when clicking a data point whose `x` value is `xclick` rather than the annotation's `x` value.
        public static Box<IAnnotationProperty> xclick(System.DateTime val) => Interop.mkAnnotationAttr("xclick", val);
        /// Toggle this annotation when clicking a data point whose `x` value is `xclick` rather than the annotation's `x` value.
        public static Box<IAnnotationProperty> xclick(params System.DateTime[] values) => Interop.mkAnnotationAttr("xclick", values);
        /// Toggle this annotation when clicking a data point whose `x` value is `xclick` rather than the annotation's `x` value.
        public static Box<IAnnotationProperty> xclick(int val) => Interop.mkAnnotationAttr("xclick", val);
        /// Toggle this annotation when clicking a data point whose `x` value is `xclick` rather than the annotation's `x` value.
        public static Box<IAnnotationProperty> xclick(params int[] values) => Interop.mkAnnotationAttr("xclick", values);
        /// Toggle this annotation when clicking a data point whose `x` value is `xclick` rather than the annotation's `x` value.
        public static Box<IAnnotationProperty> xclick(float val) => Interop.mkAnnotationAttr("xclick", val);
        /// Toggle this annotation when clicking a data point whose `x` value is `xclick` rather than the annotation's `x` value.
        public static Box<IAnnotationProperty> xclick(params float[] values) => Interop.mkAnnotationAttr("xclick", values);
        /// Toggle this annotation when clicking a data point whose `x` value is `xclick` rather than the annotation's `x` value.
        public static Box<IAnnotationProperty> xclick(string val) => Interop.mkAnnotationAttr("xclick", val);
        /// Toggle this annotation when clicking a data point whose `x` value is `xclick` rather than the annotation's `x` value.
        public static Box<IAnnotationProperty> xclick(params string[] values) => Interop.mkAnnotationAttr("xclick", values);
        /// Toggle this annotation when clicking a data point whose `y` value is `yclick` rather than the annotation's `y` value.
        public static Box<IAnnotationProperty> yclick(bool val) => Interop.mkAnnotationAttr("yclick", val);
        /// Toggle this annotation when clicking a data point whose `y` value is `yclick` rather than the annotation's `y` value.
        public static Box<IAnnotationProperty> yclick(params bool[] values) => Interop.mkAnnotationAttr("yclick", values);
        /// Toggle this annotation when clicking a data point whose `y` value is `yclick` rather than the annotation's `y` value.
        public static Box<IAnnotationProperty> yclick(System.DateTime val) => Interop.mkAnnotationAttr("yclick", val);
        /// Toggle this annotation when clicking a data point whose `y` value is `yclick` rather than the annotation's `y` value.
        public static Box<IAnnotationProperty> yclick(params System.DateTime[] values) => Interop.mkAnnotationAttr("yclick", values);
        /// Toggle this annotation when clicking a data point whose `y` value is `yclick` rather than the annotation's `y` value.
        public static Box<IAnnotationProperty> yclick(int val) => Interop.mkAnnotationAttr("yclick", val);
        /// Toggle this annotation when clicking a data point whose `y` value is `yclick` rather than the annotation's `y` value.
        public static Box<IAnnotationProperty> yclick(params int[] values) => Interop.mkAnnotationAttr("yclick", values);
        /// Toggle this annotation when clicking a data point whose `y` value is `yclick` rather than the annotation's `y` value.
        public static Box<IAnnotationProperty> yclick(float val) => Interop.mkAnnotationAttr("yclick", val);
        /// Toggle this annotation when clicking a data point whose `y` value is `yclick` rather than the annotation's `y` value.
        public static Box<IAnnotationProperty> yclick(params float[] values) => Interop.mkAnnotationAttr("yclick", values);
        /// Toggle this annotation when clicking a data point whose `y` value is `yclick` rather than the annotation's `y` value.
        public static Box<IAnnotationProperty> yclick(string val) => Interop.mkAnnotationAttr("yclick", val);
        /// Toggle this annotation when clicking a data point whose `y` value is `yclick` rather than the annotation's `y` value.
        public static Box<IAnnotationProperty> yclick(params string[] values) => Interop.mkAnnotationAttr("yclick", values);
    }

    public static partial class Annotation
    {
        /// Sets the text box's horizontal position anchor This anchor binds the `x` position to the *left*, *center* or *right* of the annotation. For example, if `x` is set to 1, `xref` to *paper* and `xanchor` to *right* then the right-most portion of the annotation lines up with the right-most edge of the plotting area. If *auto*, the anchor is equivalent to *center* for data-referenced annotations or if there is an arrow, whereas for paper-referenced with no arrow, the anchor picked corresponds to the closest side.
        public static partial class Xanchor
        {
            public static Box<IAnnotationProperty> auto() => Interop.mkAnnotationAttr("xanchor", "auto");
            public static Box<IAnnotationProperty> center() => Interop.mkAnnotationAttr("xanchor", "center");
            public static Box<IAnnotationProperty> left() => Interop.mkAnnotationAttr("xanchor", "left");
            public static Box<IAnnotationProperty> right() => Interop.mkAnnotationAttr("xanchor", "right");
        }

        /// Sets the text box's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the annotation. For example, if `y` is set to 1, `yref` to *paper* and `yanchor` to *top* then the top-most portion of the annotation lines up with the top-most edge of the plotting area. If *auto*, the anchor is equivalent to *middle* for data-referenced annotations or if there is an arrow, whereas for paper-referenced with no arrow, the anchor picked corresponds to the closest side.
        public static partial class Yanchor
        {
            public static Box<IAnnotationProperty> auto() => Interop.mkAnnotationAttr("yanchor", "auto");
            public static Box<IAnnotationProperty> bottom() => Interop.mkAnnotationAttr("yanchor", "bottom");
            public static Box<IAnnotationProperty> middle() => Interop.mkAnnotationAttr("yanchor", "middle");
            public static Box<IAnnotationProperty> top() => Interop.mkAnnotationAttr("yanchor", "top");
        }

        /// Sets the horizontal alignment of the `text` within the box. Has an effect only if `text` spans two or more lines (i.e. `text` contains one or more <br> HTML tags) or if an explicit width is set to override the text width.
        public static partial class Align
        {
            public static Box<IAnnotationProperty> center() => Interop.mkAnnotationAttr("align", "center");
            public static Box<IAnnotationProperty> left() => Interop.mkAnnotationAttr("align", "left");
            public static Box<IAnnotationProperty> right() => Interop.mkAnnotationAttr("align", "right");
        }

        /// Sets the vertical alignment of the `text` within the box. Has an effect only if an explicit height is set to override the text height.
        public static partial class Valign
        {
            public static Box<IAnnotationProperty> bottom() => Interop.mkAnnotationAttr("valign", "bottom");
            public static Box<IAnnotationProperty> middle() => Interop.mkAnnotationAttr("valign", "middle");
            public static Box<IAnnotationProperty> top() => Interop.mkAnnotationAttr("valign", "top");
        }

        /// Sets the annotation arrow head position.
        public static partial class Arrowside
        {
            public static Box<IAnnotationProperty> none() => Interop.mkAnnotationAttr("arrowside", "none");
            public static Box<IAnnotationProperty> _end() => Interop.mkAnnotationAttr("arrowside", "end");
            public static Box<IAnnotationProperty> start() => Interop.mkAnnotationAttr("arrowside", "start");
        }

        /// Indicates in what terms the tail of the annotation (ax,ay)  is specified. If `pixel`, `ax` is a relative offset in pixels  from `x`. If set to an x axis id (e.g. *x* or *x2*), `ax` is  specified in the same terms as that axis. This is useful  for trendline annotations which should continue to indicate  the correct trend when zoomed.
        public static partial class Axref
        {
            public static Box<IAnnotationProperty> pixel() => Interop.mkAnnotationAttr("axref", "pixel");
            public static Box<IAnnotationProperty> custom(string val) => Interop.mkAnnotationAttr("axref", val);
            public static Box<IAnnotationProperty> x(int anchorId) => Interop.mkAnnotationAttr("axref", anchorId > 1 ? $"x{anchorId}" : "");
        }

        /// Indicates in what terms the tail of the annotation (ax,ay)  is specified. If `pixel`, `ay` is a relative offset in pixels  from `y`. If set to a y axis id (e.g. *y* or *y2*), `ay` is  specified in the same terms as that axis. This is useful  for trendline annotations which should continue to indicate  the correct trend when zoomed.
        public static partial class Ayref
        {
            public static Box<IAnnotationProperty> pixel() => Interop.mkAnnotationAttr("ayref", "pixel");
            public static Box<IAnnotationProperty> custom(string val) => Interop.mkAnnotationAttr("ayref", val);
            public static Box<IAnnotationProperty> y(int anchorId) => Interop.mkAnnotationAttr("ayref", anchorId > 1 ? $"y{anchorId}" : "");
        }

        /// Sets the annotation's x coordinate axis. If set to an x axis id (e.g. *x* or *x2*), the `x` position refers to an x coordinate If set to *paper*, the `x` position refers to the distance from the left side of the plotting area in normalized coordinates where 0 (1) corresponds to the left (right) side.
        public static partial class Xref
        {
            public static Box<IAnnotationProperty> paper() => Interop.mkAnnotationAttr("xref", "paper");
            public static Box<IAnnotationProperty> custom(string val) => Interop.mkAnnotationAttr("xref", val);
            public static Box<IAnnotationProperty> x(int anchorId) => Interop.mkAnnotationAttr("xref", anchorId > 1 ? $"x{anchorId}" : "");
        }

        /// Sets the annotation's y coordinate axis. If set to an y axis id (e.g. *y* or *y2*), the `y` position refers to an y coordinate If set to *paper*, the `y` position refers to the distance from the bottom of the plotting area in normalized coordinates where 0 (1) corresponds to the bottom (top).
        public static partial class Yref
        {
            public static Box<IAnnotationProperty> paper() => Interop.mkAnnotationAttr("yref", "paper");
            public static Box<IAnnotationProperty> custom(string val) => Interop.mkAnnotationAttr("yref", val);
            public static Box<IAnnotationProperty> y(int anchorId) => Interop.mkAnnotationAttr("yref", anchorId > 1 ? $"y{anchorId}" : "");
        }

        /// Makes this annotation respond to clicks on the plot. If you click a data point that exactly matches the `x` and `y` values of this annotation, and it is hidden (visible: false), it will appear. In *onoff* mode, you must click the same point again to make it disappear, so if you click multiple points, you can show multiple annotations. In *onout* mode, a click anywhere else in the plot (on another data point or not) will hide this annotation. If you need to show/hide this annotation in response to different `x` or `y` values, you can set `xclick` and/or `yclick`. This is useful for example to label the side of a bar. To label markers though, `standoff` is preferred over `xclick` and `yclick`.
        public static partial class Clicktoshow
        {
            public static Box<IAnnotationProperty> onoff() => Interop.mkAnnotationAttr("clicktoshow", "onoff");
            public static Box<IAnnotationProperty> onout() => Interop.mkAnnotationAttr("clicktoshow", "onout");
            public static Box<IAnnotationProperty> _false() => Interop.mkAnnotationAttr("clicktoshow", false);
        }
    }
}