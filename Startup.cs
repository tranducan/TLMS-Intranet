using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TLMS_Intranet.Startup))]
namespace TLMS_Intranet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
