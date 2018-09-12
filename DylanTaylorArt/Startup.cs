using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DylanTaylorArt.Startup))]
namespace DylanTaylorArt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
