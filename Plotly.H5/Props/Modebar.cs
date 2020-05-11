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

    public static partial class Modebar
    {
        /// Sets the background color of the modebar.
        public static Box<IModebarProperty> bgcolor(string val) => Interop.mkModebarAttr("bgcolor", val);
        /// Sets the color of the icons in the modebar.
        public static Box<IModebarProperty> color(string val) => Interop.mkModebarAttr("color", val);
        /// Sets the color of the active or hovered on icons in the modebar.
        public static Box<IModebarProperty> activecolor(string val) => Interop.mkModebarAttr("activecolor", val);
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        public static Box<IModebarProperty> uirevision(bool val) => Interop.mkModebarAttr("uirevision", val);
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        public static Box<IModebarProperty> uirevision(params bool[] values) => Interop.mkModebarAttr("uirevision", values);
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        public static Box<IModebarProperty> uirevision(System.DateTime val) => Interop.mkModebarAttr("uirevision", val);
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        public static Box<IModebarProperty> uirevision(params System.DateTime[] values) => Interop.mkModebarAttr("uirevision", values);
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        public static Box<IModebarProperty> uirevision(int val) => Interop.mkModebarAttr("uirevision", val);
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        public static Box<IModebarProperty> uirevision(params int[] values) => Interop.mkModebarAttr("uirevision", values);
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        public static Box<IModebarProperty> uirevision(float val) => Interop.mkModebarAttr("uirevision", val);
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        public static Box<IModebarProperty> uirevision(params float[] values) => Interop.mkModebarAttr("uirevision", values);
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        public static Box<IModebarProperty> uirevision(string val) => Interop.mkModebarAttr("uirevision", val);
        /// Controls persistence of user-driven changes related to the modebar, including `hovermode`, `dragmode`, and `showspikes` at both the root level and inside subplots. Defaults to `layout.uirevision`.
        public static Box<IModebarProperty> uirevision(params string[] values) => Interop.mkModebarAttr("uirevision", values);
    }

    public static partial class Modebar
    {
        /// Sets the orientation of the modebar.
        public static partial class Orientation
        {
            public static Box<IModebarProperty> h() => Interop.mkModebarAttr("orientation", "h");
            public static Box<IModebarProperty> v() => Interop.mkModebarAttr("orientation", "v");
        }
    }
}