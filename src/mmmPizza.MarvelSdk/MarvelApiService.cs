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
    internal async Task<DataContainer<T>?> GetResourceAsync<T>(Flurl.Url url)
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

        DataWrapper<T>? wrapper = JsonSerializer.Deserialize<DataWrapper<T>>(json, _jsonOptions);

        return wrapper?.Data;
    }

    // Public Methods
    public CharacterRequestBuilder GetCharacters() => CharacterRequestBuilder.Create(this);
    public CharacterRequestBuilder GetCharacters(int characterId) => CharacterRequestBuilder.Create(this, characterId);

    public ComicRequestBuilder GetComics() => ComicRequestBuilder.Create(this);
    public ComicRequestBuilder GetComics(int comicId) => ComicRequestBuilder.Create(this);

    public CreatorRequestBuilder GetCreators() => CreatorRequestBuilder.Create(this);
    public CreatorRequestBuilder GetCreators(int creatorId) => CreatorRequestBuilder.Create(this, creatorId);

    public EventRequestBuilder GetEvents() => EventRequestBuilder.Create(this);
    public EventRequestBuilder GetEvents(int eventId) => EventRequestBuilder.Create(this, eventId);

    public SeriesRequestBuilder GetSeries() => SeriesRequestBuilder.Create(this);
    public SeriesRequestBuilder GetSeries(int seriesId) => SeriesRequestBuilder.Create(this, seriesId);

    // public async Task<DataContainer<Story>?> GetStoryAsync(int storyId) => await GetResourceAsync<Story>(ResourceRoutes.StoriesUrl.AppendPathSegment(storyId));
    // public async Task<DataContainer<Story>?> GetStoriesAsync() => await GetResourceAsync<Story>(ResourceRoutes.StoriesUrl);
    // public async Task<DataContainer<Story>?> GetStoriesAsync(StoryOptionSet options) => await GetResourceAsync<Story>(ResourceRoutes.StoriesUrl.SetQueryParams<StoryOptionSet>(options));
    // public async Task<DataContainer<Story>?> GetStoriesByComicAsync(int comicId) => await GetResourceAsync<Story>(ResourceRoutes.ComicsUrl.AppendPathSegment(comicId).AppendPathSegment(ResourceRoutes.Stories));
    // public async Task<DataContainer<Story>?> GetStoriesByComicAsync(int comicId, StoryOptionSet options) => await GetResourceAsync<Story>(ResourceRoutes.ComicsUrl.AppendPathSegment(comicId).AppendPathSegment(ResourceRoutes.Stories).SetQueryParams<StoryOptionSet>(options));
    // public async Task<DataContainer<Story>?> GetStoriesByCharacterAsync(int characterId) => await GetResourceAsync<Story>(ResourceRoutes.CharactersUrl.AppendPathSegment(characterId).AppendPathSegment(ResourceRoutes.Stories));
    // public async Task<DataContainer<Story>?> GetStoriesByCharacterAsync(int characterId, StoryOptionSet options) => await GetResourceAsync<Story>(ResourceRoutes.CharactersUrl.AppendPathSegment(characterId).AppendPathSegment(ResourceRoutes.Stories).SetQueryParams<StoryOptionSet>(options));
    // public async Task<DataContainer<Story>?> GetStoriesByCreatorAsync(int creatorId) => await GetResourceAsync<Story>(ResourceRoutes.CreatorsUrl.AppendPathSegment(creatorId).AppendPathSegment(ResourceRoutes.Stories));
    // public async Task<DataContainer<Story>?> GetStoriesByCreatorAsync(int creatorId, StoryOptionSet options) => await GetResourceAsync<Story>(ResourceRoutes.CreatorsUrl.AppendPathSegment(creatorId).AppendPathSegment(ResourceRoutes.Stories).SetQueryParams<StoryOptionSet>(options));
    // public async Task<DataContainer<Story>?> GetStoriesByEventAsync(int eventId) => await GetResourceAsync<Story>(ResourceRoutes.EventsUrl.AppendPathSegment(eventId).AppendPathSegment(ResourceRoutes.Stories));
    // public async Task<DataContainer<Story>?> GetStoriesByEventAsync(int eventId, StoryOptionSet options) => await GetResourceAsync<Story>(ResourceRoutes.EventsUrl.AppendPathSegment(eventId).AppendPathSegment(ResourceRoutes.Stories).SetQueryParams<StoryOptionSet>(options));
    // public async Task<DataContainer<Story>?> GetStoriesBySeriesAsync(int seriesId) => await GetResourceAsync<Story>(ResourceRoutes.SeriesUrl.AppendPathSegment(seriesId).AppendPathSegment(ResourceRoutes.Stories));
    // public async Task<DataContainer<Story>?> GetStoriesBySeriesAsync(int seriesId, StoryOptionSet options) => await GetResourceAsync<Story>(ResourceRoutes.SeriesUrl.AppendPathSegment(seriesId).AppendPathSegment(ResourceRoutes.Stories).SetQueryParams<StoryOptionSet>(options));

}
