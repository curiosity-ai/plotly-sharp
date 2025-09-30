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
    using H5;
    using static H5.Core.dom;

    public static partial class Rangebreaks
    {
        public static Box<IRangebreaksProperty> rangebreak(params Box<IRangebreakProperty>[] properties) => Interop.mkRangebreaksAttr("rangebreak", Bindings.flattenProperties(properties));
    }
}