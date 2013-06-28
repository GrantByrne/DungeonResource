using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using DndDev.Repository;
using DndDev.Repository.Abstract;

namespace DndDev.Web.App_Start.Modules
{
    public class RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ISpellRepository>().To<SpellRepository>();
            Bind<IUserRepository>().To<UserRepository>();
            Bind<IBookRepository>().To<BookRepository>();
        }
    }
}