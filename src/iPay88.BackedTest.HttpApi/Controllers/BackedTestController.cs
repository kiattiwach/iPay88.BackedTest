using iPay88.BackedTest.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace iPay88.BackedTest.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BackedTestController : AbpControllerBase
{
    protected BackedTestController()
    {
        LocalizationResource = typeof(BackedTestResource);
    }
}
