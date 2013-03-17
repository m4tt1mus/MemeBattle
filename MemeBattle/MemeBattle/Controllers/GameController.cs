using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemeBattle.Controllers
{
    public class GameController : Controller
    {
        public ActionResult Battle()
        {
            return View();
        }
    }
}
