using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace URLOnActionName
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
            app.UseEndpoints(
                    endpoints =>
                    {
                        endpoints.MapControllerRoute(
                            name: "Default",
                            pattern: "{controller=home}/{action=index}/{id?}");
                    }
                );
        }
    }
}
