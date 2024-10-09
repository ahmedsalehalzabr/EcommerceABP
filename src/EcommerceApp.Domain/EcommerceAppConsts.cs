using Volo.Abp.Identity;

namespace EcommerceApp;

public static class EcommerceAppConsts
{
    public const string DbTablePrefix = "App";
    public const string? DbSchema = null;
    public const string AdminEmailDefaultValue = IdentityDataSeedContributor.AdminEmailDefaultValue;
    public const string AdminPasswordDefaultValue = IdentityDataSeedContributor.AdminPasswordDefaultValue;
    public const int GeneralTextMaxlength = 300;

    public const int DescriptionTextMaxLength = 1000;
}
