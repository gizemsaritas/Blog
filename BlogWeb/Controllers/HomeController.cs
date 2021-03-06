using System.Threading.Tasks;
using BlogWeb.ApiServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogApiService _blogApiService;

        public HomeController(IBlogApiService blogApiService)
        {
            _blogApiService=blogApiService;
        }
        public async Task<IActionResult> Index(int? categoryId)
        {
            if(categoryId.HasValue){
                ViewBag.ActiveCategory=categoryId;
                return View(await _blogApiService.GetAllByCategoryIdAsync((int)categoryId));
            }
            return View(await _blogApiService.GetAllAsync());
        }
        public async Task<IActionResult> BlogDetail(int id){
            ViewBag.Comments=await _blogApiService.GetCommentsAsync(id,null);
            return View(await _blogApiService.GetByIdAsync(id));
        }
    }
}