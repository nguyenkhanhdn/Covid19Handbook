using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Covid19Handbook.Startup))]
namespace Covid19Handbook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
