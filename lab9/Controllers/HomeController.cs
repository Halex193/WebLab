﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab9.Controllers
{
    // [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["UserName"] == null)
            {
                return RedirectToRoute("Default", new { controller = "Login", action = "Index"});
            }
            return View();
        }

        public ActionResult Add()
        {
            if (Session["UserName"] == null)
            {
                return RedirectToRoute("Default", new { controller = "Login", action = "Index"});
            }
            return View();
        }

        public ActionResult Delete()
        {
            if (Session["UserName"] == null)
            {
                return RedirectToRoute("Default", new { controller = "Login", action = "Index"});
            }
            return View();
        }

        public ActionResult Update()
        {
            if (Session["UserName"] == null)
            {
                return RedirectToRoute("Default", new { controller = "Login", action = "Index"});
            }
            return View();
        }
        
        public ActionResult Read()
        {
            if (Session["UserName"] == null)
            {
                return RedirectToRoute("Default", new { controller = "Login", action = "Index"});
            }
            return View();
        }
    }
}