using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

using Landpag2.Data;
using Radzen;
namespace Landpag2
{
    public partial class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        partial void OnConfigureServices(IServiceCollection services);

        partial void OnConfiguringServices(IServiceCollection services);

        public void ConfigureServices(IServiceCollection services)
        {
            OnConfiguringServices(services);

            services.AddHttpContextAccessor();
            services.AddScoped<HttpClient>(serviceProvider =>
            {

              var uriHelper = serviceProvider.GetRequiredService<NavigationManager>();

              return new HttpClient
              {
                BaseAddress = new Uri(uriHelper.BaseUri)
              };
            });

            services.AddHttpClient();
            services.AddScoped<AuthenticationconnService>();

            services.AddDbContext<Landpag2.Data.AuthenticationconnContext>(options =>
            {
              options.UseSqlServer(Configuration.GetConnectionString("authenticationconnConnection"));
            });

            services.AddRazorPages();
            services.AddServerSideBlazor().AddHubOptions(o =>
            {
                o.MaximumReceiveMessageSize = 10 * 1024 * 1024;
            });

            services.AddScoped<DialogService>();
            services.AddScoped<NotificationService>();
            services.AddScoped<TooltipService>();
            services.AddScoped<ContextMenuService>();
            services.AddLocalization();

            var supportedCultures = new[]
            {
                new System.Globalization.CultureInfo("ar"),
                new System.Globalization.CultureInfo("en"),
            };

            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("ar");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });


            OnConfigureServices(services);
        }

        partial void OnConfigure(IApplicationBuilder app, IWebHostEnvironment env);
        partial void OnConfiguring(IApplicationBuilder app, IWebHostEnvironment env);

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            OnConfiguring(app, env);

            var supportedCultures = new[]
            {
                new System.Globalization.CultureInfo("ar"),
                new System.Globalization.CultureInfo("en"),
            };

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("ar"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            });

            if (env.IsDevelopment())
            {
                Microsoft.IdentityModel.Logging.IdentityModelEventSource.ShowPII = true;
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.Use((ctx, next) =>
                {
                    return next();
                });
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "default",
                  pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });

            OnConfigure(app, env);
        }
    }


}
