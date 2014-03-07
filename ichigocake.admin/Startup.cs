using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ichigocake.admin.Startup))]
namespace ichigocake.admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
