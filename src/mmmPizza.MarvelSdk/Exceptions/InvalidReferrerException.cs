namespace mmmPizza.MarvelSdk;

public class InvalidReferrerException : Exception
{
    public readonly string Reason = "Occurs when a referrer which is not valid for the passed apikey parameter is sent.";
}