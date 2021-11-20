using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
              /*
               a) Service  AddSingleton does not stop until the application stops
               b) Service  AddScoped is scoped to the lifetime of the http request, once it is used, is disposed
               c) Serice   AddTransient the service is created an d destroied as soon as the method is finished             
            */
            services.AddScoped<ITokenService, TokenService>();
            // Here the constructor DataContext  passes as options a conection string and it is added a a service
            services.AddDbContext<DataContext>(options =>  {
                // The connection string will be created in the appsettings.Development.json
                options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });

            return services;
        }
    }
}