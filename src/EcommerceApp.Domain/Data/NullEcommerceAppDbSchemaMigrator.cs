using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace EcommerceApp.Data;

/* This is used if database provider does't define
 * IEcommerceAppDbSchemaMigrator implementation.
 */
public class NullEcommerceAppDbSchemaMigrator : IEcommerceAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
