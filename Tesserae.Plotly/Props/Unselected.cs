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

    public static partial class Unselected
    {
        public static Box<IUnselectedProperty> marker(params Box<IMarkerProperty>[] properties) => Interop.mkUnselectedAttr("marker", Bindings.flattenProperties(properties));
        public static Box<IUnselectedProperty> textfont(params Box<ITextfontProperty>[] properties) => Interop.mkUnselectedAttr("textfont", Bindings.flattenProperties(properties));
    }
}