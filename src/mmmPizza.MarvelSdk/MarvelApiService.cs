using System.Text.Json;
using Flurl.Http;

namespace mmmPizza.MarvelSdk;

public class MarvelApiService
{
    // Private Properties
    private readonly JsonSerializerOptions _jsonOptions = default!;
    private readonly string _privateApiKey = default!;
    private readonly string _publicApiKey = default!;


    // Constructors
    private MarvelApiService() { }
    public MarvelApiService(string privateApiKey, string publicApiKey)
    {
        ArgumentNullException.ThrowIfNull(privateApiKey);
        ArgumentNullException.ThrowIfNull(publicApiKey);

        _privateApiKey = privateApiKey;
        _publicApiKey = publicApiKey;

        _jsonOptions = new()
        {
            PropertyNameCaseInsensitive = true
        };
        _jsonOptions.Converters.Add(new MarvelDateTimeConverter("yyyy-MM-ddTHH:mm:ssK"));
    }

    // Private Methods
    private async Task<DataContainer<T>?> GetResourceAsync<T>(Flurl.Url url)
    {
        url.AppendAuthorization(_privateApiKey, _publicApiKey);

        var response = url
            .AllowAnyHttpStatus()
            .GetAsync()
            .Result
            .ThrowOnError();

        if (response.StatusCode != 200) throw new Exception();

        string json = await response.GetStringAsync();
        json = json.Replace("-0001-11-30T00:00:00-0500", "1900-01-01T00:00:00-00:00");

        DataWrapper<T> wrapper = JsonSerializer.Deserialize<DataWrapper<T>>(json, _jsonOptions);

        return wrapper?.Data;
    }

    // Public Methods
    public async Task<DataContainer<Character>?> GetCharacterAsync(int characterId) => await GetResourceAsync<Character>(ResourceRoutes.CharactersUrl.AppendPathSegment(characterId));
    public async Task<DataContainer<Character>?> GetCharactersAsync() => await GetResourceAsync<Character>(ResourceRoutes.CharactersUrl);
    public async Task<DataContainer<Character>?> GetCharactersAsync(CharacterOptionSet options) => await GetResourceAsync<Character>(ResourceRoutes.CharactersUrl.SetQueryParams<CharacterOptionSet>(options));
    public async Task<DataContainer<Character>?> GetCharactersByComicAsync(int comicId) => await GetResourceAsync<Character>(ResourceRoutes.ComicsUrl.AppendPathSegment(comicId).AppendPathSegment(ResourceRoutes.Characters));
    public async Task<DataContainer<Character>?> GetCharactersByComicAsync(int comicId, CharacterOptionSet options) => await GetResourceAsync<Character>(ResourceRoutes.ComicsUrl.AppendPathSegment(comicId).AppendPathSegment(ResourceRoutes.Characters).SetQueryParams<CharacterOptionSet>(options));
    public async Task<DataContainer<Character>?> GetCharactersByEventAsync(int eventId) => await GetResourceAsync<Character>(ResourceRoutes.EventsUrl.AppendPathSegment(eventId).AppendPathSegment(ResourceRoutes.Characters));
    public async Task<DataContainer<Character>?> GetCharactersByEventAsync(int eventId, CharacterOptionSet options) => await GetResourceAsync<Character>(ResourceRoutes.EventsUrl.AppendPathSegment(eventId).AppendPathSegment(ResourceRoutes.Characters).SetQueryParams<CharacterOptionSet>(options));
    public async Task<DataContainer<Character>?> GetCharactersBySeriesAsync(int seriesId) => await GetResourceAsync<Character>(ResourceRoutes.SeriesUrl.AppendPathSegment(seriesId).AppendPathSegment(ResourceRoutes.Characters));
    public async Task<DataContainer<Character>?> GetCharactersBySeriesAsync(int seriesId, CharacterOptionSet options) => await GetResourceAsync<Character>(ResourceRoutes.SeriesUrl.AppendPathSegment(seriesId).AppendPathSegment(ResourceRoutes.Characters).SetQueryParams<CharacterOptionSet>(options));
    public async Task<DataContainer<Character>?> GetCharactersByStoryAsync(int storyId) => await GetResourceAsync<Character>(ResourceRoutes.StoriesUrl.AppendPathSegment(storyId).AppendPathSegment(ResourceRoutes.Characters));
    public async Task<DataContainer<Character>?> GetCharactersByStoryAsync(int storyId, CharacterOptionSet options) => await GetResourceAsync<Character>(ResourceRoutes.StoriesUrl.AppendPathSegment(storyId).AppendPathSegment(ResourceRoutes.Characters).SetQueryParams<CharacterOptionSet>(options));

