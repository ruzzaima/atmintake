using Microsoft.Owin;
using Owin;
using SevenH.MMCSB.Atm.Web;

[assembly: OwinStartup(typeof(Startup))]
namespace SevenH.MMCSB.Atm.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
