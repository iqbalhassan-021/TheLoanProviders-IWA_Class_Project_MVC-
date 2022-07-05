using Microsoft.AspNetCore.Mvc;

namespace TheLoanProviders.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {


            return View();
        }
        public ActionResult loginpage()
        {


            return View();
        }
        public ActionResult signuppage()
        {


            return View();
        }
        public ActionResult dashboard()
        {


            return View();
        }
        public IActionResult login_Det(string uname, string upass)
        {
            if(uname == "hassan47" && upass == "saan47")
            {
                return View("dashboard");
            }

            else
            {
                ViewBag.Message1 = "you have enterd an invalid username or password";
             
                return View("loginpage");
              
            }
        }

        public ActionResult ClassInputForm(string fname, string lname, string email, string Phone)
        {
            if (fname != null && lname != null)
            {
                ViewBag.Message = "The data is being recieved";
            }

            return View("ClassInputForm");
      
        }

        public ActionResult UserDataForm()
        {


            return View();
        }
        public IActionResult userinfo(string applicantname, string applicantphone)
        {
         if(applicantname == null &&  applicantphone == null)
            {
     
                return View("UserDataForm");
                ViewBag.Message = "Please fill all the above given inputs";
            }
            else
            {
                return View("Index");
            }
        }

        public IActionResult singupuser(string newuserpass, string newusername,string securitypin)
        {
            if (newuserpass == null && newusername == null && securitypin !="hassan47")
            {

                return View("signuppage");
               
            }
            else
            {
                return View("loginpage");
            }
        }

    }
}
