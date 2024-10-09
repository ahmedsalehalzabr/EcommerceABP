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
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<EcommerceAppResource>(name);
    }
}
