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

    public static partial class Grid
    {
        /// The number of rows in the grid. If you provide a 2D `subplots` array or a `yaxes` array, its length is used as the default. But it's also possible to have a different length, if you want to leave a row at the end for non-cartesian subplots.
        public static Box<IGridProperty> rows(int val) => Interop.mkGridAttr("rows", val);
        /// The number of columns in the grid. If you provide a 2D `subplots` array, the length of its longest row is used as the default. If you give an `xaxes` array, its length is used as the default. But it's also possible to have a different length, if you want to leave a row at the end for non-cartesian subplots.
        public static Box<IGridProperty> columns(int val) => Interop.mkGridAttr("columns", val);
        /// Horizontal space between grid cells, expressed as a fraction of the total width available to one cell. Defaults to 0.1 for coupled-axes grids and 0.2 for independent grids.
        public static Box<IGridProperty> xgap(int val) => Interop.mkGridAttr("xgap", val);
        /// Horizontal space between grid cells, expressed as a fraction of the total width available to one cell. Defaults to 0.1 for coupled-axes grids and 0.2 for independent grids.
        public static Box<IGridProperty> xgap(float val) => Interop.mkGridAttr("xgap", val);
        /// Vertical space between grid cells, expressed as a fraction of the total height available to one cell. Defaults to 0.1 for coupled-axes grids and 0.3 for independent grids.
        public static Box<IGridProperty> ygap(int val) => Interop.mkGridAttr("ygap", val);
        /// Vertical space between grid cells, expressed as a fraction of the total height available to one cell. Defaults to 0.1 for coupled-axes grids and 0.3 for independent grids.
        public static Box<IGridProperty> ygap(float val) => Interop.mkGridAttr("ygap", val);
        public static Box<IGridProperty> domain(params Box<IDomainProperty>[] properties) => Interop.mkGridAttr("domain", Bindings.flattenProperties(properties));
    }

    public static partial class Grid
    {
        /// Is the first row the top or the bottom? Note that columns are always enumerated from left to right.
        public static partial class Roworder
        {
            public static Box<IGridProperty> bottomToTop() => Interop.mkGridAttr("roworder", "bottom to top");
            public static Box<IGridProperty> topToBottom() => Interop.mkGridAttr("roworder", "top to bottom");
        }

        /// If no `subplots`, `xaxes`, or `yaxes` are given but we do have `rows` and `columns`, we can generate defaults using consecutive axis IDs, in two ways: *coupled* gives one x axis per column and one y axis per row. *independent* uses a new xy pair for each cell, left-to-right across each row then iterating rows according to `roworder`.
        public static partial class Pattern
        {
            public static Box<IGridProperty> coupled() => Interop.mkGridAttr("pattern", "coupled");
            public static Box<IGridProperty> independent() => Interop.mkGridAttr("pattern", "independent");
        }

        /// Sets where the x axis labels and titles go. *bottom* means the very bottom of the grid. *bottom plot* is the lowest plot that each x axis is used in. *top* and *top plot* are similar.
        public static partial class Xside
        {
            public static Box<IGridProperty> bottomPlot() => Interop.mkGridAttr("xside", "bottom plot");
            public static Box<IGridProperty> bottom() => Interop.mkGridAttr("xside", "bottom");
            public static Box<IGridProperty> topPlot() => Interop.mkGridAttr("xside", "top plot");
            public static Box<IGridProperty> top() => Interop.mkGridAttr("xside", "top");
        }

        /// Sets where the y axis labels and titles go. *left* means the very left edge of the grid. *left plot* is the leftmost plot that each y axis is used in. *right* and *right plot* are similar.
        public static partial class Yside
        {
            public static Box<IGridProperty> leftPlot() => Interop.mkGridAttr("yside", "left plot");
            public static Box<IGridProperty> left() => Interop.mkGridAttr("yside", "left");
            public static Box<IGridProperty> rightPlot() => Interop.mkGridAttr("yside", "right plot");
            public static Box<IGridProperty> right() => Interop.mkGridAttr("yside", "right");
        }
    }
}