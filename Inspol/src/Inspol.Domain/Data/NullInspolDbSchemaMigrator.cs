using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Inspol.Data;

/* This is used if database provider does't define
 * IInspolDbSchemaMigrator implementation.
 */
public class NullInspolDbSchemaMigrator : IInspolDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
