using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace iPay88.BackedTest.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class BackedTestDbContextFactory : IDesignTimeDbContextFactory<BackedTestDbContext>
{
    public BackedTestDbContext CreateDbContext(string[] args)
    {
        BackedTestEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<BackedTestDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new BackedTestDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../iPay88.BackedTest.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
