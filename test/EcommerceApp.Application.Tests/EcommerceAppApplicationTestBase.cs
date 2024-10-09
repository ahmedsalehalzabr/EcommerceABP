using Volo.Abp.Modularity;

namespace EcommerceApp;

public abstract class EcommerceAppApplicationTestBase<TStartupModule> : EcommerceAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
