using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HelloAspNetLogging
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // Add an ILoggerFactory parameter here to request that logging be added via Dependency Injection
        // For more info on dependency injection in .NET Core, see https://docs.asp.net/en/latest/fundamentals/dependency-injection.html
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            // Here, AddConsole is an extension method provided by the Microsoft.Extensions.Logging.Console package
            // Normally you'll want another logging solution, like Serilog which provides a wide variety of logging storage formats.
            //
            // Head over to Controllers/HomeController.cs to see how to create and use an ILogger instance
            loggerFactory.AddConsole(LogLevel.Warning);
            
            // This uses the default route, which is www.domain.com/controller/action with an optional id parameter
            // This is the middleware that calls into the Controllers/HomeController.cs to render a page.
            app.UseMvcWithDefaultRoute();
        }
    }
}