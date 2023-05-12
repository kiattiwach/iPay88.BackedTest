using System.Threading.Tasks;

namespace iPay88.BackedTest.Data;

public interface IBackedTestDbSchemaMigrator
{
    Task MigrateAsync();
}
