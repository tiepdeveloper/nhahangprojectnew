using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sosproject.Startup))]
namespace sosproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
