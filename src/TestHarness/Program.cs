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

var characters = await api.GetCharacters()
    .LimitResultsBy(10)
    .Excelsior();


Console.WriteLine();