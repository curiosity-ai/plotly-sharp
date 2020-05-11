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

    public static partial class Colorbar
    {
        /// Sets the thickness of the color bar This measure excludes the size of the padding, ticks and labels.
        public static Box<IColorbarProperty> thickness(int val) => Interop.mkColorbarAttr("thickness", val);
        /// Sets the thickness of the color bar This measure excludes the size of the padding, ticks and labels.
        public static Box<IColorbarProperty> thickness(float val) => Interop.mkColorbarAttr("thickness", val);
        /// Sets the length of the color bar This measure excludes the padding of both ends. That is, the color bar length is this length minus the padding on both ends.
        public static Box<IColorbarProperty> len(int val) => Interop.mkColorbarAttr("len", val);
        /// Sets the length of the color bar This measure excludes the padding of both ends. That is, the color bar length is this length minus the padding on both ends.
        public static Box<IColorbarProperty> len(float val) => Interop.mkColorbarAttr("len", val);
        /// Sets the x position of the color bar (in plot fraction).
        public static Box<IColorbarProperty> x(int val) => Interop.mkColorbarAttr("x", val);
        /// Sets the x position of the color bar (in plot fraction).
        public static Box<IColorbarProperty> x(float val) => Interop.mkColorbarAttr("x", val);
        /// Sets the amount of padding (in px) along the x direction.
        public static Box<IColorbarProperty> xpad(int val) => Interop.mkColorbarAttr("xpad", val);
        /// Sets the amount of padding (in px) along the x direction.
        public static Box<IColorbarProperty> xpad(float val) => Interop.mkColorbarAttr("xpad", val);
        /// Sets the y position of the color bar (in plot fraction).
        public static Box<IColorbarProperty> y(int val) => Interop.mkColorbarAttr("y", val);
        /// Sets the y position of the color bar (in plot fraction).
        public static Box<IColorbarProperty> y(float val) => Interop.mkColorbarAttr("y", val);
        /// Sets the amount of padding (in px) along the y direction.
        public static Box<IColorbarProperty> ypad(int val) => Interop.mkColorbarAttr("ypad", val);
        /// Sets the amount of padding (in px) along the y direction.
        public static Box<IColorbarProperty> ypad(float val) => Interop.mkColorbarAttr("ypad", val);
        /// Sets the axis line color.
        public static Box<IColorbarProperty> outlinecolor(string val) => Interop.mkColorbarAttr("outlinecolor", val);
        /// Sets the width (in px) of the axis line.
        public static Box<IColorbarProperty> outlinewidth(int val) => Interop.mkColorbarAttr("outlinewidth", val);
        /// Sets the width (in px) of the axis line.
        public static Box<IColorbarProperty> outlinewidth(float val) => Interop.mkColorbarAttr("outlinewidth", val);
        /// Sets the axis line color.
        public static Box<IColorbarProperty> bordercolor(string val) => Interop.mkColorbarAttr("bordercolor", val);
        /// Sets the width (in px) or the border enclosing this color bar.
        public static Box<IColorbarProperty> borderwidth(int val) => Interop.mkColorbarAttr("borderwidth", val);
        /// Sets the width (in px) or the border enclosing this color bar.
        public static Box<IColorbarProperty> borderwidth(float val) => Interop.mkColorbarAttr("borderwidth", val);
        /// Sets the color of padded area.
        public static Box<IColorbarProperty> bgcolor(string val) => Interop.mkColorbarAttr("bgcolor", val);
        /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
        public static Box<IColorbarProperty> nticks(int val) => Interop.mkColorbarAttr("nticks", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IColorbarProperty> tick0(bool val) => Interop.mkColorbarAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IColorbarProperty> tick0(params bool[] values) => Interop.mkColorbarAttr("tick0", values);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IColorbarProperty> tick0(System.DateTime val) => Interop.mkColorbarAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IColorbarProperty> tick0(params System.DateTime[] values) => Interop.mkColorbarAttr("tick0", values);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IColorbarProperty> tick0(int val) => Interop.mkColorbarAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IColorbarProperty> tick0(params int[] values) => Interop.mkColorbarAttr("tick0", values);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IColorbarProperty> tick0(float val) => Interop.mkColorbarAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IColorbarProperty> tick0(params float[] values) => Interop.mkColorbarAttr("tick0", values);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IColorbarProperty> tick0(string val) => Interop.mkColorbarAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IColorbarProperty> tick0(params string[] values) => Interop.mkColorbarAttr("tick0", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IColorbarProperty> dtick(bool val) => Interop.mkColorbarAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IColorbarProperty> dtick(params bool[] values) => Interop.mkColorbarAttr("dtick", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IColorbarProperty> dtick(System.DateTime val) => Interop.mkColorbarAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IColorbarProperty> dtick(params System.DateTime[] values) => Interop.mkColorbarAttr("dtick", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IColorbarProperty> dtick(int val) => Interop.mkColorbarAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IColorbarProperty> dtick(params int[] values) => Interop.mkColorbarAttr("dtick", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IColorbarProperty> dtick(float val) => Interop.mkColorbarAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IColorbarProperty> dtick(params float[] values) => Interop.mkColorbarAttr("dtick", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IColorbarProperty> dtick(string val) => Interop.mkColorbarAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IColorbarProperty> dtick(params string[] values) => Interop.mkColorbarAttr("dtick", values);
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IColorbarProperty> tickvals(bool val) => Interop.mkColorbarAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IColorbarProperty> tickvals(IEnumerable<bool> values) => Interop.mkColorbarAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IColorbarProperty> tickvals(System.DateTime val) => Interop.mkColorbarAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IColorbarProperty> tickvals(IEnumerable<System.DateTime> values) => Interop.mkColorbarAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IColorbarProperty> tickvals(float val) => Interop.mkColorbarAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IColorbarProperty> tickvals(IEnumerable<float> values) => Interop.mkColorbarAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IColorbarProperty> tickvals(int val) => Interop.mkColorbarAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IColorbarProperty> tickvals(IEnumerable<int> values) => Interop.mkColorbarAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IColorbarProperty> tickvals(string val) => Interop.mkColorbarAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IColorbarProperty> tickvals(IEnumerable<string> values) => Interop.mkColorbarAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IColorbarProperty> tickvals(IEnumerable<bool[]> values) => Interop.mkColorbarAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IColorbarProperty> tickvals(List<bool[]> values) => Interop.mkColorbarAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IColorbarProperty> tickvals(params bool[][] values) => Interop.mkColorbarAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IColorbarProperty> tickvals(IEnumerable<IEnumerable<string>> values) => Interop.mkColorbarAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IColorbarProperty> tickvals(List<string[]> values) => Interop.mkColorbarAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IColorbarProperty> tickvals(params string[][] values) => Interop.mkColorbarAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IColorbarProperty> tickvals(IEnumerable<IEnumerable<int>> values) => Interop.mkColorbarAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IColorbarProperty> tickvals(List<int[]> values) => Interop.mkColorbarAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IColorbarProperty> tickvals(params int[][] values) => Interop.mkColorbarAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IColorbarProperty> tickvals(IEnumerable<IEnumerable<float>> values) => Interop.mkColorbarAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IColorbarProperty> tickvals(List<float[]> values) => Interop.mkColorbarAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IColorbarProperty> tickvals(params float[][] values) => Interop.mkColorbarAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IColorbarProperty> tickvals(Literals.PlotData[] values) => Interop.mkColorbarAttr("tickvals", values);
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IColorbarProperty> tickvals(IEnumerable<bool?> values) => Interop.mkColorbarAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IColorbarProperty> tickvals(IEnumerable<System.DateTime?> values) => Interop.mkColorbarAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IColorbarProperty> tickvals(IEnumerable<int?> values) => Interop.mkColorbarAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IColorbarProperty> tickvals(IEnumerable<float?> values) => Interop.mkColorbarAttr("tickvals", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IColorbarProperty> ticktext(bool val) => Interop.mkColorbarAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IColorbarProperty> ticktext(IEnumerable<bool> values) => Interop.mkColorbarAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IColorbarProperty> ticktext(System.DateTime val) => Interop.mkColorbarAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IColorbarProperty> ticktext(IEnumerable<System.DateTime> values) => Interop.mkColorbarAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IColorbarProperty> ticktext(float val) => Interop.mkColorbarAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IColorbarProperty> ticktext(IEnumerable<float> values) => Interop.mkColorbarAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IColorbarProperty> ticktext(int val) => Interop.mkColorbarAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IColorbarProperty> ticktext(IEnumerable<int> values) => Interop.mkColorbarAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IColorbarProperty> ticktext(string val) => Interop.mkColorbarAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IColorbarProperty> ticktext(IEnumerable<string> values) => Interop.mkColorbarAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IColorbarProperty> ticktext(IEnumerable<bool[]> values) => Interop.mkColorbarAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IColorbarProperty> ticktext(List<bool[]> values) => Interop.mkColorbarAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IColorbarProperty> ticktext(params bool[][] values) => Interop.mkColorbarAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IColorbarProperty> ticktext(IEnumerable<IEnumerable<string>> values) => Interop.mkColorbarAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IColorbarProperty> ticktext(List<string[]> values) => Interop.mkColorbarAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IColorbarProperty> ticktext(params string[][] values) => Interop.mkColorbarAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IColorbarProperty> ticktext(IEnumerable<IEnumerable<int>> values) => Interop.mkColorbarAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IColorbarProperty> ticktext(List<int[]> values) => Interop.mkColorbarAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IColorbarProperty> ticktext(params int[][] values) => Interop.mkColorbarAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IColorbarProperty> ticktext(IEnumerable<IEnumerable<float>> values) => Interop.mkColorbarAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IColorbarProperty> ticktext(List<float[]> values) => Interop.mkColorbarAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IColorbarProperty> ticktext(params float[][] values) => Interop.mkColorbarAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IColorbarProperty> ticktext(Literals.PlotData[] values) => Interop.mkColorbarAttr("ticktext", values);
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IColorbarProperty> ticktext(IEnumerable<bool?> values) => Interop.mkColorbarAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IColorbarProperty> ticktext(IEnumerable<System.DateTime?> values) => Interop.mkColorbarAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IColorbarProperty> ticktext(IEnumerable<int?> values) => Interop.mkColorbarAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IColorbarProperty> ticktext(IEnumerable<float?> values) => Interop.mkColorbarAttr("ticktext", values.ToArray());
        /// Sets the tick length (in px).
        public static Box<IColorbarProperty> ticklen(int val) => Interop.mkColorbarAttr("ticklen", val);
        /// Sets the tick length (in px).
        public static Box<IColorbarProperty> ticklen(float val) => Interop.mkColorbarAttr("ticklen", val);
        /// Sets the tick width (in px).
        public static Box<IColorbarProperty> tickwidth(int val) => Interop.mkColorbarAttr("tickwidth", val);
        /// Sets the tick width (in px).
        public static Box<IColorbarProperty> tickwidth(float val) => Interop.mkColorbarAttr("tickwidth", val);
        /// Sets the tick color.
        public static Box<IColorbarProperty> tickcolor(string val) => Interop.mkColorbarAttr("tickcolor", val);
        /// Determines whether or not the tick labels are drawn.
        public static Box<IColorbarProperty> showticklabels(bool val) => Interop.mkColorbarAttr("showticklabels", val);
        /// Sets the color bar's tick label font
        public static Box<IColorbarProperty> tickfont(params Box<ITickfontProperty>[] properties) => Interop.mkColorbarAttr("tickfont", Bindings.flattenProperties(properties));
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        public static Box<IColorbarProperty> tickangle(int val) => Interop.mkColorbarAttr("tickangle", val);
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        public static Box<IColorbarProperty> tickangle(float val) => Interop.mkColorbarAttr("tickangle", val);
        /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        public static Box<IColorbarProperty> tickformat(string val) => Interop.mkColorbarAttr("tickformat", val);
        public static Box<IColorbarProperty> tickformatstops(params Box<ITickformatstopsProperty>[] properties) => Interop.mkColorbarAttr("tickformatstops", Bindings.flattenProperties(properties));
        /// Sets a tick label prefix.
        public static Box<IColorbarProperty> tickprefix(string val) => Interop.mkColorbarAttr("tickprefix", val);
        /// Sets a tick label suffix.
        public static Box<IColorbarProperty> ticksuffix(string val) => Interop.mkColorbarAttr("ticksuffix", val);
        /// If \"true\", even 4-digit integers are separated
        public static Box<IColorbarProperty> separatethousands(bool val) => Interop.mkColorbarAttr("separatethousands", val);
        public static Box<IColorbarProperty> title(params Box<ITitleProperty>[] properties) => Interop.mkColorbarAttr("title", Bindings.flattenProperties(properties));
        /// Sets the source reference on plot.ly for  tickvals .
        public static Box<IColorbarProperty> tickvalssrc(string val) => Interop.mkColorbarAttr("tickvalssrc", val);
        /// Sets the source reference on plot.ly for  ticktext .
        public static Box<IColorbarProperty> ticktextsrc(string val) => Interop.mkColorbarAttr("ticktextsrc", val);
    }

    public static partial class Colorbar
    {
        /// Determines whether this color bar's thickness (i.e. the measure in the constant color direction) is set in units of plot *fraction* or in *pixels*. Use `thickness` to set the value.
        public static partial class Thicknessmode
        {
            public static Box<IColorbarProperty> fraction() => Interop.mkColorbarAttr("thicknessmode", "fraction");
            public static Box<IColorbarProperty> pixels() => Interop.mkColorbarAttr("thicknessmode", "pixels");
        }

        /// Determines whether this color bar's length (i.e. the measure in the color variation direction) is set in units of plot *fraction* or in *pixels. Use `len` to set the value.
        public static partial class Lenmode
        {
            public static Box<IColorbarProperty> fraction() => Interop.mkColorbarAttr("lenmode", "fraction");
            public static Box<IColorbarProperty> pixels() => Interop.mkColorbarAttr("lenmode", "pixels");
        }

        /// Sets this color bar's horizontal position anchor. This anchor binds the `x` position to the *left*, *center* or *right* of the color bar.
        public static partial class Xanchor
        {
            public static Box<IColorbarProperty> center() => Interop.mkColorbarAttr("xanchor", "center");
            public static Box<IColorbarProperty> left() => Interop.mkColorbarAttr("xanchor", "left");
            public static Box<IColorbarProperty> right() => Interop.mkColorbarAttr("xanchor", "right");
        }

        /// Sets this color bar's vertical position anchor This anchor binds the `y` position to the *top*, *middle* or *bottom* of the color bar.
        public static partial class Yanchor
        {
            public static Box<IColorbarProperty> bottom() => Interop.mkColorbarAttr("yanchor", "bottom");
            public static Box<IColorbarProperty> middle() => Interop.mkColorbarAttr("yanchor", "middle");
            public static Box<IColorbarProperty> top() => Interop.mkColorbarAttr("yanchor", "top");
        }

        /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
        public static partial class Tickmode
        {
            public static Box<IColorbarProperty> array() => Interop.mkColorbarAttr("tickmode", "array");
            public static Box<IColorbarProperty> auto() => Interop.mkColorbarAttr("tickmode", "auto");
            public static Box<IColorbarProperty> linear() => Interop.mkColorbarAttr("tickmode", "linear");
        }

        /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
        public static partial class Ticks
        {
            public static Box<IColorbarProperty> none() => Interop.mkColorbarAttr("ticks", "");
            public static Box<IColorbarProperty> inside() => Interop.mkColorbarAttr("ticks", "inside");
            public static Box<IColorbarProperty> outside() => Interop.mkColorbarAttr("ticks", "outside");
        }

        /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
        public static partial class Showtickprefix
        {
            public static Box<IColorbarProperty> all() => Interop.mkColorbarAttr("showtickprefix", "all");
            public static Box<IColorbarProperty> first() => Interop.mkColorbarAttr("showtickprefix", "first");
            public static Box<IColorbarProperty> last() => Interop.mkColorbarAttr("showtickprefix", "last");
            public static Box<IColorbarProperty> none() => Interop.mkColorbarAttr("showtickprefix", "none");
        }

        /// Same as `showtickprefix` but for tick suffixes.
        public static partial class Showticksuffix
        {
            public static Box<IColorbarProperty> all() => Interop.mkColorbarAttr("showticksuffix", "all");
            public static Box<IColorbarProperty> first() => Interop.mkColorbarAttr("showticksuffix", "first");
            public static Box<IColorbarProperty> last() => Interop.mkColorbarAttr("showticksuffix", "last");
            public static Box<IColorbarProperty> none() => Interop.mkColorbarAttr("showticksuffix", "none");
        }

        /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
        public static partial class Exponentformat
        {
            public static Box<IColorbarProperty> B() => Interop.mkColorbarAttr("exponentformat", "B");
            public static Box<IColorbarProperty> E() => Interop.mkColorbarAttr("exponentformat", "E");
            public static Box<IColorbarProperty> SI() => Interop.mkColorbarAttr("exponentformat", "SI");
            public static Box<IColorbarProperty> e() => Interop.mkColorbarAttr("exponentformat", "e");
            public static Box<IColorbarProperty> none() => Interop.mkColorbarAttr("exponentformat", "none");
            public static Box<IColorbarProperty> power() => Interop.mkColorbarAttr("exponentformat", "power");
        }

        /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
        public static partial class Showexponent
        {
            public static Box<IColorbarProperty> all() => Interop.mkColorbarAttr("showexponent", "all");
            public static Box<IColorbarProperty> first() => Interop.mkColorbarAttr("showexponent", "first");
            public static Box<IColorbarProperty> last() => Interop.mkColorbarAttr("showexponent", "last");
            public static Box<IColorbarProperty> none() => Interop.mkColorbarAttr("showexponent", "none");
        }
    }
}