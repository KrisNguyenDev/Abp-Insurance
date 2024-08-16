using Volo.Abp.Modularity;

namespace Inspol;

[DependsOn(
    typeof(InspolDomainModule),
    typeof(InspolTestBaseModule)
)]
public class InspolDomainTestModule : AbpModule
{

}
