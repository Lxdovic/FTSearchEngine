using FTSearchEngine.Tokenizing;

namespace FTSearchEngine;

public static class Program {
    public static void Main() {
        var index = new Indexing.InvertedIndex();
        
        index.IndexDocument("The quick brown fox jumps over the lazy dog.");
        index.IndexDocument("The quick brown fox jumps over the lazy dog and the lazy cat.");
        index.IndexDocument("The quick brown fox jumps over the lazy dog and the lazy cat. The quick brown fox jumps over the lazy dog and the lazy cat.");
        
        var results = index.Search("cat");
        
        foreach (var (word, documents) in results) {
            Console.WriteLine($"Word: {word}");
            Console.WriteLine("Documents:");
            foreach (var document in documents) {
                Console.WriteLine(document);
            }
        }
    }
}