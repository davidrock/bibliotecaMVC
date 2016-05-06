using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrabalhoBiblioteca.Startup))]
namespace TrabalhoBiblioteca
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
