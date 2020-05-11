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

    public static partial class Button
    {
        /// Determines whether or not this button is visible.
        public static Box<IButtonProperty> visible(bool val) => Interop.mkButtonAttr("visible", val);
        /// Sets the number of steps to take to update the range. Use with `step` to specify the update interval.
        public static Box<IButtonProperty> count(int val) => Interop.mkButtonAttr("count", val);
        /// Sets the number of steps to take to update the range. Use with `step` to specify the update interval.
        public static Box<IButtonProperty> count(float val) => Interop.mkButtonAttr("count", val);
        /// Sets the text label to appear on the button.
        public static Box<IButtonProperty> label(string val) => Interop.mkButtonAttr("label", val);
        /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
        public static Box<IButtonProperty> name(string val) => Interop.mkButtonAttr("name", val);
        /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
        public static Box<IButtonProperty> templateitemname(string val) => Interop.mkButtonAttr("templateitemname", val);
        /// Sets the arguments values to be passed to the Plotly method set in `method` on click.
        public static Box<IButtonProperty> args(bool val) => Interop.mkButtonAttr("args", new[]{val});
        /// Sets the arguments values to be passed to the Plotly method set in `method` on click.
        public static Box<IButtonProperty> args(IEnumerable<bool> values) => Interop.mkButtonAttr("args", values.ToArray());
        /// Sets the arguments values to be passed to the Plotly method set in `method` on click.
        public static Box<IButtonProperty> args(System.DateTime val) => Interop.mkButtonAttr("args", new[]{val});
        /// Sets the arguments values to be passed to the Plotly method set in `method` on click.
        public static Box<IButtonProperty> args(IEnumerable<System.DateTime> values) => Interop.mkButtonAttr("args", values.ToArray());
        /// Sets the arguments values to be passed to the Plotly method set in `method` on click.
        public static Box<IButtonProperty> args(float val) => Interop.mkButtonAttr("args", new[]{val});
        /// Sets the arguments values to be passed to the Plotly method set in `method` on click.
        public static Box<IButtonProperty> args(IEnumerable<float> values) => Interop.mkButtonAttr("args", values.ToArray());
        /// Sets the arguments values to be passed to the Plotly method set in `method` on click.
        public static Box<IButtonProperty> args(int val) => Interop.mkButtonAttr("args", new[]{val});
        /// Sets the arguments values to be passed to the Plotly method set in `method` on click.
        public static Box<IButtonProperty> args(IEnumerable<int> values) => Interop.mkButtonAttr("args", values.ToArray());
        /// Sets the arguments values to be passed to the Plotly method set in `method` on click.
        public static Box<IButtonProperty> args(string val) => Interop.mkButtonAttr("args", new[]{val});
        /// Sets the arguments values to be passed to the Plotly method set in `method` on click.
        public static Box<IButtonProperty> args(IEnumerable<string> values) => Interop.mkButtonAttr("args", values.ToArray());
        /// Sets a 2nd set of `args`, these arguments values are passed to the Plotly method set in `method` when clicking this button while in the active state. Use this to create toggle buttons.
        public static Box<IButtonProperty> args2(bool val) => Interop.mkButtonAttr("args2", new[]{val});
        /// Sets a 2nd set of `args`, these arguments values are passed to the Plotly method set in `method` when clicking this button while in the active state. Use this to create toggle buttons.
        public static Box<IButtonProperty> args2(IEnumerable<bool> values) => Interop.mkButtonAttr("args2", values.ToArray());
        /// Sets a 2nd set of `args`, these arguments values are passed to the Plotly method set in `method` when clicking this button while in the active state. Use this to create toggle buttons.
        public static Box<IButtonProperty> args2(System.DateTime val) => Interop.mkButtonAttr("args2", new[]{val});
        /// Sets a 2nd set of `args`, these arguments values are passed to the Plotly method set in `method` when clicking this button while in the active state. Use this to create toggle buttons.
        public static Box<IButtonProperty> args2(IEnumerable<System.DateTime> values) => Interop.mkButtonAttr("args2", values.ToArray());
        /// Sets a 2nd set of `args`, these arguments values are passed to the Plotly method set in `method` when clicking this button while in the active state. Use this to create toggle buttons.
        public static Box<IButtonProperty> args2(float val) => Interop.mkButtonAttr("args2", new[]{val});
        /// Sets a 2nd set of `args`, these arguments values are passed to the Plotly method set in `method` when clicking this button while in the active state. Use this to create toggle buttons.
        public static Box<IButtonProperty> args2(IEnumerable<float> values) => Interop.mkButtonAttr("args2", values.ToArray());
        /// Sets a 2nd set of `args`, these arguments values are passed to the Plotly method set in `method` when clicking this button while in the active state. Use this to create toggle buttons.
        public static Box<IButtonProperty> args2(int val) => Interop.mkButtonAttr("args2", new[]{val});
        /// Sets a 2nd set of `args`, these arguments values are passed to the Plotly method set in `method` when clicking this button while in the active state. Use this to create toggle buttons.
        public static Box<IButtonProperty> args2(IEnumerable<int> values) => Interop.mkButtonAttr("args2", values.ToArray());
        /// Sets a 2nd set of `args`, these arguments values are passed to the Plotly method set in `method` when clicking this button while in the active state. Use this to create toggle buttons.
        public static Box<IButtonProperty> args2(string val) => Interop.mkButtonAttr("args2", new[]{val});
        /// Sets a 2nd set of `args`, these arguments values are passed to the Plotly method set in `method` when clicking this button while in the active state. Use this to create toggle buttons.
        public static Box<IButtonProperty> args2(IEnumerable<string> values) => Interop.mkButtonAttr("args2", values.ToArray());
        /// When true, the API method is executed. When false, all other behaviors are the same and command execution is skipped. This may be useful when hooking into, for example, the `plotly_buttonclicked` method and executing the API command manually without losing the benefit of the updatemenu automatically binding to the state of the plot through the specification of `method` and `args`.
        public static Box<IButtonProperty> execute(bool val) => Interop.mkButtonAttr("execute", val);
    }

    public static partial class Button
    {
        /// The unit of measurement that the `count` value will set the range by.
        public static partial class Step
        {
            public static Box<IButtonProperty> all() => Interop.mkButtonAttr("step", "all");
            public static Box<IButtonProperty> day() => Interop.mkButtonAttr("step", "day");
            public static Box<IButtonProperty> hour() => Interop.mkButtonAttr("step", "hour");
            public static Box<IButtonProperty> minute() => Interop.mkButtonAttr("step", "minute");
            public static Box<IButtonProperty> month() => Interop.mkButtonAttr("step", "month");
            public static Box<IButtonProperty> second() => Interop.mkButtonAttr("step", "second");
            public static Box<IButtonProperty> year() => Interop.mkButtonAttr("step", "year");
        }

        /// Sets the range update mode. If *backward*, the range update shifts the start of range back *count* times *step* milliseconds. If *todate*, the range update shifts the start of range back to the first timestamp from *count* times *step* milliseconds back. For example, with `step` set to *year* and `count` set to *1* the range update shifts the start of the range back to January 01 of the current year. Month and year *todate* are currently available only for the built-in (Gregorian) calendar.
        public static partial class Stepmode
        {
            public static Box<IButtonProperty> backward() => Interop.mkButtonAttr("stepmode", "backward");
            public static Box<IButtonProperty> todate() => Interop.mkButtonAttr("stepmode", "todate");
        }

        /// Sets the Plotly method to be called on click. If the `skip` method is used, the API updatemenu will function as normal but will perform no API calls and will not bind automatically to state updates. This may be used to create a component interface and attach to updatemenu events manually via JavaScript.
        public static partial class Method
        {
            public static Box<IButtonProperty> animate() => Interop.mkButtonAttr("method", "animate");
            public static Box<IButtonProperty> relayout() => Interop.mkButtonAttr("method", "relayout");
            public static Box<IButtonProperty> restyle() => Interop.mkButtonAttr("method", "restyle");
            public static Box<IButtonProperty> skip() => Interop.mkButtonAttr("method", "skip");
            public static Box<IButtonProperty> update() => Interop.mkButtonAttr("method", "update");
        }
    }
}