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

    public static partial class Filter
    {
        /// Determines whether this filter transform is enabled or disabled.
        public static Box<IFilterProperty> enabled(bool val) => Interop.mkFilterAttr("enabled", val);
        /// Sets the filter target by which the filter is applied. If a string, `target` is assumed to be a reference to a data array in the parent trace object. To filter about nested variables, use *.* to access them. For example, set `target` to *marker.color* to filter about the marker color array. If an array, `target` is then the data array by which the filter is applied.
        public static Box<IFilterProperty> target(string val) => Interop.mkFilterAttr("target", val);
        /// Sets the filter target by which the filter is applied. If a string, `target` is assumed to be a reference to a data array in the parent trace object. To filter about nested variables, use *.* to access them. For example, set `target` to *marker.color* to filter about the marker color array. If an array, `target` is then the data array by which the filter is applied.
        public static Box<IFilterProperty> target(IEnumerable<string> values) => Interop.mkFilterAttr("target", values.ToArray());
        /// Sets the value or values by which to filter. Values are expected to be in the same type as the data linked to `target`. When `operation` is set to one of the comparison values (=,!=,< ,>=,>,<  =  ) ` value ` is  expected  to  be  a  number  or  a  string.  When ` operation ` is  set  to  one  of  the  interval  values ( [ ] , ( ) , [ ) , ( ] , ] [ , ) ( , ] ( , ) [ ) ` value ` is  expected  to  be 2 - item  array  where  the  first  item  is  the  lower  bound  and  the  second  item  is  the  upper  bound.  When ` operation ` , is  set  to  one  of  the  set  values ( { } , } { ) ` value ` is  expected  to  be  an  array  with  as  many  items  as  the  desired  set  elements. 
        public static Box<IFilterProperty> value(bool val) => Interop.mkFilterAttr("value", val);
        /// Sets the value or values by which to filter. Values are expected to be in the same type as the data linked to `target`. When `operation` is set to one of the comparison values (=,!=,< ,>=,>,<  =  ) ` value ` is  expected  to  be  a  number  or  a  string.  When ` operation ` is  set  to  one  of  the  interval  values ( [ ] , ( ) , [ ) , ( ] , ] [ , ) ( , ] ( , ) [ ) ` value ` is  expected  to  be 2 - item  array  where  the  first  item  is  the  lower  bound  and  the  second  item  is  the  upper  bound.  When ` operation ` , is  set  to  one  of  the  set  values ( { } , } { ) ` value ` is  expected  to  be  an  array  with  as  many  items  as  the  desired  set  elements. 
        public static Box<IFilterProperty> value(params bool[] values) => Interop.mkFilterAttr("value", values);
        /// Sets the value or values by which to filter. Values are expected to be in the same type as the data linked to `target`. When `operation` is set to one of the comparison values (=,!=,< ,>=,>,<  =  ) ` value ` is  expected  to  be  a  number  or  a  string.  When ` operation ` is  set  to  one  of  the  interval  values ( [ ] , ( ) , [ ) , ( ] , ] [ , ) ( , ] ( , ) [ ) ` value ` is  expected  to  be 2 - item  array  where  the  first  item  is  the  lower  bound  and  the  second  item  is  the  upper  bound.  When ` operation ` , is  set  to  one  of  the  set  values ( { } , } { ) ` value ` is  expected  to  be  an  array  with  as  many  items  as  the  desired  set  elements. 
        public static Box<IFilterProperty> value(System.DateTime val) => Interop.mkFilterAttr("value", val);
        /// Sets the value or values by which to filter. Values are expected to be in the same type as the data linked to `target`. When `operation` is set to one of the comparison values (=,!=,< ,>=,>,<  =  ) ` value ` is  expected  to  be  a  number  or  a  string.  When ` operation ` is  set  to  one  of  the  interval  values ( [ ] , ( ) , [ ) , ( ] , ] [ , ) ( , ] ( , ) [ ) ` value ` is  expected  to  be 2 - item  array  where  the  first  item  is  the  lower  bound  and  the  second  item  is  the  upper  bound.  When ` operation ` , is  set  to  one  of  the  set  values ( { } , } { ) ` value ` is  expected  to  be  an  array  with  as  many  items  as  the  desired  set  elements. 
        public static Box<IFilterProperty> value(params System.DateTime[] values) => Interop.mkFilterAttr("value", values);
        /// Sets the value or values by which to filter. Values are expected to be in the same type as the data linked to `target`. When `operation` is set to one of the comparison values (=,!=,< ,>=,>,<  =  ) ` value ` is  expected  to  be  a  number  or  a  string.  When ` operation ` is  set  to  one  of  the  interval  values ( [ ] , ( ) , [ ) , ( ] , ] [ , ) ( , ] ( , ) [ ) ` value ` is  expected  to  be 2 - item  array  where  the  first  item  is  the  lower  bound  and  the  second  item  is  the  upper  bound.  When ` operation ` , is  set  to  one  of  the  set  values ( { } , } { ) ` value ` is  expected  to  be  an  array  with  as  many  items  as  the  desired  set  elements. 
        public static Box<IFilterProperty> value(int val) => Interop.mkFilterAttr("value", val);
        /// Sets the value or values by which to filter. Values are expected to be in the same type as the data linked to `target`. When `operation` is set to one of the comparison values (=,!=,< ,>=,>,<  =  ) ` value ` is  expected  to  be  a  number  or  a  string.  When ` operation ` is  set  to  one  of  the  interval  values ( [ ] , ( ) , [ ) , ( ] , ] [ , ) ( , ] ( , ) [ ) ` value ` is  expected  to  be 2 - item  array  where  the  first  item  is  the  lower  bound  and  the  second  item  is  the  upper  bound.  When ` operation ` , is  set  to  one  of  the  set  values ( { } , } { ) ` value ` is  expected  to  be  an  array  with  as  many  items  as  the  desired  set  elements. 
        public static Box<IFilterProperty> value(params int[] values) => Interop.mkFilterAttr("value", values);
        /// Sets the value or values by which to filter. Values are expected to be in the same type as the data linked to `target`. When `operation` is set to one of the comparison values (=,!=,< ,>=,>,<  =  ) ` value ` is  expected  to  be  a  number  or  a  string.  When ` operation ` is  set  to  one  of  the  interval  values ( [ ] , ( ) , [ ) , ( ] , ] [ , ) ( , ] ( , ) [ ) ` value ` is  expected  to  be 2 - item  array  where  the  first  item  is  the  lower  bound  and  the  second  item  is  the  upper  bound.  When ` operation ` , is  set  to  one  of  the  set  values ( { } , } { ) ` value ` is  expected  to  be  an  array  with  as  many  items  as  the  desired  set  elements. 
        public static Box<IFilterProperty> value(float val) => Interop.mkFilterAttr("value", val);
        /// Sets the value or values by which to filter. Values are expected to be in the same type as the data linked to `target`. When `operation` is set to one of the comparison values (=,!=,< ,>=,>,<  =  ) ` value ` is  expected  to  be  a  number  or  a  string.  When ` operation ` is  set  to  one  of  the  interval  values ( [ ] , ( ) , [ ) , ( ] , ] [ , ) ( , ] ( , ) [ ) ` value ` is  expected  to  be 2 - item  array  where  the  first  item  is  the  lower  bound  and  the  second  item  is  the  upper  bound.  When ` operation ` , is  set  to  one  of  the  set  values ( { } , } { ) ` value ` is  expected  to  be  an  array  with  as  many  items  as  the  desired  set  elements. 
        public static Box<IFilterProperty> value(params float[] values) => Interop.mkFilterAttr("value", values);
        /// Sets the value or values by which to filter. Values are expected to be in the same type as the data linked to `target`. When `operation` is set to one of the comparison values (=,!=,< ,>=,>,<  =  ) ` value ` is  expected  to  be  a  number  or  a  string.  When ` operation ` is  set  to  one  of  the  interval  values ( [ ] , ( ) , [ ) , ( ] , ] [ , ) ( , ] ( , ) [ ) ` value ` is  expected  to  be 2 - item  array  where  the  first  item  is  the  lower  bound  and  the  second  item  is  the  upper  bound.  When ` operation ` , is  set  to  one  of  the  set  values ( { } , } { ) ` value ` is  expected  to  be  an  array  with  as  many  items  as  the  desired  set  elements. 
        public static Box<IFilterProperty> value(string val) => Interop.mkFilterAttr("value", val);
        /// Sets the value or values by which to filter. Values are expected to be in the same type as the data linked to `target`. When `operation` is set to one of the comparison values (=,!=,< ,>=,>,<  =  ) ` value ` is  expected  to  be  a  number  or  a  string.  When ` operation ` is  set  to  one  of  the  interval  values ( [ ] , ( ) , [ ) , ( ] , ] [ , ) ( , ] ( , ) [ ) ` value ` is  expected  to  be 2 - item  array  where  the  first  item  is  the  lower  bound  and  the  second  item  is  the  upper  bound.  When ` operation ` , is  set  to  one  of  the  set  values ( { } , } { ) ` value ` is  expected  to  be  an  array  with  as  many  items  as  the  desired  set  elements. 
        public static Box<IFilterProperty> value(params string[] values) => Interop.mkFilterAttr("value", values);
        /// Determines whether or not gaps in data arrays produced by the filter operation are preserved. Setting this to *true* might be useful when plotting a line chart with `connectgaps` set to *false*.
        public static Box<IFilterProperty> preservegaps(bool val) => Interop.mkFilterAttr("preservegaps", val);
        /// Sets the source reference on plot.ly for  target .
        public static Box<IFilterProperty> targetsrc(string val) => Interop.mkFilterAttr("targetsrc", val);
    }

    public static partial class Filter
    {
        /// Sets the filter operation. *=* keeps items equal to `value` *!=* keeps items not equal to `value` *< * keeps  items  less  than ` value ` *<  =  * keeps  items  less  than  or  equal  to ` value ` * >* keeps items greater than `value` *>=* keeps items greater than or equal to `value` *[]* keeps items inside `value[0]` to `value[1]` including both bounds *()* keeps items inside `value[0]` to `value[1]` excluding both bounds *[)* keeps items inside `value[0]` to `value[1]` including `value[0]` but excluding `value[1] *(]* keeps items inside `value[0]` to `value[1]` excluding `value[0]` but including `value[1] *][* keeps items outside `value[0]` to `value[1]` and equal to both bounds *)(* keeps items outside `value[0]` to `value[1]` *](* keeps items outside `value[0]` to `value[1]` and equal to `value[0]` *)[* keeps items outside `value[0]` to `value[1]` and equal to `value[1]` *{}* keeps items present in a set of values *}{* keeps items not present in a set of values
        public static partial class Operation
        {
            public static Box<IFilterProperty> notEq() => Interop.mkFilterAttr("operation", "!=");
            public static Box<IFilterProperty> exclusiveRange() => Interop.mkFilterAttr("operation", "()");
            public static Box<IFilterProperty> rightIncLeftExcRange() => Interop.mkFilterAttr("operation", "(]");
            public static Box<IFilterProperty> exclusiveBounds() => Interop.mkFilterAttr("operation", ")(");
            public static Box<IFilterProperty> leftExcRightIncBounds() => Interop.mkFilterAttr("operation", ")[");
            public static Box<IFilterProperty> lt() => Interop.mkFilterAttr("operation", "<");
            public static Box<IFilterProperty> ltEq() => Interop.mkFilterAttr("operation", "<=");
            public static Box<IFilterProperty> eq() => Interop.mkFilterAttr("operation", "=");
            public static Box<IFilterProperty> gt() => Interop.mkFilterAttr("operation", ">");
            public static Box<IFilterProperty> gtEq() => Interop.mkFilterAttr("operation", ">=");
            public static Box<IFilterProperty> leftIncLRightExcRange() => Interop.mkFilterAttr("operation", "[)");
            public static Box<IFilterProperty> rightExcLeftIncBounds() => Interop.mkFilterAttr("operation", "](");
            public static Box<IFilterProperty> keepPresent() => Interop.mkFilterAttr("operation", "{}");
            public static Box<IFilterProperty> filterPresent() => Interop.mkFilterAttr("operation", "}{");
            public static Box<IFilterProperty> custom(string val) => Interop.mkFilterAttr("operation", val);
        }

        /// Sets the calendar system to use for `value`, if it is a date.
        public static partial class Valuecalendar
        {
            public static Box<IFilterProperty> chinese() => Interop.mkFilterAttr("valuecalendar", "chinese");
            public static Box<IFilterProperty> coptic() => Interop.mkFilterAttr("valuecalendar", "coptic");
            public static Box<IFilterProperty> discworld() => Interop.mkFilterAttr("valuecalendar", "discworld");
            public static Box<IFilterProperty> ethiopian() => Interop.mkFilterAttr("valuecalendar", "ethiopian");
            public static Box<IFilterProperty> gregorian() => Interop.mkFilterAttr("valuecalendar", "gregorian");
            public static Box<IFilterProperty> hebrew() => Interop.mkFilterAttr("valuecalendar", "hebrew");
            public static Box<IFilterProperty> islamic() => Interop.mkFilterAttr("valuecalendar", "islamic");
            public static Box<IFilterProperty> jalali() => Interop.mkFilterAttr("valuecalendar", "jalali");
            public static Box<IFilterProperty> julian() => Interop.mkFilterAttr("valuecalendar", "julian");
            public static Box<IFilterProperty> mayan() => Interop.mkFilterAttr("valuecalendar", "mayan");
            public static Box<IFilterProperty> nanakshahi() => Interop.mkFilterAttr("valuecalendar", "nanakshahi");
            public static Box<IFilterProperty> nepali() => Interop.mkFilterAttr("valuecalendar", "nepali");
            public static Box<IFilterProperty> persian() => Interop.mkFilterAttr("valuecalendar", "persian");
            public static Box<IFilterProperty> taiwan() => Interop.mkFilterAttr("valuecalendar", "taiwan");
            public static Box<IFilterProperty> thai() => Interop.mkFilterAttr("valuecalendar", "thai");
            public static Box<IFilterProperty> ummalqura() => Interop.mkFilterAttr("valuecalendar", "ummalqura");
        }

        /// Sets the calendar system to use for `target`, if it is an array of dates. If `target` is a string (eg *x*) we use the corresponding trace attribute (eg `xcalendar`) if it exists, even if `targetcalendar` is provided.
        public static partial class Targetcalendar
        {
            public static Box<IFilterProperty> chinese() => Interop.mkFilterAttr("targetcalendar", "chinese");
            public static Box<IFilterProperty> coptic() => Interop.mkFilterAttr("targetcalendar", "coptic");
            public static Box<IFilterProperty> discworld() => Interop.mkFilterAttr("targetcalendar", "discworld");
            public static Box<IFilterProperty> ethiopian() => Interop.mkFilterAttr("targetcalendar", "ethiopian");
            public static Box<IFilterProperty> gregorian() => Interop.mkFilterAttr("targetcalendar", "gregorian");
            public static Box<IFilterProperty> hebrew() => Interop.mkFilterAttr("targetcalendar", "hebrew");
            public static Box<IFilterProperty> islamic() => Interop.mkFilterAttr("targetcalendar", "islamic");
            public static Box<IFilterProperty> jalali() => Interop.mkFilterAttr("targetcalendar", "jalali");
            public static Box<IFilterProperty> julian() => Interop.mkFilterAttr("targetcalendar", "julian");
            public static Box<IFilterProperty> mayan() => Interop.mkFilterAttr("targetcalendar", "mayan");
            public static Box<IFilterProperty> nanakshahi() => Interop.mkFilterAttr("targetcalendar", "nanakshahi");
            public static Box<IFilterProperty> nepali() => Interop.mkFilterAttr("targetcalendar", "nepali");
            public static Box<IFilterProperty> persian() => Interop.mkFilterAttr("targetcalendar", "persian");
            public static Box<IFilterProperty> taiwan() => Interop.mkFilterAttr("targetcalendar", "taiwan");
            public static Box<IFilterProperty> thai() => Interop.mkFilterAttr("targetcalendar", "thai");
            public static Box<IFilterProperty> ummalqura() => Interop.mkFilterAttr("targetcalendar", "ummalqura");
        }
    }
}