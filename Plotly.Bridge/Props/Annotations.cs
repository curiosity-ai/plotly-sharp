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

    public static partial class Annotations
    {
        public static Box<IAnnotationsProperty> annotation(params Box<IAnnotationProperty>[] properties) => Interop.mkAnnotationsAttr("annotation", Bindings.flattenProperties(properties));
    }
}