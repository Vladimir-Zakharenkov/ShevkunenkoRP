using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace CatchAll
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

                // {*data} - catch all параметр, которых подходит в тех случаях, когда изначально не известно количество сегментов.
                // значение catch all параметра, будет соответствовать оставшейся строке URL адреса, которая не подошла под другие параметры
                // /home/values/10/20 в параметре {*data} будет находиться значение "10/20"
                endpoints.MapControllerRoute(
                    name: "CatchAll",
                    pattern: "{controller=home}/{action=values}/{*data}"
                    );
            });
        }
    }
}


