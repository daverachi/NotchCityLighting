using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NotchCityLighting.Web.Startup))]
namespace NotchCityLighting.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
