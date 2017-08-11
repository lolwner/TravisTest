using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TravisTest.Startup))]
namespace TravisTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
