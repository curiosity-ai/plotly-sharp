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

    public static partial class ErrorZ
    {
        /// Determines whether or not this set of error bars is visible.
        public static Box<IErrorZProperty> visible(bool val) => Interop.mkErrorZAttr("visible", val);
        /// Determines whether or not the error bars have the same length in both direction (top/bottom for vertical bars, left/right for horizontal bars.
        public static Box<IErrorZProperty> symmetric(bool val) => Interop.mkErrorZAttr("symmetric", val);
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> array(bool val) => Interop.mkErrorZAttr("array", new[]{val});
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> array(params bool[] values) => Interop.mkErrorZAttr("array", values);
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> array(System.DateTime val) => Interop.mkErrorZAttr("array", new[]{val});
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> array(params System.DateTime[] values) => Interop.mkErrorZAttr("array", values);
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> array(float val) => Interop.mkErrorZAttr("array", new[]{val});
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> array(params float[] values) => Interop.mkErrorZAttr("array", values);
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> array(int val) => Interop.mkErrorZAttr("array", new[]{val});
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> array(params int[] values) => Interop.mkErrorZAttr("array", values);
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> array(string val) => Interop.mkErrorZAttr("array", new[]{val});
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> array(params string[] values) => Interop.mkErrorZAttr("array", values);
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> array(IEnumerable<bool[]> values) => Interop.mkErrorZAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> array(List<bool[]> values) => Interop.mkErrorZAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> array(params bool[][] values) => Interop.mkErrorZAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> array(IEnumerable<IEnumerable<string>> values) => Interop.mkErrorZAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> array(List<string[]> values) => Interop.mkErrorZAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> array(params string[][] values) => Interop.mkErrorZAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> array(IEnumerable<IEnumerable<int>> values) => Interop.mkErrorZAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> array(List<int[]> values) => Interop.mkErrorZAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> array(params int[][] values) => Interop.mkErrorZAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> array(IEnumerable<IEnumerable<float>> values) => Interop.mkErrorZAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> array(List<float[]> values) => Interop.mkErrorZAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> array(params float[][] values) => Interop.mkErrorZAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> array(Literals.PlotData[] values) => Interop.mkErrorZAttr("array", values);
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> array(IEnumerable<bool?> values) => Interop.mkErrorZAttr("array", values.ToArray());
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> array(IEnumerable<System.DateTime?> values) => Interop.mkErrorZAttr("array", values.ToArray());
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> array(IEnumerable<int?> values) => Interop.mkErrorZAttr("array", values.ToArray());
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> array(IEnumerable<float?> values) => Interop.mkErrorZAttr("array", values.ToArray());
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> arrayminus(bool val) => Interop.mkErrorZAttr("arrayminus", new[]{val});
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> arrayminus(params bool[] values) => Interop.mkErrorZAttr("arrayminus", values);
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> arrayminus(System.DateTime val) => Interop.mkErrorZAttr("arrayminus", new[]{val});
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> arrayminus(params System.DateTime[] values) => Interop.mkErrorZAttr("arrayminus", values);
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> arrayminus(float val) => Interop.mkErrorZAttr("arrayminus", new[]{val});
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> arrayminus(params float[] values) => Interop.mkErrorZAttr("arrayminus", values);
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> arrayminus(int val) => Interop.mkErrorZAttr("arrayminus", new[]{val});
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> arrayminus(params int[] values) => Interop.mkErrorZAttr("arrayminus", values);
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> arrayminus(string val) => Interop.mkErrorZAttr("arrayminus", new[]{val});
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> arrayminus(params string[] values) => Interop.mkErrorZAttr("arrayminus", values);
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> arrayminus(IEnumerable<bool[]> values) => Interop.mkErrorZAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> arrayminus(List<bool[]> values) => Interop.mkErrorZAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> arrayminus(params bool[][] values) => Interop.mkErrorZAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> arrayminus(IEnumerable<IEnumerable<string>> values) => Interop.mkErrorZAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> arrayminus(List<string[]> values) => Interop.mkErrorZAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> arrayminus(params string[][] values) => Interop.mkErrorZAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> arrayminus(IEnumerable<IEnumerable<int>> values) => Interop.mkErrorZAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> arrayminus(List<int[]> values) => Interop.mkErrorZAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> arrayminus(params int[][] values) => Interop.mkErrorZAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> arrayminus(IEnumerable<IEnumerable<float>> values) => Interop.mkErrorZAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> arrayminus(List<float[]> values) => Interop.mkErrorZAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> arrayminus(params float[][] values) => Interop.mkErrorZAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> arrayminus(Literals.PlotData[] values) => Interop.mkErrorZAttr("arrayminus", values);
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> arrayminus(IEnumerable<bool?> values) => Interop.mkErrorZAttr("arrayminus", values.ToArray());
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> arrayminus(IEnumerable<System.DateTime?> values) => Interop.mkErrorZAttr("arrayminus", values.ToArray());
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> arrayminus(IEnumerable<int?> values) => Interop.mkErrorZAttr("arrayminus", values.ToArray());
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorZProperty> arrayminus(IEnumerable<float?> values) => Interop.mkErrorZAttr("arrayminus", values.ToArray());
        /// Sets the value of either the percentage (if `type` is set to *percent*) or the constant (if `type` is set to *constant*) corresponding to the lengths of the error bars.
        public static Box<IErrorZProperty> value(int val) => Interop.mkErrorZAttr("value", val);
        /// Sets the value of either the percentage (if `type` is set to *percent*) or the constant (if `type` is set to *constant*) corresponding to the lengths of the error bars.
        public static Box<IErrorZProperty> value(float val) => Interop.mkErrorZAttr("value", val);
        /// Sets the value of either the percentage (if `type` is set to *percent*) or the constant (if `type` is set to *constant*) corresponding to the lengths of the error bars in the bottom (left) direction for vertical (horizontal) bars
        public static Box<IErrorZProperty> valueminus(int val) => Interop.mkErrorZAttr("valueminus", val);
        /// Sets the value of either the percentage (if `type` is set to *percent*) or the constant (if `type` is set to *constant*) corresponding to the lengths of the error bars in the bottom (left) direction for vertical (horizontal) bars
        public static Box<IErrorZProperty> valueminus(float val) => Interop.mkErrorZAttr("valueminus", val);
        public static Box<IErrorZProperty> traceref(int val) => Interop.mkErrorZAttr("traceref", val);
        public static Box<IErrorZProperty> tracerefminus(int val) => Interop.mkErrorZAttr("tracerefminus", val);
        /// Sets the stoke color of the error bars.
        public static Box<IErrorZProperty> color(string val) => Interop.mkErrorZAttr("color", val);
        /// Sets the thickness (in px) of the error bars.
        public static Box<IErrorZProperty> thickness(int val) => Interop.mkErrorZAttr("thickness", val);
        /// Sets the thickness (in px) of the error bars.
        public static Box<IErrorZProperty> thickness(float val) => Interop.mkErrorZAttr("thickness", val);
        /// Sets the width (in px) of the cross-bar at both ends of the error bars.
        public static Box<IErrorZProperty> width(int val) => Interop.mkErrorZAttr("width", val);
        /// Sets the width (in px) of the cross-bar at both ends of the error bars.
        public static Box<IErrorZProperty> width(float val) => Interop.mkErrorZAttr("width", val);
        /// Sets the source reference on plot.ly for  array .
        public static Box<IErrorZProperty> arraysrc(string val) => Interop.mkErrorZAttr("arraysrc", val);
        /// Sets the source reference on plot.ly for  arrayminus .
        public static Box<IErrorZProperty> arrayminussrc(string val) => Interop.mkErrorZAttr("arrayminussrc", val);
    }

    public static partial class ErrorZ
    {
        /// Determines the rule used to generate the error bars. If *constant`, the bar lengths are of a constant value. Set this constant in `value`. If *percent*, the bar lengths correspond to a percentage of underlying data. Set this percentage in `value`. If *sqrt*, the bar lengths correspond to the sqaure of the underlying data. If *data*, the bar lengths are set with data set `array`.
        public static partial class _type
        {
            public static Box<IErrorZProperty> constant() => Interop.mkErrorZAttr("type", "constant");
            public static Box<IErrorZProperty> data() => Interop.mkErrorZAttr("type", "data");
            public static Box<IErrorZProperty> percent() => Interop.mkErrorZAttr("type", "percent");
            public static Box<IErrorZProperty> sqrt() => Interop.mkErrorZAttr("type", "sqrt");
        }
    }
}