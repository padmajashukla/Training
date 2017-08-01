using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VIPA.Startup))]
namespace VIPA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
