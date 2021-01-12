using BlogWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogWeb.Controllers
{
    public class AccountController:Controller
    {
        public IActionResult SignIn(){
            return View();
        }
        [HttpPost]
        public IActionResult SignIn(AppUserLoginModel model){
            return View();
        }
    }
}