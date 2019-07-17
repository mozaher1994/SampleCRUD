using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleCRUD.Startup))]
namespace SampleCRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
