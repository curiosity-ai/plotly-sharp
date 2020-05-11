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

    public static partial class Center
    {
        public static Box<ICenterProperty> x(int val) => Interop.mkCenterAttr("x", val);
        public static Box<ICenterProperty> x(float val) => Interop.mkCenterAttr("x", val);
        public static Box<ICenterProperty> y(int val) => Interop.mkCenterAttr("y", val);
        public static Box<ICenterProperty> y(float val) => Interop.mkCenterAttr("y", val);
        public static Box<ICenterProperty> z(int val) => Interop.mkCenterAttr("z", val);
        public static Box<ICenterProperty> z(float val) => Interop.mkCenterAttr("z", val);
        /// Sets the longitude of the map's center. By default, the map's longitude center lies at the middle of the longitude range for scoped projection and above `projection.rotation.lon` otherwise.
        public static Box<ICenterProperty> lon(int val) => Interop.mkCenterAttr("lon", val);
        /// Sets the longitude of the map's center. By default, the map's longitude center lies at the middle of the longitude range for scoped projection and above `projection.rotation.lon` otherwise.
        public static Box<ICenterProperty> lon(float val) => Interop.mkCenterAttr("lon", val);
        /// Sets the latitude of the map's center. For all projection types, the map's latitude center lies at the middle of the latitude range by default.
        public static Box<ICenterProperty> lat(int val) => Interop.mkCenterAttr("lat", val);
        /// Sets the latitude of the map's center. For all projection types, the map's latitude center lies at the middle of the latitude range by default.
        public static Box<ICenterProperty> lat(float val) => Interop.mkCenterAttr("lat", val);
    }
}