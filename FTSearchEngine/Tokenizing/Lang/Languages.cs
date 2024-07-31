using System.Text.RegularExpressions;

namespace FTSearchEngine.Tokenizing.Lang;

public enum SupportedLanguages {
    Arabic,
    Armenian,
    Danish,
    Dutch,
    English,
    Finnish,
    French,
    German,
    Greek,
    Hungarian,
    Irish,
    Italian,
    Lithuanian,
    Nepali,
    Norwegian,
    Portuguese,
    Romanian,
    Russian,
    Serbian,
    Spanish,
    Swedish,
    Tamil,
    Turkish
}

public static class Languages {
    private static readonly Dictionary<SupportedLanguages, Language> InternalLanguages = new() {
        { SupportedLanguages.Arabic, new Arabic() },
        { SupportedLanguages.Armenian, new Armenian() },
        { SupportedLanguages.Danish, new Danish() },
        { SupportedLanguages.Dutch, new Dutch() },
        { SupportedLanguages.English, new English() },
        { SupportedLanguages.Finnish, new Finnish() },
        { SupportedLanguages.French, new French() },
        { SupportedLanguages.German, new German() },
        { SupportedLanguages.Greek, new Greek() },
        { SupportedLanguages.Hungarian, new Hungarian() },
        { SupportedLanguages.Irish, new Irish() },
        { SupportedLanguages.Italian, new Italian() },
        { SupportedLanguages.Lithuanian, new Lithuanian() },
        { SupportedLanguages.Nepali, new Nepali() },
        { SupportedLanguages.Norwegian, new Norwegian() },
        { SupportedLanguages.Portuguese, new Portuguese() },
        { SupportedLanguages.Romanian, new Romanian() },
        { SupportedLanguages.Russian, new Russian() },
        { SupportedLanguages.Serbian, new Serbian() },
        { SupportedLanguages.Spanish, new Spanish() },
        { SupportedLanguages.Swedish, new Swedish() },
        { SupportedLanguages.Tamil, new Tamil() },
        { SupportedLanguages.Turkish, new Turkish() }
    };

    public static readonly Dictionary<SupportedLanguages, Regex> Splitters = new() {
        {
            SupportedLanguages.Dutch,
            new Regex("[^A-Za-zàèéìòóù0-9_'-]+", RegexOptions.Multiline | RegexOptions.IgnoreCase)
        }, {
            SupportedLanguages.English,
            new Regex("[^A-Za-zàèéìòóù0-9_'-]+", RegexOptions.Multiline | RegexOptions.IgnoreCase)
        }, {
            SupportedLanguages.French,
            new Regex("[^a-z0-9äâàéèëêïîöôùüûœç-]+", RegexOptions.Multiline | RegexOptions.IgnoreCase)
        }, {
            SupportedLanguages.Italian,
            new Regex("[^A-Za-zàèéìòóù0-9_'-]+", RegexOptions.Multiline | RegexOptions.IgnoreCase)
        }, {
            SupportedLanguages.Norwegian,
            new Regex("[^a-z0-9_æøåÆØÅäÄöÖüÜ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase)
        }, {
            SupportedLanguages.Portuguese,
            new Regex("[^a-z0-9à-úÀ-Ú]", RegexOptions.Multiline | RegexOptions.IgnoreCase)
        }, {
            SupportedLanguages.Russian,
            new Regex("[^a-z0-9а-яА-ЯёЁ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase)
        }, {
            SupportedLanguages.Spanish,
            new Regex("[^a-z0-9A-Zá-úÁ-ÚñÑüÜ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase)
        }, {
            SupportedLanguages.Swedish,
            new Regex("[^a-z0-9_åÅäÄöÖüÜ-]+", RegexOptions.Multiline | RegexOptions.IgnoreCase)
        }, {
            SupportedLanguages.German,
            new Regex("[^a-z0-9A-ZäöüÄÖÜß]+", RegexOptions.Multiline | RegexOptions.IgnoreCase)
        },
        { SupportedLanguages.Finnish, new Regex("[^a-z0-9äöÄÖ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { SupportedLanguages.Danish, new Regex("[^a-z0-9æøåÆØÅ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) }, {
            SupportedLanguages.Hungarian,
            new Regex("[^a-z0-9áéíóöőúüűÁÉÍÓÖŐÚÜŰ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase)
        }, {
            SupportedLanguages.Romanian,
            new Regex("[^a-z0-9ăâîșțĂÂÎȘȚ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase)
        }, {
            SupportedLanguages.Serbian,
            new Regex("[^a-z0-9čćžšđČĆŽŠĐ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase)
        }, {
            SupportedLanguages.Turkish,
            new Regex("[^a-z0-9çÇğĞıİöÖşŞüÜ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase)
        }, {
            SupportedLanguages.Lithuanian,
            new Regex("[^a-z0-9ąčęėįšųūžĄČĘĖĮŠŲŪŽ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase)
        },
        { SupportedLanguages.Arabic, new Regex("[^a-z0-9أ-ي]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { SupportedLanguages.Nepali, new Regex("[^a-z0-9अ-ह]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) }, {
            SupportedLanguages.Irish,
            new Regex("[^a-z0-9áéíóúÁÉÍÓÚ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase)
        },
        { SupportedLanguages.Armenian, new Regex("[^a-z0-9ա-ֆ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { SupportedLanguages.Greek, new Regex("[^a-z0-9α-ωά-ώ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) },
        { SupportedLanguages.Tamil, new Regex("[^a-z0-9அ-ஹ]+", RegexOptions.Multiline | RegexOptions.IgnoreCase) }
    };

    public static Language Get(SupportedLanguages language) {
        return InternalLanguages[language];
    }
}