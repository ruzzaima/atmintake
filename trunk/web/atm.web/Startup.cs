using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SevenH.MMCSB.Atm.Web.Startup))]
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
