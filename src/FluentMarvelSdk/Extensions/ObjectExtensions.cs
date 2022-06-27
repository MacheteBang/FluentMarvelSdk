using System.Text.Json;

namespace FluentMarvelSdk;

public static class ObjectExtensions
{
    public static T CreateDeepCopy<T>(this T obj)
    {
        string json = JsonSerializer.Serialize(obj);
        return JsonSerializer.Deserialize<T>(json)!;
    }
}