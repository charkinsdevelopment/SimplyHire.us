using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimplyHireWeb.Startup))]
namespace SimplyHireWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
