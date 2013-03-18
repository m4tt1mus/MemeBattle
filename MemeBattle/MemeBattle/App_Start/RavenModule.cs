using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MemeBattle.Models;
using Ninject;
using Ninject.Activation;
using Ninject.Modules;
using Ninject.Web.Common;
using Raven.Client;
using Raven.Client.Document;
using Raven.Client.Embedded;

namespace MemeBattle.App_Start
{
    public class RavenModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDocumentStore>()
                .ToMethod(InitDocStore)
                .InSingletonScope();

            Bind<IDocumentSession>()
                .ToMethod(c => c.Kernel.Get<IDocumentStore>().OpenSession())
                .InRequestScope();
        }

        private IDocumentStore InitDocStore(IContext context)
        {
            var docStore = new EmbeddableDocumentStore() { };
            docStore.Initialize();
            return docStore;
        }
    }
}