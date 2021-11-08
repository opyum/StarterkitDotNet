using DataAccessLayer.UnifOfWork;
using Microsoft.Extensions.DependencyInjection;
using StarterKitAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterKitAPI.Injection
{
    public static class Injection
    {
        public static void SetInjection(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IPersonneService, PersonneService>();
        
        }
    }
}
