using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sandbox.Web.Controllers
{
    public class HelloController : Controller
    {
        public ActionResult Index()
        {
            return Content("Bye!");
        }
    }
}