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

    public static partial class Labelfont
    {
        /// HTML font family - the typeface that will be applied by the web browser. The web browser will only be able to apply a font if it is available on the system which it operates. Provide multiple font families, separated by commas, to indicate the preference in which to apply fonts if they aren't available on the system. The plotly service (at https://plot.ly or on-premise) generates images on a server, where only a select number of fonts are installed and supported. These include *Arial*, *Balto*, *Courier New*, *Droid Sans*,, *Droid Serif*, *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*, *PT Sans Narrow*, *Raleway*, *Times New Roman*.
        public static Box<ILabelfontProperty> family(string val) => Interop.mkLabelfontAttr("family", val);
        public static Box<ILabelfontProperty> size(int val) => Interop.mkLabelfontAttr("size", val);
        public static Box<ILabelfontProperty> size(float val) => Interop.mkLabelfontAttr("size", val);
        public static Box<ILabelfontProperty> color(string val) => Interop.mkLabelfontAttr("color", val);
    }
}