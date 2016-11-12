using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecretPet.Startup))]
namespace SecretPet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
