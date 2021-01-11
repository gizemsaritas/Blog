using Microsoft.AspNetCore.Mvc;

namespace BlogWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}