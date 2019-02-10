using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrackMyMoney.Startup))]
namespace TrackMyMoney
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
