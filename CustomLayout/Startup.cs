using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomLayout.Startup))]
namespace CustomLayout
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
