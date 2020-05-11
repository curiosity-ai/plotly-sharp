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

    public static partial class Header
    {
        /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<IHeaderProperty> values(bool val) => Interop.mkHeaderAttr("values", new[]{val});
        /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<IHeaderProperty> values(params bool[] values) => Interop.mkHeaderAttr("values", values);
        /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<IHeaderProperty> values(System.DateTime val) => Interop.mkHeaderAttr("values", new[]{val});
        /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<IHeaderProperty> values(params System.DateTime[] values) => Interop.mkHeaderAttr("values", values);
        /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<IHeaderProperty> values(float val) => Interop.mkHeaderAttr("values", new[]{val});
        /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<IHeaderProperty> values(params float[] values) => Interop.mkHeaderAttr("values", values);
        /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<IHeaderProperty> values(int val) => Interop.mkHeaderAttr("values", new[]{val});
        /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<IHeaderProperty> values(params int[] values) => Interop.mkHeaderAttr("values", values);
        /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<IHeaderProperty> values(string val) => Interop.mkHeaderAttr("values", new[]{val});
        /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<IHeaderProperty> values(params string[] values) => Interop.mkHeaderAttr("values", values);
        /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<IHeaderProperty> values(IEnumerable<bool[]> values) => Interop.mkHeaderAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<IHeaderProperty> values(List<bool[]> values) => Interop.mkHeaderAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<IHeaderProperty> values(params bool[][] values) => Interop.mkHeaderAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<IHeaderProperty> values(IEnumerable<IEnumerable<string>> values) => Interop.mkHeaderAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<IHeaderProperty> values(List<string[]> values) => Interop.mkHeaderAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<IHeaderProperty> values(params string[][] values) => Interop.mkHeaderAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<IHeaderProperty> values(IEnumerable<IEnumerable<int>> values) => Interop.mkHeaderAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<IHeaderProperty> values(List<int[]> values) => Interop.mkHeaderAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<IHeaderProperty> values(params int[][] values) => Interop.mkHeaderAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<IHeaderProperty> values(IEnumerable<IEnumerable<float>> values) => Interop.mkHeaderAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<IHeaderProperty> values(List<float[]> values) => Interop.mkHeaderAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<IHeaderProperty> values(params float[][] values) => Interop.mkHeaderAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<IHeaderProperty> values(Literals.PlotData[] values) => Interop.mkHeaderAttr("values", values);
        /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<IHeaderProperty> values(IEnumerable<bool?> values) => Interop.mkHeaderAttr("values", values.ToArray());
        /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<IHeaderProperty> values(IEnumerable<System.DateTime?> values) => Interop.mkHeaderAttr("values", values.ToArray());
        /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<IHeaderProperty> values(IEnumerable<int?> values) => Interop.mkHeaderAttr("values", values.ToArray());
        /// Header cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<IHeaderProperty> values(IEnumerable<float?> values) => Interop.mkHeaderAttr("values", values.ToArray());
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHeaderProperty> format(bool val) => Interop.mkHeaderAttr("format", new[]{val});
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHeaderProperty> format(params bool[] values) => Interop.mkHeaderAttr("format", values);
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHeaderProperty> format(System.DateTime val) => Interop.mkHeaderAttr("format", new[]{val});
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHeaderProperty> format(params System.DateTime[] values) => Interop.mkHeaderAttr("format", values);
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHeaderProperty> format(float val) => Interop.mkHeaderAttr("format", new[]{val});
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHeaderProperty> format(params float[] values) => Interop.mkHeaderAttr("format", values);
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHeaderProperty> format(int val) => Interop.mkHeaderAttr("format", new[]{val});
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHeaderProperty> format(params int[] values) => Interop.mkHeaderAttr("format", values);
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHeaderProperty> format(string val) => Interop.mkHeaderAttr("format", new[]{val});
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHeaderProperty> format(params string[] values) => Interop.mkHeaderAttr("format", values);
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHeaderProperty> format(IEnumerable<bool[]> values) => Interop.mkHeaderAttr("format", Bindings.flatten2DArrayIf1D(values));
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHeaderProperty> format(List<bool[]> values) => Interop.mkHeaderAttr("format", Bindings.flatten2DArrayIf1D(values));
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHeaderProperty> format(params bool[][] values) => Interop.mkHeaderAttr("format", Bindings.flatten2DArrayIf1D(values));
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHeaderProperty> format(IEnumerable<IEnumerable<string>> values) => Interop.mkHeaderAttr("format", Bindings.flatten2DArrayIf1D(values));
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHeaderProperty> format(List<string[]> values) => Interop.mkHeaderAttr("format", Bindings.flatten2DArrayIf1D(values));
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHeaderProperty> format(params string[][] values) => Interop.mkHeaderAttr("format", Bindings.flatten2DArrayIf1D(values));
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHeaderProperty> format(IEnumerable<IEnumerable<int>> values) => Interop.mkHeaderAttr("format", Bindings.flatten2DArrayIf1D(values));
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHeaderProperty> format(List<int[]> values) => Interop.mkHeaderAttr("format", Bindings.flatten2DArrayIf1D(values));
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHeaderProperty> format(params int[][] values) => Interop.mkHeaderAttr("format", Bindings.flatten2DArrayIf1D(values));
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHeaderProperty> format(IEnumerable<IEnumerable<float>> values) => Interop.mkHeaderAttr("format", Bindings.flatten2DArrayIf1D(values));
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHeaderProperty> format(List<float[]> values) => Interop.mkHeaderAttr("format", Bindings.flatten2DArrayIf1D(values));
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHeaderProperty> format(params float[][] values) => Interop.mkHeaderAttr("format", Bindings.flatten2DArrayIf1D(values));
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHeaderProperty> format(Literals.PlotData[] values) => Interop.mkHeaderAttr("format", values);
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHeaderProperty> format(IEnumerable<bool?> values) => Interop.mkHeaderAttr("format", values.ToArray());
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHeaderProperty> format(IEnumerable<System.DateTime?> values) => Interop.mkHeaderAttr("format", values.ToArray());
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHeaderProperty> format(IEnumerable<int?> values) => Interop.mkHeaderAttr("format", values.ToArray());
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IHeaderProperty> format(IEnumerable<float?> values) => Interop.mkHeaderAttr("format", values.ToArray());
        /// Prefix for cell values.
        public static Box<IHeaderProperty> prefix(string val) => Interop.mkHeaderAttr("prefix", val);
        /// Prefix for cell values.
        public static Box<IHeaderProperty> prefix(IEnumerable<string> values) => Interop.mkHeaderAttr("prefix", values.ToArray());
        /// Suffix for cell values.
        public static Box<IHeaderProperty> suffix(string val) => Interop.mkHeaderAttr("suffix", val);
        /// Suffix for cell values.
        public static Box<IHeaderProperty> suffix(IEnumerable<string> values) => Interop.mkHeaderAttr("suffix", values.ToArray());
        /// The height of cells.
        public static Box<IHeaderProperty> height(int val) => Interop.mkHeaderAttr("height", val);
        /// The height of cells.
        public static Box<IHeaderProperty> height(float val) => Interop.mkHeaderAttr("height", val);
        /// Sets the horizontal alignment of the `text` within the box. Has an effect only if `text` spans two or more lines (i.e. `text` contains one or more <br> HTML tags) or if an explicit width is set to override the text width.
        public static Box<IHeaderProperty> align(IEnumerable<Box<IHeaderProperty>> properties) => Interop.mkHeaderAttr("align", Bindings.flattenProperties(properties));
        public static Box<IHeaderProperty> line(params Box<ILineProperty>[] properties) => Interop.mkHeaderAttr("line", Bindings.flattenProperties(properties));
        public static Box<IHeaderProperty> fill(params Box<IFillProperty>[] properties) => Interop.mkHeaderAttr("fill", Bindings.flattenProperties(properties));
        public static Box<IHeaderProperty> font(params Box<IFontProperty>[] properties) => Interop.mkHeaderAttr("font", Bindings.flattenProperties(properties));
        /// Sets the source reference on plot.ly for  values .
        public static Box<IHeaderProperty> valuessrc(string val) => Interop.mkHeaderAttr("valuessrc", val);
        /// Sets the source reference on plot.ly for  format .
        public static Box<IHeaderProperty> formatsrc(string val) => Interop.mkHeaderAttr("formatsrc", val);
        /// Sets the source reference on plot.ly for  prefix .
        public static Box<IHeaderProperty> prefixsrc(string val) => Interop.mkHeaderAttr("prefixsrc", val);
        /// Sets the source reference on plot.ly for  suffix .
        public static Box<IHeaderProperty> suffixsrc(string val) => Interop.mkHeaderAttr("suffixsrc", val);
        /// Sets the source reference on plot.ly for  align .
        public static Box<IHeaderProperty> alignsrc(string val) => Interop.mkHeaderAttr("alignsrc", val);
    }

    public static partial class Header
    {
        /// Sets the horizontal alignment of the `text` within the box. Has an effect only if `text` spans two or more lines (i.e. `text` contains one or more <br> HTML tags) or if an explicit width is set to override the text width.
        public static partial class Align
        {
            public static Box<IHeaderProperty> center() => Interop.mkHeaderAttr("align", "center");
            public static Box<IHeaderProperty> left() => Interop.mkHeaderAttr("align", "left");
            public static Box<IHeaderProperty> right() => Interop.mkHeaderAttr("align", "right");
        }
    }
}