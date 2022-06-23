using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace FluentMarvelSdk;

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

    internal static Flurl.Url SetQueryParams<T>(this Flurl.Url url, T options)
    {
        if (options is null) return url;

        foreach (PropertyInfo p in options.GetType().GetProperties())
        {
            var propertyValue = p.GetValue(options);

            if (propertyValue is null) continue;

            if (p.PropertyType.IsArray)
            {
                string values = "";
                foreach (var i in (Array)propertyValue) values += i.ToString() + ',';

                url.SetQueryParam(p.Name.ToCamelCase(), values);
                continue;
            }

            url.SetQueryParam(p.Name.ToCamelCase(), propertyValue);
        }

        return url;
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