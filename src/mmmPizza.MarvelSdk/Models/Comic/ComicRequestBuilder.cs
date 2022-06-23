namespace mmmPizza.MarvelSdk;

public class ComicRequestBuilder : ResourceRequestBuilder<Comic, ComicOptionSet>
{
    public ComicRequestBuilder(MarvelApiService service) : base(service, new()) { }
    public ComicRequestBuilder(MarvelApiService service, int characterId) : base(service, new(), characterId) { }

    /// <summary>
    /// Filters the request to return only comics in the specific issue format.
    /// </summary>
    /// <param name="format"></param>
    public ComicRequestBuilder InFormatOf(ComicFormats format)
    {
        OptionSet.Format = format;
        return this;
    }

    /// <summary>
    /// Filters the request to return only comics in the specific issue format type.
    /// </summary>
    /// <param name="formatType"></param>
    public ComicRequestBuilder InFormatTypeOf(ComicFormatTypes formatType)
    {
        OptionSet.FormatType = formatType;
        return this;
    }

    /// <summary>
    /// Filters the request to remove comics that are variants (alternate covers, secondary printings, director's cuts, etc.).
    /// </summary>
    public ComicRequestBuilder RemoveVariants()
    {
        OptionSet.NoVariants = true;
        return this;
    }

    /// <summary>
    /// Filters the request to return only comics within a predefined date range.
    /// </summary>
    /// <param name="dateDescriptor"></param>
    public ComicRequestBuilder WithinRecent(DateDescriptors dateDescriptor)
    {
        OptionSet.DateDescriptor = dateDescriptor;
        return this;
    }

    /// <summary>
    /// Filters the request to return comics only within a specified date range.
    /// </summary>
    /// <param name="startDate"></param>
    /// <param name="endDate"></param>
    public ComicRequestBuilder InDateRange(DateOnly startDate, DateOnly endDate)
    {
        OptionSet.DateRange = new DateOnly[] { startDate, endDate };
        return this;
    }

    /// <summary>
    /// Filters the request to return only comics with the exact full title.
    /// </summary>
    /// <param name="title"></param>
    public ComicRequestBuilder WithTitle(string title)
    {
        OptionSet.Title = title;
        return this;
    }

    /// <summary>
    /// Filters the request to return only comics a title that starts with <see cref="titleStartsWith"/>.
    /// </summary>
    /// <param name="nameStartsWith"></param>
    public ComicRequestBuilder WithTitleStartingWith(string titleStartsWith)
    {
        OptionSet.TitleStartsWith = titleStartsWith;
        return this;
    }

    /// <summary>
    /// Filters the request to return only comics whose start year matches <see cref="year"/>.
    /// </summary>
    /// <param name="year"></param>
    public ComicRequestBuilder StartingWithYear(int year)
    {
        OptionSet.StartYear = year;
        return this;
    }

    /// <summary>
    /// Filters the request to return only comics with the specific issue number.
    /// </summary>
    /// <param name="issueNumber"></param>
    public ComicRequestBuilder WithIssueNumber(int issueNumber)
    {
        OptionSet.IssueNumber = issueNumber;
        return this;
    }

    /// <summary>
    /// Filters the request to return only comics with the specific diamond code.
    /// </summary>
    /// <param name="diamondCode"></param>
    public ComicRequestBuilder WithDiamondCode(string diamondCode)
    {
        OptionSet.DiamondCode = diamondCode;
        return this;
    }

    /// <summary>
    /// Filters the request to return only comics with the specific digital ID.
    /// </summary>
    /// <param name="digitalId"></param>
    public ComicRequestBuilder WithDigitalId(int digitalId)
    {
        OptionSet.DigitalId = digitalId;
        return this;
    }

    /// <summary>
    /// Filters the request to return only comics with the specific UPC.
    /// </summary>
    /// <param name="upc"></param>
    public ComicRequestBuilder WithUpc(string upc)
    {
        OptionSet.Upc = upc;
        return this;
    }

