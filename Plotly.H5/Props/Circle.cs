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

    public static partial class Circle
    {
        /// Sets the circle radius (mapbox.layer.paint.circle-radius). Has an effect only when `type` is set to *circle*.
        public static Box<ICircleProperty> radius(int val) => Interop.mkCircleAttr("radius", val);
        /// Sets the circle radius (mapbox.layer.paint.circle-radius). Has an effect only when `type` is set to *circle*.
        public static Box<ICircleProperty> radius(float val) => Interop.mkCircleAttr("radius", val);
    }
}