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

    public static partial class Legendgrouptitle
    {
        /// Sets the title of the legend group.
        public static Box<ILegendgrouptitleProperty> text(string val) => Interop.mkLegendgrouptitleAttr("text", val);
        /// Sets this legend group's title font.
        public static Box<ILegendgrouptitleProperty> font(params Box<IFontProperty>[] properties) => Interop.mkLegendgrouptitleAttr("font", Bindings.flattenProperties(properties));
    }
}