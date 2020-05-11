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

    public static partial class Xaxis
    {
        /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
        public static Box<IXaxisProperty> visible(bool val) => Interop.mkXaxisAttr("visible", val);
        /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
        public static Box<IXaxisProperty> color(string val) => Interop.mkXaxisAttr("color", val);
        public static Box<IXaxisProperty> title(params Box<ITitleProperty>[] properties) => Interop.mkXaxisAttr("title", Bindings.flattenProperties(properties));
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IXaxisProperty> range(bool val) => Interop.mkXaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IXaxisProperty> range(IEnumerable<bool> values) => Interop.mkXaxisAttr("range", values.ToArray());
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IXaxisProperty> range(System.DateTime val) => Interop.mkXaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IXaxisProperty> range(IEnumerable<System.DateTime> values) => Interop.mkXaxisAttr("range", values.ToArray());
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IXaxisProperty> range(float val) => Interop.mkXaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IXaxisProperty> range(IEnumerable<float> values) => Interop.mkXaxisAttr("range", values.ToArray());
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IXaxisProperty> range(int val) => Interop.mkXaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IXaxisProperty> range(IEnumerable<int> values) => Interop.mkXaxisAttr("range", values.ToArray());
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IXaxisProperty> range(string val) => Interop.mkXaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IXaxisProperty> range(IEnumerable<string> values) => Interop.mkXaxisAttr("range", values.ToArray());
        /// Determines whether or not this axis is zoom-able. If true, then zoom is disabled.
        public static Box<IXaxisProperty> fixedrange(bool val) => Interop.mkXaxisAttr("fixedrange", val);
        /// If this axis is linked to another by `scaleanchor`, this determines the pixel to unit scale ratio. For example, if this value is 10, then every unit on this axis spans 10 times the number of pixels as a unit on the linked axis. Use this for example to create an elevation profile where the vertical scale is exaggerated a fixed amount with respect to the horizontal.
        public static Box<IXaxisProperty> scaleratio(int val) => Interop.mkXaxisAttr("scaleratio", val);
        /// If this axis is linked to another by `scaleanchor`, this determines the pixel to unit scale ratio. For example, if this value is 10, then every unit on this axis spans 10 times the number of pixels as a unit on the linked axis. Use this for example to create an elevation profile where the vertical scale is exaggerated a fixed amount with respect to the horizontal.
        public static Box<IXaxisProperty> scaleratio(float val) => Interop.mkXaxisAttr("scaleratio", val);
        /// If set to another axis id (e.g. `x2`, `y`), the range of this axis will match the range of the corresponding axis in data-coordinates space. Moreover, matching axes share auto-range values, category lists and histogram auto-bins. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden. Moreover, note that matching axes must have the same `type`.
        public static Box<IXaxisProperty> matches(string val) => Interop.mkXaxisAttr("matches", val);
        /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
        public static Box<IXaxisProperty> nticks(int val) => Interop.mkXaxisAttr("nticks", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IXaxisProperty> tick0(bool val) => Interop.mkXaxisAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IXaxisProperty> tick0(params bool[] values) => Interop.mkXaxisAttr("tick0", values);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IXaxisProperty> tick0(System.DateTime val) => Interop.mkXaxisAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IXaxisProperty> tick0(params System.DateTime[] values) => Interop.mkXaxisAttr("tick0", values);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IXaxisProperty> tick0(int val) => Interop.mkXaxisAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IXaxisProperty> tick0(params int[] values) => Interop.mkXaxisAttr("tick0", values);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IXaxisProperty> tick0(float val) => Interop.mkXaxisAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IXaxisProperty> tick0(params float[] values) => Interop.mkXaxisAttr("tick0", values);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IXaxisProperty> tick0(string val) => Interop.mkXaxisAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IXaxisProperty> tick0(params string[] values) => Interop.mkXaxisAttr("tick0", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IXaxisProperty> dtick(bool val) => Interop.mkXaxisAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IXaxisProperty> dtick(params bool[] values) => Interop.mkXaxisAttr("dtick", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IXaxisProperty> dtick(System.DateTime val) => Interop.mkXaxisAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IXaxisProperty> dtick(params System.DateTime[] values) => Interop.mkXaxisAttr("dtick", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IXaxisProperty> dtick(int val) => Interop.mkXaxisAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IXaxisProperty> dtick(params int[] values) => Interop.mkXaxisAttr("dtick", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IXaxisProperty> dtick(float val) => Interop.mkXaxisAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IXaxisProperty> dtick(params float[] values) => Interop.mkXaxisAttr("dtick", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IXaxisProperty> dtick(string val) => Interop.mkXaxisAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IXaxisProperty> dtick(params string[] values) => Interop.mkXaxisAttr("dtick", values);
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IXaxisProperty> tickvals(bool val) => Interop.mkXaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IXaxisProperty> tickvals(IEnumerable<bool> values) => Interop.mkXaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IXaxisProperty> tickvals(System.DateTime val) => Interop.mkXaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IXaxisProperty> tickvals(IEnumerable<System.DateTime> values) => Interop.mkXaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IXaxisProperty> tickvals(float val) => Interop.mkXaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IXaxisProperty> tickvals(IEnumerable<float> values) => Interop.mkXaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IXaxisProperty> tickvals(int val) => Interop.mkXaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IXaxisProperty> tickvals(IEnumerable<int> values) => Interop.mkXaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IXaxisProperty> tickvals(string val) => Interop.mkXaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IXaxisProperty> tickvals(IEnumerable<string> values) => Interop.mkXaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IXaxisProperty> tickvals(IEnumerable<bool[]> values) => Interop.mkXaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IXaxisProperty> tickvals(List<bool[]> values) => Interop.mkXaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IXaxisProperty> tickvals(params bool[][] values) => Interop.mkXaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IXaxisProperty> tickvals(IEnumerable<IEnumerable<string>> values) => Interop.mkXaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IXaxisProperty> tickvals(List<string[]> values) => Interop.mkXaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IXaxisProperty> tickvals(params string[][] values) => Interop.mkXaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IXaxisProperty> tickvals(IEnumerable<IEnumerable<int>> values) => Interop.mkXaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IXaxisProperty> tickvals(List<int[]> values) => Interop.mkXaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IXaxisProperty> tickvals(params int[][] values) => Interop.mkXaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IXaxisProperty> tickvals(IEnumerable<IEnumerable<float>> values) => Interop.mkXaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IXaxisProperty> tickvals(List<float[]> values) => Interop.mkXaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IXaxisProperty> tickvals(params float[][] values) => Interop.mkXaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IXaxisProperty> tickvals(Literals.PlotData[] values) => Interop.mkXaxisAttr("tickvals", values);
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IXaxisProperty> tickvals(IEnumerable<bool?> values) => Interop.mkXaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IXaxisProperty> tickvals(IEnumerable<System.DateTime?> values) => Interop.mkXaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IXaxisProperty> tickvals(IEnumerable<int?> values) => Interop.mkXaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IXaxisProperty> tickvals(IEnumerable<float?> values) => Interop.mkXaxisAttr("tickvals", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IXaxisProperty> ticktext(bool val) => Interop.mkXaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IXaxisProperty> ticktext(IEnumerable<bool> values) => Interop.mkXaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IXaxisProperty> ticktext(System.DateTime val) => Interop.mkXaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IXaxisProperty> ticktext(IEnumerable<System.DateTime> values) => Interop.mkXaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IXaxisProperty> ticktext(float val) => Interop.mkXaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IXaxisProperty> ticktext(IEnumerable<float> values) => Interop.mkXaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IXaxisProperty> ticktext(int val) => Interop.mkXaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IXaxisProperty> ticktext(IEnumerable<int> values) => Interop.mkXaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IXaxisProperty> ticktext(string val) => Interop.mkXaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IXaxisProperty> ticktext(IEnumerable<string> values) => Interop.mkXaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IXaxisProperty> ticktext(IEnumerable<bool[]> values) => Interop.mkXaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IXaxisProperty> ticktext(List<bool[]> values) => Interop.mkXaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IXaxisProperty> ticktext(params bool[][] values) => Interop.mkXaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IXaxisProperty> ticktext(IEnumerable<IEnumerable<string>> values) => Interop.mkXaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IXaxisProperty> ticktext(List<string[]> values) => Interop.mkXaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IXaxisProperty> ticktext(params string[][] values) => Interop.mkXaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IXaxisProperty> ticktext(IEnumerable<IEnumerable<int>> values) => Interop.mkXaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IXaxisProperty> ticktext(List<int[]> values) => Interop.mkXaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IXaxisProperty> ticktext(params int[][] values) => Interop.mkXaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IXaxisProperty> ticktext(IEnumerable<IEnumerable<float>> values) => Interop.mkXaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IXaxisProperty> ticktext(List<float[]> values) => Interop.mkXaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IXaxisProperty> ticktext(params float[][] values) => Interop.mkXaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IXaxisProperty> ticktext(Literals.PlotData[] values) => Interop.mkXaxisAttr("ticktext", values);
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IXaxisProperty> ticktext(IEnumerable<bool?> values) => Interop.mkXaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IXaxisProperty> ticktext(IEnumerable<System.DateTime?> values) => Interop.mkXaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IXaxisProperty> ticktext(IEnumerable<int?> values) => Interop.mkXaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IXaxisProperty> ticktext(IEnumerable<float?> values) => Interop.mkXaxisAttr("ticktext", values.ToArray());
        /// Sets the tick length (in px).
        public static Box<IXaxisProperty> ticklen(int val) => Interop.mkXaxisAttr("ticklen", val);
        /// Sets the tick length (in px).
        public static Box<IXaxisProperty> ticklen(float val) => Interop.mkXaxisAttr("ticklen", val);
        /// Sets the tick width (in px).
        public static Box<IXaxisProperty> tickwidth(int val) => Interop.mkXaxisAttr("tickwidth", val);
        /// Sets the tick width (in px).
        public static Box<IXaxisProperty> tickwidth(float val) => Interop.mkXaxisAttr("tickwidth", val);
        /// Sets the tick color.
        public static Box<IXaxisProperty> tickcolor(string val) => Interop.mkXaxisAttr("tickcolor", val);
        /// Determines whether or not the tick labels are drawn.
        public static Box<IXaxisProperty> showticklabels(bool val) => Interop.mkXaxisAttr("showticklabels", val);
        /// Determines whether long tick labels automatically grow the figure margins.
        public static Box<IXaxisProperty> automargin(bool val) => Interop.mkXaxisAttr("automargin", val);
        /// Determines whether or not spikes (aka droplines) are drawn for this axis. Note: This only takes affect when hovermode = closest
        public static Box<IXaxisProperty> showspikes(bool val) => Interop.mkXaxisAttr("showspikes", val);
        /// Sets the spike color. If undefined, will use the series color
        public static Box<IXaxisProperty> spikecolor(string val) => Interop.mkXaxisAttr("spikecolor", val);
        /// Sets the width (in px) of the zero line.
        public static Box<IXaxisProperty> spikethickness(int val) => Interop.mkXaxisAttr("spikethickness", val);
        /// Sets the width (in px) of the zero line.
        public static Box<IXaxisProperty> spikethickness(float val) => Interop.mkXaxisAttr("spikethickness", val);
        /// Determines the drawing mode for the spike line If *toaxis*, the line is drawn from the data point to the axis the  series is plotted on. If *across*, the line is drawn across the entire plot area, and supercedes *toaxis*. If *marker*, then a marker dot is drawn on the axis the series is plotted on
        public static Box<IXaxisProperty> spikemode(params Box<IXaxisProperty>[] properties) => Interop.mkXaxisAttr("spikemode", Bindings.joinEnumProperties(properties));
        /// Sets the tick font.
        public static Box<IXaxisProperty> tickfont(params Box<ITickfontProperty>[] properties) => Interop.mkXaxisAttr("tickfont", Bindings.flattenProperties(properties));
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        public static Box<IXaxisProperty> tickangle(int val) => Interop.mkXaxisAttr("tickangle", val);
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        public static Box<IXaxisProperty> tickangle(float val) => Interop.mkXaxisAttr("tickangle", val);
        /// Sets a tick label prefix.
        public static Box<IXaxisProperty> tickprefix(string val) => Interop.mkXaxisAttr("tickprefix", val);
        /// Sets a tick label suffix.
        public static Box<IXaxisProperty> ticksuffix(string val) => Interop.mkXaxisAttr("ticksuffix", val);
        /// If \"true\", even 4-digit integers are separated
        public static Box<IXaxisProperty> separatethousands(bool val) => Interop.mkXaxisAttr("separatethousands", val);
        /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        public static Box<IXaxisProperty> tickformat(string val) => Interop.mkXaxisAttr("tickformat", val);
        public static Box<IXaxisProperty> tickformatstops(params Box<ITickformatstopsProperty>[] properties) => Interop.mkXaxisAttr("tickformatstops", Bindings.flattenProperties(properties));
        /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        public static Box<IXaxisProperty> hoverformat(string val) => Interop.mkXaxisAttr("hoverformat", val);
        /// Determines whether or not a line bounding this axis is drawn.
        public static Box<IXaxisProperty> showline(bool val) => Interop.mkXaxisAttr("showline", val);
        /// Sets the axis line color.
        public static Box<IXaxisProperty> linecolor(string val) => Interop.mkXaxisAttr("linecolor", val);
        /// Sets the width (in px) of the axis line.
        public static Box<IXaxisProperty> linewidth(int val) => Interop.mkXaxisAttr("linewidth", val);
        /// Sets the width (in px) of the axis line.
        public static Box<IXaxisProperty> linewidth(float val) => Interop.mkXaxisAttr("linewidth", val);
        /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
        public static Box<IXaxisProperty> showgrid(bool val) => Interop.mkXaxisAttr("showgrid", val);
        /// Sets the color of the grid lines.
        public static Box<IXaxisProperty> gridcolor(string val) => Interop.mkXaxisAttr("gridcolor", val);
        /// Sets the width (in px) of the grid lines.
        public static Box<IXaxisProperty> gridwidth(int val) => Interop.mkXaxisAttr("gridwidth", val);
        /// Sets the width (in px) of the grid lines.
        public static Box<IXaxisProperty> gridwidth(float val) => Interop.mkXaxisAttr("gridwidth", val);
        /// Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines.
        public static Box<IXaxisProperty> zeroline(bool val) => Interop.mkXaxisAttr("zeroline", val);
        /// Sets the line color of the zero line.
        public static Box<IXaxisProperty> zerolinecolor(string val) => Interop.mkXaxisAttr("zerolinecolor", val);
        /// Sets the width (in px) of the zero line.
        public static Box<IXaxisProperty> zerolinewidth(int val) => Interop.mkXaxisAttr("zerolinewidth", val);
        /// Sets the width (in px) of the zero line.
        public static Box<IXaxisProperty> zerolinewidth(float val) => Interop.mkXaxisAttr("zerolinewidth", val);
        /// Determines whether or not a dividers are drawn between the category levels of this axis. Only has an effect on *multicategory* axes.
        public static Box<IXaxisProperty> showdividers(bool val) => Interop.mkXaxisAttr("showdividers", val);
        /// Sets the color of the dividers Only has an effect on *multicategory* axes.
        public static Box<IXaxisProperty> dividercolor(string val) => Interop.mkXaxisAttr("dividercolor", val);
        /// Sets the width (in px) of the dividers Only has an effect on *multicategory* axes.
        public static Box<IXaxisProperty> dividerwidth(int val) => Interop.mkXaxisAttr("dividerwidth", val);
        /// Sets the width (in px) of the dividers Only has an effect on *multicategory* axes.
        public static Box<IXaxisProperty> dividerwidth(float val) => Interop.mkXaxisAttr("dividerwidth", val);
        /// Sets the domain of this axis (in plot fraction).
        public static Box<IXaxisProperty> domain(int val) => Interop.mkXaxisAttr("domain", new[]{val});
        /// Sets the domain of this axis (in plot fraction).
        public static Box<IXaxisProperty> domain(IEnumerable<int> values) => Interop.mkXaxisAttr("domain", values.ToArray());
        /// Sets the domain of this axis (in plot fraction).
        public static Box<IXaxisProperty> domain(float val) => Interop.mkXaxisAttr("domain", new[]{val});
        /// Sets the domain of this axis (in plot fraction).
        public static Box<IXaxisProperty> domain(IEnumerable<float> values) => Interop.mkXaxisAttr("domain", values.ToArray());
        /// Sets the position of this axis in the plotting space (in normalized coordinates). Only has an effect if `anchor` is set to *free*.
        public static Box<IXaxisProperty> position(int val) => Interop.mkXaxisAttr("position", val);
        /// Sets the position of this axis in the plotting space (in normalized coordinates). Only has an effect if `anchor` is set to *free*.
        public static Box<IXaxisProperty> position(float val) => Interop.mkXaxisAttr("position", val);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IXaxisProperty> categoryarray(bool val) => Interop.mkXaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IXaxisProperty> categoryarray(params bool[] values) => Interop.mkXaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IXaxisProperty> categoryarray(System.DateTime val) => Interop.mkXaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IXaxisProperty> categoryarray(params System.DateTime[] values) => Interop.mkXaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IXaxisProperty> categoryarray(float val) => Interop.mkXaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IXaxisProperty> categoryarray(params float[] values) => Interop.mkXaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IXaxisProperty> categoryarray(int val) => Interop.mkXaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IXaxisProperty> categoryarray(params int[] values) => Interop.mkXaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IXaxisProperty> categoryarray(string val) => Interop.mkXaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IXaxisProperty> categoryarray(params string[] values) => Interop.mkXaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IXaxisProperty> categoryarray(IEnumerable<bool[]> values) => Interop.mkXaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IXaxisProperty> categoryarray(List<bool[]> values) => Interop.mkXaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IXaxisProperty> categoryarray(params bool[][] values) => Interop.mkXaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IXaxisProperty> categoryarray(IEnumerable<IEnumerable<string>> values) => Interop.mkXaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IXaxisProperty> categoryarray(List<string[]> values) => Interop.mkXaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IXaxisProperty> categoryarray(params string[][] values) => Interop.mkXaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IXaxisProperty> categoryarray(IEnumerable<IEnumerable<int>> values) => Interop.mkXaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IXaxisProperty> categoryarray(List<int[]> values) => Interop.mkXaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IXaxisProperty> categoryarray(params int[][] values) => Interop.mkXaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IXaxisProperty> categoryarray(IEnumerable<IEnumerable<float>> values) => Interop.mkXaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IXaxisProperty> categoryarray(List<float[]> values) => Interop.mkXaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IXaxisProperty> categoryarray(params float[][] values) => Interop.mkXaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IXaxisProperty> categoryarray(Literals.PlotData[] values) => Interop.mkXaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IXaxisProperty> categoryarray(IEnumerable<bool?> values) => Interop.mkXaxisAttr("categoryarray", values.ToArray());
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IXaxisProperty> categoryarray(IEnumerable<System.DateTime?> values) => Interop.mkXaxisAttr("categoryarray", values.ToArray());
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IXaxisProperty> categoryarray(IEnumerable<int?> values) => Interop.mkXaxisAttr("categoryarray", values.ToArray());
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IXaxisProperty> categoryarray(IEnumerable<float?> values) => Interop.mkXaxisAttr("categoryarray", values.ToArray());
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        public static Box<IXaxisProperty> uirevision(bool val) => Interop.mkXaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        public static Box<IXaxisProperty> uirevision(params bool[] values) => Interop.mkXaxisAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        public static Box<IXaxisProperty> uirevision(System.DateTime val) => Interop.mkXaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        public static Box<IXaxisProperty> uirevision(params System.DateTime[] values) => Interop.mkXaxisAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        public static Box<IXaxisProperty> uirevision(int val) => Interop.mkXaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        public static Box<IXaxisProperty> uirevision(params int[] values) => Interop.mkXaxisAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        public static Box<IXaxisProperty> uirevision(float val) => Interop.mkXaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        public static Box<IXaxisProperty> uirevision(params float[] values) => Interop.mkXaxisAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        public static Box<IXaxisProperty> uirevision(string val) => Interop.mkXaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        public static Box<IXaxisProperty> uirevision(params string[] values) => Interop.mkXaxisAttr("uirevision", values);
        public static Box<IXaxisProperty> rangeslider(params Box<IRangesliderProperty>[] properties) => Interop.mkXaxisAttr("rangeslider", Bindings.flattenProperties(properties));
        public static Box<IXaxisProperty> rangeselector(params Box<IRangeselectorProperty>[] properties) => Interop.mkXaxisAttr("rangeselector", Bindings.flattenProperties(properties));
        /// Sets the source reference on plot.ly for  tickvals .
        public static Box<IXaxisProperty> tickvalssrc(string val) => Interop.mkXaxisAttr("tickvalssrc", val);
        /// Sets the source reference on plot.ly for  ticktext .
        public static Box<IXaxisProperty> ticktextsrc(string val) => Interop.mkXaxisAttr("ticktextsrc", val);
        /// Sets the source reference on plot.ly for  categoryarray .
        public static Box<IXaxisProperty> categoryarraysrc(string val) => Interop.mkXaxisAttr("categoryarraysrc", val);
        /// Sets whether or not spikes extending from the projection data points to this axis' wall boundaries are shown on hover.
        public static Box<IXaxisProperty> spikesides(bool val) => Interop.mkXaxisAttr("spikesides", val);
        /// Sets whether or not this axis' wall has a background color.
        public static Box<IXaxisProperty> showbackground(bool val) => Interop.mkXaxisAttr("showbackground", val);
        /// Sets the background color of this axis' wall.
        public static Box<IXaxisProperty> backgroundcolor(string val) => Interop.mkXaxisAttr("backgroundcolor", val);
        /// Sets whether or not this axis is labeled
        public static Box<IXaxisProperty> showaxeslabels(bool val) => Interop.mkXaxisAttr("showaxeslabels", val);
    }

    public static partial class Xaxis
    {
        /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
        public static partial class _type
        {
            public static Box<IXaxisProperty> dash() => Interop.mkXaxisAttr("type", "-");
            public static Box<IXaxisProperty> category() => Interop.mkXaxisAttr("type", "category");
            public static Box<IXaxisProperty> date() => Interop.mkXaxisAttr("type", "date");
            public static Box<IXaxisProperty> linear() => Interop.mkXaxisAttr("type", "linear");
            public static Box<IXaxisProperty> log() => Interop.mkXaxisAttr("type", "log");
            public static Box<IXaxisProperty> multicategory() => Interop.mkXaxisAttr("type", "multicategory");
        }

        /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
        public static partial class Autorange
        {
            public static Box<IXaxisProperty> reversed() => Interop.mkXaxisAttr("autorange", "reversed");
            public static Box<IXaxisProperty> _false() => Interop.mkXaxisAttr("autorange", false);
            public static Box<IXaxisProperty> _true() => Interop.mkXaxisAttr("autorange", true);
        }

        /// If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes.
        public static partial class Rangemode
        {
            public static Box<IXaxisProperty> nonnegative() => Interop.mkXaxisAttr("rangemode", "nonnegative");
            public static Box<IXaxisProperty> normal() => Interop.mkXaxisAttr("rangemode", "normal");
            public static Box<IXaxisProperty> tozero() => Interop.mkXaxisAttr("rangemode", "tozero");
        }

        /// If set to another axis id (e.g. `x2`, `y`), the range of this axis changes together with the range of the corresponding axis such that the scale of pixels per unit is in a constant ratio. Both axes are still zoomable, but when you zoom one, the other will zoom the same amount, keeping a fixed midpoint. `constrain` and `constraintoward` determine how we enforce the constraint. You can chain these, ie `yaxis: {scaleanchor: *x*}, xaxis2: {scaleanchor: *y*}` but you can only link axes of the same `type`. The linked axis can have the opposite letter (to constrain the aspect ratio) or the same letter (to match scales across subplots). Loops (`yaxis: {scaleanchor: *x*}, xaxis: {scaleanchor: *y*}` or longer) are redundant and the last constraint encountered will be ignored to avoid possible inconsistent constraints via `scaleratio`. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden.
        public static partial class Scaleanchor
        {
            public static Box<IXaxisProperty> custom(string val) => Interop.mkXaxisAttr("scaleanchor", val);
            public static Box<IXaxisProperty> x(int anchorId) => Interop.mkXaxisAttr("scaleanchor", anchorId > 1 ? $"x{anchorId}" : "");
            public static Box<IXaxisProperty> y(int anchorId) => Interop.mkXaxisAttr("scaleanchor", anchorId > 1 ? $"y{anchorId}" : "");
        }

        /// If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines how that happens: by increasing the *range* (default), or by decreasing the *domain*.
        public static partial class Constrain
        {
            public static Box<IXaxisProperty> domain() => Interop.mkXaxisAttr("constrain", "domain");
            public static Box<IXaxisProperty> range() => Interop.mkXaxisAttr("constrain", "range");
        }

        /// If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines which direction we push the originally specified plot area. Options are *left*, *center* (default), and *right* for x axes, and *top*, *middle* (default), and *bottom* for y axes.
        public static partial class Constraintoward
        {
            public static Box<IXaxisProperty> bottom() => Interop.mkXaxisAttr("constraintoward", "bottom");
            public static Box<IXaxisProperty> center() => Interop.mkXaxisAttr("constraintoward", "center");
            public static Box<IXaxisProperty> left() => Interop.mkXaxisAttr("constraintoward", "left");
            public static Box<IXaxisProperty> middle() => Interop.mkXaxisAttr("constraintoward", "middle");
            public static Box<IXaxisProperty> right() => Interop.mkXaxisAttr("constraintoward", "right");
            public static Box<IXaxisProperty> top() => Interop.mkXaxisAttr("constraintoward", "top");
        }

        /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
        public static partial class Tickmode
        {
            public static Box<IXaxisProperty> array() => Interop.mkXaxisAttr("tickmode", "array");
            public static Box<IXaxisProperty> auto() => Interop.mkXaxisAttr("tickmode", "auto");
            public static Box<IXaxisProperty> linear() => Interop.mkXaxisAttr("tickmode", "linear");
        }

        /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
        public static partial class Ticks
        {
            public static Box<IXaxisProperty> none() => Interop.mkXaxisAttr("ticks", "");
            public static Box<IXaxisProperty> inside() => Interop.mkXaxisAttr("ticks", "inside");
            public static Box<IXaxisProperty> outside() => Interop.mkXaxisAttr("ticks", "outside");
        }

        /// Determines where ticks and grid lines are drawn with respect to their corresponding tick labels. Only has an effect for axes of `type` *category* or *multicategory*. When set to *boundaries*, ticks and grid lines are drawn half a category to the left/bottom of labels.
        public static partial class Tickson
        {
            public static Box<IXaxisProperty> boundaries() => Interop.mkXaxisAttr("tickson", "boundaries");
            public static Box<IXaxisProperty> labels() => Interop.mkXaxisAttr("tickson", "labels");
        }

        /// Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots.
        public static partial class Mirror
        {
            public static Box<IXaxisProperty> all() => Interop.mkXaxisAttr("mirror", "all");
            public static Box<IXaxisProperty> allticks() => Interop.mkXaxisAttr("mirror", "allticks");
            public static Box<IXaxisProperty> ticks() => Interop.mkXaxisAttr("mirror", "ticks");
            public static Box<IXaxisProperty> _false() => Interop.mkXaxisAttr("mirror", false);
            public static Box<IXaxisProperty> _true() => Interop.mkXaxisAttr("mirror", true);
        }

        /// Sets the dash style of lines. Set to a dash type string (*solid*, *dot*, *dash*, *longdash*, *dashdot*, or *longdashdot*) or a dash length list in px (eg *5px,10px,2px,2px*).
        public static partial class Spikedash
        {
            public static Box<IXaxisProperty> dash() => Interop.mkXaxisAttr("spikedash", "dash");
            public static Box<IXaxisProperty> dashdot() => Interop.mkXaxisAttr("spikedash", "dashdot");
            public static Box<IXaxisProperty> dot() => Interop.mkXaxisAttr("spikedash", "dot");
            public static Box<IXaxisProperty> longdash() => Interop.mkXaxisAttr("spikedash", "longdash");
            public static Box<IXaxisProperty> longdashdot() => Interop.mkXaxisAttr("spikedash", "longdashdot");
            public static Box<IXaxisProperty> solid() => Interop.mkXaxisAttr("spikedash", "solid");
            public static Box<IXaxisProperty> custom(string val) => Interop.mkXaxisAttr("spikedash", val);
        }

        /// Determines the drawing mode for the spike line If *toaxis*, the line is drawn from the data point to the axis the  series is plotted on. If *across*, the line is drawn across the entire plot area, and supercedes *toaxis*. If *marker*, then a marker dot is drawn on the axis the series is plotted on
        public static partial class Spikemode
        {
            public static Box<IXaxisProperty> across() => Interop.mkXaxisAttr("spikemode", "across");
            public static Box<IXaxisProperty> marker() => Interop.mkXaxisAttr("spikemode", "marker");
            public static Box<IXaxisProperty> toaxis() => Interop.mkXaxisAttr("spikemode", "toaxis");
        }

        /// Determines whether spikelines are stuck to the cursor or to the closest datapoints.
        public static partial class Spikesnap
        {
            public static Box<IXaxisProperty> cursor() => Interop.mkXaxisAttr("spikesnap", "cursor");
            public static Box<IXaxisProperty> data() => Interop.mkXaxisAttr("spikesnap", "data");
        }

        /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
        public static partial class Showtickprefix
        {
            public static Box<IXaxisProperty> all() => Interop.mkXaxisAttr("showtickprefix", "all");
            public static Box<IXaxisProperty> first() => Interop.mkXaxisAttr("showtickprefix", "first");
            public static Box<IXaxisProperty> last() => Interop.mkXaxisAttr("showtickprefix", "last");
            public static Box<IXaxisProperty> none() => Interop.mkXaxisAttr("showtickprefix", "none");
        }

        /// Same as `showtickprefix` but for tick suffixes.
        public static partial class Showticksuffix
        {
            public static Box<IXaxisProperty> all() => Interop.mkXaxisAttr("showticksuffix", "all");
            public static Box<IXaxisProperty> first() => Interop.mkXaxisAttr("showticksuffix", "first");
            public static Box<IXaxisProperty> last() => Interop.mkXaxisAttr("showticksuffix", "last");
            public static Box<IXaxisProperty> none() => Interop.mkXaxisAttr("showticksuffix", "none");
        }

        /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
        public static partial class Showexponent
        {
            public static Box<IXaxisProperty> all() => Interop.mkXaxisAttr("showexponent", "all");
            public static Box<IXaxisProperty> first() => Interop.mkXaxisAttr("showexponent", "first");
            public static Box<IXaxisProperty> last() => Interop.mkXaxisAttr("showexponent", "last");
            public static Box<IXaxisProperty> none() => Interop.mkXaxisAttr("showexponent", "none");
        }

        /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
        public static partial class Exponentformat
        {
            public static Box<IXaxisProperty> B() => Interop.mkXaxisAttr("exponentformat", "B");
            public static Box<IXaxisProperty> E() => Interop.mkXaxisAttr("exponentformat", "E");
            public static Box<IXaxisProperty> SI() => Interop.mkXaxisAttr("exponentformat", "SI");
            public static Box<IXaxisProperty> e() => Interop.mkXaxisAttr("exponentformat", "e");
            public static Box<IXaxisProperty> none() => Interop.mkXaxisAttr("exponentformat", "none");
            public static Box<IXaxisProperty> power() => Interop.mkXaxisAttr("exponentformat", "power");
        }

        /// If set to an opposite-letter axis id (e.g. `x2`, `y`), this axis is bound to the corresponding opposite-letter axis. If set to *free*, this axis' position is determined by `position`.
        public static partial class Anchor
        {
            public static Box<IXaxisProperty> free() => Interop.mkXaxisAttr("anchor", "free");
            public static Box<IXaxisProperty> custom(string val) => Interop.mkXaxisAttr("anchor", val);
            public static Box<IXaxisProperty> x(int anchorId) => Interop.mkXaxisAttr("anchor", anchorId > 1 ? $"x{anchorId}" : "");
            public static Box<IXaxisProperty> y(int anchorId) => Interop.mkXaxisAttr("anchor", anchorId > 1 ? $"y{anchorId}" : "");
        }

        /// Determines whether a x (y) axis is positioned at the *bottom* (*left*) or *top* (*right*) of the plotting area.
        public static partial class Side
        {
            public static Box<IXaxisProperty> bottom() => Interop.mkXaxisAttr("side", "bottom");
            public static Box<IXaxisProperty> left() => Interop.mkXaxisAttr("side", "left");
            public static Box<IXaxisProperty> right() => Interop.mkXaxisAttr("side", "right");
            public static Box<IXaxisProperty> top() => Interop.mkXaxisAttr("side", "top");
        }

        /// If set a same-letter axis id, this axis is overlaid on top of the corresponding same-letter axis, with traces and axes visible for both axes. If *false*, this axis does not overlay any same-letter axes. In this case, for axes with overlapping domains only the highest-numbered axis will be visible.
        public static partial class Overlaying
        {
            public static Box<IXaxisProperty> free() => Interop.mkXaxisAttr("overlaying", "free");
            public static Box<IXaxisProperty> custom(string val) => Interop.mkXaxisAttr("overlaying", val);
            public static Box<IXaxisProperty> x(int anchorId) => Interop.mkXaxisAttr("overlaying", anchorId > 1 ? $"x{anchorId}" : "");
            public static Box<IXaxisProperty> y(int anchorId) => Interop.mkXaxisAttr("overlaying", anchorId > 1 ? $"y{anchorId}" : "");
        }

        /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
        public static partial class Layer
        {
            public static Box<IXaxisProperty> aboveTraces() => Interop.mkXaxisAttr("layer", "above traces");
            public static Box<IXaxisProperty> belowTraces() => Interop.mkXaxisAttr("layer", "below traces");
        }

        /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
        public static partial class Categoryorder
        {
            public static Box<IXaxisProperty> array() => Interop.mkXaxisAttr("categoryorder", "array");
            public static Box<IXaxisProperty> categoryAscending() => Interop.mkXaxisAttr("categoryorder", "category ascending");
            public static Box<IXaxisProperty> categoryDescending() => Interop.mkXaxisAttr("categoryorder", "category descending");
            public static Box<IXaxisProperty> maxAscending() => Interop.mkXaxisAttr("categoryorder", "max ascending");
            public static Box<IXaxisProperty> maxDescending() => Interop.mkXaxisAttr("categoryorder", "max descending");
            public static Box<IXaxisProperty> meanAscending() => Interop.mkXaxisAttr("categoryorder", "mean ascending");
            public static Box<IXaxisProperty> meanDescending() => Interop.mkXaxisAttr("categoryorder", "mean descending");
            public static Box<IXaxisProperty> medianAscending() => Interop.mkXaxisAttr("categoryorder", "median ascending");
            public static Box<IXaxisProperty> medianDescending() => Interop.mkXaxisAttr("categoryorder", "median descending");
            public static Box<IXaxisProperty> minAscending() => Interop.mkXaxisAttr("categoryorder", "min ascending");
            public static Box<IXaxisProperty> minDescending() => Interop.mkXaxisAttr("categoryorder", "min descending");
            public static Box<IXaxisProperty> sumAscending() => Interop.mkXaxisAttr("categoryorder", "sum ascending");
            public static Box<IXaxisProperty> sumDescending() => Interop.mkXaxisAttr("categoryorder", "sum descending");
            public static Box<IXaxisProperty> totalAscending() => Interop.mkXaxisAttr("categoryorder", "total ascending");
            public static Box<IXaxisProperty> totalDescending() => Interop.mkXaxisAttr("categoryorder", "total descending");
            public static Box<IXaxisProperty> trace() => Interop.mkXaxisAttr("categoryorder", "trace");
        }

        /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
        public static partial class Calendar
        {
            public static Box<IXaxisProperty> chinese() => Interop.mkXaxisAttr("calendar", "chinese");
            public static Box<IXaxisProperty> coptic() => Interop.mkXaxisAttr("calendar", "coptic");
            public static Box<IXaxisProperty> discworld() => Interop.mkXaxisAttr("calendar", "discworld");
            public static Box<IXaxisProperty> ethiopian() => Interop.mkXaxisAttr("calendar", "ethiopian");
            public static Box<IXaxisProperty> gregorian() => Interop.mkXaxisAttr("calendar", "gregorian");
            public static Box<IXaxisProperty> hebrew() => Interop.mkXaxisAttr("calendar", "hebrew");
            public static Box<IXaxisProperty> islamic() => Interop.mkXaxisAttr("calendar", "islamic");
            public static Box<IXaxisProperty> jalali() => Interop.mkXaxisAttr("calendar", "jalali");
            public static Box<IXaxisProperty> julian() => Interop.mkXaxisAttr("calendar", "julian");
            public static Box<IXaxisProperty> mayan() => Interop.mkXaxisAttr("calendar", "mayan");
            public static Box<IXaxisProperty> nanakshahi() => Interop.mkXaxisAttr("calendar", "nanakshahi");
            public static Box<IXaxisProperty> nepali() => Interop.mkXaxisAttr("calendar", "nepali");
            public static Box<IXaxisProperty> persian() => Interop.mkXaxisAttr("calendar", "persian");
            public static Box<IXaxisProperty> taiwan() => Interop.mkXaxisAttr("calendar", "taiwan");
            public static Box<IXaxisProperty> thai() => Interop.mkXaxisAttr("calendar", "thai");
            public static Box<IXaxisProperty> ummalqura() => Interop.mkXaxisAttr("calendar", "ummalqura");
        }
    }
}