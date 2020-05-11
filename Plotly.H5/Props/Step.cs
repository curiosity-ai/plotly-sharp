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

    public static partial class Step
    {
        /// Sets the background color of the arc.
        public static Box<IStepProperty> color(string val) => Interop.mkStepAttr("color", val);
        public static Box<IStepProperty> line(params Box<ILineProperty>[] properties) => Interop.mkStepAttr("line", Bindings.flattenProperties(properties));
        /// Sets the thickness of the bar as a fraction of the total thickness of the gauge.
        public static Box<IStepProperty> thickness(int val) => Interop.mkStepAttr("thickness", val);
        /// Sets the thickness of the bar as a fraction of the total thickness of the gauge.
        public static Box<IStepProperty> thickness(float val) => Interop.mkStepAttr("thickness", val);
        /// Sets the range of this axis.
        public static Box<IStepProperty> range(int val) => Interop.mkStepAttr("range", new[]{val});
        /// Sets the range of this axis.
        public static Box<IStepProperty> range(IEnumerable<int> values) => Interop.mkStepAttr("range", values.ToArray());
        /// Sets the range of this axis.
        public static Box<IStepProperty> range(float val) => Interop.mkStepAttr("range", new[]{val});
        /// Sets the range of this axis.
        public static Box<IStepProperty> range(IEnumerable<float> values) => Interop.mkStepAttr("range", values.ToArray());
        /// When used in a template, named items are created in the output figure in addition to any items the figure already has in this array. You can modify these items in the output figure by making your own item with `templateitemname` matching this `name` alongside your modifications (including `visible: false` or `enabled: false` to hide it). Has no effect outside of a template.
        public static Box<IStepProperty> name(string val) => Interop.mkStepAttr("name", val);
        /// Used to refer to a named item in this array in the template. Named items from the template will be created even without a matching item in the input figure, but you can modify one by making an item with `templateitemname` matching its `name`, alongside your modifications (including `visible: false` or `enabled: false` to hide it). If there is no template or no matching item, this item will be hidden unless you explicitly show it with `visible: true`.
        public static Box<IStepProperty> templateitemname(string val) => Interop.mkStepAttr("templateitemname", val);
        /// Determines whether or not this step is included in the slider.
        public static Box<IStepProperty> visible(bool val) => Interop.mkStepAttr("visible", val);
        /// Sets the arguments values to be passed to the Plotly method set in `method` on slide.
        public static Box<IStepProperty> args(bool val) => Interop.mkStepAttr("args", new[]{val});
        /// Sets the arguments values to be passed to the Plotly method set in `method` on slide.
        public static Box<IStepProperty> args(IEnumerable<bool> values) => Interop.mkStepAttr("args", values.ToArray());
        /// Sets the arguments values to be passed to the Plotly method set in `method` on slide.
        public static Box<IStepProperty> args(System.DateTime val) => Interop.mkStepAttr("args", new[]{val});
        /// Sets the arguments values to be passed to the Plotly method set in `method` on slide.
        public static Box<IStepProperty> args(IEnumerable<System.DateTime> values) => Interop.mkStepAttr("args", values.ToArray());
        /// Sets the arguments values to be passed to the Plotly method set in `method` on slide.
        public static Box<IStepProperty> args(float val) => Interop.mkStepAttr("args", new[]{val});
        /// Sets the arguments values to be passed to the Plotly method set in `method` on slide.
        public static Box<IStepProperty> args(IEnumerable<float> values) => Interop.mkStepAttr("args", values.ToArray());
        /// Sets the arguments values to be passed to the Plotly method set in `method` on slide.
        public static Box<IStepProperty> args(int val) => Interop.mkStepAttr("args", new[]{val});
        /// Sets the arguments values to be passed to the Plotly method set in `method` on slide.
        public static Box<IStepProperty> args(IEnumerable<int> values) => Interop.mkStepAttr("args", values.ToArray());
        /// Sets the arguments values to be passed to the Plotly method set in `method` on slide.
        public static Box<IStepProperty> args(string val) => Interop.mkStepAttr("args", new[]{val});
        /// Sets the arguments values to be passed to the Plotly method set in `method` on slide.
        public static Box<IStepProperty> args(IEnumerable<string> values) => Interop.mkStepAttr("args", values.ToArray());
        /// Sets the text label to appear on the slider
        public static Box<IStepProperty> label(string val) => Interop.mkStepAttr("label", val);
        /// Sets the value of the slider step, used to refer to the step programatically. Defaults to the slider label if not provided.
        public static Box<IStepProperty> value(string val) => Interop.mkStepAttr("value", val);
        /// When true, the API method is executed. When false, all other behaviors are the same and command execution is skipped. This may be useful when hooking into, for example, the `plotly_sliderchange` method and executing the API command manually without losing the benefit of the slider automatically binding to the state of the plot through the specification of `method` and `args`.
        public static Box<IStepProperty> execute(bool val) => Interop.mkStepAttr("execute", val);
    }

    public static partial class Step
    {
        /// Sets the Plotly method to be called when the slider value is changed. If the `skip` method is used, the API slider will function as normal but will perform no API calls and will not bind automatically to state updates. This may be used to create a component interface and attach to slider events manually via JavaScript.
        public static partial class Method
        {
            public static Box<IStepProperty> animate() => Interop.mkStepAttr("method", "animate");
            public static Box<IStepProperty> relayout() => Interop.mkStepAttr("method", "relayout");
            public static Box<IStepProperty> restyle() => Interop.mkStepAttr("method", "restyle");
            public static Box<IStepProperty> skip() => Interop.mkStepAttr("method", "skip");
            public static Box<IStepProperty> update() => Interop.mkStepAttr("method", "update");
        }
    }
}