using Inspol.Localization;
using Volo.Abp.Application.Services;

namespace Inspol;

/* Inherit your application services from this class.
 */
public abstract class InspolAppService : ApplicationService
{
    protected InspolAppService()
    {
        LocalizationResource = typeof(InspolResource);
    }
}
