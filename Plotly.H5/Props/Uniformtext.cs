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

    public static partial class Uniformtext
    {
        /// Sets the minimum text size between traces of the same type.
        public static Box<IUniformtextProperty> minsize(int val) => Interop.mkUniformtextAttr("minsize", val);
        /// Sets the minimum text size between traces of the same type.
        public static Box<IUniformtextProperty> minsize(float val) => Interop.mkUniformtextAttr("minsize", val);
    }

    public static partial class Uniformtext
    {
        /// Determines how the font size for various text elements are uniformed between each trace type. If the computed text sizes were smaller than the minimum size defined by `uniformtext.minsize` using *hide* option hides the text; and using *show* option shows the text without further downscaling. Please note that if the size defined by `minsize` is greater than the font size defined by trace, then the `minsize` is used.
        public static partial class Mode
        {
            public static Box<IUniformtextProperty> hide() => Interop.mkUniformtextAttr("mode", "hide");
            public static Box<IUniformtextProperty> show() => Interop.mkUniformtextAttr("mode", "show");
            public static Box<IUniformtextProperty> _false() => Interop.mkUniformtextAttr("mode", false);
        }
    }
}