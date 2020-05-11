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

    public static partial class X
    {
        /// Sets whether or not projections are shown along the x axis.
        public static Box<IXProperty> show(bool val) => Interop.mkXAttr("show", val);
        /// Sets the projection color.
        public static Box<IXProperty> opacity(int val) => Interop.mkXAttr("opacity", val);
        /// Sets the projection color.
        public static Box<IXProperty> opacity(float val) => Interop.mkXAttr("opacity", val);
        /// Sets the scale factor determining the size of the projection marker points.
        public static Box<IXProperty> scale(int val) => Interop.mkXAttr("scale", val);
        /// Sets the scale factor determining the size of the projection marker points.
        public static Box<IXProperty> scale(float val) => Interop.mkXAttr("scale", val);
        /// Sets the starting contour level value. Must be less than `contours.end`
        public static Box<IXProperty> start(int val) => Interop.mkXAttr("start", val);
        /// Sets the starting contour level value. Must be less than `contours.end`
        public static Box<IXProperty> start(float val) => Interop.mkXAttr("start", val);
        /// Sets the end contour level value. Must be more than `contours.start`
        public static Box<IXProperty> _end(int val) => Interop.mkXAttr("end", val);
        /// Sets the end contour level value. Must be more than `contours.start`
        public static Box<IXProperty> _end(float val) => Interop.mkXAttr("end", val);
        /// Sets the step between each contour level. Must be positive.
        public static Box<IXProperty> size(int val) => Interop.mkXAttr("size", val);
        /// Sets the step between each contour level. Must be positive.
        public static Box<IXProperty> size(float val) => Interop.mkXAttr("size", val);
        public static Box<IXProperty> project(params Box<IProjectProperty>[] properties) => Interop.mkXAttr("project", Bindings.flattenProperties(properties));
        /// Sets the color of the contour lines.
        public static Box<IXProperty> color(string val) => Interop.mkXAttr("color", val);
        /// An alternate to *color*. Determines whether or not the contour lines are colored using the trace *colorscale*.
        public static Box<IXProperty> usecolormap(bool val) => Interop.mkXAttr("usecolormap", val);
        /// Sets the width of the contour lines.
        public static Box<IXProperty> width(int val) => Interop.mkXAttr("width", val);
        /// Sets the width of the contour lines.
        public static Box<IXProperty> width(float val) => Interop.mkXAttr("width", val);
        /// Determines whether or not contour lines about the x dimension are highlighted on hover.
        public static Box<IXProperty> highlight(bool val) => Interop.mkXAttr("highlight", val);
        /// Sets the color of the highlighted contour lines.
        public static Box<IXProperty> highlightcolor(string val) => Interop.mkXAttr("highlightcolor", val);
        /// Sets the width of the highlighted contour lines.
        public static Box<IXProperty> highlightwidth(int val) => Interop.mkXAttr("highlightwidth", val);
        /// Sets the width of the highlighted contour lines.
        public static Box<IXProperty> highlightwidth(float val) => Interop.mkXAttr("highlightwidth", val);
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
        public static Box<IXProperty> locations(bool val) => Interop.mkXAttr("locations", new[]{val});
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
        public static Box<IXProperty> locations(params bool[] values) => Interop.mkXAttr("locations", values);
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
        public static Box<IXProperty> locations(System.DateTime val) => Interop.mkXAttr("locations", new[]{val});
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
        public static Box<IXProperty> locations(params System.DateTime[] values) => Interop.mkXAttr("locations", values);
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
        public static Box<IXProperty> locations(float val) => Interop.mkXAttr("locations", new[]{val});
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
        public static Box<IXProperty> locations(params float[] values) => Interop.mkXAttr("locations", values);
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
        public static Box<IXProperty> locations(int val) => Interop.mkXAttr("locations", new[]{val});
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
        public static Box<IXProperty> locations(params int[] values) => Interop.mkXAttr("locations", values);
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
        public static Box<IXProperty> locations(string val) => Interop.mkXAttr("locations", new[]{val});
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
        public static Box<IXProperty> locations(params string[] values) => Interop.mkXAttr("locations", values);
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
        public static Box<IXProperty> locations(IEnumerable<bool[]> values) => Interop.mkXAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
        public static Box<IXProperty> locations(List<bool[]> values) => Interop.mkXAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
        public static Box<IXProperty> locations(params bool[][] values) => Interop.mkXAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
        public static Box<IXProperty> locations(IEnumerable<IEnumerable<string>> values) => Interop.mkXAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
        public static Box<IXProperty> locations(List<string[]> values) => Interop.mkXAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
        public static Box<IXProperty> locations(params string[][] values) => Interop.mkXAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
        public static Box<IXProperty> locations(IEnumerable<IEnumerable<int>> values) => Interop.mkXAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
        public static Box<IXProperty> locations(List<int[]> values) => Interop.mkXAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
        public static Box<IXProperty> locations(params int[][] values) => Interop.mkXAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
        public static Box<IXProperty> locations(IEnumerable<IEnumerable<float>> values) => Interop.mkXAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
        public static Box<IXProperty> locations(List<float[]> values) => Interop.mkXAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
        public static Box<IXProperty> locations(params float[][] values) => Interop.mkXAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
        public static Box<IXProperty> locations(Literals.PlotData[] values) => Interop.mkXAttr("locations", values);
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
        public static Box<IXProperty> locations(IEnumerable<bool?> values) => Interop.mkXAttr("locations", values.ToArray());
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
        public static Box<IXProperty> locations(IEnumerable<System.DateTime?> values) => Interop.mkXAttr("locations", values.ToArray());
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
        public static Box<IXProperty> locations(IEnumerable<int?> values) => Interop.mkXAttr("locations", values.ToArray());
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis x except start and end.
        public static Box<IXProperty> locations(IEnumerable<float?> values) => Interop.mkXAttr("locations", values.ToArray());
        /// Sets the fill ratio of the `slices`. The default fill value of the `slices` is 1 meaning that they are entirely shaded. On the other hand Applying a `fill` ratio less than one would allow the creation of openings parallel to the edges.
        public static Box<IXProperty> fill(int val) => Interop.mkXAttr("fill", val);
        /// Sets the fill ratio of the `slices`. The default fill value of the `slices` is 1 meaning that they are entirely shaded. On the other hand Applying a `fill` ratio less than one would allow the creation of openings parallel to the edges.
        public static Box<IXProperty> fill(float val) => Interop.mkXAttr("fill", val);
        /// Sets the source reference on plot.ly for  locations .
        public static Box<IXProperty> locationssrc(string val) => Interop.mkXAttr("locationssrc", val);
    }
}