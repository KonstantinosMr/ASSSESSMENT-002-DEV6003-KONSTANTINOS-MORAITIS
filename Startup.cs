using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASSSESSMENT_002_DEV6003_KONSTANTINOS_MORAITIS.Startup))]
namespace ASSSESSMENT_002_DEV6003_KONSTANTINOS_MORAITIS
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
