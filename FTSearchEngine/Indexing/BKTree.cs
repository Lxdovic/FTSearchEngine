using FTSearchEngine.Tokenizing;
using FTSearchEngine.Tokenizing.Lang;

namespace FTSearchEngine.Indexing;

public class BkNode(string word) {
    public string Word { get; set; } = word;
    public Dictionary<int, BkNode> Children { get; } = new();

    public BkNode GetChild(int distance) {
        return Children[distance];
    }

    public void AddChild(int distance, BkNode node) {
        Children.Add(distance, node);
    }

    public void Search(string word, int maxDistance, Dictionary<string, int> results) {
        var distance = Levenshtein.Distance(Word, word);

        if (distance <= maxDistance) results.TryAdd(Word, distance);

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

    public void AddDocument(string document) {
        var tokens = Tokenizer.Tokenize(Language, document);

        foreach (var token in tokens) AddWord(token);
    }

    public void AddWord(string word) {
        if (Root == null) {
            Root = new BkNode(word);

            return;
        }

        AddWord(Root, word);
    }

    private void AddWord(BkNode parent, string word) {
        var distance = Levenshtein.Distance(parent.Word, word);

        if (parent.Children.ContainsKey(distance)) {
            AddWord(parent.GetChild(distance), word);

            return;
        }

        parent.AddChild(distance, new BkNode(word));
    }

    public List<KeyValuePair<string, int>> Search(string query, int maxDistance) {
        if (Root == null) return new List<KeyValuePair<string, int>>();

        var tokens = Tokenizer.Tokenize(Language, query);

        return tokens.SelectMany(token => SearchWord(token, maxDistance)).ToList();
    }

    public List<KeyValuePair<string, int>> SearchWord(string word, int maxDistance) {
        if (Root == null) return new List<KeyValuePair<string, int>>();

        Dictionary<string, int> results = new();

        Root.Search(word, maxDistance, results);

        return results.OrderBy(x => x.Value).ToList();
    }
}