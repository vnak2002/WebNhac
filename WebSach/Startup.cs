using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebSach.Startup))]
namespace WebSach
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
