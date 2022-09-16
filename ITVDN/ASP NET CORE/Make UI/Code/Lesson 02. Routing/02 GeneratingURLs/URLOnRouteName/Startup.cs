using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace URLOnRouteName
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints => 
            {
                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{controller=home}/{action=index}"
                    );

                endpoints.MapControllerRoute(
                    name: "ViewProduct",
                    pattern: "data/{controller=product}/{action=details}/{id}"
                    );
            });
        }
    }
}
