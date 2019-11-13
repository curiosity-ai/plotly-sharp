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

    public static partial class Animation
    {
        /// Play frames starting at the current frame instead of the beginning.
        public static Box<IAnimationProperty> fromcurrent(bool val) => Interop.mkAnimationAttr("fromcurrent", val);
        public static Box<IAnimationProperty> frame(params Box<IFrameProperty>[] properties) => Interop.mkAnimationAttr("frame", Bindings.flattenProperties(properties));
        public static Box<IAnimationProperty> transition(params Box<ITransitionProperty>[] properties) => Interop.mkAnimationAttr("transition", Bindings.flattenProperties(properties));
    }

    public static partial class Animation
    {
        /// Describes how a new animate call interacts with currently-running animations. If `immediate`, current animations are interrupted and the new animation is started. If `next`, the current frame is allowed to complete, after which the new animation is started. If `afterall` all existing frames are animated to completion before the new animation is started.
        public static partial class Mode
        {
            public static Box<IAnimationProperty> afterall() => Interop.mkAnimationAttr("mode", "afterall");
            public static Box<IAnimationProperty> immediate() => Interop.mkAnimationAttr("mode", "immediate");
            public static Box<IAnimationProperty> next() => Interop.mkAnimationAttr("mode", "next");
        }

        /// The direction in which to play the frames triggered by the animation call
        public static partial class Direction
        {
            public static Box<IAnimationProperty> forward() => Interop.mkAnimationAttr("direction", "forward");
            public static Box<IAnimationProperty> reverse() => Interop.mkAnimationAttr("direction", "reverse");
        }
    }
}