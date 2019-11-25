using Bridge;
using static Retyped.dom;

namespace PlotlyBridge
{
    public static class Literals
    {
        public class Color { } //TODO 
        public class ColorScale { } //TODO 

        [ObjectLiteral]
        public class ErrorEvent
        {
        }

        public class Datum { }

        [Enum(Emit.StringNameLowerCase)]
        public enum XAnchor
        {
            Left,
            Center,
            Right,
        }

        [Enum(Emit.StringNameLowerCase)]
        public enum YAnchor
        {
            Top,
            Center,
            Right,
        }

        [Enum(Emit.StringNameLowerCase)]
        public enum XAnchorAuto
        {
            Auto,
            Left,
            Center,
            Right,
        }

        [Enum(Emit.StringNameLowerCase)]
        public enum YAnchorAuto
        {
            Auto,
            Top,
            Center,
            Right,
        }

        [Enum(Emit.StringNameLowerCase)]
        public enum ImageFormat
        {
            Jpeg,
            Png,
            Webp,
            Svg,
        }

        public partial class Layout
        {
            [Enum(Emit.StringNameLowerCase)]
            public enum Direction
            {
                Clockwise,
                CounterClockwise,
            }

            [Enum(Emit.StringNameLowerCase)]
            public enum DragMode
            {
                Zoom,
                Pan,
                Select,
                Lasso,
                Orbit,
                Turntable,
            }

            [Enum(Emit.StringNameLowerCase)]
            public enum BarMode
            {
                Stack,
                Group,
                Overlay,
                Relative,
            }

            [Enum(Emit.StringNameLowerCase)]
            public enum SelectDirection
            {
                H,
                V,
                D,
                Any,
            }
        }


        [Enum(Emit.StringNameLowerCase)]
        public enum AxisType
        {
            [Name("-")] Dash
            , Linear
            , Log
            , Date
            , Category
        }
        [Enum(Emit.StringNameLowerCase)]
        public enum TickMode
        {
            Auto
            , Linear
            , Array
        }
        [Enum(Emit.StringNameLowerCase)]
        public enum Ticks
        {
            Outside
            , Inside
            , [Name("")] None
        }
        [Enum(Emit.StringNameLowerCase)]
        public enum ShowOptions
        {
            All
            , First
            , Last
            , None
        }
        [Enum(Emit.StringNameLowerCase)]
        public enum ExponentFormat
        {
            None
            , [Name("e")] LowerE
            , [Name("E")] UpperE
            , Power
            , SI
            , B
        }


        public partial class Axis
        {
            [Enum(Emit.StringNameLowerCase)]
            public enum RangeMode
            {
                Normal
                , [Name("tozero")] ToZero
                , [Name("nonnegative")] NonNegative
            }
            [Enum(Emit.StringNameLowerCase)]
            public enum Mirror
            {
                Ticks
                , All
                , [Name("allticks")] AllTicks
            }
            [Enum(Emit.StringNameLowerCase)]
            public enum CategoryOrder
            {
                Trace
                , [Name("category ascending")] Ascending
                , [Name("category descending")] Descending
                , Array
            }
            [Enum(Emit.StringNameLowerCase)]
            public enum Constrain
            {
                Range
                , Domain
            }
            [Enum(Emit.StringNameLowerCase)]
            public enum ConstrainToward
            {
                Left
                , Center
                , Right
                , Top
                , Middle
                , Bottom
            }
            [Enum(Emit.StringNameLowerCase)]
            public enum Name
            {
                X, X2, X3, X4, X5, X6, X7, X8, X9
                , Y, Y2, Y3, Y4, Y5, Y6, Y7, Y8, Y9
            }
            [Enum(Emit.StringNameLowerCase)]
            public enum Positioning
            {
                Free
                , X, X2, X3, X4, X5, X6, X7, X8, X9
                , Y, Y2, Y3, Y4, Y5, Y6, Y7, Y8, Y9
            }
            [Enum(Emit.StringNameLowerCase)]
            public enum Side
            {
                Top
                , Bottom
                , Left
                , Right
            }
            [Enum(Emit.StringNameLowerCase)]
            public enum Layer
            {
                [Name("above traces")] AboveTraces
                , [Name("below traces")] BelowTraces
            }
        }

        [Enum(Emit.StringNameLowerCase)]
        public enum Calendar
        {
            Gregorian
            , Chinese
            , Coptic
            , Discworld
            , Ethiopian
            , Hebrew
            , Islamic
            , Julian
            , Mayan
            , Nanakshahi
            , Nepali
            , Persian
            , Jalali
            , Taiwan
            , Thai
            , Ummalqura
        }

        public partial class Shape
        {
            [Enum(Emit.StringNameLowerCase)]
            public enum Layer
            {
                Below
                , Above
            }
            [Enum(Emit.StringNameLowerCase)]
            public enum Type
            {

                Rect
                , Circle
                , Line
                , Path
            }
            [Enum(Emit.StringNameLowerCase)]
            public enum Xref
            {

                X
                , Paper
            }
            [Enum(Emit.StringNameLowerCase)]
            public enum Yref
            {

                Y
                , Paper
            }
        }

        [Enum(Emit.StringNameLowerCase)]
        public enum ModeBarDefaultButtons
        {
            Lasso2d
                , Select2d
                , SendDataToCloud
                , AutoScale2d
                , Zoom2d
                , Pan2d
                , ZoomIn2d
                , ZoomOut2d
                , ResetScale2d
                , HoverClosestCartesian
                , HoverCompareCartesian
                , Zoom3d
                , Pan3d
                , OrbitRotation
                , TableRotation
                , ResetCameraDefault3d
                , ResetCameraLastSave3d
                , HoverClosest3d
                , ZoomInGeo
                , ZoomOutGeo
                , ResetGeo
                , HoverClosestGeo
                , HoverClosestGl2d
                , HoverClosestPie
                , ToggleHover
                , ToImage
                , ResetViews
                , ToggleSpikelines
        }


        [Enum(Emit.StringNameLowerCase)]
        public enum Dash
        {
            Solid
            , Dot
            , Dash
            , Longdash
            , Dashdot
            , Longdashdot
        }


        [Enum(Emit.StringNameLowerCase)]
        public enum Orientation
        {

            V
            , H
        }

        [Enum(Emit.StringNameLowerCase)]
        public enum MarkerSizeMode
        {

            Diameter
            , Area
        }

        [Enum(Emit.StringNameLowerCase)]
        public enum LineShape
        {

            Linear
            , Spline
            , Hv
            , Vh
            , Hvh
        }


        public partial class PlotData
        {
            [Enum(Emit.StringNameLowerCase)]
            public enum Type
            {

