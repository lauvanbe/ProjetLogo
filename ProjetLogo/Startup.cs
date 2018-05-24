using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetLogo.Startup))]
namespace ProjetLogo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
