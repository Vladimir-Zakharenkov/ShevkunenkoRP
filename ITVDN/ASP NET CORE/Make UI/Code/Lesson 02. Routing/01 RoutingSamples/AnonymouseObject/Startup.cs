using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.DependencyInjection;

namespace AnonymouseObject
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
            // Использование анонимного объекта для определения значений по умолчанию и ограничений.
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "Default",
                  pattern: "{controller}/{action}/{id?}",
                  // значения по умолчанию для параметров маршрута controller и action
                  defaults: new
                  {
                      controller = "home",
                      action = "index"
                  },
                  // ограничение для параметра маршрута id
                  constraints: new
                  {
                      id = new IntRouteConstraint()
                  });


                endpoints.MapControllerRoute(
                    name: "Documents",
                    pattern: "documents/{controller}/{number}/{action}",
                    defaults: new
                    {
                        controller = "invoices",
                        action = "view"
                    },
                    constraints: new
                    {
                        number = new RegexRouteConstraint("[a-z]{2}\\d{5}")
                    });

                // В большинстве случаев, для построения маршрута и установки значений по умолчанию с ограничениями,
                // используется синтаксис, показанный в предыдущих примерах.
                // Но для определения значений по умолчанию для параметров, которые не представлены сегментами
                // используется перегрузка метода MapControllerRoute требующая использования анонимных типов данных.
                endpoints.MapControllerRoute(
                    name: "Users",
                    pattern: "users/{name}",
                    defaults: new
                    {
                        controller = "users",
                        action = "index"
                    });
            });
        }
    }
}