using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Variables
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
                // Запрос, полученный приложением, будет сопоставляется с каждым маршрутом, определенным при настройке UseEndpoints middleware
                // (сравнение происходит в порядке добавления маршрутов)
                // Как только будет найден подходящий маршрут, начнется обработка запроса контроллером.
                // Более специфические маршруты должны находиться в начале списка маршрутов

                // В этом примере данный маршрут позволяет обработать запрос home/calc/10/20
                // при этом два последних сегмента будут доступны в методе действия calc как параметры с именами x и y
                endpoints.MapControllerRoute(
                    name: "TwoParameterRoute",
                    pattern: "{controller}/{action}/{x}/{y}"
                    );

                // Маршрут по умолчанию с значениями по умолчанию.
                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{controller=home}/{action=index}"
                    );
            });
        }
    }
}