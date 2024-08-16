using Xunit;

namespace Inspol.EntityFrameworkCore;

[CollectionDefinition(InspolTestConsts.CollectionDefinitionName)]
public class InspolEntityFrameworkCoreCollection : ICollectionFixture<InspolEntityFrameworkCoreFixture>
{

}
