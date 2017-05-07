using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThinkDigital.Startup))]
namespace ThinkDigital
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
