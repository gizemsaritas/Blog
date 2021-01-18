using BlogAPI.Business.Tools.FacadeTool;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErrorController : ControllerBase
    {
        private readonly IFacade _facade;

        public ErrorController(IFacade facade)
        {
            _facade = facade;
        }
        [HttpGet]
        public IActionResult Error()
        {
            var errorInfo = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            _facade.CustomLogger.LogError($"Hatanın oluştuğu yer:{errorInfo.Path}\n Hata Mesajı:{errorInfo.Error.Message}\n Stack Trace : {errorInfo.Error.StackTrace}");
            return Problem(detail: "bir hata oluştu");
        }
    }
}
