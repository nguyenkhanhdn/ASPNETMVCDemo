using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WADReview.Startup))]
namespace WADReview
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
