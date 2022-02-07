using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ontap.Startup))]
namespace Ontap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
