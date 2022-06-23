namespace FluentMarvelSdk;

public static class ImageExtensions
{
    public static string? ToImageUrl(this Image? image, ImageVariants variant)
    {
        if (image is null) return "";
        if (string.IsNullOrWhiteSpace(image.Path)) return "";
        if (string.IsNullOrWhiteSpace(image.Extension)) return "";

        string imagePath = image.Path;
        if (variant != ImageVariants.Detail) imagePath += "/" + variant.Value;

        imagePath += "." + image.Extension;

        return imagePath;
    }
}