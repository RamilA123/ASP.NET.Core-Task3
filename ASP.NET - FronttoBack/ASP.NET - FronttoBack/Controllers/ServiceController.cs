using Microsoft.AspNetCore.Mvc;
using ASP.NET___FronttoBack.Models;

namespace ASP.NET___FronttoBack.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
