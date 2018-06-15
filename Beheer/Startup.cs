using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Beheer.Startup))]
namespace Beheer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
