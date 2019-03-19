using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogWebApplication.Startup))]
namespace BlogWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
