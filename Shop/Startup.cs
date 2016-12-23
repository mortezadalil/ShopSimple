using Microsoft.Owin;
using Owin;
using Shop;

[assembly: OwinStartup(typeof(Startup))]

namespace Shop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
