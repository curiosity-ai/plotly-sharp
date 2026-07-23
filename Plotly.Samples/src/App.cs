using System;
using System.Collections.Generic;
using System.Linq;
using Tesserae;
using static Tesserae.UI;
using static Transpose.Core.dom;

namespace Plotly.Samples
{
    internal static class App
    {
        private static void Main()
        {
            document.body.style.overflow = "hidden";

            // Discover every ISample in this assembly (reflection is emitted inline; see tps.json).
            var samples = typeof(ISample).Assembly.GetTypes()
                .Where(t => typeof(ISample).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .Select(t => (ISample)Activator.CreateInstance(t))
                .OrderBy(s => s.Group)
                .ThenBy(s => s.Name)
                .ToList();

            var current = new SettableObservable<ISample>(samples.FirstOrDefault());

            var content = DeferSync(current, s => s is null
                ? (IComponent)TextBlock("Select a sample from the left.").P(24)
                : s.Content());

            var nav = VStack().HS().ScrollY().W(240).NoShrink().PT(12).PB(24).Children(
                TextBlock("Tesserae.Plotly", textSize: TextSize.Large, textWeight: TextWeight.Bold).PL(16).PB(4),
                TextBlock("Chart samples", textSize: TextSize.XSmall).PL(16).PB(12));

            foreach (var group in samples.GroupBy(s => s.Group))
            {
                nav.Add(TextBlock(group.Key.ToUpper(), textSize: TextSize.XSmall, textWeight: TextWeight.SemiBold).PL(16).PT(12).PB(4));

                foreach (var s in group)
                {
                    var sample = s;
                    var button = Button(sample.Name).NoBorder().NoBackground().WS();
                    button.OnClick(() => current.Value = sample);
                    nav.Add(button);
                }
            }

            // .W(1).Grow() gives the content pane a tiny flex-basis so it fills the leftover space but can
            // still shrink below its content width (otherwise wide charts would overflow the viewport).
            var layout = HStack().S().Children(
                nav.HS(),
                VStack().W(1).Grow().HS().Children(content.S()));

            MountToBody(layout);
        }
    }
}
