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

    public static partial class Rangeslider
    {
        /// Sets the background color of the range slider.
        public static Box<IRangesliderProperty> bgcolor(string val) => Interop.mkRangesliderAttr("bgcolor", val);
        /// Sets the border color of the range slider.
        public static Box<IRangesliderProperty> bordercolor(string val) => Interop.mkRangesliderAttr("bordercolor", val);
        /// Sets the border width of the range slider.
        public static Box<IRangesliderProperty> borderwidth(int val) => Interop.mkRangesliderAttr("borderwidth", val);
        /// Determines whether or not the range slider range is computed in relation to the input data. If `range` is provided, then `autorange` is set to *false*.
        public static Box<IRangesliderProperty> autorange(bool val) => Interop.mkRangesliderAttr("autorange", val);
        /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRangesliderProperty> range(bool val) => Interop.mkRangesliderAttr("range", new[]{val});
        /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRangesliderProperty> range(IEnumerable<bool> values) => Interop.mkRangesliderAttr("range", values.ToArray());
        /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRangesliderProperty> range(System.DateTime val) => Interop.mkRangesliderAttr("range", new[]{val});
        /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRangesliderProperty> range(IEnumerable<System.DateTime> values) => Interop.mkRangesliderAttr("range", values.ToArray());
        /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRangesliderProperty> range(float val) => Interop.mkRangesliderAttr("range", new[]{val});
        /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRangesliderProperty> range(IEnumerable<float> values) => Interop.mkRangesliderAttr("range", values.ToArray());
        /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRangesliderProperty> range(int val) => Interop.mkRangesliderAttr("range", new[]{val});
        /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRangesliderProperty> range(IEnumerable<int> values) => Interop.mkRangesliderAttr("range", values.ToArray());
        /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRangesliderProperty> range(string val) => Interop.mkRangesliderAttr("range", new[]{val});
        /// Sets the range of the range slider. If not set, defaults to the full xaxis range. If the axis `type` is *log*, then you must take the log of your desired range. If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRangesliderProperty> range(IEnumerable<string> values) => Interop.mkRangesliderAttr("range", values.ToArray());
        /// The height of the range slider as a fraction of the total plot area height.
        public static Box<IRangesliderProperty> thickness(int val) => Interop.mkRangesliderAttr("thickness", val);
        /// The height of the range slider as a fraction of the total plot area height.
        public static Box<IRangesliderProperty> thickness(float val) => Interop.mkRangesliderAttr("thickness", val);
        /// Determines whether or not the range slider will be visible. If visible, perpendicular axes will be set to `fixedrange`
        public static Box<IRangesliderProperty> visible(bool val) => Interop.mkRangesliderAttr("visible", val);
        public static Box<IRangesliderProperty> yaxis(int anchorId) => Interop.mkRangesliderAttr("yaxis", anchorId > 1 ? $"y{anchorId}" : "");
        public static Box<IRangesliderProperty> yaxis(params Box<IYaxisProperty>[] properties) => Interop.mkRangesliderAttr("yaxis", Bindings.flattenProperties(properties));
    }
}