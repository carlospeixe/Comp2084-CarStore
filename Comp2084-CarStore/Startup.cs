using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Comp2084_CarStore.Startup))]
namespace Comp2084_CarStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
