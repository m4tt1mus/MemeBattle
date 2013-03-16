using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemeBattle.Controllers
{
    public class MemeController : Controller
    {
        //
        // GET: /Meme/
        // List the existing Memes
        public ActionResult Index()
        {

            return View();
        }

        //
        // GET: /Meme/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Meme/Create
        public ActionResult Create()
        {
            return View();
        }

        // Resources
        // http://www.hanselman.com/blog/ABackToBasicsCaseStudyImplementingHTTPFileUploadWithASPNETMVCIncludingTestsAndMocks.aspx
        // http://haacked.com/archive/2010/07/16/uploading-files-with-aspnetmvc.aspx
        // POST: /Meme/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Meme/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Meme/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Meme/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Meme/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
