using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Raven.Client;
using Raven.Client.Embedded;

namespace MemeBattle.Controllers
{
    public abstract class RavenController : Controller
    {
        public IDocumentStore RavenDb
        {
            get { return LazyDocStore.Value; }
        }

        private static readonly Lazy<IDocumentStore> LazyDocStore = new Lazy<IDocumentStore>(() =>
        {
            var docStore = new EmbeddableDocumentStore()
            {
                DataDirectory = "~/App_Data",
                UseEmbeddedHttpServer = true
            };

            docStore.Initialize();
            return docStore;
        });
    }
}