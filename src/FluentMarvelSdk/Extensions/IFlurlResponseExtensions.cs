using Flurl.Http;

namespace FluentMarvelSdk;

public static class IFlurlResponseExtensions
{
    public static IFlurlResponse ThrowOnError(this IFlurlResponse response)
    {
        if (response.StatusCode < 400) return response;
        if (response.StatusCode >= 500) throw new Exception("Unknown error at Marvel API");
        
        ApiError error = response.GetJsonAsync<ApiError>().Result;

        switch (response.StatusCode)
        {
            case 401:
                if (error.Code == "InvalidCredentials") throw new InvalidHashException(error.Message);
                break;
            case 403:
                throw new ApiException(403, "Occurs when a user with an otherwise authenticated request attempts to access an endpoint to which they do not have access.");
            case 405:
                throw new ApiException(405, "Occurs when an API endpoint is accessed using an HTTP verb which is not allowed for that endpoint.");
            case 409:
                if (error.Code == "MissingParameter" && error.Message.Contains("user key")) throw new MissingApiKeyException(error.Message);
                if (error.Code == "MissingParameter" && error.Message.Contains("hash")) throw new MissingHashException(error.Message);
                if (error.Code == "MissingParameter" && error.Message.Contains("timestamp")) throw new MissingTimestampException(error.Message);
                break;
            default:
                throw new ApiException(response.StatusCode, error.Message);
        }


        // TODO: #1 Implement API Error handling
        // https://developer.marvel.com/documentation/authorization
        return response;
    }
}