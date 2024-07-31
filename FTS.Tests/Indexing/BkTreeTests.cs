using FTSearchEngine.Indexing;

namespace FTS.Tests.Indexing;

public class BkTreeTests {
    [Fact]
    public void BkTreeShouldReturnSimilarWords() {
        var tree = new BkTree();

        tree.AddDocument("book books nook nooks b boo bo bookies");
        tree.AddWord("hook");

        var results = tree.Search("book", 1);

        List<KeyValuePair<string, int>> correctResult = [
            new KeyValuePair<string, int>("book", 0),
            new KeyValuePair<string, int>("books", 1),
            new KeyValuePair<string, int>("booki", 1), // stemmer(bookies) -> booki
            new KeyValuePair<string, int>("nook", 1),
            new KeyValuePair<string, int>("boo", 1),
            new KeyValuePair<string, int>("hook", 1)
        ];

        foreach (var result in results) Assert.Contains(result, correctResult);
    }
}