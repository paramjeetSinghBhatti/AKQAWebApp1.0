using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AKQAWebApp.Startup))]
namespace AKQAWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
