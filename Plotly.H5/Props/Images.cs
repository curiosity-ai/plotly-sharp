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

    public static partial class Images
    {
        public static Box<IImagesProperty> image(params Box<IImageProperty>[] properties) => Interop.mkImagesAttr("image", Bindings.flattenProperties(properties));
    }
}