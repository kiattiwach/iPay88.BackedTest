using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace iPay88.BackedTest.Pages;

public class Index_Tests : BackedTestWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
