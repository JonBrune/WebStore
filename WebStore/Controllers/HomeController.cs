﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStore.DAL;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return RedirectToAction("Index", "Products");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}