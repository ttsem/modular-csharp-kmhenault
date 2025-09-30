using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    public static class ColorCoderTests
    {
        public static void TestColorFromPairNumber(
            int pairNumber,
            Color expectedMajor,
            Color expectedMinor
        )
        {
            ColorPair pair = ColorCoder.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0}, [Out] Colors: {1}\n", pairNumber, pair);
            Debug.Assert(pair.majorColor == expectedMajor);
            Debug.Assert(pair.minorColor == expectedMinor);
        }

        public static void TestPairNumberFromColor(ColorPair pair, int expectedPairNumber)
        {
            int pairNumber = ColorCoder.GetPairNumberFromColor(pair);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", pair, pairNumber);
            Debug.Assert(pairNumber == expectedPairNumber);
        }
    }
}
