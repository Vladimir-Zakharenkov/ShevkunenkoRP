using ActionFilterSample.Infrastructure;
using DITypeFilterSample.Services;
using GlobalFilters.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ActionFilterSample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<Logger>();
            services.AddSingleton<ExceptionLogingAttribute>();

            // Регистрация глобальных фильтров. Эти фильтры будут срабатывать для каждого контроллера и метода действия в приложении.
            services.AddMvc().AddMvcOptions(
                options => {
                    options.Filters.Add<ProfileAttribute>(); // без внедрения зависимострей
                    options.Filters.AddService<ExceptionLogingAttribute>(); // с внедрением зависимостей
                });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseEndpoints(endpoints => {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
