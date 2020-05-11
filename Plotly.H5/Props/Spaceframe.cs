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

    public static partial class Spaceframe
    {
        /// Displays/hides tetrahedron shapes between minimum and maximum iso-values. Often useful when either caps or surfaces are disabled or filled with values less than 1.
        public static Box<ISpaceframeProperty> show(bool val) => Interop.mkSpaceframeAttr("show", val);
        /// Sets the fill ratio of the `spaceframe` elements. The default fill value is 0.15 meaning that only 15% of the area of every faces of tetras would be shaded. Applying a greater `fill` ratio would allow the creation of stronger elements or could be sued to have entirely closed areas (in case of using 1).
        public static Box<ISpaceframeProperty> fill(int val) => Interop.mkSpaceframeAttr("fill", val);
        /// Sets the fill ratio of the `spaceframe` elements. The default fill value is 0.15 meaning that only 15% of the area of every faces of tetras would be shaded. Applying a greater `fill` ratio would allow the creation of stronger elements or could be sued to have entirely closed areas (in case of using 1).
        public static Box<ISpaceframeProperty> fill(float val) => Interop.mkSpaceframeAttr("fill", val);
    }
}