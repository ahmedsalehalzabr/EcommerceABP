using Volo.Abp.Modularity;

namespace EcommerceApp;

/* Inherit from this class for your domain layer tests. */
public abstract class EcommerceAppDomainTestBase<TStartupModule> : EcommerceAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
