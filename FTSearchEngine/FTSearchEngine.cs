using FTSearchEngine.Indexing;
using FTSearchEngine.Tokenizing.Lang;

namespace FTSearchEngine;

public class FtSearchEngine {
    // public InvertedIndex? InvertedIndex { get; }

    public FtSearchEngine(SupportedLanguages language /*, bool useFuzzySearch = true*/) {
        Language = language;
        // UseFuzzySearch = useFuzzySearch;

        /*if (useFuzzySearch)*/
        BkTree = new BkTree(language);
        // else InvertedIndex = new InvertedIndex(language);
    }

    public SupportedLanguages Language { get; }

    // public bool UseFuzzySearch { get; }
    public BkTree? BkTree { get; }

    public void AddDocument(string document) {
        /*if (UseFuzzySearch)*/
        BkTree?.AddDocument(document);
        // else InvertedIndex?.IndexDocument(document);
    }

    public List<(string word, int score)> Search(string query, int maxDistance = 1) {
        /*if (UseFuzzySearch)*/
        return BkTree?
                   .Search(query, maxDistance)
                   .Select(result => (result.Key, result.Value))
                   .ToList() ??
               new List<(string Key, int Value)>();
        // else return InvertedIndex?.Search(query).SelectMany(result => result.documents).ToList() ?? new();
    }
}