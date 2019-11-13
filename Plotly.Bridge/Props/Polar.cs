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

    public static partial class Polar
    {
        public static Box<IPolarProperty> domain(params Box<IDomainProperty>[] properties) => Interop.mkPolarAttr("domain", Bindings.flattenProperties(properties));
        /// Sets angular span of this polar subplot with two angles (in degrees). Sector are assumed to be spanned in the counterclockwise direction with *0* corresponding to rightmost limit of the polar subplot.
        public static Box<IPolarProperty> sector(int val) => Interop.mkPolarAttr("sector", new[]{val});
        /// Sets angular span of this polar subplot with two angles (in degrees). Sector are assumed to be spanned in the counterclockwise direction with *0* corresponding to rightmost limit of the polar subplot.
        public static Box<IPolarProperty> sector(IEnumerable<int> values) => Interop.mkPolarAttr("sector", values.ToArray());
        /// Sets angular span of this polar subplot with two angles (in degrees). Sector are assumed to be spanned in the counterclockwise direction with *0* corresponding to rightmost limit of the polar subplot.
        public static Box<IPolarProperty> sector(float val) => Interop.mkPolarAttr("sector", new[]{val});
        /// Sets angular span of this polar subplot with two angles (in degrees). Sector are assumed to be spanned in the counterclockwise direction with *0* corresponding to rightmost limit of the polar subplot.
        public static Box<IPolarProperty> sector(IEnumerable<float> values) => Interop.mkPolarAttr("sector", values.ToArray());
        /// Sets the fraction of the radius to cut out of the polar subplot.
        public static Box<IPolarProperty> hole(int val) => Interop.mkPolarAttr("hole", val);
        /// Sets the fraction of the radius to cut out of the polar subplot.
        public static Box<IPolarProperty> hole(float val) => Interop.mkPolarAttr("hole", val);
        /// Set the background color of the subplot
        public static Box<IPolarProperty> bgcolor(string val) => Interop.mkPolarAttr("bgcolor", val);
        public static Box<IPolarProperty> radialaxis(params Box<IRadialaxisProperty>[] properties) => Interop.mkPolarAttr("radialaxis", Bindings.flattenProperties(properties));
        public static Box<IPolarProperty> angularaxis(params Box<IAngularaxisProperty>[] properties) => Interop.mkPolarAttr("angularaxis", Bindings.flattenProperties(properties));
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        public static Box<IPolarProperty> uirevision(bool val) => Interop.mkPolarAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        public static Box<IPolarProperty> uirevision(params bool[] values) => Interop.mkPolarAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        public static Box<IPolarProperty> uirevision(System.DateTime val) => Interop.mkPolarAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        public static Box<IPolarProperty> uirevision(params System.DateTime[] values) => Interop.mkPolarAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        public static Box<IPolarProperty> uirevision(int val) => Interop.mkPolarAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        public static Box<IPolarProperty> uirevision(params int[] values) => Interop.mkPolarAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        public static Box<IPolarProperty> uirevision(float val) => Interop.mkPolarAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        public static Box<IPolarProperty> uirevision(params float[] values) => Interop.mkPolarAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        public static Box<IPolarProperty> uirevision(string val) => Interop.mkPolarAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis attributes, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        public static Box<IPolarProperty> uirevision(params string[] values) => Interop.mkPolarAttr("uirevision", values);
        /// Sets the gap between bars of adjacent location coordinates. Values are unitless, they represent fractions of the minimum difference in bar positions in the data.
        public static Box<IPolarProperty> bargap(int val) => Interop.mkPolarAttr("bargap", val);
        /// Sets the gap between bars of adjacent location coordinates. Values are unitless, they represent fractions of the minimum difference in bar positions in the data.
        public static Box<IPolarProperty> bargap(float val) => Interop.mkPolarAttr("bargap", val);
    }

    public static partial class Polar
    {
        /// Determines if the radial axis grid lines and angular axis line are drawn as *circular* sectors or as *linear* (polygon) sectors. Has an effect only when the angular axis has `type` *category*. Note that `radialaxis.angle` is snapped to the angle of the closest vertex when `gridshape` is *circular* (so that radial axis scale is the same as the data scale).
        public static partial class Gridshape
        {
            public static Box<IPolarProperty> circular() => Interop.mkPolarAttr("gridshape", "circular");
            public static Box<IPolarProperty> linear() => Interop.mkPolarAttr("gridshape", "linear");
        }

        /// Determines how bars at the same location coordinate are displayed on the graph. With *stack*, the bars are stacked on top of one another With *overlay*, the bars are plotted over one another, you might need to an *opacity* to see multiple bars.
        public static partial class Barmode
        {
            public static Box<IPolarProperty> group() => Interop.mkPolarAttr("barmode", "group");
            public static Box<IPolarProperty> overlay() => Interop.mkPolarAttr("barmode", "overlay");
            public static Box<IPolarProperty> relative() => Interop.mkPolarAttr("barmode", "relative");
            public static Box<IPolarProperty> stack() => Interop.mkPolarAttr("barmode", "stack");
        }
    }
}