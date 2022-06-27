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

        foreach (PropertyInfo p in options.GetType().GetProperties().Where(p => p.GetValue(options) is not null))
        {
            var propertyValue = p.GetValue(options);

            if (p.PropertyType.IsArray)
            {
                string values = "";

                if (propertyValue is int[])
                {
                    values = string.Join(",", ((int[])propertyValue).Select(x => x.ToString()).ToArray());
                }

                if (propertyValue is DateOnly[])
                {
                    values = string.Join(",", ((DateOnly[])propertyValue).Select(x => x.ToString("yyyy-MM-dd")).ToArray());
                }

                url.SetQueryParam(p.Name.ToCamelCase(), values, true);
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