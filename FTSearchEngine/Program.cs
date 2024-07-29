using static FTSearchEngine.TokenizerNS.Tokenizer;

namespace FTSearchEngine;

public class Program {
    public static void Main() {
        var tokens = Tokenize("english", "It's alive! It's alive!");

        foreach (var token in tokens)
            Console.WriteLine(token);
    }
}