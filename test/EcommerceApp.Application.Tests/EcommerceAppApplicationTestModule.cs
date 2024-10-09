using Volo.Abp.Modularity;

namespace EcommerceApp;

[DependsOn(
    typeof(EcommerceAppApplicationModule),
    typeof(EcommerceAppDomainTestModule)
)]
public class EcommerceAppApplicationTestModule : AbpModule
{

}
