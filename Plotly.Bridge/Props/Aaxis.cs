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

    public static partial class Aaxis
    {
        /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
        public static Box<IAaxisProperty> color(string val) => Interop.mkAaxisAttr("color", val);
        public static Box<IAaxisProperty> smoothing(int val) => Interop.mkAaxisAttr("smoothing", val);
        public static Box<IAaxisProperty> smoothing(float val) => Interop.mkAaxisAttr("smoothing", val);
        public static Box<IAaxisProperty> title(params Box<ITitleProperty>[] properties) => Interop.mkAaxisAttr("title", Bindings.flattenProperties(properties));
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IAaxisProperty> range(bool val) => Interop.mkAaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IAaxisProperty> range(IEnumerable<bool> values) => Interop.mkAaxisAttr("range", values.ToArray());
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IAaxisProperty> range(System.DateTime val) => Interop.mkAaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IAaxisProperty> range(IEnumerable<System.DateTime> values) => Interop.mkAaxisAttr("range", values.ToArray());
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IAaxisProperty> range(float val) => Interop.mkAaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IAaxisProperty> range(IEnumerable<float> values) => Interop.mkAaxisAttr("range", values.ToArray());
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IAaxisProperty> range(int val) => Interop.mkAaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IAaxisProperty> range(IEnumerable<int> values) => Interop.mkAaxisAttr("range", values.ToArray());
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IAaxisProperty> range(string val) => Interop.mkAaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IAaxisProperty> range(IEnumerable<string> values) => Interop.mkAaxisAttr("range", values.ToArray());
        /// Determines whether or not this axis is zoom-able. If true, then zoom is disabled.
        public static Box<IAaxisProperty> fixedrange(bool val) => Interop.mkAaxisAttr("fixedrange", val);
        /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
        public static Box<IAaxisProperty> nticks(int val) => Interop.mkAaxisAttr("nticks", val);
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IAaxisProperty> tickvals(bool val) => Interop.mkAaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IAaxisProperty> tickvals(params bool[] values) => Interop.mkAaxisAttr("tickvals", values);
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IAaxisProperty> tickvals(System.DateTime val) => Interop.mkAaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IAaxisProperty> tickvals(params System.DateTime[] values) => Interop.mkAaxisAttr("tickvals", values);
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IAaxisProperty> tickvals(float val) => Interop.mkAaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IAaxisProperty> tickvals(params float[] values) => Interop.mkAaxisAttr("tickvals", values);
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IAaxisProperty> tickvals(int val) => Interop.mkAaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IAaxisProperty> tickvals(params int[] values) => Interop.mkAaxisAttr("tickvals", values);
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IAaxisProperty> tickvals(string val) => Interop.mkAaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IAaxisProperty> tickvals(params string[] values) => Interop.mkAaxisAttr("tickvals", values);
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IAaxisProperty> tickvals(IEnumerable<bool[]> values) => Interop.mkAaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IAaxisProperty> tickvals(List<bool[]> values) => Interop.mkAaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IAaxisProperty> tickvals(params bool[][] values) => Interop.mkAaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IAaxisProperty> tickvals(IEnumerable<IEnumerable<string>> values) => Interop.mkAaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IAaxisProperty> tickvals(List<string[]> values) => Interop.mkAaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IAaxisProperty> tickvals(params string[][] values) => Interop.mkAaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IAaxisProperty> tickvals(IEnumerable<IEnumerable<int>> values) => Interop.mkAaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IAaxisProperty> tickvals(List<int[]> values) => Interop.mkAaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IAaxisProperty> tickvals(params int[][] values) => Interop.mkAaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IAaxisProperty> tickvals(IEnumerable<IEnumerable<float>> values) => Interop.mkAaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IAaxisProperty> tickvals(List<float[]> values) => Interop.mkAaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IAaxisProperty> tickvals(params float[][] values) => Interop.mkAaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IAaxisProperty> tickvals(Literals.PlotData[] values) => Interop.mkAaxisAttr("tickvals", values);
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IAaxisProperty> tickvals(IEnumerable<bool?> values) => Interop.mkAaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IAaxisProperty> tickvals(IEnumerable<System.DateTime?> values) => Interop.mkAaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IAaxisProperty> tickvals(IEnumerable<int?> values) => Interop.mkAaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IAaxisProperty> tickvals(IEnumerable<float?> values) => Interop.mkAaxisAttr("tickvals", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IAaxisProperty> ticktext(bool val) => Interop.mkAaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IAaxisProperty> ticktext(params bool[] values) => Interop.mkAaxisAttr("ticktext", values);
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IAaxisProperty> ticktext(System.DateTime val) => Interop.mkAaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IAaxisProperty> ticktext(params System.DateTime[] values) => Interop.mkAaxisAttr("ticktext", values);
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IAaxisProperty> ticktext(float val) => Interop.mkAaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IAaxisProperty> ticktext(params float[] values) => Interop.mkAaxisAttr("ticktext", values);
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IAaxisProperty> ticktext(int val) => Interop.mkAaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IAaxisProperty> ticktext(params int[] values) => Interop.mkAaxisAttr("ticktext", values);
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IAaxisProperty> ticktext(string val) => Interop.mkAaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IAaxisProperty> ticktext(params string[] values) => Interop.mkAaxisAttr("ticktext", values);
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IAaxisProperty> ticktext(IEnumerable<bool[]> values) => Interop.mkAaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IAaxisProperty> ticktext(List<bool[]> values) => Interop.mkAaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IAaxisProperty> ticktext(params bool[][] values) => Interop.mkAaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IAaxisProperty> ticktext(IEnumerable<IEnumerable<string>> values) => Interop.mkAaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IAaxisProperty> ticktext(List<string[]> values) => Interop.mkAaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IAaxisProperty> ticktext(params string[][] values) => Interop.mkAaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IAaxisProperty> ticktext(IEnumerable<IEnumerable<int>> values) => Interop.mkAaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IAaxisProperty> ticktext(List<int[]> values) => Interop.mkAaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IAaxisProperty> ticktext(params int[][] values) => Interop.mkAaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IAaxisProperty> ticktext(IEnumerable<IEnumerable<float>> values) => Interop.mkAaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IAaxisProperty> ticktext(List<float[]> values) => Interop.mkAaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IAaxisProperty> ticktext(params float[][] values) => Interop.mkAaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IAaxisProperty> ticktext(Literals.PlotData[] values) => Interop.mkAaxisAttr("ticktext", values);
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IAaxisProperty> ticktext(IEnumerable<bool?> values) => Interop.mkAaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IAaxisProperty> ticktext(IEnumerable<System.DateTime?> values) => Interop.mkAaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IAaxisProperty> ticktext(IEnumerable<int?> values) => Interop.mkAaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IAaxisProperty> ticktext(IEnumerable<float?> values) => Interop.mkAaxisAttr("ticktext", values.ToArray());
        /// Sets the tick font.
        public static Box<IAaxisProperty> tickfont(params Box<ITickfontProperty>[] properties) => Interop.mkAaxisAttr("tickfont", Bindings.flattenProperties(properties));
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        public static Box<IAaxisProperty> tickangle(int val) => Interop.mkAaxisAttr("tickangle", val);
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        public static Box<IAaxisProperty> tickangle(float val) => Interop.mkAaxisAttr("tickangle", val);
        /// Sets a tick label prefix.
        public static Box<IAaxisProperty> tickprefix(string val) => Interop.mkAaxisAttr("tickprefix", val);
        /// Sets a tick label suffix.
        public static Box<IAaxisProperty> ticksuffix(string val) => Interop.mkAaxisAttr("ticksuffix", val);
        /// If \"true\", even 4-digit integers are separated
        public static Box<IAaxisProperty> separatethousands(bool val) => Interop.mkAaxisAttr("separatethousands", val);
        /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see:  We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        public static Box<IAaxisProperty> tickformat(string val) => Interop.mkAaxisAttr("tickformat", val);
        public static Box<IAaxisProperty> tickformatstops(params Box<ITickformatstopsProperty>[] properties) => Interop.mkAaxisAttr("tickformatstops", Bindings.flattenProperties(properties));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IAaxisProperty> categoryarray(bool val) => Interop.mkAaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IAaxisProperty> categoryarray(params bool[] values) => Interop.mkAaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IAaxisProperty> categoryarray(System.DateTime val) => Interop.mkAaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IAaxisProperty> categoryarray(params System.DateTime[] values) => Interop.mkAaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IAaxisProperty> categoryarray(float val) => Interop.mkAaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IAaxisProperty> categoryarray(params float[] values) => Interop.mkAaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IAaxisProperty> categoryarray(int val) => Interop.mkAaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IAaxisProperty> categoryarray(params int[] values) => Interop.mkAaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IAaxisProperty> categoryarray(string val) => Interop.mkAaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IAaxisProperty> categoryarray(params string[] values) => Interop.mkAaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IAaxisProperty> categoryarray(IEnumerable<bool[]> values) => Interop.mkAaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IAaxisProperty> categoryarray(List<bool[]> values) => Interop.mkAaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IAaxisProperty> categoryarray(params bool[][] values) => Interop.mkAaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IAaxisProperty> categoryarray(IEnumerable<IEnumerable<string>> values) => Interop.mkAaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IAaxisProperty> categoryarray(List<string[]> values) => Interop.mkAaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IAaxisProperty> categoryarray(params string[][] values) => Interop.mkAaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IAaxisProperty> categoryarray(IEnumerable<IEnumerable<int>> values) => Interop.mkAaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IAaxisProperty> categoryarray(List<int[]> values) => Interop.mkAaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IAaxisProperty> categoryarray(params int[][] values) => Interop.mkAaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IAaxisProperty> categoryarray(IEnumerable<IEnumerable<float>> values) => Interop.mkAaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IAaxisProperty> categoryarray(List<float[]> values) => Interop.mkAaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IAaxisProperty> categoryarray(params float[][] values) => Interop.mkAaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IAaxisProperty> categoryarray(Literals.PlotData[] values) => Interop.mkAaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IAaxisProperty> categoryarray(IEnumerable<bool?> values) => Interop.mkAaxisAttr("categoryarray", values.ToArray());
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IAaxisProperty> categoryarray(IEnumerable<System.DateTime?> values) => Interop.mkAaxisAttr("categoryarray", values.ToArray());
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IAaxisProperty> categoryarray(IEnumerable<int?> values) => Interop.mkAaxisAttr("categoryarray", values.ToArray());
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IAaxisProperty> categoryarray(IEnumerable<float?> values) => Interop.mkAaxisAttr("categoryarray", values.ToArray());
        /// Extra padding between label and the axis
        public static Box<IAaxisProperty> labelpadding(int val) => Interop.mkAaxisAttr("labelpadding", val);
        /// Sets a axis label prefix.
        public static Box<IAaxisProperty> labelprefix(string val) => Interop.mkAaxisAttr("labelprefix", val);
        /// Sets a axis label suffix.
        public static Box<IAaxisProperty> labelsuffix(string val) => Interop.mkAaxisAttr("labelsuffix", val);
        /// Determines whether or not a line bounding this axis is drawn.
        public static Box<IAaxisProperty> showline(bool val) => Interop.mkAaxisAttr("showline", val);
        /// Sets the axis line color.
        public static Box<IAaxisProperty> linecolor(string val) => Interop.mkAaxisAttr("linecolor", val);
        /// Sets the width (in px) of the axis line.
        public static Box<IAaxisProperty> linewidth(int val) => Interop.mkAaxisAttr("linewidth", val);
        /// Sets the width (in px) of the axis line.
        public static Box<IAaxisProperty> linewidth(float val) => Interop.mkAaxisAttr("linewidth", val);
        /// Sets the axis line color.
        public static Box<IAaxisProperty> gridcolor(string val) => Interop.mkAaxisAttr("gridcolor", val);
        /// Sets the width (in px) of the axis line.
        public static Box<IAaxisProperty> gridwidth(int val) => Interop.mkAaxisAttr("gridwidth", val);
        /// Sets the width (in px) of the axis line.
        public static Box<IAaxisProperty> gridwidth(float val) => Interop.mkAaxisAttr("gridwidth", val);
        /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
        public static Box<IAaxisProperty> showgrid(bool val) => Interop.mkAaxisAttr("showgrid", val);
        /// Sets the number of minor grid ticks per major grid tick
        public static Box<IAaxisProperty> minorgridcount(int val) => Interop.mkAaxisAttr("minorgridcount", val);
        /// Sets the width (in px) of the grid lines.
        public static Box<IAaxisProperty> minorgridwidth(int val) => Interop.mkAaxisAttr("minorgridwidth", val);
        /// Sets the width (in px) of the grid lines.
        public static Box<IAaxisProperty> minorgridwidth(float val) => Interop.mkAaxisAttr("minorgridwidth", val);
        /// Sets the color of the grid lines.
        public static Box<IAaxisProperty> minorgridcolor(string val) => Interop.mkAaxisAttr("minorgridcolor", val);
        /// Determines whether or not a line is drawn at along the starting value of this axis. If *true*, the start line is drawn on top of the grid lines.
        public static Box<IAaxisProperty> startline(bool val) => Interop.mkAaxisAttr("startline", val);
        /// Sets the line color of the start line.
        public static Box<IAaxisProperty> startlinecolor(string val) => Interop.mkAaxisAttr("startlinecolor", val);
        /// Sets the width (in px) of the start line.
        public static Box<IAaxisProperty> startlinewidth(int val) => Interop.mkAaxisAttr("startlinewidth", val);
        /// Sets the width (in px) of the start line.
        public static Box<IAaxisProperty> startlinewidth(float val) => Interop.mkAaxisAttr("startlinewidth", val);
        /// Determines whether or not a line is drawn at along the final value of this axis. If *true*, the end line is drawn on top of the grid lines.
        public static Box<IAaxisProperty> endline(bool val) => Interop.mkAaxisAttr("endline", val);
        /// Sets the width (in px) of the end line.
        public static Box<IAaxisProperty> endlinewidth(int val) => Interop.mkAaxisAttr("endlinewidth", val);
        /// Sets the width (in px) of the end line.
        public static Box<IAaxisProperty> endlinewidth(float val) => Interop.mkAaxisAttr("endlinewidth", val);
        /// Sets the line color of the end line.
        public static Box<IAaxisProperty> endlinecolor(string val) => Interop.mkAaxisAttr("endlinecolor", val);
        /// The starting index of grid lines along the axis
        public static Box<IAaxisProperty> tick0(int val) => Interop.mkAaxisAttr("tick0", val);
        /// The starting index of grid lines along the axis
        public static Box<IAaxisProperty> tick0(float val) => Interop.mkAaxisAttr("tick0", val);
        /// The stride between grid lines along the axis
        public static Box<IAaxisProperty> dtick(int val) => Interop.mkAaxisAttr("dtick", val);
        /// The stride between grid lines along the axis
        public static Box<IAaxisProperty> dtick(float val) => Interop.mkAaxisAttr("dtick", val);
        /// The starting index of grid lines along the axis
        public static Box<IAaxisProperty> arraytick0(int val) => Interop.mkAaxisAttr("arraytick0", val);
        /// The stride between grid lines along the axis
        public static Box<IAaxisProperty> arraydtick(int val) => Interop.mkAaxisAttr("arraydtick", val);
        /// Sets the source reference on plot.ly for  tickvals .
        public static Box<IAaxisProperty> tickvalssrc(string val) => Interop.mkAaxisAttr("tickvalssrc", val);
        /// Sets the source reference on plot.ly for  ticktext .
        public static Box<IAaxisProperty> ticktextsrc(string val) => Interop.mkAaxisAttr("ticktextsrc", val);
        /// Sets the source reference on plot.ly for  categoryarray .
        public static Box<IAaxisProperty> categoryarraysrc(string val) => Interop.mkAaxisAttr("categoryarraysrc", val);
        /// Sets the tick length (in px).
        public static Box<IAaxisProperty> ticklen(int val) => Interop.mkAaxisAttr("ticklen", val);
        /// Sets the tick length (in px).
        public static Box<IAaxisProperty> ticklen(float val) => Interop.mkAaxisAttr("ticklen", val);
        /// Sets the tick width (in px).
        public static Box<IAaxisProperty> tickwidth(int val) => Interop.mkAaxisAttr("tickwidth", val);
        /// Sets the tick width (in px).
        public static Box<IAaxisProperty> tickwidth(float val) => Interop.mkAaxisAttr("tickwidth", val);
        /// Sets the tick color.
        public static Box<IAaxisProperty> tickcolor(string val) => Interop.mkAaxisAttr("tickcolor", val);
        /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        public static Box<IAaxisProperty> hoverformat(string val) => Interop.mkAaxisAttr("hoverformat", val);
        /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
        public static Box<IAaxisProperty> min(int val) => Interop.mkAaxisAttr("min", val);
        /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
        public static Box<IAaxisProperty> min(float val) => Interop.mkAaxisAttr("min", val);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<IAaxisProperty> uirevision(bool val) => Interop.mkAaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<IAaxisProperty> uirevision(params bool[] values) => Interop.mkAaxisAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<IAaxisProperty> uirevision(System.DateTime val) => Interop.mkAaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<IAaxisProperty> uirevision(params System.DateTime[] values) => Interop.mkAaxisAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<IAaxisProperty> uirevision(int val) => Interop.mkAaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<IAaxisProperty> uirevision(params int[] values) => Interop.mkAaxisAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<IAaxisProperty> uirevision(float val) => Interop.mkAaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<IAaxisProperty> uirevision(params float[] values) => Interop.mkAaxisAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<IAaxisProperty> uirevision(string val) => Interop.mkAaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<IAaxisProperty> uirevision(params string[] values) => Interop.mkAaxisAttr("uirevision", values);
    }

    public static partial class Aaxis
    {
        /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
        public static partial class _type
        {
            public static Box<IAaxisProperty> dash() => Interop.mkAaxisAttr("type", "-");
            public static Box<IAaxisProperty> category() => Interop.mkAaxisAttr("type", "category");
            public static Box<IAaxisProperty> date() => Interop.mkAaxisAttr("type", "date");
            public static Box<IAaxisProperty> linear() => Interop.mkAaxisAttr("type", "linear");
        }

        /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
        public static partial class Autorange
        {
            public static Box<IAaxisProperty> reversed() => Interop.mkAaxisAttr("autorange", "reversed");
            public static Box<IAaxisProperty> _false() => Interop.mkAaxisAttr("autorange", false);
            public static Box<IAaxisProperty> _true() => Interop.mkAaxisAttr("autorange", true);
        }

        /// If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data.
        public static partial class Rangemode
        {
            public static Box<IAaxisProperty> nonnegative() => Interop.mkAaxisAttr("rangemode", "nonnegative");
            public static Box<IAaxisProperty> normal() => Interop.mkAaxisAttr("rangemode", "normal");
            public static Box<IAaxisProperty> tozero() => Interop.mkAaxisAttr("rangemode", "tozero");
        }

        public static partial class Cheatertype
        {
            public static Box<IAaxisProperty> index() => Interop.mkAaxisAttr("cheatertype", "index");
            public static Box<IAaxisProperty> value() => Interop.mkAaxisAttr("cheatertype", "value");
        }

        public static partial class Tickmode
        {
            public static Box<IAaxisProperty> array() => Interop.mkAaxisAttr("tickmode", "array");
            public static Box<IAaxisProperty> auto() => Interop.mkAaxisAttr("tickmode", "auto");
            public static Box<IAaxisProperty> linear() => Interop.mkAaxisAttr("tickmode", "linear");
        }

        /// Determines whether axis labels are drawn on the low side, the high side, both, or neither side of the axis.
        public static partial class Showticklabels
        {
            public static Box<IAaxisProperty> both() => Interop.mkAaxisAttr("showticklabels", "both");
            public static Box<IAaxisProperty> _end() => Interop.mkAaxisAttr("showticklabels", "end");
            public static Box<IAaxisProperty> none() => Interop.mkAaxisAttr("showticklabels", "none");
            public static Box<IAaxisProperty> start() => Interop.mkAaxisAttr("showticklabels", "start");
        }

        /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
        public static partial class Showtickprefix
        {
            public static Box<IAaxisProperty> all() => Interop.mkAaxisAttr("showtickprefix", "all");
            public static Box<IAaxisProperty> first() => Interop.mkAaxisAttr("showtickprefix", "first");
            public static Box<IAaxisProperty> last() => Interop.mkAaxisAttr("showtickprefix", "last");
            public static Box<IAaxisProperty> none() => Interop.mkAaxisAttr("showtickprefix", "none");
        }

        /// Same as `showtickprefix` but for tick suffixes.
        public static partial class Showticksuffix
        {
            public static Box<IAaxisProperty> all() => Interop.mkAaxisAttr("showticksuffix", "all");
            public static Box<IAaxisProperty> first() => Interop.mkAaxisAttr("showticksuffix", "first");
            public static Box<IAaxisProperty> last() => Interop.mkAaxisAttr("showticksuffix", "last");
            public static Box<IAaxisProperty> none() => Interop.mkAaxisAttr("showticksuffix", "none");
        }

        /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
        public static partial class Showexponent
        {
            public static Box<IAaxisProperty> all() => Interop.mkAaxisAttr("showexponent", "all");
            public static Box<IAaxisProperty> first() => Interop.mkAaxisAttr("showexponent", "first");
            public static Box<IAaxisProperty> last() => Interop.mkAaxisAttr("showexponent", "last");
            public static Box<IAaxisProperty> none() => Interop.mkAaxisAttr("showexponent", "none");
        }

        /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
        public static partial class Exponentformat
        {
            public static Box<IAaxisProperty> B() => Interop.mkAaxisAttr("exponentformat", "B");
            public static Box<IAaxisProperty> E() => Interop.mkAaxisAttr("exponentformat", "E");
            public static Box<IAaxisProperty> SI() => Interop.mkAaxisAttr("exponentformat", "SI");
            public static Box<IAaxisProperty> e() => Interop.mkAaxisAttr("exponentformat", "e");
            public static Box<IAaxisProperty> none() => Interop.mkAaxisAttr("exponentformat", "none");
            public static Box<IAaxisProperty> power() => Interop.mkAaxisAttr("exponentformat", "power");
        }

        /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`.
        public static partial class Categoryorder
        {
            public static Box<IAaxisProperty> array() => Interop.mkAaxisAttr("categoryorder", "array");
            public static Box<IAaxisProperty> categoryAscending() => Interop.mkAaxisAttr("categoryorder", "category ascending");
            public static Box<IAaxisProperty> categoryDescending() => Interop.mkAaxisAttr("categoryorder", "category descending");
            public static Box<IAaxisProperty> trace() => Interop.mkAaxisAttr("categoryorder", "trace");
        }

        /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
        public static partial class Ticks
        {
            public static Box<IAaxisProperty> none() => Interop.mkAaxisAttr("ticks", "");
            public static Box<IAaxisProperty> inside() => Interop.mkAaxisAttr("ticks", "inside");
            public static Box<IAaxisProperty> outside() => Interop.mkAaxisAttr("ticks", "outside");
        }

        /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
        public static partial class Layer
        {
            public static Box<IAaxisProperty> aboveTraces() => Interop.mkAaxisAttr("layer", "above traces");
            public static Box<IAaxisProperty> belowTraces() => Interop.mkAaxisAttr("layer", "below traces");
        }
    }
}