using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Statemanagement.Startup))]
namespace Statemanagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
