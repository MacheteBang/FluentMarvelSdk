using System.Text.Json;
using Microsoft.Extensions.Configuration;
using mmmPizza.MarvelSdk;
using Spectre.Console;

IConfiguration _configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", false, true)
    .Build();

AnsiConsole.MarkupLine("[bold red] Marvel SDK Test Harness[/]");
AnsiConsole.MarkupLine("Creating instance...");
var api = MarvelApiService.Create(_configuration["Marvel:PrivateKey"],_configuration["Marvel:PublicKey"]);

AnsiConsole.MarkupLine("Getting all comics...");
var comics = await api.GetComics();

AnsiConsole.MarkupLine("Showing comics...");
AnsiConsole.MarkupLine(JsonSerializer.Serialize(comics));

AnsiConsole.Ask<string>("Any Key to Exit");