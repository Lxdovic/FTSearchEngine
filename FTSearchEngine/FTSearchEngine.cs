using FTSearchEngine.Indexing;
using FTSearchEngine.Tokenizing.Lang;

namespace FTSearchEngine;

public class FtSearchEngine(SupportedLanguages language) {
    private SupportedLanguages Language { get; } = language;
    private BkTree? BkTree { get; } = new(language);

    public void AddDocument<T>(T document, List<string>? fields = null) {
        var documentFields = typeof(T).GetProperties();

        foreach (var documentField in documentFields) {
            var value = documentField.GetValue(document)?.ToString();

            if (value == null) continue;

            if (fields == null) {
                BkTree?.AddDocument(value, document);
                continue;
            }

            if (fields.Contains(documentField.Name)) BkTree?.AddDocument(value, document);
        }
    }

    public void AddDocuments<T>(IEnumerable<T> documents, List<string>? fields = null) {
        foreach (var document in documents) AddDocument(document, fields);
    }

    public List<Result> Search(string query, int maxDistance = 1) {
        return BkTree?.Search(query, maxDistance) ??
               new List<Result>();
    }
}