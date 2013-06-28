using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using Ninject.Activation;
using Raven.Client;
using Raven.Client.Document;
using Ninject;
using Ninject.Web.Common;
using DndDev.Service;
using SimpleCrypto;
using DndDev.Repository;
using DndDev.Repository.Abstract;
using Raven.Client.Indexes;

namespace DndDev.Web.App_Start.Modules
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
            DocumentStore ds = new DocumentStore { ConnectionStringName = "RavenHQ" };
            //RavenProfiler.InitializeFor(ds);
            // also good to setup the glimpse plugin here            
            ds.Initialize();
            AddIndex(ds);
            //RavenIndexes.CreateIndexes(ds);
            return ds;
        }

        private void AddIndex(IDocumentStore ds)
        {
            IndexCreation.CreateIndexes(typeof(DndDev.Repository.Index.Spell_GetAll).Assembly, ds);
        }
    }
}