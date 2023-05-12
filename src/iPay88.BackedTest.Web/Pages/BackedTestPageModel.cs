using iPay88.BackedTest.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace iPay88.BackedTest.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class BackedTestPageModel : AbpPageModel
{
    protected BackedTestPageModel()
    {
        LocalizationResourceType = typeof(BackedTestResource);
    }
}
