namespace Transpose.Plotly
{
    /*////////////////////////////////
    /// THIS FILE IS AUTO-GENERATED //
    ///      by propsDocument       //
    ////////////////////////////////*/
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Types;
    using Transpose;
    using static Transpose.Core.dom;

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
        /// Determines which predefined modebar buttons to add. Please note that these buttons will only be shown if they are compatible with all trace types used in a graph. Similar to `config.modeBarButtonsToAdd` option. This may include *v1hovermode*, *hoverclosest*, *hovercompare*, *togglehover*, *togglespikelines*, *drawline*, *drawopenpath*, *drawclosedpath*, *drawcircle*, *drawrect*, *eraseshape*.
        public static Box<IModebarProperty> add(string val) => Interop.mkModebarAttr("add", val);
        /// Determines which predefined modebar buttons to add. Please note that these buttons will only be shown if they are compatible with all trace types used in a graph. Similar to `config.modeBarButtonsToAdd` option. This may include *v1hovermode*, *hoverclosest*, *hovercompare*, *togglehover*, *togglespikelines*, *drawline*, *drawopenpath*, *drawclosedpath*, *drawcircle*, *drawrect*, *eraseshape*.
        public static Box<IModebarProperty> add(IEnumerable<string> values) => Interop.mkModebarAttr("add", values.ToArray());
        /// Determines which predefined modebar buttons to remove. Similar to `config.modeBarButtonsToRemove` option. This may include *autoScale2d*, *autoscale*, *editInChartStudio*, *editinchartstudio*, *hoverCompareCartesian*, *hovercompare*, *lasso*, *lasso2d*, *orbitRotation*, *orbitrotation*, *pan*, *pan2d*, *pan3d*, *reset*, *resetCameraDefault3d*, *resetCameraLastSave3d*, *resetGeo*, *resetSankeyGroup*, *resetScale2d*, *resetViewMapbox*, *resetViews*, *resetcameradefault*, *resetcameralastsave*, *resetsankeygroup*, *resetscale*, *resetview*, *resetviews*, *select*, *select2d*, *sendDataToCloud*, *senddatatocloud*, *tableRotation*, *tablerotation*, *toImage*, *toggleHover*, *toggleSpikelines*, *togglehover*, *togglespikelines*, *toimage*, *zoom*, *zoom2d*, *zoom3d*, *zoomIn2d*, *zoomInGeo*, *zoomInMapbox*, *zoomOut2d*, *zoomOutGeo*, *zoomOutMapbox*, *zoomin*, *zoomout*.
        public static Box<IModebarProperty> remove(string val) => Interop.mkModebarAttr("remove", val);
        /// Determines which predefined modebar buttons to remove. Similar to `config.modeBarButtonsToRemove` option. This may include *autoScale2d*, *autoscale*, *editInChartStudio*, *editinchartstudio*, *hoverCompareCartesian*, *hovercompare*, *lasso*, *lasso2d*, *orbitRotation*, *orbitrotation*, *pan*, *pan2d*, *pan3d*, *reset*, *resetCameraDefault3d*, *resetCameraLastSave3d*, *resetGeo*, *resetSankeyGroup*, *resetScale2d*, *resetViewMapbox*, *resetViews*, *resetcameradefault*, *resetcameralastsave*, *resetsankeygroup*, *resetscale*, *resetview*, *resetviews*, *select*, *select2d*, *sendDataToCloud*, *senddatatocloud*, *tableRotation*, *tablerotation*, *toImage*, *toggleHover*, *toggleSpikelines*, *togglehover*, *togglespikelines*, *toimage*, *zoom*, *zoom2d*, *zoom3d*, *zoomIn2d*, *zoomInGeo*, *zoomInMapbox*, *zoomOut2d*, *zoomOutGeo*, *zoomOutMapbox*, *zoomin*, *zoomout*.
        public static Box<IModebarProperty> remove(IEnumerable<string> values) => Interop.mkModebarAttr("remove", values.ToArray());
        /// Sets the source reference on Chart Studio Cloud for  add .
        public static Box<IModebarProperty> addsrc(string val) => Interop.mkModebarAttr("addsrc", val);
        /// Sets the source reference on Chart Studio Cloud for  remove .
        public static Box<IModebarProperty> removesrc(string val) => Interop.mkModebarAttr("removesrc", val);
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