using Volo.Abp.Modularity;

namespace Inspol;

public abstract class InspolApplicationTestBase<TStartupModule> : InspolTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