                Bar
                , Box
                , Candlestick
                , Choropleth
                , Contour
                , Heatmap
                , Histogram
                , Mesh3d
                , Ohlc
                , Paroords
                , Pie
                , [Name("pointcloud")] PointCloud
                , Scatter
                , Scatter3d
                , [Name("scatterternary")] ScatterGeo
                , [Name("scattergl")] ScatterGL
                , [Name("scatterpolar")] ScatterPolar
                , [Name("scatterternary")] ScatterTernary
                , Surface
            }

            [Enum(Emit.StringNameLowerCase)]
            public enum Mode
            {

                Lines
                , Markers
                , Text
                , [Name("lines+markers")] LinesAndMarkers
                , [Name("text+markers")] TextAndMarkers
                , [Name("text+lines")] TextAndLines
                , [Name("text+lines+markers")] TextLinesAndMarkers
                , None
            }

            [Enum(Emit.StringNameLowerCase)]
            public enum HoverOn
            {

                Points
                , Fills
            }

            [Enum(Emit.StringNameLowerCase)]
            public enum HoverInfo
            {

                All
                , Name
                , None
                , Skip
                , Text
                , X
                , [Name("x+text")] XAndText
                , [Name("x+name")] XAndName
                , [Name("x+y")] XAndY
                , [Name("x+y+text")] XYAndText
                , [Name("x+y+name")] XYAndName
                , [Name("x+y+z")] XYAndY
                , [Name("x+y+z+text")] XYZAndText
                , [Name("x+y+z+name")] XYZAndName
                , [Name("y+name")] YAndName
                , [Name("y+x")] YAndX
                , [Name("y+text")] YAndText
                , [Name("y+x+text")] YXAndText
                , [Name("y+x+name")] YXAndName
                , [Name("y+z")] YAndZ
                , [Name("y+z+text")] YZAndText
                , [Name("y+z+name")] YZAndName
                , [Name("y+x+z")] YXAndZ
                , [Name("y+x+z+text")] YXZAndText
                , [Name("y+x+z+name")] YXZAndName
                , [Name("z+x")] ZAndX
                , [Name("z+x+text")] ZXAndText
                , [Name("z+x+name")] ZXAndName
                , [Name("z+y+x")] ZYAndX
                , [Name("z+y+x+text")] ZYXandText
                , [Name("z+y+x+name")] ZYXAndName
                , [Name("z+x+y")] ZXAndY
                , [Name("z+x+y+text")] ZXYAndText
                , [Name("z+x+y+name")] ZXYAndName
            }

            [Enum(Emit.StringNameLowerCase)]
            public enum TextInfo
            {

                Label
                , [Name("label+text")] LabelAndText
                , [Name("label+value")] LabelAndValue
                , [Name("label+percent")] LabelAndPercent
                , [Name("label+text+value")] LabelTextAndValue
                , [Name("label+text+percent")] LabelTextAndPercent
                , [Name("label+value+percent")] LabelValueAndPercent
                , Text
                , [Name("text+value")] TextAndValue
                , [Name("text+percent")] TextAndPercent
                , [Name("text+value+percent")] TextValueAndPercent
                , Value
                , [Name("value+percent")] ValueAndPercent
                , Percent
                , None
            }

            [Enum(Emit.StringNameLowerCase)]
            public enum TextPosition
            {

                TopLeft
                , TopCenter
                , TopRight
                , MiddleLeft
                , MiddleCenter
                , MiddleRight
                , BottomLeft
                , BottomCenter
                , BottomRight
                , Inside
            }

            [Enum(Emit.StringNameLowerCase)]
            public enum Fill
            {

                None
                , [Name("tozeroy")] ToZeroY
                , [Name("tozerox")] ToZeroX
                , [Name("tonexty")] ToNextY
                , [Name("tonextx")] ToNextX
                , [Name("toself")] ToSelf
                , [Name("tonext")] ToNext
            }

            [Enum(Emit.StringNameLowerCase)]
            public enum BoxMean
            {

                Sd
            }

            [Enum(Emit.StringNameLowerCase)]
            public enum ZSmooth
            {

                Fast
                , Best
            }

        }

        public partial class Transform
        {
            [Enum(Emit.StringNameLowerCase)]
            public enum Type
            {
                Aggregate
                , Filter
                , [Name("groupby")] GroupBy
                , Sort
            }


            [Enum(Emit.StringNameLowerCase)]
            public enum Order
            {
                Ascending
                , Descending
            }
        }

        public partial class TransformAggregation
        {
            [Enum(Emit.StringNameLowerCase)]
            public enum Func
            {

                Count
                , Sum
                , Avg
                , Median
                , Mode
                , Rms
                , Stddev
                , Min
                , Max
                , First
                , Last
            }

            [Enum(Emit.StringNameLowerCase)]
            public enum FuncMode
            {

                Sample
                , Population
            }
        }

        public partial class ColorBar
        {
            [Enum(Emit.StringNameLowerCase)]
            public enum TitleSide
            {

                Right
                , Top
                , Bottom
            }
        }

        [Enum(Emit.StringNameLowerCase)]
        public enum SizeMode
        {

            Fraction
            , Pixels
        }


        public partial class RangeSelectorButton
        {
            [Enum(Emit.StringNameLowerCase)]
            public enum Step
            {

                Second
                , Minute
                , Hour
                , Day
                , Month
                , Year
                , All
            }

            [Enum(Emit.StringNameLowerCase)]
            public enum StepMode
            {

                Backward
                , [Name("todate")] ToDate
            }
        }

        public partial class HoverLabel
        {
            [Enum(Emit.StringNameLowerCase)]
            public enum Align
            {

                Left
                , Right
                , Auto
            }
        }


        public partial class Annotations
        {
            [Enum(Emit.StringNameLowerCase)]
            public enum Align
            {

                Left
                , Center
                , Right
            }

            [Enum(Emit.StringNameLowerCase)]
            public enum VAlign
            {

                Top
                , Middle
                , Bottom
            }

            [Enum(Emit.StringNameLowerCase)]
            public enum ArrowSide
            {

                End
                , Start
            }

            [Enum(Emit.StringNameLowerCase)]
            public enum AXRef
            {

                Pixel
                , X, X2, X3, X4, X5, X6, X7, X8, X9
            }

            [Enum(Emit.StringNameLowerCase)]
            public enum AYRef
            {

                Pixel
                , Y, Y2, Y3, Y4, Y5, Y6, Y7, Y8, Y9
            }

            [Enum(Emit.StringNameLowerCase)]
            public enum XAnchor
            {

                Auto
                , Left
                , Center
                , Right
            }

            [Enum(Emit.StringNameLowerCase)]
            public enum YAnchor
            {

                Auto
                , Top
                , Middle
                , Bottom
            }

            [Enum(Emit.StringNameLowerCase)]
            public enum ClickToShow
            {

                [Name("onoff")] OnOff
                , [Name("onout")] OnOut
            }
        }


        [Enum(Emit.StringNameLowerCase)]
        public enum XRef
        {

            Paper
            , X
        }

