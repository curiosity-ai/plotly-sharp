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

    public static partial class Outsidetextfont
    {
        /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
        public static Box<IOutsidetextfontProperty> family(string val) => Interop.mkOutsidetextfontAttr("family", val);
        /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
        public static Box<IOutsidetextfontProperty> family(IEnumerable<string> values) => Interop.mkOutsidetextfontAttr("family", values.ToArray());
        public static Box<IOutsidetextfontProperty> size(int val) => Interop.mkOutsidetextfontAttr("size", val);
        public static Box<IOutsidetextfontProperty> size(float val) => Interop.mkOutsidetextfontAttr("size", val);
        public static Box<IOutsidetextfontProperty> size(IEnumerable<int> values) => Interop.mkOutsidetextfontAttr("size", values.ToArray());
        public static Box<IOutsidetextfontProperty> size(IEnumerable<float> values) => Interop.mkOutsidetextfontAttr("size", values.ToArray());
        public static Box<IOutsidetextfontProperty> color(string val) => Interop.mkOutsidetextfontAttr("color", val);
        public static Box<IOutsidetextfontProperty> color(IEnumerable<string> values) => Interop.mkOutsidetextfontAttr("color", values.ToArray());
        public static Box<IOutsidetextfontProperty> color(params int[] values) => Interop.mkOutsidetextfontAttr("color", values);
        public static Box<IOutsidetextfontProperty> color(params float[] values) => Interop.mkOutsidetextfontAttr("color", values);
        /// Sets the source reference on plot.ly for  family .
        public static Box<IOutsidetextfontProperty> familysrc(string val) => Interop.mkOutsidetextfontAttr("familysrc", val);
        /// Sets the source reference on plot.ly for  size .
        public static Box<IOutsidetextfontProperty> sizesrc(string val) => Interop.mkOutsidetextfontAttr("sizesrc", val);
        /// Sets the source reference on plot.ly for  color .
        public static Box<IOutsidetextfontProperty> colorsrc(string val) => Interop.mkOutsidetextfontAttr("colorsrc", val);
    }
}