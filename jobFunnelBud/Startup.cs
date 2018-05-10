using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jobFunnelBud.Startup))]
namespace jobFunnelBud
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
