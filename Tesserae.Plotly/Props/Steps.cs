namespace Tesserae.Plotly
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

    public static partial class Steps
    {
        public static Box<IStepsProperty> step(params Box<IStepProperty>[] properties) => Interop.mkStepsAttr("step", Bindings.flattenProperties(properties));
    }
}