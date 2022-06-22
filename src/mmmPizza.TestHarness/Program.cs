using System.Text.Json;
using Microsoft.Extensions.Configuration;
using mmmPizza.MarvelSdk;
using Spectre.Console;

IConfiguration _configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", false, true)
    .Build();

AnsiConsole.MarkupLine("[bold red] Marvel SDK Test Harness[/]");
AnsiConsole.MarkupLine("Creating instance...");
var api = new MarvelApiService(_configuration["Marvel:PrivateKey"], _configuration["Marvel:PublicKey"]);

AnsiConsole.MarkupLine("Getting all comics...");
var characters = await api.GetCharactersAsync(new CharacterOptions
{
    NameStartsWith = "Spider",
    Comics = new int[] { 123, 456 }
});


Console.WriteLine(JsonSerializer.Serialize(characters));

