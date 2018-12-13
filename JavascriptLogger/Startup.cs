using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JavascriptLogger.Startup))]
namespace JavascriptLogger
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
