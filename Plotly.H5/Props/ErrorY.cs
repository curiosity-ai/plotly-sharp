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

    public static partial class ErrorY
    {
        /// Determines whether or not this set of error bars is visible.
        public static Box<IErrorYProperty> visible(bool val) => Interop.mkErrorYAttr("visible", val);
        /// Determines whether or not the error bars have the same length in both direction (top/bottom for vertical bars, left/right for horizontal bars.
        public static Box<IErrorYProperty> symmetric(bool val) => Interop.mkErrorYAttr("symmetric", val);
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> array(bool val) => Interop.mkErrorYAttr("array", new[]{val});
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> array(params bool[] values) => Interop.mkErrorYAttr("array", values);
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> array(System.DateTime val) => Interop.mkErrorYAttr("array", new[]{val});
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> array(params System.DateTime[] values) => Interop.mkErrorYAttr("array", values);
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> array(float val) => Interop.mkErrorYAttr("array", new[]{val});
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> array(params float[] values) => Interop.mkErrorYAttr("array", values);
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> array(int val) => Interop.mkErrorYAttr("array", new[]{val});
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> array(params int[] values) => Interop.mkErrorYAttr("array", values);
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> array(string val) => Interop.mkErrorYAttr("array", new[]{val});
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> array(params string[] values) => Interop.mkErrorYAttr("array", values);
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> array(IEnumerable<bool[]> values) => Interop.mkErrorYAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> array(List<bool[]> values) => Interop.mkErrorYAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> array(params bool[][] values) => Interop.mkErrorYAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> array(IEnumerable<IEnumerable<string>> values) => Interop.mkErrorYAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> array(List<string[]> values) => Interop.mkErrorYAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> array(params string[][] values) => Interop.mkErrorYAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> array(IEnumerable<IEnumerable<int>> values) => Interop.mkErrorYAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> array(List<int[]> values) => Interop.mkErrorYAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> array(params int[][] values) => Interop.mkErrorYAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> array(IEnumerable<IEnumerable<float>> values) => Interop.mkErrorYAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> array(List<float[]> values) => Interop.mkErrorYAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> array(params float[][] values) => Interop.mkErrorYAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> array(Literals.PlotData[] values) => Interop.mkErrorYAttr("array", values);
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> array(IEnumerable<bool?> values) => Interop.mkErrorYAttr("array", values.ToArray());
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> array(IEnumerable<System.DateTime?> values) => Interop.mkErrorYAttr("array", values.ToArray());
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> array(IEnumerable<int?> values) => Interop.mkErrorYAttr("array", values.ToArray());
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> array(IEnumerable<float?> values) => Interop.mkErrorYAttr("array", values.ToArray());
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> arrayminus(bool val) => Interop.mkErrorYAttr("arrayminus", new[]{val});
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> arrayminus(params bool[] values) => Interop.mkErrorYAttr("arrayminus", values);
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> arrayminus(System.DateTime val) => Interop.mkErrorYAttr("arrayminus", new[]{val});
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> arrayminus(params System.DateTime[] values) => Interop.mkErrorYAttr("arrayminus", values);
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> arrayminus(float val) => Interop.mkErrorYAttr("arrayminus", new[]{val});
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> arrayminus(params float[] values) => Interop.mkErrorYAttr("arrayminus", values);
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> arrayminus(int val) => Interop.mkErrorYAttr("arrayminus", new[]{val});
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> arrayminus(params int[] values) => Interop.mkErrorYAttr("arrayminus", values);
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> arrayminus(string val) => Interop.mkErrorYAttr("arrayminus", new[]{val});
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> arrayminus(params string[] values) => Interop.mkErrorYAttr("arrayminus", values);
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> arrayminus(IEnumerable<bool[]> values) => Interop.mkErrorYAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> arrayminus(List<bool[]> values) => Interop.mkErrorYAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> arrayminus(params bool[][] values) => Interop.mkErrorYAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> arrayminus(IEnumerable<IEnumerable<string>> values) => Interop.mkErrorYAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> arrayminus(List<string[]> values) => Interop.mkErrorYAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> arrayminus(params string[][] values) => Interop.mkErrorYAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> arrayminus(IEnumerable<IEnumerable<int>> values) => Interop.mkErrorYAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> arrayminus(List<int[]> values) => Interop.mkErrorYAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> arrayminus(params int[][] values) => Interop.mkErrorYAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> arrayminus(IEnumerable<IEnumerable<float>> values) => Interop.mkErrorYAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> arrayminus(List<float[]> values) => Interop.mkErrorYAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> arrayminus(params float[][] values) => Interop.mkErrorYAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> arrayminus(Literals.PlotData[] values) => Interop.mkErrorYAttr("arrayminus", values);
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> arrayminus(IEnumerable<bool?> values) => Interop.mkErrorYAttr("arrayminus", values.ToArray());
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> arrayminus(IEnumerable<System.DateTime?> values) => Interop.mkErrorYAttr("arrayminus", values.ToArray());
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> arrayminus(IEnumerable<int?> values) => Interop.mkErrorYAttr("arrayminus", values.ToArray());
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorYProperty> arrayminus(IEnumerable<float?> values) => Interop.mkErrorYAttr("arrayminus", values.ToArray());
        /// Sets the value of either the percentage (if `type` is set to *percent*) or the constant (if `type` is set to *constant*) corresponding to the lengths of the error bars.
        public static Box<IErrorYProperty> value(int val) => Interop.mkErrorYAttr("value", val);
        /// Sets the value of either the percentage (if `type` is set to *percent*) or the constant (if `type` is set to *constant*) corresponding to the lengths of the error bars.
        public static Box<IErrorYProperty> value(float val) => Interop.mkErrorYAttr("value", val);
        /// Sets the value of either the percentage (if `type` is set to *percent*) or the constant (if `type` is set to *constant*) corresponding to the lengths of the error bars in the bottom (left) direction for vertical (horizontal) bars
        public static Box<IErrorYProperty> valueminus(int val) => Interop.mkErrorYAttr("valueminus", val);
        /// Sets the value of either the percentage (if `type` is set to *percent*) or the constant (if `type` is set to *constant*) corresponding to the lengths of the error bars in the bottom (left) direction for vertical (horizontal) bars
        public static Box<IErrorYProperty> valueminus(float val) => Interop.mkErrorYAttr("valueminus", val);
        public static Box<IErrorYProperty> traceref(int val) => Interop.mkErrorYAttr("traceref", val);
        public static Box<IErrorYProperty> tracerefminus(int val) => Interop.mkErrorYAttr("tracerefminus", val);
        /// Sets the stoke color of the error bars.
        public static Box<IErrorYProperty> color(string val) => Interop.mkErrorYAttr("color", val);
        /// Sets the thickness (in px) of the error bars.
        public static Box<IErrorYProperty> thickness(int val) => Interop.mkErrorYAttr("thickness", val);
        /// Sets the thickness (in px) of the error bars.
        public static Box<IErrorYProperty> thickness(float val) => Interop.mkErrorYAttr("thickness", val);
        /// Sets the width (in px) of the cross-bar at both ends of the error bars.
        public static Box<IErrorYProperty> width(int val) => Interop.mkErrorYAttr("width", val);
        /// Sets the width (in px) of the cross-bar at both ends of the error bars.
        public static Box<IErrorYProperty> width(float val) => Interop.mkErrorYAttr("width", val);
        /// Sets the source reference on plot.ly for  array .
        public static Box<IErrorYProperty> arraysrc(string val) => Interop.mkErrorYAttr("arraysrc", val);
        /// Sets the source reference on plot.ly for  arrayminus .
        public static Box<IErrorYProperty> arrayminussrc(string val) => Interop.mkErrorYAttr("arrayminussrc", val);
        public static Box<IErrorYProperty> copyZstyle(bool val) => Interop.mkErrorYAttr("copy_zstyle", val);
    }

    public static partial class ErrorY
    {
        /// Determines the rule used to generate the error bars. If *constant`, the bar lengths are of a constant value. Set this constant in `value`. If *percent*, the bar lengths correspond to a percentage of underlying data. Set this percentage in `value`. If *sqrt*, the bar lengths correspond to the sqaure of the underlying data. If *data*, the bar lengths are set with data set `array`.
        public static partial class _type
        {
            public static Box<IErrorYProperty> constant() => Interop.mkErrorYAttr("type", "constant");
            public static Box<IErrorYProperty> data() => Interop.mkErrorYAttr("type", "data");
            public static Box<IErrorYProperty> percent() => Interop.mkErrorYAttr("type", "percent");
            public static Box<IErrorYProperty> sqrt() => Interop.mkErrorYAttr("type", "sqrt");
        }
    }
}