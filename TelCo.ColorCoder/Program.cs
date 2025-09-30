using System;
using System.Drawing;
using TelCo.ColorCoder.Tests;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// The 25-pair color code, originally known as even-count color code,
    /// is a color code used to identify individual conductors in twisted-pair
    /// wiring for telecommunications.
    /// This class provides the color coding and
    /// mapping of pair number to color and color to pair number.
    /// </summary>
    class Program
    {
        private static void Main(string[] args)
        {
            ColorCoderTests.TestColorFromPairNumber(4, Color.White, Color.Brown);
            ColorCoderTests.TestColorFromPairNumber(5, Color.White, Color.SlateGray);
            ColorCoderTests.TestColorFromPairNumber(23, Color.Violet, Color.Green);

            ColorCoderTests.TestPairNumberFromColor(
                new ColorPair { majorColor = Color.Yellow, minorColor = Color.Green },
                18
            );
            ColorCoderTests.TestPairNumberFromColor(
                new ColorPair { majorColor = Color.Red, minorColor = Color.Blue },
                6
            );

            Console.WriteLine(ColorCodeManualGenerator.Generate());
        }
    }
}
