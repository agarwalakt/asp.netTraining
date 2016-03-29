using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrainingTest.Startup))]
namespace TrainingTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
