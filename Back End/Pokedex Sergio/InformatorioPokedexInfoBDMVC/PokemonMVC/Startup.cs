using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PokemonMVC.Startup))]
namespace PokemonMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
