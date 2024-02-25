using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Service;

namespace Application
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddScoped<CounterService>();
        }
    }
}