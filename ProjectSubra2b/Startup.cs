using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectSubra2b.Startup))]
namespace ProjectSubra2b
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
