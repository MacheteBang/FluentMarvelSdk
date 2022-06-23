using Flurl;

namespace FluentMarvelSdk;

internal static class ResourceRoutes
{
    private static string Base = "https://gateway.marvel.com/v1/public";
    private static string Comics = "comics";
    private static string Characters = "characters";
    private static string Creators = "creators";
    private static string Events = "events";
    private static string Series = "series";
    private static string Stories = "stories";

    public static Flurl.Url ComicsUrl = Base.AppendPathSegment(Comics);
    public static Flurl.Url CharactersUrl = Base.AppendPathSegment(Characters);
    public static Flurl.Url CreatorsUrl = Base.AppendPathSegment(Creators);
    public static Flurl.Url EventsUrl = Base.AppendPathSegment(Events);
    public static Flurl.Url SeriesUrl = Base.AppendPathSegment(Series);
    public static Flurl.Url StoriesUrl = Base.AppendPathSegment(Stories);

    public static Flurl.Url GetRoute<T>() => typeof(T).Name switch
    {
        nameof(Comic) => ComicsUrl,
        nameof(Character) => CharactersUrl,
        nameof(Creator) => CreatorsUrl,
        nameof(Event) => EventsUrl,
        nameof(FluentMarvelSdk.Series) => SeriesUrl,
        nameof(FluentMarvelSdk.Story) => StoriesUrl,
        _ => throw new Exception()
    };
}