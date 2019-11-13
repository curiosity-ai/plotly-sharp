namespace PlotlyBridge
{
    /*////////////////////////////////
    /// THIS FILE IS AUTO-GENERATED //
    ///      by propsDocument       //
    ////////////////////////////////*/
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Types;
    using Bridge;
    using static Retyped.dom;

    public static partial class Projection
    {
        public static Box<IProjectionProperty> x(params Box<IXProperty>[] properties) => Interop.mkProjectionAttr("x", Bindings.flattenProperties(properties));
        public static Box<IProjectionProperty> y(params Box<IYProperty>[] properties) => Interop.mkProjectionAttr("y", Bindings.flattenProperties(properties));
        public static Box<IProjectionProperty> z(params Box<IZProperty>[] properties) => Interop.mkProjectionAttr("z", Bindings.flattenProperties(properties));
        public static Box<IProjectionProperty> rotation(params Box<IRotationProperty>[] properties) => Interop.mkProjectionAttr("rotation", Bindings.flattenProperties(properties));
        /// For conic projection types only. Sets the parallels (tangent, secant) where the cone intersects the sphere.
        public static Box<IProjectionProperty> parallels(int val) => Interop.mkProjectionAttr("parallels", new[]{val});
        /// For conic projection types only. Sets the parallels (tangent, secant) where the cone intersects the sphere.
        public static Box<IProjectionProperty> parallels(IEnumerable<int> values) => Interop.mkProjectionAttr("parallels", values.ToArray());
        /// For conic projection types only. Sets the parallels (tangent, secant) where the cone intersects the sphere.
        public static Box<IProjectionProperty> parallels(float val) => Interop.mkProjectionAttr("parallels", new[]{val});
        /// For conic projection types only. Sets the parallels (tangent, secant) where the cone intersects the sphere.
        public static Box<IProjectionProperty> parallels(IEnumerable<float> values) => Interop.mkProjectionAttr("parallels", values.ToArray());
        /// Zooms in or out on the map view. A scale of *1* corresponds to the largest zoom level that fits the map's lon and lat ranges.
        public static Box<IProjectionProperty> scale(int val) => Interop.mkProjectionAttr("scale", val);
        /// Zooms in or out on the map view. A scale of *1* corresponds to the largest zoom level that fits the map's lon and lat ranges.
        public static Box<IProjectionProperty> scale(float val) => Interop.mkProjectionAttr("scale", val);
    }

    public static partial class Projection
    {
        /// Sets the projection type. The projection type could be either *perspective* or *orthographic*. The default is *perspective*.
        public static partial class _type
        {
            public static Box<IProjectionProperty> aitoff() => Interop.mkProjectionAttr("type", "aitoff");
            public static Box<IProjectionProperty> albersUsa() => Interop.mkProjectionAttr("type", "albers usa");
            public static Box<IProjectionProperty> azimuthalEqualArea() => Interop.mkProjectionAttr("type", "azimuthal equal area");
            public static Box<IProjectionProperty> azimuthalEquidistant() => Interop.mkProjectionAttr("type", "azimuthal equidistant");
            public static Box<IProjectionProperty> conicConformal() => Interop.mkProjectionAttr("type", "conic conformal");
            public static Box<IProjectionProperty> conicEqualArea() => Interop.mkProjectionAttr("type", "conic equal area");
            public static Box<IProjectionProperty> conicEquidistant() => Interop.mkProjectionAttr("type", "conic equidistant");
            public static Box<IProjectionProperty> eckert4() => Interop.mkProjectionAttr("type", "eckert4");
            public static Box<IProjectionProperty> equirectangular() => Interop.mkProjectionAttr("type", "equirectangular");
            public static Box<IProjectionProperty> gnomonic() => Interop.mkProjectionAttr("type", "gnomonic");
            public static Box<IProjectionProperty> hammer() => Interop.mkProjectionAttr("type", "hammer");
            public static Box<IProjectionProperty> kavrayskiy7() => Interop.mkProjectionAttr("type", "kavrayskiy7");
            public static Box<IProjectionProperty> mercator() => Interop.mkProjectionAttr("type", "mercator");
            public static Box<IProjectionProperty> miller() => Interop.mkProjectionAttr("type", "miller");
            public static Box<IProjectionProperty> mollweide() => Interop.mkProjectionAttr("type", "mollweide");
            public static Box<IProjectionProperty> naturalEarth() => Interop.mkProjectionAttr("type", "natural earth");
            public static Box<IProjectionProperty> orthographic() => Interop.mkProjectionAttr("type", "orthographic");
            public static Box<IProjectionProperty> perspective() => Interop.mkProjectionAttr("type", "perspective");
            public static Box<IProjectionProperty> robinson() => Interop.mkProjectionAttr("type", "robinson");
            public static Box<IProjectionProperty> sinusoidal() => Interop.mkProjectionAttr("type", "sinusoidal");
            public static Box<IProjectionProperty> stereographic() => Interop.mkProjectionAttr("type", "stereographic");
            public static Box<IProjectionProperty> transverseMercator() => Interop.mkProjectionAttr("type", "transverse mercator");
            public static Box<IProjectionProperty> winkelTripel() => Interop.mkProjectionAttr("type", "winkel tripel");
        }
    }
}