        [Enum(Emit.StringNameLowerCase)]
        public enum YRef
        {

            Paper
            , Y
        }



        public partial class Image
        {
            [Enum(Emit.StringNameLowerCase)]
            public enum Layer
            {

                Below
                , Above
            }

            [Enum(Emit.StringNameLowerCase)]
            public enum Sizing
            {

                Fill
                , Contain
                , Stretch
            }

            [Enum(Emit.StringNameLowerCase)]
            public enum XAnchor
            {

                Left
                , Center
                , Right
            }

            [Enum(Emit.StringNameLowerCase)]
            public enum YAnchor
            {

                Top
                , Middle
                , Bottom
            }

            [Enum(Emit.StringNameLowerCase)]
            public enum Xref
            {

                X
                , Paper
            }

            [Enum(Emit.StringNameLowerCase)]
            public enum Yref
            {

                Y
                , Paper
            }

        }


        [Enum(Emit.StringNameLowerCase)]
        public enum SceneAspectMode
        {

            Auto
        , Cube
        , Data
        , Manual
        }

        [Enum(Emit.StringNameLowerCase)]
        public enum SceneDragMode
        {

            Orbit
        , Turntable
        , Zoom
        , Pan
        }

        [Enum(Emit.StringNameLowerCase)]
        public enum SceneHoverMode
        {

            Closest
        }


        public partial class Transition
        {
            [Enum(Emit.StringNameLowerCase)]
            public enum Easing
            {
                Linear, Quad, Cubic, Sin, Exp, Circle, Elastic, Back, Bounce
                , [Name("linear-in")] LinearIn
                , [Name("quad-in ")] QuadIn
                , [Name("cubic-in ")] CubicIn
                , [Name("sin-in ")] SinIn
                , [Name("exp-in ")] ExpIn
                , [Name("circle-in ")] CircleIn
                , [Name("elastic-in")] ElasticIn
                , [Name("back-in")] BackIn
                , [Name("bounce-in ")] BounceIn
                , [Name("linear-out ")] LinearOut
                , [Name("quad-out ")] QuadOut
                , [Name("cubic-out")] CubicOut
                , [Name("sin-out ")] SinOut
                , [Name("exp-out ")] ExpOut
                , [Name("circle-out ")] CircleOut
                , [Name("elastic-out ")] ElasticOut
                , [Name("back-out ")] BackOut
                , [Name("bounce-out ")] BounceOut
                , [Name("linear-in-out ")] LinearInOut
                , [Name("quad-in-out ")] QuadInOut
                , [Name("cubic-in-out ")] CubicInOut
                , [Name("sin-in-out ")] SinInOut
                , [Name("exp-in-out ")] ExpInOut
                , [Name("circle-in-out ")] CircleInOut
                , [Name("elastic-in-out ")] ElasticInOut
                , [Name("back-in-out ")] BackInOut
                , [Name("bounce-in-out")] BounceInOut
            }

        }

        public partial class SliderStep
        {
            [Enum(Emit.StringNameLowerCase)]
            public enum Method
            {

                Animate
                , Relayout
                , Restyle
                , Skip
                , Update
            }
        }

        public partial class Padding
        {
            [Enum(Emit.StringNameLowerCase)]
            public enum EditType
            {
                ArrayDraw
            }
        }

        public partial class Gradient
        {
            [Enum(Emit.StringNameLowerCase)]
            public enum Type
            {
                Radial
                , Horizontal
                , Vertical
                , None
            }
        }


        [ObjectLiteral]
        public partial class Point
        {
            public float x;
            public float y;
            public float z;
        }

        [ObjectLiteral]
        public partial class PlotScatterDataPoint
        {
            public float curveNumber;
            public PlotData data;
            public float pointIndex;
            public float pointNumber;
            public float x;
            public LayoutAxis xaxis;
            public float y;
            public LayoutAxis yaxis;
        }

        [ObjectLiteral]
        public partial class PlotDatum
        {
            public float curveNumber;
            public PlotData data;
            public float pointIndex;
            public float pointNumber;
            public Datum x;
            public LayoutAxis xaxis;
            public Datum y;
            public LayoutAxis yaxis;
            public string text;
        }

        [ObjectLiteral]
        public partial class PlotMouseEvent
        {
            public PlotDatum[] points;
            public MouseEvent @event;
        }
        [ObjectLiteral]
        public partial class PlotCoordinate
        {
            public float x;
            public float y;
            public float pointNumber;
        }
        [ObjectLiteral]
        public partial class SelectionRange
        {
            public float[] x;
            public float[] y;
        }

        [ObjectLiteral]
        public partial class PlotSelectedData { }


        [ObjectLiteral]
        public partial class PlotSelectionEvent
        {
            public PlotDatum[] points;
            public SelectionRange range;
            public SelectionRange lassoPoints;
        }
        [ObjectLiteral]
        public partial class PlotRestyleEvent { }


        [ObjectLiteral]
        public partial class PlotAxis
        {
            public float[] range;
            public bool autorange;
        }
        [ObjectLiteral]
        public partial class PlotScene
        {
            public Point center;
            public Point eye;
            public Point up;
        }
        [ObjectLiteral]
        public partial class PlotRelayoutEvent
        {
            public PlotAxis xaxis;
            public PlotAxis yaxis;
            public PlotScene scene;
        }
        [ObjectLiteral]
        public partial class ClickAnnotationEvent
        {
            public float index;
            public Annotations annotation;
            public Annotations fullAnnotation;
            public MouseEvent @event;
        }
        [ObjectLiteral]
        public partial class FrameAnimationEvent
        {
            public string name;
            public Frame frame;
            public Animation animation;
        }
        [ObjectLiteral]
        public partial class LegendClickEvent
        {
            public MouseEvent @event;
            public HTMLElement node;
            public float curveNumber;
            public float expandedIndex;
            public Data[] data;
            public object layout;
            public Frame[] frames;
            public object config;
            public Data[] fullData;
            public object fullLayout;
        }
        [ObjectLiteral]
        public partial class SliderChangeEvent
        {
            public Slider slider;
            public SliderStep step;
            public bool interaction;
            public float previousActive;
        }
        [ObjectLiteral]
        public partial class SliderStartEvent
        {
            public Slider slider;
        }
        [ObjectLiteral]
        public partial class SliderEndEvent
        {
            public Slider slider;
            public SliderStep step;
        }
        [ObjectLiteral]
        public partial class BeforePlotEvent
        {
            public Data[] data;
            public object layout;
            public object config;
        }

        [ObjectLiteral]
        public partial class ToImgopts
        {
            public ImageFormat format;
            public float width;
            public float height;
        }
        [ObjectLiteral]
        public partial class DownloadImgopts
        {
            public ImageFormat format;
            public float width;
            public float height;
            public string filename;
        }

