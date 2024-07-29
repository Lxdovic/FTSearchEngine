using System.Text.RegularExpressions;

namespace FTSearchEngine.Tokenizer.Languages;

public static class Languages {
    public static readonly Dictionary<string, string> Stemmers = new() {
        { "arabic", "ar" },
        { "armenian", "am" },
        { "bulgarian", "bg" },
        { "danish", "dk" },
        { "dutch", "nl" },
        { "english", "en" },
        { "finnish", "fi" },
        { "french", "fr" },
        { "german", "de" },
        { "greek", "gr" },
        { "hungarian", "hu" },
        { "indian", "in" },
        { "indonesian", "id" },
        { "irish", "ie" },
        { "italian", "it" },
        { "lithuanian", "lt" },
        { "nepali", "np" },
        { "norwegian", "no" },
        { "portuguese", "pt" },
        { "romanian", "ro" },
        { "russian", "ru" },
        { "serbian", "rs" },
        { "slovenian", "ru" },
        { "spanish", "es" },
        { "swedish", "se" },
        { "tamil", "ta" },
        { "turkish", "tr" },
        { "ukrainian", "uk" },
        { "sanskrit", "sk" }
    };

    private static readonly Dictionary<string, Regex?> Splitters = new() {
        { "dutch", new Regex("[^A-Za-zàèéìòóù0-9_'-]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { "english", new Regex("[^A-Za-zàèéìòóù0-9_'-]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { "french", new Regex("[^a-z0-9äâàéèëêïîöôùüûœç-]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { "italian", new Regex("[^A-Za-zàèéìòóù0-9_'-]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { "norwegian", new Regex("[^a-z0-9_æøåÆØÅäÄöÖüÜ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { "portuguese", new Regex("[^a-z0-9à-úÀ-Ú]", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { "russian", new Regex("[^a-z0-9а-яА-ЯёЁ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { "spanish", new Regex("[^a-z0-9A-Zá-úÁ-ÚñÑüÜ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { "swedish", new Regex("[^a-z0-9_åÅäÄöÖüÜ-]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { "german", new Regex("[^a-z0-9A-ZäöüÄÖÜß]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { "finnish", new Regex("[^a-z0-9äöÄÖ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { "danish", new Regex("[^a-z0-9æøåÆØÅ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { "hungarian", new Regex("[^a-z0-9áéíóöőúüűÁÉÍÓÖŐÚÜŰ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { "romanian", new Regex("[^a-z0-9ăâîșțĂÂÎȘȚ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { "serbian", new Regex("[^a-z0-9čćžšđČĆŽŠĐ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { "turkish", new Regex("[^a-z0-9çÇğĞıİöÖşŞüÜ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { "lithuanian", new Regex("[^a-z0-9ąčęėįšųūžĄČĘĖĮŠŲŪŽ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { "arabic", new Regex("[^a-z0-9أ-ي]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { "nepali", new Regex("[^a-z0-9अ-ह]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { "irish", new Regex("[^a-z0-9áéíóúÁÉÍÓÚ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { "indian", new Regex("[^a-z0-9अ-ह]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { "armenian", new Regex("[^a-z0-9ա-ֆ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { "greek", new Regex("[^a-z0-9α-ωά-ώ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { "indonesian", new Regex("[^a-z0-9]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { "ukrainian", new Regex("[^a-z0-9а-яА-ЯіїєІЇЄ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { "slovenian", new Regex("[^a-z0-9čžšČŽŠ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { "bulgarian", new Regex("[^a-z0-9а-яА-Я]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { "tamil", new Regex("[^a-z0-9அ-ஹ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { "sanskrit", new Regex("[^a-z0-9A-Zāīūṛḷṃṁḥśṣṭḍṇṅñḻḹṝ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) }
    };

    private static readonly List<string> SupportedLanguages = Stemmers.Keys.ToList();

    public static void GetSplitter(string language, out Regex? splitter) {
        Splitters.TryGetValue(language, out splitter);
    }
}