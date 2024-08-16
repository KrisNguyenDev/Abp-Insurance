using Inspol.Samples;
using Xunit;

namespace Inspol.EntityFrameworkCore.Domains;

[Collection(InspolTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<InspolEntityFrameworkCoreTestModule>
{

}
