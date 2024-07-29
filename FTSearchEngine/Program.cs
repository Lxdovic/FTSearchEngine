using FTSearchEngine.Indexing;
using static FTSearchEngine.TokenizerNS.Tokenizer;

namespace FTSearchEngine;

public static class Program {
    public static void Main() {
        var invertedIndex = new InvertedIndex();
        
        invertedIndex.IndexDocument("Hello, world!");
        invertedIndex.IndexDocument("Hello, Jacob!");
        invertedIndex.IndexDocument("Goodbye!");
        
        invertedIndex.Search("Hello").ForEach(result => {
            Console.WriteLine($"Word: {result.word}");
            Console.WriteLine($"Document IDs: {string.Join(", ", result.index.DocumentIds)}");
        });
    }
}