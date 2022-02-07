using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFDemo.Startup))]
namespace EFDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
