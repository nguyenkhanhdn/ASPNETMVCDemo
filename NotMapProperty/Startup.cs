using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NotMapProperty.Startup))]
namespace NotMapProperty
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