        [ObjectLiteral]
        public partial class Layout
        {
            public dynamic title;
            public object titlefont; // Partial<Font>
            public bool autosize;
            public bool showlegend;
            public Color paper_bgcolor;
            public Color plot_bgcolor;
            public string separators;
            public bool hidesources;
            public Axis xaxis; // Partial<LayoutAxis> for all *axis methods
            public Axis xaxis2;
            public Axis xaxis3;
            public Axis xaxis4;
            public Axis xaxis5;
            public Axis xaxis6;
            public Axis xaxis7;
            public Axis xaxis8;
            public Axis xaxis9;
            public Axis yaxis;
            public Axis yaxis2;
            public Axis yaxis3;
            public Axis yaxis4;
            public Axis yaxis5;
            public Axis yaxis6;
            public Axis yaxis7;
            public Axis yaxis8;
            public Axis yaxis9;
            public object margin; // Partial<Margin>
            public float height;
            public float width;
            public dynamic hovermode;
            public object hoverlabel; // Partial<HoverLabel>
            public Calendar calendar;


            public dynamic ternary;
            public dynamic geo;
            public dynamic mapbox;
            public dynamic radialaxis; // Partial<Axis>
            public dynamic angularaxis;
            public Layout.Direction direction;
            public Layout.DragMode dragmode;
            public float orientation;
            public Annotations[] annotations; // Array<Partial<Annotations>>
            public object[] shapes; // Array<Partial<Shape>>
            public object[] images; // Array<Partial<Image>>
            public dynamic updatemenus;
            public object[] sliders; // Array<Partial<Slider>>
            public object legend; // Partial<Legend>
            public object font; // Partial<Font>
            public object scene; // Partial<Scene>
            public Layout.BarMode barmode;
            public float bargap;
            public float bargroupgap;
            public Layout.SelectDirection selectdirection;
        }
        [ObjectLiteral]
        public partial class Legend : Label
        {
            public dynamic traceorder;
            public float x;
            public float y;
            public float borderwidth;
            public dynamic orientation;
            public float tracegroupgap;
            public XAnchorAuto xanchor;
            public YAnchorAuto yanchor;
        }

        [ObjectLiteral]
        public partial class Axis
        {
            public bool visible;
            public Color color;
            public string title;
            public object titlefont;
            public AxisType @type;
            public dynamic autorange;
            public Axis.RangeMode rangemode;
            public object[] range;
            public TickMode tickmode;
            public float nticks;
            public dynamic tick0;
            public dynamic dtick;
            public object[] tickvals;
            public string[] ticktext;
            public Ticks ticks;
            public dynamic mirror;
            public float ticklen;
            public float tickwidth;
            public Color tickcolor;
            public bool showticklabels;
            public bool showspikes;
            public Color spikecolor;
            public float spikethickness;
            public dynamic categoryorder;
            public object[] categoryarray;
            public object tickfont;
            public float tickangle;
            public string tickprefix;
            public ShowOptions showtickprefix;
            public string ticksuffix;
            public ShowOptions showticksuffix;
            public ShowOptions showexponent;
            public ExponentFormat exponentformat;
            public bool separatethousands;
            public string tickformat;
            public string hoverformat;
            public bool showline;
            public Color linecolor;
            public float linewidth;
            public bool showgrid;
            public Color gridcolor;
            public float gridwidth;
            public bool zeroline;
            public Color zerolinecolor;
            public float zerolinewidth;
            public Calendar calendar;
        }

        [ObjectLiteral]
        public partial class LayoutAxis : Axis
        {
            public bool fixedrange;
            public Axis.Name scaleanchor;
            public float scaleratio;
            public Axis.Constrain constrain;
            public Axis.ConstrainToward constraintoward;
            public string spikedash;
            public string spikemode;
            public Axis.Positioning anchor;
            public Axis.Side side;
            public Axis.Positioning overlaying;
            public Axis.Layer layer;
            public float[] domain;
            public float position;
            public object rangeslider;
            public object rangeselector;
            public bool automargin;
        }

        [ObjectLiteral]
        public partial class SceneAxis : Axis
        {
            public bool spikesides;
            public bool showbackground;
            public Color backgroundcolor;
            public bool showaxeslabels;
        }
        [ObjectLiteral]
        public partial class ShapeLine
        {
            public string color;
            public float width;
            public Dash dash;
        }
        [ObjectLiteral]
        public partial class Shape
        {
            public bool visible;
            public Shape.Layer layer;
            public Shape.Type @type;
            public string path;
            public Shape.Xref xref;
            public Shape.Yref yref;
            public Datum x0;
            public Datum y0;
            public Datum x1;
            public Datum y1;
            public string fillcolor;
            public float opacity;
            public object line;
        }
        [ObjectLiteral]
        public partial class Margin
        {
            public float t;
            public float b;
            public float l;
            public float r;
        }
        [ObjectLiteral]
        public partial class ButtonClickEvent
        {

        }
        [ObjectLiteral]
        public partial class Icon
        {
            public float width;
            public string path;
            public float ascent;
            public float descent;
        }

        [ObjectLiteral]
        public partial class ModeBarButton
        {
            /// name / id of the buttons (for tracking) 
            public string name;
            /// text that appears while hovering over the button,
            /// enter null, false or '' for no hover text
            public string title;
            /// svg icon object associated with the button
            /// can be linked to Plotly.Icons to use the default plotly icons
            public dynamic icon;
            /// icon positioning 
            public string gravity;
            /// click handler associated with the button, a function of
            /// 'gd' (the main graph object) and
            /// 'ev' (the event object)
            public ButtonClickEvent click;
            /// attribute associated with button,
            /// use this with 'val' to keep track of the state
            public string attr;
            /// initial 'attr' value, can be a function of gd 
            public object val;
            /// is the button a toggle button? 
            public bool? toggle;
        }

        //    [ObjectLiteral]
        //    public partial class Datum
        //    {
        //        dynamic option
        //            let ofStringOption v: Datum
        //{ v |> Microsoft.FSharp.Core.Option.map U3.Case1
        //        let ofString v: Datum
        //{
        //            v |> U3.Case1 |> Some
        //        let isString(v: Datum)
        //{
        //                match v with None -> false | Some o->match o with U3.Case1 _ -> true | _-> false
        //        let asString(v: Datum)
        //{
        //                    match v with None -> None | Some o->match o with U3.Case1 o -> Some o | _->None
        //        let ofFloatOption v: Datum
        //{
        //                        v |> Microsoft.FSharp.Core.Option.map U3.Case2
        //                              let ofFloat v: Datum
        //{
        //                            v |> U3.Case2 |> Some
        //        let isFloat(v: Datum)
        //{
        //                                match v with None -> false | Some o->match o with U3.Case2 _ -> true | _-> false
        //        let asFloat(v: Datum)
        //{
        //                                    match v with None -> None | Some o->match o with U3.Case2 o -> Some o | _->None
        //        let ofDateTimeOption v: Datum
        //{
        //                                        v |> Microsoft.FSharp.Core.Option.map U3.Case3
        //                                              let ofDateTime v: Datum
        //{
        //                                            v |> U3.Case3 |> Some
        //        let isDateTime(v: Datum)
        //{
        //                                                match v with None -> false | Some o->match o with U3.Case3 _ -> true | _-> false
        //        let asDateTime(v: Datum)
        //{
        //                                                    match v with None -> None | Some o->match o with U3.Case3 o -> Some o | _->None


