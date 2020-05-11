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

    public static partial class Gauge
    {
        /// Set the appearance of the gauge's value
        public static Box<IGaugeProperty> bar(params Box<IBarProperty>[] properties) => Interop.mkGaugeAttr("bar", Bindings.flattenProperties(properties));
        /// Sets the gauge background color.
        public static Box<IGaugeProperty> bgcolor(string val) => Interop.mkGaugeAttr("bgcolor", val);
        /// Sets the color of the border enclosing the gauge.
        public static Box<IGaugeProperty> bordercolor(string val) => Interop.mkGaugeAttr("bordercolor", val);
        /// Sets the width (in px) of the border enclosing the gauge.
        public static Box<IGaugeProperty> borderwidth(int val) => Interop.mkGaugeAttr("borderwidth", val);
        /// Sets the width (in px) of the border enclosing the gauge.
        public static Box<IGaugeProperty> borderwidth(float val) => Interop.mkGaugeAttr("borderwidth", val);
        public static Box<IGaugeProperty> axis(params Box<IAxisProperty>[] properties) => Interop.mkGaugeAttr("axis", Bindings.flattenProperties(properties));
        public static Box<IGaugeProperty> steps(params Box<IStepsProperty>[] properties) => Interop.mkGaugeAttr("steps", Bindings.flattenProperties(properties));
        public static Box<IGaugeProperty> threshold(params Box<IThresholdProperty>[] properties) => Interop.mkGaugeAttr("threshold", Bindings.flattenProperties(properties));
    }

    public static partial class Gauge
    {
        /// Set the shape of the gauge
        public static partial class Shape
        {
            public static Box<IGaugeProperty> angular() => Interop.mkGaugeAttr("shape", "angular");
            public static Box<IGaugeProperty> bullet() => Interop.mkGaugeAttr("shape", "bullet");
        }
    }
}