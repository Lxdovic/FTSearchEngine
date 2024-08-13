namespace FTSearchEngine.Matching;

public static class Bitap {
    public static int Fuzzy(string text, string pattern, int k) {
        var result = -1;
        var m = pattern.Length;
        int[] R;
        var patternMask = new int[128];
        int i, d;

        if (string.IsNullOrEmpty(pattern)) return 0;
        if (m > 31) return -1; //Error: The pattern is too long!

        R = new int[(k + 1) * sizeof(int)];
        for (i = 0; i <= k; ++i)
            R[i] = ~1;

        for (i = 0; i <= 127; ++i)
            patternMask[i] = ~0;

        for (i = 0; i < m; ++i)
            patternMask[pattern[i]] &= ~(1 << i);

        for (i = 0; i < text.Length; ++i) {
            var oldRd1 = R[0];

            R[0] |= patternMask[text[i]];
            R[0] <<= 1;

            for (d = 1; d <= k; ++d) {
                var tmp = R[d];

                R[d] = (oldRd1 & (R[d] | patternMask[text[i]])) << 1;
                oldRd1 = tmp;
            }

            if (0 == (R[k] & (1 << m))) {
                result = i - m + 1;
                break;
            }
        }

        return result;
    }
}