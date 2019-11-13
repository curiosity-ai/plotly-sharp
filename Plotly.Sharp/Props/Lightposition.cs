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

    public static partial class Lightposition
    {
        /// Numeric vector, representing the X coordinate for each vertex.
        public static Box<ILightpositionProperty> x(int val) => Interop.mkLightpositionAttr("x", val);
        /// Numeric vector, representing the X coordinate for each vertex.
        public static Box<ILightpositionProperty> x(float val) => Interop.mkLightpositionAttr("x", val);
        /// Numeric vector, representing the Y coordinate for each vertex.
        public static Box<ILightpositionProperty> y(int val) => Interop.mkLightpositionAttr("y", val);
        /// Numeric vector, representing the Y coordinate for each vertex.
        public static Box<ILightpositionProperty> y(float val) => Interop.mkLightpositionAttr("y", val);
        /// Numeric vector, representing the Z coordinate for each vertex.
        public static Box<ILightpositionProperty> z(int val) => Interop.mkLightpositionAttr("z", val);
        /// Numeric vector, representing the Z coordinate for each vertex.
        public static Box<ILightpositionProperty> z(float val) => Interop.mkLightpositionAttr("z", val);
    }
}