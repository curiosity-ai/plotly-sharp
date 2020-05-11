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

    public static partial class Caxis
    {
        public static Box<ICaxisProperty> title(params Box<ITitleProperty>[] properties) => Interop.mkCaxisAttr("title", Bindings.flattenProperties(properties));
        /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
        public static Box<ICaxisProperty> color(string val) => Interop.mkCaxisAttr("color", val);
        /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
        public static Box<ICaxisProperty> nticks(int val) => Interop.mkCaxisAttr("nticks", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<ICaxisProperty> tick0(bool val) => Interop.mkCaxisAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<ICaxisProperty> tick0(params bool[] values) => Interop.mkCaxisAttr("tick0", values);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<ICaxisProperty> tick0(System.DateTime val) => Interop.mkCaxisAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<ICaxisProperty> tick0(params System.DateTime[] values) => Interop.mkCaxisAttr("tick0", values);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<ICaxisProperty> tick0(int val) => Interop.mkCaxisAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<ICaxisProperty> tick0(params int[] values) => Interop.mkCaxisAttr("tick0", values);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<ICaxisProperty> tick0(float val) => Interop.mkCaxisAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<ICaxisProperty> tick0(params float[] values) => Interop.mkCaxisAttr("tick0", values);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<ICaxisProperty> tick0(string val) => Interop.mkCaxisAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<ICaxisProperty> tick0(params string[] values) => Interop.mkCaxisAttr("tick0", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<ICaxisProperty> dtick(bool val) => Interop.mkCaxisAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<ICaxisProperty> dtick(params bool[] values) => Interop.mkCaxisAttr("dtick", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<ICaxisProperty> dtick(System.DateTime val) => Interop.mkCaxisAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<ICaxisProperty> dtick(params System.DateTime[] values) => Interop.mkCaxisAttr("dtick", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<ICaxisProperty> dtick(int val) => Interop.mkCaxisAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<ICaxisProperty> dtick(params int[] values) => Interop.mkCaxisAttr("dtick", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<ICaxisProperty> dtick(float val) => Interop.mkCaxisAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<ICaxisProperty> dtick(params float[] values) => Interop.mkCaxisAttr("dtick", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<ICaxisProperty> dtick(string val) => Interop.mkCaxisAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<ICaxisProperty> dtick(params string[] values) => Interop.mkCaxisAttr("dtick", values);
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<ICaxisProperty> tickvals(bool val) => Interop.mkCaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<ICaxisProperty> tickvals(IEnumerable<bool> values) => Interop.mkCaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<ICaxisProperty> tickvals(System.DateTime val) => Interop.mkCaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<ICaxisProperty> tickvals(IEnumerable<System.DateTime> values) => Interop.mkCaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<ICaxisProperty> tickvals(float val) => Interop.mkCaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<ICaxisProperty> tickvals(IEnumerable<float> values) => Interop.mkCaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<ICaxisProperty> tickvals(int val) => Interop.mkCaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<ICaxisProperty> tickvals(IEnumerable<int> values) => Interop.mkCaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<ICaxisProperty> tickvals(string val) => Interop.mkCaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<ICaxisProperty> tickvals(IEnumerable<string> values) => Interop.mkCaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<ICaxisProperty> tickvals(IEnumerable<bool[]> values) => Interop.mkCaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<ICaxisProperty> tickvals(List<bool[]> values) => Interop.mkCaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<ICaxisProperty> tickvals(params bool[][] values) => Interop.mkCaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<ICaxisProperty> tickvals(IEnumerable<IEnumerable<string>> values) => Interop.mkCaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<ICaxisProperty> tickvals(List<string[]> values) => Interop.mkCaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<ICaxisProperty> tickvals(params string[][] values) => Interop.mkCaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<ICaxisProperty> tickvals(IEnumerable<IEnumerable<int>> values) => Interop.mkCaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<ICaxisProperty> tickvals(List<int[]> values) => Interop.mkCaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<ICaxisProperty> tickvals(params int[][] values) => Interop.mkCaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<ICaxisProperty> tickvals(IEnumerable<IEnumerable<float>> values) => Interop.mkCaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<ICaxisProperty> tickvals(List<float[]> values) => Interop.mkCaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<ICaxisProperty> tickvals(params float[][] values) => Interop.mkCaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<ICaxisProperty> tickvals(Literals.PlotData[] values) => Interop.mkCaxisAttr("tickvals", values);
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<ICaxisProperty> tickvals(IEnumerable<bool?> values) => Interop.mkCaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<ICaxisProperty> tickvals(IEnumerable<System.DateTime?> values) => Interop.mkCaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<ICaxisProperty> tickvals(IEnumerable<int?> values) => Interop.mkCaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<ICaxisProperty> tickvals(IEnumerable<float?> values) => Interop.mkCaxisAttr("tickvals", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<ICaxisProperty> ticktext(bool val) => Interop.mkCaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<ICaxisProperty> ticktext(IEnumerable<bool> values) => Interop.mkCaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<ICaxisProperty> ticktext(System.DateTime val) => Interop.mkCaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<ICaxisProperty> ticktext(IEnumerable<System.DateTime> values) => Interop.mkCaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<ICaxisProperty> ticktext(float val) => Interop.mkCaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<ICaxisProperty> ticktext(IEnumerable<float> values) => Interop.mkCaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<ICaxisProperty> ticktext(int val) => Interop.mkCaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<ICaxisProperty> ticktext(IEnumerable<int> values) => Interop.mkCaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<ICaxisProperty> ticktext(string val) => Interop.mkCaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<ICaxisProperty> ticktext(IEnumerable<string> values) => Interop.mkCaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<ICaxisProperty> ticktext(IEnumerable<bool[]> values) => Interop.mkCaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<ICaxisProperty> ticktext(List<bool[]> values) => Interop.mkCaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<ICaxisProperty> ticktext(params bool[][] values) => Interop.mkCaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<ICaxisProperty> ticktext(IEnumerable<IEnumerable<string>> values) => Interop.mkCaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<ICaxisProperty> ticktext(List<string[]> values) => Interop.mkCaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<ICaxisProperty> ticktext(params string[][] values) => Interop.mkCaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<ICaxisProperty> ticktext(IEnumerable<IEnumerable<int>> values) => Interop.mkCaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<ICaxisProperty> ticktext(List<int[]> values) => Interop.mkCaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<ICaxisProperty> ticktext(params int[][] values) => Interop.mkCaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<ICaxisProperty> ticktext(IEnumerable<IEnumerable<float>> values) => Interop.mkCaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<ICaxisProperty> ticktext(List<float[]> values) => Interop.mkCaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<ICaxisProperty> ticktext(params float[][] values) => Interop.mkCaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<ICaxisProperty> ticktext(Literals.PlotData[] values) => Interop.mkCaxisAttr("ticktext", values);
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<ICaxisProperty> ticktext(IEnumerable<bool?> values) => Interop.mkCaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<ICaxisProperty> ticktext(IEnumerable<System.DateTime?> values) => Interop.mkCaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<ICaxisProperty> ticktext(IEnumerable<int?> values) => Interop.mkCaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<ICaxisProperty> ticktext(IEnumerable<float?> values) => Interop.mkCaxisAttr("ticktext", values.ToArray());
        /// Sets the tick length (in px).
        public static Box<ICaxisProperty> ticklen(int val) => Interop.mkCaxisAttr("ticklen", val);
        /// Sets the tick length (in px).
        public static Box<ICaxisProperty> ticklen(float val) => Interop.mkCaxisAttr("ticklen", val);
        /// Sets the tick width (in px).
        public static Box<ICaxisProperty> tickwidth(int val) => Interop.mkCaxisAttr("tickwidth", val);
        /// Sets the tick width (in px).
        public static Box<ICaxisProperty> tickwidth(float val) => Interop.mkCaxisAttr("tickwidth", val);
        /// Sets the tick color.
        public static Box<ICaxisProperty> tickcolor(string val) => Interop.mkCaxisAttr("tickcolor", val);
        /// Determines whether or not the tick labels are drawn.
        public static Box<ICaxisProperty> showticklabels(bool val) => Interop.mkCaxisAttr("showticklabels", val);
        /// Sets a tick label prefix.
        public static Box<ICaxisProperty> tickprefix(string val) => Interop.mkCaxisAttr("tickprefix", val);
        /// Sets a tick label suffix.
        public static Box<ICaxisProperty> ticksuffix(string val) => Interop.mkCaxisAttr("ticksuffix", val);
        /// If \"true\", even 4-digit integers are separated
        public static Box<ICaxisProperty> separatethousands(bool val) => Interop.mkCaxisAttr("separatethousands", val);
        /// Sets the tick font.
        public static Box<ICaxisProperty> tickfont(params Box<ITickfontProperty>[] properties) => Interop.mkCaxisAttr("tickfont", Bindings.flattenProperties(properties));
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        public static Box<ICaxisProperty> tickangle(int val) => Interop.mkCaxisAttr("tickangle", val);
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        public static Box<ICaxisProperty> tickangle(float val) => Interop.mkCaxisAttr("tickangle", val);
        /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        public static Box<ICaxisProperty> tickformat(string val) => Interop.mkCaxisAttr("tickformat", val);
        public static Box<ICaxisProperty> tickformatstops(params Box<ITickformatstopsProperty>[] properties) => Interop.mkCaxisAttr("tickformatstops", Bindings.flattenProperties(properties));
        /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        public static Box<ICaxisProperty> hoverformat(string val) => Interop.mkCaxisAttr("hoverformat", val);
        /// Determines whether or not a line bounding this axis is drawn.
        public static Box<ICaxisProperty> showline(bool val) => Interop.mkCaxisAttr("showline", val);
        /// Sets the axis line color.
        public static Box<ICaxisProperty> linecolor(string val) => Interop.mkCaxisAttr("linecolor", val);
        /// Sets the width (in px) of the axis line.
        public static Box<ICaxisProperty> linewidth(int val) => Interop.mkCaxisAttr("linewidth", val);
        /// Sets the width (in px) of the axis line.
        public static Box<ICaxisProperty> linewidth(float val) => Interop.mkCaxisAttr("linewidth", val);
        /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
        public static Box<ICaxisProperty> showgrid(bool val) => Interop.mkCaxisAttr("showgrid", val);
        /// Sets the color of the grid lines.
        public static Box<ICaxisProperty> gridcolor(string val) => Interop.mkCaxisAttr("gridcolor", val);
        /// Sets the width (in px) of the grid lines.
        public static Box<ICaxisProperty> gridwidth(int val) => Interop.mkCaxisAttr("gridwidth", val);
        /// Sets the width (in px) of the grid lines.
        public static Box<ICaxisProperty> gridwidth(float val) => Interop.mkCaxisAttr("gridwidth", val);
        /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
        public static Box<ICaxisProperty> min(int val) => Interop.mkCaxisAttr("min", val);
        /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
        public static Box<ICaxisProperty> min(float val) => Interop.mkCaxisAttr("min", val);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<ICaxisProperty> uirevision(bool val) => Interop.mkCaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<ICaxisProperty> uirevision(params bool[] values) => Interop.mkCaxisAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<ICaxisProperty> uirevision(System.DateTime val) => Interop.mkCaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<ICaxisProperty> uirevision(params System.DateTime[] values) => Interop.mkCaxisAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<ICaxisProperty> uirevision(int val) => Interop.mkCaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<ICaxisProperty> uirevision(params int[] values) => Interop.mkCaxisAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<ICaxisProperty> uirevision(float val) => Interop.mkCaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<ICaxisProperty> uirevision(params float[] values) => Interop.mkCaxisAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<ICaxisProperty> uirevision(string val) => Interop.mkCaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<ICaxisProperty> uirevision(params string[] values) => Interop.mkCaxisAttr("uirevision", values);
        /// Sets the source reference on plot.ly for  tickvals .
        public static Box<ICaxisProperty> tickvalssrc(string val) => Interop.mkCaxisAttr("tickvalssrc", val);
        /// Sets the source reference on plot.ly for  ticktext .
        public static Box<ICaxisProperty> ticktextsrc(string val) => Interop.mkCaxisAttr("ticktextsrc", val);
    }

    public static partial class Caxis
    {
        /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
        public static partial class Tickmode
        {
            public static Box<ICaxisProperty> array() => Interop.mkCaxisAttr("tickmode", "array");
            public static Box<ICaxisProperty> auto() => Interop.mkCaxisAttr("tickmode", "auto");
            public static Box<ICaxisProperty> linear() => Interop.mkCaxisAttr("tickmode", "linear");
        }

        /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
        public static partial class Ticks
        {
            public static Box<ICaxisProperty> none() => Interop.mkCaxisAttr("ticks", "");
            public static Box<ICaxisProperty> inside() => Interop.mkCaxisAttr("ticks", "inside");
            public static Box<ICaxisProperty> outside() => Interop.mkCaxisAttr("ticks", "outside");
        }

        /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
        public static partial class Showtickprefix
        {
            public static Box<ICaxisProperty> all() => Interop.mkCaxisAttr("showtickprefix", "all");
            public static Box<ICaxisProperty> first() => Interop.mkCaxisAttr("showtickprefix", "first");
            public static Box<ICaxisProperty> last() => Interop.mkCaxisAttr("showtickprefix", "last");
            public static Box<ICaxisProperty> none() => Interop.mkCaxisAttr("showtickprefix", "none");
        }

        /// Same as `showtickprefix` but for tick suffixes.
        public static partial class Showticksuffix
        {
            public static Box<ICaxisProperty> all() => Interop.mkCaxisAttr("showticksuffix", "all");
            public static Box<ICaxisProperty> first() => Interop.mkCaxisAttr("showticksuffix", "first");
            public static Box<ICaxisProperty> last() => Interop.mkCaxisAttr("showticksuffix", "last");
            public static Box<ICaxisProperty> none() => Interop.mkCaxisAttr("showticksuffix", "none");
        }

        /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
        public static partial class Showexponent
        {
            public static Box<ICaxisProperty> all() => Interop.mkCaxisAttr("showexponent", "all");
            public static Box<ICaxisProperty> first() => Interop.mkCaxisAttr("showexponent", "first");
            public static Box<ICaxisProperty> last() => Interop.mkCaxisAttr("showexponent", "last");
            public static Box<ICaxisProperty> none() => Interop.mkCaxisAttr("showexponent", "none");
        }

        /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
        public static partial class Exponentformat
        {
            public static Box<ICaxisProperty> B() => Interop.mkCaxisAttr("exponentformat", "B");
            public static Box<ICaxisProperty> E() => Interop.mkCaxisAttr("exponentformat", "E");
            public static Box<ICaxisProperty> SI() => Interop.mkCaxisAttr("exponentformat", "SI");
            public static Box<ICaxisProperty> e() => Interop.mkCaxisAttr("exponentformat", "e");
            public static Box<ICaxisProperty> none() => Interop.mkCaxisAttr("exponentformat", "none");
            public static Box<ICaxisProperty> power() => Interop.mkCaxisAttr("exponentformat", "power");
        }

        /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
        public static partial class Layer
        {
            public static Box<ICaxisProperty> aboveTraces() => Interop.mkCaxisAttr("layer", "above traces");
            public static Box<ICaxisProperty> belowTraces() => Interop.mkCaxisAttr("layer", "below traces");
        }
    }
}