using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_eway.Startup))]
namespace _eway
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
