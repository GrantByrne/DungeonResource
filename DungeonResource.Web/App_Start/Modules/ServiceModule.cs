using DungeonResource.Components.Service;
using DungeonResource.Components.Service.Abstract;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DungeonResource.Web.App_Start.Modules
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            // Services
            Bind<IUserService>().To<UserService>();
            Bind<ISpellService>().To<SpellService>();
            Bind<IBookService>().To<BookService>();
        }
    }
}