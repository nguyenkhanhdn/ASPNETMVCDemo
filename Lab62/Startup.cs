using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab62.Startup))]
namespace Lab62
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
