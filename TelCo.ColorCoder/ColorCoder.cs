using System;

namespace TelCo.ColorCoder;

public static class ColorCoder
{
    public static ColorPair GetColorFromPairNumber(int pairNumber)
    {
        int minorSize = ColorMap.MinorColors.Length;
        int majorSize = ColorMap.MajorColors.Length;

        if (pairNumber < 1 || pairNumber > minorSize * majorSize)
        {
            throw new ArgumentOutOfRangeException(
                nameof(pairNumber),
                $"Argument PairNumber:{pairNumber} is outside the allowed range"
            );
        }

        int zeroBasedPairNumber = pairNumber - 1;
        int majorIndex = zeroBasedPairNumber / minorSize;
        int minorIndex = zeroBasedPairNumber % minorSize;

        return new ColorPair
        {
            majorColor = ColorMap.MajorColors[majorIndex],
            minorColor = ColorMap.MinorColors[minorIndex]
        };
    }

    public static int GetPairNumberFromColor(ColorPair pair)
    {
        int majorIndex = Array.IndexOf(ColorMap.MajorColors, pair.majorColor);
        int minorIndex = Array.IndexOf(ColorMap.MinorColors, pair.minorColor);

        if (majorIndex == -1 || minorIndex == -1)
        {
            throw new ArgumentException($"Unknown Colors: {pair}");
        }

        return (majorIndex * ColorMap.MinorColors.Length) + (minorIndex + 1);
    }
}
