using Microsoft.AspNetCore.Mvc;

namespace TheLoanProviders.Controllers
{
    public class HomeController : Controller
    {
    
        public IActionResult Index()
        {
        
            return View("Index");
        }
    
        public IActionResult ClassInputForm()
        {
            
            ViewBag.Message = "The data is being recieved";
            return View("ClassInputForm");
        }
    }
}
