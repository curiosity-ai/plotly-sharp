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

    public static partial class Colorscales
    {
        public static Box<IColorscalesProperty> concentrationscales(params Box<IConcentrationscalesProperty>[] properties) => Interop.mkColorscalesAttr("concentrationscales", Bindings.flattenProperties(properties));
    }
}