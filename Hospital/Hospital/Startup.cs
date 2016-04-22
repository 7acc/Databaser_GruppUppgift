using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hospital.Startup))]
namespace Hospital
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
