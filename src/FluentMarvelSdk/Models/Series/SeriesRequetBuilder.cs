namespace FluentMarvelSdk;

public class SeriesRequestBuilder : ResourceRequestBuilder<Series, SeriesOptionSet>
{

    internal static SeriesRequestBuilder Create(MarvelApiService service) => new SeriesRequestBuilder(service);
    internal static SeriesRequestBuilder Create(MarvelApiService service, int characterId) => new SeriesRequestBuilder(service, characterId);

    private SeriesRequestBuilder(MarvelApiService service) : base(service, new()) { }
    private SeriesRequestBuilder(MarvelApiService service, int characterId) : base(service, new(), characterId) { }


    /// <summary>
    /// Filters the request to return only series with the exact full title.
    /// </summary>
    /// <param name="title"></param>
    public SeriesRequestBuilder WithTitle(string title)
    {
        OptionSet.Title = title;
        return this;
    }

    /// <summary>
    /// Filters the request to return only series a title that starts with <see cref="titleStartsWith"/>.
    /// </summary>
    /// <param name="nameStartsWith"></param>
    public SeriesRequestBuilder WithTitleStartingWith(string titleStartsWith)
    {
        OptionSet.TitleStartsWith = titleStartsWith;
        return this;
    }

    /// <summary>
    /// Filters the request to return only series whose start year matches <see cref="year"/>.
    /// </summary>
    /// <param name="year"></param>
    public SeriesRequestBuilder StartingWithYear(int year)
    {
        OptionSet.StartYear = year;
        return this;
    }

    /// <summary>
    /// Filters the request to return only series which appear in any of the specified stories.
    /// </summary>
    /// <param name="storyIds"></param>
    public SeriesRequestBuilder InStory(params int[] storyIds)
    {
        OptionSet.Stories = storyIds;
        return this;
    }

    /// <summary>
    /// Filters the request to return only series which appear in any of the specified events.
    /// </summary>
    /// <param name="eventIds"></param>
    public SeriesRequestBuilder DuringEvent(params int[] eventIds)
    {
        OptionSet.Events = eventIds;
        return this;
    }

    /// <summary>
    /// Filters the request to return only series created by any of the specified creators.
    /// </summary>
    /// <param name="creatorIds"></param>
    public SeriesRequestBuilder ByCreator(params int[] creatorIds)
    {
        OptionSet.Creators = creatorIds;
        return this;
    }

    /// <summary>
    /// Filters the request to return only series which have any of the specified characters.
    /// </summary>
    /// <param name="characterIds"></param>
    public SeriesRequestBuilder WithAnyCharacters(params int[] characterIds)
    {
        OptionSet.Characters = characterIds;
        return this;
    }
    
    /// <summary>
    /// Filters the request to return only series which have the specified frequency.
    /// </summary>
    /// <param name="seriesFrequencyType"></param>
    public SeriesRequestBuilder WithFrequencyType(SeriesTypes seriesFrequencyType)
    {
        OptionSet.SeriesType = seriesFrequencyType;
        return this;
    }
}