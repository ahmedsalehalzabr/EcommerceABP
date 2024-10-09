using EcommerceApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace EcommerceApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class EcommerceAppController : AbpControllerBase
{
    protected EcommerceAppController()
    {
        LocalizationResource = typeof(EcommerceAppResource);
    }
}
