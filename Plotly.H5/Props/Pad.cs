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
    using static Retyped.dom;

    public static partial class Pad
    {
        /// Sets the padding form the top (in px).
        public static Box<IPadProperty> t(int val) => Interop.mkPadAttr("t", val);
        /// Sets the padding form the top (in px).
        public static Box<IPadProperty> t(float val) => Interop.mkPadAttr("t", val);
        /// Sets the padding form the left (in px).
        public static Box<IPadProperty> l(int val) => Interop.mkPadAttr("l", val);
        /// Sets the padding form the left (in px).
        public static Box<IPadProperty> l(float val) => Interop.mkPadAttr("l", val);
        /// Sets the padding form the right (in px).
        public static Box<IPadProperty> r(int val) => Interop.mkPadAttr("r", val);
        /// Sets the padding form the right (in px).
        public static Box<IPadProperty> r(float val) => Interop.mkPadAttr("r", val);
        /// Sets the padding form the bottom (in px).
        public static Box<IPadProperty> b(int val) => Interop.mkPadAttr("b", val);
        /// Sets the padding form the bottom (in px).
        public static Box<IPadProperty> b(float val) => Interop.mkPadAttr("b", val);
    }
}