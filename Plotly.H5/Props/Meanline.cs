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

    public static partial class Meanline
    {
        /// Determines if a line corresponding to the sample's mean is shown inside the violins. If `box.visible` is turned on, the mean line is drawn inside the inner box. Otherwise, the mean line is drawn from one side of the violin to other.
        public static Box<IMeanlineProperty> visible(bool val) => Interop.mkMeanlineAttr("visible", val);
        /// Sets the mean line color.
        public static Box<IMeanlineProperty> color(string val) => Interop.mkMeanlineAttr("color", val);
        /// Sets the mean line width.
        public static Box<IMeanlineProperty> width(int val) => Interop.mkMeanlineAttr("width", val);
        /// Sets the mean line width.
        public static Box<IMeanlineProperty> width(float val) => Interop.mkMeanlineAttr("width", val);
    }
}