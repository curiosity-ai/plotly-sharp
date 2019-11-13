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

    public static partial class Dimension
    {
        /// Determines whether or not this dimension is shown on the graph. Note that even visible false dimension contribute to the default grid generate by this splom trace.
        public static Box<IDimensionProperty> visible(bool val) => Interop.mkDimensionAttr("visible", val);
        /// Sets the label corresponding to this splom dimension.
        public static Box<IDimensionProperty> label(string val) => Interop.mkDimensionAttr("label", val);
        /// Sets the dimension values to be plotted.
        public static Box<IDimensionProperty> values(bool val) => Interop.mkDimensionAttr("values", new[]{val});
        /// Sets the dimension values to be plotted.
        public static Box<IDimensionProperty> values(IEnumerable<bool> values) => Interop.mkDimensionAttr("values", values.ToArray());
        /// Sets the dimension values to be plotted.
        public static Box<IDimensionProperty> values(System.DateTime val) => Interop.mkDimensionAttr("values", new[]{val});
        /// Sets the dimension values to be plotted.
        public static Box<IDimensionProperty> values(IEnumerable<System.DateTime> values) => Interop.mkDimensionAttr("values", values.ToArray());
        /// Sets the dimension values to be plotted.
        public static Box<IDimensionProperty> values(float val) => Interop.mkDimensionAttr("values", new[]{val});
        /// Sets the dimension values to be plotted.
        public static Box<IDimensionProperty> values(IEnumerable<float> values) => Interop.mkDimensionAttr("values", values.ToArray());
        /// Sets the dimension values to be plotted.
        public static Box<IDimensionProperty> values(int val) => Interop.mkDimensionAttr("values", new[]{val});
        /// Sets the dimension values to be plotted.
        public static Box<IDimensionProperty> values(IEnumerable<int> values) => Interop.mkDimensionAttr("values", values.ToArray());
        /// Sets the dimension values to be plotted.
        public static Box<IDimensionProperty> values(string val) => Interop.mkDimensionAttr("values", new[]{val});
        /// Sets the dimension values to be plotted.
        public static Box<IDimensionProperty> values(IEnumerable<string> values) => Interop.mkDimensionAttr("values", values.ToArray());
        /// Sets the dimension values to be plotted.
        public static Box<IDimensionProperty> values(IEnumerable<bool[]> values) => Interop.mkDimensionAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the dimension values to be plotted.
        public static Box<IDimensionProperty> values(List<bool[]> values) => Interop.mkDimensionAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the dimension values to be plotted.
        public static Box<IDimensionProperty> values(params bool[][] values) => Interop.mkDimensionAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the dimension values to be plotted.
        public static Box<IDimensionProperty> values(IEnumerable<IEnumerable<string>> values) => Interop.mkDimensionAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the dimension values to be plotted.
        public static Box<IDimensionProperty> values(List<string[]> values) => Interop.mkDimensionAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the dimension values to be plotted.
        public static Box<IDimensionProperty> values(params string[][] values) => Interop.mkDimensionAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the dimension values to be plotted.
        public static Box<IDimensionProperty> values(IEnumerable<IEnumerable<int>> values) => Interop.mkDimensionAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the dimension values to be plotted.
        public static Box<IDimensionProperty> values(List<int[]> values) => Interop.mkDimensionAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the dimension values to be plotted.
        public static Box<IDimensionProperty> values(params int[][] values) => Interop.mkDimensionAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the dimension values to be plotted.
        public static Box<IDimensionProperty> values(IEnumerable<IEnumerable<float>> values) => Interop.mkDimensionAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the dimension values to be plotted.
        public static Box<IDimensionProperty> values(List<float[]> values) => Interop.mkDimensionAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the dimension values to be plotted.
        public static Box<IDimensionProperty> values(params float[][] values) => Interop.mkDimensionAttr("values", Bindings.flatten2DArrayIf1D(values));
        /// Sets the dimension values to be plotted.
        public static Box<IDimensionProperty> values(Literals.PlotData[] values) => Interop.mkDimensionAttr("values", values);
        /// Sets the dimension values to be plotted.
        public static Box<IDimensionProperty> values(IEnumerable<bool?> values) => Interop.mkDimensionAttr("values", values.ToArray());
        /// Sets the dimension values to be plotted.
        public static Box<IDimensionProperty> values(IEnumerable<System.DateTime?> values) => Interop.mkDimensionAttr("values", values.ToArray());
        /// Sets the dimension values to be plotted.
        public static Box<IDimensionProperty> values(IEnumerable<int?> values) => Interop.mkDimensionAttr("values", values.ToArray());
        /// Sets the dimension values to be plotted.
        public static Box<IDimensionProperty> values(IEnumerable<float?> values) => Interop.mkDimensionAttr("values", values.ToArray());
        public static Box<IDimensionProperty> axis(params Box<IAxisProperty>[] properties) => Interop.mkDimensionAttr("axis", Bindings.flattenProperties(properties));
        /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
        public static Box<IDimensionProperty> name(string val) => Interop.mkDimensionAttr("name", val);
        /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
        public static Box<IDimensionProperty> templateitemname(string val) => Interop.mkDimensionAttr("templateitemname", val);
        /// Sets the source reference on plot.ly for  values .
        public static Box<IDimensionProperty> valuessrc(string val) => Interop.mkDimensionAttr("valuessrc", val);
        /// Sets the values at which ticks on this axis appear.
        public static Box<IDimensionProperty> tickvals(bool val) => Interop.mkDimensionAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear.
        public static Box<IDimensionProperty> tickvals(IEnumerable<bool> values) => Interop.mkDimensionAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear.
        public static Box<IDimensionProperty> tickvals(System.DateTime val) => Interop.mkDimensionAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear.
        public static Box<IDimensionProperty> tickvals(IEnumerable<System.DateTime> values) => Interop.mkDimensionAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear.
        public static Box<IDimensionProperty> tickvals(float val) => Interop.mkDimensionAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear.
        public static Box<IDimensionProperty> tickvals(IEnumerable<float> values) => Interop.mkDimensionAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear.
        public static Box<IDimensionProperty> tickvals(int val) => Interop.mkDimensionAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear.
        public static Box<IDimensionProperty> tickvals(IEnumerable<int> values) => Interop.mkDimensionAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear.
        public static Box<IDimensionProperty> tickvals(string val) => Interop.mkDimensionAttr("tickvals", new[]{val});
        /// Sets the values at which ticks on this axis appear.
        public static Box<IDimensionProperty> tickvals(IEnumerable<string> values) => Interop.mkDimensionAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear.
        public static Box<IDimensionProperty> tickvals(IEnumerable<bool[]> values) => Interop.mkDimensionAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear.
        public static Box<IDimensionProperty> tickvals(List<bool[]> values) => Interop.mkDimensionAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear.
        public static Box<IDimensionProperty> tickvals(params bool[][] values) => Interop.mkDimensionAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear.
        public static Box<IDimensionProperty> tickvals(IEnumerable<IEnumerable<string>> values) => Interop.mkDimensionAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear.
        public static Box<IDimensionProperty> tickvals(List<string[]> values) => Interop.mkDimensionAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear.
        public static Box<IDimensionProperty> tickvals(params string[][] values) => Interop.mkDimensionAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear.
        public static Box<IDimensionProperty> tickvals(IEnumerable<IEnumerable<int>> values) => Interop.mkDimensionAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear.
        public static Box<IDimensionProperty> tickvals(List<int[]> values) => Interop.mkDimensionAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear.
        public static Box<IDimensionProperty> tickvals(params int[][] values) => Interop.mkDimensionAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear.
        public static Box<IDimensionProperty> tickvals(IEnumerable<IEnumerable<float>> values) => Interop.mkDimensionAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear.
        public static Box<IDimensionProperty> tickvals(List<float[]> values) => Interop.mkDimensionAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear.
        public static Box<IDimensionProperty> tickvals(params float[][] values) => Interop.mkDimensionAttr("tickvals", Bindings.flatten2DArrayIf1D(values));
        /// Sets the values at which ticks on this axis appear.
        public static Box<IDimensionProperty> tickvals(Literals.PlotData[] values) => Interop.mkDimensionAttr("tickvals", values);
        /// Sets the values at which ticks on this axis appear.
        public static Box<IDimensionProperty> tickvals(IEnumerable<bool?> values) => Interop.mkDimensionAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear.
        public static Box<IDimensionProperty> tickvals(IEnumerable<System.DateTime?> values) => Interop.mkDimensionAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear.
        public static Box<IDimensionProperty> tickvals(IEnumerable<int?> values) => Interop.mkDimensionAttr("tickvals", values.ToArray());
        /// Sets the values at which ticks on this axis appear.
        public static Box<IDimensionProperty> tickvals(IEnumerable<float?> values) => Interop.mkDimensionAttr("tickvals", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`.
        public static Box<IDimensionProperty> ticktext(bool val) => Interop.mkDimensionAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`.
        public static Box<IDimensionProperty> ticktext(IEnumerable<bool> values) => Interop.mkDimensionAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`.
        public static Box<IDimensionProperty> ticktext(System.DateTime val) => Interop.mkDimensionAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`.
        public static Box<IDimensionProperty> ticktext(IEnumerable<System.DateTime> values) => Interop.mkDimensionAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`.
        public static Box<IDimensionProperty> ticktext(float val) => Interop.mkDimensionAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`.
        public static Box<IDimensionProperty> ticktext(IEnumerable<float> values) => Interop.mkDimensionAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`.
        public static Box<IDimensionProperty> ticktext(int val) => Interop.mkDimensionAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`.
        public static Box<IDimensionProperty> ticktext(IEnumerable<int> values) => Interop.mkDimensionAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`.
        public static Box<IDimensionProperty> ticktext(string val) => Interop.mkDimensionAttr("ticktext", new[]{val});
        /// Sets the text displayed at the ticks position via `tickvals`.
        public static Box<IDimensionProperty> ticktext(IEnumerable<string> values) => Interop.mkDimensionAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`.
        public static Box<IDimensionProperty> ticktext(IEnumerable<bool[]> values) => Interop.mkDimensionAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`.
        public static Box<IDimensionProperty> ticktext(List<bool[]> values) => Interop.mkDimensionAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`.
        public static Box<IDimensionProperty> ticktext(params bool[][] values) => Interop.mkDimensionAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`.
        public static Box<IDimensionProperty> ticktext(IEnumerable<IEnumerable<string>> values) => Interop.mkDimensionAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`.
        public static Box<IDimensionProperty> ticktext(List<string[]> values) => Interop.mkDimensionAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`.
        public static Box<IDimensionProperty> ticktext(params string[][] values) => Interop.mkDimensionAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`.
        public static Box<IDimensionProperty> ticktext(IEnumerable<IEnumerable<int>> values) => Interop.mkDimensionAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`.
        public static Box<IDimensionProperty> ticktext(List<int[]> values) => Interop.mkDimensionAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`.
        public static Box<IDimensionProperty> ticktext(params int[][] values) => Interop.mkDimensionAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`.
        public static Box<IDimensionProperty> ticktext(IEnumerable<IEnumerable<float>> values) => Interop.mkDimensionAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`.
        public static Box<IDimensionProperty> ticktext(List<float[]> values) => Interop.mkDimensionAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`.
        public static Box<IDimensionProperty> ticktext(params float[][] values) => Interop.mkDimensionAttr("ticktext", Bindings.flatten2DArrayIf1D(values));
        /// Sets the text displayed at the ticks position via `tickvals`.
        public static Box<IDimensionProperty> ticktext(Literals.PlotData[] values) => Interop.mkDimensionAttr("ticktext", values);
        /// Sets the text displayed at the ticks position via `tickvals`.
        public static Box<IDimensionProperty> ticktext(IEnumerable<bool?> values) => Interop.mkDimensionAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`.
        public static Box<IDimensionProperty> ticktext(IEnumerable<System.DateTime?> values) => Interop.mkDimensionAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`.
        public static Box<IDimensionProperty> ticktext(IEnumerable<int?> values) => Interop.mkDimensionAttr("ticktext", values.ToArray());
        /// Sets the text displayed at the ticks position via `tickvals`.
        public static Box<IDimensionProperty> ticktext(IEnumerable<float?> values) => Interop.mkDimensionAttr("ticktext", values.ToArray());
        /// Sets the tick label formatting rule using d3 formatting mini-languages which are very similar to those in Python. For numbers, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format And for dates see: https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format We add one item to d3's date formatter: *%{n}f* for fractional seconds with n digits. For example, *2016-10-13 09:15:23.456* with tickformat *%H~%M~%S.%2f* would display *09~15~23.46*
        public static Box<IDimensionProperty> tickformat(string val) => Interop.mkDimensionAttr("tickformat", val);
        /// The domain range that represents the full, shown axis extent. Defaults to the `values` extent. Must be an array of `[fromValue, toValue]` with finite numbers as elements.
        public static Box<IDimensionProperty> range(int val) => Interop.mkDimensionAttr("range", new[]{val});
        /// The domain range that represents the full, shown axis extent. Defaults to the `values` extent. Must be an array of `[fromValue, toValue]` with finite numbers as elements.
        public static Box<IDimensionProperty> range(IEnumerable<int> values) => Interop.mkDimensionAttr("range", values.ToArray());
        /// The domain range that represents the full, shown axis extent. Defaults to the `values` extent. Must be an array of `[fromValue, toValue]` with finite numbers as elements.
        public static Box<IDimensionProperty> range(float val) => Interop.mkDimensionAttr("range", new[]{val});
        /// The domain range that represents the full, shown axis extent. Defaults to the `values` extent. Must be an array of `[fromValue, toValue]` with finite numbers as elements.
        public static Box<IDimensionProperty> range(IEnumerable<float> values) => Interop.mkDimensionAttr("range", values.ToArray());
        /// The domain range to which the filter on the dimension is constrained. Must be an array of `[fromValue, toValue]` with `fromValue <  =  toValue ` , or  if ` multiselect ` is  not  disabled , you  may  give  an  array  of  arrays , where  each  inner  array  is ` [ fromValue , toValue ] ` . 
        public static Box<IDimensionProperty> constraintrange(int val) => Interop.mkDimensionAttr("constraintrange", new[]{val});
        /// The domain range to which the filter on the dimension is constrained. Must be an array of `[fromValue, toValue]` with `fromValue <  =  toValue ` , or  if ` multiselect ` is  not  disabled , you  may  give  an  array  of  arrays , where  each  inner  array  is ` [ fromValue , toValue ] ` . 
        public static Box<IDimensionProperty> constraintrange(IEnumerable<int> values) => Interop.mkDimensionAttr("constraintrange", values.ToArray());
        /// The domain range to which the filter on the dimension is constrained. Must be an array of `[fromValue, toValue]` with `fromValue <  =  toValue ` , or  if ` multiselect ` is  not  disabled , you  may  give  an  array  of  arrays , where  each  inner  array  is ` [ fromValue , toValue ] ` . 
        public static Box<IDimensionProperty> constraintrange(float val) => Interop.mkDimensionAttr("constraintrange", new[]{val});
        /// The domain range to which the filter on the dimension is constrained. Must be an array of `[fromValue, toValue]` with `fromValue <  =  toValue ` , or  if ` multiselect ` is  not  disabled , you  may  give  an  array  of  arrays , where  each  inner  array  is ` [ fromValue , toValue ] ` . 
        public static Box<IDimensionProperty> constraintrange(IEnumerable<float> values) => Interop.mkDimensionAttr("constraintrange", values.ToArray());
        /// Do we allow multiple selection ranges or just a single range?
        public static Box<IDimensionProperty> multiselect(bool val) => Interop.mkDimensionAttr("multiselect", val);
        /// Sets the source reference on plot.ly for  tickvals .
        public static Box<IDimensionProperty> tickvalssrc(string val) => Interop.mkDimensionAttr("tickvalssrc", val);
        /// Sets the source reference on plot.ly for  ticktext .
        public static Box<IDimensionProperty> ticktextsrc(string val) => Interop.mkDimensionAttr("ticktextsrc", val);
        /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IDimensionProperty> categoryarray(bool val) => Interop.mkDimensionAttr("categoryarray", new[]{val});
        /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IDimensionProperty> categoryarray(params bool[] values) => Interop.mkDimensionAttr("categoryarray", values);
        /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IDimensionProperty> categoryarray(System.DateTime val) => Interop.mkDimensionAttr("categoryarray", new[]{val});
        /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IDimensionProperty> categoryarray(params System.DateTime[] values) => Interop.mkDimensionAttr("categoryarray", values);
        /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IDimensionProperty> categoryarray(float val) => Interop.mkDimensionAttr("categoryarray", new[]{val});
        /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IDimensionProperty> categoryarray(params float[] values) => Interop.mkDimensionAttr("categoryarray", values);
        /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IDimensionProperty> categoryarray(int val) => Interop.mkDimensionAttr("categoryarray", new[]{val});
        /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IDimensionProperty> categoryarray(params int[] values) => Interop.mkDimensionAttr("categoryarray", values);
        /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IDimensionProperty> categoryarray(string val) => Interop.mkDimensionAttr("categoryarray", new[]{val});
        /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IDimensionProperty> categoryarray(params string[] values) => Interop.mkDimensionAttr("categoryarray", values);
        /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IDimensionProperty> categoryarray(IEnumerable<bool[]> values) => Interop.mkDimensionAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IDimensionProperty> categoryarray(List<bool[]> values) => Interop.mkDimensionAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IDimensionProperty> categoryarray(params bool[][] values) => Interop.mkDimensionAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IDimensionProperty> categoryarray(IEnumerable<IEnumerable<string>> values) => Interop.mkDimensionAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IDimensionProperty> categoryarray(List<string[]> values) => Interop.mkDimensionAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IDimensionProperty> categoryarray(params string[][] values) => Interop.mkDimensionAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IDimensionProperty> categoryarray(IEnumerable<IEnumerable<int>> values) => Interop.mkDimensionAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IDimensionProperty> categoryarray(List<int[]> values) => Interop.mkDimensionAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IDimensionProperty> categoryarray(params int[][] values) => Interop.mkDimensionAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IDimensionProperty> categoryarray(IEnumerable<IEnumerable<float>> values) => Interop.mkDimensionAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IDimensionProperty> categoryarray(List<float[]> values) => Interop.mkDimensionAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IDimensionProperty> categoryarray(params float[][] values) => Interop.mkDimensionAttr("categoryarray", Bindings.flatten2DArrayIf1D(values));
        /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IDimensionProperty> categoryarray(Literals.PlotData[] values) => Interop.mkDimensionAttr("categoryarray", values);
        /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IDimensionProperty> categoryarray(IEnumerable<bool?> values) => Interop.mkDimensionAttr("categoryarray", values.ToArray());
        /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IDimensionProperty> categoryarray(IEnumerable<System.DateTime?> values) => Interop.mkDimensionAttr("categoryarray", values.ToArray());
        /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IDimensionProperty> categoryarray(IEnumerable<int?> values) => Interop.mkDimensionAttr("categoryarray", values.ToArray());
        /// Sets the order in which categories in this dimension appear. Only has an effect if `categoryorder` is set to *array*. Used with `categoryorder`.
        public static Box<IDimensionProperty> categoryarray(IEnumerable<float?> values) => Interop.mkDimensionAttr("categoryarray", values.ToArray());
        /// The display index of dimension, from left to right, zero indexed, defaults to dimension index.
        public static Box<IDimensionProperty> displayindex(int val) => Interop.mkDimensionAttr("displayindex", val);
        /// Sets the source reference on plot.ly for  categoryarray .
        public static Box<IDimensionProperty> categoryarraysrc(string val) => Interop.mkDimensionAttr("categoryarraysrc", val);
    }

    public static partial class Dimension
    {
        /// Specifies the ordering logic for the categories in the dimension. By default, plotly uses *trace*, which specifies the order that is present in the data supplied. Set `categoryorder` to *category ascending* or *category descending* if order should be determined by the alphanumerical order of the category names. Set `categoryorder` to *array* to derive the ordering from the attribute `categoryarray`. If a category is not found in the `categoryarray` array, the sorting behavior for that attribute will be identical to the *trace* mode. The unspecified categories will follow the categories in `categoryarray`.
        public static partial class Categoryorder
        {
            public static Box<IDimensionProperty> array() => Interop.mkDimensionAttr("categoryorder", "array");
            public static Box<IDimensionProperty> categoryAscending() => Interop.mkDimensionAttr("categoryorder", "category ascending");
            public static Box<IDimensionProperty> categoryDescending() => Interop.mkDimensionAttr("categoryorder", "category descending");
            public static Box<IDimensionProperty> trace() => Interop.mkDimensionAttr("categoryorder", "trace");
        }
    }
}