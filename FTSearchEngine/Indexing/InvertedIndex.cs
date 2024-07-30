using FTSearchEngine.Tokenizing;

namespace FTSearchEngine.Indexing;

public class InvertedIndex {
    public List<string> Documents = new();
    public Dictionary<string, List<int>> Indices = new();

    public void IndexDocument(string document) {
        var tokens = Tokenizer.Tokenize("english", document);

        Documents.Add(document);

        foreach (var token in tokens) {
            if (!Indices.ContainsKey(token))
                Indices[token] = new List<int>();

            Indices[token].Add(Documents.Count);
        }
    }

    public List<(string word, List<string> documents)> Search(string query) {
        var tokens = Tokenizer.Tokenize("english", query);
        var results = new List<(string word, List<string> documents)>();

        foreach (var token in tokens)
            if (Indices.ContainsKey(token))
                results.Add((token, Indices[token].Select(index => Documents[index - 1]).ToList()));

        return results;
    }
}