using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CoreDemo.AutoMapper;
using CoreDemo.Data.Common;
using CoreDemo.Data.Entity;
using CoreDemo.Data.Repository;
using CoreDemo.Service.TestDetailService;
using CoreDemo.Service.TestService;
using CoreDemo.Service.TestTypeService;
using CoreDemo.Service.UserService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CoreDemo
{
    public class Startup
    {
        private MapperConfiguration _mapperConfiguration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            _mapperConfiguration = new MapperConfiguration(cfg => { cfg.AddProfile(new AutoMapperConfig()); });
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DeveloperTestContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DeveloperTestDatabase")));
            CommonHelper.ConnectionString = Configuration.GetConnectionString("DeveloperTestDatabase");

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddAutoMapper();

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<ITestService, TestService>();
            services.AddTransient<ITestTypeService, TestTypeService>();
            services.AddTransient<ITestDetailService, TestDetailService>();
            services.AddTransient<IUserService, UserService>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Test}/{action=Index}/{id?}");
            });
        }
    }
}
