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

    public static partial class Stream
    {
        /// The stream id number links a data trace on a plot with a stream. See https://plot.ly/settings for more details.
        public static Box<IStreamProperty> token(string val) => Interop.mkStreamAttr("token", val);
        /// Sets the maximum number of points to keep on the plots from an incoming stream. If `maxpoints` is set to *50*, only the newest 50 points will be displayed on the plot.
        public static Box<IStreamProperty> maxpoints(int val) => Interop.mkStreamAttr("maxpoints", val);
        /// Sets the maximum number of points to keep on the plots from an incoming stream. If `maxpoints` is set to *50*, only the newest 50 points will be displayed on the plot.
        public static Box<IStreamProperty> maxpoints(float val) => Interop.mkStreamAttr("maxpoints", val);
    }
}