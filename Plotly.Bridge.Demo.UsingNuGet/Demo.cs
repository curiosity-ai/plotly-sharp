﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Retyped.dom;
using PlotlyBridge;

namespace PlotlyBridgeDemo
{
    public static class Demo
    {
        public static void Main()
        {
            var data = new[]
                            {
                                new float[]{ 1, 20, 30 },
                                new float[]{20,  1, 60 },
                                new float[]{30, 60,  1 }
                            };


            var chart = Plotly.plot(
                                plot.traces(
                                     Traces.heatmap(
                                            Heatmap.z(data)
                                    )
                                )
                            );

            document.body.appendChild(chart.Render());

            var xData = new[] { "A", "B", "C", "D", "E" };

            var yData = new[] { "W", "X", "Y", "Z" };
            var zData = new[]
            {
                new float[] { 0, 0, 0.75f, 0.75f, 0 },
                new float[] { 0, 0, 0.75f, 0.75f, 0 },
                new float[] { 0.75f, 0.75f, 0.75f, 0.75f, 0.75f },
                new float[] { 0, 0, 0, 0.75f, 0 } 
            };

            var annotations = yData.SelectMany((y,yi)=> xData.Select((x,xi) => Annotations.annotation(
                Annotation.x(x),
                Annotation.y(y),
                Annotation.Xref.x(1),
                Annotation.Yref.y(1),
                Annotation.text(zData[yi][xi].ToString()),
                Annotation.font(Font.family("Arial"), Font.size(12), Font.color(zData[yi][xi] < 0 ? "black" : "white")),
                Annotation.showarrow(false)
                ))).ToArray();

            var chart2 = Plotly.plot(
                    plot.traces(
                         Traces.heatmap(
                                Heatmap.x(xData),
                                Heatmap.y(yData),
                                Heatmap.z(zData),
                                Heatmap.colorscale("Magma"),
                                Heatmap.showscale(false)
                        )
                    ),
                    plot.layout(Layout.title(Title.text("Annotated Heatmap")),
                                   Layout.annotations(annotations),
                                   Layout.xaxis(Xaxis.Ticks.none(), Xaxis.Side.top(), Xaxis.ticksuffix(" ")),
                                   Layout.yaxis(Yaxis.Ticks.none(), Yaxis.Side.top(), Yaxis.ticksuffix(" ")),
                                   Layout.width(700),
                                   Layout.height(700),
                                   Layout.autosize(false)
                    ),
                    plot.onClick(me => { console.log(me.points.First().x); })

                );

            document.body.appendChild(chart2.Render());

        }
    }
}