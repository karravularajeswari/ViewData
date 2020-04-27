using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPractice.Controllers
{
    public class ViewDataExampleController : Controller
    {
        // GET: ViewDataExample
        public ActionResult Index()
        {
            ViewData.Add("uname", "Raje");
            /*ViewData["Uname"] = "Prem";*/
            ViewData["Categories"] = new List<String>()
            {
                "Electronics",
                "shoes"
            };
            return View();
        }
    }
}