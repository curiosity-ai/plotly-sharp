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

    public static partial class Config
    {
        /// Determines whether the graphs are interactive or not. If *false*, no interactivity, for export or image generation.
        public static Box<IConfigProperty> staticPlot(bool val) => Interop.mkConfigAttr("staticPlot", val);
        /// Sets base URL for the 'Edit in Chart Studio' (aka sendDataToCloud) mode bar button and the showLink/sendData on-graph link
        public static Box<IConfigProperty> plotlyServerURL(string val) => Interop.mkConfigAttr("plotlyServerURL", val);
        /// Determines whether the graph is editable or not. Sets all pieces of `edits` unless a separate `edits` config item overrides individual parts.
        public static Box<IConfigProperty> editable(bool val) => Interop.mkConfigAttr("editable", val);
        public static Box<IConfigProperty> edits(params Box<IEditsProperty>[] properties) => Interop.mkConfigAttr("edits", Bindings.flattenProperties(properties));
        /// Determines whether the graphs are plotted with respect to layout.autosize:true and infer its container size.
        public static Box<IConfigProperty> autosizable(bool val) => Interop.mkConfigAttr("autosizable", val);
        /// Determines whether to change the layout size when window is resized. In v2, this option will be removed and will always be true.
        public static Box<IConfigProperty> responsive(bool val) => Interop.mkConfigAttr("responsive", val);
        /// When `layout.autosize` is turned on, determines whether the graph fills the container (the default) or the screen (if set to *true*).
        public static Box<IConfigProperty> fillFrame(bool val) => Interop.mkConfigAttr("fillFrame", val);
        /// When `layout.autosize` is turned on, set the frame margins in fraction of the graph size.
        public static Box<IConfigProperty> frameMargins(int val) => Interop.mkConfigAttr("frameMargins", val);
        /// When `layout.autosize` is turned on, set the frame margins in fraction of the graph size.
        public static Box<IConfigProperty> frameMargins(float val) => Interop.mkConfigAttr("frameMargins", val);
        /// Determines whether mouse wheel or two-finger scroll zooms is enable. Turned on by default for gl3d, geo and mapbox subplots (as these subplot types do not have zoombox via pan), but turned off by default for cartesian subplots. Set `scrollZoom` to *false* to disable scrolling for all subplots.
        public static Box<IConfigProperty> scrollZoom(params Box<IConfigProperty>[] properties) => Interop.mkConfigAttr("scrollZoom", Bindings.joinEnumProperties(properties));
        /// Sets the delay for registering a double-click in ms. This is the time interval (in ms) between first mousedown and 2nd mouseup to constitute a double-click. This setting propagates to all on-subplot double clicks (except for geo and mapbox) and on-legend double clicks.
        public static Box<IConfigProperty> doubleClickDelay(int val) => Interop.mkConfigAttr("doubleClickDelay", val);
        /// Sets the delay for registering a double-click in ms. This is the time interval (in ms) between first mousedown and 2nd mouseup to constitute a double-click. This setting propagates to all on-subplot double clicks (except for geo and mapbox) and on-legend double clicks.
        public static Box<IConfigProperty> doubleClickDelay(float val) => Interop.mkConfigAttr("doubleClickDelay", val);
        /// Set to *false* to omit cartesian axis pan/zoom drag handles.
        public static Box<IConfigProperty> showAxisDragHandles(bool val) => Interop.mkConfigAttr("showAxisDragHandles", val);
        /// Set to *false* to omit direct range entry at the pan/zoom drag points, note that `showAxisDragHandles` must be enabled to have an effect.
        public static Box<IConfigProperty> showAxisRangeEntryBoxes(bool val) => Interop.mkConfigAttr("showAxisRangeEntryBoxes", val);
        /// Determines whether or not tips are shown while interacting with the resulting graphs.
        public static Box<IConfigProperty> showTips(bool val) => Interop.mkConfigAttr("showTips", val);
        /// Determines whether a link to plot.ly is displayed at the bottom right corner of resulting graphs. Use with `sendData` and `linkText`.
        public static Box<IConfigProperty> showLink(bool val) => Interop.mkConfigAttr("showLink", val);
        /// Sets the text appearing in the `showLink` link.
        public static Box<IConfigProperty> linkText(string val) => Interop.mkConfigAttr("linkText", val);
        /// If *showLink* is true, does it contain data just link to a plot.ly file?
        public static Box<IConfigProperty> sendData(bool val) => Interop.mkConfigAttr("sendData", val);
        /// Adds a source-displaying function to show sources on the resulting graphs.
        public static Box<IConfigProperty> showSources(bool val) => Interop.mkConfigAttr("showSources", val);
        /// Adds a source-displaying function to show sources on the resulting graphs.
        public static Box<IConfigProperty> showSources(params bool[] values) => Interop.mkConfigAttr("showSources", values);
        /// Adds a source-displaying function to show sources on the resulting graphs.
        public static Box<IConfigProperty> showSources(System.DateTime val) => Interop.mkConfigAttr("showSources", val);
        /// Adds a source-displaying function to show sources on the resulting graphs.
        public static Box<IConfigProperty> showSources(params System.DateTime[] values) => Interop.mkConfigAttr("showSources", values);
        /// Adds a source-displaying function to show sources on the resulting graphs.
        public static Box<IConfigProperty> showSources(int val) => Interop.mkConfigAttr("showSources", val);
        /// Adds a source-displaying function to show sources on the resulting graphs.
        public static Box<IConfigProperty> showSources(params int[] values) => Interop.mkConfigAttr("showSources", values);
        /// Adds a source-displaying function to show sources on the resulting graphs.
        public static Box<IConfigProperty> showSources(float val) => Interop.mkConfigAttr("showSources", val);
        /// Adds a source-displaying function to show sources on the resulting graphs.
        public static Box<IConfigProperty> showSources(params float[] values) => Interop.mkConfigAttr("showSources", values);
        /// Adds a source-displaying function to show sources on the resulting graphs.
        public static Box<IConfigProperty> showSources(string val) => Interop.mkConfigAttr("showSources", val);
        /// Adds a source-displaying function to show sources on the resulting graphs.
        public static Box<IConfigProperty> showSources(params string[] values) => Interop.mkConfigAttr("showSources", values);
        /// Should we include a ModeBar button, labeled \"Edit in Chart Studio\", that sends this chart to plot.ly or another plotly server as specified by `plotlyServerURL` for editing, export, etc? Prior to version 1.43.0 this button was included by default, now it is opt-in using this flag. Note that this button can (depending on `plotlyServerURL`) send your data to an external server. However that server does not persist your data until you arrive at the Chart Studio and explicitly click \"Save\".
        public static Box<IConfigProperty> showSendToCloud(bool val) => Interop.mkConfigAttr("showSendToCloud", val);
        /// Same as `showSendToCloud`, but use a pencil icon instead of a floppy-disk. Note that if both `showSendToCloud` and `showEditInChartStudio` are turned, only `showEditInChartStudio` will be honored.
        public static Box<IConfigProperty> showEditInChartStudio(bool val) => Interop.mkConfigAttr("showEditInChartStudio", val);
        /// Remove mode bar buttons by name. See ./components/modebar/buttons.js for the list of names.
        public static Box<IConfigProperty> modeBarButtonsToRemove(bool val) => Interop.mkConfigAttr("modeBarButtonsToRemove", val);
        /// Remove mode bar buttons by name. See ./components/modebar/buttons.js for the list of names.
        public static Box<IConfigProperty> modeBarButtonsToRemove(params bool[] values) => Interop.mkConfigAttr("modeBarButtonsToRemove", values);
        /// Remove mode bar buttons by name. See ./components/modebar/buttons.js for the list of names.
        public static Box<IConfigProperty> modeBarButtonsToRemove(System.DateTime val) => Interop.mkConfigAttr("modeBarButtonsToRemove", val);
        /// Remove mode bar buttons by name. See ./components/modebar/buttons.js for the list of names.
        public static Box<IConfigProperty> modeBarButtonsToRemove(params System.DateTime[] values) => Interop.mkConfigAttr("modeBarButtonsToRemove", values);
        /// Remove mode bar buttons by name. See ./components/modebar/buttons.js for the list of names.
        public static Box<IConfigProperty> modeBarButtonsToRemove(int val) => Interop.mkConfigAttr("modeBarButtonsToRemove", val);
        /// Remove mode bar buttons by name. See ./components/modebar/buttons.js for the list of names.
        public static Box<IConfigProperty> modeBarButtonsToRemove(params int[] values) => Interop.mkConfigAttr("modeBarButtonsToRemove", values);
        /// Remove mode bar buttons by name. See ./components/modebar/buttons.js for the list of names.
        public static Box<IConfigProperty> modeBarButtonsToRemove(float val) => Interop.mkConfigAttr("modeBarButtonsToRemove", val);
        /// Remove mode bar buttons by name. See ./components/modebar/buttons.js for the list of names.
        public static Box<IConfigProperty> modeBarButtonsToRemove(params float[] values) => Interop.mkConfigAttr("modeBarButtonsToRemove", values);
        /// Remove mode bar buttons by name. See ./components/modebar/buttons.js for the list of names.
        public static Box<IConfigProperty> modeBarButtonsToRemove(string val) => Interop.mkConfigAttr("modeBarButtonsToRemove", val);
        /// Remove mode bar buttons by name. See ./components/modebar/buttons.js for the list of names.
        public static Box<IConfigProperty> modeBarButtonsToRemove(params string[] values) => Interop.mkConfigAttr("modeBarButtonsToRemove", values);
        /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments.
        public static Box<IConfigProperty> modeBarButtonsToAdd(bool val) => Interop.mkConfigAttr("modeBarButtonsToAdd", val);
        /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments.
        public static Box<IConfigProperty> modeBarButtonsToAdd(params bool[] values) => Interop.mkConfigAttr("modeBarButtonsToAdd", values);
        /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments.
        public static Box<IConfigProperty> modeBarButtonsToAdd(System.DateTime val) => Interop.mkConfigAttr("modeBarButtonsToAdd", val);
        /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments.
        public static Box<IConfigProperty> modeBarButtonsToAdd(params System.DateTime[] values) => Interop.mkConfigAttr("modeBarButtonsToAdd", values);
        /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments.
        public static Box<IConfigProperty> modeBarButtonsToAdd(int val) => Interop.mkConfigAttr("modeBarButtonsToAdd", val);
        /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments.
        public static Box<IConfigProperty> modeBarButtonsToAdd(params int[] values) => Interop.mkConfigAttr("modeBarButtonsToAdd", values);
        /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments.
        public static Box<IConfigProperty> modeBarButtonsToAdd(float val) => Interop.mkConfigAttr("modeBarButtonsToAdd", val);
        /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments.
        public static Box<IConfigProperty> modeBarButtonsToAdd(params float[] values) => Interop.mkConfigAttr("modeBarButtonsToAdd", values);
        /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments.
        public static Box<IConfigProperty> modeBarButtonsToAdd(string val) => Interop.mkConfigAttr("modeBarButtonsToAdd", val);
        /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments.
        public static Box<IConfigProperty> modeBarButtonsToAdd(params string[] values) => Interop.mkConfigAttr("modeBarButtonsToAdd", values);
        /// Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info.
        public static Box<IConfigProperty> modeBarButtons(bool val) => Interop.mkConfigAttr("modeBarButtons", val);
        /// Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info.
        public static Box<IConfigProperty> modeBarButtons(params bool[] values) => Interop.mkConfigAttr("modeBarButtons", values);
        /// Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info.
        public static Box<IConfigProperty> modeBarButtons(System.DateTime val) => Interop.mkConfigAttr("modeBarButtons", val);
        /// Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info.
        public static Box<IConfigProperty> modeBarButtons(params System.DateTime[] values) => Interop.mkConfigAttr("modeBarButtons", values);
        /// Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info.
        public static Box<IConfigProperty> modeBarButtons(int val) => Interop.mkConfigAttr("modeBarButtons", val);
        /// Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info.
        public static Box<IConfigProperty> modeBarButtons(params int[] values) => Interop.mkConfigAttr("modeBarButtons", values);
        /// Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info.
        public static Box<IConfigProperty> modeBarButtons(float val) => Interop.mkConfigAttr("modeBarButtons", val);
        /// Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info.
        public static Box<IConfigProperty> modeBarButtons(params float[] values) => Interop.mkConfigAttr("modeBarButtons", values);
        /// Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info.
        public static Box<IConfigProperty> modeBarButtons(string val) => Interop.mkConfigAttr("modeBarButtons", val);
        /// Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info.
        public static Box<IConfigProperty> modeBarButtons(params string[] values) => Interop.mkConfigAttr("modeBarButtons", values);
        /// Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js
        public static Box<IConfigProperty> toImageButtonOptions(bool val) => Interop.mkConfigAttr("toImageButtonOptions", val);
        /// Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js
        public static Box<IConfigProperty> toImageButtonOptions(params bool[] values) => Interop.mkConfigAttr("toImageButtonOptions", values);
        /// Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js
        public static Box<IConfigProperty> toImageButtonOptions(System.DateTime val) => Interop.mkConfigAttr("toImageButtonOptions", val);
        /// Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js
        public static Box<IConfigProperty> toImageButtonOptions(params System.DateTime[] values) => Interop.mkConfigAttr("toImageButtonOptions", values);
        /// Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js
        public static Box<IConfigProperty> toImageButtonOptions(int val) => Interop.mkConfigAttr("toImageButtonOptions", val);
        /// Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js
        public static Box<IConfigProperty> toImageButtonOptions(params int[] values) => Interop.mkConfigAttr("toImageButtonOptions", values);
        /// Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js
        public static Box<IConfigProperty> toImageButtonOptions(float val) => Interop.mkConfigAttr("toImageButtonOptions", val);
        /// Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js
        public static Box<IConfigProperty> toImageButtonOptions(params float[] values) => Interop.mkConfigAttr("toImageButtonOptions", values);
        /// Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js
        public static Box<IConfigProperty> toImageButtonOptions(string val) => Interop.mkConfigAttr("toImageButtonOptions", val);
        /// Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js
        public static Box<IConfigProperty> toImageButtonOptions(params string[] values) => Interop.mkConfigAttr("toImageButtonOptions", values);
        /// Determines whether or not the plotly logo is displayed on the end of the mode bar.
        public static Box<IConfigProperty> displaylogo(bool val) => Interop.mkConfigAttr("displaylogo", val);
        /// watermark the images with the company's logo
        public static Box<IConfigProperty> watermark(bool val) => Interop.mkConfigAttr("watermark", val);
        /// Set the pixel ratio during WebGL image export. This config option was formerly named `plot3dPixelRatio` which is now deprecated.
        public static Box<IConfigProperty> plotGlPixelRatio(int val) => Interop.mkConfigAttr("plotGlPixelRatio", val);
        /// Set the pixel ratio during WebGL image export. This config option was formerly named `plot3dPixelRatio` which is now deprecated.
        public static Box<IConfigProperty> plotGlPixelRatio(float val) => Interop.mkConfigAttr("plotGlPixelRatio", val);
        /// Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it.
        public static Box<IConfigProperty> setBackground(bool val) => Interop.mkConfigAttr("setBackground", val);
        /// Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it.
        public static Box<IConfigProperty> setBackground(params bool[] values) => Interop.mkConfigAttr("setBackground", values);
        /// Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it.
        public static Box<IConfigProperty> setBackground(System.DateTime val) => Interop.mkConfigAttr("setBackground", val);
        /// Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it.
        public static Box<IConfigProperty> setBackground(params System.DateTime[] values) => Interop.mkConfigAttr("setBackground", values);
        /// Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it.
        public static Box<IConfigProperty> setBackground(int val) => Interop.mkConfigAttr("setBackground", val);
        /// Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it.
        public static Box<IConfigProperty> setBackground(params int[] values) => Interop.mkConfigAttr("setBackground", values);
        /// Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it.
        public static Box<IConfigProperty> setBackground(float val) => Interop.mkConfigAttr("setBackground", val);
        /// Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it.
        public static Box<IConfigProperty> setBackground(params float[] values) => Interop.mkConfigAttr("setBackground", values);
        /// Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it.
        public static Box<IConfigProperty> setBackground(string val) => Interop.mkConfigAttr("setBackground", val);
        /// Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it.
        public static Box<IConfigProperty> setBackground(params string[] values) => Interop.mkConfigAttr("setBackground", values);
        /// Set the URL to topojson used in geo charts. By default, the topojson files are fetched from cdn.plot.ly. For example, set this option to: <path-to-plotly.js>/dist/topojson/ to render geographical feature using the topojson files that ship with the plotly.js module.
        public static Box<IConfigProperty> topojsonURL(string val) => Interop.mkConfigAttr("topojsonURL", val);
        /// Mapbox access token (required to plot mapbox trace types) If using an Mapbox Atlas server, set this option to '' so that plotly.js won't attempt to authenticate to the public Mapbox server.
        public static Box<IConfigProperty> mapboxAccessToken(string val) => Interop.mkConfigAttr("mapboxAccessToken", val);
        /// Turn all console logging on or off (errors will be thrown) This should ONLY be set via Plotly.setPlotConfig Available levels: 0: no logs 1: warnings and errors, but not informational messages 2: verbose logs
        public static Box<IConfigProperty> logging(bool val) => Interop.mkConfigAttr("logging", val);
        /// Sets the length of the undo/redo queue.
        public static Box<IConfigProperty> queueLength(int val) => Interop.mkConfigAttr("queueLength", val);
        /// Set global transform to be applied to all traces with no specification needed
        public static Box<IConfigProperty> globalTransforms(bool val) => Interop.mkConfigAttr("globalTransforms", val);
        /// Set global transform to be applied to all traces with no specification needed
        public static Box<IConfigProperty> globalTransforms(params bool[] values) => Interop.mkConfigAttr("globalTransforms", values);
        /// Set global transform to be applied to all traces with no specification needed
        public static Box<IConfigProperty> globalTransforms(System.DateTime val) => Interop.mkConfigAttr("globalTransforms", val);
        /// Set global transform to be applied to all traces with no specification needed
        public static Box<IConfigProperty> globalTransforms(params System.DateTime[] values) => Interop.mkConfigAttr("globalTransforms", values);
        /// Set global transform to be applied to all traces with no specification needed
        public static Box<IConfigProperty> globalTransforms(int val) => Interop.mkConfigAttr("globalTransforms", val);
        /// Set global transform to be applied to all traces with no specification needed
        public static Box<IConfigProperty> globalTransforms(params int[] values) => Interop.mkConfigAttr("globalTransforms", values);
        /// Set global transform to be applied to all traces with no specification needed
        public static Box<IConfigProperty> globalTransforms(float val) => Interop.mkConfigAttr("globalTransforms", val);
        /// Set global transform to be applied to all traces with no specification needed
        public static Box<IConfigProperty> globalTransforms(params float[] values) => Interop.mkConfigAttr("globalTransforms", values);
        /// Set global transform to be applied to all traces with no specification needed
        public static Box<IConfigProperty> globalTransforms(string val) => Interop.mkConfigAttr("globalTransforms", val);
        /// Set global transform to be applied to all traces with no specification needed
        public static Box<IConfigProperty> globalTransforms(params string[] values) => Interop.mkConfigAttr("globalTransforms", values);
        /// Which localization should we use? Should be a string like 'en' or 'en-US'.
        public static Box<IConfigProperty> locale(string val) => Interop.mkConfigAttr("locale", val);
        /// Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats.
        public static Box<IConfigProperty> locales(bool val) => Interop.mkConfigAttr("locales", val);
        /// Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats.
        public static Box<IConfigProperty> locales(params bool[] values) => Interop.mkConfigAttr("locales", values);
        /// Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats.
        public static Box<IConfigProperty> locales(System.DateTime val) => Interop.mkConfigAttr("locales", val);
        /// Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats.
        public static Box<IConfigProperty> locales(params System.DateTime[] values) => Interop.mkConfigAttr("locales", values);
        /// Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats.
        public static Box<IConfigProperty> locales(int val) => Interop.mkConfigAttr("locales", val);
        /// Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats.
        public static Box<IConfigProperty> locales(params int[] values) => Interop.mkConfigAttr("locales", values);
        /// Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats.
        public static Box<IConfigProperty> locales(float val) => Interop.mkConfigAttr("locales", val);
        /// Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats.
        public static Box<IConfigProperty> locales(params float[] values) => Interop.mkConfigAttr("locales", values);
        /// Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats.
        public static Box<IConfigProperty> locales(string val) => Interop.mkConfigAttr("locales", val);
        /// Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats.
        public static Box<IConfigProperty> locales(params string[] values) => Interop.mkConfigAttr("locales", values);
    }

    public static partial class Config
    {
        /// Determines whether mouse wheel or two-finger scroll zooms is enable. Turned on by default for gl3d, geo and mapbox subplots (as these subplot types do not have zoombox via pan), but turned off by default for cartesian subplots. Set `scrollZoom` to *false* to disable scrolling for all subplots.
        public static partial class ScrollZoom
        {
            public static Box<IConfigProperty> cartesian() => Interop.mkConfigAttr("scrollZoom", "cartesian");
            public static Box<IConfigProperty> _false() => Interop.mkConfigAttr("scrollZoom", false);
            public static Box<IConfigProperty> geo() => Interop.mkConfigAttr("scrollZoom", "geo");
            public static Box<IConfigProperty> gl3d() => Interop.mkConfigAttr("scrollZoom", "gl3d");
            public static Box<IConfigProperty> mapbox() => Interop.mkConfigAttr("scrollZoom", "mapbox");
            public static Box<IConfigProperty> _true() => Interop.mkConfigAttr("scrollZoom", true);
        }

        /// Sets the double click interaction mode. Has an effect only in cartesian plots. If *false*, double click is disable. If *reset*, double click resets the axis ranges to their initial values. If *autosize*, double click set the axis ranges to their autorange values. If *reset+autosize*, the odd double clicks resets the axis ranges to their initial values and even double clicks set the axis ranges to their autorange values.
        public static partial class DoubleClick
        {
            public static Box<IConfigProperty> autosize() => Interop.mkConfigAttr("doubleClick", "autosize");
            public static Box<IConfigProperty> reset() => Interop.mkConfigAttr("doubleClick", "reset");
            public static Box<IConfigProperty> resetAndAutosize() => Interop.mkConfigAttr("doubleClick", "reset+autosize");
            public static Box<IConfigProperty> _false() => Interop.mkConfigAttr("doubleClick", false);
        }

        /// Determines the mode bar display mode. If *true*, the mode bar is always visible. If *false*, the mode bar is always hidden. If *hover*, the mode bar is visible while the mouse cursor is on the graph container.
        public static partial class DisplayModeBar
        {
            public static Box<IConfigProperty> hover() => Interop.mkConfigAttr("displayModeBar", "hover");
            public static Box<IConfigProperty> _false() => Interop.mkConfigAttr("displayModeBar", false);
            public static Box<IConfigProperty> _true() => Interop.mkConfigAttr("displayModeBar", true);
        }
    }
}