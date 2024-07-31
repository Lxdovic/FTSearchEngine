using FTSearchEngine.Tokenizing.Lang;

namespace FTSearchEngine;

public static class Program {
    public static void Main() {
        var engine = new FtSearchEngine(SupportedLanguages.English);
        
        engine.AddDocument("book books nook nooks b boo bo bookies");
        
        var results = engine.Search("book", 1);

        foreach (var result in results) {
            Console.WriteLine($"{result.word} - {result.score}");
        }
    }
}