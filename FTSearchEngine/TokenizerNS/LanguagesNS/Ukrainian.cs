namespace FTSearchEngine.Tokenizer.Languages;

public class Ukrainian : Language {
    public static string CountryCode { get; } = "uk";

    public override List<string> StopWords { get; } = [
        "з",
        "й",
        "що",
        "та",
        "Із",
        "але",
        "цей",
        "коли",
        "як",
        "чого",
        "хоча",
        "нам",
        "яко╞",
        "чи",
        "це",
        "в╡д",
        "про",
        "╡",
        "╞х",
        "╙",
        "Інших",
        "ти",
        "вІн",
        "вона",
        "воно",
        "ми",
        "ви",
        "вони"
    ];
}