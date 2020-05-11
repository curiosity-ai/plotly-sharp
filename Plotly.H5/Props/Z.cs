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

    public static partial class Z
    {
        /// Sets whether or not projections are shown along the z axis.
        public static Box<IZProperty> show(bool val) => Interop.mkZAttr("show", val);
        /// Sets the projection color.
        public static Box<IZProperty> opacity(int val) => Interop.mkZAttr("opacity", val);
        /// Sets the projection color.
        public static Box<IZProperty> opacity(float val) => Interop.mkZAttr("opacity", val);
        /// Sets the scale factor determining the size of the projection marker points.
        public static Box<IZProperty> scale(int val) => Interop.mkZAttr("scale", val);
        /// Sets the scale factor determining the size of the projection marker points.
        public static Box<IZProperty> scale(float val) => Interop.mkZAttr("scale", val);
        /// Sets the starting contour level value. Must be less than `contours.end`
        public static Box<IZProperty> start(int val) => Interop.mkZAttr("start", val);
        /// Sets the starting contour level value. Must be less than `contours.end`
        public static Box<IZProperty> start(float val) => Interop.mkZAttr("start", val);
        /// Sets the end contour level value. Must be more than `contours.start`
        public static Box<IZProperty> _end(int val) => Interop.mkZAttr("end", val);
        /// Sets the end contour level value. Must be more than `contours.start`
        public static Box<IZProperty> _end(float val) => Interop.mkZAttr("end", val);
        /// Sets the step between each contour level. Must be positive.
        public static Box<IZProperty> size(int val) => Interop.mkZAttr("size", val);
        /// Sets the step between each contour level. Must be positive.
        public static Box<IZProperty> size(float val) => Interop.mkZAttr("size", val);
        public static Box<IZProperty> project(params Box<IProjectProperty>[] properties) => Interop.mkZAttr("project", Bindings.flattenProperties(properties));
        /// Sets the color of the contour lines.
        public static Box<IZProperty> color(string val) => Interop.mkZAttr("color", val);
        /// An alternate to *color*. Determines whether or not the contour lines are colored using the trace *colorscale*.
        public static Box<IZProperty> usecolormap(bool val) => Interop.mkZAttr("usecolormap", val);
        /// Sets the width of the contour lines.
        public static Box<IZProperty> width(int val) => Interop.mkZAttr("width", val);
        /// Sets the width of the contour lines.
        public static Box<IZProperty> width(float val) => Interop.mkZAttr("width", val);
        /// Determines whether or not contour lines about the z dimension are highlighted on hover.
        public static Box<IZProperty> highlight(bool val) => Interop.mkZAttr("highlight", val);
        /// Sets the color of the highlighted contour lines.
        public static Box<IZProperty> highlightcolor(string val) => Interop.mkZAttr("highlightcolor", val);
        /// Sets the width of the highlighted contour lines.
        public static Box<IZProperty> highlightwidth(int val) => Interop.mkZAttr("highlightwidth", val);
        /// Sets the width of the highlighted contour lines.
        public static Box<IZProperty> highlightwidth(float val) => Interop.mkZAttr("highlightwidth", val);
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
        public static Box<IZProperty> locations(bool val) => Interop.mkZAttr("locations", new[]{val});
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
        public static Box<IZProperty> locations(params bool[] values) => Interop.mkZAttr("locations", values);
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
        public static Box<IZProperty> locations(System.DateTime val) => Interop.mkZAttr("locations", new[]{val});
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
        public static Box<IZProperty> locations(params System.DateTime[] values) => Interop.mkZAttr("locations", values);
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
        public static Box<IZProperty> locations(float val) => Interop.mkZAttr("locations", new[]{val});
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
        public static Box<IZProperty> locations(params float[] values) => Interop.mkZAttr("locations", values);
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
        public static Box<IZProperty> locations(int val) => Interop.mkZAttr("locations", new[]{val});
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
        public static Box<IZProperty> locations(params int[] values) => Interop.mkZAttr("locations", values);
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
        public static Box<IZProperty> locations(string val) => Interop.mkZAttr("locations", new[]{val});
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
        public static Box<IZProperty> locations(params string[] values) => Interop.mkZAttr("locations", values);
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
        public static Box<IZProperty> locations(IEnumerable<bool[]> values) => Interop.mkZAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
        public static Box<IZProperty> locations(List<bool[]> values) => Interop.mkZAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
        public static Box<IZProperty> locations(params bool[][] values) => Interop.mkZAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
        public static Box<IZProperty> locations(IEnumerable<IEnumerable<string>> values) => Interop.mkZAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
        public static Box<IZProperty> locations(List<string[]> values) => Interop.mkZAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
        public static Box<IZProperty> locations(params string[][] values) => Interop.mkZAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
        public static Box<IZProperty> locations(IEnumerable<IEnumerable<int>> values) => Interop.mkZAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
        public static Box<IZProperty> locations(List<int[]> values) => Interop.mkZAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
        public static Box<IZProperty> locations(params int[][] values) => Interop.mkZAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
        public static Box<IZProperty> locations(IEnumerable<IEnumerable<float>> values) => Interop.mkZAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
        public static Box<IZProperty> locations(List<float[]> values) => Interop.mkZAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
        public static Box<IZProperty> locations(params float[][] values) => Interop.mkZAttr("locations", Bindings.flatten2DArrayIf1D(values));
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
        public static Box<IZProperty> locations(Literals.PlotData[] values) => Interop.mkZAttr("locations", values);
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
        public static Box<IZProperty> locations(IEnumerable<bool?> values) => Interop.mkZAttr("locations", values.ToArray());
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
        public static Box<IZProperty> locations(IEnumerable<System.DateTime?> values) => Interop.mkZAttr("locations", values.ToArray());
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
        public static Box<IZProperty> locations(IEnumerable<int?> values) => Interop.mkZAttr("locations", values.ToArray());
        /// Specifies the location(s) of slices on the axis. When not specified slices would be created for all points of the axis z except start and end.
        public static Box<IZProperty> locations(IEnumerable<float?> values) => Interop.mkZAttr("locations", values.ToArray());
        /// Sets the fill ratio of the `slices`. The default fill value of the `slices` is 1 meaning that they are entirely shaded. On the other hand Applying a `fill` ratio less than one would allow the creation of openings parallel to the edges.
        public static Box<IZProperty> fill(int val) => Interop.mkZAttr("fill", val);
        /// Sets the fill ratio of the `slices`. The default fill value of the `slices` is 1 meaning that they are entirely shaded. On the other hand Applying a `fill` ratio less than one would allow the creation of openings parallel to the edges.
        public static Box<IZProperty> fill(float val) => Interop.mkZAttr("fill", val);
        /// Sets the source reference on plot.ly for  locations .
        public static Box<IZProperty> locationssrc(string val) => Interop.mkZAttr("locationssrc", val);
    }
}