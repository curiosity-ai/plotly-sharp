namespace Bridge //Kept only for simplicity of the generator code
{
    internal class ObjectLiteralAttribute : System.Attribute { }
}

namespace Retyped //Kept only for simplicity of the generator code
{
    public static class dom 
    {
        /// Placeholder to hold the generated HTML, can cast implicitly to string
        public class HTMLElement
        {
            private string HTML;
            internal HTMLElement(string html) { HTML = html; }

            public static implicit operator string(HTMLElement html) => html.HTML;
            public override string ToString() => HTML;
        }
    }
    internal static class es5 { }
}

namespace Plotly
{
    using System;
    using Types;
    using System.Collections.Generic;
    using Bridge;
    using System.Linq;
    using System.Dynamic;
    using System.Text;
    using Newtonsoft.Json;
    using static Retyped.dom;

    public static class data
    {
        /// <summary>
        /// Helper class for creating matrices with less typing
        /// </summary>
        /// <typeparam name="T">Element type, like string, float, etc...</typeparam>
        /// <returns>Itself, can be implicitly cast to T[][]</returns>
        public static mat<T> m<T>(params T[] firstRow) => new mat<T>().r(firstRow);
        public static T[] v<T>(params T[] values) => values;

        public class mat<T>
        {
            private List<T[]> rows = new List<T[]>();
            public mat<T> r(params T[] newRow)
            {
                rows.Add(newRow); return this;
            }
            public static implicit operator T[][](mat<T> m) => m.rows.ToArray();

            public T[] this[int i]
            {
                get { return rows[i]; }
                set { rows[i] = value; }
            }
        }
    }

    internal interface IPlot
    {
        HTMLElement Render();
        void Update(params Box<IPlotProperty>[] props);
    }

    public class Box<T>
    {
        public dynamic THIS;
        public IDictionary<string, object> DICT => THIS as IDictionary<string, object>;
        public static Box<T> For(string key, dynamic value)
        {
            var box = new Box<T>();
            box.THIS = new ExpandoObject();
            Bindings.SetProperty(box.THIS, key, value);
            return box;
        }
    }

    internal static class Bindings
    {
        internal static IPlot createPlot(params Box<IPlotProperty>[] props)
        {
            return new PlotlyPlot(props);
        }

        internal static void SetProperty(dynamic obj, string key, dynamic value)
        {
            var expandoDict = obj as IDictionary<string, object>;
            expandoDict[key] = value;
        }

        internal static dynamic joinEnumProperties<T>(params Box<T>[] props)
        {
            var l = new List<string>();

            for (int i = 0; i < props.Length; i++)
            {
                var p = props[i];

                foreach (var k in p.DICT.Keys)
                {
                    l.Add((string)p.DICT[k]);
                    break;
                }
            }

            return string.Join("+", l);
        }

        internal static dynamic flatten2DArrayIf1D<T>(IEnumerable<IEnumerable<T>> values)
        {
            return values.Count() == 1 ? (object)(values.First().ToArray()) : values.Select(a => a.ToArray()).ToArray();
        }

        internal static dynamic flattenProperties<T>(IEnumerable<Box<T>> properties, dynamic initial = null)
        {
            dynamic result = initial ?? new ExpandoObject();
            foreach (var prop in properties)
            {
                foreach(var p in prop.DICT.Keys)
                {
                    SetProperty(result, p, prop.DICT[p]);
                }
            }
            return result;
        }

        internal static Box<IPlotProperty> extractTraces(IEnumerable<Box<ITracesProperty>> props)
        {
            return Interop.mkPlotAttr("data", flattenPropertiesToArray(props));
        }

        internal static dynamic[] flattenPropertiesToArray<T>(IEnumerable<Box<T>> props)
        {
            var all = props.ToArray();

            dynamic[] results = new dynamic[all.Length];
            for (int i = 0; i < all.Length; i++)
            {
                var p = all[i];
                foreach (var k in p.DICT.Keys)
                {
                    results[i] = p.DICT[k];
                    break;
                }
            }

            return results;
        }

        internal static Box<IPlotProperty> extractConfig(IEnumerable<Box<IConfigProperty>> props)
        {
            return Interop.mkPlotAttr("config", flattenProperties(props));
        }

        internal static Box<IPlotProperty> extractLayout(IEnumerable<Box<ILayoutProperty>> props)
        {
            return Interop.mkPlotAttr("layout", flattenProperties(props));
        }

        private class PlotlyPlot :IPlot
        {
            public PlotlyPlot(IEnumerable<Box<IPlotProperty>> props)
            {
                Props = flattenProperties(props) as IDictionary<string, object>;
            }

            public void Update(params Box<IPlotProperty>[] props)
            {
                Props = flattenProperties(props, Props);
            }

