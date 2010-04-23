using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrimaryEducationSystem.Families.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           return View();
           //return Redirect(this.Url.ToString() + "//" + "Services/PESService");
        }



        public ActionResult About()
        {
            return View();
        }
    }
}
