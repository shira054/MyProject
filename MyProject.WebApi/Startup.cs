using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using MyProject.Mock;
using MyProject.Repositoties.Interface;
using MyProject.Repositoties.Interfaces;
using MyProject.Repositoties.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using myProject.context;

namespace MyProject.WebApi
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
            var MyOrigins = "_myOrigins";
            services.AddCors(options =>
            {
                options.AddPolicy(name: MyOrigins,
                                  policy =>
                                  {
                                      policy.WithOrigins("*")
                                      .AllowAnyMethod()
                                     .AllowAnyHeader();
                                  });
            });
            services.AddControllers();
             services.AddDbContext<MyDbContext>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MyProject.WebApi", Version = "v1" });
            });
            // services.AddScoped<IEmailManager, EmailManager>();
            //  services.AddScoped<IRoleRepository, RoleRepository>();
            // services.AddScoped<IContex,MockContext>();
            //  services.AddScoped<IPermissionRepository, PermmisionRepository>();
            //  services.AddScoped<IClaimRepository, ClaimRepository>();

        }
     
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyProject.WebApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
