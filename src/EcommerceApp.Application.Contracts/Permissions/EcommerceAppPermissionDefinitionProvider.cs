using EcommerceApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace EcommerceApp.Permissions;

public class EcommerceAppPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(EcommerceAppPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(EcommerceAppPermissions.MyPermission1, L("Permission:MyPermission1"));
        var productGroup = context.AddGroup(EcommerceAppPermissions.ProductGroupName, L("EcommercApp.Products"));
        productGroup.AddPermission(EcommerceAppPermissions.CreateEditProductPermission, L("Permission:Products:CreateEditProduct"));
        productGroup.AddPermission(EcommerceAppPermissions.DeleteProductPermission, L("Permission:Products:DeleteProduct"));
        productGroup.AddPermission(EcommerceAppPermissions.GetProductPermission, L("Permission:Products:GetProduct"));
        productGroup.AddPermission(EcommerceAppPermissions.ListProductPermission, L("Permission:Products:ListProduct"));

    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<EcommerceAppResource>(name);
    }
}
