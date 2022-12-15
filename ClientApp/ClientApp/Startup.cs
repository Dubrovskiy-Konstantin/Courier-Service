using ClientApp.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var corsBuilder = new CorsPolicyBuilder();
            corsBuilder.AllowAnyHeader();
            corsBuilder.AllowAnyMethod();
            corsBuilder.AllowAnyOrigin(); // For anyone access.
            //corsBuilder.WithOrigins("http://localhost:56573"); // for a specific url. Don't add a forward slash on the end!
            corsBuilder.WithOrigins("https://metanit.com/sharp/mvc5/4.1.php"); 
            //corsBuilder.AllowCredentials();

            services.AddCors(options =>
            {
                options.AddPolicy("SiteCorsPolicy", corsBuilder.Build());
            });

            services.AddControllersWithViews();
            services.AddSingleton<IConfiguration>(p => Configuration);
            services.Configure<PayPalCredentials>(Configuration.GetSection("PayPal"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
            //app.UseCors(MyAllowSpecificOrigins);
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseCors("SiteCorsPolicy");
            //app.UseCors(builder =>
            //{
            //    builder
            //    //.WithOrigins(@"https://metanit.com/sharp/mvc5/4.1.php",
            //    //                                          "http://www.contoso.com")
            //        .AllowAnyOrigin()
            //        .AllowAnyMethod()
            //        .AllowAnyHeader();
            //});


            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
