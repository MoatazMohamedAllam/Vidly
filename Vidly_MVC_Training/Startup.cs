using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly_MVC_Training.Startup))]
namespace Vidly_MVC_Training
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
