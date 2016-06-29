using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClassTest.Startup))]
namespace ClassTest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
