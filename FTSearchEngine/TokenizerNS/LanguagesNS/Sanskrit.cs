namespace FTSearchEngine.Tokenizer.Languages;

public class Sanskrit : Language {
    public static string CountryCode { get; } = "sk";

    public override List<string> StopWords { get; } = [
        "ahaṃ",
        "tava",
        "tvayi",
        "svayam",
        "vayam",
        "asmān",
        "nas",
        "yat",
        "yaḥ",
        "kiṃ",
        "kaḥ",
        "saḥ",
        "taḥ",
        "tasya",
        "tasmai",
        "asya",
        "tat",
        "tad",
        "tatra",
        "katham",
        "yadi",
        "vā",
        "athavā",
        "evaṃ",
        "na",
        "api",
        "atha",
        "sama",
        "santu",
        "antaḥ",
        "antar",
        "ubhau"
    ];
}