using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoConsolaMvc.Startup))]
namespace ProyectoConsolaMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
