using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    //For NetCore 2.2 You must create FallbackController
    public class Fallback : Controller
    {
        public IActionResult Index()
        {
            //Same for Net Core 2.2 and 3.0
            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "index.html"), "text/HTML");
        }
    }
}