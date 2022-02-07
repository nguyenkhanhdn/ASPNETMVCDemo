using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecDemo.Startup))]
namespace SecDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
