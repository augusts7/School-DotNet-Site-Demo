using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(demo_school_app.Startup))]
namespace demo_school_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            
        }

    }
}
