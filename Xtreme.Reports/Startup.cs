using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Xtreme.Reports.Startup))]
namespace Xtreme.Reports
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
