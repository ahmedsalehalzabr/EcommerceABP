using Volo.Abp.Modularity;

namespace EcommerceApp;

[DependsOn(
    typeof(EcommerceAppDomainModule),
    typeof(EcommerceAppTestBaseModule)
)]
public class EcommerceAppDomainTestModule : AbpModule
{

}
