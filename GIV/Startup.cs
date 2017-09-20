using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GIV.Startup))]
namespace GIV
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
