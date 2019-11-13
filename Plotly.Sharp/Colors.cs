using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plotly
{
    public static class colorscale
    {
        private static string getScaled(float len, float n) => (n / (len - 1)).ToString("n2");

        public static string[][] sequential(params string[] colors)
        {
            return colors.Select((c, i) => new[] { getScaled(colors.Length, i), c }).ToArray();
        }

        public static string[][] sequentialMinus(params string[] colors)
        {
            return colors.Select((c, i) => new[] { getScaled(colors.Length, colors.Length - i), c }).ToArray();
        }

        public static string[][] diverging(float mid, float threshold, params string[] colors)
        {
            throw new NotImplementedException();

            //Original to convert:

            //let diverging (mid: float) (threshold: float) (colors: string list) =
            //            let colorListSize = colors.Length |> float

            //            let exceededMin, newMin =
            //                match mid - threshold with
            //                | min when min >= 0. -> false, min
            //                | _ -> true, 0.

            //            let exceededMax, newMax = 
            //                match mid + threshold with
            //                | max when max <= 1. -> false, max
            //                | _ -> true, 1.

            //            let diverge n = newMin + n * (newMax - newMin) / (colorListSize - 2.)

            //            match exceededMin, exceededMax with
            //            | true, false -> 
            //                [ 0. .. (colorListSize - 2.) ]
            //                |> List.map (diverge >> string)
            //                |> fun res -> [ yield! res; "1." ]
            //            | false, true ->
            //                [ 0. .. (colorListSize - 2.) ]
            //                |> List.map (diverge >> string)
            //                |> fun res -> [ "0."; yield! res ]
            //            | _ ->
            //                [ 0. .. (colorListSize - 3.) ]
            //                |> List.map (diverge >> string)
            //                |> fun res -> [ "0."; yield! res; "1." ]
            //            |> List.map2 (fun color i ->
            //                [ i; color ]
            //            ) colors
        }


        public static string[][] greys() => sequential(new[] { color.rgb(0, 0, 0), color.rgb(255, 255, 255) });

        public static string[][] ylGnBu => sequential(new[] { color.rgb(8, 29, 88), color.rgb(37, 52, 148), color.rgb(34, 94, 168), color.rgb(29, 145, 192), color.rgb(65, 182, 196), color.rgb(127, 205, 187), color.rgb(199, 233, 180), color.rgb(237, 248, 217), color.rgb(255, 255, 217) });

        public static string[][] greens => sequential(new[] { color.rgb(0, 68, 27), color.rgb(0, 109, 44), color.rgb(35, 139, 69), color.rgb(65, 171, 93), color.rgb(116, 196, 118), color.rgb(161, 217, 155), color.rgb(199, 233, 192), color.rgb(229, 245, 224), color.rgb(247, 252, 245) });

        public static string[][] ylOrRd => sequential(new[] { color.rgb(128, 0, 38), color.rgb(189, 0, 38), color.rgb(227, 26, 28), color.rgb(252, 78, 42), color.rgb(253, 141, 60), color.rgb(254, 178, 76), color.rgb(254, 217, 118), color.rgb(255, 237, 160), color.rgb(255, 255, 204) });

        public static string[][] bluered => sequential(new[] { color.rgb(0, 0, 255), color.rgb(255, 0, 0) });

        /// modified RdBu based on
        ///
        /// http://www.kennethmoreland.com/color-maps/
        /// 
        public static string[][] rdBu => new[] { new[] { "0", color.rgb(5, 10, 172) }, new[] { "0.35", color.rgb(106, 137, 247) }, new[] { "0.5", color.rgb(190, 190, 190) }, new[] { "0.6", color.rgb(220, 170, 132) }, new[] { "0.7", color.rgb(230, 145, 90) }, new[] { "1", color.rgb(178, 10, 28) } };

        /// Scale for non-negative numeric values
        public static string[][] reds => diverging(0, 0.4f, new[] { color.rgb(220, 220, 220), color.rgb(245, 195, 157), color.rgb(245, 160, 105), color.rgb(178, 10, 28) });

        /// Scale for non-positive numeric values
        public static string[][] blues => new[] { new[] { "0", color.rgb(5, 10, 172) }, new[] { "0.35", color.rgb(40, 60, 190) }, new[] { "0.5", color.rgb(70, 100, 245) }, new[] { "0.6", color.rgb(90, 120, 245) }, new[] { "0.7", color.rgb(106, 137, 247) }, new[] { "1", color.rgb(220, 220, 220) } };

        public static string[][] picnic = sequential(color.rgb(0, 0, 255), color.rgb(51, 153, 255), color.rgb(102, 204, 255), color.rgb(153, 204, 255), color.rgb(204, 204, 255), color.rgb(255, 255, 255), color.rgb(255, 204, 255), color.rgb(255, 153, 255), color.rgb(255, 102, 204), color.rgb(255, 102, 102), color.rgb(255, 0, 0));

        public static string[][] rainbow => sequential(color.rgb(150, 0, 90), color.rgb(0, 0, 200), color.rgb(0, 25, 255), color.rgb(0, 152, 255), color.rgb(44, 255, 150), color.rgb(151, 255, 0), color.rgb(255, 234, 0), color.rgb(255, 111, 0), color.rgb(255, 0, 0));

        public static string[][] portland => sequential(color.rgb(12, 51, 131), color.rgb(10, 136, 186), color.rgb(242, 211, 56), color.rgb(242, 143, 56), color.rgb(217, 30, 30));

        public static string[][] jet => sequential(color.rgb(0, 0, 131), color.rgb(0, 60, 170), color.rgb(5, 255, 255), color.rgb(255, 255, 0), color.rgb(250, 0, 0), color.rgb(128, 0, 0));

        public static string[][] hot => new[] { new[] { "0", color.rgb(0, 0, 0) }, new[] { "0.3", color.rgb(230, 0, 0) }, new[] { "0.6", color.rgb(255, 210, 0) }, new[] { "1.", color.rgb(255, 255, 255) } };

        public static string[][] blackbody => new[] { new[] { "0", color.rgb(0, 0, 0) }, new[] { "0.2", color.rgb(230, 0, 0) }, new[] { "0.4", color.rgb(230, 210, 0) }, new[] { "0.7", color.rgb(255, 255, 255) }, new[] { "1", color.rgb(160, 200, 255) } };

        public static string[][] earth => new[] { new[] { "0", color.rgb(0, 0, 130) }, new[] { "0.1", color.rgb(0, 180, 180) }, new[] { "0.2", color.rgb(40, 210, 40) }, new[] { "0.4", color.rgb(230, 230, 50) }, new[] { "0.6", color.rgb(120, 70, 20) }, new[] { "1", color.rgb(255, 255, 255) } };

        public static string[][] electric => new[] { new[] { "0", color.rgb(0, 0, 0) }, new[] { "0.15", color.rgb(30, 0, 100) }, new[] { "0.4", color.rgb(120, 0, 100) }, new[] { "0.6", color.rgb(160, 90, 0) }, new[] { "0.8", color.rgb(230, 200, 0) }, new[] { "1", color.rgb(255, 250, 220) } };

        public static string[][] viridis => sequential("#440154", "#48186a", "#472d7b", "#424086", "#3b528b", "#33638d", "#2c728e", "#26828e", "#21918c", "#1fa088", "#28ae80", "#3fbc73", "#5ec962", "#84d44b", "#addc30", "#d8e219", "#fde725");

        public static string[][] cividis => sequential(color.rgb(0, 32, 76), color.rgb(0, 42, 102), color.rgb(0, 52, 110), color.rgb(39, 63, 108), color.rgb(60, 74, 107), color.rgb(76, 85, 107), color.rgb(91, 95, 109), color.rgb(104, 106, 112), color.rgb(117, 117, 117), color.rgb(131, 129, 120),
                                                       color.rgb(146, 140, 120), color.rgb(161, 152, 118), color.rgb(176, 165, 114), color.rgb(192, 177, 109), color.rgb(209, 191, 102), color.rgb(225, 204, 92), color.rgb(243, 219, 79), color.rgb(255, 233, 69));

    }

    public static class color
    {
        public static string hsl(float hue, float saturation, float lightness) => $"hsl({hue}, {saturation}%, {lightness}%)";
        public static string rgb(float r, float g, float b) => $"rgb({r}, {g}%, {b}%)";
        public static string rgba(float r, float g, float b, float a) => $"rgba({r}, {g}, {b}, {a})";

        public const string indianRed = "#CD5C5C";
        public const string lightCoral = "#F08080";
        public const string salmon = "#FA8072";
        public const string darkSalmon = "#E9967A";
        public const string lightSalmon = "#FFA07A";
        public const string crimson = "#DC143C";
        public const string red = "#FF0000";
        public const string fireBrick = "#B22222";
        public const string darkRed = "#8B0000";
        public const string pink = "#FFC0CB";
        public const string lightPink = "#FFB6C1";
        public const string hotPink = "#FF69B4";
        public const string deepPink = "#FF1493";
        public const string mediumVioletRed = "#C71585";
        public const string paleVioletRed = "#DB7093";
        public const string coral = "#FF7F50";
        public const string tomato = "#FF6347";
        public const string orangeRed = "#FF4500";
        public const string darkOrange = "#FF8C00";
        public const string orange = "#FFA500";
        public const string gold = "#FFD700";
        public const string yellow = "#FFFF00";
        public const string lightYellow = "#FFFFE0";
        public const string limonChiffon = "#FFFACD";
        public const string lightGoldenRodYellow = "#FAFAD2";
        public const string papayaWhip = "#FFEFD5";
        public const string moccasin = "#FFE4B5";
        public const string peachPuff = "#FFDAB9";
        public const string paleGoldenRod = "#EEE8AA";
        public const string khaki = "#F0E68C";
        public const string darkKhaki = "#BDB76B";
        public const string lavender = "#E6E6FA";
        public const string thistle = "#D8BFD8";
        public const string plum = "#DDA0DD";
        public const string violet = "#EE82EE";
        public const string orchid = "#DA70D6";
        public const string fuchsia = "#FF00FF";
        public const string magenta = "#FF00FF";
        public const string mediumOrchid = "#BA55D3";
        public const string mediumPurple = "#9370DB";
        public const string rebeccaPurple = "#663399";
        public const string blueViolet = "#8A2BE2";
        public const string darkViolet = "#9400D3";
        public const string darkOrchid = "#9932CC";
        public const string darkMagenta = "#8B008B";
        public const string purple = "#800080";
        public const string indigo = "#4B0082";
        public const string slateBlue = "#6A5ACD";
        public const string darkSlateBlue = "#483D8B";
        public const string mediumSlateBlue = "#7B68EE";
        public const string greenYellow = "#ADFF2F";
        public const string chartreuse = "#7FFF00";
        public const string lawnGreen = "#7CFC00";
        public const string lime = "#00FF00";
        public const string limeGreen = "#32CD32";
        public const string paleGreen = "#98FB98";
        public const string lightGreen = "#90EE90";
        public const string mediumSpringGreen = "#00FA9A";
        public const string springGreen = "#00FF7F";
        public const string mediumSeaGreen = "#3CB371";
        public const string seaGreen = "#2E8B57";
        public const string forestGreen = "#228B22";
        public const string green = "#008000";
        public const string darkGreen = "#006400";
        public const string yellowGreen = "#9ACD32";
        public const string oliveDrab = "#6B8E23";
        public const string olive = "#808000";
        public const string darkOliveGreen = "#556B2F";
        public const string mediumAquamarine = "#66CDAA";
        public const string darkSeaGreen = "#8FBC8B";
        public const string lightSeaGreen = "#20B2AA";
        public const string darkCyan = "#008B8B";
        public const string teal = "#008080";
        public const string aqua = "#00FFFF";
        public const string cyan = "#00FFFF";
        public const string lightCyan = "#E0FFFF";
        public const string paleTurqouise = "#AFEEEE";
        public const string aquaMarine = "#7FFFD4";
        public const string turqouise = "#AFEEEE";
        public const string mediumTurqouise = "#48D1CC";
        public const string darkTurqouise = "#00CED1";
        public const string cadetBlue = "#5F9EA0";
        public const string steelBlue = "#4682B4";
        public const string lightSteelBlue = "#B0C4DE";
        public const string powederBlue = "#B0E0E6";
        public const string lightBlue = "#ADD8E6";
        public const string skyBlue = "#87CEEB";
        public const string lightSkyBlue = "#87CEFA";
        public const string deepSkyBlue = "#00BFFF";
        public const string dodgerBlue = "#1E90FF";
        public const string cornFlowerBlue = "#6495ED";
        public const string royalBlue = "#4169E1";
        public const string blue = "#0000FF";
        public const string mediumBlue = "#0000CD";
        public const string darkBlue = "#00008B";
        public const string navy = "#000080";
        public const string midnightBlue = "#191970";
        public const string cornSilk = "#FFF8DC";
        public const string blanchedAlmond = "#FFEBCD";
        public const string bisque = "#FFE4C4";
        public const string navajoWhite = "#FFDEAD";
        public const string wheat = "#F5DEB3";
        public const string burlyWood = "#DEB887";
        public const string tan = "#D2B48C";
        public const string rosyBrown = "#BC8F8F";
        public const string sandyBrown = "#F4A460";
        public const string goldenRod = "#DAA520";
        public const string darkGoldenRod = "#B8860B";
        public const string peru = "#CD853F";
        public const string chocolate = "#D2691E";
        public const string saddleBrown = "#8B4513";
        public const string sienna = "#A0522D";
        public const string brown = "#A52A2A";
        public const string maroon = "#A52A2A";
        public const string white = "#FFFFFF";
        public const string snow = "#FFFAFA";
        public const string honeyDew = "#F0FFF0";
        public const string mintCream = "#F5FFFA";
        public const string azure = "#F0FFFF";
        public const string aliceBlue = "#F0F8FF";
        public const string ghostWhite = "#F8F8FF";
        public const string whiteSmoke = "#F5F5F5";
        public const string seaShell = "#FFF5EE";
        public const string beige = "#F5F5DC";
        public const string oldLace = "#FDF5E6";
        public const string floralWhite = "#FFFAF0";
        public const string ivory = "#FFFFF0";
        public const string antiqueWhite = "#FAEBD7";
        public const string linen = "#FAF0E6";
        public const string lavenderBlush = "#FFF0F5";
        public const string mistyRose = "#FFE4E1";
        public const string gainsBoro = "#DCDCDC";
        public const string lightGray = "#D3D3D3";
        public const string silver = "#C0C0C0";
        public const string darkGray = "#A9A9A9";
        public const string gray = "#808080";
        public const string dimGray = "#696969";
        public const string lightSlateGray = "#778899";
        public const string slateGray = "#708090";
        public const string darkSlateGray = "#2F4F4F";
        public const string black = "#000000";
        public const string transparent = "transparent";
    }
}
