using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Resolutions.Startup))]
namespace Resolutions
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
