namespace FluentMarvelSdk;

public class EventRequestBuilder : ResourceRequestBuilder<Event, EventOptionSet>
{

    internal static EventRequestBuilder Create(MarvelApiService service) => new EventRequestBuilder(service);
    internal static EventRequestBuilder Create(MarvelApiService service, int characterId) => new EventRequestBuilder(service, characterId);

    private EventRequestBuilder(MarvelApiService service) : base(service, new()) { }
    private EventRequestBuilder(MarvelApiService service, int characterId) : base(service, new(), characterId) { }

    /// <summary>
    /// Filters the request to return only events with the exact name.
    /// </summary>
    /// <param name="name"></param>
    public EventRequestBuilder WithName(string name)
    {
        OptionSet.Name = name;
        return this;
    }

    /// <summary>
    /// Filters the request to return only events a name that starts with <see cref="nameStartsWith"/>.
    /// </summary>
    /// <param name="nameStartsWith"></param>
    public EventRequestBuilder WithNameStartingWith(string nameStartsWith)
    {
        OptionSet.NameStartsWith = nameStartsWith;
        return this;
    }

    /// <summary>
    /// Filters the request to return only events created by any of the specified creators .
    /// </summary>
    /// <param name="creatorIds"></param>
    public EventRequestBuilder ByCreator(params int[] creatorIds)
    {
        OptionSet.Creators = creatorIds;
        return this;
    }

    /// <summary>
    /// Filters the request to return only events which have any of the specified characters.
    /// </summary>
    /// <param name="characterIds"></param>
    public EventRequestBuilder WithAnyCharacters(params int[] characterIds)
    {
        OptionSet.Characters = characterIds;
        return this;
    }

    /// <summary>
    /// Filters the request to return only events which appear in any of the specified series.
    /// </summary>
    /// <param name="seriesIds"></param>
    public EventRequestBuilder InSeries(params int[] seriesIds)
    {
        OptionSet.Series = seriesIds;
        return this;
    }

    /// <summary>
    /// Filters the request to return only events which appear in the specified comics.
    /// </summary>
    /// <param name="comicIds"></param>
    public EventRequestBuilder InComics(params int[] comicIds)
    {
        OptionSet.Comics = comicIds;
        return this;
    }

    /// <summary>
    /// Filters the request to return only events which appear in any of the specified stories.
    /// </summary>
    /// <param name="storyIds"></param>
    public EventRequestBuilder InStory(params int[] storyIds)
    {
        OptionSet.Stories = storyIds;
        return this;
    }
}