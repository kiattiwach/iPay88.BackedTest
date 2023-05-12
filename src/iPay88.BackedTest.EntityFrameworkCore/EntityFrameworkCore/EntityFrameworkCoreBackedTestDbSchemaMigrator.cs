using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using iPay88.BackedTest.Data;
using Volo.Abp.DependencyInjection;

namespace iPay88.BackedTest.EntityFrameworkCore;

public class EntityFrameworkCoreBackedTestDbSchemaMigrator
    : IBackedTestDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBackedTestDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the BackedTestDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BackedTestDbContext>()
            .Database
            .MigrateAsync();
    }
}
