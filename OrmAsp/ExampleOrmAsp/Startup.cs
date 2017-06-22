using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExampleOrmAsp.Startup))]
namespace ExampleOrmAsp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
