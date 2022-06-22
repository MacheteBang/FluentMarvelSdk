using Flurl;

namespace mmmPizza.MarvelSdk;

internal static class ResourceRoutes
{
    public static string Base = "https://gateway.marvel.com/v1/public";
    public static string Comics = "comics";
    public static string Characters = "characters";
    public static string Creators = "creators";
    public static string Events = "events";
    public static string Series = "series";
    public static string Stories = "stories";

    public static Flurl.Url ComicsUrl = Base.AppendPathSegment(Comics);
    public static Flurl.Url CharactersUrl = Base.AppendPathSegment(Characters);
    public static Flurl.Url CreatorsUrl = Base.AppendPathSegment(Creators);
    public static Flurl.Url EventsUrl = Base.AppendPathSegment(Events);
    public static Flurl.Url SeriesUrl = Base.AppendPathSegment(Series);
    public static Flurl.Url StoriesUrl = Base.AppendPathSegment(Stories);
}