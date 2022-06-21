using Flurl;
using Flurl.Http;

namespace mmmPizza.MarvelSdk;

public partial class MarvelApiService
{
    // Public Methods
    public async Task<DataContainer<Series>?> GetSeriesAsync()
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Series);

        return await GetResourceAsync<Series>(url);
    }
    public async Task<DataContainer<Series>?> GetSeriesAsync(int seriesId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Series)
            .AppendPathSegment(seriesId);

        return await GetResourceAsync<Series>(url);
    }
    // public async Task<DataContainer<Series>?> GetSeriesByComicAsync(int comicId)
    // {
    //     Flurl.Url url = ResourceRoutes
    //         .BaseUrl
    //         .AppendPathSegment(ResourceRoutes.Comics)
    //         .AppendPathSegment(comicId)
    //         .AppendPathSegment(ResourceRoutes.Series);

    //     return await GetResourceAsync<Series>(url);
    // }
    public async Task<DataContainer<Series>?> GetSeriesByCharacterAsync(int creatorId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Characters)
            .AppendPathSegment(creatorId)
            .AppendPathSegment(ResourceRoutes.Series);

        return await GetResourceAsync<Series>(url);
    }
    public async Task<DataContainer<Series>?> GetSeriesByCreatorAsync(int creatorId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Creators)
            .AppendPathSegment(creatorId)
            .AppendPathSegment(ResourceRoutes.Series);

        return await GetResourceAsync<Series>(url);
    }
    public async Task<DataContainer<Series>?> GetSeriesByEventAsync(int eventId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Events)
            .AppendPathSegment(eventId)
            .AppendPathSegment(ResourceRoutes.Series);

        return await GetResourceAsync<Series>(url);
    }
    public async Task<DataContainer<Series>?> GetSeriesByStoryAsync(int storyId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Stories)
            .AppendPathSegment(storyId)
            .AppendPathSegment(ResourceRoutes.Series);

        return await GetResourceAsync<Series>(url);
    }
}
