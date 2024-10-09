using System.Threading.Tasks;

namespace EcommerceApp.Data;

public interface IEcommerceAppDbSchemaMigrator
{
    Task MigrateAsync();
}
