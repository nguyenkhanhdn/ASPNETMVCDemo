using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Secdemo2.Startup))]
namespace Secdemo2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
