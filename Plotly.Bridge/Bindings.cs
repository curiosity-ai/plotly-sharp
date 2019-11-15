namespace PlotlyBridge
{
    using System;
    using Types;
    using System.Collections.Generic;
    using Bridge;
    using static Retyped.dom;
    using System.Linq;

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

    public interface IPlot
    {
        HTMLElement Render();
    }

    [ObjectLiteral(ObjectCreateMode.Constructor)]
    public class Box<T>
    {
        public Box(string key, object value)
        {
            Script.Write("{0}[{1}] = {2}", this, key, value);
        }
    }

    public static class Bindings
    {
        public static bool Debug { get; set; } = false;
        
        public static IPlot createPlot(params Box<IPlotProperty>[] props)
        {
            CheckForPlotlyOrLoadFromCDN();
            return new PlotlyPlot(props);
        }

        internal static object joinEnumProperties<T>(params Box<T>[] props)
        {
            var l = new List<string>();

            for (int i = 0; i < props.Length; i++)
            {
                var p = props[i];
                var keys = object.GetOwnPropertyNames(p);

                foreach (var k in keys)
                {
                    if (k.StartsWith("$")) continue;
                    l.Add((string)p[k]);
                    break;
                }
            }

            return string.Join("+", l);
        }

        internal static object flatten2DArrayIf1D<T>(IEnumerable<IEnumerable<T>> values)
        {
            return values.Count() == 1 ? (object)(values.First().ToArray()) : values.Select(a => a.ToArray()).ToArray();
        }

        internal static object flattenProperties<T>(IEnumerable<Box<T>> properties)
        {
            object result = new object();
            foreach (var prop in properties)
            {
                Script.Write("result = Object.assign(result, {0})", prop);
            }
            return result;
        }



        private static void CheckForPlotlyOrLoadFromCDN()
        {
            //TODO
        }

        internal static Box<IPlotProperty> extractTraces(IEnumerable<Box<ITracesProperty>> props)
        {
            return Interop.mkPlotAttr("data", flattenPropertiesToArray(props));
        }

        internal static object[] flattenPropertiesToArray<T>(IEnumerable<Box<T>> props)
        {
            var all = props.ToArray();

            object[] results = new object[all.Length];
            for (int i = 0; i < all.Length; i++)
            {
                var p = all[i];
                var keys = object.GetOwnPropertyNames(p);

                foreach (var k in keys)
                {
                    if (k.StartsWith("$")) continue;
                    results[i] = p[k];
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
                Props = flattenProperties(props);
            }

            public object Props { get; }

            private bool IsRendered;
            private HTMLElement Container;

            public HTMLElement Render()
            {
                Container = Container ?? new HTMLDivElement();
                
                Container.style.height = "100%";
                Container.style.width = "100%";

                object data = Props["data"] ?? new object();
                object layout = Props["layout"] ?? new object();
                object config = Props["config"] ?? new object();

                if (Debug)
                {
                    console.log(data);
                    console.log(layout);
                    console.log(config);
                }

                if (IsRendered)
                {
                    Script.Write("Plotly.react({0}, {1}, {2}, {3})",
                                 Container,
                                 data,
                                 layout,
                                 config);
                }
                else
                {
                    Script.Write("Plotly.newPlot({0}, {1}, {2}, {3})",
                                 Container,
                                 data,
                                 layout,
                                 config);
                }

                //onError onPurge onUpdate  onInitialized useResizeHandler events should go to the newPlot

                BindPlotlyEvents(Props, Container);

                IsRendered = true;
                return Container;
            }

            private static void BindPlotlyEvents(object props, HTMLElement container)
            {
                foreach(var e in GetOwnPropertyNames(props))
                {
                    BindIfAny(e, container, Script.Write<Action<object>>("props[e]"));
                }
            }

            private static void BindIfAny(string name, HTMLElement container, Action<object> action)
            {
                if(action == null) { return; }

                string plotlyEventName;

                switch (name)
                {
                    case "onClick"                :  { plotlyEventName = "plotly_click"; break; }
                    case "onAfterPlot"            :  { plotlyEventName = "plotly_afterplot"; break; }
                    case "onAnimated"             :  { plotlyEventName = "plotly_animated"; break; }
                    case "onAnimatingFrame"       :  { plotlyEventName = "plotly_animatingframe"; break; }
                    case "onAnimationInterrupted" :  { plotlyEventName = "plotly_animationinterrupted"; break; }
                    case "onAutoSize"             :  { plotlyEventName = "plotly_autosize"; break; }
                    case "onBeforeExport"         :  { plotlyEventName = "plotly_beforeexport"; break; }
                    case "onButtonClicked"        :  { plotlyEventName = "plotly_buttonclicked"; break; }
                    case "onClickAnnotation"      :  { plotlyEventName = "plotly_clickannotation"; break; }
                    case "onDeselect"             :  { plotlyEventName = "plotly_deselect"; break; }
                    case "onDoubleClick"          :  { plotlyEventName = "plotly_doubleclick"; break; }
                    case "onFramework"            :  { plotlyEventName = "plotly_framework"; break; }
                    case "onHover"                :  { plotlyEventName = "plotly_hover"; break; }
                    case "onLegendClick"          :  { plotlyEventName = "plotly_legendclick"; break; }
                    case "onLegendDoubleClick"    :  { plotlyEventName = "plotly_legenddoubleclick"; break; }
                    case "onRelayout"             :  { plotlyEventName = "plotly_relayout"; break; }
                    case "onRestyle"              :  { plotlyEventName = "plotly_restyle"; break; }
                    case "onRedraw"               :  { plotlyEventName = "plotly_redraw"; break; }
                    case "onSelected"             :  { plotlyEventName = "plotly_selected"; break; }
                    case "onSelecting"            :  { plotlyEventName = "plotly_selecting"; break; }
                    case "onSliderChange"         :  { plotlyEventName = "plotly_sliderchange"; break; }
                    case "onSliderEnd"            :  { plotlyEventName = "plotly_sliderend"; break; }
                    case "onSliderStart"          :  { plotlyEventName = "plotly_sliderstart"; break; }
                    case "onTransitioning"        :  { plotlyEventName = "plotly_transitioning"; break; }
                    case "onTransitionInterrupted":  { plotlyEventName = "plotly_transitioninterrupted"; break; }
                    case "onUnhover"              :  { plotlyEventName = "plotly_unhover"; break; }
                    default:return;
                }

                Script.Write("{0}.on({1}, {2})", container, plotlyEventName, action);
            }
        }
    }
}