using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HAAMEGameReview.Startup))]
namespace HAAMEGameReview
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
