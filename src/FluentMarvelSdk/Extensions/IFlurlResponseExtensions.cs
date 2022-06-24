using Flurl.Http;

namespace FluentMarvelSdk;

public static class IFlurlResponseExtensions
{
    public static IFlurlResponse ThrowOnError(this IFlurlResponse response)
    {
        if (response.StatusCode < 400) return response;

        ApiError error = response.GetJsonAsync<ApiError>().Result;

        if (response.StatusCode >= 500) throw new MarvelApiException(error);

        switch (response.StatusCode)
        {
            case 401:
                if (error.Code == "InvalidCredentials") throw new InvalidHashException(error);
                break;
            case 404:
                throw new ResourceNotFoundException();
            case 409:
                if (error.Status.Contains("cannot be blank if it is set")) throw new EmptyParameterException(error);
                if (error.Status.Contains("We don't recognize the parameter")) throw new InvalidParameterException(error);
                if (error.Status.Contains("may not request more than")) throw new InvalidLimitException(error);
                if (error.Status.Contains("limit greater than")) throw new InvalidLimitException(error);
                if (error.Code == "MissingParameter" && error.Message.Contains("user key")) throw new MissingApiKeyException(error);
                if (error.Code == "MissingParameter" && error.Message.Contains("hash")) throw new MissingHashException(error);
                if (error.Code == "MissingParameter" && error.Message.Contains("timestamp")) throw new MissingTimestampException(error);
                break;
            default:
                throw new MarvelApiException(error);
        }

        return response;
    }
}