using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder.Tests;

public static class ColorCoderTests
{
    public static void TestColorFromPairNumber(
        int pairNumber,
        Color expectedMajor,
        Color expectedMinor
    )
    {
        ColorPair pair = ColorCoder.GetColorFromPairNumber(pairNumber);
        Debug.Assert(pair.majorColor == expectedMajor);
        Debug.Assert(pair.minorColor == expectedMinor);
    }

    public static void TestPairNumberFromColor(ColorPair pair, int expectedPairNumber)
    {
        int pairNumber = ColorCoder.GetPairNumberFromColor(pair);
        Debug.Assert(pairNumber == expectedPairNumber);
    }
}