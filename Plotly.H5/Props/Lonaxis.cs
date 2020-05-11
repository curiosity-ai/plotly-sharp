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

    public static partial class Lonaxis
    {
        /// Sets the range of this axis (in degrees), sets the map's clipped coordinates.
        public static Box<ILonaxisProperty> range(int val) => Interop.mkLonaxisAttr("range", new[]{val});
        /// Sets the range of this axis (in degrees), sets the map's clipped coordinates.
        public static Box<ILonaxisProperty> range(IEnumerable<int> values) => Interop.mkLonaxisAttr("range", values.ToArray());
        /// Sets the range of this axis (in degrees), sets the map's clipped coordinates.
        public static Box<ILonaxisProperty> range(float val) => Interop.mkLonaxisAttr("range", new[]{val});
        /// Sets the range of this axis (in degrees), sets the map's clipped coordinates.
        public static Box<ILonaxisProperty> range(IEnumerable<float> values) => Interop.mkLonaxisAttr("range", values.ToArray());
        /// Sets whether or not graticule are shown on the map.
        public static Box<ILonaxisProperty> showgrid(bool val) => Interop.mkLonaxisAttr("showgrid", val);
        /// Sets the graticule's starting tick longitude/latitude.
        public static Box<ILonaxisProperty> tick0(int val) => Interop.mkLonaxisAttr("tick0", val);
        /// Sets the graticule's starting tick longitude/latitude.
        public static Box<ILonaxisProperty> tick0(float val) => Interop.mkLonaxisAttr("tick0", val);
        /// Sets the graticule's longitude/latitude tick step.
        public static Box<ILonaxisProperty> dtick(int val) => Interop.mkLonaxisAttr("dtick", val);
        /// Sets the graticule's longitude/latitude tick step.
        public static Box<ILonaxisProperty> dtick(float val) => Interop.mkLonaxisAttr("dtick", val);
        /// Sets the graticule's stroke color.
        public static Box<ILonaxisProperty> gridcolor(string val) => Interop.mkLonaxisAttr("gridcolor", val);
        /// Sets the graticule's stroke width (in px).
        public static Box<ILonaxisProperty> gridwidth(int val) => Interop.mkLonaxisAttr("gridwidth", val);
        /// Sets the graticule's stroke width (in px).
        public static Box<ILonaxisProperty> gridwidth(float val) => Interop.mkLonaxisAttr("gridwidth", val);
    }
}