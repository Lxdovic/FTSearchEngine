using FTSearchEngine.TokenizerNS.LanguagesNS;

namespace FTSearchEngine.TokenizerNS;

public static class Tokenizer {
    public static string[] Tokenize(string language, string input) {
        var lang = Languages.SupportedLanguages[language];
        var sentence = input.ToLower();

        Languages.Splitters.TryGetValue(language, out var splitter);
        if (splitter == null) throw new Exception($"Splitter not found for language {language}");

        var tokens = splitter
            .Split(sentence)
            .Where(token => !lang.StopWords.Contains(token))
            .Distinct();

        return tokens.ToArray();
    }
}