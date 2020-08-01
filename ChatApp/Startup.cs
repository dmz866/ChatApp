using Microsoft.Owin;
using Microsoft.Extensions.DependencyInjection;
using ChatApp.Infrastructure.Services;
using ChatApp.Core.Interfaces;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChatApp.Startup))]
namespace ChatApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IUtilsService, UtilsService>();
        }
    }
}