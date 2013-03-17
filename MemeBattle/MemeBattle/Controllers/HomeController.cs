using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Raven.Client;
using Raven.Client.Embedded;

namespace MemeBattle.Controllers
{
    public class HomeController : Controller
    {

        private IDocumentSession session;
        public HomeController(IDocumentSession session)
        {
            this.session = session;
        }

        public RedirectToRouteResult Index()
        {
            return RedirectToAction("ChooseMeme", "Home");
        }

        // Choose your meme to use in battle
        public ActionResult ChooseMeme()
        {


            return View();
        }


    }
}
