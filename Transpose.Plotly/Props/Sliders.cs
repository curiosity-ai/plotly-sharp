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

    public static partial class Sliders
    {
        public static Box<ISlidersProperty> slider(params Box<ISliderProperty>[] properties) => Interop.mkSlidersAttr("slider", Bindings.flattenProperties(properties));
    }
}