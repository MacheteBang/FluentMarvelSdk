using Flurl;
using Flurl.Http;

namespace mmmPizza.MarvelSdk;

public partial class MarvelApiService
{
    // Public Methods
    public async Task<DataContainer<Event>?> GetEventsAsync()
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Events);

        return await GetResourceAsync<Event>(url);
    }
    public async Task<DataContainer<Event>?> GetEventAsync(int eventId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Events)
            .AppendPathSegment(eventId);

        return await GetResourceAsync<Event>(url);
    }
    public async Task<DataContainer<Event>?> GetEventsByComicAsync(int comicId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Comics)
            .AppendPathSegment(comicId)
            .AppendPathSegment(ResourceRoutes.Events);

        return await GetResourceAsync<Event>(url);
    }
    public async Task<DataContainer<Event>?> GetEventsByCharacterAsync(int creatorId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Characters)
            .AppendPathSegment(creatorId)
            .AppendPathSegment(ResourceRoutes.Events);

        return await GetResourceAsync<Event>(url);
    }
    public async Task<DataContainer<Event>?> GetEventsByCreatorAsync(int creatorId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Creators)
            .AppendPathSegment(creatorId)
            .AppendPathSegment(ResourceRoutes.Events);

        return await GetResourceAsync<Event>(url);
    }
    public async Task<DataContainer<Event>?> GetEventsBySeriesAsync(int seriesId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Series)
            .AppendPathSegment(seriesId)
            .AppendPathSegment(ResourceRoutes.Events);

        return await GetResourceAsync<Event>(url);
    }
    public async Task<DataContainer<Event>?> GetEventsByStoryAsync(int storyId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Stories)
            .AppendPathSegment(storyId)
            .AppendPathSegment(ResourceRoutes.Events);

        return await GetResourceAsync<Event>(url);
    }
}
