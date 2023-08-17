using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Causes.Startup))]
namespace Causes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
