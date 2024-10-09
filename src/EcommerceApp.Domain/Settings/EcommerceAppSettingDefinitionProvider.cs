using Volo.Abp.Settings;

namespace EcommerceApp.Settings;

public class EcommerceAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(EcommerceAppSettings.MySetting1));
    }
}
