using System;
using System.Diagnostics;

namespace TelCo.ColorCoder;

public static class ColorCodeManualTests
{
    public static void AssertManualIsCorrect()
    {
        string manual = ColorCodeManualGenerator.Generate();

        int expectedTotalPairs = ColorMap.MajorColors.Length * ColorMap.MinorColors.Length;

        for (int pairNumber = 1; pairNumber <= expectedTotalPairs; pairNumber++)
        {
            var pair = ColorCoder.GetColorFromPairNumber(pairNumber);
            string expectedLine =
                $"Pair {pairNumber}: {pair.majorColor.Name} - {pair.minorColor.Name}";
            Debug.Assert(manual.Contains(expectedLine), $"Missing line: {expectedLine}");
        }
    }
}
