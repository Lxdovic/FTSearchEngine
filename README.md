# FTSearchEngine

FTSearchEngine is a simple search engine that can be used to search for a word 
in one or many documents. It is part of a series of projects that I am working
on to learn more about how algorithms we use in the everyday life works.

This work is based on the talk of [Michele Riva](https://github.com/micheleriva) 
about [Writing a full-text search engine](https://www.youtube.com/watch?v=amSuoBKG1Ns)

## How it works

When setting up the search engine, you typically give it a list of documents
that you want to search in. The search engine will then index these documents
using data structures like **Inverted Index** or **Trie** which allows for fast
searching. Before indexing the documents, the search engine will process every
document in order to normalize it and keep only the meaningful information. 

Tokenization is typically done in multiple steps.

1. Break the given sentence down into individual words.
2. Remove any punctuation, accents, diacritics or special characters.
3. Lowercase the tokens (optional, but disallows case-sensitive search).
4. Remove stop-words (words that does not carry meaning)
5. Stemming - Normalize the tokens' meaning.
6. Remove duplicates

After the indexing, the engine will be ready for a search query. The search
query will be processed in the same way as the documents, and then the search
engine will look up the tokens in the index and return the documents that
contains the tokens.

## How to use

Make sure you have C# and .NET Core 8 installed on your machine. You can check
if you have it installed by running the following command in your terminal.

```sh
dotnet --version
```

If you don't have it installed, you can download it from the official website
[.NET Core](https://dotnet.microsoft.com/download)

Then, clone the repository and run the project

```sh
git clone https://github.com/Lxdovic/FTSearchEngine
cd FTSearchEngine
dotnet run
```