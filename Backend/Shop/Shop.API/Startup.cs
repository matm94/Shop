using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Shop.Core.Repositories;
using Shop.Db;
using Shop.Infrastructure.Repositories;
using Shop.Infrastructure.Services;
using AutoMapper;
using Shop.Infrastructure.AutoMapperProfile;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Identity;
using Shop.Core.Domain;
using Shop.Infrastructure.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Shop.API
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
            var authenticationJWTOptions = new AuthenticationJWTOptions();
            Configuration.GetSection("Authentication").Bind(authenticationJWTOptions);
            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = "Bearer";
                opt.DefaultScheme = "Bearer";
                opt.DefaultChallengeScheme = "Bearer";
            }).AddJwtBearer(cfg =>
           {
               cfg.RequireHttpsMetadata = false;
               cfg.SaveToken = true;
               cfg.TokenValidationParameters = new TokenValidationParameters
               {
                   ValidIssuer = authenticationJWTOptions.JWTIssuer,
                   ValidAudience = authenticationJWTOptions.JWTIssuer,
                   IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(authenticationJWTOptions.JWTKey))
               };
           });
            services.AddSingleton(authenticationJWTOptions);

            services.AddControllers();
            services.AddDbContext<ShopDbContext>(
                options => options.UseSqlServer
                (Configuration.GetConnectionString("Default"), m => m.MigrationsAssembly("Shop.API")));

            services.AddAutoMapper(typeof(ShopProfile));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("V1", new OpenApiInfo() { Title = "KataShop", Version = "V1" });
            });
                
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderService, OrderService>();

            services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();

            services.AddScoped<SampleDataInDb>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, SampleDataInDb sdb)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/V1/swagger.json", "KataShop"));
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseCors(c =>
                        c.WithOrigins("http://localhost:4200")
                        .AllowAnyHeader()
                        .AllowAnyMethod());
            
            sdb.GetSampleDataInDb();
        }
    }
}
