using DataAccessLayer.Context;
using DataAccessLayer.UnifOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StarterKitAPI.Profile;
using StarterKitAPI.Services;
using System.Configuration;

namespace ServiceTest
{
    public class InitTest
    {

        public IPersonneService personneService { get; set; }
        public InitTest()
        {

            IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            var services = new ServiceCollection();
            services.AddMvc();
            services.AddEntityFrameworkSqlite().AddDbContext<SqliteContext>(options =>
                            options.UseSqlite(config["ConnectionStrings:bdd"]));
            services.AddEntityFrameworkSqlite().AddDbContext<LogContext>(options =>
                options.UseSqlite(config["ConnectionStrings:LogDB"]));
            services.AddAutoMapper(typeof(PersonneProfile));

            services.AddScoped<IUnitOfWork<SqliteContext>, UnitOfWork<SqliteContext>>();
            services.AddScoped<IUnitOfWork<LogContext>, UnitOfWork<LogContext>>();
            services.AddTransient<IPersonneService, PersonneService>();
            services.AddTransient<ILogService, LogService>();
            services.AddAutoMapper(typeof(PersonneProfile));

            var builder = services.BuildServiceProvider();
            personneService = builder.GetService<IPersonneService>();
        }
    }
}
