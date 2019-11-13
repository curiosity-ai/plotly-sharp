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

    public static partial class Geo
    {
        public static Box<IGeoProperty> domain(params Box<IDomainProperty>[] properties) => Interop.mkGeoAttr("domain", Bindings.flattenProperties(properties));
        public static Box<IGeoProperty> projection(params Box<IProjectionProperty>[] properties) => Interop.mkGeoAttr("projection", Bindings.flattenProperties(properties));
        public static Box<IGeoProperty> center(params Box<ICenterProperty>[] properties) => Interop.mkGeoAttr("center", Bindings.flattenProperties(properties));
        /// Sets whether or not the coastlines are drawn.
        public static Box<IGeoProperty> showcoastlines(bool val) => Interop.mkGeoAttr("showcoastlines", val);
        /// Sets the coastline color.
        public static Box<IGeoProperty> coastlinecolor(string val) => Interop.mkGeoAttr("coastlinecolor", val);
        /// Sets the coastline stroke width (in px).
        public static Box<IGeoProperty> coastlinewidth(int val) => Interop.mkGeoAttr("coastlinewidth", val);
        /// Sets the coastline stroke width (in px).
        public static Box<IGeoProperty> coastlinewidth(float val) => Interop.mkGeoAttr("coastlinewidth", val);
        /// Sets whether or not land masses are filled in color.
        public static Box<IGeoProperty> showland(bool val) => Interop.mkGeoAttr("showland", val);
        /// Sets the land mass color.
        public static Box<IGeoProperty> landcolor(string val) => Interop.mkGeoAttr("landcolor", val);
        /// Sets whether or not oceans are filled in color.
        public static Box<IGeoProperty> showocean(bool val) => Interop.mkGeoAttr("showocean", val);
        /// Sets the ocean color
        public static Box<IGeoProperty> oceancolor(string val) => Interop.mkGeoAttr("oceancolor", val);
        /// Sets whether or not lakes are drawn.
        public static Box<IGeoProperty> showlakes(bool val) => Interop.mkGeoAttr("showlakes", val);
        /// Sets the color of the lakes.
        public static Box<IGeoProperty> lakecolor(string val) => Interop.mkGeoAttr("lakecolor", val);
        /// Sets whether or not rivers are drawn.
        public static Box<IGeoProperty> showrivers(bool val) => Interop.mkGeoAttr("showrivers", val);
        /// Sets color of the rivers.
        public static Box<IGeoProperty> rivercolor(string val) => Interop.mkGeoAttr("rivercolor", val);
        /// Sets the stroke width (in px) of the rivers.
        public static Box<IGeoProperty> riverwidth(int val) => Interop.mkGeoAttr("riverwidth", val);
        /// Sets the stroke width (in px) of the rivers.
        public static Box<IGeoProperty> riverwidth(float val) => Interop.mkGeoAttr("riverwidth", val);
        /// Sets whether or not country boundaries are drawn.
        public static Box<IGeoProperty> showcountries(bool val) => Interop.mkGeoAttr("showcountries", val);
        /// Sets line color of the country boundaries.
        public static Box<IGeoProperty> countrycolor(string val) => Interop.mkGeoAttr("countrycolor", val);
        /// Sets line width (in px) of the country boundaries.
        public static Box<IGeoProperty> countrywidth(int val) => Interop.mkGeoAttr("countrywidth", val);
        /// Sets line width (in px) of the country boundaries.
        public static Box<IGeoProperty> countrywidth(float val) => Interop.mkGeoAttr("countrywidth", val);
        /// Sets whether or not boundaries of subunits within countries (e.g. states, provinces) are drawn.
        public static Box<IGeoProperty> showsubunits(bool val) => Interop.mkGeoAttr("showsubunits", val);
        /// Sets the color of the subunits boundaries.
        public static Box<IGeoProperty> subunitcolor(string val) => Interop.mkGeoAttr("subunitcolor", val);
        /// Sets the stroke width (in px) of the subunits boundaries.
        public static Box<IGeoProperty> subunitwidth(int val) => Interop.mkGeoAttr("subunitwidth", val);
        /// Sets the stroke width (in px) of the subunits boundaries.
        public static Box<IGeoProperty> subunitwidth(float val) => Interop.mkGeoAttr("subunitwidth", val);
        /// Sets whether or not a frame is drawn around the map.
        public static Box<IGeoProperty> showframe(bool val) => Interop.mkGeoAttr("showframe", val);
        /// Sets the color the frame.
        public static Box<IGeoProperty> framecolor(string val) => Interop.mkGeoAttr("framecolor", val);
        /// Sets the stroke width (in px) of the frame.
        public static Box<IGeoProperty> framewidth(int val) => Interop.mkGeoAttr("framewidth", val);
        /// Sets the stroke width (in px) of the frame.
        public static Box<IGeoProperty> framewidth(float val) => Interop.mkGeoAttr("framewidth", val);
        /// Set the background color of the map
        public static Box<IGeoProperty> bgcolor(string val) => Interop.mkGeoAttr("bgcolor", val);
        public static Box<IGeoProperty> lonaxis(params Box<ILonaxisProperty>[] properties) => Interop.mkGeoAttr("lonaxis", Bindings.flattenProperties(properties));
        public static Box<IGeoProperty> lataxis(params Box<ILataxisProperty>[] properties) => Interop.mkGeoAttr("lataxis", Bindings.flattenProperties(properties));
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        public static Box<IGeoProperty> uirevision(bool val) => Interop.mkGeoAttr("uirevision", val);
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        public static Box<IGeoProperty> uirevision(params bool[] values) => Interop.mkGeoAttr("uirevision", values);
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        public static Box<IGeoProperty> uirevision(System.DateTime val) => Interop.mkGeoAttr("uirevision", val);
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        public static Box<IGeoProperty> uirevision(params System.DateTime[] values) => Interop.mkGeoAttr("uirevision", values);
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        public static Box<IGeoProperty> uirevision(int val) => Interop.mkGeoAttr("uirevision", val);
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        public static Box<IGeoProperty> uirevision(params int[] values) => Interop.mkGeoAttr("uirevision", values);
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        public static Box<IGeoProperty> uirevision(float val) => Interop.mkGeoAttr("uirevision", val);
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        public static Box<IGeoProperty> uirevision(params float[] values) => Interop.mkGeoAttr("uirevision", values);
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        public static Box<IGeoProperty> uirevision(string val) => Interop.mkGeoAttr("uirevision", val);
        /// Controls persistence of user-driven changes in the view (projection and center). Defaults to `layout.uirevision`.
        public static Box<IGeoProperty> uirevision(params string[] values) => Interop.mkGeoAttr("uirevision", values);
    }

    public static partial class Geo
    {
        /// Sets the resolution of the base layers. The values have units of km/mm e.g. 110 corresponds to a scale ratio of 1:110,000,000.
        public static partial class Resolution
        {
            public static Box<IGeoProperty> _110() => Interop.mkGeoAttr("resolution", "110");
            public static Box<IGeoProperty> _50() => Interop.mkGeoAttr("resolution", "50");
        }

        /// Set the scope of the map.
        public static partial class Scope
        {
            public static Box<IGeoProperty> africa() => Interop.mkGeoAttr("scope", "africa");
            public static Box<IGeoProperty> asia() => Interop.mkGeoAttr("scope", "asia");
            public static Box<IGeoProperty> europe() => Interop.mkGeoAttr("scope", "europe");
            public static Box<IGeoProperty> northAmerica() => Interop.mkGeoAttr("scope", "north america");
            public static Box<IGeoProperty> southAmerica() => Interop.mkGeoAttr("scope", "south america");
            public static Box<IGeoProperty> usa() => Interop.mkGeoAttr("scope", "usa");
            public static Box<IGeoProperty> world() => Interop.mkGeoAttr("scope", "world");
        }
    }
}