using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EscuelaMVC.Startup))]
namespace EscuelaMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
