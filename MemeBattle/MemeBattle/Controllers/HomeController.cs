using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Raven.Client.Embedded;

namespace MemeBattle.Controllers
{
    public class HomeController : Controller
    {
        private EmbeddableDocumentStore repo;

        public HomeController()
        {
            repo = new EmbeddableDocumentStore
            {
                DataDirectory = "Data"
            };
        }

        public RedirectToRouteResult Index()
        {
            return RedirectToAction("ChooseMeme", "Home");
        }

        // Choose your meme to use in battle
        public ActionResult ChooseMeme()
        {
            throw new NotImplementedException();
        }


    }
}
