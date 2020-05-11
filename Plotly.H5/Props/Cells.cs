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

    public static partial class Cells
    {
        /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<ICellsProperty> values(bool val) => Interop.mkCellsAttr("values", new[]{val});
        /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<ICellsProperty> values(params bool[] values) => Interop.mkCellsAttr("values", values);
        /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<ICellsProperty> values(System.DateTime val) => Interop.mkCellsAttr("values", new[]{val});
        /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<ICellsProperty> values(params System.DateTime[] values) => Interop.mkCellsAttr("values", values);
        /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<ICellsProperty> values(float val) => Interop.mkCellsAttr("values", new[]{val});
        /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<ICellsProperty> values(params float[] values) => Interop.mkCellsAttr("values", values);
        /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<ICellsProperty> values(int val) => Interop.mkCellsAttr("values", new[]{val});
        /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<ICellsProperty> values(params int[] values) => Interop.mkCellsAttr("values", values);
        /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<ICellsProperty> values(string val) => Interop.mkCellsAttr("values", new[]{val});
        /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<ICellsProperty> values(params string[] values) => Interop.mkCellsAttr("values", values);
        /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<ICellsProperty> values(IEnumerable<bool[]> values) => Interop.mkCellsAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<ICellsProperty> values(List<bool[]> values) => Interop.mkCellsAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<ICellsProperty> values(params bool[][] values) => Interop.mkCellsAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<ICellsProperty> values(IEnumerable<IEnumerable<string>> values) => Interop.mkCellsAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<ICellsProperty> values(List<string[]> values) => Interop.mkCellsAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<ICellsProperty> values(params string[][] values) => Interop.mkCellsAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<ICellsProperty> values(IEnumerable<IEnumerable<int>> values) => Interop.mkCellsAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<ICellsProperty> values(List<int[]> values) => Interop.mkCellsAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<ICellsProperty> values(params int[][] values) => Interop.mkCellsAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<ICellsProperty> values(IEnumerable<IEnumerable<float>> values) => Interop.mkCellsAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<ICellsProperty> values(List<float[]> values) => Interop.mkCellsAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<ICellsProperty> values(params float[][] values) => Interop.mkCellsAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<ICellsProperty> values(Literals.PlotData[] values) => Interop.mkCellsAttr("values", values);
        /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<ICellsProperty> values(IEnumerable<bool?> values) => Interop.mkCellsAttr("values", values.ToArray());
        /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<ICellsProperty> values(IEnumerable<System.DateTime?> values) => Interop.mkCellsAttr("values", values.ToArray());
        /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<ICellsProperty> values(IEnumerable<int?> values) => Interop.mkCellsAttr("values", values.ToArray());
        /// Cell values. `values[m][n]` represents the value of the `n`th point in column `m`, therefore the `values[m]` vector length for all columns must be the same (longer vectors will be truncated). Each value must be a finite number or a string.
        public static Box<ICellsProperty> values(IEnumerable<float?> values) => Interop.mkCellsAttr("values", values.ToArray());
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<ICellsProperty> format(bool val) => Interop.mkCellsAttr("format", new[]{val});
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<ICellsProperty> format(params bool[] values) => Interop.mkCellsAttr("format", values);
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<ICellsProperty> format(System.DateTime val) => Interop.mkCellsAttr("format", new[]{val});
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<ICellsProperty> format(params System.DateTime[] values) => Interop.mkCellsAttr("format", values);
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<ICellsProperty> format(float val) => Interop.mkCellsAttr("format", new[]{val});
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<ICellsProperty> format(params float[] values) => Interop.mkCellsAttr("format", values);
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<ICellsProperty> format(int val) => Interop.mkCellsAttr("format", new[]{val});
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<ICellsProperty> format(params int[] values) => Interop.mkCellsAttr("format", values);
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<ICellsProperty> format(string val) => Interop.mkCellsAttr("format", new[]{val});
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<ICellsProperty> format(params string[] values) => Interop.mkCellsAttr("format", values);
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<ICellsProperty> format(IEnumerable<bool[]> values) => Interop.mkCellsAttr("format", Bindings.flatten2DArrayIf1D(values));
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<ICellsProperty> format(List<bool[]> values) => Interop.mkCellsAttr("format", Bindings.flatten2DArrayIf1D(values));
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<ICellsProperty> format(params bool[][] values) => Interop.mkCellsAttr("format", Bindings.flatten2DArrayIf1D(values));
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<ICellsProperty> format(IEnumerable<IEnumerable<string>> values) => Interop.mkCellsAttr("format", Bindings.flatten2DArrayIf1D(values));
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<ICellsProperty> format(List<string[]> values) => Interop.mkCellsAttr("format", Bindings.flatten2DArrayIf1D(values));
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<ICellsProperty> format(params string[][] values) => Interop.mkCellsAttr("format", Bindings.flatten2DArrayIf1D(values));
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<ICellsProperty> format(IEnumerable<IEnumerable<int>> values) => Interop.mkCellsAttr("format", Bindings.flatten2DArrayIf1D(values));
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<ICellsProperty> format(List<int[]> values) => Interop.mkCellsAttr("format", Bindings.flatten2DArrayIf1D(values));
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<ICellsProperty> format(params int[][] values) => Interop.mkCellsAttr("format", Bindings.flatten2DArrayIf1D(values));
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<ICellsProperty> format(IEnumerable<IEnumerable<float>> values) => Interop.mkCellsAttr("format", Bindings.flatten2DArrayIf1D(values));
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<ICellsProperty> format(List<float[]> values) => Interop.mkCellsAttr("format", Bindings.flatten2DArrayIf1D(values));
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<ICellsProperty> format(params float[][] values) => Interop.mkCellsAttr("format", Bindings.flatten2DArrayIf1D(values));
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<ICellsProperty> format(Literals.PlotData[] values) => Interop.mkCellsAttr("format", values);
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<ICellsProperty> format(IEnumerable<bool?> values) => Interop.mkCellsAttr("format", values.ToArray());
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<ICellsProperty> format(IEnumerable<System.DateTime?> values) => Interop.mkCellsAttr("format", values.ToArray());
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<ICellsProperty> format(IEnumerable<int?> values) => Interop.mkCellsAttr("format", values.ToArray());
        /// Sets the cell value formatting rule using d3 formatting mini-language which is similar to those of Python. See https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<ICellsProperty> format(IEnumerable<float?> values) => Interop.mkCellsAttr("format", values.ToArray());
        /// Prefix for cell values.
        public static Box<ICellsProperty> prefix(string val) => Interop.mkCellsAttr("prefix", val);
        /// Prefix for cell values.
        public static Box<ICellsProperty> prefix(IEnumerable<string> values) => Interop.mkCellsAttr("prefix", values.ToArray());
        /// Suffix for cell values.
        public static Box<ICellsProperty> suffix(string val) => Interop.mkCellsAttr("suffix", val);
        /// Suffix for cell values.
        public static Box<ICellsProperty> suffix(IEnumerable<string> values) => Interop.mkCellsAttr("suffix", values.ToArray());
        /// The height of cells.
        public static Box<ICellsProperty> height(int val) => Interop.mkCellsAttr("height", val);
        /// The height of cells.
        public static Box<ICellsProperty> height(float val) => Interop.mkCellsAttr("height", val);
        /// Sets the horizontal alignment of the `text` within the box. Has an effect only if `text` spans two or more lines (i.e. `text` contains one or more <br> HTML tags) or if an explicit width is set to override the text width.
        public static Box<ICellsProperty> align(IEnumerable<Box<ICellsProperty>> properties) => Interop.mkCellsAttr("align", Bindings.flattenProperties(properties));
        public static Box<ICellsProperty> line(params Box<ILineProperty>[] properties) => Interop.mkCellsAttr("line", Bindings.flattenProperties(properties));
        public static Box<ICellsProperty> fill(params Box<IFillProperty>[] properties) => Interop.mkCellsAttr("fill", Bindings.flattenProperties(properties));
        public static Box<ICellsProperty> font(params Box<IFontProperty>[] properties) => Interop.mkCellsAttr("font", Bindings.flattenProperties(properties));
        /// Sets the source reference on plot.ly for  values .
        public static Box<ICellsProperty> valuessrc(string val) => Interop.mkCellsAttr("valuessrc", val);
        /// Sets the source reference on plot.ly for  format .
        public static Box<ICellsProperty> formatsrc(string val) => Interop.mkCellsAttr("formatsrc", val);
        /// Sets the source reference on plot.ly for  prefix .
        public static Box<ICellsProperty> prefixsrc(string val) => Interop.mkCellsAttr("prefixsrc", val);
        /// Sets the source reference on plot.ly for  suffix .
        public static Box<ICellsProperty> suffixsrc(string val) => Interop.mkCellsAttr("suffixsrc", val);
        /// Sets the source reference on plot.ly for  align .
        public static Box<ICellsProperty> alignsrc(string val) => Interop.mkCellsAttr("alignsrc", val);
    }

    public static partial class Cells
    {
        /// Sets the horizontal alignment of the `text` within the box. Has an effect only if `text` spans two or more lines (i.e. `text` contains one or more <br> HTML tags) or if an explicit width is set to override the text width.
        public static partial class Align
        {
            public static Box<ICellsProperty> center() => Interop.mkCellsAttr("align", "center");
            public static Box<ICellsProperty> left() => Interop.mkCellsAttr("align", "left");
            public static Box<ICellsProperty> right() => Interop.mkCellsAttr("align", "right");
        }
    }
}