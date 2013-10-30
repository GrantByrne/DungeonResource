using Ninject.Modules;
using SimpleCrypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DungeonResource.Web.App_Start.Modules
{
    public class SimpleCryptoModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICryptoService>().To<PBKDF2>();
        }
    }
}