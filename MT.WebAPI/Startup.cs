using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using MT.Data.Models;
using MT.Repository.AttributeRepo;
using MT.Repository.MonterRepo;
using MT.Repository.SkillRepo;
using MT.Repository.TypeRepo;
using MT.Repository.UserRepo;
using MT.Service.AttributeServices;
using MT.Service.MonterServices;
using MT.Service.SkillServices;
using MT.Service.TypeServices;
using MT.Service.UserService;
using MT.WebAPI.Configurations;

namespace MT.WebAPI
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
            services.AddCors();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MT.WebAPI", Version = "v1" });
            });
            services.AddCommonServices();
            //service
            services.AddScoped<IAttributeService, AttributeService>();
            services.AddScoped<ITypeService, TypeService>();
            services.AddScoped<ISkillService, SkillService>();
            services.AddScoped<IMonterService, MonterService>();
            services.AddScoped<IUserService, UserService>();
            //services.AddScoped<AppSettings, AppSettings>();



            //repo
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAttributeRepository, AttributeRepository>();
            services.AddScoped<ITypeRepository, TypeRepository>();
            services.AddScoped<ISkillRepository, SkillRepository>();
            services.AddScoped<IMonterRepository, MonterRepository>();

            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));


            string connectionString = Configuration.GetConnectionString("MonterDataContext");
            services.AddDbContext<MonterDataContext>(options =>
           options.UseSqlServer(connectionString));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MT.WebAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseMiddleware<JwtMiddleware>();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
