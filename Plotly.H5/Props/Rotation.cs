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

    public static partial class Rotation
    {
        /// Rotates the map along parallels (in degrees East). Defaults to the center of the `lonaxis.range` values.
        public static Box<IRotationProperty> lon(int val) => Interop.mkRotationAttr("lon", val);
        /// Rotates the map along parallels (in degrees East). Defaults to the center of the `lonaxis.range` values.
        public static Box<IRotationProperty> lon(float val) => Interop.mkRotationAttr("lon", val);
        /// Rotates the map along meridians (in degrees North).
        public static Box<IRotationProperty> lat(int val) => Interop.mkRotationAttr("lat", val);
        /// Rotates the map along meridians (in degrees North).
        public static Box<IRotationProperty> lat(float val) => Interop.mkRotationAttr("lat", val);
        /// Roll the map (in degrees) For example, a roll of *180* makes the map appear upside down.
        public static Box<IRotationProperty> roll(int val) => Interop.mkRotationAttr("roll", val);
        /// Roll the map (in degrees) For example, a roll of *180* makes the map appear upside down.
        public static Box<IRotationProperty> roll(float val) => Interop.mkRotationAttr("roll", val);
    }
}