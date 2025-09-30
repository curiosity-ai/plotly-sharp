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

    public static partial class Rangebreak
    {
        /// Determines whether this axis rangebreak is enabled or disabled. Please note that `rangebreaks` only work for *date* axis type.
        public static Box<IRangebreakProperty> enabled(bool val) => Interop.mkRangebreakAttr("enabled", val);
        /// Sets the lower and upper bounds of this axis rangebreak. Can be used with `pattern`.
        public static Box<IRangebreakProperty> bounds(bool val) => Interop.mkRangebreakAttr("bounds", new[] { val });
        /// Sets the lower and upper bounds of this axis rangebreak. Can be used with `pattern`.
        public static Box<IRangebreakProperty> bounds(IEnumerable<bool> values) => Interop.mkRangebreakAttr("bounds", values.ToArray());
        /// Sets the lower and upper bounds of this axis rangebreak. Can be used with `pattern`.
        public static Box<IRangebreakProperty> bounds(System.DateTime val) => Interop.mkRangebreakAttr("bounds", new[] { val });
        /// Sets the lower and upper bounds of this axis rangebreak. Can be used with `pattern`.
        public static Box<IRangebreakProperty> bounds(IEnumerable<System.DateTime> values) => Interop.mkRangebreakAttr("bounds", values.ToArray());
        /// Sets the lower and upper bounds of this axis rangebreak. Can be used with `pattern`.
        public static Box<IRangebreakProperty> bounds(float val) => Interop.mkRangebreakAttr("bounds", new[] { val });
        /// Sets the lower and upper bounds of this axis rangebreak. Can be used with `pattern`.
        public static Box<IRangebreakProperty> bounds(IEnumerable<float> values) => Interop.mkRangebreakAttr("bounds", values.ToArray());
        /// Sets the lower and upper bounds of this axis rangebreak. Can be used with `pattern`.
        public static Box<IRangebreakProperty> bounds(int val) => Interop.mkRangebreakAttr("bounds", new[] { val });
        /// Sets the lower and upper bounds of this axis rangebreak. Can be used with `pattern`.
        public static Box<IRangebreakProperty> bounds(IEnumerable<int> values) => Interop.mkRangebreakAttr("bounds", values.ToArray());
        /// Sets the lower and upper bounds of this axis rangebreak. Can be used with `pattern`.
        public static Box<IRangebreakProperty> bounds(string val) => Interop.mkRangebreakAttr("bounds", new[] { val });
        /// Sets the lower and upper bounds of this axis rangebreak. Can be used with `pattern`.
        public static Box<IRangebreakProperty> bounds(IEnumerable<string> values) => Interop.mkRangebreakAttr("bounds", values.ToArray());
        /// Sets the coordinate values corresponding to the rangebreaks. An alternative to `bounds`. Use `dvalue` to set the size of the values along the axis.
        public static Box<IRangebreakProperty> values(bool val) => Interop.mkRangebreakAttr("values", new[] { val });
        /// Sets the coordinate values corresponding to the rangebreaks. An alternative to `bounds`. Use `dvalue` to set the size of the values along the axis.
        public static Box<IRangebreakProperty> values(IEnumerable<bool> values) => Interop.mkRangebreakAttr("values", values.ToArray());
        /// Sets the coordinate values corresponding to the rangebreaks. An alternative to `bounds`. Use `dvalue` to set the size of the values along the axis.
        public static Box<IRangebreakProperty> values(System.DateTime val) => Interop.mkRangebreakAttr("values", new[] { val });
        /// Sets the coordinate values corresponding to the rangebreaks. An alternative to `bounds`. Use `dvalue` to set the size of the values along the axis.
        public static Box<IRangebreakProperty> values(IEnumerable<System.DateTime> values) => Interop.mkRangebreakAttr("values", values.ToArray());
        /// Sets the coordinate values corresponding to the rangebreaks. An alternative to `bounds`. Use `dvalue` to set the size of the values along the axis.
        public static Box<IRangebreakProperty> values(float val) => Interop.mkRangebreakAttr("values", new[] { val });
        /// Sets the coordinate values corresponding to the rangebreaks. An alternative to `bounds`. Use `dvalue` to set the size of the values along the axis.
        public static Box<IRangebreakProperty> values(IEnumerable<float> values) => Interop.mkRangebreakAttr("values", values.ToArray());
        /// Sets the coordinate values corresponding to the rangebreaks. An alternative to `bounds`. Use `dvalue` to set the size of the values along the axis.
        public static Box<IRangebreakProperty> values(int val) => Interop.mkRangebreakAttr("values", new[] { val });
        /// Sets the coordinate values corresponding to the rangebreaks. An alternative to `bounds`. Use `dvalue` to set the size of the values along the axis.
        public static Box<IRangebreakProperty> values(IEnumerable<int> values) => Interop.mkRangebreakAttr("values", values.ToArray());
        /// Sets the coordinate values corresponding to the rangebreaks. An alternative to `bounds`. Use `dvalue` to set the size of the values along the axis.
        public static Box<IRangebreakProperty> values(string val) => Interop.mkRangebreakAttr("values", new[] { val });
        /// Sets the coordinate values corresponding to the rangebreaks. An alternative to `bounds`. Use `dvalue` to set the size of the values along the axis.
        public static Box<IRangebreakProperty> values(IEnumerable<string> values) => Interop.mkRangebreakAttr("values", values.ToArray());
        /// Sets the size of each `values` item. The default is one day in milliseconds.
        public static Box<IRangebreakProperty> dvalue(int val) => Interop.mkRangebreakAttr("dvalue", val);
        /// Sets the size of each `values` item. The default is one day in milliseconds.
        public static Box<IRangebreakProperty> dvalue(float val) => Interop.mkRangebreakAttr("dvalue", val);
        /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
        public static Box<IRangebreakProperty> name(string val) => Interop.mkRangebreakAttr("name", val);
        /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
        public static Box<IRangebreakProperty> templateitemname(string val) => Interop.mkRangebreakAttr("templateitemname", val);
    }

    public static partial class Rangebreak
    {
        /// Determines a pattern on the time line that generates breaks. If *day of week* - days of the week in English e.g. 'Sunday' or `sun` (matching is case-insensitive and considers only the first three characters), as well as Sunday-based integers between 0 and 6. If *hour* - hour (24-hour clock) as decimal numbers between 0 and 24. for more info. Examples: - { pattern: 'day of week', bounds: [6, 1] }  or simply { bounds: ['sat', 'mon'] }   breaks from Saturday to Monday (i.e. skips the weekends). - { pattern: 'hour', bounds: [17, 8] }   breaks from 5pm to 8am (i.e. skips non-work hours).
        public static partial class Pattern
        {
            public static Box<IRangebreakProperty> none() => Interop.mkRangebreakAttr("pattern", "");
            public static Box<IRangebreakProperty> dayOfWeek() => Interop.mkRangebreakAttr("pattern", "day of week");
            public static Box<IRangebreakProperty> hour() => Interop.mkRangebreakAttr("pattern", "hour");
        }
    }
}