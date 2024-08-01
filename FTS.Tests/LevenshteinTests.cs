using FTSearchEngine.Matching;

namespace FTS.Tests;

public class LevenshteinTests {
    [Fact]
    public void DistanceIsCorrect() {
        Assert.Equal(0, Levenshtein.Distance("", ""));
        Assert.Equal(0, Levenshtein.Distance("different", "different"));
        Assert.Equal(2, Levenshtein.Distance("maison", "macon"));
        Assert.Equal(4, Levenshtein.Distance("niche", "chien"));
        Assert.Equal(3, Levenshtein.Distance("example", "samples"));
        Assert.Equal(6, Levenshtein.Distance("forward", "drawrof"));
        Assert.Equal(6, Levenshtein.Distance("levenshtein", "frankenstein"));
    }
}