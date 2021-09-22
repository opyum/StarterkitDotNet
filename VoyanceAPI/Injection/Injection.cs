using DataAccessLayer.UnifOfWork;
using Microsoft.Extensions.DependencyInjection;
using VoyanceApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoyanceApi.Injection
{
    public static class Injection
    {
        public static void SetInjection(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddTransient<ILoginService, LoginService>();
        
        }
    }
}
