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

    public static partial class Number
    {
        /// Sets the value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<INumberProperty> valueformat(string val) => Interop.mkNumberAttr("valueformat", val);
        /// Set the font used to display main number
        public static Box<INumberProperty> font(params Box<IFontProperty>[] properties) => Interop.mkNumberAttr("font", Bindings.flattenProperties(properties));
        /// Sets a prefix appearing before the number.
        public static Box<INumberProperty> prefix(string val) => Interop.mkNumberAttr("prefix", val);
        /// Sets a suffix appearing next to the number.
        public static Box<INumberProperty> suffix(string val) => Interop.mkNumberAttr("suffix", val);
    }
}