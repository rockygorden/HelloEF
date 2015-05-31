using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloEF.Web.Startup))]
namespace HelloEF.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
