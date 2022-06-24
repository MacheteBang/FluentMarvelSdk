namespace FluentMarvelSdk;

public class CreatorRequestBuilder : ResourceRequestBuilder<Creator, CreatorOptionSet>
{
    internal static CreatorRequestBuilder Create(MarvelApiService service) => new CreatorRequestBuilder(service);
    internal static CreatorRequestBuilder Create(MarvelApiService service, int characterId) => new CreatorRequestBuilder(service, characterId);

    private CreatorRequestBuilder(MarvelApiService service) : base(service, new()) { }
    private CreatorRequestBuilder(MarvelApiService service, int characterId) : base(service, new(), characterId) { }


    /// <summary>
    /// Filters the request to return only creators with the exact first name.
    /// </summary>
    /// <param name="firstName"></param>
    public CreatorRequestBuilder WithFirstName(string firstName)
    {
        OptionSet.FirstName = firstName;
        return this;
    }

    /// <summary>
    /// Filters the request to return only creators with the exact middle name.
    /// </summary>
    /// <param name="firstName"></param>
    public CreatorRequestBuilder WithMiddleName(string middleName)
    {
        OptionSet.MiddleName = middleName;
        return this;
    }

    /// <summary>
    /// Filters the request to return only creators with the exact last name.
    /// </summary>
    /// <param name="lastName"></param>
    public CreatorRequestBuilder WithLastName(string lastName)
    {
        OptionSet.LastName = lastName;
        return this;
    }

    /// <summary>
    /// Filters the request to return only creators with the exact suffix.
    /// </summary>
    /// <param name="suffix"></param>
    public CreatorRequestBuilder WithSuffix(string suffix)
    {
        OptionSet.Suffix = suffix;
        return this;
    }

    /// <summary>
    /// Filters the request to return only creators with a name that starts with <see cref="nameStartsWith"/>.
    /// </summary>
    /// <param name="nameStartsWith"></param>
    public CreatorRequestBuilder WithNameStartingWith(string nameStartsWith)
    {
        OptionSet.NameStartsWith = nameStartsWith;
        return this;
    }

    /// <summary>
    /// Filters the request to return only creators with a first name that starts with <see cref="firstNameStartsWith"/>.
    /// </summary>
    /// <param name="firstNameStartsWith"></param>
    public CreatorRequestBuilder WithFirstNameStartingWith(string firstNameStartsWith)
    {
        OptionSet.FirstNameStartsWith = firstNameStartsWith;
        return this;
    }

    /// <summary>
    /// Filters the request to return only creators with a middle name that starts with <see cref="middleNameStartsWith"/>.
    /// </summary>
    /// <param name="middleNameStartsWith"></param>
    public CreatorRequestBuilder WithMiddleNameStartingWith(string middleNameStartsWith)
    {
        OptionSet.MiddleNameStartsWith = middleNameStartsWith;
        return this;
    }

    /// <summary>
    /// Filters the request to return only creators with a last name that starts with <see cref="lastNameStartsWith"/>.
    /// </summary>
    /// <param name="lastNameStartsWith"></param>
    public CreatorRequestBuilder WithLastNameStartingWith(string lastNameStartsWith)
    {
        OptionSet.LastNameStartsWith = lastNameStartsWith;
        return this;
    }

    /// <summary>
    /// Filters the request to return only creators which created the specified comics.
    /// </summary>
    /// <param name="comicIds"></param>
    public CreatorRequestBuilder InComics(params int[] comicIds)
    {
        OptionSet.Comics = comicIds;
        return this;
    }

    /// <summary>
    /// Filters the request to return only creators worked on the specified events.
    /// </summary>
    /// <param name="eventIds"></param>
    public CreatorRequestBuilder DuringEvents(params int[] eventIds)
    {
        OptionSet.Events = eventIds;
        return this;
    }

    /// <summary>
    /// Filters the request to return only creators who worked on the specified series.
    /// </summary>
    /// <param name="seriesIds"></param>
    public CreatorRequestBuilder InSeries(params int[] seriesIds)
    {
        OptionSet.Series = seriesIds;
        return this;
    }

    /// <summary>
    /// Filters the request to return only creators who worked on the specified stories.
    /// </summary>
    /// <param name="storyIds"></param>
    public CreatorRequestBuilder InStory(params int[] storyIds)
    {
        OptionSet.Stories = storyIds;
        return this;
    }

    /// <summary>
    /// Limit the returned results.
    /// </summary>
    /// <param name="limit"></param>
    public CreatorRequestBuilder LimitResultsBy(int limit)
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
    public CreatorRequestBuilder OffsetResultsBy(int offset)
    {
        OptionSet.Offset = offset;
        return this;
    }

    /// <summary>
    /// Filters the request to return only creators modified since <see cref="date"/>.
    /// </summary>
    /// <param name="date"></param>
    public CreatorRequestBuilder ModifiedSince(DateOnly date)
    {
        OptionSet.ModifiedSince = new(date.Year, date.Month, date.Day, 0, 0, 0, TimeSpan.FromHours(10));
        return this;
    }
}