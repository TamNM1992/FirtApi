using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using MT.Data.Models;
using MT.Repository.UserRepo;
using MT.Service.UserService;
using MT.WebAPI.Configurations;

namespace WebApplication1
{
    public class Start
    {
        public Start(IConfiguration configuration)
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
                c.SwaggerDoc("v2", new OpenApiInfo { Title = "MT.WebAPI", Version = "v2" });
            });
            //services.AddCommonServices();
            //service

            services.AddScoped<IUserService, UserService>();
            //services.AddScoped<AppSettings, AppSettings>();



            //repo
            services.AddScoped<IUserRepository, UserRepository>();


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
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v2/swagger.json", "MT.WebAPI v2"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseCors(x => x
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
