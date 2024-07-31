using FTSearchEngine.Tokenizing;
using FTSearchEngine.Tokenizing.Lang;

namespace FTSearchEngine.Indexing;

public class BkNode(string word, object originalDocument) {
    public string Word { get; set; } = word;
    public Dictionary<int, BkNode> Children { get; } = new();
    public object OriginalDocument { get; set; } = originalDocument;

    public BkNode GetChild(int distance) {
        return Children[distance];
    }

    public void AddChild(int distance, BkNode node) {
        Children.Add(distance, node);
    }

    public void Search(string word, int maxDistance, List<Result> results) {
        var distance = Levenshtein.Distance(Word, word);

        if (distance <= maxDistance)
            results.Add(new Result {
                Word = Word,
                OriginalDocument = OriginalDocument,
                Score = distance
            });

        var start = distance - maxDistance;
        var end = distance + maxDistance;

        for (var i = start; i <= end; i++)
            if (Children.ContainsKey(i))
                Children[i].Search(word, maxDistance, results);
    }
}

public class BkTree(SupportedLanguages language) {
    private BkNode? Root { get; set; }
    public SupportedLanguages Language { get; } = language;

    public void AddDocument<T>(string content, T originalDocument) {
        var tokens = Tokenizer.Tokenize(Language, content);

        foreach (var token in tokens) AddWord(token, originalDocument);
    }

    public void AddWord<T>(string word, T originalDocument) {
        if (Root == null) {
            Root = new BkNode(word, originalDocument);

            return;
        }

        AddWord(Root, word, originalDocument);
    }

    private void AddWord<T>(BkNode parent, string word, T originalDocument) {
        var distance = Levenshtein.Distance(parent.Word, word);

        if (parent.Children.ContainsKey(distance)) {
            AddWord(parent.GetChild(distance), word, originalDocument);

            return;
        }

        parent.AddChild(distance, new BkNode(word, originalDocument));
    }

    public List<Result> Search(string query, int maxDistance) {
        if (Root == null) return new List<Result>();

        var tokens = Tokenizer.Tokenize(Language, query);

        return tokens.SelectMany(token => SearchWord(token, maxDistance)).ToList();
    }

    public List<Result> SearchWord(string word, int maxDistance) {
        if (Root == null) return new List<Result>();

        List<Result> results = new();

        Root.Search(word, maxDistance, results);

        return results.OrderBy(x => x.Score).ToList();
    }
}

public struct Result {
    public string Word { get; set; }
    public int Score { get; set; }
    public object OriginalDocument { get; set; }
}