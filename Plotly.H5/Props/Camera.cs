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

    public static partial class Camera
    {
        /// Sets the (x,y,z) components of the 'up' camera vector. This vector determines the up direction of this scene with respect to the page. The default is *{x: 0, y: 0, z: 1}* which means that the z axis points up.
        public static Box<ICameraProperty> up(params Box<IUpProperty>[] properties) => Interop.mkCameraAttr("up", Bindings.flattenProperties(properties));
        /// Sets the (x,y,z) components of the 'center' camera vector This vector determines the translation (x,y,z) space about the center of this scene. By default, there is no such translation.
        public static Box<ICameraProperty> center(params Box<ICenterProperty>[] properties) => Interop.mkCameraAttr("center", Bindings.flattenProperties(properties));
        /// Sets the (x,y,z) components of the 'eye' camera vector. This vector determines the view point about the origin of this scene.
        public static Box<ICameraProperty> eye(params Box<IEyeProperty>[] properties) => Interop.mkCameraAttr("eye", Bindings.flattenProperties(properties));
        public static Box<ICameraProperty> projection(params Box<IProjectionProperty>[] properties) => Interop.mkCameraAttr("projection", Bindings.flattenProperties(properties));
    }
}