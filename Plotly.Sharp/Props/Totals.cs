namespace Plotly
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

    public static partial class Totals
    {
        public static Box<ITotalsProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkTotalsAttr("marker", Bindings.flattenProperties(properties));
    }
}