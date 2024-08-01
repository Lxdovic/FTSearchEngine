namespace FTSearchEngine.Matching;

public static class JaroWinkler {
    private const double MWeightThreshold = 0.7;
    private const int MNumChars = 4;

    public static double Distance(string aString1, string aString2) {
        return 1.0 - Proximity(aString1, aString2);
    }

    public static double Proximity(string aString1, string aString2) {
        var lLen1 = aString1.Length;
        var lLen2 = aString2.Length;
        if (lLen1 == 0)
            return lLen2 == 0 ? 1.0 : 0.0;

        var lSearchRange = Math.Max(0, Math.Max(lLen1, lLen2) / 2 - 1);

        var lMatched1 = new bool[lLen1];
        var lMatched2 = new bool[lLen2];

        var lNumCommon = 0;
        
        for (var i = 0; i < lLen1; ++i) {
            var lStart = Math.Max(0, i - lSearchRange);
            var lEnd = Math.Min(i + lSearchRange + 1, lLen2);
            for (var j = lStart; j < lEnd; ++j) {
                if (lMatched2[j]) continue;
                if (aString1[i] != aString2[j])
                    continue;
                lMatched1[i] = true;
                lMatched2[j] = true;
                ++lNumCommon;
                break;
            }
        }

        if (lNumCommon == 0) return 0.0;

        var lNumHalfTransposed = 0;
        var k = 0;
        for (var i = 0; i < lLen1; ++i) {
            if (!lMatched1[i]) continue;
            while (!lMatched2[k]) ++k;
            if (aString1[i] != aString2[k])
                ++lNumHalfTransposed;
            ++k;
        }

        var lNumTransposed = lNumHalfTransposed / 2;

        double lNumCommonD = lNumCommon;
        var lWeight = (lNumCommonD / lLen1
                       + lNumCommonD / lLen2
                       + (lNumCommon - lNumTransposed) / lNumCommonD) / 3.0;

        if (lWeight <= MWeightThreshold) return lWeight;
        var lMax = Math.Min(MNumChars, Math.Min(aString1.Length, aString2.Length));
        var lPos = 0;
        while (lPos < lMax && aString1[lPos] == aString2[lPos])
            ++lPos;
        if (lPos == 0) return lWeight;
        return lWeight + 0.1 * lPos * (1.0 - lWeight);
    }
}