            public IDictionary<string, object> Props { get; private set; }

            public HTMLElement Render()
            {
                dynamic data   = Props.TryGetValue("data", out var d) ? d : new object();
                dynamic layout = Props.TryGetValue("layout", out var l) ? l : new object();
                dynamic config = Props.TryGetValue("config", out var c) ? c : new object();

                string dataJson = JsonConvert.SerializeObject(data);
                string layoutJson = JsonConvert.SerializeObject(layout);
                string configJson = JsonConvert.SerializeObject(config);

                var sb = new StringBuilder();
                sb.AppendLine("<!DOCTYPE html>");
    

                sb.AppendLine("<html>");
                sb.AppendLine("<head><script src='https://cdn.plot.ly/plotly-latest.min.js'></script></head>");
                sb.AppendLine("<body><div id='plotContainer' style='width: 100%; height: 100%;'></div>");
                sb.AppendLine("<script>");

                sb.Append("data   = ").Append(dataJson).AppendLine(";");
                sb.Append("layout = ").Append(layoutJson).AppendLine(";");
                sb.Append("config = ").Append(configJson).AppendLine(";");

                sb.AppendLine("Plotly.newPlot('plotContainer', data, layout, config);");
                sb.AppendLine("</script>");
                //onError onPurge onUpdate  onInitialized useResizeHandler events should go to the newPlot
                //BindPlotlyEvents(Props, Container);
                sb.AppendLine("</body></html>");

                return new HTMLElement(sb.ToString());
            }

            //private static void BindPlotlyEvents(object props, HTMLElement container)
            //{
            //    foreach(var e in GetOwnPropertyNames(props))
            //    {
            //        BindIfAny(e, container, Script.Write<Action<object>>("props[e]"));
            //    }
            //}

            //private static void BindIfAny(string name, HTMLElement container, Action<object> action)
            //{
            //    if(action == null) { return; }

            //    string plotlyEventName;

            //    switch (name)
            //    {
            //        case "onClick"                :  { plotlyEventName = "plotly_click"; break; }
            //        case "onAfterPlot"            :  { plotlyEventName = "plotly_afterplot"; break; }
            //        case "onAnimated"             :  { plotlyEventName = "plotly_animated"; break; }
            //        case "onAnimatingFrame"       :  { plotlyEventName = "plotly_animatingframe"; break; }
            //        case "onAnimationInterrupted" :  { plotlyEventName = "plotly_animationinterrupted"; break; }
            //        case "onAutoSize"             :  { plotlyEventName = "plotly_autosize"; break; }
            //        case "onBeforeExport"         :  { plotlyEventName = "plotly_beforeexport"; break; }
            //        case "onButtonClicked"        :  { plotlyEventName = "plotly_buttonclicked"; break; }
            //        case "onClickAnnotation"      :  { plotlyEventName = "plotly_clickannotation"; break; }
            //        case "onDeselect"             :  { plotlyEventName = "plotly_deselect"; break; }
            //        case "onDoubleClick"          :  { plotlyEventName = "plotly_doubleclick"; break; }
            //        case "onFramework"            :  { plotlyEventName = "plotly_framework"; break; }
            //        case "onHover"                :  { plotlyEventName = "plotly_hover"; break; }
            //        case "onLegendClick"          :  { plotlyEventName = "plotly_legendclick"; break; }
            //        case "onLegendDoubleClick"    :  { plotlyEventName = "plotly_legenddoubleclick"; break; }
            //        case "onRelayout"             :  { plotlyEventName = "plotly_relayout"; break; }
            //        case "onRestyle"              :  { plotlyEventName = "plotly_restyle"; break; }
            //        case "onRedraw"               :  { plotlyEventName = "plotly_redraw"; break; }
            //        case "onSelected"             :  { plotlyEventName = "plotly_selected"; break; }
            //        case "onSelecting"            :  { plotlyEventName = "plotly_selecting"; break; }
            //        case "onSliderChange"         :  { plotlyEventName = "plotly_sliderchange"; break; }
            //        case "onSliderEnd"            :  { plotlyEventName = "plotly_sliderend"; break; }
            //        case "onSliderStart"          :  { plotlyEventName = "plotly_sliderstart"; break; }
            //        case "onTransitioning"        :  { plotlyEventName = "plotly_transitioning"; break; }
            //        case "onTransitionInterrupted":  { plotlyEventName = "plotly_transitioninterrupted"; break; }
            //        case "onUnhover"              :  { plotlyEventName = "plotly_unhover"; break; }
            //        default:return;
            //    }

            //    Script.Write("{0}.on({1}, {2})", container, plotlyEventName, action);
            //}
        }
    }
}