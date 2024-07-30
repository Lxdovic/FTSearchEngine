using FTSearchEngine.Lang;
using Snowball;

namespace FTSearchEngine.Tokenizing;

public static class Tokenizer {
    public static string[] Tokenize(string language, string input) {
        var lang = Languages.SupportedLanguages[language];
        var sentence = input.ToLower();

        var stemmer = new EnglishStemmer();

        Languages.Splitters.TryGetValue(language, out var splitter);
        if (splitter == null) throw new Exception($"Splitter not found for language {language}");

        var tokens = new List<string>();

        splitter
            .Split(sentence)
            .Where(token => !lang.StopWords.Contains(token))
            .ToList()
            .ForEach(token => tokens.Add(stemmer.Stem(token)));

        return tokens.Distinct().ToArray();
    }
}