    public async Task<DataContainer<Comic>?> GetComicAsync(int comicId) => await GetResourceAsync<Comic>(ResourceRoutes.ComicsUrl.AppendPathSegment(comicId));
    public async Task<DataContainer<Comic>?> GetComicsAsync() => await GetResourceAsync<Comic>(ResourceRoutes.ComicsUrl);
    public async Task<DataContainer<Comic>?> GetComicsAsync(ComicOptionSet options) => await GetResourceAsync<Comic>(ResourceRoutes.ComicsUrl.SetQueryParams<ComicOptionSet>(options));
    public async Task<DataContainer<Comic>?> GetComicsByCharacterAsync(int characterId) => await GetResourceAsync<Comic>(ResourceRoutes.CharactersUrl.AppendPathSegment(characterId).AppendPathSegment(ResourceRoutes.Comics));
    public async Task<DataContainer<Comic>?> GetComicsByCharacterAsync(int characterId, ComicOptionSet options) => await GetResourceAsync<Comic>(ResourceRoutes.CharactersUrl.AppendPathSegment(characterId).AppendPathSegment(ResourceRoutes.Comics).SetQueryParams<ComicOptionSet>(options));
    public async Task<DataContainer<Comic>?> GetComicsByCreatorAsync(int creatorId) => await GetResourceAsync<Comic>(ResourceRoutes.CreatorsUrl.AppendPathSegment(creatorId).AppendPathSegment(ResourceRoutes.Comics));
    public async Task<DataContainer<Comic>?> GetComicsByCreatorAsync(int creatorId, ComicOptionSet options) => await GetResourceAsync<Comic>(ResourceRoutes.CreatorsUrl.AppendPathSegment(creatorId).AppendPathSegment(ResourceRoutes.Comics).SetQueryParams<ComicOptionSet>(options));
    public async Task<DataContainer<Comic>?> GetComicsByEventAsync(int eventId) => await GetResourceAsync<Comic>(ResourceRoutes.EventsUrl.AppendPathSegment(eventId).AppendPathSegment(ResourceRoutes.Comics));
    public async Task<DataContainer<Comic>?> GetComicsByEventAsync(int eventId, ComicOptionSet options) => await GetResourceAsync<Comic>(ResourceRoutes.EventsUrl.AppendPathSegment(eventId).AppendPathSegment(ResourceRoutes.Comics).SetQueryParams<ComicOptionSet>(options));
    public async Task<DataContainer<Comic>?> GetComicsBySeriesAsync(int seriesId) => await GetResourceAsync<Comic>(ResourceRoutes.SeriesUrl.AppendPathSegment(seriesId).AppendPathSegment(ResourceRoutes.Comics));
    public async Task<DataContainer<Comic>?> GetComicsBySeriesAsync(int seriesId, ComicOptionSet options) => await GetResourceAsync<Comic>(ResourceRoutes.SeriesUrl.AppendPathSegment(seriesId).AppendPathSegment(ResourceRoutes.Comics).SetQueryParams<ComicOptionSet>(options));
    public async Task<DataContainer<Comic>?> GetComicsByStoryAsync(int storyId) => await GetResourceAsync<Comic>(ResourceRoutes.StoriesUrl.AppendPathSegment(storyId).AppendPathSegment(ResourceRoutes.Comics));
    public async Task<DataContainer<Comic>?> GetComicsByStoryAsync(int storyId, ComicOptionSet options) => await GetResourceAsync<Comic>(ResourceRoutes.StoriesUrl.AppendPathSegment(storyId).AppendPathSegment(ResourceRoutes.Comics).SetQueryParams<ComicOptionSet>(options));

