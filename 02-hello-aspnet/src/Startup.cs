using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace HelloAspNet
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            // You can define your own middleware like this, but it's not very flexible and you can only do a few
            // simple things with it. This shows how to write static html out to the client.
            //
            // ASP.NET has a TON of middleware options, like authentication and MVC. These will be explored in the next
            // few tutorials.
            app.Run(async context => {
                
                context.Response.ContentType = @"text/html";

                await context.Response.WriteAsync(
                    "<h3>Hello World</h3>"
                    + $"<p>Framework: {Microsoft.Extensions.PlatformAbstractions.PlatformServices.Default.Application.RuntimeFramework}</p>"
                    + $"<p>{System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription}, {System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture}, {Microsoft.Extensions.PlatformAbstractions.PlatformServices.Default.Application.RuntimeFramework.Version}</p>"
                    + $"<p>OS: {System.Runtime.InteropServices.RuntimeInformation.OSDescription} {System.Runtime.InteropServices.RuntimeInformation.OSArchitecture}</p>"
                );
            });
        }
    }
}