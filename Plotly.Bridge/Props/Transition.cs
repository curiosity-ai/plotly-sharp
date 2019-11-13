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

    public static partial class Transition
    {
        /// The duration of the transition, in milliseconds. If equal to zero, updates are synchronous.
        public static Box<ITransitionProperty> duration(int val) => Interop.mkTransitionAttr("duration", val);
        /// The duration of the transition, in milliseconds. If equal to zero, updates are synchronous.
        public static Box<ITransitionProperty> duration(float val) => Interop.mkTransitionAttr("duration", val);
    }

    public static partial class Transition
    {
        /// The easing function used for the transition
        public static partial class Easing
        {
            public static Box<ITransitionProperty> back() => Interop.mkTransitionAttr("easing", "back");
            public static Box<ITransitionProperty> backIn() => Interop.mkTransitionAttr("easing", "back-in");
            public static Box<ITransitionProperty> backInOut() => Interop.mkTransitionAttr("easing", "back-in-out");
            public static Box<ITransitionProperty> backOut() => Interop.mkTransitionAttr("easing", "back-out");
            public static Box<ITransitionProperty> bounce() => Interop.mkTransitionAttr("easing", "bounce");
            public static Box<ITransitionProperty> bounceIn() => Interop.mkTransitionAttr("easing", "bounce-in");
            public static Box<ITransitionProperty> bounceInOut() => Interop.mkTransitionAttr("easing", "bounce-in-out");
            public static Box<ITransitionProperty> bounceOut() => Interop.mkTransitionAttr("easing", "bounce-out");
            public static Box<ITransitionProperty> circle() => Interop.mkTransitionAttr("easing", "circle");
            public static Box<ITransitionProperty> circleIn() => Interop.mkTransitionAttr("easing", "circle-in");
            public static Box<ITransitionProperty> circleInOut() => Interop.mkTransitionAttr("easing", "circle-in-out");
            public static Box<ITransitionProperty> circleOut() => Interop.mkTransitionAttr("easing", "circle-out");
            public static Box<ITransitionProperty> cubic() => Interop.mkTransitionAttr("easing", "cubic");
            public static Box<ITransitionProperty> cubicIn() => Interop.mkTransitionAttr("easing", "cubic-in");
            public static Box<ITransitionProperty> cubicInOut() => Interop.mkTransitionAttr("easing", "cubic-in-out");
            public static Box<ITransitionProperty> cubicOut() => Interop.mkTransitionAttr("easing", "cubic-out");
            public static Box<ITransitionProperty> elastic() => Interop.mkTransitionAttr("easing", "elastic");
            public static Box<ITransitionProperty> elasticIn() => Interop.mkTransitionAttr("easing", "elastic-in");
            public static Box<ITransitionProperty> elasticInOut() => Interop.mkTransitionAttr("easing", "elastic-in-out");
            public static Box<ITransitionProperty> elasticOut() => Interop.mkTransitionAttr("easing", "elastic-out");
            public static Box<ITransitionProperty> exp() => Interop.mkTransitionAttr("easing", "exp");
            public static Box<ITransitionProperty> expIn() => Interop.mkTransitionAttr("easing", "exp-in");
            public static Box<ITransitionProperty> expInOut() => Interop.mkTransitionAttr("easing", "exp-in-out");
            public static Box<ITransitionProperty> expOut() => Interop.mkTransitionAttr("easing", "exp-out");
            public static Box<ITransitionProperty> linear() => Interop.mkTransitionAttr("easing", "linear");
            public static Box<ITransitionProperty> linearIn() => Interop.mkTransitionAttr("easing", "linear-in");
            public static Box<ITransitionProperty> linearInOut() => Interop.mkTransitionAttr("easing", "linear-in-out");
            public static Box<ITransitionProperty> linearOut() => Interop.mkTransitionAttr("easing", "linear-out");
            public static Box<ITransitionProperty> quad() => Interop.mkTransitionAttr("easing", "quad");
            public static Box<ITransitionProperty> quadIn() => Interop.mkTransitionAttr("easing", "quad-in");
            public static Box<ITransitionProperty> quadInOut() => Interop.mkTransitionAttr("easing", "quad-in-out");
            public static Box<ITransitionProperty> quadOut() => Interop.mkTransitionAttr("easing", "quad-out");
            public static Box<ITransitionProperty> sin() => Interop.mkTransitionAttr("easing", "sin");
            public static Box<ITransitionProperty> sinIn() => Interop.mkTransitionAttr("easing", "sin-in");
            public static Box<ITransitionProperty> sinInOut() => Interop.mkTransitionAttr("easing", "sin-in-out");
            public static Box<ITransitionProperty> sinOut() => Interop.mkTransitionAttr("easing", "sin-out");
        }

        /// Determines whether the figure's layout or traces smoothly transitions during updates that make both traces and layout change.
        public static partial class Ordering
        {
            public static Box<ITransitionProperty> layoutFirst() => Interop.mkTransitionAttr("ordering", "layout first");
            public static Box<ITransitionProperty> tracesFirst() => Interop.mkTransitionAttr("ordering", "traces first");
        }
    }
}