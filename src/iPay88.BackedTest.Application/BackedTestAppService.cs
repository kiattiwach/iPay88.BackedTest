using System;
using System.Collections.Generic;
using System.Text;
using iPay88.BackedTest.Localization;
using Volo.Abp.Application.Services;

namespace iPay88.BackedTest;

/* Inherit your application services from this class.
 */
public abstract class BackedTestAppService : ApplicationService
{
    protected BackedTestAppService()
    {
        LocalizationResource = typeof(BackedTestResource);
    }
}
