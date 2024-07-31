using FTSearchEngine.Tokenizing.Lang;

namespace FTSearchEngine.Tokenizing;

public static class Tokenizer {
    public static string[] Tokenize(SupportedLanguages language, string input) {
        var lang = Languages.Get(language);
        var sentence = input.ToLower();

        Languages.Splitters.TryGetValue(language, out var splitter);

        if (splitter == null) throw new Exception($"Splitter not found for language {language}");

        return splitter
            .Split(sentence)
            .Where(token => !lang.StopWords.Contains(token))
            .Select(token => lang.Stemmer.Stem(token))
            .Distinct()
            .ToArray();
    }
}