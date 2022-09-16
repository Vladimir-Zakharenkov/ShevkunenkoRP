using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Literal
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
                    /* 
                    * в маршруте присутствует литерал api все запросы должны содержать такой сегмент в URL.
                    * в данном примере будет работать запрос по адресу /api/values/list                         
                    */
                    pattern: "api/{controller}/{action}"
                    );
            });
        }
    }
}