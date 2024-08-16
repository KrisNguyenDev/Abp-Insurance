using System.Threading.Tasks;

namespace Inspol.Data;

public interface IInspolDbSchemaMigrator
{
    Task MigrateAsync();
}
