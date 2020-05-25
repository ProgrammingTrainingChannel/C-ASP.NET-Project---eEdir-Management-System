using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eEdir_Management_System.Startup))]
namespace eEdir_Management_System
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
