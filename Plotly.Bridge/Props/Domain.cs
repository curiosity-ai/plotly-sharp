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

    public static partial class Domain
    {
        /// Sets the horizontal domain of this pie trace (in plot fraction).
        public static Box<IDomainProperty> x(int val) => Interop.mkDomainAttr("x", new[]{val});
        /// Sets the horizontal domain of this pie trace (in plot fraction).
        public static Box<IDomainProperty> x(IEnumerable<int> values) => Interop.mkDomainAttr("x", values.ToArray());
        /// Sets the horizontal domain of this pie trace (in plot fraction).
        public static Box<IDomainProperty> x(float val) => Interop.mkDomainAttr("x", new[]{val});
        /// Sets the horizontal domain of this pie trace (in plot fraction).
        public static Box<IDomainProperty> x(IEnumerable<float> values) => Interop.mkDomainAttr("x", values.ToArray());
        /// Sets the vertical domain of this pie trace (in plot fraction).
        public static Box<IDomainProperty> y(int val) => Interop.mkDomainAttr("y", new[]{val});
        /// Sets the vertical domain of this pie trace (in plot fraction).
        public static Box<IDomainProperty> y(IEnumerable<int> values) => Interop.mkDomainAttr("y", values.ToArray());
        /// Sets the vertical domain of this pie trace (in plot fraction).
        public static Box<IDomainProperty> y(float val) => Interop.mkDomainAttr("y", new[]{val});
        /// Sets the vertical domain of this pie trace (in plot fraction).
        public static Box<IDomainProperty> y(IEnumerable<float> values) => Interop.mkDomainAttr("y", values.ToArray());
        /// If there is a layout grid, use the domain for this row in the grid for this pie trace .
        public static Box<IDomainProperty> row(int val) => Interop.mkDomainAttr("row", val);
        /// If there is a layout grid, use the domain for this column in the grid for this pie trace .
        public static Box<IDomainProperty> column(int val) => Interop.mkDomainAttr("column", val);
    }
}