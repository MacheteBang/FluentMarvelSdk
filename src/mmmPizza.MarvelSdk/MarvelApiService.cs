using System.Text.Json;
using Flurl.Http;

namespace mmmPizza.MarvelSdk;

public partial class MarvelApiService
{
    // Private Properties
    private readonly JsonSerializerOptions _jsonOptions = default!;
    private readonly string _privateApiKey = default!;
    private readonly string _publicApiKey = default!;


    // Constructors
    private MarvelApiService() { }
    public MarvelApiService(string privateApiKey, string publicApiKey)
    {
        ArgumentNullException.ThrowIfNull(privateApiKey);
        ArgumentNullException.ThrowIfNull(publicApiKey);

        _privateApiKey = privateApiKey;
        _publicApiKey = publicApiKey;

        _jsonOptions = new()
        {
            PropertyNameCaseInsensitive = true
        };
        _jsonOptions.Converters.Add(new MarvelDateTimeConverter("yyyy-MM-ddTHH:mm:ssK"));
    }


    // Private Methods
    private async Task<DataContainer<T>?> GetResourceAsync<T>(Flurl.Url url)
    {
        url.AppendAuthorization(_privateApiKey, _publicApiKey);

        var response = url
            .AllowAnyHttpStatus()
            .GetAsync()
            .Result
            .ThrowOnError();

        if (response.StatusCode != 200) throw new Exception();

        string json = await response.GetStringAsync();
        json = json.Replace("-0001-11-30T00:00:00-0500", "1900-01-01T00:00:00-00:00");

        DataWrapper<T> wrapper = JsonSerializer.Deserialize<DataWrapper<T>>(json, _jsonOptions);

        return wrapper?.Data;
    }
}
