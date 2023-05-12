using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace iPay88.BackedTest;

public class BackedTestWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<BackedTestWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
