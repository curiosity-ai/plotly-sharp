namespace PlotlyH5
{
    /*////////////////////////////////
    /// THIS FILE IS AUTO-GENERATED //
    ///      by propsDocument       //
    ////////////////////////////////*/
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Types;
    using H5;
    using static H5.Core.dom;

    public static partial class Font
    {
        /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
        public static Box<IFontProperty> family(string val) => Interop.mkFontAttr("family", val);
        public static Box<IFontProperty> size(int val) => Interop.mkFontAttr("size", val);
        public static Box<IFontProperty> size(float val) => Interop.mkFontAttr("size", val);
        public static Box<IFontProperty> color(string val) => Interop.mkFontAttr("color", val);
        /// Sets the source reference on Chart Studio Cloud for  family .
        public static Box<IFontProperty> familysrc(string val) => Interop.mkFontAttr("familysrc", val);
        /// Sets the source reference on Chart Studio Cloud for  size .
        public static Box<IFontProperty> sizesrc(string val) => Interop.mkFontAttr("sizesrc", val);
        /// Sets the source reference on Chart Studio Cloud for  color .
        public static Box<IFontProperty> colorsrc(string val) => Interop.mkFontAttr("colorsrc", val);
    }
}