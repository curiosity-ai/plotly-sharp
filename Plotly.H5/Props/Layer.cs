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

    public static partial class Layer
    {
        /// Determines whether this layer is displayed
        public static Box<ILayerProperty> visible(bool val) => Interop.mkLayerAttr("visible", val);
        /// Sets the source data for this layer (mapbox.layer.source). When `sourcetype` is set to *geojson*, `source` can be a URL to a GeoJSON or a GeoJSON object. When `sourcetype` is set to *vector* or *raster*, `source` can be a URL or an array of tile URLs. When `sourcetype` is set to *image*, `source` can be a URL to an image.
        public static Box<ILayerProperty> source(bool val) => Interop.mkLayerAttr("source", val);
        /// Sets the source data for this layer (mapbox.layer.source). When `sourcetype` is set to *geojson*, `source` can be a URL to a GeoJSON or a GeoJSON object. When `sourcetype` is set to *vector* or *raster*, `source` can be a URL or an array of tile URLs. When `sourcetype` is set to *image*, `source` can be a URL to an image.
        public static Box<ILayerProperty> source(params bool[] values) => Interop.mkLayerAttr("source", values);
        /// Sets the source data for this layer (mapbox.layer.source). When `sourcetype` is set to *geojson*, `source` can be a URL to a GeoJSON or a GeoJSON object. When `sourcetype` is set to *vector* or *raster*, `source` can be a URL or an array of tile URLs. When `sourcetype` is set to *image*, `source` can be a URL to an image.
        public static Box<ILayerProperty> source(System.DateTime val) => Interop.mkLayerAttr("source", val);
        /// Sets the source data for this layer (mapbox.layer.source). When `sourcetype` is set to *geojson*, `source` can be a URL to a GeoJSON or a GeoJSON object. When `sourcetype` is set to *vector* or *raster*, `source` can be a URL or an array of tile URLs. When `sourcetype` is set to *image*, `source` can be a URL to an image.
        public static Box<ILayerProperty> source(params System.DateTime[] values) => Interop.mkLayerAttr("source", values);
        /// Sets the source data for this layer (mapbox.layer.source). When `sourcetype` is set to *geojson*, `source` can be a URL to a GeoJSON or a GeoJSON object. When `sourcetype` is set to *vector* or *raster*, `source` can be a URL or an array of tile URLs. When `sourcetype` is set to *image*, `source` can be a URL to an image.
        public static Box<ILayerProperty> source(int val) => Interop.mkLayerAttr("source", val);
        /// Sets the source data for this layer (mapbox.layer.source). When `sourcetype` is set to *geojson*, `source` can be a URL to a GeoJSON or a GeoJSON object. When `sourcetype` is set to *vector* or *raster*, `source` can be a URL or an array of tile URLs. When `sourcetype` is set to *image*, `source` can be a URL to an image.
        public static Box<ILayerProperty> source(params int[] values) => Interop.mkLayerAttr("source", values);
        /// Sets the source data for this layer (mapbox.layer.source). When `sourcetype` is set to *geojson*, `source` can be a URL to a GeoJSON or a GeoJSON object. When `sourcetype` is set to *vector* or *raster*, `source` can be a URL or an array of tile URLs. When `sourcetype` is set to *image*, `source` can be a URL to an image.
        public static Box<ILayerProperty> source(float val) => Interop.mkLayerAttr("source", val);
        /// Sets the source data for this layer (mapbox.layer.source). When `sourcetype` is set to *geojson*, `source` can be a URL to a GeoJSON or a GeoJSON object. When `sourcetype` is set to *vector* or *raster*, `source` can be a URL or an array of tile URLs. When `sourcetype` is set to *image*, `source` can be a URL to an image.
        public static Box<ILayerProperty> source(params float[] values) => Interop.mkLayerAttr("source", values);
        /// Sets the source data for this layer (mapbox.layer.source). When `sourcetype` is set to *geojson*, `source` can be a URL to a GeoJSON or a GeoJSON object. When `sourcetype` is set to *vector* or *raster*, `source` can be a URL or an array of tile URLs. When `sourcetype` is set to *image*, `source` can be a URL to an image.
        public static Box<ILayerProperty> source(string val) => Interop.mkLayerAttr("source", val);
        /// Sets the source data for this layer (mapbox.layer.source). When `sourcetype` is set to *geojson*, `source` can be a URL to a GeoJSON or a GeoJSON object. When `sourcetype` is set to *vector* or *raster*, `source` can be a URL or an array of tile URLs. When `sourcetype` is set to *image*, `source` can be a URL to an image.
        public static Box<ILayerProperty> source(params string[] values) => Interop.mkLayerAttr("source", values);
        /// Specifies the layer to use from a vector tile source (mapbox.layer.source-layer). Required for *vector* source type that supports multiple layers.
        public static Box<ILayerProperty> sourcelayer(string val) => Interop.mkLayerAttr("sourcelayer", val);
        /// Sets the attribution for this source.
        public static Box<ILayerProperty> sourceattribution(string val) => Interop.mkLayerAttr("sourceattribution", val);
        /// Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`.
        public static Box<ILayerProperty> coordinates(bool val) => Interop.mkLayerAttr("coordinates", val);
        /// Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`.
        public static Box<ILayerProperty> coordinates(params bool[] values) => Interop.mkLayerAttr("coordinates", values);
        /// Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`.
        public static Box<ILayerProperty> coordinates(System.DateTime val) => Interop.mkLayerAttr("coordinates", val);
        /// Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`.
        public static Box<ILayerProperty> coordinates(params System.DateTime[] values) => Interop.mkLayerAttr("coordinates", values);
        /// Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`.
        public static Box<ILayerProperty> coordinates(int val) => Interop.mkLayerAttr("coordinates", val);
        /// Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`.
        public static Box<ILayerProperty> coordinates(params int[] values) => Interop.mkLayerAttr("coordinates", values);
        /// Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`.
        public static Box<ILayerProperty> coordinates(float val) => Interop.mkLayerAttr("coordinates", val);
        /// Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`.
        public static Box<ILayerProperty> coordinates(params float[] values) => Interop.mkLayerAttr("coordinates", values);
        /// Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`.
        public static Box<ILayerProperty> coordinates(string val) => Interop.mkLayerAttr("coordinates", val);
        /// Sets the coordinates array contains [longitude, latitude] pairs for the image corners listed in clockwise order: top left, top right, bottom right, bottom left. Only has an effect for *image* `sourcetype`.
        public static Box<ILayerProperty> coordinates(params string[] values) => Interop.mkLayerAttr("coordinates", values);
        /// Determines if the layer will be inserted before the layer with the specified ID. If omitted or set to '', the layer will be inserted above every existing layer.
        public static Box<ILayerProperty> below(string val) => Interop.mkLayerAttr("below", val);
        /// Sets the primary layer color. If `type` is *circle*, color corresponds to the circle color (mapbox.layer.paint.circle-color) If `type` is *line*, color corresponds to the line color (mapbox.layer.paint.line-color) If `type` is *fill*, color corresponds to the fill color (mapbox.layer.paint.fill-color) If `type` is *symbol*, color corresponds to the icon color (mapbox.layer.paint.icon-color)
        public static Box<ILayerProperty> color(string val) => Interop.mkLayerAttr("color", val);
        /// Sets the opacity of the layer. If `type` is *circle*, opacity corresponds to the circle opacity (mapbox.layer.paint.circle-opacity) If `type` is *line*, opacity corresponds to the line opacity (mapbox.layer.paint.line-opacity) If `type` is *fill*, opacity corresponds to the fill opacity (mapbox.layer.paint.fill-opacity) If `type` is *symbol*, opacity corresponds to the icon/text opacity (mapbox.layer.paint.text-opacity)
        public static Box<ILayerProperty> opacity(int val) => Interop.mkLayerAttr("opacity", val);
        /// Sets the opacity of the layer. If `type` is *circle*, opacity corresponds to the circle opacity (mapbox.layer.paint.circle-opacity) If `type` is *line*, opacity corresponds to the line opacity (mapbox.layer.paint.line-opacity) If `type` is *fill*, opacity corresponds to the fill opacity (mapbox.layer.paint.fill-opacity) If `type` is *symbol*, opacity corresponds to the icon/text opacity (mapbox.layer.paint.text-opacity)
        public static Box<ILayerProperty> opacity(float val) => Interop.mkLayerAttr("opacity", val);
        /// Sets the minimum zoom level (mapbox.layer.minzoom). At zoom levels less than the minzoom, the layer will be hidden.
        public static Box<ILayerProperty> minzoom(int val) => Interop.mkLayerAttr("minzoom", val);
        /// Sets the minimum zoom level (mapbox.layer.minzoom). At zoom levels less than the minzoom, the layer will be hidden.
        public static Box<ILayerProperty> minzoom(float val) => Interop.mkLayerAttr("minzoom", val);
        /// Sets the maximum zoom level (mapbox.layer.maxzoom). At zoom levels equal to or greater than the maxzoom, the layer will be hidden.
        public static Box<ILayerProperty> maxzoom(int val) => Interop.mkLayerAttr("maxzoom", val);
        /// Sets the maximum zoom level (mapbox.layer.maxzoom). At zoom levels equal to or greater than the maxzoom, the layer will be hidden.
        public static Box<ILayerProperty> maxzoom(float val) => Interop.mkLayerAttr("maxzoom", val);
        public static Box<ILayerProperty> circle(params Box<ICircleProperty>[] properties) => Interop.mkLayerAttr("circle", Bindings.flattenProperties(properties));
        public static Box<ILayerProperty> line(params Box<ILineProperty>[] properties) => Interop.mkLayerAttr("line", Bindings.flattenProperties(properties));
        public static Box<ILayerProperty> fill(params Box<IFillProperty>[] properties) => Interop.mkLayerAttr("fill", Bindings.flattenProperties(properties));
        public static Box<ILayerProperty> symbol(params Box<ISymbolProperty>[] properties) => Interop.mkLayerAttr("symbol", Bindings.flattenProperties(properties));
        /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
        public static Box<ILayerProperty> name(string val) => Interop.mkLayerAttr("name", val);
        /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
        public static Box<ILayerProperty> templateitemname(string val) => Interop.mkLayerAttr("templateitemname", val);
    }

    public static partial class Layer
    {
        /// Sets the source type for this layer, that is the type of the layer data.
        public static partial class Sourcetype
        {
            public static Box<ILayerProperty> geojson() => Interop.mkLayerAttr("sourcetype", "geojson");
            public static Box<ILayerProperty> image() => Interop.mkLayerAttr("sourcetype", "image");
            public static Box<ILayerProperty> raster() => Interop.mkLayerAttr("sourcetype", "raster");
            public static Box<ILayerProperty> vector() => Interop.mkLayerAttr("sourcetype", "vector");
        }

        /// Sets the layer type, that is the how the layer data set in `source` will be rendered With `sourcetype` set to *geojson*, the following values are allowed: *circle*, *line*, *fill* and *symbol*. but note that *line* and *fill* are not compatible with Point GeoJSON geometries. With `sourcetype` set to *vector*, the following values are allowed:  *circle*, *line*, *fill* and *symbol*. With `sourcetype` set to *raster* or `*image*`, only the *raster* value is allowed.
        public static partial class _type
        {
            public static Box<ILayerProperty> circle() => Interop.mkLayerAttr("type", "circle");
            public static Box<ILayerProperty> fill() => Interop.mkLayerAttr("type", "fill");
            public static Box<ILayerProperty> line() => Interop.mkLayerAttr("type", "line");
            public static Box<ILayerProperty> raster() => Interop.mkLayerAttr("type", "raster");
            public static Box<ILayerProperty> symbol() => Interop.mkLayerAttr("type", "symbol");
        }
    }
}