using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using DndDev.Service;
using DndDev.Service.Abstract;

namespace DndDev.Web.App_Start.Modules
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