using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Assignment2_Html5_App.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
