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
    using Bridge;
    using static Retyped.dom;

    public static partial class Tiling
    {
        /// When using *squarify* `packing` algorithm, according to https://github.com/d3/d3-hierarchy/blob/master/README.md#squarify_ratio this option specifies the desired aspect ratio of the generated rectangles. The ratio must be specified as a number greater than or equal to one. Note that the orientation of the generated rectangles (tall or wide) is not implied by the ratio; for example, a ratio of two will attempt to produce a mixture of rectangles whose width:height ratio is either 2:1 or 1:2. When using *squarify*, unlike d3 which uses the Golden Ratio i.e. 1.618034, Plotly applies 1 to increase squares in treemap layouts.
        public static Box<ITilingProperty> squarifyratio(int val) => Interop.mkTilingAttr("squarifyratio", val);
        /// When using *squarify* `packing` algorithm, according to https://github.com/d3/d3-hierarchy/blob/master/README.md#squarify_ratio this option specifies the desired aspect ratio of the generated rectangles. The ratio must be specified as a number greater than or equal to one. Note that the orientation of the generated rectangles (tall or wide) is not implied by the ratio; for example, a ratio of two will attempt to produce a mixture of rectangles whose width:height ratio is either 2:1 or 1:2. When using *squarify*, unlike d3 which uses the Golden Ratio i.e. 1.618034, Plotly applies 1 to increase squares in treemap layouts.
        public static Box<ITilingProperty> squarifyratio(float val) => Interop.mkTilingAttr("squarifyratio", val);
        /// Determines if the positions obtained from solver are flipped on each axis.
        public static Box<ITilingProperty> flip(params Box<ITilingProperty>[] properties) => Interop.mkTilingAttr("flip", Bindings.joinEnumProperties(properties));
        /// Sets the inner padding (in px).
        public static Box<ITilingProperty> pad(int val) => Interop.mkTilingAttr("pad", val);
        /// Sets the inner padding (in px).
        public static Box<ITilingProperty> pad(float val) => Interop.mkTilingAttr("pad", val);
    }

    public static partial class Tiling
    {
        /// Determines d3 treemap solver. For more info please refer to https://github.com/d3/d3-hierarchy#treemap-tiling
        public static partial class Packing
        {
            public static Box<ITilingProperty> binary() => Interop.mkTilingAttr("packing", "binary");
            public static Box<ITilingProperty> dice() => Interop.mkTilingAttr("packing", "dice");
            public static Box<ITilingProperty> diceSlice() => Interop.mkTilingAttr("packing", "dice-slice");
            public static Box<ITilingProperty> slice() => Interop.mkTilingAttr("packing", "slice");
            public static Box<ITilingProperty> sliceDice() => Interop.mkTilingAttr("packing", "slice-dice");
            public static Box<ITilingProperty> squarify() => Interop.mkTilingAttr("packing", "squarify");
        }

        /// Determines if the positions obtained from solver are flipped on each axis.
        public static partial class Flip
        {
            public static Box<ITilingProperty> x() => Interop.mkTilingAttr("flip", "x");
            public static Box<ITilingProperty> y() => Interop.mkTilingAttr("flip", "y");
        }
    }
}