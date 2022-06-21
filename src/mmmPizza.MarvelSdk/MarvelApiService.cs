using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using Flurl;
using Flurl.Http;

namespace mmmPizza.MarvelSdk;

public class MarvelApiService
{
    // Private Properties
    private readonly JsonSerializerOptions _jsonOptions = default!;
    private readonly string _privateApiKey = default!;
    private readonly string _publicApiKey = default!;

    private long _currentTimeStamp;


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




    private void SetTimeStamp()
    {
        _currentTimeStamp = DateTimeOffset.Now.ToUnixTimeSeconds();
    }
    private long GetTimeStamp()
    {
        if (_currentTimeStamp == default) SetTimeStamp();
        return _currentTimeStamp;
    }
    private string GetHash()
    {
        byte[] hashBytes;
        using (MD5 md5 = MD5.Create())
        {
            hashBytes = md5
                .ComputeHash(Encoding.UTF8.GetBytes($"{_currentTimeStamp}{_privateApiKey}{_publicApiKey}"));
        }

        return BitConverter.ToString(hashBytes).Replace("-", string.Empty).ToLower();
    }
}
