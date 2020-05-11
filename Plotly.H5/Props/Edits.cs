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
    using static Retyped.dom;

    public static partial class Edits
    {
        /// Determines if the main anchor of the annotation is editable. The main anchor corresponds to the text (if no arrow) or the arrow (which drags the whole thing leaving the arrow length & direction unchanged).
        public static Box<IEditsProperty> annotationPosition(bool val) => Interop.mkEditsAttr("annotationPosition", val);
        /// Has only an effect for annotations with arrows. Enables changing the length and direction of the arrow.
        public static Box<IEditsProperty> annotationTail(bool val) => Interop.mkEditsAttr("annotationTail", val);
        /// Enables editing annotation text.
        public static Box<IEditsProperty> annotationText(bool val) => Interop.mkEditsAttr("annotationText", val);
        /// Enables editing axis title text.
        public static Box<IEditsProperty> axisTitleText(bool val) => Interop.mkEditsAttr("axisTitleText", val);
        /// Enables moving colorbars.
        public static Box<IEditsProperty> colorbarPosition(bool val) => Interop.mkEditsAttr("colorbarPosition", val);
        /// Enables editing colorbar title text.
        public static Box<IEditsProperty> colorbarTitleText(bool val) => Interop.mkEditsAttr("colorbarTitleText", val);
        /// Enables moving the legend.
        public static Box<IEditsProperty> legendPosition(bool val) => Interop.mkEditsAttr("legendPosition", val);
        /// Enables editing the trace name fields from the legend
        public static Box<IEditsProperty> legendText(bool val) => Interop.mkEditsAttr("legendText", val);
        /// Enables moving shapes.
        public static Box<IEditsProperty> shapePosition(bool val) => Interop.mkEditsAttr("shapePosition", val);
        /// Enables editing the global layout title.
        public static Box<IEditsProperty> titleText(bool val) => Interop.mkEditsAttr("titleText", val);
    }
}