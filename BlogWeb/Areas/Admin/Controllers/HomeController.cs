using BlogWeb.Filters;
using Microsoft.AspNetCore.Mvc;

namespace BlogWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController:Controller
    {
        [JwtAuthorize]
        public IActionResult Index(){
            return View();
        }
    }
}