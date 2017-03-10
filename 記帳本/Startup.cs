using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(記帳本.Startup))]
namespace 記帳本
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
