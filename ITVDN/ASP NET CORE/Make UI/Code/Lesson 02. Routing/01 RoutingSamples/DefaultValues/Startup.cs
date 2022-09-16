using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace DefaultValues
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
                    pattern: "{controller=Home}/{action=Index}");

                // controller=Home - опциональный параметр маршрута с значением по умолчанию 
                // если сегмент для параметра controller отсутствует, будет использоваться значение Home
            });
        }
    }
}

