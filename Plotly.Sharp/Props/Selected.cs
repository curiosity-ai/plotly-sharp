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



    public static partial class Selected
    {
        public static Box<ISelectedProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkSelectedAttr("marker", Bindings.flattenProperties(properties));
        public static Box<ISelectedProperty> textfont(params Box<ITextfontProperty>[] properties) => Interop.mkSelectedAttr("textfont", Bindings.flattenProperties(properties));
    }
}