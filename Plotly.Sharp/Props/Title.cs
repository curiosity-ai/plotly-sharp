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

    public static partial class Title
    {
        /// Sets the title of the color bar. Note that before the existence of `title.text`, the title's contents used to be defined as the `title` attribute itself. This behavior has been deprecated.
        public static Box<ITitleProperty> text(string val) => Interop.mkTitleAttr("text", val);
        /// Sets this color bar's title font. Note that the title's font used to be set by the now deprecated `titlefont` attribute.
        public static Box<ITitleProperty> font(params Box<IFontProperty>[] properties) => Interop.mkTitleAttr("font", Bindings.flattenProperties(properties));
        /// An additional amount by which to offset the title from the tick labels, given in pixels. Note that this used to be set by the now deprecated `titleoffset` attribute.
        public static Box<ITitleProperty> offset(int val) => Interop.mkTitleAttr("offset", val);
        /// An additional amount by which to offset the title from the tick labels, given in pixels. Note that this used to be set by the now deprecated `titleoffset` attribute.
        public static Box<ITitleProperty> offset(float val) => Interop.mkTitleAttr("offset", val);
        /// Sets the x position with respect to `xref` in normalized coordinates from *0* (left) to *1* (right).
        public static Box<ITitleProperty> x(int val) => Interop.mkTitleAttr("x", val);
        /// Sets the x position with respect to `xref` in normalized coordinates from *0* (left) to *1* (right).
        public static Box<ITitleProperty> x(float val) => Interop.mkTitleAttr("x", val);
        /// Sets the y position with respect to `yref` in normalized coordinates from *0* (bottom) to *1* (top). *auto* places the baseline of the title onto the vertical center of the top margin.
        public static Box<ITitleProperty> y(int val) => Interop.mkTitleAttr("y", val);
        /// Sets the y position with respect to `yref` in normalized coordinates from *0* (bottom) to *1* (top). *auto* places the baseline of the title onto the vertical center of the top margin.
        public static Box<ITitleProperty> y(float val) => Interop.mkTitleAttr("y", val);
        /// Sets the padding of the title. Each padding value only applies when the corresponding `xanchor`/`yanchor` value is set accordingly. E.g. for left padding to take effect, `xanchor` must be set to *left*. The same rule applies if `xanchor`/`yanchor` is determined automatically. Padding is muted if the respective anchor value is *middle*/*center*.
        public static Box<ITitleProperty> pad(params Box<IPadProperty>[] properties) => Interop.mkTitleAttr("pad", Bindings.flattenProperties(properties));
        /// Sets the standoff distance (in px) between the axis labels and the title text The default value is a function of the axis tick labels, the title `font.size` and the axis `linewidth`. Note that the axis title position is always constrained within the margins, so the actual standoff distance is always less than the set or default value. By setting `standoff` and turning on `automargin`, plotly.js will push the margins to fit the axis title at given standoff distance.
        public static Box<ITitleProperty> standoff(int val) => Interop.mkTitleAttr("standoff", val);
        /// Sets the standoff distance (in px) between the axis labels and the title text The default value is a function of the axis tick labels, the title `font.size` and the axis `linewidth`. Note that the axis title position is always constrained within the margins, so the actual standoff distance is always less than the set or default value. By setting `standoff` and turning on `automargin`, plotly.js will push the margins to fit the axis title at given standoff distance.
        public static Box<ITitleProperty> standoff(float val) => Interop.mkTitleAttr("standoff", val);
    }

    public static partial class Title
    {
        /// Determines the location of color bar's title with respect to the color bar. Note that the title's location used to be set by the now deprecated `titleside` attribute.
        public static partial class Side
        {
            public static Box<ITitleProperty> bottom() => Interop.mkTitleAttr("side", "bottom");
            public static Box<ITitleProperty> right() => Interop.mkTitleAttr("side", "right");
            public static Box<ITitleProperty> top() => Interop.mkTitleAttr("side", "top");
        }

        /// Specifies the location of the `title`. Note that the title's position used to be set by the now deprecated `titleposition` attribute.
        public static partial class Position
        {
            public static Box<ITitleProperty> bottomCenter() => Interop.mkTitleAttr("position", "bottom center");
            public static Box<ITitleProperty> bottomLeft() => Interop.mkTitleAttr("position", "bottom left");
            public static Box<ITitleProperty> bottomRight() => Interop.mkTitleAttr("position", "bottom right");
            public static Box<ITitleProperty> middleCenter() => Interop.mkTitleAttr("position", "middle center");
            public static Box<ITitleProperty> topCenter() => Interop.mkTitleAttr("position", "top center");
            public static Box<ITitleProperty> topLeft() => Interop.mkTitleAttr("position", "top left");
            public static Box<ITitleProperty> topRight() => Interop.mkTitleAttr("position", "top right");
        }

        /// Sets the horizontal alignment of the title. It defaults to `center` except for bullet charts for which it defaults to right.
        public static partial class Align
        {
            public static Box<ITitleProperty> center() => Interop.mkTitleAttr("align", "center");
            public static Box<ITitleProperty> left() => Interop.mkTitleAttr("align", "left");
            public static Box<ITitleProperty> right() => Interop.mkTitleAttr("align", "right");
        }

        /// Sets the container `x` refers to. *container* spans the entire `width` of the plot. *paper* refers to the width of the plotting area only.
        public static partial class Xref
        {
            public static Box<ITitleProperty> container() => Interop.mkTitleAttr("xref", "container");
            public static Box<ITitleProperty> paper() => Interop.mkTitleAttr("xref", "paper");
        }

        /// Sets the container `y` refers to. *container* spans the entire `height` of the plot. *paper* refers to the height of the plotting area only.
        public static partial class Yref
        {
            public static Box<ITitleProperty> container() => Interop.mkTitleAttr("yref", "container");
            public static Box<ITitleProperty> paper() => Interop.mkTitleAttr("yref", "paper");
        }

        /// Sets the title's horizontal alignment with respect to its x position. *left* means that the title starts at x, *right* means that the title ends at x and *center* means that the title's center is at x. *auto* divides `xref` by three and calculates the `xanchor` value automatically based on the value of `x`.
        public static partial class Xanchor
        {
            public static Box<ITitleProperty> auto() => Interop.mkTitleAttr("xanchor", "auto");
            public static Box<ITitleProperty> center() => Interop.mkTitleAttr("xanchor", "center");
            public static Box<ITitleProperty> left() => Interop.mkTitleAttr("xanchor", "left");
            public static Box<ITitleProperty> right() => Interop.mkTitleAttr("xanchor", "right");
        }

        /// Sets the title's vertical alignment with respect to its y position. *top* means that the title's cap line is at y, *bottom* means that the title's baseline is at y and *middle* means that the title's midline is at y. *auto* divides `yref` by three and calculates the `yanchor` value automatically based on the value of `y`.
        public static partial class Yanchor
        {
            public static Box<ITitleProperty> auto() => Interop.mkTitleAttr("yanchor", "auto");
            public static Box<ITitleProperty> bottom() => Interop.mkTitleAttr("yanchor", "bottom");
            public static Box<ITitleProperty> middle() => Interop.mkTitleAttr("yanchor", "middle");
            public static Box<ITitleProperty> top() => Interop.mkTitleAttr("yanchor", "top");
        }
    }
}