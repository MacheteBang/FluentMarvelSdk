namespace FluentMarvelSdk;

public sealed class CreatorOrderBy : ResourceOrderBy
{
    public static readonly CreatorOrderBy LastNameAsc = new CreatorOrderBy(nameof(LastNameAsc), "lastName");
    public static readonly CreatorOrderBy LastNameDesc = new CreatorOrderBy(nameof(LastNameDesc), "-lastName");
    public static readonly CreatorOrderBy FirstNameAsc = new CreatorOrderBy(nameof(FirstNameAsc), "firstName");
    public static readonly CreatorOrderBy FirstNameDesc = new CreatorOrderBy(nameof(FirstNameDesc), "-firstName");
    public static readonly CreatorOrderBy MiddleNameAsc = new CreatorOrderBy(nameof(MiddleNameAsc), "middleName");
    public static readonly CreatorOrderBy MiddleNameDesc = new CreatorOrderBy(nameof(MiddleNameDesc), "-middleName");
    public static readonly CreatorOrderBy SuffixAsc = new CreatorOrderBy(nameof(SuffixAsc), "suffix");
    public static readonly CreatorOrderBy SuffixDesc = new CreatorOrderBy(nameof(SuffixDesc), "-suffix");

    private CreatorOrderBy(string name, string value) : base(name, value) { }
}