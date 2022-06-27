namespace FluentMarvelSdk;

public abstract class ResourceSummary<TResource> : IResourceSummary
{
    public string? ResourceUri { get; set; }
    public string? Name { get; set; }

    public int? ResourceId => GetId();


    private int? GetId()
    {
        int.TryParse(ResourceUri?.Split("/").LastOrDefault(), out int resourceId);
        return resourceId;
    }
}