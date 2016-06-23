using Microsoft.AspNetCore.Mvc;

namespace MakeItGo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
