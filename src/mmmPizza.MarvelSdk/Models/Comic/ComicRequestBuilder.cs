namespace mmmPizza.MarvelSdk;

public class ComicRequestBuilder : ResourceRequestBuilder<Comic, ComicOptionSet>
{
    public ComicRequestBuilder(MarvelApiService service) : base(service, new()) { }
    public ComicRequestBuilder(MarvelApiService service, int characterId) : base(service, new(), characterId) { }

    public ComicRequestBuilder InFormatOf(ComicFormats format)
    {
        OptionSet.Format = format;
        return this;
    }
    public ComicRequestBuilder InFormatTypeOf(ComicFormatTypes formatType)
    {
        OptionSet.FormatType = formatType;
        return this;
    }
    public ComicRequestBuilder RemoveVariants()
    {
        OptionSet.NoVariants = true;
        return this;
    }
    public ComicRequestBuilder WithinRecent(DateDescriptors dateDescriptor)
    {
        OptionSet.DateDescriptor = dateDescriptor;
        return this;
    }
    public ComicRequestBuilder InDateRange(DateOnly startDate, DateOnly endDate)
    {
        // FIXME
        OptionSet.DateRange = 0;
        return this;
    }
    public ComicRequestBuilder WithTitle(string title)
    {
        OptionSet.Title = title;
        return this;
    }
    public ComicRequestBuilder WithTitleStartingWith(string titleStartsWith)
    {
        OptionSet.TitleStartsWith = titleStartsWith;
        return this;
    }
    public ComicRequestBuilder StartingWithYear(int year)
    {
        OptionSet.StartYear = year;
        return this;
    }
    public ComicRequestBuilder WithIssueNumber(int issueNumber)
    {
        OptionSet.IssueNumber = issueNumber;
        return this;
    }
    public ComicRequestBuilder WithDiamondCode(string diamondCode)
    {
        OptionSet.DiamondCode = diamondCode;
        return this;
    }
    public ComicRequestBuilder WithDigitalId(int digitalId)
    {
        OptionSet.DigitalId = digitalId;
        return this;
    }
    public ComicRequestBuilder WithUpc(string upc)
    {
        OptionSet.Upc = upc;
        return this;
    }
    public ComicRequestBuilder WithIsbn(string isbn)
    {
        OptionSet.Isbn = isbn;
        return this;
    }
    public ComicRequestBuilder WithEan(string ean)
    {
        OptionSet.Ean = ean;
        return this;
    }
    public ComicRequestBuilder WithIssn(string issn)
    {
        OptionSet.Issn = issn;
        return this;
    }
    public ComicRequestBuilder HasDigitalIssues(bool hasDigitalIssue)
    {
        OptionSet.HasDigitalIssue = hasDigitalIssue;
        return this;
    }

    public ComicRequestBuilder ByCreator(params int[] creatorIds)
    {
        OptionSet.Creators = creatorIds;
        return this;
    }
    public ComicRequestBuilder InSeries(params int[] seriesIds)
    {
        OptionSet.Series = seriesIds;
        return this;
    }
    public ComicRequestBuilder DuringEvent(params int[] eventIds)
    {
        OptionSet.Events = eventIds;
        return this;
    }
    public ComicRequestBuilder InStory(params int[] storyIds)
    {
        OptionSet.Stories = storyIds;
        return this;
    }
    public ComicRequestBuilder WithCharacters(params int[] characterIds)
    {
        OptionSet.SharedAppearances = characterIds;
        return this;
    }
    public ComicRequestBuilder WithCollaborators(params int[] collaboratorIds)
    {
        OptionSet.Collaborators = collaboratorIds;
        return this;
    }
}