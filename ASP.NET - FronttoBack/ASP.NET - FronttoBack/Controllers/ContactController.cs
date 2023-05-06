using Microsoft.AspNetCore.Mvc;

namespace ASP.NET___FronttoBack.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
