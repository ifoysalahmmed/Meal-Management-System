using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Meal_Management_System.Startup))]
namespace Meal_Management_System
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
