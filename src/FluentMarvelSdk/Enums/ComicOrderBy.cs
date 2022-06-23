using Ardalis.SmartEnum;

namespace FluentMarvelSdk;

public sealed class ComicOrderBy : SmartEnum<ComicOrderBy, string>
{
    public static readonly ComicOrderBy FocDateAsc = new ComicOrderBy(nameof(FocDateAsc), "focDate");
    public static readonly ComicOrderBy FocDateDesc = new ComicOrderBy(nameof(FocDateDesc), "-focDate");
    public static readonly ComicOrderBy OnSaleDateAsc = new ComicOrderBy(nameof(OnSaleDateAsc), "onsaleDate");
    public static readonly ComicOrderBy OnSaleDateDesc = new ComicOrderBy(nameof(OnSaleDateDesc), "-onsaleDate");
    public static readonly ComicOrderBy TitleAsc = new ComicOrderBy(nameof(TitleAsc), "title");
    public static readonly ComicOrderBy TitleDesc = new ComicOrderBy(nameof(TitleDesc), "-title");
    public static readonly ComicOrderBy IssueNumberAsc = new ComicOrderBy(nameof(IssueNumberAsc), "issueNumber");
    public static readonly ComicOrderBy IssueNumberDesc = new ComicOrderBy(nameof(IssueNumberDesc), "-issueNumber");
    public static readonly ComicOrderBy ModifiedAsc = new ComicOrderBy(nameof(ModifiedAsc), "modified");
    public static readonly ComicOrderBy ModifiedDesc = new ComicOrderBy(nameof(ModifiedDesc), "-modified");

    private ComicOrderBy(string name, string value) : base(name, value) { }

    public override string ToString() => Value;
}