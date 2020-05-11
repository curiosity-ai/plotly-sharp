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

    public static partial class Project
    {
        /// Determines whether or not these contour lines are projected on the x plane. If `highlight` is set to *true* (the default), the projected lines are shown on hover. If `show` is set to *true*, the projected lines are shown in permanence.
        public static Box<IProjectProperty> x(bool val) => Interop.mkProjectAttr("x", val);
        /// Determines whether or not these contour lines are projected on the y plane. If `highlight` is set to *true* (the default), the projected lines are shown on hover. If `show` is set to *true*, the projected lines are shown in permanence.
        public static Box<IProjectProperty> y(bool val) => Interop.mkProjectAttr("y", val);
        /// Determines whether or not these contour lines are projected on the z plane. If `highlight` is set to *true* (the default), the projected lines are shown on hover. If `show` is set to *true*, the projected lines are shown in permanence.
        public static Box<IProjectProperty> z(bool val) => Interop.mkProjectAttr("z", val);
    }
}