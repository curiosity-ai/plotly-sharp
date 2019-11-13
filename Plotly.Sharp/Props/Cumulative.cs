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

    public static partial class Cumulative
    {
        /// If true, display the cumulative distribution by summing the binned values. Use the `direction` and `centralbin` attributes to tune the accumulation method. Note: in this mode, the *density* `histnorm` settings behave the same as their equivalents without *density*: ** and *density* both rise to the number of data points, and *probability* and *probability density* both rise to the number of sample points.
        public static Box<ICumulativeProperty> enabled(bool val) => Interop.mkCumulativeAttr("enabled", val);
    }

    public static partial class Cumulative
    {
        /// Only applies if cumulative is enabled. If *increasing* (default) we sum all prior bins, so the result increases from left to right. If *decreasing* we sum later bins so the result decreases from left to right.
        public static partial class Direction
        {
            public static Box<ICumulativeProperty> decreasing() => Interop.mkCumulativeAttr("direction", "decreasing");
            public static Box<ICumulativeProperty> increasing() => Interop.mkCumulativeAttr("direction", "increasing");
        }

        /// Only applies if cumulative is enabled. Sets whether the current bin is included, excluded, or has half of its value included in the current cumulative value. *include* is the default for compatibility with various other tools, however it introduces a half-bin bias to the results. *exclude* makes the opposite half-bin bias, and *half* removes it.
        public static partial class Currentbin
        {
            public static Box<ICumulativeProperty> exclude() => Interop.mkCumulativeAttr("currentbin", "exclude");
            public static Box<ICumulativeProperty> half() => Interop.mkCumulativeAttr("currentbin", "half");
            public static Box<ICumulativeProperty> _include() => Interop.mkCumulativeAttr("currentbin", "include");
        }
    }
}