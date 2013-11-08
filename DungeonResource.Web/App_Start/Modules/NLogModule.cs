using DungeonResource.Components.Service;
using DungeonResource.Components.Service.Abstract;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DungeonResource.Web.App_Start.Modules
{
    public class NLogModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IClassLogger>().To<ClassLogger>().InSingletonScope();
            Bind<ILogService>().To<LogService>();
        }
    }
}