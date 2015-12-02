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

        public ActionResult HandShake()
        {
            return Content("handshake");
        }

        public ActionResult Bow()
        {
            return Content("bow");
        }
    }
}