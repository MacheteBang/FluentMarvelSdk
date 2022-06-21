using Flurl;
using Flurl.Http;

namespace mmmPizza.MarvelSdk;

public partial class MarvelApiService
{
    // Public Methods
    public async Task<DataContainer<Comic>?> GetComicsAsync()
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Comics);

        return await GetResourceAsync<Comic>(url);
    }
    public async Task<DataContainer<Comic>?> GetComicAsync(int comicId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Comics)
            .AppendPathSegment(comicId);

        return await GetResourceAsync<Comic>(url);
    }
    public async Task<DataContainer<Comic>?> GetComicsByCharacterAsync(int characterId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Characters)
            .AppendPathSegment(characterId)
            .AppendPathSegment(ResourceRoutes.Comics);

        return await GetResourceAsync<Comic>(url);
    }
    public async Task<DataContainer<Comic>?> GetComicsByCreatorAsync(int creatorId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Creators)
            .AppendPathSegment(creatorId)
            .AppendPathSegment(ResourceRoutes.Comics);

        return await GetResourceAsync<Comic>(url);
    }
    public async Task<DataContainer<Comic>?> GetComicsByEventAsync(int eventId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Events)
            .AppendPathSegment(eventId)
            .AppendPathSegment(ResourceRoutes.Comics);

        return await GetResourceAsync<Comic>(url);
    }
    public async Task<DataContainer<Comic>?> GetComicsBySeriesAsync(int seriesId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Series)
            .AppendPathSegment(seriesId)
            .AppendPathSegment(ResourceRoutes.Comics);

        return await GetResourceAsync<Comic>(url);
    }
    public async Task<DataContainer<Comic>?> GetComicsByStoryAsync(int storyId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Stories)
            .AppendPathSegment(storyId)
            .AppendPathSegment(ResourceRoutes.Comics);

        return await GetResourceAsync<Comic>(url);
    }
}
