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

    public static partial class Baxis
    {
        /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
        public static Box<IBaxisProperty> color(string val) => Interop.mkBaxisAttr("color", val);
        public static Box<IBaxisProperty> smoothing(int val) => Interop.mkBaxisAttr("smoothing", val);
        public static Box<IBaxisProperty> smoothing(float val) => Interop.mkBaxisAttr("smoothing", val);
        public static Box<IBaxisProperty> title(params Box<ITitleProperty>[] properties) => Interop.mkBaxisAttr("title", Bindings.flattenProperties(properties));
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IBaxisProperty> range(bool val) => Interop.mkBaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IBaxisProperty> range(IEnumerable<bool> values) => Interop.mkBaxisAttr("range", values.ToArray());
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IBaxisProperty> range(System.DateTime val) => Interop.mkBaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IBaxisProperty> range(IEnumerable<System.DateTime> values) => Interop.mkBaxisAttr("range", values.ToArray());
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IBaxisProperty> range(float val) => Interop.mkBaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IBaxisProperty> range(IEnumerable<float> values) => Interop.mkBaxisAttr("range", values.ToArray());
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IBaxisProperty> range(int val) => Interop.mkBaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IBaxisProperty> range(IEnumerable<int> values) => Interop.mkBaxisAttr("range", values.ToArray());
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IBaxisProperty> range(string val) => Interop.mkBaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IBaxisProperty> range(IEnumerable<string> values) => Interop.mkBaxisAttr("range", values.ToArray());
        /// Determines whether or not this axis is zoom-able. If true, then zoom is disabled.
        public static Box<IBaxisProperty> fixedrange(bool val) => Interop.mkBaxisAttr("fixedrange", val);
        /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
        public static Box<IBaxisProperty> nticks(int val) => Interop.mkBaxisAttr("nticks", val);
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IBaxisProperty> tickvals(bool val) => Interop.mkBaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IBaxisProperty> tickvals(params bool[] values) => Interop.mkBaxisAttr("tickvals", values);
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IBaxisProperty> tickvals(System.DateTime val) => Interop.mkBaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IBaxisProperty> tickvals(params System.DateTime[] values) => Interop.mkBaxisAttr("tickvals", values);
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IBaxisProperty> tickvals(float val) => Interop.mkBaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IBaxisProperty> tickvals(params float[] values) => Interop.mkBaxisAttr("tickvals", values);
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IBaxisProperty> tickvals(int val) => Interop.mkBaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IBaxisProperty> tickvals(params int[] values) => Interop.mkBaxisAttr("tickvals", values);
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IBaxisProperty> tickvals(string val) => Interop.mkBaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IBaxisProperty> tickvals(params string[] values) => Interop.mkBaxisAttr("tickvals", values);
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IBaxisProperty> tickvals(IEnumerable<bool[]> values) => Interop.mkBaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IBaxisProperty> tickvals(List<bool[]> values) => Interop.mkBaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IBaxisProperty> tickvals(params bool[][] values) => Interop.mkBaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IBaxisProperty> tickvals(IEnumerable<IEnumerable<string>> values) => Interop.mkBaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IBaxisProperty> tickvals(List<string[]> values) => Interop.mkBaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IBaxisProperty> tickvals(params string[][] values) => Interop.mkBaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IBaxisProperty> tickvals(IEnumerable<IEnumerable<int>> values) => Interop.mkBaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IBaxisProperty> tickvals(List<int[]> values) => Interop.mkBaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IBaxisProperty> tickvals(params int[][] values) => Interop.mkBaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IBaxisProperty> tickvals(IEnumerable<IEnumerable<float>> values) => Interop.mkBaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IBaxisProperty> tickvals(List<float[]> values) => Interop.mkBaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IBaxisProperty> tickvals(params float[][] values) => Interop.mkBaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IBaxisProperty> tickvals(Literals.PlotData[] values) => Interop.mkBaxisAttr("tickvals", values);
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IBaxisProperty> tickvals(IEnumerable<bool?> values) => Interop.mkBaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IBaxisProperty> tickvals(IEnumerable<System.DateTime?> values) => Interop.mkBaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IBaxisProperty> tickvals(IEnumerable<int?> values) => Interop.mkBaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IBaxisProperty> tickvals(IEnumerable<float?> values) => Interop.mkBaxisAttr("tickvals", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IBaxisProperty> ticktext(bool val) => Interop.mkBaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IBaxisProperty> ticktext(params bool[] values) => Interop.mkBaxisAttr("ticktext", values);
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IBaxisProperty> ticktext(System.DateTime val) => Interop.mkBaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IBaxisProperty> ticktext(params System.DateTime[] values) => Interop.mkBaxisAttr("ticktext", values);
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IBaxisProperty> ticktext(float val) => Interop.mkBaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IBaxisProperty> ticktext(params float[] values) => Interop.mkBaxisAttr("ticktext", values);
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IBaxisProperty> ticktext(int val) => Interop.mkBaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IBaxisProperty> ticktext(params int[] values) => Interop.mkBaxisAttr("ticktext", values);
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IBaxisProperty> ticktext(string val) => Interop.mkBaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IBaxisProperty> ticktext(params string[] values) => Interop.mkBaxisAttr("ticktext", values);
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IBaxisProperty> ticktext(IEnumerable<bool[]> values) => Interop.mkBaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IBaxisProperty> ticktext(List<bool[]> values) => Interop.mkBaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IBaxisProperty> ticktext(params bool[][] values) => Interop.mkBaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IBaxisProperty> ticktext(IEnumerable<IEnumerable<string>> values) => Interop.mkBaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IBaxisProperty> ticktext(List<string[]> values) => Interop.mkBaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IBaxisProperty> ticktext(params string[][] values) => Interop.mkBaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IBaxisProperty> ticktext(IEnumerable<IEnumerable<int>> values) => Interop.mkBaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IBaxisProperty> ticktext(List<int[]> values) => Interop.mkBaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IBaxisProperty> ticktext(params int[][] values) => Interop.mkBaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IBaxisProperty> ticktext(IEnumerable<IEnumerable<float>> values) => Interop.mkBaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IBaxisProperty> ticktext(List<float[]> values) => Interop.mkBaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IBaxisProperty> ticktext(params float[][] values) => Interop.mkBaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IBaxisProperty> ticktext(Literals.PlotData[] values) => Interop.mkBaxisAttr("ticktext", values);
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IBaxisProperty> ticktext(IEnumerable<bool?> values) => Interop.mkBaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IBaxisProperty> ticktext(IEnumerable<System.DateTime?> values) => Interop.mkBaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IBaxisProperty> ticktext(IEnumerable<int?> values) => Interop.mkBaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IBaxisProperty> ticktext(IEnumerable<float?> values) => Interop.mkBaxisAttr("ticktext", values.ToArray());
        /// Sets the tick font.
        public static Box<IBaxisProperty> tickfont(params Box<ITickfontProperty>[] properties) => Interop.mkBaxisAttr("tickfont", Bindings.flattenProperties(properties));
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        public static Box<IBaxisProperty> tickangle(int val) => Interop.mkBaxisAttr("tickangle", val);
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        public static Box<IBaxisProperty> tickangle(float val) => Interop.mkBaxisAttr("tickangle", val);
        /// Sets a tick label prefix.
        public static Box<IBaxisProperty> tickprefix(string val) => Interop.mkBaxisAttr("tickprefix", val);
        /// Sets a tick label suffix.
        public static Box<IBaxisProperty> ticksuffix(string val) => Interop.mkBaxisAttr("ticksuffix", val);
        /// If \"true\", even 4-digit integers are separated
        public static Box<IBaxisProperty> separatethousands(bool val) => Interop.mkBaxisAttr("separatethousands", val);
        /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see:  We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        public static Box<IBaxisProperty> tickformat(string val) => Interop.mkBaxisAttr("tickformat", val);
        public static Box<IBaxisProperty> tickformatstops(params Box<ITickformatstopsProperty>[] properties) => Interop.mkBaxisAttr("tickformatstops", Bindings.flattenProperties(properties));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IBaxisProperty> categoryarray(bool val) => Interop.mkBaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IBaxisProperty> categoryarray(params bool[] values) => Interop.mkBaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IBaxisProperty> categoryarray(System.DateTime val) => Interop.mkBaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IBaxisProperty> categoryarray(params System.DateTime[] values) => Interop.mkBaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IBaxisProperty> categoryarray(float val) => Interop.mkBaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IBaxisProperty> categoryarray(params float[] values) => Interop.mkBaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IBaxisProperty> categoryarray(int val) => Interop.mkBaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IBaxisProperty> categoryarray(params int[] values) => Interop.mkBaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IBaxisProperty> categoryarray(string val) => Interop.mkBaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IBaxisProperty> categoryarray(params string[] values) => Interop.mkBaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IBaxisProperty> categoryarray(IEnumerable<bool[]> values) => Interop.mkBaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IBaxisProperty> categoryarray(List<bool[]> values) => Interop.mkBaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IBaxisProperty> categoryarray(params bool[][] values) => Interop.mkBaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IBaxisProperty> categoryarray(IEnumerable<IEnumerable<string>> values) => Interop.mkBaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IBaxisProperty> categoryarray(List<string[]> values) => Interop.mkBaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IBaxisProperty> categoryarray(params string[][] values) => Interop.mkBaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IBaxisProperty> categoryarray(IEnumerable<IEnumerable<int>> values) => Interop.mkBaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IBaxisProperty> categoryarray(List<int[]> values) => Interop.mkBaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IBaxisProperty> categoryarray(params int[][] values) => Interop.mkBaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IBaxisProperty> categoryarray(IEnumerable<IEnumerable<float>> values) => Interop.mkBaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IBaxisProperty> categoryarray(List<float[]> values) => Interop.mkBaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IBaxisProperty> categoryarray(params float[][] values) => Interop.mkBaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IBaxisProperty> categoryarray(Literals.PlotData[] values) => Interop.mkBaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IBaxisProperty> categoryarray(IEnumerable<bool?> values) => Interop.mkBaxisAttr("categoryarray", values.ToArray());
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IBaxisProperty> categoryarray(IEnumerable<System.DateTime?> values) => Interop.mkBaxisAttr("categoryarray", values.ToArray());
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IBaxisProperty> categoryarray(IEnumerable<int?> values) => Interop.mkBaxisAttr("categoryarray", values.ToArray());
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IBaxisProperty> categoryarray(IEnumerable<float?> values) => Interop.mkBaxisAttr("categoryarray", values.ToArray());
        /// Extra padding between label and the axis
        public static Box<IBaxisProperty> labelpadding(int val) => Interop.mkBaxisAttr("labelpadding", val);
        /// Sets a axis label prefix.
        public static Box<IBaxisProperty> labelprefix(string val) => Interop.mkBaxisAttr("labelprefix", val);
        /// Sets a axis label suffix.
        public static Box<IBaxisProperty> labelsuffix(string val) => Interop.mkBaxisAttr("labelsuffix", val);
        /// Determines whether or not a line bounding this axis is drawn.
        public static Box<IBaxisProperty> showline(bool val) => Interop.mkBaxisAttr("showline", val);
        /// Sets the axis line color.
        public static Box<IBaxisProperty> linecolor(string val) => Interop.mkBaxisAttr("linecolor", val);
        /// Sets the width (in px) of the axis line.
        public static Box<IBaxisProperty> linewidth(int val) => Interop.mkBaxisAttr("linewidth", val);
        /// Sets the width (in px) of the axis line.
        public static Box<IBaxisProperty> linewidth(float val) => Interop.mkBaxisAttr("linewidth", val);
        /// Sets the axis line color.
        public static Box<IBaxisProperty> gridcolor(string val) => Interop.mkBaxisAttr("gridcolor", val);
        /// Sets the width (in px) of the axis line.
        public static Box<IBaxisProperty> gridwidth(int val) => Interop.mkBaxisAttr("gridwidth", val);
        /// Sets the width (in px) of the axis line.
        public static Box<IBaxisProperty> gridwidth(float val) => Interop.mkBaxisAttr("gridwidth", val);
        /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
        public static Box<IBaxisProperty> showgrid(bool val) => Interop.mkBaxisAttr("showgrid", val);
        /// Sets the number of minor grid ticks per major grid tick
        public static Box<IBaxisProperty> minorgridcount(int val) => Interop.mkBaxisAttr("minorgridcount", val);
        /// Sets the width (in px) of the grid lines.
        public static Box<IBaxisProperty> minorgridwidth(int val) => Interop.mkBaxisAttr("minorgridwidth", val);
        /// Sets the width (in px) of the grid lines.
        public static Box<IBaxisProperty> minorgridwidth(float val) => Interop.mkBaxisAttr("minorgridwidth", val);
        /// Sets the color of the grid lines.
        public static Box<IBaxisProperty> minorgridcolor(string val) => Interop.mkBaxisAttr("minorgridcolor", val);
        /// Determines whether or not a line is drawn at along the starting value of this axis. If *true*, the start line is drawn on top of the grid lines.
        public static Box<IBaxisProperty> startline(bool val) => Interop.mkBaxisAttr("startline", val);
        /// Sets the line color of the start line.
        public static Box<IBaxisProperty> startlinecolor(string val) => Interop.mkBaxisAttr("startlinecolor", val);
        /// Sets the width (in px) of the start line.
        public static Box<IBaxisProperty> startlinewidth(int val) => Interop.mkBaxisAttr("startlinewidth", val);
        /// Sets the width (in px) of the start line.
        public static Box<IBaxisProperty> startlinewidth(float val) => Interop.mkBaxisAttr("startlinewidth", val);
        /// Determines whether or not a line is drawn at along the final value of this axis. If *true*, the end line is drawn on top of the grid lines.
        public static Box<IBaxisProperty> endline(bool val) => Interop.mkBaxisAttr("endline", val);
        /// Sets the width (in px) of the end line.
        public static Box<IBaxisProperty> endlinewidth(int val) => Interop.mkBaxisAttr("endlinewidth", val);
        /// Sets the width (in px) of the end line.
        public static Box<IBaxisProperty> endlinewidth(float val) => Interop.mkBaxisAttr("endlinewidth", val);
        /// Sets the line color of the end line.
        public static Box<IBaxisProperty> endlinecolor(string val) => Interop.mkBaxisAttr("endlinecolor", val);
        /// The starting index of grid lines along the axis
        public static Box<IBaxisProperty> tick0(int val) => Interop.mkBaxisAttr("tick0", val);
        /// The starting index of grid lines along the axis
        public static Box<IBaxisProperty> tick0(float val) => Interop.mkBaxisAttr("tick0", val);
        /// The stride between grid lines along the axis
        public static Box<IBaxisProperty> dtick(int val) => Interop.mkBaxisAttr("dtick", val);
        /// The stride between grid lines along the axis
        public static Box<IBaxisProperty> dtick(float val) => Interop.mkBaxisAttr("dtick", val);
        /// The starting index of grid lines along the axis
        public static Box<IBaxisProperty> arraytick0(int val) => Interop.mkBaxisAttr("arraytick0", val);
        /// The stride between grid lines along the axis
        public static Box<IBaxisProperty> arraydtick(int val) => Interop.mkBaxisAttr("arraydtick", val);
        /// Sets the source reference on plot.ly for  tickvals .
        public static Box<IBaxisProperty> tickvalssrc(string val) => Interop.mkBaxisAttr("tickvalssrc", val);
        /// Sets the source reference on plot.ly for  ticktext .
        public static Box<IBaxisProperty> ticktextsrc(string val) => Interop.mkBaxisAttr("ticktextsrc", val);
        /// Sets the source reference on plot.ly for  categoryarray .
        public static Box<IBaxisProperty> categoryarraysrc(string val) => Interop.mkBaxisAttr("categoryarraysrc", val);
        /// Sets the tick length (in px).
        public static Box<IBaxisProperty> ticklen(int val) => Interop.mkBaxisAttr("ticklen", val);
        /// Sets the tick length (in px).
        public static Box<IBaxisProperty> ticklen(float val) => Interop.mkBaxisAttr("ticklen", val);
        /// Sets the tick width (in px).
        public static Box<IBaxisProperty> tickwidth(int val) => Interop.mkBaxisAttr("tickwidth", val);
        /// Sets the tick width (in px).
        public static Box<IBaxisProperty> tickwidth(float val) => Interop.mkBaxisAttr("tickwidth", val);
        /// Sets the tick color.
        public static Box<IBaxisProperty> tickcolor(string val) => Interop.mkBaxisAttr("tickcolor", val);
        /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        public static Box<IBaxisProperty> hoverformat(string val) => Interop.mkBaxisAttr("hoverformat", val);
        /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
        public static Box<IBaxisProperty> min(int val) => Interop.mkBaxisAttr("min", val);
        /// The minimum value visible on this axis. The maximum is determined by the sum minus the minimum values of the other two axes. The full view corresponds to all the minima set to zero.
        public static Box<IBaxisProperty> min(float val) => Interop.mkBaxisAttr("min", val);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<IBaxisProperty> uirevision(bool val) => Interop.mkBaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<IBaxisProperty> uirevision(params bool[] values) => Interop.mkBaxisAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<IBaxisProperty> uirevision(System.DateTime val) => Interop.mkBaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<IBaxisProperty> uirevision(params System.DateTime[] values) => Interop.mkBaxisAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<IBaxisProperty> uirevision(int val) => Interop.mkBaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<IBaxisProperty> uirevision(params int[] values) => Interop.mkBaxisAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<IBaxisProperty> uirevision(float val) => Interop.mkBaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<IBaxisProperty> uirevision(params float[] values) => Interop.mkBaxisAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<IBaxisProperty> uirevision(string val) => Interop.mkBaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `min`, and `title` if in `editable: true` configuration. Defaults to `ternary<N>.uirevision`.
        public static Box<IBaxisProperty> uirevision(params string[] values) => Interop.mkBaxisAttr("uirevision", values);
    }

    public static partial class Baxis
    {
        /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
        public static partial class _type
        {
            public static Box<IBaxisProperty> dash() => Interop.mkBaxisAttr("type", "-");
            public static Box<IBaxisProperty> category() => Interop.mkBaxisAttr("type", "category");
            public static Box<IBaxisProperty> date() => Interop.mkBaxisAttr("type", "date");
            public static Box<IBaxisProperty> linear() => Interop.mkBaxisAttr("type", "linear");
        }

        /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
        public static partial class Autorange
        {
            public static Box<IBaxisProperty> reversed() => Interop.mkBaxisAttr("autorange", "reversed");
            public static Box<IBaxisProperty> _false() => Interop.mkBaxisAttr("autorange", false);
            public static Box<IBaxisProperty> _true() => Interop.mkBaxisAttr("autorange", true);
        }

        /// If *normal*, the range is computed in relation to the extrema of the input data. If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data.
        public static partial class Rangemode
        {
            public static Box<IBaxisProperty> nonnegative() => Interop.mkBaxisAttr("rangemode", "nonnegative");
            public static Box<IBaxisProperty> normal() => Interop.mkBaxisAttr("rangemode", "normal");
            public static Box<IBaxisProperty> tozero() => Interop.mkBaxisAttr("rangemode", "tozero");
        }

        public static partial class Cheatertype
        {
            public static Box<IBaxisProperty> index() => Interop.mkBaxisAttr("cheatertype", "index");
            public static Box<IBaxisProperty> value() => Interop.mkBaxisAttr("cheatertype", "value");
        }

        public static partial class Tickmode
        {
            public static Box<IBaxisProperty> array() => Interop.mkBaxisAttr("tickmode", "array");
            public static Box<IBaxisProperty> auto() => Interop.mkBaxisAttr("tickmode", "auto");
            public static Box<IBaxisProperty> linear() => Interop.mkBaxisAttr("tickmode", "linear");
        }

        /// Determines whether axis labels are drawn on the low side, the high side, both, or neither side of the axis.
        public static partial class Showticklabels
        {
            public static Box<IBaxisProperty> both() => Interop.mkBaxisAttr("showticklabels", "both");
            public static Box<IBaxisProperty> _end() => Interop.mkBaxisAttr("showticklabels", "end");
            public static Box<IBaxisProperty> none() => Interop.mkBaxisAttr("showticklabels", "none");
            public static Box<IBaxisProperty> start() => Interop.mkBaxisAttr("showticklabels", "start");
        }

        /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
        public static partial class Showtickprefix
        {
            public static Box<IBaxisProperty> all() => Interop.mkBaxisAttr("showtickprefix", "all");
            public static Box<IBaxisProperty> first() => Interop.mkBaxisAttr("showtickprefix", "first");
            public static Box<IBaxisProperty> last() => Interop.mkBaxisAttr("showtickprefix", "last");
            public static Box<IBaxisProperty> none() => Interop.mkBaxisAttr("showtickprefix", "none");
        }

        /// Same as `showtickprefix` but for tick suffixes.
        public static partial class Showticksuffix
        {
            public static Box<IBaxisProperty> all() => Interop.mkBaxisAttr("showticksuffix", "all");
            public static Box<IBaxisProperty> first() => Interop.mkBaxisAttr("showticksuffix", "first");
            public static Box<IBaxisProperty> last() => Interop.mkBaxisAttr("showticksuffix", "last");
            public static Box<IBaxisProperty> none() => Interop.mkBaxisAttr("showticksuffix", "none");
        }

        /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
        public static partial class Showexponent
        {
            public static Box<IBaxisProperty> all() => Interop.mkBaxisAttr("showexponent", "all");
            public static Box<IBaxisProperty> first() => Interop.mkBaxisAttr("showexponent", "first");
            public static Box<IBaxisProperty> last() => Interop.mkBaxisAttr("showexponent", "last");
            public static Box<IBaxisProperty> none() => Interop.mkBaxisAttr("showexponent", "none");
        }

        /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
        public static partial class Exponentformat
        {
            public static Box<IBaxisProperty> B() => Interop.mkBaxisAttr("exponentformat", "B");
            public static Box<IBaxisProperty> E() => Interop.mkBaxisAttr("exponentformat", "E");
            public static Box<IBaxisProperty> SI() => Interop.mkBaxisAttr("exponentformat", "SI");
            public static Box<IBaxisProperty> e() => Interop.mkBaxisAttr("exponentformat", "e");
            public static Box<IBaxisProperty> none() => Interop.mkBaxisAttr("exponentformat", "none");
            public static Box<IBaxisProperty> power() => Interop.mkBaxisAttr("exponentformat", "power");
        }

        /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`.
        public static partial class Categoryorder
        {
            public static Box<IBaxisProperty> array() => Interop.mkBaxisAttr("categoryorder", "array");
            public static Box<IBaxisProperty> categoryAscending() => Interop.mkBaxisAttr("categoryorder", "category ascending");
            public static Box<IBaxisProperty> categoryDescending() => Interop.mkBaxisAttr("categoryorder", "category descending");
            public static Box<IBaxisProperty> trace() => Interop.mkBaxisAttr("categoryorder", "trace");
        }

        /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
        public static partial class Ticks
        {
            public static Box<IBaxisProperty> none() => Interop.mkBaxisAttr("ticks", "");
            public static Box<IBaxisProperty> inside() => Interop.mkBaxisAttr("ticks", "inside");
            public static Box<IBaxisProperty> outside() => Interop.mkBaxisAttr("ticks", "outside");
        }

        /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
        public static partial class Layer
        {
            public static Box<IBaxisProperty> aboveTraces() => Interop.mkBaxisAttr("layer", "above traces");
            public static Box<IBaxisProperty> belowTraces() => Interop.mkBaxisAttr("layer", "below traces");
        }
    }
}