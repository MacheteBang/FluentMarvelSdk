namespace FluentMarvelSdk;

public interface IResourceRequestBuilder<TResource>
{
    Task<DataContainer<TResource>?> Excelsior();
}
