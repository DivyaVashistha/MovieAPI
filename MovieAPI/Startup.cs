using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieAPI.Startup))]
namespace MovieAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
