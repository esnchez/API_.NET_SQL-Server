using API___test.Core.Interfaces.IRepositories;
using API___test.Core.Interfaces.IServices;
using API___test.Core.Services;
using API___test.Infrastructure.Data;
using API___test.Infrastructure.Repositories;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;

namespace API___test
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
            services.AddDbContext<ApplicationDbContext>(options => 
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddCors();
            services.AddMvc();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddControllers();


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API___test", Version = "v1" });
            });

            //Dependency Injection (Scoped or Trasient?)
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<ICompanyService, CompanyService>();
            services.AddTransient<ITeamService, TeamService>();


            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<ITeamRepository, TeamRepository>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();


            //services.AddTransient<IUnitOfWork, UnitOfWork>();

            //services.AddFluentValidation(options => options.RegisterValidatorsFromAssemblies(
            //    AppDomain.CurrentDomain.GetAssemblies()));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API___test v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
