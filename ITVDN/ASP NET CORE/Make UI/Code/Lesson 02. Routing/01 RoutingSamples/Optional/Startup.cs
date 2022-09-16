using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Optional
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                // {id?} - опциональный параметр. Если параметр есть - роутер получит его значение, если нет - проигнорирует.
                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{controller=products}/{action=details}/{id?}"
                    );
            });
        }
    }
}
