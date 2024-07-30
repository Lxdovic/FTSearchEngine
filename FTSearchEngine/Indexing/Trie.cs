namespace FTSearchEngine.Indexing;

public class TrieNode(char? character, TrieNode? parent = null, bool isLeaf = false, bool isRoot = false) {
    public char? Character { get; } = character;
    public bool IsRoot { get; } = isRoot;
    public bool IsLeaf { get; set; } = isLeaf;
    public Dictionary<string, TrieNode> Children { get; } = new();
    public TrieNode? Parent { get; set; } = parent;
}

public class Trie {
    public readonly TrieNode Root = new('@', null, false, true);

    public void Insert(string word) {
        if (string.IsNullOrEmpty(word)) return;

        var node = Root;

        foreach (var c in word) {
            var character = c.ToString();

            if (node.Children.TryGetValue(character, out var child)) {
                node = child;

                continue;
            }

            var newNode = new TrieNode(c, node);

            node.Children.Add(character, newNode);
            node = newNode;
        }

        node.IsLeaf = true;
    }

    public List<string> Search(string word) {
        var node = Root;
        var result = new List<string>();

        foreach (var c in word) {
            var character = c.ToString();

            if (node.Children.TryGetValue(character, out var child)) {
                node = child;

                continue;
            }

            return result;
        }

        return result;
    }

    public void Print(TrieNode node) {
        Console.WriteLine(
            $"Character: {node.Character}, parent: {node.Parent?.Character}, isLeaf: {node.IsLeaf}, isRoot: {node.IsRoot}");

        foreach (var (character, child) in node.Children) Print(child);
    }
}