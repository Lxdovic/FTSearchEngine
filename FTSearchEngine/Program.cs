using System.ComponentModel;
using System.Diagnostics;
using FTSearchEngine.Tokenizing.Lang;
using Newtonsoft.Json;

namespace FTSearchEngine;

public class User {
    public User(string name, string gender) {
        Name = name;
        Gender = gender;
    }

    public string Name { get; set; }
    public string Gender { get; set; }
}

public static class Program {
    public static readonly FtSearchEngine Engine = new(SupportedLanguages.English);

    public static void Main() {
        Console.WriteLine("Loading mock data...");
        
        var users = LoadMockData();
        
        Console.WriteLine("Indexing mock data...");
        
        if (users == null) return;
        
        Engine.AddDocuments(users.Slice(0, 3000), ["Name", "Gender"]);
        
        Repl();
    }

    public static void Repl() {
        while (true) {
            Console.WriteLine("Enter a query or 'exit' to quit:");
            Console.Write("> ");
            var query = Console.ReadLine();

            if (query == "exit") break;
            if (query == null) continue;

            Console.WriteLine($"Searching for '{query}' with a max distance of 2...");

            var watch = Stopwatch.StartNew();
            var results = Engine.Search(query, 2);

            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine($"Found {results.Count} entries in {elapsedMs}ms. Results:");

            foreach (var result in results) {
                Console.WriteLine($"{result.Word} - {result.Score} - Original Document: (");

                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(result.OriginalDocument)) {
                    var name = descriptor.Name;
                    var value = descriptor.GetValue(result.OriginalDocument);
                    Console.WriteLine($"    {name} = {value}");
                }

                Console.WriteLine(")");
            }
        }
    }

    public static List<User>? LoadMockData() {
        using (var r = new StreamReader(Path.Combine(Environment.CurrentDirectory, "resources/MOCK_DATA.json"))) {
            var json = r.ReadToEnd();
            var items = JsonConvert.DeserializeObject<List<User>>(json);

            return items;
        }
    }
}