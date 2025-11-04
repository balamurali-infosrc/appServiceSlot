using Microsoft.AspNetCore.Mvc;

namespace SlotDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return Content("✅ App is working! Home route found!");
        }
    }
}
