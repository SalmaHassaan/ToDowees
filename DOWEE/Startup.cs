using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DOWEE.Startup))]
namespace DOWEE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
