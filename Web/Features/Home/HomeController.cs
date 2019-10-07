using Microsoft.AspNetCore.Mvc;

namespace Web.Features.Home
{

    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}