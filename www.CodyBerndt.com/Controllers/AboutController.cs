using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using www.CodyBerndt.com.Models.About;

namespace www.CodyBerndt.com.Controllers
{
    public class AboutController : Controller
    {
        public ActionResult About()
        {
            var model = new AboutModels() {};

            return View();
        }
    }
}
