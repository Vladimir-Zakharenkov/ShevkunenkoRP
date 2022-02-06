using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.WebEncoders;
using Site.Services;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using WebMarkupMin.AspNetCore5;

namespace Site
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<SiteContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("SiteDB"));
            });

            services.AddScoped<ISitemapModelRepository, SQLSitemapModelRepository>();

            services.AddScoped<IImageModelRepository, SQLImageModelRepository>();

            services.AddScoped<ICardModelRepository, SQLCardModelRepository>();

            services.AddScoped<IMovieModelRepository, SQLMovieModelRepository>();

            services.AddRazorPages();

            services.Configure<RouteOptions>(options =>
            {
                options.LowercaseUrls = true;
                options.LowercaseQueryStrings = true;
                options.AppendTrailingSlash = true;
            });

            services.Configure<WebEncoderOptions>(options =>
                options.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All));

            services.AddWebMarkupMin(
            options =>
            {
                options.AllowMinificationInDevelopmentEnvironment = true;
                options.AllowCompressionInDevelopmentEnvironment = true;
            })
            .AddHtmlMinification(
                options =>
                {
                    options.MinificationSettings.RemoveRedundantAttributes = true;
                    options.MinificationSettings.RemoveHttpProtocolFromAttributes = true;
                    options.MinificationSettings.RemoveHttpsProtocolFromAttributes = true;
                })
            .AddHttpCompression();

            services.AddHealthChecks();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseStatusCodePagesWithReExecute("/Error{0}");

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            //app.UseWebMarkupMin();
            app.UseWelcomePage("/Welcome");

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapHealthChecks("/healthz");
                endpoints.MapGet("/test", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}