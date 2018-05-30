using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KeyOnboardVer_3.Startup))]
namespace KeyOnboardVer_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
