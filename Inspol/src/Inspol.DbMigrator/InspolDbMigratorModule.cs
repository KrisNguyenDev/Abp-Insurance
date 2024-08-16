using Inspol.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Inspol.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(InspolEntityFrameworkCoreModule),
    typeof(InspolApplicationContractsModule)
)]
public class InspolDbMigratorModule : AbpModule
{
}