        [ObjectLiteral]
        public partial class ErrorOptions
        {
            public bool visible;
            public bool symmetric;
            public Color color;
            public float thickness;
            public float width;
            public float opacity;
        }

        [ObjectLiteral]
        public partial class ErrorBar
        {
        }

        [ObjectLiteral] public partial class Data : PlotData { }

        [ObjectLiteral] public partial class DataTransform { }

        [ObjectLiteral] public partial class ScatterData : PlotData { }


        [ObjectLiteral]
        public class PlotLine
        {
            public Color color;
            public float width;
            public Dash dash;
            public LineShape shape;
            public float smoothing;
            public bool simplify;
        }


        [ObjectLiteral]
        public partial class PlotData
        {
            public PlotData.Type @type;
            public dynamic x;
            public dynamic y;
            public dynamic z;
            public object xy;
            public ErrorBar error_x;
            public ErrorBar error_y;
            public string xaxis;
            public string yaxis;
            public string text;
            public PlotMarker marker;
            public PlotLine line;
            public PlotData.Mode mode;
            public PlotData.HoverOn hoveron;
            public PlotData.HoverInfo hoverinfo;
            public object hoverlabel; // Partial<HoverLabel>
            public dynamic hovertemplate;
            public PlotData.TextInfo textinfo;
            public PlotData.TextPosition textposition;
            public PlotData.Fill fill;
            public string fillcolor;
            public string legendgroup;
            public string name;
            public string stackgroup;
            public bool connectgaps;
            public dynamic visible;
            public DataTransform[] transforms;
            public Orientation orientation;
            public dynamic width;
            public dynamic boxmean;
            public ColorScale colorscale;
            public dynamic zsmooth;
            public float ygap;
            public float xgap;
            public bool transpose;
            public bool autobinx;
            public XBins xbins;
            public Datum[] values;
            public Datum[] labels;
            public float hole;
            public float rotation;
            public Datum[] theta;
            public Datum[] r;

        }

        /// These interfaces are based on attribute descriptions in
        /// https://github.com/plotly/plotly.js/tree/9d6144304308fc3007f0facf2535d38ea3e9b26c/src/transforms
        [ObjectLiteral]
        public partial class TransformStyle
        {
            public dynamic target;
            public object value;
        }

        [ObjectLiteral]
        public partial class TransformAggregation
        {
            public string target;
            public TransformAggregation.Func? func;
            public TransformAggregation.FuncMode? funcmode;
            public bool? enabled;
        }

        [ObjectLiteral]
        public partial class Transform
        {
            public Transform.Type @type;
            public bool enabled;
            public dynamic target;
            public string operation;
            public TransformAggregation[] aggregations;
            public bool preservegaps;
            public dynamic groups;
            public string nameformat;
            public TransformStyle[] styles;
            public object value;
            public Transform.Order order;
        }

        [ObjectLiteral]
        public partial class ColorBar
        {
            public SizeMode thicknessmode;
            public float thickness;
            public SizeMode lenmode;
            public float len;
            public float x;
            public XAnchor xanchor;
            public float xpad;
            public float y;
            public YAnchor yanchor;
            public float ypad;
            public Color outlinecolor;
            public float outlinewidth;
            public Color bordercolor;
            public Color borderwidth;
            public Color bgcolor;
            public TickMode tickmode;
            public float nticks;
            public dynamic tick0;
            public dynamic dtick;
            public dynamic tickvals;
            public dynamic ticktext;
            public Ticks ticks;
            public float ticklen;
            public float tickwidth;
            public Color tickcolor;
            public bool showticklabels;
            public Font tickfont;
            public float tickangle;
            public string tickformat;
            public TickFormatStops tickformatstops;
            public string tickprefix;
            public ShowOptions showtickprefix;
            public string ticksuffix;
            public ShowOptions showticksuffix;
            public bool separatethousands;
            public ExponentFormat exponentformat;
            public ShowOptions showexponent;
            public string title;
            public Font titlefont;
            public ColorBar.TitleSide titleside;
            public object tickvalssrc;
            public object ticktextsrc;
        }

        /// Any combination of "x", "y", "z", "text", "name" joined with a "+" OR "all" or "none" or "skip".
        /// examples: "x", "y", "x+y", "x+y+z", "all"
        /// default: "all"
        [ObjectLiteral]
        public partial class PlotMarker
        {
            public dynamic symbol;
            public dynamic color;
            public Color[] colors;
            public ColorScale colorscale;
            public bool cauto;
            public float cmax;
            public float cmin;
            public bool autocolorscale;
            public bool reversescale;
            public dynamic opacity;
            public dynamic size;
            public float maxdisplayed;
            public float sizeref;
            public float sizemax;
            public float sizemin;
            public MarkerSizeMode sizemode;
            public bool showscale;
            public object line;
            public float width;
            public object colorbar;
            public Gradient gradient;

        }
        [ObjectLiteral] public partial class ScatterMarker : PlotMarker { }

        [ObjectLiteral]
        public partial class ScatterMarkerLine
        {
            public dynamic width;
            public Color color;
            public ColorScale colorscale;
            public bool cauto;
            public float cmax;
            public float cmin;
            public bool autocolorscale;
            public bool reversescale;

        }
        [ObjectLiteral]
        public partial class ScatterLine
        {
            public Color color;
            public float width;
            public Dash dash;
            public LineShape shape;
            public float smoothing;
            public bool simplify;
        }
        [ObjectLiteral]
        public partial class Font
        {
            /// HTML font family - the typeface that will be applied by the web browser.
            /// The web browser will only be able to apply a font if it is available on the system
            /// which it operates. Provide multiple font families, separated by commas, to indicate
            /// the preference in which to apply fonts if they aren't available on the system.
            /// The plotly service (at https://plot.ly or on-premise) generates images on a server,
            /// where only a select number of fonts are installed and supported.
            /// These include *Arial*, *Balto*, *Courier New*, *Droid Sans*, *Droid Serif*,
            /// *Droid Sans Mono*, *Gravitas One*, *Old Standard TT*, *Open Sans*, *Overpass*,
            /// *PT Sans Narrow*, *Raleway*, *Times New Roman*.
            public string family;
            public float size;
            public Color color;
        }
        [ObjectLiteral]
        public partial class Edits
        {
            public bool annotationPosition;
            public bool annotationTail;
            public bool annotationText;
            public bool axisTitleText;
            public bool colorbarPosition;
            public bool colorbarTitleText;
            public bool legendPosition;
            public bool legendText;
            public bool shapePosition;
            public bool titleText;
        }


