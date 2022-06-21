using Flurl;
using Flurl.Http;

namespace mmmPizza.MarvelSdk;

public partial class MarvelApiService
{
    // Public Methods
    public async Task<DataContainer<Story>?> GetStoriesAsync()
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Stories);

        return await GetResourceAsync<Story>(url);
    }
    public async Task<DataContainer<Story>?> GetStoryAsync(int storyId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Stories)
            .AppendPathSegment(storyId);

        return await GetResourceAsync<Story>(url);
    }
    public async Task<DataContainer<Story>?> GetStoriesByComicAsync(int comicId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Comics)
            .AppendPathSegment(comicId)
            .AppendPathSegment(ResourceRoutes.Stories);

        return await GetResourceAsync<Story>(url);
    }
    public async Task<DataContainer<Story>?> GetStoriesByCharacterAsync(int creatorId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Characters)
            .AppendPathSegment(creatorId)
            .AppendPathSegment(ResourceRoutes.Stories);

        return await GetResourceAsync<Story>(url);
    }
    public async Task<DataContainer<Story>?> GetStoriesByCreatorAsync(int creatorId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Creators)
            .AppendPathSegment(creatorId)
            .AppendPathSegment(ResourceRoutes.Stories);

        return await GetResourceAsync<Story>(url);
    }
    public async Task<DataContainer<Story>?> GetStoriesByEventAsync(int eventId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Events)
            .AppendPathSegment(eventId)
            .AppendPathSegment(ResourceRoutes.Stories);

        return await GetResourceAsync<Story>(url);
    }
    public async Task<DataContainer<Story>?> GetStoriesBySeriesAsync(int seriesId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Series)
            .AppendPathSegment(seriesId)
            .AppendPathSegment(ResourceRoutes.Stories);

        return await GetResourceAsync<Story>(url);
    }
}
