using System.Web.Mvc;
using Raven.Client;

namespace MemeBattle.Controllers
{
    public class HomeController : Controller
    {
        // Choose your meme to use in battle
        public ActionResult AllMemes()
        {
            return View();
        }


    }
}
