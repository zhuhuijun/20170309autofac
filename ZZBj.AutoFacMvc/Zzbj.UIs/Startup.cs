using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zzbj.UIs.Startup))]
namespace Zzbj.UIs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
