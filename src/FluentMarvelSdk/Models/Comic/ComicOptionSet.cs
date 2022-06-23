namespace FluentMarvelSdk;

public class ComicOptionSet : OptionSet
{
    public ComicFormats? Format { get; set; }
    public ComicFormatTypes? FormatType { get; set; }
    public bool? NoVariants { get; set; }
    public DateDescriptors? DateDescriptor { get; set; }
    public DateOnly[]? DateRange { get; set; }
    public string? Title { get; set; }
    public string? TitleStartsWith { get; set; }
    public int? StartYear { get; set; }
    public int? IssueNumber { get; set; }
    public string? DiamondCode { get; set; }
    public int? DigitalId { get; set; }
    public string? Upc { get; set; }
    public string? Isbn { get; set; }
    public string? Ean { get; set; }
    public string? Issn { get; set; }
    public bool? HasDigitalIssue { get; set; }
    public int[]? Creators { get; set; }
    public int[]? Characters { get; set; }
    public int[]? Series { get; set; }
    public int[]? Events { get; set; }
    public int[]? Stories { get; set; }
    public int[]? SharedAppearances { get; set; }
    public int[]? Collaborators { get; set; }
    public ComicOrderBy? OrderBy { get; set; }
}