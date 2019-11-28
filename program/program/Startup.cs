using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(program.Startup))]
namespace program
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
