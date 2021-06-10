using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PopisStudenata.Startup))]
namespace PopisStudenata
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
