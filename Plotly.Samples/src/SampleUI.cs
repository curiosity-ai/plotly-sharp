using System.Collections.Generic;
using Tesserae;
using static Tesserae.UI;

namespace Plotly.Samples
{
    /// <summary>A single demo page in the samples app.</summary>
    public interface ISample
    {
        /// <summary>Sidebar group this sample belongs to.</summary>
        string Group { get; }
        /// <summary>Display name of the sample.</summary>
        string Name { get; }
        /// <summary>Builds the page content (rebuilt each time the sample is selected).</summary>
        IComponent Content();
    }

    /// <summary>One example (a titled, described chart) shown on a sample page.</summary>
    public sealed class Example
    {
        public Example(string title, string description, IComponent chart, int height = 360)
        {
            Title       = title;
            Description = description;
            Chart       = chart;
            Height      = height;
        }

        public string     Title       { get; }
        public string     Description { get; }
        public IComponent Chart       { get; }
        public int        Height      { get; }
    }

    /// <summary>Helpers for laying out a sample page consistently.</summary>
    internal static class SampleUI
    {
        /// <summary>Builds a scrollable page with a heading, an intro paragraph, and one card per example.</summary>
        public static IComponent Page(string title, string intro, params Example[] examples)
        {
            var children = new List<IComponent>
            {
                TextBlock(title, textSize: TextSize.XLarge, textWeight: TextWeight.Bold).PT(24).PB(4),
                TextBlock(intro, textSize: TextSize.Medium).PB(16)
            };

            foreach (var ex in examples)
            {
                var card = VStack().WS().Children(
                    TextBlock(ex.Title, textSize: TextSize.MediumPlus, textWeight: TextWeight.SemiBold).PB(4));

                if (!string.IsNullOrEmpty(ex.Description))
                {
                    card.Add(TextBlock(ex.Description, textSize: TextSize.Small).PB(8));
                }

                card.Add(ex.Chart.WS().H(ex.Height));

                children.Add(Card(card).WS().MB(16));
            }

            return VStack().S().ScrollY().PL(24).PR(24).PB(24).Children(children.ToArray());
        }
    }
}
