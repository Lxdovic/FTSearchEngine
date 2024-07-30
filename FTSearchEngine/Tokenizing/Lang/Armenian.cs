using FTSearchEngine.Stemming;
using Snowball;

namespace FTSearchEngine.Tokenizing.Lang;

public class Armenian : Language {
    public static string CountryCode { get; } = "am";
    public override Stemmer Stemmer { get; } = new ArmenianStemmer();

    public override List<string> StopWords { get; } = [
        "այդ",
        "այլ",
        "այն",
        "այս",
        "դու",
        "դուք",
        "եմ",
        "են",
        "ենք",
        "ես",
        "եք",
        "է",
        "էի",
        "էին",
        "էինք",
        "էիր",
        "էիք",
        "էր",
        "ըստ",
        "թ",
        "ի",
        "ին",
        "իսկ",
        "իր",
        "կամ",
        "համար",
        "հետ",
        "հետո",
        "մենք",
        "մեջ",
        "մի",
        "ն",
        "նա",
        "նաև",
        "նրա",
        "նրանք",
        "որ",
        "որը",
        "որոնք",
        "որպես",
        "ու",
        "ում",
        "պիտի",
        "վրա",
        "և"
    ];
}