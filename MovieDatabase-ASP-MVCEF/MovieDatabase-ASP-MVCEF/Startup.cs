using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieDatabase_ASP_MVCEF.Startup))]
namespace MovieDatabase_ASP_MVCEF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
