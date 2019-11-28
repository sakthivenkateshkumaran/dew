using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pasp.Startup))]
namespace pasp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
