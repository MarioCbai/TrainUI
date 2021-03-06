using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TeachingCultureUI.Controllers;

namespace TeachingCultureUI
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
            services.AddSession();
            services.AddControllersWithViews();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(opt => { opt.LoginPath = new PathString("/Home/Index/"); });
            string str = Configuration["ConnectionString:locastr"];
            AuthorityMController.Str = str;
            EssentialDataController.Str = str;
            FinancesController.Str = str;
            IndentMController.Str = str;
            InstitutionMController.Str = str;
            StudentMController.Str = str;
            TeacherMController.Str = str;
            TeachingMController.Str = str;
            

            //services.Add(new ServiceDescriptor(typeof(AuthorityMController), new AuthorityMController(Configuration["ConnectionString:locastr"])));

            //services.Add(configuration["ConnectionStrings:locastr"]);

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
            }
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=AuthorityM}/{action=Register}/{id?}");
            });
        }
    }
}
