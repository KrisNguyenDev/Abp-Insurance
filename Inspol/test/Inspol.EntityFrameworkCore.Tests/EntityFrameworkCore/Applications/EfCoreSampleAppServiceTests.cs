using Inspol.Samples;
using Xunit;

namespace Inspol.EntityFrameworkCore.Applications;

[Collection(InspolTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<InspolEntityFrameworkCoreTestModule>
{

}
