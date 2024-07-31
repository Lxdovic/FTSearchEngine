using FTSearchEngine.Indexing;
using FTSearchEngine.Tokenizing.Lang;

namespace FTS.Tests.Indexing;

public class BkTreeTests {
    [Fact]
    public void BkTreeShouldReturnSimilarWords() {
        var tree = new BkTree(SupportedLanguages.English);

        string[] documents = [
            "book books nook nooks b boo bo bookies",
            "hook"
        ];

        foreach (var document in documents) tree.AddDocument(document, document);

        var results = tree.Search("book", 1);

        List<Result> correctResult = [
            new Result { Word = "book", Score = 0, OriginalDocument = documents[0] },
            new Result { Word = "books", Score = 1, OriginalDocument = documents[0] },
            new Result { Word = "booki", Score = 1, OriginalDocument = documents[0] }, // stemmer{bookies) -> booki
            new Result { Word = "nook", Score = 1, OriginalDocument = documents[0] },
            new Result { Word = "boo", Score = 1, OriginalDocument = documents[0] },
            new Result { Word = "hook", Score = 1, OriginalDocument = documents[1] }
        ];

        foreach (var result in results) Assert.Contains(result, correctResult);
    }
}