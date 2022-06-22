using System.Reflection;
using Flurl;
using Flurl.Http;

namespace mmmPizza.MarvelSdk;

public partial class MarvelApiService
{
    // Public Methods
    public async Task<DataContainer<Character>?> GetCharactersAsync()
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Characters);

        return await GetResourceAsync<Character>(url);
    }
    public async Task<DataContainer<Character>?> GetCharactersAsync(CharacterOptions options)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Characters)
            .SetQueryParams<CharacterOptions>(options);        

        return await GetResourceAsync<Character>(url);
    }
    public async Task<DataContainer<Character>?> GetCharacterAsync(int characterId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Characters)
            .AppendPathSegment(characterId);

        return await GetResourceAsync<Character>(url);
    }
    public async Task<DataContainer<Character>?> GetCharactersByComicAsync(int comicId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Comics)
            .AppendPathSegment(comicId)
            .AppendPathSegment(ResourceRoutes.Characters);

        return await GetResourceAsync<Character>(url);
    }
    // public async Task<DataContainer<Character>?> GetCharactersByCreatorAsync(int creatorId)
    // {
    //     Flurl.Url url = ResourceRoutes
    //         .BaseUrl
    //         .AppendPathSegment(ResourceRoutes.Creators)
    //         .AppendPathSegment(creatorId)
    //         .AppendPathSegment(ResourceRoutes.Characters);

    //     return await GetResourceAsync<Character>(url);
    // }
    public async Task<DataContainer<Character>?> GetCharactersByEventAsync(int eventId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Events)
            .AppendPathSegment(eventId)
            .AppendPathSegment(ResourceRoutes.Characters);

        return await GetResourceAsync<Character>(url);
    }
    public async Task<DataContainer<Character>?> GetCharactersBySeriesAsync(int seriesId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Series)
            .AppendPathSegment(seriesId)
            .AppendPathSegment(ResourceRoutes.Characters);

        return await GetResourceAsync<Character>(url);
    }
    public async Task<DataContainer<Character>?> GetCharactersByStoryAsync(int storyId)
    {
        Flurl.Url url = ResourceRoutes
            .BaseUrl
            .AppendPathSegment(ResourceRoutes.Stories)
            .AppendPathSegment(storyId)
            .AppendPathSegment(ResourceRoutes.Characters);

        return await GetResourceAsync<Character>(url);
    }
}
