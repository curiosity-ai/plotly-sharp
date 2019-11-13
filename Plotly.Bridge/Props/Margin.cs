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

    public static partial class Margin
    {
        /// Sets the left margin (in px).
        public static Box<IMarginProperty> l(int val) => Interop.mkMarginAttr("l", val);
        /// Sets the left margin (in px).
        public static Box<IMarginProperty> l(float val) => Interop.mkMarginAttr("l", val);
        /// Sets the right margin (in px).
        public static Box<IMarginProperty> r(int val) => Interop.mkMarginAttr("r", val);
        /// Sets the right margin (in px).
        public static Box<IMarginProperty> r(float val) => Interop.mkMarginAttr("r", val);
        /// Sets the top margin (in px).
        public static Box<IMarginProperty> t(int val) => Interop.mkMarginAttr("t", val);
        /// Sets the top margin (in px).
        public static Box<IMarginProperty> t(float val) => Interop.mkMarginAttr("t", val);
        /// Sets the bottom margin (in px).
        public static Box<IMarginProperty> b(int val) => Interop.mkMarginAttr("b", val);
        /// Sets the bottom margin (in px).
        public static Box<IMarginProperty> b(float val) => Interop.mkMarginAttr("b", val);
        /// Sets the amount of padding (in px) between the plotting area and the axis lines
        public static Box<IMarginProperty> pad(int val) => Interop.mkMarginAttr("pad", val);
        /// Sets the amount of padding (in px) between the plotting area and the axis lines
        public static Box<IMarginProperty> pad(float val) => Interop.mkMarginAttr("pad", val);
        /// Turns on/off margin expansion computations. Legends, colorbars, updatemenus, sliders, axis rangeselector and rangeslider are allowed to push the margins by defaults.
        public static Box<IMarginProperty> autoexpand(bool val) => Interop.mkMarginAttr("autoexpand", val);
    }
}