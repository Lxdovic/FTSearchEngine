namespace FTSearchEngine.Tokenizer.Languages;

public abstract class Language {
    public abstract List<string> StopWords { get; }
}