using System.Text.Json;
using FluentMarvelSdk;
using Microsoft.Extensions.Configuration;

IConfiguration _configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", false, true)
    .Build();


var serializerOptions = new JsonSerializerOptions()
{
    WriteIndented = true
};


var api = new MarvelApiService(_configuration["Marvel:PrivateKey"], _configuration["Marvel:PublicKey"]);


var comics = api.GetCharacters()
    .Excelsior()
    .Result;

var comicsFilterd = api.GetComics()
    //.WithTitleStartingWith("The Amazing Spider-Man")
    .RemoveVariants()
    .InFormatOf(ComicFormats.Comic)
    .InFormatTypeOf(ComicFormatTypes.Comic)
    //.InDateRange(new DateOnly(2022,01,01), new DateOnly(2022,07,01))
    //.WithinRecent(DateDescriptors.ThisMonth)
    //.WithIssueNumber(100)
    //.WithUpc("75960620200300211")
    //.WithTitle("The Amazing Spider-Man (2022) #4") // Seems to not be working on Marvel's end
    //.StartingWithSeriesYear(2022)
    //.InSeries(1987, 1991) //1987
    //.WithAnyCharacters(1009220, 1017575)
    .WithAllCharacters(1009220, 1017575)
    .LimitResultsBy(5)
    .Excelsior()
    .Result;


foreach (var c in comicsFilterd.Results)
{
    Console.WriteLine($"{c.Id} {c.Dates.FirstOrDefault().Date} {c.Title} {c.IssueNumber} {c.Series.ResourceUri}");

}