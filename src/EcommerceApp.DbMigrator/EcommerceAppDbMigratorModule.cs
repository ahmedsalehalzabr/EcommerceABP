using EcommerceApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace EcommerceApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(EcommerceAppEntityFrameworkCoreModule),
    typeof(EcommerceAppApplicationContractsModule)
)]
public class EcommerceAppDbMigratorModule : AbpModule
{
}
