using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Enrollment.Infrastructure.Data.Context;
using Enrollment.Infrastructure.Data.Interfaces;
using Enrollment.Infrastructure.Data.Repository;
using Enrollment.Services;
using Enrollment.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using FluentValidation.AspNetCore;

namespace Enrollment
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

            services.AddControllers()
                .AddNewtonsoftJson(options =>  options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore)
                .AddFluentValidation(options => options.RegisterValidatorsFromAssemblyContaining<Startup>()); ;


            services.AddDbContext<EnrollmentContext>(
                options => options.UseSqlServer("name=DefaultConnection"));


            services.AddTransient<IHttpHelperService, HttpHelperService>();
            services.AddTransient<IUserEnrollmentService, UserEnrollmentService>();
            services.AddTransient<IUserEnrollmentRepository, UserEnrollmentRepository>();
            //Inject all CRUD generic <T>
            services.AddTransient(typeof(ICrudService<>), typeof(CrudService<>));
            services.AddTransient(typeof(ICrudRepository<>), typeof(CrudRepository<>));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Enrollment", Version = "v1" });
            });

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Enrollment v1"));
            }

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
