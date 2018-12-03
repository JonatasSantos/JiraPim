using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CamadaWeb.Startup))]
namespace CamadaWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
