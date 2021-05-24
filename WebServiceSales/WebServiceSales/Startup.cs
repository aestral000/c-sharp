using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebServiceSales.Data;
using WebServiceSales.Views.Sellers;
using WebServiceSales.Models.Services;
using System.Globalization;
using Microsoft.AspNetCore.Localization;

namespace WebServiceSales {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.Configure<CookiePolicyOptions>(options => {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<WebServiceSalesContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("WebServiceSalesContext")));

            services.AddScoped<SeedingService>();
            services.AddScoped<SellerService>();
            services.AddScoped<DepartmentService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, SeedingService seeding) {
            CultureInfo cultureInfoUSA = new CultureInfo("en-US");
            RequestLocalizationOptions requestLocalizationOptions = new RequestLocalizationOptions {
                DefaultRequestCulture = new RequestCulture(cultureInfoUSA),
                SupportedCultures = new List<CultureInfo> { cultureInfoUSA },
                SupportedUICultures = new List<CultureInfo> { cultureInfoUSA }

            };

            app.UseRequestLocalization(requestLocalizationOptions);

            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
                //seeding.Seed(); Desabilitando o seed, pois o sql server não libera a inserção direta de foreign key
                //INSERT_IDENTITY sem estar setado para ON
            }
            else {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
