using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DHospital.Startup))]
namespace DHospital
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
