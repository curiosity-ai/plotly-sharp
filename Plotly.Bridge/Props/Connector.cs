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

    public static partial class Connector
    {
        /// Sets the fill color.
        public static Box<IConnectorProperty> fillcolor(string val) => Interop.mkConnectorAttr("fillcolor", val);
        public static Box<IConnectorProperty> line(params Box<ILineProperty>[] properties) => Interop.mkConnectorAttr("line", Bindings.flattenProperties(properties));
        /// Determines if connector regions and lines are drawn.
        public static Box<IConnectorProperty> visible(bool val) => Interop.mkConnectorAttr("visible", val);
    }

    public static partial class Connector
    {
        /// Sets the shape of connector lines.
        public static partial class Mode
        {
            public static Box<IConnectorProperty> between() => Interop.mkConnectorAttr("mode", "between");
            public static Box<IConnectorProperty> spanning() => Interop.mkConnectorAttr("mode", "spanning");
        }
    }
}