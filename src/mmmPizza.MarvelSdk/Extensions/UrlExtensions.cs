using System.Security.Cryptography;
using System.Text;

namespace mmmPizza.MarvelSdk;

internal static class UrlExtensions
{
    internal static Flurl.Url AppendAuthorization(this Flurl.Url url, string privateKey, string publicKey)
    {
        long timeStamp = DateTimeOffset.Now.ToUnixTimeSeconds();
        string hash = GetHash(timeStamp, privateKey, publicKey);

        return url
            .SetQueryParam("ts", timeStamp)
            .SetQueryParam("apikey", publicKey)
            .SetQueryParam("hash", hash);
    }



    private static string GetHash(long timeStamp, string privateKey, string publicKey)
    {
        byte[] hashBytes;
        using (MD5 md5 = MD5.Create())
        {
            hashBytes = md5
                .ComputeHash(Encoding.UTF8.GetBytes($"{timeStamp}{privateKey}{publicKey}"));
        }

        return BitConverter.ToString(hashBytes).Replace("-", string.Empty).ToLower();
    }
}