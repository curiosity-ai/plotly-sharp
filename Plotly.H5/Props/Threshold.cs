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

    public static partial class Threshold
    {
        public static Box<IThresholdProperty> line(params Box<ILineProperty>[] properties) => Interop.mkThresholdAttr("line", Bindings.flattenProperties(properties));
        /// Sets the thickness of the threshold line as a fraction of the thickness of the gauge.
        public static Box<IThresholdProperty> thickness(int val) => Interop.mkThresholdAttr("thickness", val);
        /// Sets the thickness of the threshold line as a fraction of the thickness of the gauge.
        public static Box<IThresholdProperty> thickness(float val) => Interop.mkThresholdAttr("thickness", val);
        /// Sets a treshold value drawn as a line.
        public static Box<IThresholdProperty> value(int val) => Interop.mkThresholdAttr("value", val);
        /// Sets a treshold value drawn as a line.
        public static Box<IThresholdProperty> value(float val) => Interop.mkThresholdAttr("value", val);
    }
}