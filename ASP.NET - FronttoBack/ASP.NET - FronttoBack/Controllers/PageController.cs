using Microsoft.AspNetCore.Mvc;

namespace ASP.NET___FronttoBack.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
