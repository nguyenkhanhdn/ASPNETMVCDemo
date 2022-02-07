using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AjaxDemo.Startup))]
namespace AjaxDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
