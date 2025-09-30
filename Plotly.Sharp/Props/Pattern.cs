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
    using H5;
    using static H5.Core.dom;

    public static partial class Pattern
    {
        /// Sets the shape of the pattern fill. By default, no pattern is used for filling the area.
        public static Box<IPatternProperty> shape(IEnumerable<Box<IPatternProperty>> properties) => Interop.mkPatternAttr("shape", Bindings.flattenProperties(properties));
        /// When there is no colorscale sets the color of background pattern fill. Defaults to a `marker.color` background when `fillmode` is *overlay*. Otherwise, defaults to a transparent background.
        public static Box<IPatternProperty> bgcolor(string val) => Interop.mkPatternAttr("bgcolor", val);
        /// When there is no colorscale sets the color of background pattern fill. Defaults to a `marker.color` background when `fillmode` is *overlay*. Otherwise, defaults to a transparent background.
        public static Box<IPatternProperty> bgcolor(IEnumerable<string> values) => Interop.mkPatternAttr("bgcolor", values.ToArray());
        /// When there is no colorscale sets the color of background pattern fill. Defaults to a `marker.color` background when `fillmode` is *overlay*. Otherwise, defaults to a transparent background.
        public static Box<IPatternProperty> bgcolor(params int[] values) => Interop.mkPatternAttr("bgcolor", values);
        /// When there is no colorscale sets the color of background pattern fill. Defaults to a `marker.color` background when `fillmode` is *overlay*. Otherwise, defaults to a transparent background.
        public static Box<IPatternProperty> bgcolor(params float[] values) => Interop.mkPatternAttr("bgcolor", values);
        /// When there is no colorscale sets the color of foreground pattern fill. Defaults to a `marker.color` background when `fillmode` is *replace*. Otherwise, defaults to dark grey or white to increase contrast with the `bgcolor`.
        public static Box<IPatternProperty> fgcolor(string val) => Interop.mkPatternAttr("fgcolor", val);
        /// When there is no colorscale sets the color of foreground pattern fill. Defaults to a `marker.color` background when `fillmode` is *replace*. Otherwise, defaults to dark grey or white to increase contrast with the `bgcolor`.
        public static Box<IPatternProperty> fgcolor(IEnumerable<string> values) => Interop.mkPatternAttr("fgcolor", values.ToArray());
        /// When there is no colorscale sets the color of foreground pattern fill. Defaults to a `marker.color` background when `fillmode` is *replace*. Otherwise, defaults to dark grey or white to increase contrast with the `bgcolor`.
        public static Box<IPatternProperty> fgcolor(params int[] values) => Interop.mkPatternAttr("fgcolor", values);
        /// When there is no colorscale sets the color of foreground pattern fill. Defaults to a `marker.color` background when `fillmode` is *replace*. Otherwise, defaults to dark grey or white to increase contrast with the `bgcolor`.
        public static Box<IPatternProperty> fgcolor(params float[] values) => Interop.mkPatternAttr("fgcolor", values);
        /// Sets the opacity of the foreground pattern fill. Defaults to a 0.5 when `fillmode` is *overlay*. Otherwise, defaults to 1.
        public static Box<IPatternProperty> fgopacity(int val) => Interop.mkPatternAttr("fgopacity", val);
        /// Sets the opacity of the foreground pattern fill. Defaults to a 0.5 when `fillmode` is *overlay*. Otherwise, defaults to 1.
        public static Box<IPatternProperty> fgopacity(float val) => Interop.mkPatternAttr("fgopacity", val);
        /// Sets the size of unit squares of the pattern fill in pixels, which corresponds to the interval of repetition of the pattern.
        public static Box<IPatternProperty> size(int val) => Interop.mkPatternAttr("size", val);
        /// Sets the size of unit squares of the pattern fill in pixels, which corresponds to the interval of repetition of the pattern.
        public static Box<IPatternProperty> size(float val) => Interop.mkPatternAttr("size", val);
        /// Sets the size of unit squares of the pattern fill in pixels, which corresponds to the interval of repetition of the pattern.
        public static Box<IPatternProperty> size(IEnumerable<int> values) => Interop.mkPatternAttr("size", values.ToArray());
        /// Sets the size of unit squares of the pattern fill in pixels, which corresponds to the interval of repetition of the pattern.
        public static Box<IPatternProperty> size(IEnumerable<float> values) => Interop.mkPatternAttr("size", values.ToArray());
        /// Sets the solidity of the pattern fill. Solidity is roughly the fraction of the area filled by the pattern. Solidity of 0 shows only the background color without pattern and solidty of 1 shows only the foreground color without pattern.
        public static Box<IPatternProperty> solidity(int val) => Interop.mkPatternAttr("solidity", val);
        /// Sets the solidity of the pattern fill. Solidity is roughly the fraction of the area filled by the pattern. Solidity of 0 shows only the background color without pattern and solidty of 1 shows only the foreground color without pattern.
        public static Box<IPatternProperty> solidity(float val) => Interop.mkPatternAttr("solidity", val);
        /// Sets the solidity of the pattern fill. Solidity is roughly the fraction of the area filled by the pattern. Solidity of 0 shows only the background color without pattern and solidty of 1 shows only the foreground color without pattern.
        public static Box<IPatternProperty> solidity(IEnumerable<int> values) => Interop.mkPatternAttr("solidity", values.ToArray());
        /// Sets the solidity of the pattern fill. Solidity is roughly the fraction of the area filled by the pattern. Solidity of 0 shows only the background color without pattern and solidty of 1 shows only the foreground color without pattern.
        public static Box<IPatternProperty> solidity(IEnumerable<float> values) => Interop.mkPatternAttr("solidity", values.ToArray());
        /// Sets the source reference on Chart Studio Cloud for  shape .
        public static Box<IPatternProperty> shapesrc(string val) => Interop.mkPatternAttr("shapesrc", val);
        /// Sets the source reference on Chart Studio Cloud for  bgcolor .
        public static Box<IPatternProperty> bgcolorsrc(string val) => Interop.mkPatternAttr("bgcolorsrc", val);
        /// Sets the source reference on Chart Studio Cloud for  fgcolor .
        public static Box<IPatternProperty> fgcolorsrc(string val) => Interop.mkPatternAttr("fgcolorsrc", val);
        /// Sets the source reference on Chart Studio Cloud for  size .
        public static Box<IPatternProperty> sizesrc(string val) => Interop.mkPatternAttr("sizesrc", val);
        /// Sets the source reference on Chart Studio Cloud for  solidity .
        public static Box<IPatternProperty> soliditysrc(string val) => Interop.mkPatternAttr("soliditysrc", val);
    }

    public static partial class Pattern
    {
        /// Sets the shape of the pattern fill. By default, no pattern is used for filling the area.
        public static partial class Shape
        {
            public static Box<IPatternProperty> none() => Interop.mkPatternAttr("shape", "");
            public static Box<IPatternProperty> empty() => Interop.mkPatternAttr("shape", "+");
            public static Box<IPatternProperty> dash() => Interop.mkPatternAttr("shape", "-");
            public static Box<IPatternProperty> dot() => Interop.mkPatternAttr("shape", ".");
            public static Box<IPatternProperty> ldivide() => Interop.mkPatternAttr("shape", "/");
            public static Box<IPatternProperty> \ \ () =>  Interop.mkPatternAttr( "shape" ,  "\\" ) ; public static Box<IPatternProperty> x() => Interop.mkPatternAttr("shape", "x");
            public static Box<IPatternProperty> pipe() => Interop.mkPatternAttr("shape", "|");
        }

        /// Determines whether `marker.color` should be used as a default to `bgcolor` or a `fgcolor`.
        public static partial class Fillmode
        {
            public static Box<IPatternProperty> overlay() => Interop.mkPatternAttr("fillmode", "overlay");
            public static Box<IPatternProperty> replace() => Interop.mkPatternAttr("fillmode", "replace");
        }
    }
}