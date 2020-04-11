using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Loop.Web.Startup))]
namespace Loop.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
