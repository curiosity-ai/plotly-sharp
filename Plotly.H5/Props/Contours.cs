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

    public static partial class Contours
    {
        /// Sets the starting contour level value. Must be less than `contours.end`
        public static Box<IContoursProperty> start(int val) => Interop.mkContoursAttr("start", val);
        /// Sets the starting contour level value. Must be less than `contours.end`
        public static Box<IContoursProperty> start(float val) => Interop.mkContoursAttr("start", val);
        /// Sets the end contour level value. Must be more than `contours.start`
        public static Box<IContoursProperty> _end(int val) => Interop.mkContoursAttr("end", val);
        /// Sets the end contour level value. Must be more than `contours.start`
        public static Box<IContoursProperty> _end(float val) => Interop.mkContoursAttr("end", val);
        /// Sets the step between each contour level. Must be positive.
        public static Box<IContoursProperty> size(int val) => Interop.mkContoursAttr("size", val);
        /// Sets the step between each contour level. Must be positive.
        public static Box<IContoursProperty> size(float val) => Interop.mkContoursAttr("size", val);
        /// Determines whether or not the contour lines are drawn. Has an effect only if `contours.coloring` is set to *fill*.
        public static Box<IContoursProperty> showlines(bool val) => Interop.mkContoursAttr("showlines", val);
        /// Determines whether to label the contour lines with their values.
        public static Box<IContoursProperty> showlabels(bool val) => Interop.mkContoursAttr("showlabels", val);
        /// Sets the font used for labeling the contour levels. The default color comes from the lines, if shown. The default family and size come from `layout.font`.
        public static Box<IContoursProperty> labelfont(params Box<ILabelfontProperty>[] properties) => Interop.mkContoursAttr("labelfont", Bindings.flattenProperties(properties));
        /// Sets the contour label formatting rule using d3 formatting mini-language which is very similar to Python, see: https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format
        public static Box<IContoursProperty> labelformat(string val) => Interop.mkContoursAttr("labelformat", val);
        /// Sets the value or values of the constraint boundary. When `operation` is set to one of the comparison values (=,< ,>=,>,<  =  ) * value * is  expected  to  be  a  number.  When ` operation ` is  set  to  one  of  the  interval  values ( [ ] , ( ) , [ ) , ( ] , ] [ , ) ( , ] ( , ) [ ) * value * is  expected  to  be  an  array  of  two  numbers  where  the  first  is  the  lower  bound  and  the  second  is  the  upper  bound. 
        public static Box<IContoursProperty> value(bool val) => Interop.mkContoursAttr("value", val);
        /// Sets the value or values of the constraint boundary. When `operation` is set to one of the comparison values (=,< ,>=,>,<  =  ) * value * is  expected  to  be  a  number.  When ` operation ` is  set  to  one  of  the  interval  values ( [ ] , ( ) , [ ) , ( ] , ] [ , ) ( , ] ( , ) [ ) * value * is  expected  to  be  an  array  of  two  numbers  where  the  first  is  the  lower  bound  and  the  second  is  the  upper  bound. 
        public static Box<IContoursProperty> value(params bool[] values) => Interop.mkContoursAttr("value", values);
        /// Sets the value or values of the constraint boundary. When `operation` is set to one of the comparison values (=,< ,>=,>,<  =  ) * value * is  expected  to  be  a  number.  When ` operation ` is  set  to  one  of  the  interval  values ( [ ] , ( ) , [ ) , ( ] , ] [ , ) ( , ] ( , ) [ ) * value * is  expected  to  be  an  array  of  two  numbers  where  the  first  is  the  lower  bound  and  the  second  is  the  upper  bound. 
        public static Box<IContoursProperty> value(System.DateTime val) => Interop.mkContoursAttr("value", val);
        /// Sets the value or values of the constraint boundary. When `operation` is set to one of the comparison values (=,< ,>=,>,<  =  ) * value * is  expected  to  be  a  number.  When ` operation ` is  set  to  one  of  the  interval  values ( [ ] , ( ) , [ ) , ( ] , ] [ , ) ( , ] ( , ) [ ) * value * is  expected  to  be  an  array  of  two  numbers  where  the  first  is  the  lower  bound  and  the  second  is  the  upper  bound. 
        public static Box<IContoursProperty> value(params System.DateTime[] values) => Interop.mkContoursAttr("value", values);
        /// Sets the value or values of the constraint boundary. When `operation` is set to one of the comparison values (=,< ,>=,>,<  =  ) * value * is  expected  to  be  a  number.  When ` operation ` is  set  to  one  of  the  interval  values ( [ ] , ( ) , [ ) , ( ] , ] [ , ) ( , ] ( , ) [ ) * value * is  expected  to  be  an  array  of  two  numbers  where  the  first  is  the  lower  bound  and  the  second  is  the  upper  bound. 
        public static Box<IContoursProperty> value(int val) => Interop.mkContoursAttr("value", val);
        /// Sets the value or values of the constraint boundary. When `operation` is set to one of the comparison values (=,< ,>=,>,<  =  ) * value * is  expected  to  be  a  number.  When ` operation ` is  set  to  one  of  the  interval  values ( [ ] , ( ) , [ ) , ( ] , ] [ , ) ( , ] ( , ) [ ) * value * is  expected  to  be  an  array  of  two  numbers  where  the  first  is  the  lower  bound  and  the  second  is  the  upper  bound. 
        public static Box<IContoursProperty> value(params int[] values) => Interop.mkContoursAttr("value", values);
        /// Sets the value or values of the constraint boundary. When `operation` is set to one of the comparison values (=,< ,>=,>,<  =  ) * value * is  expected  to  be  a  number.  When ` operation ` is  set  to  one  of  the  interval  values ( [ ] , ( ) , [ ) , ( ] , ] [ , ) ( , ] ( , ) [ ) * value * is  expected  to  be  an  array  of  two  numbers  where  the  first  is  the  lower  bound  and  the  second  is  the  upper  bound. 
        public static Box<IContoursProperty> value(float val) => Interop.mkContoursAttr("value", val);
        /// Sets the value or values of the constraint boundary. When `operation` is set to one of the comparison values (=,< ,>=,>,<  =  ) * value * is  expected  to  be  a  number.  When ` operation ` is  set  to  one  of  the  interval  values ( [ ] , ( ) , [ ) , ( ] , ] [ , ) ( , ] ( , ) [ ) * value * is  expected  to  be  an  array  of  two  numbers  where  the  first  is  the  lower  bound  and  the  second  is  the  upper  bound. 
        public static Box<IContoursProperty> value(params float[] values) => Interop.mkContoursAttr("value", values);
        /// Sets the value or values of the constraint boundary. When `operation` is set to one of the comparison values (=,< ,>=,>,<  =  ) * value * is  expected  to  be  a  number.  When ` operation ` is  set  to  one  of  the  interval  values ( [ ] , ( ) , [ ) , ( ] , ] [ , ) ( , ] ( , ) [ ) * value * is  expected  to  be  an  array  of  two  numbers  where  the  first  is  the  lower  bound  and  the  second  is  the  upper  bound. 
        public static Box<IContoursProperty> value(string val) => Interop.mkContoursAttr("value", val);
        /// Sets the value or values of the constraint boundary. When `operation` is set to one of the comparison values (=,< ,>=,>,<  =  ) * value * is  expected  to  be  a  number.  When ` operation ` is  set  to  one  of  the  interval  values ( [ ] , ( ) , [ ) , ( ] , ] [ , ) ( , ] ( , ) [ ) * value * is  expected  to  be  an  array  of  two  numbers  where  the  first  is  the  lower  bound  and  the  second  is  the  upper  bound. 
        public static Box<IContoursProperty> value(params string[] values) => Interop.mkContoursAttr("value", values);
        public static Box<IContoursProperty> x(params Box<IXProperty>[] properties) => Interop.mkContoursAttr("x", Bindings.flattenProperties(properties));
        public static Box<IContoursProperty> y(params Box<IYProperty>[] properties) => Interop.mkContoursAttr("y", Bindings.flattenProperties(properties));
        public static Box<IContoursProperty> z(params Box<IZProperty>[] properties) => Interop.mkContoursAttr("z", Bindings.flattenProperties(properties));
    }

    public static partial class Contours
    {
        /// If `levels`, the data is represented as a contour plot with multiple levels displayed. If `constraint`, the data is represented as constraints with the invalid region shaded as specified by the `operation` and `value` parameters.
        public static partial class _type
        {
            public static Box<IContoursProperty> _constraint() => Interop.mkContoursAttr("type", "constraint");
            public static Box<IContoursProperty> levels() => Interop.mkContoursAttr("type", "levels");
        }

        /// Determines the coloring method showing the contour values. If *fill*, coloring is done evenly between each contour level If *heatmap*, a heatmap gradient coloring is applied between each contour level. If *lines*, coloring is done on the contour lines. If *none*, no coloring is applied on this trace.
        public static partial class Coloring
        {
            public static Box<IContoursProperty> fill() => Interop.mkContoursAttr("coloring", "fill");
            public static Box<IContoursProperty> heatmap() => Interop.mkContoursAttr("coloring", "heatmap");
            public static Box<IContoursProperty> lines() => Interop.mkContoursAttr("coloring", "lines");
            public static Box<IContoursProperty> none() => Interop.mkContoursAttr("coloring", "none");
        }

        /// Sets the constraint operation. *=* keeps regions equal to `value` *< * and *<  =  * keep  regions  less  than ` value ` * >* and *>=* keep regions greater than `value` *[]*, *()*, *[)*, and *(]* keep regions inside `value[0]` to `value[1]` *][*, *)(*, *](*, *)[* keep regions outside `value[0]` to value[1]` Open vs. closed intervals make no difference to constraint display, but all versions are allowed for consistency with filter transforms.
        public static partial class Operation
        {
            public static Box<IContoursProperty> exclusiveRange() => Interop.mkContoursAttr("operation", "()");
            public static Box<IContoursProperty> rightIncLeftExcRange() => Interop.mkContoursAttr("operation", "(]");
            public static Box<IContoursProperty> exclusiveBounds() => Interop.mkContoursAttr("operation", ")(");
            public static Box<IContoursProperty> leftExcRightIncBounds() => Interop.mkContoursAttr("operation", ")[");
            public static Box<IContoursProperty> lt() => Interop.mkContoursAttr("operation", "<");
            public static Box<IContoursProperty> ltEq() => Interop.mkContoursAttr("operation", "<=");
            public static Box<IContoursProperty> eq() => Interop.mkContoursAttr("operation", "=");
            public static Box<IContoursProperty> gt() => Interop.mkContoursAttr("operation", ">");
            public static Box<IContoursProperty> gtEq() => Interop.mkContoursAttr("operation", ">=");
            public static Box<IContoursProperty> leftIncLRightExcRange() => Interop.mkContoursAttr("operation", "[)");
            public static Box<IContoursProperty> rightExcLeftIncBounds() => Interop.mkContoursAttr("operation", "](");
            public static Box<IContoursProperty> custom(string val) => Interop.mkContoursAttr("operation", val);
        }
    }
}