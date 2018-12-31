using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iCare.Startup))]
namespace iCare
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
