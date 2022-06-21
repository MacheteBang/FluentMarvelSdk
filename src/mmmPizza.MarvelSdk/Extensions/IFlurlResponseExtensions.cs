using Flurl.Http;

namespace mmmPizza.MarvelSdk;

public static class IFlurlResponseExtensions
{
    public static IFlurlResponse ThrowOnError(this IFlurlResponse response)
    {
        // TODO: Implement API Error handling
        // https://developer.marvel.com/documentation/authorization
        return response;
    }
}