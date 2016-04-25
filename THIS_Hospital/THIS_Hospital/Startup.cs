using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(THIS_Hospital.Startup))]
namespace THIS_Hospital
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
