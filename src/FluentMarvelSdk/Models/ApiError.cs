namespace FluentMarvelSdk;

internal class ApiError
{
    public string Code { get; set; } = default!;
    public string Message { get; set; } = default!;
    public string Status { get; set; } = default!;
}