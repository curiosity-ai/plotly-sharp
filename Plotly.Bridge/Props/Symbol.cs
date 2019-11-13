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

    public static partial class Symbol
    {
        /// Sets the symbol icon image (mapbox.layer.layout.icon-image). Full list: https://www.mapbox.com/maki-icons/
        public static Box<ISymbolProperty> icon(string val) => Interop.mkSymbolAttr("icon", val);
        /// Sets the symbol icon size (mapbox.layer.layout.icon-size). Has an effect only when `type` is set to *symbol*.
        public static Box<ISymbolProperty> iconsize(int val) => Interop.mkSymbolAttr("iconsize", val);
        /// Sets the symbol icon size (mapbox.layer.layout.icon-size). Has an effect only when `type` is set to *symbol*.
        public static Box<ISymbolProperty> iconsize(float val) => Interop.mkSymbolAttr("iconsize", val);
        /// Sets the symbol text (mapbox.layer.layout.text-field).
        public static Box<ISymbolProperty> text(string val) => Interop.mkSymbolAttr("text", val);
        /// Sets the icon text font (color=mapbox.layer.paint.text-color, size=mapbox.layer.layout.text-size). Has an effect only when `type` is set to *symbol*.
        public static Box<ISymbolProperty> textfont(params Box<ITextfontProperty>[] properties) => Interop.mkSymbolAttr("textfont", Bindings.flattenProperties(properties));
    }

    public static partial class Symbol
    {
        /// Sets the symbol and/or text placement (mapbox.layer.layout.symbol-placement). If `placement` is *point*, the label is placed where the geometry is located If `placement` is *line*, the label is placed along the line of the geometry If `placement` is *line-center*, the label is placed on the center of the geometry
        public static partial class Placement
        {
            public static Box<ISymbolProperty> line() => Interop.mkSymbolAttr("placement", "line");
            public static Box<ISymbolProperty> lineCenter() => Interop.mkSymbolAttr("placement", "line-center");
            public static Box<ISymbolProperty> point() => Interop.mkSymbolAttr("placement", "point");
        }

        /// Sets the positions of the `text` elements with respects to the (x,y) coordinates.
        public static partial class Textposition
        {
            public static Box<ISymbolProperty> bottomCenter() => Interop.mkSymbolAttr("textposition", "bottom center");
            public static Box<ISymbolProperty> bottomLeft() => Interop.mkSymbolAttr("textposition", "bottom left");
            public static Box<ISymbolProperty> bottomRight() => Interop.mkSymbolAttr("textposition", "bottom right");
            public static Box<ISymbolProperty> middleCenter() => Interop.mkSymbolAttr("textposition", "middle center");
            public static Box<ISymbolProperty> middleLeft() => Interop.mkSymbolAttr("textposition", "middle left");
            public static Box<ISymbolProperty> middleRight() => Interop.mkSymbolAttr("textposition", "middle right");
            public static Box<ISymbolProperty> topCenter() => Interop.mkSymbolAttr("textposition", "top center");
            public static Box<ISymbolProperty> topLeft() => Interop.mkSymbolAttr("textposition", "top left");
            public static Box<ISymbolProperty> topRight() => Interop.mkSymbolAttr("textposition", "top right");
        }
    }
}