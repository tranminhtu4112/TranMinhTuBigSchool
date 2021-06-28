using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TranMinhTu_BIgSchool.Startup))]
namespace TranMinhTu_BIgSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
