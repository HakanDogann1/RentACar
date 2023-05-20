using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RentACar.BusinessLayer.Abstract;
using RentACar.BusinessLayer.Concrete;
using RentACar.DataAccessLayer.Abstract;
using RentACar.DataAccessLayer.Concrete;
using RentACar.DataAccessLayer.EntityFramework;
using RentACar.EntityLayer.Concrete;
using RentACar.PresentetionLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.PresentetionLayer
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
            services.AddDbContext<Context>();

            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>().AddErrorDescriber<CustomeIdentityValidator>();
            services.AddScoped<IAboutUsDal, EfAboutUsDal>();
            services.AddScoped<IAboutUsService,AboutUsManager>();

            services.AddScoped<IBlogDal,EfBlogDal>();
            services.AddScoped<IBlogService,BlogManager>();

            services.AddScoped<IBlogCommentDal,EfBlogCommentDal>();
            services.AddScoped<IBlogCommentService,BlogCommentManager>();

            services.AddScoped<IContactMeDal,EfContactMeDal>();
            services.AddScoped<IContactMeService,ContactMeManager>();

            services.AddScoped<IHeaderDal,EfHeaderDal>();
            services.AddScoped<IHeaderService,HeaderManager>();

            services.AddScoped<IReferenceService,ReferenceManager>();
            services.AddScoped<IReferenceDal,EfReferenceDal>();

            services.AddScoped<IReserveDal,EfReserveDal>();
            services.AddScoped<IReserveService,ReserveManager>();

            services.AddScoped<IReserveServiceDal,EfReserveServiceDal>();
            services.AddScoped<IReserveServiceService,ReserveServiceManager>();

            services.AddScoped<IServiceService,ServiceManager>();
            services.AddScoped<IServiceDal,EfServiceDal>();

            services.AddScoped<IStatisticDal,EfStatisticDal>();
            services.AddScoped<IStatisticService,StatisticManager>();

            services.AddScoped<ITagCloudDal,EfTagCloudDal>();
            services.AddScoped<ITagCloudService,TagCloudManager>();

            services.AddScoped<IReserveDal, EfReserveDal>();
            services.AddScoped<IReserveService, ReserveManager>();

            services.AddScoped<ICarBrandService,CarBrandManager>();
            services.AddScoped<ICarBrandDal, EfCarBrandDal>();

            services.AddScoped<ICarDal, EfCarDal>();
            services.AddScoped<ICarService,CarManager>();

            services.AddScoped<ICarTransmissionDal, EfCarTransmissionDal>();
            services.AddScoped<ICarTransmissionService, CarTransmissionManager>();

            services.AddScoped<ICarRegisterDal, EfCarRegisterDal>();
            services.AddScoped<ICarRegisterService, CarRegisterManager>();
            services.AddControllersWithViews();
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
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
