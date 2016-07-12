using System;
using Microsoft.AspNetCore.Mvc;

namespace HelloAspNetMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Console.WriteLine("Hello from the HomeController!");
            return View("Index");
        }
    }
}