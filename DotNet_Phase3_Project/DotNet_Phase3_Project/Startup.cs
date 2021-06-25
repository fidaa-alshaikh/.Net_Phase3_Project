using DotNet_Phase3_Project.Models;
using DotNet_Phase3_Project.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(DotNet_Phase3_Project.Startup))]

namespace DotNet_Phase3_Project
{
    public class Startup
    {

        public   void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IRepo<Product>, MockProductRepo > ();

        }
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
        }
    }
}
