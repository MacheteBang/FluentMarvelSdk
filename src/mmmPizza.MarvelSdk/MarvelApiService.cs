using System.Security.Cryptography;
using System.Text;
using Flurl;
using Flurl.Http;

namespace mmmPizza.MarvelSdk;

public class MarvelApiService
{
    // Constructor
    private MarvelApiService() { }


    // Private Properties
    private string _privateApiKey = default!;
    private string _publicApiKey = default!;

    private long _currentTimeStamp;


    public static MarvelApiService Create(string privateApiKey, string publicApiKey)
    {
        ArgumentNullException.ThrowIfNull(privateApiKey);
        ArgumentNullException.ThrowIfNull(publicApiKey);

        return new MarvelApiService
        {
            _privateApiKey = privateApiKey,
            _publicApiKey = publicApiKey
        };
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
        
        var response = await comicsUrl.GetAsync();
        if (response.StatusCode != 200) throw new Exception();
        
        string json = await response.GetJsonAsync();
        json = json.Replace("-0001-11-30T00:00:00-0500", "");

        DataWrapper<Comic> comics = System.Text.Json.JsonSerializer.Deserialize<DataWrapper<Comic>>(json);

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
