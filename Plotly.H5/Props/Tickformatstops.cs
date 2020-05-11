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

    public static partial class Tickformatstops
    {
        public static Box<ITickformatstopsProperty> tickformatstop(params Box<ITickformatstopProperty>[] properties) => Interop.mkTickformatstopsAttr("tickformatstop", Bindings.flattenProperties(properties));
    }
}