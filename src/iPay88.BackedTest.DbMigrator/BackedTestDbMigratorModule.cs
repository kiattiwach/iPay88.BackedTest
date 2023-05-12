using iPay88.BackedTest.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace iPay88.BackedTest.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BackedTestEntityFrameworkCoreModule),
    typeof(BackedTestApplicationContractsModule)
    )]
public class BackedTestDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
