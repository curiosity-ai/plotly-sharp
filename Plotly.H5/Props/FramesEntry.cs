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
    using static Retyped.dom;

    public static partial class FramesEntry
    {
        /// An identifier that specifies the group to which the frame belongs, used by animate to select a subset of frames.
        public static Box<IFramesEntryProperty> group(string val) => Interop.mkFramesEntryAttr("group", val);
        /// A label by which to identify the frame
        public static Box<IFramesEntryProperty> name(string val) => Interop.mkFramesEntryAttr("name", val);
        /// The name of the frame into which this frame's properties are merged before applying. This is used to unify properties and avoid needing to specify the same values for the same properties in multiple frames.
        public static Box<IFramesEntryProperty> baseframe(string val) => Interop.mkFramesEntryAttr("baseframe", val);
        /// A list of traces this frame modifies. The format is identical to the normal trace definition.
        public static Box<IFramesEntryProperty> data(bool val) => Interop.mkFramesEntryAttr("data", val);
        /// A list of traces this frame modifies. The format is identical to the normal trace definition.
        public static Box<IFramesEntryProperty> data(params bool[] values) => Interop.mkFramesEntryAttr("data", values);
        /// A list of traces this frame modifies. The format is identical to the normal trace definition.
        public static Box<IFramesEntryProperty> data(System.DateTime val) => Interop.mkFramesEntryAttr("data", val);
        /// A list of traces this frame modifies. The format is identical to the normal trace definition.
        public static Box<IFramesEntryProperty> data(params System.DateTime[] values) => Interop.mkFramesEntryAttr("data", values);
        /// A list of traces this frame modifies. The format is identical to the normal trace definition.
        public static Box<IFramesEntryProperty> data(int val) => Interop.mkFramesEntryAttr("data", val);
        /// A list of traces this frame modifies. The format is identical to the normal trace definition.
        public static Box<IFramesEntryProperty> data(params int[] values) => Interop.mkFramesEntryAttr("data", values);
        /// A list of traces this frame modifies. The format is identical to the normal trace definition.
        public static Box<IFramesEntryProperty> data(float val) => Interop.mkFramesEntryAttr("data", val);
        /// A list of traces this frame modifies. The format is identical to the normal trace definition.
        public static Box<IFramesEntryProperty> data(params float[] values) => Interop.mkFramesEntryAttr("data", values);
        /// A list of traces this frame modifies. The format is identical to the normal trace definition.
        public static Box<IFramesEntryProperty> data(string val) => Interop.mkFramesEntryAttr("data", val);
        /// A list of traces this frame modifies. The format is identical to the normal trace definition.
        public static Box<IFramesEntryProperty> data(params string[] values) => Interop.mkFramesEntryAttr("data", values);
        /// Layout properties which this frame modifies. The format is identical to the normal layout definition.
        public static Box<IFramesEntryProperty> layout(bool val) => Interop.mkFramesEntryAttr("layout", val);
        /// Layout properties which this frame modifies. The format is identical to the normal layout definition.
        public static Box<IFramesEntryProperty> layout(params bool[] values) => Interop.mkFramesEntryAttr("layout", values);
        /// Layout properties which this frame modifies. The format is identical to the normal layout definition.
        public static Box<IFramesEntryProperty> layout(System.DateTime val) => Interop.mkFramesEntryAttr("layout", val);
        /// Layout properties which this frame modifies. The format is identical to the normal layout definition.
        public static Box<IFramesEntryProperty> layout(params System.DateTime[] values) => Interop.mkFramesEntryAttr("layout", values);
        /// Layout properties which this frame modifies. The format is identical to the normal layout definition.
        public static Box<IFramesEntryProperty> layout(int val) => Interop.mkFramesEntryAttr("layout", val);
        /// Layout properties which this frame modifies. The format is identical to the normal layout definition.
        public static Box<IFramesEntryProperty> layout(params int[] values) => Interop.mkFramesEntryAttr("layout", values);
        /// Layout properties which this frame modifies. The format is identical to the normal layout definition.
        public static Box<IFramesEntryProperty> layout(float val) => Interop.mkFramesEntryAttr("layout", val);
        /// Layout properties which this frame modifies. The format is identical to the normal layout definition.
        public static Box<IFramesEntryProperty> layout(params float[] values) => Interop.mkFramesEntryAttr("layout", values);
        /// Layout properties which this frame modifies. The format is identical to the normal layout definition.
        public static Box<IFramesEntryProperty> layout(string val) => Interop.mkFramesEntryAttr("layout", val);
        /// Layout properties which this frame modifies. The format is identical to the normal layout definition.
        public static Box<IFramesEntryProperty> layout(params string[] values) => Interop.mkFramesEntryAttr("layout", values);
    }
}