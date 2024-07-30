using FTSearchEngine.Stemming;

namespace FTSearchEngine.Tokenizing.Lang;

public abstract class Language {
    public abstract List<string> StopWords { get; }
    public abstract Stemmer Stemmer { get; }
}