using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Mvc;
using Raven.Client;
using Raven.Client.Document;
using Raven.Client.Embedded;

namespace MemeBattle.Controllers
{
    public abstract class RavenApiController : ApiController
    {
        public IDocumentStore RavenDb
        {
            get { return LazyDocStore.Value; }
        }

        private static readonly Lazy<IDocumentStore> LazyDocStore = new Lazy<IDocumentStore>(() =>
        {
            var docStore = new EmbeddableDocumentStore()
            {
                DataDirectory = "~/App_Data/Raven",
                UseEmbeddedHttpServer = true
            };

            docStore.Initialize();
            return docStore;
        });

    }
}
