using DataAccessLayer.Context;
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
            services.AddScoped<IUnitOfWork<SqliteContext>, UnitOfWork<SqliteContext>>();
            services.AddScoped<IUnitOfWork<LogContext>, UnitOfWork<LogContext>>();
            services.AddTransient<IPersonneService, PersonneService>();
            services.AddTransient<ILogService, LogService>();
        
        }
    }
}
