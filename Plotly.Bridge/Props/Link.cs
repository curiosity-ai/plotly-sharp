namespace PlotlyBridge
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

    public static partial class Link
    {
        /// The shown name of the link.
        public static Box<ILinkProperty> label(bool val) => Interop.mkLinkAttr("label", new[]{val});
        /// The shown name of the link.
        public static Box<ILinkProperty> label(params bool[] values) => Interop.mkLinkAttr("label", values);
        /// The shown name of the link.
        public static Box<ILinkProperty> label(System.DateTime val) => Interop.mkLinkAttr("label", new[]{val});
        /// The shown name of the link.
        public static Box<ILinkProperty> label(params System.DateTime[] values) => Interop.mkLinkAttr("label", values);
        /// The shown name of the link.
        public static Box<ILinkProperty> label(float val) => Interop.mkLinkAttr("label", new[]{val});
        /// The shown name of the link.
        public static Box<ILinkProperty> label(params float[] values) => Interop.mkLinkAttr("label", values);
        /// The shown name of the link.
        public static Box<ILinkProperty> label(int val) => Interop.mkLinkAttr("label", new[]{val});
        /// The shown name of the link.
        public static Box<ILinkProperty> label(params int[] values) => Interop.mkLinkAttr("label", values);
        /// The shown name of the link.
        public static Box<ILinkProperty> label(string val) => Interop.mkLinkAttr("label", new[]{val});
        /// The shown name of the link.
        public static Box<ILinkProperty> label(params string[] values) => Interop.mkLinkAttr("label", values);
        /// The shown name of the link.
        public static Box<ILinkProperty> label(IEnumerable<bool[]> values) => Interop.mkLinkAttr("label", Bindings.flatten2DArrayIf1D(values));
        /// The shown name of the link.
        public static Box<ILinkProperty> label(List<bool[]> values) => Interop.mkLinkAttr("label", Bindings.flatten2DArrayIf1D(values));
        /// The shown name of the link.
        public static Box<ILinkProperty> label(params bool[][] values) => Interop.mkLinkAttr("label", Bindings.flatten2DArrayIf1D(values));
        /// The shown name of the link.
        public static Box<ILinkProperty> label(IEnumerable<IEnumerable<string>> values) => Interop.mkLinkAttr("label", Bindings.flatten2DArrayIf1D(values));
        /// The shown name of the link.
        public static Box<ILinkProperty> label(List<string[]> values) => Interop.mkLinkAttr("label", Bindings.flatten2DArrayIf1D(values));
        /// The shown name of the link.
        public static Box<ILinkProperty> label(params string[][] values) => Interop.mkLinkAttr("label", Bindings.flatten2DArrayIf1D(values));
        /// The shown name of the link.
        public static Box<ILinkProperty> label(IEnumerable<IEnumerable<int>> values) => Interop.mkLinkAttr("label", Bindings.flatten2DArrayIf1D(values));
        /// The shown name of the link.
        public static Box<ILinkProperty> label(List<int[]> values) => Interop.mkLinkAttr("label", Bindings.flatten2DArrayIf1D(values));
        /// The shown name of the link.
        public static Box<ILinkProperty> label(params int[][] values) => Interop.mkLinkAttr("label", Bindings.flatten2DArrayIf1D(values));
        /// The shown name of the link.
        public static Box<ILinkProperty> label(IEnumerable<IEnumerable<float>> values) => Interop.mkLinkAttr("label", Bindings.flatten2DArrayIf1D(values));
        /// The shown name of the link.
        public static Box<ILinkProperty> label(List<float[]> values) => Interop.mkLinkAttr("label", Bindings.flatten2DArrayIf1D(values));
        /// The shown name of the link.
        public static Box<ILinkProperty> label(params float[][] values) => Interop.mkLinkAttr("label", Bindings.flatten2DArrayIf1D(values));
        /// The shown name of the link.
        public static Box<ILinkProperty> label(Literals.PlotData[] values) => Interop.mkLinkAttr("label", values);
        /// The shown name of the link.
        public static Box<ILinkProperty> label(IEnumerable<bool?> values) => Interop.mkLinkAttr("label", values.ToArray());
        /// The shown name of the link.
        public static Box<ILinkProperty> label(IEnumerable<System.DateTime?> values) => Interop.mkLinkAttr("label", values.ToArray());
        /// The shown name of the link.
        public static Box<ILinkProperty> label(IEnumerable<int?> values) => Interop.mkLinkAttr("label", values.ToArray());
        /// The shown name of the link.
        public static Box<ILinkProperty> label(IEnumerable<float?> values) => Interop.mkLinkAttr("label", values.ToArray());
        /// Sets the `link` color. It can be a single value, or an array for specifying color for each `link`. If `link.color` is omitted, then by default, a translucent grey link will be used.
        public static Box<ILinkProperty> color(string val) => Interop.mkLinkAttr("color", val);
        /// Sets the `link` color. It can be a single value, or an array for specifying color for each `link`. If `link.color` is omitted, then by default, a translucent grey link will be used.
        public static Box<ILinkProperty> color(IEnumerable<string> values) => Interop.mkLinkAttr("color", values.ToArray());
        /// Sets the `link` color. It can be a single value, or an array for specifying color for each `link`. If `link.color` is omitted, then by default, a translucent grey link will be used.
        public static Box<ILinkProperty> color(params int[] values) => Interop.mkLinkAttr("color", values);
        /// Sets the `link` color. It can be a single value, or an array for specifying color for each `link`. If `link.color` is omitted, then by default, a translucent grey link will be used.
        public static Box<ILinkProperty> color(params float[] values) => Interop.mkLinkAttr("color", values);
        public static Box<ILinkProperty> line(params Box<ILineProperty>[] properties) => Interop.mkLinkAttr("line", Bindings.flattenProperties(properties));
        /// An integer number `[0..nodes.length - 1]` that represents the source node.
        public static Box<ILinkProperty> source(bool val) => Interop.mkLinkAttr("source", new[]{val});
        /// An integer number `[0..nodes.length - 1]` that represents the source node.
        public static Box<ILinkProperty> source(params bool[] values) => Interop.mkLinkAttr("source", values);
        /// An integer number `[0..nodes.length - 1]` that represents the source node.
        public static Box<ILinkProperty> source(System.DateTime val) => Interop.mkLinkAttr("source", new[]{val});
        /// An integer number `[0..nodes.length - 1]` that represents the source node.
        public static Box<ILinkProperty> source(params System.DateTime[] values) => Interop.mkLinkAttr("source", values);
        /// An integer number `[0..nodes.length - 1]` that represents the source node.
        public static Box<ILinkProperty> source(float val) => Interop.mkLinkAttr("source", new[]{val});
        /// An integer number `[0..nodes.length - 1]` that represents the source node.
        public static Box<ILinkProperty> source(params float[] values) => Interop.mkLinkAttr("source", values);
        /// An integer number `[0..nodes.length - 1]` that represents the source node.
        public static Box<ILinkProperty> source(int val) => Interop.mkLinkAttr("source", new[]{val});
        /// An integer number `[0..nodes.length - 1]` that represents the source node.
        public static Box<ILinkProperty> source(params int[] values) => Interop.mkLinkAttr("source", values);
        /// An integer number `[0..nodes.length - 1]` that represents the source node.
        public static Box<ILinkProperty> source(string val) => Interop.mkLinkAttr("source", new[]{val});
        /// An integer number `[0..nodes.length - 1]` that represents the source node.
        public static Box<ILinkProperty> source(params string[] values) => Interop.mkLinkAttr("source", values);
        /// An integer number `[0..nodes.length - 1]` that represents the source node.
        public static Box<ILinkProperty> source(IEnumerable<bool[]> values) => Interop.mkLinkAttr("source", Bindings.flatten2DArrayIf1D(values));
        /// An integer number `[0..nodes.length - 1]` that represents the source node.
        public static Box<ILinkProperty> source(List<bool[]> values) => Interop.mkLinkAttr("source", Bindings.flatten2DArrayIf1D(values));
        /// An integer number `[0..nodes.length - 1]` that represents the source node.
        public static Box<ILinkProperty> source(params bool[][] values) => Interop.mkLinkAttr("source", Bindings.flatten2DArrayIf1D(values));
        /// An integer number `[0..nodes.length - 1]` that represents the source node.
        public static Box<ILinkProperty> source(IEnumerable<IEnumerable<string>> values) => Interop.mkLinkAttr("source", Bindings.flatten2DArrayIf1D(values));
        /// An integer number `[0..nodes.length - 1]` that represents the source node.
        public static Box<ILinkProperty> source(List<string[]> values) => Interop.mkLinkAttr("source", Bindings.flatten2DArrayIf1D(values));
        /// An integer number `[0..nodes.length - 1]` that represents the source node.
        public static Box<ILinkProperty> source(params string[][] values) => Interop.mkLinkAttr("source", Bindings.flatten2DArrayIf1D(values));
        /// An integer number `[0..nodes.length - 1]` that represents the source node.
        public static Box<ILinkProperty> source(IEnumerable<IEnumerable<int>> values) => Interop.mkLinkAttr("source", Bindings.flatten2DArrayIf1D(values));
        /// An integer number `[0..nodes.length - 1]` that represents the source node.
        public static Box<ILinkProperty> source(List<int[]> values) => Interop.mkLinkAttr("source", Bindings.flatten2DArrayIf1D(values));
        /// An integer number `[0..nodes.length - 1]` that represents the source node.
        public static Box<ILinkProperty> source(params int[][] values) => Interop.mkLinkAttr("source", Bindings.flatten2DArrayIf1D(values));
        /// An integer number `[0..nodes.length - 1]` that represents the source node.
        public static Box<ILinkProperty> source(IEnumerable<IEnumerable<float>> values) => Interop.mkLinkAttr("source", Bindings.flatten2DArrayIf1D(values));
        /// An integer number `[0..nodes.length - 1]` that represents the source node.
        public static Box<ILinkProperty> source(List<float[]> values) => Interop.mkLinkAttr("source", Bindings.flatten2DArrayIf1D(values));
        /// An integer number `[0..nodes.length - 1]` that represents the source node.
        public static Box<ILinkProperty> source(params float[][] values) => Interop.mkLinkAttr("source", Bindings.flatten2DArrayIf1D(values));
        /// An integer number `[0..nodes.length - 1]` that represents the source node.
        public static Box<ILinkProperty> source(Literals.PlotData[] values) => Interop.mkLinkAttr("source", values);
        /// An integer number `[0..nodes.length - 1]` that represents the source node.
        public static Box<ILinkProperty> source(IEnumerable<bool?> values) => Interop.mkLinkAttr("source", values.ToArray());
        /// An integer number `[0..nodes.length - 1]` that represents the source node.
        public static Box<ILinkProperty> source(IEnumerable<System.DateTime?> values) => Interop.mkLinkAttr("source", values.ToArray());
        /// An integer number `[0..nodes.length - 1]` that represents the source node.
        public static Box<ILinkProperty> source(IEnumerable<int?> values) => Interop.mkLinkAttr("source", values.ToArray());
        /// An integer number `[0..nodes.length - 1]` that represents the source node.
        public static Box<ILinkProperty> source(IEnumerable<float?> values) => Interop.mkLinkAttr("source", values.ToArray());
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        public static Box<ILinkProperty> target(bool val) => Interop.mkLinkAttr("target", new[]{val});
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        public static Box<ILinkProperty> target(params bool[] values) => Interop.mkLinkAttr("target", values);
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        public static Box<ILinkProperty> target(System.DateTime val) => Interop.mkLinkAttr("target", new[]{val});
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        public static Box<ILinkProperty> target(params System.DateTime[] values) => Interop.mkLinkAttr("target", values);
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        public static Box<ILinkProperty> target(float val) => Interop.mkLinkAttr("target", new[]{val});
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        public static Box<ILinkProperty> target(params float[] values) => Interop.mkLinkAttr("target", values);
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        public static Box<ILinkProperty> target(int val) => Interop.mkLinkAttr("target", new[]{val});
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        public static Box<ILinkProperty> target(params int[] values) => Interop.mkLinkAttr("target", values);
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        public static Box<ILinkProperty> target(string val) => Interop.mkLinkAttr("target", new[]{val});
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        public static Box<ILinkProperty> target(params string[] values) => Interop.mkLinkAttr("target", values);
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        public static Box<ILinkProperty> target(IEnumerable<bool[]> values) => Interop.mkLinkAttr("target", Bindings.flatten2DArrayIf1D(values));
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        public static Box<ILinkProperty> target(List<bool[]> values) => Interop.mkLinkAttr("target", Bindings.flatten2DArrayIf1D(values));
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        public static Box<ILinkProperty> target(params bool[][] values) => Interop.mkLinkAttr("target", Bindings.flatten2DArrayIf1D(values));
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        public static Box<ILinkProperty> target(IEnumerable<IEnumerable<string>> values) => Interop.mkLinkAttr("target", Bindings.flatten2DArrayIf1D(values));
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        public static Box<ILinkProperty> target(List<string[]> values) => Interop.mkLinkAttr("target", Bindings.flatten2DArrayIf1D(values));
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        public static Box<ILinkProperty> target(params string[][] values) => Interop.mkLinkAttr("target", Bindings.flatten2DArrayIf1D(values));
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        public static Box<ILinkProperty> target(IEnumerable<IEnumerable<int>> values) => Interop.mkLinkAttr("target", Bindings.flatten2DArrayIf1D(values));
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        public static Box<ILinkProperty> target(List<int[]> values) => Interop.mkLinkAttr("target", Bindings.flatten2DArrayIf1D(values));
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        public static Box<ILinkProperty> target(params int[][] values) => Interop.mkLinkAttr("target", Bindings.flatten2DArrayIf1D(values));
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        public static Box<ILinkProperty> target(IEnumerable<IEnumerable<float>> values) => Interop.mkLinkAttr("target", Bindings.flatten2DArrayIf1D(values));
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        public static Box<ILinkProperty> target(List<float[]> values) => Interop.mkLinkAttr("target", Bindings.flatten2DArrayIf1D(values));
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        public static Box<ILinkProperty> target(params float[][] values) => Interop.mkLinkAttr("target", Bindings.flatten2DArrayIf1D(values));
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        public static Box<ILinkProperty> target(Literals.PlotData[] values) => Interop.mkLinkAttr("target", values);
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        public static Box<ILinkProperty> target(IEnumerable<bool?> values) => Interop.mkLinkAttr("target", values.ToArray());
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        public static Box<ILinkProperty> target(IEnumerable<System.DateTime?> values) => Interop.mkLinkAttr("target", values.ToArray());
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        public static Box<ILinkProperty> target(IEnumerable<int?> values) => Interop.mkLinkAttr("target", values.ToArray());
        /// An integer number `[0..nodes.length - 1]` that represents the target node.
        public static Box<ILinkProperty> target(IEnumerable<float?> values) => Interop.mkLinkAttr("target", values.ToArray());
        /// A numeric value representing the flow volume value.
        public static Box<ILinkProperty> value(bool val) => Interop.mkLinkAttr("value", new[]{val});
        /// A numeric value representing the flow volume value.
        public static Box<ILinkProperty> value(params bool[] values) => Interop.mkLinkAttr("value", values);
        /// A numeric value representing the flow volume value.
        public static Box<ILinkProperty> value(System.DateTime val) => Interop.mkLinkAttr("value", new[]{val});
        /// A numeric value representing the flow volume value.
        public static Box<ILinkProperty> value(params System.DateTime[] values) => Interop.mkLinkAttr("value", values);
        /// A numeric value representing the flow volume value.
        public static Box<ILinkProperty> value(float val) => Interop.mkLinkAttr("value", new[]{val});
        /// A numeric value representing the flow volume value.
        public static Box<ILinkProperty> value(params float[] values) => Interop.mkLinkAttr("value", values);
        /// A numeric value representing the flow volume value.
        public static Box<ILinkProperty> value(int val) => Interop.mkLinkAttr("value", new[]{val});
        /// A numeric value representing the flow volume value.
        public static Box<ILinkProperty> value(params int[] values) => Interop.mkLinkAttr("value", values);
        /// A numeric value representing the flow volume value.
        public static Box<ILinkProperty> value(string val) => Interop.mkLinkAttr("value", new[]{val});
        /// A numeric value representing the flow volume value.
        public static Box<ILinkProperty> value(params string[] values) => Interop.mkLinkAttr("value", values);
        /// A numeric value representing the flow volume value.
        public static Box<ILinkProperty> value(IEnumerable<bool[]> values) => Interop.mkLinkAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// A numeric value representing the flow volume value.
        public static Box<ILinkProperty> value(List<bool[]> values) => Interop.mkLinkAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// A numeric value representing the flow volume value.
        public static Box<ILinkProperty> value(params bool[][] values) => Interop.mkLinkAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// A numeric value representing the flow volume value.
        public static Box<ILinkProperty> value(IEnumerable<IEnumerable<string>> values) => Interop.mkLinkAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// A numeric value representing the flow volume value.
        public static Box<ILinkProperty> value(List<string[]> values) => Interop.mkLinkAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// A numeric value representing the flow volume value.
        public static Box<ILinkProperty> value(params string[][] values) => Interop.mkLinkAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// A numeric value representing the flow volume value.
        public static Box<ILinkProperty> value(IEnumerable<IEnumerable<int>> values) => Interop.mkLinkAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// A numeric value representing the flow volume value.
        public static Box<ILinkProperty> value(List<int[]> values) => Interop.mkLinkAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// A numeric value representing the flow volume value.
        public static Box<ILinkProperty> value(params int[][] values) => Interop.mkLinkAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// A numeric value representing the flow volume value.
        public static Box<ILinkProperty> value(IEnumerable<IEnumerable<float>> values) => Interop.mkLinkAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// A numeric value representing the flow volume value.
        public static Box<ILinkProperty> value(List<float[]> values) => Interop.mkLinkAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// A numeric value representing the flow volume value.
        public static Box<ILinkProperty> value(params float[][] values) => Interop.mkLinkAttr("value", Bindings.flatten2DArrayIf1D(values));
        /// A numeric value representing the flow volume value.
        public static Box<ILinkProperty> value(Literals.PlotData[] values) => Interop.mkLinkAttr("value", values);
        /// A numeric value representing the flow volume value.
        public static Box<ILinkProperty> value(IEnumerable<bool?> values) => Interop.mkLinkAttr("value", values.ToArray());
        /// A numeric value representing the flow volume value.
        public static Box<ILinkProperty> value(IEnumerable<System.DateTime?> values) => Interop.mkLinkAttr("value", values.ToArray());
        /// A numeric value representing the flow volume value.
        public static Box<ILinkProperty> value(IEnumerable<int?> values) => Interop.mkLinkAttr("value", values.ToArray());
        /// A numeric value representing the flow volume value.
        public static Box<ILinkProperty> value(IEnumerable<float?> values) => Interop.mkLinkAttr("value", values.ToArray());
        public static Box<ILinkProperty> hoverlabel(params Box<IHoverlabelProperty>[] properties) => Interop.mkLinkAttr("hoverlabel", Bindings.flattenProperties(properties));
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `value` and `label`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<ILinkProperty> hovertemplate(string val) => Interop.mkLinkAttr("hovertemplate", val);
        /// Template string used for rendering the information that appear on hover box. Note that this will override `hoverinfo`. Variables are inserted using %{variable}, for example \"y: %{y}\". Numbers are formatted using d3-format's syntax %{variable:d3-format}, for example \"Price: %{y:$.2f}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Formatting.md#d3_format for details on the formatting syntax. Dates are formatted using d3-time-format's syntax %{variable|d3-time-format}, for example \"Day: %{2019-01-01|%A}\". https://github.com/d3/d3-3.x-api-reference/blob/master/Time-Formatting.md#format for details on the date formatting syntax. The variables available in `hovertemplate` are the ones emitted as event data described at this link https://plot.ly/javascript/plotlyjs-events/#event-data. Additionally, every attributes that can be specified per-point (the ones that are `arrayOk: true`) are available. variables `value` and `label`. Anything contained in tag `<extra>` is displayed in the secondary box, for example \"<extra>{fullData.name}</extra>\". To hide the secondary box completely, use an empty tag `<extra></extra>`.
        public static Box<ILinkProperty> hovertemplate(IEnumerable<string> values) => Interop.mkLinkAttr("hovertemplate", values.ToArray());
        public static Box<ILinkProperty> colorscales(params Box<IColorscalesProperty>[] properties) => Interop.mkLinkAttr("colorscales", Bindings.flattenProperties(properties));
        /// Sets the source reference on plot.ly for  label .
        public static Box<ILinkProperty> labelsrc(string val) => Interop.mkLinkAttr("labelsrc", val);
        /// Sets the source reference on plot.ly for  color .
        public static Box<ILinkProperty> colorsrc(string val) => Interop.mkLinkAttr("colorsrc", val);
        /// Sets the source reference on plot.ly for  source .
        public static Box<ILinkProperty> sourcesrc(string val) => Interop.mkLinkAttr("sourcesrc", val);
        /// Sets the source reference on plot.ly for  target .
        public static Box<ILinkProperty> targetsrc(string val) => Interop.mkLinkAttr("targetsrc", val);
        /// Sets the source reference on plot.ly for  value .
        public static Box<ILinkProperty> valuesrc(string val) => Interop.mkLinkAttr("valuesrc", val);
        /// Sets the source reference on plot.ly for  hovertemplate .
        public static Box<ILinkProperty> hovertemplatesrc(string val) => Interop.mkLinkAttr("hovertemplatesrc", val);
    }

    public static partial class Link
    {
        /// Determines which trace information appear when hovering links. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
        public static partial class Hoverinfo
        {
            public static Box<ILinkProperty> all() => Interop.mkLinkAttr("hoverinfo", "all");
            public static Box<ILinkProperty> none() => Interop.mkLinkAttr("hoverinfo", "none");
            public static Box<ILinkProperty> skip() => Interop.mkLinkAttr("hoverinfo", "skip");
        }
    }
}