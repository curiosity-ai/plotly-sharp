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

    public static partial class Totals
    {
        public static Box<ITotalsProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkTotalsAttr("marker", Bindings.flattenProperties(properties));
    }
}