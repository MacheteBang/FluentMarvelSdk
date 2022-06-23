namespace mmmPizza.MarvelSdk;

public abstract class ResourceRequestBuilder<T, TOptionSet>
{
    public TOptionSet OptionSet { get; init; }
    protected MarvelApiService _service;
    protected int _resourceId;

    protected ResourceRequestBuilder(MarvelApiService service, TOptionSet optionSet)
    {
        _service = service;
        OptionSet = optionSet;
    }
    protected ResourceRequestBuilder(MarvelApiService service, TOptionSet optionSet, int resourceId)
    {
        _service = service;
        OptionSet = optionSet;
        _resourceId = resourceId;
    }

    public async Task<DataContainer<T>?> Excelsior()
    {
        Flurl.Url url = ResourceRoutes.GetRoute<T>();
        if (_resourceId != 0) url.AppendPathSegment(_resourceId);
        url.SetQueryParams<TOptionSet>(OptionSet);

        return await _service.GetResourceAsync<T>(url);
    }
}