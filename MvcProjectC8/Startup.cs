using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcProjectC8.Startup))]
namespace MvcProjectC8
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
