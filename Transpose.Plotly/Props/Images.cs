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

    public static partial class Images
    {
        public static Box<IImagesProperty> image(params Box<IImageProperty>[] properties) => Interop.mkImagesAttr("image", Bindings.flattenProperties(properties));
    }
}