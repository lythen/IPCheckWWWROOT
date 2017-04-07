using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lythen.Web.Startup))]
namespace Lythen.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
