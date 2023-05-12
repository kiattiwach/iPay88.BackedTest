using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace iPay88.BackedTest.Data;

/* This is used if database provider does't define
 * IBackedTestDbSchemaMigrator implementation.
 */
public class NullBackedTestDbSchemaMigrator : IBackedTestDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
