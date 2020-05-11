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

    public static partial class Buttons
    {
        /// Sets the specifications for each buttons. By default, a range selector comes with no buttons.
        public static Box<IButtonsProperty> button(params Box<IButtonProperty>[] properties) => Interop.mkButtonsAttr("button", Bindings.flattenProperties(properties));
    }
}