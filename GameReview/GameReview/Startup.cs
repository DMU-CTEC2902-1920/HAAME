using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GameReview.Startup))]
namespace GameReview
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
