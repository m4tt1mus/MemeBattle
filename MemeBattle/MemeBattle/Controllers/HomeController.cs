using System.Web.Mvc;
using Raven.Client;

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
            return RedirectToAction("AllMemes", "Home");
        }

        // Choose your meme to use in battle
        public ActionResult AllMemes()
        {
            
            return View();
        }


    }
}
