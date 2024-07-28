namespace FTSearchEngine;

public static class Levenshtein {
    public static int Distance(string a, string b) {
        var table = new int[a.Length + 1, b.Length + 1];

        for (var i = 0; i <= a.Length; i++) table[i, 0] = i;

        for (var i = 0; i <= b.Length; i++) table[0, i] = i;


        for (var i = 1; i <= a.Length; i++)
        for (var j = 1; j <= b.Length; j++) {
            var cost = a[i - 1] == b[j - 1] ? 0 : 1;

            table[i, j] = new[] { table[i - 1, j] + 1, table[i, j - 1] + 1, table[i - 1, j - 1] + cost }.Min();
        }

        for (var i = 0; i <= a.Length; i++) {
            for (var j = 0; j <= b.Length; j++) Console.Write($" {table[i, j]} ");

            Console.WriteLine();
        }

        return table[a.Length, b.Length];
    }
}