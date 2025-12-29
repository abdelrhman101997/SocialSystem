using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Social.Infrastructure.Presistance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Infrastructure.Configration
{
   public static class DependancyInjection
    {
        public static IServiceCollection AddInfastructureService(this IServiceCollection services , IConfiguration configuration) 
        {


            services.AddDbContext<ApplicationDBContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly("Social.Infrastructure") // ← اسم مشروع الـInfrastructure حسب الموجود فعلاً
                )
            );
            return services;
        }
        public static WebApplication AddInfastructureWeb(this WebApplication app) 
        {
        return app;
        }
    }
}
