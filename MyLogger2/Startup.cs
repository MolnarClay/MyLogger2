using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyLogger2.Startup))]
namespace MyLogger2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
