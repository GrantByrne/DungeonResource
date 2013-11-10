using DungeonResource.Components.Repository;
using DungeonResource.Components.Repository.Abstract;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DungeonResource.Web.App_Start.Modules
{
    public class RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserRepository>().To<UserRepository>();
            Bind(typeof(IGenericRepository<>)).To(typeof(GenericRepository<>));
        }
    }
}