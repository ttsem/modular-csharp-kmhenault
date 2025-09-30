using System.Text;

namespace TelCo.ColorCoder;

public static class ColorCodeManualGenerator
{
    public static string Generate()
    {
        var sb = new StringBuilder();
        int totalPairs = ColorMap.MajorColors.Length * ColorMap.MinorColors.Length;

        sb.AppendLine("25-Pair Color Code Reference Manual");
        sb.AppendLine("-----------------------------------");

        for (int pairNumber = 1; pairNumber <= totalPairs; pairNumber++)
        {
            var pair = ColorCoder.GetColorFromPairNumber(pairNumber);
            sb.AppendLine($"Pair {pairNumber}: {pair.majorColor.Name} - {pair.minorColor.Name}");
        }

        return sb.ToString();
    }
}