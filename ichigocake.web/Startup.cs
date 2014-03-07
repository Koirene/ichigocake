using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ichigocake.web.Startup))]
namespace ichigocake.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
