namespace mmmPizza.MarvelSdk;

public class StoryRequestBuilder : ResourceRequestBuilder<Story, StoryOptionSet>
{
    internal static StoryRequestBuilder Create(MarvelApiService service) => new StoryRequestBuilder(service);
    internal static StoryRequestBuilder Create(MarvelApiService service, int characterId) => new StoryRequestBuilder(service, characterId);

    private StoryRequestBuilder(MarvelApiService service) : base(service, new()) { }
    private StoryRequestBuilder(MarvelApiService service, int characterId) : base(service, new(), characterId) { }

    /// <summary>
    /// Filters the request to return only stories which appear in the specified comics.
    /// </summary>
    /// <param name="comicIds"></param>
    public StoryRequestBuilder InComics(params int[] comicIds)
    {
        OptionSet.Comics = comicIds;
        return this;
    }

    /// <summary>
    /// Filters the request to return only stories which appear in any of the specified series.
    /// </summary>
    /// <param name="seriesIds"></param>
    public StoryRequestBuilder InSeries(params int[] seriesIds)
    {
        OptionSet.Series = seriesIds;
        return this;
    }

    /// <summary>
    /// Filters the request to return only stories which appear in any of the specified events.
    /// </summary>
    /// <param name="eventIds"></param>
    public StoryRequestBuilder DuringEvent(params int[] eventIds)
    {
        OptionSet.Events = eventIds;
        return this;
    }

    /// <summary>
    /// Filters the request to return only stories created by any of the specified creators.
    /// </summary>
    /// <param name="creatorIds"></param>
    public StoryRequestBuilder ByCreator(params int[] creatorIds)
    {
        OptionSet.Creators = creatorIds;
        return this;
    }

    /// <summary>
    /// Filters the request to return only stories which have any of the specified characters.
    /// </summary>
    /// <param name="characterIds"></param>
    public StoryRequestBuilder WithAnyCharacters(params int[] characterIds)
    {
        OptionSet.Characters = characterIds;
        return this;
    }

    /// <summary>
    /// Limit the returned results.
    /// </summary>
    /// <param name="limit"></param>
    public StoryRequestBuilder LimitResultsBy(int limit)
    {
        OptionSet.Limit = limit;
        return this;
    }

    /// <summary>
    /// Skips the specified number of results.
    /// </summary>
    /// <param name="offset"></param>
    public StoryRequestBuilder OffsetResultsBy(int offset)
    {
        OptionSet.Offset = offset;
        return this;
    }

    /// <summary>
    /// Filters the request to return only characters modified since <see cref="date"/>.
    /// </summary>
    /// <param name="date"></param>
    public StoryRequestBuilder ModifiedSince(DateOnly date)
    {
        OptionSet.ModifiedSince = new(date.Year, date.Month, date.Day, 0, 0, 0, TimeSpan.FromHours(10));
        return this;
    }


}