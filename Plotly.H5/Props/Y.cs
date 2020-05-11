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

    public static partial class Y
    {
        /// Sets whether or not projections are shown along the y axis.
        public static Box<IYProperty> show(bool val) => Interop.mkYAttr("show", val);
        /// Sets the projection color.
        public static Box<IYProperty> opacity(int val) => Interop.mkYAttr("opacity", val);
        /// Sets the projection color.
        public static Box<IYProperty> opacity(float val) => Interop.mkYAttr("opacity", val);
        /// Sets the scale factor determining the size of the projection marker points.
        public static Box<IYProperty> scale(int val) => Interop.mkYAttr("scale", val);
        /// Sets the scale factor determining the size of the projection marker points.
        public static Box<IYProperty> scale(float val) => Interop.mkYAttr("scale", val);
        /// Sets the starting contour level value. Must be less than `contours.end`
        public static Box<IYProperty> start(int val) => Interop.mkYAttr("start", val);
        /// Sets the starting contour level value. Must be less than `contours.end`
        public static Box<IYProperty> start(float val) => Interop.mkYAttr("start", val);
        /// Sets the end contour level value. Must be more than `contours.start`
        public static Box<IYProperty> _end(int val) => Interop.mkYAttr("end", val);
        /// Sets the end contour level value. Must be more than `contours.start`
        public static Box<IYProperty> _end(float val) => Interop.mkYAttr("end", val);
        /// Sets the step between each contour level. Must be positive.
        public static Box<IYProperty> size(int val) => Interop.mkYAttr("size", val);
        /// Sets the step between each contour level. Must be positive.
        public static Box<IYProperty> size(float val) => Interop.mkYAttr("size", val);
        public static Box<IYProperty> project(params Box<IProjectProperty>[] properties) => Interop.mkYAttr("project", Bindings.flattenProperties(properties));
        /// Sets the color of the contour lines.
        public static Box<IYProperty> color(string val) => Interop.mkYAttr("color", val);
        /// An alternate to *color*. Determines whether or not the contour lines are colored using the trace *colorscale*.
        public static Box<IYProperty> usecolormap(bool val) => Interop.mkYAttr("usecolormap", val);
        /// Sets the width of the contour lines.
        public static Box<IYProperty> width(int val) => Interop.mkYAttr("width", val);
        /// Sets the width of the contour lines.
        public static Box<IYProperty> width(float val) => Interop.mkYAttr("width", val);
        /// Determines whether or not contour lines about the y dimension are highlighted on hover.
        public static Box<IYProperty> highlight(bool val) => Interop.mkYAttr("highlight", val);
        /// Sets the color of the highlighted contour lines.
        public static Box<IYProperty> highlightcolor(string val) => Interop.mkYAttr("highlightcolor", val);
        /// Sets the width of the highlighted contour lines.
        public static Box<IYProperty> highlightwidth(int val) => Interop.mkYAttr("highlightwidth", val);
        /// Sets the width of the highlighted contour lines.
        public static Box<IYProperty> highlightwidth(float val) => Interop.mkYAttr("highlightwidth", val);
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
        public static Box<IYProperty> locations(bool val) => Interop.mkYAttr("locations", new[]{val});
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
        public static Box<IYProperty> locations(params bool[] values) => Interop.mkYAttr("locations", values);
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
        public static Box<IYProperty> locations(System.DateTime val) => Interop.mkYAttr("locations", new[]{val});
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
        public static Box<IYProperty> locations(params System.DateTime[] values) => Interop.mkYAttr("locations", values);
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
        public static Box<IYProperty> locations(float val) => Interop.mkYAttr("locations", new[]{val});
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
        public static Box<IYProperty> locations(params float[] values) => Interop.mkYAttr("locations", values);
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
        public static Box<IYProperty> locations(int val) => Interop.mkYAttr("locations", new[]{val});
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
        public static Box<IYProperty> locations(params int[] values) => Interop.mkYAttr("locations", values);
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
        public static Box<IYProperty> locations(string val) => Interop.mkYAttr("locations", new[]{val});
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
        public static Box<IYProperty> locations(params string[] values) => Interop.mkYAttr("locations", values);
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
        public static Box<IYProperty> locations(IEnumerable<bool[]> values) => Interop.mkYAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
        public static Box<IYProperty> locations(List<bool[]> values) => Interop.mkYAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
        public static Box<IYProperty> locations(params bool[][] values) => Interop.mkYAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
        public static Box<IYProperty> locations(IEnumerable<IEnumerable<string>> values) => Interop.mkYAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
        public static Box<IYProperty> locations(List<string[]> values) => Interop.mkYAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
        public static Box<IYProperty> locations(params string[][] values) => Interop.mkYAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
        public static Box<IYProperty> locations(IEnumerable<IEnumerable<int>> values) => Interop.mkYAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
        public static Box<IYProperty> locations(List<int[]> values) => Interop.mkYAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
        public static Box<IYProperty> locations(params int[][] values) => Interop.mkYAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
        public static Box<IYProperty> locations(IEnumerable<IEnumerable<float>> values) => Interop.mkYAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
        public static Box<IYProperty> locations(List<float[]> values) => Interop.mkYAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
        public static Box<IYProperty> locations(params float[][] values) => Interop.mkYAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
        public static Box<IYProperty> locations(Literals.PlotData[] values) => Interop.mkYAttr("locations", values);
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
        public static Box<IYProperty> locations(IEnumerable<bool?> values) => Interop.mkYAttr("locations", values.ToArray());
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
        public static Box<IYProperty> locations(IEnumerable<System.DateTime?> values) => Interop.mkYAttr("locations", values.ToArray());
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
        public static Box<IYProperty> locations(IEnumerable<int?> values) => Interop.mkYAttr("locations", values.ToArray());
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis y except start and end.
        public static Box<IYProperty> locations(IEnumerable<float?> values) => Interop.mkYAttr("locations", values.ToArray());
        /// Sets the fill ratio of the `slices`. The default fill value of the `slices` is 1 meaning that they are entirely shaded. On the other hand Applying a `fill` ratio less than one would allow the creation of openings parallel to the edges.
        public static Box<IYProperty> fill(int val) => Interop.mkYAttr("fill", val);
        /// Sets the fill ratio of the `slices`. The default fill value of the `slices` is 1 meaning that they are entirely shaded. On the other hand Applying a `fill` ratio less than one would allow the creation of openings parallel to the edges.
        public static Box<IYProperty> fill(float val) => Interop.mkYAttr("fill", val);
        /// Sets the source reference on plot.ly for  locations .
        public static Box<IYProperty> locationssrc(string val) => Interop.mkYAttr("locationssrc", val);
    }
}