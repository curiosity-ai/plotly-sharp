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

    public static partial class Eye
    {
        public static Box<IEyeProperty> x(int val) => Interop.mkEyeAttr("x", val);
        public static Box<IEyeProperty> x(float val) => Interop.mkEyeAttr("x", val);
        public static Box<IEyeProperty> y(int val) => Interop.mkEyeAttr("y", val);
        public static Box<IEyeProperty> y(float val) => Interop.mkEyeAttr("y", val);
        public static Box<IEyeProperty> z(int val) => Interop.mkEyeAttr("z", val);
        public static Box<IEyeProperty> z(float val) => Interop.mkEyeAttr("z", val);
    }
}