        [ObjectLiteral]
        public partial class Config
        {
            /// override the defaults for the toImageButton 
            public object toImageButtonOptions;
            /// no interactivity, for export or image generation 
            public bool staticPlot;
            /// we can edit titles, move annotations, etc 
            public bool editable;
            public dynamic edits; // Partial<Edits>
                                  /// DO autosize once regardless of layout.autosize (use default width or height values otherwise) 
            public bool autosizable;
            /// set the length of the undo/redo queue 
            public float queueLength;
            /// if we DO autosize, do we fill the container or the screen? 
            public bool fillFrame;
            /// if we DO autosize, set the frame margins in percents of plot size 
            public float frameMargins;
            /// mousewheel or two-finger scroll zooms the plot 
            public bool scrollZoom;
            /// double click interaction (false, 'reset', 'autosize' or 'reset+autosize') 
            public dynamic doubleClick;
            /// new users see some hints about interactivity 
            public bool showTips;
            /// enable axis pan/zoom drag handles 
            public bool showAxisDragHandles;
            /// enable direct range entry at the pan/zoom drag points (drag handles must be enabled above) 
            public bool showAxisRangeEntryBoxes;
            /// link to open this plot in plotly 
            public bool showLink;
            /// if we show a link, does it contain data or just link to a plotly file? 
            public bool sendData;
            /// text appearing in the sendData link 
            public string linkText;
            /// false or function adding source(s) to linkText <text> 
            public bool showSources;
            /// display the mode bar (true, false, or 'hover') 
            public dynamic displayModeBar;
            /// remove mode bar button by name (see ./components/modebar/buttons.js for the list of names) 
            public ModeBarDefaultButtons[] modeBarButtonsToRemove;
            /// add mode bar button using config objects (see ./components/modebar/buttons.js for list of arguments) 
            public dynamic modeBarButtonsToAdd;
            /// fully custom mode bar buttons as nested array, where the outer
            /// arrays represents button groups, and the inner arrays have
            /// buttons config objects or names of default buttons
            /// (see ./components/modebar/buttons.js for more info)
            public dynamic modeBarButtons;
            /// add the plotly logo on the end of the mode bar 
            public bool displaylogo;
            /// increase the pixel ratio for Gl plot images 
            public float plotGlPixelRatio;
            /// function to add the background color to a different container
            /// or 'opaque' to ensure there's white behind it
            /// or 'transparent'
            [External]
            public void setBackground(string color) { }
            /// URL to topojson files used in geo charts 
            public string topojsonURL;
            /// Mapbox access token (required to plot mapbox trace types)
            /// If using an Mapbox Atlas server, set this option to '',
            /// so that plotly.js won't attempt to authenticate to the public Mapbox server.
            public string mapboxAccessToken;
            /// Turn all console logging on or off (errors will be thrown)
            /// This should ONLY be set via Plotly.setPlotConfig
            /// only accepts 0, 1, and 2
            public dynamic logging;
            /// Set global transform to be applied to all traces with no specification needed 
            public object[] globalTransforms;
            /// Which localization should we use? Should be a string like 'en' or 'en-US' 
            public string locale;
            /// Make the chart responsive to window size 
            public bool responsive;
        }
        [ObjectLiteral]
        public partial class RangeSlider
        {
            public bool visible;
            public float thickness;
            public Datum[] range;
            public float borderwidth;
            public string bordercolor;
            public string bgcolor;
        }

        [ObjectLiteral]
        public partial class RangeSelectorButton
        {
            public RangeSelectorButton.Step step;
            public RangeSelectorButton.StepMode stepmode;
            public float count;
            public string label;
        }

        [ObjectLiteral]
        public partial class RangeSelector : Label
        {
            public object[] buttons; // Array<Partial<RangeSelectorButton>>
            public bool visible;
            public float x;
            public XAnchorAuto xanchor;
            public float y;
            public YAnchorAuto yanchor;
            public string activecolor;
            public float borderwidth;
        }
        [ObjectLiteral]
        public partial class Camera
        {
            public object up; // Partial<Point>
            public object center; // Partial<Point>
            public object eye; // Partial<Point>
        }
        [ObjectLiteral]
        public partial class Label
        {
            /// Sets the background color of all hover labels on graph. 
            public string bgcolor;
            /// Sets the border color of all hover labels on graph. 
            public string bordercolor;
            /// Sets the default hover label font used by all traces on the graph. 
            public object font; // Partial<Font>
        }


        [ObjectLiteral]
        public partial class HoverLabel : Label
        {
            /// Sets the horizontal alignment of the text content within hover label box. 
            public HoverLabel.Align align;
            /// Sets the default length (in number of characters) (default 15) of the trace name
            /// in the hover labels for all traces.
            /// -1 shows the whole name regardless of length.
            public float namelength;
        }

