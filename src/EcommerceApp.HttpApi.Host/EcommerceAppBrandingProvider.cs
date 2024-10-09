using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace EcommerceApp;

[Dependency(ReplaceServices = true)]
public class EcommerceAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "EcommerceApp";
}
