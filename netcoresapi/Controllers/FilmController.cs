using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netcoresapi.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace netcoresapi.Controllers
{
    [Route("api/[controller]")]
    public class FilmsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            SakilaContext context = HttpContext.RequestServices.GetService(typeof(Models.SakilaContext)) as SakilaContext;

            return View("~/Views/Films/Index.cshtml",context.GetAllFilms());
        }
    }
}
