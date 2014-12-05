using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using www.CodyBerndt.com.Models.Contact;

namespace www.CodyBerndt.com.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}