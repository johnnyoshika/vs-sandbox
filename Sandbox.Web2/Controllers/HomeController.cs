﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sandbox.Web2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var greeting = "Hello :-)";
            return Content(greeting);
        }
    }
}