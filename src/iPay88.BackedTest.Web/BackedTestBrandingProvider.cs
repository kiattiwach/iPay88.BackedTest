using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace iPay88.BackedTest.Web;

[Dependency(ReplaceServices = true)]
public class BackedTestBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BackedTest";
}
