using System.Text.Json;
using Flurl;
using Flurl.Http;

namespace mmmPizza.MarvelSdk;

public partial class MarvelApiService
{
    // Public Methods
    public async Task<DataWrapper<Comic>> GetComics()
    {
        SetTimeStamp();

        Flurl.Url comicsUrl = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Comics)
            .SetQueryParam("ts", _currentTimeStamp)
            .SetQueryParam("apikey", _publicApiKey)
            .SetQueryParam("hash", GetHash());

        var response = comicsUrl
            .GetAsync()
            .Result
            .ThrowOnError();

        if (response.StatusCode != 200) throw new Exception();

        string json = await response.GetStringAsync();
        json = json.Replace("-0001-11-30T00:00:00-0500", "1900-01-01T00:00:00-00:00");

        DataWrapper<Comic> comics = JsonSerializer.Deserialize<DataWrapper<Comic>>(json, _jsonOptions);

        return comics;
    }
}
