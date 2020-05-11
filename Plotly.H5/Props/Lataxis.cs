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

    public static partial class Lataxis
    {
        /// Sets the range of this axis (in degrees), sets the map's clipped coordinates.
        public static Box<ILataxisProperty> range(int val) => Interop.mkLataxisAttr("range", new[]{val});
        /// Sets the range of this axis (in degrees), sets the map's clipped coordinates.
        public static Box<ILataxisProperty> range(IEnumerable<int> values) => Interop.mkLataxisAttr("range", values.ToArray());
        /// Sets the range of this axis (in degrees), sets the map's clipped coordinates.
        public static Box<ILataxisProperty> range(float val) => Interop.mkLataxisAttr("range", new[]{val});
        /// Sets the range of this axis (in degrees), sets the map's clipped coordinates.
        public static Box<ILataxisProperty> range(IEnumerable<float> values) => Interop.mkLataxisAttr("range", values.ToArray());
        /// Sets whether or not graticule are shown on the map.
        public static Box<ILataxisProperty> showgrid(bool val) => Interop.mkLataxisAttr("showgrid", val);
        /// Sets the graticule's starting tick longitude/latitude.
        public static Box<ILataxisProperty> tick0(int val) => Interop.mkLataxisAttr("tick0", val);
        /// Sets the graticule's starting tick longitude/latitude.
        public static Box<ILataxisProperty> tick0(float val) => Interop.mkLataxisAttr("tick0", val);
        /// Sets the graticule's longitude/latitude tick step.
        public static Box<ILataxisProperty> dtick(int val) => Interop.mkLataxisAttr("dtick", val);
        /// Sets the graticule's longitude/latitude tick step.
        public static Box<ILataxisProperty> dtick(float val) => Interop.mkLataxisAttr("dtick", val);
        /// Sets the graticule's stroke color.
        public static Box<ILataxisProperty> gridcolor(string val) => Interop.mkLataxisAttr("gridcolor", val);
        /// Sets the graticule's stroke width (in px).
        public static Box<ILataxisProperty> gridwidth(int val) => Interop.mkLataxisAttr("gridwidth", val);
        /// Sets the graticule's stroke width (in px).
        public static Box<ILataxisProperty> gridwidth(float val) => Interop.mkLataxisAttr("gridwidth", val);
    }
}