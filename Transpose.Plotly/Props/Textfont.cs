namespace Transpose.Plotly
{
    /*////////////////////////////////
    /// THIS FILE IS AUTO-GENERATED //
    ///      by propsDocument       //
    ////////////////////////////////*/
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Types;
    using Transpose;
    using static Transpose.Core.dom;

    public static partial class Textfont
    {
        /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
        public static Box<ITextfontProperty> family(string val) => Interop.mkTextfontAttr("family", val);
        /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The Chart Studio Cloud (at https://chart-studio.plotly.com or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
        public static Box<ITextfontProperty> family(IEnumerable<string> values) => Interop.mkTextfontAttr("family", values.ToArray());
        public static Box<ITextfontProperty> size(int val) => Interop.mkTextfontAttr("size", val);
        public static Box<ITextfontProperty> size(float val) => Interop.mkTextfontAttr("size", val);
        public static Box<ITextfontProperty> size(IEnumerable<int> values) => Interop.mkTextfontAttr("size", values.ToArray());
        public static Box<ITextfontProperty> size(IEnumerable<float> values) => Interop.mkTextfontAttr("size", values.ToArray());
        public static Box<ITextfontProperty> color(string val) => Interop.mkTextfontAttr("color", val);
        public static Box<ITextfontProperty> color(IEnumerable<string> values) => Interop.mkTextfontAttr("color", values.ToArray());
        public static Box<ITextfontProperty> color(params int[] values) => Interop.mkTextfontAttr("color", values);
        public static Box<ITextfontProperty> color(params float[] values) => Interop.mkTextfontAttr("color", values);
        /// Sets the source reference on Chart Studio Cloud for  family .
        public static Box<ITextfontProperty> familysrc(string val) => Interop.mkTextfontAttr("familysrc", val);
        /// Sets the source reference on Chart Studio Cloud for  size .
        public static Box<ITextfontProperty> sizesrc(string val) => Interop.mkTextfontAttr("sizesrc", val);
        /// Sets the source reference on Chart Studio Cloud for  color .
        public static Box<ITextfontProperty> colorsrc(string val) => Interop.mkTextfontAttr("colorsrc", val);
    }
}