        [ObjectLiteral]
        public partial class Annotations : Label
        {
            /// Determines whether or not this annotation is visible. 
            public bool visible;
            /// Sets the text associated with this annotation.
            /// Plotly uses a subset of HTML tags to do things like
            /// newline (<br>), bold (<b></b>), italics (<i></i>),
            /// hyperlinks (<a href='...'></a>). Tags <em>, <sup>, <sub>
            /// <span> are also supported.
            public string text;
            /// Sets the angle at which the `text` is drawn with respect to the horizontal. 
            public string textangle;
            /// Sets an explicit width for the text box. null (default) lets the
            /// text set the box width. Wider text will be clipped.
            /// There is no automatic wrapping; use <br> to start a new line.
            public float width;
            /// Sets an explicit height for the text box. null (default) lets the
            /// text set the box height. Taller text will be clipped.
            public float height;
            /// Sets the opacity of the annotation (text + arrow). 
            public float opacity;
            /// Sets the horizontal alignment of the `text` within the box.
            /// Has an effect only if `text` spans more two or more lines
            /// (i.e. `text` contains one or more <br> HTML tags) or if an
            /// explicit width is set to override the text width.
            public Annotations.Align align;
            /// Sets the vertical alignment of the `text` within the box.
            /// Has an effect only if an explicit height is set to override the text height.
            public Annotations.VAlign valign;
            /// Sets the padding (in px) between the `text` and the enclosing border. 
            public float borderpad;
            /// Sets the width (in px) of the border enclosing the annotation `text`. 
            public float borderwidth;
            /// Determines whether or not the annotation is drawn with an arrow.
            /// If *true*, `text` is placed near the arrow's tail.
            /// If *false*, `text` lines up with the `x` and `y` provided.
            public bool showarrow;
            /// Sets the color of the annotation arrow. 
            public string arrowcolor;
            /// Sets the end annotation arrow head style. 
            public float arrowhead;
            /// Sets the start annotation arrow head style. 
            public float startarrowhead;
            /// Sets the annotation arrow head position. 
            public Annotations.ArrowSide arrowside;
            /// Sets the size of the end annotation arrow head, relative to `arrowwidth`.
            /// A value of 1 (default) gives a head about 3x as wide as the line.
            public float arrowsize;
            /// Sets the size of the start annotation arrow head, relative to `arrowwidth`.
            /// A value of 1 (default) gives a head about 3x as wide as the line.
            public float startarrowsize;
            /// Sets the width (in px) of annotation arrow line. 
            public float arrowwidth;
            /// Sets a distance, in pixels, to move the end arrowhead away from the
            /// position it is pointing at, for example to point at the edge of
            /// a marker independent of zoom. Note that this shortens the arrow
            /// from the `ax` / `ay` vector, in contrast to `xshift` / `yshift`
            /// which moves everything by this amount.
            public float standoff;
            /// Sets a distance, in pixels, to move the start arrowhead away from the
            /// position it is pointing at, for example to point at the edge of
            /// a marker independent of zoom. Note that this shortens the arrow
            /// from the `ax` / `ay` vector, in contrast to `xshift` / `yshift`
            /// which moves everything by this amount.
            public float startstandoff;
            /// Sets the x component of the arrow tail about the arrow head.
            /// If `axref` is `pixel`, a positive (negative)
            /// component corresponds to an arrow pointing
            /// from right to left (left to right).
            /// If `axref` is an axis, this is an absolute value on that axis,
            /// like `x`, NOT a relative value.
            public float ax;
            /// Sets the y component of the arrow tail about the arrow head.
            /// If `ayref` is `pixel`, a positive (negative)
            /// component corresponds to an arrow pointing
            /// from bottom to top (top to bottom).
            /// If `ayref` is an axis, this is an absolute value on that axis,
            /// like `y`, NOT a relative value.
            public float ay;
            /// Indicates in what terms the tail of the annotation (ax,ay)
            /// is specified. If `pixel`, `ax` is a relative offset in pixels
            /// from `x`. If set to an x axis id (e.g. *x* or *x2*), `ax` is
            /// specified in the same terms as that axis. This is useful
            /// for trendline annotations which should continue to indicate
            /// the correct trend when zoomed.
            public string axref;
            /// Indicates in what terms the tail of the annotation (ax,ay)
            /// is specified. If `pixel`, `ay` is a relative offset in pixels
            /// from `y`. If set to a y axis id (e.g. *y* or *y2*), `ay` is
            /// specified in the same terms as that axis. This is useful
            /// for trendline annotations which should continue to indicate
            /// the correct trend when zoomed.
            public string ayref;
            /// Sets the annotation's x coordinate axis.
            /// If set to an x axis id (e.g. *x* or *x2*), the `x` position refers to an x coordinate
            /// If set to *paper*, the `x` position refers to the distance from
            /// the left side of the plotting area in normalized coordinates
            /// where 0 (1) corresponds to the left (right) side.
            public XRef xref;
            /// Sets the annotation's x position.
            /// If the axis `type` is *log*, then you must take the log of your desired range.
            /// If the axis `type` is *date*, it should be date strings, like date data,
            /// though Date objects and unix milliseconds will be accepted and converted to strings.
            /// If the axis `type` is *category*, it should be numbers, using the scale where each
            /// category is assigned a serial number from zero in the order it appears.
            public dynamic x;
            /// Sets the text box's horizontal position anchor
            /// This anchor binds the `x` position to the *left*, *center* or *right* of the annotation.
            /// For example, if `x` is set to 1, `xref` to *paper* and `xanchor` to *right* then the
            /// right-most portion of the annotation lines up with the right-most edge of the plotting area.
            /// If *auto*, the anchor is equivalent to *center* for data-referenced annotations or if there
            /// is an arrow, whereas for paper-referenced with no arrow, the anchor picked corresponds to the closest side.
            public Annotations.XAnchor xanchor;
            /// Shifts the position of the whole annotation and arrow to the
            /// right (positive) or left (negative) by this many pixels.
            public float xshift;
            /// Sets the annotation's y coordinate axis.
            /// If set to an y axis id (e.g. *y* or *y2*), the `y` position refers to an y coordinate
            /// If set to *paper*, the `y` position refers to the distance from
            /// the bottom of the plotting area in normalized coordinates
            /// where 0 (1) corresponds to the bottom (top).
            public YRef yref;
            /// Sets the annotation's y position.
            /// If the axis `type` is *log*, then you must take the log of your desired range.
            /// If the axis `type` is *date*, it should be date strings, like date data,
            /// though Date objects and unix milliseconds will be accepted and converted to strings.
            /// If the axis `type` is *category*, it should be numbers, using the scale where each
            /// category is assigned a serial number from zero in the order it appears.
            public dynamic y;
            /// Sets the text box's vertical position anchor
            /// This anchor binds the `y` position to the *top*, *middle* or *bottom* of the annotation.
            /// For example, if `y` is set to 1, `yref` to *paper* and `yanchor` to *top* then the
            /// top-most portion of the annotation lines up with the top-most edge of the plotting area.
            /// If *auto*, the anchor is equivalent to *middle* for data-referenced annotations or if
            /// there is an arrow, whereas for paper-referenced with no arrow, the anchor picked
            /// corresponds to the closest side.
            public Annotations.YAnchor yanchor;
            /// Shifts the position of the whole annotation and arrow up
            /// (positive) or down (negative) by this many pixels.
            public float yshift;
            /// Makes this annotation respond to clicks on the plot.
            /// If you click a data point that exactly matches the `x` and `y` values of this annotation,
            /// and it is hidden (visible: false), it will appear. In *onoff* mode, you must click the same
            /// point again to make it disappear, so if you click multiple points, you can show multiple
            /// annotations. In *onout* mode, a click anywhere else in the plot (on another data point or not)
            /// will hide this annotation. If you need to show/hide this annotation in response to different
            /// `x` or `y` values, you can set `xclick` and/or `yclick`. This is useful for example to label
            /// the side of a bar. To label markers though, `standoff` is preferred over `xclick` and `yclick`.
            public dynamic clicktoshow;
            /// Toggle this annotation when clicking a data point whose `x` value
            /// is `xclick` rather than the annotation's `x` value.
            public object xclick;
            /// Toggle this annotation when clicking a data point whose `y` value
            /// is `yclick` rather than the annotation's `y` value.
            public object yclick;
            /// Sets text to appear when hovering over this annotation.
            /// If omitted or blank, no hover label will appear.
            public string hovertext;
            public object hoverlabel; // Partial<HoverLabel>
                                      /// Determines whether the annotation text box captures mouse move and click events,
                                      /// or allows those events to pass through to data points in the plot that may be
                                      /// behind the annotation. By default `captureevents` is *false* unless `hovertext`
                                      /// is provided. If you use the event `plotly_clickannotation` without `hovertext`
                                      /// you must explicitly enable `captureevents`.
            public bool captureevents;
        }