    public async Task<DataContainer<Creator>?> GetCreatorAsync(int creatorId) => await GetResourceAsync<Creator>(ResourceRoutes.CreatorsUrl.AppendPathSegment(creatorId));
    public async Task<DataContainer<Creator>?> GetCreatorsAsync() => await GetResourceAsync<Creator>(ResourceRoutes.CreatorsUrl);
    public async Task<DataContainer<Creator>?> GetCreatorsAsync(CreatorOptionSet options) => await GetResourceAsync<Creator>(ResourceRoutes.CreatorsUrl.SetQueryParams<CreatorOptionSet>(options));
    public async Task<DataContainer<Creator>?> GetCreatorsByComicAsync(int comicId) => await GetResourceAsync<Creator>(ResourceRoutes.ComicsUrl.AppendPathSegment(comicId).AppendPathSegment(ResourceRoutes.Creators));
    public async Task<DataContainer<Creator>?> GetCreatorsByComicAsync(int comicId, CreatorOptionSet options) => await GetResourceAsync<Creator>(ResourceRoutes.ComicsUrl.AppendPathSegment(comicId).AppendPathSegment(ResourceRoutes.Creators).SetQueryParams<CreatorOptionSet>(options));
    public async Task<DataContainer<Creator>?> GetCreatorsByEventAsync(int eventId) => await GetResourceAsync<Creator>(ResourceRoutes.EventsUrl.AppendPathSegment(eventId).AppendPathSegment(ResourceRoutes.Creators));
    public async Task<DataContainer<Creator>?> GetCreatorsByEventAsync(int eventId, CreatorOptionSet options) => await GetResourceAsync<Creator>(ResourceRoutes.EventsUrl.AppendPathSegment(eventId).AppendPathSegment(ResourceRoutes.Creators).SetQueryParams<CreatorOptionSet>(options));
    public async Task<DataContainer<Creator>?> GetCreatorsBySeriesAsync(int seriesId) => await GetResourceAsync<Creator>(ResourceRoutes.SeriesUrl.AppendPathSegment(seriesId).AppendPathSegment(ResourceRoutes.Creators));
    public async Task<DataContainer<Creator>?> GetCreatorsBySeriesAsync(int seriesId, CreatorOptionSet options) => await GetResourceAsync<Creator>(ResourceRoutes.SeriesUrl.AppendPathSegment(seriesId).AppendPathSegment(ResourceRoutes.Creators).SetQueryParams<CreatorOptionSet>(options));
    public async Task<DataContainer<Creator>?> GetCreatorsByStoryAsync(int storyId) => await GetResourceAsync<Creator>(ResourceRoutes.StoriesUrl.AppendPathSegment(storyId).AppendPathSegment(ResourceRoutes.Creators));
    public async Task<DataContainer<Creator>?> GetCreatorsByStoryAsync(int storyId, CreatorOptionSet options) => await GetResourceAsync<Creator>(ResourceRoutes.StoriesUrl.AppendPathSegment(storyId).AppendPathSegment(ResourceRoutes.Creators).SetQueryParams<CreatorOptionSet>(options));

