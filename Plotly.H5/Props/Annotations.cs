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
    using static H5.Core.dom;

    public static partial class Annotations
    {
        public static Box<IAnnotationsProperty> annotation(params Box<IAnnotationProperty>[] properties) => Interop.mkAnnotationsAttr("annotation", Bindings.flattenProperties(properties));
    }
}