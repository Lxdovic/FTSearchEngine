using FTSearchEngine.Tokenizing;

namespace FTSearchEngine.Indexing;

public class WordIndex {
    public List<int> DocumentIds { get; } = new();

    public void AddDocumentId(int documentId) {
        DocumentIds.Add(documentId);
    }
}

public class InvertedIndex {
    public List<string> Documents = new();
    public Dictionary<string, WordIndex> Indices = new();

    public void IndexDocument(string document) {
        var tokens = Tokenizer.Tokenize("english", document);

        Documents.Add(document);

        foreach (var token in tokens) {
            if (!Indices.ContainsKey(token))
                Indices[token] = new WordIndex();

            Indices[token].AddDocumentId(Documents.Count);
        }
    }

    public List<(string word, WordIndex index)> Search(string query) {
        var tokens = Tokenizer.Tokenize("english", query);
        var results = new List<(string word, WordIndex index)>();

        foreach (var token in tokens)
            if (Indices.ContainsKey(token))
                results.Add((token, Indices[token]));

        return results;
    }
}