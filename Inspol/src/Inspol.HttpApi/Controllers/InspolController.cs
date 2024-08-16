using Inspol.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Inspol.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class InspolController : AbpControllerBase
{
    protected InspolController()
    {
        LocalizationResource = typeof(InspolResource);
    }
}
