using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HAAME.Startup))]
namespace HAAME
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
