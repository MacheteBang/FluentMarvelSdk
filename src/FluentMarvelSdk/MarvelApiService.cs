using System.Text.Json;
using Flurl.Http;

namespace FluentMarvelSdk;

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
    public ComicRequestBuilder GetComics(int comicId) => ComicRequestBuilder.Create(this, comicId);

    public CreatorRequestBuilder GetCreators() => CreatorRequestBuilder.Create(this);
    public CreatorRequestBuilder GetCreators(int creatorId) => CreatorRequestBuilder.Create(this, creatorId);

    public EventRequestBuilder GetEvents() => EventRequestBuilder.Create(this);
    public EventRequestBuilder GetEvents(int eventId) => EventRequestBuilder.Create(this, eventId);

    public SeriesRequestBuilder GetSeries() => SeriesRequestBuilder.Create(this);
    public SeriesRequestBuilder GetSeries(int seriesId) => SeriesRequestBuilder.Create(this, seriesId);

    public StoryRequestBuilder GetStories() => StoryRequestBuilder.Create(this);
    public StoryRequestBuilder GetStories(int storyId) => StoryRequestBuilder.Create(this, storyId);
}