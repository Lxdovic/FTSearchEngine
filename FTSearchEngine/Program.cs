using FTSearchEngine.Tokenizing;

namespace FTSearchEngine;

public static class Program {
    public static void Main() {
        var tokens = Tokenizer.Tokenize("french", "continu continua continuait continuant continuation");

        foreach (var token in tokens) Console.WriteLine(token);
    }
}