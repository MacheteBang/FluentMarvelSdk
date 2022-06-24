namespace FluentMarvelSdk;

public class CharacterRequestBuilder : ResourceRequestBuilder<Character, CharacterOptionSet>
{

    internal static CharacterRequestBuilder Create(MarvelApiService service) => new CharacterRequestBuilder(service);
    internal static CharacterRequestBuilder Create(MarvelApiService service, int characterId) => new CharacterRequestBuilder(service, characterId);

    private CharacterRequestBuilder(MarvelApiService service) : base(service, new()) { }
    private CharacterRequestBuilder(MarvelApiService service, int characterId) : base(service, new(), characterId) { }

    /// <summary>
    /// Filters the request to return only characters which appear in the specified comics.
    /// </summary>
    /// <param name="comicIds"></param>
    public CharacterRequestBuilder InComics(params int[] comicIds)
    {
        OptionSet.Comics = comicIds;
        return this;
    }

    /// <summary>
    /// Filters the request to return only characters which appear during the specified events.
    /// </summary>
    /// <param name="eventIds"></param>
    public CharacterRequestBuilder DuringEvents(params int[] eventIds)
    {
        OptionSet.Events = eventIds;
        return this;
    }

    /// <summary>
    /// Filters the request to return only characters which appear in any of the specified series.
    /// </summary>
    /// <param name="seriesIds"></param>
    public CharacterRequestBuilder InSeries(params int[] seriesIds)
    {
        OptionSet.Series = seriesIds;
        return this;
    }

    /// <summary>
    /// Filters the request to return only characters which appear in the specified stories.
    /// </summary>
    /// <param name="storyIds"></param>
    public CharacterRequestBuilder InStory(params int[] storyIds)
    {
        OptionSet.Stories = storyIds;
        return this;
    }

    /// <summary>
    /// Filters the request to return only characters with the exact full name.
    /// </summary>
    /// <param name="name"></param>
    public CharacterRequestBuilder WithName(string name)
    {
        OptionSet.Name = name;
        return this;
    }

    /// <summary>
    /// Filters the request to return only characters a name that starts with <see cref="nameStartsWith"/>.
    /// </summary>
    /// <param name="nameStartsWith"></param>
    public CharacterRequestBuilder WithNameStartingWith(string nameStartsWith)
    {
        OptionSet.NameStartsWith = nameStartsWith;
        return this;
    }
}