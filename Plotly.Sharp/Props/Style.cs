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

    public static partial class Style
    {
        /// The group value which receives these styles.
        public static Box<IStyleProperty> target(string val) => Interop.mkStyleAttr("target", val);
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IScatterProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IBarProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IBoxProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IHeatmapProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IHistogramProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IHistogram2dProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IHistogram2dcontourProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IContourProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IScatterternaryProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IViolinProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IFunnelProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IWaterfallProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IImageProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IPieProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<ISunburstProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<ITreemapProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IFunnelareaProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IScatter3dProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<ISurfaceProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IIsosurfaceProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IVolumeProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IMesh3dProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IConeProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IStreamtubeProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IScattergeoProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IChoroplethProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IScatterglProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<ISplomProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IPointcloudProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IHeatmapglProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IParcoordsProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IParcatsProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IScattermapboxProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IChoroplethmapboxProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IDensitymapboxProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<ISankeyProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IIndicatorProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<ITableProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<ICarpetProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IScattercarpetProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IContourcarpetProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IOhlcProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<ICandlestickProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IScatterpolarProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IScatterpolarglProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IBarpolarProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params Box<IAreaProperty>[] properties) => Interop.mkStyleAttr("value", Bindings.flattenProperties(properties));
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(bool val) => Interop.mkStyleAttr("value", val);
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params bool[] values) => Interop.mkStyleAttr("value", values);
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(System.DateTime val) => Interop.mkStyleAttr("value", val);
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params System.DateTime[] values) => Interop.mkStyleAttr("value", values);
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(int val) => Interop.mkStyleAttr("value", val);
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params int[] values) => Interop.mkStyleAttr("value", values);
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(float val) => Interop.mkStyleAttr("value", val);
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params float[] values) => Interop.mkStyleAttr("value", values);
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(string val) => Interop.mkStyleAttr("value", val);
        /// Sets each group styles. For example, with `groups` set to *['a', 'b', 'a', 'b']* and `styles` set to *[{target: 'a', value: { marker: { color: 'red' } }}] marker points in group *'a'* will be drawn in red.
        public static Box<IStyleProperty> value(params string[] values) => Interop.mkStyleAttr("value", values);
    }
}