using Flurl;
using Flurl.Http;

namespace mmmPizza.MarvelSdk;

public partial class MarvelApiService
{
    // Public Methods
    public async Task<DataContainer<Creator>?> GetCreatorsAsync()
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Creators);

        return await GetResourceAsync<Creator>(url);
    }
    public async Task<DataContainer<Creator>?> GetCreatorAsync(int creatorId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Creators)
            .AppendPathSegment(creatorId);

        return await GetResourceAsync<Creator>(url);
    }
    public async Task<DataContainer<Creator>?> GetCreatorsByComicAsync(int comicId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Comics)
            .AppendPathSegment(comicId)
            .AppendPathSegment(ResourceRoutes.Creators);

        return await GetResourceAsync<Creator>(url);
    }
    // public async Task<DataContainer<Creator>?> GetCreatorsByCharacterAsync(int creatorId)
    // {
    //     Flurl.Url url = ResourceRoutes
    //         .BaseUrl
    //         .AppendPathSegment(ResourceRoutes.Characters)
    //         .AppendPathSegment(creatorId)
    //         .AppendPathSegment(ResourceRoutes.Creators);

    //     return await GetResourceAsync<Creator>(url);
    // }
    public async Task<DataContainer<Creator>?> GetCreatorsByEventAsync(int eventId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Events)
            .AppendPathSegment(eventId)
            .AppendPathSegment(ResourceRoutes.Creators);

        return await GetResourceAsync<Creator>(url);
    }
    public async Task<DataContainer<Creator>?> GetCreatorsBySeriesAsync(int seriesId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Series)
            .AppendPathSegment(seriesId)
            .AppendPathSegment(ResourceRoutes.Creators);

        return await GetResourceAsync<Creator>(url);
    }
    public async Task<DataContainer<Creator>?> GetCreatorsByStoryAsync(int storyId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Stories)
            .AppendPathSegment(storyId)
            .AppendPathSegment(ResourceRoutes.Creators);

        return await GetResourceAsync<Creator>(url);
    }
}
