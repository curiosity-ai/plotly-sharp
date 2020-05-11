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

    public static partial class ErrorX
    {
        /// Determines whether or not this set of error bars is visible.
        public static Box<IErrorXProperty> visible(bool val) => Interop.mkErrorXAttr("visible", val);
        /// Determines whether or not the error bars have the same length in both direction (top/bottom for vertical bars, left/right for horizontal bars.
        public static Box<IErrorXProperty> symmetric(bool val) => Interop.mkErrorXAttr("symmetric", val);
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> array(bool val) => Interop.mkErrorXAttr("array", new[]{val});
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> array(params bool[] values) => Interop.mkErrorXAttr("array", values);
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> array(System.DateTime val) => Interop.mkErrorXAttr("array", new[]{val});
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> array(params System.DateTime[] values) => Interop.mkErrorXAttr("array", values);
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> array(float val) => Interop.mkErrorXAttr("array", new[]{val});
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> array(params float[] values) => Interop.mkErrorXAttr("array", values);
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> array(int val) => Interop.mkErrorXAttr("array", new[]{val});
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> array(params int[] values) => Interop.mkErrorXAttr("array", values);
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> array(string val) => Interop.mkErrorXAttr("array", new[]{val});
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> array(params string[] values) => Interop.mkErrorXAttr("array", values);
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> array(IEnumerable<bool[]> values) => Interop.mkErrorXAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> array(List<bool[]> values) => Interop.mkErrorXAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> array(params bool[][] values) => Interop.mkErrorXAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> array(IEnumerable<IEnumerable<string>> values) => Interop.mkErrorXAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> array(List<string[]> values) => Interop.mkErrorXAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> array(params string[][] values) => Interop.mkErrorXAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> array(IEnumerable<IEnumerable<int>> values) => Interop.mkErrorXAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> array(List<int[]> values) => Interop.mkErrorXAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> array(params int[][] values) => Interop.mkErrorXAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> array(IEnumerable<IEnumerable<float>> values) => Interop.mkErrorXAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> array(List<float[]> values) => Interop.mkErrorXAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> array(params float[][] values) => Interop.mkErrorXAttr("array", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> array(Literals.PlotData[] values) => Interop.mkErrorXAttr("array", values);
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> array(IEnumerable<bool?> values) => Interop.mkErrorXAttr("array", values.ToArray());
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> array(IEnumerable<System.DateTime?> values) => Interop.mkErrorXAttr("array", values.ToArray());
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> array(IEnumerable<int?> values) => Interop.mkErrorXAttr("array", values.ToArray());
        /// Sets the data corresponding the length of each error bar. Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> array(IEnumerable<float?> values) => Interop.mkErrorXAttr("array", values.ToArray());
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> arrayminus(bool val) => Interop.mkErrorXAttr("arrayminus", new[]{val});
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> arrayminus(params bool[] values) => Interop.mkErrorXAttr("arrayminus", values);
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> arrayminus(System.DateTime val) => Interop.mkErrorXAttr("arrayminus", new[]{val});
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> arrayminus(params System.DateTime[] values) => Interop.mkErrorXAttr("arrayminus", values);
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> arrayminus(float val) => Interop.mkErrorXAttr("arrayminus", new[]{val});
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> arrayminus(params float[] values) => Interop.mkErrorXAttr("arrayminus", values);
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> arrayminus(int val) => Interop.mkErrorXAttr("arrayminus", new[]{val});
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> arrayminus(params int[] values) => Interop.mkErrorXAttr("arrayminus", values);
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> arrayminus(string val) => Interop.mkErrorXAttr("arrayminus", new[]{val});
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> arrayminus(params string[] values) => Interop.mkErrorXAttr("arrayminus", values);
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> arrayminus(IEnumerable<bool[]> values) => Interop.mkErrorXAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> arrayminus(List<bool[]> values) => Interop.mkErrorXAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> arrayminus(params bool[][] values) => Interop.mkErrorXAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> arrayminus(IEnumerable<IEnumerable<string>> values) => Interop.mkErrorXAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> arrayminus(List<string[]> values) => Interop.mkErrorXAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> arrayminus(params string[][] values) => Interop.mkErrorXAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> arrayminus(IEnumerable<IEnumerable<int>> values) => Interop.mkErrorXAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> arrayminus(List<int[]> values) => Interop.mkErrorXAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> arrayminus(params int[][] values) => Interop.mkErrorXAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> arrayminus(IEnumerable<IEnumerable<float>> values) => Interop.mkErrorXAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> arrayminus(List<float[]> values) => Interop.mkErrorXAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> arrayminus(params float[][] values) => Interop.mkErrorXAttr("arrayminus", Bindings.flatten2DArrayIf1D(values));
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> arrayminus(Literals.PlotData[] values) => Interop.mkErrorXAttr("arrayminus", values);
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> arrayminus(IEnumerable<bool?> values) => Interop.mkErrorXAttr("arrayminus", values.ToArray());
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> arrayminus(IEnumerable<System.DateTime?> values) => Interop.mkErrorXAttr("arrayminus", values.ToArray());
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> arrayminus(IEnumerable<int?> values) => Interop.mkErrorXAttr("arrayminus", values.ToArray());
        /// Sets the data corresponding the length of each error bar in the bottom (left) direction for vertical (horizontal) bars Values are plotted relative to the underlying data.
        public static Box<IErrorXProperty> arrayminus(IEnumerable<float?> values) => Interop.mkErrorXAttr("arrayminus", values.ToArray());
        /// Sets the value of either the percentage (if `type` is set to *percent*) or the constant (if `type` is set to *constant*) corresponding to the lengths of the error bars.
        public static Box<IErrorXProperty> value(int val) => Interop.mkErrorXAttr("value", val);
        /// Sets the value of either the percentage (if `type` is set to *percent*) or the constant (if `type` is set to *constant*) corresponding to the lengths of the error bars.
        public static Box<IErrorXProperty> value(float val) => Interop.mkErrorXAttr("value", val);
        /// Sets the value of either the percentage (if `type` is set to *percent*) or the constant (if `type` is set to *constant*) corresponding to the lengths of the error bars in the bottom (left) direction for vertical (horizontal) bars
        public static Box<IErrorXProperty> valueminus(int val) => Interop.mkErrorXAttr("valueminus", val);
        /// Sets the value of either the percentage (if `type` is set to *percent*) or the constant (if `type` is set to *constant*) corresponding to the lengths of the error bars in the bottom (left) direction for vertical (horizontal) bars
        public static Box<IErrorXProperty> valueminus(float val) => Interop.mkErrorXAttr("valueminus", val);
        public static Box<IErrorXProperty> traceref(int val) => Interop.mkErrorXAttr("traceref", val);
        public static Box<IErrorXProperty> tracerefminus(int val) => Interop.mkErrorXAttr("tracerefminus", val);
        public static Box<IErrorXProperty> copyYstyle(bool val) => Interop.mkErrorXAttr("copy_ystyle", val);
        /// Sets the stoke color of the error bars.
        public static Box<IErrorXProperty> color(string val) => Interop.mkErrorXAttr("color", val);
        /// Sets the thickness (in px) of the error bars.
        public static Box<IErrorXProperty> thickness(int val) => Interop.mkErrorXAttr("thickness", val);
        /// Sets the thickness (in px) of the error bars.
        public static Box<IErrorXProperty> thickness(float val) => Interop.mkErrorXAttr("thickness", val);
        /// Sets the width (in px) of the cross-bar at both ends of the error bars.
        public static Box<IErrorXProperty> width(int val) => Interop.mkErrorXAttr("width", val);
        /// Sets the width (in px) of the cross-bar at both ends of the error bars.
        public static Box<IErrorXProperty> width(float val) => Interop.mkErrorXAttr("width", val);
        /// Sets the source reference on plot.ly for  array .
        public static Box<IErrorXProperty> arraysrc(string val) => Interop.mkErrorXAttr("arraysrc", val);
        /// Sets the source reference on plot.ly for  arrayminus .
        public static Box<IErrorXProperty> arrayminussrc(string val) => Interop.mkErrorXAttr("arrayminussrc", val);
        public static Box<IErrorXProperty> copyZstyle(bool val) => Interop.mkErrorXAttr("copy_zstyle", val);
    }

    public static partial class ErrorX
    {
        /// Determines the rule used to generate the error bars. If *constant`, the bar lengths are of a constant value. Set this constant in `value`. If *percent*, the bar lengths correspond to a percentage of underlying data. Set this percentage in `value`. If *sqrt*, the bar lengths correspond to the sqaure of the underlying data. If *data*, the bar lengths are set with data set `array`.
        public static partial class _type
        {
            public static Box<IErrorXProperty> constant() => Interop.mkErrorXAttr("type", "constant");
            public static Box<IErrorXProperty> data() => Interop.mkErrorXAttr("type", "data");
            public static Box<IErrorXProperty> percent() => Interop.mkErrorXAttr("type", "percent");
            public static Box<IErrorXProperty> sqrt() => Interop.mkErrorXAttr("type", "sqrt");
        }
    }
}