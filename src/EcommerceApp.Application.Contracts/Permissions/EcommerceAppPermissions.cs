namespace EcommerceApp.Permissions;

public static class EcommerceAppPermissions
{
    public const string GroupName = "EcommerceApp";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
    public const string ProductGroupName = GroupName + ".Products";
    public const string CreateEditProductPermission = ProductGroupName + ".CreateEdit";
    public const string DeleteProductPermission = ProductGroupName + ".Delete";
    public const string GetProductPermission = ProductGroupName + ".Get";
    public const string ListProductPermission = ProductGroupName + ".List"; 
}
