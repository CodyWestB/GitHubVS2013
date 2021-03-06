﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using www.CodyBerndt.com.Models.Home;

namespace www.CodyBerndt.com.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new HomeModels
            {
                Controller = RouteData.Values["controller"],
                Action = RouteData.Values["action"],
                Id = RouteData.Values["id"]
            };

            // builds route structure
            //var controller = RouteData.Values["controller"];
            //var action = RouteData.Values["action"];
            //var id = RouteData.Values["id"];
            //var message = String.Format("{0}::{1} {2}", controller, action, id);
            //ViewBag.Message = message;

            return View(model);
        }

        /*public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }*/

        /*public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }*/
    }
}
