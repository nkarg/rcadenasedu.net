using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(miMVC.Startup))]
namespace miMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
