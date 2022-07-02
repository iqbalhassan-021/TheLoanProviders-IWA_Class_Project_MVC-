using Microsoft.AspNetCore.Mvc;

namespace TheLoanProviders.Controllers
{
    public class HomeController : Controller
    {
    
        public IActionResult Index(string fname, string lname, string email, string Phone)
        {

            if(fname != null && lname != null)
            {
                ViewBag.Message = "The data is being recieved";
            }
         
            return View("ClassInputForm");

        }
    
        public IActionResult ClassInputForm()
        {
            return View("Index");
        }

      
    }
}
