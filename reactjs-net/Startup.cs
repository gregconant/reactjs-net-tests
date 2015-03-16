using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(reactjs_net.Startup))]
namespace reactjs_net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
