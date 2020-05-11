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

    public static partial class Frames
    {
        public static Box<IFramesProperty> framesEntry(params Box<IFramesEntryProperty>[] properties) => Interop.mkFramesAttr("frames_entry", Bindings.flattenProperties(properties));
    }
}