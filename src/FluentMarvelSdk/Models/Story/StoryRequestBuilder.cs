namespace FluentMarvelSdk;

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
}