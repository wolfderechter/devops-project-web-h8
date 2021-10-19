using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;

namespace EuropArt.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();
            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddRazorPages();
            
        }

        private RequestLocalizationOptions GetLocalizationOptions()
        {
            var cultures = Configuration.GetSection("Cultures").GetChildren().ToDictionary(x => x.Key, x => x.Value);
            var supportedCultures = cultures.Keys.ToArray();
            var localizationOptions = new RequestLocalizationOptions().AddSupportedCultures(supportedCultures).AddSupportedUICultures(supportedCultures);
            return localizationOptions;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            //app.UseRequestLocalization(GetLocalizationOptions());
            app.UseRequestLocalization(new RequestLocalizationOptions()
                .AddSupportedCultures(new[] { "en-US", "es-CL" })
                .AddSupportedUICultures(new[] { "en-US", "es-CL" }));

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapRazorPages();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}