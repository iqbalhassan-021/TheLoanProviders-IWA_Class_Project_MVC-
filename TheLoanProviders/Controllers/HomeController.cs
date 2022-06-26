using Microsoft.AspNetCore.Mvc;

namespace TheLoanProviders.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
