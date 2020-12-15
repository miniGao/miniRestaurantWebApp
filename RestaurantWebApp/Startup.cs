using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RestaurantWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantWebApp
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
            services.AddDbContext<RestaurantDbContext>(options =>
                options.UseSqlServer(
                    Configuration["Data:RestaurantItems:ConnectionString"]
                    ));

            //services.AddTransient<IItemRepository, TestItemRepository>();
            services.AddTransient<IItemRepository, ItemRepository>();
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                // improve url
                routes.MapRoute(
                    name: "improvepageurl",
                    template: "Items/Page{itemPage}",
                    defaults: new { Controller = "Item", action = "Index" }
                    );

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Item}/{action=Index}/{id?}"
                    );
            });
            SampleData.PopulateSampleData(app);
        }
    }
}