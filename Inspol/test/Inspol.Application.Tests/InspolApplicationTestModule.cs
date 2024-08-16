using Volo.Abp.Modularity;

namespace Inspol;

[DependsOn(
    typeof(InspolApplicationModule),
    typeof(InspolDomainTestModule)
)]
public class InspolApplicationTestModule : AbpModule
{

}
