using Ninject.Activation;
using Ninject.Modules;
using Raven.Client;
using Raven.Client.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using Ninject.Web.Common;

namespace DungeonResource.Web.App_Start.Modules
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
            DocumentStore ds = new DocumentStore { Url = "http://127.0.0.1:8080/" };
            var something = ds.Url;
            ds.Initialize();
            return ds;
        }
    }
}