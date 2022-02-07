using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab3Demo.Startup))]
namespace Lab3Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