    /// <summary>
    /// Filters the request to return only comics with the specific ISBN.
    /// </summary>
    /// <param name="isbn"></param>
    public ComicRequestBuilder WithIsbn(string isbn)
    {
        OptionSet.Isbn = isbn;
        return this;
    }

    /// <summary>
    /// Filters the request to return only comics with the specific EAN.
    /// </summary>
    /// <param name="ean"></param>
    public ComicRequestBuilder WithEan(string ean)
    {
        OptionSet.Ean = ean;
        return this;
    }

    /// <summary>
    /// Filters the request to return only comics with the specific ISSN.
    /// </summary>
    /// <param name="issn"></param>
    public ComicRequestBuilder WithIssn(string issn)
    {
        OptionSet.Issn = issn;
        return this;
    }

    /// <summary>
    /// Filters the request to return only comics with digital issues only.
    /// </summary>
    public ComicRequestBuilder HasDigitalIssuesOnly()
    {
        OptionSet.HasDigitalIssue = true;
        return this;
    }

    /// <summary>
    /// Filters the request to return only comics created by any of the creators in <see cref="comicIds"/>.
    /// </summary>
    /// <param name="creatorIds"></param>
    public ComicRequestBuilder ByCreator(params int[] creatorIds)
    {
        OptionSet.Creators = creatorIds;
        return this;
    }

    /// <summary>
    /// Filters the request to return only comics which appear in any of the specified series.
    /// </summary>
    /// <param name="seriesIds"></param>
    public ComicRequestBuilder InSeries(params int[] seriesIds)
    {
        OptionSet.Series = seriesIds;
        return this;
    }

    /// <summary>
    /// Filters the request to return only comics which appear in any of the specified events.
    /// </summary>
    /// <param name="eventIds"></param>
    public ComicRequestBuilder DuringEvent(params int[] eventIds)
    {
        OptionSet.Events = eventIds;
        return this;
    }

    /// <summary>
    /// Filters the request to return only comics which appear in any of the specified stories.
    /// </summary>
    /// <param name="storyIds"></param>
    public ComicRequestBuilder InStory(params int[] storyIds)
    {
        OptionSet.Stories = storyIds;
        return this;
    }

    /// <summary>
    /// Filters the request to return only comics which have all of the specified characters in that comic.
    /// </summary>
    /// <param name="characterIds"></param>
    public ComicRequestBuilder WithCharacters(params int[] characterIds)
    {
        OptionSet.SharedAppearances = characterIds;
        return this;
    }

    /// <summary>
    /// Filters the request to return only comics which have all of the specified collaborators that worked on that comic.
    /// </summary>
    /// <param name="collaboratorIds"></param>
    public ComicRequestBuilder WithCollaborators(params int[] collaboratorIds)
    {
        OptionSet.Collaborators = collaboratorIds;
        return this;
    }

    /// <summary>
    /// Limit the returned results.
    /// </summary>
    /// <param name="limit"></param>
    /// <returns></returns>
    public ComicRequestBuilder LimitResultsBy(int limit)
    {
        OptionSet.Limit = limit;
        return this;
    }

    /// <summary>
    /// Skips the specified number of results.
    /// </summary>
    /// <param name="offset"></param>
    /// <returns></returns>
    public ComicRequestBuilder OffsetResultsBy(int offset)
    {
        OptionSet.Offset = offset;
        return this;
    }

    /// <summary>
    /// Filters the request to return only characters modified since <see cref="date"/>.
    /// </summary>
    /// <param name="date"></param>
    /// <returns></returns>
    public ComicRequestBuilder ModifiedSince(DateOnly date)
    {
        OptionSet.ModifiedSince = new(date.Year, date.Month, date.Day, 0, 0, 0, TimeSpan.FromHours(10));
        return this;
    }
}