using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Inspol;

[Dependency(ReplaceServices = true)]
public class InspolBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Inspol";
}
