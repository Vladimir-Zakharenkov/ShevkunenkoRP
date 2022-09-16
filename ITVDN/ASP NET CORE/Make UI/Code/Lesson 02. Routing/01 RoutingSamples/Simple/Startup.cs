using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Simple
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
                // Определение route template
                endpoints.MapControllerRoute(
                    name: "Default",                    // название 
                    pattern: "{controller}/{action}");  // route template для запросов состоящих из двух сегментов

                //  {controller} и {action} - зарезервированные названия параметров маршрута
            });
        }
    }
}