        [ObjectLiteral]
        public partial class Image
        {
            public bool visible;
            public string source;
            public Image.Layer layer;
            public float sizex;
            public float sizey;
            public Image.Sizing sizing;
            public float opacity;
            public dynamic x;
            public dynamic y;
            public Image.XAnchor xanchor;
            public Image.YAnchor yanchor;
            public Image.Xref xref;
            public Image.Yref yref;
        }

        [ObjectLiteral]
        public partial class Scene
        {
            public string bgcolor;
            public object camera; // Partial<Camera>
            public object domain; // Partial<Domain>
            public SceneAspectMode aspectmode;
            public object aspectratio; // Partial<Point>
            public object xaxis; // Partial<SceneAxis>
            public object yaxis; // Partial<SceneAxis>
            public object zaxis; // Partial<SceneAxis>
            public dynamic dragmode;
            public dynamic hovermode;
            public dynamic annotations; // Partial<Annotations> | Array<Partial<Annotations>>
            public bool captureevents;
        }
        [ObjectLiteral]
        public partial class Domain
        {
            public float[] x;
            public float[] y;
        }
        [ObjectLiteral]
        public partial class Frame
        {
            /// An identifier that specifies the group to which the frame belongs,
            /// used by animate to select a subset of frames.
            public string group;
            /// A label by which to identify the frame
            public string name;
            /// A list of trace indices that identify the respective traces in the
            /// data attribute
            public float[] traces;
            /// The name of the frame into which this frame's properties are merged
            /// before applying. This is used to unify properties and avoid needing
            /// to specify the same values for the same properties in multiple frames.
            public string baseframe;
            /// A list of traces this frame modifies. The format is identical to the
            /// normal trace definition.
            public Data[] data;
            /// Layout properties which this frame modifies. The format is identical
            /// to the normal layout definition.
            public object layout; // Partial<Layout>
        }

        [ObjectLiteral]
        public partial class Transition
        {
            /// Sets the duration of the slider transition
            public float duration;
            /// Sets the easing function of the slider transition
            public Transition.Easing easing;
        }

        [ObjectLiteral]
        public partial class SliderStep
        {
            /// Determines whether or not this step is included in the slider.
            public bool visible;
            /// Sets the Plotly method to be called when the slider value is changed.
            /// If the `skip` method is used, the API slider will function as normal
            /// but will perform no API calls and will not bind automatically to state
            /// updates. This may be used to create a component interface and attach to
            /// slider events manually via JavaScript.
            public SliderStep.Method @method;
            /// Sets the arguments values to be passed to the Plotly
            /// method set in `method` on slide.
            public object[] args;
            /// Sets the text label to appear on the slider
            public string label;
            /// Sets the value of the slider step, used to refer to the step programatically.
            /// Defaults to the slider label if not provided.
            public string value;
            /// When true, the API method is executed. When false, all other behaviors are the same
            /// and command execution is skipped. This may be useful when hooking into, for example,
            /// the `plotly_sliderchange` method and executing the API command manually without losing
            /// the benefit of the slider automatically binding to the state of the plot through the
            /// specification of `method` and `args`.
            public bool execute;
        }

        [ObjectLiteral]
        public partial class Padding
        {
            /// The amount of padding (in px) along the top of the component.
            public float t;
            /// The amount of padding (in px) on the right side of the component.
            public float r;
            /// The amount of padding (in px) along the bottom of the component.
            public float b;
            /// The amount of padding (in px) on the left side of the component.
            public float l;
            public Padding.EditType editType;
        }
        [ObjectLiteral]
        public partial class Slider
        {
            /// Determines whether or not the slider is visible.
            public bool visible;
            /// Determines which button (by index starting from 0) is
            /// considered active.
            public float active;
            public object[] steps; // Array<Partial<SliderStep>>
                                   /// Determines whether this slider length
                                   /// is set in units of plot *fraction* or in *pixels.
                                   /// Use `len` to set the value.
            public SizeMode lenmode;
            /// Sets the length of the slider
            /// This measure excludes the padding of both ends.
            /// That is, the slider's length is this length minus the
            /// padding on both ends.
            public float len;
            /// Sets the x position (in normalized coordinates) of the slider.
            public float x;
            /// Sets the y position (in normalized coordinates) of the slider.
            public float y;
            /// Set the padding of the slider component along each side.
            public object pad; // Partial<Padding>
                               /// Sets the slider's horizontal position anchor.
                               /// This anchor binds the `x` position to the *left*, *center*
                               /// or *right* of the range selector.
            public XAnchorAuto xanchor;
            /// Sets the slider's vertical position anchor
            /// This anchor binds the `y` position to the *top*, *middle*
            /// or *bottom* of the range selector.
            public YAnchorAuto yanchor;
            public Transition transition;
            public SliderValue currentvalue;
            /// Sets the font of the slider step labels.
            public Font font;
            /// Sets the background color of the slider grip
            /// while dragging.
            public Color activebgcolor;
            /// Sets the background color of the slider.
            public Color bgcolor;
            /// Sets the color of the border enclosing the slider.
            public Color bordercolor;
            /// Sets the width (in px) of the border enclosing the slider.
            public float borderwidth;
            /// Sets the length in pixels of step tick marks
            public float ticklen;
            /// Sets the color of the border enclosing the slider.
            public Color tickcolor;
            /// Sets the tick width (in px).
            public float tickwidth;
            /// Sets the length in pixels of minor step tick marks
            public float minorticklen;
        }

        [ObjectLiteral]
        public partial class Gradient
        {
            public Gradient.Type @type;
            public Color color;
            public object typesrc; // any
            public object colorsrc; // any
        }

        [ObjectLiteral]
        public partial class TickFormatStops
        {
            public object[] dtickrange;
            public string value;
        }
        [ObjectLiteral]
        public partial class FrameAnimation
        {
            public float duration;
            public bool redraw;
        }
        [ObjectLiteral]
        public partial class Animation
        {
            public FrameAnimation frame;
            public Transition transition;
        }
        [ObjectLiteral]
        public partial class XBins
        {
            public dynamic start;
            public dynamic end;
            public dynamic size;
        }
        [ObjectLiteral]
        public partial class SliderValue
        {
            /// Shows the currently-selected value above the slider.
            public bool visible;
            /// The alignment of the value readout relative to the length of the slider.
            public XAnchor xanchor;
            /// The amount of space, in pixels, between the current value label
            /// and the slider.
            public float offset;
            /// When currentvalue.visible is true, this sets the prefix of the label.
            public string prefix;
            /// When currentvalue.visible is true, this sets the suffix of the label.
            public string suffix;
            /// Sets the font of the current value label text.
            public object font; // Partial<Font>

        }

    }
}