# FTSearchEngine

FTSearchEngine is a simple search engine that can be used to search for a word 
in one or many documents. It is part of a series of projects that I am working
on to learn more about how algorithms we use in the everyday life works.

This work is based on the talk of [Michele Riva](https://github.com/micheleriva) 
about [Writing a full-text search engine](https://www.youtube.com/watch?v=amSuoBKG1Ns)

## How it works

### Tokenization 

The idea behind tokenization is to normalize the data we want to search. It reduces memory usage by removing duplicates, meaningless words and so on. It is typically done in multiple steps.

1. Break the text down into individual words.
2. Remove any punctuation, accents, diacritics or special characters.
3. Lowercase the tokens (optional, but disallows case-sensitive search).
4. Remove stop-words (words that does not carry meaning)
5. Stemming - Normalize the tokens' meaning.
6. Remove duplicates

### Fuzzy Matching

One of the core components of this fuzzy matching algorithm is the **Levenshtein Distance** algorithm. It give the edit distance between two words given 3 operations (Deletion, Insertion, Replacement) Here's an example with the words "kitten" and "sitting":

- replace k with s.
- replace e with i.
- insert g at the end.

The edit distance between these two words is 3.

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
