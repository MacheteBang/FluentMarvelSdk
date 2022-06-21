using Flurl.Http;

namespace mmmPizza.MarvelSdk;

public static class IFlurlResponseExtensions
{
    public static IFlurlResponse ThrowOnError(this IFlurlResponse response)
    {
        return response;
    }
}