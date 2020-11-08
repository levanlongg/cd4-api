using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cd4_api.Models;
using cd4_api.Services.Client.Users;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Umbraco.Core.Services.Implement;

namespace cd4_api
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
            services.AddDbContext<CoreDbContext>(op => op.UseSqlServer(Configuration.GetConnectionString("Database")));
            services.AddTransient<UserManager<Dbuser>, UserManager<Dbuser>>();
            services.AddTransient<SignInManager<Dbuser>, SignInManager<Dbuser>>();
            services.AddTransient<RoleManager<Dbuser>, RoleManager<Dbuser>>();
            services.AddTransient<IUserService, UserServices>();
            services.AddControllers();
            //services.AddTransient<UserManager<AppUser>, UserManager<AppUser>()>
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
