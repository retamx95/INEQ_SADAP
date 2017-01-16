using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(INEQ_SADAP.Startup))]
namespace INEQ_SADAP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
