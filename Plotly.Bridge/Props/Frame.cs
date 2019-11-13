namespace PlotlyBridge
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

    public static partial class Frame
    {
        /// The duration in milliseconds of each frame. If greater than the frame duration, it will be limited to the frame duration.
        public static Box<IFrameProperty> duration(int val) => Interop.mkFrameAttr("duration", val);
        /// The duration in milliseconds of each frame. If greater than the frame duration, it will be limited to the frame duration.
        public static Box<IFrameProperty> duration(float val) => Interop.mkFrameAttr("duration", val);
        /// Redraw the plot at completion of the transition. This is desirable for transitions that include properties that cannot be transitioned, but may significantly slow down updates that do not require a full redraw of the plot
        public static Box<IFrameProperty> redraw(bool val) => Interop.mkFrameAttr("redraw", val);
    }
}