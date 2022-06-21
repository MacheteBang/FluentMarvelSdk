namespace mmmPizza.MarvelSdk;

public class InvalidHashException : Exception
{
    public readonly string Reason = "Occurs when a ts, hash and apikey parameter are sent but the hash is not valid per the above hash generation rule.";
}