namespace FluentMarvelSdk;

public class ResourceNotFoundException: Exception
{
    public ResourceNotFoundException() : base($"The requested resource (comic, character, creator, etc) cannot be found.")
    {
    }
}