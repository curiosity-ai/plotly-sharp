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

    public static partial class Tickformatstop
    {
        /// Determines whether or not this stop is used. If `false`, this stop is ignored even within its `dtickrange`.
        public static Box<ITickformatstopProperty> enabled(bool val) => Interop.mkTickformatstopAttr("enabled", val);
        /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
        public static Box<ITickformatstopProperty> dtickrange(bool val) => Interop.mkTickformatstopAttr("dtickrange", new[]{val});
        /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
        public static Box<ITickformatstopProperty> dtickrange(IEnumerable<bool> values) => Interop.mkTickformatstopAttr("dtickrange", values.ToArray());
        /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
        public static Box<ITickformatstopProperty> dtickrange(System.DateTime val) => Interop.mkTickformatstopAttr("dtickrange", new[]{val});
        /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
        public static Box<ITickformatstopProperty> dtickrange(IEnumerable<System.DateTime> values) => Interop.mkTickformatstopAttr("dtickrange", values.ToArray());
        /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
        public static Box<ITickformatstopProperty> dtickrange(float val) => Interop.mkTickformatstopAttr("dtickrange", new[]{val});
        /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
        public static Box<ITickformatstopProperty> dtickrange(IEnumerable<float> values) => Interop.mkTickformatstopAttr("dtickrange", values.ToArray());
        /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
        public static Box<ITickformatstopProperty> dtickrange(int val) => Interop.mkTickformatstopAttr("dtickrange", new[]{val});
        /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
        public static Box<ITickformatstopProperty> dtickrange(IEnumerable<int> values) => Interop.mkTickformatstopAttr("dtickrange", values.ToArray());
        /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
        public static Box<ITickformatstopProperty> dtickrange(string val) => Interop.mkTickformatstopAttr("dtickrange", new[]{val});
        /// range [*min*, *max*], where *min*, *max* - dtick values which describe some zoom level, it is possible to omit *min* or *max* value by passing *null*
        public static Box<ITickformatstopProperty> dtickrange(IEnumerable<string> values) => Interop.mkTickformatstopAttr("dtickrange", values.ToArray());
        /// string - dtickformat for described zoom level, the same as *tickformat*
        public static Box<ITickformatstopProperty> value(string val) => Interop.mkTickformatstopAttr("value", val);
        /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
        public static Box<ITickformatstopProperty> name(string val) => Interop.mkTickformatstopAttr("name", val);
        /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
        public static Box<ITickformatstopProperty> templateitemname(string val) => Interop.mkTickformatstopAttr("templateitemname", val);
    }
}