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

    public static partial class Radialaxis
    {
        /// Polar chart subplots are not supported yet. This key has currently no effect.
        public static Box<IRadialaxisProperty> domain(int val) => Interop.mkRadialaxisAttr("domain", new[]{val});
        /// Polar chart subplots are not supported yet. This key has currently no effect.
        public static Box<IRadialaxisProperty> domain(IEnumerable<int> values) => Interop.mkRadialaxisAttr("domain", values.ToArray());
        /// Polar chart subplots are not supported yet. This key has currently no effect.
        public static Box<IRadialaxisProperty> domain(float val) => Interop.mkRadialaxisAttr("domain", new[]{val});
        /// Polar chart subplots are not supported yet. This key has currently no effect.
        public static Box<IRadialaxisProperty> domain(IEnumerable<float> values) => Interop.mkRadialaxisAttr("domain", values.ToArray());
        /// A single toggle to hide the axis while preserving interaction like dragging. Default is true when a cheater plot is present on the axis, otherwise false
        public static Box<IRadialaxisProperty> visible(bool val) => Interop.mkRadialaxisAttr("visible", val);
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRadialaxisProperty> range(bool val) => Interop.mkRadialaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRadialaxisProperty> range(IEnumerable<bool> values) => Interop.mkRadialaxisAttr("range", values.ToArray());
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRadialaxisProperty> range(System.DateTime val) => Interop.mkRadialaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRadialaxisProperty> range(IEnumerable<System.DateTime> values) => Interop.mkRadialaxisAttr("range", values.ToArray());
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRadialaxisProperty> range(float val) => Interop.mkRadialaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRadialaxisProperty> range(IEnumerable<float> values) => Interop.mkRadialaxisAttr("range", values.ToArray());
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRadialaxisProperty> range(int val) => Interop.mkRadialaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRadialaxisProperty> range(IEnumerable<int> values) => Interop.mkRadialaxisAttr("range", values.ToArray());
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRadialaxisProperty> range(string val) => Interop.mkRadialaxisAttr("range", new[]{val});
        /// Sets the range of this axis. If the axis `type` is *log*, then you must take the log of your desired range (e.g. to set the range from 1 to 100, set the range from 0 to 2). If the axis `type` is *date*, it should be date strings, like date data, though Date objects and unix milliseconds will be accepted and converted to strings. If the axis `type` is *category*, it should be numbers, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRadialaxisProperty> range(IEnumerable<string> values) => Interop.mkRadialaxisAttr("range", values.ToArray());
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IRadialaxisProperty> categoryarray(bool val) => Interop.mkRadialaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IRadialaxisProperty> categoryarray(params bool[] values) => Interop.mkRadialaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IRadialaxisProperty> categoryarray(System.DateTime val) => Interop.mkRadialaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IRadialaxisProperty> categoryarray(params System.DateTime[] values) => Interop.mkRadialaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IRadialaxisProperty> categoryarray(float val) => Interop.mkRadialaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IRadialaxisProperty> categoryarray(params float[] values) => Interop.mkRadialaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IRadialaxisProperty> categoryarray(int val) => Interop.mkRadialaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IRadialaxisProperty> categoryarray(params int[] values) => Interop.mkRadialaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IRadialaxisProperty> categoryarray(string val) => Interop.mkRadialaxisAttr("categoryarray", new[]{val});
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IRadialaxisProperty> categoryarray(params string[] values) => Interop.mkRadialaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IRadialaxisProperty> categoryarray(IEnumerable<bool[]> values) => Interop.mkRadialaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IRadialaxisProperty> categoryarray(List<bool[]> values) => Interop.mkRadialaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IRadialaxisProperty> categoryarray(params bool[][] values) => Interop.mkRadialaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IRadialaxisProperty> categoryarray(IEnumerable<IEnumerable<string>> values) => Interop.mkRadialaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IRadialaxisProperty> categoryarray(List<string[]> values) => Interop.mkRadialaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IRadialaxisProperty> categoryarray(params string[][] values) => Interop.mkRadialaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IRadialaxisProperty> categoryarray(IEnumerable<IEnumerable<int>> values) => Interop.mkRadialaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IRadialaxisProperty> categoryarray(List<int[]> values) => Interop.mkRadialaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IRadialaxisProperty> categoryarray(params int[][] values) => Interop.mkRadialaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IRadialaxisProperty> categoryarray(IEnumerable<IEnumerable<float>> values) => Interop.mkRadialaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IRadialaxisProperty> categoryarray(List<float[]> values) => Interop.mkRadialaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IRadialaxisProperty> categoryarray(params float[][] values) => Interop.mkRadialaxisAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IRadialaxisProperty> categoryarray(Literals.PlotData[] values) => Interop.mkRadialaxisAttr("categoryarray", values);
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IRadialaxisProperty> categoryarray(IEnumerable<bool?> values) => Interop.mkRadialaxisAttr("categoryarray", values.ToArray());
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IRadialaxisProperty> categoryarray(IEnumerable<System.DateTime?> values) => Interop.mkRadialaxisAttr("categoryarray", values.ToArray());
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IRadialaxisProperty> categoryarray(IEnumerable<int?> values) => Interop.mkRadialaxisAttr("categoryarray", values.ToArray());
        /// Sets the order in which categories on this axis appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IRadialaxisProperty> categoryarray(IEnumerable<float?> values) => Interop.mkRadialaxisAttr("categoryarray", values.ToArray());
        /// Sets the angle (in degrees) from which the radial axis is drawn. Note that by default, radial axis line on the theta=0 line corresponds to a line pointing right (like what mathematicians prefer). Defaults to the first `polar.sector` angle.
        public static Box<IRadialaxisProperty> angle(int val) => Interop.mkRadialaxisAttr("angle", val);
        /// Sets the angle (in degrees) from which the radial axis is drawn. Note that by default, radial axis line on the theta=0 line corresponds to a line pointing right (like what mathematicians prefer). Defaults to the first `polar.sector` angle.
        public static Box<IRadialaxisProperty> angle(float val) => Interop.mkRadialaxisAttr("angle", val);
        public static Box<IRadialaxisProperty> title(params Box<ITitleProperty>[] properties) => Interop.mkRadialaxisAttr("title", Bindings.flattenProperties(properties));
        /// Sets the hover text formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        public static Box<IRadialaxisProperty> hoverformat(string val) => Interop.mkRadialaxisAttr("hoverformat", val);
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
        public static Box<IRadialaxisProperty> uirevision(bool val) => Interop.mkRadialaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
        public static Box<IRadialaxisProperty> uirevision(params bool[] values) => Interop.mkRadialaxisAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
        public static Box<IRadialaxisProperty> uirevision(System.DateTime val) => Interop.mkRadialaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
        public static Box<IRadialaxisProperty> uirevision(params System.DateTime[] values) => Interop.mkRadialaxisAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
        public static Box<IRadialaxisProperty> uirevision(int val) => Interop.mkRadialaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
        public static Box<IRadialaxisProperty> uirevision(params int[] values) => Interop.mkRadialaxisAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
        public static Box<IRadialaxisProperty> uirevision(float val) => Interop.mkRadialaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
        public static Box<IRadialaxisProperty> uirevision(params float[] values) => Interop.mkRadialaxisAttr("uirevision", values);
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
        public static Box<IRadialaxisProperty> uirevision(string val) => Interop.mkRadialaxisAttr("uirevision", val);
        /// Controls persistence of user-driven changes in axis `range`, `autorange`, `angle`, and `title` if in `editable: true` configuration. Defaults to `polar<N>.uirevision`.
        public static Box<IRadialaxisProperty> uirevision(params string[] values) => Interop.mkRadialaxisAttr("uirevision", values);
        /// Sets default for all colors associated with this axis all at once: line, font, tick, and grid colors. Grid color is lightened by blending this with the plot background Individual pieces can override this.
        public static Box<IRadialaxisProperty> color(string val) => Interop.mkRadialaxisAttr("color", val);
        /// Determines whether or not a line bounding this axis is drawn.
        public static Box<IRadialaxisProperty> showline(bool val) => Interop.mkRadialaxisAttr("showline", val);
        /// Sets the axis line color.
        public static Box<IRadialaxisProperty> linecolor(string val) => Interop.mkRadialaxisAttr("linecolor", val);
        /// Sets the width (in px) of the axis line.
        public static Box<IRadialaxisProperty> linewidth(int val) => Interop.mkRadialaxisAttr("linewidth", val);
        /// Sets the width (in px) of the axis line.
        public static Box<IRadialaxisProperty> linewidth(float val) => Interop.mkRadialaxisAttr("linewidth", val);
        /// Determines whether or not grid lines are drawn. If *true*, the grid lines are drawn at every tick mark.
        public static Box<IRadialaxisProperty> showgrid(bool val) => Interop.mkRadialaxisAttr("showgrid", val);
        /// Sets the color of the grid lines.
        public static Box<IRadialaxisProperty> gridcolor(string val) => Interop.mkRadialaxisAttr("gridcolor", val);
        /// Sets the width (in px) of the grid lines.
        public static Box<IRadialaxisProperty> gridwidth(int val) => Interop.mkRadialaxisAttr("gridwidth", val);
        /// Sets the width (in px) of the grid lines.
        public static Box<IRadialaxisProperty> gridwidth(float val) => Interop.mkRadialaxisAttr("gridwidth", val);
        /// Specifies the maximum number of ticks for the particular axis. The actual number of ticks will be chosen automatically to be less than or equal to `nticks`. Has an effect only if `tickmode` is set to *auto*.
        public static Box<IRadialaxisProperty> nticks(int val) => Interop.mkRadialaxisAttr("nticks", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRadialaxisProperty> tick0(bool val) => Interop.mkRadialaxisAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRadialaxisProperty> tick0(params bool[] values) => Interop.mkRadialaxisAttr("tick0", values);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRadialaxisProperty> tick0(System.DateTime val) => Interop.mkRadialaxisAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRadialaxisProperty> tick0(params System.DateTime[] values) => Interop.mkRadialaxisAttr("tick0", values);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRadialaxisProperty> tick0(int val) => Interop.mkRadialaxisAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRadialaxisProperty> tick0(params int[] values) => Interop.mkRadialaxisAttr("tick0", values);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRadialaxisProperty> tick0(float val) => Interop.mkRadialaxisAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRadialaxisProperty> tick0(params float[] values) => Interop.mkRadialaxisAttr("tick0", values);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRadialaxisProperty> tick0(string val) => Interop.mkRadialaxisAttr("tick0", val);
        /// Sets the placement of the first tick on this axis. Use with `dtick`. If the axis `type` is *log*, then you must take the log of your starting tick (e.g. to set the starting tick to 100, set the `tick0` to 2) except when `dtick`=*L<f>* (see `dtick` for more info). If the axis `type` is *date*, it should be a date string, like date data. If the axis `type` is *category*, it should be a number, using the scale where each category is assigned a serial number from zero in the order it appears.
        public static Box<IRadialaxisProperty> tick0(params string[] values) => Interop.mkRadialaxisAttr("tick0", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IRadialaxisProperty> dtick(bool val) => Interop.mkRadialaxisAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IRadialaxisProperty> dtick(params bool[] values) => Interop.mkRadialaxisAttr("dtick", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IRadialaxisProperty> dtick(System.DateTime val) => Interop.mkRadialaxisAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IRadialaxisProperty> dtick(params System.DateTime[] values) => Interop.mkRadialaxisAttr("dtick", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IRadialaxisProperty> dtick(int val) => Interop.mkRadialaxisAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IRadialaxisProperty> dtick(params int[] values) => Interop.mkRadialaxisAttr("dtick", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IRadialaxisProperty> dtick(float val) => Interop.mkRadialaxisAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IRadialaxisProperty> dtick(params float[] values) => Interop.mkRadialaxisAttr("dtick", values);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IRadialaxisProperty> dtick(string val) => Interop.mkRadialaxisAttr("dtick", val);
        /// Sets the step in-between ticks on this axis. Use with `tick0`. Must be a positive number, or special strings available to *log* and *date* axes. If the axis `type` is *log*, then ticks are set every 10^(n*dtick) where n is the tick number. For example, to set a tick mark at 1, 10, 100, 1000, ... set dtick to 1. To set tick marks at 1, 100, 10000, ... set dtick to 2. To set tick marks at 1, 5, 25, 125, 625, 3125, ... set dtick to log_10(5), or 0.69897000433. *log* has several special values; *L<f>*, where `f` is a positive number, gives ticks linearly spaced in value (but not position). For example `tick0` = 0.1, `dtick` = *L0.5* will put ticks at 0.1, 0.6, 1.1, 1.6 etc. To show powers of 10 plus small digits between, use *D1* (all digits) or *D2* (only 2 and 5). `tick0` is ignored for *D1* and *D2*. If the axis `type` is *date*, then you must convert the time to milliseconds. For example, to set the interval between ticks to one day, set `dtick` to 86400000.0. *date* also has special values *M<n>* gives ticks spaced by a number of months. `n` must be a positive integer. To set ticks on the 15th of every third month, set `tick0` to *2000-01-15* and `dtick` to *M3*. To set ticks every 4 years, set `dtick` to *M48*
        public static Box<IRadialaxisProperty> dtick(params string[] values) => Interop.mkRadialaxisAttr("dtick", values);
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IRadialaxisProperty> tickvals(bool val) => Interop.mkRadialaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IRadialaxisProperty> tickvals(IEnumerable<bool> values) => Interop.mkRadialaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IRadialaxisProperty> tickvals(System.DateTime val) => Interop.mkRadialaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IRadialaxisProperty> tickvals(IEnumerable<System.DateTime> values) => Interop.mkRadialaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IRadialaxisProperty> tickvals(float val) => Interop.mkRadialaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IRadialaxisProperty> tickvals(IEnumerable<float> values) => Interop.mkRadialaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IRadialaxisProperty> tickvals(int val) => Interop.mkRadialaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IRadialaxisProperty> tickvals(IEnumerable<int> values) => Interop.mkRadialaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IRadialaxisProperty> tickvals(string val) => Interop.mkRadialaxisAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IRadialaxisProperty> tickvals(IEnumerable<string> values) => Interop.mkRadialaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IRadialaxisProperty> tickvals(IEnumerable<bool[]> values) => Interop.mkRadialaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IRadialaxisProperty> tickvals(List<bool[]> values) => Interop.mkRadialaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IRadialaxisProperty> tickvals(params bool[][] values) => Interop.mkRadialaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IRadialaxisProperty> tickvals(IEnumerable<IEnumerable<string>> values) => Interop.mkRadialaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IRadialaxisProperty> tickvals(List<string[]> values) => Interop.mkRadialaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IRadialaxisProperty> tickvals(params string[][] values) => Interop.mkRadialaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IRadialaxisProperty> tickvals(IEnumerable<IEnumerable<int>> values) => Interop.mkRadialaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IRadialaxisProperty> tickvals(List<int[]> values) => Interop.mkRadialaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IRadialaxisProperty> tickvals(params int[][] values) => Interop.mkRadialaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IRadialaxisProperty> tickvals(IEnumerable<IEnumerable<float>> values) => Interop.mkRadialaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IRadialaxisProperty> tickvals(List<float[]> values) => Interop.mkRadialaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IRadialaxisProperty> tickvals(params float[][] values) => Interop.mkRadialaxisAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IRadialaxisProperty> tickvals(Literals.PlotData[] values) => Interop.mkRadialaxisAttr("tickvals", values);
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IRadialaxisProperty> tickvals(IEnumerable<bool?> values) => Interop.mkRadialaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IRadialaxisProperty> tickvals(IEnumerable<System.DateTime?> values) => Interop.mkRadialaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IRadialaxisProperty> tickvals(IEnumerable<int?> values) => Interop.mkRadialaxisAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear. Only has an effect if `tickmode` is set to *array*. Used with `ticktext`.
        public static Box<IRadialaxisProperty> tickvals(IEnumerable<float?> values) => Interop.mkRadialaxisAttr("tickvals", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IRadialaxisProperty> ticktext(bool val) => Interop.mkRadialaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IRadialaxisProperty> ticktext(IEnumerable<bool> values) => Interop.mkRadialaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IRadialaxisProperty> ticktext(System.DateTime val) => Interop.mkRadialaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IRadialaxisProperty> ticktext(IEnumerable<System.DateTime> values) => Interop.mkRadialaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IRadialaxisProperty> ticktext(float val) => Interop.mkRadialaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IRadialaxisProperty> ticktext(IEnumerable<float> values) => Interop.mkRadialaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IRadialaxisProperty> ticktext(int val) => Interop.mkRadialaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IRadialaxisProperty> ticktext(IEnumerable<int> values) => Interop.mkRadialaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IRadialaxisProperty> ticktext(string val) => Interop.mkRadialaxisAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IRadialaxisProperty> ticktext(IEnumerable<string> values) => Interop.mkRadialaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IRadialaxisProperty> ticktext(IEnumerable<bool[]> values) => Interop.mkRadialaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IRadialaxisProperty> ticktext(List<bool[]> values) => Interop.mkRadialaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IRadialaxisProperty> ticktext(params bool[][] values) => Interop.mkRadialaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IRadialaxisProperty> ticktext(IEnumerable<IEnumerable<string>> values) => Interop.mkRadialaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IRadialaxisProperty> ticktext(List<string[]> values) => Interop.mkRadialaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IRadialaxisProperty> ticktext(params string[][] values) => Interop.mkRadialaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IRadialaxisProperty> ticktext(IEnumerable<IEnumerable<int>> values) => Interop.mkRadialaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IRadialaxisProperty> ticktext(List<int[]> values) => Interop.mkRadialaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IRadialaxisProperty> ticktext(params int[][] values) => Interop.mkRadialaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IRadialaxisProperty> ticktext(IEnumerable<IEnumerable<float>> values) => Interop.mkRadialaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IRadialaxisProperty> ticktext(List<float[]> values) => Interop.mkRadialaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IRadialaxisProperty> ticktext(params float[][] values) => Interop.mkRadialaxisAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IRadialaxisProperty> ticktext(Literals.PlotData[] values) => Interop.mkRadialaxisAttr("ticktext", values);
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IRadialaxisProperty> ticktext(IEnumerable<bool?> values) => Interop.mkRadialaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IRadialaxisProperty> ticktext(IEnumerable<System.DateTime?> values) => Interop.mkRadialaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IRadialaxisProperty> ticktext(IEnumerable<int?> values) => Interop.mkRadialaxisAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`. Only has an effect if `tickmode` is set to *array*. Used with `tickvals`.
        public static Box<IRadialaxisProperty> ticktext(IEnumerable<float?> values) => Interop.mkRadialaxisAttr("ticktext", values.ToArray());
        /// Sets the tick length (in px).
        public static Box<IRadialaxisProperty> ticklen(int val) => Interop.mkRadialaxisAttr("ticklen", val);
        /// Sets the tick length (in px).
        public static Box<IRadialaxisProperty> ticklen(float val) => Interop.mkRadialaxisAttr("ticklen", val);
        /// Sets the tick width (in px).
        public static Box<IRadialaxisProperty> tickwidth(int val) => Interop.mkRadialaxisAttr("tickwidth", val);
        /// Sets the tick width (in px).
        public static Box<IRadialaxisProperty> tickwidth(float val) => Interop.mkRadialaxisAttr("tickwidth", val);
        /// Sets the tick color.
        public static Box<IRadialaxisProperty> tickcolor(string val) => Interop.mkRadialaxisAttr("tickcolor", val);
        /// Determines whether or not the tick labels are drawn.
        public static Box<IRadialaxisProperty> showticklabels(bool val) => Interop.mkRadialaxisAttr("showticklabels", val);
        /// Sets a tick label prefix.
        public static Box<IRadialaxisProperty> tickprefix(string val) => Interop.mkRadialaxisAttr("tickprefix", val);
        /// Sets a tick label suffix.
        public static Box<IRadialaxisProperty> ticksuffix(string val) => Interop.mkRadialaxisAttr("ticksuffix", val);
        /// If \"true\", even 4-digit integers are separated
        public static Box<IRadialaxisProperty> separatethousands(bool val) => Interop.mkRadialaxisAttr("separatethousands", val);
        /// Sets the tick font.
        public static Box<IRadialaxisProperty> tickfont(params Box<ITickfontProperty>[] properties) => Interop.mkRadialaxisAttr("tickfont", Bindings.flattenProperties(properties));
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        public static Box<IRadialaxisProperty> tickangle(int val) => Interop.mkRadialaxisAttr("tickangle", val);
        /// Sets the angle of the tick labels with respect to the horizontal. For example, a `tickangle` of -90 draws the tick labels vertically.
        public static Box<IRadialaxisProperty> tickangle(float val) => Interop.mkRadialaxisAttr("tickangle", val);
        /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        public static Box<IRadialaxisProperty> tickformat(string val) => Interop.mkRadialaxisAttr("tickformat", val);
        public static Box<IRadialaxisProperty> tickformatstops(params Box<ITickformatstopsProperty>[] properties) => Interop.mkRadialaxisAttr("tickformatstops", Bindings.flattenProperties(properties));
        /// Sets the source reference on plot.ly for  categoryarray .
        public static Box<IRadialaxisProperty> categoryarraysrc(string val) => Interop.mkRadialaxisAttr("categoryarraysrc", val);
        /// Sets the source reference on plot.ly for  tickvals .
        public static Box<IRadialaxisProperty> tickvalssrc(string val) => Interop.mkRadialaxisAttr("tickvalssrc", val);
        /// Sets the source reference on plot.ly for  ticktext .
        public static Box<IRadialaxisProperty> ticktextsrc(string val) => Interop.mkRadialaxisAttr("ticktextsrc", val);
    }

    public static partial class Radialaxis
    {
        /// Sets the axis type. By default, plotly attempts to determined the axis type by looking into the data of the traces that referenced the axis in question.
        public static partial class _type
        {
            public static Box<IRadialaxisProperty> dash() => Interop.mkRadialaxisAttr("type", "-");
            public static Box<IRadialaxisProperty> category() => Interop.mkRadialaxisAttr("type", "category");
            public static Box<IRadialaxisProperty> date() => Interop.mkRadialaxisAttr("type", "date");
            public static Box<IRadialaxisProperty> linear() => Interop.mkRadialaxisAttr("type", "linear");
            public static Box<IRadialaxisProperty> log() => Interop.mkRadialaxisAttr("type", "log");
        }

        /// Determines whether or not the range of this axis is computed in relation to the input data. See `rangemode` for more info. If `range` is provided, then `autorange` is set to *false*.
        public static partial class Autorange
        {
            public static Box<IRadialaxisProperty> reversed() => Interop.mkRadialaxisAttr("autorange", "reversed");
            public static Box<IRadialaxisProperty> _false() => Interop.mkRadialaxisAttr("autorange", false);
            public static Box<IRadialaxisProperty> _true() => Interop.mkRadialaxisAttr("autorange", true);
        }

        /// If *tozero*`, the range extends to 0, regardless of the input data If *nonnegative*, the range is non-negative, regardless of the input data. If *normal*, the range is computed in relation to the extrema of the input data (same behavior as for cartesian axes).
        public static partial class Rangemode
        {
            public static Box<IRadialaxisProperty> nonnegative() => Interop.mkRadialaxisAttr("rangemode", "nonnegative");
            public static Box<IRadialaxisProperty> normal() => Interop.mkRadialaxisAttr("rangemode", "normal");
            public static Box<IRadialaxisProperty> tozero() => Interop.mkRadialaxisAttr("rangemode", "tozero");
        }

        /// Specifies the ordering logic for the case of categorical variables. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`. Set `categoryorder` to *total ascending* or *total descending* if order should be determined by the numerical order of the values. Similarly, the order can be determined by the min, max, sum, mean or median of all the values.
        public static partial class Categoryorder
        {
            public static Box<IRadialaxisProperty> array() => Interop.mkRadialaxisAttr("categoryorder", "array");
            public static Box<IRadialaxisProperty> categoryAscending() => Interop.mkRadialaxisAttr("categoryorder", "category ascending");
            public static Box<IRadialaxisProperty> categoryDescending() => Interop.mkRadialaxisAttr("categoryorder", "category descending");
            public static Box<IRadialaxisProperty> maxAscending() => Interop.mkRadialaxisAttr("categoryorder", "max ascending");
            public static Box<IRadialaxisProperty> maxDescending() => Interop.mkRadialaxisAttr("categoryorder", "max descending");
            public static Box<IRadialaxisProperty> meanAscending() => Interop.mkRadialaxisAttr("categoryorder", "mean ascending");
            public static Box<IRadialaxisProperty> meanDescending() => Interop.mkRadialaxisAttr("categoryorder", "mean descending");
            public static Box<IRadialaxisProperty> medianAscending() => Interop.mkRadialaxisAttr("categoryorder", "median ascending");
            public static Box<IRadialaxisProperty> medianDescending() => Interop.mkRadialaxisAttr("categoryorder", "median descending");
            public static Box<IRadialaxisProperty> minAscending() => Interop.mkRadialaxisAttr("categoryorder", "min ascending");
            public static Box<IRadialaxisProperty> minDescending() => Interop.mkRadialaxisAttr("categoryorder", "min descending");
            public static Box<IRadialaxisProperty> sumAscending() => Interop.mkRadialaxisAttr("categoryorder", "sum ascending");
            public static Box<IRadialaxisProperty> sumDescending() => Interop.mkRadialaxisAttr("categoryorder", "sum descending");
            public static Box<IRadialaxisProperty> totalAscending() => Interop.mkRadialaxisAttr("categoryorder", "total ascending");
            public static Box<IRadialaxisProperty> totalDescending() => Interop.mkRadialaxisAttr("categoryorder", "total descending");
            public static Box<IRadialaxisProperty> trace() => Interop.mkRadialaxisAttr("categoryorder", "trace");
        }

        /// Determines on which side of radial axis line the tick and tick labels appear.
        public static partial class Side
        {
            public static Box<IRadialaxisProperty> clockwise() => Interop.mkRadialaxisAttr("side", "clockwise");
            public static Box<IRadialaxisProperty> counterclockwise() => Interop.mkRadialaxisAttr("side", "counterclockwise");
        }

        /// Sets the tick mode for this axis. If *auto*, the number of ticks is set via `nticks`. If *linear*, the placement of the ticks is determined by a starting position `tick0` and a tick step `dtick` (*linear* is the default value if `tick0` and `dtick` are provided). If *array*, the placement of the ticks is set via `tickvals` and the tick text is `ticktext`. (*array* is the default value if `tickvals` is provided).
        public static partial class Tickmode
        {
            public static Box<IRadialaxisProperty> array() => Interop.mkRadialaxisAttr("tickmode", "array");
            public static Box<IRadialaxisProperty> auto() => Interop.mkRadialaxisAttr("tickmode", "auto");
            public static Box<IRadialaxisProperty> linear() => Interop.mkRadialaxisAttr("tickmode", "linear");
        }

        /// Determines whether ticks are drawn or not. If **, this axis' ticks are not drawn. If *outside* (*inside*), this axis' are drawn outside (inside) the axis lines.
        public static partial class Ticks
        {
            public static Box<IRadialaxisProperty> none() => Interop.mkRadialaxisAttr("ticks", "");
            public static Box<IRadialaxisProperty> inside() => Interop.mkRadialaxisAttr("ticks", "inside");
            public static Box<IRadialaxisProperty> outside() => Interop.mkRadialaxisAttr("ticks", "outside");
        }

        /// If *all*, all tick labels are displayed with a prefix. If *first*, only the first tick is displayed with a prefix. If *last*, only the last tick is displayed with a suffix. If *none*, tick prefixes are hidden.
        public static partial class Showtickprefix
        {
            public static Box<IRadialaxisProperty> all() => Interop.mkRadialaxisAttr("showtickprefix", "all");
            public static Box<IRadialaxisProperty> first() => Interop.mkRadialaxisAttr("showtickprefix", "first");
            public static Box<IRadialaxisProperty> last() => Interop.mkRadialaxisAttr("showtickprefix", "last");
            public static Box<IRadialaxisProperty> none() => Interop.mkRadialaxisAttr("showtickprefix", "none");
        }

        /// Same as `showtickprefix` but for tick suffixes.
        public static partial class Showticksuffix
        {
            public static Box<IRadialaxisProperty> all() => Interop.mkRadialaxisAttr("showticksuffix", "all");
            public static Box<IRadialaxisProperty> first() => Interop.mkRadialaxisAttr("showticksuffix", "first");
            public static Box<IRadialaxisProperty> last() => Interop.mkRadialaxisAttr("showticksuffix", "last");
            public static Box<IRadialaxisProperty> none() => Interop.mkRadialaxisAttr("showticksuffix", "none");
        }

        /// If *all*, all exponents are shown besides their significands. If *first*, only the exponent of the first tick is shown. If *last*, only the exponent of the last tick is shown. If *none*, no exponents appear.
        public static partial class Showexponent
        {
            public static Box<IRadialaxisProperty> all() => Interop.mkRadialaxisAttr("showexponent", "all");
            public static Box<IRadialaxisProperty> first() => Interop.mkRadialaxisAttr("showexponent", "first");
            public static Box<IRadialaxisProperty> last() => Interop.mkRadialaxisAttr("showexponent", "last");
            public static Box<IRadialaxisProperty> none() => Interop.mkRadialaxisAttr("showexponent", "none");
        }

        /// Determines a formatting rule for the tick exponents. For example, consider the number 1,000,000,000. If *none*, it appears as 1,000,000,000. If *e*, 1e+9. If *E*, 1E+9. If *power*, 1x10^9 (with 9 in a super script). If *SI*, 1G. If *B*, 1B.
        public static partial class Exponentformat
        {
            public static Box<IRadialaxisProperty> B() => Interop.mkRadialaxisAttr("exponentformat", "B");
            public static Box<IRadialaxisProperty> E() => Interop.mkRadialaxisAttr("exponentformat", "E");
            public static Box<IRadialaxisProperty> SI() => Interop.mkRadialaxisAttr("exponentformat", "SI");
            public static Box<IRadialaxisProperty> e() => Interop.mkRadialaxisAttr("exponentformat", "e");
            public static Box<IRadialaxisProperty> none() => Interop.mkRadialaxisAttr("exponentformat", "none");
            public static Box<IRadialaxisProperty> power() => Interop.mkRadialaxisAttr("exponentformat", "power");
        }

        /// Sets the layer on which this axis is displayed. If *above traces*, this axis is displayed above all the subplot's traces If *below traces*, this axis is displayed below all the subplot's traces, but above the grid lines. Useful when used together with scatter-like traces with `cliponaxis` set to *false* to show markers and/or text nodes above this axis.
        public static partial class Layer
        {
            public static Box<IRadialaxisProperty> aboveTraces() => Interop.mkRadialaxisAttr("layer", "above traces");
            public static Box<IRadialaxisProperty> belowTraces() => Interop.mkRadialaxisAttr("layer", "below traces");
        }

        /// Sets the calendar system to use for `range` and `tick0` if this is a date axis. This does not set the calendar for interpreting data on this axis, that's specified in the trace or via the global `layout.calendar`
        public static partial class Calendar
        {
            public static Box<IRadialaxisProperty> chinese() => Interop.mkRadialaxisAttr("calendar", "chinese");
            public static Box<IRadialaxisProperty> coptic() => Interop.mkRadialaxisAttr("calendar", "coptic");
            public static Box<IRadialaxisProperty> discworld() => Interop.mkRadialaxisAttr("calendar", "discworld");
            public static Box<IRadialaxisProperty> ethiopian() => Interop.mkRadialaxisAttr("calendar", "ethiopian");
            public static Box<IRadialaxisProperty> gregorian() => Interop.mkRadialaxisAttr("calendar", "gregorian");
            public static Box<IRadialaxisProperty> hebrew() => Interop.mkRadialaxisAttr("calendar", "hebrew");
            public static Box<IRadialaxisProperty> islamic() => Interop.mkRadialaxisAttr("calendar", "islamic");
            public static Box<IRadialaxisProperty> jalali() => Interop.mkRadialaxisAttr("calendar", "jalali");
            public static Box<IRadialaxisProperty> julian() => Interop.mkRadialaxisAttr("calendar", "julian");
            public static Box<IRadialaxisProperty> mayan() => Interop.mkRadialaxisAttr("calendar", "mayan");
            public static Box<IRadialaxisProperty> nanakshahi() => Interop.mkRadialaxisAttr("calendar", "nanakshahi");
            public static Box<IRadialaxisProperty> nepali() => Interop.mkRadialaxisAttr("calendar", "nepali");
            public static Box<IRadialaxisProperty> persian() => Interop.mkRadialaxisAttr("calendar", "persian");
            public static Box<IRadialaxisProperty> taiwan() => Interop.mkRadialaxisAttr("calendar", "taiwan");
            public static Box<IRadialaxisProperty> thai() => Interop.mkRadialaxisAttr("calendar", "thai");
            public static Box<IRadialaxisProperty> ummalqura() => Interop.mkRadialaxisAttr("calendar", "ummalqura");
        }
    }
}