using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DungeonResource.Web.Startup))]
namespace DungeonResource.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
