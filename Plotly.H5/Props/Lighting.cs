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

    public static partial class Lighting
    {
        /// Ambient light increases overall color visibility but can wash out the image.
        public static Box<ILightingProperty> ambient(int val) => Interop.mkLightingAttr("ambient", val);
        /// Ambient light increases overall color visibility but can wash out the image.
        public static Box<ILightingProperty> ambient(float val) => Interop.mkLightingAttr("ambient", val);
        /// Represents the extent that incident rays are reflected in a range of angles.
        public static Box<ILightingProperty> diffuse(int val) => Interop.mkLightingAttr("diffuse", val);
        /// Represents the extent that incident rays are reflected in a range of angles.
        public static Box<ILightingProperty> diffuse(float val) => Interop.mkLightingAttr("diffuse", val);
        /// Represents the level that incident rays are reflected in a single direction, causing shine.
        public static Box<ILightingProperty> specular(int val) => Interop.mkLightingAttr("specular", val);
        /// Represents the level that incident rays are reflected in a single direction, causing shine.
        public static Box<ILightingProperty> specular(float val) => Interop.mkLightingAttr("specular", val);
        /// Alters specular reflection; the rougher the surface, the wider and less contrasty the shine.
        public static Box<ILightingProperty> roughness(int val) => Interop.mkLightingAttr("roughness", val);
        /// Alters specular reflection; the rougher the surface, the wider and less contrasty the shine.
        public static Box<ILightingProperty> roughness(float val) => Interop.mkLightingAttr("roughness", val);
        /// Represents the reflectance as a dependency of the viewing angle; e.g. paper is reflective when viewing it from the edge of the paper (almost 90 degrees), causing shine.
        public static Box<ILightingProperty> fresnel(int val) => Interop.mkLightingAttr("fresnel", val);
        /// Represents the reflectance as a dependency of the viewing angle; e.g. paper is reflective when viewing it from the edge of the paper (almost 90 degrees), causing shine.
        public static Box<ILightingProperty> fresnel(float val) => Interop.mkLightingAttr("fresnel", val);
        /// Epsilon for vertex normals calculation avoids math issues arising from degenerate geometry.
        public static Box<ILightingProperty> vertexnormalsepsilon(int val) => Interop.mkLightingAttr("vertexnormalsepsilon", val);
        /// Epsilon for vertex normals calculation avoids math issues arising from degenerate geometry.
        public static Box<ILightingProperty> vertexnormalsepsilon(float val) => Interop.mkLightingAttr("vertexnormalsepsilon", val);
        /// Epsilon for face normals calculation avoids math issues arising from degenerate geometry.
        public static Box<ILightingProperty> facenormalsepsilon(int val) => Interop.mkLightingAttr("facenormalsepsilon", val);
        /// Epsilon for face normals calculation avoids math issues arising from degenerate geometry.
        public static Box<ILightingProperty> facenormalsepsilon(float val) => Interop.mkLightingAttr("facenormalsepsilon", val);
    }
}