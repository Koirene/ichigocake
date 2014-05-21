using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ichigocake.chef.Startup))]
namespace ichigocake.chef
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