    public async Task<DataContainer<Event>?> GetEventAsync(int eventId) => await GetResourceAsync<Event>(ResourceRoutes.EventsUrl.AppendPathSegment(eventId));
    public async Task<DataContainer<Event>?> GetEventsAsync() => await GetResourceAsync<Event>(ResourceRoutes.EventsUrl);
    public async Task<DataContainer<Event>?> GetEventsByComicAsync(int comicId) => await GetResourceAsync<Event>(ResourceRoutes.ComicsUrl.AppendPathSegment(comicId).AppendPathSegment(ResourceRoutes.Events));
    public async Task<DataContainer<Event>?> GetEventsByCharacterAsync(int creatorId) => await GetResourceAsync<Event>(ResourceRoutes.CharactersUrl.AppendPathSegment(creatorId).AppendPathSegment(ResourceRoutes.Events));
    public async Task<DataContainer<Event>?> GetEventsByCreatorAsync(int creatorId) => await GetResourceAsync<Event>(ResourceRoutes.CreatorsUrl.AppendPathSegment(creatorId).AppendPathSegment(ResourceRoutes.Events));
    public async Task<DataContainer<Event>?> GetEventsBySeriesAsync(int seriesId) => await GetResourceAsync<Event>(ResourceRoutes.SeriesUrl.AppendPathSegment(seriesId).AppendPathSegment(ResourceRoutes.Events));
    public async Task<DataContainer<Event>?> GetEventsByStoryAsync(int storyId) => await GetResourceAsync<Event>(ResourceRoutes.StoriesUrl.AppendPathSegment(storyId).AppendPathSegment(ResourceRoutes.Events));

    public async Task<DataContainer<Series>?> GetSeriesAsync(int seriesId) => await GetResourceAsync<Series>(ResourceRoutes.SeriesUrl.AppendPathSegment(seriesId));
    public async Task<DataContainer<Series>?> GetSeriesAsync() => await GetResourceAsync<Series>(ResourceRoutes.SeriesUrl);
    public async Task<DataContainer<Series>?> GetSeriesByCharacterAsync(int creatorId) => await GetResourceAsync<Series>(ResourceRoutes.CharactersUrl.AppendPathSegment(creatorId).AppendPathSegment(ResourceRoutes.Series));
    public async Task<DataContainer<Series>?> GetSeriesByCreatorAsync(int creatorId) => await GetResourceAsync<Series>(ResourceRoutes.CreatorsUrl.AppendPathSegment(creatorId).AppendPathSegment(ResourceRoutes.Series));
    public async Task<DataContainer<Series>?> GetSeriesByEventAsync(int eventId) => await GetResourceAsync<Series>(ResourceRoutes.EventsUrl.AppendPathSegment(eventId).AppendPathSegment(ResourceRoutes.Series));
    public async Task<DataContainer<Series>?> GetSeriesByStoryAsync(int storyId) => await GetResourceAsync<Series>(ResourceRoutes.StoriesUrl.AppendPathSegment(storyId).AppendPathSegment(ResourceRoutes.Series));

    public async Task<DataContainer<Story>?> GetStoryAsync(int storyId) => await GetResourceAsync<Story>(ResourceRoutes.StoriesUrl.AppendPathSegment(storyId));
    public async Task<DataContainer<Story>?> GetStoriesAsync() => await GetResourceAsync<Story>(ResourceRoutes.StoriesUrl);
    public async Task<DataContainer<Story>?> GetStoriesByComicAsync(int comicId) => await GetResourceAsync<Story>(ResourceRoutes.ComicsUrl.AppendPathSegment(comicId).AppendPathSegment(ResourceRoutes.Stories));
    public async Task<DataContainer<Story>?> GetStoriesByCharacterAsync(int creatorId) => await GetResourceAsync<Story>(ResourceRoutes.CharactersUrl.AppendPathSegment(creatorId).AppendPathSegment(ResourceRoutes.Stories));
    public async Task<DataContainer<Story>?> GetStoriesByCreatorAsync(int creatorId) => await GetResourceAsync<Story>(ResourceRoutes.CreatorsUrl.AppendPathSegment(creatorId).AppendPathSegment(ResourceRoutes.Stories));
    public async Task<DataContainer<Story>?> GetStoriesByEventAsync(int eventId) => await GetResourceAsync<Story>(ResourceRoutes.EventsUrl.AppendPathSegment(eventId).AppendPathSegment(ResourceRoutes.Stories));
    public async Task<DataContainer<Story>?> GetStoriesBySeriesAsync(int seriesId) => await GetResourceAsync<Story>(ResourceRoutes.SeriesUrl.AppendPathSegment(seriesId).AppendPathSegment(ResourceRoutes.Stories));
}
