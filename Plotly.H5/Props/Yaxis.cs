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

    public static partial class Yaxis
    {
        /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
        public static Box<IYaxisProperty> visible(bool val) => Interop.mkYaxisAttr("visible", val);
        /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
        public static Box<IYaxisProperty> color(string val) => Interop.mkYaxisAttr("color", val);
        public static Box<IYaxisProperty> title(params Box<ITitleProperty>[] properties) => Interop.mkYaxisAttr("title", Bindings.flattenProperties(properties));
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IYaxisProperty> range(bool val) => Interop.mkYaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IYaxisProperty> range(IEnumerable<bool> values) => Interop.mkYaxisAttr("range", values.ToArray());
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IYaxisProperty> range(System.DateTime val) => Interop.mkYaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IYaxisProperty> range(IEnumerable<System.DateTime> values) => Interop.mkYaxisAttr("range", values.ToArray());
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IYaxisProperty> range(float val) => Interop.mkYaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IYaxisProperty> range(IEnumerable<float> values) => Interop.mkYaxisAttr("range", values.ToArray());
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IYaxisProperty> range(int val) => Interop.mkYaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IYaxisProperty> range(IEnumerable<int> values) => Interop.mkYaxisAttr("range", values.ToArray());
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IYaxisProperty> range(string val) => Interop.mkYaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IYaxisProperty> range(IEnumerable<string> values) => Interop.mkYaxisAttr("range", values.ToArray());
        /// Determines whether or not this axis is zoom-able. If true, then zoom is disabled.
        public static Box<IYaxisProperty> fixedrange(bool val) => Interop.mkYaxisAttr("fixedrange", val);
        /// If this axis is linked to another by `scaleanchor`, this determines the pixel to unit scale ratio. For example, if this value is 10, then every unit on this axis spans 10 times the number of pixels as a unit on the linked axis. Use this for example to create an elevation profile where the vertical scale is exaggerated a fixed amount with respect to the horizontal.
        public static Box<IYaxisProperty> scaleratio(int val) => Interop.mkYaxisAttr("scaleratio", val);
        /// If this axis is linked to another by `scaleanchor`, this determines the pixel to unit scale ratio. For example, if this value is 10, then every unit on this axis spans 10 times the number of pixels as a unit on the linked axis. Use this for example to create an elevation profile where the vertical scale is exaggerated a fixed amount with respect to the horizontal.
        public static Box<IYaxisProperty> scaleratio(float val) => Interop.mkYaxisAttr("scaleratio", val);
        /// If set to another axis id (e.g. `x2`, `y`), the range of this axis will match the range of the corresponding axis in data-coordinates space. Moreover, matching axes share auto-range values, category lists and histogram auto-bins. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden. Moreover, note that matching axes must have the same `type`.
        public static Box<IYaxisProperty> matches(string val) => Interop.mkYaxisAttr("matches", val);
        /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
        public static Box<IYaxisProperty> nticks(int val) => Interop.mkYaxisAttr("nticks", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IYaxisProperty> tick0(bool val) => Interop.mkYaxisAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IYaxisProperty> tick0(params bool[] values) => Interop.mkYaxisAttr("tick0", values);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IYaxisProperty> tick0(System.DateTime val) => Interop.mkYaxisAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IYaxisProperty> tick0(params System.DateTime[] values) => Interop.mkYaxisAttr("tick0", values);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IYaxisProperty> tick0(int val) => Interop.mkYaxisAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IYaxisProperty> tick0(params int[] values) => Interop.mkYaxisAttr("tick0", values);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IYaxisProperty> tick0(float val) => Interop.mkYaxisAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IYaxisProperty> tick0(params float[] values) => Interop.mkYaxisAttr("tick0", values);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IYaxisProperty> tick0(string val) => Interop.mkYaxisAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IYaxisProperty> tick0(params string[] values) => Interop.mkYaxisAttr("tick0", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IYaxisProperty> dtick(bool val) => Interop.mkYaxisAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IYaxisProperty> dtick(params bool[] values) => Interop.mkYaxisAttr("dtick", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IYaxisProperty> dtick(System.DateTime val) => Interop.mkYaxisAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IYaxisProperty> dtick(params System.DateTime[] values) => Interop.mkYaxisAttr("dtick", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IYaxisProperty> dtick(int val) => Interop.mkYaxisAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IYaxisProperty> dtick(params int[] values) => Interop.mkYaxisAttr("dtick", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IYaxisProperty> dtick(float val) => Interop.mkYaxisAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IYaxisProperty> dtick(params float[] values) => Interop.mkYaxisAttr("dtick", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IYaxisProperty> dtick(string val) => Interop.mkYaxisAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IYaxisProperty> dtick(params string[] values) => Interop.mkYaxisAttr("dtick", values);
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IYaxisProperty> tickvals(bool val) => Interop.mkYaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IYaxisProperty> tickvals(IEnumerable<bool> values) => Interop.mkYaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IYaxisProperty> tickvals(System.DateTime val) => Interop.mkYaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IYaxisProperty> tickvals(IEnumerable<System.DateTime> values) => Interop.mkYaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IYaxisProperty> tickvals(float val) => Interop.mkYaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IYaxisProperty> tickvals(IEnumerable<float> values) => Interop.mkYaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IYaxisProperty> tickvals(int val) => Interop.mkYaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IYaxisProperty> tickvals(IEnumerable<int> values) => Interop.mkYaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IYaxisProperty> tickvals(string val) => Interop.mkYaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IYaxisProperty> tickvals(IEnumerable<string> values) => Interop.mkYaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IYaxisProperty> tickvals(IEnumerable<bool[]> values) => Interop.mkYaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IYaxisProperty> tickvals(List<bool[]> values) => Interop.mkYaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IYaxisProperty> tickvals(params bool[][] values) => Interop.mkYaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IYaxisProperty> tickvals(IEnumerable<IEnumerable<string>> values) => Interop.mkYaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IYaxisProperty> tickvals(List<string[]> values) => Interop.mkYaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IYaxisProperty> tickvals(params string[][] values) => Interop.mkYaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IYaxisProperty> tickvals(IEnumerable<IEnumerable<int>> values) => Interop.mkYaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IYaxisProperty> tickvals(List<int[]> values) => Interop.mkYaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IYaxisProperty> tickvals(params int[][] values) => Interop.mkYaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IYaxisProperty> tickvals(IEnumerable<IEnumerable<float>> values) => Interop.mkYaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IYaxisProperty> tickvals(List<float[]> values) => Interop.mkYaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IYaxisProperty> tickvals(params float[][] values) => Interop.mkYaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IYaxisProperty> tickvals(Literals.PlotData[] values) => Interop.mkYaxisAttr("tickvals", values);
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IYaxisProperty> tickvals(IEnumerable<bool?> values) => Interop.mkYaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IYaxisProperty> tickvals(IEnumerable<System.DateTime?> values) => Interop.mkYaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IYaxisProperty> tickvals(IEnumerable<int?> values) => Interop.mkYaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IYaxisProperty> tickvals(IEnumerable<float?> values) => Interop.mkYaxisAttr("tickvals", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IYaxisProperty> ticktext(bool val) => Interop.mkYaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IYaxisProperty> ticktext(IEnumerable<bool> values) => Interop.mkYaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IYaxisProperty> ticktext(System.DateTime val) => Interop.mkYaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IYaxisProperty> ticktext(IEnumerable<System.DateTime> values) => Interop.mkYaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IYaxisProperty> ticktext(float val) => Interop.mkYaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IYaxisProperty> ticktext(IEnumerable<float> values) => Interop.mkYaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IYaxisProperty> ticktext(int val) => Interop.mkYaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IYaxisProperty> ticktext(IEnumerable<int> values) => Interop.mkYaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IYaxisProperty> ticktext(string val) => Interop.mkYaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IYaxisProperty> ticktext(IEnumerable<string> values) => Interop.mkYaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IYaxisProperty> ticktext(IEnumerable<bool[]> values) => Interop.mkYaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IYaxisProperty> ticktext(List<bool[]> values) => Interop.mkYaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IYaxisProperty> ticktext(params bool[][] values) => Interop.mkYaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IYaxisProperty> ticktext(IEnumerable<IEnumerable<string>> values) => Interop.mkYaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IYaxisProperty> ticktext(List<string[]> values) => Interop.mkYaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IYaxisProperty> ticktext(params string[][] values) => Interop.mkYaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IYaxisProperty> ticktext(IEnumerable<IEnumerable<int>> values) => Interop.mkYaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IYaxisProperty> ticktext(List<int[]> values) => Interop.mkYaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IYaxisProperty> ticktext(params int[][] values) => Interop.mkYaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IYaxisProperty> ticktext(IEnumerable<IEnumerable<float>> values) => Interop.mkYaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IYaxisProperty> ticktext(List<float[]> values) => Interop.mkYaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IYaxisProperty> ticktext(params float[][] values) => Interop.mkYaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IYaxisProperty> ticktext(Literals.PlotData[] values) => Interop.mkYaxisAttr("ticktext", values);
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IYaxisProperty> ticktext(IEnumerable<bool?> values) => Interop.mkYaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IYaxisProperty> ticktext(IEnumerable<System.DateTime?> values) => Interop.mkYaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IYaxisProperty> ticktext(IEnumerable<int?> values) => Interop.mkYaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IYaxisProperty> ticktext(IEnumerable<float?> values) => Interop.mkYaxisAttr("ticktext", values.ToArray());
        /// Sets the tick length (in px).
        public static Box<IYaxisProperty> ticklen(int val) => Interop.mkYaxisAttr("ticklen", val);
        /// Sets the tick length (in px).
        public static Box<IYaxisProperty> ticklen(float val) => Interop.mkYaxisAttr("ticklen", val);
        /// Sets the tick width (in px).
        public static Box<IYaxisProperty> tickwidth(int val) => Interop.mkYaxisAttr("tickwidth", val);
        /// Sets the tick width (in px).
        public static Box<IYaxisProperty> tickwidth(float val) => Interop.mkYaxisAttr("tickwidth", val);
        /// Sets the tick color.
        public static Box<IYaxisProperty> tickcolor(string val) => Interop.mkYaxisAttr("tickcolor", val);
        /// Determines whether or not the tick labels are drawn.
        public static Box<IYaxisProperty> showticklabels(bool val) => Interop.mkYaxisAttr("showticklabels", val);
        /// Determines whether long tick labels automatically grow the figure margins.
        public static Box<IYaxisProperty> automargin(bool val) => Interop.mkYaxisAttr("automargin", val);
        /// Determines whether or not spikes (aka droplines) are drawn for this axis. Note: This only takes affect when hovermode = closest
        public static Box<IYaxisProperty> showspikes(bool val) => Interop.mkYaxisAttr("showspikes", val);
        /// Sets the spike color. If undefined, will use the series color
        public static Box<IYaxisProperty> spikecolor(string val) => Interop.mkYaxisAttr("spikecolor", val);
        /// Sets the width (in px) of the zero line.
        public static Box<IYaxisProperty> spikethickness(int val) => Interop.mkYaxisAttr("spikethickness", val);
        /// Sets the width (in px) of the zero line.
        public static Box<IYaxisProperty> spikethickness(float val) => Interop.mkYaxisAttr("spikethickness", val);
        /// Determines the drawing mode for the spike line If *toaxis*, the line is drawn from the data point to the axis the  series is plotted on. If *across*, the line is drawn across the entire plot area, and supercedes *toaxis*. If *marker*, then a marker dot is drawn on the axis the series is plotted on
        public static Box<IYaxisProperty> spikemode(params Box<IYaxisProperty>[] properties) => Interop.mkYaxisAttr("spikemode", Bindings.joinEnumProperties(properties));
        /// Sets the tick font.
        public static Box<IYaxisProperty> tickfont(params Box<ITickfontProperty>[] properties) => Interop.mkYaxisAttr("tickfont", Bindings.flattenProperties(properties));
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        public static Box<IYaxisProperty> tickangle(int val) => Interop.mkYaxisAttr("tickangle", val);
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        public static Box<IYaxisProperty> tickangle(float val) => Interop.mkYaxisAttr("tickangle", val);
        /// Sets a tick label prefix.
        public static Box<IYaxisProperty> tickprefix(string val) => Interop.mkYaxisAttr("tickprefix", val);
        /// Sets a tick label suffix.
        public static Box<IYaxisProperty> ticksuffix(string val) => Interop.mkYaxisAttr("ticksuffix", val);
        /// If \"true\", even 4-digit integers are separated
        public static Box<IYaxisProperty> separatethousands(bool val) => Interop.mkYaxisAttr("separatethousands", val);
        /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        public static Box<IYaxisProperty> tickformat(string val) => Interop.mkYaxisAttr("tickformat", val);
        public static Box<IYaxisProperty> tickformatstops(params Box<ITickformatstopsProperty>[] properties) => Interop.mkYaxisAttr("tickformatstops", Bindings.flattenProperties(properties));
        /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        public static Box<IYaxisProperty> hoverformat(string val) => Interop.mkYaxisAttr("hoverformat", val);
        /// Determines whether or not a line bounding this axis is drawn.
        public static Box<IYaxisProperty> showline(bool val) => Interop.mkYaxisAttr("showline", val);
        /// Sets the axis line color.
        public static Box<IYaxisProperty> linecolor(string val) => Interop.mkYaxisAttr("linecolor", val);
        /// Sets the width (in px) of the axis line.
        public static Box<IYaxisProperty> linewidth(int val) => Interop.mkYaxisAttr("linewidth", val);
        /// Sets the width (in px) of the axis line.
        public static Box<IYaxisProperty> linewidth(float val) => Interop.mkYaxisAttr("linewidth", val);
        /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
        public static Box<IYaxisProperty> showgrid(bool val) => Interop.mkYaxisAttr("showgrid", val);
        /// Sets the color of the grid lines.
        public static Box<IYaxisProperty> gridcolor(string val) => Interop.mkYaxisAttr("gridcolor", val);
        /// Sets the width (in px) of the grid lines.
        public static Box<IYaxisProperty> gridwidth(int val) => Interop.mkYaxisAttr("gridwidth", val);
        /// Sets the width (in px) of the grid lines.
        public static Box<IYaxisProperty> gridwidth(float val) => Interop.mkYaxisAttr("gridwidth", val);
        /// Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines.
        public static Box<IYaxisProperty> zeroline(bool val) => Interop.mkYaxisAttr("zeroline", val);
        /// Sets the line color of the zero line.
        public static Box<IYaxisProperty> zerolinecolor(string val) => Interop.mkYaxisAttr("zerolinecolor", val);
        /// Sets the width (in px) of the zero line.
        public static Box<IYaxisProperty> zerolinewidth(int val) => Interop.mkYaxisAttr("zerolinewidth", val);
        /// Sets the width (in px) of the zero line.
        public static Box<IYaxisProperty> zerolinewidth(float val) => Interop.mkYaxisAttr("zerolinewidth", val);
        /// Determines whether or not a dividers are drawn between the category levels of this axis. Only has an effect on *multicategory* axes.
        public static Box<IYaxisProperty> showdividers(bool val) => Interop.mkYaxisAttr("showdividers", val);
        /// Sets the color of the dividers Only has an effect on *multicategory* axes.
        public static Box<IYaxisProperty> dividercolor(string val) => Interop.mkYaxisAttr("dividercolor", val);
        /// Sets the width (in px) of the dividers Only has an effect on *multicategory* axes.
        public static Box<IYaxisProperty> dividerwidth(int val) => Interop.mkYaxisAttr("dividerwidth", val);
        /// Sets the width (in px) of the dividers Only has an effect on *multicategory* axes.
        public static Box<IYaxisProperty> dividerwidth(float val) => Interop.mkYaxisAttr("dividerwidth", val);
        /// Sets the domain of this axis (in plot fraction).
        public static Box<IYaxisProperty> domain(int val) => Interop.mkYaxisAttr("domain", new[]{val});
        /// Sets the domain of this axis (in plot fraction).
        public static Box<IYaxisProperty> domain(IEnumerable<int> values) => Interop.mkYaxisAttr("domain", values.ToArray());
        /// Sets the domain of this axis (in plot fraction).
        public static Box<IYaxisProperty> domain(float val) => Interop.mkYaxisAttr("domain", new[]{val});
        /// Sets the domain of this axis (in plot fraction).
        public static Box<IYaxisProperty> domain(IEnumerable<float> values) => Interop.mkYaxisAttr("domain", values.ToArray());
        /// Sets the position of this axis in the plotting space (in normalized coordinates). Only has an effect if `anchor` is set to *free*.
        public static Box<IYaxisProperty> position(int val) => Interop.mkYaxisAttr("position", val);
        /// Sets the position of this axis in the plotting space (in normalized coordinates). Only has an effect if `anchor` is set to *free*.
        public static Box<IYaxisProperty> position(float val) => Interop.mkYaxisAttr("position", val);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IYaxisProperty> categoryarray(bool val) => Interop.mkYaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IYaxisProperty> categoryarray(params bool[] values) => Interop.mkYaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IYaxisProperty> categoryarray(System.DateTime val) => Interop.mkYaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IYaxisProperty> categoryarray(params System.DateTime[] values) => Interop.mkYaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IYaxisProperty> categoryarray(float val) => Interop.mkYaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IYaxisProperty> categoryarray(params float[] values) => Interop.mkYaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IYaxisProperty> categoryarray(int val) => Interop.mkYaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IYaxisProperty> categoryarray(params int[] values) => Interop.mkYaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IYaxisProperty> categoryarray(string val) => Interop.mkYaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IYaxisProperty> categoryarray(params string[] values) => Interop.mkYaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IYaxisProperty> categoryarray(IEnumerable<bool[]> values) => Interop.mkYaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IYaxisProperty> categoryarray(List<bool[]> values) => Interop.mkYaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IYaxisProperty> categoryarray(params bool[][] values) => Interop.mkYaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IYaxisProperty> categoryarray(IEnumerable<IEnumerable<string>> values) => Interop.mkYaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IYaxisProperty> categoryarray(List<string[]> values) => Interop.mkYaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IYaxisProperty> categoryarray(params string[][] values) => Interop.mkYaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IYaxisProperty> categoryarray(IEnumerable<IEnumerable<int>> values) => Interop.mkYaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IYaxisProperty> categoryarray(List<int[]> values) => Interop.mkYaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IYaxisProperty> categoryarray(params int[][] values) => Interop.mkYaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IYaxisProperty> categoryarray(IEnumerable<IEnumerable<float>> values) => Interop.mkYaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IYaxisProperty> categoryarray(List<float[]> values) => Interop.mkYaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IYaxisProperty> categoryarray(params float[][] values) => Interop.mkYaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IYaxisProperty> categoryarray(Literals.PlotData[] values) => Interop.mkYaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IYaxisProperty> categoryarray(IEnumerable<bool?> values) => Interop.mkYaxisAttr("categoryarray", values.ToArray());
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IYaxisProperty> categoryarray(IEnumerable<System.DateTime?> values) => Interop.mkYaxisAttr("categoryarray", values.ToArray());
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IYaxisProperty> categoryarray(IEnumerable<int?> values) => Interop.mkYaxisAttr("categoryarray", values.ToArray());
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IYaxisProperty> categoryarray(IEnumerable<float?> values) => Interop.mkYaxisAttr("categoryarray", values.ToArray());
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        public static Box<IYaxisProperty> uirevision(bool val) => Interop.mkYaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        public static Box<IYaxisProperty> uirevision(params bool[] values) => Interop.mkYaxisAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        public static Box<IYaxisProperty> uirevision(System.DateTime val) => Interop.mkYaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        public static Box<IYaxisProperty> uirevision(params System.DateTime[] values) => Interop.mkYaxisAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        public static Box<IYaxisProperty> uirevision(int val) => Interop.mkYaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        public static Box<IYaxisProperty> uirevision(params int[] values) => Interop.mkYaxisAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        public static Box<IYaxisProperty> uirevision(float val) => Interop.mkYaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        public static Box<IYaxisProperty> uirevision(params float[] values) => Interop.mkYaxisAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        public static Box<IYaxisProperty> uirevision(string val) => Interop.mkYaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, and `title` if in `editable: true` configuration. Defaults to `layout.uirevision`.
        public static Box<IYaxisProperty> uirevision(params string[] values) => Interop.mkYaxisAttr("uirevision", values);
        /// Sets the source reference on plot.ly for  tickvals .
        public static Box<IYaxisProperty> tickvalssrc(string val) => Interop.mkYaxisAttr("tickvalssrc", val);
        /// Sets the source reference on plot.ly for  ticktext .
        public static Box<IYaxisProperty> ticktextsrc(string val) => Interop.mkYaxisAttr("ticktextsrc", val);
        /// Sets the source reference on plot.ly for  categoryarray .
        public static Box<IYaxisProperty> categoryarraysrc(string val) => Interop.mkYaxisAttr("categoryarraysrc", val);
        /// Sets whether or not spikes extending from the projection data points to this axis' wall boundaries are shown on hover.
        public static Box<IYaxisProperty> spikesides(bool val) => Interop.mkYaxisAttr("spikesides", val);
        /// Sets whether or not this axis' wall has a background color.
        public static Box<IYaxisProperty> showbackground(bool val) => Interop.mkYaxisAttr("showbackground", val);
        /// Sets the background color of this axis' wall.
        public static Box<IYaxisProperty> backgroundcolor(string val) => Interop.mkYaxisAttr("backgroundcolor", val);
        /// Sets whether or not this axis is labeled
        public static Box<IYaxisProperty> showaxeslabels(bool val) => Interop.mkYaxisAttr("showaxeslabels", val);
    }

    public static partial class Yaxis
    {
        /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
        public static partial class _type
        {
            public static Box<IYaxisProperty> dash() => Interop.mkYaxisAttr("type", "-");
            public static Box<IYaxisProperty> category() => Interop.mkYaxisAttr("type", "category");
            public static Box<IYaxisProperty> date() => Interop.mkYaxisAttr("type", "date");
            public static Box<IYaxisProperty> linear() => Interop.mkYaxisAttr("type", "linear");
            public static Box<IYaxisProperty> log() => Interop.mkYaxisAttr("type", "log");
            public static Box<IYaxisProperty> multicategory() => Interop.mkYaxisAttr("type", "multicategory");
        }

        /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
        public static partial class Autorange
        {
            public static Box<IYaxisProperty> reversed() => Interop.mkYaxisAttr("autorange", "reversed");
            public static Box<IYaxisProperty> _false() => Interop.mkYaxisAttr("autorange", false);
            public static Box<IYaxisProperty> _true() => Interop.mkYaxisAttr("autorange", true);
        }

        /// If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes.
        public static partial class Rangemode
        {
            public static Box<IYaxisProperty> auto() => Interop.mkYaxisAttr("rangemode", "auto");
            public static Box<IYaxisProperty> _fixed() => Interop.mkYaxisAttr("rangemode", "fixed");
            public static Box<IYaxisProperty> _match() => Interop.mkYaxisAttr("rangemode", "match");
            public static Box<IYaxisProperty> nonnegative() => Interop.mkYaxisAttr("rangemode", "nonnegative");
            public static Box<IYaxisProperty> normal() => Interop.mkYaxisAttr("rangemode", "normal");
            public static Box<IYaxisProperty> tozero() => Interop.mkYaxisAttr("rangemode", "tozero");
        }

        /// If set to another axis id (e.g. `x2`, `y`), the range of this axis changes together with the range of the corresponding axis such that the scale of pixels per unit is in a constant ratio. Both axes are still zoomable, but when you zoom one, the other will zoom the same amount, keeping a fixed midpoint. `constrain` and `constraintoward` determine how we enforce the constraint. You can chain these, ie `yaxis: {scaleanchor: *x*}, xaxis2: {scaleanchor: *y*}` but you can only link axes of the same `type`. The linked axis can have the opposite letter (to constrain the aspect ratio) or the same letter (to match scales across subplots). Loops (`yaxis: {scaleanchor: *x*}, xaxis: {scaleanchor: *y*}` or longer) are redundant and the last constraint encountered will be ignored to avoid possible inconsistent constraints via `scaleratio`. Note that setting axes simultaneously in both a `scaleanchor` and a `matches` constraint is currently forbidden.
        public static partial class Scaleanchor
        {
            public static Box<IYaxisProperty> custom(string val) => Interop.mkYaxisAttr("scaleanchor", val);
            public static Box<IYaxisProperty> x(int anchorId) => Interop.mkYaxisAttr("scaleanchor", anchorId > 1 ? $"x{anchorId}" : "");
            public static Box<IYaxisProperty> y(int anchorId) => Interop.mkYaxisAttr("scaleanchor", anchorId > 1 ? $"y{anchorId}" : "");
        }

        /// If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines how that happens: by increasing the *range* (default), or by decreasing the *domain*.
        public static partial class Constrain
        {
            public static Box<IYaxisProperty> domain() => Interop.mkYaxisAttr("constrain", "domain");
            public static Box<IYaxisProperty> range() => Interop.mkYaxisAttr("constrain", "range");
        }

        /// If this axis needs to be compressed (either due to its own `scaleanchor` and `scaleratio` or those of the other axis), determines which direction we push the originally specified plot area. Options are *left*, *center* (default), and *right* for x axes, and *top*, *middle* (default), and *bottom* for y axes.
        public static partial class Constraintoward
        {
            public static Box<IYaxisProperty> bottom() => Interop.mkYaxisAttr("constraintoward", "bottom");
            public static Box<IYaxisProperty> center() => Interop.mkYaxisAttr("constraintoward", "center");
            public static Box<IYaxisProperty> left() => Interop.mkYaxisAttr("constraintoward", "left");
            public static Box<IYaxisProperty> middle() => Interop.mkYaxisAttr("constraintoward", "middle");
            public static Box<IYaxisProperty> right() => Interop.mkYaxisAttr("constraintoward", "right");
            public static Box<IYaxisProperty> top() => Interop.mkYaxisAttr("constraintoward", "top");
        }

        /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
        public static partial class Tickmode
        {
            public static Box<IYaxisProperty> array() => Interop.mkYaxisAttr("tickmode", "array");
            public static Box<IYaxisProperty> auto() => Interop.mkYaxisAttr("tickmode", "auto");
            public static Box<IYaxisProperty> linear() => Interop.mkYaxisAttr("tickmode", "linear");
        }

        /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
        public static partial class Ticks
        {
            public static Box<IYaxisProperty> none() => Interop.mkYaxisAttr("ticks", "");
            public static Box<IYaxisProperty> inside() => Interop.mkYaxisAttr("ticks", "inside");
            public static Box<IYaxisProperty> outside() => Interop.mkYaxisAttr("ticks", "outside");
        }

        /// Determines where ticks and grid lines are drawn with respect to their corresponding tick labels. Only has an effect for axes of `type` *category* or *multicategory*. When set to *boundaries*, ticks and grid lines are drawn half a category to the left/bottom of labels.
        public static partial class Tickson
        {
            public static Box<IYaxisProperty> boundaries() => Interop.mkYaxisAttr("tickson", "boundaries");
            public static Box<IYaxisProperty> labels() => Interop.mkYaxisAttr("tickson", "labels");
        }

        /// Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots.
        public static partial class Mirror
        {
            public static Box<IYaxisProperty> all() => Interop.mkYaxisAttr("mirror", "all");
            public static Box<IYaxisProperty> allticks() => Interop.mkYaxisAttr("mirror", "allticks");
            public static Box<IYaxisProperty> ticks() => Interop.mkYaxisAttr("mirror", "ticks");
            public static Box<IYaxisProperty> _false() => Interop.mkYaxisAttr("mirror", false);
            public static Box<IYaxisProperty> _true() => Interop.mkYaxisAttr("mirror", true);
        }

        /// Sets the dash style of lines. Set to a dash type string (*solid*, *dot*, *dash*, *longdash*, *dashdot*, or *longdashdot*) or a dash length list in px (eg *5px,10px,2px,2px*).
        public static partial class Spikedash
        {
            public static Box<IYaxisProperty> dash() => Interop.mkYaxisAttr("spikedash", "dash");
            public static Box<IYaxisProperty> dashdot() => Interop.mkYaxisAttr("spikedash", "dashdot");
            public static Box<IYaxisProperty> dot() => Interop.mkYaxisAttr("spikedash", "dot");
            public static Box<IYaxisProperty> longdash() => Interop.mkYaxisAttr("spikedash", "longdash");
            public static Box<IYaxisProperty> longdashdot() => Interop.mkYaxisAttr("spikedash", "longdashdot");
            public static Box<IYaxisProperty> solid() => Interop.mkYaxisAttr("spikedash", "solid");
            public static Box<IYaxisProperty> custom(string val) => Interop.mkYaxisAttr("spikedash", val);
        }

        /// Determines the drawing mode for the spike line If *toaxis*, the line is drawn from the data point to the axis the  series is plotted on. If *across*, the line is drawn across the entire plot area, and supercedes *toaxis*. If *marker*, then a marker dot is drawn on the axis the series is plotted on
        public static partial class Spikemode
        {
            public static Box<IYaxisProperty> across() => Interop.mkYaxisAttr("spikemode", "across");
            public static Box<IYaxisProperty> marker() => Interop.mkYaxisAttr("spikemode", "marker");
            public static Box<IYaxisProperty> toaxis() => Interop.mkYaxisAttr("spikemode", "toaxis");
        }

        /// Determines whether spikelines are stuck to the cursor or to the closest datapoints.
        public static partial class Spikesnap
        {
            public static Box<IYaxisProperty> cursor() => Interop.mkYaxisAttr("spikesnap", "cursor");
            public static Box<IYaxisProperty> data() => Interop.mkYaxisAttr("spikesnap", "data");
        }

        /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
        public static partial class Showtickprefix
        {
            public static Box<IYaxisProperty> all() => Interop.mkYaxisAttr("showtickprefix", "all");
            public static Box<IYaxisProperty> first() => Interop.mkYaxisAttr("showtickprefix", "first");
            public static Box<IYaxisProperty> last() => Interop.mkYaxisAttr("showtickprefix", "last");
            public static Box<IYaxisProperty> none() => Interop.mkYaxisAttr("showtickprefix", "none");
        }

        /// Same as `showtickprefix` but for tick suffixes.
        public static partial class Showticksuffix
        {
            public static Box<IYaxisProperty> all() => Interop.mkYaxisAttr("showticksuffix", "all");
            public static Box<IYaxisProperty> first() => Interop.mkYaxisAttr("showticksuffix", "first");
            public static Box<IYaxisProperty> last() => Interop.mkYaxisAttr("showticksuffix", "last");
            public static Box<IYaxisProperty> none() => Interop.mkYaxisAttr("showticksuffix", "none");
        }

        /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
        public static partial class Showexponent
        {
            public static Box<IYaxisProperty> all() => Interop.mkYaxisAttr("showexponent", "all");
            public static Box<IYaxisProperty> first() => Interop.mkYaxisAttr("showexponent", "first");
            public static Box<IYaxisProperty> last() => Interop.mkYaxisAttr("showexponent", "last");
            public static Box<IYaxisProperty> none() => Interop.mkYaxisAttr("showexponent", "none");
        }

        /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
        public static partial class Exponentformat
        {
            public static Box<IYaxisProperty> B() => Interop.mkYaxisAttr("exponentformat", "B");
            public static Box<IYaxisProperty> E() => Interop.mkYaxisAttr("exponentformat", "E");
            public static Box<IYaxisProperty> SI() => Interop.mkYaxisAttr("exponentformat", "SI");
            public static Box<IYaxisProperty> e() => Interop.mkYaxisAttr("exponentformat", "e");
            public static Box<IYaxisProperty> none() => Interop.mkYaxisAttr("exponentformat", "none");
            public static Box<IYaxisProperty> power() => Interop.mkYaxisAttr("exponentformat", "power");
        }

        /// If set to an opposite-letter axis id (e.g. `x2`, `y`), this axis is bound to the corresponding opposite-letter axis. If set to *free*, this axis' position is determined by `position`.
        public static partial class Anchor
        {
            public static Box<IYaxisProperty> free() => Interop.mkYaxisAttr("anchor", "free");
            public static Box<IYaxisProperty> custom(string val) => Interop.mkYaxisAttr("anchor", val);
            public static Box<IYaxisProperty> x(int anchorId) => Interop.mkYaxisAttr("anchor", anchorId > 1 ? $"x{anchorId}" : "");
            public static Box<IYaxisProperty> y(int anchorId) => Interop.mkYaxisAttr("anchor", anchorId > 1 ? $"y{anchorId}" : "");
        }

        /// Determines whether a x (y) axis is positioned at the *bottom* (*left*) or *top* (*right*) of the plotting area.
        public static partial class Side
        {
            public static Box<IYaxisProperty> bottom() => Interop.mkYaxisAttr("side", "bottom");
            public static Box<IYaxisProperty> left() => Interop.mkYaxisAttr("side", "left");
            public static Box<IYaxisProperty> right() => Interop.mkYaxisAttr("side", "right");
            public static Box<IYaxisProperty> top() => Interop.mkYaxisAttr("side", "top");
        }

        /// If set a same-letter axis id, this axis is overlaid on top of the corresponding same-letter axis, with traces and axes visible for both axes. If *false*, this axis does not overlay any same-letter axes. In this case, for axes with overlapping domains only the highest-numbered axis will be visible.
        public static partial class Overlaying
        {
            public static Box<IYaxisProperty> free() => Interop.mkYaxisAttr("overlaying", "free");
            public static Box<IYaxisProperty> custom(string val) => Interop.mkYaxisAttr("overlaying", val);
            public static Box<IYaxisProperty> x(int anchorId) => Interop.mkYaxisAttr("overlaying", anchorId > 1 ? $"x{anchorId}" : "");
            public static Box<IYaxisProperty> y(int anchorId) => Interop.mkYaxisAttr("overlaying", anchorId > 1 ? $"y{anchorId}" : "");
        }

        /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
        public static partial class Layer
        {
            public static Box<IYaxisProperty> aboveTraces() => Interop.mkYaxisAttr("layer", "above traces");
            public static Box<IYaxisProperty> belowTraces() => Interop.mkYaxisAttr("layer", "below traces");
        }

        /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
        public static partial class Categoryorder
        {
            public static Box<IYaxisProperty> array() => Interop.mkYaxisAttr("categoryorder", "array");
            public static Box<IYaxisProperty> categoryAscending() => Interop.mkYaxisAttr("categoryorder", "category ascending");
            public static Box<IYaxisProperty> categoryDescending() => Interop.mkYaxisAttr("categoryorder", "category descending");
            public static Box<IYaxisProperty> maxAscending() => Interop.mkYaxisAttr("categoryorder", "max ascending");
            public static Box<IYaxisProperty> maxDescending() => Interop.mkYaxisAttr("categoryorder", "max descending");
            public static Box<IYaxisProperty> meanAscending() => Interop.mkYaxisAttr("categoryorder", "mean ascending");
            public static Box<IYaxisProperty> meanDescending() => Interop.mkYaxisAttr("categoryorder", "mean descending");
            public static Box<IYaxisProperty> medianAscending() => Interop.mkYaxisAttr("categoryorder", "median ascending");
            public static Box<IYaxisProperty> medianDescending() => Interop.mkYaxisAttr("categoryorder", "median descending");
            public static Box<IYaxisProperty> minAscending() => Interop.mkYaxisAttr("categoryorder", "min ascending");
            public static Box<IYaxisProperty> minDescending() => Interop.mkYaxisAttr("categoryorder", "min descending");
            public static Box<IYaxisProperty> sumAscending() => Interop.mkYaxisAttr("categoryorder", "sum ascending");
            public static Box<IYaxisProperty> sumDescending() => Interop.mkYaxisAttr("categoryorder", "sum descending");
            public static Box<IYaxisProperty> totalAscending() => Interop.mkYaxisAttr("categoryorder", "total ascending");
            public static Box<IYaxisProperty> totalDescending() => Interop.mkYaxisAttr("categoryorder", "total descending");
            public static Box<IYaxisProperty> trace() => Interop.mkYaxisAttr("categoryorder", "trace");
        }

        /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
        public static partial class Calendar
        {
            public static Box<IYaxisProperty> chinese() => Interop.mkYaxisAttr("calendar", "chinese");
            public static Box<IYaxisProperty> coptic() => Interop.mkYaxisAttr("calendar", "coptic");
            public static Box<IYaxisProperty> discworld() => Interop.mkYaxisAttr("calendar", "discworld");
            public static Box<IYaxisProperty> ethiopian() => Interop.mkYaxisAttr("calendar", "ethiopian");
            public static Box<IYaxisProperty> gregorian() => Interop.mkYaxisAttr("calendar", "gregorian");
            public static Box<IYaxisProperty> hebrew() => Interop.mkYaxisAttr("calendar", "hebrew");
            public static Box<IYaxisProperty> islamic() => Interop.mkYaxisAttr("calendar", "islamic");
            public static Box<IYaxisProperty> jalali() => Interop.mkYaxisAttr("calendar", "jalali");
            public static Box<IYaxisProperty> julian() => Interop.mkYaxisAttr("calendar", "julian");
            public static Box<IYaxisProperty> mayan() => Interop.mkYaxisAttr("calendar", "mayan");
            public static Box<IYaxisProperty> nanakshahi() => Interop.mkYaxisAttr("calendar", "nanakshahi");
            public static Box<IYaxisProperty> nepali() => Interop.mkYaxisAttr("calendar", "nepali");
            public static Box<IYaxisProperty> persian() => Interop.mkYaxisAttr("calendar", "persian");
            public static Box<IYaxisProperty> taiwan() => Interop.mkYaxisAttr("calendar", "taiwan");
            public static Box<IYaxisProperty> thai() => Interop.mkYaxisAttr("calendar", "thai");
            public static Box<IYaxisProperty> ummalqura() => Interop.mkYaxisAttr("calendar", "ummalqura");
        }
    }
}