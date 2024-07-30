using FTSearchEngine.Tokenizing;

namespace FTSearchEngine;

public static class Program {
    public static void Main() {
        var tokens = Tokenizer.Tokenize("english", "become is the same meaning as becoming");

        foreach (var token in tokens) Console.WriteLine(token);
    }
}