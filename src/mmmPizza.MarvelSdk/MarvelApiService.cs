using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace mmmPizza.MarvelSdk;

public partial class MarvelApiService
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


    // Private Methods
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
