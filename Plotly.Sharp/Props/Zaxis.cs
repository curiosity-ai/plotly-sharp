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

    public static partial class Zaxis
    {
        /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
        public static Box<IZaxisProperty> visible(bool val) => Interop.mkZaxisAttr("visible", val);
        /// Sets whether or not spikes starting from data points to this axis' wall are shown on hover.
        public static Box<IZaxisProperty> showspikes(bool val) => Interop.mkZaxisAttr("showspikes", val);
        /// Sets whether or not spikes extending from the projection data points to this axis' wall boundaries are shown on hover.
        public static Box<IZaxisProperty> spikesides(bool val) => Interop.mkZaxisAttr("spikesides", val);
        /// Sets the thickness (in px) of the spikes.
        public static Box<IZaxisProperty> spikethickness(int val) => Interop.mkZaxisAttr("spikethickness", val);
        /// Sets the thickness (in px) of the spikes.
        public static Box<IZaxisProperty> spikethickness(float val) => Interop.mkZaxisAttr("spikethickness", val);
        /// Sets the color of the spikes.
        public static Box<IZaxisProperty> spikecolor(string val) => Interop.mkZaxisAttr("spikecolor", val);
        /// Sets whether or not this axis' wall has a background color.
        public static Box<IZaxisProperty> showbackground(bool val) => Interop.mkZaxisAttr("showbackground", val);
        /// Sets the background color of this axis' wall.
        public static Box<IZaxisProperty> backgroundcolor(string val) => Interop.mkZaxisAttr("backgroundcolor", val);
        /// Sets whether or not this axis is labeled
        public static Box<IZaxisProperty> showaxeslabels(bool val) => Interop.mkZaxisAttr("showaxeslabels", val);
        /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
        public static Box<IZaxisProperty> color(string val) => Interop.mkZaxisAttr("color", val);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IZaxisProperty> categoryarray(bool val) => Interop.mkZaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IZaxisProperty> categoryarray(IEnumerable<bool> values) => Interop.mkZaxisAttr("categoryarray", values.ToArray());
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IZaxisProperty> categoryarray(System.DateTime val) => Interop.mkZaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IZaxisProperty> categoryarray(IEnumerable<System.DateTime> values) => Interop.mkZaxisAttr("categoryarray", values.ToArray());
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IZaxisProperty> categoryarray(float val) => Interop.mkZaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IZaxisProperty> categoryarray(IEnumerable<float> values) => Interop.mkZaxisAttr("categoryarray", values.ToArray());
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IZaxisProperty> categoryarray(int val) => Interop.mkZaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IZaxisProperty> categoryarray(IEnumerable<int> values) => Interop.mkZaxisAttr("categoryarray", values.ToArray());
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IZaxisProperty> categoryarray(string val) => Interop.mkZaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IZaxisProperty> categoryarray(IEnumerable<string> values) => Interop.mkZaxisAttr("categoryarray", values.ToArray());
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IZaxisProperty> categoryarray(IEnumerable<bool[]> values) => Interop.mkZaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IZaxisProperty> categoryarray(List<bool[]> values) => Interop.mkZaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IZaxisProperty> categoryarray(params bool[][] values) => Interop.mkZaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IZaxisProperty> categoryarray(IEnumerable<IEnumerable<string>> values) => Interop.mkZaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IZaxisProperty> categoryarray(List<string[]> values) => Interop.mkZaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IZaxisProperty> categoryarray(params string[][] values) => Interop.mkZaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IZaxisProperty> categoryarray(IEnumerable<IEnumerable<int>> values) => Interop.mkZaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IZaxisProperty> categoryarray(List<int[]> values) => Interop.mkZaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IZaxisProperty> categoryarray(params int[][] values) => Interop.mkZaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IZaxisProperty> categoryarray(IEnumerable<IEnumerable<float>> values) => Interop.mkZaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IZaxisProperty> categoryarray(List<float[]> values) => Interop.mkZaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IZaxisProperty> categoryarray(params float[][] values) => Interop.mkZaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IZaxisProperty> categoryarray(Literals.PlotData[] values) => Interop.mkZaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IZaxisProperty> categoryarray(IEnumerable<bool?> values) => Interop.mkZaxisAttr("categoryarray", values.ToArray());
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IZaxisProperty> categoryarray(IEnumerable<System.DateTime?> values) => Interop.mkZaxisAttr("categoryarray", values.ToArray());
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IZaxisProperty> categoryarray(IEnumerable<int?> values) => Interop.mkZaxisAttr("categoryarray", values.ToArray());
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IZaxisProperty> categoryarray(IEnumerable<float?> values) => Interop.mkZaxisAttr("categoryarray", values.ToArray());
        public static Box<IZaxisProperty> title(params Box<ITitleProperty>[] properties) => Interop.mkZaxisAttr("title", Bindings.flattenProperties(properties));
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IZaxisProperty> range(bool val) => Interop.mkZaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IZaxisProperty> range(IEnumerable<bool> values) => Interop.mkZaxisAttr("range", values.ToArray());
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IZaxisProperty> range(System.DateTime val) => Interop.mkZaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IZaxisProperty> range(IEnumerable<System.DateTime> values) => Interop.mkZaxisAttr("range", values.ToArray());
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IZaxisProperty> range(float val) => Interop.mkZaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IZaxisProperty> range(IEnumerable<float> values) => Interop.mkZaxisAttr("range", values.ToArray());
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IZaxisProperty> range(int val) => Interop.mkZaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IZaxisProperty> range(IEnumerable<int> values) => Interop.mkZaxisAttr("range", values.ToArray());
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IZaxisProperty> range(string val) => Interop.mkZaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IZaxisProperty> range(IEnumerable<string> values) => Interop.mkZaxisAttr("range", values.ToArray());
        /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
        public static Box<IZaxisProperty> nticks(int val) => Interop.mkZaxisAttr("nticks", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IZaxisProperty> tick0(bool val) => Interop.mkZaxisAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IZaxisProperty> tick0(params bool[] values) => Interop.mkZaxisAttr("tick0", values);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IZaxisProperty> tick0(System.DateTime val) => Interop.mkZaxisAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IZaxisProperty> tick0(params System.DateTime[] values) => Interop.mkZaxisAttr("tick0", values);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IZaxisProperty> tick0(int val) => Interop.mkZaxisAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IZaxisProperty> tick0(params int[] values) => Interop.mkZaxisAttr("tick0", values);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IZaxisProperty> tick0(float val) => Interop.mkZaxisAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IZaxisProperty> tick0(params float[] values) => Interop.mkZaxisAttr("tick0", values);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IZaxisProperty> tick0(string val) => Interop.mkZaxisAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IZaxisProperty> tick0(params string[] values) => Interop.mkZaxisAttr("tick0", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IZaxisProperty> dtick(bool val) => Interop.mkZaxisAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IZaxisProperty> dtick(params bool[] values) => Interop.mkZaxisAttr("dtick", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IZaxisProperty> dtick(System.DateTime val) => Interop.mkZaxisAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IZaxisProperty> dtick(params System.DateTime[] values) => Interop.mkZaxisAttr("dtick", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IZaxisProperty> dtick(int val) => Interop.mkZaxisAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IZaxisProperty> dtick(params int[] values) => Interop.mkZaxisAttr("dtick", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IZaxisProperty> dtick(float val) => Interop.mkZaxisAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IZaxisProperty> dtick(params float[] values) => Interop.mkZaxisAttr("dtick", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IZaxisProperty> dtick(string val) => Interop.mkZaxisAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IZaxisProperty> dtick(params string[] values) => Interop.mkZaxisAttr("dtick", values);
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IZaxisProperty> tickvals(bool val) => Interop.mkZaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IZaxisProperty> tickvals(IEnumerable<bool> values) => Interop.mkZaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IZaxisProperty> tickvals(System.DateTime val) => Interop.mkZaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IZaxisProperty> tickvals(IEnumerable<System.DateTime> values) => Interop.mkZaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IZaxisProperty> tickvals(float val) => Interop.mkZaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IZaxisProperty> tickvals(IEnumerable<float> values) => Interop.mkZaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IZaxisProperty> tickvals(int val) => Interop.mkZaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IZaxisProperty> tickvals(IEnumerable<int> values) => Interop.mkZaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IZaxisProperty> tickvals(string val) => Interop.mkZaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IZaxisProperty> tickvals(IEnumerable<string> values) => Interop.mkZaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IZaxisProperty> tickvals(IEnumerable<bool[]> values) => Interop.mkZaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IZaxisProperty> tickvals(List<bool[]> values) => Interop.mkZaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IZaxisProperty> tickvals(params bool[][] values) => Interop.mkZaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IZaxisProperty> tickvals(IEnumerable<IEnumerable<string>> values) => Interop.mkZaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IZaxisProperty> tickvals(List<string[]> values) => Interop.mkZaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IZaxisProperty> tickvals(params string[][] values) => Interop.mkZaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IZaxisProperty> tickvals(IEnumerable<IEnumerable<int>> values) => Interop.mkZaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IZaxisProperty> tickvals(List<int[]> values) => Interop.mkZaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IZaxisProperty> tickvals(params int[][] values) => Interop.mkZaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IZaxisProperty> tickvals(IEnumerable<IEnumerable<float>> values) => Interop.mkZaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IZaxisProperty> tickvals(List<float[]> values) => Interop.mkZaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IZaxisProperty> tickvals(params float[][] values) => Interop.mkZaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IZaxisProperty> tickvals(Literals.PlotData[] values) => Interop.mkZaxisAttr("tickvals", values);
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IZaxisProperty> tickvals(IEnumerable<bool?> values) => Interop.mkZaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IZaxisProperty> tickvals(IEnumerable<System.DateTime?> values) => Interop.mkZaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IZaxisProperty> tickvals(IEnumerable<int?> values) => Interop.mkZaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IZaxisProperty> tickvals(IEnumerable<float?> values) => Interop.mkZaxisAttr("tickvals", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IZaxisProperty> ticktext(bool val) => Interop.mkZaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IZaxisProperty> ticktext(IEnumerable<bool> values) => Interop.mkZaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IZaxisProperty> ticktext(System.DateTime val) => Interop.mkZaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IZaxisProperty> ticktext(IEnumerable<System.DateTime> values) => Interop.mkZaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IZaxisProperty> ticktext(float val) => Interop.mkZaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IZaxisProperty> ticktext(IEnumerable<float> values) => Interop.mkZaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IZaxisProperty> ticktext(int val) => Interop.mkZaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IZaxisProperty> ticktext(IEnumerable<int> values) => Interop.mkZaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IZaxisProperty> ticktext(string val) => Interop.mkZaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IZaxisProperty> ticktext(IEnumerable<string> values) => Interop.mkZaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IZaxisProperty> ticktext(IEnumerable<bool[]> values) => Interop.mkZaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IZaxisProperty> ticktext(List<bool[]> values) => Interop.mkZaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IZaxisProperty> ticktext(params bool[][] values) => Interop.mkZaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IZaxisProperty> ticktext(IEnumerable<IEnumerable<string>> values) => Interop.mkZaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IZaxisProperty> ticktext(List<string[]> values) => Interop.mkZaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IZaxisProperty> ticktext(params string[][] values) => Interop.mkZaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IZaxisProperty> ticktext(IEnumerable<IEnumerable<int>> values) => Interop.mkZaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IZaxisProperty> ticktext(List<int[]> values) => Interop.mkZaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IZaxisProperty> ticktext(params int[][] values) => Interop.mkZaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IZaxisProperty> ticktext(IEnumerable<IEnumerable<float>> values) => Interop.mkZaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IZaxisProperty> ticktext(List<float[]> values) => Interop.mkZaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IZaxisProperty> ticktext(params float[][] values) => Interop.mkZaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IZaxisProperty> ticktext(Literals.PlotData[] values) => Interop.mkZaxisAttr("ticktext", values);
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IZaxisProperty> ticktext(IEnumerable<bool?> values) => Interop.mkZaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IZaxisProperty> ticktext(IEnumerable<System.DateTime?> values) => Interop.mkZaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IZaxisProperty> ticktext(IEnumerable<int?> values) => Interop.mkZaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IZaxisProperty> ticktext(IEnumerable<float?> values) => Interop.mkZaxisAttr("ticktext", values.ToArray());
        /// Sets the tick length (in px).
        public static Box<IZaxisProperty> ticklen(int val) => Interop.mkZaxisAttr("ticklen", val);
        /// Sets the tick length (in px).
        public static Box<IZaxisProperty> ticklen(float val) => Interop.mkZaxisAttr("ticklen", val);
        /// Sets the tick width (in px).
        public static Box<IZaxisProperty> tickwidth(int val) => Interop.mkZaxisAttr("tickwidth", val);
        /// Sets the tick width (in px).
        public static Box<IZaxisProperty> tickwidth(float val) => Interop.mkZaxisAttr("tickwidth", val);
        /// Sets the tick color.
        public static Box<IZaxisProperty> tickcolor(string val) => Interop.mkZaxisAttr("tickcolor", val);
        /// Determines whether or not the tick labels are drawn.
        public static Box<IZaxisProperty> showticklabels(bool val) => Interop.mkZaxisAttr("showticklabels", val);
        /// Sets the tick font.
        public static Box<IZaxisProperty> tickfont(params Box<ITickfontProperty>[] properties) => Interop.mkZaxisAttr("tickfont", Bindings.flattenProperties(properties));
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        public static Box<IZaxisProperty> tickangle(int val) => Interop.mkZaxisAttr("tickangle", val);
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        public static Box<IZaxisProperty> tickangle(float val) => Interop.mkZaxisAttr("tickangle", val);
        /// Sets a tick label prefix.
        public static Box<IZaxisProperty> tickprefix(string val) => Interop.mkZaxisAttr("tickprefix", val);
        /// Sets a tick label suffix.
        public static Box<IZaxisProperty> ticksuffix(string val) => Interop.mkZaxisAttr("ticksuffix", val);
        /// If \"true\", even 4-digit integers are separated
        public static Box<IZaxisProperty> separatethousands(bool val) => Interop.mkZaxisAttr("separatethousands", val);
        /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        public static Box<IZaxisProperty> tickformat(string val) => Interop.mkZaxisAttr("tickformat", val);
        public static Box<IZaxisProperty> tickformatstops(params Box<ITickformatstopsProperty>[] properties) => Interop.mkZaxisAttr("tickformatstops", Bindings.flattenProperties(properties));
        /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        public static Box<IZaxisProperty> hoverformat(string val) => Interop.mkZaxisAttr("hoverformat", val);
        /// Determines whether or not a line bounding this axis is drawn.
        public static Box<IZaxisProperty> showline(bool val) => Interop.mkZaxisAttr("showline", val);
        /// Sets the axis line color.
        public static Box<IZaxisProperty> linecolor(string val) => Interop.mkZaxisAttr("linecolor", val);
        /// Sets the width (in px) of the axis line.
        public static Box<IZaxisProperty> linewidth(int val) => Interop.mkZaxisAttr("linewidth", val);
        /// Sets the width (in px) of the axis line.
        public static Box<IZaxisProperty> linewidth(float val) => Interop.mkZaxisAttr("linewidth", val);
        /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
        public static Box<IZaxisProperty> showgrid(bool val) => Interop.mkZaxisAttr("showgrid", val);
        /// Sets the color of the grid lines.
        public static Box<IZaxisProperty> gridcolor(string val) => Interop.mkZaxisAttr("gridcolor", val);
        /// Sets the width (in px) of the grid lines.
        public static Box<IZaxisProperty> gridwidth(int val) => Interop.mkZaxisAttr("gridwidth", val);
        /// Sets the width (in px) of the grid lines.
        public static Box<IZaxisProperty> gridwidth(float val) => Interop.mkZaxisAttr("gridwidth", val);
        /// Determines whether or not a line is drawn at along the 0 value of this axis. If *true*, the zero line is drawn on top of the grid lines.
        public static Box<IZaxisProperty> zeroline(bool val) => Interop.mkZaxisAttr("zeroline", val);
        /// Sets the line color of the zero line.
        public static Box<IZaxisProperty> zerolinecolor(string val) => Interop.mkZaxisAttr("zerolinecolor", val);
        /// Sets the width (in px) of the zero line.
        public static Box<IZaxisProperty> zerolinewidth(int val) => Interop.mkZaxisAttr("zerolinewidth", val);
        /// Sets the width (in px) of the zero line.
        public static Box<IZaxisProperty> zerolinewidth(float val) => Interop.mkZaxisAttr("zerolinewidth", val);
        /// Sets the source reference on plot.ly for  categoryarray .
        public static Box<IZaxisProperty> categoryarraysrc(string val) => Interop.mkZaxisAttr("categoryarraysrc", val);
        /// Sets the source reference on plot.ly for  tickvals .
        public static Box<IZaxisProperty> tickvalssrc(string val) => Interop.mkZaxisAttr("tickvalssrc", val);
        /// Sets the source reference on plot.ly for  ticktext .
        public static Box<IZaxisProperty> ticktextsrc(string val) => Interop.mkZaxisAttr("ticktextsrc", val);
    }

    public static partial class Zaxis
    {
        /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
        public static partial class Categoryorder
        {
            public static Box<IZaxisProperty> array() => Interop.mkZaxisAttr("categoryorder", "array");
            public static Box<IZaxisProperty> categoryAscending() => Interop.mkZaxisAttr("categoryorder", "category ascending");
            public static Box<IZaxisProperty> categoryDescending() => Interop.mkZaxisAttr("categoryorder", "category descending");
            public static Box<IZaxisProperty> maxAscending() => Interop.mkZaxisAttr("categoryorder", "max ascending");
            public static Box<IZaxisProperty> maxDescending() => Interop.mkZaxisAttr("categoryorder", "max descending");
            public static Box<IZaxisProperty> meanAscending() => Interop.mkZaxisAttr("categoryorder", "mean ascending");
            public static Box<IZaxisProperty> meanDescending() => Interop.mkZaxisAttr("categoryorder", "mean descending");
            public static Box<IZaxisProperty> medianAscending() => Interop.mkZaxisAttr("categoryorder", "median ascending");
            public static Box<IZaxisProperty> medianDescending() => Interop.mkZaxisAttr("categoryorder", "median descending");
            public static Box<IZaxisProperty> minAscending() => Interop.mkZaxisAttr("categoryorder", "min ascending");
            public static Box<IZaxisProperty> minDescending() => Interop.mkZaxisAttr("categoryorder", "min descending");
            public static Box<IZaxisProperty> sumAscending() => Interop.mkZaxisAttr("categoryorder", "sum ascending");
            public static Box<IZaxisProperty> sumDescending() => Interop.mkZaxisAttr("categoryorder", "sum descending");
            public static Box<IZaxisProperty> totalAscending() => Interop.mkZaxisAttr("categoryorder", "total ascending");
            public static Box<IZaxisProperty> totalDescending() => Interop.mkZaxisAttr("categoryorder", "total descending");
            public static Box<IZaxisProperty> trace() => Interop.mkZaxisAttr("categoryorder", "trace");
        }

        /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
        public static partial class _type
        {
            public static Box<IZaxisProperty> dash() => Interop.mkZaxisAttr("type", "-");
            public static Box<IZaxisProperty> category() => Interop.mkZaxisAttr("type", "category");
            public static Box<IZaxisProperty> date() => Interop.mkZaxisAttr("type", "date");
            public static Box<IZaxisProperty> linear() => Interop.mkZaxisAttr("type", "linear");
            public static Box<IZaxisProperty> log() => Interop.mkZaxisAttr("type", "log");
        }

        /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
        public static partial class Autorange
        {
            public static Box<IZaxisProperty> reversed() => Interop.mkZaxisAttr("autorange", "reversed");
            public static Box<IZaxisProperty> _false() => Interop.mkZaxisAttr("autorange", false);
            public static Box<IZaxisProperty> _true() => Interop.mkZaxisAttr("autorange", true);
        }

        /// If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. Applies only to linear axes.
        public static partial class Rangemode
        {
            public static Box<IZaxisProperty> nonnegative() => Interop.mkZaxisAttr("rangemode", "nonnegative");
            public static Box<IZaxisProperty> normal() => Interop.mkZaxisAttr("rangemode", "normal");
            public static Box<IZaxisProperty> tozero() => Interop.mkZaxisAttr("rangemode", "tozero");
        }

        /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
        public static partial class Tickmode
        {
            public static Box<IZaxisProperty> array() => Interop.mkZaxisAttr("tickmode", "array");
            public static Box<IZaxisProperty> auto() => Interop.mkZaxisAttr("tickmode", "auto");
            public static Box<IZaxisProperty> linear() => Interop.mkZaxisAttr("tickmode", "linear");
        }

        /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
        public static partial class Ticks
        {
            public static Box<IZaxisProperty> none() => Interop.mkZaxisAttr("ticks", "");
            public static Box<IZaxisProperty> inside() => Interop.mkZaxisAttr("ticks", "inside");
            public static Box<IZaxisProperty> outside() => Interop.mkZaxisAttr("ticks", "outside");
        }

        /// Determines if the axis lines or/and ticks are mirrored to the opposite side of the plotting area. If *true*, the axis lines are mirrored. If *ticks*, the axis lines and ticks are mirrored. If *false*, mirroring is disable. If *all*, axis lines are mirrored on all shared-axes subplots. If *allticks*, axis lines and ticks are mirrored on all shared-axes subplots.
        public static partial class Mirror
        {
            public static Box<IZaxisProperty> all() => Interop.mkZaxisAttr("mirror", "all");
            public static Box<IZaxisProperty> allticks() => Interop.mkZaxisAttr("mirror", "allticks");
            public static Box<IZaxisProperty> ticks() => Interop.mkZaxisAttr("mirror", "ticks");
            public static Box<IZaxisProperty> _false() => Interop.mkZaxisAttr("mirror", false);
            public static Box<IZaxisProperty> _true() => Interop.mkZaxisAttr("mirror", true);
        }

        /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
        public static partial class Showtickprefix
        {
            public static Box<IZaxisProperty> all() => Interop.mkZaxisAttr("showtickprefix", "all");
            public static Box<IZaxisProperty> first() => Interop.mkZaxisAttr("showtickprefix", "first");
            public static Box<IZaxisProperty> last() => Interop.mkZaxisAttr("showtickprefix", "last");
            public static Box<IZaxisProperty> none() => Interop.mkZaxisAttr("showtickprefix", "none");
        }

        /// Same as `showtickprefix` but for tick suffixes.
        public static partial class Showticksuffix
        {
            public static Box<IZaxisProperty> all() => Interop.mkZaxisAttr("showticksuffix", "all");
            public static Box<IZaxisProperty> first() => Interop.mkZaxisAttr("showticksuffix", "first");
            public static Box<IZaxisProperty> last() => Interop.mkZaxisAttr("showticksuffix", "last");
            public static Box<IZaxisProperty> none() => Interop.mkZaxisAttr("showticksuffix", "none");
        }

        /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
        public static partial class Showexponent
        {
            public static Box<IZaxisProperty> all() => Interop.mkZaxisAttr("showexponent", "all");
            public static Box<IZaxisProperty> first() => Interop.mkZaxisAttr("showexponent", "first");
            public static Box<IZaxisProperty> last() => Interop.mkZaxisAttr("showexponent", "last");
            public static Box<IZaxisProperty> none() => Interop.mkZaxisAttr("showexponent", "none");
        }

        /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
        public static partial class Exponentformat
        {
            public static Box<IZaxisProperty> B() => Interop.mkZaxisAttr("exponentformat", "B");
            public static Box<IZaxisProperty> E() => Interop.mkZaxisAttr("exponentformat", "E");
            public static Box<IZaxisProperty> SI() => Interop.mkZaxisAttr("exponentformat", "SI");
            public static Box<IZaxisProperty> e() => Interop.mkZaxisAttr("exponentformat", "e");
            public static Box<IZaxisProperty> none() => Interop.mkZaxisAttr("exponentformat", "none");
            public static Box<IZaxisProperty> power() => Interop.mkZaxisAttr("exponentformat", "power");
        }

        /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
        public static partial class Calendar
        {
            public static Box<IZaxisProperty> chinese() => Interop.mkZaxisAttr("calendar", "chinese");
            public static Box<IZaxisProperty> coptic() => Interop.mkZaxisAttr("calendar", "coptic");
            public static Box<IZaxisProperty> discworld() => Interop.mkZaxisAttr("calendar", "discworld");
            public static Box<IZaxisProperty> ethiopian() => Interop.mkZaxisAttr("calendar", "ethiopian");
            public static Box<IZaxisProperty> gregorian() => Interop.mkZaxisAttr("calendar", "gregorian");
            public static Box<IZaxisProperty> hebrew() => Interop.mkZaxisAttr("calendar", "hebrew");
            public static Box<IZaxisProperty> islamic() => Interop.mkZaxisAttr("calendar", "islamic");
            public static Box<IZaxisProperty> jalali() => Interop.mkZaxisAttr("calendar", "jalali");
            public static Box<IZaxisProperty> julian() => Interop.mkZaxisAttr("calendar", "julian");
            public static Box<IZaxisProperty> mayan() => Interop.mkZaxisAttr("calendar", "mayan");
            public static Box<IZaxisProperty> nanakshahi() => Interop.mkZaxisAttr("calendar", "nanakshahi");
            public static Box<IZaxisProperty> nepali() => Interop.mkZaxisAttr("calendar", "nepali");
            public static Box<IZaxisProperty> persian() => Interop.mkZaxisAttr("calendar", "persian");
            public static Box<IZaxisProperty> taiwan() => Interop.mkZaxisAttr("calendar", "taiwan");
            public static Box<IZaxisProperty> thai() => Interop.mkZaxisAttr("calendar", "thai");
            public static Box<IZaxisProperty> ummalqura() => Interop.mkZaxisAttr("calendar", "ummalqura");
        }
    }
}