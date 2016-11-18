using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MiAdminPub.Startup))]
namespace MiAdminPub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
