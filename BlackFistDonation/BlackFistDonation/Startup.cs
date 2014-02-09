using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlackFistDonation.Startup))]
namespace BlackFistDonation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
