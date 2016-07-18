using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HelloAspNetLogging.Controllers
{
    public class HomeController : Controller
    {
        // This is just a private reference to the logger, which prevents the need to create a new instance for each request
        private ILogger<HomeController> logger;

        // To ask for a logger via dependency injection, define a constructor with an ILogger parameter like this.
        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }

        public IActionResult Index()
        {
            //Console.WriteLine("Hello from the HomeController!");
            logger.LogWarning("Hello from the HomeController logger!");

            // Note the following extensions exist
            // logger.LogTrace();
            // logger.LogDebug();
            // logger.LogInformation();
            // logger.LogWarning();
            // logger.LogError();
            // logger.LogCritical();            

            return View("Index");
        }
    }
}