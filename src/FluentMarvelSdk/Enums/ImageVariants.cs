using Ardalis.SmartEnum;

public abstract class ImageVariants : SmartEnum<ImageVariants, string>
{
    public static readonly ImageVariants PortraitSmall = new PortraitSmallType();
    public static readonly ImageVariants PortraitMedium = new PortraitMediumType();
    public static readonly ImageVariants PortraitExtraLarge = new PortraitExtraLargeType();
    public static readonly ImageVariants PortraitFantastic = new PortraitFantasticType();
    public static readonly ImageVariants PortraitUncanny = new PortraitUncannyType();
    public static readonly ImageVariants PortraitIncredible = new PortraitIncredibleType();

    public static readonly ImageVariants SquareSmall = new SquareSmallType();
    public static readonly ImageVariants SquareMedium = new SquareMediumType();
    public static readonly ImageVariants SquareLarge = new SquareLargeType();
    public static readonly ImageVariants SquareExtraLarge = new SquareExtraLargeType();
    public static readonly ImageVariants SquareFantastic = new SquareFantasticType();
    public static readonly ImageVariants SquareAmazing = new SquareAmazingType();

    public static readonly ImageVariants LandscapeSmall = new LandscapeSmallType();
    public static readonly ImageVariants LandscapeMedium = new LandscapeMediumType();
    public static readonly ImageVariants LandscapeLarge = new LandscapeLargeType();
    public static readonly ImageVariants LandscapeExtraLarge = new LandscapeExtraLargeType();
    public static readonly ImageVariants LandscapeAmazing = new LandscapeAmazingType();
    public static readonly ImageVariants LandscapeIncredible = new LandscapeIncredibleType();
    
    public static readonly ImageVariants Detail = new DetailType();
    public static readonly ImageVariants FullSize = new FullSizeType();

    private ImageVariants(string name, string value) : base(name, value) { }
    public abstract string Dimensions { get; }

    #region Portrait
    private sealed class PortraitSmallType : ImageVariants
    {
        public PortraitSmallType() : base("PortraitSmall", "portrait_small") { }
        public override string Dimensions => "50x75";
    }
    private sealed class PortraitMediumType : ImageVariants
    {
        public PortraitMediumType() : base("PortraitMedium", "portrait_medium") { }
        public override string Dimensions => "100x150";
    }
    private sealed class PortraitExtraLargeType : ImageVariants
    {
        public PortraitExtraLargeType() : base("PortraitExtraLarge", "portrait_xlarge") { }
        public override string Dimensions => "150x225";
    }
    private sealed class PortraitFantasticType : ImageVariants
    {
        public PortraitFantasticType() : base("PortraitFantastic", "portrait_fantastic") { }
        public override string Dimensions => "168x252";
    }
    private sealed class PortraitUncannyType : ImageVariants
    {
        public PortraitUncannyType() : base("PortraitUncanny", "portrait_uncanny") { }
        public override string Dimensions => "300x450";
    }
    private sealed class PortraitIncredibleType : ImageVariants
    {
        public PortraitIncredibleType() : base("PortraitIncredible", "portrait_incredible") { }
        public override string Dimensions => "216x450";
    }
    #endregion

    #region Square
    private sealed class SquareSmallType : ImageVariants
    {
        public SquareSmallType() : base("SquareSmall", "standard_small") { }
        public override string Dimensions => "65x45";
    }
    private sealed class SquareMediumType : ImageVariants
    {
        public SquareMediumType() : base("SquareMedium", "standard_medium") { }
        public override string Dimensions => "100x100";
    }
    private sealed class SquareLargeType : ImageVariants
    {
        public SquareLargeType() : base("SquareLarge", "standard_large") { }
        public override string Dimensions => "140x140";
    }
    private sealed class SquareExtraLargeType : ImageVariants
    {
        public SquareExtraLargeType() : base("SquareExtraLarge", "standard_xlarge") { }
        public override string Dimensions => "200x200";
    }
    private sealed class SquareFantasticType : ImageVariants
    {
        public SquareFantasticType() : base("SquareFantastic", "standard_fantastic") { }
        public override string Dimensions => "250x250";
    }
    private sealed class SquareAmazingType : ImageVariants
    {
        public SquareAmazingType() : base("SquareAmazing", "standard_amazing") { }
        public override string Dimensions => "180x180";
    }
    #endregion

    #region Landscape
    private sealed class LandscapeSmallType : ImageVariants
    {
        public LandscapeSmallType() : base("LandscapeSmall", "landscape_small") { }
        public override string Dimensions => "120x90";
    }
    private sealed class LandscapeMediumType : ImageVariants
    {
        public LandscapeMediumType() : base("LandscapeMedium", "landscape_medium") { }
        public override string Dimensions => "175x130";
    }
    private sealed class LandscapeLargeType : ImageVariants
    {
        public LandscapeLargeType() : base("LandscapeLarge", "landscape_large") { }
        public override string Dimensions => "190x140";
    }
    private sealed class LandscapeExtraLargeType : ImageVariants
    {
        public LandscapeExtraLargeType() : base("LandscapeExtraLarge", "landscape_xlarge") { }
        public override string Dimensions => "270x200";
    }
    private sealed class LandscapeAmazingType : ImageVariants
    {
        public LandscapeAmazingType() : base("LandscapeAmazing", "landscape_amazing") { }
        public override string Dimensions => "250x156";
    }
    private sealed class LandscapeIncredibleType : ImageVariants
    {
        public LandscapeIncredibleType() : base("LandscapeIncredible", "landscape_incredible") { }
        public override string Dimensions => "464x261";
    }
    #endregion

    #region Detail
    private sealed class DetailType : ImageVariants
    {
        public DetailType() : base("detail", "detail") { }
        public override string Dimensions => "max 500px wide";
    }
    private sealed class FullSizeType : ImageVariants
    {
        public FullSizeType() : base("FullSize", "") { }
        public override string Dimensions => "";
    }

    #endregion
}