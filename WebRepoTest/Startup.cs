using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebRepoTest.Startup))]
namespace WebRepoTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
