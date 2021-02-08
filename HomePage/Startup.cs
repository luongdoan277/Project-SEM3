using HomePage.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomePage
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
            services.AddControllersWithViews();
            services.AddDbContext<StoreDbContext>(
              opts =>
              {
                  opts.UseSqlServer
                  (Configuration["ConnectionStrings:ABCDMall"]);
              }
              );
            services.AddScoped<IStoreRepository, EFStoreRepository>();

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
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("Home",
                   "/",
                   new { Controller = "Home", action = "Index" });

                endpoints.MapControllerRoute("Shops",
                   "Shops",
                   new { Controller = "Shops", action = "Index" });

                endpoints.MapControllerRoute("ShopsDetails",
                   "ShopsDetails/ID={ShopID}",
                   new { Controller = "Shops", action = "Detail" });


                endpoints.MapControllerRoute("Movie",
                   "Movie",
                   new { Controller = "Movie", action = "Index" });

                endpoints.MapControllerRoute("MovieDetail",
                   "MovieDetail/ID={MovieID}",
                   new { Controller = "Movie", action = "Detail" });

                //endpoints.MapControllerRoute("MovieDetail",
                //   "MovieDetail",
                //   new { Controller = "Movie", action = "Detail" });

                endpoints.MapControllerRoute("ContactUs",
                   "ContactUs",
                   new { Controller = "ContactUs", action = "Index" });

                endpoints.MapControllerRoute("FeedBack",
                  "FeedBack",
                  new { Controller = "FeedBack", action = "Index" });

                endpoints.MapControllerRoute("CinemaSeat",
                  "CinemaSeat/CinemaHallID={CinemaHallID}",
                  new { Controller = "CinemaSeat", action = "Index" });

                endpoints.MapControllerRoute("PaymentTicket",
                  "PaymentTicket",
                  new { Controller = "PaymentTicket", action = "Index" });
                
            });
        }
    }
}
