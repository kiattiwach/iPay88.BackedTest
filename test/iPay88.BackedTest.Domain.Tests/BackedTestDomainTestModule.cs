using iPay88.BackedTest.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace iPay88.BackedTest;

[DependsOn(
    typeof(BackedTestEntityFrameworkCoreTestModule)
    )]
public class BackedTestDomainTestModule : AbpModule
{

}
