using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecurityDemo.Startup))]
namespace SecurityDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
