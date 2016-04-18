using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SportsStrore.SampleProject.Startup))]
namespace SportsStrore.SampleProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
