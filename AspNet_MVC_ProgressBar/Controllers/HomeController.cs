using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace AspNet_MVC_ProgressBar.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<SelectListItem> dropdownItem = new List<SelectListItem>
            {
                new SelectListItem { Text = "40", Value = "40" },
                new SelectListItem { Text = "50", Value = "50" },
                new SelectListItem { Text = "60", Value = "60" },
                new SelectListItem { Text = "70", Value = "70" },
                new SelectListItem { Text = "80", Value = "80" },
                new SelectListItem { Text = "90", Value = "90" },
                new SelectListItem { Text = "100", Value = "100" }
            };
            ViewBag.totalRecords = new SelectList(dropdownItem, "Value", "Text", "40");

            return View();
        }

        [HttpPost]
        public ActionResult ProsesData(string id)
        {
            //pause for 2000 milli second (konon2 tgh run sql)
            Thread.Sleep(2000);
            SelectListItem retVal = new SelectListItem { Text = "6", Value = "10" };
            return Json(retVal, JsonRequestBehavior.AllowGet);
        }
    }
}