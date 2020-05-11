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

    public static partial class Ternary
    {
        public static Box<ITernaryProperty> domain(params Box<IDomainProperty>[] properties) => Interop.mkTernaryAttr("domain", Bindings.flattenProperties(properties));
        /// Set the background color of the subplot
        public static Box<ITernaryProperty> bgcolor(string val) => Interop.mkTernaryAttr("bgcolor", val);
        /// The number each triplet should sum to, and the maximum range of each axis
        public static Box<ITernaryProperty> sum(int val) => Interop.mkTernaryAttr("sum", val);
        /// The number each triplet should sum to, and the maximum range of each axis
        public static Box<ITernaryProperty> sum(float val) => Interop.mkTernaryAttr("sum", val);
        public static Box<ITernaryProperty> aaxis(params Box<IAaxisProperty>[] properties) => Interop.mkTernaryAttr("aaxis", Bindings.flattenProperties(properties));
        public static Box<ITernaryProperty> baxis(params Box<IBaxisProperty>[] properties) => Interop.mkTernaryAttr("baxis", Bindings.flattenProperties(properties));
        public static Box<ITernaryProperty> caxis(params Box<ICaxisProperty>[] properties) => Interop.mkTernaryAttr("caxis", Bindings.flattenProperties(properties));
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        public static Box<ITernaryProperty> uirevision(bool val) => Interop.mkTernaryAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        public static Box<ITernaryProperty> uirevision(params bool[] values) => Interop.mkTernaryAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        public static Box<ITernaryProperty> uirevision(System.DateTime val) => Interop.mkTernaryAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        public static Box<ITernaryProperty> uirevision(params System.DateTime[] values) => Interop.mkTernaryAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        public static Box<ITernaryProperty> uirevision(int val) => Interop.mkTernaryAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        public static Box<ITernaryProperty> uirevision(params int[] values) => Interop.mkTernaryAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        public static Box<ITernaryProperty> uirevision(float val) => Interop.mkTernaryAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        public static Box<ITernaryProperty> uirevision(params float[] values) => Interop.mkTernaryAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        public static Box<ITernaryProperty> uirevision(string val) => Interop.mkTernaryAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `min` and `title`, if not overridden in the individual axes. Defaults to `layout.uirevision`.
        public static Box<ITernaryProperty> uirevision(params string[] values) => Interop.mkTernaryAttr("uirevision", values);
    }
}