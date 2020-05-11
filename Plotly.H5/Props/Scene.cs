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

    public static partial class Scene
    {
        public static Box<ISceneProperty> bgcolor(string val) => Interop.mkSceneAttr("bgcolor", val);
        public static Box<ISceneProperty> camera(params Box<ICameraProperty>[] properties) => Interop.mkSceneAttr("camera", Bindings.flattenProperties(properties));
        public static Box<ISceneProperty> domain(params Box<IDomainProperty>[] properties) => Interop.mkSceneAttr("domain", Bindings.flattenProperties(properties));
        /// Sets this scene's axis aspectratio.
        public static Box<ISceneProperty> aspectratio(params Box<IAspectratioProperty>[] properties) => Interop.mkSceneAttr("aspectratio", Bindings.flattenProperties(properties));
        public static Box<ISceneProperty> xaxis(int anchorId) => Interop.mkSceneAttr("xaxis", anchorId > 1 ? $"x{anchorId}" : "");
        public static Box<ISceneProperty> xaxis(params Box<IXaxisProperty>[] properties) => Interop.mkSceneAttr("xaxis", Bindings.flattenProperties(properties));
        public static Box<ISceneProperty> yaxis(int anchorId) => Interop.mkSceneAttr("yaxis", anchorId > 1 ? $"y{anchorId}" : "");
        public static Box<ISceneProperty> yaxis(params Box<IYaxisProperty>[] properties) => Interop.mkSceneAttr("yaxis", Bindings.flattenProperties(properties));
        public static Box<ISceneProperty> zaxis(params Box<IZaxisProperty>[] properties) => Interop.mkSceneAttr("zaxis", Bindings.flattenProperties(properties));
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        public static Box<ISceneProperty> uirevision(bool val) => Interop.mkSceneAttr("uirevision", val);
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        public static Box<ISceneProperty> uirevision(params bool[] values) => Interop.mkSceneAttr("uirevision", values);
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        public static Box<ISceneProperty> uirevision(System.DateTime val) => Interop.mkSceneAttr("uirevision", val);
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        public static Box<ISceneProperty> uirevision(params System.DateTime[] values) => Interop.mkSceneAttr("uirevision", values);
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        public static Box<ISceneProperty> uirevision(int val) => Interop.mkSceneAttr("uirevision", val);
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        public static Box<ISceneProperty> uirevision(params int[] values) => Interop.mkSceneAttr("uirevision", values);
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        public static Box<ISceneProperty> uirevision(float val) => Interop.mkSceneAttr("uirevision", val);
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        public static Box<ISceneProperty> uirevision(params float[] values) => Interop.mkSceneAttr("uirevision", values);
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        public static Box<ISceneProperty> uirevision(string val) => Interop.mkSceneAttr("uirevision", val);
        /// Controls persistence of user-driven changes in camera attributes. Defaults to `layout.uirevision`.
        public static Box<ISceneProperty> uirevision(params string[] values) => Interop.mkSceneAttr("uirevision", values);
        public static Box<ISceneProperty> annotations(params Box<IAnnotationsProperty>[] properties) => Interop.mkSceneAttr("annotations", Bindings.flattenPropertiesToArray(properties));
    }

    public static partial class Scene
    {
        /// If *cube*, this scene's axes are drawn as a cube, regardless of the axes' ranges. If *data*, this scene's axes are drawn in proportion with the axes' ranges. If *manual*, this scene's axes are drawn in proportion with the input of *aspectratio* (the default behavior if *aspectratio* is provided). If *auto*, this scene's axes are drawn using the results of *data* except when one axis is more than four times the size of the two others, where in that case the results of *cube* are used.
        public static partial class Aspectmode
        {
            public static Box<ISceneProperty> auto() => Interop.mkSceneAttr("aspectmode", "auto");
            public static Box<ISceneProperty> cube() => Interop.mkSceneAttr("aspectmode", "cube");
            public static Box<ISceneProperty> data() => Interop.mkSceneAttr("aspectmode", "data");
            public static Box<ISceneProperty> manual() => Interop.mkSceneAttr("aspectmode", "manual");
        }

        /// Determines the mode of drag interactions for this scene.
        public static partial class Dragmode
        {
            public static Box<ISceneProperty> orbit() => Interop.mkSceneAttr("dragmode", "orbit");
            public static Box<ISceneProperty> pan() => Interop.mkSceneAttr("dragmode", "pan");
            public static Box<ISceneProperty> turntable() => Interop.mkSceneAttr("dragmode", "turntable");
            public static Box<ISceneProperty> zoom() => Interop.mkSceneAttr("dragmode", "zoom");
            public static Box<ISceneProperty> _false() => Interop.mkSceneAttr("dragmode", false);
        }

        /// Determines the mode of hover interactions for this scene.
        public static partial class Hovermode
        {
            public static Box<ISceneProperty> closest() => Interop.mkSceneAttr("hovermode", "closest");
            public static Box<ISceneProperty> _false() => Interop.mkSceneAttr("hovermode", false);
        }
    }
}