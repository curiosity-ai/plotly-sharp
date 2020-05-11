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

    public static partial class Insidetextfont
    {
        /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
        public static Box<IInsidetextfontProperty> family(string val) => Interop.mkInsidetextfontAttr("family", val);
        /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
        public static Box<IInsidetextfontProperty> family(IEnumerable<string> values) => Interop.mkInsidetextfontAttr("family", values.ToArray());
        public static Box<IInsidetextfontProperty> size(int val) => Interop.mkInsidetextfontAttr("size", val);
        public static Box<IInsidetextfontProperty> size(float val) => Interop.mkInsidetextfontAttr("size", val);
        public static Box<IInsidetextfontProperty> size(IEnumerable<int> values) => Interop.mkInsidetextfontAttr("size", values.ToArray());
        public static Box<IInsidetextfontProperty> size(IEnumerable<float> values) => Interop.mkInsidetextfontAttr("size", values.ToArray());
        public static Box<IInsidetextfontProperty> color(string val) => Interop.mkInsidetextfontAttr("color", val);
        public static Box<IInsidetextfontProperty> color(IEnumerable<string> values) => Interop.mkInsidetextfontAttr("color", values.ToArray());
        public static Box<IInsidetextfontProperty> color(params int[] values) => Interop.mkInsidetextfontAttr("color", values);
        public static Box<IInsidetextfontProperty> color(params float[] values) => Interop.mkInsidetextfontAttr("color", values);
        /// Sets the source reference on plot.ly for  family .
        public static Box<IInsidetextfontProperty> familysrc(string val) => Interop.mkInsidetextfontAttr("familysrc", val);
        /// Sets the source reference on plot.ly for  size .
        public static Box<IInsidetextfontProperty> sizesrc(string val) => Interop.mkInsidetextfontAttr("sizesrc", val);
        /// Sets the source reference on plot.ly for  color .
        public static Box<IInsidetextfontProperty> colorsrc(string val) => Interop.mkInsidetextfontAttr("colorsrc", val);
    }
}