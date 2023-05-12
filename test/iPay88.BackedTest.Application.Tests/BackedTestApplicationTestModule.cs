using Volo.Abp.Modularity;

namespace iPay88.BackedTest;

[DependsOn(
    typeof(BackedTestApplicationModule),
    typeof(BackedTestDomainTestModule)
    )]
public class BackedTestApplicationTestModule : AbpModule
{

}
