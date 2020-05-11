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

    public static partial class Delta
    {
        /// Sets the reference value to compute the delta. By default, it is set to the current value.
        public static Box<IDeltaProperty> reference(int val) => Interop.mkDeltaAttr("reference", val);
        /// Sets the reference value to compute the delta. By default, it is set to the current value.
        public static Box<IDeltaProperty> reference(float val) => Interop.mkDeltaAttr("reference", val);
        /// Show relative change
        public static Box<IDeltaProperty> relative(bool val) => Interop.mkDeltaAttr("relative", val);
        /// Sets the value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IDeltaProperty> valueformat(string val) => Interop.mkDeltaAttr("valueformat", val);
        public static Box<IDeltaProperty> increasing(params Box<IIncreasingProperty>[] properties) => Interop.mkDeltaAttr("increasing", Bindings.flattenProperties(properties));
        public static Box<IDeltaProperty> decreasing(params Box<IDecreasingProperty>[] properties) => Interop.mkDeltaAttr("decreasing", Bindings.flattenProperties(properties));
        /// Set the font used to display the delta
        public static Box<IDeltaProperty> font(params Box<IFontProperty>[] properties) => Interop.mkDeltaAttr("font", Bindings.flattenProperties(properties));
    }

    public static partial class Delta
    {
        /// Sets the position of delta with respect to the number.
        public static partial class Position
        {
            public static Box<IDeltaProperty> bottom() => Interop.mkDeltaAttr("position", "bottom");
            public static Box<IDeltaProperty> left() => Interop.mkDeltaAttr("position", "left");
            public static Box<IDeltaProperty> right() => Interop.mkDeltaAttr("position", "right");
            public static Box<IDeltaProperty> top() => Interop.mkDeltaAttr("position", "top");
        }
    }
}