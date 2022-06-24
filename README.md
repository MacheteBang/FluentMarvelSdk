# 💥 Fluent Marvel API
The goal of this project is to make access to the Marvel Comics API as simple as possible using the .NET framework.

This is .NET Core 6.0 class library fluently designed to access data via the official [Marvel Comic API](https://developer.marvel.com/docs).

**This is a work in progress repo, and is subject to change while it is before 1.0. Especially since, as of this writing, there isn't actually a NuGet package yet!**

## Background
The intention of this repository is to build a modern SDK using a [Fluent Interface](https://en.wikipedia.org/wiki/Fluent_interface) design pattern to view all of the data available via the Marvel Comics API. This is an exercise in learning for me, but my goal is to make this as robust as possible.

In order to use this SDK, you'll have to register for your own account at the [Marvel Developer Portal](https://developer.marvel.com/).

In sync with the API, this supports the following resources:
* Comics 📔
* Characters ⛹️
* Series 📚
* Stories 🧚
* Events 🎟️
* Creators ✍🏽

## Installation 🚧
_For now_, you'll have to incorporate this library directly into your source code.  That is not the ultimate intention, but during active development, I am hesitant to publish a NuGet package - at least till things are stable!

## Usage
Instantiating a new api service class:
```cs
string privateKey = "abcdefg"; // Add yours here
string publicKey = "zyxwvut"; // Add yours here

var marvelApi = MarvelApiService(privateKey, privateKey);
```

Querying the data can be done via a series of chained method calls.  Each of these method calls continues to refine the builder and filter the ultimate query results.

The final method call (`Excelsior()`) executes the query against the API and returns the results.

```cs
var amazingSpiderMan69 = await marvelApi.GetComics()
    .WithTitleStartingWith("The Amazing Spider-Man")
    .WithIssueNumber(69)
    .StartingWithSeriesYear(1963)
    .InFormatOf(ComicFormats.Comic)
    .Excelsior();
```

Additionally, the API can cross reference multiple resources with each other.  For example, query for the top 5 comics that are not a variant where both Captain America (Steve Rogers) `1009220` and Captain America (Sam Wilson) `1017575` appear together.

```cs
var comicsWithSteveAndSam = await marvelApi.GetComics()
    .RemoveVariants()
    .WithAllCharacters(1009220, 1017575)
    .LimitResultsBy(5)
    .Excelsior()
```

## Contributing
Issue creation and pull requests are welcome.  As stated earlier, this was born out of learning more, so I'm encouraging others to contribute by "fixing" my code to make it better.

As well as add new features!

## Credits
* [Flurl.dev](https://flurl.dev) - Flurl makes http requests _extremely_ simple allow one to build (and ultimately) execute http url using a Fluent design pattern.
* [SmartEnum](https://github.com/ardalis/SmartEnum) - Allows detailed creation and management of enumerators.