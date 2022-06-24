namespace FluentMarvelSdk;

public abstract class ResourceRequestBuilder<T, TOptionSet> where TOptionSet : OptionSet
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

    /// <summary>
    /// Limit the returned results.
    /// </summary>
    /// <param name="limit"></param>
    public  ResourceRequestBuilder<T, TOptionSet> LimitResultsBy(int limit)
    {
        // Try to block uneeded calls to the API by validating this parameter locally. At the mercy of the API changing, but...
        if (limit < Constants.LimitLowerBound) throw new InvalidLimitException(new ApiError() { Message = $"Limit must be above {Constants.LimitLowerBound}" });
        if (limit > Constants.LimitUpperBound) throw new InvalidLimitException(new ApiError() { Message = $"Limit must be less than or equal to {Constants.LimitUpperBound}" });

        OptionSet.Limit = limit;
        return this;
    }

    /// <summary>
    /// Skips the specified number of results.
    /// </summary>
    /// <param name="offset"></param>
    public  ResourceRequestBuilder<T, TOptionSet> OffsetResultsBy(int offset)
    {
        OptionSet.Offset = offset;
        return this;
    }

    /// <summary>
    /// Filters the request to return only characters modified since <see cref="date"/>.
    /// </summary>
    /// <param name="date"></param>
    public ResourceRequestBuilder<T, TOptionSet> ModifiedSince(DateOnly date)
    {
        OptionSet.ModifiedSince = new(date.Year, date.Month, date.Day, 0, 0, 0, TimeSpan.FromHours(10));
        return this;
    }
}