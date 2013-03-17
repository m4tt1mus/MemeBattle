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
            var docStore = new EmbeddableDocumentStore()
            {
                DataDirectory = "~/App_Data/Raven/"
            };

            docStore.Initialize();
            RavenIndexes.CreateIndexes(docStore);
            return docStore;
        }
    }

    public static class RavenIndexes
    {
        public static void CreateIndexes(IDocumentStore docStore)
        {
            docStore.Conventions.FindIdentityProperty = prop =>
            {
                if (prop.DeclaringType == typeof(Meme))
                    return prop.Name == "Name";

                // Default
                return prop.Name == "Id";
            };
        }
    }
}