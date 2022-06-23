using Ardalis.SmartEnum;

public sealed class ComicFormats : SmartEnum<ComicFormats, string>
{
    public static readonly ComicFormats Comic = new ComicFormats(nameof(Comic), "comic");
    public static readonly ComicFormats Magazine = new ComicFormats(nameof(Magazine), "magazine");
    public static readonly ComicFormats TradePaperback = new ComicFormats(nameof(TradePaperback), "trade paperback");
    public static readonly ComicFormats Hardcover = new ComicFormats(nameof(Hardcover), "hardcover");
    public static readonly ComicFormats Digest = new ComicFormats(nameof(Digest), "digest");
    public static readonly ComicFormats GraphicNovel = new ComicFormats(nameof(GraphicNovel), "graphic novel");
    public static readonly ComicFormats DigitalComic = new ComicFormats(nameof(DigitalComic), "digital comic");
    public static readonly ComicFormats InfiniteComic = new ComicFormats(nameof(InfiniteComic), "infinite comic");

    private ComicFormats(string name, string value) : base(name, value) { }

    public override string ToString() => Value;
}