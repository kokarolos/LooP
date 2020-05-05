using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Loop.Web.Startup))]
namespace Loop.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //if i exclude ConfigureAuth website will play but it will be full buggy

            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
