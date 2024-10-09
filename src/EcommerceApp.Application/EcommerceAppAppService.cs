using EcommerceApp.Localization;
using Volo.Abp.Application.Services;

namespace EcommerceApp;

/* Inherit your application services from this class.
 */
public abstract class EcommerceAppAppService : ApplicationService
{
    protected EcommerceAppAppService()
    {
        LocalizationResource = typeof(EcommerceAppResource);
    }
}
