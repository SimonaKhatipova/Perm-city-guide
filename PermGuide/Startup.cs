using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PermGuide.Startup))]
namespace PermGuide
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
